using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SnapPlayer1Row1Card1ToSlot9 : SnapCardToSlotParent {

	private string partnerName = "Player1Row1Card1Slot9";
	private GameObject battlefield;
	private GameObject player1Deck;
	private Button button;
	//private bool mulligan;
	
	void Awake(){
		
		partnerGo = GameObject.Find(partnerName);
		if(partnerGo){
			
			normalColor = partnerGo.gameObject.GetComponent<Renderer>().material.color;
		}
		
		
		battlefield = GameObject.Find("Battlefield");
		
		player1Deck = GameObject.Find("Player1TableShowCards");
		
		button = GameObject.Find("TriggerAI").GetComponent<Button>();
	}
     
    void Start() {
		 //mulligan = false;
		 button.interactable = false;
    }
	
	void Update(){
		
      
	}
	
	void StartMulligan(){
		mulligan = true;
	}
	
	void StopMulligan(){
		mulligan = false;
	}
     
   void OnMouseDrag() {
		 
		if(partnerGo){
			var partnerPos = Camera.main.WorldToViewportPoint(partnerGo.transform.position);
			if(mulligan){
				transform.position =  new Vector3(Mathf.Clamp(transform.position.x, -10.0f, 10.0f), transform.position.y, Mathf.Clamp(transform.position.z, -7.5f, -7.5f));
				player1Deck.GetComponent<BoxCollider>().size = new Vector3(1.0f,1.0f,1.0f);
			}else{
				transform.position =  new Vector3(Mathf.Clamp(transform.position.x, -8.5f, 8.5f), transform.position.y, Mathf.Clamp(transform.position.z, -5.5f, -0.5f));
			}
			
 
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			dist = Vector2.Distance(partnerPos, myPos);
			partnerGo.GetComponent<Renderer>().material.color = (dist < closeVPDist) ? closeColor : normalColor;
		}
    }
     
    void OnMouseUp() {
		
			if (partnerGo && dist < closeVPDist) {
				transform.parent = partnerGo.transform;
				StartCoroutine("InstallPart");
				
				
			}
			
		if(mulligan){	
			player1Deck.GetComponent<BoxCollider>().size = new Vector3(1.0f,1.0f,1.0f);
			button.interactable = false;
		}else{
			player1Deck.GetComponent<BoxCollider>().size = new Vector3(1.0f,2.0f,1.0f);
			button.interactable = true;
		}
	}
     
	IEnumerator InstallPart() {
         while (transform.localPosition != Vector3.zero || transform.localRotation != Quaternion.identity) {
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, Vector3.zero, Time.deltaTime * moveSpeed);
            transform.localRotation = Quaternion.RotateTowards(transform.localRotation, Quaternion.identity, Time.deltaTime * rotateSpeed);

            yield return null;

         }
     }
	 
	  void OnMouseDown(){
		 gameObject.GetComponent<Renderer>().material.color = new Color(1,0,0);
	 }
	 
	 
	
}
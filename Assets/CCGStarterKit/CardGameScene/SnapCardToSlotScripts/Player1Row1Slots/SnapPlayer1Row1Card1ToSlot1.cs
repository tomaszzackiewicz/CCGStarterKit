using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SnapPlayer1Row1Card1ToSlot1 : SnapCardToSlotParent {
	
	private string partnerName = "Player1Row1Card1Slot1";
	private GameObject battlefield;
	private GameObject player1Deck;
	private GameObject player1SpawnCards;
	private Button button;
	//public bool mulligan;
	
	
	void Awake(){
		
		partnerGo = GameObject.Find(partnerName);
		if(partnerGo){
			
			normalColor = partnerGo.gameObject.GetComponent<Renderer>().material.color;
		}
		
		
		battlefield = GameObject.Find("Battlefield");
		
		player1Deck = GameObject.Find("Player1TableShowCards");
		
		player1SpawnCards = GameObject.Find("Player1SpawnCards");
		
		button = GameObject.Find("TriggerAI").GetComponent<Button>();
	}
     
    void Start() {
		//mulligan = false;
		button.interactable = false;
		
    }
	
	void Update(){
		
		if(Input.GetKeyDown(KeyCode.Space)){
			mulligan = true;
		}
		
		if(Input.GetKeyDown(KeyCode.Return)){
			mulligan = true;
			player1SpawnCards.GetComponent<BoxCollider>().size = new Vector3(1.0f,1.0f,1.0f);
		}
		
		if(Input.GetKeyDown(KeyCode.P)){
			mulligan = false;
		}
      
	}
	
     
     void OnMouseDrag() {
		 
		if(partnerGo){
			var partnerPos = Camera.main.WorldToViewportPoint(partnerGo.transform.position);
			if(mulligan){
				transform.position =  new Vector3(Mathf.Clamp(transform.position.x, -11.0f, 11.0f), Mathf.Clamp(transform.position.y, 0.3f, 0.3f), Mathf.Clamp(transform.position.z, -7.5f, -7.5f));
				player1Deck.GetComponent<BoxCollider>().size = new Vector3(1.0f,1.0f,1.0f);
			}else{
				transform.position =  new Vector3(Mathf.Clamp(transform.position.x, -8.5f, 8.5f), Mathf.Clamp(transform.position.y, 0.3f, 0.3f), Mathf.Clamp(transform.position.z, -5.5f, -1.0f));
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
	 
	 
	 
	
	
	
}

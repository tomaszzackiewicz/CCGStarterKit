using UnityEngine;
using System.Collections;

public class SnapToPlayer1DeckSlot1 : SnapToPlayer1DeckSlotParent {

	private string partnerName = "Mirek";
	
	void Awake(){
		
		partnerGo = GameObject.Find(partnerName);
        if(partnerGo){
			
			normalColor = partnerGo.gameObject.GetComponent<Renderer>().material.color;
		}
	}
     
     void Start() {
		
     }
     
    void OnMouseDrag() {
		 
			if(partnerGo){
				var partnerPos = Camera.main.WorldToViewportPoint(partnerGo.transform.position);
				var myPos = Camera.main.WorldToViewportPoint(transform.position);
				dist = Vector2.Distance(partnerPos, myPos);
				partnerGo.GetComponent<Renderer>().material.color = (dist < closeVPDist) ? closeColor : normalColor;
			}
    }
     
    void OnMouseUp() {

			if (partnerGo && dist < closeVPDist) {
				transform.parent = partnerGo.transform;
				StartCoroutine("InstallPart");
				transform.localScale = new Vector3(325f,200f,340.0f);
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

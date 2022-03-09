using UnityEngine;
using System.Collections;

public class SnapCode : MonoBehaviour {
	
	private RaycastHit hit;
	private float distance;
	private Vector3 direction;
	private Vector3 currentPos;
	
	void Start() {
		distance = 1;
		direction = new Vector3(0,-1,0);
		currentPos = transform.position;
    }
	
	
	void Update(){
		
		//Debug.DrawRay(transform.position,direction * distance,Color.green);
		//if(Physics.Raycast(transform.position,direction,out hit,distance)){
           //the ray collided with something, you can interact
           // with the hit object now by using hit.collider.gameObject
		   //if(hit.collider.gameObject.name == "Player1DeckSlot1"){
				//transform.parent = hit.collider.gameObject.transform;
				//transform.localPosition = Vector3.MoveTowards(transform.localPosition, hit.collider.gameObject.transform.position, Time.deltaTime * 0.5f);
		// }
		   
		//}
		
		
		

	}
	
 
 
}

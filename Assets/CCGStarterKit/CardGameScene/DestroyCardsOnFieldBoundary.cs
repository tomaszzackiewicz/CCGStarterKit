using UnityEngine;
using System.Collections;

public class DestroyCardsOnFieldBoundary : MonoBehaviour {
	
	private bool mouseUp;
	private DragObjectWithMouse mouseState;
	private bool mouseStateUpdate1;
	public GameObject mouseStateObject;
	private bool timeLeft;
	private float collisionTime;
	private int collisionTimeInt;

	// Use this for initialization
	void Start () {
		timeLeft = false;
		mouseUp = false;
		collisionTime = 10.0f;

		//mouseState1 = mouseStateObject1.GetComponent<DragObjectWithMouse>();
		//mouseState2 = mouseStateObject2.GetComponent<DragObjectWithMouse>();
		//mouseState3 = mouseStateObject3.GetComponent<DragObjectWithMouse>();
		
	
	}
	
	// Update is called once per frame
	void Update () {
		
		//mouseStateUpdate1 = mouseState1.mouseUp;
		//mouseStateUpdate2 = mouseState2.mouseUp;
		//mouseStateUpdate3 = mouseState3.mouseUp; 
		
		if(timeLeft){
			collisionTime -= Time.deltaTime;
			collisionTimeInt = (int)collisionTime;
			if(collisionTimeInt <= 0){
				collisionTimeInt = 0;
				timeLeft = false;
			}
		}else{
			collisionTime = 10;
		}
		
		if(Input.GetKeyDown(KeyCode.Return)) {
			
			collisionTime = 10.0f;
			
			}
		
	
	}
	
	
	void OnCollisionStay(Collision collision){
		
		if((collision.gameObject.tag == "Card1" || collision.gameObject.tag == "Card2" || collision.gameObject.tag == "Card3")){
			Debug.Log("Mirek");
			timeLeft = true;
			
			 Debug.Log(collisionTimeInt);
			 if ( collisionTimeInt == 0){
				 Destroy(collision.gameObject);
				 }
			
		}else{
			timeLeft = false;
			
			//Debug.Log("OK!");
		}
		
	}
	
	
	/*
	void OntriggerEnter(Collider other){
		if(other.tag == "Card1"){
			Debug.Log("Mirek");
			Destroy(other.gameObject);
		}
	}
	*/
}

    using UnityEngine;
    using System.Collections;
     
	
    //[RequireComponent(typeof(MeshCollider))]
     
    public class DragObjectWithMouse : MonoBehaviour{
	
    public bool timeLeft;
	
    private Vector3 screenPoint;
    private Vector3 offset;
	private bool switcher;
	private bool mouseUp;
	private float collisionTime;
	private int collisionTimeInt;
	
	void Start(){
		
		timeLeft = false;
		mouseUp = false;
		collisionTime = 10.0f;
		switcher = true;
		
	}
	
	
     
    void OnMouseDown(){
		 if (!enabled) return;
		//if(switcher == true){
			screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
     
			offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
		//}
		
    }
     
    void OnMouseDrag(){
		 if (!enabled) return;
		if(switcher == true){
			Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
     
			Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
			transform.position = curPosition;
		}
    }
	
	void OnMouseUp(){
		 if (!enabled) return;
		mouseUp = true;
		
	}
	
	
	
	void Update(){
		
	}
	
	
	void OnCollisionStay(Collision collision){
		
		
		
	}
	
	
     
}

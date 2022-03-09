using UnityEngine;
using System.Collections;

public class DetectCardSlot : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		float theDistance;
		Vector3 down = transform.TransformDirection(Vector3.down) * 100;
		Debug.DrawRay(transform.position, down, Color.green);
		if(Physics.Raycast(transform.position, down, out hit)){
			theDistance = hit.distance;
			if(hit.collider.gameObject.tag == "CardSlot1"){
				print(theDistance + " " + hit.collider.gameObject.name);
			}
		}
	
	}
}

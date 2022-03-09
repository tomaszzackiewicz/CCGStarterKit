using UnityEngine;
using System.Collections;

public class ConstrainCardMove : MonoBehaviour {
	private float minX = -10.0f; //left boundary 
	private float maxX = 10.0f; //right boundary 
	private float minY = -10.0f; // up boundary 
	private float maxY = 10.0f; // down boundary
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	 outofbounds();
	}
	
	
	
 

 void outofbounds() {
	Vector3 tempPos = transform.position;
	if (tempPos.x < minX) { 
		tempPos.x = minX; 
	}
	
	if (tempPos.x > maxX) { 
		tempPos.x = maxX; 
	}
 

	if (tempPos.y < minY) { 
		tempPos.y = minY; 
	}
	
	if (tempPos.y > maxY) { 
		tempPos.y = maxY; 
	}
 

}
 

}

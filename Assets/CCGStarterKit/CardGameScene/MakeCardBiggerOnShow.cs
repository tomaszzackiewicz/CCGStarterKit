using UnityEngine;
using System.Collections;

public class MakeCardBiggerOnShow : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider col){
		if(col.gameObject.tag == "Card1" || col.gameObject.tag == "Card2" || col.gameObject.tag == "Card3"){
			col.gameObject.transform.localScale = new Vector3(325f,200f,340.0f);
		}
			
	}
	
	void OnTriggerExit(Collider col){
		if(col.gameObject.tag == "Card1" || col.gameObject.tag == "Card2" || col.gameObject.tag == "Card3"){
			col.gameObject.transform.localScale = new Vector3(125.0f,100.0f,140.0f);
		}
			
	}
}

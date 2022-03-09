using UnityEngine;
using System.Collections;

public class MakeCardBiggerOnPreviewZone : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	//void OnTriggerStay(Collider col){
		//if(col.gameObject.tag == "Card1" || col.gameObject.tag == "Card2" || col.gameObject.tag == "Card3"){
			//col.gameObject.transform.localScale = new Vector3(425f,200f,440.0f);
	//	}
			
	//}
	
	void OnTriggerExit(Collider col){
		if(col.gameObject.name.Contains("Card")){
			//Vector3(170.0f,100.0f,185.0f)
			col.gameObject.transform.localScale = new Vector3(150.0f,100.0f,90.0f);
			col.gameObject.AddComponent<Rigidbody>();
			col.gameObject.GetComponent<Rigidbody>().useGravity = false;
			col.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
		}
			
	}
}

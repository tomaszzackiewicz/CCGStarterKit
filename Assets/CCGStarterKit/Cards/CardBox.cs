using UnityEngine;
using System.Collections;

public class CardBox : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerExit(Collider col){
		if(col.gameObject.tag == "Player1SpawnCards" /*|| col.gameObject.tag == "Player2SpawnCards"*/){
			Destroy(gameObject,1);
		}
		
	}
}

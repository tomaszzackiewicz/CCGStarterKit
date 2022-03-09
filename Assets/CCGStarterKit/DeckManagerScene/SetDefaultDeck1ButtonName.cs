using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetDefaultDeck1ButtonName : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if(gameObject.GetComponent<Text>().text == ""){
			gameObject.GetComponent<Text>().text = "Deck 1";
		}
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

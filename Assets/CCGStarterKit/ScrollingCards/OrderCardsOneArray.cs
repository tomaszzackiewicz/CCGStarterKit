using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Caerwent{

public class OrderCardsOneArray : MonoBehaviour {
	
	private GameObject[] allObjects;
	public List<GameObject> orderCards = new List<GameObject>();
	float offset = 10.0f;
	
	
	void Awake(){
		
	}

	// Use this for initialization
	void Start () {
		
		
		
		
		allObjects = GameObject.FindObjectsOfType(typeof(GameObject)) as GameObject[];
		foreach (GameObject obj in allObjects){
			if (obj.name.Contains("Card1") ||
			obj.name.Contains("Card2") ||
			obj.name.Contains("Card3") ||
			obj.name.Contains("Card4") ||
			obj.name.Contains("Card5") ||
			obj.name.Contains("Card6") ||
			obj.name.Contains("Card7") ||
			obj.name.Contains("Card8") ||
			obj.name.Contains("Card9") ||
			obj.name.Contains("Card10") ||
			obj.name.Contains("Card11") ||
			obj.name.Contains("Card12") ||
			obj.name.Contains("Card13") ||
			obj.name.Contains("Card14") ||
			obj.name.Contains("Card15") ||
			obj.name.Contains("Card16") ||
			obj.name.Contains("Card17") ||
			obj.name.Contains("Card18") ||
			obj.name.Contains("Card19") ||
			obj.name.Contains("Card20") ||
			obj.name.Contains("Card21") ||
			obj.name.Contains("Card22") ||
			obj.name.Contains("Card23") ||
			obj.name.Contains("Card24") ||
			obj.name.Contains("Card25") ||
			obj.name.Contains("Card26") ||
			obj.name.Contains("Card27") ||
			obj.name.Contains("Card28") ||
			obj.name.Contains("Card29") ||
			obj.name.Contains("Card30") ||
			obj.name.Contains("Card31") ||
			obj.name.Contains("Card32") ||
			obj.name.Contains("Card33") ||
			obj.name.Contains("Card34") ||
			obj.name.Contains("Card35") ||
			obj.name.Contains("Card36") ||
			obj.name.Contains("Card37") ||
			obj.name.Contains("Card38") ||
			obj.name.Contains("Card39") ||
			obj.name.Contains("Card40") ||
			obj.name.Contains("Card41") ||
			obj.name.Contains("Card42") ||
			obj.name.Contains("Card43") ||
			obj.name.Contains("Card44") ||
			obj.name.Contains("Card45") ||
			obj.name.Contains("Card46") ||
			obj.name.Contains("Card47") ||
			obj.name.Contains("Card48") ||
			obj.name.Contains("Card49") ||
			obj.name.Contains("Card50") ||
			obj.name.Contains("Card51") ||
			obj.name.Contains("Card52") ||
			obj.name.Contains("Card53") ||
			obj.name.Contains("Card54") ||
			obj.name.Contains("Card55") ||
			obj.name.Contains("Card56") ||
			obj.name.Contains("Card57") ||
			obj.name.Contains("Card58") ||
			obj.name.Contains("Card59") ||
			obj.name.Contains("Card60")){
				
				orderCards.Add(obj);
				orderCards.Reverse();
				
				
				
			}

		
		}
		
		for(int i = 0; i < orderCards.Count; i++){
					
			orderCards[i].transform.position = new Vector3(offset, 0, 50.0f);
			offset += 10.0f;
					
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

}

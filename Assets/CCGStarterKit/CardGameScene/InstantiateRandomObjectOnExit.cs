using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InstantiateRandomObjectOnExit : MonoBehaviour {

	public GameObject[] cardsInDeck;
	public GameObject[] cardsInMulligan;
	private GameObject[] allObjects;
	public List<GameObject> likeNames = new List<GameObject>();
	public Transform spawnPoint;
	public int NumberOfCards;
	private int instances;
	private bool switcher;
	public int countCollision;
	
	// Use this for initialization
	void Start () {
		
		NumberOfCards = 10;
		instances = 0;
		switcher = false;
		countCollision = 0;

	}


	// Update is called once per frame
	void Update (){
		

	}
	

	void OnTriggerExit() {
		
		allObjects = Object.FindObjectsOfType(typeof(GameObject)) as GameObject[];
		foreach (GameObject obj in allObjects){
			if (obj.name.Contains("Card")){
				likeNames.Add(obj);
				print(likeNames.Count);
				}
			}
		
		while(likeNames.Count < NumberOfCards) {
			//Instantiate(element, spawnPoint.transform.position, spawnPoint.transform.rotation);
			GameObject card = Instantiate (cardsInDeck[Random.Range(0,cardsInDeck.Length)], spawnPoint.transform.position, spawnPoint.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(325f,200f,340.0f);
			card.name = "instantiatedCard";
			//instances++;
			
			}
		
	}
	
	
	
	
	
	void SpawnObject(){
		
		GameObject card = Instantiate (cardsInMulligan[Random.Range(0,cardsInMulligan.Length)], spawnPoint.transform.position, spawnPoint.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(325f,100f,340.0f);
			card.name = "instantiatedCard";
			
		//}
	}
	
	
	
}

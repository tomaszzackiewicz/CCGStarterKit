using UnityEngine;
using System.Collections;

public class AISpawnCardSlot1 : MonoBehaviour {
	
	private int NumberOfCards;
	private int instances;
	public GameObject cardsInSlot1;
	public Transform spawnPoint;

	// Use this for initialization
	void Start () {
		NumberOfCards = 1;
		instances = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void SpawnCard1(){
		while(instances < NumberOfCards) {
			GameObject card = Instantiate (cardsInSlot1, spawnPoint.transform.position, spawnPoint.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(125.0f,100.0f,140.0f);
			instances++;
			}
		
	}
}

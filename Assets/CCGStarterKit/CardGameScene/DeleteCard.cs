using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DeleteCard : MonoBehaviour {
	
	public int countCollision;
	public int numberCardsToReplace;
	private GameObject card1;
	private GameObject card2;
	private GameObject card3;
	private GameObject player1Deck;
	private GameObject player1SpawnCards;
	
	void Awake(){
		player1Deck = GameObject.Find("Player1TableShowCards");
		player1SpawnCards = GameObject.Find("Player1SpawnCards");
	}
	
	void Start(){
		countCollision = 0;
		numberCardsToReplace = 2;
	}
	
	void Update(){
		
	}
	
	void OnCollisionEnter(Collision col){
		
		if (countCollision < numberCardsToReplace){

			Destroy(col.gameObject,1);
		
			countCollision++;
			
			
		}
		
	}
	
	
}

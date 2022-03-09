using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class AIController : MonoBehaviour {
	
	//delegate()
	public delegate IEnumerator EndTurnDelegateIE();      
	//event  
	public static event EndTurnDelegateIE EndTurnEventIE;
	
	private GameObject[] allObjects;
	public List<GameObject> likeNames = new List<GameObject>();
	public GameObject player1Deck;
	public Transform spawnPoint;
	private GameObject cardToMove;
	private bool target;
	private Vector3 newPosition;
	public Button button;
	
	
	void Awake(){
		player1Deck = GameObject.Find("Player1TableShowCards");
		
	}
	
	// Use this for initialization
	void Start () {
		target = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Space)){
			
			player1Deck.GetComponent<BoxCollider>().size = new Vector3(1.0f,2.0f,1.0f);
			StartCoroutine(EndTurnEventIE());
			
		}
			CardMoving();
			likeNames.RemoveAll(item => item == null);
		
		
	}
	
	void CardMoving(){
		if(cardToMove){
			newPosition = new Vector3(10.0f, 0.32f, 0.0f);
			cardToMove.transform.position = Vector3.MoveTowards(cardToMove.transform.position, newPosition, Time.deltaTime * 10.0f);
			
			}else{
				return;
			}
			
		}
	
	
	public void GetCards(){
		likeNames.Clear();
		likeNames.RemoveAll(item => item == null);
		allObjects = GameObject.FindObjectsOfType(typeof(GameObject)) as GameObject[];
		foreach (GameObject obj in allObjects){
			if (obj.name.Contains("instantiatedAIDeckCard")){
				
					likeNames.Add(obj);
					
					
					
			}
		}
		
		cardToMove = likeNames[Random.Range(0,likeNames.Count)] as GameObject;
		
		player1Deck.GetComponent<BoxCollider>().size = new Vector3(1.0f,1.0f,1.0f);
		
		Vector3 deck = new Vector3(1.0f,1.0f,1.0f);
		if(player1Deck.GetComponent<BoxCollider>().size == deck){
			button.interactable = false;
		}
			
		
	}
	
	
	void OnTriggerEnter(Collider col){
		
		if(col.gameObject.name.Contains("instantiatedAIDeckCard")){
			
			col.gameObject.transform.localScale = new Vector3(525.0f, 200.0f, 540.0f);
			likeNames.Remove(cardToMove);
			Destroy(cardToMove,3);
			
			likeNames.RemoveAll(item => item == null);
		}
	}
 
	
	
	public void EndTurn(){
		
		player1Deck.GetComponent<BoxCollider>().size = new Vector3(1.0f,2.0f,1.0f);
		StartCoroutine(EndTurnEventIE());
		
	}
	
}

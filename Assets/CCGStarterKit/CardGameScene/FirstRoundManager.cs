using UnityEngine;
using System.Collections;

public class FirstRoundManager : MonoBehaviour {
	
	//delegate()
	public delegate void ButtonClick();      
	//event  
	public static event ButtonClick Click;
	
	//delegate()
	public delegate IEnumerator AITurnDelegateIE();      
	//event  
	public static event AITurnDelegateIE AITurnEventIE;
	
	public GameObject startFirstRoundPanel;
	private GameObject youStartFirstInfo;
	private GameObject aiStartsFirstInfo;
    private GameObject player1Deck;
    //private BoxCollider col;

    void Awake(){
        player1Deck = GameObject.Find("Player1TableShowCards");
        aiStartsFirstInfo = GameObject.Find("AIStartsFirstInfo");
		youStartFirstInfo = GameObject.Find("YouStartFirstInfo");
        

    }

	// Use this for initialization
	void Start () {
		
		startFirstRoundPanel.SetActive(true);
		
		aiStartsFirstInfo.SetActive(false);
		
		youStartFirstInfo.SetActive(false);

        BoxCollider col = player1Deck.GetComponent<BoxCollider>();
        col.size = new Vector3(col.size.x, 2.0f, col.size.z);

        Click += SetStartFirstRoundPanelInactive;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	//On Button Click the event named Click can be called    
	public void StartFirstRound()    {        
		//call the event 
		if(Click != null){
			Click(); 
		}
		   
	}
	
	void SetStartFirstRoundPanelInactive(){
		
		startFirstRoundPanel.SetActive(false);
		Click -= SetStartFirstRoundPanelInactive;
	}
	
	//Continue Button & Done Button
	public void WhoStartsFirst(){
        SnapCardToSlotParent.mulligan = true;

        StartCoroutine(WhoStartsFirstGame()); 
	}
	
	
	IEnumerator WhoStartsFirstGame(){
        
        int whoFirst = Random.Range(0, 100);
        //Debug.Log(whoFirst);
		if(whoFirst % 2 == 0){
           
            BoxCollider col = player1Deck.GetComponent<BoxCollider>();
            col.size = new Vector3(col.size.x, 1.0f, col.size.z);
			youStartFirstInfo.SetActive(true);
			yield return new WaitForSeconds(3);
			youStartFirstInfo.SetActive(false);
            //Debug.Log("Player");

        } else{
            //GameObject player1Deck = GameObject.Find("Player1TableShowCards");
            BoxCollider col = player1Deck.GetComponent<BoxCollider>();
            col.size = new Vector3(col.size.x, 2.0f, col.size.z);
			aiStartsFirstInfo.SetActive(true);
			yield return new WaitForSeconds(3);
			aiStartsFirstInfo.SetActive(false);
			StartCoroutine(AITurnEventIE());
            //Debug.Log("AI");
        }
        yield return null;
	}


}

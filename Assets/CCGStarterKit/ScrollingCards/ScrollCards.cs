using UnityEngine;
using System.Collections;

namespace Caerwent{

public class ScrollCards : MonoBehaviour {

	 public static int curCard;
     private int currentCard;
     private Vector3 oldPosition;
	 private GameObject[] cardsInDeck30 = new GameObject[30];
	 
	 
	 void Awake(){
		cardsInDeck30[0] = GameObject.Find("Card1");
		cardsInDeck30[1] = GameObject.Find("Card2");
		cardsInDeck30[2] = GameObject.Find("Card3");
		cardsInDeck30[3] = GameObject.Find("Card4");
		cardsInDeck30[4] = GameObject.Find("Card5");
		cardsInDeck30[5] = GameObject.Find("Card6");
		cardsInDeck30[6] = GameObject.Find("Card7");
		cardsInDeck30[7] = GameObject.Find("Card8");
		cardsInDeck30[8] = GameObject.Find("Card9");
		cardsInDeck30[9] = GameObject.Find("Card10");
		cardsInDeck30[10] = GameObject.Find("Card11");
		cardsInDeck30[11] = GameObject.Find("Card12");
		cardsInDeck30[12] = GameObject.Find("Card13");
		cardsInDeck30[13] = GameObject.Find("Card14");
		cardsInDeck30[14] = GameObject.Find("Card15");
		cardsInDeck30[15] = GameObject.Find("Card16");
		cardsInDeck30[16] = GameObject.Find("Card17");
		cardsInDeck30[17] = GameObject.Find("Card18");
		cardsInDeck30[18] = GameObject.Find("Card19");
		cardsInDeck30[19] = GameObject.Find("Card20");
		cardsInDeck30[20] = GameObject.Find("Card21");
		cardsInDeck30[21] = GameObject.Find("Card22");
		cardsInDeck30[22] = GameObject.Find("Card23");
		cardsInDeck30[23] = GameObject.Find("Card24");
		cardsInDeck30[24] = GameObject.Find("Card25");
		cardsInDeck30[25] = GameObject.Find("Card26");
		cardsInDeck30[26] = GameObject.Find("Card27");
		cardsInDeck30[27] = GameObject.Find("Card28");
		cardsInDeck30[28] = GameObject.Find("Card29");
		cardsInDeck30[29] = GameObject.Find("Card30");
		
	}
 
     // Use this for initialization
     void Start () {
         curCard = 0;
     }
     // Update is called once per frame
     void Update () {
         
		 if(Input.GetKeyDown(KeyCode.A)){
			 curCard++;
		 }
		 if(Input.GetKeyDown(KeyCode.D)){
			 curCard--;
		 }
         
         
         if(curCard == cardsInDeck30.Length + 1){
             curCard = 0;
         }
         
         if(curCard == -1){
             curCard = cardsInDeck30.Length;
         }
         
         changeCard(curCard);
     }
     
     public void changeCard(int num) {
     
         currentCard = num;
         
         for(int i = 0; i < cardsInDeck30.Length; i++) {
			//oldPosition = cardsInDeck30[i].gameObject.transform.position;
             if(i == num){
                 
                 cardsInDeck30[i].gameObject.transform.localScale = new Vector3(625.0f,200.0f,640.0f);
                 //cardsInDeck30[i].gameObject.transform.position = new Vector3(0,0,0);
                 
                 }
                 
             else{
                 
                 cardsInDeck30[i].gameObject.transform.localScale = new Vector3(325.0f,100.0f,340.0f);
                 //cardsInDeck30[i].gameObject.transform.position = oldPosition;
                 
                 }
     
             }
     }
	 
	 
	 public void LeftScrollCards(){
		 curCard++;
	 }
	 
	  public void RightScrollCards(){
		 curCard--;
	 }
}

}

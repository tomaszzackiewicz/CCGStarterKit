using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

namespace Caerwent{

	public class CircularScrollCardsMulligan : MonoBehaviour {

		public static int curCard;
		private int currentCard;
		private Vector3 normalCard = new Vector3(325.0f,100.0f,340.0f);
		private Vector3 previewCard = new Vector3(1025.0f,200.0f,1040.0f);
		private Vector3 centerPosition = new Vector3(0,0,0);
		private Vector3 spawnPoint = new Vector3(0,0,0);
		
		// Public Variables
		public RectTransform panel;	// To hold the ScrollPanel
		public RectTransform center;	// Center to compare the distance for each button
		public List<GameObject> itemsToScroll = new List<GameObject>();
		public List<GameObject> grabbedHandDeck1Cards = new List<GameObject>();
		public List<GameObject> grabbedHandDeck2Cards = new List<GameObject>();
		public List<GameObject> grabbedHandDeck3Cards = new List<GameObject>();
		
		// Private Variables
		public float[] distance;	// All buttons' distance to the center
		public float[] distReposition;
		private bool dragging = false;	// Will be true, while we drag the panel
		private int bttnDistance;	// Will hold the distance between the buttons
		private int minButtonNum;	// To hold the number of the button, with smallest distance to center
		private int bttnLength;
		private int scrollLimit;
		private float speed = 100;
		private GameObject mulliganInfo;
		private bool isScrollCardModels;
		private GameObject handCardCollection;
		
		private GameObject[] allObjects;
		private GameObject[] allObjects1;
		public List<GameObject> orderCards = new List<GameObject>();
		float offset = 10.0f;
		int j;
		
		static float posXLeft = 0.0f;
		static float posYLeft = 0.0f;
		static float posZLeft = 0.0f;
		static float posXRight = 0.0f;
		static float posYRight = 0.0f;
		static float posZRight = 0.0f;
		
		private GameObject dropDownMenu;
		private LoadDeckCards1 loadDeckCards1;
		private LoadDeckCards2 loadDeckCards2;
		private LoadDeckCards3 loadDeckCards3;
		
		private GameObject cardModel1;
		private GameObject cardModel1a;
		private GameObject cardModel1b;
		private GameObject cardModel1c;
		private GameObject cardModel2;
		private GameObject cardModel2a;
		private GameObject cardModel2b;
		private GameObject cardModel2c;
		private GameObject cardModel3;
		private GameObject cardModel3a;
		private GameObject cardModel3b;
		private GameObject cardModel3c;
		private GameObject cardModel4;
		private GameObject cardModel4a;
		private GameObject cardModel4b;
		private GameObject cardModel4c;
		private GameObject cardModel5;
		private GameObject cardModel5a;
		private GameObject cardModel5b;
		private GameObject cardModel5c;
		private GameObject cardModel6;
		private GameObject cardModel6a;
		private GameObject cardModel6b;
		private GameObject cardModel6c;
		private GameObject cardModel7;
		private GameObject cardModel7a;
		private GameObject cardModel7b;
		private GameObject cardModel7c;
		private GameObject cardModel8;
		private GameObject cardModel8a;
		private GameObject cardModel8b;
		private GameObject cardModel8c;
		private GameObject cardModel9;
		private GameObject cardModel9a;
		private GameObject cardModel9b;
		private GameObject cardModel9c;
		private GameObject cardModel10;
		private GameObject cardModel10a;
		private GameObject cardModel10b;
		private GameObject cardModel10c;
		private GameObject cardModel11;
		private GameObject cardModel11a;
		private GameObject cardModel11b;
		private GameObject cardModel11c;
		private GameObject cardModel12;
		private GameObject cardModel12a;
		private GameObject cardModel12b;
		private GameObject cardModel12c;
		private GameObject cardModel13;
		private GameObject cardModel13a;
		private GameObject cardModel13b;
		private GameObject cardModel13c;
		private GameObject cardModel14;
		private GameObject cardModel14a;
		private GameObject cardModel14b;
		private GameObject cardModel14c;
		private GameObject cardModel15;
		private GameObject cardModel15a;
		private GameObject cardModel15b;
		private GameObject cardModel15c;
		private GameObject cardModel16;
		private GameObject cardModel16a;
		private GameObject cardModel16b;
		private GameObject cardModel16c;
		private GameObject cardModel17;
		private GameObject cardModel17a;
		private GameObject cardModel17b;
		private GameObject cardModel17c;
		private GameObject cardModel18;
		private GameObject cardModel18a;
		private GameObject cardModel18b;
		private GameObject cardModel18c;
		private GameObject cardModel19;
		private GameObject cardModel19a;
		private GameObject cardModel19b;
		private GameObject cardModel19c;
		private GameObject cardModel20;
		private GameObject cardModel20a;
		private GameObject cardModel20b;
		private GameObject cardModel20c;
		private GameObject cardModel21;
		private GameObject cardModel21a;
		private GameObject cardModel21b;
		private GameObject cardModel21c;
		private GameObject cardModel22;
		private GameObject cardModel22a;
		private GameObject cardModel22b;
		private GameObject cardModel22c;
		private GameObject cardModel23;
		private GameObject cardModel23a;
		private GameObject cardModel23b;
		private GameObject cardModel23c;
		private GameObject cardModel24;
		private GameObject cardModel24a;
		private GameObject cardModel24b;
		private GameObject cardModel24c;
		private GameObject cardModel25;
		private GameObject cardModel25a;
		private GameObject cardModel25b;
		private GameObject cardModel25c;
		private GameObject cardModel26;
		private GameObject cardModel26a;
		private GameObject cardModel26b;
		private GameObject cardModel26c;
		private GameObject cardModel27;
		private GameObject cardModel27a;
		private GameObject cardModel27b;
		private GameObject cardModel27c;
		private GameObject cardModel28;
		private GameObject cardModel28a;
		private GameObject cardModel28b;
		private GameObject cardModel28c;
		private GameObject cardModel29;
		private GameObject cardModel29a;
		private GameObject cardModel29b;
		private GameObject cardModel29c;
		private GameObject cardModel30;
		private GameObject cardModel30a;
		private GameObject cardModel30b;
		private GameObject cardModel30c;
		private GameObject cardModel31;
		private GameObject cardModel31a;
		private GameObject cardModel31b;
		private GameObject cardModel31c;
		private GameObject cardModel32;
		private GameObject cardModel32a;
		private GameObject cardModel32b;
		private GameObject cardModel32c;
		private GameObject cardModel33;
		private GameObject cardModel33a;
		private GameObject cardModel33b;
		private GameObject cardModel33c;
		private GameObject cardModel34;
		private GameObject cardModel34a;
		private GameObject cardModel34b;
		private GameObject cardModel34c;
		private GameObject cardModel35;
		private GameObject cardModel35a;
		private GameObject cardModel35b;
		private GameObject cardModel35c;
		private GameObject cardModel36;
		private GameObject cardModel36a;
		private GameObject cardModel36b;
		private GameObject cardModel36c;
		private GameObject cardModel37;
		private GameObject cardModel37a;
		private GameObject cardModel37b;
		private GameObject cardModel37c;
		private GameObject cardModel38;
		private GameObject cardModel38a;
		private GameObject cardModel38b;
		private GameObject cardModel38c;
		private GameObject cardModel39;
		private GameObject cardModel39a;
		private GameObject cardModel39b;
		private GameObject cardModel39c;
		private GameObject cardModel40;
		private GameObject cardModel40a;
		private GameObject cardModel40b;
		private GameObject cardModel40c;
		private GameObject cardModel41;
		private GameObject cardModel41a;
		private GameObject cardModel41b;
		private GameObject cardModel41c;
		private GameObject cardModel42;
		private GameObject cardModel42a;
		private GameObject cardModel42b;
		private GameObject cardModel42c;
		private GameObject cardModel43;
		private GameObject cardModel43a;
		private GameObject cardModel43b;
		private GameObject cardModel43c;
		private GameObject cardModel44;
		private GameObject cardModel44a;
		private GameObject cardModel44b;
		private GameObject cardModel44c;
		private GameObject cardModel45;
		private GameObject cardModel45a;
		private GameObject cardModel45b;
		private GameObject cardModel45c;
		private GameObject cardModel46;
		private GameObject cardModel46a;
		private GameObject cardModel46b;
		private GameObject cardModel46c;
		private GameObject cardModel47;
		private GameObject cardModel47a;
		private GameObject cardModel47b;
		private GameObject cardModel47c;
		private GameObject cardModel48;
		private GameObject cardModel48a;
		private GameObject cardModel48b;
		private GameObject cardModel48c;
		private GameObject cardModel49;
		private GameObject cardModel49a;
		private GameObject cardModel49b;
		private GameObject cardModel49c;
		private GameObject cardModel50;
		private GameObject cardModel50a;
		private GameObject cardModel50b;
		private GameObject cardModel50c;
		private GameObject cardModel51;
		private GameObject cardModel51a;
		private GameObject cardModel51b;
		private GameObject cardModel51c;
		private GameObject cardModel52;
		private GameObject cardModel52a;
		private GameObject cardModel52b;
		private GameObject cardModel52c;
		private GameObject cardModel53;
		private GameObject cardModel53a;
		private GameObject cardModel53b;
		private GameObject cardModel53c;
		private GameObject cardModel54;
		private GameObject cardModel54a;
		private GameObject cardModel54b;
		private GameObject cardModel54c;
		private GameObject cardModel55;
		private GameObject cardModel55a;
		private GameObject cardModel55b;
		private GameObject cardModel55c;
		private GameObject cardModel56;
		private GameObject cardModel56a;
		private GameObject cardModel56b;
		private GameObject cardModel56c;
		private GameObject cardModel57;
		private GameObject cardModel57a;
		private GameObject cardModel57b;
		private GameObject cardModel57c;
		private GameObject cardModel58;
		private GameObject cardModel58a;
		private GameObject cardModel58b;
		private GameObject cardModel58c;
		private GameObject cardModel59;
		private GameObject cardModel59a;
		private GameObject cardModel59b;
		private GameObject cardModel59c;
		private GameObject cardModel60;
		private GameObject cardModel60a;
		private GameObject cardModel60b;
		private GameObject cardModel60c;
		 
		void Awake(){
			
			dropDownMenu = GameObject.Find("DropDownMenu");
			loadDeckCards1 = dropDownMenu.GetComponent<LoadDeckCards1>();
			loadDeckCards2 = dropDownMenu.GetComponent<LoadDeckCards2>();
			loadDeckCards3 = dropDownMenu.GetComponent<LoadDeckCards3>();
			mulliganInfo = GameObject.Find("MulliganInformation");
			handCardCollection = GameObject.Find("HandCardCollection");
			
			cardModel1 = GameObject.Find("CardModel1");
			cardModel1a = GameObject.Find("CardModel1a");
			cardModel1b = GameObject.Find("CardModel1b");
			cardModel1c = GameObject.Find("CardModel1c");
			cardModel2 = GameObject.Find("CardModel2");
			cardModel2a = GameObject.Find("CardModel2a");
			cardModel2b = GameObject.Find("CardModel2b");
			cardModel2c = GameObject.Find("CardModel2c");
			cardModel3 = GameObject.Find("CardModel3");
			cardModel3a = GameObject.Find("CardModel3a");
			cardModel3b = GameObject.Find("CardModel3b");
			cardModel3c = GameObject.Find("CardModel3c");
			cardModel4 = GameObject.Find("CardModel4");
			cardModel4a = GameObject.Find("CardModel4a");
			cardModel4b = GameObject.Find("CardModel4b");
			cardModel4c = GameObject.Find("CardModel4c");
			cardModel5 = GameObject.Find("CardModel5");
			cardModel5a = GameObject.Find("CardModel5a");
			cardModel5b = GameObject.Find("CardModel5b");
			cardModel5c = GameObject.Find("CardModel5c");
			cardModel6 = GameObject.Find("CardModel6");
			cardModel6a = GameObject.Find("CardModel6a");
			cardModel6b = GameObject.Find("CardModel6b");
			cardModel6c = GameObject.Find("CardModel6c");
			cardModel7 = GameObject.Find("CardModel7");
			cardModel7a = GameObject.Find("CardModel7a");
			cardModel7b = GameObject.Find("CardModel7b");
			cardModel7c = GameObject.Find("CardModel7c");
			cardModel8 = GameObject.Find("CardModel8");
			cardModel8a = GameObject.Find("CardModel8a");
			cardModel8b = GameObject.Find("CardModel8b");
			cardModel8c = GameObject.Find("CardModel8c");
			cardModel9 = GameObject.Find("CardModel9");
			cardModel9a = GameObject.Find("CardModel9a");
			cardModel9b = GameObject.Find("CardModel9b");
			cardModel9c = GameObject.Find("CardModel9c");
			cardModel10 = GameObject.Find("CardModel10");
			cardModel10a = GameObject.Find("CardModel10a");
			cardModel10b = GameObject.Find("CardModel10b");
			cardModel10c = GameObject.Find("CardModel10c");
			cardModel11 = GameObject.Find("CardModel11");
			cardModel11a = GameObject.Find("CardModel11a");
			cardModel11b = GameObject.Find("CardModel11b");
			cardModel11c = GameObject.Find("CardModel11c");
			cardModel12 = GameObject.Find("CardModel12");
			cardModel12a = GameObject.Find("CardModel12a");
			cardModel12b = GameObject.Find("CardModel12b");
			cardModel12c = GameObject.Find("CardModel12c");
			cardModel13 = GameObject.Find("CardModel13");
			cardModel13a = GameObject.Find("CardModel13a");
			cardModel13b = GameObject.Find("CardModel13b");
			cardModel13c = GameObject.Find("CardModel13c");
			cardModel14 = GameObject.Find("CardModel14");
			cardModel14a = GameObject.Find("CardModel14a");
			cardModel14b = GameObject.Find("CardModel14b");
			cardModel14c = GameObject.Find("CardModel14c");
			cardModel15 = GameObject.Find("CardModel15");
			cardModel15a = GameObject.Find("CardModel15a");
			cardModel15b = GameObject.Find("CardModel15b");
			cardModel15c = GameObject.Find("CardModel15c");
			cardModel16 = GameObject.Find("CardModel16");
			cardModel16a = GameObject.Find("CardModel16a");
			cardModel16b = GameObject.Find("CardModel16b");
			cardModel16c = GameObject.Find("CardModel16c");
			cardModel17 = GameObject.Find("CardModel17");
			cardModel17a = GameObject.Find("CardModel17a");
			cardModel17b = GameObject.Find("CardModel17b");
			cardModel17c = GameObject.Find("CardModel17c");
			cardModel18 = GameObject.Find("CardModel18");
			cardModel18a = GameObject.Find("CardModel18a");
			cardModel18b = GameObject.Find("CardModel18b");
			cardModel18c = GameObject.Find("CardModel18c");
			cardModel19 = GameObject.Find("CardModel19");
			cardModel19a = GameObject.Find("CardModel19a");
			cardModel19b = GameObject.Find("CardModel19b");
			cardModel19c = GameObject.Find("CardModel19c");
			cardModel20 = GameObject.Find("CardModel20");
			cardModel20a = GameObject.Find("CardModel20a");
			cardModel20b = GameObject.Find("CardModel20b");
			cardModel20c = GameObject.Find("CardModel20c");
			cardModel21 = GameObject.Find("CardModel21");
			cardModel21a = GameObject.Find("CardModel21a");
			cardModel21b = GameObject.Find("CardModel21b");
			cardModel21c = GameObject.Find("CardModel21c");
			cardModel22 = GameObject.Find("CardModel22");
			cardModel22a = GameObject.Find("CardModel22a");
			cardModel22b = GameObject.Find("CardModel22b");
			cardModel22c = GameObject.Find("CardModel22c");
			cardModel23 = GameObject.Find("CardModel23");
			cardModel23a = GameObject.Find("CardModel23a");
			cardModel23b = GameObject.Find("CardModel23b");
			cardModel23c = GameObject.Find("CardModel23c");
			cardModel24 = GameObject.Find("CardModel24");
			cardModel24a = GameObject.Find("CardModel24a");
			cardModel24b = GameObject.Find("CardModel24b");
			cardModel24c = GameObject.Find("CardModel24c");
			cardModel25 = GameObject.Find("CardModel25");
			cardModel25a = GameObject.Find("CardModel25a");
			cardModel25b = GameObject.Find("CardModel25b");
			cardModel25c = GameObject.Find("CardModel25c");
			cardModel26 = GameObject.Find("CardModel26");
			cardModel26a = GameObject.Find("CardModel26a");
			cardModel26b = GameObject.Find("CardModel26b");
			cardModel26c = GameObject.Find("CardModel26c");
			cardModel27 = GameObject.Find("CardModel27");
			cardModel27a = GameObject.Find("CardModel27a");
			cardModel27b = GameObject.Find("CardModel27b");
			cardModel27c = GameObject.Find("CardModel27c");
			cardModel28 = GameObject.Find("CardModel28");
			cardModel28a = GameObject.Find("CardModel28a");
			cardModel28b = GameObject.Find("CardModel28b");
			cardModel28c = GameObject.Find("CardModel28c");
			cardModel29 = GameObject.Find("CardModel29");
			cardModel29a = GameObject.Find("CardModel29a");
			cardModel29b = GameObject.Find("CardModel29b");
			cardModel29c = GameObject.Find("CardModel29c");
			cardModel30 = GameObject.Find("CardModel30");
			cardModel30a = GameObject.Find("CardModel30a");
			cardModel30b = GameObject.Find("CardModel30b");
			cardModel30c = GameObject.Find("CardModel30c");
			cardModel31 = GameObject.Find("CardModel31");
			cardModel31a = GameObject.Find("CardModel31a");
			cardModel31b = GameObject.Find("CardModel31b");
			cardModel31c = GameObject.Find("CardModel31c");
			cardModel32 = GameObject.Find("CardModel32");
			cardModel32a = GameObject.Find("CardModel32a");
			cardModel32b = GameObject.Find("CardModel32b");
			cardModel32c = GameObject.Find("CardModel32c");
			cardModel33 = GameObject.Find("CardModel33");
			cardModel33a = GameObject.Find("CardModel33a");
			cardModel33b = GameObject.Find("CardModel33b");
			cardModel33c = GameObject.Find("CardModel33c");
			cardModel34 = GameObject.Find("CardModel34");
			cardModel34a = GameObject.Find("CardModel34a");
			cardModel34b = GameObject.Find("CardModel34b");
			cardModel34c = GameObject.Find("CardModel34c");
			cardModel35 = GameObject.Find("CardModel35");
			cardModel35a = GameObject.Find("CardModel35a");
			cardModel35b = GameObject.Find("CardModel35b");
			cardModel35c = GameObject.Find("CardModel35c");
			cardModel36 = GameObject.Find("CardModel36");
			cardModel36a = GameObject.Find("CardModel36a");
			cardModel36b = GameObject.Find("CardModel36b");
			cardModel36c = GameObject.Find("CardModel36c");
			cardModel37 = GameObject.Find("CardModel37");
			cardModel37a = GameObject.Find("CardModel37a");
			cardModel37b = GameObject.Find("CardModel37b");
			cardModel37c = GameObject.Find("CardModel37c");
			cardModel38 = GameObject.Find("CardModel38");
			cardModel38a = GameObject.Find("CardModel38a");
			cardModel38b = GameObject.Find("CardModel38b");
			cardModel38c = GameObject.Find("CardModel38c");
			cardModel39 = GameObject.Find("CardModel39");
			cardModel39a = GameObject.Find("CardModel39a");
			cardModel39b = GameObject.Find("CardModel39b");
			cardModel39c = GameObject.Find("CardModel39c");
			cardModel40 = GameObject.Find("CardModel40");
			cardModel40a = GameObject.Find("CardModel40a");
			cardModel40b = GameObject.Find("CardModel40b");
			cardModel40c = GameObject.Find("CardModel40c");
			cardModel41 = GameObject.Find("CardModel41");
			cardModel41a = GameObject.Find("CardModel41a");
			cardModel41b = GameObject.Find("CardModel41b");
			cardModel41c = GameObject.Find("CardModel41c");
			cardModel42 = GameObject.Find("CardModel42");
			cardModel42a = GameObject.Find("CardModel42a");
			cardModel42b = GameObject.Find("CardModel42b");
			cardModel42c = GameObject.Find("CardModel42c");
			cardModel43 = GameObject.Find("CardModel43");
			cardModel43a = GameObject.Find("CardModel43a");
			cardModel43b = GameObject.Find("CardModel43b");
			cardModel43c = GameObject.Find("CardModel43c");
			cardModel44 = GameObject.Find("CardModel44");
			cardModel44a = GameObject.Find("CardModel44a");
			cardModel44b = GameObject.Find("CardModel44b");
			cardModel44c = GameObject.Find("CardModel44c");
			cardModel45 = GameObject.Find("CardModel45");
			cardModel45a = GameObject.Find("CardModel45a");
			cardModel45b = GameObject.Find("CardModel45b");
			cardModel45c = GameObject.Find("CardModel45c");
			cardModel46 = GameObject.Find("CardModel46");
			cardModel46a = GameObject.Find("CardModel46a");
			cardModel46b = GameObject.Find("CardModel46b");
			cardModel46c = GameObject.Find("CardModel46c");
			cardModel47 = GameObject.Find("CardModel47");
			cardModel47a = GameObject.Find("CardModel47a");
			cardModel47b = GameObject.Find("CardModel47b");
			cardModel47c = GameObject.Find("CardModel47c");
			cardModel48 = GameObject.Find("CardModel48");
			cardModel48a = GameObject.Find("CardModel48a");
			cardModel48b = GameObject.Find("CardModel48b");
			cardModel48c = GameObject.Find("CardModel48c");
			cardModel49 = GameObject.Find("CardModel49");
			cardModel49a = GameObject.Find("CardModel49a");
			cardModel49b = GameObject.Find("CardModel49b");
			cardModel49c = GameObject.Find("CardModel49c");
			cardModel50 = GameObject.Find("CardModel50");
			cardModel50a = GameObject.Find("CardModel50a");
			cardModel50b = GameObject.Find("CardModel50b");
			cardModel50c = GameObject.Find("CardModel50c");
			cardModel51 = GameObject.Find("CardModel51");
			cardModel51a = GameObject.Find("CardModel51a");
			cardModel51b = GameObject.Find("CardModel51b");
			cardModel51c = GameObject.Find("CardModel51c");
			cardModel52 = GameObject.Find("CardModel52");
			cardModel52a = GameObject.Find("CardModel52a");
			cardModel52b = GameObject.Find("CardModel52b");
			cardModel52c = GameObject.Find("CardModel52c");
			cardModel53 = GameObject.Find("CardModel53");
			cardModel53a = GameObject.Find("CardModel53a");
			cardModel53b = GameObject.Find("CardModel53b");
			cardModel53c = GameObject.Find("CardModel53c");
			cardModel54 = GameObject.Find("CardModel54");
			cardModel54a = GameObject.Find("CardModel54a");
			cardModel54b = GameObject.Find("CardModel54b");
			cardModel54c = GameObject.Find("CardModel54c");
			cardModel55 = GameObject.Find("CardModel55");
			cardModel55a = GameObject.Find("CardModel55a");
			cardModel55b = GameObject.Find("CardModel55b");
			cardModel55c = GameObject.Find("CardModel55c");
			cardModel56 = GameObject.Find("CardModel56");
			cardModel56a = GameObject.Find("CardModel56a");
			cardModel56b = GameObject.Find("CardModel56b");
			cardModel56c = GameObject.Find("CardModel56c");
			cardModel57 = GameObject.Find("CardModel57");
			cardModel57a = GameObject.Find("CardModel57a");
			cardModel57b = GameObject.Find("CardModel57b");
			cardModel57c = GameObject.Find("CardModel57c");
			cardModel58 = GameObject.Find("CardModel58");
			cardModel58a = GameObject.Find("CardModel58a");
			cardModel58b = GameObject.Find("CardModel58b");
			cardModel58c = GameObject.Find("CardModel58c");
			cardModel59 = GameObject.Find("CardModel59");
			cardModel59a = GameObject.Find("CardModel59a");
			cardModel59b = GameObject.Find("CardModel59b");
			cardModel59c = GameObject.Find("CardModel59c");
			cardModel60 = GameObject.Find("CardModel60");
			cardModel60a = GameObject.Find("CardModel60a");
			cardModel60b = GameObject.Find("CardModel60b");
			cardModel60c = GameObject.Find("CardModel60c");
			
		}
	 
		 // Use this for initialization
		 void Start () {
			 
			isScrollCardModels = false;
			handCardCollection.SetActive(false);
		
		 }
		 
		
		 
		 // Update is called once per frame
		 void Update () {
			 
			if(isScrollCardModels && itemsToScroll.Count > 0){
				
			 
			 
				for (int i = 0; i < itemsToScroll.Count; i++){
				
					distReposition[i] = center.GetComponent<Transform>().position.x - itemsToScroll[i].GetComponent<Transform>().position.x;
					distance[i] = Mathf.Abs(distReposition[i]);
					

					if (distReposition[i] > scrollLimit){ //if distReposition is greater than 1200 from the center
						float curX = itemsToScroll[i].GetComponent<Transform>().localPosition.x;
						float curY = itemsToScroll[i].GetComponent<Transform>().localPosition.y;
						float curZ = itemsToScroll[i].GetComponent<Transform>().localPosition.z;

						Vector3 newLocalPos = new Vector3 (curX + (bttnLength * bttnDistance), curY, curZ); 
						itemsToScroll[i].GetComponent<Transform>().localPosition = newLocalPos;
					}

					if (distReposition[i] < -scrollLimit){ //if distReposition is lesser than 1200 from the center
						float curX = itemsToScroll[i].GetComponent<Transform>().localPosition.x;
						float curY = itemsToScroll[i].GetComponent<Transform>().localPosition.y;
						float curZ = itemsToScroll[i].GetComponent<Transform>().localPosition.z;

						Vector3 newLocalPos = new Vector3 (curX - (bttnLength * bttnDistance), curY, curZ);
						itemsToScroll[i].GetComponent<Transform>().localPosition = newLocalPos;
					}
				} 
			
				float minDistance = Mathf.Min(distance);	// Get the min distance

				for (int a = 0; a < itemsToScroll.Count; a++){
					if (minDistance == distance[a]){
						minButtonNum = a;
					}
				}

				if (!dragging){
				//	LerpToBttn(minButtonNum * -bttnDistance);
					LerpToBttn (-itemsToScroll[minButtonNum].GetComponent<Transform>().localPosition.x);
				}
				
				
				if(Input.GetKeyDown(KeyCode.RightArrow)){
					
					posXRight = 0.0f;
					posYRight = 0.0f;
					posZRight = 0.0f;
					
					center.transform.localPosition = new Vector3(posXLeft,posYLeft,posZLeft);
					print(center.transform.localPosition);
					posXLeft += 3.0f;
					posYLeft += 3.0f;
					posZLeft += 3.0f;
					
					if(posXLeft > 21.0f && posYLeft > 21.0f && posZLeft > 21.0f){
						posXLeft = 0.0f;
						posYLeft = 0.0f;
						posZLeft = 0.0f;
					}
					
				}
				
				if(Input.GetKeyDown(KeyCode.LeftArrow)){
					
					posXLeft = 0.0f;
					posYLeft = 0.0f;
					posZLeft = 0.0f;
					
					center.transform.localPosition = new Vector3(posXRight,posYRight,posZRight);
					print(center.transform.localPosition);
					posXRight += -3.0f;
					posYRight += -3.0f;
					posZRight += -3.0f;
					
					if(posXRight < -21.0f && posYRight < -21.0f && posZRight < -21.0f){
						posXRight = 0.0f;
						posYRight = 0.0f;
						posZRight = 0.0f;
					}
					
				}
				
				if(Input.GetKeyDown(KeyCode.DownArrow)){
					
					center.transform.localPosition = new Vector3(0,0,0);

				}
				
				if(Input.GetKeyDown(KeyCode.UpArrow)){
					
				
				

				}
			
			}
		
		}
		 
		 
		 
		void LerpToBttn(float position){
			float newX = Mathf.Lerp (panel.localPosition.x, position, Time.deltaTime * 5.0f);
			Vector3 newPosition = new Vector3 (newX, panel.localPosition.y, panel.localPosition.z);

			panel.localPosition = newPosition;
		}

		public void StartDrag(){
			//print("dragging");
			dragging = true;
		}

		public void EndDrag(){
			//print("not dragging");
			dragging = false;
		}
		
		
		
		 IEnumerator StartScrollStuffDeck1(){
			 
			 yield return new WaitForSeconds(1);
			 
			 for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
				
				grabbedHandDeck1Cards.Add(loadDeckCards1.getHandCardsDeck1[i]);
				
			}
			
			
			
			foreach(GameObject reference in grabbedHandDeck1Cards){
					
					if(reference.name == "instantiated1HandCard1"){
						
						GameObject card = Instantiate (cardModel1, spawnPoint, Quaternion.identity) as GameObject;
						//card.transform.localScale = new Vector3(325f,200f,340.0f);
						card.transform.parent = panel.transform;
						card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
						card.name = "instantiated1ScrollCard1";
						itemsToScroll.Add(card);
						
						
					
					}
					
					if(reference.name == "instantiated1HandCard1a"){
							
							GameObject card = Instantiate (cardModel1a, spawnPoint, Quaternion.identity) as GameObject;
							//card.transform.localScale = new Vector3(325f,200f,340.0f);
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard1a";
							itemsToScroll.Add(card);
							
							
					}
					
					if(reference.name == "instantiated1HandCard1b"){
						
							
							GameObject card = Instantiate (cardModel1b, spawnPoint, Quaternion.identity) as GameObject;
							//card.transform.localScale = new Vector3(325f,200f,340.0f);
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard1b";
							itemsToScroll.Add(card);
							
						
					}
					
					if(reference.name == "instantiated1HandCard1c"){
						
							
							GameObject card = Instantiate (cardModel1c, spawnPoint, Quaternion.identity) as GameObject;
							//card.transform.localScale = new Vector3(325f,200f,340.0f);
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard1c";
							itemsToScroll.Add(card);
							
						
					}
					
					if(reference.name == "instantiated1HandCard2"){
						
							
							GameObject card = Instantiate (cardModel2, spawnPoint, Quaternion.identity) as GameObject;
							//card.transform.localScale = new Vector3(325f,200f,340.0f);
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard2";
							itemsToScroll.Add(card);
						
					}
					
					if(reference.name == "instantiated1HandCard2a"){
						
							
							GameObject card = Instantiate (cardModel2a, spawnPoint, Quaternion.identity) as GameObject;
							//card.transform.localScale = new Vector3(325f,200f,340.0f);
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard2a";
							itemsToScroll.Add(card);
							
						
					}
					
					if(reference.name == "instantiated1HandCard2b"){
						
							
							GameObject card = Instantiate (cardModel2b, spawnPoint, Quaternion.identity) as GameObject;
							//card.transform.localScale = new Vector3(325f,200f,340.0f);
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard2b";
							itemsToScroll.Add(card);
							
					
					}
					
					if(reference.name == "instantiated1HandCard2c"){
						
							
							GameObject card = Instantiate (cardModel2c, spawnPoint, Quaternion.identity) as GameObject;
							//card.transform.localScale = new Vector3(325f,200f,340.0f);
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard2c";
							itemsToScroll.Add(card);
							
					
					}
					
					if(reference.name == "instantiated1HandCard3"){
						
							
							GameObject card = Instantiate (cardModel3, spawnPoint, Quaternion.identity) as GameObject;
							//card.transform.localScale = new Vector3(325f,200f,340.0f);
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard3";
							itemsToScroll.Add(card);
							
					
					}
					
					if(reference.name == "instantiated1HandCard3a"){
						
							
							GameObject card = Instantiate (cardModel3a, spawnPoint, Quaternion.identity) as GameObject;
							//card.transform.localScale = new Vector3(325f,200f,340.0f);
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard3a";
							itemsToScroll.Add(card);
							
					
					}
					
					if(reference.name == "instantiated1HandCard3b"){
						
							
							GameObject card = Instantiate (cardModel3b, spawnPoint, Quaternion.identity) as GameObject;
							//card.transform.localScale = new Vector3(325f,200f,340.0f);
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard3b";
							itemsToScroll.Add(card);
							
					
					}
					
					if(reference.name == "instantiated1HandCard3c"){
						
							
							GameObject card = Instantiate (cardModel3c, spawnPoint, Quaternion.identity) as GameObject;
							//card.transform.localScale = new Vector3(325f,200f,340.0f);
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard3c";
							itemsToScroll.Add(card);
							
					
					}
					
					if(reference.name == "instantiated1HandCard4"){
						
							
							GameObject card = Instantiate (cardModel4, spawnPoint, Quaternion.identity) as GameObject;
							//card.transform.localScale = new Vector3(325f,200f,340.0f);
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard4";
							itemsToScroll.Add(card);
							
					
					}
					
					if(reference.name == "instantiated1HandCard4a"){
						
							
							GameObject card = Instantiate (cardModel4a, spawnPoint, Quaternion.identity) as GameObject;
							//card.transform.localScale = new Vector3(325f,200f,340.0f);
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard4a";
							itemsToScroll.Add(card);
							
					
					}
					
					if(reference.name == "instantiated1HandCard4b"){
						
							
							GameObject card = Instantiate (cardModel4b, spawnPoint, Quaternion.identity) as GameObject;
							//card.transform.localScale = new Vector3(325f,200f,340.0f);
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard4b";
							itemsToScroll.Add(card);
							
					
					}
					
					if(reference.name == "instantiated1HandCard4c"){
						
							
							GameObject card = Instantiate (cardModel4c, spawnPoint, Quaternion.identity) as GameObject;
							//card.transform.localScale = new Vector3(325f,200f,340.0f);
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard4c";
							itemsToScroll.Add(card);
							
					
					}
					
					if(reference.name == "instantiated1HandCard5"){
						
							
							GameObject card = Instantiate (cardModel5, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard5";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard5a"){
						
							
							GameObject card = Instantiate (cardModel5a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard5a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard5b"){
						
							
							GameObject card = Instantiate (cardModel5b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard5b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard5c"){
						
							
							GameObject card = Instantiate (cardModel5c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard5c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard6"){
						
							
							GameObject card = Instantiate (cardModel6, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard6";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard6a"){
						
							
							GameObject card = Instantiate (cardModel6a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard6a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard6b"){
						
							
							GameObject card = Instantiate (cardModel6b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard6b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard6c"){
						
							
							GameObject card = Instantiate (cardModel6c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard6c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard7"){
						
							
							GameObject card = Instantiate (cardModel7, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard7";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard7a"){
						
							
							GameObject card = Instantiate (cardModel7a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard7a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard7b"){
						
							
							GameObject card = Instantiate (cardModel7b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard7b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard7c"){
						
							
							GameObject card = Instantiate (cardModel7c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard7c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard8"){
						
							
							GameObject card = Instantiate (cardModel8, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard8";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard8a"){
						
							
							GameObject card = Instantiate (cardModel8a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard8a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard8b"){
						
							
							GameObject card = Instantiate (cardModel8b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard8b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard8c"){
						
							
							GameObject card = Instantiate (cardModel8c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard8c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard9"){
						
							
							GameObject card = Instantiate (cardModel9, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard9";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard9a"){
						
							
							GameObject card = Instantiate (cardModel9a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard9a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard9b"){
						
							
							GameObject card = Instantiate (cardModel9b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard9b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard9c"){
						
							
							GameObject card = Instantiate (cardModel9c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard9c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard10"){
						
							
							GameObject card = Instantiate (cardModel10, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard10";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard10a"){
						
							
							GameObject card = Instantiate (cardModel10a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard10a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard10b"){
						
							
							GameObject card = Instantiate (cardModel10b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard10b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard10c"){
						
							
							GameObject card = Instantiate (cardModel10c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard10c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard11"){
						
							
							GameObject card = Instantiate (cardModel11, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard11";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard11a"){
						
							
							GameObject card = Instantiate (cardModel11a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard11a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard11b"){
						
							
							GameObject card = Instantiate (cardModel11b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard11b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard11c"){
						
							
							GameObject card = Instantiate (cardModel11c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard11c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard12"){
						
							
							GameObject card = Instantiate (cardModel12, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard12";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard12a"){
						
							
							GameObject card = Instantiate (cardModel12a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard12a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard12b"){
						
							
							GameObject card = Instantiate (cardModel12b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard12b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard12c"){
						
							
							GameObject card = Instantiate (cardModel12c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard12c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard13"){
						
							
							GameObject card = Instantiate (cardModel13, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard13";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard13a"){
						
							
							GameObject card = Instantiate (cardModel13a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard13a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard13b"){
						
							
							GameObject card = Instantiate (cardModel13b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard13b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard13c"){
						
							
							GameObject card = Instantiate (cardModel13c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard13c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard14"){
						
							
							GameObject card = Instantiate (cardModel14, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard14";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard14a"){
						
							
							GameObject card = Instantiate (cardModel14a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard14a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard14b"){
						
							
							GameObject card = Instantiate (cardModel14b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard14b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard14c"){
						
							
							GameObject card = Instantiate (cardModel14c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard14c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard15"){
					
							
							GameObject card = Instantiate (cardModel15, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard15";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard15a"){
						
							
							GameObject card = Instantiate (cardModel15a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard15a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard15b"){
						
							
							GameObject card = Instantiate (cardModel15b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard15b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard15c"){
						
							
							GameObject card = Instantiate (cardModel15c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard15c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard16"){
						
							
							GameObject card = Instantiate (cardModel16, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard16";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard16a"){
						
							
							GameObject card = Instantiate (cardModel16a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard16a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard16b"){
						
							
							GameObject card = Instantiate (cardModel16b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard16b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard16c"){
						
							
							GameObject card = Instantiate (cardModel16c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard16c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard17"){
						
							
							GameObject card = Instantiate (cardModel17, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard17";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard17a"){
						
							
							GameObject card = Instantiate (cardModel17a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard17a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard17b"){
						
							
							GameObject card = Instantiate (cardModel17b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard17b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard17c"){
						
							
							GameObject card = Instantiate (cardModel17c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard17c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard18"){
						
							
							GameObject card = Instantiate (cardModel18, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard18";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard18a"){
						
							
							GameObject card = Instantiate (cardModel18a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard18a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard18b"){
						
							
							GameObject card = Instantiate (cardModel18b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard18b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard18c"){
						
							
							GameObject card = Instantiate (cardModel18c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard18c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard19"){
						
							
							GameObject card = Instantiate (cardModel19, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard19";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard19a"){
						
							
							GameObject card = Instantiate (cardModel19a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard19a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard19b"){
						
							
							GameObject card = Instantiate (cardModel19b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard19b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard19c"){
						
							
							GameObject card = Instantiate (cardModel19c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard19c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard20"){
						
							
							GameObject card = Instantiate (cardModel20, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard20";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard20a"){
						
							
							GameObject card = Instantiate (cardModel20a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard20a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard20b"){
						
							
							GameObject card = Instantiate (cardModel20b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard20b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard20c"){
						
							
							GameObject card = Instantiate (cardModel20c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard20c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard21"){
						
							
							GameObject card = Instantiate (cardModel21, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard21";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard21a"){
						
							
							GameObject card = Instantiate (cardModel21a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard21a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard21b"){
						
							
							GameObject card = Instantiate (cardModel21b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard21b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard21c"){
						
							
							GameObject card = Instantiate (cardModel21c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard21c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard22"){
						
							
							GameObject card = Instantiate (cardModel22, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard22";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard22a"){
						
							
							GameObject card = Instantiate (cardModel22a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard22a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard22b"){
						
							
							GameObject card = Instantiate (cardModel22b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard22b";
							itemsToScroll.Add(card);
						
					}
					
					if(reference.name == "instantiated1HandCard22c"){
						
							
							GameObject card = Instantiate (cardModel22c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard22c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard23"){
						
							
							GameObject card = Instantiate (cardModel23, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard23";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard23a"){
						
							
							GameObject card = Instantiate (cardModel23a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard23a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard23b"){
						
							
							GameObject card = Instantiate (cardModel23b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard23b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard23c"){
						
							
							GameObject card = Instantiate (cardModel23c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard23c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard24"){
						
							
							GameObject card = Instantiate (cardModel24, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard24";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard24a"){
						
							
							GameObject card = Instantiate (cardModel24a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard24a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard24b"){
						
							
							GameObject card = Instantiate (cardModel24b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard24b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard24c"){
						
							
							GameObject card = Instantiate (cardModel24c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard24c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard25"){
						
							
							GameObject card = Instantiate (cardModel25, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard25";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard25a"){
						
							
							GameObject card = Instantiate (cardModel25a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard25a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard25b"){
						
							
							GameObject card = Instantiate (cardModel25b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard25b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard25c"){
						
							
							GameObject card = Instantiate (cardModel25c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard25c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard26"){
						
							
							GameObject card = Instantiate (cardModel26, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard26";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard26a"){
						
							
							GameObject card = Instantiate (cardModel26a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard26a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard26b"){
						
							
							GameObject card = Instantiate (cardModel26b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard26b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard26c"){
						
							
							GameObject card = Instantiate (cardModel26c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard26c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard27"){
						
							
							GameObject card = Instantiate (cardModel27, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard27";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard27a"){
						
							
							GameObject card = Instantiate (cardModel27a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard27a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard27b"){
						
							
							GameObject card = Instantiate (cardModel27b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard27b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard27c"){
						
							
							GameObject card = Instantiate (cardModel27c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard27c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard28"){
						
							
							GameObject card = Instantiate (cardModel28, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard28";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard28a"){
						
							
							GameObject card = Instantiate (cardModel28a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard28a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard28b"){
						
							
							GameObject card = Instantiate (cardModel28b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard28b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard28c"){
						
							
							GameObject card = Instantiate (cardModel28c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard28c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard29"){
						
							
							GameObject card = Instantiate (cardModel29, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard29";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard29a"){
						
							
							GameObject card = Instantiate (cardModel29a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard29a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard29b"){
						
							
							GameObject card = Instantiate (cardModel29b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard29b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard29c"){
						
							
							GameObject card = Instantiate (cardModel29c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard29c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard30"){
					
							
							GameObject card = Instantiate (cardModel30, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard30";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard30a"){
						
							
							GameObject card = Instantiate (cardModel30a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard30a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard30b"){
						
							
							GameObject card = Instantiate (cardModel30b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard30b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard30c"){
						
							
							GameObject card = Instantiate (cardModel30c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard30c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard31"){
						
							
							GameObject card = Instantiate (cardModel31, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard31";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard31a"){
						
							
							GameObject card = Instantiate (cardModel31a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard31a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard31b"){
						
							
							GameObject card = Instantiate (cardModel31b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard31b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard31c"){
						
							
							GameObject card = Instantiate (cardModel31c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard31c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard32"){
					
							
							GameObject card = Instantiate (cardModel32, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard32";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard32a"){
					
							
							GameObject card = Instantiate (cardModel32a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard32a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard32b"){
						
							
							GameObject card = Instantiate (cardModel32b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard32b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard32c"){
						
							
							GameObject card = Instantiate (cardModel32c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard32c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard33"){
						
							
							GameObject card = Instantiate (cardModel33, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard33";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard33a"){
						
							
							GameObject card = Instantiate (cardModel33a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard33a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard33b"){
						
							
							GameObject card = Instantiate (cardModel33b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard33b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard33c"){
						
							
							GameObject card = Instantiate (cardModel33c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard33c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard34"){
						
							
							GameObject card = Instantiate (cardModel34, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard34";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard34a"){
						
							
							GameObject card = Instantiate (cardModel34a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard34a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard34b"){
						
							
							GameObject card = Instantiate (cardModel34b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard34b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard34c"){
						
							
							GameObject card = Instantiate (cardModel34c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard34c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard35"){
						
							
							GameObject card = Instantiate (cardModel35, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard35";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard35a"){
						
							
							GameObject card = Instantiate (cardModel35a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard35a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard35b"){
						
							
							GameObject card = Instantiate (cardModel35b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard35b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard35c"){
						
							
							GameObject card = Instantiate (cardModel35c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard35c";
							itemsToScroll.Add(card);
					}
					
					if(reference.name == "instantiated1HandCard36"){
						
							
							GameObject card = Instantiate (cardModel36, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard36";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard36a"){
						
							
							GameObject card = Instantiate (cardModel36a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard36a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard36b"){
						
							
							GameObject card = Instantiate (cardModel36b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard36b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard36c"){
						
							
							GameObject card = Instantiate (cardModel36c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard36c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard37"){
						
							
							GameObject card = Instantiate (cardModel37, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard37";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard37a"){
						
							
							GameObject card = Instantiate (cardModel37a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard37a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard37b"){
						
							
							GameObject card = Instantiate (cardModel37b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard37b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard37c"){
						
							
							GameObject card = Instantiate (cardModel37c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard37c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard38"){
						
							
							GameObject card = Instantiate (cardModel38, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard38";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard38a"){
						
							
							GameObject card = Instantiate (cardModel38a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard38a";
							itemsToScroll.Add(card);
							
					
					}
					
					if(reference.name == "instantiated1HandCard38b"){
						
							
							GameObject card = Instantiate (cardModel38b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard38b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard38c"){
						
							
							GameObject card = Instantiate (cardModel38c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard38c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard39"){
						
							
							GameObject card = Instantiate (cardModel39, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard39";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard39a"){
						
							
							GameObject card = Instantiate (cardModel39a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard39a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard39b"){
						
							
							GameObject card = Instantiate (cardModel39b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard39b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard39c"){
						
							
							GameObject card = Instantiate (cardModel39c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard39c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard40"){
						
							
							GameObject card = Instantiate (cardModel40, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard40";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard40a"){
						
							
							GameObject card = Instantiate (cardModel40a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard40a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard40b"){
						
							
							GameObject card = Instantiate (cardModel40b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard40b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard40c"){
						
							
							GameObject card = Instantiate (cardModel40c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard40c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard41"){
						
							
							GameObject card = Instantiate (cardModel41, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard41";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard41a"){
						
							
							GameObject card = Instantiate (cardModel41a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard41a";
							itemsToScroll.Add(card);
							
					
					}
					
					if(reference.name == "instantiated1HandCard41b"){
						
							
							GameObject card = Instantiate (cardModel41b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard41b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard41c"){
						
							
							GameObject card = Instantiate (cardModel41c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard41c";
							itemsToScroll.Add(card);
							
					
					}
					
					if(reference.name == "instantiated1HandCard42"){
						
							
							GameObject card = Instantiate (cardModel42, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard42";
							itemsToScroll.Add(card);
							
					
					}
					
					if(reference.name == "instantiated1HandCard42a"){
						
							
							GameObject card = Instantiate (cardModel42a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard42a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard42b"){
						
							
							GameObject card = Instantiate (cardModel42b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard42b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard42c"){
						
							
							GameObject card = Instantiate (cardModel42c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard42c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard43"){
						
							
							GameObject card = Instantiate (cardModel43, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard43";
							itemsToScroll.Add(card);
							
					
					}
					
					if(reference.name == "instantiated1HandCard43a"){
						
							
							GameObject card = Instantiate (cardModel43a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard43a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard43b"){
						
							
							GameObject card = Instantiate (cardModel43b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard43b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard43c"){
						
							
							GameObject card = Instantiate (cardModel43c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard43c";
							itemsToScroll.Add(card);
							
					
					}
					
					if(reference.name == "instantiated1HandCard44"){
						
							
							GameObject card = Instantiate (cardModel44, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard44";
							itemsToScroll.Add(card);
							
					
					}
					
					if(reference.name == "instantiated1HandCard44a"){
						
							
							GameObject card = Instantiate (cardModel44a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard44a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard44b"){
						
							
							GameObject card = Instantiate (cardModel44b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard44b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard44c"){
						
							
							GameObject card = Instantiate (cardModel44c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard44c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard45"){
						
							
							GameObject card = Instantiate (cardModel45, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard45";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard45a"){
						
							
							GameObject card = Instantiate (cardModel45a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard45a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard45b"){
						
							
							GameObject card = Instantiate (cardModel45b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard45b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard45c"){
						
							
							GameObject card = Instantiate (cardModel45c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard45c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard46"){
						
							
							GameObject card = Instantiate (cardModel46, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard46";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard46a"){
						
							
							GameObject card = Instantiate (cardModel46a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard46a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard46b"){
						
							
							GameObject card = Instantiate (cardModel46b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard46b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard46c"){
						
							
							GameObject card = Instantiate (cardModel46c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard46c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard47"){
						
							
							GameObject card = Instantiate (cardModel47, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard47";
							itemsToScroll.Add(card);
							
					}
					
					if(reference.name == "instantiated1HandCard47a"){
						
							
							GameObject card = Instantiate (cardModel47a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard47a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard47b"){
						
							
							GameObject card = Instantiate (cardModel47b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard47b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard47c"){
						
							
							GameObject card = Instantiate (cardModel47c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard47c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard48"){
						
							
							GameObject card = Instantiate (cardModel48, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard48";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard48a"){
						
							
							GameObject card = Instantiate (cardModel48a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard48a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard48b"){
						
							
							GameObject card = Instantiate (cardModel48b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard48b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard48c"){
						
							
							GameObject card = Instantiate (cardModel48c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard48c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard49"){
						
							
							GameObject card = Instantiate (cardModel49, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard49";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard49a"){
						
							
							GameObject card = Instantiate (cardModel49a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard49a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard49b"){
						
							
							GameObject card = Instantiate (cardModel49b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard49b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard49c"){
						
							
							GameObject card = Instantiate (cardModel49c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard49c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard50"){
						
							
							GameObject card = Instantiate (cardModel50, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard50";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard50a"){
						
							
							GameObject card = Instantiate (cardModel50a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard50a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard50b"){
						
							
							GameObject card = Instantiate (cardModel50b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard50b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard50c"){
						
							
							GameObject card = Instantiate (cardModel50c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard50c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard51"){
						
							
							GameObject card = Instantiate (cardModel51, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard51";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard51a"){
						
							
							GameObject card = Instantiate (cardModel51a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard51a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard51b"){
						
							
							GameObject card = Instantiate (cardModel51b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard51b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard51c"){
						
							
							GameObject card = Instantiate (cardModel51c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard51c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard52"){
						
							
							GameObject card = Instantiate (cardModel52, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard52";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard52a"){
						
							
							GameObject card = Instantiate (cardModel52a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard52a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard52b"){
						
							
							GameObject card = Instantiate (cardModel52b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard52b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard52c"){
						
							
							GameObject card = Instantiate (cardModel52c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard52c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard53"){
						
							
							GameObject card = Instantiate (cardModel53, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard53";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard53a"){
						
							
							GameObject card = Instantiate (cardModel53a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard53a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard53b"){
						
							
							GameObject card = Instantiate (cardModel53b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard53b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard53c"){
						
							
							GameObject card = Instantiate (cardModel53c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard53c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard54"){
						
							
							GameObject card = Instantiate (cardModel54, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard54";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard54a"){
						
							
							GameObject card = Instantiate (cardModel54a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard54a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard54b"){
						
							
							GameObject card = Instantiate (cardModel54b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard54b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard54c"){
						
							
							GameObject card = Instantiate (cardModel54c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard54c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard55"){
						
							
							GameObject card = Instantiate (cardModel55, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard55";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard55a"){
						
							
							GameObject card = Instantiate (cardModel55a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard55a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard55b"){
						
							
							GameObject card = Instantiate (cardModel55b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard55b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard55c"){
						
							
							GameObject card = Instantiate (cardModel55c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard55c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard56"){
						
							
							GameObject card = Instantiate (cardModel56, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard56";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard56a"){
						
							
							GameObject card = Instantiate (cardModel56a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard56a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard56b"){
						
							
							GameObject card = Instantiate (cardModel56b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard56b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard56c"){
						
							
							GameObject card = Instantiate (cardModel56c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard56c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard57"){
						
							
							GameObject card = Instantiate (cardModel57, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard57";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard57a"){
						
							
							GameObject card = Instantiate (cardModel57a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard57a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard57b"){
						
							
							GameObject card = Instantiate (cardModel57b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard57b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard57c"){
						
							
							GameObject card = Instantiate (cardModel57c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard57c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard58"){
						
							
							GameObject card = Instantiate (cardModel58, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard58";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard58a"){
						
							
							GameObject card = Instantiate (cardModel58a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard58a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard58b"){
						
							
							GameObject card = Instantiate (cardModel58b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard58b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard58c"){
						
							
							GameObject card = Instantiate (cardModel58c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard58c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard59"){
						
							
							GameObject card = Instantiate (cardModel59, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard59";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard59a"){
						
							
							GameObject card = Instantiate (cardModel59a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard59a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard59b"){
						
							
							GameObject card = Instantiate (cardModel59b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard59b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard59c"){
						
							
							GameObject card = Instantiate (cardModel59c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard59c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard60"){
						
							
							GameObject card = Instantiate (cardModel60, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard60";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard60a"){
						
							
							GameObject card = Instantiate (cardModel60a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard60a";
							itemsToScroll.Add(card);
					
					}	

					if(reference.name == "instantiated1HandCard60b"){
						
							
							GameObject card = Instantiate (cardModel60b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard60b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated1HandCard60c"){
						
							
							GameObject card = Instantiate (cardModel60c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated1ScrollCard60c";
							itemsToScroll.Add(card);
					
					}	

					
				}
				
			 
			 yield return new WaitForSeconds(2);
			 
			for(int i = 0; i < itemsToScroll.Count; i++){
						
				itemsToScroll[i].transform.localPosition = new Vector3(offset, 0, 0);
				offset += 6.0f;
						
			}
			
			bttnLength = itemsToScroll.Count;
			distance = new float[bttnLength];
			distReposition = new float[bttnLength];
			
			// Get distance between buttons
			bttnDistance  = (int)Mathf.Abs(itemsToScroll[1].GetComponent<Transform>().localPosition.x - itemsToScroll[0].GetComponent<Transform>().localPosition.x);
			
			//bttnLength = 240, bttnDistance = 10, 240 * 10 = 2400, 2400/2 = 1200
			scrollLimit = ((bttnLength * bttnDistance) / 2);
			
			//print("bttnLength" + bttnLength);
			//print("bttnDistance" + bttnDistance);
			
			yield return new WaitForSeconds(2);
			 
			isScrollCardModels = true;
		}
		
		
		IEnumerator StartScrollStuffDeck2(){
			 
			 yield return new WaitForSeconds(1);
			 
			 for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
				
				grabbedHandDeck2Cards.Add(loadDeckCards2.getHandCardsDeck2[i]);
				
			}
			
			
			
			foreach(GameObject reference in grabbedHandDeck2Cards){
					
					if(reference.name == "instantiated2HandCard1"){
						
						GameObject card = Instantiate (cardModel1, spawnPoint, Quaternion.identity) as GameObject;
						//card.transform.localScale = new Vector3(325f,200f,340.0f);
						card.transform.parent = panel.transform;
						card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
						card.name = "instantiated2ScrollCard1";
						itemsToScroll.Add(card);
						
						
					
					}
					
					if(reference.name == "instantiated2HandCard1a"){
							
							GameObject card = Instantiate (cardModel1a, spawnPoint, Quaternion.identity) as GameObject;
							//card.transform.localScale = new Vector3(325f,200f,340.0f);
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard1a";
							itemsToScroll.Add(card);
							
							
					}
					
					if(reference.name == "instantiated2HandCard1b"){
						
							
							GameObject card = Instantiate (cardModel1b, spawnPoint, Quaternion.identity) as GameObject;
							//card.transform.localScale = new Vector3(325f,200f,340.0f);
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard1b";
							itemsToScroll.Add(card);
							
						
					}
					
					if(reference.name == "instantiated2HandCard1c"){
						
							
							GameObject card = Instantiate (cardModel1c, spawnPoint, Quaternion.identity) as GameObject;
							//card.transform.localScale = new Vector3(325f,200f,340.0f);
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard1c";
							itemsToScroll.Add(card);
							
						
					}
					
					if(reference.name == "instantiated2HandCard2"){
						
							
							GameObject card = Instantiate (cardModel2, spawnPoint, Quaternion.identity) as GameObject;
							//card.transform.localScale = new Vector3(325f,200f,340.0f);
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard2";
							itemsToScroll.Add(card);
						
					}
					
					if(reference.name == "instantiated2HandCard2a"){
						
							
							GameObject card = Instantiate (cardModel2a, spawnPoint, Quaternion.identity) as GameObject;
							//card.transform.localScale = new Vector3(325f,200f,340.0f);
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard2a";
							itemsToScroll.Add(card);
							
						
					}
					
					if(reference.name == "instantiated2HandCard2b"){
						
							
							GameObject card = Instantiate (cardModel2b, spawnPoint, Quaternion.identity) as GameObject;
							//card.transform.localScale = new Vector3(325f,200f,340.0f);
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard2b";
							itemsToScroll.Add(card);
							
					
					}
					
					if(reference.name == "instantiated2HandCard2c"){
						
							
							GameObject card = Instantiate (cardModel2c, spawnPoint, Quaternion.identity) as GameObject;
							//card.transform.localScale = new Vector3(325f,200f,340.0f);
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard2c";
							itemsToScroll.Add(card);
							
					
					}
					
					if(reference.name == "instantiated2HandCard3"){
						
							
							GameObject card = Instantiate (cardModel3, spawnPoint, Quaternion.identity) as GameObject;
							//card.transform.localScale = new Vector3(325f,200f,340.0f);
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard3";
							itemsToScroll.Add(card);
							
					
					}
					
					if(reference.name == "instantiated2HandCard3a"){
						
							
							GameObject card = Instantiate (cardModel3a, spawnPoint, Quaternion.identity) as GameObject;
							//card.transform.localScale = new Vector3(325f,200f,340.0f);
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard3a";
							itemsToScroll.Add(card);
							
					
					}
					
					if(reference.name == "instantiated2HandCard3b"){
						
							
							GameObject card = Instantiate (cardModel3b, spawnPoint, Quaternion.identity) as GameObject;
							//card.transform.localScale = new Vector3(325f,200f,340.0f);
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard3b";
							itemsToScroll.Add(card);
							
					
					}
					
					if(reference.name == "instantiated2HandCard3c"){
						
							
							GameObject card = Instantiate (cardModel3c, spawnPoint, Quaternion.identity) as GameObject;
							//card.transform.localScale = new Vector3(325f,200f,340.0f);
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard3c";
							itemsToScroll.Add(card);
							
					
					}
					
					if(reference.name == "instantiated2HandCard4"){
						
							
							GameObject card = Instantiate (cardModel4, spawnPoint, Quaternion.identity) as GameObject;
							//card.transform.localScale = new Vector3(325f,200f,340.0f);
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard4";
							itemsToScroll.Add(card);
							
					
					}
					
					if(reference.name == "instantiated2HandCard4a"){
						
							
							GameObject card = Instantiate (cardModel4a, spawnPoint, Quaternion.identity) as GameObject;
							//card.transform.localScale = new Vector3(325f,200f,340.0f);
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard4a";
							itemsToScroll.Add(card);
							
					
					}
					
					if(reference.name == "instantiated2HandCard4b"){
						
							
							GameObject card = Instantiate (cardModel4b, spawnPoint, Quaternion.identity) as GameObject;
							//card.transform.localScale = new Vector3(325f,200f,340.0f);
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard4b";
							itemsToScroll.Add(card);
							
					
					}
					
					if(reference.name == "instantiated2HandCard4c"){
						
							
							GameObject card = Instantiate (cardModel4c, spawnPoint, Quaternion.identity) as GameObject;
							//card.transform.localScale = new Vector3(325f,200f,340.0f);
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard4c";
							itemsToScroll.Add(card);
							
					
					}
					
					if(reference.name == "instantiated2HandCard5"){
						
							
							GameObject card = Instantiate (cardModel5, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard5";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard5a"){
						
							
							GameObject card = Instantiate (cardModel5a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard5a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard5b"){
						
							
							GameObject card = Instantiate (cardModel5b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard5b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard5c"){
						
							
							GameObject card = Instantiate (cardModel5c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard5c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard6"){
						
							
							GameObject card = Instantiate (cardModel6, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard6";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard6a"){
						
							
							GameObject card = Instantiate (cardModel6a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard6a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard6b"){
						
							
							GameObject card = Instantiate (cardModel6b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard6b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard6c"){
						
							
							GameObject card = Instantiate (cardModel6c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard6c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard7"){
						
							
							GameObject card = Instantiate (cardModel7, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard7";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard7a"){
						
							
							GameObject card = Instantiate (cardModel7a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard7a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard7b"){
						
							
							GameObject card = Instantiate (cardModel7b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard7b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard7c"){
						
							
							GameObject card = Instantiate (cardModel7c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard7c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard8"){
						
							
							GameObject card = Instantiate (cardModel8, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard8";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard8a"){
						
							
							GameObject card = Instantiate (cardModel8a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard8a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard8b"){
						
							
							GameObject card = Instantiate (cardModel8b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard8b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard8c"){
						
							
							GameObject card = Instantiate (cardModel8c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard8c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard9"){
						
							
							GameObject card = Instantiate (cardModel9, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard9";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard9a"){
						
							
							GameObject card = Instantiate (cardModel9a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard9a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard9b"){
						
							
							GameObject card = Instantiate (cardModel9b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard9b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard9c"){
						
							
							GameObject card = Instantiate (cardModel9c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard9c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard10"){
						
							
							GameObject card = Instantiate (cardModel10, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard10";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard10a"){
						
							
							GameObject card = Instantiate (cardModel10a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard10a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard10b"){
						
							
							GameObject card = Instantiate (cardModel10b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard10b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard10c"){
						
							
							GameObject card = Instantiate (cardModel10c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard10c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard11"){
						
							
							GameObject card = Instantiate (cardModel11, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard11";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard11a"){
						
							
							GameObject card = Instantiate (cardModel11a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard11a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard11b"){
						
							
							GameObject card = Instantiate (cardModel11b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard11b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard11c"){
						
							
							GameObject card = Instantiate (cardModel11c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard11c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard12"){
						
							
							GameObject card = Instantiate (cardModel12, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard12";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard12a"){
						
							
							GameObject card = Instantiate (cardModel12a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard12a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard12b"){
						
							
							GameObject card = Instantiate (cardModel12b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard12b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard12c"){
						
							
							GameObject card = Instantiate (cardModel12c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard12c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard13"){
						
							
							GameObject card = Instantiate (cardModel13, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard13";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard13a"){
						
							
							GameObject card = Instantiate (cardModel13a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard13a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard13b"){
						
							
							GameObject card = Instantiate (cardModel13b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard13b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard13c"){
						
							
							GameObject card = Instantiate (cardModel13c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard13c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard14"){
						
							
							GameObject card = Instantiate (cardModel14, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard14";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard14a"){
						
							
							GameObject card = Instantiate (cardModel14a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard14a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard14b"){
						
							
							GameObject card = Instantiate (cardModel14b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard14b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard14c"){
						
							
							GameObject card = Instantiate (cardModel14c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard14c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard15"){
					
							
							GameObject card = Instantiate (cardModel15, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard15";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard15a"){
						
							
							GameObject card = Instantiate (cardModel15a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard15a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard15b"){
						
							
							GameObject card = Instantiate (cardModel15b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard15b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard15c"){
						
							
							GameObject card = Instantiate (cardModel15c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard15c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard16"){
						
							
							GameObject card = Instantiate (cardModel16, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard16";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard16a"){
						
							
							GameObject card = Instantiate (cardModel16a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard16a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard16b"){
						
							
							GameObject card = Instantiate (cardModel16b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard16b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard16c"){
						
							
							GameObject card = Instantiate (cardModel16c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard16c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard17"){
						
							
							GameObject card = Instantiate (cardModel17, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard17";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard17a"){
						
							
							GameObject card = Instantiate (cardModel17a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard17a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard17b"){
						
							
							GameObject card = Instantiate (cardModel17b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard17b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard17c"){
						
							
							GameObject card = Instantiate (cardModel17c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard17c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard18"){
						
							
							GameObject card = Instantiate (cardModel18, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard18";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard18a"){
						
							
							GameObject card = Instantiate (cardModel18a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard18a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard18b"){
						
							
							GameObject card = Instantiate (cardModel18b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard18b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard18c"){
						
							
							GameObject card = Instantiate (cardModel18c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard18c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard19"){
						
							
							GameObject card = Instantiate (cardModel19, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard19";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard19a"){
						
							
							GameObject card = Instantiate (cardModel19a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard19a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard19b"){
						
							
							GameObject card = Instantiate (cardModel19b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard19b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard19c"){
						
							
							GameObject card = Instantiate (cardModel19c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard19c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard20"){
						
							
							GameObject card = Instantiate (cardModel20, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard20";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard20a"){
						
							
							GameObject card = Instantiate (cardModel20a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard20a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard20b"){
						
							
							GameObject card = Instantiate (cardModel20b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard20b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard20c"){
						
							
							GameObject card = Instantiate (cardModel20c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard20c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard21"){
						
							
							GameObject card = Instantiate (cardModel21, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard21";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard21a"){
						
							
							GameObject card = Instantiate (cardModel21a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard21a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard21b"){
						
							
							GameObject card = Instantiate (cardModel21b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard21b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard21c"){
						
							
							GameObject card = Instantiate (cardModel21c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard21c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard22"){
						
							
							GameObject card = Instantiate (cardModel22, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard22";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard22a"){
						
							
							GameObject card = Instantiate (cardModel22a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard22a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard22b"){
						
							
							GameObject card = Instantiate (cardModel22b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard22b";
							itemsToScroll.Add(card);
						
					}
					
					if(reference.name == "instantiated2HandCard22c"){
						
							
							GameObject card = Instantiate (cardModel22c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard22c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard23"){
						
							
							GameObject card = Instantiate (cardModel23, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard23";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard23a"){
						
							
							GameObject card = Instantiate (cardModel23a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard23a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard23b"){
						
							
							GameObject card = Instantiate (cardModel23b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard23b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard23c"){
						
							
							GameObject card = Instantiate (cardModel23c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard23c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard24"){
						
							
							GameObject card = Instantiate (cardModel24, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard24";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard24a"){
						
							
							GameObject card = Instantiate (cardModel24a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard24a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard24b"){
						
							
							GameObject card = Instantiate (cardModel24b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard24b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard24c"){
						
							
							GameObject card = Instantiate (cardModel24c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard24c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard25"){
						
							
							GameObject card = Instantiate (cardModel25, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard25";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard25a"){
						
							
							GameObject card = Instantiate (cardModel25a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard25a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard25b"){
						
							
							GameObject card = Instantiate (cardModel25b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard25b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard25c"){
						
							
							GameObject card = Instantiate (cardModel25c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard25c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard26"){
						
							
							GameObject card = Instantiate (cardModel26, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard26";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard26a"){
						
							
							GameObject card = Instantiate (cardModel26a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard26a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard26b"){
						
							
							GameObject card = Instantiate (cardModel26b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard26b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard26c"){
						
							
							GameObject card = Instantiate (cardModel26c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard26c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard27"){
						
							
							GameObject card = Instantiate (cardModel27, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard27";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard27a"){
						
							
							GameObject card = Instantiate (cardModel27a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard27a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard27b"){
						
							
							GameObject card = Instantiate (cardModel27b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard27b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard27c"){
						
							
							GameObject card = Instantiate (cardModel27c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard27c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard28"){
						
							
							GameObject card = Instantiate (cardModel28, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard28";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard28a"){
						
							
							GameObject card = Instantiate (cardModel28a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard28a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard28b"){
						
							
							GameObject card = Instantiate (cardModel28b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard28b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard28c"){
						
							
							GameObject card = Instantiate (cardModel28c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard28c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard29"){
						
							
							GameObject card = Instantiate (cardModel29, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard29";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard29a"){
						
							
							GameObject card = Instantiate (cardModel29a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard29a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard29b"){
						
							
							GameObject card = Instantiate (cardModel29b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard29b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard29c"){
						
							
							GameObject card = Instantiate (cardModel29c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard29c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard30"){
					
							
							GameObject card = Instantiate (cardModel30, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard30";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard30a"){
						
							
							GameObject card = Instantiate (cardModel30a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard30a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard30b"){
						
							
							GameObject card = Instantiate (cardModel30b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard30b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard30c"){
						
							
							GameObject card = Instantiate (cardModel30c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard30c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard31"){
						
							
							GameObject card = Instantiate (cardModel31, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard31";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard31a"){
						
							
							GameObject card = Instantiate (cardModel31a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard31a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard31b"){
						
							
							GameObject card = Instantiate (cardModel31b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard31b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard31c"){
						
							
							GameObject card = Instantiate (cardModel31c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard31c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard32"){
					
							
							GameObject card = Instantiate (cardModel32, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard32";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard32a"){
					
							
							GameObject card = Instantiate (cardModel32a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard32a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard32b"){
						
							
							GameObject card = Instantiate (cardModel32b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard32b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard32c"){
						
							
							GameObject card = Instantiate (cardModel32c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard32c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard33"){
						
							
							GameObject card = Instantiate (cardModel33, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard33";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard33a"){
						
							
							GameObject card = Instantiate (cardModel33a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard33a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard33b"){
						
							
							GameObject card = Instantiate (cardModel33b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard33b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard33c"){
						
							
							GameObject card = Instantiate (cardModel33c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard33c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard34"){
						
							
							GameObject card = Instantiate (cardModel34, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard34";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard34a"){
						
							
							GameObject card = Instantiate (cardModel34a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard34a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard34b"){
						
							
							GameObject card = Instantiate (cardModel34b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard34b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard34c"){
						
							
							GameObject card = Instantiate (cardModel34c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard34c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard35"){
						
							
							GameObject card = Instantiate (cardModel35, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard35";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard35a"){
						
							
							GameObject card = Instantiate (cardModel35a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard35a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard35b"){
						
							
							GameObject card = Instantiate (cardModel35b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard35b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard35c"){
						
							
							GameObject card = Instantiate (cardModel35c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard35c";
							itemsToScroll.Add(card);
					}
					
					if(reference.name == "instantiated2HandCard36"){
						
							
							GameObject card = Instantiate (cardModel36, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard36";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard36a"){
						
							
							GameObject card = Instantiate (cardModel36a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard36a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard36b"){
						
							
							GameObject card = Instantiate (cardModel36b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard36b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard36c"){
						
							
							GameObject card = Instantiate (cardModel36c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard36c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard37"){
						
							
							GameObject card = Instantiate (cardModel37, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard37";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard37a"){
						
							
							GameObject card = Instantiate (cardModel37a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard37a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard37b"){
						
							
							GameObject card = Instantiate (cardModel37b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard37b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard37c"){
						
							
							GameObject card = Instantiate (cardModel37c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard37c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard38"){
						
							
							GameObject card = Instantiate (cardModel38, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard38";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard38a"){
						
							
							GameObject card = Instantiate (cardModel38a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard38a";
							itemsToScroll.Add(card);
							
					
					}
					
					if(reference.name == "instantiated2HandCard38b"){
						
							
							GameObject card = Instantiate (cardModel38b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard38b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard38c"){
						
							
							GameObject card = Instantiate (cardModel38c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard38c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard39"){
						
							
							GameObject card = Instantiate (cardModel39, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard39";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard39a"){
						
							
							GameObject card = Instantiate (cardModel39a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard39a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard39b"){
						
							
							GameObject card = Instantiate (cardModel39b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard39b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard39c"){
						
							
							GameObject card = Instantiate (cardModel39c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard39c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard40"){
						
							
							GameObject card = Instantiate (cardModel40, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard40";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard40a"){
						
							
							GameObject card = Instantiate (cardModel40a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard40a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard40b"){
						
							
							GameObject card = Instantiate (cardModel40b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard40b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard40c"){
						
							
							GameObject card = Instantiate (cardModel40c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard40c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard41"){
						
							
							GameObject card = Instantiate (cardModel41, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard41";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard41a"){
						
							
							GameObject card = Instantiate (cardModel41a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard41a";
							itemsToScroll.Add(card);
							
					
					}
					
					if(reference.name == "instantiated2HandCard41b"){
						
							
							GameObject card = Instantiate (cardModel41b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard41b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard41c"){
						
							
							GameObject card = Instantiate (cardModel41c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard41c";
							itemsToScroll.Add(card);
							
					
					}
					
					if(reference.name == "instantiated2HandCard42"){
						
							
							GameObject card = Instantiate (cardModel42, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard42";
							itemsToScroll.Add(card);
							
					
					}
					
					if(reference.name == "instantiated2HandCard42a"){
						
							
							GameObject card = Instantiate (cardModel42a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard42a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard42b"){
						
							
							GameObject card = Instantiate (cardModel42b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard42b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard42c"){
						
							
							GameObject card = Instantiate (cardModel42c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard42c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard43"){
						
							
							GameObject card = Instantiate (cardModel43, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard43";
							itemsToScroll.Add(card);
							
					
					}
					
					if(reference.name == "instantiated2HandCard43a"){
						
							
							GameObject card = Instantiate (cardModel43a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard43a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard43b"){
						
							
							GameObject card = Instantiate (cardModel43b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard43b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard43c"){
						
							
							GameObject card = Instantiate (cardModel43c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard43c";
							itemsToScroll.Add(card);
							
					
					}
					
					if(reference.name == "instantiated2HandCard44"){
						
							
							GameObject card = Instantiate (cardModel44, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard44";
							itemsToScroll.Add(card);
							
					
					}
					
					if(reference.name == "instantiated2HandCard44a"){
						
							
							GameObject card = Instantiate (cardModel44a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard44a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard44b"){
						
							
							GameObject card = Instantiate (cardModel44b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard44b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard44c"){
						
							
							GameObject card = Instantiate (cardModel44c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard44c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard45"){
						
							
							GameObject card = Instantiate (cardModel45, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard45";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard45a"){
						
							
							GameObject card = Instantiate (cardModel45a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard45a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard45b"){
						
							
							GameObject card = Instantiate (cardModel45b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard45b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard45c"){
						
							
							GameObject card = Instantiate (cardModel45c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard45c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard46"){
						
							
							GameObject card = Instantiate (cardModel46, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard46";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard46a"){
						
							
							GameObject card = Instantiate (cardModel46a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard46a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard46b"){
						
							
							GameObject card = Instantiate (cardModel46b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard46b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard46c"){
						
							
							GameObject card = Instantiate (cardModel46c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard46c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard47"){
						
							
							GameObject card = Instantiate (cardModel47, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard47";
							itemsToScroll.Add(card);
							
					}
					
					if(reference.name == "instantiated2HandCard47a"){
						
							
							GameObject card = Instantiate (cardModel47a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard47a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard47b"){
						
							
							GameObject card = Instantiate (cardModel47b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard47b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard47c"){
						
							
							GameObject card = Instantiate (cardModel47c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard47c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard48"){
						
							
							GameObject card = Instantiate (cardModel48, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard48";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard48a"){
						
							
							GameObject card = Instantiate (cardModel48a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard48a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard48b"){
						
							
							GameObject card = Instantiate (cardModel48b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard48b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard48c"){
						
							
							GameObject card = Instantiate (cardModel48c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard48c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard49"){
						
							
							GameObject card = Instantiate (cardModel49, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard49";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard49a"){
						
							
							GameObject card = Instantiate (cardModel49a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard49a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard49b"){
						
							
							GameObject card = Instantiate (cardModel49b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard49b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard49c"){
						
							
							GameObject card = Instantiate (cardModel49c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard49c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard50"){
						
							
							GameObject card = Instantiate (cardModel50, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard50";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard50a"){
						
							
							GameObject card = Instantiate (cardModel50a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard50a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard50b"){
						
							
							GameObject card = Instantiate (cardModel50b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard50b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard50c"){
						
							
							GameObject card = Instantiate (cardModel50c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard50c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard51"){
						
							
							GameObject card = Instantiate (cardModel51, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard51";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard51a"){
						
							
							GameObject card = Instantiate (cardModel51a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard51a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard51b"){
						
							
							GameObject card = Instantiate (cardModel51b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard51b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard51c"){
						
							
							GameObject card = Instantiate (cardModel51c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard51c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard52"){
						
							
							GameObject card = Instantiate (cardModel52, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard52";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard52a"){
						
							
							GameObject card = Instantiate (cardModel52a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard52a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard52b"){
						
							
							GameObject card = Instantiate (cardModel52b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard52b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard52c"){
						
							
							GameObject card = Instantiate (cardModel52c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard52c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard53"){
						
							
							GameObject card = Instantiate (cardModel53, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard53";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard53a"){
						
							
							GameObject card = Instantiate (cardModel53a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard53a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard53b"){
						
							
							GameObject card = Instantiate (cardModel53b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard53b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard53c"){
						
							
							GameObject card = Instantiate (cardModel53c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard53c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard54"){
						
							
							GameObject card = Instantiate (cardModel54, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard54";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard54a"){
						
							
							GameObject card = Instantiate (cardModel54a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard54a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard54b"){
						
							
							GameObject card = Instantiate (cardModel54b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard54b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard54c"){
						
							
							GameObject card = Instantiate (cardModel54c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard54c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard55"){
						
							
							GameObject card = Instantiate (cardModel55, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard55";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard55a"){
						
							
							GameObject card = Instantiate (cardModel55a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard55a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard55b"){
						
							
							GameObject card = Instantiate (cardModel55b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard55b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard55c"){
						
							
							GameObject card = Instantiate (cardModel55c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard55c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard56"){
						
							
							GameObject card = Instantiate (cardModel56, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard56";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard56a"){
						
							
							GameObject card = Instantiate (cardModel56a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard56a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard56b"){
						
							
							GameObject card = Instantiate (cardModel56b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard56b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard56c"){
						
							
							GameObject card = Instantiate (cardModel56c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard56c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard57"){
						
							
							GameObject card = Instantiate (cardModel57, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard57";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard57a"){
						
							
							GameObject card = Instantiate (cardModel57a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard57a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard57b"){
						
							
							GameObject card = Instantiate (cardModel57b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard57b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard57c"){
						
							
							GameObject card = Instantiate (cardModel57c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard57c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard58"){
						
							
							GameObject card = Instantiate (cardModel58, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard58";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard58a"){
						
							
							GameObject card = Instantiate (cardModel58a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard58a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard58b"){
						
							
							GameObject card = Instantiate (cardModel58b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard58b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard58c"){
						
							
							GameObject card = Instantiate (cardModel58c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard58c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard59"){
						
							
							GameObject card = Instantiate (cardModel59, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard59";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard59a"){
						
							
							GameObject card = Instantiate (cardModel59a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard59a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard59b"){
						
							
							GameObject card = Instantiate (cardModel59b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard59b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard59c"){
						
							
							GameObject card = Instantiate (cardModel59c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard59c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard60"){
						
							
							GameObject card = Instantiate (cardModel60, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard60";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard60a"){
						
							
							GameObject card = Instantiate (cardModel60a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard60a";
							itemsToScroll.Add(card);
					
					}	

					if(reference.name == "instantiated2HandCard60b"){
						
							
							GameObject card = Instantiate (cardModel60b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard60b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated2HandCard60c"){
						
							
							GameObject card = Instantiate (cardModel60c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated2ScrollCard60c";
							itemsToScroll.Add(card);
					
					}	

					
				}
				
			 
			 yield return new WaitForSeconds(2);
			 
			for(int i = 0; i < itemsToScroll.Count; i++){
						
				itemsToScroll[i].transform.localPosition = new Vector3(offset, 0, 0);
				offset += 6.0f;
						
			}
			
			bttnLength = itemsToScroll.Count;
			distance = new float[bttnLength];
			distReposition = new float[bttnLength];
			
			// Get distance between buttons
			bttnDistance  = (int)Mathf.Abs(itemsToScroll[1].GetComponent<Transform>().localPosition.x - itemsToScroll[0].GetComponent<Transform>().localPosition.x);
			
			//bttnLength = 240, bttnDistance = 10, 240 * 10 = 2400, 2400/2 = 1200
			scrollLimit = ((bttnLength * bttnDistance) / 2);
			
			//print("bttnLength" + bttnLength);
			//print("bttnDistance" + bttnDistance);
			
			yield return new WaitForSeconds(2);
			 
			isScrollCardModels = true;
		}
		
		
		 IEnumerator StartScrollStuffDeck3(){
			 
			 yield return new WaitForSeconds(1);
			 
			 for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
				
				grabbedHandDeck3Cards.Add(loadDeckCards3.getHandCardsDeck3[i]);
				
			}
			
			
			
			foreach(GameObject reference in grabbedHandDeck3Cards){
					
					if(reference.name == "instantiated3HandCard1"){
						
						GameObject card = Instantiate (cardModel1, spawnPoint, Quaternion.identity) as GameObject;
						//card.transform.localScale = new Vector3(325f,200f,340.0f);
						card.transform.parent = panel.transform;
						card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
						card.name = "instantiated3ScrollCard1";
						itemsToScroll.Add(card);
						
						
					
					}
					
					if(reference.name == "instantiated3HandCard1a"){
							
							GameObject card = Instantiate (cardModel1a, spawnPoint, Quaternion.identity) as GameObject;
							//card.transform.localScale = new Vector3(325f,200f,340.0f);
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard1a";
							itemsToScroll.Add(card);
							
							
					}
					
					if(reference.name == "instantiated3HandCard1b"){
						
							
							GameObject card = Instantiate (cardModel1b, spawnPoint, Quaternion.identity) as GameObject;
							//card.transform.localScale = new Vector3(325f,200f,340.0f);
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard1b";
							itemsToScroll.Add(card);
							
						
					}
					
					if(reference.name == "instantiated3HandCard1c"){
						
							
							GameObject card = Instantiate (cardModel1c, spawnPoint, Quaternion.identity) as GameObject;
							//card.transform.localScale = new Vector3(325f,200f,340.0f);
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard1c";
							itemsToScroll.Add(card);
							
						
					}
					
					if(reference.name == "instantiated3HandCard2"){
						
							
							GameObject card = Instantiate (cardModel2, spawnPoint, Quaternion.identity) as GameObject;
							//card.transform.localScale = new Vector3(325f,200f,340.0f);
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard2";
							itemsToScroll.Add(card);
						
					}
					
					if(reference.name == "instantiated3HandCard2a"){
						
							
							GameObject card = Instantiate (cardModel2a, spawnPoint, Quaternion.identity) as GameObject;
							//card.transform.localScale = new Vector3(325f,200f,340.0f);
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard2a";
							itemsToScroll.Add(card);
							
						
					}
					
					if(reference.name == "instantiated3HandCard2b"){
						
							
							GameObject card = Instantiate (cardModel2b, spawnPoint, Quaternion.identity) as GameObject;
							//card.transform.localScale = new Vector3(325f,200f,340.0f);
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard2b";
							itemsToScroll.Add(card);
							
					
					}
					
					if(reference.name == "instantiated3HandCard2c"){
						
							
							GameObject card = Instantiate (cardModel2c, spawnPoint, Quaternion.identity) as GameObject;
							//card.transform.localScale = new Vector3(325f,200f,340.0f);
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard2c";
							itemsToScroll.Add(card);
							
					
					}
					
					if(reference.name == "instantiated3HandCard3"){
						
							
							GameObject card = Instantiate (cardModel3, spawnPoint, Quaternion.identity) as GameObject;
							//card.transform.localScale = new Vector3(325f,200f,340.0f);
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard3";
							itemsToScroll.Add(card);
							
					
					}
					
					if(reference.name == "instantiated3HandCard3a"){
						
							
							GameObject card = Instantiate (cardModel3a, spawnPoint, Quaternion.identity) as GameObject;
							//card.transform.localScale = new Vector3(325f,200f,340.0f);
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard3a";
							itemsToScroll.Add(card);
							
					
					}
					
					if(reference.name == "instantiated3HandCard3b"){
						
							
							GameObject card = Instantiate (cardModel3b, spawnPoint, Quaternion.identity) as GameObject;
							//card.transform.localScale = new Vector3(325f,200f,340.0f);
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard3b";
							itemsToScroll.Add(card);
							
					
					}
					
					if(reference.name == "instantiated3HandCard3c"){
						
							
							GameObject card = Instantiate (cardModel3c, spawnPoint, Quaternion.identity) as GameObject;
							//card.transform.localScale = new Vector3(325f,200f,340.0f);
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard3c";
							itemsToScroll.Add(card);
							
					
					}
					
					if(reference.name == "instantiated3HandCard4"){
						
							
							GameObject card = Instantiate (cardModel4, spawnPoint, Quaternion.identity) as GameObject;
							//card.transform.localScale = new Vector3(325f,200f,340.0f);
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard4";
							itemsToScroll.Add(card);
							
					
					}
					
					if(reference.name == "instantiated3HandCard4a"){
						
							
							GameObject card = Instantiate (cardModel4a, spawnPoint, Quaternion.identity) as GameObject;
							//card.transform.localScale = new Vector3(325f,200f,340.0f);
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard4a";
							itemsToScroll.Add(card);
							
					
					}
					
					if(reference.name == "instantiated3HandCard4b"){
						
							
							GameObject card = Instantiate (cardModel4b, spawnPoint, Quaternion.identity) as GameObject;
							//card.transform.localScale = new Vector3(325f,200f,340.0f);
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard4b";
							itemsToScroll.Add(card);
							
					
					}
					
					if(reference.name == "instantiated3HandCard4c"){
						
							
							GameObject card = Instantiate (cardModel4c, spawnPoint, Quaternion.identity) as GameObject;
							//card.transform.localScale = new Vector3(325f,200f,340.0f);
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard4c";
							itemsToScroll.Add(card);
							
					
					}
					
					if(reference.name == "instantiated3HandCard5"){
						
							
							GameObject card = Instantiate (cardModel5, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard5";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard5a"){
						
							
							GameObject card = Instantiate (cardModel5a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard5a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard5b"){
						
							
							GameObject card = Instantiate (cardModel5b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard5b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard5c"){
						
							
							GameObject card = Instantiate (cardModel5c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard5c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard6"){
						
							
							GameObject card = Instantiate (cardModel6, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard6";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard6a"){
						
							
							GameObject card = Instantiate (cardModel6a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard6a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard6b"){
						
							
							GameObject card = Instantiate (cardModel6b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard6b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard6c"){
						
							
							GameObject card = Instantiate (cardModel6c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard6c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard7"){
						
							
							GameObject card = Instantiate (cardModel7, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard7";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard7a"){
						
							
							GameObject card = Instantiate (cardModel7a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard7a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard7b"){
						
							
							GameObject card = Instantiate (cardModel7b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard7b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard7c"){
						
							
							GameObject card = Instantiate (cardModel7c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard7c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard8"){
						
							
							GameObject card = Instantiate (cardModel8, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard8";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard8a"){
						
							
							GameObject card = Instantiate (cardModel8a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard8a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard8b"){
						
							
							GameObject card = Instantiate (cardModel8b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard8b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard8c"){
						
							
							GameObject card = Instantiate (cardModel8c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard8c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard9"){
						
							
							GameObject card = Instantiate (cardModel9, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard9";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard9a"){
						
							
							GameObject card = Instantiate (cardModel9a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard9a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard9b"){
						
							
							GameObject card = Instantiate (cardModel9b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard9b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard9c"){
						
							
							GameObject card = Instantiate (cardModel9c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard9c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard10"){
						
							
							GameObject card = Instantiate (cardModel10, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard10";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard10a"){
						
							
							GameObject card = Instantiate (cardModel10a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard10a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard10b"){
						
							
							GameObject card = Instantiate (cardModel10b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard10b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard10c"){
						
							
							GameObject card = Instantiate (cardModel10c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard10c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard11"){
						
							
							GameObject card = Instantiate (cardModel11, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard11";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard11a"){
						
							
							GameObject card = Instantiate (cardModel11a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard11a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard11b"){
						
							
							GameObject card = Instantiate (cardModel11b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard11b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard11c"){
						
							
							GameObject card = Instantiate (cardModel11c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard11c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard12"){
						
							
							GameObject card = Instantiate (cardModel12, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard12";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard12a"){
						
							
							GameObject card = Instantiate (cardModel12a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard12a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard12b"){
						
							
							GameObject card = Instantiate (cardModel12b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard12b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard12c"){
						
							
							GameObject card = Instantiate (cardModel12c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard12c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard13"){
						
							
							GameObject card = Instantiate (cardModel13, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard13";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard13a"){
						
							
							GameObject card = Instantiate (cardModel13a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard13a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard13b"){
						
							
							GameObject card = Instantiate (cardModel13b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard13b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard13c"){
						
							
							GameObject card = Instantiate (cardModel13c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard13c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard14"){
						
							
							GameObject card = Instantiate (cardModel14, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard14";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard14a"){
						
							
							GameObject card = Instantiate (cardModel14a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard14a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard14b"){
						
							
							GameObject card = Instantiate (cardModel14b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard14b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard14c"){
						
							
							GameObject card = Instantiate (cardModel14c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard14c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard15"){
					
							
							GameObject card = Instantiate (cardModel15, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard15";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard15a"){
						
							
							GameObject card = Instantiate (cardModel15a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard15a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard15b"){
						
							
							GameObject card = Instantiate (cardModel15b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard15b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard15c"){
						
							
							GameObject card = Instantiate (cardModel15c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard15c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard16"){
						
							
							GameObject card = Instantiate (cardModel16, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard16";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard16a"){
						
							
							GameObject card = Instantiate (cardModel16a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard16a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard16b"){
						
							
							GameObject card = Instantiate (cardModel16b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard16b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard16c"){
						
							
							GameObject card = Instantiate (cardModel16c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard16c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard17"){
						
							
							GameObject card = Instantiate (cardModel17, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard17";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard17a"){
						
							
							GameObject card = Instantiate (cardModel17a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard17a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard17b"){
						
							
							GameObject card = Instantiate (cardModel17b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard17b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard17c"){
						
							
							GameObject card = Instantiate (cardModel17c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard17c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard18"){
						
							
							GameObject card = Instantiate (cardModel18, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard18";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard18a"){
						
							
							GameObject card = Instantiate (cardModel18a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard18a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard18b"){
						
							
							GameObject card = Instantiate (cardModel18b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard18b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard18c"){
						
							
							GameObject card = Instantiate (cardModel18c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard18c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard19"){
						
							
							GameObject card = Instantiate (cardModel19, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard19";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard19a"){
						
							
							GameObject card = Instantiate (cardModel19a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard19a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard19b"){
						
							
							GameObject card = Instantiate (cardModel19b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard19b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard19c"){
						
							
							GameObject card = Instantiate (cardModel19c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard19c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard20"){
						
							
							GameObject card = Instantiate (cardModel20, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard20";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard20a"){
						
							
							GameObject card = Instantiate (cardModel20a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard20a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard20b"){
						
							
							GameObject card = Instantiate (cardModel20b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard20b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard20c"){
						
							
							GameObject card = Instantiate (cardModel20c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard20c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard21"){
						
							
							GameObject card = Instantiate (cardModel21, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard21";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard21a"){
						
							
							GameObject card = Instantiate (cardModel21a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard21a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard21b"){
						
							
							GameObject card = Instantiate (cardModel21b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard21b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard21c"){
						
							
							GameObject card = Instantiate (cardModel21c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard21c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard22"){
						
							
							GameObject card = Instantiate (cardModel22, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard22";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard22a"){
						
							
							GameObject card = Instantiate (cardModel22a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard22a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard22b"){
						
							
							GameObject card = Instantiate (cardModel22b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard22b";
							itemsToScroll.Add(card);
						
					}
					
					if(reference.name == "instantiated3HandCard22c"){
						
							
							GameObject card = Instantiate (cardModel22c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard22c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard23"){
						
							
							GameObject card = Instantiate (cardModel23, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard23";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard23a"){
						
							
							GameObject card = Instantiate (cardModel23a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard23a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard23b"){
						
							
							GameObject card = Instantiate (cardModel23b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard23b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard23c"){
						
							
							GameObject card = Instantiate (cardModel23c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard23c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard24"){
						
							
							GameObject card = Instantiate (cardModel24, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard24";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard24a"){
						
							
							GameObject card = Instantiate (cardModel24a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard24a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard24b"){
						
							
							GameObject card = Instantiate (cardModel24b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard24b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard24c"){
						
							
							GameObject card = Instantiate (cardModel24c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard24c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard25"){
						
							
							GameObject card = Instantiate (cardModel25, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard25";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard25a"){
						
							
							GameObject card = Instantiate (cardModel25a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard25a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard25b"){
						
							
							GameObject card = Instantiate (cardModel25b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard25b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard25c"){
						
							
							GameObject card = Instantiate (cardModel25c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard25c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard26"){
						
							
							GameObject card = Instantiate (cardModel26, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard26";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard26a"){
						
							
							GameObject card = Instantiate (cardModel26a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard26a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard26b"){
						
							
							GameObject card = Instantiate (cardModel26b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard26b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard26c"){
						
							
							GameObject card = Instantiate (cardModel26c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard26c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard27"){
						
							
							GameObject card = Instantiate (cardModel27, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard27";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard27a"){
						
							
							GameObject card = Instantiate (cardModel27a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard27a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard27b"){
						
							
							GameObject card = Instantiate (cardModel27b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard27b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard27c"){
						
							
							GameObject card = Instantiate (cardModel27c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard27c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard28"){
						
							
							GameObject card = Instantiate (cardModel28, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard28";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard28a"){
						
							
							GameObject card = Instantiate (cardModel28a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard28a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard28b"){
						
							
							GameObject card = Instantiate (cardModel28b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard28b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard28c"){
						
							
							GameObject card = Instantiate (cardModel28c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard28c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard29"){
						
							
							GameObject card = Instantiate (cardModel29, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard29";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard29a"){
						
							
							GameObject card = Instantiate (cardModel29a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard29a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard29b"){
						
							
							GameObject card = Instantiate (cardModel29b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard29b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard29c"){
						
							
							GameObject card = Instantiate (cardModel29c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard29c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard30"){
					
							
							GameObject card = Instantiate (cardModel30, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard30";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard30a"){
						
							
							GameObject card = Instantiate (cardModel30a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard30a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard30b"){
						
							
							GameObject card = Instantiate (cardModel30b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard30b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard30c"){
						
							
							GameObject card = Instantiate (cardModel30c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard30c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard31"){
						
							
							GameObject card = Instantiate (cardModel31, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard31";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard31a"){
						
							
							GameObject card = Instantiate (cardModel31a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard31a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard31b"){
						
							
							GameObject card = Instantiate (cardModel31b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard31b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard31c"){
						
							
							GameObject card = Instantiate (cardModel31c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard31c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard32"){
					
							
							GameObject card = Instantiate (cardModel32, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard32";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard32a"){
					
							
							GameObject card = Instantiate (cardModel32a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard32a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard32b"){
						
							
							GameObject card = Instantiate (cardModel32b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard32b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard32c"){
						
							
							GameObject card = Instantiate (cardModel32c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard32c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard33"){
						
							
							GameObject card = Instantiate (cardModel33, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard33";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard33a"){
						
							
							GameObject card = Instantiate (cardModel33a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard33a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard33b"){
						
							
							GameObject card = Instantiate (cardModel33b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard33b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard33c"){
						
							
							GameObject card = Instantiate (cardModel33c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard33c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard34"){
						
							
							GameObject card = Instantiate (cardModel34, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard34";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard34a"){
						
							
							GameObject card = Instantiate (cardModel34a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard34a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard34b"){
						
							
							GameObject card = Instantiate (cardModel34b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard34b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard34c"){
						
							
							GameObject card = Instantiate (cardModel34c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard34c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard35"){
						
							
							GameObject card = Instantiate (cardModel35, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard35";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard35a"){
						
							
							GameObject card = Instantiate (cardModel35a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard35a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard35b"){
						
							
							GameObject card = Instantiate (cardModel35b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard35b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard35c"){
						
							
							GameObject card = Instantiate (cardModel35c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard35c";
							itemsToScroll.Add(card);
					}
					
					if(reference.name == "instantiated3HandCard36"){
						
							
							GameObject card = Instantiate (cardModel36, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard36";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard36a"){
						
							
							GameObject card = Instantiate (cardModel36a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard36a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard36b"){
						
							
							GameObject card = Instantiate (cardModel36b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard36b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard36c"){
						
							
							GameObject card = Instantiate (cardModel36c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard36c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard37"){
						
							
							GameObject card = Instantiate (cardModel37, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard37";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard37a"){
						
							
							GameObject card = Instantiate (cardModel37a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard37a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard37b"){
						
							
							GameObject card = Instantiate (cardModel37b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard37b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard37c"){
						
							
							GameObject card = Instantiate (cardModel37c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard37c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard38"){
						
							
							GameObject card = Instantiate (cardModel38, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard38";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard38a"){
						
							
							GameObject card = Instantiate (cardModel38a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard38a";
							itemsToScroll.Add(card);
							
					
					}
					
					if(reference.name == "instantiated3HandCard38b"){
						
							
							GameObject card = Instantiate (cardModel38b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard38b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard38c"){
						
							
							GameObject card = Instantiate (cardModel38c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard38c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard39"){
						
							
							GameObject card = Instantiate (cardModel39, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard39";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard39a"){
						
							
							GameObject card = Instantiate (cardModel39a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard39a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard39b"){
						
							
							GameObject card = Instantiate (cardModel39b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard39b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard39c"){
						
							
							GameObject card = Instantiate (cardModel39c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard39c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard40"){
						
							
							GameObject card = Instantiate (cardModel40, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard40";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard40a"){
						
							
							GameObject card = Instantiate (cardModel40a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard40a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard40b"){
						
							
							GameObject card = Instantiate (cardModel40b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard40b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard40c"){
						
							
							GameObject card = Instantiate (cardModel40c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard40c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard41"){
						
							
							GameObject card = Instantiate (cardModel41, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard41";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard41a"){
						
							
							GameObject card = Instantiate (cardModel41a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard41a";
							itemsToScroll.Add(card);
							
					
					}
					
					if(reference.name == "instantiated3HandCard41b"){
						
							
							GameObject card = Instantiate (cardModel41b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard41b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard41c"){
						
							
							GameObject card = Instantiate (cardModel41c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard41c";
							itemsToScroll.Add(card);
							
					
					}
					
					if(reference.name == "instantiated3HandCard42"){
						
							
							GameObject card = Instantiate (cardModel42, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard42";
							itemsToScroll.Add(card);
							
					
					}
					
					if(reference.name == "instantiated3HandCard42a"){
						
							
							GameObject card = Instantiate (cardModel42a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard42a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard42b"){
						
							
							GameObject card = Instantiate (cardModel42b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard42b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard42c"){
						
							
							GameObject card = Instantiate (cardModel42c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard42c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard43"){
						
							
							GameObject card = Instantiate (cardModel43, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard43";
							itemsToScroll.Add(card);
							
					
					}
					
					if(reference.name == "instantiated3HandCard43a"){
						
							
							GameObject card = Instantiate (cardModel43a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard43a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard43b"){
						
							
							GameObject card = Instantiate (cardModel43b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard43b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard43c"){
						
							
							GameObject card = Instantiate (cardModel43c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard43c";
							itemsToScroll.Add(card);
							
					
					}
					
					if(reference.name == "instantiated3HandCard44"){
						
							
							GameObject card = Instantiate (cardModel44, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard44";
							itemsToScroll.Add(card);
							
					
					}
					
					if(reference.name == "instantiated3HandCard44a"){
						
							
							GameObject card = Instantiate (cardModel44a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard44a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard44b"){
						
							
							GameObject card = Instantiate (cardModel44b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard44b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard44c"){
						
							
							GameObject card = Instantiate (cardModel44c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard44c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard45"){
						
							
							GameObject card = Instantiate (cardModel45, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard45";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard45a"){
						
							
							GameObject card = Instantiate (cardModel45a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard45a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard45b"){
						
							
							GameObject card = Instantiate (cardModel45b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard45b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard45c"){
						
							
							GameObject card = Instantiate (cardModel45c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard45c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard46"){
						
							
							GameObject card = Instantiate (cardModel46, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard46";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard46a"){
						
							
							GameObject card = Instantiate (cardModel46a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard46a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard46b"){
						
							
							GameObject card = Instantiate (cardModel46b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard46b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard46c"){
						
							
							GameObject card = Instantiate (cardModel46c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard46c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard47"){
						
							
							GameObject card = Instantiate (cardModel47, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard47";
							itemsToScroll.Add(card);
							
					}
					
					if(reference.name == "instantiated3HandCard47a"){
						
							
							GameObject card = Instantiate (cardModel47a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard47a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard47b"){
						
							
							GameObject card = Instantiate (cardModel47b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard47b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard47c"){
						
							
							GameObject card = Instantiate (cardModel47c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard47c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard48"){
						
							
							GameObject card = Instantiate (cardModel48, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard48";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard48a"){
						
							
							GameObject card = Instantiate (cardModel48a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard48a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard48b"){
						
							
							GameObject card = Instantiate (cardModel48b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard48b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard48c"){
						
							
							GameObject card = Instantiate (cardModel48c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard48c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard49"){
						
							
							GameObject card = Instantiate (cardModel49, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard49";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard49a"){
						
							
							GameObject card = Instantiate (cardModel49a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard49a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard49b"){
						
							
							GameObject card = Instantiate (cardModel49b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard49b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard49c"){
						
							
							GameObject card = Instantiate (cardModel49c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard49c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard50"){
						
							
							GameObject card = Instantiate (cardModel50, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard50";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard50a"){
						
							
							GameObject card = Instantiate (cardModel50a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard50a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard50b"){
						
							
							GameObject card = Instantiate (cardModel50b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard50b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard50c"){
						
							
							GameObject card = Instantiate (cardModel50c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard50c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard51"){
						
							
							GameObject card = Instantiate (cardModel51, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard51";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard51a"){
						
							
							GameObject card = Instantiate (cardModel51a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard51a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard51b"){
						
							
							GameObject card = Instantiate (cardModel51b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard51b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard51c"){
						
							
							GameObject card = Instantiate (cardModel51c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard51c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard52"){
						
							
							GameObject card = Instantiate (cardModel52, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard52";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard52a"){
						
							
							GameObject card = Instantiate (cardModel52a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard52a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard52b"){
						
							
							GameObject card = Instantiate (cardModel52b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard52b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard52c"){
						
							
							GameObject card = Instantiate (cardModel52c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard52c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard53"){
						
							
							GameObject card = Instantiate (cardModel53, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard53";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard53a"){
						
							
							GameObject card = Instantiate (cardModel53a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard53a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard53b"){
						
							
							GameObject card = Instantiate (cardModel53b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard53b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard53c"){
						
							
							GameObject card = Instantiate (cardModel53c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard53c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard54"){
						
							
							GameObject card = Instantiate (cardModel54, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard54";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard54a"){
						
							
							GameObject card = Instantiate (cardModel54a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard54a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard54b"){
						
							
							GameObject card = Instantiate (cardModel54b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard54b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard54c"){
						
							
							GameObject card = Instantiate (cardModel54c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard54c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard55"){
						
							
							GameObject card = Instantiate (cardModel55, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard55";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard55a"){
						
							
							GameObject card = Instantiate (cardModel55a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard55a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard55b"){
						
							
							GameObject card = Instantiate (cardModel55b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard55b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard55c"){
						
							
							GameObject card = Instantiate (cardModel55c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard55c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard56"){
						
							
							GameObject card = Instantiate (cardModel56, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard56";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard56a"){
						
							
							GameObject card = Instantiate (cardModel56a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard56a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard56b"){
						
							
							GameObject card = Instantiate (cardModel56b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard56b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard56c"){
						
							
							GameObject card = Instantiate (cardModel56c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard56c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard57"){
						
							
							GameObject card = Instantiate (cardModel57, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard57";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard57a"){
						
							
							GameObject card = Instantiate (cardModel57a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard57a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard57b"){
						
							
							GameObject card = Instantiate (cardModel57b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard57b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard57c"){
						
							
							GameObject card = Instantiate (cardModel57c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard57c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard58"){
						
							
							GameObject card = Instantiate (cardModel58, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard58";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard58a"){
						
							
							GameObject card = Instantiate (cardModel58a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard58a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard58b"){
						
							
							GameObject card = Instantiate (cardModel58b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard58b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard58c"){
						
							
							GameObject card = Instantiate (cardModel58c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard58c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard59"){
						
							
							GameObject card = Instantiate (cardModel59, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard59";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard59a"){
						
							
							GameObject card = Instantiate (cardModel59a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard59a";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard59b"){
						
							
							GameObject card = Instantiate (cardModel59b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard59b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard59c"){
						
							
							GameObject card = Instantiate (cardModel59c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard59c";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard60"){
						
							
							GameObject card = Instantiate (cardModel60, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard60";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard60a"){
						
							
							GameObject card = Instantiate (cardModel60a, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard60a";
							itemsToScroll.Add(card);
					
					}	

					if(reference.name == "instantiated3HandCard60b"){
						
							
							GameObject card = Instantiate (cardModel60b, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard60b";
							itemsToScroll.Add(card);
					
					}
					
					if(reference.name == "instantiated3HandCard60c"){
						
							
							GameObject card = Instantiate (cardModel60c, spawnPoint, Quaternion.identity) as GameObject;
							card.transform.parent = panel.transform;
							card.transform.localScale = new Vector3(1025.0f,200.0f,1040.0f);
							card.name = "instantiated3ScrollCard60c";
							itemsToScroll.Add(card);
					
					}	

					
				}
				
			 
			 yield return new WaitForSeconds(2);
			 
			for(int i = 0; i < itemsToScroll.Count; i++){
						
				itemsToScroll[i].transform.localPosition = new Vector3(offset, 0, 0);
				offset += 6.0f;
						
			}
			
			bttnLength = itemsToScroll.Count;
			distance = new float[bttnLength];
			distReposition = new float[bttnLength];
			
			// Get distance between buttons
			bttnDistance  = (int)Mathf.Abs(itemsToScroll[1].GetComponent<Transform>().localPosition.x - itemsToScroll[0].GetComponent<Transform>().localPosition.x);
			
			//bttnLength = 240, bttnDistance = 10, 240 * 10 = 2400, 2400/2 = 1200
			scrollLimit = ((bttnLength * bttnDistance) / 2);
			
			//print("bttnLength" + bttnLength);
			//print("bttnDistance" + bttnDistance);
			
			yield return new WaitForSeconds(2);
			 
			isScrollCardModels = true;
		}
		
		
		
		
		public void StartMulligan(){
			
			mulliganInfo.SetActive(false);
			handCardCollection.SetActive(true);
			
			if(loadDeckCards1.isScrollDeck1){
				StartCoroutine(StartScrollStuffDeck1());
			}else if(loadDeckCards2.isScrollDeck2){
				StartCoroutine(StartScrollStuffDeck2());
			}else if(loadDeckCards3.isScrollDeck3){
				StartCoroutine(StartScrollStuffDeck3());
			}
			
			
			
			
			
			
			
		}
		
		public void StopMulligan(){
			
			mulliganInfo.SetActive(false);
			
			
		}
		
	}

}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

namespace Caerwent{

	public class CircularScrollCardsTest1 : MonoBehaviour {

		public static int curCard;
		private int currentCard;
		private Vector3 normalCard = new Vector3(325.0f,100.0f,340.0f);
		private Vector3 previewCard = new Vector3(1025.0f,200.0f,1040.0f);
		private Vector3 centerPosition = new Vector3(0,0,0);
		
		// Public Variables
		public RectTransform panel;	// To hold the ScrollPanel
		public RectTransform center;	// Center to compare the distance for each button
		public List<GameObject> itemsToScroll = new List<GameObject>();
		
		// Private Variables
		public float[] distance;	// All buttons' distance to the center
		public float[] distReposition;
		private bool dragging = false;	// Will be true, while we drag the panel
		private int bttnDistance;	// Will hold the distance between the buttons
		private int minButtonNum;	// To hold the number of the button, with smallest distance to center
		private int bttnLength;
		private int scrollLimit;
		private float speed = 100;
		
		private GameObject[] allObjects;
		public List<GameObject> orderCards = new List<GameObject>();
		float offset = 10.0f;
		int j;
		
		static float posXLeft = 0.0f;
		static float posYLeft = 0.0f;
		static float posZLeft = 0.0f;
		static float posXRight = 0.0f;
		static float posYRight = 0.0f;
		static float posZRight = 0.0f;
		
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
		
		 
		 void Awake(){
			
			
			
			
			
		}
	 
		 // Use this for initialization
		 void Start () {
			 //curCard = 0;
			
			
			
			
			
			
		 }
		 
		 // Update is called once per frame
		 void Update () {
			 if(Input.GetKeyDown(KeyCode.U)){
				
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
					 
				itemsToScroll.Insert(0, cardModel1);
				itemsToScroll.Insert(1, cardModel1a);
				itemsToScroll.Insert(2, cardModel1b);
				itemsToScroll.Insert(3, cardModel1c);
				itemsToScroll.Insert(4, cardModel2);
				itemsToScroll.Insert(5, cardModel2a);
				itemsToScroll.Insert(6, cardModel2b);
				itemsToScroll.Insert(7, cardModel2c);
				itemsToScroll.Insert(8, cardModel3);
				itemsToScroll.Insert(9, cardModel3a);
				itemsToScroll.Insert(10, cardModel3b);
				itemsToScroll.Insert(11, cardModel3c);
					
				for(int i = 0; i < itemsToScroll.Count; i++){
							
					itemsToScroll[i].transform.localPosition = new Vector3(offset, 0, 0);
					offset += 15.0f;
				}			
			
				
				bttnLength = itemsToScroll.Count;
				distance = new float[bttnLength];
				distReposition = new float[bttnLength];
				
				// Get distance between buttons
				bttnDistance  = (int)Mathf.Abs(itemsToScroll[1].GetComponent<Transform>().localPosition.x - itemsToScroll[0].GetComponent<Transform>().localPosition.x);
				
				//bttnLength = 240, bttnDistance = 10, 240 * 10 = 2400, 2400/2 = 1200
				scrollLimit = ((bttnLength * bttnDistance) / 2);
				 
			}
			 
				
				 
				 
		
			 
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
		 
		 
		 
		void LerpToBttn(float position){
			float newX = Mathf.Lerp (panel.localPosition.x, position, Time.deltaTime * 5.0f);
			Vector3 newPosition = new Vector3 (newX, panel.localPosition.y, panel.localPosition.z);

			panel.localPosition = newPosition;
		}

		public void StartDrag(){
			dragging = true;
		}

		public void EndDrag(){
			dragging = false;
		}
	}

}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

namespace Caerwent{

public class ScrollRectSnap_CS : MonoBehaviour 
{
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
	
	
	private GameObject card1;
	private GameObject card2;
	private GameObject card3;
	private GameObject card4;
	private GameObject card5;
	private GameObject card6;
	private GameObject card7;
	private GameObject card8;
	private GameObject card9;
	private GameObject card10;
	private GameObject card11;
	private GameObject card12;
	private GameObject card13;
	private GameObject card14;
	private GameObject card15;
	private GameObject card16;
	private GameObject card17;
	private GameObject card18;
	private GameObject card19;
	private GameObject card20;
	private GameObject card21;
	private GameObject card22;
	private GameObject card23;
	private GameObject card24;
	private GameObject card25;
	private GameObject card26;
	private GameObject card27;
	private GameObject card28;
	private GameObject card29;
	private GameObject card30;
	private GameObject card31;
	private GameObject card32;
	private GameObject card33;
	private GameObject card34;
	private GameObject card35;
	private GameObject card36;
	private GameObject card37;
	private GameObject card38;
	private GameObject card39;
	private GameObject card40;
	private GameObject card41;
	private GameObject card42;
	private GameObject card43;
	private GameObject card44;
	private GameObject card45;
	private GameObject card46;
	private GameObject card47;
	private GameObject card48;
	private GameObject card49;
	private GameObject card50;
	private GameObject card51;
	private GameObject card52;
	private GameObject card53;
	private GameObject card54;
	private GameObject card55;
	private GameObject card56;
	private GameObject card57;
	private GameObject card58;
	private GameObject card59;
	private GameObject card60;
	
	void Awake(){
		card1 = GameObject.Find("Card1");
		card2 = GameObject.Find("Card2");
		card3 = GameObject.Find("Card3");
		card4 = GameObject.Find("Card4");
		card5 = GameObject.Find("Card5");
		card6 = GameObject.Find("Card6");
		card7 = GameObject.Find("Card7");
		card8 = GameObject.Find("Card8");
		card9 = GameObject.Find("Card9");
		card10 = GameObject.Find("Card10");
		card11 = GameObject.Find("Card11");
		card12 = GameObject.Find("Card12");
		card13 = GameObject.Find("Card13");
		card14 = GameObject.Find("Card14");
		card15 = GameObject.Find("Card15");
		card16 = GameObject.Find("Card16");
		card17 = GameObject.Find("Card17");
		card18 = GameObject.Find("Card18");
		card19 = GameObject.Find("Card19");
		card20 = GameObject.Find("Card20");
		card21 = GameObject.Find("Card21");
		card22 = GameObject.Find("Card22");
		card23 = GameObject.Find("Card23");
		card24 = GameObject.Find("Card24");
		card25 = GameObject.Find("Card25");
		card26 = GameObject.Find("Card26");
		card27 = GameObject.Find("Card27");
		card28 = GameObject.Find("Card28");
		card29 = GameObject.Find("Card29");
		card30 = GameObject.Find("Card30");
		card31 = GameObject.Find("Card31");
		card32 = GameObject.Find("Card32");
		card33 = GameObject.Find("Card33");
		card34 = GameObject.Find("Card34");
		card35 = GameObject.Find("Card35");
		card36 = GameObject.Find("Card36");
		card37 = GameObject.Find("Card37");
		card38 = GameObject.Find("Card38");
		card39 = GameObject.Find("Card39");
		card40 = GameObject.Find("Card40");
		card41 = GameObject.Find("Card41");
		card42 = GameObject.Find("Card42");
		card43 = GameObject.Find("Card43");
		card44 = GameObject.Find("Card44");
		card45 = GameObject.Find("Card45");
		card46 = GameObject.Find("Card46");
		card47 = GameObject.Find("Card47");
		card48 = GameObject.Find("Card48");
		card49 = GameObject.Find("Card49");
		card50 = GameObject.Find("Card50");
		card51 = GameObject.Find("Card51");
		card52 = GameObject.Find("Card52");
		card53 = GameObject.Find("Card53");
		card54 = GameObject.Find("Card54");
		card55 = GameObject.Find("Card55");
		card56 = GameObject.Find("Card56");
		card57 = GameObject.Find("Card57");
		card58 = GameObject.Find("Card58");
		card59 = GameObject.Find("Card59");
		card60 = GameObject.Find("Card60");
		
	}

	void Start(){
		
		itemsToScroll.Insert(0, card1);
		itemsToScroll.Insert(1, card2);
		itemsToScroll.Insert(2, card3);
		itemsToScroll.Insert(3, card4);
		itemsToScroll.Insert(4, card5);
		itemsToScroll.Insert(5, card6);
		itemsToScroll.Insert(6, card7);
		itemsToScroll.Insert(7, card8);
		itemsToScroll.Insert(8, card9);
		itemsToScroll.Insert(9, card10);
		itemsToScroll.Insert(10, card11);
		itemsToScroll.Insert(11, card12);
		itemsToScroll.Insert(12, card13);
		itemsToScroll.Insert(13, card14);
		itemsToScroll.Insert(14, card15);
		itemsToScroll.Insert(15, card16);
		itemsToScroll.Insert(16, card17);
		itemsToScroll.Insert(17, card18);
		itemsToScroll.Insert(18, card19);
		itemsToScroll.Insert(19, card20);
		itemsToScroll.Insert(20, card21);
		itemsToScroll.Insert(21, card22);
		itemsToScroll.Insert(22, card23);
		itemsToScroll.Insert(23, card24);
		itemsToScroll.Insert(24, card25);
		itemsToScroll.Insert(25, card26);
		itemsToScroll.Insert(26, card27);
		itemsToScroll.Insert(27, card28);
		itemsToScroll.Insert(28, card29);
		itemsToScroll.Insert(29, card30);
		itemsToScroll.Insert(30, card31);
		itemsToScroll.Insert(31, card32);
		itemsToScroll.Insert(32, card33);
		itemsToScroll.Insert(33, card34);
		itemsToScroll.Insert(34, card35);
		itemsToScroll.Insert(35, card36);
		itemsToScroll.Insert(36, card37);
		itemsToScroll.Insert(37, card38);
		itemsToScroll.Insert(38, card39);
		itemsToScroll.Insert(39, card40);
		itemsToScroll.Insert(40, card41);
		itemsToScroll.Insert(41, card42);
		itemsToScroll.Insert(42, card43);
		itemsToScroll.Insert(43, card44);
		itemsToScroll.Insert(44, card45);
		itemsToScroll.Insert(45, card46);
		itemsToScroll.Insert(46, card47);
		itemsToScroll.Insert(47, card48);
		itemsToScroll.Insert(48, card49);
		itemsToScroll.Insert(49, card50);
		itemsToScroll.Insert(50, card51);
		itemsToScroll.Insert(51, card52);
		itemsToScroll.Insert(52, card53);
		itemsToScroll.Insert(53, card54);
		itemsToScroll.Insert(54, card55);
		itemsToScroll.Insert(55, card56);
		itemsToScroll.Insert(56, card57);
		itemsToScroll.Insert(57, card58);
		itemsToScroll.Insert(58, card59);
		itemsToScroll.Insert(59, card60);
		
		//Debug.Log(itemsToScroll.Count);
		bttnLength = itemsToScroll.Count;
		distance = new float[bttnLength];
		distReposition = new float[bttnLength];
		//Debug.Log(distance); //Single[]
		//Debug.Log(distReposition); //Single[]

		// Get distance between buttons
		bttnDistance  = (int)Mathf.Abs(itemsToScroll[1].GetComponent<Transform>().localPosition.x - itemsToScroll[0].GetComponent<Transform>().localPosition.x);
		Debug.Log(bttnDistance);
		Debug.Log(bttnLength);		//2
	}

	void Update(){
		for (int i = 0; i < itemsToScroll.Count; i++){
			//if(center && itemsToScroll){
				distReposition[i] = center.GetComponent<Transform>().position.x - itemsToScroll[i].GetComponent<Transform>().position.x;
			distance[i] = Mathf.Abs(distReposition[i]);
			//}
			

			if (distReposition[i] > 60){ //if distReposition is greater than 180 from the center
				float curX = itemsToScroll[i].GetComponent<Transform>().localPosition.x;
				float curY = itemsToScroll[i].GetComponent<Transform>().localPosition.y;
				float curZ = itemsToScroll[i].GetComponent<Transform>().localPosition.z;
//bttnLength * bttnDistance
				Vector3 newLocalPos = new Vector3 (curX + (bttnLength * bttnDistance), curY, curZ); //bttnLength = 60, bttnDistance = 2, 60 * 2 = 120
				itemsToScroll[i].GetComponent<Transform>().localPosition = newLocalPos;
			}

			if (distReposition[i] < -60){ //if distReposition is lesser than 180 from the center
				float curX = itemsToScroll[i].GetComponent<Transform>().localPosition.x;
				float curY = itemsToScroll[i].GetComponent<Transform>().localPosition.y;
				float curZ = itemsToScroll[i].GetComponent<Transform>().localPosition.z;
//bttnLength * bttnDistance
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
	}

	void LerpToBttn(float position){
		float newX = Mathf.Lerp (panel.localPosition.x, position, Time.deltaTime * 5f);
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














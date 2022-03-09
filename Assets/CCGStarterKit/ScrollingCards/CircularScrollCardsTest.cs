using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

namespace Caerwent{

	public class CircularScrollCardsTest : MonoBehaviour {

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
		/* private GameObject cardModel4;
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
		private GameObject cardModel60c; */
		
		 
		 void Awake(){
			
			
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
			/* cardModel4 = GameObject.Find("CardModel4");
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
			cardModel60c = GameObject.Find("CardModel60c"); */
			
		}
	 
		 // Use this for initialization
		 void Start () {
			 //curCard = 0;
			
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
			/* itemsToScroll.Insert(12, cardModel4);
			itemsToScroll.Insert(13, cardModel4a);
			itemsToScroll.Insert(14, cardModel4b);
			itemsToScroll.Insert(15, cardModel4c);
			itemsToScroll.Insert(16, cardModel5);
			itemsToScroll.Insert(17, cardModel5a);
			itemsToScroll.Insert(18, cardModel5b);
			itemsToScroll.Insert(19, cardModel5c);
			itemsToScroll.Insert(20, cardModel6);
			itemsToScroll.Insert(21, cardModel6a);
			itemsToScroll.Insert(22, cardModel6b);
			itemsToScroll.Insert(23, cardModel6c);
			itemsToScroll.Insert(24, cardModel7);
			itemsToScroll.Insert(25, cardModel7a);
			itemsToScroll.Insert(26, cardModel7b);
			itemsToScroll.Insert(27, cardModel7c);
			itemsToScroll.Insert(28, cardModel8);
			itemsToScroll.Insert(29, cardModel8a);
			itemsToScroll.Insert(30, cardModel8b);
			itemsToScroll.Insert(31, cardModel8c);
			itemsToScroll.Insert(32, cardModel9);
			itemsToScroll.Insert(33, cardModel9a);
			itemsToScroll.Insert(34, cardModel9b);
			itemsToScroll.Insert(35, cardModel9c);
			itemsToScroll.Insert(36, cardModel10);
			itemsToScroll.Insert(37, cardModel10a);
			itemsToScroll.Insert(38, cardModel10b);
			itemsToScroll.Insert(39, cardModel10c);
			itemsToScroll.Insert(40, cardModel11);
			itemsToScroll.Insert(41, cardModel11a);
			itemsToScroll.Insert(42, cardModel11b);
			itemsToScroll.Insert(43, cardModel11c);
			itemsToScroll.Insert(44, cardModel12);
			itemsToScroll.Insert(45, cardModel12a);
			itemsToScroll.Insert(46, cardModel12b);
			itemsToScroll.Insert(47, cardModel12c);
			itemsToScroll.Insert(48, cardModel13);
			itemsToScroll.Insert(49, cardModel13a);
			itemsToScroll.Insert(50, cardModel13b);
			itemsToScroll.Insert(51, cardModel13c);
			itemsToScroll.Insert(52, cardModel14);
			itemsToScroll.Insert(53, cardModel14a);
			itemsToScroll.Insert(54, cardModel14b);
			itemsToScroll.Insert(55, cardModel14c);
			itemsToScroll.Insert(56, cardModel15);
			itemsToScroll.Insert(57, cardModel15a);
			itemsToScroll.Insert(58, cardModel15b);
			itemsToScroll.Insert(59, cardModel15c);
			itemsToScroll.Insert(60, cardModel16);
			itemsToScroll.Insert(61, cardModel16a);
			itemsToScroll.Insert(62, cardModel16b);
			itemsToScroll.Insert(63, cardModel16c);
			itemsToScroll.Insert(64, cardModel17);
			itemsToScroll.Insert(65, cardModel17a);
			itemsToScroll.Insert(66, cardModel17b);
			itemsToScroll.Insert(67, cardModel17c);
			itemsToScroll.Insert(68, cardModel18);
			itemsToScroll.Insert(69, cardModel18a);
			itemsToScroll.Insert(70, cardModel18b);
			itemsToScroll.Insert(71, cardModel18c);
			itemsToScroll.Insert(72, cardModel19);
			itemsToScroll.Insert(73, cardModel19a);
			itemsToScroll.Insert(74, cardModel19b);
			itemsToScroll.Insert(75, cardModel19c);
			itemsToScroll.Insert(76, cardModel20);
			itemsToScroll.Insert(77, cardModel20a);
			itemsToScroll.Insert(78, cardModel20b);
			itemsToScroll.Insert(79, cardModel20c);
			itemsToScroll.Insert(80, cardModel21);
			itemsToScroll.Insert(81, cardModel21a);
			itemsToScroll.Insert(82, cardModel21b);
			itemsToScroll.Insert(83, cardModel21c);
			itemsToScroll.Insert(84, cardModel22);
			itemsToScroll.Insert(85, cardModel22a);
			itemsToScroll.Insert(86, cardModel22b);
			itemsToScroll.Insert(87, cardModel22c);
			itemsToScroll.Insert(88, cardModel23);
			itemsToScroll.Insert(89, cardModel23a);
			itemsToScroll.Insert(90, cardModel23b);
			itemsToScroll.Insert(91, cardModel23c);
			itemsToScroll.Insert(92, cardModel24);
			itemsToScroll.Insert(93, cardModel24a);
			itemsToScroll.Insert(94, cardModel24b);
			itemsToScroll.Insert(95, cardModel24c);
			itemsToScroll.Insert(96, cardModel25);
			itemsToScroll.Insert(97, cardModel25a);
			itemsToScroll.Insert(98, cardModel25b);
			itemsToScroll.Insert(99, cardModel25c);
			itemsToScroll.Insert(100, cardModel26);
			itemsToScroll.Insert(101, cardModel26a);
			itemsToScroll.Insert(102, cardModel26b);
			itemsToScroll.Insert(103, cardModel26c);
			itemsToScroll.Insert(104, cardModel27);
			itemsToScroll.Insert(105, cardModel27a);
			itemsToScroll.Insert(106, cardModel27b);
			itemsToScroll.Insert(107, cardModel27c);
			itemsToScroll.Insert(108, cardModel28);
			itemsToScroll.Insert(109, cardModel28a);
			itemsToScroll.Insert(110, cardModel28b);
			itemsToScroll.Insert(110, cardModel28c);
			itemsToScroll.Insert(112, cardModel29);
			itemsToScroll.Insert(113, cardModel29a);
			itemsToScroll.Insert(114, cardModel29b);
			itemsToScroll.Insert(115, cardModel29c);
			itemsToScroll.Insert(116, cardModel30);
			itemsToScroll.Insert(117, cardModel30a);
			itemsToScroll.Insert(118, cardModel30b);
			itemsToScroll.Insert(119, cardModel30c);
			itemsToScroll.Insert(120, cardModel31);
			itemsToScroll.Insert(120, cardModel31a);
			itemsToScroll.Insert(120, cardModel31b);
			itemsToScroll.Insert(120, cardModel31c);
			itemsToScroll.Insert(121, cardModel32);
			itemsToScroll.Insert(121, cardModel32a);
			itemsToScroll.Insert(121, cardModel32b);
			itemsToScroll.Insert(121, cardModel32c);
			itemsToScroll.Insert(122, cardModel33);
			itemsToScroll.Insert(122, cardModel33a);
			itemsToScroll.Insert(122, cardModel33b);
			itemsToScroll.Insert(122, cardModel33c);
			itemsToScroll.Insert(123, cardModel34);
			itemsToScroll.Insert(123, cardModel34a);
			itemsToScroll.Insert(123, cardModel34b);
			itemsToScroll.Insert(123, cardModel34c);
			itemsToScroll.Insert(124, cardModel35);
			itemsToScroll.Insert(123, cardModel35a);
			itemsToScroll.Insert(123, cardModel35b);
			itemsToScroll.Insert(123, cardModel35c);
			itemsToScroll.Insert(125, cardModel36);
			itemsToScroll.Insert(125, cardModel36a);
			itemsToScroll.Insert(125, cardModel36b);
			itemsToScroll.Insert(125, cardModel36c);
			itemsToScroll.Insert(126, cardModel37);
			itemsToScroll.Insert(126, cardModel37a);
			itemsToScroll.Insert(126, cardModel37b);
			itemsToScroll.Insert(126, cardModel37c);
			itemsToScroll.Insert(127, cardModel38);
			itemsToScroll.Insert(127, cardModel38a);
			itemsToScroll.Insert(127, cardModel38b);
			itemsToScroll.Insert(127, cardModel38c);
			itemsToScroll.Insert(128, cardModel39);
			itemsToScroll.Insert(128, cardModel39a);
			itemsToScroll.Insert(128, cardModel39b);
			itemsToScroll.Insert(128, cardModel39c);
			itemsToScroll.Insert(129, cardModel40);
			itemsToScroll.Insert(129, cardModel40a);
			itemsToScroll.Insert(129, cardModel40b);
			itemsToScroll.Insert(129, cardModel40c);
			itemsToScroll.Insert(130, cardModel41);
			itemsToScroll.Insert(130, cardModel41a);
			itemsToScroll.Insert(130, cardModel41b);
			itemsToScroll.Insert(130, cardModel41c);
			itemsToScroll.Insert(131, cardModel42);
			itemsToScroll.Insert(131, cardModel42a);
			itemsToScroll.Insert(131, cardModel42b);
			itemsToScroll.Insert(131, cardModel42c);
			itemsToScroll.Insert(132, cardModel43);
			itemsToScroll.Insert(132, cardModel43a);
			itemsToScroll.Insert(132, cardModel43b);
			itemsToScroll.Insert(132, cardModel43c);
			itemsToScroll.Insert(133, cardModel44);
			itemsToScroll.Insert(133, cardModel44a);
			itemsToScroll.Insert(133, cardModel44b);
			itemsToScroll.Insert(133, cardModel44c);
			itemsToScroll.Insert(134, cardModel45);
			itemsToScroll.Insert(134, cardModel45a);
			itemsToScroll.Insert(134, cardModel45b);
			itemsToScroll.Insert(134, cardModel45c);
			itemsToScroll.Insert(135, cardModel46);
			itemsToScroll.Insert(135, cardModel46a);
			itemsToScroll.Insert(135, cardModel46b);
			itemsToScroll.Insert(135, cardModel46c);
			itemsToScroll.Insert(136, cardModel47);
			itemsToScroll.Insert(136, cardModel47a);
			itemsToScroll.Insert(136, cardModel47b);
			itemsToScroll.Insert(136, cardModel47c);
			itemsToScroll.Insert(137, cardModel48);
			itemsToScroll.Insert(137, cardModel48a);
			itemsToScroll.Insert(137, cardModel48b);
			itemsToScroll.Insert(137, cardModel48c);
			itemsToScroll.Insert(138, cardModel49);
			itemsToScroll.Insert(138, cardModel49a);
			itemsToScroll.Insert(138, cardModel49b);
			itemsToScroll.Insert(138, cardModel49c);
			itemsToScroll.Insert(139, cardModel50);
			itemsToScroll.Insert(139, cardModel50a);
			itemsToScroll.Insert(139, cardModel50b);
			itemsToScroll.Insert(139, cardModel50c);
			itemsToScroll.Insert(140, cardModel51);
			itemsToScroll.Insert(140, cardModel51a);
			itemsToScroll.Insert(140, cardModel51b);
			itemsToScroll.Insert(140, cardModel51c);
			itemsToScroll.Insert(141, cardModel52);
			itemsToScroll.Insert(141, cardModel52a);
			itemsToScroll.Insert(141, cardModel52b);
			itemsToScroll.Insert(141, cardModel52c);
			itemsToScroll.Insert(142, cardModel53);
			itemsToScroll.Insert(142, cardModel53a);
			itemsToScroll.Insert(142, cardModel53b);
			itemsToScroll.Insert(142, cardModel53c);
			itemsToScroll.Insert(143, cardModel54);
			itemsToScroll.Insert(143, cardModel54a);
			itemsToScroll.Insert(143, cardModel54b);
			itemsToScroll.Insert(143, cardModel54c);
			itemsToScroll.Insert(144, cardModel55);
			itemsToScroll.Insert(144, cardModel55a);
			itemsToScroll.Insert(144, cardModel55b);
			itemsToScroll.Insert(144, cardModel55c);
			itemsToScroll.Insert(145, cardModel56);
			itemsToScroll.Insert(145, cardModel56a);
			itemsToScroll.Insert(145, cardModel56b);
			itemsToScroll.Insert(145, cardModel56c);
			itemsToScroll.Insert(146, cardModel57);
			itemsToScroll.Insert(146, cardModel57a);
			itemsToScroll.Insert(146, cardModel57b);
			itemsToScroll.Insert(146, cardModel57c);
			itemsToScroll.Insert(147, cardModel58);
			itemsToScroll.Insert(147, cardModel58a);
			itemsToScroll.Insert(147, cardModel58b);
			itemsToScroll.Insert(147, cardModel58c);
			itemsToScroll.Insert(148, cardModel59);
			itemsToScroll.Insert(148, cardModel59a);
			itemsToScroll.Insert(148, cardModel59b);
			itemsToScroll.Insert(148, cardModel59c);
			itemsToScroll.Insert(149, cardModel60);
			itemsToScroll.Insert(149, cardModel60a);
			itemsToScroll.Insert(149, cardModel60b);
			itemsToScroll.Insert(149, cardModel60c); */
			
			
			
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
		 
		 // Update is called once per frame
		 void Update () {
			 
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

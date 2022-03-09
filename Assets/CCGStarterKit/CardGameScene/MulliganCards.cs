using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Caerwent {

	public class MulliganCards : MonoBehaviour {
		
		public List<GameObject> spawnPointsHand = new List<GameObject>();
		private Ray ray;
		private RaycastHit hit;
		public int numberOfCards;
		public int numberOfMulligan;
		private GameObject spawnPoint;
		private float lastClickTime;
		public float catchTime = 0.25f;
		private GameObject dropDownMenu;
		private GameObject doneButton1;
		private GameObject doneButton2;
		private GameObject doneButton3;
		
		private LoadDeckCards1 loadDeckCards1;
		private LoadDeckCards2 loadDeckCards2;
		private LoadDeckCards3 loadDeckCards3;
		
		private static int mulliganCounter1;
		private static int mulliganCounter2;
		private static int mulliganCounter3;
		
		private GameObject player1DeckSlot1;
		private GameObject player1DeckSlot2;
		private GameObject player1DeckSlot3;
		private GameObject player1DeckSlot4;
		private GameObject player1DeckSlot5;
		private GameObject player1DeckSlot6;
		private GameObject player1DeckSlot7;
		private GameObject player1DeckSlot8;
		private GameObject player1DeckSlot9;
		private GameObject player1DeckSlot10;
		
		private GameObject spawnPoints1;
		private GameObject spawnPoints2;
		private GameObject spawnPoints3;
		private GameObject spawnPoints4;
		private GameObject spawnPoints5;
		private GameObject spawnPoints6;
		private GameObject spawnPoints7;
		private GameObject spawnPoints8;
		private GameObject spawnPoints9;
		private GameObject spawnPoints10;
		
		
		private int instances1;
		private int instances1a;
		private int instances1b;
		private int instances1c;
		private int instances2;
		private int instances2a;
		private int instances2b;
		private int instances2c;
		private int instances3;
		private int instances3a;
		private int instances3b;
		private int instances3c;
		private int instances4;
		private int instances4a;
		private int instances4b;
		private int instances4c;
		private int instances5;
		private int instances5a;
		private int instances5b;
		private int instances5c;
		private int instances6;
		private int instances6a;
		private int instances6b;
		private int instances6c;
		private int instances7;
		private int instances7a;
		private int instances7b;
		private int instances7c;
		private int instances8;
		private int instances8a;
		private int instances8b;
		private int instances8c;
		private int instances9;
		private int instances9a;
		private int instances9b;
		private int instances9c;
		private int instances10;
		private int instances10a;
		private int instances10b;
		private int instances10c;
		private int instances11;
		private int instances11a;
		private int instances11b;
		private int instances11c;
		private int instances12;
		private int instances12a;
		private int instances12b;
		private int instances12c;
		private int instances13;
		private int instances13a;
		private int instances13b;
		private int instances13c;
		private int instances14;
		private int instances14a;
		private int instances14b;
		private int instances14c;
		private int instances15;
		private int instances15a;
		private int instances15b;
		private int instances15c;
		private int instances16;
		private int instances16a;
		private int instances16b;
		private int instances16c;
		private int instances17;
		private int instances17a;
		private int instances17b;
		private int instances17c;
		private int instances18;
		private int instances18a;
		private int instances18b;
		private int instances18c;
		private int instances19;
		private int instances19a;
		private int instances19b;
		private int instances19c;
		private int instances20;
		private int instances20a;
		private int instances20b;
		private int instances20c;
		private int instances21;
		private int instances21a;
		private int instances21b;
		private int instances21c;
		private int instances22;
		private int instances22a;
		private int instances22b;
		private int instances22c;
		private int instances23;
		private int instances23a;
		private int instances23b;
		private int instances23c;
		private int instances24;
		private int instances24a;
		private int instances24b;
		private int instances24c;
		private int instances25;
		private int instances25a;
		private int instances25b;
		private int instances25c;
		private int instances26;
		private int instances26a;
		private int instances26b;
		private int instances26c;
		private int instances27;
		private int instances27a;
		private int instances27b;
		private int instances27c;
		private int instances28;
		private int instances28a;
		private int instances28b;
		private int instances28c;
		private int instances29;
		private int instances29a;
		private int instances29b;
		private int instances29c;
		private int instances30;
		private int instances30a;
		private int instances30b;
		private int instances30c;
		private int instances31;
		private int instances31a;
		private int instances31b;
		private int instances31c;
		private int instances32;
		private int instances32a;
		private int instances32b;
		private int instances32c;
		private int instances33;
		private int instances33a;
		private int instances33b;
		private int instances33c;
		private int instances34;
		private int instances34a;
		private int instances34b;
		private int instances34c;
		private int instances35;
		private int instances35a;
		private int instances35b;
		private int instances35c;
		private int instances36;
		private int instances36a;
		private int instances36b;
		private int instances36c;
		private int instances37;
		private int instances37a;
		private int instances37b;
		private int instances37c;
		private int instances38;
		private int instances38a;
		private int instances38b;
		private int instances38c;
		private int instances39;
		private int instances39a;
		private int instances39b;
		private int instances39c;
		private int instances40;
		private int instances40a;
		private int instances40b;
		private int instances40c;
		private int instances41;
		private int instances41a;
		private int instances41b;
		private int instances41c;
		private int instances42;
		private int instances42a;
		private int instances42b;
		private int instances42c;
		private int instances43;
		private int instances43a;
		private int instances43b;
		private int instances43c;
		private int instances44;
		private int instances44a;
		private int instances44b;
		private int instances44c;
		private int instances45;
		private int instances45a;
		private int instances45b;
		private int instances45c;
		private int instances46;
		private int instances46a;
		private int instances46b;
		private int instances46c;
		private int instances47;
		private int instances47a;
		private int instances47b;
		private int instances47c;
		private int instances48;
		private int instances48a;
		private int instances48b;
		private int instances48c;
		private int instances49;
		private int instances49a;
		private int instances49b;
		private int instances49c;
		private int instances50;
		private int instances50a;
		private int instances50b;
		private int instances50c;
		private int instances51;
		private int instances51a;
		private int instances51b;
		private int instances51c;
		private int instances52;
		private int instances52a;
		private int instances52b;
		private int instances52c;
		private int instances53;
		private int instances53a;
		private int instances53b;
		private int instances53c;
		private int instances54;
		private int instances54a;
		private int instances54b;
		private int instances54c;
		private int instances55;
		private int instances55a;
		private int instances55b;
		private int instances55c;
		private int instances56;
		private int instances56a;
		private int instances56b;
		private int instances56c;
		private int instances57;
		private int instances57a;
		private int instances57b;
		private int instances57c;
		private int instances58;
		private int instances58a;
		private int instances58b;
		private int instances58c;
		private int instances59;
		private int instances59a;
		private int instances59b;
		private int instances59c;
		private int instances60;
		private int instances60a;
		private int instances60b;
		private int instances60c;
		
		//Cards to spawn in the deck
		[HideInInspector]
		public GameObject card1;
		[HideInInspector]
		public GameObject card1a;
		[HideInInspector]
		public GameObject card1b;
		[HideInInspector]
		public GameObject card1c;
		[HideInInspector]
		public GameObject card2;
		[HideInInspector]
		public GameObject card2a;
		[HideInInspector]
		public GameObject card2b;
		[HideInInspector]
		public GameObject card2c;
		[HideInInspector]
		public GameObject card3;
		[HideInInspector]
		public GameObject card3a;
		[HideInInspector]
		public GameObject card3b;
		[HideInInspector]
		public GameObject card3c;
		[HideInInspector]
		public GameObject card4;
		[HideInInspector]
		public GameObject card4a;
		[HideInInspector]
		public GameObject card4b;
		[HideInInspector]
		public GameObject card4c;
		[HideInInspector]
		public GameObject card5;
		[HideInInspector]
		public GameObject card5a;
		[HideInInspector]
		public GameObject card5b;
		[HideInInspector]
		public GameObject card5c;
		[HideInInspector]
		public GameObject card6;
		[HideInInspector]
		public GameObject card6a;
		[HideInInspector]
		public GameObject card6b;
		[HideInInspector]
		public GameObject card6c;
		[HideInInspector]
		public GameObject card7;
		[HideInInspector]
		public GameObject card7a;
		[HideInInspector]
		public GameObject card7b;
		[HideInInspector]
		public GameObject card7c;
		[HideInInspector]
		public GameObject card8;
		[HideInInspector]
		public GameObject card8a;
		[HideInInspector]
		public GameObject card8b;
		[HideInInspector]
		public GameObject card8c;
		[HideInInspector]
		public GameObject card9;
		[HideInInspector]
		public GameObject card9a;
		[HideInInspector]
		public GameObject card9b;
		[HideInInspector]
		public GameObject card9c;
		[HideInInspector]
		public GameObject card10;
		[HideInInspector]
		public GameObject card10a;
		[HideInInspector]
		public GameObject card10b;
		[HideInInspector]
		public GameObject card10c;
		[HideInInspector]
		public GameObject card11;
		[HideInInspector]
		public GameObject card11a;
		[HideInInspector]
		public GameObject card11b;
		[HideInInspector]
		public GameObject card11c;
		[HideInInspector]
		public GameObject card12;
		[HideInInspector]
		public GameObject card12a;
		[HideInInspector]
		public GameObject card12b;
		[HideInInspector]
		public GameObject card12c;
		[HideInInspector]
		public GameObject card13;
		[HideInInspector]
		public GameObject card13a;
		[HideInInspector]
		public GameObject card13b;
		[HideInInspector]
		public GameObject card13c;
		[HideInInspector]
		public GameObject card14;
		[HideInInspector]
		public GameObject card14a;
		[HideInInspector]
		public GameObject card14b;
		[HideInInspector]
		public GameObject card14c;
		[HideInInspector]
		public GameObject card15;
		[HideInInspector]
		public GameObject card15a;
		[HideInInspector]
		public GameObject card15b;
		[HideInInspector]
		public GameObject card15c;
		[HideInInspector]
		public GameObject card16;
		[HideInInspector]
		public GameObject card16a;
		[HideInInspector]
		public GameObject card16b;
		[HideInInspector]
		public GameObject card16c;
		[HideInInspector]
		public GameObject card17;
		[HideInInspector]
		public GameObject card17a;
		[HideInInspector]
		public GameObject card17b;
		[HideInInspector]
		public GameObject card17c;
		[HideInInspector]
		public GameObject card18;
		[HideInInspector]
		public GameObject card18a;
		[HideInInspector]
		public GameObject card18b;
		[HideInInspector]
		public GameObject card18c;
		[HideInInspector]
		public GameObject card19;
		[HideInInspector]
		public GameObject card19a;
		[HideInInspector]
		public GameObject card19b;
		[HideInInspector]
		public GameObject card19c;
		[HideInInspector]
		public GameObject card20;
		[HideInInspector]
		public GameObject card20a;
		[HideInInspector]
		public GameObject card20b;
		[HideInInspector]
		public GameObject card20c;
		[HideInInspector]
		public GameObject card21;
		[HideInInspector]
		public GameObject card21a;
		[HideInInspector]
		public GameObject card21b;
		[HideInInspector]
		public GameObject card21c;
		[HideInInspector]
		public GameObject card22;
		[HideInInspector]
		public GameObject card22a;
		[HideInInspector]
		public GameObject card22b;
		[HideInInspector]
		public GameObject card22c;
		[HideInInspector]
		public GameObject card23;
		[HideInInspector]
		public GameObject card23a;
		[HideInInspector]
		public GameObject card23b;
		[HideInInspector]
		public GameObject card23c;
		[HideInInspector]
		public GameObject card24;
		[HideInInspector]
		public GameObject card24a;
		[HideInInspector]
		public GameObject card24b;
		[HideInInspector]
		public GameObject card24c;
		[HideInInspector]
		public GameObject card25;
		[HideInInspector]
		public GameObject card25a;
		[HideInInspector]
		public GameObject card25b;
		[HideInInspector]
		public GameObject card25c;
		[HideInInspector]
		public GameObject card26;
		[HideInInspector]
		public GameObject card26a;
		[HideInInspector]
		public GameObject card26b;
		[HideInInspector]
		public GameObject card26c;
		[HideInInspector]
		public GameObject card27;
		[HideInInspector]
		public GameObject card27a;
		[HideInInspector]
		public GameObject card27b;
		[HideInInspector]
		public GameObject card27c;
		[HideInInspector]
		public GameObject card28;
		[HideInInspector]
		public GameObject card28a;
		[HideInInspector]
		public GameObject card28b;
		[HideInInspector]
		public GameObject card28c;
		[HideInInspector]
		public GameObject card29;
		[HideInInspector]
		public GameObject card29a;
		[HideInInspector]
		public GameObject card29b;
		[HideInInspector]
		public GameObject card29c;
		[HideInInspector]
		public GameObject card30;
		[HideInInspector]
		public GameObject card30a;
		[HideInInspector]
		public GameObject card30b;
		[HideInInspector]
		public GameObject card30c;
		[HideInInspector]
		public GameObject card31;
		[HideInInspector]
		public GameObject card31a;
		[HideInInspector]
		public GameObject card31b;
		[HideInInspector]
		public GameObject card31c;
		[HideInInspector]
		public GameObject card32;
		[HideInInspector]
		public GameObject card32a;
		[HideInInspector]
		public GameObject card32b;
		[HideInInspector]
		public GameObject card32c;
		[HideInInspector]
		public GameObject card33;
		[HideInInspector]
		public GameObject card33a;
		[HideInInspector]
		public GameObject card33b;
		[HideInInspector]
		public GameObject card33c;
		[HideInInspector]
		public GameObject card34;
		[HideInInspector]
		public GameObject card34a;
		[HideInInspector]
		public GameObject card34b;
		[HideInInspector]
		public GameObject card34c;
		[HideInInspector]
		public GameObject card35;
		[HideInInspector]
		public GameObject card35a;
		[HideInInspector]
		public GameObject card35b;
		[HideInInspector]
		public GameObject card35c;
		[HideInInspector]
		public GameObject card36;
		[HideInInspector]
		public GameObject card36a;
		[HideInInspector]
		public GameObject card36b;
		[HideInInspector]
		public GameObject card36c;
		[HideInInspector]
		public GameObject card37;
		[HideInInspector]
		public GameObject card37a;
		[HideInInspector]
		public GameObject card37b;
		[HideInInspector]
		public GameObject card37c;
		[HideInInspector]
		public GameObject card38;
		[HideInInspector]
		public GameObject card38a;
		[HideInInspector]
		public GameObject card38b;
		[HideInInspector]
		public GameObject card38c;
		[HideInInspector]
		public GameObject card39;
		[HideInInspector]
		public GameObject card39a;
		[HideInInspector]
		public GameObject card39b;
		[HideInInspector]
		public GameObject card39c;
		[HideInInspector]
		public GameObject card40;
		[HideInInspector]
		public GameObject card40a;
		[HideInInspector]
		public GameObject card40b;
		[HideInInspector]
		public GameObject card40c;
		[HideInInspector]
		public GameObject card41;
		[HideInInspector]
		public GameObject card41a;
		[HideInInspector]
		public GameObject card41b;
		[HideInInspector]
		public GameObject card41c;
		[HideInInspector]
		public GameObject card42;
		[HideInInspector]
		public GameObject card42a;
		[HideInInspector]
		public GameObject card42b;
		[HideInInspector]
		public GameObject card42c;
		[HideInInspector]
		public GameObject card43;
		[HideInInspector]
		public GameObject card43a;
		[HideInInspector]
		public GameObject card43b;
		[HideInInspector]
		public GameObject card43c;
		[HideInInspector]
		public GameObject card44;
		[HideInInspector]
		public GameObject card44a;
		[HideInInspector]
		public GameObject card44b;
		[HideInInspector]
		public GameObject card44c;
		[HideInInspector]
		public GameObject card45;
		[HideInInspector]
		public GameObject card45a;
		[HideInInspector]
		public GameObject card45b;
		[HideInInspector]
		public GameObject card45c;
		[HideInInspector]
		public GameObject card46;
		[HideInInspector]
		public GameObject card46a;
		[HideInInspector]
		public GameObject card46b;
		[HideInInspector]
		public GameObject card46c;
		[HideInInspector]
		public GameObject card47;
		[HideInInspector]
		public GameObject card47a;
		[HideInInspector]
		public GameObject card47b;
		[HideInInspector]
		public GameObject card47c;
		[HideInInspector]
		public GameObject card48;
		[HideInInspector]
		public GameObject card48a;
		[HideInInspector]
		public GameObject card48b;
		[HideInInspector]
		public GameObject card48c;
		[HideInInspector]
		public GameObject card49;
		[HideInInspector]
		public GameObject card49a;
		[HideInInspector]
		public GameObject card49b;
		[HideInInspector]
		public GameObject card49c;
		[HideInInspector]
		public GameObject card50;
		[HideInInspector]
		public GameObject card50a;
		[HideInInspector]
		public GameObject card50b;
		[HideInInspector]
		public GameObject card50c;
		[HideInInspector]
		public GameObject card51;
		[HideInInspector]
		public GameObject card51a;
		[HideInInspector]
		public GameObject card51b;
		[HideInInspector]
		public GameObject card51c;
		[HideInInspector]
		public GameObject card52;
		[HideInInspector]
		public GameObject card52a;
		[HideInInspector]
		public GameObject card52b;
		[HideInInspector]
		public GameObject card52c;
		[HideInInspector]
		public GameObject card53;
		[HideInInspector]
		public GameObject card53a;
		[HideInInspector]
		public GameObject card53b;
		[HideInInspector]
		public GameObject card53c;
		[HideInInspector]
		public GameObject card54;
		[HideInInspector]
		public GameObject card54a;
		[HideInInspector]
		public GameObject card54b;
		[HideInInspector]
		public GameObject card54c;
		[HideInInspector]
		public GameObject card55;
		[HideInInspector]
		public GameObject card55a;
		[HideInInspector]
		public GameObject card55b;
		[HideInInspector]
		public GameObject card55c;
		[HideInInspector]
		public GameObject card56;
		[HideInInspector]
		public GameObject card56a;
		[HideInInspector]
		public GameObject card56b;
		[HideInInspector]
		public GameObject card56c;
		[HideInInspector]
		public GameObject card57;
		[HideInInspector]
		public GameObject card57a;
		[HideInInspector]
		public GameObject card57b;
		[HideInInspector]
		public GameObject card57c;
		[HideInInspector]
		public GameObject card58;
		[HideInInspector]
		public GameObject card58a;
		[HideInInspector]
		public GameObject card58b;
		[HideInInspector]
		public GameObject card58c;
		[HideInInspector]
		public GameObject card59;
		[HideInInspector]
		public GameObject card59a;
		[HideInInspector]
		public GameObject card59b;
		[HideInInspector]
		public GameObject card59c;
		[HideInInspector]
		public GameObject card60;
		[HideInInspector]
		public GameObject card60a;
		[HideInInspector]
		public GameObject card60b;
		[HideInInspector]
		public GameObject card60c;
		
		void Awake(){
			
			dropDownMenu = GameObject.Find("DropDownMenu");
			loadDeckCards1 = dropDownMenu.GetComponent<LoadDeckCards1>();
			loadDeckCards2 = dropDownMenu.GetComponent<LoadDeckCards2>();
			loadDeckCards3 = dropDownMenu.GetComponent<LoadDeckCards3>();
			doneButton1 = GameObject.Find("DoneButton1");
			doneButton2 = GameObject.Find("DoneButton2");
			doneButton3 = GameObject.Find("DoneButton3");
			
			player1DeckSlot1 = GameObject.Find("Player1DeckSlot1");
			player1DeckSlot2 = GameObject.Find("Player1DeckSlot2");
			player1DeckSlot3 = GameObject.Find("Player1DeckSlot3");
			player1DeckSlot4 = GameObject.Find("Player1DeckSlot4");
			player1DeckSlot5 = GameObject.Find("Player1DeckSlot5");
			player1DeckSlot6 = GameObject.Find("Player1DeckSlot6");
			player1DeckSlot7 = GameObject.Find("Player1DeckSlot7");
			player1DeckSlot8 = GameObject.Find("Player1DeckSlot8");
			player1DeckSlot9 = GameObject.Find("Player1DeckSlot9");
			player1DeckSlot10 = GameObject.Find("Player1DeckSlot10");
			
			card1 = GameObject.Find("Card1");
			card1a = GameObject.Find("Card1a");
			card1b = GameObject.Find("Card1b");
			card1c = GameObject.Find("Card1c");
			card2 = GameObject.Find("Card2");
			card2a = GameObject.Find("Card2a");
			card2b = GameObject.Find("Card2b");
			card2c = GameObject.Find("Card2c");
			card3 = GameObject.Find("Card3");
			card3a = GameObject.Find("Card3a");
			card3b = GameObject.Find("Card3b");
			card3c = GameObject.Find("Card3c");
			card4 = GameObject.Find("Card4");
			card4a = GameObject.Find("Card4a");
			card4b = GameObject.Find("Card4b");
			card4c = GameObject.Find("Card4c");
			card5 = GameObject.Find("Card5");
			card5a = GameObject.Find("Card5a");
			card5b = GameObject.Find("Card5b");
			card5c = GameObject.Find("Card5c");
			card6 = GameObject.Find("Card6");
			card6a = GameObject.Find("Card6a");
			card6b = GameObject.Find("Card6b");
			card6c = GameObject.Find("Card6c");
			card7 = GameObject.Find("Card7");
			card7a = GameObject.Find("Card7a");
			card7b = GameObject.Find("Card7b");
			card7c = GameObject.Find("Card7c");
			card8 = GameObject.Find("Card8");
			card8a = GameObject.Find("Card8a");
			card8b = GameObject.Find("Card8b");
			card8c = GameObject.Find("Card8c");
			card9 = GameObject.Find("Card9");
			card9a = GameObject.Find("Card9a");
			card9b = GameObject.Find("Card9b");
			card9c = GameObject.Find("Card9c");
			card10 = GameObject.Find("Card10");
			card10a = GameObject.Find("Card10a");
			card10b = GameObject.Find("Card10b");
			card10c = GameObject.Find("Card10c");
			card11 = GameObject.Find("Card11");
			card11a = GameObject.Find("Card11a");
			card11b = GameObject.Find("Card11b");
			card11c = GameObject.Find("Card11c");
			card12 = GameObject.Find("Card12");
			card12a = GameObject.Find("Card12a");
			card12b = GameObject.Find("Card12b");
			card12c = GameObject.Find("Card12c");
			card13 = GameObject.Find("Card13");
			card13a = GameObject.Find("Card13a");
			card13b = GameObject.Find("Card13b");
			card13c = GameObject.Find("Card13c");
			card14 = GameObject.Find("Card14");
			card14a = GameObject.Find("Card14a");
			card14b = GameObject.Find("Card14b");
			card14c = GameObject.Find("Card14c");
			card15 = GameObject.Find("Card15");
			card15a = GameObject.Find("Card15a");
			card15b = GameObject.Find("Card15b");
			card15c = GameObject.Find("Card15c");
			card16 = GameObject.Find("Card16");
			card16a = GameObject.Find("Card16a");
			card16b = GameObject.Find("Card16b");
			card16c = GameObject.Find("Card16c");
			card17 = GameObject.Find("Card17");
			card17a = GameObject.Find("Card17a");
			card17b = GameObject.Find("Card17b");
			card17c = GameObject.Find("Card17c");
			card18 = GameObject.Find("Card18");
			card18a = GameObject.Find("Card18a");
			card18b = GameObject.Find("Card18b");
			card18c = GameObject.Find("Card18c");
			card19 = GameObject.Find("Card19");
			card19a = GameObject.Find("Card19a");
			card19b = GameObject.Find("Card19b");
			card19c = GameObject.Find("Card19c");
			card20 = GameObject.Find("Card20");
			card20a = GameObject.Find("Card20a");
			card20b = GameObject.Find("Card20b");
			card20c = GameObject.Find("Card20c");
			card21 = GameObject.Find("Card21");
			card21a = GameObject.Find("Card21a");
			card21b = GameObject.Find("Card21b");
			card21c = GameObject.Find("Card21c");
			card22 = GameObject.Find("Card22");
			card22a = GameObject.Find("Card22a");
			card22b = GameObject.Find("Card22b");
			card22c = GameObject.Find("Card22c");
			card23 = GameObject.Find("Card23");
			card23a = GameObject.Find("Card23a");
			card23b = GameObject.Find("Card23b");
			card23c = GameObject.Find("Card23c");
			card24 = GameObject.Find("Card24");
			card24a = GameObject.Find("Card24a");
			card24b = GameObject.Find("Card24b");
			card24c = GameObject.Find("Card24c");
			card25 = GameObject.Find("Card25");
			card25a = GameObject.Find("Card25a");
			card25b = GameObject.Find("Card25b");
			card25c = GameObject.Find("Card25c");
			card26 = GameObject.Find("Card26");
			card26a = GameObject.Find("Card26a");
			card26b = GameObject.Find("Card26b");
			card26c = GameObject.Find("Card26c");
			card27 = GameObject.Find("Card27");
			card27a = GameObject.Find("Card27a");
			card27b = GameObject.Find("Card27b");
			card27c = GameObject.Find("Card27c");
			card28 = GameObject.Find("Card28");
			card28a = GameObject.Find("Card28a");
			card28b = GameObject.Find("Card28b");
			card28c = GameObject.Find("Card28c");
			card29 = GameObject.Find("Card29");
			card29a = GameObject.Find("Card29a");
			card29b = GameObject.Find("Card29b");
			card29c = GameObject.Find("Card29c");
			card30 = GameObject.Find("Card30");
			card30a = GameObject.Find("Card30a");
			card30b = GameObject.Find("Card30b");
			card30c = GameObject.Find("Card30c");
			card31 = GameObject.Find("Card31");
			card31a = GameObject.Find("Card31a");
			card31b = GameObject.Find("Card31b");
			card31c = GameObject.Find("Card31c");
			card32 = GameObject.Find("Card32");
			card32a = GameObject.Find("Card32a");
			card32b = GameObject.Find("Card32b");
			card32c = GameObject.Find("Card32c");
			card33 = GameObject.Find("Card33");
			card33a = GameObject.Find("Card33a");
			card33b = GameObject.Find("Card33b");
			card33c = GameObject.Find("Card33c");
			card34 = GameObject.Find("Card34");
			card34a = GameObject.Find("Card34a");
			card34b = GameObject.Find("Card34b");
			card34c = GameObject.Find("Card34c");
			card35 = GameObject.Find("Card35");
			card35a = GameObject.Find("Card35a");
			card35b = GameObject.Find("Card35b");
			card35c = GameObject.Find("Card35c");
			card36 = GameObject.Find("Card36");
			card36a = GameObject.Find("Card36a");
			card36b = GameObject.Find("Card36b");
			card36c = GameObject.Find("Card36c");
			card37 = GameObject.Find("Card37");
			card37a = GameObject.Find("Card37a");
			card37b = GameObject.Find("Card37b");
			card37c = GameObject.Find("Card37c");
			card38 = GameObject.Find("Card38");
			card38a = GameObject.Find("Card38a");
			card38b = GameObject.Find("Card38b");
			card38c = GameObject.Find("Card38c");
			card39 = GameObject.Find("Card39");
			card39a = GameObject.Find("Card39a");
			card39b = GameObject.Find("Card39b");
			card39c = GameObject.Find("Card39c");
			card40 = GameObject.Find("Card40");
			card40a = GameObject.Find("Card40a");
			card40b = GameObject.Find("Card40b");
			card40c = GameObject.Find("Card40c");
			card41 = GameObject.Find("Card41");
			card41a = GameObject.Find("Card41a");
			card41b = GameObject.Find("Card41b");
			card41c = GameObject.Find("Card41c");
			card42 = GameObject.Find("Card42");
			card42a = GameObject.Find("Card42a");
			card42b = GameObject.Find("Card42b");
			card42c = GameObject.Find("Card42c");
			card43 = GameObject.Find("Card43");
			card43a = GameObject.Find("Card43a");
			card43b = GameObject.Find("Card43b");
			card43c = GameObject.Find("Card43c");
			card44 = GameObject.Find("Card44");
			card44a = GameObject.Find("Card44a");
			card44b = GameObject.Find("Card44b");
			card44c = GameObject.Find("Card44c");
			card45 = GameObject.Find("Card45");
			card45a = GameObject.Find("Card45a");
			card45b = GameObject.Find("Card45b");
			card45c = GameObject.Find("Card45c");
			card46 = GameObject.Find("Card46");
			card46a = GameObject.Find("Card46a");
			card46b = GameObject.Find("Card46b");
			card46c = GameObject.Find("Card46c");
			card47 = GameObject.Find("Card47");
			card47a = GameObject.Find("Card47a");
			card47b = GameObject.Find("Card47b");
			card47c = GameObject.Find("Card47c");
			card48 = GameObject.Find("Card48");
			card48a = GameObject.Find("Card48a");
			card48b = GameObject.Find("Card48b");
			card48c = GameObject.Find("Card48c");
			card49 = GameObject.Find("Card49");
			card49a = GameObject.Find("Card49a");
			card49b = GameObject.Find("Card49b");
			card49c = GameObject.Find("Card49c");
			card50 = GameObject.Find("Card50");
			card50a = GameObject.Find("Card50a");
			card50b = GameObject.Find("Card50b");
			card50c = GameObject.Find("Card50c");
			card51 = GameObject.Find("Card51");
			card51a = GameObject.Find("Card51a");
			card51b = GameObject.Find("Card51b");
			card51c = GameObject.Find("Card51c");
			card52 = GameObject.Find("Card52");
			card52a = GameObject.Find("Card52a");
			card52b = GameObject.Find("Card52b");
			card52c = GameObject.Find("Card52c");
			card53 = GameObject.Find("Card53");
			card53a = GameObject.Find("Card53a");
			card53b = GameObject.Find("Card53b");
			card53c = GameObject.Find("Card53c");
			card54 = GameObject.Find("Card54");
			card54a = GameObject.Find("Card54a");
			card54b = GameObject.Find("Card54b");
			card54c = GameObject.Find("Card54c");
			card55 = GameObject.Find("Card55");
			card55a = GameObject.Find("Card55a");
			card55b = GameObject.Find("Card55b");
			card55c = GameObject.Find("Card55c");
			card56 = GameObject.Find("Card56");
			card56a = GameObject.Find("Card56a");
			card56b = GameObject.Find("Card56b");
			card56c = GameObject.Find("Card56c");
			card57 = GameObject.Find("Card57");
			card57a = GameObject.Find("Card57a");
			card57b = GameObject.Find("Card57b");
			card57c = GameObject.Find("Card57c");
			card58 = GameObject.Find("Card58");
			card58a = GameObject.Find("Card58a");
			card58b = GameObject.Find("Card58b");
			card58c = GameObject.Find("Card58c");
			card59 = GameObject.Find("Card59");
			card59a = GameObject.Find("Card59a");
			card59b = GameObject.Find("Card59b");
			card59c = GameObject.Find("Card59c");
			card60 = GameObject.Find("Card60");
			card60a = GameObject.Find("Card60a");
			card60b = GameObject.Find("Card60b");
			card60c = GameObject.Find("Card60c");
			
		}

		// Use this for initialization
		void Start () {
			
			doneButton1.SetActive(false);
			doneButton2.SetActive(false);
			doneButton3.SetActive(false);
			
			numberOfCards = 1;
			numberOfMulligan = 2;
			
			mulliganCounter1 = 0;
			mulliganCounter2 = 0;
			mulliganCounter3 = 0;
			
			instances1 = 0;
			instances1a = 0;
			instances1b = 0;
			instances1c = 0;
			instances2 = 0;
			instances2a = 0;
			instances2b = 0;
			instances2c = 0;
			instances3 = 0;
			instances3a = 0;
			instances3b = 0;
			instances3c = 0;
			instances4 = 0;
			instances4a = 0;
			instances4b = 0;
			instances4c = 0;
			instances5 = 0;
			instances5a = 0;
			instances5b = 0;
			instances5c = 0;
			instances6 = 0;
			instances6a = 0;
			instances6b = 0;
			instances6c = 0;
			instances7 = 0;
			instances7a = 0;
			instances7b = 0;
			instances7c = 0;
			instances8 = 0;
			instances8a = 0;
			instances8b = 0;
			instances8c = 0;
			instances9 = 0;
			instances9a = 0;
			instances9b = 0;
			instances9c = 0;
			instances10 = 0;
			instances10a = 0;
			instances10b = 0;
			instances10c = 0;
			instances11 = 0;
			instances11a = 0;
			instances11b = 0;
			instances11c = 0;
			instances12 = 0;
			instances12a = 0;
			instances12b = 0;
			instances12c = 0;
			instances13 = 0;
			instances13a = 0;
			instances13b = 0;
			instances13c = 0;
			instances14 = 0;
			instances14a = 0;
			instances14b = 0;
			instances14c = 0;
			instances15 = 0;
			instances15a = 0;
			instances15b = 0;
			instances15c = 0;
			instances16 = 0;
			instances16a = 0;
			instances16b = 0;
			instances16c = 0;
			instances17 = 0;
			instances17a = 0;
			instances17b = 0;
			instances17c = 0;
			instances18 = 0;
			instances18a = 0;
			instances18b = 0;
			instances18c = 0;
			instances19 = 0;
			instances19a = 0;
			instances19b = 0;
			instances19c = 0;
			instances20 = 0;
			instances20a = 0;
			instances20b = 0;
			instances20c = 0;
			instances21 = 0;
			instances21a = 0;
			instances21b = 0;
			instances21c = 0;
			instances22 = 0;
			instances22a = 0;
			instances22b = 0;
			instances22c = 0;
			instances23 = 0;
			instances23a = 0;
			instances23b = 0;
			instances23c = 0;
			instances24 = 0;
			instances24a = 0;
			instances24b = 0;
			instances24c = 0;
			instances25 = 0;
			instances25a = 0;
			instances25b = 0;
			instances25c = 0;
			instances26 = 0;
			instances26a = 0;
			instances26b = 0;
			instances26c = 0;
			instances27 = 0;
			instances27a = 0;
			instances27b = 0;
			instances27c = 0;
			instances28 = 0;
			instances28a = 0;
			instances28b = 0;
			instances28c = 0;
			instances29 = 0;
			instances29a = 0;
			instances29b = 0;
			instances29c = 0;
			instances30 = 0;
			instances30a = 0;
			instances30b = 0;
			instances30c = 0;
			instances31 = 0;
			instances31a = 0;
			instances31b = 0;
			instances31c = 0;
			instances32 = 0;
			instances32a = 0;
			instances32b = 0;
			instances32c = 0;
			instances33 = 0;
			instances33a = 0;
			instances33b = 0;
			instances33c = 0;
			instances34 = 0;
			instances34a = 0;
			instances34b = 0;
			instances34c = 0;
			instances35 = 0;
			instances35a = 0;
			instances35b = 0;
			instances35c = 0;
			instances36 = 0;
			instances36a = 0;
			instances36b = 0;
			instances36c = 0;
			instances37 = 0;
			instances37a = 0;
			instances37b = 0;
			instances37c = 0;
			instances38 = 0;
			instances38a = 0;
			instances38b = 0;
			instances38c = 0;
			instances39 = 0;
			instances39a = 0;
			instances39b = 0;
			instances39c = 0;
			instances40 = 0;
			instances40a = 0;
			instances40b = 0;
			instances40c = 0;
			instances41 = 0;
			instances41a = 0;
			instances41b = 0;
			instances41c = 0;
			instances42 = 0;
			instances42a = 0;
			instances42b = 0;
			instances42c = 0;
			instances43 = 0;
			instances43a = 0;
			instances43b = 0;
			instances43c = 0;
			instances44 = 0;
			instances44a = 0;
			instances44b = 0;
			instances44c = 0;
			instances45 = 0;
			instances45a = 0;
			instances45b = 0;
			instances45c = 0;
			instances46 = 0;
			instances46a = 0;
			instances46b = 0;
			instances46c = 0;
			instances47 = 0;
			instances47a = 0;
			instances47b = 0;
			instances47c = 0;
			instances48 = 0;
			instances48a = 0;
			instances48b = 0;
			instances48c = 0;
			instances49 = 0;
			instances49a = 0;
			instances49b = 0;
			instances49c = 0;
			instances50 = 0;
			instances50a = 0;
			instances50b = 0;
			instances50c = 0;
			instances51 = 0;
			instances51a = 0;
			instances51b = 0;
			instances51c = 0;
			instances52 = 0;
			instances52a = 0;
			instances52b = 0;
			instances52c = 0;
			instances53 = 0;
			instances53a = 0;
			instances53b = 0;
			instances53c = 0;
			instances54 = 0;
			instances54a = 0;
			instances54b = 0;
			instances54c = 0;
			instances55 = 0;
			instances55a = 0;
			instances55b = 0;
			instances55c = 0;
			instances56 = 0;
			instances56a = 0;
			instances56b = 0;
			instances56c = 0;
			instances57 = 0;
			instances57a = 0;
			instances57b = 0;
			instances57c = 0;
			instances58 = 0;
			instances58a = 0;
			instances58b = 0;
			instances58c = 0;
			instances59 = 0;
			instances59a = 0;
			instances59b = 0;
			instances59c = 0;
			instances60 = 0;
			instances60a = 0;
			instances60b = 0;
			instances60c = 0;
			
			spawnPoints1 = player1DeckSlot1;
			spawnPoints2 = player1DeckSlot2;
			spawnPoints3 = player1DeckSlot3;
			spawnPoints4 = player1DeckSlot4;
			spawnPoints5 = player1DeckSlot5;
			spawnPoints6 = player1DeckSlot6;
			spawnPoints7 = player1DeckSlot7;
			spawnPoints8 = player1DeckSlot8;
			spawnPoints9 = player1DeckSlot9;
			spawnPoints10 = player1DeckSlot10;
			
			spawnPointsHand.Insert(0,spawnPoints1);
			spawnPointsHand.Insert(1,spawnPoints2);
			spawnPointsHand.Insert(2,spawnPoints3);
			spawnPointsHand.Insert(3,spawnPoints4);
			spawnPointsHand.Insert(4,spawnPoints5);
			spawnPointsHand.Insert(5,spawnPoints6);
			spawnPointsHand.Insert(6,spawnPoints7);
			spawnPointsHand.Insert(7,spawnPoints8);
			spawnPointsHand.Insert(8,spawnPoints9);
			spawnPointsHand.Insert(9,spawnPoints10);
			
			
		}
		
		// Update is called once per frame
		void Update () {
			
			if(mulliganCounter1 < numberOfMulligan){
			
				MulliganCardsDeck1();
			
			}else{
					
				return;
			}
			
			if(mulliganCounter2 < numberOfMulligan){
			
				MulliganCardsDeck2();
			
			}else{
					
				return;
			}
			
			if(mulliganCounter3 < numberOfMulligan){
			
				MulliganCardsDeck3();
			
			}else{
					
				return;
			}
			
			
		}
		
		
		void MulliganCardsDeck1(){
			
			//if(mulliganCounter1 < numberOfMulligan){
				
				Vector3 newPosition = new Vector3(-10.0f, 0.31f, -7.53f);
			
				ray = Camera.main.ScreenPointToRay(Input.mousePosition);

				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard1"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
											
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard1"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card1, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard1";
												
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard1a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard1a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card1a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard1a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard1b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard1b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card1b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard1b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard1c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard1c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card1c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard1c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard2"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard2"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card2, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard2";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard2a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard2a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card2a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard2a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard2b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard2b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card2b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard2b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard2c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard2c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card2c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard2c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard3"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name=="instantiated1HandCard3"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card3, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard3";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard3a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name=="instantiated1HandCard3a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card3a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard3a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard3b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard3b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card3b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard3b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard3c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard3c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card3c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard3c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard4"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
											
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard4"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card4, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard4";
												
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard4a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard4a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card4a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard4a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard4b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard4b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card4b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard4b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard4c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard4c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card4c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard4c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard5"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard5"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card5, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard5";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard5a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard5a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card5a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard5a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard5b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard5b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card5b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard5b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard5c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard5c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card5c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard5c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard6"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name=="instantiated1HandCard6"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card6, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard6";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard6a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name=="instantiated1HandCard6a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card6a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard6a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard6b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard6b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card6b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard6b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard6c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard6c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card6c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard6c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard7"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
											
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard7"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card7, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard7";
												
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard7a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard7a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card7a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard7a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard7b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard7b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card7b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard7b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard7c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard7c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card7c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard7c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard8"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard8"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card8, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard8";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard8a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard8a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card8a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard8a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard8b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard8b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card8b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard8b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard8c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard8c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card8c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard8c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard9"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name=="instantiated1HandCard9"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card9, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard9";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard9a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name=="instantiated1HandCard9a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card9a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard9a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard9b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard9b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card9b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard9b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard9c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard9c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card9c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard9c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard10"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name=="instantiated1HandCard10"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card10, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard10";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard10a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name=="instantiated1HandCard10a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card10a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard10a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard10b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard10b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card10b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard10b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard10c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard10c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card10c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard10c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard11"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
											
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard11"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card11, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard11";
												
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard11a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard11a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card11a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard11a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard11b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard11b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card11b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard11b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard11c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard11c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card11c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard11c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard12"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard12"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card12, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard12";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard12a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard12a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card12a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard12a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard12b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard12b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card12b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard12b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard12c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard12c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card12c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard12c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard13"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name=="instantiated1HandCard13"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card13, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard13";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard13a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name=="instantiated1HandCard13a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card13a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard13a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard13b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard13b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card13b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard13b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard13c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard13c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card13c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard13c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard14"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
											
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard14"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card14, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard14";
												
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard14a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard14a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card14a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard14a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard14b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard14b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card14b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard14b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard14c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard14c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card14c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard14c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard15"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard15"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card15, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard15";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard15a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard15a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card15a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard15a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard15b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard15b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card15b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard15b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard15c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard15c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card15c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard15c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard16"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name=="instantiated1HandCard16"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card16, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard16";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard16a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name=="instantiated1HandCard16a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card16a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard16a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard16b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard16b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card16b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard16b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard16c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard16c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card16c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard16c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard17"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
											
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard17"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card17, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard17";
												
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard17a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard17a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card17a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard17a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard17b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard17b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card17b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard17b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard17c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard17c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card17c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard17c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard18"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard18"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card18, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard18";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard18a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard18a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card18a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard18a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard18b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard18b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card18b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard18b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard18c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard18c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card18c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard18c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard19"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name=="instantiated1HandCard19"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card19, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard19";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard19a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name=="instantiated1HandCard19a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card19a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard19a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard19b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard19b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card19b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard19b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard19c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard19c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card19c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard19c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard20"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name=="instantiated1HandCard20"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card20, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard20";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard20a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name=="instantiated1HandCard20a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card20a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard20a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard20b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard20b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card20b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard20b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard20c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard20c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card20c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard20c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard21"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
											
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard21"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card21, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard21";
												
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard21a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard21a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card21a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard21a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard21b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard21b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card21b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard21b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard21c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard21c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card21c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard21c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard22"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard22"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card22, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard22";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard22a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard22a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card22a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard22a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard22b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard22b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card22b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard22b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard22c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard22c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card22c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard22c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard23"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name=="instantiated1HandCard23"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card23, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard23";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard23a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name=="instantiated1HandCard23a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card23a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard23a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard23b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard23b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card23b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard23b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard23c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard23c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card23c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard23c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard24"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
											
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard24"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card24, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard24";
												
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard24a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard24a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card24a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard24a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard24b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard24b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card24b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard24b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard24c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard24c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card24c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard24c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard25"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard25"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card25, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard25";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard25a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard25a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card25a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard25a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard25b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard25b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card25b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard25b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard25c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard25c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card25c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard25c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard26"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name=="instantiated1HandCard26"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card26, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard26";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard26a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name=="instantiated1HandCard26a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card26a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard26a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard26b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard26b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card26b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard26b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard26c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard26c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card26c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard26c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard27"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
											
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard27"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card27, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard27";
												
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard27a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard27a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card27a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard27a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard27b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard27b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card27b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard27b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard27c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard27c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card27c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard27c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard28"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard28"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card28, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard28";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard28a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard28a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card28a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard28a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard28b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard28b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card28b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard28b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard28c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard28c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card28c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard28c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard29"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name=="instantiated1HandCard29"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card29, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard29";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard29a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name=="instantiated1HandCard29a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card29a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard29a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard29b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard29b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card29b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard29b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard29c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard29c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card29c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard29c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard30"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name=="instantiated1HandCard30"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card30, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard30";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard30a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name=="instantiated1HandCard30a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card30a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard30a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard30b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard30b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card30b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard30b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard30c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard30c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card30c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard30c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard31"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
											
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard31"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card31, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard31";
												
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard31a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard31a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card31a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard31a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard31b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard31b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card31b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard31b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard31c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard31c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card31c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard31c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard32"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard32"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card32, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard32";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard32a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard32a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card32a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard32a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard32b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard32b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card32b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard32b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard32c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard32c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card32c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard32c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard33"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name=="instantiated1HandCard33"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card33, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard33";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard33a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name=="instantiated1HandCard33a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card33a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard33a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard33b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard33b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card33b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard33b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard33c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard33c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card33c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard33c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard34"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
											
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard34"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card34, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard34";
												
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard34a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard34a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card34a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard34a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard34b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard34b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card34b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard34b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard34c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard34c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card34c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard34c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard35"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard35"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card35, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard35";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard35a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard35a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card35a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard35a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard35b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard35b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card35b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard35b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard35c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard35c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card35c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard35c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard36"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name=="instantiated1HandCard36"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card36, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard36";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard36a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name=="instantiated1HandCard36a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card36a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard36a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard36b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard36b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card36b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard36b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard36c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard36c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card36c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard36c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard37"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
											
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard37"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card37, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard37";
												
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard37a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard37a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card37a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard37a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard37b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard37b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card37b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard37b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard37c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard37c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card37c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard37c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard38"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard38"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card38, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard38";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard38a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard38a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card38a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard38a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard38b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard38b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card38b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard38b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard38c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard38c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card38c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard38c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard39"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name=="instantiated1HandCard39"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card39, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard39";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard39a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name=="instantiated1HandCard39a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card39a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard39a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard39b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard39b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card39b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard39b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard39c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard39c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card39c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard39c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard40"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name=="instantiated1HandCard40"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card40, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard40";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard40a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name=="instantiated1HandCard40a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card40a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard40a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard40b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard40b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card40b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard40b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard40c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard40c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card40c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard40c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard41"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
											
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard41"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card41, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard41";
												
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard41a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard41a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card41a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard41a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard41b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard41b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card41b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard41b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard41c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard41c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card41c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard41c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard42"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard42"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card42, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard42";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard42a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard42a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card42a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard42a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard42b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard42b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card42b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard42b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard42c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard42c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card42c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard42c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard43"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name=="instantiated1HandCard43"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card43, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard43";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard43a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name=="instantiated1HandCard43a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card43a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard43a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard43b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard43b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card43b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard43b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard43c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard43c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card43c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard43c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard44"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
											
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard44"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card44, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard44";
												
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard44a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard44a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card44a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard44a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard44b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard44b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card44b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard44b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard44c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard44c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card44c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard44c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard45"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard45"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card45, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard45";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard45a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard45a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card45a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard45a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard45b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard45b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card45b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard45b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard45c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard45c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card45c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard45c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard46"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name=="instantiated1HandCard46"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card46, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard46";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard46a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name=="instantiated1HandCard46a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card46a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard46a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard46b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard46b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card46b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard46b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard46c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard46c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card46c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard46c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard47"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
											
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard47"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card47, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard47";
												
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard47a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard47a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card47a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard47a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard47b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard47b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card47b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard47b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard47c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard47c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card47c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard47c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard48"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard48"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card48, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard48";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard48a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard48a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card48a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard48a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard48b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard48b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card48b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard48b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard48c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard48c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card48c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard48c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard49"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name=="instantiated1HandCard49"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card49, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard49";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard49a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name=="instantiated1HandCard49a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card49a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard49a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard49b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard49b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card49b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard49b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard49c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard49c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card49c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard49c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard50"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name=="instantiated1HandCard50"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card50, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard50";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard50a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name=="instantiated1HandCard50a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card50a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard50a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard50b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard50b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card50b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard50b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard50c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard50c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card50c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard50c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard51"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
											
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard51"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card51, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard51";
												
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard51a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard1a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card51a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard51a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard51b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard51b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card51b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard51b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard51c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard51c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card51c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard51c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard52"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard52"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card52, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard52";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard52a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard52a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card52a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard52a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard52b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard52b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card52b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard52b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard52c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard52c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card52c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard52c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard53"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name=="instantiated1HandCard53"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card53, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard53";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard53a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name=="instantiated1HandCard53a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card53a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard53a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard53b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard53b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card53b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard53b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard53c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard53c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card53c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard53c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard54"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
											
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard54"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card54, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard54";
												
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard54a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard54a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card54a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard54a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard54b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard54b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card54b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard54b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard54c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard54c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card54c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard54c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard55"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard55"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card55, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard55";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard55a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard55a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card55a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard55a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard55b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard55b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card55b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard55b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard55c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard55c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card55c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard55c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard56"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name=="instantiated1HandCard56"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card56, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard56";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard56a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name=="instantiated1HandCard56a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card56a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard56a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard56b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard56b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card56b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard56b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard56c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard56c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card56c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard56c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard57"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
											
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard57"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card57, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard57";
												
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard57a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard57a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card57a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard57a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard57b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard57b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card57b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard57b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard57c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard57c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card57c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard57c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard58"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard58"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card58, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard58";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard58a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard58a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card58a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard58a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard58b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard58b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card58b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard58b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard58c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard58c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card58c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard58c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard59"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name=="instantiated1HandCard59"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card59, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard59";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard59a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name=="instantiated1HandCard59a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card59a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard59a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard59b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard59b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card59b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard59b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard59c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard59c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card59c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard59c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard60"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name=="instantiated1HandCard60"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card60, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard60";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard60a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name=="instantiated1HandCard60a"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card60a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard60a";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard60b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard60b"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card60b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard60b";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated1ScrollCard60c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton1.SetActive(true);
									
									for(int i = 0; i < loadDeckCards1.getHandCardsDeck1.Count; i++){
										
										if(loadDeckCards1.getHandCardsDeck1[i]){
					
											if(loadDeckCards1.getHandCardsDeck1[i].name =="instantiated1HandCard60c"){
												
												Destroy(loadDeckCards1.getHandCardsDeck1[i]);
												
												GameObject card = Instantiate (card60c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated1HandCard60c";
											}
										}
									}
									
									mulliganCounter1++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				
			
			
			//}
			
		}
		
		
		
		void MulliganCardsDeck2(){
			
			//if(mulliganCounter1 < numberOfMulligan){
				
				Vector3 newPosition = new Vector3(-10.0f, 0.31f, -7.53f);
			
				ray = Camera.main.ScreenPointToRay(Input.mousePosition);

				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard1"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
											
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard1"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card1, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard1";
												
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard1a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard1a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card1a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard1a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard1b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard1b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card1b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard1b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard1c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard1c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card1c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard1c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard2"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard2"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card2, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard2";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard2a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard2a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card2a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard2a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard2b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard2b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card2b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard2b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard2c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard2c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card2c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard2c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard3"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name=="instantiated2HandCard3"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card3, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard3";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard3a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name=="instantiated2HandCard3a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card3a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard3a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard3b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard3b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card3b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard3b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard3c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard3c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card3c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard3c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard4"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
											
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard4"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card4, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard4";
												
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard4a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard4a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card4a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard4a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard4b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard4b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card4b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard4b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard4c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard4c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card4c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard4c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard5"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard5"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card5, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard5";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard5a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard5a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card5a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard5a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard5b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard5b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card5b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard5b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard5c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard5c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card5c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard5c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard6"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name=="instantiated2HandCard6"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card6, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard6";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard6a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name=="instantiated2HandCard6a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card6a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard6a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard6b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard6b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card6b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard6b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard6c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard6c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card6c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard6c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard7"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
											
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard7"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card7, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard7";
												
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard7a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard7a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card7a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard7a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard7b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard7b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card7b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard7b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard7c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard7c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card7c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard7c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard8"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard8"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card8, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard8";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard8a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard8a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card8a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard8a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard8b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard8b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card8b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard8b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard8c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard8c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card8c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard8c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard9"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name=="instantiated2HandCard9"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card9, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard9";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard9a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name=="instantiated2HandCard9a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card9a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard9a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard9b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard9b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card9b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard9b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard9c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard9c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card9c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard9c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard10"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name=="instantiated2HandCard10"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card10, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard10";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard10a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name=="instantiated2HandCard10a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card10a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard10a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard10b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard10b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card10b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard10b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard10c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard10c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card10c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard10c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard11"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
											
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard11"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card11, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard11";
												
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard11a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard11a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card11a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard11a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard11b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard11b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card11b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard11b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard11c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard11c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card11c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard11c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard12"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard12"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card12, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard12";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard12a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard12a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card12a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard12a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard12b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard12b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card12b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard12b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard12c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard12c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card12c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard12c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard13"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name=="instantiated2HandCard13"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card13, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard13";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard13a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name=="instantiated2HandCard13a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card13a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard13a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard13b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard13b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card13b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard13b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard13c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard13c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card13c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard13c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard14"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
											
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard14"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card14, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard14";
												
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard14a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard14a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card14a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard14a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard14b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard14b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card14b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard14b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard14c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard14c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card14c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard14c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard15"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard15"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card15, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard15";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard15a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard15a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card15a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard15a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard15b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard15b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card15b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard15b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard15c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard15c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card15c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard15c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard16"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name=="instantiated2HandCard16"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card16, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard16";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard16a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name=="instantiated2HandCard16a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card16a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard16a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard16b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard16b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card16b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard16b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard16c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard16c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card16c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard16c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard17"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
											
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard17"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card17, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard17";
												
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard17a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard17a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card17a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard17a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard17b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard17b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card17b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard17b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard17c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard17c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card17c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard17c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard18"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard18"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card18, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard18";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard18a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard18a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card18a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard18a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard18b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard18b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card18b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard18b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard18c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard18c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card18c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard18c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard19"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name=="instantiated2HandCard19"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card19, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard19";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard19a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name=="instantiated2HandCard19a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card19a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard19a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard19b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard19b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card19b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard19b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard19c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard19c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card19c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard19c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard20"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name=="instantiated2HandCard20"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card20, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard20";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard20a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name=="instantiated2HandCard20a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card20a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard20a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard20b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard20b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card20b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard20b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard20c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard20c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card20c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard20c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard21"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
											
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard21"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card21, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard21";
												
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard21a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard21a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card21a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard21a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard21b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard21b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card21b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard21b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard21c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard21c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card21c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard21c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard22"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard22"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card22, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard22";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard22a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard22a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card22a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard22a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard22b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard22b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card22b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard22b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard22c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard22c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card22c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard22c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard23"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name=="instantiated2HandCard23"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card23, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard23";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard23a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name=="instantiated2HandCard23a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card23a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard23a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard23b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard23b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card23b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard23b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard23c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard23c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card23c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard23c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard24"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
											
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard24"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card24, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard24";
												
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard24a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard24a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card24a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard24a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard24b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard24b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card24b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard24b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard24c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard24c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card24c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard24c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard25"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard25"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card25, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard25";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard25a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard25a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card25a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard25a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard25b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard25b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card25b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard25b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard25c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard25c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card25c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard25c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard26"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name=="instantiated2HandCard26"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card26, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard26";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard26a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name=="instantiated2HandCard26a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card26a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard26a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard26b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard26b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card26b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard26b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard26c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard26c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card26c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard26c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard27"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
											
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard27"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card27, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard27";
												
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard27a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard27a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card27a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard27a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard27b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard27b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card27b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard27b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard27c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard27c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card27c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard27c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard28"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard28"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card28, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard28";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard28a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard28a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card28a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard28a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard28b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard28b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card28b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard28b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard28c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard28c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card28c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard28c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard29"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name=="instantiated2HandCard29"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card29, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard29";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard29a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name=="instantiated2HandCard29a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card29a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard29a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard29b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard29b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card29b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard29b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard29c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard29c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card29c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard29c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard30"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name=="instantiated2HandCard30"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card30, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard30";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard30a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name=="instantiated2HandCard30a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card30a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard30a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard30b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard30b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card30b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard30b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard30c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard30c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card30c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard30c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard31"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
											
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard31"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card31, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard31";
												
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard31a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard31a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card31a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard31a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard31b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard31b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card31b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard31b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard31c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard31c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card31c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard31c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard32"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard32"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card32, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard32";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard32a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard32a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card32a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard32a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard32b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard32b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card32b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard32b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard32c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard32c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card32c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard32c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard33"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name=="instantiated2HandCard33"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card33, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard33";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard33a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name=="instantiated2HandCard33a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card33a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard33a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard33b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard33b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card33b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard33b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard33c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard33c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card33c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard33c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard34"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
											
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard34"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card34, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard34";
												
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard34a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard34a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card34a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard34a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard34b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard34b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card34b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard34b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard34c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard34c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card34c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard34c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard35"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard35"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card35, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard35";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard35a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard35a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card35a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard35a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard35b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard35b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card35b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard35b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard35c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard35c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card35c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard35c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard36"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name=="instantiated2HandCard36"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card36, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard36";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard36a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name=="instantiated2HandCard36a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card36a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard36a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard36b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard36b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card36b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard36b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard36c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard36c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card36c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard36c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard37"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
											
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard37"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card37, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard37";
												
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard37a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard37a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card37a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard37a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard37b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard37b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card37b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard37b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard37c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard37c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card37c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard37c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard38"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard38"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card38, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard38";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard38a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard38a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card38a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard38a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard38b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard38b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card38b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard38b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard38c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard38c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card38c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard38c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard39"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name=="instantiated2HandCard39"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card39, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard39";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard39a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name=="instantiated2HandCard39a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card39a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard39a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard39b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard39b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card39b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard39b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard39c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard39c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card39c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard39c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard40"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name=="instantiated2HandCard40"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card40, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard40";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard40a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name=="instantiated2HandCard40a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card40a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard40a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard40b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard40b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card40b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard40b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard40c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard40c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card40c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard40c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard41"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
											
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard41"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card41, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard41";
												
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard41a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard41a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card41a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard41a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard41b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard41b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card41b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard41b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard41c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard41c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card41c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard41c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard42"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard42"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card42, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard42";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard42a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard42a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card42a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard42a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard42b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard42b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card42b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard42b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard42c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard42c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card42c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard42c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard43"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name=="instantiated2HandCard43"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card43, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard43";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard43a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name=="instantiated2HandCard43a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card43a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard43a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard43b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard43b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card43b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard43b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard43c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard43c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card43c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard43c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard44"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
											
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard44"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card44, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard44";
												
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard44a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard44a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card44a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard44a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard44b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard44b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card44b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard44b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard44c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard44c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card44c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard44c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard45"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard45"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card45, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard45";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard45a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard45a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card45a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard45a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard45b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard45b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card45b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard45b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard45c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard45c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card45c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard45c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard46"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name=="instantiated2HandCard46"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card46, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard46";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard46a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name=="instantiated2HandCard46a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card46a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard46a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard46b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard46b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card46b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard46b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard46c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard46c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card46c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard46c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard47"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
											
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard47"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card47, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard47";
												
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard47a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard47a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card47a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard47a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard47b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard47b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card47b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard47b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard47c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard47c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card47c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard47c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard48"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard48"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card48, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard48";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard48a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard48a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card48a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard48a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard48b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard48b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card48b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard48b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard48c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard48c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card48c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard48c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard49"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name=="instantiated2HandCard49"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card49, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard49";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard49a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name=="instantiated2HandCard49a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card49a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard49a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard49b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard49b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card49b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard49b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard49c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard49c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card49c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard49c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard50"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name=="instantiated2HandCard50"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card50, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard50";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard50a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name=="instantiated2HandCard50a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card50a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard50a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard50b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard50b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card50b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard50b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard50c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard50c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card50c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard50c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard51"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
											
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard51"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card51, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard51";
												
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard51a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard1a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card51a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard51a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard51b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard51b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card51b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard51b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard51c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard51c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card51c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard51c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard52"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard52"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card52, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard52";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard52a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard52a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card52a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard52a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard52b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard52b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card52b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard52b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard52c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard52c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card52c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard52c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard53"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name=="instantiated2HandCard53"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card53, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard53";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard53a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name=="instantiated2HandCard53a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card53a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard53a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard53b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard53b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card53b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard53b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard53c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard53c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card53c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard53c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard54"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
											
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard54"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card54, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard54";
												
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard54a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard54a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card54a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard54a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard54b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard54b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card54b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard54b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard54c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard54c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card54c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard54c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard55"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard55"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card55, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard55";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard55a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard55a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card55a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard55a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard55b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard55b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card55b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard55b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard55c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard55c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card55c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard55c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard56"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name=="instantiated2HandCard56"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card56, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard56";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard56a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name=="instantiated2HandCard56a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card56a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard56a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard56b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard56b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card56b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard56b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard56c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard56c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card56c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard56c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard57"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
											
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard57"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card57, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard57";
												
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard57a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard57a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card57a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard57a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard57b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard57b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card57b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard57b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard57c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard57c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card57c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard57c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard58"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard58"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card58, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard58";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard58a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard58a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card58a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard58a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard58b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard58b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card58b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard58b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard58c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard58c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card58c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard58c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard59"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name=="instantiated2HandCard59"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card59, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard59";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard59a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name=="instantiated2HandCard59a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card59a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard59a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard59b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard59b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card59b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard59b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard59c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard59c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card59c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard59c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard60"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name=="instantiated2HandCard60"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card60, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard60";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard60a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name=="instantiated2HandCard60a"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card60a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard60a";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard60b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard60b"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card60b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard60b";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated2ScrollCard60c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton2.SetActive(true);
									
									for(int i = 0; i < loadDeckCards2.getHandCardsDeck2.Count; i++){
										
										if(loadDeckCards2.getHandCardsDeck2[i]){
					
											if(loadDeckCards2.getHandCardsDeck2[i].name =="instantiated2HandCard60c"){
												
												Destroy(loadDeckCards2.getHandCardsDeck2[i]);
												
												GameObject card = Instantiate (card60c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated2HandCard60c";
											}
										}
									}
									
									mulliganCounter2++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				
			
			
			//}
			
		}
		
		
		void MulliganCardsDeck3(){
			
			//if(mulliganCounter3 < numberOfMulligan){
				
				Vector3 newPosition = new Vector3(-10.0f, 0.31f, -7.53f);
			
				ray = Camera.main.ScreenPointToRay(Input.mousePosition);

				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard1"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
											
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard1"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card1, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard1";
												
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard1a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard1a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card1a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard1a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard1b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard1b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card1b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard1b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard1c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard1c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card1c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard1c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard2"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard2"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card2, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard2";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard2a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard2a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card2a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard2a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard2b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard2b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card2b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard2b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard2c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard2c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card2c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard2c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard3"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name=="instantiated3HandCard3"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card3, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard3";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard3a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name=="instantiated3HandCard3a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card3a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard3a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard3b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard3b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card3b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard3b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard3c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard3c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card3c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard3c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard4"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
											
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard4"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card4, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard4";
												
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard4a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard4a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card4a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard4a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard4b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard4b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card4b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard4b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard4c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard4c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card4c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard4c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard5"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard5"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card5, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard5";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard5a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard5a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card5a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard5a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard5b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard5b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card5b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard5b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard5c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard5c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card5c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard5c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard6"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name=="instantiated3HandCard6"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card6, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard6";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard6a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name=="instantiated3HandCard6a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card6a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard6a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard6b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard6b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card6b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard6b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard6c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard6c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card6c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard6c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard7"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
											
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard7"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card7, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard7";
												
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard7a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard7a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card7a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard7a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard7b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard7b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card7b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard7b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard7c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard7c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card7c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard7c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard8"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard8"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card8, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard8";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard8a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard8a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card8a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard8a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard8b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard8b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card8b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard8b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard8c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard8c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card8c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard8c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard9"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name=="instantiated3HandCard9"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card9, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard9";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard9a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name=="instantiated3HandCard9a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card9a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard9a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard9b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard9b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card9b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard9b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard9c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard9c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card9c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard9c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard10"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name=="instantiated3HandCard10"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card10, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard10";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard10a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name=="instantiated3HandCard10a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card10a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard10a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard10b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard10b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card10b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard10b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard10c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard10c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card10c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard10c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard11"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
											
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard11"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card11, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard11";
												
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard11a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard11a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card11a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard11a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard11b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard11b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card11b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard11b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard11c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard11c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card11c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard11c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard12"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard12"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card12, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard12";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard12a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard12a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card12a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard12a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard12b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard12b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card12b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard12b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard12c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard12c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card12c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard12c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard13"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name=="instantiated3HandCard13"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card13, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard13";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard13a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name=="instantiated3HandCard13a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card13a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard13a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard13b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard13b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card13b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard13b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard13c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard13c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card13c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard13c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard14"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
											
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard14"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card14, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard14";
												
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard14a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard14a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card14a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard14a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard14b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard14b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card14b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard14b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard14c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard14c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card14c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard14c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard15"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard15"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card15, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard15";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard15a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard15a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card15a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard15a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard15b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard15b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card15b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard15b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard15c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard15c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card15c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard15c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard16"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name=="instantiated3HandCard16"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card16, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard16";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard16a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name=="instantiated3HandCard16a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card16a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard16a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard16b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard16b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card16b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard16b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard16c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard16c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card16c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard16c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard17"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
											
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard17"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card17, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard17";
												
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard17a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard17a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card17a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard17a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard17b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard17b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card17b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard17b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard17c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard17c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card17c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard17c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard18"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard18"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card18, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard18";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard18a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard18a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card18a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard18a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard18b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard18b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card18b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard18b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard18c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard18c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card18c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard18c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard19"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name=="instantiated3HandCard19"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card19, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard19";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard19a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name=="instantiated3HandCard19a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card19a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard19a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard19b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard19b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card19b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard19b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard19c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard19c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card19c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard19c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard20"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name=="instantiated3HandCard20"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card20, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard20";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard20a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name=="instantiated3HandCard20a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card20a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard20a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard20b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard20b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card20b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard20b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard20c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard20c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card20c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard20c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard21"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
											
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard21"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card21, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard21";
												
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard21a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard21a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card21a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard21a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard21b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard21b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card21b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard21b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard21c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard21c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card21c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard21c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard22"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard22"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card22, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard22";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard22a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard22a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card22a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard22a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard22b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard22b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card22b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard22b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard22c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard22c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card22c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard22c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard23"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name=="instantiated3HandCard23"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card23, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard23";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard23a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name=="instantiated3HandCard23a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card23a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard23a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard23b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard23b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card23b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard23b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard23c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard23c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card23c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard23c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard24"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
											
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard24"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card24, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard24";
												
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard24a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard24a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card24a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard24a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard24b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard24b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card24b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard24b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard24c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard24c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card24c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard24c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard25"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard25"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card25, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard25";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard25a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard25a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card25a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard25a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard25b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard25b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card25b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard25b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard25c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard25c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card25c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard25c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard26"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name=="instantiated3HandCard26"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card26, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard26";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard26a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name=="instantiated3HandCard26a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card26a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard26a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard26b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard26b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card26b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard26b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard26c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard26c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card26c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard26c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard27"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
											
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard27"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card27, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard27";
												
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard27a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard27a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card27a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard27a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard27b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard27b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card27b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard27b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard27c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard27c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card27c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard27c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard28"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard28"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card28, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard28";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard28a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard28a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card28a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard28a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard28b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard28b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card28b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard28b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard28c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard28c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card28c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard28c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard29"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name=="instantiated3HandCard29"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card29, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard29";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard29a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name=="instantiated3HandCard29a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card29a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard29a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard29b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard29b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card29b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard29b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard29c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard29c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card29c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard29c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard30"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name=="instantiated3HandCard30"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card30, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard30";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard30a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name=="instantiated3HandCard30a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card30a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard30a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard30b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard30b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card30b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard30b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard30c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard30c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card30c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard30c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard31"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
											
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard31"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card31, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard31";
												
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard31a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard31a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card31a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard31a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard31b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard31b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card31b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard31b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard31c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard31c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card31c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard31c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard32"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard32"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card32, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard32";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard32a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard32a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card32a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard32a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard32b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard32b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card32b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard32b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard32c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard32c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card32c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard32c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard33"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name=="instantiated3HandCard33"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card33, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard33";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard33a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name=="instantiated3HandCard33a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card33a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard33a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard33b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard33b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card33b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard33b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard33c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard33c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card33c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard33c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard34"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
											
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard34"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card34, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard34";
												
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard34a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard34a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card34a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard34a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard34b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard34b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card34b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard34b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard34c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard34c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card34c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard34c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard35"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard35"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card35, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard35";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard35a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard35a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card35a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard35a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard35b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard35b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card35b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard35b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard35c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard35c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card35c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard35c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard36"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name=="instantiated3HandCard36"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card36, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard36";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard36a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name=="instantiated3HandCard36a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card36a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard36a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard36b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard36b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card36b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard36b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard36c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard36c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card36c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard36c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard37"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
											
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard37"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card37, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard37";
												
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard37a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard37a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card37a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard37a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard37b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard37b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card37b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard37b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard37c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard37c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card37c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard37c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard38"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard38"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card38, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard38";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard38a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard38a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card38a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard38a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard38b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard38b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card38b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard38b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard38c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard38c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card38c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard38c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard39"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name=="instantiated3HandCard39"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card39, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard39";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard39a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name=="instantiated3HandCard39a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card39a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard39a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard39b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard39b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card39b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard39b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard39c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard39c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card39c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard39c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard40"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name=="instantiated3HandCard40"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card40, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard40";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard40a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name=="instantiated3HandCard40a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card40a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard40a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard40b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard40b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card40b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard40b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard40c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard40c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card40c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard40c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard41"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
											
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard41"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card41, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard41";
												
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard41a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard41a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card41a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard41a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard41b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard41b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card41b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard41b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard41c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard41c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card41c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard41c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard42"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard42"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card42, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard42";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard42a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard42a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card42a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard42a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard42b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard42b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card42b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard42b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard42c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard42c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card42c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard42c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard43"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name=="instantiated3HandCard43"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card43, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard43";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard43a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name=="instantiated3HandCard43a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card43a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard43a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard43b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard43b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card43b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard43b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard43c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard43c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card43c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard43c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard44"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
											
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard44"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card44, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard44";
												
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard44a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard44a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card44a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard44a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard44b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard44b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card44b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard44b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard44c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard44c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card44c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard44c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard45"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard45"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card45, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard45";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard45a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard45a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card45a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard45a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard45b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard45b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card45b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard45b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard45c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard45c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card45c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard45c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard46"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name=="instantiated3HandCard46"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card46, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard46";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard46a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name=="instantiated3HandCard46a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card46a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard46a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard46b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard46b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card46b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard46b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard46c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard46c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card46c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard46c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard47"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
											
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard47"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card47, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard47";
												
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard47a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard47a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card47a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard47a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard47b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard47b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card47b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard47b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard47c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard47c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card47c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard47c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard48"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard48"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card48, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard48";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard48a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard48a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card48a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard48a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard48b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard48b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card48b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard48b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard48c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard48c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card48c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard48c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard49"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name=="instantiated3HandCard49"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card49, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard49";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard49a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name=="instantiated3HandCard49a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card49a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard49a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard49b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard49b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card49b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard49b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard49c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard49c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card49c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard49c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard50"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name=="instantiated3HandCard50"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card50, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard50";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard50a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name=="instantiated3HandCard50a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card50a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard50a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard50b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard50b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card50b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard50b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard50c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard50c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card50c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard50c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard51"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
											
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard51"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card51, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard51";
												
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard51a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard1a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card51a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard51a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard51b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard51b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card51b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard51b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard51c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard51c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card51c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard51c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard52"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard52"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card52, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard52";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard52a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard52a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card52a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard52a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard52b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard52b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card52b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard52b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard52c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard52c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card52c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard52c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard53"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name=="instantiated3HandCard53"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card53, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard53";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard53a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name=="instantiated3HandCard53a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card53a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard53a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard53b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard53b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card53b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard53b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard53c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard53c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card53c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard53c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard54"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
											
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard54"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card54, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard54";
												
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard54a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard54a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card54a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard54a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard54b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard54b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card54b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard54b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard54c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard54c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card54c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard54c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard55"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard55"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card55, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard55";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard55a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard55a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card55a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard55a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard55b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard55b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card55b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard55b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard55c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard55c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card55c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard55c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard56"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name=="instantiated3HandCard56"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card56, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard56";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard56a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name=="instantiated3HandCard56a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card56a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard56a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard56b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard56b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card56b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard56b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard56c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard56c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card56c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard56c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard57"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
											
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard57"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card57, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard57";
												
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard57a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard57a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card57a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard57a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard57b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard57b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card57b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard57b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard57c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard57c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card57c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard57c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard58"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard58"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card58, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard58";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard58a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard58a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card58a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard58a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard58b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard58b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card58b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard58b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard58c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard58c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card58c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard58c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard59"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name=="instantiated3HandCard59"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card59, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard59";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard59a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name=="instantiated3HandCard59a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card59a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard59a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard59b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard59b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card59b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard59b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard59c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard59c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card59c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard59c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard60"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name=="instantiated3HandCard60"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card60, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard60";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard60a"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name=="instantiated3HandCard60a"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card60a, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard60a";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard60b"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard60b"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card60b, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard60b";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				if(Physics.Raycast(ray,out hit)){
					
					if(hit.collider.gameObject.name == "instantiated3ScrollCard60c"){
						
						//if(hit.collider.gameObject.transform.localScale.magnitude >= modelCardScale.magnitude){
							
							if(Input.GetKeyDown(KeyCode.Mouse0)){
								
								if(Time.time - lastClickTime < catchTime){
									
									doneButton3.SetActive(true);
									
									for(int i = 0; i < loadDeckCards3.getHandCardsDeck3.Count; i++){
										
										if(loadDeckCards3.getHandCardsDeck3[i]){
					
											if(loadDeckCards3.getHandCardsDeck3[i].name =="instantiated3HandCard60c"){
												
												Destroy(loadDeckCards3.getHandCardsDeck3[i]);
												
												GameObject card = Instantiate (card60c, newPosition, Quaternion.identity) as GameObject;
												card.transform.localScale = new Vector3(325f,200f,340.0f);
												card.name = "instantiated3HandCard60c";
											}
										}
									}
									
									mulliganCounter3++;	
								}
									lastClickTime = Time.time;
							}
						//}				
					 
					}
				}
				
				
				
			
			
			//}
			
		}
		
		
		
		
		
	}
}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.UI;

namespace Caerwent {

    public class LoadDeckCards1 : MonoBehaviour {

        static readonly string BINARY_FILE = "cardsDeck1.dat";

        public GameObject[] allObjects;
        public GameObject[] allObjects1;
        public List<Vector3> spawnPointsDeck1 = new List<Vector3>();
        public List<string> cardsDeck1 = new List<string>();
        public List<GameObject> playCardsDeck1 = new List<GameObject>();
        public List<GameObject> getHandCardsDeck1 = new List<GameObject>();

        private int NumberOfCards;
        private Vector3 spawnPoint = new Vector3(10.0f, 0.35f, -7.55f);
        private GameObject mulliganInfo;
        private GameObject doneButton1;
        private GameObject handCardCollection;
        public bool isScrollDeck1;

        private int instances1;
        private int instances2;
        private int instances3;
        private int instances4;
        private int instances5;
        private int instances6;
        private int instances7;
        private int instances8;
        private int instances9;
        private int instances10;

        private int instances1M;
        private int instances2M;
        private int instances3M;
        private int instances4M;
        private int instances5M;
        private int instances6M;
        private int instances7M;
        private int instances8M;
        private int instances9M;
        private int instances10M;

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

        private Vector3 spawnPoints1;
        private Vector3 spawnPoints2;
        private Vector3 spawnPoints3;
        private Vector3 spawnPoints4;
        private Vector3 spawnPoints5;
        private Vector3 spawnPoints6;
        private Vector3 spawnPoints7;
        private Vector3 spawnPoints8;
        private Vector3 spawnPoints9;
        private Vector3 spawnPoints10;


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


        void Awake() {

            mulliganInfo = GameObject.Find("MulliganInformation");
            doneButton1 = GameObject.Find("DoneButton1");
            handCardCollection = GameObject.Find("HandCardCollection");

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
        }

        // Use this for initialization
        void Start() {

            mulliganInfo.SetActive(false);
            isScrollDeck1 = false;

            NumberOfCards = 1;

            instances1 = 0;
            instances2 = 0;
            instances3 = 0;
            instances4 = 0;
            instances5 = 0;
            instances6 = 0;
            instances7 = 0;
            instances8 = 0;
            instances9 = 0;
            instances10 = 0;

            instances1M = 0;
            instances2M = 0;
            instances3M = 0;
            instances4M = 0;
            instances5M = 0;
            instances6M = 0;
            instances7M = 0;
            instances8M = 0;
            instances9M = 0;
            instances10M = 0;

            spawnPoints1 = player1DeckSlot1.transform.position;
            spawnPoints2 = player1DeckSlot2.transform.position;
            spawnPoints3 = player1DeckSlot3.transform.position;
            spawnPoints4 = player1DeckSlot4.transform.position;
            spawnPoints5 = player1DeckSlot5.transform.position;
            spawnPoints6 = player1DeckSlot6.transform.position;
            spawnPoints7 = player1DeckSlot7.transform.position;
            spawnPoints8 = player1DeckSlot8.transform.position;
            spawnPoints9 = player1DeckSlot9.transform.position;
            spawnPoints10 = player1DeckSlot10.transform.position;

            spawnPointsDeck1.Insert(0, spawnPoints1);
            spawnPointsDeck1.Insert(1, spawnPoints2);
            spawnPointsDeck1.Insert(2, spawnPoints3);
            spawnPointsDeck1.Insert(3, spawnPoints4);
            spawnPointsDeck1.Insert(4, spawnPoints5);
            spawnPointsDeck1.Insert(5, spawnPoints6);
            spawnPointsDeck1.Insert(6, spawnPoints7);
            spawnPointsDeck1.Insert(7, spawnPoints8);
            spawnPointsDeck1.Insert(8, spawnPoints9);
            spawnPointsDeck1.Insert(9, spawnPoints10);

        }

        // Update is called once per frame
        void Update() {

        }

        public void LoadDeck1() {
            isScrollDeck1 = true;
            if (File.Exists(Path.Combine(Application.persistentDataPath, BINARY_FILE))) {

                BinaryFormatter bf = new BinaryFormatter();

                FileStream file = File.Open(Path.Combine(Application.persistentDataPath, BINARY_FILE), FileMode.Open);
                DataToSave1 data = (DataToSave1)bf.Deserialize(file);
                file.Close();
                cardsDeck1 = data.cardsDeck1;
                //Debug.Log(cardsDeck1.Count);


                foreach (string cardReference in cardsDeck1) {

                    if (cardReference == "instantiated1Card1") {

                        GameObject card = Instantiate(card1, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card1";


                    }

                    if (cardReference == "instantiated1Card1a") {

                        GameObject card = Instantiate(card1a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card1a";

                    }

                    if (cardReference == "instantiated1Card1b") {


                        GameObject card = Instantiate(card1b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card1b";

                    }

                    if (cardReference == "instantiated1Card1c") {


                        GameObject card = Instantiate(card1c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card1c";

                    }

                    if (cardReference == "instantiated1Card2") {


                        GameObject card = Instantiate(card2, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card2";

                    }

                    if (cardReference == "instantiated1Card2a") {


                        GameObject card = Instantiate(card2a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card2a";

                    }

                    if (cardReference == "instantiated1Card2b") {


                        GameObject card = Instantiate(card2b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card2b";

                    }

                    if (cardReference == "instantiated1Card2c") {


                        GameObject card = Instantiate(card2c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card2c";

                    }

                    if (cardReference == "instantiated1Card3") {


                        GameObject card = Instantiate(card3, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card3";

                    }

                    if (cardReference == "instantiated1Card3a") {


                        GameObject card = Instantiate(card3a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card3a";

                    }

                    if (cardReference == "instantiated1Card3b") {


                        GameObject card = Instantiate(card3b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card3b";

                    }

                    if (cardReference == "instantiated1Card3c") {


                        GameObject card = Instantiate(card3c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card3c";

                    }

                    if (cardReference == "instantiated1Card4") {


                        GameObject card = Instantiate(card4, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card4";

                    }

                    if (cardReference == "instantiated1Card4a") {


                        GameObject card = Instantiate(card4a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card4a";

                    }

                    if (cardReference == "instantiated1Card4b") {


                        GameObject card = Instantiate(card4b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card4b";

                    }

                    if (cardReference == "instantiated1Card4c") {


                        GameObject card = Instantiate(card4c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card4c";

                    }

                    if (cardReference == "instantiated1Card5") {


                        GameObject card = Instantiate(card5, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card5";

                    }

                    if (cardReference == "instantiated1Card5a") {


                        GameObject card = Instantiate(card5a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card5a";

                    }

                    if (cardReference == "instantiated1Card5b") {


                        GameObject card = Instantiate(card5b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card5b";

                    }

                    if (cardReference == "instantiated1Card5c") {


                        GameObject card = Instantiate(card5c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card5c";

                    }

                    if (cardReference == "instantiated1Card6") {


                        GameObject card = Instantiate(card6, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card6";

                    }

                    if (cardReference == "instantiated1Card6a") {


                        GameObject card = Instantiate(card6a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card6a";

                    }

                    if (cardReference == "instantiated1Card6b") {


                        GameObject card = Instantiate(card6b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card6b";

                    }

                    if (cardReference == "instantiated1Card6c") {


                        GameObject card = Instantiate(card6c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card6c";

                    }

                    if (cardReference == "instantiated1Card7") {


                        GameObject card = Instantiate(card7, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card7";

                    }

                    if (cardReference == "instantiated1Card7a") {


                        GameObject card = Instantiate(card7a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card7a";

                    }

                    if (cardReference == "instantiated1Card7b") {


                        GameObject card = Instantiate(card7b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card7b";

                    }

                    if (cardReference == "instantiated1Card7c") {


                        GameObject card = Instantiate(card7c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card7c";

                    }

                    if (cardReference == "instantiated1Card8") {


                        GameObject card = Instantiate(card8, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card8";

                    }

                    if (cardReference == "instantiated1Card8a") {


                        GameObject card = Instantiate(card8a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card8a";

                    }

                    if (cardReference == "instantiated1Card8b") {


                        GameObject card = Instantiate(card8b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card8b";

                    }

                    if (cardReference == "instantiated1Card8c") {


                        GameObject card = Instantiate(card8c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card8c";

                    }

                    if (cardReference == "instantiated1Card9") {


                        GameObject card = Instantiate(card9, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card9";

                    }

                    if (cardReference == "instantiated1Card9a") {


                        GameObject card = Instantiate(card9a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card9a";

                    }

                    if (cardReference == "instantiated1Card9b") {


                        GameObject card = Instantiate(card9b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card9b";

                    }

                    if (cardReference == "instantiated1Card9c") {


                        GameObject card = Instantiate(card9c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card9c";

                    }

                    if (cardReference == "instantiated1Card10") {


                        GameObject card = Instantiate(card10, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card10";

                    }

                    if (cardReference == "instantiated1Card10a") {


                        GameObject card = Instantiate(card10a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card10a";

                    }

                    if (cardReference == "instantiated1Card10b") {


                        GameObject card = Instantiate(card10b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card10b";

                    }

                    if (cardReference == "instantiated1Card10c") {


                        GameObject card = Instantiate(card10c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card10c";

                    }

                    if (cardReference == "instantiated1Card11") {


                        GameObject card = Instantiate(card11, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card11";

                    }

                    if (cardReference == "instantiated1Card11a") {


                        GameObject card = Instantiate(card11a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card11a";

                    }

                    if (cardReference == "instantiated1Card11b") {


                        GameObject card = Instantiate(card11b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card11b";

                    }

                    if (cardReference == "instantiated1Card11c") {


                        GameObject card = Instantiate(card11c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card11c";

                    }

                    if (cardReference == "instantiated1Card12") {


                        GameObject card = Instantiate(card12, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card12";

                    }

                    if (cardReference == "instantiated1Card12a") {


                        GameObject card = Instantiate(card12a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card12a";

                    }

                    if (cardReference == "instantiated1Card12b") {


                        GameObject card = Instantiate(card12b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card12b";

                    }

                    if (cardReference == "instantiated1Card12c") {


                        GameObject card = Instantiate(card12c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card12c";

                    }

                    if (cardReference == "instantiated1Card13") {


                        GameObject card = Instantiate(card13, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card13";

                    }

                    if (cardReference == "instantiated1Card13a") {


                        GameObject card = Instantiate(card13a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card13a";

                    }

                    if (cardReference == "instantiated1Card13b") {


                        GameObject card = Instantiate(card13b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card13b";

                    }

                    if (cardReference == "instantiated1Card13c") {


                        GameObject card = Instantiate(card13c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card13c";

                    }

                    if (cardReference == "instantiated1Card14") {


                        GameObject card = Instantiate(card14, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card14";

                    }

                    if (cardReference == "instantiated1Card14a") {


                        GameObject card = Instantiate(card14a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card14a";

                    }

                    if (cardReference == "instantiated1Card14b") {


                        GameObject card = Instantiate(card14b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card14b";

                    }

                    if (cardReference == "instantiated1Card14c") {


                        GameObject card = Instantiate(card14c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card14c";

                    }

                    if (cardReference == "instantiated1Card15") {


                        GameObject card = Instantiate(card15, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card15";

                    }

                    if (cardReference == "instantiated1Card15a") {


                        GameObject card = Instantiate(card15a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card15a";

                    }

                    if (cardReference == "instantiated1Card15b") {


                        GameObject card = Instantiate(card15b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card15b";

                    }

                    if (cardReference == "instantiated1Card15c") {


                        GameObject card = Instantiate(card15c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card15c";

                    }

                    if (cardReference == "instantiated1Card16") {


                        GameObject card = Instantiate(card16, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card16";

                    }

                    if (cardReference == "instantiated1Card16a") {


                        GameObject card = Instantiate(card16a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card16a";

                    }

                    if (cardReference == "instantiated1Card16b") {


                        GameObject card = Instantiate(card16b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card16b";

                    }

                    if (cardReference == "instantiated1Card16c") {


                        GameObject card = Instantiate(card16c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card16c";

                    }

                    if (cardReference == "instantiated1Card17") {


                        GameObject card = Instantiate(card17, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card17";

                    }

                    if (cardReference == "instantiated1Card17a") {


                        GameObject card = Instantiate(card17a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card17a";

                    }

                    if (cardReference == "instantiated1Card17b") {


                        GameObject card = Instantiate(card17b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card17b";

                    }

                    if (cardReference == "instantiated1Card17c") {


                        GameObject card = Instantiate(card17c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card17c";

                    }

                    if (cardReference == "instantiated1Card18") {


                        GameObject card = Instantiate(card18, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card18";

                    }

                    if (cardReference == "instantiated1Card18a") {


                        GameObject card = Instantiate(card18a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card18a";

                    }

                    if (cardReference == "instantiated1Card18b") {


                        GameObject card = Instantiate(card18b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card18b";

                    }

                    if (cardReference == "instantiated1Card18c") {


                        GameObject card = Instantiate(card18c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card18c";

                    }

                    if (cardReference == "instantiated1Card19") {


                        GameObject card = Instantiate(card19, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card19";

                    }

                    if (cardReference == "instantiated1Card19a") {


                        GameObject card = Instantiate(card19a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card19a";

                    }

                    if (cardReference == "instantiated1Card19b") {


                        GameObject card = Instantiate(card19b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card19b";

                    }

                    if (cardReference == "instantiated1Card19c") {


                        GameObject card = Instantiate(card19c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card19c";

                    }

                    if (cardReference == "instantiated1Card20") {


                        GameObject card = Instantiate(card20, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card20";

                    }

                    if (cardReference == "instantiated1Card20a") {


                        GameObject card = Instantiate(card20a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card20a";

                    }

                    if (cardReference == "instantiated1Card20b") {


                        GameObject card = Instantiate(card20b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card20b";

                    }

                    if (cardReference == "instantiated1Card20c") {


                        GameObject card = Instantiate(card20c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card20c";

                    }

                    if (cardReference == "instantiated1Card21") {


                        GameObject card = Instantiate(card21, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card21";

                    }

                    if (cardReference == "instantiated1Card21a") {


                        GameObject card = Instantiate(card21a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card21a";

                    }

                    if (cardReference == "instantiated1Card21b") {


                        GameObject card = Instantiate(card21b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card21b";

                    }

                    if (cardReference == "instantiated1Card21c") {


                        GameObject card = Instantiate(card21c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card21c";

                    }

                    if (cardReference == "instantiated1Card22") {


                        GameObject card = Instantiate(card22, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card22";

                    }

                    if (cardReference == "instantiated1Card22a") {


                        GameObject card = Instantiate(card22a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card22a";

                    }

                    if (cardReference == "instantiated1Card22b") {


                        GameObject card = Instantiate(card22b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card22b";

                    }

                    if (cardReference == "instantiated1Card22c") {


                        GameObject card = Instantiate(card22c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card22c";

                    }

                    if (cardReference == "instantiated1Card23") {


                        GameObject card = Instantiate(card23, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card23";

                    }

                    if (cardReference == "instantiated1Card23a") {


                        GameObject card = Instantiate(card23a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card23a";

                    }

                    if (cardReference == "instantiated1Card23b") {


                        GameObject card = Instantiate(card23b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card23b";

                    }

                    if (cardReference == "instantiated1Card23c") {


                        GameObject card = Instantiate(card23c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card23c";

                    }

                    if (cardReference == "instantiated1Card24") {


                        GameObject card = Instantiate(card24, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card24";

                    }

                    if (cardReference == "instantiated1Card24a") {


                        GameObject card = Instantiate(card24a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card24a";

                    }

                    if (cardReference == "instantiated1Card24b") {


                        GameObject card = Instantiate(card24b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card24b";

                    }

                    if (cardReference == "instantiated1Card24c") {


                        GameObject card = Instantiate(card24c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card24c";

                    }

                    if (cardReference == "instantiated1Card25") {


                        GameObject card = Instantiate(card25, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card25";

                    }

                    if (cardReference == "instantiated1Card25a") {


                        GameObject card = Instantiate(card25a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card25a";

                    }

                    if (cardReference == "instantiated1Card25b") {


                        GameObject card = Instantiate(card25b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card25b";

                    }

                    if (cardReference == "instantiated1Card25c") {


                        GameObject card = Instantiate(card25c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card25c";

                    }

                    if (cardReference == "instantiated1Card26") {


                        GameObject card = Instantiate(card26, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card26";

                    }

                    if (cardReference == "instantiated1Card26a") {


                        GameObject card = Instantiate(card26a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card26a";

                    }

                    if (cardReference == "instantiated1Card26b") {


                        GameObject card = Instantiate(card26b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card26b";

                    }

                    if (cardReference == "instantiated1Card26c") {


                        GameObject card = Instantiate(card26c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card26c";

                    }

                    if (cardReference == "instantiated1Card27") {


                        GameObject card = Instantiate(card27, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card27";

                    }

                    if (cardReference == "instantiated1Card27a") {


                        GameObject card = Instantiate(card27a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card27a";

                    }

                    if (cardReference == "instantiated1Card27b") {


                        GameObject card = Instantiate(card27b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card27b";

                    }

                    if (cardReference == "instantiated1Card27c") {


                        GameObject card = Instantiate(card27c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card27c";

                    }

                    if (cardReference == "instantiated1Card28") {


                        GameObject card = Instantiate(card28, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card28";

                    }

                    if (cardReference == "instantiated1Card28a") {


                        GameObject card = Instantiate(card28a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card28a";

                    }

                    if (cardReference == "instantiated1Card28b") {


                        GameObject card = Instantiate(card28b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card28b";

                    }

                    if (cardReference == "instantiated1Card28c") {


                        GameObject card = Instantiate(card28c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card28c";

                    }

                    if (cardReference == "instantiated1Card29") {


                        GameObject card = Instantiate(card29, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card29";

                    }

                    if (cardReference == "instantiated1Card29a") {


                        GameObject card = Instantiate(card29a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card29a";

                    }

                    if (cardReference == "instantiated1Card29b") {


                        GameObject card = Instantiate(card29b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card29b";

                    }

                    if (cardReference == "instantiated1Card29c") {


                        GameObject card = Instantiate(card29c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card29c";

                    }

                    if (cardReference == "instantiated1Card30") {


                        GameObject card = Instantiate(card30, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card30";

                    }

                    if (cardReference == "instantiated1Card30a") {


                        GameObject card = Instantiate(card30a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card30a";

                    }

                    if (cardReference == "instantiated1Card30b") {


                        GameObject card = Instantiate(card30b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card30b";

                    }

                    if (cardReference == "instantiated1Card30c") {


                        GameObject card = Instantiate(card30c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card30c";

                    }

                    if (cardReference == "instantiated1Card31") {


                        GameObject card = Instantiate(card31, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card31";

                    }

                    if (cardReference == "instantiated1Card31a") {


                        GameObject card = Instantiate(card31a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card31a";

                    }

                    if (cardReference == "instantiated1Card31b") {


                        GameObject card = Instantiate(card31b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card31b";

                    }

                    if (cardReference == "instantiated1Card31c") {


                        GameObject card = Instantiate(card31c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card31c";

                    }

                    if (cardReference == "instantiated1Card32") {


                        GameObject card = Instantiate(card32, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card32";

                    }

                    if (cardReference == "instantiated1Card32a") {


                        GameObject card = Instantiate(card32a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card32a";

                    }

                    if (cardReference == "instantiated1Card32b") {


                        GameObject card = Instantiate(card32b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card32b";

                    }

                    if (cardReference == "instantiated1Card32c") {


                        GameObject card = Instantiate(card32c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card32c";

                    }

                    if (cardReference == "instantiated1Card33") {


                        GameObject card = Instantiate(card33, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card33";

                    }

                    if (cardReference == "instantiated1Card33a") {


                        GameObject card = Instantiate(card33a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card33a";

                    }

                    if (cardReference == "instantiated1Card33b") {


                        GameObject card = Instantiate(card33b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card33b";

                    }

                    if (cardReference == "instantiated1Card33c") {


                        GameObject card = Instantiate(card33c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card33c";

                    }

                    if (cardReference == "instantiated1Card34") {


                        GameObject card = Instantiate(card34, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card34";

                    }

                    if (cardReference == "instantiated1Card34a") {


                        GameObject card = Instantiate(card34a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card34a";

                    }

                    if (cardReference == "instantiated1Card34b") {


                        GameObject card = Instantiate(card34b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card34b";

                    }

                    if (cardReference == "instantiated1Card34c") {


                        GameObject card = Instantiate(card34c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card34c";

                    }

                    if (cardReference == "instantiated1Card35") {


                        GameObject card = Instantiate(card35, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card35";

                    }

                    if (cardReference == "instantiated1Card35a") {


                        GameObject card = Instantiate(card35a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card35a";

                    }

                    if (cardReference == "instantiated1Card35b") {


                        GameObject card = Instantiate(card35b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card35b";

                    }

                    if (cardReference == "instantiated1Card35c") {


                        GameObject card = Instantiate(card35c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card35c";
                    }

                    if (cardReference == "instantiated1Card36") {


                        GameObject card = Instantiate(card36, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card36";

                    }

                    if (cardReference == "instantiated1Card36a") {


                        GameObject card = Instantiate(card36a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card36a";

                    }

                    if (cardReference == "instantiated1Card36b") {


                        GameObject card = Instantiate(card36b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card36b";

                    }

                    if (cardReference == "instantiated1Card36c") {


                        GameObject card = Instantiate(card36c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card36c";

                    }

                    if (cardReference == "instantiated1Card37") {


                        GameObject card = Instantiate(card37, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card37";

                    }

                    if (cardReference == "instantiated1Card37a") {


                        GameObject card = Instantiate(card37a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card37a";

                    }

                    if (cardReference == "instantiated1Card37b") {


                        GameObject card = Instantiate(card37b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card37b";

                    }

                    if (cardReference == "instantiated1Card37c") {


                        GameObject card = Instantiate(card37c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card37c";

                    }

                    if (cardReference == "instantiated1Card38") {


                        GameObject card = Instantiate(card38, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card38";

                    }

                    if (cardReference == "instantiated1Card38a") {


                        GameObject card = Instantiate(card38a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card38a";


                    }

                    if (cardReference == "instantiated1Card38b") {


                        GameObject card = Instantiate(card38b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card38b";

                    }

                    if (cardReference == "instantiated1Card38c") {


                        GameObject card = Instantiate(card38c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card38c";

                    }

                    if (cardReference == "instantiated1Card39") {


                        GameObject card = Instantiate(card39, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card39";

                    }

                    if (cardReference == "instantiated1Card39a") {


                        GameObject card = Instantiate(card39a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card39a";

                    }

                    if (cardReference == "instantiated1Card39b") {


                        GameObject card = Instantiate(card39b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card39b";

                    }

                    if (cardReference == "instantiated1Card39c") {


                        GameObject card = Instantiate(card39c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card39c";

                    }

                    if (cardReference == "instantiated1Card40") {


                        GameObject card = Instantiate(card40, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card40";

                    }

                    if (cardReference == "instantiated1Card40a") {


                        GameObject card = Instantiate(card40a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card40a";

                    }

                    if (cardReference == "instantiated1Card40b") {


                        GameObject card = Instantiate(card40b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card40b";

                    }

                    if (cardReference == "instantiated1Card40c") {


                        GameObject card = Instantiate(card40c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card40c";

                    }

                    if (cardReference == "instantiated1Card41") {


                        GameObject card = Instantiate(card41, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card41";

                    }

                    if (cardReference == "instantiated1Card41a") {


                        GameObject card = Instantiate(card41a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card41a";


                    }

                    if (cardReference == "instantiated1Card41b") {


                        GameObject card = Instantiate(card41b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card41b";

                    }

                    if (cardReference == "instantiated1Card41c") {


                        GameObject card = Instantiate(card41c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card41c";


                    }

                    if (cardReference == "instantiated1Card42") {


                        GameObject card = Instantiate(card42, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card42";


                    }

                    if (cardReference == "instantiated1Card42a") {


                        GameObject card = Instantiate(card42a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card42a";

                    }

                    if (cardReference == "instantiated1Card42b") {


                        GameObject card = Instantiate(card42b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card42b";

                    }

                    if (cardReference == "instantiated1Card42c") {


                        GameObject card = Instantiate(card42c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card42c";

                    }

                    if (cardReference == "instantiated1Card43") {


                        GameObject card = Instantiate(card43, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card43";


                    }

                    if (cardReference == "instantiated1Card43a") {


                        GameObject card = Instantiate(card43a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card43a";

                    }

                    if (cardReference == "instantiated1Card43b") {


                        GameObject card = Instantiate(card43b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card43b";

                    }

                    if (cardReference == "instantiated1Card43c") {


                        GameObject card = Instantiate(card43c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card43c";


                    }

                    if (cardReference == "instantiated1Card44") {


                        GameObject card = Instantiate(card44, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card44";


                    }

                    if (cardReference == "instantiated1Card44a") {


                        GameObject card = Instantiate(card44a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card44a";

                    }

                    if (cardReference == "instantiated1Card44b") {


                        GameObject card = Instantiate(card44b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card44b";

                    }

                    if (cardReference == "instantiated1Card44c") {


                        GameObject card = Instantiate(card44c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card44c";

                    }

                    if (cardReference == "instantiated1Card45") {


                        GameObject card = Instantiate(card45, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card45";

                    }

                    if (cardReference == "instantiated1Card45a") {


                        GameObject card = Instantiate(card45a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card45a";

                    }

                    if (cardReference == "instantiated1Card45b") {


                        GameObject card = Instantiate(card45b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card45b";

                    }

                    if (cardReference == "instantiated1Card45c") {


                        GameObject card = Instantiate(card45c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card45c";

                    }

                    if (cardReference == "instantiated1Card46") {


                        GameObject card = Instantiate(card46, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card46";

                    }

                    if (cardReference == "instantiated1Card46a") {


                        GameObject card = Instantiate(card46a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card46a";

                    }

                    if (cardReference == "instantiated1Card46b") {


                        GameObject card = Instantiate(card46b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card46b";


                    }

                    if (cardReference == "instantiated1Card46c") {


                        GameObject card = Instantiate(card46c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card46c";

                    }

                    if (cardReference == "instantiated1Card47") {


                        GameObject card = Instantiate(card47, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card47";

                    }

                    if (cardReference == "instantiated1Card47a") {


                        GameObject card = Instantiate(card47a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card47a";

                    }

                    if (cardReference == "instantiated1Card47b") {


                        GameObject card = Instantiate(card47b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card47b";

                    }

                    if (cardReference == "instantiated1Card47c") {


                        GameObject card = Instantiate(card47c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card47c";

                    }

                    if (cardReference == "instantiated1Card48") {


                        GameObject card = Instantiate(card48, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card48";

                    }

                    if (cardReference == "instantiated1Card48a") {


                        GameObject card = Instantiate(card48a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card48a";

                    }

                    if (cardReference == "instantiated1Card48b") {


                        GameObject card = Instantiate(card48b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card48b";

                    }

                    if (cardReference == "instantiated1Card48c") {


                        GameObject card = Instantiate(card48c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card48c";

                    }

                    if (cardReference == "instantiated1Card49") {


                        GameObject card = Instantiate(card49, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card49";

                    }

                    if (cardReference == "instantiated1Card49a") {


                        GameObject card = Instantiate(card49a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card49a";

                    }

                    if (cardReference == "instantiated1Card49b") {


                        GameObject card = Instantiate(card49b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card49b";

                    }

                    if (cardReference == "instantiated1Card49c") {


                        GameObject card = Instantiate(card49c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card49c";

                    }

                    if (cardReference == "instantiated1Card50") {


                        GameObject card = Instantiate(card50, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card50";

                    }

                    if (cardReference == "instantiated1Card50a") {


                        GameObject card = Instantiate(card50a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card50a";

                    }

                    if (cardReference == "instantiated1Card50b") {


                        GameObject card = Instantiate(card50b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card50b";

                    }

                    if (cardReference == "instantiated1Card50c") {


                        GameObject card = Instantiate(card50c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card50c";

                    }

                    if (cardReference == "instantiated1Card51") {


                        GameObject card = Instantiate(card51, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card51";

                    }

                    if (cardReference == "instantiated1Card51a") {


                        GameObject card = Instantiate(card51a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card51a";

                    }

                    if (cardReference == "instantiated1Card51b") {


                        GameObject card = Instantiate(card51b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card51b";

                    }

                    if (cardReference == "instantiated1Card51c") {


                        GameObject card = Instantiate(card51c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card51c";

                    }

                    if (cardReference == "instantiated1Card52") {


                        GameObject card = Instantiate(card52, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card52";

                    }

                    if (cardReference == "instantiated1Card52a") {


                        GameObject card = Instantiate(card52a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card52a";

                    }

                    if (cardReference == "instantiated1Card52b") {


                        GameObject card = Instantiate(card52b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card52b";

                    }

                    if (cardReference == "instantiated1Card52c") {


                        GameObject card = Instantiate(card52c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card52c";

                    }

                    if (cardReference == "instantiated1Card53") {


                        GameObject card = Instantiate(card53, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card53";

                    }

                    if (cardReference == "instantiated1Card53a") {


                        GameObject card = Instantiate(card53a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card53a";

                    }

                    if (cardReference == "instantiated1Card53b") {


                        GameObject card = Instantiate(card53b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card53b";

                    }

                    if (cardReference == "instantiated1Card53c") {


                        GameObject card = Instantiate(card53c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card53c";

                    }

                    if (cardReference == "instantiated1Card54") {


                        GameObject card = Instantiate(card54, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card54";

                    }

                    if (cardReference == "instantiated1Card54a") {


                        GameObject card = Instantiate(card54a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card54a";

                    }

                    if (cardReference == "instantiated1Card54b") {


                        GameObject card = Instantiate(card54b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card54b";

                    }

                    if (cardReference == "instantiated1Card54c") {


                        GameObject card = Instantiate(card54c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card54c";

                    }

                    if (cardReference == "instantiated1Card55") {


                        GameObject card = Instantiate(card55, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card55";

                    }

                    if (cardReference == "instantiated1Card55a") {


                        GameObject card = Instantiate(card55a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card55a";

                    }

                    if (cardReference == "instantiated1Card55b") {


                        GameObject card = Instantiate(card55b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card55b";

                    }

                    if (cardReference == "instantiated1Card55c") {


                        GameObject card = Instantiate(card55c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card55c";

                    }

                    if (cardReference == "instantiated1Card56") {


                        GameObject card = Instantiate(card56, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card56";

                    }

                    if (cardReference == "instantiated1Card56a") {


                        GameObject card = Instantiate(card56a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card56a";

                    }

                    if (cardReference == "instantiated1Card56b") {


                        GameObject card = Instantiate(card56b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card56b";

                    }

                    if (cardReference == "instantiated1Card56c") {


                        GameObject card = Instantiate(card56c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card56c";

                    }

                    if (cardReference == "instantiated1Card57") {


                        GameObject card = Instantiate(card57, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card57";

                    }

                    if (cardReference == "instantiated1Card57a") {


                        GameObject card = Instantiate(card57a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card57a";

                    }

                    if (cardReference == "instantiated1Card57b") {


                        GameObject card = Instantiate(card57b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card57b";

                    }

                    if (cardReference == "instantiated1Card57c") {


                        GameObject card = Instantiate(card57c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card57c";

                    }

                    if (cardReference == "instantiated1Card58") {


                        GameObject card = Instantiate(card58, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card58";

                    }

                    if (cardReference == "instantiated1Card58a") {


                        GameObject card = Instantiate(card58a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card58a";

                    }

                    if (cardReference == "instantiated1Card58b") {


                        GameObject card = Instantiate(card58b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card58b";

                    }

                    if (cardReference == "instantiated1Card58c") {


                        GameObject card = Instantiate(card58c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card58c";

                    }

                    if (cardReference == "instantiated1Card59") {


                        GameObject card = Instantiate(card59, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card59";

                    }

                    if (cardReference == "instantiated1Card59a") {


                        GameObject card = Instantiate(card59a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card59a";

                    }

                    if (cardReference == "instantiated1Card59b") {


                        GameObject card = Instantiate(card59b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card59b";

                    }

                    if (cardReference == "instantiated1Card59c") {


                        GameObject card = Instantiate(card59c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card59c";

                    }

                    if (cardReference == "instantiated1Card60") {


                        GameObject card = Instantiate(card60, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card60";

                    }

                    if (cardReference == "instantiated1Card60a") {


                        GameObject card = Instantiate(card60a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card60a";

                    }

                    if (cardReference == "instantiated1Card60b") {


                        GameObject card = Instantiate(card60b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card60b";

                    }

                    if (cardReference == "instantiated1Card60c") {


                        GameObject card = Instantiate(card60c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated1Card60c";

                    }


                }

            }


            StartCoroutine(GetDeck1Cards());
            StartCoroutine(CreateRandomCardsFromDeck1());
            StartCoroutine(GetHandCards());


        }

        IEnumerator GetDeck1Cards() {

            yield return new WaitForSeconds(1);

            allObjects = GameObject.FindObjectsOfType(typeof(GameObject)) as GameObject[];

            foreach (GameObject obj in allObjects) {
                if (obj.name.Contains("instantiated1Card")) {

                    playCardsDeck1.Add(obj);

                }
            }


        }

        IEnumerator CreateRandomCardsFromDeck1() {

            yield return new WaitForSeconds(2);

            while (instances1 < NumberOfCards) {

                GameObject card = Instantiate(playCardsDeck1[UnityEngine.Random.Range(0, playCardsDeck1.Count)], player1DeckSlot1.transform.position, player1DeckSlot1.transform.rotation) as GameObject;
                card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                card.transform.parent = player1DeckSlot1.transform;

                if (card.name == "instantiated1Card1(Clone)") {

                    card.name = "instantiated1HandCard1";

                } else if (card.name == "instantiated1Card1a(Clone)") {

                    card.name = "instantiated1HandCard1a";

                } else if (card.name == "instantiated1Card1b(Clone)") {

                    card.name = "instantiated1HandCard1b";

                } else if (card.name == "instantiated1Card1c(Clone)") {

                    card.name = "instantiated1HandCard1c";

                } else if (card.name == "instantiated1Card2(Clone)") {

                    card.name = "instantiated1HandCard2";

                } else if (card.name == "instantiated1Card2a(Clone)") {

                    card.name = "instantiated1HandCard2a";

                } else if (card.name == "instantiated1Card2b(Clone)") {

                    card.name = "instantiated1HandCard2b";

                } else if (card.name == "instantiated1Card2c(Clone)") {

                    card.name = "instantiated1HandCard2c";

                } else if (card.name == "instantiated1Card3(Clone)") {

                    card.name = "instantiated1HandCard3";

                } else if (card.name == "instantiated1Card3a(Clone)") {

                    card.name = "instantiated1HandCard3a";

                } else if (card.name == "instantiated1Card3b(Clone)") {

                    card.name = "instantiated1HandCard3b";

                } else if (card.name == "instantiated1Card3c(Clone)") {

                    card.name = "instantiated1HandCard3c";

                } else if (card.name == "instantiated1Card4(Clone)") {

                    card.name = "instantiated1HandCard4";

                } else if (card.name == "instantiated1Card4a(Clone)") {

                    card.name = "instantiated1HandCard4a";

                } else if (card.name == "instantiated1Card4b(Clone)") {

                    card.name = "instantiated1HandCard4b";

                } else if (card.name == "instantiated1Card4c(Clone)") {

                    card.name = "instantiated1HandCard4c";

                } else if (card.name == "instantiated1Card5(Clone)") {

                    card.name = "instantiated1HandCard5";

                } else if (card.name == "instantiated1Card5a(Clone)") {

                    card.name = "instantiated1HandCard5a";

                } else if (card.name == "instantiated1Card5b(Clone)") {

                    card.name = "instantiated1HandCard5b";

                } else if (card.name == "instantiated1Card5c(Clone)") {

                    card.name = "instantiated1HandCard5c";

                } else if (card.name == "instantiated1Card6(Clone)") {

                    card.name = "instantiated1HandCard6";

                } else if (card.name == "instantiated1Card6a(Clone)") {

                    card.name = "instantiated1HandCard6a";

                } else if (card.name == "instantiated1Card6b(Clone)") {

                    card.name = "instantiated1HandCard6b";

                } else if (card.name == "instantiated1Card6c(Clone)") {

                    card.name = "instantiated1HandCard6c";

                } else if (card.name == "instantiated1Card7(Clone)") {

                    card.name = "instantiated1HandCard7";

                } else if (card.name == "instantiated1Card7a(Clone)") {

                    card.name = "instantiated1HandCard7a";

                } else if (card.name == "instantiated1Card7b(Clone)") {

                    card.name = "instantiated1HandCard7b";

                } else if (card.name == "instantiated1Card7c(Clone)") {

                    card.name = "instantiated1HandCard7c";

                } else if (card.name == "instantiated1Card8(Clone)") {

                    card.name = "instantiated1HandCard8";

                } else if (card.name == "instantiated1Card8a(Clone)") {

                    card.name = "instantiated1HandCard8a";

                } else if (card.name == "instantiated1Card8b(Clone)") {

                    card.name = "instantiated1HandCard8b";

                } else if (card.name == "instantiated1Card8c(Clone)") {

                    card.name = "instantiated1HandCard8c";

                } else if (card.name == "instantiated1Card9(Clone)") {

                    card.name = "instantiated1HandCard9";

                } else if (card.name == "instantiated1Card9a(Clone)") {

                    card.name = "instantiated1HandCard9a";

                } else if (card.name == "instantiated1Card9b(Clone)") {

                    card.name = "instantiated1HandCard9b";

                } else if (card.name == "instantiated1Card9c(Clone)") {

                    card.name = "instantiated1HandCard9c";

                } else if (card.name == "instantiated1Card10(Clone)") {

                    card.name = "instantiatedAICard10";

                } else if (card.name == "instantiated1Card10a(Clone)") {

                    card.name = "instantiated1HandCard10a";

                } else if (card.name == "instantiated1Card10b(Clone)") {

                    card.name = "instantiated1HandCard10b";

                } else if (card.name == "instantiated1Card10c(Clone)") {

                    card.name = "instantiated1HandCard10c";

                } else if (card.name == "instantiated1Card11(Clone)") {

                    card.name = "instantiated1HandCard11";

                } else if (card.name == "instantiated1Card11a(Clone)") {

                    card.name = "instantiated1HandCard11a";

                } else if (card.name == "instantiated1Card11b(Clone)") {

                    card.name = "instantiated1HandCard11b";

                } else if (card.name == "instantiated1Card11c(Clone)") {

                    card.name = "instantiated1HandCard11c";

                } else if (card.name == "instantiated1Card12(Clone)") {

                    card.name = "instantiated1HandCard12";

                } else if (card.name == "instantiated1Card12a(Clone)") {

                    card.name = "instantiated1HandCard12a";

                } else if (card.name == "instantiated1Card12b(Clone)") {

                    card.name = "instantiated1HandCard12b";

                } else if (card.name == "instantiated1Card12c(Clone)") {

                    card.name = "instantiated1HandCard12c";

                } else if (card.name == "instantiated1Card13(Clone)") {

                    card.name = "instantiated1HandCard13";

                } else if (card.name == "instantiated1Card13a(Clone)") {

                    card.name = "instantiated1HandCard13a";

                } else if (card.name == "instantiated1Card13b(Clone)") {

                    card.name = "instantiated1HandCard13b";

                } else if (card.name == "instantiated1Card13c(Clone)") {

                    card.name = "instantiated1HandCard13c";

                } else if (card.name == "instantiated1Card14(Clone)") {

                    card.name = "instantiated1HandCard14";

                } else if (card.name == "instantiated1Card14a(Clone)") {

                    card.name = "instantiated1HandCard14a";

                } else if (card.name == "instantiated1Card14b(Clone)") {

                    card.name = "instantiated1HandCard14b";

                } else if (card.name == "instantiated1Card14c(Clone)") {

                    card.name = "instantiated1HandCard14c";

                } else if (card.name == "instantiated1Card15(Clone)") {

                    card.name = "instantiated1HandCard15";

                } else if (card.name == "instantiated1Card15a(Clone)") {

                    card.name = "instantiated1HandCard15a";

                } else if (card.name == "instantiated1Card15b(Clone)") {

                    card.name = "instantiated1HandCard15b";

                } else if (card.name == "instantiated1Card15c(Clone)") {

                    card.name = "instantiated1HandCard15c";

                } else if (card.name == "instantiated1Card16(Clone)") {

                    card.name = "instantiated1HandCard16";

                } else if (card.name == "instantiated1Card16a(Clone)") {

                    card.name = "instantiated1HandCard16a";

                } else if (card.name == "instantiated1Card16b(Clone)") {

                    card.name = "instantiated1HandCard16b";

                } else if (card.name == "instantiated1Card16c(Clone)") {

                    card.name = "instantiated1HandCard16c";

                } else if (card.name == "instantiated1Card17(Clone)") {

                    card.name = "instantiated1HandCard17";

                } else if (card.name == "instantiated1Card17a(Clone)") {

                    card.name = "instantiated1HandCard17a";

                } else if (card.name == "instantiated1Card17b(Clone)") {

                    card.name = "instantiated1HandCard17b";

                } else if (card.name == "instantiated1Card17c(Clone)") {

                    card.name = "instantiated1HandCard17c";

                } else if (card.name == "instantiated1Card18(Clone)") {

                    card.name = "instantiated1HandCard18";

                } else if (card.name == "instantiated1Card18a(Clone)") {

                    card.name = "instantiated1HandCard18a";

                } else if (card.name == "instantiated1Card18b(Clone)") {

                    card.name = "instantiated1HandCard18b";

                } else if (card.name == "instantiated1Card18c(Clone)") {

                    card.name = "instantiated1HandCard18c";

                } else if (card.name == "instantiated1Card19(Clone)") {

                    card.name = "instantiated1HandCard19";

                } else if (card.name == "instantiated1Card19a(Clone)") {

                    card.name = "instantiated1HandCard19a";

                } else if (card.name == "instantiated1Card19b(Clone)") {

                    card.name = "instantiated1HandCard19b";

                } else if (card.name == "instantiated1Card19c(Clone)") {

                    card.name = "instantiated1HandCard19c";

                } else if (card.name == "instantiated1Card20(Clone)") {

                    card.name = "instantiated1HandCard20";

                } else if (card.name == "instantiated1Card20a(Clone)") {

                    card.name = "instantiated1HandCard20a";

                } else if (card.name == "instantiated1Card20b(Clone)") {

                    card.name = "instantiated1HandCard20b";

                } else if (card.name == "instantiated1Card20c(Clone)") {

                    card.name = "instantiated1HandCard20c";

                } else if (card.name == "instantiated1Card21(Clone)") {

                    card.name = "instantiated1HandCard21";

                } else if (card.name == "instantiated1Card21a(Clone)") {

                    card.name = "instantiated1HandCard21a";

                } else if (card.name == "instantiated1Card21b(Clone)") {

                    card.name = "instantiated1HandCard21b";

                } else if (card.name == "instantiated1Card21c(Clone)") {

                    card.name = "instantiated1HandCard21c";

                } else if (card.name == "instantiated1Card22(Clone)") {

                    card.name = "instantiated1HandCard22";

                } else if (card.name == "instantiated1Card22a(Clone)") {

                    card.name = "instantiated1HandCard22a";

                } else if (card.name == "instantiated1Card22b(Clone)") {

                    card.name = "instantiated1HandCard22b";

                } else if (card.name == "instantiated1Card22c(Clone)") {

                    card.name = "instantiated1HandCard22c";

                } else if (card.name == "instantiated1Card23(Clone)") {

                    card.name = "instantiated1HandCard23";

                } else if (card.name == "instantiated1Card23a(Clone)") {

                    card.name = "instantiated1HandCard23a";

                } else if (card.name == "instantiated1Card23b(Clone)") {

                    card.name = "instantiated1HandCard23b";

                } else if (card.name == "instantiated1Card23c(Clone)") {

                    card.name = "instantiated1HandCard23c";

                } else if (card.name == "instantiated1Card24(Clone)") {

                    card.name = "instantiated1HandCard24";

                } else if (card.name == "instantiated1Card24a(Clone)") {

                    card.name = "instantiated1HandCard24a";

                } else if (card.name == "instantiated1Card24b(Clone)") {

                    card.name = "instantiated1HandCard24b";

                } else if (card.name == "instantiated1Card24c(Clone)") {

                    card.name = "instantiated1HandCard24c";

                } else if (card.name == "instantiated1Card25(Clone)") {

                    card.name = "instantiated1HandCard25";

                } else if (card.name == "instantiated1Card25a(Clone)") {

                    card.name = "instantiated1HandCard25a";

                } else if (card.name == "instantiated1Card25b(Clone)") {

                    card.name = "instantiated1HandCard25b";

                } else if (card.name == "instantiated1Card25c(Clone)") {

                    card.name = "instantiated1HandCard25c";

                } else if (card.name == "instantiated1Card26(Clone)") {

                    card.name = "instantiated1HandCard26";

                } else if (card.name == "instantiated1Card26a(Clone)") {

                    card.name = "instantiated1HandCard26a";

                } else if (card.name == "instantiated1Card26b(Clone)") {

                    card.name = "instantiated1HandCard26b";

                } else if (card.name == "instantiated1Card26c(Clone)") {

                    card.name = "instantiated1HandCard26c";

                } else if (card.name == "instantiated1Card27(Clone)") {

                    card.name = "instantiated1HandCard27";

                } else if (card.name == "instantiated1Card27a(Clone)") {

                    card.name = "instantiated1HandCard27a";

                } else if (card.name == "instantiated1Card27b(Clone)") {

                    card.name = "instantiated1HandCard27b";

                } else if (card.name == "instantiated1Card27c(Clone)") {

                    card.name = "instantiated1HandCard27c";

                } else if (card.name == "instantiated1Card28(Clone)") {

                    card.name = "instantiated1HandCard28";

                } else if (card.name == "instantiated1Card28a(Clone)") {

                    card.name = "instantiated1HandCard28a";

                } else if (card.name == "instantiated1Card28b(Clone)") {

                    card.name = "instantiated1HandCard28b";

                } else if (card.name == "instantiated1Card28c(Clone)") {

                    card.name = "instantiated1HandCard28c";

                } else if (card.name == "instantiated1Card29(Clone)") {

                    card.name = "instantiated1HandCard29";

                } else if (card.name == "instantiated1Card29a(Clone)") {

                    card.name = "instantiated1HandCard29a";

                } else if (card.name == "instantiated1Card29b(Clone)") {

                    card.name = "instantiated1HandCard29b";

                } else if (card.name == "instantiated1Card29c(Clone)") {

                    card.name = "instantiated1HandCard29c";

                } else if (card.name == "instantiated1Card30(Clone)") {

                    card.name = "instantiated1HandCard30";

                } else if (card.name == "instantiated1Card30a(Clone)") {

                    card.name = "instantiated1HandCard30a";

                } else if (card.name == "instantiated1Card30b(Clone)") {

                    card.name = "instantiated1HandCard30b";

                } else if (card.name == "instantiated1Card30c(Clone)") {

                    card.name = "instantiated1HandCard30c";

                } else if (card.name == "instantiated1Card31(Clone)") {

                    card.name = "instantiated1HandCard31";

                } else if (card.name == "instantiated1Card31a(Clone)") {

                    card.name = "instantiated1HandCard31a";

                } else if (card.name == "instantiated1Card31b(Clone)") {

                    card.name = "instantiated1HandCard31b";

                } else if (card.name == "instantiated1Card31c(Clone)") {

                    card.name = "instantiated1HandCard31c";

                } else if (card.name == "instantiated1Card32(Clone)") {

                    card.name = "instantiated1HandCard32";

                } else if (card.name == "instantiated1Card32a(Clone)") {

                    card.name = "instantiated1HandCard32a";

                } else if (card.name == "instantiated1Card32b(Clone)") {

                    card.name = "instantiated1HandCard32b";

                } else if (card.name == "instantiated1Card32c(Clone)") {

                    card.name = "instantiated1HandCard32c";

                } else if (card.name == "instantiated1Card33(Clone)") {

                    card.name = "instantiated1HandCard33";

                } else if (card.name == "instantiated1Card33a(Clone)") {

                    card.name = "instantiated1HandCard33a";

                } else if (card.name == "instantiated1Card33b(Clone)") {

                    card.name = "instantiated1HandCard33b";

                } else if (card.name == "instantiated1Card33c(Clone)") {

                    card.name = "instantiated1HandCard33c";

                } else if (card.name == "instantiated1Card34(Clone)") {

                    card.name = "instantiated1HandCard34";

                } else if (card.name == "instantiated1Card34a(Clone)") {

                    card.name = "instantiated1HandCard34a";

                } else if (card.name == "instantiated1Card34b(Clone)") {

                    card.name = "instantiated1HandCard34b";

                } else if (card.name == "instantiated1Card34c(Clone)") {

                    card.name = "instantiated1HandCard34c";

                } else if (card.name == "instantiated1Card35(Clone)") {

                    card.name = "instantiated1HandCard35";

                } else if (card.name == "instantiated1Card35a(Clone)") {

                    card.name = "instantiated1HandCard35a";

                } else if (card.name == "instantiated1Card35b(Clone)") {

                    card.name = "instantiated1HandCard35b";

                } else if (card.name == "instantiated1Card35c(Clone)") {

                    card.name = "instantiated1HandCard35c";

                } else if (card.name == "instantiated1Card36(Clone)") {

                    card.name = "instantiated1HandCard36";

                } else if (card.name == "instantiated1Card36a(Clone)") {

                    card.name = "instantiated1HandCard36a";

                } else if (card.name == "instantiated1Card36b(Clone)") {

                    card.name = "instantiated1HandCard36b";

                } else if (card.name == "instantiated1Card36c(Clone)") {

                    card.name = "instantiated1HandCard36c";

                } else if (card.name == "instantiated1Card37(Clone)") {

                    card.name = "instantiated1HandCard37";

                } else if (card.name == "instantiated1Card37a(Clone)") {

                    card.name = "instantiated1HandCard37a";

                } else if (card.name == "instantiated1Card37b(Clone)") {

                    card.name = "instantiated1HandCard37b";

                } else if (card.name == "instantiated1Card37c(Clone)") {

                    card.name = "instantiated1HandCard37c";

                } else if (card.name == "instantiated1Card38(Clone)") {

                    card.name = "instantiated1HandCard38";

                } else if (card.name == "instantiated1Card38a(Clone)") {

                    card.name = "instantiated1HandCard38a";

                } else if (card.name == "instantiated1Card38b(Clone)") {

                    card.name = "instantiated1HandCard38b";

                } else if (card.name == "instantiated1Card38c(Clone)") {

                    card.name = "instantiated1HandCard38c";

                } else if (card.name == "instantiated1Card39(Clone)") {

                    card.name = "instantiated1HandCard39";

                } else if (card.name == "instantiated1Card39a(Clone)") {

                    card.name = "instantiated1HandCard39a";

                } else if (card.name == "instantiated1Card39b(Clone)") {

                    card.name = "instantiated1HandCard39b";

                } else if (card.name == "instantiated1Card39c(Clone)") {

                    card.name = "instantiated1HandCard39c";

                } else if (card.name == "instantiated1Card40(Clone)") {

                    card.name = "instantiated1HandCard40";

                } else if (card.name == "instantiated1Card40a(Clone)") {

                    card.name = "instantiated1HandCard40a";

                } else if (card.name == "instantiated1Card40b(Clone)") {

                    card.name = "instantiated1HandCard40b";

                } else if (card.name == "instantiated1Card40c(Clone)") {

                    card.name = "instantiated1HandCard40c";

                } else if (card.name == "instantiated1Card41(Clone)") {

                    card.name = "instantiated1HandCard41";

                } else if (card.name == "instantiated1Card41a(Clone)") {

                    card.name = "instantiated1HandCard41a";

                } else if (card.name == "instantiated1Card41b(Clone)") {

                    card.name = "instantiated1HandCard41b";

                } else if (card.name == "instantiated1Card41c(Clone)") {

                    card.name = "instantiated1HandCard41c";

                } else if (card.name == "instantiated1Card42(Clone)") {

                    card.name = "instantiated1HandCard42";

                } else if (card.name == "instantiated1Card42a(Clone)") {

                    card.name = "instantiated1HandCard42a";

                } else if (card.name == "instantiated1Card42b(Clone)") {

                    card.name = "instantiated1HandCard42b";

                } else if (card.name == "instantiated1Card42c(Clone)") {

                    card.name = "instantiated1HandCard42c";

                } else if (card.name == "instantiated1Card43(Clone)") {

                    card.name = "instantiated1HandCard43";

                } else if (card.name == "instantiated1Card43a(Clone)") {

                    card.name = "instantiated1HandCard43a";

                } else if (card.name == "instantiated1Card43b(Clone)") {

                    card.name = "instantiated1HandCard43b";

                } else if (card.name == "instantiated1Card43c(Clone)") {

                    card.name = "instantiated1HandCard43c";

                } else if (card.name == "instantiated1Card44(Clone)") {

                    card.name = "instantiated1HandCard44";

                } else if (card.name == "instantiated1Card44a(Clone)") {

                    card.name = "instantiated1HandCard44a";

                } else if (card.name == "instantiated1Card44b(Clone)") {

                    card.name = "instantiated1HandCard44b";

                } else if (card.name == "instantiated1Card44c(Clone)") {

                    card.name = "instantiated1HandCard44c";

                } else if (card.name == "instantiated1Card45(Clone)") {

                    card.name = "instantiated1HandCard45";

                } else if (card.name == "instantiated1Card45a(Clone)") {

                    card.name = "instantiated1HandCard45a";

                } else if (card.name == "instantiated1Card45b(Clone)") {

                    card.name = "instantiated1HandCard45b";

                } else if (card.name == "instantiated1Card45c(Clone)") {

                    card.name = "instantiated1HandCard45c";

                } else if (card.name == "instantiated1Card46(Clone)") {

                    card.name = "instantiated1HandCard46";

                } else if (card.name == "instantiated1Card46a(Clone)") {

                    card.name = "instantiated1HandCard46a";

                } else if (card.name == "instantiated1Card46b(Clone)") {

                    card.name = "instantiated1HandCard46b";

                } else if (card.name == "instantiated1Card46c(Clone)") {

                    card.name = "instantiated1HandCard46c";

                } else if (card.name == "instantiated1Card47(Clone)") {

                    card.name = "instantiated1HandCard47";

                } else if (card.name == "instantiated1Card47a(Clone)") {

                    card.name = "instantiated1HandCard47a";

                } else if (card.name == "instantiated1Card47b(Clone)") {

                    card.name = "instantiated1HandCard47b";

                } else if (card.name == "instantiated1Card47c(Clone)") {

                    card.name = "instantiated1HandCard47c";

                } else if (card.name == "instantiated1Card48(Clone)") {

                    card.name = "instantiated1HandCard48";

                } else if (card.name == "instantiated1Card48a(Clone)") {

                    card.name = "instantiated1HandCard48a";

                } else if (card.name == "instantiated1Card48b(Clone)") {

                    card.name = "instantiated1HandCard48b";

                } else if (card.name == "instantiated1Card48c(Clone)") {

                    card.name = "instantiated1HandCard48c";

                } else if (card.name == "instantiated1Card49(Clone)") {

                    card.name = "instantiated1HandCard49";

                } else if (card.name == "instantiated1Card49a(Clone)") {

                    card.name = "instantiated1HandCard49a";

                } else if (card.name == "instantiated1Card49b(Clone)") {

                    card.name = "instantiated1HandCard49b";

                } else if (card.name == "instantiated1Card49c(Clone)") {

                    card.name = "instantiated1HandCard49c";

                } else if (card.name == "instantiated1Card50(Clone)") {

                    card.name = "instantiated1HandCard50";

                } else if (card.name == "instantiated1Card50a(Clone)") {

                    card.name = "instantiated1HandCard50a";

                } else if (card.name == "instantiated1Card50b(Clone)") {

                    card.name = "instantiated1HandCard50b";

                } else if (card.name == "instantiated1Card50c(Clone)") {

                    card.name = "instantiated1HandCard50c";

                } else if (card.name == "instantiated1Card51(Clone)") {

                    card.name = "instantiated1HandCard51";

                } else if (card.name == "instantiated1Card51a(Clone)") {

                    card.name = "instantiated1HandCard51a";

                } else if (card.name == "instantiated1Card51b(Clone)") {

                    card.name = "instantiated1HandCard51b";

                } else if (card.name == "instantiated1Card51c(Clone)") {

                    card.name = "instantiated1HandCard51c";

                } else if (card.name == "instantiated1Card52(Clone)") {

                    card.name = "instantiated1HandCard52";

                } else if (card.name == "instantiated1Card52a(Clone)") {

                    card.name = "instantiated1HandCard52a";

                } else if (card.name == "instantiated1Card52b(Clone)") {

                    card.name = "instantiated1HandCard52b";

                } else if (card.name == "instantiated1Card52c(Clone)") {

                    card.name = "instantiated1HandCard52c";

                } else if (card.name == "instantiated1Card53(Clone)") {

                    card.name = "instantiated1HandCard53";

                } else if (card.name == "instantiated1Card53a(Clone)") {

                    card.name = "instantiated1HandCard53a";

                } else if (card.name == "instantiated1Card53b(Clone)") {

                    card.name = "instantiated1HandCard53b";

                } else if (card.name == "instantiated1Card53c(Clone)") {

                    card.name = "instantiated1HandCard53c";

                } else if (card.name == "instantiated1Card54(Clone)") {

                    card.name = "instantiated1HandCard54";

                } else if (card.name == "instantiated1Card54a(Clone)") {

                    card.name = "instantiated1HandCard54a";

                } else if (card.name == "instantiated1Card54b(Clone)") {

                    card.name = "instantiated1HandCard54b";

                } else if (card.name == "instantiated1Card54c(Clone)") {

                    card.name = "instantiated1HandCard54c";

                } else if (card.name == "instantiated1Card55(Clone)") {

                    card.name = "instantiated1HandCard55";

                } else if (card.name == "instantiated1Card55a(Clone)") {

                    card.name = "instantiated1HandCard55a";

                } else if (card.name == "instantiated1Card55b(Clone)") {

                    card.name = "instantiated1HandCard55b";

                } else if (card.name == "instantiated1Card55c(Clone)") {

                    card.name = "instantiated1HandCard55c";

                } else if (card.name == "instantiated1Card56(Clone)") {

                    card.name = "instantiated1HandCard56";

                } else if (card.name == "instantiated1Card56a(Clone)") {

                    card.name = "instantiated1HandCard56a";

                } else if (card.name == "instantiated1Card56b(Clone)") {

                    card.name = "instantiated1HandCard56b";

                } else if (card.name == "instantiated1Card56c(Clone)") {

                    card.name = "instantiated1HandCard56c";

                } else if (card.name == "instantiated1Card57(Clone)") {

                    card.name = "instantiated1HandCard57";

                } else if (card.name == "instantiated1Card57a(Clone)") {

                    card.name = "instantiated1HandCard57a";

                } else if (card.name == "instantiated1Card57b(Clone)") {

                    card.name = "instantiated1HandCard57b";

                } else if (card.name == "instantiated1Card57c(Clone)") {

                    card.name = "instantiated1HandCard57c";

                } else if (card.name == "instantiated1Card58(Clone)") {

                    card.name = "instantiated1HandCard58";

                } else if (card.name == "instantiated1Card58a(Clone)") {

                    card.name = "instantiated1HandCard58a";

                } else if (card.name == "instantiated1Card58b(Clone)") {

                    card.name = "instantiated1HandCard58b";

                } else if (card.name == "instantiated1Card58c(Clone)") {

                    card.name = "instantiated1HandCard58c";

                } else if (card.name == "instantiated1Card59(Clone)") {

                    card.name = "instantiated1HandCard59";

                } else if (card.name == "instantiated1Card59a(Clone)") {

                    card.name = "instantiated1HandCard59a";

                } else if (card.name == "instantiated1Card59b(Clone)") {

                    card.name = "instantiated1HandCard59b";

                } else if (card.name == "instantiated1Card59c(Clone)") {

                    card.name = "instantiated1HandCard59c";

                } else if (card.name == "instantiated1Card60(Clone)") {

                    card.name = "instantiated1HandCard60";

                } else if (card.name == "instantiated1Card60a(Clone)") {

                    card.name = "instantiated1HandCard60a";

                } else if (card.name == "instantiated1Card60b(Clone)") {

                    card.name = "instantiated1HandCard60b";

                } else if (card.name == "instantiated1Card60c(Clone)") {

                    card.name = "instantiated1HandCard60c";
                }

                instances1++;

            }

            while (instances2 < NumberOfCards) {

                GameObject card = Instantiate(playCardsDeck1[UnityEngine.Random.Range(0, playCardsDeck1.Count)], player1DeckSlot2.transform.position, player1DeckSlot2.transform.rotation) as GameObject;
                card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                card.transform.parent = player1DeckSlot2.transform;

                if (card.name == "instantiated1Card1(Clone)") {

                    card.name = "instantiated1HandCard1";

                } else if (card.name == "instantiated1Card1a(Clone)") {

                    card.name = "instantiated1HandCard1a";

                } else if (card.name == "instantiated1Card1b(Clone)") {

                    card.name = "instantiated1HandCard1b";

                } else if (card.name == "instantiated1Card1c(Clone)") {

                    card.name = "instantiated1HandCard1c";

                } else if (card.name == "instantiated1Card2(Clone)") {

                    card.name = "instantiated1HandCard2";

                } else if (card.name == "instantiated1Card2a(Clone)") {

                    card.name = "instantiated1HandCard2a";

                } else if (card.name == "instantiated1Card2b(Clone)") {

                    card.name = "instantiated1HandCard2b";

                } else if (card.name == "instantiated1Card2c(Clone)") {

                    card.name = "instantiated1HandCard2c";

                } else if (card.name == "instantiated1Card3(Clone)") {

                    card.name = "instantiated1HandCard3";

                } else if (card.name == "instantiated1Card3a(Clone)") {

                    card.name = "instantiated1HandCard3a";

                } else if (card.name == "instantiated1Card3b(Clone)") {

                    card.name = "instantiated1HandCard3b";

                } else if (card.name == "instantiated1Card3c(Clone)") {

                    card.name = "instantiated1HandCard3c";

                } else if (card.name == "instantiated1Card4(Clone)") {

                    card.name = "instantiated1HandCard4";

                } else if (card.name == "instantiated1Card4a(Clone)") {

                    card.name = "instantiated1HandCard4a";

                } else if (card.name == "instantiated1Card4b(Clone)") {

                    card.name = "instantiated1HandCard4b";

                } else if (card.name == "instantiated1Card4c(Clone)") {

                    card.name = "instantiated1HandCard4c";

                } else if (card.name == "instantiated1Card5(Clone)") {

                    card.name = "instantiated1HandCard5";

                } else if (card.name == "instantiated1Card5a(Clone)") {

                    card.name = "instantiated1HandCard5a";

                } else if (card.name == "instantiated1Card5b(Clone)") {

                    card.name = "instantiated1HandCard5b";

                } else if (card.name == "instantiated1Card5c(Clone)") {

                    card.name = "instantiated1HandCard5c";

                } else if (card.name == "instantiated1Card6(Clone)") {

                    card.name = "instantiated1HandCard6";

                } else if (card.name == "instantiated1Card6a(Clone)") {

                    card.name = "instantiated1HandCard6a";

                } else if (card.name == "instantiated1Card6b(Clone)") {

                    card.name = "instantiated1HandCard6b";

                } else if (card.name == "instantiated1Card6c(Clone)") {

                    card.name = "instantiated1HandCard6c";

                } else if (card.name == "instantiated1Card7(Clone)") {

                    card.name = "instantiated1HandCard7";

                } else if (card.name == "instantiated1Card7a(Clone)") {

                    card.name = "instantiated1HandCard7a";

                } else if (card.name == "instantiated1Card7b(Clone)") {

                    card.name = "instantiated1HandCard7b";

                } else if (card.name == "instantiated1Card7c(Clone)") {

                    card.name = "instantiated1HandCard7c";

                } else if (card.name == "instantiated1Card8(Clone)") {

                    card.name = "instantiated1HandCard8";

                } else if (card.name == "instantiated1Card8a(Clone)") {

                    card.name = "instantiated1HandCard8a";

                } else if (card.name == "instantiated1Card8b(Clone)") {

                    card.name = "instantiated1HandCard8b";

                } else if (card.name == "instantiated1Card8c(Clone)") {

                    card.name = "instantiated1HandCard8c";

                } else if (card.name == "instantiated1Card9(Clone)") {

                    card.name = "instantiated1HandCard9";

                } else if (card.name == "instantiated1Card9a(Clone)") {

                    card.name = "instantiated1HandCard9a";

                } else if (card.name == "instantiated1Card9b(Clone)") {

                    card.name = "instantiated1HandCard9b";

                } else if (card.name == "instantiated1Card9c(Clone)") {

                    card.name = "instantiated1HandCard9c";

                } else if (card.name == "instantiated1Card10(Clone)") {

                    card.name = "instantiatedAICard10";

                } else if (card.name == "instantiated1Card10a(Clone)") {

                    card.name = "instantiated1HandCard10a";

                } else if (card.name == "instantiated1Card10b(Clone)") {

                    card.name = "instantiated1HandCard10b";

                } else if (card.name == "instantiated1Card10c(Clone)") {

                    card.name = "instantiated1HandCard10c";

                } else if (card.name == "instantiated1Card11(Clone)") {

                    card.name = "instantiated1HandCard11";

                } else if (card.name == "instantiated1Card11a(Clone)") {

                    card.name = "instantiated1HandCard11a";

                } else if (card.name == "instantiated1Card11b(Clone)") {

                    card.name = "instantiated1HandCard11b";

                } else if (card.name == "instantiated1Card11c(Clone)") {

                    card.name = "instantiated1HandCard11c";

                } else if (card.name == "instantiated1Card12(Clone)") {

                    card.name = "instantiated1HandCard12";

                } else if (card.name == "instantiated1Card12a(Clone)") {

                    card.name = "instantiated1HandCard12a";

                } else if (card.name == "instantiated1Card12b(Clone)") {

                    card.name = "instantiated1HandCard12b";

                } else if (card.name == "instantiated1Card12c(Clone)") {

                    card.name = "instantiated1HandCard12c";

                } else if (card.name == "instantiated1Card13(Clone)") {

                    card.name = "instantiated1HandCard13";

                } else if (card.name == "instantiated1Card13a(Clone)") {

                    card.name = "instantiated1HandCard13a";

                } else if (card.name == "instantiated1Card13b(Clone)") {

                    card.name = "instantiated1HandCard13b";

                } else if (card.name == "instantiated1Card13c(Clone)") {

                    card.name = "instantiated1HandCard13c";

                } else if (card.name == "instantiated1Card14(Clone)") {

                    card.name = "instantiated1HandCard14";

                } else if (card.name == "instantiated1Card14a(Clone)") {

                    card.name = "instantiated1HandCard14a";

                } else if (card.name == "instantiated1Card14b(Clone)") {

                    card.name = "instantiated1HandCard14b";

                } else if (card.name == "instantiated1Card14c(Clone)") {

                    card.name = "instantiated1HandCard14c";

                } else if (card.name == "instantiated1Card15(Clone)") {

                    card.name = "instantiated1HandCard15";

                } else if (card.name == "instantiated1Card15a(Clone)") {

                    card.name = "instantiated1HandCard15a";

                } else if (card.name == "instantiated1Card15b(Clone)") {

                    card.name = "instantiated1HandCard15b";

                } else if (card.name == "instantiated1Card15c(Clone)") {

                    card.name = "instantiated1HandCard15c";

                } else if (card.name == "instantiated1Card16(Clone)") {

                    card.name = "instantiated1HandCard16";

                } else if (card.name == "instantiated1Card16a(Clone)") {

                    card.name = "instantiated1HandCard16a";

                } else if (card.name == "instantiated1Card16b(Clone)") {

                    card.name = "instantiated1HandCard16b";

                } else if (card.name == "instantiated1Card16c(Clone)") {

                    card.name = "instantiated1HandCard16c";

                } else if (card.name == "instantiated1Card17(Clone)") {

                    card.name = "instantiated1HandCard17";

                } else if (card.name == "instantiated1Card17a(Clone)") {

                    card.name = "instantiated1HandCard17a";

                } else if (card.name == "instantiated1Card17b(Clone)") {

                    card.name = "instantiated1HandCard17b";

                } else if (card.name == "instantiated1Card17c(Clone)") {

                    card.name = "instantiated1HandCard17c";

                } else if (card.name == "instantiated1Card18(Clone)") {

                    card.name = "instantiated1HandCard18";

                } else if (card.name == "instantiated1Card18a(Clone)") {

                    card.name = "instantiated1HandCard18a";

                } else if (card.name == "instantiated1Card18b(Clone)") {

                    card.name = "instantiated1HandCard18b";

                } else if (card.name == "instantiated1Card18c(Clone)") {

                    card.name = "instantiated1HandCard18c";

                } else if (card.name == "instantiated1Card19(Clone)") {

                    card.name = "instantiated1HandCard19";

                } else if (card.name == "instantiated1Card19a(Clone)") {

                    card.name = "instantiated1HandCard19a";

                } else if (card.name == "instantiated1Card19b(Clone)") {

                    card.name = "instantiated1HandCard19b";

                } else if (card.name == "instantiated1Card19c(Clone)") {

                    card.name = "instantiated1HandCard19c";

                } else if (card.name == "instantiated1Card20(Clone)") {

                    card.name = "instantiated1HandCard20";

                } else if (card.name == "instantiated1Card20a(Clone)") {

                    card.name = "instantiated1HandCard20a";

                } else if (card.name == "instantiated1Card20b(Clone)") {

                    card.name = "instantiated1HandCard20b";

                } else if (card.name == "instantiated1Card20c(Clone)") {

                    card.name = "instantiated1HandCard20c";

                } else if (card.name == "instantiated1Card21(Clone)") {

                    card.name = "instantiated1HandCard21";

                } else if (card.name == "instantiated1Card21a(Clone)") {

                    card.name = "instantiated1HandCard21a";

                } else if (card.name == "instantiated1Card21b(Clone)") {

                    card.name = "instantiated1HandCard21b";

                } else if (card.name == "instantiated1Card21c(Clone)") {

                    card.name = "instantiated1HandCard21c";

                } else if (card.name == "instantiated1Card22(Clone)") {

                    card.name = "instantiated1HandCard22";

                } else if (card.name == "instantiated1Card22a(Clone)") {

                    card.name = "instantiated1HandCard22a";

                } else if (card.name == "instantiated1Card22b(Clone)") {

                    card.name = "instantiated1HandCard22b";

                } else if (card.name == "instantiated1Card22c(Clone)") {

                    card.name = "instantiated1HandCard22c";

                } else if (card.name == "instantiated1Card23(Clone)") {

                    card.name = "instantiated1HandCard23";

                } else if (card.name == "instantiated1Card23a(Clone)") {

                    card.name = "instantiated1HandCard23a";

                } else if (card.name == "instantiated1Card23b(Clone)") {

                    card.name = "instantiated1HandCard23b";

                } else if (card.name == "instantiated1Card23c(Clone)") {

                    card.name = "instantiated1HandCard23c";

                } else if (card.name == "instantiated1Card24(Clone)") {

                    card.name = "instantiated1HandCard24";

                } else if (card.name == "instantiated1Card24a(Clone)") {

                    card.name = "instantiated1HandCard24a";

                } else if (card.name == "instantiated1Card24b(Clone)") {

                    card.name = "instantiated1HandCard24b";

                } else if (card.name == "instantiated1Card24c(Clone)") {

                    card.name = "instantiated1HandCard24c";

                } else if (card.name == "instantiated1Card25(Clone)") {

                    card.name = "instantiated1HandCard25";

                } else if (card.name == "instantiated1Card25a(Clone)") {

                    card.name = "instantiated1HandCard25a";

                } else if (card.name == "instantiated1Card25b(Clone)") {

                    card.name = "instantiated1HandCard25b";

                } else if (card.name == "instantiated1Card25c(Clone)") {

                    card.name = "instantiated1HandCard25c";

                } else if (card.name == "instantiated1Card26(Clone)") {

                    card.name = "instantiated1HandCard26";

                } else if (card.name == "instantiated1Card26a(Clone)") {

                    card.name = "instantiated1HandCard26a";

                } else if (card.name == "instantiated1Card26b(Clone)") {

                    card.name = "instantiated1HandCard26b";

                } else if (card.name == "instantiated1Card26c(Clone)") {

                    card.name = "instantiated1HandCard26c";

                } else if (card.name == "instantiated1Card27(Clone)") {

                    card.name = "instantiated1HandCard27";

                } else if (card.name == "instantiated1Card27a(Clone)") {

                    card.name = "instantiated1HandCard27a";

                } else if (card.name == "instantiated1Card27b(Clone)") {

                    card.name = "instantiated1HandCard27b";

                } else if (card.name == "instantiated1Card27c(Clone)") {

                    card.name = "instantiated1HandCard27c";

                } else if (card.name == "instantiated1Card28(Clone)") {

                    card.name = "instantiated1HandCard28";

                } else if (card.name == "instantiated1Card28a(Clone)") {

                    card.name = "instantiated1HandCard28a";

                } else if (card.name == "instantiated1Card28b(Clone)") {

                    card.name = "instantiated1HandCard28b";

                } else if (card.name == "instantiated1Card28c(Clone)") {

                    card.name = "instantiated1HandCard28c";

                } else if (card.name == "instantiated1Card29(Clone)") {

                    card.name = "instantiated1HandCard29";

                } else if (card.name == "instantiated1Card29a(Clone)") {

                    card.name = "instantiated1HandCard29a";

                } else if (card.name == "instantiated1Card29b(Clone)") {

                    card.name = "instantiated1HandCard29b";

                } else if (card.name == "instantiated1Card29c(Clone)") {

                    card.name = "instantiated1HandCard29c";

                } else if (card.name == "instantiated1Card30(Clone)") {

                    card.name = "instantiated1HandCard30";

                } else if (card.name == "instantiated1Card30a(Clone)") {

                    card.name = "instantiated1HandCard30a";

                } else if (card.name == "instantiated1Card30b(Clone)") {

                    card.name = "instantiated1HandCard30b";

                } else if (card.name == "instantiated1Card30c(Clone)") {

                    card.name = "instantiated1HandCard30c";

                } else if (card.name == "instantiated1Card31(Clone)") {

                    card.name = "instantiated1HandCard31";

                } else if (card.name == "instantiated1Card31a(Clone)") {

                    card.name = "instantiated1HandCard31a";

                } else if (card.name == "instantiated1Card31b(Clone)") {

                    card.name = "instantiated1HandCard31b";

                } else if (card.name == "instantiated1Card31c(Clone)") {

                    card.name = "instantiated1HandCard31c";

                } else if (card.name == "instantiated1Card32(Clone)") {

                    card.name = "instantiated1HandCard32";

                } else if (card.name == "instantiated1Card32a(Clone)") {

                    card.name = "instantiated1HandCard32a";

                } else if (card.name == "instantiated1Card32b(Clone)") {

                    card.name = "instantiated1HandCard32b";

                } else if (card.name == "instantiated1Card32c(Clone)") {

                    card.name = "instantiated1HandCard32c";

                } else if (card.name == "instantiated1Card33(Clone)") {

                    card.name = "instantiated1HandCard33";

                } else if (card.name == "instantiated1Card33a(Clone)") {

                    card.name = "instantiated1HandCard33a";

                } else if (card.name == "instantiated1Card33b(Clone)") {

                    card.name = "instantiated1HandCard33b";

                } else if (card.name == "instantiated1Card33c(Clone)") {

                    card.name = "instantiated1HandCard33c";

                } else if (card.name == "instantiated1Card34(Clone)") {

                    card.name = "instantiated1HandCard34";

                } else if (card.name == "instantiated1Card34a(Clone)") {

                    card.name = "instantiated1HandCard34a";

                } else if (card.name == "instantiated1Card34b(Clone)") {

                    card.name = "instantiated1HandCard34b";

                } else if (card.name == "instantiated1Card34c(Clone)") {

                    card.name = "instantiated1HandCard34c";

                } else if (card.name == "instantiated1Card35(Clone)") {

                    card.name = "instantiated1HandCard35";

                } else if (card.name == "instantiated1Card35a(Clone)") {

                    card.name = "instantiated1HandCard35a";

                } else if (card.name == "instantiated1Card35b(Clone)") {

                    card.name = "instantiated1HandCard35b";

                } else if (card.name == "instantiated1Card35c(Clone)") {

                    card.name = "instantiated1HandCard35c";

                } else if (card.name == "instantiated1Card36(Clone)") {

                    card.name = "instantiated1HandCard36";

                } else if (card.name == "instantiated1Card36a(Clone)") {

                    card.name = "instantiated1HandCard36a";

                } else if (card.name == "instantiated1Card36b(Clone)") {

                    card.name = "instantiated1HandCard36b";

                } else if (card.name == "instantiated1Card36c(Clone)") {

                    card.name = "instantiated1HandCard36c";

                } else if (card.name == "instantiated1Card37(Clone)") {

                    card.name = "instantiated1HandCard37";

                } else if (card.name == "instantiated1Card37a(Clone)") {

                    card.name = "instantiated1HandCard37a";

                } else if (card.name == "instantiated1Card37b(Clone)") {

                    card.name = "instantiated1HandCard37b";

                } else if (card.name == "instantiated1Card37c(Clone)") {

                    card.name = "instantiated1HandCard37c";

                } else if (card.name == "instantiated1Card38(Clone)") {

                    card.name = "instantiated1HandCard38";

                } else if (card.name == "instantiated1Card38a(Clone)") {

                    card.name = "instantiated1HandCard38a";

                } else if (card.name == "instantiated1Card38b(Clone)") {

                    card.name = "instantiated1HandCard38b";

                } else if (card.name == "instantiated1Card38c(Clone)") {

                    card.name = "instantiated1HandCard38c";

                } else if (card.name == "instantiated1Card39(Clone)") {

                    card.name = "instantiated1HandCard39";

                } else if (card.name == "instantiated1Card39a(Clone)") {

                    card.name = "instantiated1HandCard39a";

                } else if (card.name == "instantiated1Card39b(Clone)") {

                    card.name = "instantiated1HandCard39b";

                } else if (card.name == "instantiated1Card39c(Clone)") {

                    card.name = "instantiated1HandCard39c";

                } else if (card.name == "instantiated1Card40(Clone)") {

                    card.name = "instantiated1HandCard40";

                } else if (card.name == "instantiated1Card40a(Clone)") {

                    card.name = "instantiated1HandCard40a";

                } else if (card.name == "instantiated1Card40b(Clone)") {

                    card.name = "instantiated1HandCard40b";

                } else if (card.name == "instantiated1Card40c(Clone)") {

                    card.name = "instantiated1HandCard40c";

                } else if (card.name == "instantiated1Card41(Clone)") {

                    card.name = "instantiated1HandCard41";

                } else if (card.name == "instantiated1Card41a(Clone)") {

                    card.name = "instantiated1HandCard41a";

                } else if (card.name == "instantiated1Card41b(Clone)") {

                    card.name = "instantiated1HandCard41b";

                } else if (card.name == "instantiated1Card41c(Clone)") {

                    card.name = "instantiated1HandCard41c";

                } else if (card.name == "instantiated1Card42(Clone)") {

                    card.name = "instantiated1HandCard42";

                } else if (card.name == "instantiated1Card42a(Clone)") {

                    card.name = "instantiated1HandCard42a";

                } else if (card.name == "instantiated1Card42b(Clone)") {

                    card.name = "instantiated1HandCard42b";

                } else if (card.name == "instantiated1Card42c(Clone)") {

                    card.name = "instantiated1HandCard42c";

                } else if (card.name == "instantiated1Card43(Clone)") {

                    card.name = "instantiated1HandCard43";

                } else if (card.name == "instantiated1Card43a(Clone)") {

                    card.name = "instantiated1HandCard43a";

                } else if (card.name == "instantiated1Card43b(Clone)") {

                    card.name = "instantiated1HandCard43b";

                } else if (card.name == "instantiated1Card43c(Clone)") {

                    card.name = "instantiated1HandCard43c";

                } else if (card.name == "instantiated1Card44(Clone)") {

                    card.name = "instantiated1HandCard44";

                } else if (card.name == "instantiated1Card44a(Clone)") {

                    card.name = "instantiated1HandCard44a";

                } else if (card.name == "instantiated1Card44b(Clone)") {

                    card.name = "instantiated1HandCard44b";

                } else if (card.name == "instantiated1Card44c(Clone)") {

                    card.name = "instantiated1HandCard44c";

                } else if (card.name == "instantiated1Card45(Clone)") {

                    card.name = "instantiated1HandCard45";

                } else if (card.name == "instantiated1Card45a(Clone)") {

                    card.name = "instantiated1HandCard45a";

                } else if (card.name == "instantiated1Card45b(Clone)") {

                    card.name = "instantiated1HandCard45b";

                } else if (card.name == "instantiated1Card45c(Clone)") {

                    card.name = "instantiated1HandCard45c";

                } else if (card.name == "instantiated1Card46(Clone)") {

                    card.name = "instantiated1HandCard46";

                } else if (card.name == "instantiated1Card46a(Clone)") {

                    card.name = "instantiated1HandCard46a";

                } else if (card.name == "instantiated1Card46b(Clone)") {

                    card.name = "instantiated1HandCard46b";

                } else if (card.name == "instantiated1Card46c(Clone)") {

                    card.name = "instantiated1HandCard46c";

                } else if (card.name == "instantiated1Card47(Clone)") {

                    card.name = "instantiated1HandCard47";

                } else if (card.name == "instantiated1Card47a(Clone)") {

                    card.name = "instantiated1HandCard47a";

                } else if (card.name == "instantiated1Card47b(Clone)") {

                    card.name = "instantiated1HandCard47b";

                } else if (card.name == "instantiated1Card47c(Clone)") {

                    card.name = "instantiated1HandCard47c";

                } else if (card.name == "instantiated1Card48(Clone)") {

                    card.name = "instantiated1HandCard48";

                } else if (card.name == "instantiated1Card48a(Clone)") {

                    card.name = "instantiated1HandCard48a";

                } else if (card.name == "instantiated1Card48b(Clone)") {

                    card.name = "instantiated1HandCard48b";

                } else if (card.name == "instantiated1Card48c(Clone)") {

                    card.name = "instantiated1HandCard48c";

                } else if (card.name == "instantiated1Card49(Clone)") {

                    card.name = "instantiated1HandCard49";

                } else if (card.name == "instantiated1Card49a(Clone)") {

                    card.name = "instantiated1HandCard49a";

                } else if (card.name == "instantiated1Card49b(Clone)") {

                    card.name = "instantiated1HandCard49b";

                } else if (card.name == "instantiated1Card49c(Clone)") {

                    card.name = "instantiated1HandCard49c";

                } else if (card.name == "instantiated1Card50(Clone)") {

                    card.name = "instantiated1HandCard50";

                } else if (card.name == "instantiated1Card50a(Clone)") {

                    card.name = "instantiated1HandCard50a";

                } else if (card.name == "instantiated1Card50b(Clone)") {

                    card.name = "instantiated1HandCard50b";

                } else if (card.name == "instantiated1Card50c(Clone)") {

                    card.name = "instantiated1HandCard50c";

                } else if (card.name == "instantiated1Card51(Clone)") {

                    card.name = "instantiated1HandCard51";

                } else if (card.name == "instantiated1Card51a(Clone)") {

                    card.name = "instantiated1HandCard51a";

                } else if (card.name == "instantiated1Card51b(Clone)") {

                    card.name = "instantiated1HandCard51b";

                } else if (card.name == "instantiated1Card51c(Clone)") {

                    card.name = "instantiated1HandCard51c";

                } else if (card.name == "instantiated1Card52(Clone)") {

                    card.name = "instantiated1HandCard52";

                } else if (card.name == "instantiated1Card52a(Clone)") {

                    card.name = "instantiated1HandCard52a";

                } else if (card.name == "instantiated1Card52b(Clone)") {

                    card.name = "instantiated1HandCard52b";

                } else if (card.name == "instantiated1Card52c(Clone)") {

                    card.name = "instantiated1HandCard52c";

                } else if (card.name == "instantiated1Card53(Clone)") {

                    card.name = "instantiated1HandCard53";

                } else if (card.name == "instantiated1Card53a(Clone)") {

                    card.name = "instantiated1HandCard53a";

                } else if (card.name == "instantiated1Card53b(Clone)") {

                    card.name = "instantiated1HandCard53b";

                } else if (card.name == "instantiated1Card53c(Clone)") {

                    card.name = "instantiated1HandCard53c";

                } else if (card.name == "instantiated1Card54(Clone)") {

                    card.name = "instantiated1HandCard54";

                } else if (card.name == "instantiated1Card54a(Clone)") {

                    card.name = "instantiated1HandCard54a";

                } else if (card.name == "instantiated1Card54b(Clone)") {

                    card.name = "instantiated1HandCard54b";

                } else if (card.name == "instantiated1Card54c(Clone)") {

                    card.name = "instantiated1HandCard54c";

                } else if (card.name == "instantiated1Card55(Clone)") {

                    card.name = "instantiated1HandCard55";

                } else if (card.name == "instantiated1Card55a(Clone)") {

                    card.name = "instantiated1HandCard55a";

                } else if (card.name == "instantiated1Card55b(Clone)") {

                    card.name = "instantiated1HandCard55b";

                } else if (card.name == "instantiated1Card55c(Clone)") {

                    card.name = "instantiated1HandCard55c";

                } else if (card.name == "instantiated1Card56(Clone)") {

                    card.name = "instantiated1HandCard56";

                } else if (card.name == "instantiated1Card56a(Clone)") {

                    card.name = "instantiated1HandCard56a";

                } else if (card.name == "instantiated1Card56b(Clone)") {

                    card.name = "instantiated1HandCard56b";

                } else if (card.name == "instantiated1Card56c(Clone)") {

                    card.name = "instantiated1HandCard56c";

                } else if (card.name == "instantiated1Card57(Clone)") {

                    card.name = "instantiated1HandCard57";

                } else if (card.name == "instantiated1Card57a(Clone)") {

                    card.name = "instantiated1HandCard57a";

                } else if (card.name == "instantiated1Card57b(Clone)") {

                    card.name = "instantiated1HandCard57b";

                } else if (card.name == "instantiated1Card57c(Clone)") {

                    card.name = "instantiated1HandCard57c";

                } else if (card.name == "instantiated1Card58(Clone)") {

                    card.name = "instantiated1HandCard58";

                } else if (card.name == "instantiated1Card58a(Clone)") {

                    card.name = "instantiated1HandCard58a";

                } else if (card.name == "instantiated1Card58b(Clone)") {

                    card.name = "instantiated1HandCard58b";

                } else if (card.name == "instantiated1Card58c(Clone)") {

                    card.name = "instantiated1HandCard58c";

                } else if (card.name == "instantiated1Card59(Clone)") {

                    card.name = "instantiated1HandCard59";

                } else if (card.name == "instantiated1Card59a(Clone)") {

                    card.name = "instantiated1HandCard59a";

                } else if (card.name == "instantiated1Card59b(Clone)") {

                    card.name = "instantiated1HandCard59b";

                } else if (card.name == "instantiated1Card59c(Clone)") {

                    card.name = "instantiated1HandCard59c";

                } else if (card.name == "instantiated1Card60(Clone)") {

                    card.name = "instantiated1HandCard60";

                } else if (card.name == "instantiated1Card60a(Clone)") {

                    card.name = "instantiated1HandCard60a";

                } else if (card.name == "instantiated1Card60b(Clone)") {

                    card.name = "instantiated1HandCard60b";

                } else if (card.name == "instantiated1Card60c(Clone)") {

                    card.name = "instantiated1HandCard60c";
                }

                instances2++;

            }

            while (instances3 < NumberOfCards) {

                GameObject card = Instantiate(playCardsDeck1[UnityEngine.Random.Range(0, playCardsDeck1.Count)], player1DeckSlot3.transform.position, player1DeckSlot3.transform.rotation) as GameObject;
                card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                card.transform.parent = player1DeckSlot3.transform;

                if (card.name == "instantiated1Card1(Clone)") {

                    card.name = "instantiated1HandCard1";

                } else if (card.name == "instantiated1Card1a(Clone)") {

                    card.name = "instantiated1HandCard1a";

                } else if (card.name == "instantiated1Card1b(Clone)") {

                    card.name = "instantiated1HandCard1b";

                } else if (card.name == "instantiated1Card1c(Clone)") {

                    card.name = "instantiated1HandCard1c";

                } else if (card.name == "instantiated1Card2(Clone)") {

                    card.name = "instantiated1HandCard2";

                } else if (card.name == "instantiated1Card2a(Clone)") {

                    card.name = "instantiated1HandCard2a";

                } else if (card.name == "instantiated1Card2b(Clone)") {

                    card.name = "instantiated1HandCard2b";

                } else if (card.name == "instantiated1Card2c(Clone)") {

                    card.name = "instantiated1HandCard2c";

                } else if (card.name == "instantiated1Card3(Clone)") {

                    card.name = "instantiated1HandCard3";

                } else if (card.name == "instantiated1Card3a(Clone)") {

                    card.name = "instantiated1HandCard3a";

                } else if (card.name == "instantiated1Card3b(Clone)") {

                    card.name = "instantiated1HandCard3b";

                } else if (card.name == "instantiated1Card3c(Clone)") {

                    card.name = "instantiated1HandCard3c";

                } else if (card.name == "instantiated1Card4(Clone)") {

                    card.name = "instantiated1HandCard4";

                } else if (card.name == "instantiated1Card4a(Clone)") {

                    card.name = "instantiated1HandCard4a";

                } else if (card.name == "instantiated1Card4b(Clone)") {

                    card.name = "instantiated1HandCard4b";

                } else if (card.name == "instantiated1Card4c(Clone)") {

                    card.name = "instantiated1HandCard4c";

                } else if (card.name == "instantiated1Card5(Clone)") {

                    card.name = "instantiated1HandCard5";

                } else if (card.name == "instantiated1Card5a(Clone)") {

                    card.name = "instantiated1HandCard5a";

                } else if (card.name == "instantiated1Card5b(Clone)") {

                    card.name = "instantiated1HandCard5b";

                } else if (card.name == "instantiated1Card5c(Clone)") {

                    card.name = "instantiated1HandCard5c";

                } else if (card.name == "instantiated1Card6(Clone)") {

                    card.name = "instantiated1HandCard6";

                } else if (card.name == "instantiated1Card6a(Clone)") {

                    card.name = "instantiated1HandCard6a";

                } else if (card.name == "instantiated1Card6b(Clone)") {

                    card.name = "instantiated1HandCard6b";

                } else if (card.name == "instantiated1Card6c(Clone)") {

                    card.name = "instantiated1HandCard6c";

                } else if (card.name == "instantiated1Card7(Clone)") {

                    card.name = "instantiated1HandCard7";

                } else if (card.name == "instantiated1Card7a(Clone)") {

                    card.name = "instantiated1HandCard7a";

                } else if (card.name == "instantiated1Card7b(Clone)") {

                    card.name = "instantiated1HandCard7b";

                } else if (card.name == "instantiated1Card7c(Clone)") {

                    card.name = "instantiated1HandCard7c";

                } else if (card.name == "instantiated1Card8(Clone)") {

                    card.name = "instantiated1HandCard8";

                } else if (card.name == "instantiated1Card8a(Clone)") {

                    card.name = "instantiated1HandCard8a";

                } else if (card.name == "instantiated1Card8b(Clone)") {

                    card.name = "instantiated1HandCard8b";

                } else if (card.name == "instantiated1Card8c(Clone)") {

                    card.name = "instantiated1HandCard8c";

                } else if (card.name == "instantiated1Card9(Clone)") {

                    card.name = "instantiated1HandCard9";

                } else if (card.name == "instantiated1Card9a(Clone)") {

                    card.name = "instantiated1HandCard9a";

                } else if (card.name == "instantiated1Card9b(Clone)") {

                    card.name = "instantiated1HandCard9b";

                } else if (card.name == "instantiated1Card9c(Clone)") {

                    card.name = "instantiated1HandCard9c";

                } else if (card.name == "instantiated1Card10(Clone)") {

                    card.name = "instantiatedAICard10";

                } else if (card.name == "instantiated1Card10a(Clone)") {

                    card.name = "instantiated1HandCard10a";

                } else if (card.name == "instantiated1Card10b(Clone)") {

                    card.name = "instantiated1HandCard10b";

                } else if (card.name == "instantiated1Card10c(Clone)") {

                    card.name = "instantiated1HandCard10c";

                } else if (card.name == "instantiated1Card11(Clone)") {

                    card.name = "instantiated1HandCard11";

                } else if (card.name == "instantiated1Card11a(Clone)") {

                    card.name = "instantiated1HandCard11a";

                } else if (card.name == "instantiated1Card11b(Clone)") {

                    card.name = "instantiated1HandCard11b";

                } else if (card.name == "instantiated1Card11c(Clone)") {

                    card.name = "instantiated1HandCard11c";

                } else if (card.name == "instantiated1Card12(Clone)") {

                    card.name = "instantiated1HandCard12";

                } else if (card.name == "instantiated1Card12a(Clone)") {

                    card.name = "instantiated1HandCard12a";

                } else if (card.name == "instantiated1Card12b(Clone)") {

                    card.name = "instantiated1HandCard12b";

                } else if (card.name == "instantiated1Card12c(Clone)") {

                    card.name = "instantiated1HandCard12c";

                } else if (card.name == "instantiated1Card13(Clone)") {

                    card.name = "instantiated1HandCard13";

                } else if (card.name == "instantiated1Card13a(Clone)") {

                    card.name = "instantiated1HandCard13a";

                } else if (card.name == "instantiated1Card13b(Clone)") {

                    card.name = "instantiated1HandCard13b";

                } else if (card.name == "instantiated1Card13c(Clone)") {

                    card.name = "instantiated1HandCard13c";

                } else if (card.name == "instantiated1Card14(Clone)") {

                    card.name = "instantiated1HandCard14";

                } else if (card.name == "instantiated1Card14a(Clone)") {

                    card.name = "instantiated1HandCard14a";

                } else if (card.name == "instantiated1Card14b(Clone)") {

                    card.name = "instantiated1HandCard14b";

                } else if (card.name == "instantiated1Card14c(Clone)") {

                    card.name = "instantiated1HandCard14c";

                } else if (card.name == "instantiated1Card15(Clone)") {

                    card.name = "instantiated1HandCard15";

                } else if (card.name == "instantiated1Card15a(Clone)") {

                    card.name = "instantiated1HandCard15a";

                } else if (card.name == "instantiated1Card15b(Clone)") {

                    card.name = "instantiated1HandCard15b";

                } else if (card.name == "instantiated1Card15c(Clone)") {

                    card.name = "instantiated1HandCard15c";

                } else if (card.name == "instantiated1Card16(Clone)") {

                    card.name = "instantiated1HandCard16";

                } else if (card.name == "instantiated1Card16a(Clone)") {

                    card.name = "instantiated1HandCard16a";

                } else if (card.name == "instantiated1Card16b(Clone)") {

                    card.name = "instantiated1HandCard16b";

                } else if (card.name == "instantiated1Card16c(Clone)") {

                    card.name = "instantiated1HandCard16c";

                } else if (card.name == "instantiated1Card17(Clone)") {

                    card.name = "instantiated1HandCard17";

                } else if (card.name == "instantiated1Card17a(Clone)") {

                    card.name = "instantiated1HandCard17a";

                } else if (card.name == "instantiated1Card17b(Clone)") {

                    card.name = "instantiated1HandCard17b";

                } else if (card.name == "instantiated1Card17c(Clone)") {

                    card.name = "instantiated1HandCard17c";

                } else if (card.name == "instantiated1Card18(Clone)") {

                    card.name = "instantiated1HandCard18";

                } else if (card.name == "instantiated1Card18a(Clone)") {

                    card.name = "instantiated1HandCard18a";

                } else if (card.name == "instantiated1Card18b(Clone)") {

                    card.name = "instantiated1HandCard18b";

                } else if (card.name == "instantiated1Card18c(Clone)") {

                    card.name = "instantiated1HandCard18c";

                } else if (card.name == "instantiated1Card19(Clone)") {

                    card.name = "instantiated1HandCard19";

                } else if (card.name == "instantiated1Card19a(Clone)") {

                    card.name = "instantiated1HandCard19a";

                } else if (card.name == "instantiated1Card19b(Clone)") {

                    card.name = "instantiated1HandCard19b";

                } else if (card.name == "instantiated1Card19c(Clone)") {

                    card.name = "instantiated1HandCard19c";

                } else if (card.name == "instantiated1Card20(Clone)") {

                    card.name = "instantiated1HandCard20";

                } else if (card.name == "instantiated1Card20a(Clone)") {

                    card.name = "instantiated1HandCard20a";

                } else if (card.name == "instantiated1Card20b(Clone)") {

                    card.name = "instantiated1HandCard20b";

                } else if (card.name == "instantiated1Card20c(Clone)") {

                    card.name = "instantiated1HandCard20c";

                } else if (card.name == "instantiated1Card21(Clone)") {

                    card.name = "instantiated1HandCard21";

                } else if (card.name == "instantiated1Card21a(Clone)") {

                    card.name = "instantiated1HandCard21a";

                } else if (card.name == "instantiated1Card21b(Clone)") {

                    card.name = "instantiated1HandCard21b";

                } else if (card.name == "instantiated1Card21c(Clone)") {

                    card.name = "instantiated1HandCard21c";

                } else if (card.name == "instantiated1Card22(Clone)") {

                    card.name = "instantiated1HandCard22";

                } else if (card.name == "instantiated1Card22a(Clone)") {

                    card.name = "instantiated1HandCard22a";

                } else if (card.name == "instantiated1Card22b(Clone)") {

                    card.name = "instantiated1HandCard22b";

                } else if (card.name == "instantiated1Card22c(Clone)") {

                    card.name = "instantiated1HandCard22c";

                } else if (card.name == "instantiated1Card23(Clone)") {

                    card.name = "instantiated1HandCard23";

                } else if (card.name == "instantiated1Card23a(Clone)") {

                    card.name = "instantiated1HandCard23a";

                } else if (card.name == "instantiated1Card23b(Clone)") {

                    card.name = "instantiated1HandCard23b";

                } else if (card.name == "instantiated1Card23c(Clone)") {

                    card.name = "instantiated1HandCard23c";

                } else if (card.name == "instantiated1Card24(Clone)") {

                    card.name = "instantiated1HandCard24";

                } else if (card.name == "instantiated1Card24a(Clone)") {

                    card.name = "instantiated1HandCard24a";

                } else if (card.name == "instantiated1Card24b(Clone)") {

                    card.name = "instantiated1HandCard24b";

                } else if (card.name == "instantiated1Card24c(Clone)") {

                    card.name = "instantiated1HandCard24c";

                } else if (card.name == "instantiated1Card25(Clone)") {

                    card.name = "instantiated1HandCard25";

                } else if (card.name == "instantiated1Card25a(Clone)") {

                    card.name = "instantiated1HandCard25a";

                } else if (card.name == "instantiated1Card25b(Clone)") {

                    card.name = "instantiated1HandCard25b";

                } else if (card.name == "instantiated1Card25c(Clone)") {

                    card.name = "instantiated1HandCard25c";

                } else if (card.name == "instantiated1Card26(Clone)") {

                    card.name = "instantiated1HandCard26";

                } else if (card.name == "instantiated1Card26a(Clone)") {

                    card.name = "instantiated1HandCard26a";

                } else if (card.name == "instantiated1Card26b(Clone)") {

                    card.name = "instantiated1HandCard26b";

                } else if (card.name == "instantiated1Card26c(Clone)") {

                    card.name = "instantiated1HandCard26c";

                } else if (card.name == "instantiated1Card27(Clone)") {

                    card.name = "instantiated1HandCard27";

                } else if (card.name == "instantiated1Card27a(Clone)") {

                    card.name = "instantiated1HandCard27a";

                } else if (card.name == "instantiated1Card27b(Clone)") {

                    card.name = "instantiated1HandCard27b";

                } else if (card.name == "instantiated1Card27c(Clone)") {

                    card.name = "instantiated1HandCard27c";

                } else if (card.name == "instantiated1Card28(Clone)") {

                    card.name = "instantiated1HandCard28";

                } else if (card.name == "instantiated1Card28a(Clone)") {

                    card.name = "instantiated1HandCard28a";

                } else if (card.name == "instantiated1Card28b(Clone)") {

                    card.name = "instantiated1HandCard28b";

                } else if (card.name == "instantiated1Card28c(Clone)") {

                    card.name = "instantiated1HandCard28c";

                } else if (card.name == "instantiated1Card29(Clone)") {

                    card.name = "instantiated1HandCard29";

                } else if (card.name == "instantiated1Card29a(Clone)") {

                    card.name = "instantiated1HandCard29a";

                } else if (card.name == "instantiated1Card29b(Clone)") {

                    card.name = "instantiated1HandCard29b";

                } else if (card.name == "instantiated1Card29c(Clone)") {

                    card.name = "instantiated1HandCard29c";

                } else if (card.name == "instantiated1Card30(Clone)") {

                    card.name = "instantiated1HandCard30";

                } else if (card.name == "instantiated1Card30a(Clone)") {

                    card.name = "instantiated1HandCard30a";

                } else if (card.name == "instantiated1Card30b(Clone)") {

                    card.name = "instantiated1HandCard30b";

                } else if (card.name == "instantiated1Card30c(Clone)") {

                    card.name = "instantiated1HandCard30c";

                } else if (card.name == "instantiated1Card31(Clone)") {

                    card.name = "instantiated1HandCard31";

                } else if (card.name == "instantiated1Card31a(Clone)") {

                    card.name = "instantiated1HandCard31a";

                } else if (card.name == "instantiated1Card31b(Clone)") {

                    card.name = "instantiated1HandCard31b";

                } else if (card.name == "instantiated1Card31c(Clone)") {

                    card.name = "instantiated1HandCard31c";

                } else if (card.name == "instantiated1Card32(Clone)") {

                    card.name = "instantiated1HandCard32";

                } else if (card.name == "instantiated1Card32a(Clone)") {

                    card.name = "instantiated1HandCard32a";

                } else if (card.name == "instantiated1Card32b(Clone)") {

                    card.name = "instantiated1HandCard32b";

                } else if (card.name == "instantiated1Card32c(Clone)") {

                    card.name = "instantiated1HandCard32c";

                } else if (card.name == "instantiated1Card33(Clone)") {

                    card.name = "instantiated1HandCard33";

                } else if (card.name == "instantiated1Card33a(Clone)") {

                    card.name = "instantiated1HandCard33a";

                } else if (card.name == "instantiated1Card33b(Clone)") {

                    card.name = "instantiated1HandCard33b";

                } else if (card.name == "instantiated1Card33c(Clone)") {

                    card.name = "instantiated1HandCard33c";

                } else if (card.name == "instantiated1Card34(Clone)") {

                    card.name = "instantiated1HandCard34";

                } else if (card.name == "instantiated1Card34a(Clone)") {

                    card.name = "instantiated1HandCard34a";

                } else if (card.name == "instantiated1Card34b(Clone)") {

                    card.name = "instantiated1HandCard34b";

                } else if (card.name == "instantiated1Card34c(Clone)") {

                    card.name = "instantiated1HandCard34c";

                } else if (card.name == "instantiated1Card35(Clone)") {

                    card.name = "instantiated1HandCard35";

                } else if (card.name == "instantiated1Card35a(Clone)") {

                    card.name = "instantiated1HandCard35a";

                } else if (card.name == "instantiated1Card35b(Clone)") {

                    card.name = "instantiated1HandCard35b";

                } else if (card.name == "instantiated1Card35c(Clone)") {

                    card.name = "instantiated1HandCard35c";

                } else if (card.name == "instantiated1Card36(Clone)") {

                    card.name = "instantiated1HandCard36";

                } else if (card.name == "instantiated1Card36a(Clone)") {

                    card.name = "instantiated1HandCard36a";

                } else if (card.name == "instantiated1Card36b(Clone)") {

                    card.name = "instantiated1HandCard36b";

                } else if (card.name == "instantiated1Card36c(Clone)") {

                    card.name = "instantiated1HandCard36c";

                } else if (card.name == "instantiated1Card37(Clone)") {

                    card.name = "instantiated1HandCard37";

                } else if (card.name == "instantiated1Card37a(Clone)") {

                    card.name = "instantiated1HandCard37a";

                } else if (card.name == "instantiated1Card37b(Clone)") {

                    card.name = "instantiated1HandCard37b";

                } else if (card.name == "instantiated1Card37c(Clone)") {

                    card.name = "instantiated1HandCard37c";

                } else if (card.name == "instantiated1Card38(Clone)") {

                    card.name = "instantiated1HandCard38";

                } else if (card.name == "instantiated1Card38a(Clone)") {

                    card.name = "instantiated1HandCard38a";

                } else if (card.name == "instantiated1Card38b(Clone)") {

                    card.name = "instantiated1HandCard38b";

                } else if (card.name == "instantiated1Card38c(Clone)") {

                    card.name = "instantiated1HandCard38c";

                } else if (card.name == "instantiated1Card39(Clone)") {

                    card.name = "instantiated1HandCard39";

                } else if (card.name == "instantiated1Card39a(Clone)") {

                    card.name = "instantiated1HandCard39a";

                } else if (card.name == "instantiated1Card39b(Clone)") {

                    card.name = "instantiated1HandCard39b";

                } else if (card.name == "instantiated1Card39c(Clone)") {

                    card.name = "instantiated1HandCard39c";

                } else if (card.name == "instantiated1Card40(Clone)") {

                    card.name = "instantiated1HandCard40";

                } else if (card.name == "instantiated1Card40a(Clone)") {

                    card.name = "instantiated1HandCard40a";

                } else if (card.name == "instantiated1Card40b(Clone)") {

                    card.name = "instantiated1HandCard40b";

                } else if (card.name == "instantiated1Card40c(Clone)") {

                    card.name = "instantiated1HandCard40c";

                } else if (card.name == "instantiated1Card41(Clone)") {

                    card.name = "instantiated1HandCard41";

                } else if (card.name == "instantiated1Card41a(Clone)") {

                    card.name = "instantiated1HandCard41a";

                } else if (card.name == "instantiated1Card41b(Clone)") {

                    card.name = "instantiated1HandCard41b";

                } else if (card.name == "instantiated1Card41c(Clone)") {

                    card.name = "instantiated1HandCard41c";

                } else if (card.name == "instantiated1Card42(Clone)") {

                    card.name = "instantiated1HandCard42";

                } else if (card.name == "instantiated1Card42a(Clone)") {

                    card.name = "instantiated1HandCard42a";

                } else if (card.name == "instantiated1Card42b(Clone)") {

                    card.name = "instantiated1HandCard42b";

                } else if (card.name == "instantiated1Card42c(Clone)") {

                    card.name = "instantiated1HandCard42c";

                } else if (card.name == "instantiated1Card43(Clone)") {

                    card.name = "instantiated1HandCard43";

                } else if (card.name == "instantiated1Card43a(Clone)") {

                    card.name = "instantiated1HandCard43a";

                } else if (card.name == "instantiated1Card43b(Clone)") {

                    card.name = "instantiated1HandCard43b";

                } else if (card.name == "instantiated1Card43c(Clone)") {

                    card.name = "instantiated1HandCard43c";

                } else if (card.name == "instantiated1Card44(Clone)") {

                    card.name = "instantiated1HandCard44";

                } else if (card.name == "instantiated1Card44a(Clone)") {

                    card.name = "instantiated1HandCard44a";

                } else if (card.name == "instantiated1Card44b(Clone)") {

                    card.name = "instantiated1HandCard44b";

                } else if (card.name == "instantiated1Card44c(Clone)") {

                    card.name = "instantiated1HandCard44c";

                } else if (card.name == "instantiated1Card45(Clone)") {

                    card.name = "instantiated1HandCard45";

                } else if (card.name == "instantiated1Card45a(Clone)") {

                    card.name = "instantiated1HandCard45a";

                } else if (card.name == "instantiated1Card45b(Clone)") {

                    card.name = "instantiated1HandCard45b";

                } else if (card.name == "instantiated1Card45c(Clone)") {

                    card.name = "instantiated1HandCard45c";

                } else if (card.name == "instantiated1Card46(Clone)") {

                    card.name = "instantiated1HandCard46";

                } else if (card.name == "instantiated1Card46a(Clone)") {

                    card.name = "instantiated1HandCard46a";

                } else if (card.name == "instantiated1Card46b(Clone)") {

                    card.name = "instantiated1HandCard46b";

                } else if (card.name == "instantiated1Card46c(Clone)") {

                    card.name = "instantiated1HandCard46c";

                } else if (card.name == "instantiated1Card47(Clone)") {

                    card.name = "instantiated1HandCard47";

                } else if (card.name == "instantiated1Card47a(Clone)") {

                    card.name = "instantiated1HandCard47a";

                } else if (card.name == "instantiated1Card47b(Clone)") {

                    card.name = "instantiated1HandCard47b";

                } else if (card.name == "instantiated1Card47c(Clone)") {

                    card.name = "instantiated1HandCard47c";

                } else if (card.name == "instantiated1Card48(Clone)") {

                    card.name = "instantiated1HandCard48";

                } else if (card.name == "instantiated1Card48a(Clone)") {

                    card.name = "instantiated1HandCard48a";

                } else if (card.name == "instantiated1Card48b(Clone)") {

                    card.name = "instantiated1HandCard48b";

                } else if (card.name == "instantiated1Card48c(Clone)") {

                    card.name = "instantiated1HandCard48c";

                } else if (card.name == "instantiated1Card49(Clone)") {

                    card.name = "instantiated1HandCard49";

                } else if (card.name == "instantiated1Card49a(Clone)") {

                    card.name = "instantiated1HandCard49a";

                } else if (card.name == "instantiated1Card49b(Clone)") {

                    card.name = "instantiated1HandCard49b";

                } else if (card.name == "instantiated1Card49c(Clone)") {

                    card.name = "instantiated1HandCard49c";

                } else if (card.name == "instantiated1Card50(Clone)") {

                    card.name = "instantiated1HandCard50";

                } else if (card.name == "instantiated1Card50a(Clone)") {

                    card.name = "instantiated1HandCard50a";

                } else if (card.name == "instantiated1Card50b(Clone)") {

                    card.name = "instantiated1HandCard50b";

                } else if (card.name == "instantiated1Card50c(Clone)") {

                    card.name = "instantiated1HandCard50c";

                } else if (card.name == "instantiated1Card51(Clone)") {

                    card.name = "instantiated1HandCard51";

                } else if (card.name == "instantiated1Card51a(Clone)") {

                    card.name = "instantiated1HandCard51a";

                } else if (card.name == "instantiated1Card51b(Clone)") {

                    card.name = "instantiated1HandCard51b";

                } else if (card.name == "instantiated1Card51c(Clone)") {

                    card.name = "instantiated1HandCard51c";

                } else if (card.name == "instantiated1Card52(Clone)") {

                    card.name = "instantiated1HandCard52";

                } else if (card.name == "instantiated1Card52a(Clone)") {

                    card.name = "instantiated1HandCard52a";

                } else if (card.name == "instantiated1Card52b(Clone)") {

                    card.name = "instantiated1HandCard52b";

                } else if (card.name == "instantiated1Card52c(Clone)") {

                    card.name = "instantiated1HandCard52c";

                } else if (card.name == "instantiated1Card53(Clone)") {

                    card.name = "instantiated1HandCard53";

                } else if (card.name == "instantiated1Card53a(Clone)") {

                    card.name = "instantiated1HandCard53a";

                } else if (card.name == "instantiated1Card53b(Clone)") {

                    card.name = "instantiated1HandCard53b";

                } else if (card.name == "instantiated1Card53c(Clone)") {

                    card.name = "instantiated1HandCard53c";

                } else if (card.name == "instantiated1Card54(Clone)") {

                    card.name = "instantiated1HandCard54";

                } else if (card.name == "instantiated1Card54a(Clone)") {

                    card.name = "instantiated1HandCard54a";

                } else if (card.name == "instantiated1Card54b(Clone)") {

                    card.name = "instantiated1HandCard54b";

                } else if (card.name == "instantiated1Card54c(Clone)") {

                    card.name = "instantiated1HandCard54c";

                } else if (card.name == "instantiated1Card55(Clone)") {

                    card.name = "instantiated1HandCard55";

                } else if (card.name == "instantiated1Card55a(Clone)") {

                    card.name = "instantiated1HandCard55a";

                } else if (card.name == "instantiated1Card55b(Clone)") {

                    card.name = "instantiated1HandCard55b";

                } else if (card.name == "instantiated1Card55c(Clone)") {

                    card.name = "instantiated1HandCard55c";

                } else if (card.name == "instantiated1Card56(Clone)") {

                    card.name = "instantiated1HandCard56";

                } else if (card.name == "instantiated1Card56a(Clone)") {

                    card.name = "instantiated1HandCard56a";

                } else if (card.name == "instantiated1Card56b(Clone)") {

                    card.name = "instantiated1HandCard56b";

                } else if (card.name == "instantiated1Card56c(Clone)") {

                    card.name = "instantiated1HandCard56c";

                } else if (card.name == "instantiated1Card57(Clone)") {

                    card.name = "instantiated1HandCard57";

                } else if (card.name == "instantiated1Card57a(Clone)") {

                    card.name = "instantiated1HandCard57a";

                } else if (card.name == "instantiated1Card57b(Clone)") {

                    card.name = "instantiated1HandCard57b";

                } else if (card.name == "instantiated1Card57c(Clone)") {

                    card.name = "instantiated1HandCard57c";

                } else if (card.name == "instantiated1Card58(Clone)") {

                    card.name = "instantiated1HandCard58";

                } else if (card.name == "instantiated1Card58a(Clone)") {

                    card.name = "instantiated1HandCard58a";

                } else if (card.name == "instantiated1Card58b(Clone)") {

                    card.name = "instantiated1HandCard58b";

                } else if (card.name == "instantiated1Card58c(Clone)") {

                    card.name = "instantiated1HandCard58c";

                } else if (card.name == "instantiated1Card59(Clone)") {

                    card.name = "instantiated1HandCard59";

                } else if (card.name == "instantiated1Card59a(Clone)") {

                    card.name = "instantiated1HandCard59a";

                } else if (card.name == "instantiated1Card59b(Clone)") {

                    card.name = "instantiated1HandCard59b";

                } else if (card.name == "instantiated1Card59c(Clone)") {

                    card.name = "instantiated1HandCard59c";

                } else if (card.name == "instantiated1Card60(Clone)") {

                    card.name = "instantiated1HandCard60";

                } else if (card.name == "instantiated1Card60a(Clone)") {

                    card.name = "instantiated1HandCard60a";

                } else if (card.name == "instantiated1Card60b(Clone)") {

                    card.name = "instantiated1HandCard60b";

                } else if (card.name == "instantiated1Card60c(Clone)") {

                    card.name = "instantiated1HandCard60c";
                }

                instances3++;

            }


            while (instances4 < NumberOfCards) {

                GameObject card = Instantiate(playCardsDeck1[UnityEngine.Random.Range(0, playCardsDeck1.Count)], player1DeckSlot4.transform.position, player1DeckSlot4.transform.rotation) as GameObject;
                card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                card.transform.parent = player1DeckSlot4.transform;

                if (card.name == "instantiated1Card1(Clone)") {

                    card.name = "instantiated1HandCard1";

                } else if (card.name == "instantiated1Card1a(Clone)") {

                    card.name = "instantiated1HandCard1a";

                } else if (card.name == "instantiated1Card1b(Clone)") {

                    card.name = "instantiated1HandCard1b";

                } else if (card.name == "instantiated1Card1c(Clone)") {

                    card.name = "instantiated1HandCard1c";

                } else if (card.name == "instantiated1Card2(Clone)") {

                    card.name = "instantiated1HandCard2";

                } else if (card.name == "instantiated1Card2a(Clone)") {

                    card.name = "instantiated1HandCard2a";

                } else if (card.name == "instantiated1Card2b(Clone)") {

                    card.name = "instantiated1HandCard2b";

                } else if (card.name == "instantiated1Card2c(Clone)") {

                    card.name = "instantiated1HandCard2c";

                } else if (card.name == "instantiated1Card3(Clone)") {

                    card.name = "instantiated1HandCard3";

                } else if (card.name == "instantiated1Card3a(Clone)") {

                    card.name = "instantiated1HandCard3a";

                } else if (card.name == "instantiated1Card3b(Clone)") {

                    card.name = "instantiated1HandCard3b";

                } else if (card.name == "instantiated1Card3c(Clone)") {

                    card.name = "instantiated1HandCard3c";

                } else if (card.name == "instantiated1Card4(Clone)") {

                    card.name = "instantiated1HandCard4";

                } else if (card.name == "instantiated1Card4a(Clone)") {

                    card.name = "instantiated1HandCard4a";

                } else if (card.name == "instantiated1Card4b(Clone)") {

                    card.name = "instantiated1HandCard4b";

                } else if (card.name == "instantiated1Card4c(Clone)") {

                    card.name = "instantiated1HandCard4c";

                } else if (card.name == "instantiated1Card5(Clone)") {

                    card.name = "instantiated1HandCard5";

                } else if (card.name == "instantiated1Card5a(Clone)") {

                    card.name = "instantiated1HandCard5a";

                } else if (card.name == "instantiated1Card5b(Clone)") {

                    card.name = "instantiated1HandCard5b";

                } else if (card.name == "instantiated1Card5c(Clone)") {

                    card.name = "instantiated1HandCard5c";

                } else if (card.name == "instantiated1Card6(Clone)") {

                    card.name = "instantiated1HandCard6";

                } else if (card.name == "instantiated1Card6a(Clone)") {

                    card.name = "instantiated1HandCard6a";

                } else if (card.name == "instantiated1Card6b(Clone)") {

                    card.name = "instantiated1HandCard6b";

                } else if (card.name == "instantiated1Card6c(Clone)") {

                    card.name = "instantiated1HandCard6c";

                } else if (card.name == "instantiated1Card7(Clone)") {

                    card.name = "instantiated1HandCard7";

                } else if (card.name == "instantiated1Card7a(Clone)") {

                    card.name = "instantiated1HandCard7a";

                } else if (card.name == "instantiated1Card7b(Clone)") {

                    card.name = "instantiated1HandCard7b";

                } else if (card.name == "instantiated1Card7c(Clone)") {

                    card.name = "instantiated1HandCard7c";

                } else if (card.name == "instantiated1Card8(Clone)") {

                    card.name = "instantiated1HandCard8";

                } else if (card.name == "instantiated1Card8a(Clone)") {

                    card.name = "instantiated1HandCard8a";

                } else if (card.name == "instantiated1Card8b(Clone)") {

                    card.name = "instantiated1HandCard8b";

                } else if (card.name == "instantiated1Card8c(Clone)") {

                    card.name = "instantiated1HandCard8c";

                } else if (card.name == "instantiated1Card9(Clone)") {

                    card.name = "instantiated1HandCard9";

                } else if (card.name == "instantiated1Card9a(Clone)") {

                    card.name = "instantiated1HandCard9a";

                } else if (card.name == "instantiated1Card9b(Clone)") {

                    card.name = "instantiated1HandCard9b";

                } else if (card.name == "instantiated1Card9c(Clone)") {

                    card.name = "instantiated1HandCard9c";

                } else if (card.name == "instantiated1Card10(Clone)") {

                    card.name = "instantiatedAICard10";

                } else if (card.name == "instantiated1Card10a(Clone)") {

                    card.name = "instantiated1HandCard10a";

                } else if (card.name == "instantiated1Card10b(Clone)") {

                    card.name = "instantiated1HandCard10b";

                } else if (card.name == "instantiated1Card10c(Clone)") {

                    card.name = "instantiated1HandCard10c";

                } else if (card.name == "instantiated1Card11(Clone)") {

                    card.name = "instantiated1HandCard11";

                } else if (card.name == "instantiated1Card11a(Clone)") {

                    card.name = "instantiated1HandCard11a";

                } else if (card.name == "instantiated1Card11b(Clone)") {

                    card.name = "instantiated1HandCard11b";

                } else if (card.name == "instantiated1Card11c(Clone)") {

                    card.name = "instantiated1HandCard11c";

                } else if (card.name == "instantiated1Card12(Clone)") {

                    card.name = "instantiated1HandCard12";

                } else if (card.name == "instantiated1Card12a(Clone)") {

                    card.name = "instantiated1HandCard12a";

                } else if (card.name == "instantiated1Card12b(Clone)") {

                    card.name = "instantiated1HandCard12b";

                } else if (card.name == "instantiated1Card12c(Clone)") {

                    card.name = "instantiated1HandCard12c";

                } else if (card.name == "instantiated1Card13(Clone)") {

                    card.name = "instantiated1HandCard13";

                } else if (card.name == "instantiated1Card13a(Clone)") {

                    card.name = "instantiated1HandCard13a";

                } else if (card.name == "instantiated1Card13b(Clone)") {

                    card.name = "instantiated1HandCard13b";

                } else if (card.name == "instantiated1Card13c(Clone)") {

                    card.name = "instantiated1HandCard13c";

                } else if (card.name == "instantiated1Card14(Clone)") {

                    card.name = "instantiated1HandCard14";

                } else if (card.name == "instantiated1Card14a(Clone)") {

                    card.name = "instantiated1HandCard14a";

                } else if (card.name == "instantiated1Card14b(Clone)") {

                    card.name = "instantiated1HandCard14b";

                } else if (card.name == "instantiated1Card14c(Clone)") {

                    card.name = "instantiated1HandCard14c";

                } else if (card.name == "instantiated1Card15(Clone)") {

                    card.name = "instantiated1HandCard15";

                } else if (card.name == "instantiated1Card15a(Clone)") {

                    card.name = "instantiated1HandCard15a";

                } else if (card.name == "instantiated1Card15b(Clone)") {

                    card.name = "instantiated1HandCard15b";

                } else if (card.name == "instantiated1Card15c(Clone)") {

                    card.name = "instantiated1HandCard15c";

                } else if (card.name == "instantiated1Card16(Clone)") {

                    card.name = "instantiated1HandCard16";

                } else if (card.name == "instantiated1Card16a(Clone)") {

                    card.name = "instantiated1HandCard16a";

                } else if (card.name == "instantiated1Card16b(Clone)") {

                    card.name = "instantiated1HandCard16b";

                } else if (card.name == "instantiated1Card16c(Clone)") {

                    card.name = "instantiated1HandCard16c";

                } else if (card.name == "instantiated1Card17(Clone)") {

                    card.name = "instantiated1HandCard17";

                } else if (card.name == "instantiated1Card17a(Clone)") {

                    card.name = "instantiated1HandCard17a";

                } else if (card.name == "instantiated1Card17b(Clone)") {

                    card.name = "instantiated1HandCard17b";

                } else if (card.name == "instantiated1Card17c(Clone)") {

                    card.name = "instantiated1HandCard17c";

                } else if (card.name == "instantiated1Card18(Clone)") {

                    card.name = "instantiated1HandCard18";

                } else if (card.name == "instantiated1Card18a(Clone)") {

                    card.name = "instantiated1HandCard18a";

                } else if (card.name == "instantiated1Card18b(Clone)") {

                    card.name = "instantiated1HandCard18b";

                } else if (card.name == "instantiated1Card18c(Clone)") {

                    card.name = "instantiated1HandCard18c";

                } else if (card.name == "instantiated1Card19(Clone)") {

                    card.name = "instantiated1HandCard19";

                } else if (card.name == "instantiated1Card19a(Clone)") {

                    card.name = "instantiated1HandCard19a";

                } else if (card.name == "instantiated1Card19b(Clone)") {

                    card.name = "instantiated1HandCard19b";

                } else if (card.name == "instantiated1Card19c(Clone)") {

                    card.name = "instantiated1HandCard19c";

                } else if (card.name == "instantiated1Card20(Clone)") {

                    card.name = "instantiated1HandCard20";

                } else if (card.name == "instantiated1Card20a(Clone)") {

                    card.name = "instantiated1HandCard20a";

                } else if (card.name == "instantiated1Card20b(Clone)") {

                    card.name = "instantiated1HandCard20b";

                } else if (card.name == "instantiated1Card20c(Clone)") {

                    card.name = "instantiated1HandCard20c";

                } else if (card.name == "instantiated1Card21(Clone)") {

                    card.name = "instantiated1HandCard21";

                } else if (card.name == "instantiated1Card21a(Clone)") {

                    card.name = "instantiated1HandCard21a";

                } else if (card.name == "instantiated1Card21b(Clone)") {

                    card.name = "instantiated1HandCard21b";

                } else if (card.name == "instantiated1Card21c(Clone)") {

                    card.name = "instantiated1HandCard21c";

                } else if (card.name == "instantiated1Card22(Clone)") {

                    card.name = "instantiated1HandCard22";

                } else if (card.name == "instantiated1Card22a(Clone)") {

                    card.name = "instantiated1HandCard22a";

                } else if (card.name == "instantiated1Card22b(Clone)") {

                    card.name = "instantiated1HandCard22b";

                } else if (card.name == "instantiated1Card22c(Clone)") {

                    card.name = "instantiated1HandCard22c";

                } else if (card.name == "instantiated1Card23(Clone)") {

                    card.name = "instantiated1HandCard23";

                } else if (card.name == "instantiated1Card23a(Clone)") {

                    card.name = "instantiated1HandCard23a";

                } else if (card.name == "instantiated1Card23b(Clone)") {

                    card.name = "instantiated1HandCard23b";

                } else if (card.name == "instantiated1Card23c(Clone)") {

                    card.name = "instantiated1HandCard23c";

                } else if (card.name == "instantiated1Card24(Clone)") {

                    card.name = "instantiated1HandCard24";

                } else if (card.name == "instantiated1Card24a(Clone)") {

                    card.name = "instantiated1HandCard24a";

                } else if (card.name == "instantiated1Card24b(Clone)") {

                    card.name = "instantiated1HandCard24b";

                } else if (card.name == "instantiated1Card24c(Clone)") {

                    card.name = "instantiated1HandCard24c";

                } else if (card.name == "instantiated1Card25(Clone)") {

                    card.name = "instantiated1HandCard25";

                } else if (card.name == "instantiated1Card25a(Clone)") {

                    card.name = "instantiated1HandCard25a";

                } else if (card.name == "instantiated1Card25b(Clone)") {

                    card.name = "instantiated1HandCard25b";

                } else if (card.name == "instantiated1Card25c(Clone)") {

                    card.name = "instantiated1HandCard25c";

                } else if (card.name == "instantiated1Card26(Clone)") {

                    card.name = "instantiated1HandCard26";

                } else if (card.name == "instantiated1Card26a(Clone)") {

                    card.name = "instantiated1HandCard26a";

                } else if (card.name == "instantiated1Card26b(Clone)") {

                    card.name = "instantiated1HandCard26b";

                } else if (card.name == "instantiated1Card26c(Clone)") {

                    card.name = "instantiated1HandCard26c";

                } else if (card.name == "instantiated1Card27(Clone)") {

                    card.name = "instantiated1HandCard27";

                } else if (card.name == "instantiated1Card27a(Clone)") {

                    card.name = "instantiated1HandCard27a";

                } else if (card.name == "instantiated1Card27b(Clone)") {

                    card.name = "instantiated1HandCard27b";

                } else if (card.name == "instantiated1Card27c(Clone)") {

                    card.name = "instantiated1HandCard27c";

                } else if (card.name == "instantiated1Card28(Clone)") {

                    card.name = "instantiated1HandCard28";

                } else if (card.name == "instantiated1Card28a(Clone)") {

                    card.name = "instantiated1HandCard28a";

                } else if (card.name == "instantiated1Card28b(Clone)") {

                    card.name = "instantiated1HandCard28b";

                } else if (card.name == "instantiated1Card28c(Clone)") {

                    card.name = "instantiated1HandCard28c";

                } else if (card.name == "instantiated1Card29(Clone)") {

                    card.name = "instantiated1HandCard29";

                } else if (card.name == "instantiated1Card29a(Clone)") {

                    card.name = "instantiated1HandCard29a";

                } else if (card.name == "instantiated1Card29b(Clone)") {

                    card.name = "instantiated1HandCard29b";

                } else if (card.name == "instantiated1Card29c(Clone)") {

                    card.name = "instantiated1HandCard29c";

                } else if (card.name == "instantiated1Card30(Clone)") {

                    card.name = "instantiated1HandCard30";

                } else if (card.name == "instantiated1Card30a(Clone)") {

                    card.name = "instantiated1HandCard30a";

                } else if (card.name == "instantiated1Card30b(Clone)") {

                    card.name = "instantiated1HandCard30b";

                } else if (card.name == "instantiated1Card30c(Clone)") {

                    card.name = "instantiated1HandCard30c";

                } else if (card.name == "instantiated1Card31(Clone)") {

                    card.name = "instantiated1HandCard31";

                } else if (card.name == "instantiated1Card31a(Clone)") {

                    card.name = "instantiated1HandCard31a";

                } else if (card.name == "instantiated1Card31b(Clone)") {

                    card.name = "instantiated1HandCard31b";

                } else if (card.name == "instantiated1Card31c(Clone)") {

                    card.name = "instantiated1HandCard31c";

                } else if (card.name == "instantiated1Card32(Clone)") {

                    card.name = "instantiated1HandCard32";

                } else if (card.name == "instantiated1Card32a(Clone)") {

                    card.name = "instantiated1HandCard32a";

                } else if (card.name == "instantiated1Card32b(Clone)") {

                    card.name = "instantiated1HandCard32b";

                } else if (card.name == "instantiated1Card32c(Clone)") {

                    card.name = "instantiated1HandCard32c";

                } else if (card.name == "instantiated1Card33(Clone)") {

                    card.name = "instantiated1HandCard33";

                } else if (card.name == "instantiated1Card33a(Clone)") {

                    card.name = "instantiated1HandCard33a";

                } else if (card.name == "instantiated1Card33b(Clone)") {

                    card.name = "instantiated1HandCard33b";

                } else if (card.name == "instantiated1Card33c(Clone)") {

                    card.name = "instantiated1HandCard33c";

                } else if (card.name == "instantiated1Card34(Clone)") {

                    card.name = "instantiated1HandCard34";

                } else if (card.name == "instantiated1Card34a(Clone)") {

                    card.name = "instantiated1HandCard34a";

                } else if (card.name == "instantiated1Card34b(Clone)") {

                    card.name = "instantiated1HandCard34b";

                } else if (card.name == "instantiated1Card34c(Clone)") {

                    card.name = "instantiated1HandCard34c";

                } else if (card.name == "instantiated1Card35(Clone)") {

                    card.name = "instantiated1HandCard35";

                } else if (card.name == "instantiated1Card35a(Clone)") {

                    card.name = "instantiated1HandCard35a";

                } else if (card.name == "instantiated1Card35b(Clone)") {

                    card.name = "instantiated1HandCard35b";

                } else if (card.name == "instantiated1Card35c(Clone)") {

                    card.name = "instantiated1HandCard35c";

                } else if (card.name == "instantiated1Card36(Clone)") {

                    card.name = "instantiated1HandCard36";

                } else if (card.name == "instantiated1Card36a(Clone)") {

                    card.name = "instantiated1HandCard36a";

                } else if (card.name == "instantiated1Card36b(Clone)") {

                    card.name = "instantiated1HandCard36b";

                } else if (card.name == "instantiated1Card36c(Clone)") {

                    card.name = "instantiated1HandCard36c";

                } else if (card.name == "instantiated1Card37(Clone)") {

                    card.name = "instantiated1HandCard37";

                } else if (card.name == "instantiated1Card37a(Clone)") {

                    card.name = "instantiated1HandCard37a";

                } else if (card.name == "instantiated1Card37b(Clone)") {

                    card.name = "instantiated1HandCard37b";

                } else if (card.name == "instantiated1Card37c(Clone)") {

                    card.name = "instantiated1HandCard37c";

                } else if (card.name == "instantiated1Card38(Clone)") {

                    card.name = "instantiated1HandCard38";

                } else if (card.name == "instantiated1Card38a(Clone)") {

                    card.name = "instantiated1HandCard38a";

                } else if (card.name == "instantiated1Card38b(Clone)") {

                    card.name = "instantiated1HandCard38b";

                } else if (card.name == "instantiated1Card38c(Clone)") {

                    card.name = "instantiated1HandCard38c";

                } else if (card.name == "instantiated1Card39(Clone)") {

                    card.name = "instantiated1HandCard39";

                } else if (card.name == "instantiated1Card39a(Clone)") {

                    card.name = "instantiated1HandCard39a";

                } else if (card.name == "instantiated1Card39b(Clone)") {

                    card.name = "instantiated1HandCard39b";

                } else if (card.name == "instantiated1Card39c(Clone)") {

                    card.name = "instantiated1HandCard39c";

                } else if (card.name == "instantiated1Card40(Clone)") {

                    card.name = "instantiated1HandCard40";

                } else if (card.name == "instantiated1Card40a(Clone)") {

                    card.name = "instantiated1HandCard40a";

                } else if (card.name == "instantiated1Card40b(Clone)") {

                    card.name = "instantiated1HandCard40b";

                } else if (card.name == "instantiated1Card40c(Clone)") {

                    card.name = "instantiated1HandCard40c";

                } else if (card.name == "instantiated1Card41(Clone)") {

                    card.name = "instantiated1HandCard41";

                } else if (card.name == "instantiated1Card41a(Clone)") {

                    card.name = "instantiated1HandCard41a";

                } else if (card.name == "instantiated1Card41b(Clone)") {

                    card.name = "instantiated1HandCard41b";

                } else if (card.name == "instantiated1Card41c(Clone)") {

                    card.name = "instantiated1HandCard41c";

                } else if (card.name == "instantiated1Card42(Clone)") {

                    card.name = "instantiated1HandCard42";

                } else if (card.name == "instantiated1Card42a(Clone)") {

                    card.name = "instantiated1HandCard42a";

                } else if (card.name == "instantiated1Card42b(Clone)") {

                    card.name = "instantiated1HandCard42b";

                } else if (card.name == "instantiated1Card42c(Clone)") {

                    card.name = "instantiated1HandCard42c";

                } else if (card.name == "instantiated1Card43(Clone)") {

                    card.name = "instantiated1HandCard43";

                } else if (card.name == "instantiated1Card43a(Clone)") {

                    card.name = "instantiated1HandCard43a";

                } else if (card.name == "instantiated1Card43b(Clone)") {

                    card.name = "instantiated1HandCard43b";

                } else if (card.name == "instantiated1Card43c(Clone)") {

                    card.name = "instantiated1HandCard43c";

                } else if (card.name == "instantiated1Card44(Clone)") {

                    card.name = "instantiated1HandCard44";

                } else if (card.name == "instantiated1Card44a(Clone)") {

                    card.name = "instantiated1HandCard44a";

                } else if (card.name == "instantiated1Card44b(Clone)") {

                    card.name = "instantiated1HandCard44b";

                } else if (card.name == "instantiated1Card44c(Clone)") {

                    card.name = "instantiated1HandCard44c";

                } else if (card.name == "instantiated1Card45(Clone)") {

                    card.name = "instantiated1HandCard45";

                } else if (card.name == "instantiated1Card45a(Clone)") {

                    card.name = "instantiated1HandCard45a";

                } else if (card.name == "instantiated1Card45b(Clone)") {

                    card.name = "instantiated1HandCard45b";

                } else if (card.name == "instantiated1Card45c(Clone)") {

                    card.name = "instantiated1HandCard45c";

                } else if (card.name == "instantiated1Card46(Clone)") {

                    card.name = "instantiated1HandCard46";

                } else if (card.name == "instantiated1Card46a(Clone)") {

                    card.name = "instantiated1HandCard46a";

                } else if (card.name == "instantiated1Card46b(Clone)") {

                    card.name = "instantiated1HandCard46b";

                } else if (card.name == "instantiated1Card46c(Clone)") {

                    card.name = "instantiated1HandCard46c";

                } else if (card.name == "instantiated1Card47(Clone)") {

                    card.name = "instantiated1HandCard47";

                } else if (card.name == "instantiated1Card47a(Clone)") {

                    card.name = "instantiated1HandCard47a";

                } else if (card.name == "instantiated1Card47b(Clone)") {

                    card.name = "instantiated1HandCard47b";

                } else if (card.name == "instantiated1Card47c(Clone)") {

                    card.name = "instantiated1HandCard47c";

                } else if (card.name == "instantiated1Card48(Clone)") {

                    card.name = "instantiated1HandCard48";

                } else if (card.name == "instantiated1Card48a(Clone)") {

                    card.name = "instantiated1HandCard48a";

                } else if (card.name == "instantiated1Card48b(Clone)") {

                    card.name = "instantiated1HandCard48b";

                } else if (card.name == "instantiated1Card48c(Clone)") {

                    card.name = "instantiated1HandCard48c";

                } else if (card.name == "instantiated1Card49(Clone)") {

                    card.name = "instantiated1HandCard49";

                } else if (card.name == "instantiated1Card49a(Clone)") {

                    card.name = "instantiated1HandCard49a";

                } else if (card.name == "instantiated1Card49b(Clone)") {

                    card.name = "instantiated1HandCard49b";

                } else if (card.name == "instantiated1Card49c(Clone)") {

                    card.name = "instantiated1HandCard49c";

                } else if (card.name == "instantiated1Card50(Clone)") {

                    card.name = "instantiated1HandCard50";

                } else if (card.name == "instantiated1Card50a(Clone)") {

                    card.name = "instantiated1HandCard50a";

                } else if (card.name == "instantiated1Card50b(Clone)") {

                    card.name = "instantiated1HandCard50b";

                } else if (card.name == "instantiated1Card50c(Clone)") {

                    card.name = "instantiated1HandCard50c";

                } else if (card.name == "instantiated1Card51(Clone)") {

                    card.name = "instantiated1HandCard51";

                } else if (card.name == "instantiated1Card51a(Clone)") {

                    card.name = "instantiated1HandCard51a";

                } else if (card.name == "instantiated1Card51b(Clone)") {

                    card.name = "instantiated1HandCard51b";

                } else if (card.name == "instantiated1Card51c(Clone)") {

                    card.name = "instantiated1HandCard51c";

                } else if (card.name == "instantiated1Card52(Clone)") {

                    card.name = "instantiated1HandCard52";

                } else if (card.name == "instantiated1Card52a(Clone)") {

                    card.name = "instantiated1HandCard52a";

                } else if (card.name == "instantiated1Card52b(Clone)") {

                    card.name = "instantiated1HandCard52b";

                } else if (card.name == "instantiated1Card52c(Clone)") {

                    card.name = "instantiated1HandCard52c";

                } else if (card.name == "instantiated1Card53(Clone)") {

                    card.name = "instantiated1HandCard53";

                } else if (card.name == "instantiated1Card53a(Clone)") {

                    card.name = "instantiated1HandCard53a";

                } else if (card.name == "instantiated1Card53b(Clone)") {

                    card.name = "instantiated1HandCard53b";

                } else if (card.name == "instantiated1Card53c(Clone)") {

                    card.name = "instantiated1HandCard53c";

                } else if (card.name == "instantiated1Card54(Clone)") {

                    card.name = "instantiated1HandCard54";

                } else if (card.name == "instantiated1Card54a(Clone)") {

                    card.name = "instantiated1HandCard54a";

                } else if (card.name == "instantiated1Card54b(Clone)") {

                    card.name = "instantiated1HandCard54b";

                } else if (card.name == "instantiated1Card54c(Clone)") {

                    card.name = "instantiated1HandCard54c";

                } else if (card.name == "instantiated1Card55(Clone)") {

                    card.name = "instantiated1HandCard55";

                } else if (card.name == "instantiated1Card55a(Clone)") {

                    card.name = "instantiated1HandCard55a";

                } else if (card.name == "instantiated1Card55b(Clone)") {

                    card.name = "instantiated1HandCard55b";

                } else if (card.name == "instantiated1Card55c(Clone)") {

                    card.name = "instantiated1HandCard55c";

                } else if (card.name == "instantiated1Card56(Clone)") {

                    card.name = "instantiated1HandCard56";

                } else if (card.name == "instantiated1Card56a(Clone)") {

                    card.name = "instantiated1HandCard56a";

                } else if (card.name == "instantiated1Card56b(Clone)") {

                    card.name = "instantiated1HandCard56b";

                } else if (card.name == "instantiated1Card56c(Clone)") {

                    card.name = "instantiated1HandCard56c";

                } else if (card.name == "instantiated1Card57(Clone)") {

                    card.name = "instantiated1HandCard57";

                } else if (card.name == "instantiated1Card57a(Clone)") {

                    card.name = "instantiated1HandCard57a";

                } else if (card.name == "instantiated1Card57b(Clone)") {

                    card.name = "instantiated1HandCard57b";

                } else if (card.name == "instantiated1Card57c(Clone)") {

                    card.name = "instantiated1HandCard57c";

                } else if (card.name == "instantiated1Card58(Clone)") {

                    card.name = "instantiated1HandCard58";

                } else if (card.name == "instantiated1Card58a(Clone)") {

                    card.name = "instantiated1HandCard58a";

                } else if (card.name == "instantiated1Card58b(Clone)") {

                    card.name = "instantiated1HandCard58b";

                } else if (card.name == "instantiated1Card58c(Clone)") {

                    card.name = "instantiated1HandCard58c";

                } else if (card.name == "instantiated1Card59(Clone)") {

                    card.name = "instantiated1HandCard59";

                } else if (card.name == "instantiated1Card59a(Clone)") {

                    card.name = "instantiated1HandCard59a";

                } else if (card.name == "instantiated1Card59b(Clone)") {

                    card.name = "instantiated1HandCard59b";

                } else if (card.name == "instantiated1Card59c(Clone)") {

                    card.name = "instantiated1HandCard59c";

                } else if (card.name == "instantiated1Card60(Clone)") {

                    card.name = "instantiated1HandCard60";

                } else if (card.name == "instantiated1Card60a(Clone)") {

                    card.name = "instantiated1HandCard60a";

                } else if (card.name == "instantiated1Card60b(Clone)") {

                    card.name = "instantiated1HandCard60b";

                } else if (card.name == "instantiated1Card60c(Clone)") {

                    card.name = "instantiated1HandCard60c";
                }

                instances4++;

            }

            while (instances5 < NumberOfCards) {

                GameObject card = Instantiate(playCardsDeck1[UnityEngine.Random.Range(0, playCardsDeck1.Count)], player1DeckSlot5.transform.position, player1DeckSlot5.transform.rotation) as GameObject;
                card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                card.transform.parent = player1DeckSlot5.transform;

                if (card.name == "instantiated1Card1(Clone)") {

                    card.name = "instantiated1HandCard1";

                } else if (card.name == "instantiated1Card1a(Clone)") {

                    card.name = "instantiated1HandCard1a";

                } else if (card.name == "instantiated1Card1b(Clone)") {

                    card.name = "instantiated1HandCard1b";

                } else if (card.name == "instantiated1Card1c(Clone)") {

                    card.name = "instantiated1HandCard1c";

                } else if (card.name == "instantiated1Card2(Clone)") {

                    card.name = "instantiated1HandCard2";

                } else if (card.name == "instantiated1Card2a(Clone)") {

                    card.name = "instantiated1HandCard2a";

                } else if (card.name == "instantiated1Card2b(Clone)") {

                    card.name = "instantiated1HandCard2b";

                } else if (card.name == "instantiated1Card2c(Clone)") {

                    card.name = "instantiated1HandCard2c";

                } else if (card.name == "instantiated1Card3(Clone)") {

                    card.name = "instantiated1HandCard3";

                } else if (card.name == "instantiated1Card3a(Clone)") {

                    card.name = "instantiated1HandCard3a";

                } else if (card.name == "instantiated1Card3b(Clone)") {

                    card.name = "instantiated1HandCard3b";

                } else if (card.name == "instantiated1Card3c(Clone)") {

                    card.name = "instantiated1HandCard3c";

                } else if (card.name == "instantiated1Card4(Clone)") {

                    card.name = "instantiated1HandCard4";

                } else if (card.name == "instantiated1Card4a(Clone)") {

                    card.name = "instantiated1HandCard4a";

                } else if (card.name == "instantiated1Card4b(Clone)") {

                    card.name = "instantiated1HandCard4b";

                } else if (card.name == "instantiated1Card4c(Clone)") {

                    card.name = "instantiated1HandCard4c";

                } else if (card.name == "instantiated1Card5(Clone)") {

                    card.name = "instantiated1HandCard5";

                } else if (card.name == "instantiated1Card5a(Clone)") {

                    card.name = "instantiated1HandCard5a";

                } else if (card.name == "instantiated1Card5b(Clone)") {

                    card.name = "instantiated1HandCard5b";

                } else if (card.name == "instantiated1Card5c(Clone)") {

                    card.name = "instantiated1HandCard5c";

                } else if (card.name == "instantiated1Card6(Clone)") {

                    card.name = "instantiated1HandCard6";

                } else if (card.name == "instantiated1Card6a(Clone)") {

                    card.name = "instantiated1HandCard6a";

                } else if (card.name == "instantiated1Card6b(Clone)") {

                    card.name = "instantiated1HandCard6b";

                } else if (card.name == "instantiated1Card6c(Clone)") {

                    card.name = "instantiated1HandCard6c";

                } else if (card.name == "instantiated1Card7(Clone)") {

                    card.name = "instantiated1HandCard7";

                } else if (card.name == "instantiated1Card7a(Clone)") {

                    card.name = "instantiated1HandCard7a";

                } else if (card.name == "instantiated1Card7b(Clone)") {

                    card.name = "instantiated1HandCard7b";

                } else if (card.name == "instantiated1Card7c(Clone)") {

                    card.name = "instantiated1HandCard7c";

                } else if (card.name == "instantiated1Card8(Clone)") {

                    card.name = "instantiated1HandCard8";

                } else if (card.name == "instantiated1Card8a(Clone)") {

                    card.name = "instantiated1HandCard8a";

                } else if (card.name == "instantiated1Card8b(Clone)") {

                    card.name = "instantiated1HandCard8b";

                } else if (card.name == "instantiated1Card8c(Clone)") {

                    card.name = "instantiated1HandCard8c";

                } else if (card.name == "instantiated1Card9(Clone)") {

                    card.name = "instantiated1HandCard9";

                } else if (card.name == "instantiated1Card9a(Clone)") {

                    card.name = "instantiated1HandCard9a";

                } else if (card.name == "instantiated1Card9b(Clone)") {

                    card.name = "instantiated1HandCard9b";

                } else if (card.name == "instantiated1Card9c(Clone)") {

                    card.name = "instantiated1HandCard9c";

                } else if (card.name == "instantiated1Card10(Clone)") {

                    card.name = "instantiatedAICard10";

                } else if (card.name == "instantiated1Card10a(Clone)") {

                    card.name = "instantiated1HandCard10a";

                } else if (card.name == "instantiated1Card10b(Clone)") {

                    card.name = "instantiated1HandCard10b";

                } else if (card.name == "instantiated1Card10c(Clone)") {

                    card.name = "instantiated1HandCard10c";

                } else if (card.name == "instantiated1Card11(Clone)") {

                    card.name = "instantiated1HandCard11";

                } else if (card.name == "instantiated1Card11a(Clone)") {

                    card.name = "instantiated1HandCard11a";

                } else if (card.name == "instantiated1Card11b(Clone)") {

                    card.name = "instantiated1HandCard11b";

                } else if (card.name == "instantiated1Card11c(Clone)") {

                    card.name = "instantiated1HandCard11c";

                } else if (card.name == "instantiated1Card12(Clone)") {

                    card.name = "instantiated1HandCard12";

                } else if (card.name == "instantiated1Card12a(Clone)") {

                    card.name = "instantiated1HandCard12a";

                } else if (card.name == "instantiated1Card12b(Clone)") {

                    card.name = "instantiated1HandCard12b";

                } else if (card.name == "instantiated1Card12c(Clone)") {

                    card.name = "instantiated1HandCard12c";

                } else if (card.name == "instantiated1Card13(Clone)") {

                    card.name = "instantiated1HandCard13";

                } else if (card.name == "instantiated1Card13a(Clone)") {

                    card.name = "instantiated1HandCard13a";

                } else if (card.name == "instantiated1Card13b(Clone)") {

                    card.name = "instantiated1HandCard13b";

                } else if (card.name == "instantiated1Card13c(Clone)") {

                    card.name = "instantiated1HandCard13c";

                } else if (card.name == "instantiated1Card14(Clone)") {

                    card.name = "instantiated1HandCard14";

                } else if (card.name == "instantiated1Card14a(Clone)") {

                    card.name = "instantiated1HandCard14a";

                } else if (card.name == "instantiated1Card14b(Clone)") {

                    card.name = "instantiated1HandCard14b";

                } else if (card.name == "instantiated1Card14c(Clone)") {

                    card.name = "instantiated1HandCard14c";

                } else if (card.name == "instantiated1Card15(Clone)") {

                    card.name = "instantiated1HandCard15";

                } else if (card.name == "instantiated1Card15a(Clone)") {

                    card.name = "instantiated1HandCard15a";

                } else if (card.name == "instantiated1Card15b(Clone)") {

                    card.name = "instantiated1HandCard15b";

                } else if (card.name == "instantiated1Card15c(Clone)") {

                    card.name = "instantiated1HandCard15c";

                } else if (card.name == "instantiated1Card16(Clone)") {

                    card.name = "instantiated1HandCard16";

                } else if (card.name == "instantiated1Card16a(Clone)") {

                    card.name = "instantiated1HandCard16a";

                } else if (card.name == "instantiated1Card16b(Clone)") {

                    card.name = "instantiated1HandCard16b";

                } else if (card.name == "instantiated1Card16c(Clone)") {

                    card.name = "instantiated1HandCard16c";

                } else if (card.name == "instantiated1Card17(Clone)") {

                    card.name = "instantiated1HandCard17";

                } else if (card.name == "instantiated1Card17a(Clone)") {

                    card.name = "instantiated1HandCard17a";

                } else if (card.name == "instantiated1Card17b(Clone)") {

                    card.name = "instantiated1HandCard17b";

                } else if (card.name == "instantiated1Card17c(Clone)") {

                    card.name = "instantiated1HandCard17c";

                } else if (card.name == "instantiated1Card18(Clone)") {

                    card.name = "instantiated1HandCard18";

                } else if (card.name == "instantiated1Card18a(Clone)") {

                    card.name = "instantiated1HandCard18a";

                } else if (card.name == "instantiated1Card18b(Clone)") {

                    card.name = "instantiated1HandCard18b";

                } else if (card.name == "instantiated1Card18c(Clone)") {

                    card.name = "instantiated1HandCard18c";

                } else if (card.name == "instantiated1Card19(Clone)") {

                    card.name = "instantiated1HandCard19";

                } else if (card.name == "instantiated1Card19a(Clone)") {

                    card.name = "instantiated1HandCard19a";

                } else if (card.name == "instantiated1Card19b(Clone)") {

                    card.name = "instantiated1HandCard19b";

                } else if (card.name == "instantiated1Card19c(Clone)") {

                    card.name = "instantiated1HandCard19c";

                } else if (card.name == "instantiated1Card20(Clone)") {

                    card.name = "instantiated1HandCard20";

                } else if (card.name == "instantiated1Card20a(Clone)") {

                    card.name = "instantiated1HandCard20a";

                } else if (card.name == "instantiated1Card20b(Clone)") {

                    card.name = "instantiated1HandCard20b";

                } else if (card.name == "instantiated1Card20c(Clone)") {

                    card.name = "instantiated1HandCard20c";

                } else if (card.name == "instantiated1Card21(Clone)") {

                    card.name = "instantiated1HandCard21";

                } else if (card.name == "instantiated1Card21a(Clone)") {

                    card.name = "instantiated1HandCard21a";

                } else if (card.name == "instantiated1Card21b(Clone)") {

                    card.name = "instantiated1HandCard21b";

                } else if (card.name == "instantiated1Card21c(Clone)") {

                    card.name = "instantiated1HandCard21c";

                } else if (card.name == "instantiated1Card22(Clone)") {

                    card.name = "instantiated1HandCard22";

                } else if (card.name == "instantiated1Card22a(Clone)") {

                    card.name = "instantiated1HandCard22a";

                } else if (card.name == "instantiated1Card22b(Clone)") {

                    card.name = "instantiated1HandCard22b";

                } else if (card.name == "instantiated1Card22c(Clone)") {

                    card.name = "instantiated1HandCard22c";

                } else if (card.name == "instantiated1Card23(Clone)") {

                    card.name = "instantiated1HandCard23";

                } else if (card.name == "instantiated1Card23a(Clone)") {

                    card.name = "instantiated1HandCard23a";

                } else if (card.name == "instantiated1Card23b(Clone)") {

                    card.name = "instantiated1HandCard23b";

                } else if (card.name == "instantiated1Card23c(Clone)") {

                    card.name = "instantiated1HandCard23c";

                } else if (card.name == "instantiated1Card24(Clone)") {

                    card.name = "instantiated1HandCard24";

                } else if (card.name == "instantiated1Card24a(Clone)") {

                    card.name = "instantiated1HandCard24a";

                } else if (card.name == "instantiated1Card24b(Clone)") {

                    card.name = "instantiated1HandCard24b";

                } else if (card.name == "instantiated1Card24c(Clone)") {

                    card.name = "instantiated1HandCard24c";

                } else if (card.name == "instantiated1Card25(Clone)") {

                    card.name = "instantiated1HandCard25";

                } else if (card.name == "instantiated1Card25a(Clone)") {

                    card.name = "instantiated1HandCard25a";

                } else if (card.name == "instantiated1Card25b(Clone)") {

                    card.name = "instantiated1HandCard25b";

                } else if (card.name == "instantiated1Card25c(Clone)") {

                    card.name = "instantiated1HandCard25c";

                } else if (card.name == "instantiated1Card26(Clone)") {

                    card.name = "instantiated1HandCard26";

                } else if (card.name == "instantiated1Card26a(Clone)") {

                    card.name = "instantiated1HandCard26a";

                } else if (card.name == "instantiated1Card26b(Clone)") {

                    card.name = "instantiated1HandCard26b";

                } else if (card.name == "instantiated1Card26c(Clone)") {

                    card.name = "instantiated1HandCard26c";

                } else if (card.name == "instantiated1Card27(Clone)") {

                    card.name = "instantiated1HandCard27";

                } else if (card.name == "instantiated1Card27a(Clone)") {

                    card.name = "instantiated1HandCard27a";

                } else if (card.name == "instantiated1Card27b(Clone)") {

                    card.name = "instantiated1HandCard27b";

                } else if (card.name == "instantiated1Card27c(Clone)") {

                    card.name = "instantiated1HandCard27c";

                } else if (card.name == "instantiated1Card28(Clone)") {

                    card.name = "instantiated1HandCard28";

                } else if (card.name == "instantiated1Card28a(Clone)") {

                    card.name = "instantiated1HandCard28a";

                } else if (card.name == "instantiated1Card28b(Clone)") {

                    card.name = "instantiated1HandCard28b";

                } else if (card.name == "instantiated1Card28c(Clone)") {

                    card.name = "instantiated1HandCard28c";

                } else if (card.name == "instantiated1Card29(Clone)") {

                    card.name = "instantiated1HandCard29";

                } else if (card.name == "instantiated1Card29a(Clone)") {

                    card.name = "instantiated1HandCard29a";

                } else if (card.name == "instantiated1Card29b(Clone)") {

                    card.name = "instantiated1HandCard29b";

                } else if (card.name == "instantiated1Card29c(Clone)") {

                    card.name = "instantiated1HandCard29c";

                } else if (card.name == "instantiated1Card30(Clone)") {

                    card.name = "instantiated1HandCard30";

                } else if (card.name == "instantiated1Card30a(Clone)") {

                    card.name = "instantiated1HandCard30a";

                } else if (card.name == "instantiated1Card30b(Clone)") {

                    card.name = "instantiated1HandCard30b";

                } else if (card.name == "instantiated1Card30c(Clone)") {

                    card.name = "instantiated1HandCard30c";

                } else if (card.name == "instantiated1Card31(Clone)") {

                    card.name = "instantiated1HandCard31";

                } else if (card.name == "instantiated1Card31a(Clone)") {

                    card.name = "instantiated1HandCard31a";

                } else if (card.name == "instantiated1Card31b(Clone)") {

                    card.name = "instantiated1HandCard31b";

                } else if (card.name == "instantiated1Card31c(Clone)") {

                    card.name = "instantiated1HandCard31c";

                } else if (card.name == "instantiated1Card32(Clone)") {

                    card.name = "instantiated1HandCard32";

                } else if (card.name == "instantiated1Card32a(Clone)") {

                    card.name = "instantiated1HandCard32a";

                } else if (card.name == "instantiated1Card32b(Clone)") {

                    card.name = "instantiated1HandCard32b";

                } else if (card.name == "instantiated1Card32c(Clone)") {

                    card.name = "instantiated1HandCard32c";

                } else if (card.name == "instantiated1Card33(Clone)") {

                    card.name = "instantiated1HandCard33";

                } else if (card.name == "instantiated1Card33a(Clone)") {

                    card.name = "instantiated1HandCard33a";

                } else if (card.name == "instantiated1Card33b(Clone)") {

                    card.name = "instantiated1HandCard33b";

                } else if (card.name == "instantiated1Card33c(Clone)") {

                    card.name = "instantiated1HandCard33c";

                } else if (card.name == "instantiated1Card34(Clone)") {

                    card.name = "instantiated1HandCard34";

                } else if (card.name == "instantiated1Card34a(Clone)") {

                    card.name = "instantiated1HandCard34a";

                } else if (card.name == "instantiated1Card34b(Clone)") {

                    card.name = "instantiated1HandCard34b";

                } else if (card.name == "instantiated1Card34c(Clone)") {

                    card.name = "instantiated1HandCard34c";

                } else if (card.name == "instantiated1Card35(Clone)") {

                    card.name = "instantiated1HandCard35";

                } else if (card.name == "instantiated1Card35a(Clone)") {

                    card.name = "instantiated1HandCard35a";

                } else if (card.name == "instantiated1Card35b(Clone)") {

                    card.name = "instantiated1HandCard35b";

                } else if (card.name == "instantiated1Card35c(Clone)") {

                    card.name = "instantiated1HandCard35c";

                } else if (card.name == "instantiated1Card36(Clone)") {

                    card.name = "instantiated1HandCard36";

                } else if (card.name == "instantiated1Card36a(Clone)") {

                    card.name = "instantiated1HandCard36a";

                } else if (card.name == "instantiated1Card36b(Clone)") {

                    card.name = "instantiated1HandCard36b";

                } else if (card.name == "instantiated1Card36c(Clone)") {

                    card.name = "instantiated1HandCard36c";

                } else if (card.name == "instantiated1Card37(Clone)") {

                    card.name = "instantiated1HandCard37";

                } else if (card.name == "instantiated1Card37a(Clone)") {

                    card.name = "instantiated1HandCard37a";

                } else if (card.name == "instantiated1Card37b(Clone)") {

                    card.name = "instantiated1HandCard37b";

                } else if (card.name == "instantiated1Card37c(Clone)") {

                    card.name = "instantiated1HandCard37c";

                } else if (card.name == "instantiated1Card38(Clone)") {

                    card.name = "instantiated1HandCard38";

                } else if (card.name == "instantiated1Card38a(Clone)") {

                    card.name = "instantiated1HandCard38a";

                } else if (card.name == "instantiated1Card38b(Clone)") {

                    card.name = "instantiated1HandCard38b";

                } else if (card.name == "instantiated1Card38c(Clone)") {

                    card.name = "instantiated1HandCard38c";

                } else if (card.name == "instantiated1Card39(Clone)") {

                    card.name = "instantiated1HandCard39";

                } else if (card.name == "instantiated1Card39a(Clone)") {

                    card.name = "instantiated1HandCard39a";

                } else if (card.name == "instantiated1Card39b(Clone)") {

                    card.name = "instantiated1HandCard39b";

                } else if (card.name == "instantiated1Card39c(Clone)") {

                    card.name = "instantiated1HandCard39c";

                } else if (card.name == "instantiated1Card40(Clone)") {

                    card.name = "instantiated1HandCard40";

                } else if (card.name == "instantiated1Card40a(Clone)") {

                    card.name = "instantiated1HandCard40a";

                } else if (card.name == "instantiated1Card40b(Clone)") {

                    card.name = "instantiated1HandCard40b";

                } else if (card.name == "instantiated1Card40c(Clone)") {

                    card.name = "instantiated1HandCard40c";

                } else if (card.name == "instantiated1Card41(Clone)") {

                    card.name = "instantiated1HandCard41";

                } else if (card.name == "instantiated1Card41a(Clone)") {

                    card.name = "instantiated1HandCard41a";

                } else if (card.name == "instantiated1Card41b(Clone)") {

                    card.name = "instantiated1HandCard41b";

                } else if (card.name == "instantiated1Card41c(Clone)") {

                    card.name = "instantiated1HandCard41c";

                } else if (card.name == "instantiated1Card42(Clone)") {

                    card.name = "instantiated1HandCard42";

                } else if (card.name == "instantiated1Card42a(Clone)") {

                    card.name = "instantiated1HandCard42a";

                } else if (card.name == "instantiated1Card42b(Clone)") {

                    card.name = "instantiated1HandCard42b";

                } else if (card.name == "instantiated1Card42c(Clone)") {

                    card.name = "instantiated1HandCard42c";

                } else if (card.name == "instantiated1Card43(Clone)") {

                    card.name = "instantiated1HandCard43";

                } else if (card.name == "instantiated1Card43a(Clone)") {

                    card.name = "instantiated1HandCard43a";

                } else if (card.name == "instantiated1Card43b(Clone)") {

                    card.name = "instantiated1HandCard43b";

                } else if (card.name == "instantiated1Card43c(Clone)") {

                    card.name = "instantiated1HandCard43c";

                } else if (card.name == "instantiated1Card44(Clone)") {

                    card.name = "instantiated1HandCard44";

                } else if (card.name == "instantiated1Card44a(Clone)") {

                    card.name = "instantiated1HandCard44a";

                } else if (card.name == "instantiated1Card44b(Clone)") {

                    card.name = "instantiated1HandCard44b";

                } else if (card.name == "instantiated1Card44c(Clone)") {

                    card.name = "instantiated1HandCard44c";

                } else if (card.name == "instantiated1Card45(Clone)") {

                    card.name = "instantiated1HandCard45";

                } else if (card.name == "instantiated1Card45a(Clone)") {

                    card.name = "instantiated1HandCard45a";

                } else if (card.name == "instantiated1Card45b(Clone)") {

                    card.name = "instantiated1HandCard45b";

                } else if (card.name == "instantiated1Card45c(Clone)") {

                    card.name = "instantiated1HandCard45c";

                } else if (card.name == "instantiated1Card46(Clone)") {

                    card.name = "instantiated1HandCard46";

                } else if (card.name == "instantiated1Card46a(Clone)") {

                    card.name = "instantiated1HandCard46a";

                } else if (card.name == "instantiated1Card46b(Clone)") {

                    card.name = "instantiated1HandCard46b";

                } else if (card.name == "instantiated1Card46c(Clone)") {

                    card.name = "instantiated1HandCard46c";

                } else if (card.name == "instantiated1Card47(Clone)") {

                    card.name = "instantiated1HandCard47";

                } else if (card.name == "instantiated1Card47a(Clone)") {

                    card.name = "instantiated1HandCard47a";

                } else if (card.name == "instantiated1Card47b(Clone)") {

                    card.name = "instantiated1HandCard47b";

                } else if (card.name == "instantiated1Card47c(Clone)") {

                    card.name = "instantiated1HandCard47c";

                } else if (card.name == "instantiated1Card48(Clone)") {

                    card.name = "instantiated1HandCard48";

                } else if (card.name == "instantiated1Card48a(Clone)") {

                    card.name = "instantiated1HandCard48a";

                } else if (card.name == "instantiated1Card48b(Clone)") {

                    card.name = "instantiated1HandCard48b";

                } else if (card.name == "instantiated1Card48c(Clone)") {

                    card.name = "instantiated1HandCard48c";

                } else if (card.name == "instantiated1Card49(Clone)") {

                    card.name = "instantiated1HandCard49";

                } else if (card.name == "instantiated1Card49a(Clone)") {

                    card.name = "instantiated1HandCard49a";

                } else if (card.name == "instantiated1Card49b(Clone)") {

                    card.name = "instantiated1HandCard49b";

                } else if (card.name == "instantiated1Card49c(Clone)") {

                    card.name = "instantiated1HandCard49c";

                } else if (card.name == "instantiated1Card50(Clone)") {

                    card.name = "instantiated1HandCard50";

                } else if (card.name == "instantiated1Card50a(Clone)") {

                    card.name = "instantiated1HandCard50a";

                } else if (card.name == "instantiated1Card50b(Clone)") {

                    card.name = "instantiated1HandCard50b";

                } else if (card.name == "instantiated1Card50c(Clone)") {

                    card.name = "instantiated1HandCard50c";

                } else if (card.name == "instantiated1Card51(Clone)") {

                    card.name = "instantiated1HandCard51";

                } else if (card.name == "instantiated1Card51a(Clone)") {

                    card.name = "instantiated1HandCard51a";

                } else if (card.name == "instantiated1Card51b(Clone)") {

                    card.name = "instantiated1HandCard51b";

                } else if (card.name == "instantiated1Card51c(Clone)") {

                    card.name = "instantiated1HandCard51c";

                } else if (card.name == "instantiated1Card52(Clone)") {

                    card.name = "instantiated1HandCard52";

                } else if (card.name == "instantiated1Card52a(Clone)") {

                    card.name = "instantiated1HandCard52a";

                } else if (card.name == "instantiated1Card52b(Clone)") {

                    card.name = "instantiated1HandCard52b";

                } else if (card.name == "instantiated1Card52c(Clone)") {

                    card.name = "instantiated1HandCard52c";

                } else if (card.name == "instantiated1Card53(Clone)") {

                    card.name = "instantiated1HandCard53";

                } else if (card.name == "instantiated1Card53a(Clone)") {

                    card.name = "instantiated1HandCard53a";

                } else if (card.name == "instantiated1Card53b(Clone)") {

                    card.name = "instantiated1HandCard53b";

                } else if (card.name == "instantiated1Card53c(Clone)") {

                    card.name = "instantiated1HandCard53c";

                } else if (card.name == "instantiated1Card54(Clone)") {

                    card.name = "instantiated1HandCard54";

                } else if (card.name == "instantiated1Card54a(Clone)") {

                    card.name = "instantiated1HandCard54a";

                } else if (card.name == "instantiated1Card54b(Clone)") {

                    card.name = "instantiated1HandCard54b";

                } else if (card.name == "instantiated1Card54c(Clone)") {

                    card.name = "instantiated1HandCard54c";

                } else if (card.name == "instantiated1Card55(Clone)") {

                    card.name = "instantiated1HandCard55";

                } else if (card.name == "instantiated1Card55a(Clone)") {

                    card.name = "instantiated1HandCard55a";

                } else if (card.name == "instantiated1Card55b(Clone)") {

                    card.name = "instantiated1HandCard55b";

                } else if (card.name == "instantiated1Card55c(Clone)") {

                    card.name = "instantiated1HandCard55c";

                } else if (card.name == "instantiated1Card56(Clone)") {

                    card.name = "instantiated1HandCard56";

                } else if (card.name == "instantiated1Card56a(Clone)") {

                    card.name = "instantiated1HandCard56a";

                } else if (card.name == "instantiated1Card56b(Clone)") {

                    card.name = "instantiated1HandCard56b";

                } else if (card.name == "instantiated1Card56c(Clone)") {

                    card.name = "instantiated1HandCard56c";

                } else if (card.name == "instantiated1Card57(Clone)") {

                    card.name = "instantiated1HandCard57";

                } else if (card.name == "instantiated1Card57a(Clone)") {

                    card.name = "instantiated1HandCard57a";

                } else if (card.name == "instantiated1Card57b(Clone)") {

                    card.name = "instantiated1HandCard57b";

                } else if (card.name == "instantiated1Card57c(Clone)") {

                    card.name = "instantiated1HandCard57c";

                } else if (card.name == "instantiated1Card58(Clone)") {

                    card.name = "instantiated1HandCard58";

                } else if (card.name == "instantiated1Card58a(Clone)") {

                    card.name = "instantiated1HandCard58a";

                } else if (card.name == "instantiated1Card58b(Clone)") {

                    card.name = "instantiated1HandCard58b";

                } else if (card.name == "instantiated1Card58c(Clone)") {

                    card.name = "instantiated1HandCard58c";

                } else if (card.name == "instantiated1Card59(Clone)") {

                    card.name = "instantiated1HandCard59";

                } else if (card.name == "instantiated1Card59a(Clone)") {

                    card.name = "instantiated1HandCard59a";

                } else if (card.name == "instantiated1Card59b(Clone)") {

                    card.name = "instantiated1HandCard59b";

                } else if (card.name == "instantiated1Card59c(Clone)") {

                    card.name = "instantiated1HandCard59c";

                } else if (card.name == "instantiated1Card60(Clone)") {

                    card.name = "instantiated1HandCard60";

                } else if (card.name == "instantiated1Card60a(Clone)") {

                    card.name = "instantiated1HandCard60a";

                } else if (card.name == "instantiated1Card60b(Clone)") {

                    card.name = "instantiated1HandCard60b";

                } else if (card.name == "instantiated1Card60c(Clone)") {

                    card.name = "instantiated1HandCard60c";
                }

                instances5++;

            }

            while (instances6 < NumberOfCards) {

                GameObject card = Instantiate(playCardsDeck1[UnityEngine.Random.Range(0, playCardsDeck1.Count)], player1DeckSlot6.transform.position, player1DeckSlot6.transform.rotation) as GameObject;
                card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                card.transform.parent = player1DeckSlot6.transform;

                if (card.name == "instantiated1Card1(Clone)") {

                    card.name = "instantiated1HandCard1";

                } else if (card.name == "instantiated1Card1a(Clone)") {

                    card.name = "instantiated1HandCard1a";

                } else if (card.name == "instantiated1Card1b(Clone)") {

                    card.name = "instantiated1HandCard1b";

                } else if (card.name == "instantiated1Card1c(Clone)") {

                    card.name = "instantiated1HandCard1c";

                } else if (card.name == "instantiated1Card2(Clone)") {

                    card.name = "instantiated1HandCard2";

                } else if (card.name == "instantiated1Card2a(Clone)") {

                    card.name = "instantiated1HandCard2a";

                } else if (card.name == "instantiated1Card2b(Clone)") {

                    card.name = "instantiated1HandCard2b";

                } else if (card.name == "instantiated1Card2c(Clone)") {

                    card.name = "instantiated1HandCard2c";

                } else if (card.name == "instantiated1Card3(Clone)") {

                    card.name = "instantiated1HandCard3";

                } else if (card.name == "instantiated1Card3a(Clone)") {

                    card.name = "instantiated1HandCard3a";

                } else if (card.name == "instantiated1Card3b(Clone)") {

                    card.name = "instantiated1HandCard3b";

                } else if (card.name == "instantiated1Card3c(Clone)") {

                    card.name = "instantiated1HandCard3c";

                } else if (card.name == "instantiated1Card4(Clone)") {

                    card.name = "instantiated1HandCard4";

                } else if (card.name == "instantiated1Card4a(Clone)") {

                    card.name = "instantiated1HandCard4a";

                } else if (card.name == "instantiated1Card4b(Clone)") {

                    card.name = "instantiated1HandCard4b";

                } else if (card.name == "instantiated1Card4c(Clone)") {

                    card.name = "instantiated1HandCard4c";

                } else if (card.name == "instantiated1Card5(Clone)") {

                    card.name = "instantiated1HandCard5";

                } else if (card.name == "instantiated1Card5a(Clone)") {

                    card.name = "instantiated1HandCard5a";

                } else if (card.name == "instantiated1Card5b(Clone)") {

                    card.name = "instantiated1HandCard5b";

                } else if (card.name == "instantiated1Card5c(Clone)") {

                    card.name = "instantiated1HandCard5c";

                } else if (card.name == "instantiated1Card6(Clone)") {

                    card.name = "instantiated1HandCard6";

                } else if (card.name == "instantiated1Card6a(Clone)") {

                    card.name = "instantiated1HandCard6a";

                } else if (card.name == "instantiated1Card6b(Clone)") {

                    card.name = "instantiated1HandCard6b";

                } else if (card.name == "instantiated1Card6c(Clone)") {

                    card.name = "instantiated1HandCard6c";

                } else if (card.name == "instantiated1Card7(Clone)") {

                    card.name = "instantiated1HandCard7";

                } else if (card.name == "instantiated1Card7a(Clone)") {

                    card.name = "instantiated1HandCard7a";

                } else if (card.name == "instantiated1Card7b(Clone)") {

                    card.name = "instantiated1HandCard7b";

                } else if (card.name == "instantiated1Card7c(Clone)") {

                    card.name = "instantiated1HandCard7c";

                } else if (card.name == "instantiated1Card8(Clone)") {

                    card.name = "instantiated1HandCard8";

                } else if (card.name == "instantiated1Card8a(Clone)") {

                    card.name = "instantiated1HandCard8a";

                } else if (card.name == "instantiated1Card8b(Clone)") {

                    card.name = "instantiated1HandCard8b";

                } else if (card.name == "instantiated1Card8c(Clone)") {

                    card.name = "instantiated1HandCard8c";

                } else if (card.name == "instantiated1Card9(Clone)") {

                    card.name = "instantiated1HandCard9";

                } else if (card.name == "instantiated1Card9a(Clone)") {

                    card.name = "instantiated1HandCard9a";

                } else if (card.name == "instantiated1Card9b(Clone)") {

                    card.name = "instantiated1HandCard9b";

                } else if (card.name == "instantiated1Card9c(Clone)") {

                    card.name = "instantiated1HandCard9c";

                } else if (card.name == "instantiated1Card10(Clone)") {

                    card.name = "instantiatedAICard10";

                } else if (card.name == "instantiated1Card10a(Clone)") {

                    card.name = "instantiated1HandCard10a";

                } else if (card.name == "instantiated1Card10b(Clone)") {

                    card.name = "instantiated1HandCard10b";

                } else if (card.name == "instantiated1Card10c(Clone)") {

                    card.name = "instantiated1HandCard10c";

                } else if (card.name == "instantiated1Card11(Clone)") {

                    card.name = "instantiated1HandCard11";

                } else if (card.name == "instantiated1Card11a(Clone)") {

                    card.name = "instantiated1HandCard11a";

                } else if (card.name == "instantiated1Card11b(Clone)") {

                    card.name = "instantiated1HandCard11b";

                } else if (card.name == "instantiated1Card11c(Clone)") {

                    card.name = "instantiated1HandCard11c";

                } else if (card.name == "instantiated1Card12(Clone)") {

                    card.name = "instantiated1HandCard12";

                } else if (card.name == "instantiated1Card12a(Clone)") {

                    card.name = "instantiated1HandCard12a";

                } else if (card.name == "instantiated1Card12b(Clone)") {

                    card.name = "instantiated1HandCard12b";

                } else if (card.name == "instantiated1Card12c(Clone)") {

                    card.name = "instantiated1HandCard12c";

                } else if (card.name == "instantiated1Card13(Clone)") {

                    card.name = "instantiated1HandCard13";

                } else if (card.name == "instantiated1Card13a(Clone)") {

                    card.name = "instantiated1HandCard13a";

                } else if (card.name == "instantiated1Card13b(Clone)") {

                    card.name = "instantiated1HandCard13b";

                } else if (card.name == "instantiated1Card13c(Clone)") {

                    card.name = "instantiated1HandCard13c";

                } else if (card.name == "instantiated1Card14(Clone)") {

                    card.name = "instantiated1HandCard14";

                } else if (card.name == "instantiated1Card14a(Clone)") {

                    card.name = "instantiated1HandCard14a";

                } else if (card.name == "instantiated1Card14b(Clone)") {

                    card.name = "instantiated1HandCard14b";

                } else if (card.name == "instantiated1Card14c(Clone)") {

                    card.name = "instantiated1HandCard14c";

                } else if (card.name == "instantiated1Card15(Clone)") {

                    card.name = "instantiated1HandCard15";

                } else if (card.name == "instantiated1Card15a(Clone)") {

                    card.name = "instantiated1HandCard15a";

                } else if (card.name == "instantiated1Card15b(Clone)") {

                    card.name = "instantiated1HandCard15b";

                } else if (card.name == "instantiated1Card15c(Clone)") {

                    card.name = "instantiated1HandCard15c";

                } else if (card.name == "instantiated1Card16(Clone)") {

                    card.name = "instantiated1HandCard16";

                } else if (card.name == "instantiated1Card16a(Clone)") {

                    card.name = "instantiated1HandCard16a";

                } else if (card.name == "instantiated1Card16b(Clone)") {

                    card.name = "instantiated1HandCard16b";

                } else if (card.name == "instantiated1Card16c(Clone)") {

                    card.name = "instantiated1HandCard16c";

                } else if (card.name == "instantiated1Card17(Clone)") {

                    card.name = "instantiated1HandCard17";

                } else if (card.name == "instantiated1Card17a(Clone)") {

                    card.name = "instantiated1HandCard17a";

                } else if (card.name == "instantiated1Card17b(Clone)") {

                    card.name = "instantiated1HandCard17b";

                } else if (card.name == "instantiated1Card17c(Clone)") {

                    card.name = "instantiated1HandCard17c";

                } else if (card.name == "instantiated1Card18(Clone)") {

                    card.name = "instantiated1HandCard18";

                } else if (card.name == "instantiated1Card18a(Clone)") {

                    card.name = "instantiated1HandCard18a";

                } else if (card.name == "instantiated1Card18b(Clone)") {

                    card.name = "instantiated1HandCard18b";

                } else if (card.name == "instantiated1Card18c(Clone)") {

                    card.name = "instantiated1HandCard18c";

                } else if (card.name == "instantiated1Card19(Clone)") {

                    card.name = "instantiated1HandCard19";

                } else if (card.name == "instantiated1Card19a(Clone)") {

                    card.name = "instantiated1HandCard19a";

                } else if (card.name == "instantiated1Card19b(Clone)") {

                    card.name = "instantiated1HandCard19b";

                } else if (card.name == "instantiated1Card19c(Clone)") {

                    card.name = "instantiated1HandCard19c";

                } else if (card.name == "instantiated1Card20(Clone)") {

                    card.name = "instantiated1HandCard20";

                } else if (card.name == "instantiated1Card20a(Clone)") {

                    card.name = "instantiated1HandCard20a";

                } else if (card.name == "instantiated1Card20b(Clone)") {

                    card.name = "instantiated1HandCard20b";

                } else if (card.name == "instantiated1Card20c(Clone)") {

                    card.name = "instantiated1HandCard20c";

                } else if (card.name == "instantiated1Card21(Clone)") {

                    card.name = "instantiated1HandCard21";

                } else if (card.name == "instantiated1Card21a(Clone)") {

                    card.name = "instantiated1HandCard21a";

                } else if (card.name == "instantiated1Card21b(Clone)") {

                    card.name = "instantiated1HandCard21b";

                } else if (card.name == "instantiated1Card21c(Clone)") {

                    card.name = "instantiated1HandCard21c";

                } else if (card.name == "instantiated1Card22(Clone)") {

                    card.name = "instantiated1HandCard22";

                } else if (card.name == "instantiated1Card22a(Clone)") {

                    card.name = "instantiated1HandCard22a";

                } else if (card.name == "instantiated1Card22b(Clone)") {

                    card.name = "instantiated1HandCard22b";

                } else if (card.name == "instantiated1Card22c(Clone)") {

                    card.name = "instantiated1HandCard22c";

                } else if (card.name == "instantiated1Card23(Clone)") {

                    card.name = "instantiated1HandCard23";

                } else if (card.name == "instantiated1Card23a(Clone)") {

                    card.name = "instantiated1HandCard23a";

                } else if (card.name == "instantiated1Card23b(Clone)") {

                    card.name = "instantiated1HandCard23b";

                } else if (card.name == "instantiated1Card23c(Clone)") {

                    card.name = "instantiated1HandCard23c";

                } else if (card.name == "instantiated1Card24(Clone)") {

                    card.name = "instantiated1HandCard24";

                } else if (card.name == "instantiated1Card24a(Clone)") {

                    card.name = "instantiated1HandCard24a";

                } else if (card.name == "instantiated1Card24b(Clone)") {

                    card.name = "instantiated1HandCard24b";

                } else if (card.name == "instantiated1Card24c(Clone)") {

                    card.name = "instantiated1HandCard24c";

                } else if (card.name == "instantiated1Card25(Clone)") {

                    card.name = "instantiated1HandCard25";

                } else if (card.name == "instantiated1Card25a(Clone)") {

                    card.name = "instantiated1HandCard25a";

                } else if (card.name == "instantiated1Card25b(Clone)") {

                    card.name = "instantiated1HandCard25b";

                } else if (card.name == "instantiated1Card25c(Clone)") {

                    card.name = "instantiated1HandCard25c";

                } else if (card.name == "instantiated1Card26(Clone)") {

                    card.name = "instantiated1HandCard26";

                } else if (card.name == "instantiated1Card26a(Clone)") {

                    card.name = "instantiated1HandCard26a";

                } else if (card.name == "instantiated1Card26b(Clone)") {

                    card.name = "instantiated1HandCard26b";

                } else if (card.name == "instantiated1Card26c(Clone)") {

                    card.name = "instantiated1HandCard26c";

                } else if (card.name == "instantiated1Card27(Clone)") {

                    card.name = "instantiated1HandCard27";

                } else if (card.name == "instantiated1Card27a(Clone)") {

                    card.name = "instantiated1HandCard27a";

                } else if (card.name == "instantiated1Card27b(Clone)") {

                    card.name = "instantiated1HandCard27b";

                } else if (card.name == "instantiated1Card27c(Clone)") {

                    card.name = "instantiated1HandCard27c";

                } else if (card.name == "instantiated1Card28(Clone)") {

                    card.name = "instantiated1HandCard28";

                } else if (card.name == "instantiated1Card28a(Clone)") {

                    card.name = "instantiated1HandCard28a";

                } else if (card.name == "instantiated1Card28b(Clone)") {

                    card.name = "instantiated1HandCard28b";

                } else if (card.name == "instantiated1Card28c(Clone)") {

                    card.name = "instantiated1HandCard28c";

                } else if (card.name == "instantiated1Card29(Clone)") {

                    card.name = "instantiated1HandCard29";

                } else if (card.name == "instantiated1Card29a(Clone)") {

                    card.name = "instantiated1HandCard29a";

                } else if (card.name == "instantiated1Card29b(Clone)") {

                    card.name = "instantiated1HandCard29b";

                } else if (card.name == "instantiated1Card29c(Clone)") {

                    card.name = "instantiated1HandCard29c";

                } else if (card.name == "instantiated1Card30(Clone)") {

                    card.name = "instantiated1HandCard30";

                } else if (card.name == "instantiated1Card30a(Clone)") {

                    card.name = "instantiated1HandCard30a";

                } else if (card.name == "instantiated1Card30b(Clone)") {

                    card.name = "instantiated1HandCard30b";

                } else if (card.name == "instantiated1Card30c(Clone)") {

                    card.name = "instantiated1HandCard30c";

                } else if (card.name == "instantiated1Card31(Clone)") {

                    card.name = "instantiated1HandCard31";

                } else if (card.name == "instantiated1Card31a(Clone)") {

                    card.name = "instantiated1HandCard31a";

                } else if (card.name == "instantiated1Card31b(Clone)") {

                    card.name = "instantiated1HandCard31b";

                } else if (card.name == "instantiated1Card31c(Clone)") {

                    card.name = "instantiated1HandCard31c";

                } else if (card.name == "instantiated1Card32(Clone)") {

                    card.name = "instantiated1HandCard32";

                } else if (card.name == "instantiated1Card32a(Clone)") {

                    card.name = "instantiated1HandCard32a";

                } else if (card.name == "instantiated1Card32b(Clone)") {

                    card.name = "instantiated1HandCard32b";

                } else if (card.name == "instantiated1Card32c(Clone)") {

                    card.name = "instantiated1HandCard32c";

                } else if (card.name == "instantiated1Card33(Clone)") {

                    card.name = "instantiated1HandCard33";

                } else if (card.name == "instantiated1Card33a(Clone)") {

                    card.name = "instantiated1HandCard33a";

                } else if (card.name == "instantiated1Card33b(Clone)") {

                    card.name = "instantiated1HandCard33b";

                } else if (card.name == "instantiated1Card33c(Clone)") {

                    card.name = "instantiated1HandCard33c";

                } else if (card.name == "instantiated1Card34(Clone)") {

                    card.name = "instantiated1HandCard34";

                } else if (card.name == "instantiated1Card34a(Clone)") {

                    card.name = "instantiated1HandCard34a";

                } else if (card.name == "instantiated1Card34b(Clone)") {

                    card.name = "instantiated1HandCard34b";

                } else if (card.name == "instantiated1Card34c(Clone)") {

                    card.name = "instantiated1HandCard34c";

                } else if (card.name == "instantiated1Card35(Clone)") {

                    card.name = "instantiated1HandCard35";

                } else if (card.name == "instantiated1Card35a(Clone)") {

                    card.name = "instantiated1HandCard35a";

                } else if (card.name == "instantiated1Card35b(Clone)") {

                    card.name = "instantiated1HandCard35b";

                } else if (card.name == "instantiated1Card35c(Clone)") {

                    card.name = "instantiated1HandCard35c";

                } else if (card.name == "instantiated1Card36(Clone)") {

                    card.name = "instantiated1HandCard36";

                } else if (card.name == "instantiated1Card36a(Clone)") {

                    card.name = "instantiated1HandCard36a";

                } else if (card.name == "instantiated1Card36b(Clone)") {

                    card.name = "instantiated1HandCard36b";

                } else if (card.name == "instantiated1Card36c(Clone)") {

                    card.name = "instantiated1HandCard36c";

                } else if (card.name == "instantiated1Card37(Clone)") {

                    card.name = "instantiated1HandCard37";

                } else if (card.name == "instantiated1Card37a(Clone)") {

                    card.name = "instantiated1HandCard37a";

                } else if (card.name == "instantiated1Card37b(Clone)") {

                    card.name = "instantiated1HandCard37b";

                } else if (card.name == "instantiated1Card37c(Clone)") {

                    card.name = "instantiated1HandCard37c";

                } else if (card.name == "instantiated1Card38(Clone)") {

                    card.name = "instantiated1HandCard38";

                } else if (card.name == "instantiated1Card38a(Clone)") {

                    card.name = "instantiated1HandCard38a";

                } else if (card.name == "instantiated1Card38b(Clone)") {

                    card.name = "instantiated1HandCard38b";

                } else if (card.name == "instantiated1Card38c(Clone)") {

                    card.name = "instantiated1HandCard38c";

                } else if (card.name == "instantiated1Card39(Clone)") {

                    card.name = "instantiated1HandCard39";

                } else if (card.name == "instantiated1Card39a(Clone)") {

                    card.name = "instantiated1HandCard39a";

                } else if (card.name == "instantiated1Card39b(Clone)") {

                    card.name = "instantiated1HandCard39b";

                } else if (card.name == "instantiated1Card39c(Clone)") {

                    card.name = "instantiated1HandCard39c";

                } else if (card.name == "instantiated1Card40(Clone)") {

                    card.name = "instantiated1HandCard40";

                } else if (card.name == "instantiated1Card40a(Clone)") {

                    card.name = "instantiated1HandCard40a";

                } else if (card.name == "instantiated1Card40b(Clone)") {

                    card.name = "instantiated1HandCard40b";

                } else if (card.name == "instantiated1Card40c(Clone)") {

                    card.name = "instantiated1HandCard40c";

                } else if (card.name == "instantiated1Card41(Clone)") {

                    card.name = "instantiated1HandCard41";

                } else if (card.name == "instantiated1Card41a(Clone)") {

                    card.name = "instantiated1HandCard41a";

                } else if (card.name == "instantiated1Card41b(Clone)") {

                    card.name = "instantiated1HandCard41b";

                } else if (card.name == "instantiated1Card41c(Clone)") {

                    card.name = "instantiated1HandCard41c";

                } else if (card.name == "instantiated1Card42(Clone)") {

                    card.name = "instantiated1HandCard42";

                } else if (card.name == "instantiated1Card42a(Clone)") {

                    card.name = "instantiated1HandCard42a";

                } else if (card.name == "instantiated1Card42b(Clone)") {

                    card.name = "instantiated1HandCard42b";

                } else if (card.name == "instantiated1Card42c(Clone)") {

                    card.name = "instantiated1HandCard42c";

                } else if (card.name == "instantiated1Card43(Clone)") {

                    card.name = "instantiated1HandCard43";

                } else if (card.name == "instantiated1Card43a(Clone)") {

                    card.name = "instantiated1HandCard43a";

                } else if (card.name == "instantiated1Card43b(Clone)") {

                    card.name = "instantiated1HandCard43b";

                } else if (card.name == "instantiated1Card43c(Clone)") {

                    card.name = "instantiated1HandCard43c";

                } else if (card.name == "instantiated1Card44(Clone)") {

                    card.name = "instantiated1HandCard44";

                } else if (card.name == "instantiated1Card44a(Clone)") {

                    card.name = "instantiated1HandCard44a";

                } else if (card.name == "instantiated1Card44b(Clone)") {

                    card.name = "instantiated1HandCard44b";

                } else if (card.name == "instantiated1Card44c(Clone)") {

                    card.name = "instantiated1HandCard44c";

                } else if (card.name == "instantiated1Card45(Clone)") {

                    card.name = "instantiated1HandCard45";

                } else if (card.name == "instantiated1Card45a(Clone)") {

                    card.name = "instantiated1HandCard45a";

                } else if (card.name == "instantiated1Card45b(Clone)") {

                    card.name = "instantiated1HandCard45b";

                } else if (card.name == "instantiated1Card45c(Clone)") {

                    card.name = "instantiated1HandCard45c";

                } else if (card.name == "instantiated1Card46(Clone)") {

                    card.name = "instantiated1HandCard46";

                } else if (card.name == "instantiated1Card46a(Clone)") {

                    card.name = "instantiated1HandCard46a";

                } else if (card.name == "instantiated1Card46b(Clone)") {

                    card.name = "instantiated1HandCard46b";

                } else if (card.name == "instantiated1Card46c(Clone)") {

                    card.name = "instantiated1HandCard46c";

                } else if (card.name == "instantiated1Card47(Clone)") {

                    card.name = "instantiated1HandCard47";

                } else if (card.name == "instantiated1Card47a(Clone)") {

                    card.name = "instantiated1HandCard47a";

                } else if (card.name == "instantiated1Card47b(Clone)") {

                    card.name = "instantiated1HandCard47b";

                } else if (card.name == "instantiated1Card47c(Clone)") {

                    card.name = "instantiated1HandCard47c";

                } else if (card.name == "instantiated1Card48(Clone)") {

                    card.name = "instantiated1HandCard48";

                } else if (card.name == "instantiated1Card48a(Clone)") {

                    card.name = "instantiated1HandCard48a";

                } else if (card.name == "instantiated1Card48b(Clone)") {

                    card.name = "instantiated1HandCard48b";

                } else if (card.name == "instantiated1Card48c(Clone)") {

                    card.name = "instantiated1HandCard48c";

                } else if (card.name == "instantiated1Card49(Clone)") {

                    card.name = "instantiated1HandCard49";

                } else if (card.name == "instantiated1Card49a(Clone)") {

                    card.name = "instantiated1HandCard49a";

                } else if (card.name == "instantiated1Card49b(Clone)") {

                    card.name = "instantiated1HandCard49b";

                } else if (card.name == "instantiated1Card49c(Clone)") {

                    card.name = "instantiated1HandCard49c";

                } else if (card.name == "instantiated1Card50(Clone)") {

                    card.name = "instantiated1HandCard50";

                } else if (card.name == "instantiated1Card50a(Clone)") {

                    card.name = "instantiated1HandCard50a";

                } else if (card.name == "instantiated1Card50b(Clone)") {

                    card.name = "instantiated1HandCard50b";

                } else if (card.name == "instantiated1Card50c(Clone)") {

                    card.name = "instantiated1HandCard50c";

                } else if (card.name == "instantiated1Card51(Clone)") {

                    card.name = "instantiated1HandCard51";

                } else if (card.name == "instantiated1Card51a(Clone)") {

                    card.name = "instantiated1HandCard51a";

                } else if (card.name == "instantiated1Card51b(Clone)") {

                    card.name = "instantiated1HandCard51b";

                } else if (card.name == "instantiated1Card51c(Clone)") {

                    card.name = "instantiated1HandCard51c";

                } else if (card.name == "instantiated1Card52(Clone)") {

                    card.name = "instantiated1HandCard52";

                } else if (card.name == "instantiated1Card52a(Clone)") {

                    card.name = "instantiated1HandCard52a";

                } else if (card.name == "instantiated1Card52b(Clone)") {

                    card.name = "instantiated1HandCard52b";

                } else if (card.name == "instantiated1Card52c(Clone)") {

                    card.name = "instantiated1HandCard52c";

                } else if (card.name == "instantiated1Card53(Clone)") {

                    card.name = "instantiated1HandCard53";

                } else if (card.name == "instantiated1Card53a(Clone)") {

                    card.name = "instantiated1HandCard53a";

                } else if (card.name == "instantiated1Card53b(Clone)") {

                    card.name = "instantiated1HandCard53b";

                } else if (card.name == "instantiated1Card53c(Clone)") {

                    card.name = "instantiated1HandCard53c";

                } else if (card.name == "instantiated1Card54(Clone)") {

                    card.name = "instantiated1HandCard54";

                } else if (card.name == "instantiated1Card54a(Clone)") {

                    card.name = "instantiated1HandCard54a";

                } else if (card.name == "instantiated1Card54b(Clone)") {

                    card.name = "instantiated1HandCard54b";

                } else if (card.name == "instantiated1Card54c(Clone)") {

                    card.name = "instantiated1HandCard54c";

                } else if (card.name == "instantiated1Card55(Clone)") {

                    card.name = "instantiated1HandCard55";

                } else if (card.name == "instantiated1Card55a(Clone)") {

                    card.name = "instantiated1HandCard55a";

                } else if (card.name == "instantiated1Card55b(Clone)") {

                    card.name = "instantiated1HandCard55b";

                } else if (card.name == "instantiated1Card55c(Clone)") {

                    card.name = "instantiated1HandCard55c";

                } else if (card.name == "instantiated1Card56(Clone)") {

                    card.name = "instantiated1HandCard56";

                } else if (card.name == "instantiated1Card56a(Clone)") {

                    card.name = "instantiated1HandCard56a";

                } else if (card.name == "instantiated1Card56b(Clone)") {

                    card.name = "instantiated1HandCard56b";

                } else if (card.name == "instantiated1Card56c(Clone)") {

                    card.name = "instantiated1HandCard56c";

                } else if (card.name == "instantiated1Card57(Clone)") {

                    card.name = "instantiated1HandCard57";

                } else if (card.name == "instantiated1Card57a(Clone)") {

                    card.name = "instantiated1HandCard57a";

                } else if (card.name == "instantiated1Card57b(Clone)") {

                    card.name = "instantiated1HandCard57b";

                } else if (card.name == "instantiated1Card57c(Clone)") {

                    card.name = "instantiated1HandCard57c";

                } else if (card.name == "instantiated1Card58(Clone)") {

                    card.name = "instantiated1HandCard58";

                } else if (card.name == "instantiated1Card58a(Clone)") {

                    card.name = "instantiated1HandCard58a";

                } else if (card.name == "instantiated1Card58b(Clone)") {

                    card.name = "instantiated1HandCard58b";

                } else if (card.name == "instantiated1Card58c(Clone)") {

                    card.name = "instantiated1HandCard58c";

                } else if (card.name == "instantiated1Card59(Clone)") {

                    card.name = "instantiated1HandCard59";

                } else if (card.name == "instantiated1Card59a(Clone)") {

                    card.name = "instantiated1HandCard59a";

                } else if (card.name == "instantiated1Card59b(Clone)") {

                    card.name = "instantiated1HandCard59b";

                } else if (card.name == "instantiated1Card59c(Clone)") {

                    card.name = "instantiated1HandCard59c";

                } else if (card.name == "instantiated1Card60(Clone)") {

                    card.name = "instantiated1HandCard60";

                } else if (card.name == "instantiated1Card60a(Clone)") {

                    card.name = "instantiated1HandCard60a";

                } else if (card.name == "instantiated1Card60b(Clone)") {

                    card.name = "instantiated1HandCard60b";

                } else if (card.name == "instantiated1Card60c(Clone)") {

                    card.name = "instantiated1HandCard60c";
                }

                instances6++;

            }

            while (instances7 < NumberOfCards) {

                GameObject card = Instantiate(playCardsDeck1[UnityEngine.Random.Range(0, playCardsDeck1.Count)], player1DeckSlot7.transform.position, player1DeckSlot7.transform.rotation) as GameObject;
                card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                card.transform.parent = player1DeckSlot7.transform;

                if (card.name == "instantiated1Card1(Clone)") {

                    card.name = "instantiated1HandCard1";

                } else if (card.name == "instantiated1Card1a(Clone)") {

                    card.name = "instantiated1HandCard1a";

                } else if (card.name == "instantiated1Card1b(Clone)") {

                    card.name = "instantiated1HandCard1b";

                } else if (card.name == "instantiated1Card1c(Clone)") {

                    card.name = "instantiated1HandCard1c";

                } else if (card.name == "instantiated1Card2(Clone)") {

                    card.name = "instantiated1HandCard2";

                } else if (card.name == "instantiated1Card2a(Clone)") {

                    card.name = "instantiated1HandCard2a";

                } else if (card.name == "instantiated1Card2b(Clone)") {

                    card.name = "instantiated1HandCard2b";

                } else if (card.name == "instantiated1Card2c(Clone)") {

                    card.name = "instantiated1HandCard2c";

                } else if (card.name == "instantiated1Card3(Clone)") {

                    card.name = "instantiated1HandCard3";

                } else if (card.name == "instantiated1Card3a(Clone)") {

                    card.name = "instantiated1HandCard3a";

                } else if (card.name == "instantiated1Card3b(Clone)") {

                    card.name = "instantiated1HandCard3b";

                } else if (card.name == "instantiated1Card3c(Clone)") {

                    card.name = "instantiated1HandCard3c";

                } else if (card.name == "instantiated1Card4(Clone)") {

                    card.name = "instantiated1HandCard4";

                } else if (card.name == "instantiated1Card4a(Clone)") {

                    card.name = "instantiated1HandCard4a";

                } else if (card.name == "instantiated1Card4b(Clone)") {

                    card.name = "instantiated1HandCard4b";

                } else if (card.name == "instantiated1Card4c(Clone)") {

                    card.name = "instantiated1HandCard4c";

                } else if (card.name == "instantiated1Card5(Clone)") {

                    card.name = "instantiated1HandCard5";

                } else if (card.name == "instantiated1Card5a(Clone)") {

                    card.name = "instantiated1HandCard5a";

                } else if (card.name == "instantiated1Card5b(Clone)") {

                    card.name = "instantiated1HandCard5b";

                } else if (card.name == "instantiated1Card5c(Clone)") {

                    card.name = "instantiated1HandCard5c";

                } else if (card.name == "instantiated1Card6(Clone)") {

                    card.name = "instantiated1HandCard6";

                } else if (card.name == "instantiated1Card6a(Clone)") {

                    card.name = "instantiated1HandCard6a";

                } else if (card.name == "instantiated1Card6b(Clone)") {

                    card.name = "instantiated1HandCard6b";

                } else if (card.name == "instantiated1Card6c(Clone)") {

                    card.name = "instantiated1HandCard6c";

                } else if (card.name == "instantiated1Card7(Clone)") {

                    card.name = "instantiated1HandCard7";

                } else if (card.name == "instantiated1Card7a(Clone)") {

                    card.name = "instantiated1HandCard7a";

                } else if (card.name == "instantiated1Card7b(Clone)") {

                    card.name = "instantiated1HandCard7b";

                } else if (card.name == "instantiated1Card7c(Clone)") {

                    card.name = "instantiated1HandCard7c";

                } else if (card.name == "instantiated1Card8(Clone)") {

                    card.name = "instantiated1HandCard8";

                } else if (card.name == "instantiated1Card8a(Clone)") {

                    card.name = "instantiated1HandCard8a";

                } else if (card.name == "instantiated1Card8b(Clone)") {

                    card.name = "instantiated1HandCard8b";

                } else if (card.name == "instantiated1Card8c(Clone)") {

                    card.name = "instantiated1HandCard8c";

                } else if (card.name == "instantiated1Card9(Clone)") {

                    card.name = "instantiated1HandCard9";

                } else if (card.name == "instantiated1Card9a(Clone)") {

                    card.name = "instantiated1HandCard9a";

                } else if (card.name == "instantiated1Card9b(Clone)") {

                    card.name = "instantiated1HandCard9b";

                } else if (card.name == "instantiated1Card9c(Clone)") {

                    card.name = "instantiated1HandCard9c";

                } else if (card.name == "instantiated1Card10(Clone)") {

                    card.name = "instantiatedAICard10";

                } else if (card.name == "instantiated1Card10a(Clone)") {

                    card.name = "instantiated1HandCard10a";

                } else if (card.name == "instantiated1Card10b(Clone)") {

                    card.name = "instantiated1HandCard10b";

                } else if (card.name == "instantiated1Card10c(Clone)") {

                    card.name = "instantiated1HandCard10c";

                } else if (card.name == "instantiated1Card11(Clone)") {

                    card.name = "instantiated1HandCard11";

                } else if (card.name == "instantiated1Card11a(Clone)") {

                    card.name = "instantiated1HandCard11a";

                } else if (card.name == "instantiated1Card11b(Clone)") {

                    card.name = "instantiated1HandCard11b";

                } else if (card.name == "instantiated1Card11c(Clone)") {

                    card.name = "instantiated1HandCard11c";

                } else if (card.name == "instantiated1Card12(Clone)") {

                    card.name = "instantiated1HandCard12";

                } else if (card.name == "instantiated1Card12a(Clone)") {

                    card.name = "instantiated1HandCard12a";

                } else if (card.name == "instantiated1Card12b(Clone)") {

                    card.name = "instantiated1HandCard12b";

                } else if (card.name == "instantiated1Card12c(Clone)") {

                    card.name = "instantiated1HandCard12c";

                } else if (card.name == "instantiated1Card13(Clone)") {

                    card.name = "instantiated1HandCard13";

                } else if (card.name == "instantiated1Card13a(Clone)") {

                    card.name = "instantiated1HandCard13a";

                } else if (card.name == "instantiated1Card13b(Clone)") {

                    card.name = "instantiated1HandCard13b";

                } else if (card.name == "instantiated1Card13c(Clone)") {

                    card.name = "instantiated1HandCard13c";

                } else if (card.name == "instantiated1Card14(Clone)") {

                    card.name = "instantiated1HandCard14";

                } else if (card.name == "instantiated1Card14a(Clone)") {

                    card.name = "instantiated1HandCard14a";

                } else if (card.name == "instantiated1Card14b(Clone)") {

                    card.name = "instantiated1HandCard14b";

                } else if (card.name == "instantiated1Card14c(Clone)") {

                    card.name = "instantiated1HandCard14c";

                } else if (card.name == "instantiated1Card15(Clone)") {

                    card.name = "instantiated1HandCard15";

                } else if (card.name == "instantiated1Card15a(Clone)") {

                    card.name = "instantiated1HandCard15a";

                } else if (card.name == "instantiated1Card15b(Clone)") {

                    card.name = "instantiated1HandCard15b";

                } else if (card.name == "instantiated1Card15c(Clone)") {

                    card.name = "instantiated1HandCard15c";

                } else if (card.name == "instantiated1Card16(Clone)") {

                    card.name = "instantiated1HandCard16";

                } else if (card.name == "instantiated1Card16a(Clone)") {

                    card.name = "instantiated1HandCard16a";

                } else if (card.name == "instantiated1Card16b(Clone)") {

                    card.name = "instantiated1HandCard16b";

                } else if (card.name == "instantiated1Card16c(Clone)") {

                    card.name = "instantiated1HandCard16c";

                } else if (card.name == "instantiated1Card17(Clone)") {

                    card.name = "instantiated1HandCard17";

                } else if (card.name == "instantiated1Card17a(Clone)") {

                    card.name = "instantiated1HandCard17a";

                } else if (card.name == "instantiated1Card17b(Clone)") {

                    card.name = "instantiated1HandCard17b";

                } else if (card.name == "instantiated1Card17c(Clone)") {

                    card.name = "instantiated1HandCard17c";

                } else if (card.name == "instantiated1Card18(Clone)") {

                    card.name = "instantiated1HandCard18";

                } else if (card.name == "instantiated1Card18a(Clone)") {

                    card.name = "instantiated1HandCard18a";

                } else if (card.name == "instantiated1Card18b(Clone)") {

                    card.name = "instantiated1HandCard18b";

                } else if (card.name == "instantiated1Card18c(Clone)") {

                    card.name = "instantiated1HandCard18c";

                } else if (card.name == "instantiated1Card19(Clone)") {

                    card.name = "instantiated1HandCard19";

                } else if (card.name == "instantiated1Card19a(Clone)") {

                    card.name = "instantiated1HandCard19a";

                } else if (card.name == "instantiated1Card19b(Clone)") {

                    card.name = "instantiated1HandCard19b";

                } else if (card.name == "instantiated1Card19c(Clone)") {

                    card.name = "instantiated1HandCard19c";

                } else if (card.name == "instantiated1Card20(Clone)") {

                    card.name = "instantiated1HandCard20";

                } else if (card.name == "instantiated1Card20a(Clone)") {

                    card.name = "instantiated1HandCard20a";

                } else if (card.name == "instantiated1Card20b(Clone)") {

                    card.name = "instantiated1HandCard20b";

                } else if (card.name == "instantiated1Card20c(Clone)") {

                    card.name = "instantiated1HandCard20c";

                } else if (card.name == "instantiated1Card21(Clone)") {

                    card.name = "instantiated1HandCard21";

                } else if (card.name == "instantiated1Card21a(Clone)") {

                    card.name = "instantiated1HandCard21a";

                } else if (card.name == "instantiated1Card21b(Clone)") {

                    card.name = "instantiated1HandCard21b";

                } else if (card.name == "instantiated1Card21c(Clone)") {

                    card.name = "instantiated1HandCard21c";

                } else if (card.name == "instantiated1Card22(Clone)") {

                    card.name = "instantiated1HandCard22";

                } else if (card.name == "instantiated1Card22a(Clone)") {

                    card.name = "instantiated1HandCard22a";

                } else if (card.name == "instantiated1Card22b(Clone)") {

                    card.name = "instantiated1HandCard22b";

                } else if (card.name == "instantiated1Card22c(Clone)") {

                    card.name = "instantiated1HandCard22c";

                } else if (card.name == "instantiated1Card23(Clone)") {

                    card.name = "instantiated1HandCard23";

                } else if (card.name == "instantiated1Card23a(Clone)") {

                    card.name = "instantiated1HandCard23a";

                } else if (card.name == "instantiated1Card23b(Clone)") {

                    card.name = "instantiated1HandCard23b";

                } else if (card.name == "instantiated1Card23c(Clone)") {

                    card.name = "instantiated1HandCard23c";

                } else if (card.name == "instantiated1Card24(Clone)") {

                    card.name = "instantiated1HandCard24";

                } else if (card.name == "instantiated1Card24a(Clone)") {

                    card.name = "instantiated1HandCard24a";

                } else if (card.name == "instantiated1Card24b(Clone)") {

                    card.name = "instantiated1HandCard24b";

                } else if (card.name == "instantiated1Card24c(Clone)") {

                    card.name = "instantiated1HandCard24c";

                } else if (card.name == "instantiated1Card25(Clone)") {

                    card.name = "instantiated1HandCard25";

                } else if (card.name == "instantiated1Card25a(Clone)") {

                    card.name = "instantiated1HandCard25a";

                } else if (card.name == "instantiated1Card25b(Clone)") {

                    card.name = "instantiated1HandCard25b";

                } else if (card.name == "instantiated1Card25c(Clone)") {

                    card.name = "instantiated1HandCard25c";

                } else if (card.name == "instantiated1Card26(Clone)") {

                    card.name = "instantiated1HandCard26";

                } else if (card.name == "instantiated1Card26a(Clone)") {

                    card.name = "instantiated1HandCard26a";

                } else if (card.name == "instantiated1Card26b(Clone)") {

                    card.name = "instantiated1HandCard26b";

                } else if (card.name == "instantiated1Card26c(Clone)") {

                    card.name = "instantiated1HandCard26c";

                } else if (card.name == "instantiated1Card27(Clone)") {

                    card.name = "instantiated1HandCard27";

                } else if (card.name == "instantiated1Card27a(Clone)") {

                    card.name = "instantiated1HandCard27a";

                } else if (card.name == "instantiated1Card27b(Clone)") {

                    card.name = "instantiated1HandCard27b";

                } else if (card.name == "instantiated1Card27c(Clone)") {

                    card.name = "instantiated1HandCard27c";

                } else if (card.name == "instantiated1Card28(Clone)") {

                    card.name = "instantiated1HandCard28";

                } else if (card.name == "instantiated1Card28a(Clone)") {

                    card.name = "instantiated1HandCard28a";

                } else if (card.name == "instantiated1Card28b(Clone)") {

                    card.name = "instantiated1HandCard28b";

                } else if (card.name == "instantiated1Card28c(Clone)") {

                    card.name = "instantiated1HandCard28c";

                } else if (card.name == "instantiated1Card29(Clone)") {

                    card.name = "instantiated1HandCard29";

                } else if (card.name == "instantiated1Card29a(Clone)") {

                    card.name = "instantiated1HandCard29a";

                } else if (card.name == "instantiated1Card29b(Clone)") {

                    card.name = "instantiated1HandCard29b";

                } else if (card.name == "instantiated1Card29c(Clone)") {

                    card.name = "instantiated1HandCard29c";

                } else if (card.name == "instantiated1Card30(Clone)") {

                    card.name = "instantiated1HandCard30";

                } else if (card.name == "instantiated1Card30a(Clone)") {

                    card.name = "instantiated1HandCard30a";

                } else if (card.name == "instantiated1Card30b(Clone)") {

                    card.name = "instantiated1HandCard30b";

                } else if (card.name == "instantiated1Card30c(Clone)") {

                    card.name = "instantiated1HandCard30c";

                } else if (card.name == "instantiated1Card31(Clone)") {

                    card.name = "instantiated1HandCard31";

                } else if (card.name == "instantiated1Card31a(Clone)") {

                    card.name = "instantiated1HandCard31a";

                } else if (card.name == "instantiated1Card31b(Clone)") {

                    card.name = "instantiated1HandCard31b";

                } else if (card.name == "instantiated1Card31c(Clone)") {

                    card.name = "instantiated1HandCard31c";

                } else if (card.name == "instantiated1Card32(Clone)") {

                    card.name = "instantiated1HandCard32";

                } else if (card.name == "instantiated1Card32a(Clone)") {

                    card.name = "instantiated1HandCard32a";

                } else if (card.name == "instantiated1Card32b(Clone)") {

                    card.name = "instantiated1HandCard32b";

                } else if (card.name == "instantiated1Card32c(Clone)") {

                    card.name = "instantiated1HandCard32c";

                } else if (card.name == "instantiated1Card33(Clone)") {

                    card.name = "instantiated1HandCard33";

                } else if (card.name == "instantiated1Card33a(Clone)") {

                    card.name = "instantiated1HandCard33a";

                } else if (card.name == "instantiated1Card33b(Clone)") {

                    card.name = "instantiated1HandCard33b";

                } else if (card.name == "instantiated1Card33c(Clone)") {

                    card.name = "instantiated1HandCard33c";

                } else if (card.name == "instantiated1Card34(Clone)") {

                    card.name = "instantiated1HandCard34";

                } else if (card.name == "instantiated1Card34a(Clone)") {

                    card.name = "instantiated1HandCard34a";

                } else if (card.name == "instantiated1Card34b(Clone)") {

                    card.name = "instantiated1HandCard34b";

                } else if (card.name == "instantiated1Card34c(Clone)") {

                    card.name = "instantiated1HandCard34c";

                } else if (card.name == "instantiated1Card35(Clone)") {

                    card.name = "instantiated1HandCard35";

                } else if (card.name == "instantiated1Card35a(Clone)") {

                    card.name = "instantiated1HandCard35a";

                } else if (card.name == "instantiated1Card35b(Clone)") {

                    card.name = "instantiated1HandCard35b";

                } else if (card.name == "instantiated1Card35c(Clone)") {

                    card.name = "instantiated1HandCard35c";

                } else if (card.name == "instantiated1Card36(Clone)") {

                    card.name = "instantiated1HandCard36";

                } else if (card.name == "instantiated1Card36a(Clone)") {

                    card.name = "instantiated1HandCard36a";

                } else if (card.name == "instantiated1Card36b(Clone)") {

                    card.name = "instantiated1HandCard36b";

                } else if (card.name == "instantiated1Card36c(Clone)") {

                    card.name = "instantiated1HandCard36c";

                } else if (card.name == "instantiated1Card37(Clone)") {

                    card.name = "instantiated1HandCard37";

                } else if (card.name == "instantiated1Card37a(Clone)") {

                    card.name = "instantiated1HandCard37a";

                } else if (card.name == "instantiated1Card37b(Clone)") {

                    card.name = "instantiated1HandCard37b";

                } else if (card.name == "instantiated1Card37c(Clone)") {

                    card.name = "instantiated1HandCard37c";

                } else if (card.name == "instantiated1Card38(Clone)") {

                    card.name = "instantiated1HandCard38";

                } else if (card.name == "instantiated1Card38a(Clone)") {

                    card.name = "instantiated1HandCard38a";

                } else if (card.name == "instantiated1Card38b(Clone)") {

                    card.name = "instantiated1HandCard38b";

                } else if (card.name == "instantiated1Card38c(Clone)") {

                    card.name = "instantiated1HandCard38c";

                } else if (card.name == "instantiated1Card39(Clone)") {

                    card.name = "instantiated1HandCard39";

                } else if (card.name == "instantiated1Card39a(Clone)") {

                    card.name = "instantiated1HandCard39a";

                } else if (card.name == "instantiated1Card39b(Clone)") {

                    card.name = "instantiated1HandCard39b";

                } else if (card.name == "instantiated1Card39c(Clone)") {

                    card.name = "instantiated1HandCard39c";

                } else if (card.name == "instantiated1Card40(Clone)") {

                    card.name = "instantiated1HandCard40";

                } else if (card.name == "instantiated1Card40a(Clone)") {

                    card.name = "instantiated1HandCard40a";

                } else if (card.name == "instantiated1Card40b(Clone)") {

                    card.name = "instantiated1HandCard40b";

                } else if (card.name == "instantiated1Card40c(Clone)") {

                    card.name = "instantiated1HandCard40c";

                } else if (card.name == "instantiated1Card41(Clone)") {

                    card.name = "instantiated1HandCard41";

                } else if (card.name == "instantiated1Card41a(Clone)") {

                    card.name = "instantiated1HandCard41a";

                } else if (card.name == "instantiated1Card41b(Clone)") {

                    card.name = "instantiated1HandCard41b";

                } else if (card.name == "instantiated1Card41c(Clone)") {

                    card.name = "instantiated1HandCard41c";

                } else if (card.name == "instantiated1Card42(Clone)") {

                    card.name = "instantiated1HandCard42";

                } else if (card.name == "instantiated1Card42a(Clone)") {

                    card.name = "instantiated1HandCard42a";

                } else if (card.name == "instantiated1Card42b(Clone)") {

                    card.name = "instantiated1HandCard42b";

                } else if (card.name == "instantiated1Card42c(Clone)") {

                    card.name = "instantiated1HandCard42c";

                } else if (card.name == "instantiated1Card43(Clone)") {

                    card.name = "instantiated1HandCard43";

                } else if (card.name == "instantiated1Card43a(Clone)") {

                    card.name = "instantiated1HandCard43a";

                } else if (card.name == "instantiated1Card43b(Clone)") {

                    card.name = "instantiated1HandCard43b";

                } else if (card.name == "instantiated1Card43c(Clone)") {

                    card.name = "instantiated1HandCard43c";

                } else if (card.name == "instantiated1Card44(Clone)") {

                    card.name = "instantiated1HandCard44";

                } else if (card.name == "instantiated1Card44a(Clone)") {

                    card.name = "instantiated1HandCard44a";

                } else if (card.name == "instantiated1Card44b(Clone)") {

                    card.name = "instantiated1HandCard44b";

                } else if (card.name == "instantiated1Card44c(Clone)") {

                    card.name = "instantiated1HandCard44c";

                } else if (card.name == "instantiated1Card45(Clone)") {

                    card.name = "instantiated1HandCard45";

                } else if (card.name == "instantiated1Card45a(Clone)") {

                    card.name = "instantiated1HandCard45a";

                } else if (card.name == "instantiated1Card45b(Clone)") {

                    card.name = "instantiated1HandCard45b";

                } else if (card.name == "instantiated1Card45c(Clone)") {

                    card.name = "instantiated1HandCard45c";

                } else if (card.name == "instantiated1Card46(Clone)") {

                    card.name = "instantiated1HandCard46";

                } else if (card.name == "instantiated1Card46a(Clone)") {

                    card.name = "instantiated1HandCard46a";

                } else if (card.name == "instantiated1Card46b(Clone)") {

                    card.name = "instantiated1HandCard46b";

                } else if (card.name == "instantiated1Card46c(Clone)") {

                    card.name = "instantiated1HandCard46c";

                } else if (card.name == "instantiated1Card47(Clone)") {

                    card.name = "instantiated1HandCard47";

                } else if (card.name == "instantiated1Card47a(Clone)") {

                    card.name = "instantiated1HandCard47a";

                } else if (card.name == "instantiated1Card47b(Clone)") {

                    card.name = "instantiated1HandCard47b";

                } else if (card.name == "instantiated1Card47c(Clone)") {

                    card.name = "instantiated1HandCard47c";

                } else if (card.name == "instantiated1Card48(Clone)") {

                    card.name = "instantiated1HandCard48";

                } else if (card.name == "instantiated1Card48a(Clone)") {

                    card.name = "instantiated1HandCard48a";

                } else if (card.name == "instantiated1Card48b(Clone)") {

                    card.name = "instantiated1HandCard48b";

                } else if (card.name == "instantiated1Card48c(Clone)") {

                    card.name = "instantiated1HandCard48c";

                } else if (card.name == "instantiated1Card49(Clone)") {

                    card.name = "instantiated1HandCard49";

                } else if (card.name == "instantiated1Card49a(Clone)") {

                    card.name = "instantiated1HandCard49a";

                } else if (card.name == "instantiated1Card49b(Clone)") {

                    card.name = "instantiated1HandCard49b";

                } else if (card.name == "instantiated1Card49c(Clone)") {

                    card.name = "instantiated1HandCard49c";

                } else if (card.name == "instantiated1Card50(Clone)") {

                    card.name = "instantiated1HandCard50";

                } else if (card.name == "instantiated1Card50a(Clone)") {

                    card.name = "instantiated1HandCard50a";

                } else if (card.name == "instantiated1Card50b(Clone)") {

                    card.name = "instantiated1HandCard50b";

                } else if (card.name == "instantiated1Card50c(Clone)") {

                    card.name = "instantiated1HandCard50c";

                } else if (card.name == "instantiated1Card51(Clone)") {

                    card.name = "instantiated1HandCard51";

                } else if (card.name == "instantiated1Card51a(Clone)") {

                    card.name = "instantiated1HandCard51a";

                } else if (card.name == "instantiated1Card51b(Clone)") {

                    card.name = "instantiated1HandCard51b";

                } else if (card.name == "instantiated1Card51c(Clone)") {

                    card.name = "instantiated1HandCard51c";

                } else if (card.name == "instantiated1Card52(Clone)") {

                    card.name = "instantiated1HandCard52";

                } else if (card.name == "instantiated1Card52a(Clone)") {

                    card.name = "instantiated1HandCard52a";

                } else if (card.name == "instantiated1Card52b(Clone)") {

                    card.name = "instantiated1HandCard52b";

                } else if (card.name == "instantiated1Card52c(Clone)") {

                    card.name = "instantiated1HandCard52c";

                } else if (card.name == "instantiated1Card53(Clone)") {

                    card.name = "instantiated1HandCard53";

                } else if (card.name == "instantiated1Card53a(Clone)") {

                    card.name = "instantiated1HandCard53a";

                } else if (card.name == "instantiated1Card53b(Clone)") {

                    card.name = "instantiated1HandCard53b";

                } else if (card.name == "instantiated1Card53c(Clone)") {

                    card.name = "instantiated1HandCard53c";

                } else if (card.name == "instantiated1Card54(Clone)") {

                    card.name = "instantiated1HandCard54";

                } else if (card.name == "instantiated1Card54a(Clone)") {

                    card.name = "instantiated1HandCard54a";

                } else if (card.name == "instantiated1Card54b(Clone)") {

                    card.name = "instantiated1HandCard54b";

                } else if (card.name == "instantiated1Card54c(Clone)") {

                    card.name = "instantiated1HandCard54c";

                } else if (card.name == "instantiated1Card55(Clone)") {

                    card.name = "instantiated1HandCard55";

                } else if (card.name == "instantiated1Card55a(Clone)") {

                    card.name = "instantiated1HandCard55a";

                } else if (card.name == "instantiated1Card55b(Clone)") {

                    card.name = "instantiated1HandCard55b";

                } else if (card.name == "instantiated1Card55c(Clone)") {

                    card.name = "instantiated1HandCard55c";

                } else if (card.name == "instantiated1Card56(Clone)") {

                    card.name = "instantiated1HandCard56";

                } else if (card.name == "instantiated1Card56a(Clone)") {

                    card.name = "instantiated1HandCard56a";

                } else if (card.name == "instantiated1Card56b(Clone)") {

                    card.name = "instantiated1HandCard56b";

                } else if (card.name == "instantiated1Card56c(Clone)") {

                    card.name = "instantiated1HandCard56c";

                } else if (card.name == "instantiated1Card57(Clone)") {

                    card.name = "instantiated1HandCard57";

                } else if (card.name == "instantiated1Card57a(Clone)") {

                    card.name = "instantiated1HandCard57a";

                } else if (card.name == "instantiated1Card57b(Clone)") {

                    card.name = "instantiated1HandCard57b";

                } else if (card.name == "instantiated1Card57c(Clone)") {

                    card.name = "instantiated1HandCard57c";

                } else if (card.name == "instantiated1Card58(Clone)") {

                    card.name = "instantiated1HandCard58";

                } else if (card.name == "instantiated1Card58a(Clone)") {

                    card.name = "instantiated1HandCard58a";

                } else if (card.name == "instantiated1Card58b(Clone)") {

                    card.name = "instantiated1HandCard58b";

                } else if (card.name == "instantiated1Card58c(Clone)") {

                    card.name = "instantiated1HandCard58c";

                } else if (card.name == "instantiated1Card59(Clone)") {

                    card.name = "instantiated1HandCard59";

                } else if (card.name == "instantiated1Card59a(Clone)") {

                    card.name = "instantiated1HandCard59a";

                } else if (card.name == "instantiated1Card59b(Clone)") {

                    card.name = "instantiated1HandCard59b";

                } else if (card.name == "instantiated1Card59c(Clone)") {

                    card.name = "instantiated1HandCard59c";

                } else if (card.name == "instantiated1Card60(Clone)") {

                    card.name = "instantiated1HandCard60";

                } else if (card.name == "instantiated1Card60a(Clone)") {

                    card.name = "instantiated1HandCard60a";

                } else if (card.name == "instantiated1Card60b(Clone)") {

                    card.name = "instantiated1HandCard60b";

                } else if (card.name == "instantiated1Card60c(Clone)") {

                    card.name = "instantiated1HandCard60c";
                }

                instances7++;

            }

            while (instances8 < NumberOfCards) {

                GameObject card = Instantiate(playCardsDeck1[UnityEngine.Random.Range(0, playCardsDeck1.Count)], player1DeckSlot8.transform.position, player1DeckSlot8.transform.rotation) as GameObject;
                card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                card.transform.parent = player1DeckSlot8.transform;

                if (card.name == "instantiated1Card1(Clone)") {

                    card.name = "instantiated1HandCard1";

                } else if (card.name == "instantiated1Card1a(Clone)") {

                    card.name = "instantiated1HandCard1a";

                } else if (card.name == "instantiated1Card1b(Clone)") {

                    card.name = "instantiated1HandCard1b";

                } else if (card.name == "instantiated1Card1c(Clone)") {

                    card.name = "instantiated1HandCard1c";

                } else if (card.name == "instantiated1Card2(Clone)") {

                    card.name = "instantiated1HandCard2";

                } else if (card.name == "instantiated1Card2a(Clone)") {

                    card.name = "instantiated1HandCard2a";

                } else if (card.name == "instantiated1Card2b(Clone)") {

                    card.name = "instantiated1HandCard2b";

                } else if (card.name == "instantiated1Card2c(Clone)") {

                    card.name = "instantiated1HandCard2c";

                } else if (card.name == "instantiated1Card3(Clone)") {

                    card.name = "instantiated1HandCard3";

                } else if (card.name == "instantiated1Card3a(Clone)") {

                    card.name = "instantiated1HandCard3a";

                } else if (card.name == "instantiated1Card3b(Clone)") {

                    card.name = "instantiated1HandCard3b";

                } else if (card.name == "instantiated1Card3c(Clone)") {

                    card.name = "instantiated1HandCard3c";

                } else if (card.name == "instantiated1Card4(Clone)") {

                    card.name = "instantiated1HandCard4";

                } else if (card.name == "instantiated1Card4a(Clone)") {

                    card.name = "instantiated1HandCard4a";

                } else if (card.name == "instantiated1Card4b(Clone)") {

                    card.name = "instantiated1HandCard4b";

                } else if (card.name == "instantiated1Card4c(Clone)") {

                    card.name = "instantiated1HandCard4c";

                } else if (card.name == "instantiated1Card5(Clone)") {

                    card.name = "instantiated1HandCard5";

                } else if (card.name == "instantiated1Card5a(Clone)") {

                    card.name = "instantiated1HandCard5a";

                } else if (card.name == "instantiated1Card5b(Clone)") {

                    card.name = "instantiated1HandCard5b";

                } else if (card.name == "instantiated1Card5c(Clone)") {

                    card.name = "instantiated1HandCard5c";

                } else if (card.name == "instantiated1Card6(Clone)") {

                    card.name = "instantiated1HandCard6";

                } else if (card.name == "instantiated1Card6a(Clone)") {

                    card.name = "instantiated1HandCard6a";

                } else if (card.name == "instantiated1Card6b(Clone)") {

                    card.name = "instantiated1HandCard6b";

                } else if (card.name == "instantiated1Card6c(Clone)") {

                    card.name = "instantiated1HandCard6c";

                } else if (card.name == "instantiated1Card7(Clone)") {

                    card.name = "instantiated1HandCard7";

                } else if (card.name == "instantiated1Card7a(Clone)") {

                    card.name = "instantiated1HandCard7a";

                } else if (card.name == "instantiated1Card7b(Clone)") {

                    card.name = "instantiated1HandCard7b";

                } else if (card.name == "instantiated1Card7c(Clone)") {

                    card.name = "instantiated1HandCard7c";

                } else if (card.name == "instantiated1Card8(Clone)") {

                    card.name = "instantiated1HandCard8";

                } else if (card.name == "instantiated1Card8a(Clone)") {

                    card.name = "instantiated1HandCard8a";

                } else if (card.name == "instantiated1Card8b(Clone)") {

                    card.name = "instantiated1HandCard8b";

                } else if (card.name == "instantiated1Card8c(Clone)") {

                    card.name = "instantiated1HandCard8c";

                } else if (card.name == "instantiated1Card9(Clone)") {

                    card.name = "instantiated1HandCard9";

                } else if (card.name == "instantiated1Card9a(Clone)") {

                    card.name = "instantiated1HandCard9a";

                } else if (card.name == "instantiated1Card9b(Clone)") {

                    card.name = "instantiated1HandCard9b";

                } else if (card.name == "instantiated1Card9c(Clone)") {

                    card.name = "instantiated1HandCard9c";

                } else if (card.name == "instantiated1Card10(Clone)") {

                    card.name = "instantiatedAICard10";

                } else if (card.name == "instantiated1Card10a(Clone)") {

                    card.name = "instantiated1HandCard10a";

                } else if (card.name == "instantiated1Card10b(Clone)") {

                    card.name = "instantiated1HandCard10b";

                } else if (card.name == "instantiated1Card10c(Clone)") {

                    card.name = "instantiated1HandCard10c";

                } else if (card.name == "instantiated1Card11(Clone)") {

                    card.name = "instantiated1HandCard11";

                } else if (card.name == "instantiated1Card11a(Clone)") {

                    card.name = "instantiated1HandCard11a";

                } else if (card.name == "instantiated1Card11b(Clone)") {

                    card.name = "instantiated1HandCard11b";

                } else if (card.name == "instantiated1Card11c(Clone)") {

                    card.name = "instantiated1HandCard11c";

                } else if (card.name == "instantiated1Card12(Clone)") {

                    card.name = "instantiated1HandCard12";

                } else if (card.name == "instantiated1Card12a(Clone)") {

                    card.name = "instantiated1HandCard12a";

                } else if (card.name == "instantiated1Card12b(Clone)") {

                    card.name = "instantiated1HandCard12b";

                } else if (card.name == "instantiated1Card12c(Clone)") {

                    card.name = "instantiated1HandCard12c";

                } else if (card.name == "instantiated1Card13(Clone)") {

                    card.name = "instantiated1HandCard13";

                } else if (card.name == "instantiated1Card13a(Clone)") {

                    card.name = "instantiated1HandCard13a";

                } else if (card.name == "instantiated1Card13b(Clone)") {

                    card.name = "instantiated1HandCard13b";

                } else if (card.name == "instantiated1Card13c(Clone)") {

                    card.name = "instantiated1HandCard13c";

                } else if (card.name == "instantiated1Card14(Clone)") {

                    card.name = "instantiated1HandCard14";

                } else if (card.name == "instantiated1Card14a(Clone)") {

                    card.name = "instantiated1HandCard14a";

                } else if (card.name == "instantiated1Card14b(Clone)") {

                    card.name = "instantiated1HandCard14b";

                } else if (card.name == "instantiated1Card14c(Clone)") {

                    card.name = "instantiated1HandCard14c";

                } else if (card.name == "instantiated1Card15(Clone)") {

                    card.name = "instantiated1HandCard15";

                } else if (card.name == "instantiated1Card15a(Clone)") {

                    card.name = "instantiated1HandCard15a";

                } else if (card.name == "instantiated1Card15b(Clone)") {

                    card.name = "instantiated1HandCard15b";

                } else if (card.name == "instantiated1Card15c(Clone)") {

                    card.name = "instantiated1HandCard15c";

                } else if (card.name == "instantiated1Card16(Clone)") {

                    card.name = "instantiated1HandCard16";

                } else if (card.name == "instantiated1Card16a(Clone)") {

                    card.name = "instantiated1HandCard16a";

                } else if (card.name == "instantiated1Card16b(Clone)") {

                    card.name = "instantiated1HandCard16b";

                } else if (card.name == "instantiated1Card16c(Clone)") {

                    card.name = "instantiated1HandCard16c";

                } else if (card.name == "instantiated1Card17(Clone)") {

                    card.name = "instantiated1HandCard17";

                } else if (card.name == "instantiated1Card17a(Clone)") {

                    card.name = "instantiated1HandCard17a";

                } else if (card.name == "instantiated1Card17b(Clone)") {

                    card.name = "instantiated1HandCard17b";

                } else if (card.name == "instantiated1Card17c(Clone)") {

                    card.name = "instantiated1HandCard17c";

                } else if (card.name == "instantiated1Card18(Clone)") {

                    card.name = "instantiated1HandCard18";

                } else if (card.name == "instantiated1Card18a(Clone)") {

                    card.name = "instantiated1HandCard18a";

                } else if (card.name == "instantiated1Card18b(Clone)") {

                    card.name = "instantiated1HandCard18b";

                } else if (card.name == "instantiated1Card18c(Clone)") {

                    card.name = "instantiated1HandCard18c";

                } else if (card.name == "instantiated1Card19(Clone)") {

                    card.name = "instantiated1HandCard19";

                } else if (card.name == "instantiated1Card19a(Clone)") {

                    card.name = "instantiated1HandCard19a";

                } else if (card.name == "instantiated1Card19b(Clone)") {

                    card.name = "instantiated1HandCard19b";

                } else if (card.name == "instantiated1Card19c(Clone)") {

                    card.name = "instantiated1HandCard19c";

                } else if (card.name == "instantiated1Card20(Clone)") {

                    card.name = "instantiated1HandCard20";

                } else if (card.name == "instantiated1Card20a(Clone)") {

                    card.name = "instantiated1HandCard20a";

                } else if (card.name == "instantiated1Card20b(Clone)") {

                    card.name = "instantiated1HandCard20b";

                } else if (card.name == "instantiated1Card20c(Clone)") {

                    card.name = "instantiated1HandCard20c";

                } else if (card.name == "instantiated1Card21(Clone)") {

                    card.name = "instantiated1HandCard21";

                } else if (card.name == "instantiated1Card21a(Clone)") {

                    card.name = "instantiated1HandCard21a";

                } else if (card.name == "instantiated1Card21b(Clone)") {

                    card.name = "instantiated1HandCard21b";

                } else if (card.name == "instantiated1Card21c(Clone)") {

                    card.name = "instantiated1HandCard21c";

                } else if (card.name == "instantiated1Card22(Clone)") {

                    card.name = "instantiated1HandCard22";

                } else if (card.name == "instantiated1Card22a(Clone)") {

                    card.name = "instantiated1HandCard22a";

                } else if (card.name == "instantiated1Card22b(Clone)") {

                    card.name = "instantiated1HandCard22b";

                } else if (card.name == "instantiated1Card22c(Clone)") {

                    card.name = "instantiated1HandCard22c";

                } else if (card.name == "instantiated1Card23(Clone)") {

                    card.name = "instantiated1HandCard23";

                } else if (card.name == "instantiated1Card23a(Clone)") {

                    card.name = "instantiated1HandCard23a";

                } else if (card.name == "instantiated1Card23b(Clone)") {

                    card.name = "instantiated1HandCard23b";

                } else if (card.name == "instantiated1Card23c(Clone)") {

                    card.name = "instantiated1HandCard23c";

                } else if (card.name == "instantiated1Card24(Clone)") {

                    card.name = "instantiated1HandCard24";

                } else if (card.name == "instantiated1Card24a(Clone)") {

                    card.name = "instantiated1HandCard24a";

                } else if (card.name == "instantiated1Card24b(Clone)") {

                    card.name = "instantiated1HandCard24b";

                } else if (card.name == "instantiated1Card24c(Clone)") {

                    card.name = "instantiated1HandCard24c";

                } else if (card.name == "instantiated1Card25(Clone)") {

                    card.name = "instantiated1HandCard25";

                } else if (card.name == "instantiated1Card25a(Clone)") {

                    card.name = "instantiated1HandCard25a";

                } else if (card.name == "instantiated1Card25b(Clone)") {

                    card.name = "instantiated1HandCard25b";

                } else if (card.name == "instantiated1Card25c(Clone)") {

                    card.name = "instantiated1HandCard25c";

                } else if (card.name == "instantiated1Card26(Clone)") {

                    card.name = "instantiated1HandCard26";

                } else if (card.name == "instantiated1Card26a(Clone)") {

                    card.name = "instantiated1HandCard26a";

                } else if (card.name == "instantiated1Card26b(Clone)") {

                    card.name = "instantiated1HandCard26b";

                } else if (card.name == "instantiated1Card26c(Clone)") {

                    card.name = "instantiated1HandCard26c";

                } else if (card.name == "instantiated1Card27(Clone)") {

                    card.name = "instantiated1HandCard27";

                } else if (card.name == "instantiated1Card27a(Clone)") {

                    card.name = "instantiated1HandCard27a";

                } else if (card.name == "instantiated1Card27b(Clone)") {

                    card.name = "instantiated1HandCard27b";

                } else if (card.name == "instantiated1Card27c(Clone)") {

                    card.name = "instantiated1HandCard27c";

                } else if (card.name == "instantiated1Card28(Clone)") {

                    card.name = "instantiated1HandCard28";

                } else if (card.name == "instantiated1Card28a(Clone)") {

                    card.name = "instantiated1HandCard28a";

                } else if (card.name == "instantiated1Card28b(Clone)") {

                    card.name = "instantiated1HandCard28b";

                } else if (card.name == "instantiated1Card28c(Clone)") {

                    card.name = "instantiated1HandCard28c";

                } else if (card.name == "instantiated1Card29(Clone)") {

                    card.name = "instantiated1HandCard29";

                } else if (card.name == "instantiated1Card29a(Clone)") {

                    card.name = "instantiated1HandCard29a";

                } else if (card.name == "instantiated1Card29b(Clone)") {

                    card.name = "instantiated1HandCard29b";

                } else if (card.name == "instantiated1Card29c(Clone)") {

                    card.name = "instantiated1HandCard29c";

                } else if (card.name == "instantiated1Card30(Clone)") {

                    card.name = "instantiated1HandCard30";

                } else if (card.name == "instantiated1Card30a(Clone)") {

                    card.name = "instantiated1HandCard30a";

                } else if (card.name == "instantiated1Card30b(Clone)") {

                    card.name = "instantiated1HandCard30b";

                } else if (card.name == "instantiated1Card30c(Clone)") {

                    card.name = "instantiated1HandCard30c";

                } else if (card.name == "instantiated1Card31(Clone)") {

                    card.name = "instantiated1HandCard31";

                } else if (card.name == "instantiated1Card31a(Clone)") {

                    card.name = "instantiated1HandCard31a";

                } else if (card.name == "instantiated1Card31b(Clone)") {

                    card.name = "instantiated1HandCard31b";

                } else if (card.name == "instantiated1Card31c(Clone)") {

                    card.name = "instantiated1HandCard31c";

                } else if (card.name == "instantiated1Card32(Clone)") {

                    card.name = "instantiated1HandCard32";

                } else if (card.name == "instantiated1Card32a(Clone)") {

                    card.name = "instantiated1HandCard32a";

                } else if (card.name == "instantiated1Card32b(Clone)") {

                    card.name = "instantiated1HandCard32b";

                } else if (card.name == "instantiated1Card32c(Clone)") {

                    card.name = "instantiated1HandCard32c";

                } else if (card.name == "instantiated1Card33(Clone)") {

                    card.name = "instantiated1HandCard33";

                } else if (card.name == "instantiated1Card33a(Clone)") {

                    card.name = "instantiated1HandCard33a";

                } else if (card.name == "instantiated1Card33b(Clone)") {

                    card.name = "instantiated1HandCard33b";

                } else if (card.name == "instantiated1Card33c(Clone)") {

                    card.name = "instantiated1HandCard33c";

                } else if (card.name == "instantiated1Card34(Clone)") {

                    card.name = "instantiated1HandCard34";

                } else if (card.name == "instantiated1Card34a(Clone)") {

                    card.name = "instantiated1HandCard34a";

                } else if (card.name == "instantiated1Card34b(Clone)") {

                    card.name = "instantiated1HandCard34b";

                } else if (card.name == "instantiated1Card34c(Clone)") {

                    card.name = "instantiated1HandCard34c";

                } else if (card.name == "instantiated1Card35(Clone)") {

                    card.name = "instantiated1HandCard35";

                } else if (card.name == "instantiated1Card35a(Clone)") {

                    card.name = "instantiated1HandCard35a";

                } else if (card.name == "instantiated1Card35b(Clone)") {

                    card.name = "instantiated1HandCard35b";

                } else if (card.name == "instantiated1Card35c(Clone)") {

                    card.name = "instantiated1HandCard35c";

                } else if (card.name == "instantiated1Card36(Clone)") {

                    card.name = "instantiated1HandCard36";

                } else if (card.name == "instantiated1Card36a(Clone)") {

                    card.name = "instantiated1HandCard36a";

                } else if (card.name == "instantiated1Card36b(Clone)") {

                    card.name = "instantiated1HandCard36b";

                } else if (card.name == "instantiated1Card36c(Clone)") {

                    card.name = "instantiated1HandCard36c";

                } else if (card.name == "instantiated1Card37(Clone)") {

                    card.name = "instantiated1HandCard37";

                } else if (card.name == "instantiated1Card37a(Clone)") {

                    card.name = "instantiated1HandCard37a";

                } else if (card.name == "instantiated1Card37b(Clone)") {

                    card.name = "instantiated1HandCard37b";

                } else if (card.name == "instantiated1Card37c(Clone)") {

                    card.name = "instantiated1HandCard37c";

                } else if (card.name == "instantiated1Card38(Clone)") {

                    card.name = "instantiated1HandCard38";

                } else if (card.name == "instantiated1Card38a(Clone)") {

                    card.name = "instantiated1HandCard38a";

                } else if (card.name == "instantiated1Card38b(Clone)") {

                    card.name = "instantiated1HandCard38b";

                } else if (card.name == "instantiated1Card38c(Clone)") {

                    card.name = "instantiated1HandCard38c";

                } else if (card.name == "instantiated1Card39(Clone)") {

                    card.name = "instantiated1HandCard39";

                } else if (card.name == "instantiated1Card39a(Clone)") {

                    card.name = "instantiated1HandCard39a";

                } else if (card.name == "instantiated1Card39b(Clone)") {

                    card.name = "instantiated1HandCard39b";

                } else if (card.name == "instantiated1Card39c(Clone)") {

                    card.name = "instantiated1HandCard39c";

                } else if (card.name == "instantiated1Card40(Clone)") {

                    card.name = "instantiated1HandCard40";

                } else if (card.name == "instantiated1Card40a(Clone)") {

                    card.name = "instantiated1HandCard40a";

                } else if (card.name == "instantiated1Card40b(Clone)") {

                    card.name = "instantiated1HandCard40b";

                } else if (card.name == "instantiated1Card40c(Clone)") {

                    card.name = "instantiated1HandCard40c";

                } else if (card.name == "instantiated1Card41(Clone)") {

                    card.name = "instantiated1HandCard41";

                } else if (card.name == "instantiated1Card41a(Clone)") {

                    card.name = "instantiated1HandCard41a";

                } else if (card.name == "instantiated1Card41b(Clone)") {

                    card.name = "instantiated1HandCard41b";

                } else if (card.name == "instantiated1Card41c(Clone)") {

                    card.name = "instantiated1HandCard41c";

                } else if (card.name == "instantiated1Card42(Clone)") {

                    card.name = "instantiated1HandCard42";

                } else if (card.name == "instantiated1Card42a(Clone)") {

                    card.name = "instantiated1HandCard42a";

                } else if (card.name == "instantiated1Card42b(Clone)") {

                    card.name = "instantiated1HandCard42b";

                } else if (card.name == "instantiated1Card42c(Clone)") {

                    card.name = "instantiated1HandCard42c";

                } else if (card.name == "instantiated1Card43(Clone)") {

                    card.name = "instantiated1HandCard43";

                } else if (card.name == "instantiated1Card43a(Clone)") {

                    card.name = "instantiated1HandCard43a";

                } else if (card.name == "instantiated1Card43b(Clone)") {

                    card.name = "instantiated1HandCard43b";

                } else if (card.name == "instantiated1Card43c(Clone)") {

                    card.name = "instantiated1HandCard43c";

                } else if (card.name == "instantiated1Card44(Clone)") {

                    card.name = "instantiated1HandCard44";

                } else if (card.name == "instantiated1Card44a(Clone)") {

                    card.name = "instantiated1HandCard44a";

                } else if (card.name == "instantiated1Card44b(Clone)") {

                    card.name = "instantiated1HandCard44b";

                } else if (card.name == "instantiated1Card44c(Clone)") {

                    card.name = "instantiated1HandCard44c";

                } else if (card.name == "instantiated1Card45(Clone)") {

                    card.name = "instantiated1HandCard45";

                } else if (card.name == "instantiated1Card45a(Clone)") {

                    card.name = "instantiated1HandCard45a";

                } else if (card.name == "instantiated1Card45b(Clone)") {

                    card.name = "instantiated1HandCard45b";

                } else if (card.name == "instantiated1Card45c(Clone)") {

                    card.name = "instantiated1HandCard45c";

                } else if (card.name == "instantiated1Card46(Clone)") {

                    card.name = "instantiated1HandCard46";

                } else if (card.name == "instantiated1Card46a(Clone)") {

                    card.name = "instantiated1HandCard46a";

                } else if (card.name == "instantiated1Card46b(Clone)") {

                    card.name = "instantiated1HandCard46b";

                } else if (card.name == "instantiated1Card46c(Clone)") {

                    card.name = "instantiated1HandCard46c";

                } else if (card.name == "instantiated1Card47(Clone)") {

                    card.name = "instantiated1HandCard47";

                } else if (card.name == "instantiated1Card47a(Clone)") {

                    card.name = "instantiated1HandCard47a";

                } else if (card.name == "instantiated1Card47b(Clone)") {

                    card.name = "instantiated1HandCard47b";

                } else if (card.name == "instantiated1Card47c(Clone)") {

                    card.name = "instantiated1HandCard47c";

                } else if (card.name == "instantiated1Card48(Clone)") {

                    card.name = "instantiated1HandCard48";

                } else if (card.name == "instantiated1Card48a(Clone)") {

                    card.name = "instantiated1HandCard48a";

                } else if (card.name == "instantiated1Card48b(Clone)") {

                    card.name = "instantiated1HandCard48b";

                } else if (card.name == "instantiated1Card48c(Clone)") {

                    card.name = "instantiated1HandCard48c";

                } else if (card.name == "instantiated1Card49(Clone)") {

                    card.name = "instantiated1HandCard49";

                } else if (card.name == "instantiated1Card49a(Clone)") {

                    card.name = "instantiated1HandCard49a";

                } else if (card.name == "instantiated1Card49b(Clone)") {

                    card.name = "instantiated1HandCard49b";

                } else if (card.name == "instantiated1Card49c(Clone)") {

                    card.name = "instantiated1HandCard49c";

                } else if (card.name == "instantiated1Card50(Clone)") {

                    card.name = "instantiated1HandCard50";

                } else if (card.name == "instantiated1Card50a(Clone)") {

                    card.name = "instantiated1HandCard50a";

                } else if (card.name == "instantiated1Card50b(Clone)") {

                    card.name = "instantiated1HandCard50b";

                } else if (card.name == "instantiated1Card50c(Clone)") {

                    card.name = "instantiated1HandCard50c";

                } else if (card.name == "instantiated1Card51(Clone)") {

                    card.name = "instantiated1HandCard51";

                } else if (card.name == "instantiated1Card51a(Clone)") {

                    card.name = "instantiated1HandCard51a";

                } else if (card.name == "instantiated1Card51b(Clone)") {

                    card.name = "instantiated1HandCard51b";

                } else if (card.name == "instantiated1Card51c(Clone)") {

                    card.name = "instantiated1HandCard51c";

                } else if (card.name == "instantiated1Card52(Clone)") {

                    card.name = "instantiated1HandCard52";

                } else if (card.name == "instantiated1Card52a(Clone)") {

                    card.name = "instantiated1HandCard52a";

                } else if (card.name == "instantiated1Card52b(Clone)") {

                    card.name = "instantiated1HandCard52b";

                } else if (card.name == "instantiated1Card52c(Clone)") {

                    card.name = "instantiated1HandCard52c";

                } else if (card.name == "instantiated1Card53(Clone)") {

                    card.name = "instantiated1HandCard53";

                } else if (card.name == "instantiated1Card53a(Clone)") {

                    card.name = "instantiated1HandCard53a";

                } else if (card.name == "instantiated1Card53b(Clone)") {

                    card.name = "instantiated1HandCard53b";

                } else if (card.name == "instantiated1Card53c(Clone)") {

                    card.name = "instantiated1HandCard53c";

                } else if (card.name == "instantiated1Card54(Clone)") {

                    card.name = "instantiated1HandCard54";

                } else if (card.name == "instantiated1Card54a(Clone)") {

                    card.name = "instantiated1HandCard54a";

                } else if (card.name == "instantiated1Card54b(Clone)") {

                    card.name = "instantiated1HandCard54b";

                } else if (card.name == "instantiated1Card54c(Clone)") {

                    card.name = "instantiated1HandCard54c";

                } else if (card.name == "instantiated1Card55(Clone)") {

                    card.name = "instantiated1HandCard55";

                } else if (card.name == "instantiated1Card55a(Clone)") {

                    card.name = "instantiated1HandCard55a";

                } else if (card.name == "instantiated1Card55b(Clone)") {

                    card.name = "instantiated1HandCard55b";

                } else if (card.name == "instantiated1Card55c(Clone)") {

                    card.name = "instantiated1HandCard55c";

                } else if (card.name == "instantiated1Card56(Clone)") {

                    card.name = "instantiated1HandCard56";

                } else if (card.name == "instantiated1Card56a(Clone)") {

                    card.name = "instantiated1HandCard56a";

                } else if (card.name == "instantiated1Card56b(Clone)") {

                    card.name = "instantiated1HandCard56b";

                } else if (card.name == "instantiated1Card56c(Clone)") {

                    card.name = "instantiated1HandCard56c";

                } else if (card.name == "instantiated1Card57(Clone)") {

                    card.name = "instantiated1HandCard57";

                } else if (card.name == "instantiated1Card57a(Clone)") {

                    card.name = "instantiated1HandCard57a";

                } else if (card.name == "instantiated1Card57b(Clone)") {

                    card.name = "instantiated1HandCard57b";

                } else if (card.name == "instantiated1Card57c(Clone)") {

                    card.name = "instantiated1HandCard57c";

                } else if (card.name == "instantiated1Card58(Clone)") {

                    card.name = "instantiated1HandCard58";

                } else if (card.name == "instantiated1Card58a(Clone)") {

                    card.name = "instantiated1HandCard58a";

                } else if (card.name == "instantiated1Card58b(Clone)") {

                    card.name = "instantiated1HandCard58b";

                } else if (card.name == "instantiated1Card58c(Clone)") {

                    card.name = "instantiated1HandCard58c";

                } else if (card.name == "instantiated1Card59(Clone)") {

                    card.name = "instantiated1HandCard59";

                } else if (card.name == "instantiated1Card59a(Clone)") {

                    card.name = "instantiated1HandCard59a";

                } else if (card.name == "instantiated1Card59b(Clone)") {

                    card.name = "instantiated1HandCard59b";

                } else if (card.name == "instantiated1Card59c(Clone)") {

                    card.name = "instantiated1HandCard59c";

                } else if (card.name == "instantiated1Card60(Clone)") {

                    card.name = "instantiated1HandCard60";

                } else if (card.name == "instantiated1Card60a(Clone)") {

                    card.name = "instantiated1HandCard60a";

                } else if (card.name == "instantiated1Card60b(Clone)") {

                    card.name = "instantiated1HandCard60b";

                } else if (card.name == "instantiated1Card60c(Clone)") {

                    card.name = "instantiated1HandCard60c";
                }

                instances8++;

            }

            while (instances9 < NumberOfCards) {

                GameObject card = Instantiate(playCardsDeck1[UnityEngine.Random.Range(0, playCardsDeck1.Count)], player1DeckSlot9.transform.position, player1DeckSlot9.transform.rotation) as GameObject;
                card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                card.transform.parent = player1DeckSlot9.transform;

                if (card.name == "instantiated1Card1(Clone)") {

                    card.name = "instantiated1HandCard1";

                } else if (card.name == "instantiated1Card1a(Clone)") {

                    card.name = "instantiated1HandCard1a";

                } else if (card.name == "instantiated1Card1b(Clone)") {

                    card.name = "instantiated1HandCard1b";

                } else if (card.name == "instantiated1Card1c(Clone)") {

                    card.name = "instantiated1HandCard1c";

                } else if (card.name == "instantiated1Card2(Clone)") {

                    card.name = "instantiated1HandCard2";

                } else if (card.name == "instantiated1Card2a(Clone)") {

                    card.name = "instantiated1HandCard2a";

                } else if (card.name == "instantiated1Card2b(Clone)") {

                    card.name = "instantiated1HandCard2b";

                } else if (card.name == "instantiated1Card2c(Clone)") {

                    card.name = "instantiated1HandCard2c";

                } else if (card.name == "instantiated1Card3(Clone)") {

                    card.name = "instantiated1HandCard3";

                } else if (card.name == "instantiated1Card3a(Clone)") {

                    card.name = "instantiated1HandCard3a";

                } else if (card.name == "instantiated1Card3b(Clone)") {

                    card.name = "instantiated1HandCard3b";

                } else if (card.name == "instantiated1Card3c(Clone)") {

                    card.name = "instantiated1HandCard3c";

                } else if (card.name == "instantiated1Card4(Clone)") {

                    card.name = "instantiated1HandCard4";

                } else if (card.name == "instantiated1Card4a(Clone)") {

                    card.name = "instantiated1HandCard4a";

                } else if (card.name == "instantiated1Card4b(Clone)") {

                    card.name = "instantiated1HandCard4b";

                } else if (card.name == "instantiated1Card4c(Clone)") {

                    card.name = "instantiated1HandCard4c";

                } else if (card.name == "instantiated1Card5(Clone)") {

                    card.name = "instantiated1HandCard5";

                } else if (card.name == "instantiated1Card5a(Clone)") {

                    card.name = "instantiated1HandCard5a";

                } else if (card.name == "instantiated1Card5b(Clone)") {

                    card.name = "instantiated1HandCard5b";

                } else if (card.name == "instantiated1Card5c(Clone)") {

                    card.name = "instantiated1HandCard5c";

                } else if (card.name == "instantiated1Card6(Clone)") {

                    card.name = "instantiated1HandCard6";

                } else if (card.name == "instantiated1Card6a(Clone)") {

                    card.name = "instantiated1HandCard6a";

                } else if (card.name == "instantiated1Card6b(Clone)") {

                    card.name = "instantiated1HandCard6b";

                } else if (card.name == "instantiated1Card6c(Clone)") {

                    card.name = "instantiated1HandCard6c";

                } else if (card.name == "instantiated1Card7(Clone)") {

                    card.name = "instantiated1HandCard7";

                } else if (card.name == "instantiated1Card7a(Clone)") {

                    card.name = "instantiated1HandCard7a";

                } else if (card.name == "instantiated1Card7b(Clone)") {

                    card.name = "instantiated1HandCard7b";

                } else if (card.name == "instantiated1Card7c(Clone)") {

                    card.name = "instantiated1HandCard7c";

                } else if (card.name == "instantiated1Card8(Clone)") {

                    card.name = "instantiated1HandCard8";

                } else if (card.name == "instantiated1Card8a(Clone)") {

                    card.name = "instantiated1HandCard8a";

                } else if (card.name == "instantiated1Card8b(Clone)") {

                    card.name = "instantiated1HandCard8b";

                } else if (card.name == "instantiated1Card8c(Clone)") {

                    card.name = "instantiated1HandCard8c";

                } else if (card.name == "instantiated1Card9(Clone)") {

                    card.name = "instantiated1HandCard9";

                } else if (card.name == "instantiated1Card9a(Clone)") {

                    card.name = "instantiated1HandCard9a";

                } else if (card.name == "instantiated1Card9b(Clone)") {

                    card.name = "instantiated1HandCard9b";

                } else if (card.name == "instantiated1Card9c(Clone)") {

                    card.name = "instantiated1HandCard9c";

                } else if (card.name == "instantiated1Card10(Clone)") {

                    card.name = "instantiatedAICard10";

                } else if (card.name == "instantiated1Card10a(Clone)") {

                    card.name = "instantiated1HandCard10a";

                } else if (card.name == "instantiated1Card10b(Clone)") {

                    card.name = "instantiated1HandCard10b";

                } else if (card.name == "instantiated1Card10c(Clone)") {

                    card.name = "instantiated1HandCard10c";

                } else if (card.name == "instantiated1Card11(Clone)") {

                    card.name = "instantiated1HandCard11";

                } else if (card.name == "instantiated1Card11a(Clone)") {

                    card.name = "instantiated1HandCard11a";

                } else if (card.name == "instantiated1Card11b(Clone)") {

                    card.name = "instantiated1HandCard11b";

                } else if (card.name == "instantiated1Card11c(Clone)") {

                    card.name = "instantiated1HandCard11c";

                } else if (card.name == "instantiated1Card12(Clone)") {

                    card.name = "instantiated1HandCard12";

                } else if (card.name == "instantiated1Card12a(Clone)") {

                    card.name = "instantiated1HandCard12a";

                } else if (card.name == "instantiated1Card12b(Clone)") {

                    card.name = "instantiated1HandCard12b";

                } else if (card.name == "instantiated1Card12c(Clone)") {

                    card.name = "instantiated1HandCard12c";

                } else if (card.name == "instantiated1Card13(Clone)") {

                    card.name = "instantiated1HandCard13";

                } else if (card.name == "instantiated1Card13a(Clone)") {

                    card.name = "instantiated1HandCard13a";

                } else if (card.name == "instantiated1Card13b(Clone)") {

                    card.name = "instantiated1HandCard13b";

                } else if (card.name == "instantiated1Card13c(Clone)") {

                    card.name = "instantiated1HandCard13c";

                } else if (card.name == "instantiated1Card14(Clone)") {

                    card.name = "instantiated1HandCard14";

                } else if (card.name == "instantiated1Card14a(Clone)") {

                    card.name = "instantiated1HandCard14a";

                } else if (card.name == "instantiated1Card14b(Clone)") {

                    card.name = "instantiated1HandCard14b";

                } else if (card.name == "instantiated1Card14c(Clone)") {

                    card.name = "instantiated1HandCard14c";

                } else if (card.name == "instantiated1Card15(Clone)") {

                    card.name = "instantiated1HandCard15";

                } else if (card.name == "instantiated1Card15a(Clone)") {

                    card.name = "instantiated1HandCard15a";

                } else if (card.name == "instantiated1Card15b(Clone)") {

                    card.name = "instantiated1HandCard15b";

                } else if (card.name == "instantiated1Card15c(Clone)") {

                    card.name = "instantiated1HandCard15c";

                } else if (card.name == "instantiated1Card16(Clone)") {

                    card.name = "instantiated1HandCard16";

                } else if (card.name == "instantiated1Card16a(Clone)") {

                    card.name = "instantiated1HandCard16a";

                } else if (card.name == "instantiated1Card16b(Clone)") {

                    card.name = "instantiated1HandCard16b";

                } else if (card.name == "instantiated1Card16c(Clone)") {

                    card.name = "instantiated1HandCard16c";

                } else if (card.name == "instantiated1Card17(Clone)") {

                    card.name = "instantiated1HandCard17";

                } else if (card.name == "instantiated1Card17a(Clone)") {

                    card.name = "instantiated1HandCard17a";

                } else if (card.name == "instantiated1Card17b(Clone)") {

                    card.name = "instantiated1HandCard17b";

                } else if (card.name == "instantiated1Card17c(Clone)") {

                    card.name = "instantiated1HandCard17c";

                } else if (card.name == "instantiated1Card18(Clone)") {

                    card.name = "instantiated1HandCard18";

                } else if (card.name == "instantiated1Card18a(Clone)") {

                    card.name = "instantiated1HandCard18a";

                } else if (card.name == "instantiated1Card18b(Clone)") {

                    card.name = "instantiated1HandCard18b";

                } else if (card.name == "instantiated1Card18c(Clone)") {

                    card.name = "instantiated1HandCard18c";

                } else if (card.name == "instantiated1Card19(Clone)") {

                    card.name = "instantiated1HandCard19";

                } else if (card.name == "instantiated1Card19a(Clone)") {

                    card.name = "instantiated1HandCard19a";

                } else if (card.name == "instantiated1Card19b(Clone)") {

                    card.name = "instantiated1HandCard19b";

                } else if (card.name == "instantiated1Card19c(Clone)") {

                    card.name = "instantiated1HandCard19c";

                } else if (card.name == "instantiated1Card20(Clone)") {

                    card.name = "instantiated1HandCard20";

                } else if (card.name == "instantiated1Card20a(Clone)") {

                    card.name = "instantiated1HandCard20a";

                } else if (card.name == "instantiated1Card20b(Clone)") {

                    card.name = "instantiated1HandCard20b";

                } else if (card.name == "instantiated1Card20c(Clone)") {

                    card.name = "instantiated1HandCard20c";

                } else if (card.name == "instantiated1Card21(Clone)") {

                    card.name = "instantiated1HandCard21";

                } else if (card.name == "instantiated1Card21a(Clone)") {

                    card.name = "instantiated1HandCard21a";

                } else if (card.name == "instantiated1Card21b(Clone)") {

                    card.name = "instantiated1HandCard21b";

                } else if (card.name == "instantiated1Card21c(Clone)") {

                    card.name = "instantiated1HandCard21c";

                } else if (card.name == "instantiated1Card22(Clone)") {

                    card.name = "instantiated1HandCard22";

                } else if (card.name == "instantiated1Card22a(Clone)") {

                    card.name = "instantiated1HandCard22a";

                } else if (card.name == "instantiated1Card22b(Clone)") {

                    card.name = "instantiated1HandCard22b";

                } else if (card.name == "instantiated1Card22c(Clone)") {

                    card.name = "instantiated1HandCard22c";

                } else if (card.name == "instantiated1Card23(Clone)") {

                    card.name = "instantiated1HandCard23";

                } else if (card.name == "instantiated1Card23a(Clone)") {

                    card.name = "instantiated1HandCard23a";

                } else if (card.name == "instantiated1Card23b(Clone)") {

                    card.name = "instantiated1HandCard23b";

                } else if (card.name == "instantiated1Card23c(Clone)") {

                    card.name = "instantiated1HandCard23c";

                } else if (card.name == "instantiated1Card24(Clone)") {

                    card.name = "instantiated1HandCard24";

                } else if (card.name == "instantiated1Card24a(Clone)") {

                    card.name = "instantiated1HandCard24a";

                } else if (card.name == "instantiated1Card24b(Clone)") {

                    card.name = "instantiated1HandCard24b";

                } else if (card.name == "instantiated1Card24c(Clone)") {

                    card.name = "instantiated1HandCard24c";

                } else if (card.name == "instantiated1Card25(Clone)") {

                    card.name = "instantiated1HandCard25";

                } else if (card.name == "instantiated1Card25a(Clone)") {

                    card.name = "instantiated1HandCard25a";

                } else if (card.name == "instantiated1Card25b(Clone)") {

                    card.name = "instantiated1HandCard25b";

                } else if (card.name == "instantiated1Card25c(Clone)") {

                    card.name = "instantiated1HandCard25c";

                } else if (card.name == "instantiated1Card26(Clone)") {

                    card.name = "instantiated1HandCard26";

                } else if (card.name == "instantiated1Card26a(Clone)") {

                    card.name = "instantiated1HandCard26a";

                } else if (card.name == "instantiated1Card26b(Clone)") {

                    card.name = "instantiated1HandCard26b";

                } else if (card.name == "instantiated1Card26c(Clone)") {

                    card.name = "instantiated1HandCard26c";

                } else if (card.name == "instantiated1Card27(Clone)") {

                    card.name = "instantiated1HandCard27";

                } else if (card.name == "instantiated1Card27a(Clone)") {

                    card.name = "instantiated1HandCard27a";

                } else if (card.name == "instantiated1Card27b(Clone)") {

                    card.name = "instantiated1HandCard27b";

                } else if (card.name == "instantiated1Card27c(Clone)") {

                    card.name = "instantiated1HandCard27c";

                } else if (card.name == "instantiated1Card28(Clone)") {

                    card.name = "instantiated1HandCard28";

                } else if (card.name == "instantiated1Card28a(Clone)") {

                    card.name = "instantiated1HandCard28a";

                } else if (card.name == "instantiated1Card28b(Clone)") {

                    card.name = "instantiated1HandCard28b";

                } else if (card.name == "instantiated1Card28c(Clone)") {

                    card.name = "instantiated1HandCard28c";

                } else if (card.name == "instantiated1Card29(Clone)") {

                    card.name = "instantiated1HandCard29";

                } else if (card.name == "instantiated1Card29a(Clone)") {

                    card.name = "instantiated1HandCard29a";

                } else if (card.name == "instantiated1Card29b(Clone)") {

                    card.name = "instantiated1HandCard29b";

                } else if (card.name == "instantiated1Card29c(Clone)") {

                    card.name = "instantiated1HandCard29c";

                } else if (card.name == "instantiated1Card30(Clone)") {

                    card.name = "instantiated1HandCard30";

                } else if (card.name == "instantiated1Card30a(Clone)") {

                    card.name = "instantiated1HandCard30a";

                } else if (card.name == "instantiated1Card30b(Clone)") {

                    card.name = "instantiated1HandCard30b";

                } else if (card.name == "instantiated1Card30c(Clone)") {

                    card.name = "instantiated1HandCard30c";

                } else if (card.name == "instantiated1Card31(Clone)") {

                    card.name = "instantiated1HandCard31";

                } else if (card.name == "instantiated1Card31a(Clone)") {

                    card.name = "instantiated1HandCard31a";

                } else if (card.name == "instantiated1Card31b(Clone)") {

                    card.name = "instantiated1HandCard31b";

                } else if (card.name == "instantiated1Card31c(Clone)") {

                    card.name = "instantiated1HandCard31c";

                } else if (card.name == "instantiated1Card32(Clone)") {

                    card.name = "instantiated1HandCard32";

                } else if (card.name == "instantiated1Card32a(Clone)") {

                    card.name = "instantiated1HandCard32a";

                } else if (card.name == "instantiated1Card32b(Clone)") {

                    card.name = "instantiated1HandCard32b";

                } else if (card.name == "instantiated1Card32c(Clone)") {

                    card.name = "instantiated1HandCard32c";

                } else if (card.name == "instantiated1Card33(Clone)") {

                    card.name = "instantiated1HandCard33";

                } else if (card.name == "instantiated1Card33a(Clone)") {

                    card.name = "instantiated1HandCard33a";

                } else if (card.name == "instantiated1Card33b(Clone)") {

                    card.name = "instantiated1HandCard33b";

                } else if (card.name == "instantiated1Card33c(Clone)") {

                    card.name = "instantiated1HandCard33c";

                } else if (card.name == "instantiated1Card34(Clone)") {

                    card.name = "instantiated1HandCard34";

                } else if (card.name == "instantiated1Card34a(Clone)") {

                    card.name = "instantiated1HandCard34a";

                } else if (card.name == "instantiated1Card34b(Clone)") {

                    card.name = "instantiated1HandCard34b";

                } else if (card.name == "instantiated1Card34c(Clone)") {

                    card.name = "instantiated1HandCard34c";

                } else if (card.name == "instantiated1Card35(Clone)") {

                    card.name = "instantiated1HandCard35";

                } else if (card.name == "instantiated1Card35a(Clone)") {

                    card.name = "instantiated1HandCard35a";

                } else if (card.name == "instantiated1Card35b(Clone)") {

                    card.name = "instantiated1HandCard35b";

                } else if (card.name == "instantiated1Card35c(Clone)") {

                    card.name = "instantiated1HandCard35c";

                } else if (card.name == "instantiated1Card36(Clone)") {

                    card.name = "instantiated1HandCard36";

                } else if (card.name == "instantiated1Card36a(Clone)") {

                    card.name = "instantiated1HandCard36a";

                } else if (card.name == "instantiated1Card36b(Clone)") {

                    card.name = "instantiated1HandCard36b";

                } else if (card.name == "instantiated1Card36c(Clone)") {

                    card.name = "instantiated1HandCard36c";

                } else if (card.name == "instantiated1Card37(Clone)") {

                    card.name = "instantiated1HandCard37";

                } else if (card.name == "instantiated1Card37a(Clone)") {

                    card.name = "instantiated1HandCard37a";

                } else if (card.name == "instantiated1Card37b(Clone)") {

                    card.name = "instantiated1HandCard37b";

                } else if (card.name == "instantiated1Card37c(Clone)") {

                    card.name = "instantiated1HandCard37c";

                } else if (card.name == "instantiated1Card38(Clone)") {

                    card.name = "instantiated1HandCard38";

                } else if (card.name == "instantiated1Card38a(Clone)") {

                    card.name = "instantiated1HandCard38a";

                } else if (card.name == "instantiated1Card38b(Clone)") {

                    card.name = "instantiated1HandCard38b";

                } else if (card.name == "instantiated1Card38c(Clone)") {

                    card.name = "instantiated1HandCard38c";

                } else if (card.name == "instantiated1Card39(Clone)") {

                    card.name = "instantiated1HandCard39";

                } else if (card.name == "instantiated1Card39a(Clone)") {

                    card.name = "instantiated1HandCard39a";

                } else if (card.name == "instantiated1Card39b(Clone)") {

                    card.name = "instantiated1HandCard39b";

                } else if (card.name == "instantiated1Card39c(Clone)") {

                    card.name = "instantiated1HandCard39c";

                } else if (card.name == "instantiated1Card40(Clone)") {

                    card.name = "instantiated1HandCard40";

                } else if (card.name == "instantiated1Card40a(Clone)") {

                    card.name = "instantiated1HandCard40a";

                } else if (card.name == "instantiated1Card40b(Clone)") {

                    card.name = "instantiated1HandCard40b";

                } else if (card.name == "instantiated1Card40c(Clone)") {

                    card.name = "instantiated1HandCard40c";

                } else if (card.name == "instantiated1Card41(Clone)") {

                    card.name = "instantiated1HandCard41";

                } else if (card.name == "instantiated1Card41a(Clone)") {

                    card.name = "instantiated1HandCard41a";

                } else if (card.name == "instantiated1Card41b(Clone)") {

                    card.name = "instantiated1HandCard41b";

                } else if (card.name == "instantiated1Card41c(Clone)") {

                    card.name = "instantiated1HandCard41c";

                } else if (card.name == "instantiated1Card42(Clone)") {

                    card.name = "instantiated1HandCard42";

                } else if (card.name == "instantiated1Card42a(Clone)") {

                    card.name = "instantiated1HandCard42a";

                } else if (card.name == "instantiated1Card42b(Clone)") {

                    card.name = "instantiated1HandCard42b";

                } else if (card.name == "instantiated1Card42c(Clone)") {

                    card.name = "instantiated1HandCard42c";

                } else if (card.name == "instantiated1Card43(Clone)") {

                    card.name = "instantiated1HandCard43";

                } else if (card.name == "instantiated1Card43a(Clone)") {

                    card.name = "instantiated1HandCard43a";

                } else if (card.name == "instantiated1Card43b(Clone)") {

                    card.name = "instantiated1HandCard43b";

                } else if (card.name == "instantiated1Card43c(Clone)") {

                    card.name = "instantiated1HandCard43c";

                } else if (card.name == "instantiated1Card44(Clone)") {

                    card.name = "instantiated1HandCard44";

                } else if (card.name == "instantiated1Card44a(Clone)") {

                    card.name = "instantiated1HandCard44a";

                } else if (card.name == "instantiated1Card44b(Clone)") {

                    card.name = "instantiated1HandCard44b";

                } else if (card.name == "instantiated1Card44c(Clone)") {

                    card.name = "instantiated1HandCard44c";

                } else if (card.name == "instantiated1Card45(Clone)") {

                    card.name = "instantiated1HandCard45";

                } else if (card.name == "instantiated1Card45a(Clone)") {

                    card.name = "instantiated1HandCard45a";

                } else if (card.name == "instantiated1Card45b(Clone)") {

                    card.name = "instantiated1HandCard45b";

                } else if (card.name == "instantiated1Card45c(Clone)") {

                    card.name = "instantiated1HandCard45c";

                } else if (card.name == "instantiated1Card46(Clone)") {

                    card.name = "instantiated1HandCard46";

                } else if (card.name == "instantiated1Card46a(Clone)") {

                    card.name = "instantiated1HandCard46a";

                } else if (card.name == "instantiated1Card46b(Clone)") {

                    card.name = "instantiated1HandCard46b";

                } else if (card.name == "instantiated1Card46c(Clone)") {

                    card.name = "instantiated1HandCard46c";

                } else if (card.name == "instantiated1Card47(Clone)") {

                    card.name = "instantiated1HandCard47";

                } else if (card.name == "instantiated1Card47a(Clone)") {

                    card.name = "instantiated1HandCard47a";

                } else if (card.name == "instantiated1Card47b(Clone)") {

                    card.name = "instantiated1HandCard47b";

                } else if (card.name == "instantiated1Card47c(Clone)") {

                    card.name = "instantiated1HandCard47c";

                } else if (card.name == "instantiated1Card48(Clone)") {

                    card.name = "instantiated1HandCard48";

                } else if (card.name == "instantiated1Card48a(Clone)") {

                    card.name = "instantiated1HandCard48a";

                } else if (card.name == "instantiated1Card48b(Clone)") {

                    card.name = "instantiated1HandCard48b";

                } else if (card.name == "instantiated1Card48c(Clone)") {

                    card.name = "instantiated1HandCard48c";

                } else if (card.name == "instantiated1Card49(Clone)") {

                    card.name = "instantiated1HandCard49";

                } else if (card.name == "instantiated1Card49a(Clone)") {

                    card.name = "instantiated1HandCard49a";

                } else if (card.name == "instantiated1Card49b(Clone)") {

                    card.name = "instantiated1HandCard49b";

                } else if (card.name == "instantiated1Card49c(Clone)") {

                    card.name = "instantiated1HandCard49c";

                } else if (card.name == "instantiated1Card50(Clone)") {

                    card.name = "instantiated1HandCard50";

                } else if (card.name == "instantiated1Card50a(Clone)") {

                    card.name = "instantiated1HandCard50a";

                } else if (card.name == "instantiated1Card50b(Clone)") {

                    card.name = "instantiated1HandCard50b";

                } else if (card.name == "instantiated1Card50c(Clone)") {

                    card.name = "instantiated1HandCard50c";

                } else if (card.name == "instantiated1Card51(Clone)") {

                    card.name = "instantiated1HandCard51";

                } else if (card.name == "instantiated1Card51a(Clone)") {

                    card.name = "instantiated1HandCard51a";

                } else if (card.name == "instantiated1Card51b(Clone)") {

                    card.name = "instantiated1HandCard51b";

                } else if (card.name == "instantiated1Card51c(Clone)") {

                    card.name = "instantiated1HandCard51c";

                } else if (card.name == "instantiated1Card52(Clone)") {

                    card.name = "instantiated1HandCard52";

                } else if (card.name == "instantiated1Card52a(Clone)") {

                    card.name = "instantiated1HandCard52a";

                } else if (card.name == "instantiated1Card52b(Clone)") {

                    card.name = "instantiated1HandCard52b";

                } else if (card.name == "instantiated1Card52c(Clone)") {

                    card.name = "instantiated1HandCard52c";

                } else if (card.name == "instantiated1Card53(Clone)") {

                    card.name = "instantiated1HandCard53";

                } else if (card.name == "instantiated1Card53a(Clone)") {

                    card.name = "instantiated1HandCard53a";

                } else if (card.name == "instantiated1Card53b(Clone)") {

                    card.name = "instantiated1HandCard53b";

                } else if (card.name == "instantiated1Card53c(Clone)") {

                    card.name = "instantiated1HandCard53c";

                } else if (card.name == "instantiated1Card54(Clone)") {

                    card.name = "instantiated1HandCard54";

                } else if (card.name == "instantiated1Card54a(Clone)") {

                    card.name = "instantiated1HandCard54a";

                } else if (card.name == "instantiated1Card54b(Clone)") {

                    card.name = "instantiated1HandCard54b";

                } else if (card.name == "instantiated1Card54c(Clone)") {

                    card.name = "instantiated1HandCard54c";

                } else if (card.name == "instantiated1Card55(Clone)") {

                    card.name = "instantiated1HandCard55";

                } else if (card.name == "instantiated1Card55a(Clone)") {

                    card.name = "instantiated1HandCard55a";

                } else if (card.name == "instantiated1Card55b(Clone)") {

                    card.name = "instantiated1HandCard55b";

                } else if (card.name == "instantiated1Card55c(Clone)") {

                    card.name = "instantiated1HandCard55c";

                } else if (card.name == "instantiated1Card56(Clone)") {

                    card.name = "instantiated1HandCard56";

                } else if (card.name == "instantiated1Card56a(Clone)") {

                    card.name = "instantiated1HandCard56a";

                } else if (card.name == "instantiated1Card56b(Clone)") {

                    card.name = "instantiated1HandCard56b";

                } else if (card.name == "instantiated1Card56c(Clone)") {

                    card.name = "instantiated1HandCard56c";

                } else if (card.name == "instantiated1Card57(Clone)") {

                    card.name = "instantiated1HandCard57";

                } else if (card.name == "instantiated1Card57a(Clone)") {

                    card.name = "instantiated1HandCard57a";

                } else if (card.name == "instantiated1Card57b(Clone)") {

                    card.name = "instantiated1HandCard57b";

                } else if (card.name == "instantiated1Card57c(Clone)") {

                    card.name = "instantiated1HandCard57c";

                } else if (card.name == "instantiated1Card58(Clone)") {

                    card.name = "instantiated1HandCard58";

                } else if (card.name == "instantiated1Card58a(Clone)") {

                    card.name = "instantiated1HandCard58a";

                } else if (card.name == "instantiated1Card58b(Clone)") {

                    card.name = "instantiated1HandCard58b";

                } else if (card.name == "instantiated1Card58c(Clone)") {

                    card.name = "instantiated1HandCard58c";

                } else if (card.name == "instantiated1Card59(Clone)") {

                    card.name = "instantiated1HandCard59";

                } else if (card.name == "instantiated1Card59a(Clone)") {

                    card.name = "instantiated1HandCard59a";

                } else if (card.name == "instantiated1Card59b(Clone)") {

                    card.name = "instantiated1HandCard59b";

                } else if (card.name == "instantiated1Card59c(Clone)") {

                    card.name = "instantiated1HandCard59c";

                } else if (card.name == "instantiated1Card60(Clone)") {

                    card.name = "instantiated1HandCard60";

                } else if (card.name == "instantiated1Card60a(Clone)") {

                    card.name = "instantiated1HandCard60a";

                } else if (card.name == "instantiated1Card60b(Clone)") {

                    card.name = "instantiated1HandCard60b";

                } else if (card.name == "instantiated1Card60c(Clone)") {

                    card.name = "instantiated1HandCard60c";
                }

                instances9++;

            }

            while (instances10 < NumberOfCards) {

                GameObject card = Instantiate(playCardsDeck1[UnityEngine.Random.Range(0, playCardsDeck1.Count)], player1DeckSlot10.transform.position, player1DeckSlot10.transform.rotation) as GameObject;
                card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                card.transform.parent = player1DeckSlot10.transform;

                if (card.name == "instantiated1Card1(Clone)") {

                    card.name = "instantiated1HandCard1";

                } else if (card.name == "instantiated1Card1a(Clone)") {

                    card.name = "instantiated1HandCard1a";

                } else if (card.name == "instantiated1Card1b(Clone)") {

                    card.name = "instantiated1HandCard1b";

                } else if (card.name == "instantiated1Card1c(Clone)") {

                    card.name = "instantiated1HandCard1c";

                } else if (card.name == "instantiated1Card2(Clone)") {

                    card.name = "instantiated1HandCard2";

                } else if (card.name == "instantiated1Card2a(Clone)") {

                    card.name = "instantiated1HandCard2a";

                } else if (card.name == "instantiated1Card2b(Clone)") {

                    card.name = "instantiated1HandCard2b";

                } else if (card.name == "instantiated1Card2c(Clone)") {

                    card.name = "instantiated1HandCard2c";

                } else if (card.name == "instantiated1Card3(Clone)") {

                    card.name = "instantiated1HandCard3";

                } else if (card.name == "instantiated1Card3a(Clone)") {

                    card.name = "instantiated1HandCard3a";

                } else if (card.name == "instantiated1Card3b(Clone)") {

                    card.name = "instantiated1HandCard3b";

                } else if (card.name == "instantiated1Card3c(Clone)") {

                    card.name = "instantiated1HandCard3c";

                } else if (card.name == "instantiated1Card4(Clone)") {

                    card.name = "instantiated1HandCard4";

                } else if (card.name == "instantiated1Card4a(Clone)") {

                    card.name = "instantiated1HandCard4a";

                } else if (card.name == "instantiated1Card4b(Clone)") {

                    card.name = "instantiated1HandCard4b";

                } else if (card.name == "instantiated1Card4c(Clone)") {

                    card.name = "instantiated1HandCard4c";

                } else if (card.name == "instantiated1Card5(Clone)") {

                    card.name = "instantiated1HandCard5";

                } else if (card.name == "instantiated1Card5a(Clone)") {

                    card.name = "instantiated1HandCard5a";

                } else if (card.name == "instantiated1Card5b(Clone)") {

                    card.name = "instantiated1HandCard5b";

                } else if (card.name == "instantiated1Card5c(Clone)") {

                    card.name = "instantiated1HandCard5c";

                } else if (card.name == "instantiated1Card6(Clone)") {

                    card.name = "instantiated1HandCard6";

                } else if (card.name == "instantiated1Card6a(Clone)") {

                    card.name = "instantiated1HandCard6a";

                } else if (card.name == "instantiated1Card6b(Clone)") {

                    card.name = "instantiated1HandCard6b";

                } else if (card.name == "instantiated1Card6c(Clone)") {

                    card.name = "instantiated1HandCard6c";

                } else if (card.name == "instantiated1Card7(Clone)") {

                    card.name = "instantiated1HandCard7";

                } else if (card.name == "instantiated1Card7a(Clone)") {

                    card.name = "instantiated1HandCard7a";

                } else if (card.name == "instantiated1Card7b(Clone)") {

                    card.name = "instantiated1HandCard7b";

                } else if (card.name == "instantiated1Card7c(Clone)") {

                    card.name = "instantiated1HandCard7c";

                } else if (card.name == "instantiated1Card8(Clone)") {

                    card.name = "instantiated1HandCard8";

                } else if (card.name == "instantiated1Card8a(Clone)") {

                    card.name = "instantiated1HandCard8a";

                } else if (card.name == "instantiated1Card8b(Clone)") {

                    card.name = "instantiated1HandCard8b";

                } else if (card.name == "instantiated1Card8c(Clone)") {

                    card.name = "instantiated1HandCard8c";

                } else if (card.name == "instantiated1Card9(Clone)") {

                    card.name = "instantiated1HandCard9";

                } else if (card.name == "instantiated1Card9a(Clone)") {

                    card.name = "instantiated1HandCard9a";

                } else if (card.name == "instantiated1Card9b(Clone)") {

                    card.name = "instantiated1HandCard9b";

                } else if (card.name == "instantiated1Card9c(Clone)") {

                    card.name = "instantiated1HandCard9c";

                } else if (card.name == "instantiated1Card10(Clone)") {

                    card.name = "instantiatedAICard10";

                } else if (card.name == "instantiated1Card10a(Clone)") {

                    card.name = "instantiated1HandCard10a";

                } else if (card.name == "instantiated1Card10b(Clone)") {

                    card.name = "instantiated1HandCard10b";

                } else if (card.name == "instantiated1Card10c(Clone)") {

                    card.name = "instantiated1HandCard10c";

                } else if (card.name == "instantiated1Card11(Clone)") {

                    card.name = "instantiated1HandCard11";

                } else if (card.name == "instantiated1Card11a(Clone)") {

                    card.name = "instantiated1HandCard11a";

                } else if (card.name == "instantiated1Card11b(Clone)") {

                    card.name = "instantiated1HandCard11b";

                } else if (card.name == "instantiated1Card11c(Clone)") {

                    card.name = "instantiated1HandCard11c";

                } else if (card.name == "instantiated1Card12(Clone)") {

                    card.name = "instantiated1HandCard12";

                } else if (card.name == "instantiated1Card12a(Clone)") {

                    card.name = "instantiated1HandCard12a";

                } else if (card.name == "instantiated1Card12b(Clone)") {

                    card.name = "instantiated1HandCard12b";

                } else if (card.name == "instantiated1Card12c(Clone)") {

                    card.name = "instantiated1HandCard12c";

                } else if (card.name == "instantiated1Card13(Clone)") {

                    card.name = "instantiated1HandCard13";

                } else if (card.name == "instantiated1Card13a(Clone)") {

                    card.name = "instantiated1HandCard13a";

                } else if (card.name == "instantiated1Card13b(Clone)") {

                    card.name = "instantiated1HandCard13b";

                } else if (card.name == "instantiated1Card13c(Clone)") {

                    card.name = "instantiated1HandCard13c";

                } else if (card.name == "instantiated1Card14(Clone)") {

                    card.name = "instantiated1HandCard14";

                } else if (card.name == "instantiated1Card14a(Clone)") {

                    card.name = "instantiated1HandCard14a";

                } else if (card.name == "instantiated1Card14b(Clone)") {

                    card.name = "instantiated1HandCard14b";

                } else if (card.name == "instantiated1Card14c(Clone)") {

                    card.name = "instantiated1HandCard14c";

                } else if (card.name == "instantiated1Card15(Clone)") {

                    card.name = "instantiated1HandCard15";

                } else if (card.name == "instantiated1Card15a(Clone)") {

                    card.name = "instantiated1HandCard15a";

                } else if (card.name == "instantiated1Card15b(Clone)") {

                    card.name = "instantiated1HandCard15b";

                } else if (card.name == "instantiated1Card15c(Clone)") {

                    card.name = "instantiated1HandCard15c";

                } else if (card.name == "instantiated1Card16(Clone)") {

                    card.name = "instantiated1HandCard16";

                } else if (card.name == "instantiated1Card16a(Clone)") {

                    card.name = "instantiated1HandCard16a";

                } else if (card.name == "instantiated1Card16b(Clone)") {

                    card.name = "instantiated1HandCard16b";

                } else if (card.name == "instantiated1Card16c(Clone)") {

                    card.name = "instantiated1HandCard16c";

                } else if (card.name == "instantiated1Card17(Clone)") {

                    card.name = "instantiated1HandCard17";

                } else if (card.name == "instantiated1Card17a(Clone)") {

                    card.name = "instantiated1HandCard17a";

                } else if (card.name == "instantiated1Card17b(Clone)") {

                    card.name = "instantiated1HandCard17b";

                } else if (card.name == "instantiated1Card17c(Clone)") {

                    card.name = "instantiated1HandCard17c";

                } else if (card.name == "instantiated1Card18(Clone)") {

                    card.name = "instantiated1HandCard18";

                } else if (card.name == "instantiated1Card18a(Clone)") {

                    card.name = "instantiated1HandCard18a";

                } else if (card.name == "instantiated1Card18b(Clone)") {

                    card.name = "instantiated1HandCard18b";

                } else if (card.name == "instantiated1Card18c(Clone)") {

                    card.name = "instantiated1HandCard18c";

                } else if (card.name == "instantiated1Card19(Clone)") {

                    card.name = "instantiated1HandCard19";

                } else if (card.name == "instantiated1Card19a(Clone)") {

                    card.name = "instantiated1HandCard19a";

                } else if (card.name == "instantiated1Card19b(Clone)") {

                    card.name = "instantiated1HandCard19b";

                } else if (card.name == "instantiated1Card19c(Clone)") {

                    card.name = "instantiated1HandCard19c";

                } else if (card.name == "instantiated1Card20(Clone)") {

                    card.name = "instantiated1HandCard20";

                } else if (card.name == "instantiated1Card20a(Clone)") {

                    card.name = "instantiated1HandCard20a";

                } else if (card.name == "instantiated1Card20b(Clone)") {

                    card.name = "instantiated1HandCard20b";

                } else if (card.name == "instantiated1Card20c(Clone)") {

                    card.name = "instantiated1HandCard20c";

                } else if (card.name == "instantiated1Card21(Clone)") {

                    card.name = "instantiated1HandCard21";

                } else if (card.name == "instantiated1Card21a(Clone)") {

                    card.name = "instantiated1HandCard21a";

                } else if (card.name == "instantiated1Card21b(Clone)") {

                    card.name = "instantiated1HandCard21b";

                } else if (card.name == "instantiated1Card21c(Clone)") {

                    card.name = "instantiated1HandCard21c";

                } else if (card.name == "instantiated1Card22(Clone)") {

                    card.name = "instantiated1HandCard22";

                } else if (card.name == "instantiated1Card22a(Clone)") {

                    card.name = "instantiated1HandCard22a";

                } else if (card.name == "instantiated1Card22b(Clone)") {

                    card.name = "instantiated1HandCard22b";

                } else if (card.name == "instantiated1Card22c(Clone)") {

                    card.name = "instantiated1HandCard22c";

                } else if (card.name == "instantiated1Card23(Clone)") {

                    card.name = "instantiated1HandCard23";

                } else if (card.name == "instantiated1Card23a(Clone)") {

                    card.name = "instantiated1HandCard23a";

                } else if (card.name == "instantiated1Card23b(Clone)") {

                    card.name = "instantiated1HandCard23b";

                } else if (card.name == "instantiated1Card23c(Clone)") {

                    card.name = "instantiated1HandCard23c";

                } else if (card.name == "instantiated1Card24(Clone)") {

                    card.name = "instantiated1HandCard24";

                } else if (card.name == "instantiated1Card24a(Clone)") {

                    card.name = "instantiated1HandCard24a";

                } else if (card.name == "instantiated1Card24b(Clone)") {

                    card.name = "instantiated1HandCard24b";

                } else if (card.name == "instantiated1Card24c(Clone)") {

                    card.name = "instantiated1HandCard24c";

                } else if (card.name == "instantiated1Card25(Clone)") {

                    card.name = "instantiated1HandCard25";

                } else if (card.name == "instantiated1Card25a(Clone)") {

                    card.name = "instantiated1HandCard25a";

                } else if (card.name == "instantiated1Card25b(Clone)") {

                    card.name = "instantiated1HandCard25b";

                } else if (card.name == "instantiated1Card25c(Clone)") {

                    card.name = "instantiated1HandCard25c";

                } else if (card.name == "instantiated1Card26(Clone)") {

                    card.name = "instantiated1HandCard26";

                } else if (card.name == "instantiated1Card26a(Clone)") {

                    card.name = "instantiated1HandCard26a";

                } else if (card.name == "instantiated1Card26b(Clone)") {

                    card.name = "instantiated1HandCard26b";

                } else if (card.name == "instantiated1Card26c(Clone)") {

                    card.name = "instantiated1HandCard26c";

                } else if (card.name == "instantiated1Card27(Clone)") {

                    card.name = "instantiated1HandCard27";

                } else if (card.name == "instantiated1Card27a(Clone)") {

                    card.name = "instantiated1HandCard27a";

                } else if (card.name == "instantiated1Card27b(Clone)") {

                    card.name = "instantiated1HandCard27b";

                } else if (card.name == "instantiated1Card27c(Clone)") {

                    card.name = "instantiated1HandCard27c";

                } else if (card.name == "instantiated1Card28(Clone)") {

                    card.name = "instantiated1HandCard28";

                } else if (card.name == "instantiated1Card28a(Clone)") {

                    card.name = "instantiated1HandCard28a";

                } else if (card.name == "instantiated1Card28b(Clone)") {

                    card.name = "instantiated1HandCard28b";

                } else if (card.name == "instantiated1Card28c(Clone)") {

                    card.name = "instantiated1HandCard28c";

                } else if (card.name == "instantiated1Card29(Clone)") {

                    card.name = "instantiated1HandCard29";

                } else if (card.name == "instantiated1Card29a(Clone)") {

                    card.name = "instantiated1HandCard29a";

                } else if (card.name == "instantiated1Card29b(Clone)") {

                    card.name = "instantiated1HandCard29b";

                } else if (card.name == "instantiated1Card29c(Clone)") {

                    card.name = "instantiated1HandCard29c";

                } else if (card.name == "instantiated1Card30(Clone)") {

                    card.name = "instantiated1HandCard30";

                } else if (card.name == "instantiated1Card30a(Clone)") {

                    card.name = "instantiated1HandCard30a";

                } else if (card.name == "instantiated1Card30b(Clone)") {

                    card.name = "instantiated1HandCard30b";

                } else if (card.name == "instantiated1Card30c(Clone)") {

                    card.name = "instantiated1HandCard30c";

                } else if (card.name == "instantiated1Card31(Clone)") {

                    card.name = "instantiated1HandCard31";

                } else if (card.name == "instantiated1Card31a(Clone)") {

                    card.name = "instantiated1HandCard31a";

                } else if (card.name == "instantiated1Card31b(Clone)") {

                    card.name = "instantiated1HandCard31b";

                } else if (card.name == "instantiated1Card31c(Clone)") {

                    card.name = "instantiated1HandCard31c";

                } else if (card.name == "instantiated1Card32(Clone)") {

                    card.name = "instantiated1HandCard32";

                } else if (card.name == "instantiated1Card32a(Clone)") {

                    card.name = "instantiated1HandCard32a";

                } else if (card.name == "instantiated1Card32b(Clone)") {

                    card.name = "instantiated1HandCard32b";

                } else if (card.name == "instantiated1Card32c(Clone)") {

                    card.name = "instantiated1HandCard32c";

                } else if (card.name == "instantiated1Card33(Clone)") {

                    card.name = "instantiated1HandCard33";

                } else if (card.name == "instantiated1Card33a(Clone)") {

                    card.name = "instantiated1HandCard33a";

                } else if (card.name == "instantiated1Card33b(Clone)") {

                    card.name = "instantiated1HandCard33b";

                } else if (card.name == "instantiated1Card33c(Clone)") {

                    card.name = "instantiated1HandCard33c";

                } else if (card.name == "instantiated1Card34(Clone)") {

                    card.name = "instantiated1HandCard34";

                } else if (card.name == "instantiated1Card34a(Clone)") {

                    card.name = "instantiated1HandCard34a";

                } else if (card.name == "instantiated1Card34b(Clone)") {

                    card.name = "instantiated1HandCard34b";

                } else if (card.name == "instantiated1Card34c(Clone)") {

                    card.name = "instantiated1HandCard34c";

                } else if (card.name == "instantiated1Card35(Clone)") {

                    card.name = "instantiated1HandCard35";

                } else if (card.name == "instantiated1Card35a(Clone)") {

                    card.name = "instantiated1HandCard35a";

                } else if (card.name == "instantiated1Card35b(Clone)") {

                    card.name = "instantiated1HandCard35b";

                } else if (card.name == "instantiated1Card35c(Clone)") {

                    card.name = "instantiated1HandCard35c";

                } else if (card.name == "instantiated1Card36(Clone)") {

                    card.name = "instantiated1HandCard36";

                } else if (card.name == "instantiated1Card36a(Clone)") {

                    card.name = "instantiated1HandCard36a";

                } else if (card.name == "instantiated1Card36b(Clone)") {

                    card.name = "instantiated1HandCard36b";

                } else if (card.name == "instantiated1Card36c(Clone)") {

                    card.name = "instantiated1HandCard36c";

                } else if (card.name == "instantiated1Card37(Clone)") {

                    card.name = "instantiated1HandCard37";

                } else if (card.name == "instantiated1Card37a(Clone)") {

                    card.name = "instantiated1HandCard37a";

                } else if (card.name == "instantiated1Card37b(Clone)") {

                    card.name = "instantiated1HandCard37b";

                } else if (card.name == "instantiated1Card37c(Clone)") {

                    card.name = "instantiated1HandCard37c";

                } else if (card.name == "instantiated1Card38(Clone)") {

                    card.name = "instantiated1HandCard38";

                } else if (card.name == "instantiated1Card38a(Clone)") {

                    card.name = "instantiated1HandCard38a";

                } else if (card.name == "instantiated1Card38b(Clone)") {

                    card.name = "instantiated1HandCard38b";

                } else if (card.name == "instantiated1Card38c(Clone)") {

                    card.name = "instantiated1HandCard38c";

                } else if (card.name == "instantiated1Card39(Clone)") {

                    card.name = "instantiated1HandCard39";

                } else if (card.name == "instantiated1Card39a(Clone)") {

                    card.name = "instantiated1HandCard39a";

                } else if (card.name == "instantiated1Card39b(Clone)") {

                    card.name = "instantiated1HandCard39b";

                } else if (card.name == "instantiated1Card39c(Clone)") {

                    card.name = "instantiated1HandCard39c";

                } else if (card.name == "instantiated1Card40(Clone)") {

                    card.name = "instantiated1HandCard40";

                } else if (card.name == "instantiated1Card40a(Clone)") {

                    card.name = "instantiated1HandCard40a";

                } else if (card.name == "instantiated1Card40b(Clone)") {

                    card.name = "instantiated1HandCard40b";

                } else if (card.name == "instantiated1Card40c(Clone)") {

                    card.name = "instantiated1HandCard40c";

                } else if (card.name == "instantiated1Card41(Clone)") {

                    card.name = "instantiated1HandCard41";

                } else if (card.name == "instantiated1Card41a(Clone)") {

                    card.name = "instantiated1HandCard41a";

                } else if (card.name == "instantiated1Card41b(Clone)") {

                    card.name = "instantiated1HandCard41b";

                } else if (card.name == "instantiated1Card41c(Clone)") {

                    card.name = "instantiated1HandCard41c";

                } else if (card.name == "instantiated1Card42(Clone)") {

                    card.name = "instantiated1HandCard42";

                } else if (card.name == "instantiated1Card42a(Clone)") {

                    card.name = "instantiated1HandCard42a";

                } else if (card.name == "instantiated1Card42b(Clone)") {

                    card.name = "instantiated1HandCard42b";

                } else if (card.name == "instantiated1Card42c(Clone)") {

                    card.name = "instantiated1HandCard42c";

                } else if (card.name == "instantiated1Card43(Clone)") {

                    card.name = "instantiated1HandCard43";

                } else if (card.name == "instantiated1Card43a(Clone)") {

                    card.name = "instantiated1HandCard43a";

                } else if (card.name == "instantiated1Card43b(Clone)") {

                    card.name = "instantiated1HandCard43b";

                } else if (card.name == "instantiated1Card43c(Clone)") {

                    card.name = "instantiated1HandCard43c";

                } else if (card.name == "instantiated1Card44(Clone)") {

                    card.name = "instantiated1HandCard44";

                } else if (card.name == "instantiated1Card44a(Clone)") {

                    card.name = "instantiated1HandCard44a";

                } else if (card.name == "instantiated1Card44b(Clone)") {

                    card.name = "instantiated1HandCard44b";

                } else if (card.name == "instantiated1Card44c(Clone)") {

                    card.name = "instantiated1HandCard44c";

                } else if (card.name == "instantiated1Card45(Clone)") {

                    card.name = "instantiated1HandCard45";

                } else if (card.name == "instantiated1Card45a(Clone)") {

                    card.name = "instantiated1HandCard45a";

                } else if (card.name == "instantiated1Card45b(Clone)") {

                    card.name = "instantiated1HandCard45b";

                } else if (card.name == "instantiated1Card45c(Clone)") {

                    card.name = "instantiated1HandCard45c";

                } else if (card.name == "instantiated1Card46(Clone)") {

                    card.name = "instantiated1HandCard46";

                } else if (card.name == "instantiated1Card46a(Clone)") {

                    card.name = "instantiated1HandCard46a";

                } else if (card.name == "instantiated1Card46b(Clone)") {

                    card.name = "instantiated1HandCard46b";

                } else if (card.name == "instantiated1Card46c(Clone)") {

                    card.name = "instantiated1HandCard46c";

                } else if (card.name == "instantiated1Card47(Clone)") {

                    card.name = "instantiated1HandCard47";

                } else if (card.name == "instantiated1Card47a(Clone)") {

                    card.name = "instantiated1HandCard47a";

                } else if (card.name == "instantiated1Card47b(Clone)") {

                    card.name = "instantiated1HandCard47b";

                } else if (card.name == "instantiated1Card47c(Clone)") {

                    card.name = "instantiated1HandCard47c";

                } else if (card.name == "instantiated1Card48(Clone)") {

                    card.name = "instantiated1HandCard48";

                } else if (card.name == "instantiated1Card48a(Clone)") {

                    card.name = "instantiated1HandCard48a";

                } else if (card.name == "instantiated1Card48b(Clone)") {

                    card.name = "instantiated1HandCard48b";

                } else if (card.name == "instantiated1Card48c(Clone)") {

                    card.name = "instantiated1HandCard48c";

                } else if (card.name == "instantiated1Card49(Clone)") {

                    card.name = "instantiated1HandCard49";

                } else if (card.name == "instantiated1Card49a(Clone)") {

                    card.name = "instantiated1HandCard49a";

                } else if (card.name == "instantiated1Card49b(Clone)") {

                    card.name = "instantiated1HandCard49b";

                } else if (card.name == "instantiated1Card49c(Clone)") {

                    card.name = "instantiated1HandCard49c";

                } else if (card.name == "instantiated1Card50(Clone)") {

                    card.name = "instantiated1HandCard50";

                } else if (card.name == "instantiated1Card50a(Clone)") {

                    card.name = "instantiated1HandCard50a";

                } else if (card.name == "instantiated1Card50b(Clone)") {

                    card.name = "instantiated1HandCard50b";

                } else if (card.name == "instantiated1Card50c(Clone)") {

                    card.name = "instantiated1HandCard50c";

                } else if (card.name == "instantiated1Card51(Clone)") {

                    card.name = "instantiated1HandCard51";

                } else if (card.name == "instantiated1Card51a(Clone)") {

                    card.name = "instantiated1HandCard51a";

                } else if (card.name == "instantiated1Card51b(Clone)") {

                    card.name = "instantiated1HandCard51b";

                } else if (card.name == "instantiated1Card51c(Clone)") {

                    card.name = "instantiated1HandCard51c";

                } else if (card.name == "instantiated1Card52(Clone)") {

                    card.name = "instantiated1HandCard52";

                } else if (card.name == "instantiated1Card52a(Clone)") {

                    card.name = "instantiated1HandCard52a";

                } else if (card.name == "instantiated1Card52b(Clone)") {

                    card.name = "instantiated1HandCard52b";

                } else if (card.name == "instantiated1Card52c(Clone)") {

                    card.name = "instantiated1HandCard52c";

                } else if (card.name == "instantiated1Card53(Clone)") {

                    card.name = "instantiated1HandCard53";

                } else if (card.name == "instantiated1Card53a(Clone)") {

                    card.name = "instantiated1HandCard53a";

                } else if (card.name == "instantiated1Card53b(Clone)") {

                    card.name = "instantiated1HandCard53b";

                } else if (card.name == "instantiated1Card53c(Clone)") {

                    card.name = "instantiated1HandCard53c";

                } else if (card.name == "instantiated1Card54(Clone)") {

                    card.name = "instantiated1HandCard54";

                } else if (card.name == "instantiated1Card54a(Clone)") {

                    card.name = "instantiated1HandCard54a";

                } else if (card.name == "instantiated1Card54b(Clone)") {

                    card.name = "instantiated1HandCard54b";

                } else if (card.name == "instantiated1Card54c(Clone)") {

                    card.name = "instantiated1HandCard54c";

                } else if (card.name == "instantiated1Card55(Clone)") {

                    card.name = "instantiated1HandCard55";

                } else if (card.name == "instantiated1Card55a(Clone)") {

                    card.name = "instantiated1HandCard55a";

                } else if (card.name == "instantiated1Card55b(Clone)") {

                    card.name = "instantiated1HandCard55b";

                } else if (card.name == "instantiated1Card55c(Clone)") {

                    card.name = "instantiated1HandCard55c";

                } else if (card.name == "instantiated1Card56(Clone)") {

                    card.name = "instantiated1HandCard56";

                } else if (card.name == "instantiated1Card56a(Clone)") {

                    card.name = "instantiated1HandCard56a";

                } else if (card.name == "instantiated1Card56b(Clone)") {

                    card.name = "instantiated1HandCard56b";

                } else if (card.name == "instantiated1Card56c(Clone)") {

                    card.name = "instantiated1HandCard56c";

                } else if (card.name == "instantiated1Card57(Clone)") {

                    card.name = "instantiated1HandCard57";

                } else if (card.name == "instantiated1Card57a(Clone)") {

                    card.name = "instantiated1HandCard57a";

                } else if (card.name == "instantiated1Card57b(Clone)") {

                    card.name = "instantiated1HandCard57b";

                } else if (card.name == "instantiated1Card57c(Clone)") {

                    card.name = "instantiated1HandCard57c";

                } else if (card.name == "instantiated1Card58(Clone)") {

                    card.name = "instantiated1HandCard58";

                } else if (card.name == "instantiated1Card58a(Clone)") {

                    card.name = "instantiated1HandCard58a";

                } else if (card.name == "instantiated1Card58b(Clone)") {

                    card.name = "instantiated1HandCard58b";

                } else if (card.name == "instantiated1Card58c(Clone)") {

                    card.name = "instantiated1HandCard58c";

                } else if (card.name == "instantiated1Card59(Clone)") {

                    card.name = "instantiated1HandCard59";

                } else if (card.name == "instantiated1Card59a(Clone)") {

                    card.name = "instantiated1HandCard59a";

                } else if (card.name == "instantiated1Card59b(Clone)") {

                    card.name = "instantiated1HandCard59b";

                } else if (card.name == "instantiated1Card59c(Clone)") {

                    card.name = "instantiated1HandCard59c";

                } else if (card.name == "instantiated1Card60(Clone)") {

                    card.name = "instantiated1HandCard60";

                } else if (card.name == "instantiated1Card60a(Clone)") {

                    card.name = "instantiated1HandCard60a";

                } else if (card.name == "instantiated1Card60b(Clone)") {

                    card.name = "instantiated1HandCard60b";

                } else if (card.name == "instantiated1Card60c(Clone)") {

                    card.name = "instantiated1HandCard60c";
                }

                instances10++;

            }



        }

        //DoneButton1
        public void SpawnHandCardsMulligan1() {

            if (player1DeckSlot1.transform.childCount == 0) {

                while (instances1M < NumberOfCards) {

                    GameObject card = Instantiate(playCardsDeck1[UnityEngine.Random.Range(0, playCardsDeck1.Count)], player1DeckSlot1.transform.position, player1DeckSlot1.transform.rotation) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.transform.parent = player1DeckSlot1.transform;

                    if (card.name == "instantiated1Card1(Clone)") {

                        card.name = "instantiated1HandCard1";

                    } else if (card.name == "instantiated1Card1a(Clone)") {

                        card.name = "instantiated1HandCard1a";

                    } else if (card.name == "instantiated1Card1b(Clone)") {

                        card.name = "instantiated1HandCard1b";

                    } else if (card.name == "instantiated1Card1c(Clone)") {

                        card.name = "instantiated1HandCard1c";

                    } else if (card.name == "instantiated1Card2(Clone)") {

                        card.name = "instantiated1HandCard2";

                    } else if (card.name == "instantiated1Card2a(Clone)") {

                        card.name = "instantiated1HandCard2a";

                    } else if (card.name == "instantiated1Card2b(Clone)") {

                        card.name = "instantiated1HandCard2b";

                    } else if (card.name == "instantiated1Card2c(Clone)") {

                        card.name = "instantiated1HandCard2c";

                    } else if (card.name == "instantiated1Card3(Clone)") {

                        card.name = "instantiated1HandCard3";

                    } else if (card.name == "instantiated1Card3a(Clone)") {

                        card.name = "instantiated1HandCard3a";

                    } else if (card.name == "instantiated1Card3b(Clone)") {

                        card.name = "instantiated1HandCard3b";

                    } else if (card.name == "instantiated1Card3c(Clone)") {

                        card.name = "instantiated1HandCard3c";

                    } else if (card.name == "instantiated1Card4(Clone)") {

                        card.name = "instantiated1HandCard4";

                    } else if (card.name == "instantiated1Card4a(Clone)") {

                        card.name = "instantiated1HandCard4a";

                    } else if (card.name == "instantiated1Card4b(Clone)") {

                        card.name = "instantiated1HandCard4b";

                    } else if (card.name == "instantiated1Card4c(Clone)") {

                        card.name = "instantiated1HandCard4c";

                    } else if (card.name == "instantiated1Card5(Clone)") {

                        card.name = "instantiated1HandCard5";

                    } else if (card.name == "instantiated1Card5a(Clone)") {

                        card.name = "instantiated1HandCard5a";

                    } else if (card.name == "instantiated1Card5b(Clone)") {

                        card.name = "instantiated1HandCard5b";

                    } else if (card.name == "instantiated1Card5c(Clone)") {

                        card.name = "instantiated1HandCard5c";

                    } else if (card.name == "instantiated1Card6(Clone)") {

                        card.name = "instantiated1HandCard6";

                    } else if (card.name == "instantiated1Card6a(Clone)") {

                        card.name = "instantiated1HandCard6a";

                    } else if (card.name == "instantiated1Card6b(Clone)") {

                        card.name = "instantiated1HandCard6b";

                    } else if (card.name == "instantiated1Card6c(Clone)") {

                        card.name = "instantiated1HandCard6c";

                    } else if (card.name == "instantiated1Card7(Clone)") {

                        card.name = "instantiated1HandCard7";

                    } else if (card.name == "instantiated1Card7a(Clone)") {

                        card.name = "instantiated1HandCard7a";

                    } else if (card.name == "instantiated1Card7b(Clone)") {

                        card.name = "instantiated1HandCard7b";

                    } else if (card.name == "instantiated1Card7c(Clone)") {

                        card.name = "instantiated1HandCard7c";

                    } else if (card.name == "instantiated1Card8(Clone)") {

                        card.name = "instantiated1HandCard8";

                    } else if (card.name == "instantiated1Card8a(Clone)") {

                        card.name = "instantiated1HandCard8a";

                    } else if (card.name == "instantiated1Card8b(Clone)") {

                        card.name = "instantiated1HandCard8b";

                    } else if (card.name == "instantiated1Card8c(Clone)") {

                        card.name = "instantiated1HandCard8c";

                    } else if (card.name == "instantiated1Card9(Clone)") {

                        card.name = "instantiated1HandCard9";

                    } else if (card.name == "instantiated1Card9a(Clone)") {

                        card.name = "instantiated1HandCard9a";

                    } else if (card.name == "instantiated1Card9b(Clone)") {

                        card.name = "instantiated1HandCard9b";

                    } else if (card.name == "instantiated1Card9c(Clone)") {

                        card.name = "instantiated1HandCard9c";

                    } else if (card.name == "instantiated1Card10(Clone)") {

                        card.name = "instantiatedAICard10";

                    } else if (card.name == "instantiated1Card10a(Clone)") {

                        card.name = "instantiated1HandCard10a";

                    } else if (card.name == "instantiated1Card10b(Clone)") {

                        card.name = "instantiated1HandCard10b";

                    } else if (card.name == "instantiated1Card10c(Clone)") {

                        card.name = "instantiated1HandCard10c";

                    } else if (card.name == "instantiated1Card11(Clone)") {

                        card.name = "instantiated1HandCard11";

                    } else if (card.name == "instantiated1Card11a(Clone)") {

                        card.name = "instantiated1HandCard11a";

                    } else if (card.name == "instantiated1Card11b(Clone)") {

                        card.name = "instantiated1HandCard11b";

                    } else if (card.name == "instantiated1Card11c(Clone)") {

                        card.name = "instantiated1HandCard11c";

                    } else if (card.name == "instantiated1Card12(Clone)") {

                        card.name = "instantiated1HandCard12";

                    } else if (card.name == "instantiated1Card12a(Clone)") {

                        card.name = "instantiated1HandCard12a";

                    } else if (card.name == "instantiated1Card12b(Clone)") {

                        card.name = "instantiated1HandCard12b";

                    } else if (card.name == "instantiated1Card12c(Clone)") {

                        card.name = "instantiated1HandCard12c";

                    } else if (card.name == "instantiated1Card13(Clone)") {

                        card.name = "instantiated1HandCard13";

                    } else if (card.name == "instantiated1Card13a(Clone)") {

                        card.name = "instantiated1HandCard13a";

                    } else if (card.name == "instantiated1Card13b(Clone)") {

                        card.name = "instantiated1HandCard13b";

                    } else if (card.name == "instantiated1Card13c(Clone)") {

                        card.name = "instantiated1HandCard13c";

                    } else if (card.name == "instantiated1Card14(Clone)") {

                        card.name = "instantiated1HandCard14";

                    } else if (card.name == "instantiated1Card14a(Clone)") {

                        card.name = "instantiated1HandCard14a";

                    } else if (card.name == "instantiated1Card14b(Clone)") {

                        card.name = "instantiated1HandCard14b";

                    } else if (card.name == "instantiated1Card14c(Clone)") {

                        card.name = "instantiated1HandCard14c";

                    } else if (card.name == "instantiated1Card15(Clone)") {

                        card.name = "instantiated1HandCard15";

                    } else if (card.name == "instantiated1Card15a(Clone)") {

                        card.name = "instantiated1HandCard15a";

                    } else if (card.name == "instantiated1Card15b(Clone)") {

                        card.name = "instantiated1HandCard15b";

                    } else if (card.name == "instantiated1Card15c(Clone)") {

                        card.name = "instantiated1HandCard15c";

                    } else if (card.name == "instantiated1Card16(Clone)") {

                        card.name = "instantiated1HandCard16";

                    } else if (card.name == "instantiated1Card16a(Clone)") {

                        card.name = "instantiated1HandCard16a";

                    } else if (card.name == "instantiated1Card16b(Clone)") {

                        card.name = "instantiated1HandCard16b";

                    } else if (card.name == "instantiated1Card16c(Clone)") {

                        card.name = "instantiated1HandCard16c";

                    } else if (card.name == "instantiated1Card17(Clone)") {

                        card.name = "instantiated1HandCard17";

                    } else if (card.name == "instantiated1Card17a(Clone)") {

                        card.name = "instantiated1HandCard17a";

                    } else if (card.name == "instantiated1Card17b(Clone)") {

                        card.name = "instantiated1HandCard17b";

                    } else if (card.name == "instantiated1Card17c(Clone)") {

                        card.name = "instantiated1HandCard17c";

                    } else if (card.name == "instantiated1Card18(Clone)") {

                        card.name = "instantiated1HandCard18";

                    } else if (card.name == "instantiated1Card18a(Clone)") {

                        card.name = "instantiated1HandCard18a";

                    } else if (card.name == "instantiated1Card18b(Clone)") {

                        card.name = "instantiated1HandCard18b";

                    } else if (card.name == "instantiated1Card18c(Clone)") {

                        card.name = "instantiated1HandCard18c";

                    } else if (card.name == "instantiated1Card19(Clone)") {

                        card.name = "instantiated1HandCard19";

                    } else if (card.name == "instantiated1Card19a(Clone)") {

                        card.name = "instantiated1HandCard19a";

                    } else if (card.name == "instantiated1Card19b(Clone)") {

                        card.name = "instantiated1HandCard19b";

                    } else if (card.name == "instantiated1Card19c(Clone)") {

                        card.name = "instantiated1HandCard19c";

                    } else if (card.name == "instantiated1Card20(Clone)") {

                        card.name = "instantiated1HandCard20";

                    } else if (card.name == "instantiated1Card20a(Clone)") {

                        card.name = "instantiated1HandCard20a";

                    } else if (card.name == "instantiated1Card20b(Clone)") {

                        card.name = "instantiated1HandCard20b";

                    } else if (card.name == "instantiated1Card20c(Clone)") {

                        card.name = "instantiated1HandCard20c";

                    } else if (card.name == "instantiated1Card21(Clone)") {

                        card.name = "instantiated1HandCard21";

                    } else if (card.name == "instantiated1Card21a(Clone)") {

                        card.name = "instantiated1HandCard21a";

                    } else if (card.name == "instantiated1Card21b(Clone)") {

                        card.name = "instantiated1HandCard21b";

                    } else if (card.name == "instantiated1Card21c(Clone)") {

                        card.name = "instantiated1HandCard21c";

                    } else if (card.name == "instantiated1Card22(Clone)") {

                        card.name = "instantiated1HandCard22";

                    } else if (card.name == "instantiated1Card22a(Clone)") {

                        card.name = "instantiated1HandCard22a";

                    } else if (card.name == "instantiated1Card22b(Clone)") {

                        card.name = "instantiated1HandCard22b";

                    } else if (card.name == "instantiated1Card22c(Clone)") {

                        card.name = "instantiated1HandCard22c";

                    } else if (card.name == "instantiated1Card23(Clone)") {

                        card.name = "instantiated1HandCard23";

                    } else if (card.name == "instantiated1Card23a(Clone)") {

                        card.name = "instantiated1HandCard23a";

                    } else if (card.name == "instantiated1Card23b(Clone)") {

                        card.name = "instantiated1HandCard23b";

                    } else if (card.name == "instantiated1Card23c(Clone)") {

                        card.name = "instantiated1HandCard23c";

                    } else if (card.name == "instantiated1Card24(Clone)") {

                        card.name = "instantiated1HandCard24";

                    } else if (card.name == "instantiated1Card24a(Clone)") {

                        card.name = "instantiated1HandCard24a";

                    } else if (card.name == "instantiated1Card24b(Clone)") {

                        card.name = "instantiated1HandCard24b";

                    } else if (card.name == "instantiated1Card24c(Clone)") {

                        card.name = "instantiated1HandCard24c";

                    } else if (card.name == "instantiated1Card25(Clone)") {

                        card.name = "instantiated1HandCard25";

                    } else if (card.name == "instantiated1Card25a(Clone)") {

                        card.name = "instantiated1HandCard25a";

                    } else if (card.name == "instantiated1Card25b(Clone)") {

                        card.name = "instantiated1HandCard25b";

                    } else if (card.name == "instantiated1Card25c(Clone)") {

                        card.name = "instantiated1HandCard25c";

                    } else if (card.name == "instantiated1Card26(Clone)") {

                        card.name = "instantiated1HandCard26";

                    } else if (card.name == "instantiated1Card26a(Clone)") {

                        card.name = "instantiated1HandCard26a";

                    } else if (card.name == "instantiated1Card26b(Clone)") {

                        card.name = "instantiated1HandCard26b";

                    } else if (card.name == "instantiated1Card26c(Clone)") {

                        card.name = "instantiated1HandCard26c";

                    } else if (card.name == "instantiated1Card27(Clone)") {

                        card.name = "instantiated1HandCard27";

                    } else if (card.name == "instantiated1Card27a(Clone)") {

                        card.name = "instantiated1HandCard27a";

                    } else if (card.name == "instantiated1Card27b(Clone)") {

                        card.name = "instantiated1HandCard27b";

                    } else if (card.name == "instantiated1Card27c(Clone)") {

                        card.name = "instantiated1HandCard27c";

                    } else if (card.name == "instantiated1Card28(Clone)") {

                        card.name = "instantiated1HandCard28";

                    } else if (card.name == "instantiated1Card28a(Clone)") {

                        card.name = "instantiated1HandCard28a";

                    } else if (card.name == "instantiated1Card28b(Clone)") {

                        card.name = "instantiated1HandCard28b";

                    } else if (card.name == "instantiated1Card28c(Clone)") {

                        card.name = "instantiated1HandCard28c";

                    } else if (card.name == "instantiated1Card29(Clone)") {

                        card.name = "instantiated1HandCard29";

                    } else if (card.name == "instantiated1Card29a(Clone)") {

                        card.name = "instantiated1HandCard29a";

                    } else if (card.name == "instantiated1Card29b(Clone)") {

                        card.name = "instantiated1HandCard29b";

                    } else if (card.name == "instantiated1Card29c(Clone)") {

                        card.name = "instantiated1HandCard29c";

                    } else if (card.name == "instantiated1Card30(Clone)") {

                        card.name = "instantiated1HandCard30";

                    } else if (card.name == "instantiated1Card30a(Clone)") {

                        card.name = "instantiated1HandCard30a";

                    } else if (card.name == "instantiated1Card30b(Clone)") {

                        card.name = "instantiated1HandCard30b";

                    } else if (card.name == "instantiated1Card30c(Clone)") {

                        card.name = "instantiated1HandCard30c";

                    } else if (card.name == "instantiated1Card31(Clone)") {

                        card.name = "instantiated1HandCard31";

                    } else if (card.name == "instantiated1Card31a(Clone)") {

                        card.name = "instantiated1HandCard31a";

                    } else if (card.name == "instantiated1Card31b(Clone)") {

                        card.name = "instantiated1HandCard31b";

                    } else if (card.name == "instantiated1Card31c(Clone)") {

                        card.name = "instantiated1HandCard31c";

                    } else if (card.name == "instantiated1Card32(Clone)") {

                        card.name = "instantiated1HandCard32";

                    } else if (card.name == "instantiated1Card32a(Clone)") {

                        card.name = "instantiated1HandCard32a";

                    } else if (card.name == "instantiated1Card32b(Clone)") {

                        card.name = "instantiated1HandCard32b";

                    } else if (card.name == "instantiated1Card32c(Clone)") {

                        card.name = "instantiated1HandCard32c";

                    } else if (card.name == "instantiated1Card33(Clone)") {

                        card.name = "instantiated1HandCard33";

                    } else if (card.name == "instantiated1Card33a(Clone)") {

                        card.name = "instantiated1HandCard33a";

                    } else if (card.name == "instantiated1Card33b(Clone)") {

                        card.name = "instantiated1HandCard33b";

                    } else if (card.name == "instantiated1Card33c(Clone)") {

                        card.name = "instantiated1HandCard33c";

                    } else if (card.name == "instantiated1Card34(Clone)") {

                        card.name = "instantiated1HandCard34";

                    } else if (card.name == "instantiated1Card34a(Clone)") {

                        card.name = "instantiated1HandCard34a";

                    } else if (card.name == "instantiated1Card34b(Clone)") {

                        card.name = "instantiated1HandCard34b";

                    } else if (card.name == "instantiated1Card34c(Clone)") {

                        card.name = "instantiated1HandCard34c";

                    } else if (card.name == "instantiated1Card35(Clone)") {

                        card.name = "instantiated1HandCard35";

                    } else if (card.name == "instantiated1Card35a(Clone)") {

                        card.name = "instantiated1HandCard35a";

                    } else if (card.name == "instantiated1Card35b(Clone)") {

                        card.name = "instantiated1HandCard35b";

                    } else if (card.name == "instantiated1Card35c(Clone)") {

                        card.name = "instantiated1HandCard35c";

                    } else if (card.name == "instantiated1Card36(Clone)") {

                        card.name = "instantiated1HandCard36";

                    } else if (card.name == "instantiated1Card36a(Clone)") {

                        card.name = "instantiated1HandCard36a";

                    } else if (card.name == "instantiated1Card36b(Clone)") {

                        card.name = "instantiated1HandCard36b";

                    } else if (card.name == "instantiated1Card36c(Clone)") {

                        card.name = "instantiated1HandCard36c";

                    } else if (card.name == "instantiated1Card37(Clone)") {

                        card.name = "instantiated1HandCard37";

                    } else if (card.name == "instantiated1Card37a(Clone)") {

                        card.name = "instantiated1HandCard37a";

                    } else if (card.name == "instantiated1Card37b(Clone)") {

                        card.name = "instantiated1HandCard37b";

                    } else if (card.name == "instantiated1Card37c(Clone)") {

                        card.name = "instantiated1HandCard37c";

                    } else if (card.name == "instantiated1Card38(Clone)") {

                        card.name = "instantiated1HandCard38";

                    } else if (card.name == "instantiated1Card38a(Clone)") {

                        card.name = "instantiated1HandCard38a";

                    } else if (card.name == "instantiated1Card38b(Clone)") {

                        card.name = "instantiated1HandCard38b";

                    } else if (card.name == "instantiated1Card38c(Clone)") {

                        card.name = "instantiated1HandCard38c";

                    } else if (card.name == "instantiated1Card39(Clone)") {

                        card.name = "instantiated1HandCard39";

                    } else if (card.name == "instantiated1Card39a(Clone)") {

                        card.name = "instantiated1HandCard39a";

                    } else if (card.name == "instantiated1Card39b(Clone)") {

                        card.name = "instantiated1HandCard39b";

                    } else if (card.name == "instantiated1Card39c(Clone)") {

                        card.name = "instantiated1HandCard39c";

                    } else if (card.name == "instantiated1Card40(Clone)") {

                        card.name = "instantiated1HandCard40";

                    } else if (card.name == "instantiated1Card40a(Clone)") {

                        card.name = "instantiated1HandCard40a";

                    } else if (card.name == "instantiated1Card40b(Clone)") {

                        card.name = "instantiated1HandCard40b";

                    } else if (card.name == "instantiated1Card40c(Clone)") {

                        card.name = "instantiated1HandCard40c";

                    } else if (card.name == "instantiated1Card41(Clone)") {

                        card.name = "instantiated1HandCard41";

                    } else if (card.name == "instantiated1Card41a(Clone)") {

                        card.name = "instantiated1HandCard41a";

                    } else if (card.name == "instantiated1Card41b(Clone)") {

                        card.name = "instantiated1HandCard41b";

                    } else if (card.name == "instantiated1Card41c(Clone)") {

                        card.name = "instantiated1HandCard41c";

                    } else if (card.name == "instantiated1Card42(Clone)") {

                        card.name = "instantiated1HandCard42";

                    } else if (card.name == "instantiated1Card42a(Clone)") {

                        card.name = "instantiated1HandCard42a";

                    } else if (card.name == "instantiated1Card42b(Clone)") {

                        card.name = "instantiated1HandCard42b";

                    } else if (card.name == "instantiated1Card42c(Clone)") {

                        card.name = "instantiated1HandCard42c";

                    } else if (card.name == "instantiated1Card43(Clone)") {

                        card.name = "instantiated1HandCard43";

                    } else if (card.name == "instantiated1Card43a(Clone)") {

                        card.name = "instantiated1HandCard43a";

                    } else if (card.name == "instantiated1Card43b(Clone)") {

                        card.name = "instantiated1HandCard43b";

                    } else if (card.name == "instantiated1Card43c(Clone)") {

                        card.name = "instantiated1HandCard43c";

                    } else if (card.name == "instantiated1Card44(Clone)") {

                        card.name = "instantiated1HandCard44";

                    } else if (card.name == "instantiated1Card44a(Clone)") {

                        card.name = "instantiated1HandCard44a";

                    } else if (card.name == "instantiated1Card44b(Clone)") {

                        card.name = "instantiated1HandCard44b";

                    } else if (card.name == "instantiated1Card44c(Clone)") {

                        card.name = "instantiated1HandCard44c";

                    } else if (card.name == "instantiated1Card45(Clone)") {

                        card.name = "instantiated1HandCard45";

                    } else if (card.name == "instantiated1Card45a(Clone)") {

                        card.name = "instantiated1HandCard45a";

                    } else if (card.name == "instantiated1Card45b(Clone)") {

                        card.name = "instantiated1HandCard45b";

                    } else if (card.name == "instantiated1Card45c(Clone)") {

                        card.name = "instantiated1HandCard45c";

                    } else if (card.name == "instantiated1Card46(Clone)") {

                        card.name = "instantiated1HandCard46";

                    } else if (card.name == "instantiated1Card46a(Clone)") {

                        card.name = "instantiated1HandCard46a";

                    } else if (card.name == "instantiated1Card46b(Clone)") {

                        card.name = "instantiated1HandCard46b";

                    } else if (card.name == "instantiated1Card46c(Clone)") {

                        card.name = "instantiated1HandCard46c";

                    } else if (card.name == "instantiated1Card47(Clone)") {

                        card.name = "instantiated1HandCard47";

                    } else if (card.name == "instantiated1Card47a(Clone)") {

                        card.name = "instantiated1HandCard47a";

                    } else if (card.name == "instantiated1Card47b(Clone)") {

                        card.name = "instantiated1HandCard47b";

                    } else if (card.name == "instantiated1Card47c(Clone)") {

                        card.name = "instantiated1HandCard47c";

                    } else if (card.name == "instantiated1Card48(Clone)") {

                        card.name = "instantiated1HandCard48";

                    } else if (card.name == "instantiated1Card48a(Clone)") {

                        card.name = "instantiated1HandCard48a";

                    } else if (card.name == "instantiated1Card48b(Clone)") {

                        card.name = "instantiated1HandCard48b";

                    } else if (card.name == "instantiated1Card48c(Clone)") {

                        card.name = "instantiated1HandCard48c";

                    } else if (card.name == "instantiated1Card49(Clone)") {

                        card.name = "instantiated1HandCard49";

                    } else if (card.name == "instantiated1Card49a(Clone)") {

                        card.name = "instantiated1HandCard49a";

                    } else if (card.name == "instantiated1Card49b(Clone)") {

                        card.name = "instantiated1HandCard49b";

                    } else if (card.name == "instantiated1Card49c(Clone)") {

                        card.name = "instantiated1HandCard49c";

                    } else if (card.name == "instantiated1Card50(Clone)") {

                        card.name = "instantiated1HandCard50";

                    } else if (card.name == "instantiated1Card50a(Clone)") {

                        card.name = "instantiated1HandCard50a";

                    } else if (card.name == "instantiated1Card50b(Clone)") {

                        card.name = "instantiated1HandCard50b";

                    } else if (card.name == "instantiated1Card50c(Clone)") {

                        card.name = "instantiated1HandCard50c";

                    } else if (card.name == "instantiated1Card51(Clone)") {

                        card.name = "instantiated1HandCard51";

                    } else if (card.name == "instantiated1Card51a(Clone)") {

                        card.name = "instantiated1HandCard51a";

                    } else if (card.name == "instantiated1Card51b(Clone)") {

                        card.name = "instantiated1HandCard51b";

                    } else if (card.name == "instantiated1Card51c(Clone)") {

                        card.name = "instantiated1HandCard51c";

                    } else if (card.name == "instantiated1Card52(Clone)") {

                        card.name = "instantiated1HandCard52";

                    } else if (card.name == "instantiated1Card52a(Clone)") {

                        card.name = "instantiated1HandCard52a";

                    } else if (card.name == "instantiated1Card52b(Clone)") {

                        card.name = "instantiated1HandCard52b";

                    } else if (card.name == "instantiated1Card52c(Clone)") {

                        card.name = "instantiated1HandCard52c";

                    } else if (card.name == "instantiated1Card53(Clone)") {

                        card.name = "instantiated1HandCard53";

                    } else if (card.name == "instantiated1Card53a(Clone)") {

                        card.name = "instantiated1HandCard53a";

                    } else if (card.name == "instantiated1Card53b(Clone)") {

                        card.name = "instantiated1HandCard53b";

                    } else if (card.name == "instantiated1Card53c(Clone)") {

                        card.name = "instantiated1HandCard53c";

                    } else if (card.name == "instantiated1Card54(Clone)") {

                        card.name = "instantiated1HandCard54";

                    } else if (card.name == "instantiated1Card54a(Clone)") {

                        card.name = "instantiated1HandCard54a";

                    } else if (card.name == "instantiated1Card54b(Clone)") {

                        card.name = "instantiated1HandCard54b";

                    } else if (card.name == "instantiated1Card54c(Clone)") {

                        card.name = "instantiated1HandCard54c";

                    } else if (card.name == "instantiated1Card55(Clone)") {

                        card.name = "instantiated1HandCard55";

                    } else if (card.name == "instantiated1Card55a(Clone)") {

                        card.name = "instantiated1HandCard55a";

                    } else if (card.name == "instantiated1Card55b(Clone)") {

                        card.name = "instantiated1HandCard55b";

                    } else if (card.name == "instantiated1Card55c(Clone)") {

                        card.name = "instantiated1HandCard55c";

                    } else if (card.name == "instantiated1Card56(Clone)") {

                        card.name = "instantiated1HandCard56";

                    } else if (card.name == "instantiated1Card56a(Clone)") {

                        card.name = "instantiated1HandCard56a";

                    } else if (card.name == "instantiated1Card56b(Clone)") {

                        card.name = "instantiated1HandCard56b";

                    } else if (card.name == "instantiated1Card56c(Clone)") {

                        card.name = "instantiated1HandCard56c";

                    } else if (card.name == "instantiated1Card57(Clone)") {

                        card.name = "instantiated1HandCard57";

                    } else if (card.name == "instantiated1Card57a(Clone)") {

                        card.name = "instantiated1HandCard57a";

                    } else if (card.name == "instantiated1Card57b(Clone)") {

                        card.name = "instantiated1HandCard57b";

                    } else if (card.name == "instantiated1Card57c(Clone)") {

                        card.name = "instantiated1HandCard57c";

                    } else if (card.name == "instantiated1Card58(Clone)") {

                        card.name = "instantiated1HandCard58";

                    } else if (card.name == "instantiated1Card58a(Clone)") {

                        card.name = "instantiated1HandCard58a";

                    } else if (card.name == "instantiated1Card58b(Clone)") {

                        card.name = "instantiated1HandCard58b";

                    } else if (card.name == "instantiated1Card58c(Clone)") {

                        card.name = "instantiated1HandCard58c";

                    } else if (card.name == "instantiated1Card59(Clone)") {

                        card.name = "instantiated1HandCard59";

                    } else if (card.name == "instantiated1Card59a(Clone)") {

                        card.name = "instantiated1HandCard59a";

                    } else if (card.name == "instantiated1Card59b(Clone)") {

                        card.name = "instantiated1HandCard59b";

                    } else if (card.name == "instantiated1Card59c(Clone)") {

                        card.name = "instantiated1HandCard59c";

                    } else if (card.name == "instantiated1Card60(Clone)") {

                        card.name = "instantiated1HandCard60";

                    } else if (card.name == "instantiated1Card60a(Clone)") {

                        card.name = "instantiated1HandCard60a";

                    } else if (card.name == "instantiated1Card60b(Clone)") {

                        card.name = "instantiated1HandCard60b";

                    } else if (card.name == "instantiated1Card60c(Clone)") {

                        card.name = "instantiated1HandCard60c";
                    }

                    instances1M++;

                }


            }

            if (player1DeckSlot2.transform.childCount == 0) {

                while (instances2M < NumberOfCards) {

                    GameObject card = Instantiate(playCardsDeck1[UnityEngine.Random.Range(0, playCardsDeck1.Count)], player1DeckSlot2.transform.position, player1DeckSlot2.transform.rotation) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.transform.parent = player1DeckSlot2.transform;

                    if (card.name == "instantiated1Card1(Clone)") {

                        card.name = "instantiated1HandCard1";

                    } else if (card.name == "instantiated1Card1a(Clone)") {

                        card.name = "instantiated1HandCard1a";

                    } else if (card.name == "instantiated1Card1b(Clone)") {

                        card.name = "instantiated1HandCard1b";

                    } else if (card.name == "instantiated1Card1c(Clone)") {

                        card.name = "instantiated1HandCard1c";

                    } else if (card.name == "instantiated1Card2(Clone)") {

                        card.name = "instantiated1HandCard2";

                    } else if (card.name == "instantiated1Card2a(Clone)") {

                        card.name = "instantiated1HandCard2a";

                    } else if (card.name == "instantiated1Card2b(Clone)") {

                        card.name = "instantiated1HandCard2b";

                    } else if (card.name == "instantiated1Card2c(Clone)") {

                        card.name = "instantiated1HandCard2c";

                    } else if (card.name == "instantiated1Card3(Clone)") {

                        card.name = "instantiated1HandCard3";

                    } else if (card.name == "instantiated1Card3a(Clone)") {

                        card.name = "instantiated1HandCard3a";

                    } else if (card.name == "instantiated1Card3b(Clone)") {

                        card.name = "instantiated1HandCard3b";

                    } else if (card.name == "instantiated1Card3c(Clone)") {

                        card.name = "instantiated1HandCard3c";

                    } else if (card.name == "instantiated1Card4(Clone)") {

                        card.name = "instantiated1HandCard4";

                    } else if (card.name == "instantiated1Card4a(Clone)") {

                        card.name = "instantiated1HandCard4a";

                    } else if (card.name == "instantiated1Card4b(Clone)") {

                        card.name = "instantiated1HandCard4b";

                    } else if (card.name == "instantiated1Card4c(Clone)") {

                        card.name = "instantiated1HandCard4c";

                    } else if (card.name == "instantiated1Card5(Clone)") {

                        card.name = "instantiated1HandCard5";

                    } else if (card.name == "instantiated1Card5a(Clone)") {

                        card.name = "instantiated1HandCard5a";

                    } else if (card.name == "instantiated1Card5b(Clone)") {

                        card.name = "instantiated1HandCard5b";

                    } else if (card.name == "instantiated1Card5c(Clone)") {

                        card.name = "instantiated1HandCard5c";

                    } else if (card.name == "instantiated1Card6(Clone)") {

                        card.name = "instantiated1HandCard6";

                    } else if (card.name == "instantiated1Card6a(Clone)") {

                        card.name = "instantiated1HandCard6a";

                    } else if (card.name == "instantiated1Card6b(Clone)") {

                        card.name = "instantiated1HandCard6b";

                    } else if (card.name == "instantiated1Card6c(Clone)") {

                        card.name = "instantiated1HandCard6c";

                    } else if (card.name == "instantiated1Card7(Clone)") {

                        card.name = "instantiated1HandCard7";

                    } else if (card.name == "instantiated1Card7a(Clone)") {

                        card.name = "instantiated1HandCard7a";

                    } else if (card.name == "instantiated1Card7b(Clone)") {

                        card.name = "instantiated1HandCard7b";

                    } else if (card.name == "instantiated1Card7c(Clone)") {

                        card.name = "instantiated1HandCard7c";

                    } else if (card.name == "instantiated1Card8(Clone)") {

                        card.name = "instantiated1HandCard8";

                    } else if (card.name == "instantiated1Card8a(Clone)") {

                        card.name = "instantiated1HandCard8a";

                    } else if (card.name == "instantiated1Card8b(Clone)") {

                        card.name = "instantiated1HandCard8b";

                    } else if (card.name == "instantiated1Card8c(Clone)") {

                        card.name = "instantiated1HandCard8c";

                    } else if (card.name == "instantiated1Card9(Clone)") {

                        card.name = "instantiated1HandCard9";

                    } else if (card.name == "instantiated1Card9a(Clone)") {

                        card.name = "instantiated1HandCard9a";

                    } else if (card.name == "instantiated1Card9b(Clone)") {

                        card.name = "instantiated1HandCard9b";

                    } else if (card.name == "instantiated1Card9c(Clone)") {

                        card.name = "instantiated1HandCard9c";

                    } else if (card.name == "instantiated1Card10(Clone)") {

                        card.name = "instantiatedAICard10";

                    } else if (card.name == "instantiated1Card10a(Clone)") {

                        card.name = "instantiated1HandCard10a";

                    } else if (card.name == "instantiated1Card10b(Clone)") {

                        card.name = "instantiated1HandCard10b";

                    } else if (card.name == "instantiated1Card10c(Clone)") {

                        card.name = "instantiated1HandCard10c";

                    } else if (card.name == "instantiated1Card11(Clone)") {

                        card.name = "instantiated1HandCard11";

                    } else if (card.name == "instantiated1Card11a(Clone)") {

                        card.name = "instantiated1HandCard11a";

                    } else if (card.name == "instantiated1Card11b(Clone)") {

                        card.name = "instantiated1HandCard11b";

                    } else if (card.name == "instantiated1Card11c(Clone)") {

                        card.name = "instantiated1HandCard11c";

                    } else if (card.name == "instantiated1Card12(Clone)") {

                        card.name = "instantiated1HandCard12";

                    } else if (card.name == "instantiated1Card12a(Clone)") {

                        card.name = "instantiated1HandCard12a";

                    } else if (card.name == "instantiated1Card12b(Clone)") {

                        card.name = "instantiated1HandCard12b";

                    } else if (card.name == "instantiated1Card12c(Clone)") {

                        card.name = "instantiated1HandCard12c";

                    } else if (card.name == "instantiated1Card13(Clone)") {

                        card.name = "instantiated1HandCard13";

                    } else if (card.name == "instantiated1Card13a(Clone)") {

                        card.name = "instantiated1HandCard13a";

                    } else if (card.name == "instantiated1Card13b(Clone)") {

                        card.name = "instantiated1HandCard13b";

                    } else if (card.name == "instantiated1Card13c(Clone)") {

                        card.name = "instantiated1HandCard13c";

                    } else if (card.name == "instantiated1Card14(Clone)") {

                        card.name = "instantiated1HandCard14";

                    } else if (card.name == "instantiated1Card14a(Clone)") {

                        card.name = "instantiated1HandCard14a";

                    } else if (card.name == "instantiated1Card14b(Clone)") {

                        card.name = "instantiated1HandCard14b";

                    } else if (card.name == "instantiated1Card14c(Clone)") {

                        card.name = "instantiated1HandCard14c";

                    } else if (card.name == "instantiated1Card15(Clone)") {

                        card.name = "instantiated1HandCard15";

                    } else if (card.name == "instantiated1Card15a(Clone)") {

                        card.name = "instantiated1HandCard15a";

                    } else if (card.name == "instantiated1Card15b(Clone)") {

                        card.name = "instantiated1HandCard15b";

                    } else if (card.name == "instantiated1Card15c(Clone)") {

                        card.name = "instantiated1HandCard15c";

                    } else if (card.name == "instantiated1Card16(Clone)") {

                        card.name = "instantiated1HandCard16";

                    } else if (card.name == "instantiated1Card16a(Clone)") {

                        card.name = "instantiated1HandCard16a";

                    } else if (card.name == "instantiated1Card16b(Clone)") {

                        card.name = "instantiated1HandCard16b";

                    } else if (card.name == "instantiated1Card16c(Clone)") {

                        card.name = "instantiated1HandCard16c";

                    } else if (card.name == "instantiated1Card17(Clone)") {

                        card.name = "instantiated1HandCard17";

                    } else if (card.name == "instantiated1Card17a(Clone)") {

                        card.name = "instantiated1HandCard17a";

                    } else if (card.name == "instantiated1Card17b(Clone)") {

                        card.name = "instantiated1HandCard17b";

                    } else if (card.name == "instantiated1Card17c(Clone)") {

                        card.name = "instantiated1HandCard17c";

                    } else if (card.name == "instantiated1Card18(Clone)") {

                        card.name = "instantiated1HandCard18";

                    } else if (card.name == "instantiated1Card18a(Clone)") {

                        card.name = "instantiated1HandCard18a";

                    } else if (card.name == "instantiated1Card18b(Clone)") {

                        card.name = "instantiated1HandCard18b";

                    } else if (card.name == "instantiated1Card18c(Clone)") {

                        card.name = "instantiated1HandCard18c";

                    } else if (card.name == "instantiated1Card19(Clone)") {

                        card.name = "instantiated1HandCard19";

                    } else if (card.name == "instantiated1Card19a(Clone)") {

                        card.name = "instantiated1HandCard19a";

                    } else if (card.name == "instantiated1Card19b(Clone)") {

                        card.name = "instantiated1HandCard19b";

                    } else if (card.name == "instantiated1Card19c(Clone)") {

                        card.name = "instantiated1HandCard19c";

                    } else if (card.name == "instantiated1Card20(Clone)") {

                        card.name = "instantiated1HandCard20";

                    } else if (card.name == "instantiated1Card20a(Clone)") {

                        card.name = "instantiated1HandCard20a";

                    } else if (card.name == "instantiated1Card20b(Clone)") {

                        card.name = "instantiated1HandCard20b";

                    } else if (card.name == "instantiated1Card20c(Clone)") {

                        card.name = "instantiated1HandCard20c";

                    } else if (card.name == "instantiated1Card21(Clone)") {

                        card.name = "instantiated1HandCard21";

                    } else if (card.name == "instantiated1Card21a(Clone)") {

                        card.name = "instantiated1HandCard21a";

                    } else if (card.name == "instantiated1Card21b(Clone)") {

                        card.name = "instantiated1HandCard21b";

                    } else if (card.name == "instantiated1Card21c(Clone)") {

                        card.name = "instantiated1HandCard21c";

                    } else if (card.name == "instantiated1Card22(Clone)") {

                        card.name = "instantiated1HandCard22";

                    } else if (card.name == "instantiated1Card22a(Clone)") {

                        card.name = "instantiated1HandCard22a";

                    } else if (card.name == "instantiated1Card22b(Clone)") {

                        card.name = "instantiated1HandCard22b";

                    } else if (card.name == "instantiated1Card22c(Clone)") {

                        card.name = "instantiated1HandCard22c";

                    } else if (card.name == "instantiated1Card23(Clone)") {

                        card.name = "instantiated1HandCard23";

                    } else if (card.name == "instantiated1Card23a(Clone)") {

                        card.name = "instantiated1HandCard23a";

                    } else if (card.name == "instantiated1Card23b(Clone)") {

                        card.name = "instantiated1HandCard23b";

                    } else if (card.name == "instantiated1Card23c(Clone)") {

                        card.name = "instantiated1HandCard23c";

                    } else if (card.name == "instantiated1Card24(Clone)") {

                        card.name = "instantiated1HandCard24";

                    } else if (card.name == "instantiated1Card24a(Clone)") {

                        card.name = "instantiated1HandCard24a";

                    } else if (card.name == "instantiated1Card24b(Clone)") {

                        card.name = "instantiated1HandCard24b";

                    } else if (card.name == "instantiated1Card24c(Clone)") {

                        card.name = "instantiated1HandCard24c";

                    } else if (card.name == "instantiated1Card25(Clone)") {

                        card.name = "instantiated1HandCard25";

                    } else if (card.name == "instantiated1Card25a(Clone)") {

                        card.name = "instantiated1HandCard25a";

                    } else if (card.name == "instantiated1Card25b(Clone)") {

                        card.name = "instantiated1HandCard25b";

                    } else if (card.name == "instantiated1Card25c(Clone)") {

                        card.name = "instantiated1HandCard25c";

                    } else if (card.name == "instantiated1Card26(Clone)") {

                        card.name = "instantiated1HandCard26";

                    } else if (card.name == "instantiated1Card26a(Clone)") {

                        card.name = "instantiated1HandCard26a";

                    } else if (card.name == "instantiated1Card26b(Clone)") {

                        card.name = "instantiated1HandCard26b";

                    } else if (card.name == "instantiated1Card26c(Clone)") {

                        card.name = "instantiated1HandCard26c";

                    } else if (card.name == "instantiated1Card27(Clone)") {

                        card.name = "instantiated1HandCard27";

                    } else if (card.name == "instantiated1Card27a(Clone)") {

                        card.name = "instantiated1HandCard27a";

                    } else if (card.name == "instantiated1Card27b(Clone)") {

                        card.name = "instantiated1HandCard27b";

                    } else if (card.name == "instantiated1Card27c(Clone)") {

                        card.name = "instantiated1HandCard27c";

                    } else if (card.name == "instantiated1Card28(Clone)") {

                        card.name = "instantiated1HandCard28";

                    } else if (card.name == "instantiated1Card28a(Clone)") {

                        card.name = "instantiated1HandCard28a";

                    } else if (card.name == "instantiated1Card28b(Clone)") {

                        card.name = "instantiated1HandCard28b";

                    } else if (card.name == "instantiated1Card28c(Clone)") {

                        card.name = "instantiated1HandCard28c";

                    } else if (card.name == "instantiated1Card29(Clone)") {

                        card.name = "instantiated1HandCard29";

                    } else if (card.name == "instantiated1Card29a(Clone)") {

                        card.name = "instantiated1HandCard29a";

                    } else if (card.name == "instantiated1Card29b(Clone)") {

                        card.name = "instantiated1HandCard29b";

                    } else if (card.name == "instantiated1Card29c(Clone)") {

                        card.name = "instantiated1HandCard29c";

                    } else if (card.name == "instantiated1Card30(Clone)") {

                        card.name = "instantiated1HandCard30";

                    } else if (card.name == "instantiated1Card30a(Clone)") {

                        card.name = "instantiated1HandCard30a";

                    } else if (card.name == "instantiated1Card30b(Clone)") {

                        card.name = "instantiated1HandCard30b";

                    } else if (card.name == "instantiated1Card30c(Clone)") {

                        card.name = "instantiated1HandCard30c";

                    } else if (card.name == "instantiated1Card31(Clone)") {

                        card.name = "instantiated1HandCard31";

                    } else if (card.name == "instantiated1Card31a(Clone)") {

                        card.name = "instantiated1HandCard31a";

                    } else if (card.name == "instantiated1Card31b(Clone)") {

                        card.name = "instantiated1HandCard31b";

                    } else if (card.name == "instantiated1Card31c(Clone)") {

                        card.name = "instantiated1HandCard31c";

                    } else if (card.name == "instantiated1Card32(Clone)") {

                        card.name = "instantiated1HandCard32";

                    } else if (card.name == "instantiated1Card32a(Clone)") {

                        card.name = "instantiated1HandCard32a";

                    } else if (card.name == "instantiated1Card32b(Clone)") {

                        card.name = "instantiated1HandCard32b";

                    } else if (card.name == "instantiated1Card32c(Clone)") {

                        card.name = "instantiated1HandCard32c";

                    } else if (card.name == "instantiated1Card33(Clone)") {

                        card.name = "instantiated1HandCard33";

                    } else if (card.name == "instantiated1Card33a(Clone)") {

                        card.name = "instantiated1HandCard33a";

                    } else if (card.name == "instantiated1Card33b(Clone)") {

                        card.name = "instantiated1HandCard33b";

                    } else if (card.name == "instantiated1Card33c(Clone)") {

                        card.name = "instantiated1HandCard33c";

                    } else if (card.name == "instantiated1Card34(Clone)") {

                        card.name = "instantiated1HandCard34";

                    } else if (card.name == "instantiated1Card34a(Clone)") {

                        card.name = "instantiated1HandCard34a";

                    } else if (card.name == "instantiated1Card34b(Clone)") {

                        card.name = "instantiated1HandCard34b";

                    } else if (card.name == "instantiated1Card34c(Clone)") {

                        card.name = "instantiated1HandCard34c";

                    } else if (card.name == "instantiated1Card35(Clone)") {

                        card.name = "instantiated1HandCard35";

                    } else if (card.name == "instantiated1Card35a(Clone)") {

                        card.name = "instantiated1HandCard35a";

                    } else if (card.name == "instantiated1Card35b(Clone)") {

                        card.name = "instantiated1HandCard35b";

                    } else if (card.name == "instantiated1Card35c(Clone)") {

                        card.name = "instantiated1HandCard35c";

                    } else if (card.name == "instantiated1Card36(Clone)") {

                        card.name = "instantiated1HandCard36";

                    } else if (card.name == "instantiated1Card36a(Clone)") {

                        card.name = "instantiated1HandCard36a";

                    } else if (card.name == "instantiated1Card36b(Clone)") {

                        card.name = "instantiated1HandCard36b";

                    } else if (card.name == "instantiated1Card36c(Clone)") {

                        card.name = "instantiated1HandCard36c";

                    } else if (card.name == "instantiated1Card37(Clone)") {

                        card.name = "instantiated1HandCard37";

                    } else if (card.name == "instantiated1Card37a(Clone)") {

                        card.name = "instantiated1HandCard37a";

                    } else if (card.name == "instantiated1Card37b(Clone)") {

                        card.name = "instantiated1HandCard37b";

                    } else if (card.name == "instantiated1Card37c(Clone)") {

                        card.name = "instantiated1HandCard37c";

                    } else if (card.name == "instantiated1Card38(Clone)") {

                        card.name = "instantiated1HandCard38";

                    } else if (card.name == "instantiated1Card38a(Clone)") {

                        card.name = "instantiated1HandCard38a";

                    } else if (card.name == "instantiated1Card38b(Clone)") {

                        card.name = "instantiated1HandCard38b";

                    } else if (card.name == "instantiated1Card38c(Clone)") {

                        card.name = "instantiated1HandCard38c";

                    } else if (card.name == "instantiated1Card39(Clone)") {

                        card.name = "instantiated1HandCard39";

                    } else if (card.name == "instantiated1Card39a(Clone)") {

                        card.name = "instantiated1HandCard39a";

                    } else if (card.name == "instantiated1Card39b(Clone)") {

                        card.name = "instantiated1HandCard39b";

                    } else if (card.name == "instantiated1Card39c(Clone)") {

                        card.name = "instantiated1HandCard39c";

                    } else if (card.name == "instantiated1Card40(Clone)") {

                        card.name = "instantiated1HandCard40";

                    } else if (card.name == "instantiated1Card40a(Clone)") {

                        card.name = "instantiated1HandCard40a";

                    } else if (card.name == "instantiated1Card40b(Clone)") {

                        card.name = "instantiated1HandCard40b";

                    } else if (card.name == "instantiated1Card40c(Clone)") {

                        card.name = "instantiated1HandCard40c";

                    } else if (card.name == "instantiated1Card41(Clone)") {

                        card.name = "instantiated1HandCard41";

                    } else if (card.name == "instantiated1Card41a(Clone)") {

                        card.name = "instantiated1HandCard41a";

                    } else if (card.name == "instantiated1Card41b(Clone)") {

                        card.name = "instantiated1HandCard41b";

                    } else if (card.name == "instantiated1Card41c(Clone)") {

                        card.name = "instantiated1HandCard41c";

                    } else if (card.name == "instantiated1Card42(Clone)") {

                        card.name = "instantiated1HandCard42";

                    } else if (card.name == "instantiated1Card42a(Clone)") {

                        card.name = "instantiated1HandCard42a";

                    } else if (card.name == "instantiated1Card42b(Clone)") {

                        card.name = "instantiated1HandCard42b";

                    } else if (card.name == "instantiated1Card42c(Clone)") {

                        card.name = "instantiated1HandCard42c";

                    } else if (card.name == "instantiated1Card43(Clone)") {

                        card.name = "instantiated1HandCard43";

                    } else if (card.name == "instantiated1Card43a(Clone)") {

                        card.name = "instantiated1HandCard43a";

                    } else if (card.name == "instantiated1Card43b(Clone)") {

                        card.name = "instantiated1HandCard43b";

                    } else if (card.name == "instantiated1Card43c(Clone)") {

                        card.name = "instantiated1HandCard43c";

                    } else if (card.name == "instantiated1Card44(Clone)") {

                        card.name = "instantiated1HandCard44";

                    } else if (card.name == "instantiated1Card44a(Clone)") {

                        card.name = "instantiated1HandCard44a";

                    } else if (card.name == "instantiated1Card44b(Clone)") {

                        card.name = "instantiated1HandCard44b";

                    } else if (card.name == "instantiated1Card44c(Clone)") {

                        card.name = "instantiated1HandCard44c";

                    } else if (card.name == "instantiated1Card45(Clone)") {

                        card.name = "instantiated1HandCard45";

                    } else if (card.name == "instantiated1Card45a(Clone)") {

                        card.name = "instantiated1HandCard45a";

                    } else if (card.name == "instantiated1Card45b(Clone)") {

                        card.name = "instantiated1HandCard45b";

                    } else if (card.name == "instantiated1Card45c(Clone)") {

                        card.name = "instantiated1HandCard45c";

                    } else if (card.name == "instantiated1Card46(Clone)") {

                        card.name = "instantiated1HandCard46";

                    } else if (card.name == "instantiated1Card46a(Clone)") {

                        card.name = "instantiated1HandCard46a";

                    } else if (card.name == "instantiated1Card46b(Clone)") {

                        card.name = "instantiated1HandCard46b";

                    } else if (card.name == "instantiated1Card46c(Clone)") {

                        card.name = "instantiated1HandCard46c";

                    } else if (card.name == "instantiated1Card47(Clone)") {

                        card.name = "instantiated1HandCard47";

                    } else if (card.name == "instantiated1Card47a(Clone)") {

                        card.name = "instantiated1HandCard47a";

                    } else if (card.name == "instantiated1Card47b(Clone)") {

                        card.name = "instantiated1HandCard47b";

                    } else if (card.name == "instantiated1Card47c(Clone)") {

                        card.name = "instantiated1HandCard47c";

                    } else if (card.name == "instantiated1Card48(Clone)") {

                        card.name = "instantiated1HandCard48";

                    } else if (card.name == "instantiated1Card48a(Clone)") {

                        card.name = "instantiated1HandCard48a";

                    } else if (card.name == "instantiated1Card48b(Clone)") {

                        card.name = "instantiated1HandCard48b";

                    } else if (card.name == "instantiated1Card48c(Clone)") {

                        card.name = "instantiated1HandCard48c";

                    } else if (card.name == "instantiated1Card49(Clone)") {

                        card.name = "instantiated1HandCard49";

                    } else if (card.name == "instantiated1Card49a(Clone)") {

                        card.name = "instantiated1HandCard49a";

                    } else if (card.name == "instantiated1Card49b(Clone)") {

                        card.name = "instantiated1HandCard49b";

                    } else if (card.name == "instantiated1Card49c(Clone)") {

                        card.name = "instantiated1HandCard49c";

                    } else if (card.name == "instantiated1Card50(Clone)") {

                        card.name = "instantiated1HandCard50";

                    } else if (card.name == "instantiated1Card50a(Clone)") {

                        card.name = "instantiated1HandCard50a";

                    } else if (card.name == "instantiated1Card50b(Clone)") {

                        card.name = "instantiated1HandCard50b";

                    } else if (card.name == "instantiated1Card50c(Clone)") {

                        card.name = "instantiated1HandCard50c";

                    } else if (card.name == "instantiated1Card51(Clone)") {

                        card.name = "instantiated1HandCard51";

                    } else if (card.name == "instantiated1Card51a(Clone)") {

                        card.name = "instantiated1HandCard51a";

                    } else if (card.name == "instantiated1Card51b(Clone)") {

                        card.name = "instantiated1HandCard51b";

                    } else if (card.name == "instantiated1Card51c(Clone)") {

                        card.name = "instantiated1HandCard51c";

                    } else if (card.name == "instantiated1Card52(Clone)") {

                        card.name = "instantiated1HandCard52";

                    } else if (card.name == "instantiated1Card52a(Clone)") {

                        card.name = "instantiated1HandCard52a";

                    } else if (card.name == "instantiated1Card52b(Clone)") {

                        card.name = "instantiated1HandCard52b";

                    } else if (card.name == "instantiated1Card52c(Clone)") {

                        card.name = "instantiated1HandCard52c";

                    } else if (card.name == "instantiated1Card53(Clone)") {

                        card.name = "instantiated1HandCard53";

                    } else if (card.name == "instantiated1Card53a(Clone)") {

                        card.name = "instantiated1HandCard53a";

                    } else if (card.name == "instantiated1Card53b(Clone)") {

                        card.name = "instantiated1HandCard53b";

                    } else if (card.name == "instantiated1Card53c(Clone)") {

                        card.name = "instantiated1HandCard53c";

                    } else if (card.name == "instantiated1Card54(Clone)") {

                        card.name = "instantiated1HandCard54";

                    } else if (card.name == "instantiated1Card54a(Clone)") {

                        card.name = "instantiated1HandCard54a";

                    } else if (card.name == "instantiated1Card54b(Clone)") {

                        card.name = "instantiated1HandCard54b";

                    } else if (card.name == "instantiated1Card54c(Clone)") {

                        card.name = "instantiated1HandCard54c";

                    } else if (card.name == "instantiated1Card55(Clone)") {

                        card.name = "instantiated1HandCard55";

                    } else if (card.name == "instantiated1Card55a(Clone)") {

                        card.name = "instantiated1HandCard55a";

                    } else if (card.name == "instantiated1Card55b(Clone)") {

                        card.name = "instantiated1HandCard55b";

                    } else if (card.name == "instantiated1Card55c(Clone)") {

                        card.name = "instantiated1HandCard55c";

                    } else if (card.name == "instantiated1Card56(Clone)") {

                        card.name = "instantiated1HandCard56";

                    } else if (card.name == "instantiated1Card56a(Clone)") {

                        card.name = "instantiated1HandCard56a";

                    } else if (card.name == "instantiated1Card56b(Clone)") {

                        card.name = "instantiated1HandCard56b";

                    } else if (card.name == "instantiated1Card56c(Clone)") {

                        card.name = "instantiated1HandCard56c";

                    } else if (card.name == "instantiated1Card57(Clone)") {

                        card.name = "instantiated1HandCard57";

                    } else if (card.name == "instantiated1Card57a(Clone)") {

                        card.name = "instantiated1HandCard57a";

                    } else if (card.name == "instantiated1Card57b(Clone)") {

                        card.name = "instantiated1HandCard57b";

                    } else if (card.name == "instantiated1Card57c(Clone)") {

                        card.name = "instantiated1HandCard57c";

                    } else if (card.name == "instantiated1Card58(Clone)") {

                        card.name = "instantiated1HandCard58";

                    } else if (card.name == "instantiated1Card58a(Clone)") {

                        card.name = "instantiated1HandCard58a";

                    } else if (card.name == "instantiated1Card58b(Clone)") {

                        card.name = "instantiated1HandCard58b";

                    } else if (card.name == "instantiated1Card58c(Clone)") {

                        card.name = "instantiated1HandCard58c";

                    } else if (card.name == "instantiated1Card59(Clone)") {

                        card.name = "instantiated1HandCard59";

                    } else if (card.name == "instantiated1Card59a(Clone)") {

                        card.name = "instantiated1HandCard59a";

                    } else if (card.name == "instantiated1Card59b(Clone)") {

                        card.name = "instantiated1HandCard59b";

                    } else if (card.name == "instantiated1Card59c(Clone)") {

                        card.name = "instantiated1HandCard59c";

                    } else if (card.name == "instantiated1Card60(Clone)") {

                        card.name = "instantiated1HandCard60";

                    } else if (card.name == "instantiated1Card60a(Clone)") {

                        card.name = "instantiated1HandCard60a";

                    } else if (card.name == "instantiated1Card60b(Clone)") {

                        card.name = "instantiated1HandCard60b";

                    } else if (card.name == "instantiated1Card60c(Clone)") {

                        card.name = "instantiated1HandCard60c";
                    }

                    instances2M++;

                }

            }

            if (player1DeckSlot3.transform.childCount == 0) {

                while (instances3M < NumberOfCards) {

                    GameObject card = Instantiate(playCardsDeck1[UnityEngine.Random.Range(0, playCardsDeck1.Count)], player1DeckSlot3.transform.position, player1DeckSlot3.transform.rotation) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.transform.parent = player1DeckSlot3.transform;

                    if (card.name == "instantiated1Card1(Clone)") {

                        card.name = "instantiated1HandCard1";

                    } else if (card.name == "instantiated1Card1a(Clone)") {

                        card.name = "instantiated1HandCard1a";

                    } else if (card.name == "instantiated1Card1b(Clone)") {

                        card.name = "instantiated1HandCard1b";

                    } else if (card.name == "instantiated1Card1c(Clone)") {

                        card.name = "instantiated1HandCard1c";

                    } else if (card.name == "instantiated1Card2(Clone)") {

                        card.name = "instantiated1HandCard2";

                    } else if (card.name == "instantiated1Card2a(Clone)") {

                        card.name = "instantiated1HandCard2a";

                    } else if (card.name == "instantiated1Card2b(Clone)") {

                        card.name = "instantiated1HandCard2b";

                    } else if (card.name == "instantiated1Card2c(Clone)") {

                        card.name = "instantiated1HandCard2c";

                    } else if (card.name == "instantiated1Card3(Clone)") {

                        card.name = "instantiated1HandCard3";

                    } else if (card.name == "instantiated1Card3a(Clone)") {

                        card.name = "instantiated1HandCard3a";

                    } else if (card.name == "instantiated1Card3b(Clone)") {

                        card.name = "instantiated1HandCard3b";

                    } else if (card.name == "instantiated1Card3c(Clone)") {

                        card.name = "instantiated1HandCard3c";

                    } else if (card.name == "instantiated1Card4(Clone)") {

                        card.name = "instantiated1HandCard4";

                    } else if (card.name == "instantiated1Card4a(Clone)") {

                        card.name = "instantiated1HandCard4a";

                    } else if (card.name == "instantiated1Card4b(Clone)") {

                        card.name = "instantiated1HandCard4b";

                    } else if (card.name == "instantiated1Card4c(Clone)") {

                        card.name = "instantiated1HandCard4c";

                    } else if (card.name == "instantiated1Card5(Clone)") {

                        card.name = "instantiated1HandCard5";

                    } else if (card.name == "instantiated1Card5a(Clone)") {

                        card.name = "instantiated1HandCard5a";

                    } else if (card.name == "instantiated1Card5b(Clone)") {

                        card.name = "instantiated1HandCard5b";

                    } else if (card.name == "instantiated1Card5c(Clone)") {

                        card.name = "instantiated1HandCard5c";

                    } else if (card.name == "instantiated1Card6(Clone)") {

                        card.name = "instantiated1HandCard6";

                    } else if (card.name == "instantiated1Card6a(Clone)") {

                        card.name = "instantiated1HandCard6a";

                    } else if (card.name == "instantiated1Card6b(Clone)") {

                        card.name = "instantiated1HandCard6b";

                    } else if (card.name == "instantiated1Card6c(Clone)") {

                        card.name = "instantiated1HandCard6c";

                    } else if (card.name == "instantiated1Card7(Clone)") {

                        card.name = "instantiated1HandCard7";

                    } else if (card.name == "instantiated1Card7a(Clone)") {

                        card.name = "instantiated1HandCard7a";

                    } else if (card.name == "instantiated1Card7b(Clone)") {

                        card.name = "instantiated1HandCard7b";

                    } else if (card.name == "instantiated1Card7c(Clone)") {

                        card.name = "instantiated1HandCard7c";

                    } else if (card.name == "instantiated1Card8(Clone)") {

                        card.name = "instantiated1HandCard8";

                    } else if (card.name == "instantiated1Card8a(Clone)") {

                        card.name = "instantiated1HandCard8a";

                    } else if (card.name == "instantiated1Card8b(Clone)") {

                        card.name = "instantiated1HandCard8b";

                    } else if (card.name == "instantiated1Card8c(Clone)") {

                        card.name = "instantiated1HandCard8c";

                    } else if (card.name == "instantiated1Card9(Clone)") {

                        card.name = "instantiated1HandCard9";

                    } else if (card.name == "instantiated1Card9a(Clone)") {

                        card.name = "instantiated1HandCard9a";

                    } else if (card.name == "instantiated1Card9b(Clone)") {

                        card.name = "instantiated1HandCard9b";

                    } else if (card.name == "instantiated1Card9c(Clone)") {

                        card.name = "instantiated1HandCard9c";

                    } else if (card.name == "instantiated1Card10(Clone)") {

                        card.name = "instantiatedAICard10";

                    } else if (card.name == "instantiated1Card10a(Clone)") {

                        card.name = "instantiated1HandCard10a";

                    } else if (card.name == "instantiated1Card10b(Clone)") {

                        card.name = "instantiated1HandCard10b";

                    } else if (card.name == "instantiated1Card10c(Clone)") {

                        card.name = "instantiated1HandCard10c";

                    } else if (card.name == "instantiated1Card11(Clone)") {

                        card.name = "instantiated1HandCard11";

                    } else if (card.name == "instantiated1Card11a(Clone)") {

                        card.name = "instantiated1HandCard11a";

                    } else if (card.name == "instantiated1Card11b(Clone)") {

                        card.name = "instantiated1HandCard11b";

                    } else if (card.name == "instantiated1Card11c(Clone)") {

                        card.name = "instantiated1HandCard11c";

                    } else if (card.name == "instantiated1Card12(Clone)") {

                        card.name = "instantiated1HandCard12";

                    } else if (card.name == "instantiated1Card12a(Clone)") {

                        card.name = "instantiated1HandCard12a";

                    } else if (card.name == "instantiated1Card12b(Clone)") {

                        card.name = "instantiated1HandCard12b";

                    } else if (card.name == "instantiated1Card12c(Clone)") {

                        card.name = "instantiated1HandCard12c";

                    } else if (card.name == "instantiated1Card13(Clone)") {

                        card.name = "instantiated1HandCard13";

                    } else if (card.name == "instantiated1Card13a(Clone)") {

                        card.name = "instantiated1HandCard13a";

                    } else if (card.name == "instantiated1Card13b(Clone)") {

                        card.name = "instantiated1HandCard13b";

                    } else if (card.name == "instantiated1Card13c(Clone)") {

                        card.name = "instantiated1HandCard13c";

                    } else if (card.name == "instantiated1Card14(Clone)") {

                        card.name = "instantiated1HandCard14";

                    } else if (card.name == "instantiated1Card14a(Clone)") {

                        card.name = "instantiated1HandCard14a";

                    } else if (card.name == "instantiated1Card14b(Clone)") {

                        card.name = "instantiated1HandCard14b";

                    } else if (card.name == "instantiated1Card14c(Clone)") {

                        card.name = "instantiated1HandCard14c";

                    } else if (card.name == "instantiated1Card15(Clone)") {

                        card.name = "instantiated1HandCard15";

                    } else if (card.name == "instantiated1Card15a(Clone)") {

                        card.name = "instantiated1HandCard15a";

                    } else if (card.name == "instantiated1Card15b(Clone)") {

                        card.name = "instantiated1HandCard15b";

                    } else if (card.name == "instantiated1Card15c(Clone)") {

                        card.name = "instantiated1HandCard15c";

                    } else if (card.name == "instantiated1Card16(Clone)") {

                        card.name = "instantiated1HandCard16";

                    } else if (card.name == "instantiated1Card16a(Clone)") {

                        card.name = "instantiated1HandCard16a";

                    } else if (card.name == "instantiated1Card16b(Clone)") {

                        card.name = "instantiated1HandCard16b";

                    } else if (card.name == "instantiated1Card16c(Clone)") {

                        card.name = "instantiated1HandCard16c";

                    } else if (card.name == "instantiated1Card17(Clone)") {

                        card.name = "instantiated1HandCard17";

                    } else if (card.name == "instantiated1Card17a(Clone)") {

                        card.name = "instantiated1HandCard17a";

                    } else if (card.name == "instantiated1Card17b(Clone)") {

                        card.name = "instantiated1HandCard17b";

                    } else if (card.name == "instantiated1Card17c(Clone)") {

                        card.name = "instantiated1HandCard17c";

                    } else if (card.name == "instantiated1Card18(Clone)") {

                        card.name = "instantiated1HandCard18";

                    } else if (card.name == "instantiated1Card18a(Clone)") {

                        card.name = "instantiated1HandCard18a";

                    } else if (card.name == "instantiated1Card18b(Clone)") {

                        card.name = "instantiated1HandCard18b";

                    } else if (card.name == "instantiated1Card18c(Clone)") {

                        card.name = "instantiated1HandCard18c";

                    } else if (card.name == "instantiated1Card19(Clone)") {

                        card.name = "instantiated1HandCard19";

                    } else if (card.name == "instantiated1Card19a(Clone)") {

                        card.name = "instantiated1HandCard19a";

                    } else if (card.name == "instantiated1Card19b(Clone)") {

                        card.name = "instantiated1HandCard19b";

                    } else if (card.name == "instantiated1Card19c(Clone)") {

                        card.name = "instantiated1HandCard19c";

                    } else if (card.name == "instantiated1Card20(Clone)") {

                        card.name = "instantiated1HandCard20";

                    } else if (card.name == "instantiated1Card20a(Clone)") {

                        card.name = "instantiated1HandCard20a";

                    } else if (card.name == "instantiated1Card20b(Clone)") {

                        card.name = "instantiated1HandCard20b";

                    } else if (card.name == "instantiated1Card20c(Clone)") {

                        card.name = "instantiated1HandCard20c";

                    } else if (card.name == "instantiated1Card21(Clone)") {

                        card.name = "instantiated1HandCard21";

                    } else if (card.name == "instantiated1Card21a(Clone)") {

                        card.name = "instantiated1HandCard21a";

                    } else if (card.name == "instantiated1Card21b(Clone)") {

                        card.name = "instantiated1HandCard21b";

                    } else if (card.name == "instantiated1Card21c(Clone)") {

                        card.name = "instantiated1HandCard21c";

                    } else if (card.name == "instantiated1Card22(Clone)") {

                        card.name = "instantiated1HandCard22";

                    } else if (card.name == "instantiated1Card22a(Clone)") {

                        card.name = "instantiated1HandCard22a";

                    } else if (card.name == "instantiated1Card22b(Clone)") {

                        card.name = "instantiated1HandCard22b";

                    } else if (card.name == "instantiated1Card22c(Clone)") {

                        card.name = "instantiated1HandCard22c";

                    } else if (card.name == "instantiated1Card23(Clone)") {

                        card.name = "instantiated1HandCard23";

                    } else if (card.name == "instantiated1Card23a(Clone)") {

                        card.name = "instantiated1HandCard23a";

                    } else if (card.name == "instantiated1Card23b(Clone)") {

                        card.name = "instantiated1HandCard23b";

                    } else if (card.name == "instantiated1Card23c(Clone)") {

                        card.name = "instantiated1HandCard23c";

                    } else if (card.name == "instantiated1Card24(Clone)") {

                        card.name = "instantiated1HandCard24";

                    } else if (card.name == "instantiated1Card24a(Clone)") {

                        card.name = "instantiated1HandCard24a";

                    } else if (card.name == "instantiated1Card24b(Clone)") {

                        card.name = "instantiated1HandCard24b";

                    } else if (card.name == "instantiated1Card24c(Clone)") {

                        card.name = "instantiated1HandCard24c";

                    } else if (card.name == "instantiated1Card25(Clone)") {

                        card.name = "instantiated1HandCard25";

                    } else if (card.name == "instantiated1Card25a(Clone)") {

                        card.name = "instantiated1HandCard25a";

                    } else if (card.name == "instantiated1Card25b(Clone)") {

                        card.name = "instantiated1HandCard25b";

                    } else if (card.name == "instantiated1Card25c(Clone)") {

                        card.name = "instantiated1HandCard25c";

                    } else if (card.name == "instantiated1Card26(Clone)") {

                        card.name = "instantiated1HandCard26";

                    } else if (card.name == "instantiated1Card26a(Clone)") {

                        card.name = "instantiated1HandCard26a";

                    } else if (card.name == "instantiated1Card26b(Clone)") {

                        card.name = "instantiated1HandCard26b";

                    } else if (card.name == "instantiated1Card26c(Clone)") {

                        card.name = "instantiated1HandCard26c";

                    } else if (card.name == "instantiated1Card27(Clone)") {

                        card.name = "instantiated1HandCard27";

                    } else if (card.name == "instantiated1Card27a(Clone)") {

                        card.name = "instantiated1HandCard27a";

                    } else if (card.name == "instantiated1Card27b(Clone)") {

                        card.name = "instantiated1HandCard27b";

                    } else if (card.name == "instantiated1Card27c(Clone)") {

                        card.name = "instantiated1HandCard27c";

                    } else if (card.name == "instantiated1Card28(Clone)") {

                        card.name = "instantiated1HandCard28";

                    } else if (card.name == "instantiated1Card28a(Clone)") {

                        card.name = "instantiated1HandCard28a";

                    } else if (card.name == "instantiated1Card28b(Clone)") {

                        card.name = "instantiated1HandCard28b";

                    } else if (card.name == "instantiated1Card28c(Clone)") {

                        card.name = "instantiated1HandCard28c";

                    } else if (card.name == "instantiated1Card29(Clone)") {

                        card.name = "instantiated1HandCard29";

                    } else if (card.name == "instantiated1Card29a(Clone)") {

                        card.name = "instantiated1HandCard29a";

                    } else if (card.name == "instantiated1Card29b(Clone)") {

                        card.name = "instantiated1HandCard29b";

                    } else if (card.name == "instantiated1Card29c(Clone)") {

                        card.name = "instantiated1HandCard29c";

                    } else if (card.name == "instantiated1Card30(Clone)") {

                        card.name = "instantiated1HandCard30";

                    } else if (card.name == "instantiated1Card30a(Clone)") {

                        card.name = "instantiated1HandCard30a";

                    } else if (card.name == "instantiated1Card30b(Clone)") {

                        card.name = "instantiated1HandCard30b";

                    } else if (card.name == "instantiated1Card30c(Clone)") {

                        card.name = "instantiated1HandCard30c";

                    } else if (card.name == "instantiated1Card31(Clone)") {

                        card.name = "instantiated1HandCard31";

                    } else if (card.name == "instantiated1Card31a(Clone)") {

                        card.name = "instantiated1HandCard31a";

                    } else if (card.name == "instantiated1Card31b(Clone)") {

                        card.name = "instantiated1HandCard31b";

                    } else if (card.name == "instantiated1Card31c(Clone)") {

                        card.name = "instantiated1HandCard31c";

                    } else if (card.name == "instantiated1Card32(Clone)") {

                        card.name = "instantiated1HandCard32";

                    } else if (card.name == "instantiated1Card32a(Clone)") {

                        card.name = "instantiated1HandCard32a";

                    } else if (card.name == "instantiated1Card32b(Clone)") {

                        card.name = "instantiated1HandCard32b";

                    } else if (card.name == "instantiated1Card32c(Clone)") {

                        card.name = "instantiated1HandCard32c";

                    } else if (card.name == "instantiated1Card33(Clone)") {

                        card.name = "instantiated1HandCard33";

                    } else if (card.name == "instantiated1Card33a(Clone)") {

                        card.name = "instantiated1HandCard33a";

                    } else if (card.name == "instantiated1Card33b(Clone)") {

                        card.name = "instantiated1HandCard33b";

                    } else if (card.name == "instantiated1Card33c(Clone)") {

                        card.name = "instantiated1HandCard33c";

                    } else if (card.name == "instantiated1Card34(Clone)") {

                        card.name = "instantiated1HandCard34";

                    } else if (card.name == "instantiated1Card34a(Clone)") {

                        card.name = "instantiated1HandCard34a";

                    } else if (card.name == "instantiated1Card34b(Clone)") {

                        card.name = "instantiated1HandCard34b";

                    } else if (card.name == "instantiated1Card34c(Clone)") {

                        card.name = "instantiated1HandCard34c";

                    } else if (card.name == "instantiated1Card35(Clone)") {

                        card.name = "instantiated1HandCard35";

                    } else if (card.name == "instantiated1Card35a(Clone)") {

                        card.name = "instantiated1HandCard35a";

                    } else if (card.name == "instantiated1Card35b(Clone)") {

                        card.name = "instantiated1HandCard35b";

                    } else if (card.name == "instantiated1Card35c(Clone)") {

                        card.name = "instantiated1HandCard35c";

                    } else if (card.name == "instantiated1Card36(Clone)") {

                        card.name = "instantiated1HandCard36";

                    } else if (card.name == "instantiated1Card36a(Clone)") {

                        card.name = "instantiated1HandCard36a";

                    } else if (card.name == "instantiated1Card36b(Clone)") {

                        card.name = "instantiated1HandCard36b";

                    } else if (card.name == "instantiated1Card36c(Clone)") {

                        card.name = "instantiated1HandCard36c";

                    } else if (card.name == "instantiated1Card37(Clone)") {

                        card.name = "instantiated1HandCard37";

                    } else if (card.name == "instantiated1Card37a(Clone)") {

                        card.name = "instantiated1HandCard37a";

                    } else if (card.name == "instantiated1Card37b(Clone)") {

                        card.name = "instantiated1HandCard37b";

                    } else if (card.name == "instantiated1Card37c(Clone)") {

                        card.name = "instantiated1HandCard37c";

                    } else if (card.name == "instantiated1Card38(Clone)") {

                        card.name = "instantiated1HandCard38";

                    } else if (card.name == "instantiated1Card38a(Clone)") {

                        card.name = "instantiated1HandCard38a";

                    } else if (card.name == "instantiated1Card38b(Clone)") {

                        card.name = "instantiated1HandCard38b";

                    } else if (card.name == "instantiated1Card38c(Clone)") {

                        card.name = "instantiated1HandCard38c";

                    } else if (card.name == "instantiated1Card39(Clone)") {

                        card.name = "instantiated1HandCard39";

                    } else if (card.name == "instantiated1Card39a(Clone)") {

                        card.name = "instantiated1HandCard39a";

                    } else if (card.name == "instantiated1Card39b(Clone)") {

                        card.name = "instantiated1HandCard39b";

                    } else if (card.name == "instantiated1Card39c(Clone)") {

                        card.name = "instantiated1HandCard39c";

                    } else if (card.name == "instantiated1Card40(Clone)") {

                        card.name = "instantiated1HandCard40";

                    } else if (card.name == "instantiated1Card40a(Clone)") {

                        card.name = "instantiated1HandCard40a";

                    } else if (card.name == "instantiated1Card40b(Clone)") {

                        card.name = "instantiated1HandCard40b";

                    } else if (card.name == "instantiated1Card40c(Clone)") {

                        card.name = "instantiated1HandCard40c";

                    } else if (card.name == "instantiated1Card41(Clone)") {

                        card.name = "instantiated1HandCard41";

                    } else if (card.name == "instantiated1Card41a(Clone)") {

                        card.name = "instantiated1HandCard41a";

                    } else if (card.name == "instantiated1Card41b(Clone)") {

                        card.name = "instantiated1HandCard41b";

                    } else if (card.name == "instantiated1Card41c(Clone)") {

                        card.name = "instantiated1HandCard41c";

                    } else if (card.name == "instantiated1Card42(Clone)") {

                        card.name = "instantiated1HandCard42";

                    } else if (card.name == "instantiated1Card42a(Clone)") {

                        card.name = "instantiated1HandCard42a";

                    } else if (card.name == "instantiated1Card42b(Clone)") {

                        card.name = "instantiated1HandCard42b";

                    } else if (card.name == "instantiated1Card42c(Clone)") {

                        card.name = "instantiated1HandCard42c";

                    } else if (card.name == "instantiated1Card43(Clone)") {

                        card.name = "instantiated1HandCard43";

                    } else if (card.name == "instantiated1Card43a(Clone)") {

                        card.name = "instantiated1HandCard43a";

                    } else if (card.name == "instantiated1Card43b(Clone)") {

                        card.name = "instantiated1HandCard43b";

                    } else if (card.name == "instantiated1Card43c(Clone)") {

                        card.name = "instantiated1HandCard43c";

                    } else if (card.name == "instantiated1Card44(Clone)") {

                        card.name = "instantiated1HandCard44";

                    } else if (card.name == "instantiated1Card44a(Clone)") {

                        card.name = "instantiated1HandCard44a";

                    } else if (card.name == "instantiated1Card44b(Clone)") {

                        card.name = "instantiated1HandCard44b";

                    } else if (card.name == "instantiated1Card44c(Clone)") {

                        card.name = "instantiated1HandCard44c";

                    } else if (card.name == "instantiated1Card45(Clone)") {

                        card.name = "instantiated1HandCard45";

                    } else if (card.name == "instantiated1Card45a(Clone)") {

                        card.name = "instantiated1HandCard45a";

                    } else if (card.name == "instantiated1Card45b(Clone)") {

                        card.name = "instantiated1HandCard45b";

                    } else if (card.name == "instantiated1Card45c(Clone)") {

                        card.name = "instantiated1HandCard45c";

                    } else if (card.name == "instantiated1Card46(Clone)") {

                        card.name = "instantiated1HandCard46";

                    } else if (card.name == "instantiated1Card46a(Clone)") {

                        card.name = "instantiated1HandCard46a";

                    } else if (card.name == "instantiated1Card46b(Clone)") {

                        card.name = "instantiated1HandCard46b";

                    } else if (card.name == "instantiated1Card46c(Clone)") {

                        card.name = "instantiated1HandCard46c";

                    } else if (card.name == "instantiated1Card47(Clone)") {

                        card.name = "instantiated1HandCard47";

                    } else if (card.name == "instantiated1Card47a(Clone)") {

                        card.name = "instantiated1HandCard47a";

                    } else if (card.name == "instantiated1Card47b(Clone)") {

                        card.name = "instantiated1HandCard47b";

                    } else if (card.name == "instantiated1Card47c(Clone)") {

                        card.name = "instantiated1HandCard47c";

                    } else if (card.name == "instantiated1Card48(Clone)") {

                        card.name = "instantiated1HandCard48";

                    } else if (card.name == "instantiated1Card48a(Clone)") {

                        card.name = "instantiated1HandCard48a";

                    } else if (card.name == "instantiated1Card48b(Clone)") {

                        card.name = "instantiated1HandCard48b";

                    } else if (card.name == "instantiated1Card48c(Clone)") {

                        card.name = "instantiated1HandCard48c";

                    } else if (card.name == "instantiated1Card49(Clone)") {

                        card.name = "instantiated1HandCard49";

                    } else if (card.name == "instantiated1Card49a(Clone)") {

                        card.name = "instantiated1HandCard49a";

                    } else if (card.name == "instantiated1Card49b(Clone)") {

                        card.name = "instantiated1HandCard49b";

                    } else if (card.name == "instantiated1Card49c(Clone)") {

                        card.name = "instantiated1HandCard49c";

                    } else if (card.name == "instantiated1Card50(Clone)") {

                        card.name = "instantiated1HandCard50";

                    } else if (card.name == "instantiated1Card50a(Clone)") {

                        card.name = "instantiated1HandCard50a";

                    } else if (card.name == "instantiated1Card50b(Clone)") {

                        card.name = "instantiated1HandCard50b";

                    } else if (card.name == "instantiated1Card50c(Clone)") {

                        card.name = "instantiated1HandCard50c";

                    } else if (card.name == "instantiated1Card51(Clone)") {

                        card.name = "instantiated1HandCard51";

                    } else if (card.name == "instantiated1Card51a(Clone)") {

                        card.name = "instantiated1HandCard51a";

                    } else if (card.name == "instantiated1Card51b(Clone)") {

                        card.name = "instantiated1HandCard51b";

                    } else if (card.name == "instantiated1Card51c(Clone)") {

                        card.name = "instantiated1HandCard51c";

                    } else if (card.name == "instantiated1Card52(Clone)") {

                        card.name = "instantiated1HandCard52";

                    } else if (card.name == "instantiated1Card52a(Clone)") {

                        card.name = "instantiated1HandCard52a";

                    } else if (card.name == "instantiated1Card52b(Clone)") {

                        card.name = "instantiated1HandCard52b";

                    } else if (card.name == "instantiated1Card52c(Clone)") {

                        card.name = "instantiated1HandCard52c";

                    } else if (card.name == "instantiated1Card53(Clone)") {

                        card.name = "instantiated1HandCard53";

                    } else if (card.name == "instantiated1Card53a(Clone)") {

                        card.name = "instantiated1HandCard53a";

                    } else if (card.name == "instantiated1Card53b(Clone)") {

                        card.name = "instantiated1HandCard53b";

                    } else if (card.name == "instantiated1Card53c(Clone)") {

                        card.name = "instantiated1HandCard53c";

                    } else if (card.name == "instantiated1Card54(Clone)") {

                        card.name = "instantiated1HandCard54";

                    } else if (card.name == "instantiated1Card54a(Clone)") {

                        card.name = "instantiated1HandCard54a";

                    } else if (card.name == "instantiated1Card54b(Clone)") {

                        card.name = "instantiated1HandCard54b";

                    } else if (card.name == "instantiated1Card54c(Clone)") {

                        card.name = "instantiated1HandCard54c";

                    } else if (card.name == "instantiated1Card55(Clone)") {

                        card.name = "instantiated1HandCard55";

                    } else if (card.name == "instantiated1Card55a(Clone)") {

                        card.name = "instantiated1HandCard55a";

                    } else if (card.name == "instantiated1Card55b(Clone)") {

                        card.name = "instantiated1HandCard55b";

                    } else if (card.name == "instantiated1Card55c(Clone)") {

                        card.name = "instantiated1HandCard55c";

                    } else if (card.name == "instantiated1Card56(Clone)") {

                        card.name = "instantiated1HandCard56";

                    } else if (card.name == "instantiated1Card56a(Clone)") {

                        card.name = "instantiated1HandCard56a";

                    } else if (card.name == "instantiated1Card56b(Clone)") {

                        card.name = "instantiated1HandCard56b";

                    } else if (card.name == "instantiated1Card56c(Clone)") {

                        card.name = "instantiated1HandCard56c";

                    } else if (card.name == "instantiated1Card57(Clone)") {

                        card.name = "instantiated1HandCard57";

                    } else if (card.name == "instantiated1Card57a(Clone)") {

                        card.name = "instantiated1HandCard57a";

                    } else if (card.name == "instantiated1Card57b(Clone)") {

                        card.name = "instantiated1HandCard57b";

                    } else if (card.name == "instantiated1Card57c(Clone)") {

                        card.name = "instantiated1HandCard57c";

                    } else if (card.name == "instantiated1Card58(Clone)") {

                        card.name = "instantiated1HandCard58";

                    } else if (card.name == "instantiated1Card58a(Clone)") {

                        card.name = "instantiated1HandCard58a";

                    } else if (card.name == "instantiated1Card58b(Clone)") {

                        card.name = "instantiated1HandCard58b";

                    } else if (card.name == "instantiated1Card58c(Clone)") {

                        card.name = "instantiated1HandCard58c";

                    } else if (card.name == "instantiated1Card59(Clone)") {

                        card.name = "instantiated1HandCard59";

                    } else if (card.name == "instantiated1Card59a(Clone)") {

                        card.name = "instantiated1HandCard59a";

                    } else if (card.name == "instantiated1Card59b(Clone)") {

                        card.name = "instantiated1HandCard59b";

                    } else if (card.name == "instantiated1Card59c(Clone)") {

                        card.name = "instantiated1HandCard59c";

                    } else if (card.name == "instantiated1Card60(Clone)") {

                        card.name = "instantiated1HandCard60";

                    } else if (card.name == "instantiated1Card60a(Clone)") {

                        card.name = "instantiated1HandCard60a";

                    } else if (card.name == "instantiated1Card60b(Clone)") {

                        card.name = "instantiated1HandCard60b";

                    } else if (card.name == "instantiated1Card60c(Clone)") {

                        card.name = "instantiated1HandCard60c";
                    }

                    instances3M++;

                }
            }

            if (player1DeckSlot4.transform.childCount == 0) {

                while (instances4M < NumberOfCards) {

                    GameObject card = Instantiate(playCardsDeck1[UnityEngine.Random.Range(0, playCardsDeck1.Count)], player1DeckSlot4.transform.position, player1DeckSlot4.transform.rotation) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.transform.parent = player1DeckSlot4.transform;

                    if (card.name == "instantiated1Card1(Clone)") {

                        card.name = "instantiated1HandCard1";

                    } else if (card.name == "instantiated1Card1a(Clone)") {

                        card.name = "instantiated1HandCard1a";

                    } else if (card.name == "instantiated1Card1b(Clone)") {

                        card.name = "instantiated1HandCard1b";

                    } else if (card.name == "instantiated1Card1c(Clone)") {

                        card.name = "instantiated1HandCard1c";

                    } else if (card.name == "instantiated1Card2(Clone)") {

                        card.name = "instantiated1HandCard2";

                    } else if (card.name == "instantiated1Card2a(Clone)") {

                        card.name = "instantiated1HandCard2a";

                    } else if (card.name == "instantiated1Card2b(Clone)") {

                        card.name = "instantiated1HandCard2b";

                    } else if (card.name == "instantiated1Card2c(Clone)") {

                        card.name = "instantiated1HandCard2c";

                    } else if (card.name == "instantiated1Card3(Clone)") {

                        card.name = "instantiated1HandCard3";

                    } else if (card.name == "instantiated1Card3a(Clone)") {

                        card.name = "instantiated1HandCard3a";

                    } else if (card.name == "instantiated1Card3b(Clone)") {

                        card.name = "instantiated1HandCard3b";

                    } else if (card.name == "instantiated1Card3c(Clone)") {

                        card.name = "instantiated1HandCard3c";

                    } else if (card.name == "instantiated1Card4(Clone)") {

                        card.name = "instantiated1HandCard4";

                    } else if (card.name == "instantiated1Card4a(Clone)") {

                        card.name = "instantiated1HandCard4a";

                    } else if (card.name == "instantiated1Card4b(Clone)") {

                        card.name = "instantiated1HandCard4b";

                    } else if (card.name == "instantiated1Card4c(Clone)") {

                        card.name = "instantiated1HandCard4c";

                    } else if (card.name == "instantiated1Card5(Clone)") {

                        card.name = "instantiated1HandCard5";

                    } else if (card.name == "instantiated1Card5a(Clone)") {

                        card.name = "instantiated1HandCard5a";

                    } else if (card.name == "instantiated1Card5b(Clone)") {

                        card.name = "instantiated1HandCard5b";

                    } else if (card.name == "instantiated1Card5c(Clone)") {

                        card.name = "instantiated1HandCard5c";

                    } else if (card.name == "instantiated1Card6(Clone)") {

                        card.name = "instantiated1HandCard6";

                    } else if (card.name == "instantiated1Card6a(Clone)") {

                        card.name = "instantiated1HandCard6a";

                    } else if (card.name == "instantiated1Card6b(Clone)") {

                        card.name = "instantiated1HandCard6b";

                    } else if (card.name == "instantiated1Card6c(Clone)") {

                        card.name = "instantiated1HandCard6c";

                    } else if (card.name == "instantiated1Card7(Clone)") {

                        card.name = "instantiated1HandCard7";

                    } else if (card.name == "instantiated1Card7a(Clone)") {

                        card.name = "instantiated1HandCard7a";

                    } else if (card.name == "instantiated1Card7b(Clone)") {

                        card.name = "instantiated1HandCard7b";

                    } else if (card.name == "instantiated1Card7c(Clone)") {

                        card.name = "instantiated1HandCard7c";

                    } else if (card.name == "instantiated1Card8(Clone)") {

                        card.name = "instantiated1HandCard8";

                    } else if (card.name == "instantiated1Card8a(Clone)") {

                        card.name = "instantiated1HandCard8a";

                    } else if (card.name == "instantiated1Card8b(Clone)") {

                        card.name = "instantiated1HandCard8b";

                    } else if (card.name == "instantiated1Card8c(Clone)") {

                        card.name = "instantiated1HandCard8c";

                    } else if (card.name == "instantiated1Card9(Clone)") {

                        card.name = "instantiated1HandCard9";

                    } else if (card.name == "instantiated1Card9a(Clone)") {

                        card.name = "instantiated1HandCard9a";

                    } else if (card.name == "instantiated1Card9b(Clone)") {

                        card.name = "instantiated1HandCard9b";

                    } else if (card.name == "instantiated1Card9c(Clone)") {

                        card.name = "instantiated1HandCard9c";

                    } else if (card.name == "instantiated1Card10(Clone)") {

                        card.name = "instantiatedAICard10";

                    } else if (card.name == "instantiated1Card10a(Clone)") {

                        card.name = "instantiated1HandCard10a";

                    } else if (card.name == "instantiated1Card10b(Clone)") {

                        card.name = "instantiated1HandCard10b";

                    } else if (card.name == "instantiated1Card10c(Clone)") {

                        card.name = "instantiated1HandCard10c";

                    } else if (card.name == "instantiated1Card11(Clone)") {

                        card.name = "instantiated1HandCard11";

                    } else if (card.name == "instantiated1Card11a(Clone)") {

                        card.name = "instantiated1HandCard11a";

                    } else if (card.name == "instantiated1Card11b(Clone)") {

                        card.name = "instantiated1HandCard11b";

                    } else if (card.name == "instantiated1Card11c(Clone)") {

                        card.name = "instantiated1HandCard11c";

                    } else if (card.name == "instantiated1Card12(Clone)") {

                        card.name = "instantiated1HandCard12";

                    } else if (card.name == "instantiated1Card12a(Clone)") {

                        card.name = "instantiated1HandCard12a";

                    } else if (card.name == "instantiated1Card12b(Clone)") {

                        card.name = "instantiated1HandCard12b";

                    } else if (card.name == "instantiated1Card12c(Clone)") {

                        card.name = "instantiated1HandCard12c";

                    } else if (card.name == "instantiated1Card13(Clone)") {

                        card.name = "instantiated1HandCard13";

                    } else if (card.name == "instantiated1Card13a(Clone)") {

                        card.name = "instantiated1HandCard13a";

                    } else if (card.name == "instantiated1Card13b(Clone)") {

                        card.name = "instantiated1HandCard13b";

                    } else if (card.name == "instantiated1Card13c(Clone)") {

                        card.name = "instantiated1HandCard13c";

                    } else if (card.name == "instantiated1Card14(Clone)") {

                        card.name = "instantiated1HandCard14";

                    } else if (card.name == "instantiated1Card14a(Clone)") {

                        card.name = "instantiated1HandCard14a";

                    } else if (card.name == "instantiated1Card14b(Clone)") {

                        card.name = "instantiated1HandCard14b";

                    } else if (card.name == "instantiated1Card14c(Clone)") {

                        card.name = "instantiated1HandCard14c";

                    } else if (card.name == "instantiated1Card15(Clone)") {

                        card.name = "instantiated1HandCard15";

                    } else if (card.name == "instantiated1Card15a(Clone)") {

                        card.name = "instantiated1HandCard15a";

                    } else if (card.name == "instantiated1Card15b(Clone)") {

                        card.name = "instantiated1HandCard15b";

                    } else if (card.name == "instantiated1Card15c(Clone)") {

                        card.name = "instantiated1HandCard15c";

                    } else if (card.name == "instantiated1Card16(Clone)") {

                        card.name = "instantiated1HandCard16";

                    } else if (card.name == "instantiated1Card16a(Clone)") {

                        card.name = "instantiated1HandCard16a";

                    } else if (card.name == "instantiated1Card16b(Clone)") {

                        card.name = "instantiated1HandCard16b";

                    } else if (card.name == "instantiated1Card16c(Clone)") {

                        card.name = "instantiated1HandCard16c";

                    } else if (card.name == "instantiated1Card17(Clone)") {

                        card.name = "instantiated1HandCard17";

                    } else if (card.name == "instantiated1Card17a(Clone)") {

                        card.name = "instantiated1HandCard17a";

                    } else if (card.name == "instantiated1Card17b(Clone)") {

                        card.name = "instantiated1HandCard17b";

                    } else if (card.name == "instantiated1Card17c(Clone)") {

                        card.name = "instantiated1HandCard17c";

                    } else if (card.name == "instantiated1Card18(Clone)") {

                        card.name = "instantiated1HandCard18";

                    } else if (card.name == "instantiated1Card18a(Clone)") {

                        card.name = "instantiated1HandCard18a";

                    } else if (card.name == "instantiated1Card18b(Clone)") {

                        card.name = "instantiated1HandCard18b";

                    } else if (card.name == "instantiated1Card18c(Clone)") {

                        card.name = "instantiated1HandCard18c";

                    } else if (card.name == "instantiated1Card19(Clone)") {

                        card.name = "instantiated1HandCard19";

                    } else if (card.name == "instantiated1Card19a(Clone)") {

                        card.name = "instantiated1HandCard19a";

                    } else if (card.name == "instantiated1Card19b(Clone)") {

                        card.name = "instantiated1HandCard19b";

                    } else if (card.name == "instantiated1Card19c(Clone)") {

                        card.name = "instantiated1HandCard19c";

                    } else if (card.name == "instantiated1Card20(Clone)") {

                        card.name = "instantiated1HandCard20";

                    } else if (card.name == "instantiated1Card20a(Clone)") {

                        card.name = "instantiated1HandCard20a";

                    } else if (card.name == "instantiated1Card20b(Clone)") {

                        card.name = "instantiated1HandCard20b";

                    } else if (card.name == "instantiated1Card20c(Clone)") {

                        card.name = "instantiated1HandCard20c";

                    } else if (card.name == "instantiated1Card21(Clone)") {

                        card.name = "instantiated1HandCard21";

                    } else if (card.name == "instantiated1Card21a(Clone)") {

                        card.name = "instantiated1HandCard21a";

                    } else if (card.name == "instantiated1Card21b(Clone)") {

                        card.name = "instantiated1HandCard21b";

                    } else if (card.name == "instantiated1Card21c(Clone)") {

                        card.name = "instantiated1HandCard21c";

                    } else if (card.name == "instantiated1Card22(Clone)") {

                        card.name = "instantiated1HandCard22";

                    } else if (card.name == "instantiated1Card22a(Clone)") {

                        card.name = "instantiated1HandCard22a";

                    } else if (card.name == "instantiated1Card22b(Clone)") {

                        card.name = "instantiated1HandCard22b";

                    } else if (card.name == "instantiated1Card22c(Clone)") {

                        card.name = "instantiated1HandCard22c";

                    } else if (card.name == "instantiated1Card23(Clone)") {

                        card.name = "instantiated1HandCard23";

                    } else if (card.name == "instantiated1Card23a(Clone)") {

                        card.name = "instantiated1HandCard23a";

                    } else if (card.name == "instantiated1Card23b(Clone)") {

                        card.name = "instantiated1HandCard23b";

                    } else if (card.name == "instantiated1Card23c(Clone)") {

                        card.name = "instantiated1HandCard23c";

                    } else if (card.name == "instantiated1Card24(Clone)") {

                        card.name = "instantiated1HandCard24";

                    } else if (card.name == "instantiated1Card24a(Clone)") {

                        card.name = "instantiated1HandCard24a";

                    } else if (card.name == "instantiated1Card24b(Clone)") {

                        card.name = "instantiated1HandCard24b";

                    } else if (card.name == "instantiated1Card24c(Clone)") {

                        card.name = "instantiated1HandCard24c";

                    } else if (card.name == "instantiated1Card25(Clone)") {

                        card.name = "instantiated1HandCard25";

                    } else if (card.name == "instantiated1Card25a(Clone)") {

                        card.name = "instantiated1HandCard25a";

                    } else if (card.name == "instantiated1Card25b(Clone)") {

                        card.name = "instantiated1HandCard25b";

                    } else if (card.name == "instantiated1Card25c(Clone)") {

                        card.name = "instantiated1HandCard25c";

                    } else if (card.name == "instantiated1Card26(Clone)") {

                        card.name = "instantiated1HandCard26";

                    } else if (card.name == "instantiated1Card26a(Clone)") {

                        card.name = "instantiated1HandCard26a";

                    } else if (card.name == "instantiated1Card26b(Clone)") {

                        card.name = "instantiated1HandCard26b";

                    } else if (card.name == "instantiated1Card26c(Clone)") {

                        card.name = "instantiated1HandCard26c";

                    } else if (card.name == "instantiated1Card27(Clone)") {

                        card.name = "instantiated1HandCard27";

                    } else if (card.name == "instantiated1Card27a(Clone)") {

                        card.name = "instantiated1HandCard27a";

                    } else if (card.name == "instantiated1Card27b(Clone)") {

                        card.name = "instantiated1HandCard27b";

                    } else if (card.name == "instantiated1Card27c(Clone)") {

                        card.name = "instantiated1HandCard27c";

                    } else if (card.name == "instantiated1Card28(Clone)") {

                        card.name = "instantiated1HandCard28";

                    } else if (card.name == "instantiated1Card28a(Clone)") {

                        card.name = "instantiated1HandCard28a";

                    } else if (card.name == "instantiated1Card28b(Clone)") {

                        card.name = "instantiated1HandCard28b";

                    } else if (card.name == "instantiated1Card28c(Clone)") {

                        card.name = "instantiated1HandCard28c";

                    } else if (card.name == "instantiated1Card29(Clone)") {

                        card.name = "instantiated1HandCard29";

                    } else if (card.name == "instantiated1Card29a(Clone)") {

                        card.name = "instantiated1HandCard29a";

                    } else if (card.name == "instantiated1Card29b(Clone)") {

                        card.name = "instantiated1HandCard29b";

                    } else if (card.name == "instantiated1Card29c(Clone)") {

                        card.name = "instantiated1HandCard29c";

                    } else if (card.name == "instantiated1Card30(Clone)") {

                        card.name = "instantiated1HandCard30";

                    } else if (card.name == "instantiated1Card30a(Clone)") {

                        card.name = "instantiated1HandCard30a";

                    } else if (card.name == "instantiated1Card30b(Clone)") {

                        card.name = "instantiated1HandCard30b";

                    } else if (card.name == "instantiated1Card30c(Clone)") {

                        card.name = "instantiated1HandCard30c";

                    } else if (card.name == "instantiated1Card31(Clone)") {

                        card.name = "instantiated1HandCard31";

                    } else if (card.name == "instantiated1Card31a(Clone)") {

                        card.name = "instantiated1HandCard31a";

                    } else if (card.name == "instantiated1Card31b(Clone)") {

                        card.name = "instantiated1HandCard31b";

                    } else if (card.name == "instantiated1Card31c(Clone)") {

                        card.name = "instantiated1HandCard31c";

                    } else if (card.name == "instantiated1Card32(Clone)") {

                        card.name = "instantiated1HandCard32";

                    } else if (card.name == "instantiated1Card32a(Clone)") {

                        card.name = "instantiated1HandCard32a";

                    } else if (card.name == "instantiated1Card32b(Clone)") {

                        card.name = "instantiated1HandCard32b";

                    } else if (card.name == "instantiated1Card32c(Clone)") {

                        card.name = "instantiated1HandCard32c";

                    } else if (card.name == "instantiated1Card33(Clone)") {

                        card.name = "instantiated1HandCard33";

                    } else if (card.name == "instantiated1Card33a(Clone)") {

                        card.name = "instantiated1HandCard33a";

                    } else if (card.name == "instantiated1Card33b(Clone)") {

                        card.name = "instantiated1HandCard33b";

                    } else if (card.name == "instantiated1Card33c(Clone)") {

                        card.name = "instantiated1HandCard33c";

                    } else if (card.name == "instantiated1Card34(Clone)") {

                        card.name = "instantiated1HandCard34";

                    } else if (card.name == "instantiated1Card34a(Clone)") {

                        card.name = "instantiated1HandCard34a";

                    } else if (card.name == "instantiated1Card34b(Clone)") {

                        card.name = "instantiated1HandCard34b";

                    } else if (card.name == "instantiated1Card34c(Clone)") {

                        card.name = "instantiated1HandCard34c";

                    } else if (card.name == "instantiated1Card35(Clone)") {

                        card.name = "instantiated1HandCard35";

                    } else if (card.name == "instantiated1Card35a(Clone)") {

                        card.name = "instantiated1HandCard35a";

                    } else if (card.name == "instantiated1Card35b(Clone)") {

                        card.name = "instantiated1HandCard35b";

                    } else if (card.name == "instantiated1Card35c(Clone)") {

                        card.name = "instantiated1HandCard35c";

                    } else if (card.name == "instantiated1Card36(Clone)") {

                        card.name = "instantiated1HandCard36";

                    } else if (card.name == "instantiated1Card36a(Clone)") {

                        card.name = "instantiated1HandCard36a";

                    } else if (card.name == "instantiated1Card36b(Clone)") {

                        card.name = "instantiated1HandCard36b";

                    } else if (card.name == "instantiated1Card36c(Clone)") {

                        card.name = "instantiated1HandCard36c";

                    } else if (card.name == "instantiated1Card37(Clone)") {

                        card.name = "instantiated1HandCard37";

                    } else if (card.name == "instantiated1Card37a(Clone)") {

                        card.name = "instantiated1HandCard37a";

                    } else if (card.name == "instantiated1Card37b(Clone)") {

                        card.name = "instantiated1HandCard37b";

                    } else if (card.name == "instantiated1Card37c(Clone)") {

                        card.name = "instantiated1HandCard37c";

                    } else if (card.name == "instantiated1Card38(Clone)") {

                        card.name = "instantiated1HandCard38";

                    } else if (card.name == "instantiated1Card38a(Clone)") {

                        card.name = "instantiated1HandCard38a";

                    } else if (card.name == "instantiated1Card38b(Clone)") {

                        card.name = "instantiated1HandCard38b";

                    } else if (card.name == "instantiated1Card38c(Clone)") {

                        card.name = "instantiated1HandCard38c";

                    } else if (card.name == "instantiated1Card39(Clone)") {

                        card.name = "instantiated1HandCard39";

                    } else if (card.name == "instantiated1Card39a(Clone)") {

                        card.name = "instantiated1HandCard39a";

                    } else if (card.name == "instantiated1Card39b(Clone)") {

                        card.name = "instantiated1HandCard39b";

                    } else if (card.name == "instantiated1Card39c(Clone)") {

                        card.name = "instantiated1HandCard39c";

                    } else if (card.name == "instantiated1Card40(Clone)") {

                        card.name = "instantiated1HandCard40";

                    } else if (card.name == "instantiated1Card40a(Clone)") {

                        card.name = "instantiated1HandCard40a";

                    } else if (card.name == "instantiated1Card40b(Clone)") {

                        card.name = "instantiated1HandCard40b";

                    } else if (card.name == "instantiated1Card40c(Clone)") {

                        card.name = "instantiated1HandCard40c";

                    } else if (card.name == "instantiated1Card41(Clone)") {

                        card.name = "instantiated1HandCard41";

                    } else if (card.name == "instantiated1Card41a(Clone)") {

                        card.name = "instantiated1HandCard41a";

                    } else if (card.name == "instantiated1Card41b(Clone)") {

                        card.name = "instantiated1HandCard41b";

                    } else if (card.name == "instantiated1Card41c(Clone)") {

                        card.name = "instantiated1HandCard41c";

                    } else if (card.name == "instantiated1Card42(Clone)") {

                        card.name = "instantiated1HandCard42";

                    } else if (card.name == "instantiated1Card42a(Clone)") {

                        card.name = "instantiated1HandCard42a";

                    } else if (card.name == "instantiated1Card42b(Clone)") {

                        card.name = "instantiated1HandCard42b";

                    } else if (card.name == "instantiated1Card42c(Clone)") {

                        card.name = "instantiated1HandCard42c";

                    } else if (card.name == "instantiated1Card43(Clone)") {

                        card.name = "instantiated1HandCard43";

                    } else if (card.name == "instantiated1Card43a(Clone)") {

                        card.name = "instantiated1HandCard43a";

                    } else if (card.name == "instantiated1Card43b(Clone)") {

                        card.name = "instantiated1HandCard43b";

                    } else if (card.name == "instantiated1Card43c(Clone)") {

                        card.name = "instantiated1HandCard43c";

                    } else if (card.name == "instantiated1Card44(Clone)") {

                        card.name = "instantiated1HandCard44";

                    } else if (card.name == "instantiated1Card44a(Clone)") {

                        card.name = "instantiated1HandCard44a";

                    } else if (card.name == "instantiated1Card44b(Clone)") {

                        card.name = "instantiated1HandCard44b";

                    } else if (card.name == "instantiated1Card44c(Clone)") {

                        card.name = "instantiated1HandCard44c";

                    } else if (card.name == "instantiated1Card45(Clone)") {

                        card.name = "instantiated1HandCard45";

                    } else if (card.name == "instantiated1Card45a(Clone)") {

                        card.name = "instantiated1HandCard45a";

                    } else if (card.name == "instantiated1Card45b(Clone)") {

                        card.name = "instantiated1HandCard45b";

                    } else if (card.name == "instantiated1Card45c(Clone)") {

                        card.name = "instantiated1HandCard45c";

                    } else if (card.name == "instantiated1Card46(Clone)") {

                        card.name = "instantiated1HandCard46";

                    } else if (card.name == "instantiated1Card46a(Clone)") {

                        card.name = "instantiated1HandCard46a";

                    } else if (card.name == "instantiated1Card46b(Clone)") {

                        card.name = "instantiated1HandCard46b";

                    } else if (card.name == "instantiated1Card46c(Clone)") {

                        card.name = "instantiated1HandCard46c";

                    } else if (card.name == "instantiated1Card47(Clone)") {

                        card.name = "instantiated1HandCard47";

                    } else if (card.name == "instantiated1Card47a(Clone)") {

                        card.name = "instantiated1HandCard47a";

                    } else if (card.name == "instantiated1Card47b(Clone)") {

                        card.name = "instantiated1HandCard47b";

                    } else if (card.name == "instantiated1Card47c(Clone)") {

                        card.name = "instantiated1HandCard47c";

                    } else if (card.name == "instantiated1Card48(Clone)") {

                        card.name = "instantiated1HandCard48";

                    } else if (card.name == "instantiated1Card48a(Clone)") {

                        card.name = "instantiated1HandCard48a";

                    } else if (card.name == "instantiated1Card48b(Clone)") {

                        card.name = "instantiated1HandCard48b";

                    } else if (card.name == "instantiated1Card48c(Clone)") {

                        card.name = "instantiated1HandCard48c";

                    } else if (card.name == "instantiated1Card49(Clone)") {

                        card.name = "instantiated1HandCard49";

                    } else if (card.name == "instantiated1Card49a(Clone)") {

                        card.name = "instantiated1HandCard49a";

                    } else if (card.name == "instantiated1Card49b(Clone)") {

                        card.name = "instantiated1HandCard49b";

                    } else if (card.name == "instantiated1Card49c(Clone)") {

                        card.name = "instantiated1HandCard49c";

                    } else if (card.name == "instantiated1Card50(Clone)") {

                        card.name = "instantiated1HandCard50";

                    } else if (card.name == "instantiated1Card50a(Clone)") {

                        card.name = "instantiated1HandCard50a";

                    } else if (card.name == "instantiated1Card50b(Clone)") {

                        card.name = "instantiated1HandCard50b";

                    } else if (card.name == "instantiated1Card50c(Clone)") {

                        card.name = "instantiated1HandCard50c";

                    } else if (card.name == "instantiated1Card51(Clone)") {

                        card.name = "instantiated1HandCard51";

                    } else if (card.name == "instantiated1Card51a(Clone)") {

                        card.name = "instantiated1HandCard51a";

                    } else if (card.name == "instantiated1Card51b(Clone)") {

                        card.name = "instantiated1HandCard51b";

                    } else if (card.name == "instantiated1Card51c(Clone)") {

                        card.name = "instantiated1HandCard51c";

                    } else if (card.name == "instantiated1Card52(Clone)") {

                        card.name = "instantiated1HandCard52";

                    } else if (card.name == "instantiated1Card52a(Clone)") {

                        card.name = "instantiated1HandCard52a";

                    } else if (card.name == "instantiated1Card52b(Clone)") {

                        card.name = "instantiated1HandCard52b";

                    } else if (card.name == "instantiated1Card52c(Clone)") {

                        card.name = "instantiated1HandCard52c";

                    } else if (card.name == "instantiated1Card53(Clone)") {

                        card.name = "instantiated1HandCard53";

                    } else if (card.name == "instantiated1Card53a(Clone)") {

                        card.name = "instantiated1HandCard53a";

                    } else if (card.name == "instantiated1Card53b(Clone)") {

                        card.name = "instantiated1HandCard53b";

                    } else if (card.name == "instantiated1Card53c(Clone)") {

                        card.name = "instantiated1HandCard53c";

                    } else if (card.name == "instantiated1Card54(Clone)") {

                        card.name = "instantiated1HandCard54";

                    } else if (card.name == "instantiated1Card54a(Clone)") {

                        card.name = "instantiated1HandCard54a";

                    } else if (card.name == "instantiated1Card54b(Clone)") {

                        card.name = "instantiated1HandCard54b";

                    } else if (card.name == "instantiated1Card54c(Clone)") {

                        card.name = "instantiated1HandCard54c";

                    } else if (card.name == "instantiated1Card55(Clone)") {

                        card.name = "instantiated1HandCard55";

                    } else if (card.name == "instantiated1Card55a(Clone)") {

                        card.name = "instantiated1HandCard55a";

                    } else if (card.name == "instantiated1Card55b(Clone)") {

                        card.name = "instantiated1HandCard55b";

                    } else if (card.name == "instantiated1Card55c(Clone)") {

                        card.name = "instantiated1HandCard55c";

                    } else if (card.name == "instantiated1Card56(Clone)") {

                        card.name = "instantiated1HandCard56";

                    } else if (card.name == "instantiated1Card56a(Clone)") {

                        card.name = "instantiated1HandCard56a";

                    } else if (card.name == "instantiated1Card56b(Clone)") {

                        card.name = "instantiated1HandCard56b";

                    } else if (card.name == "instantiated1Card56c(Clone)") {

                        card.name = "instantiated1HandCard56c";

                    } else if (card.name == "instantiated1Card57(Clone)") {

                        card.name = "instantiated1HandCard57";

                    } else if (card.name == "instantiated1Card57a(Clone)") {

                        card.name = "instantiated1HandCard57a";

                    } else if (card.name == "instantiated1Card57b(Clone)") {

                        card.name = "instantiated1HandCard57b";

                    } else if (card.name == "instantiated1Card57c(Clone)") {

                        card.name = "instantiated1HandCard57c";

                    } else if (card.name == "instantiated1Card58(Clone)") {

                        card.name = "instantiated1HandCard58";

                    } else if (card.name == "instantiated1Card58a(Clone)") {

                        card.name = "instantiated1HandCard58a";

                    } else if (card.name == "instantiated1Card58b(Clone)") {

                        card.name = "instantiated1HandCard58b";

                    } else if (card.name == "instantiated1Card58c(Clone)") {

                        card.name = "instantiated1HandCard58c";

                    } else if (card.name == "instantiated1Card59(Clone)") {

                        card.name = "instantiated1HandCard59";

                    } else if (card.name == "instantiated1Card59a(Clone)") {

                        card.name = "instantiated1HandCard59a";

                    } else if (card.name == "instantiated1Card59b(Clone)") {

                        card.name = "instantiated1HandCard59b";

                    } else if (card.name == "instantiated1Card59c(Clone)") {

                        card.name = "instantiated1HandCard59c";

                    } else if (card.name == "instantiated1Card60(Clone)") {

                        card.name = "instantiated1HandCard60";

                    } else if (card.name == "instantiated1Card60a(Clone)") {

                        card.name = "instantiated1HandCard60a";

                    } else if (card.name == "instantiated1Card60b(Clone)") {

                        card.name = "instantiated1HandCard60b";

                    } else if (card.name == "instantiated1Card60c(Clone)") {

                        card.name = "instantiated1HandCard60c";
                    }

                    instances4M++;

                }

            }

            if (player1DeckSlot5.transform.childCount == 0) {

                while (instances5M < NumberOfCards) {

                    GameObject card = Instantiate(playCardsDeck1[UnityEngine.Random.Range(0, playCardsDeck1.Count)], player1DeckSlot5.transform.position, player1DeckSlot5.transform.rotation) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.transform.parent = player1DeckSlot5.transform;

                    if (card.name == "instantiated1Card1(Clone)") {

                        card.name = "instantiated1HandCard1";

                    } else if (card.name == "instantiated1Card1a(Clone)") {

                        card.name = "instantiated1HandCard1a";

                    } else if (card.name == "instantiated1Card1b(Clone)") {

                        card.name = "instantiated1HandCard1b";

                    } else if (card.name == "instantiated1Card1c(Clone)") {

                        card.name = "instantiated1HandCard1c";

                    } else if (card.name == "instantiated1Card2(Clone)") {

                        card.name = "instantiated1HandCard2";

                    } else if (card.name == "instantiated1Card2a(Clone)") {

                        card.name = "instantiated1HandCard2a";

                    } else if (card.name == "instantiated1Card2b(Clone)") {

                        card.name = "instantiated1HandCard2b";

                    } else if (card.name == "instantiated1Card2c(Clone)") {

                        card.name = "instantiated1HandCard2c";

                    } else if (card.name == "instantiated1Card3(Clone)") {

                        card.name = "instantiated1HandCard3";

                    } else if (card.name == "instantiated1Card3a(Clone)") {

                        card.name = "instantiated1HandCard3a";

                    } else if (card.name == "instantiated1Card3b(Clone)") {

                        card.name = "instantiated1HandCard3b";

                    } else if (card.name == "instantiated1Card3c(Clone)") {

                        card.name = "instantiated1HandCard3c";

                    } else if (card.name == "instantiated1Card4(Clone)") {

                        card.name = "instantiated1HandCard4";

                    } else if (card.name == "instantiated1Card4a(Clone)") {

                        card.name = "instantiated1HandCard4a";

                    } else if (card.name == "instantiated1Card4b(Clone)") {

                        card.name = "instantiated1HandCard4b";

                    } else if (card.name == "instantiated1Card4c(Clone)") {

                        card.name = "instantiated1HandCard4c";

                    } else if (card.name == "instantiated1Card5(Clone)") {

                        card.name = "instantiated1HandCard5";

                    } else if (card.name == "instantiated1Card5a(Clone)") {

                        card.name = "instantiated1HandCard5a";

                    } else if (card.name == "instantiated1Card5b(Clone)") {

                        card.name = "instantiated1HandCard5b";

                    } else if (card.name == "instantiated1Card5c(Clone)") {

                        card.name = "instantiated1HandCard5c";

                    } else if (card.name == "instantiated1Card6(Clone)") {

                        card.name = "instantiated1HandCard6";

                    } else if (card.name == "instantiated1Card6a(Clone)") {

                        card.name = "instantiated1HandCard6a";

                    } else if (card.name == "instantiated1Card6b(Clone)") {

                        card.name = "instantiated1HandCard6b";

                    } else if (card.name == "instantiated1Card6c(Clone)") {

                        card.name = "instantiated1HandCard6c";

                    } else if (card.name == "instantiated1Card7(Clone)") {

                        card.name = "instantiated1HandCard7";

                    } else if (card.name == "instantiated1Card7a(Clone)") {

                        card.name = "instantiated1HandCard7a";

                    } else if (card.name == "instantiated1Card7b(Clone)") {

                        card.name = "instantiated1HandCard7b";

                    } else if (card.name == "instantiated1Card7c(Clone)") {

                        card.name = "instantiated1HandCard7c";

                    } else if (card.name == "instantiated1Card8(Clone)") {

                        card.name = "instantiated1HandCard8";

                    } else if (card.name == "instantiated1Card8a(Clone)") {

                        card.name = "instantiated1HandCard8a";

                    } else if (card.name == "instantiated1Card8b(Clone)") {

                        card.name = "instantiated1HandCard8b";

                    } else if (card.name == "instantiated1Card8c(Clone)") {

                        card.name = "instantiated1HandCard8c";

                    } else if (card.name == "instantiated1Card9(Clone)") {

                        card.name = "instantiated1HandCard9";

                    } else if (card.name == "instantiated1Card9a(Clone)") {

                        card.name = "instantiated1HandCard9a";

                    } else if (card.name == "instantiated1Card9b(Clone)") {

                        card.name = "instantiated1HandCard9b";

                    } else if (card.name == "instantiated1Card9c(Clone)") {

                        card.name = "instantiated1HandCard9c";

                    } else if (card.name == "instantiated1Card10(Clone)") {

                        card.name = "instantiatedAICard10";

                    } else if (card.name == "instantiated1Card10a(Clone)") {

                        card.name = "instantiated1HandCard10a";

                    } else if (card.name == "instantiated1Card10b(Clone)") {

                        card.name = "instantiated1HandCard10b";

                    } else if (card.name == "instantiated1Card10c(Clone)") {

                        card.name = "instantiated1HandCard10c";

                    } else if (card.name == "instantiated1Card11(Clone)") {

                        card.name = "instantiated1HandCard11";

                    } else if (card.name == "instantiated1Card11a(Clone)") {

                        card.name = "instantiated1HandCard11a";

                    } else if (card.name == "instantiated1Card11b(Clone)") {

                        card.name = "instantiated1HandCard11b";

                    } else if (card.name == "instantiated1Card11c(Clone)") {

                        card.name = "instantiated1HandCard11c";

                    } else if (card.name == "instantiated1Card12(Clone)") {

                        card.name = "instantiated1HandCard12";

                    } else if (card.name == "instantiated1Card12a(Clone)") {

                        card.name = "instantiated1HandCard12a";

                    } else if (card.name == "instantiated1Card12b(Clone)") {

                        card.name = "instantiated1HandCard12b";

                    } else if (card.name == "instantiated1Card12c(Clone)") {

                        card.name = "instantiated1HandCard12c";

                    } else if (card.name == "instantiated1Card13(Clone)") {

                        card.name = "instantiated1HandCard13";

                    } else if (card.name == "instantiated1Card13a(Clone)") {

                        card.name = "instantiated1HandCard13a";

                    } else if (card.name == "instantiated1Card13b(Clone)") {

                        card.name = "instantiated1HandCard13b";

                    } else if (card.name == "instantiated1Card13c(Clone)") {

                        card.name = "instantiated1HandCard13c";

                    } else if (card.name == "instantiated1Card14(Clone)") {

                        card.name = "instantiated1HandCard14";

                    } else if (card.name == "instantiated1Card14a(Clone)") {

                        card.name = "instantiated1HandCard14a";

                    } else if (card.name == "instantiated1Card14b(Clone)") {

                        card.name = "instantiated1HandCard14b";

                    } else if (card.name == "instantiated1Card14c(Clone)") {

                        card.name = "instantiated1HandCard14c";

                    } else if (card.name == "instantiated1Card15(Clone)") {

                        card.name = "instantiated1HandCard15";

                    } else if (card.name == "instantiated1Card15a(Clone)") {

                        card.name = "instantiated1HandCard15a";

                    } else if (card.name == "instantiated1Card15b(Clone)") {

                        card.name = "instantiated1HandCard15b";

                    } else if (card.name == "instantiated1Card15c(Clone)") {

                        card.name = "instantiated1HandCard15c";

                    } else if (card.name == "instantiated1Card16(Clone)") {

                        card.name = "instantiated1HandCard16";

                    } else if (card.name == "instantiated1Card16a(Clone)") {

                        card.name = "instantiated1HandCard16a";

                    } else if (card.name == "instantiated1Card16b(Clone)") {

                        card.name = "instantiated1HandCard16b";

                    } else if (card.name == "instantiated1Card16c(Clone)") {

                        card.name = "instantiated1HandCard16c";

                    } else if (card.name == "instantiated1Card17(Clone)") {

                        card.name = "instantiated1HandCard17";

                    } else if (card.name == "instantiated1Card17a(Clone)") {

                        card.name = "instantiated1HandCard17a";

                    } else if (card.name == "instantiated1Card17b(Clone)") {

                        card.name = "instantiated1HandCard17b";

                    } else if (card.name == "instantiated1Card17c(Clone)") {

                        card.name = "instantiated1HandCard17c";

                    } else if (card.name == "instantiated1Card18(Clone)") {

                        card.name = "instantiated1HandCard18";

                    } else if (card.name == "instantiated1Card18a(Clone)") {

                        card.name = "instantiated1HandCard18a";

                    } else if (card.name == "instantiated1Card18b(Clone)") {

                        card.name = "instantiated1HandCard18b";

                    } else if (card.name == "instantiated1Card18c(Clone)") {

                        card.name = "instantiated1HandCard18c";

                    } else if (card.name == "instantiated1Card19(Clone)") {

                        card.name = "instantiated1HandCard19";

                    } else if (card.name == "instantiated1Card19a(Clone)") {

                        card.name = "instantiated1HandCard19a";

                    } else if (card.name == "instantiated1Card19b(Clone)") {

                        card.name = "instantiated1HandCard19b";

                    } else if (card.name == "instantiated1Card19c(Clone)") {

                        card.name = "instantiated1HandCard19c";

                    } else if (card.name == "instantiated1Card20(Clone)") {

                        card.name = "instantiated1HandCard20";

                    } else if (card.name == "instantiated1Card20a(Clone)") {

                        card.name = "instantiated1HandCard20a";

                    } else if (card.name == "instantiated1Card20b(Clone)") {

                        card.name = "instantiated1HandCard20b";

                    } else if (card.name == "instantiated1Card20c(Clone)") {

                        card.name = "instantiated1HandCard20c";

                    } else if (card.name == "instantiated1Card21(Clone)") {

                        card.name = "instantiated1HandCard21";

                    } else if (card.name == "instantiated1Card21a(Clone)") {

                        card.name = "instantiated1HandCard21a";

                    } else if (card.name == "instantiated1Card21b(Clone)") {

                        card.name = "instantiated1HandCard21b";

                    } else if (card.name == "instantiated1Card21c(Clone)") {

                        card.name = "instantiated1HandCard21c";

                    } else if (card.name == "instantiated1Card22(Clone)") {

                        card.name = "instantiated1HandCard22";

                    } else if (card.name == "instantiated1Card22a(Clone)") {

                        card.name = "instantiated1HandCard22a";

                    } else if (card.name == "instantiated1Card22b(Clone)") {

                        card.name = "instantiated1HandCard22b";

                    } else if (card.name == "instantiated1Card22c(Clone)") {

                        card.name = "instantiated1HandCard22c";

                    } else if (card.name == "instantiated1Card23(Clone)") {

                        card.name = "instantiated1HandCard23";

                    } else if (card.name == "instantiated1Card23a(Clone)") {

                        card.name = "instantiated1HandCard23a";

                    } else if (card.name == "instantiated1Card23b(Clone)") {

                        card.name = "instantiated1HandCard23b";

                    } else if (card.name == "instantiated1Card23c(Clone)") {

                        card.name = "instantiated1HandCard23c";

                    } else if (card.name == "instantiated1Card24(Clone)") {

                        card.name = "instantiated1HandCard24";

                    } else if (card.name == "instantiated1Card24a(Clone)") {

                        card.name = "instantiated1HandCard24a";

                    } else if (card.name == "instantiated1Card24b(Clone)") {

                        card.name = "instantiated1HandCard24b";

                    } else if (card.name == "instantiated1Card24c(Clone)") {

                        card.name = "instantiated1HandCard24c";

                    } else if (card.name == "instantiated1Card25(Clone)") {

                        card.name = "instantiated1HandCard25";

                    } else if (card.name == "instantiated1Card25a(Clone)") {

                        card.name = "instantiated1HandCard25a";

                    } else if (card.name == "instantiated1Card25b(Clone)") {

                        card.name = "instantiated1HandCard25b";

                    } else if (card.name == "instantiated1Card25c(Clone)") {

                        card.name = "instantiated1HandCard25c";

                    } else if (card.name == "instantiated1Card26(Clone)") {

                        card.name = "instantiated1HandCard26";

                    } else if (card.name == "instantiated1Card26a(Clone)") {

                        card.name = "instantiated1HandCard26a";

                    } else if (card.name == "instantiated1Card26b(Clone)") {

                        card.name = "instantiated1HandCard26b";

                    } else if (card.name == "instantiated1Card26c(Clone)") {

                        card.name = "instantiated1HandCard26c";

                    } else if (card.name == "instantiated1Card27(Clone)") {

                        card.name = "instantiated1HandCard27";

                    } else if (card.name == "instantiated1Card27a(Clone)") {

                        card.name = "instantiated1HandCard27a";

                    } else if (card.name == "instantiated1Card27b(Clone)") {

                        card.name = "instantiated1HandCard27b";

                    } else if (card.name == "instantiated1Card27c(Clone)") {

                        card.name = "instantiated1HandCard27c";

                    } else if (card.name == "instantiated1Card28(Clone)") {

                        card.name = "instantiated1HandCard28";

                    } else if (card.name == "instantiated1Card28a(Clone)") {

                        card.name = "instantiated1HandCard28a";

                    } else if (card.name == "instantiated1Card28b(Clone)") {

                        card.name = "instantiated1HandCard28b";

                    } else if (card.name == "instantiated1Card28c(Clone)") {

                        card.name = "instantiated1HandCard28c";

                    } else if (card.name == "instantiated1Card29(Clone)") {

                        card.name = "instantiated1HandCard29";

                    } else if (card.name == "instantiated1Card29a(Clone)") {

                        card.name = "instantiated1HandCard29a";

                    } else if (card.name == "instantiated1Card29b(Clone)") {

                        card.name = "instantiated1HandCard29b";

                    } else if (card.name == "instantiated1Card29c(Clone)") {

                        card.name = "instantiated1HandCard29c";

                    } else if (card.name == "instantiated1Card30(Clone)") {

                        card.name = "instantiated1HandCard30";

                    } else if (card.name == "instantiated1Card30a(Clone)") {

                        card.name = "instantiated1HandCard30a";

                    } else if (card.name == "instantiated1Card30b(Clone)") {

                        card.name = "instantiated1HandCard30b";

                    } else if (card.name == "instantiated1Card30c(Clone)") {

                        card.name = "instantiated1HandCard30c";

                    } else if (card.name == "instantiated1Card31(Clone)") {

                        card.name = "instantiated1HandCard31";

                    } else if (card.name == "instantiated1Card31a(Clone)") {

                        card.name = "instantiated1HandCard31a";

                    } else if (card.name == "instantiated1Card31b(Clone)") {

                        card.name = "instantiated1HandCard31b";

                    } else if (card.name == "instantiated1Card31c(Clone)") {

                        card.name = "instantiated1HandCard31c";

                    } else if (card.name == "instantiated1Card32(Clone)") {

                        card.name = "instantiated1HandCard32";

                    } else if (card.name == "instantiated1Card32a(Clone)") {

                        card.name = "instantiated1HandCard32a";

                    } else if (card.name == "instantiated1Card32b(Clone)") {

                        card.name = "instantiated1HandCard32b";

                    } else if (card.name == "instantiated1Card32c(Clone)") {

                        card.name = "instantiated1HandCard32c";

                    } else if (card.name == "instantiated1Card33(Clone)") {

                        card.name = "instantiated1HandCard33";

                    } else if (card.name == "instantiated1Card33a(Clone)") {

                        card.name = "instantiated1HandCard33a";

                    } else if (card.name == "instantiated1Card33b(Clone)") {

                        card.name = "instantiated1HandCard33b";

                    } else if (card.name == "instantiated1Card33c(Clone)") {

                        card.name = "instantiated1HandCard33c";

                    } else if (card.name == "instantiated1Card34(Clone)") {

                        card.name = "instantiated1HandCard34";

                    } else if (card.name == "instantiated1Card34a(Clone)") {

                        card.name = "instantiated1HandCard34a";

                    } else if (card.name == "instantiated1Card34b(Clone)") {

                        card.name = "instantiated1HandCard34b";

                    } else if (card.name == "instantiated1Card34c(Clone)") {

                        card.name = "instantiated1HandCard34c";

                    } else if (card.name == "instantiated1Card35(Clone)") {

                        card.name = "instantiated1HandCard35";

                    } else if (card.name == "instantiated1Card35a(Clone)") {

                        card.name = "instantiated1HandCard35a";

                    } else if (card.name == "instantiated1Card35b(Clone)") {

                        card.name = "instantiated1HandCard35b";

                    } else if (card.name == "instantiated1Card35c(Clone)") {

                        card.name = "instantiated1HandCard35c";

                    } else if (card.name == "instantiated1Card36(Clone)") {

                        card.name = "instantiated1HandCard36";

                    } else if (card.name == "instantiated1Card36a(Clone)") {

                        card.name = "instantiated1HandCard36a";

                    } else if (card.name == "instantiated1Card36b(Clone)") {

                        card.name = "instantiated1HandCard36b";

                    } else if (card.name == "instantiated1Card36c(Clone)") {

                        card.name = "instantiated1HandCard36c";

                    } else if (card.name == "instantiated1Card37(Clone)") {

                        card.name = "instantiated1HandCard37";

                    } else if (card.name == "instantiated1Card37a(Clone)") {

                        card.name = "instantiated1HandCard37a";

                    } else if (card.name == "instantiated1Card37b(Clone)") {

                        card.name = "instantiated1HandCard37b";

                    } else if (card.name == "instantiated1Card37c(Clone)") {

                        card.name = "instantiated1HandCard37c";

                    } else if (card.name == "instantiated1Card38(Clone)") {

                        card.name = "instantiated1HandCard38";

                    } else if (card.name == "instantiated1Card38a(Clone)") {

                        card.name = "instantiated1HandCard38a";

                    } else if (card.name == "instantiated1Card38b(Clone)") {

                        card.name = "instantiated1HandCard38b";

                    } else if (card.name == "instantiated1Card38c(Clone)") {

                        card.name = "instantiated1HandCard38c";

                    } else if (card.name == "instantiated1Card39(Clone)") {

                        card.name = "instantiated1HandCard39";

                    } else if (card.name == "instantiated1Card39a(Clone)") {

                        card.name = "instantiated1HandCard39a";

                    } else if (card.name == "instantiated1Card39b(Clone)") {

                        card.name = "instantiated1HandCard39b";

                    } else if (card.name == "instantiated1Card39c(Clone)") {

                        card.name = "instantiated1HandCard39c";

                    } else if (card.name == "instantiated1Card40(Clone)") {

                        card.name = "instantiated1HandCard40";

                    } else if (card.name == "instantiated1Card40a(Clone)") {

                        card.name = "instantiated1HandCard40a";

                    } else if (card.name == "instantiated1Card40b(Clone)") {

                        card.name = "instantiated1HandCard40b";

                    } else if (card.name == "instantiated1Card40c(Clone)") {

                        card.name = "instantiated1HandCard40c";

                    } else if (card.name == "instantiated1Card41(Clone)") {

                        card.name = "instantiated1HandCard41";

                    } else if (card.name == "instantiated1Card41a(Clone)") {

                        card.name = "instantiated1HandCard41a";

                    } else if (card.name == "instantiated1Card41b(Clone)") {

                        card.name = "instantiated1HandCard41b";

                    } else if (card.name == "instantiated1Card41c(Clone)") {

                        card.name = "instantiated1HandCard41c";

                    } else if (card.name == "instantiated1Card42(Clone)") {

                        card.name = "instantiated1HandCard42";

                    } else if (card.name == "instantiated1Card42a(Clone)") {

                        card.name = "instantiated1HandCard42a";

                    } else if (card.name == "instantiated1Card42b(Clone)") {

                        card.name = "instantiated1HandCard42b";

                    } else if (card.name == "instantiated1Card42c(Clone)") {

                        card.name = "instantiated1HandCard42c";

                    } else if (card.name == "instantiated1Card43(Clone)") {

                        card.name = "instantiated1HandCard43";

                    } else if (card.name == "instantiated1Card43a(Clone)") {

                        card.name = "instantiated1HandCard43a";

                    } else if (card.name == "instantiated1Card43b(Clone)") {

                        card.name = "instantiated1HandCard43b";

                    } else if (card.name == "instantiated1Card43c(Clone)") {

                        card.name = "instantiated1HandCard43c";

                    } else if (card.name == "instantiated1Card44(Clone)") {

                        card.name = "instantiated1HandCard44";

                    } else if (card.name == "instantiated1Card44a(Clone)") {

                        card.name = "instantiated1HandCard44a";

                    } else if (card.name == "instantiated1Card44b(Clone)") {

                        card.name = "instantiated1HandCard44b";

                    } else if (card.name == "instantiated1Card44c(Clone)") {

                        card.name = "instantiated1HandCard44c";

                    } else if (card.name == "instantiated1Card45(Clone)") {

                        card.name = "instantiated1HandCard45";

                    } else if (card.name == "instantiated1Card45a(Clone)") {

                        card.name = "instantiated1HandCard45a";

                    } else if (card.name == "instantiated1Card45b(Clone)") {

                        card.name = "instantiated1HandCard45b";

                    } else if (card.name == "instantiated1Card45c(Clone)") {

                        card.name = "instantiated1HandCard45c";

                    } else if (card.name == "instantiated1Card46(Clone)") {

                        card.name = "instantiated1HandCard46";

                    } else if (card.name == "instantiated1Card46a(Clone)") {

                        card.name = "instantiated1HandCard46a";

                    } else if (card.name == "instantiated1Card46b(Clone)") {

                        card.name = "instantiated1HandCard46b";

                    } else if (card.name == "instantiated1Card46c(Clone)") {

                        card.name = "instantiated1HandCard46c";

                    } else if (card.name == "instantiated1Card47(Clone)") {

                        card.name = "instantiated1HandCard47";

                    } else if (card.name == "instantiated1Card47a(Clone)") {

                        card.name = "instantiated1HandCard47a";

                    } else if (card.name == "instantiated1Card47b(Clone)") {

                        card.name = "instantiated1HandCard47b";

                    } else if (card.name == "instantiated1Card47c(Clone)") {

                        card.name = "instantiated1HandCard47c";

                    } else if (card.name == "instantiated1Card48(Clone)") {

                        card.name = "instantiated1HandCard48";

                    } else if (card.name == "instantiated1Card48a(Clone)") {

                        card.name = "instantiated1HandCard48a";

                    } else if (card.name == "instantiated1Card48b(Clone)") {

                        card.name = "instantiated1HandCard48b";

                    } else if (card.name == "instantiated1Card48c(Clone)") {

                        card.name = "instantiated1HandCard48c";

                    } else if (card.name == "instantiated1Card49(Clone)") {

                        card.name = "instantiated1HandCard49";

                    } else if (card.name == "instantiated1Card49a(Clone)") {

                        card.name = "instantiated1HandCard49a";

                    } else if (card.name == "instantiated1Card49b(Clone)") {

                        card.name = "instantiated1HandCard49b";

                    } else if (card.name == "instantiated1Card49c(Clone)") {

                        card.name = "instantiated1HandCard49c";

                    } else if (card.name == "instantiated1Card50(Clone)") {

                        card.name = "instantiated1HandCard50";

                    } else if (card.name == "instantiated1Card50a(Clone)") {

                        card.name = "instantiated1HandCard50a";

                    } else if (card.name == "instantiated1Card50b(Clone)") {

                        card.name = "instantiated1HandCard50b";

                    } else if (card.name == "instantiated1Card50c(Clone)") {

                        card.name = "instantiated1HandCard50c";

                    } else if (card.name == "instantiated1Card51(Clone)") {

                        card.name = "instantiated1HandCard51";

                    } else if (card.name == "instantiated1Card51a(Clone)") {

                        card.name = "instantiated1HandCard51a";

                    } else if (card.name == "instantiated1Card51b(Clone)") {

                        card.name = "instantiated1HandCard51b";

                    } else if (card.name == "instantiated1Card51c(Clone)") {

                        card.name = "instantiated1HandCard51c";

                    } else if (card.name == "instantiated1Card52(Clone)") {

                        card.name = "instantiated1HandCard52";

                    } else if (card.name == "instantiated1Card52a(Clone)") {

                        card.name = "instantiated1HandCard52a";

                    } else if (card.name == "instantiated1Card52b(Clone)") {

                        card.name = "instantiated1HandCard52b";

                    } else if (card.name == "instantiated1Card52c(Clone)") {

                        card.name = "instantiated1HandCard52c";

                    } else if (card.name == "instantiated1Card53(Clone)") {

                        card.name = "instantiated1HandCard53";

                    } else if (card.name == "instantiated1Card53a(Clone)") {

                        card.name = "instantiated1HandCard53a";

                    } else if (card.name == "instantiated1Card53b(Clone)") {

                        card.name = "instantiated1HandCard53b";

                    } else if (card.name == "instantiated1Card53c(Clone)") {

                        card.name = "instantiated1HandCard53c";

                    } else if (card.name == "instantiated1Card54(Clone)") {

                        card.name = "instantiated1HandCard54";

                    } else if (card.name == "instantiated1Card54a(Clone)") {

                        card.name = "instantiated1HandCard54a";

                    } else if (card.name == "instantiated1Card54b(Clone)") {

                        card.name = "instantiated1HandCard54b";

                    } else if (card.name == "instantiated1Card54c(Clone)") {

                        card.name = "instantiated1HandCard54c";

                    } else if (card.name == "instantiated1Card55(Clone)") {

                        card.name = "instantiated1HandCard55";

                    } else if (card.name == "instantiated1Card55a(Clone)") {

                        card.name = "instantiated1HandCard55a";

                    } else if (card.name == "instantiated1Card55b(Clone)") {

                        card.name = "instantiated1HandCard55b";

                    } else if (card.name == "instantiated1Card55c(Clone)") {

                        card.name = "instantiated1HandCard55c";

                    } else if (card.name == "instantiated1Card56(Clone)") {

                        card.name = "instantiated1HandCard56";

                    } else if (card.name == "instantiated1Card56a(Clone)") {

                        card.name = "instantiated1HandCard56a";

                    } else if (card.name == "instantiated1Card56b(Clone)") {

                        card.name = "instantiated1HandCard56b";

                    } else if (card.name == "instantiated1Card56c(Clone)") {

                        card.name = "instantiated1HandCard56c";

                    } else if (card.name == "instantiated1Card57(Clone)") {

                        card.name = "instantiated1HandCard57";

                    } else if (card.name == "instantiated1Card57a(Clone)") {

                        card.name = "instantiated1HandCard57a";

                    } else if (card.name == "instantiated1Card57b(Clone)") {

                        card.name = "instantiated1HandCard57b";

                    } else if (card.name == "instantiated1Card57c(Clone)") {

                        card.name = "instantiated1HandCard57c";

                    } else if (card.name == "instantiated1Card58(Clone)") {

                        card.name = "instantiated1HandCard58";

                    } else if (card.name == "instantiated1Card58a(Clone)") {

                        card.name = "instantiated1HandCard58a";

                    } else if (card.name == "instantiated1Card58b(Clone)") {

                        card.name = "instantiated1HandCard58b";

                    } else if (card.name == "instantiated1Card58c(Clone)") {

                        card.name = "instantiated1HandCard58c";

                    } else if (card.name == "instantiated1Card59(Clone)") {

                        card.name = "instantiated1HandCard59";

                    } else if (card.name == "instantiated1Card59a(Clone)") {

                        card.name = "instantiated1HandCard59a";

                    } else if (card.name == "instantiated1Card59b(Clone)") {

                        card.name = "instantiated1HandCard59b";

                    } else if (card.name == "instantiated1Card59c(Clone)") {

                        card.name = "instantiated1HandCard59c";

                    } else if (card.name == "instantiated1Card60(Clone)") {

                        card.name = "instantiated1HandCard60";

                    } else if (card.name == "instantiated1Card60a(Clone)") {

                        card.name = "instantiated1HandCard60a";

                    } else if (card.name == "instantiated1Card60b(Clone)") {

                        card.name = "instantiated1HandCard60b";

                    } else if (card.name == "instantiated1Card60c(Clone)") {

                        card.name = "instantiated1HandCard60c";
                    }

                    instances5M++;

                }

            }

            if (player1DeckSlot6.transform.childCount == 0) {

                while (instances6M < NumberOfCards) {

                    GameObject card = Instantiate(playCardsDeck1[UnityEngine.Random.Range(0, playCardsDeck1.Count)], player1DeckSlot6.transform.position, player1DeckSlot6.transform.rotation) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.transform.parent = player1DeckSlot6.transform;

                    if (card.name == "instantiated1Card1(Clone)") {

                        card.name = "instantiated1HandCard1";

                    } else if (card.name == "instantiated1Card1a(Clone)") {

                        card.name = "instantiated1HandCard1a";

                    } else if (card.name == "instantiated1Card1b(Clone)") {

                        card.name = "instantiated1HandCard1b";

                    } else if (card.name == "instantiated1Card1c(Clone)") {

                        card.name = "instantiated1HandCard1c";

                    } else if (card.name == "instantiated1Card2(Clone)") {

                        card.name = "instantiated1HandCard2";

                    } else if (card.name == "instantiated1Card2a(Clone)") {

                        card.name = "instantiated1HandCard2a";

                    } else if (card.name == "instantiated1Card2b(Clone)") {

                        card.name = "instantiated1HandCard2b";

                    } else if (card.name == "instantiated1Card2c(Clone)") {

                        card.name = "instantiated1HandCard2c";

                    } else if (card.name == "instantiated1Card3(Clone)") {

                        card.name = "instantiated1HandCard3";

                    } else if (card.name == "instantiated1Card3a(Clone)") {

                        card.name = "instantiated1HandCard3a";

                    } else if (card.name == "instantiated1Card3b(Clone)") {

                        card.name = "instantiated1HandCard3b";

                    } else if (card.name == "instantiated1Card3c(Clone)") {

                        card.name = "instantiated1HandCard3c";

                    } else if (card.name == "instantiated1Card4(Clone)") {

                        card.name = "instantiated1HandCard4";

                    } else if (card.name == "instantiated1Card4a(Clone)") {

                        card.name = "instantiated1HandCard4a";

                    } else if (card.name == "instantiated1Card4b(Clone)") {

                        card.name = "instantiated1HandCard4b";

                    } else if (card.name == "instantiated1Card4c(Clone)") {

                        card.name = "instantiated1HandCard4c";

                    } else if (card.name == "instantiated1Card5(Clone)") {

                        card.name = "instantiated1HandCard5";

                    } else if (card.name == "instantiated1Card5a(Clone)") {

                        card.name = "instantiated1HandCard5a";

                    } else if (card.name == "instantiated1Card5b(Clone)") {

                        card.name = "instantiated1HandCard5b";

                    } else if (card.name == "instantiated1Card5c(Clone)") {

                        card.name = "instantiated1HandCard5c";

                    } else if (card.name == "instantiated1Card6(Clone)") {

                        card.name = "instantiated1HandCard6";

                    } else if (card.name == "instantiated1Card6a(Clone)") {

                        card.name = "instantiated1HandCard6a";

                    } else if (card.name == "instantiated1Card6b(Clone)") {

                        card.name = "instantiated1HandCard6b";

                    } else if (card.name == "instantiated1Card6c(Clone)") {

                        card.name = "instantiated1HandCard6c";

                    } else if (card.name == "instantiated1Card7(Clone)") {

                        card.name = "instantiated1HandCard7";

                    } else if (card.name == "instantiated1Card7a(Clone)") {

                        card.name = "instantiated1HandCard7a";

                    } else if (card.name == "instantiated1Card7b(Clone)") {

                        card.name = "instantiated1HandCard7b";

                    } else if (card.name == "instantiated1Card7c(Clone)") {

                        card.name = "instantiated1HandCard7c";

                    } else if (card.name == "instantiated1Card8(Clone)") {

                        card.name = "instantiated1HandCard8";

                    } else if (card.name == "instantiated1Card8a(Clone)") {

                        card.name = "instantiated1HandCard8a";

                    } else if (card.name == "instantiated1Card8b(Clone)") {

                        card.name = "instantiated1HandCard8b";

                    } else if (card.name == "instantiated1Card8c(Clone)") {

                        card.name = "instantiated1HandCard8c";

                    } else if (card.name == "instantiated1Card9(Clone)") {

                        card.name = "instantiated1HandCard9";

                    } else if (card.name == "instantiated1Card9a(Clone)") {

                        card.name = "instantiated1HandCard9a";

                    } else if (card.name == "instantiated1Card9b(Clone)") {

                        card.name = "instantiated1HandCard9b";

                    } else if (card.name == "instantiated1Card9c(Clone)") {

                        card.name = "instantiated1HandCard9c";

                    } else if (card.name == "instantiated1Card10(Clone)") {

                        card.name = "instantiatedAICard10";

                    } else if (card.name == "instantiated1Card10a(Clone)") {

                        card.name = "instantiated1HandCard10a";

                    } else if (card.name == "instantiated1Card10b(Clone)") {

                        card.name = "instantiated1HandCard10b";

                    } else if (card.name == "instantiated1Card10c(Clone)") {

                        card.name = "instantiated1HandCard10c";

                    } else if (card.name == "instantiated1Card11(Clone)") {

                        card.name = "instantiated1HandCard11";

                    } else if (card.name == "instantiated1Card11a(Clone)") {

                        card.name = "instantiated1HandCard11a";

                    } else if (card.name == "instantiated1Card11b(Clone)") {

                        card.name = "instantiated1HandCard11b";

                    } else if (card.name == "instantiated1Card11c(Clone)") {

                        card.name = "instantiated1HandCard11c";

                    } else if (card.name == "instantiated1Card12(Clone)") {

                        card.name = "instantiated1HandCard12";

                    } else if (card.name == "instantiated1Card12a(Clone)") {

                        card.name = "instantiated1HandCard12a";

                    } else if (card.name == "instantiated1Card12b(Clone)") {

                        card.name = "instantiated1HandCard12b";

                    } else if (card.name == "instantiated1Card12c(Clone)") {

                        card.name = "instantiated1HandCard12c";

                    } else if (card.name == "instantiated1Card13(Clone)") {

                        card.name = "instantiated1HandCard13";

                    } else if (card.name == "instantiated1Card13a(Clone)") {

                        card.name = "instantiated1HandCard13a";

                    } else if (card.name == "instantiated1Card13b(Clone)") {

                        card.name = "instantiated1HandCard13b";

                    } else if (card.name == "instantiated1Card13c(Clone)") {

                        card.name = "instantiated1HandCard13c";

                    } else if (card.name == "instantiated1Card14(Clone)") {

                        card.name = "instantiated1HandCard14";

                    } else if (card.name == "instantiated1Card14a(Clone)") {

                        card.name = "instantiated1HandCard14a";

                    } else if (card.name == "instantiated1Card14b(Clone)") {

                        card.name = "instantiated1HandCard14b";

                    } else if (card.name == "instantiated1Card14c(Clone)") {

                        card.name = "instantiated1HandCard14c";

                    } else if (card.name == "instantiated1Card15(Clone)") {

                        card.name = "instantiated1HandCard15";

                    } else if (card.name == "instantiated1Card15a(Clone)") {

                        card.name = "instantiated1HandCard15a";

                    } else if (card.name == "instantiated1Card15b(Clone)") {

                        card.name = "instantiated1HandCard15b";

                    } else if (card.name == "instantiated1Card15c(Clone)") {

                        card.name = "instantiated1HandCard15c";

                    } else if (card.name == "instantiated1Card16(Clone)") {

                        card.name = "instantiated1HandCard16";

                    } else if (card.name == "instantiated1Card16a(Clone)") {

                        card.name = "instantiated1HandCard16a";

                    } else if (card.name == "instantiated1Card16b(Clone)") {

                        card.name = "instantiated1HandCard16b";

                    } else if (card.name == "instantiated1Card16c(Clone)") {

                        card.name = "instantiated1HandCard16c";

                    } else if (card.name == "instantiated1Card17(Clone)") {

                        card.name = "instantiated1HandCard17";

                    } else if (card.name == "instantiated1Card17a(Clone)") {

                        card.name = "instantiated1HandCard17a";

                    } else if (card.name == "instantiated1Card17b(Clone)") {

                        card.name = "instantiated1HandCard17b";

                    } else if (card.name == "instantiated1Card17c(Clone)") {

                        card.name = "instantiated1HandCard17c";

                    } else if (card.name == "instantiated1Card18(Clone)") {

                        card.name = "instantiated1HandCard18";

                    } else if (card.name == "instantiated1Card18a(Clone)") {

                        card.name = "instantiated1HandCard18a";

                    } else if (card.name == "instantiated1Card18b(Clone)") {

                        card.name = "instantiated1HandCard18b";

                    } else if (card.name == "instantiated1Card18c(Clone)") {

                        card.name = "instantiated1HandCard18c";

                    } else if (card.name == "instantiated1Card19(Clone)") {

                        card.name = "instantiated1HandCard19";

                    } else if (card.name == "instantiated1Card19a(Clone)") {

                        card.name = "instantiated1HandCard19a";

                    } else if (card.name == "instantiated1Card19b(Clone)") {

                        card.name = "instantiated1HandCard19b";

                    } else if (card.name == "instantiated1Card19c(Clone)") {

                        card.name = "instantiated1HandCard19c";

                    } else if (card.name == "instantiated1Card20(Clone)") {

                        card.name = "instantiated1HandCard20";

                    } else if (card.name == "instantiated1Card20a(Clone)") {

                        card.name = "instantiated1HandCard20a";

                    } else if (card.name == "instantiated1Card20b(Clone)") {

                        card.name = "instantiated1HandCard20b";

                    } else if (card.name == "instantiated1Card20c(Clone)") {

                        card.name = "instantiated1HandCard20c";

                    } else if (card.name == "instantiated1Card21(Clone)") {

                        card.name = "instantiated1HandCard21";

                    } else if (card.name == "instantiated1Card21a(Clone)") {

                        card.name = "instantiated1HandCard21a";

                    } else if (card.name == "instantiated1Card21b(Clone)") {

                        card.name = "instantiated1HandCard21b";

                    } else if (card.name == "instantiated1Card21c(Clone)") {

                        card.name = "instantiated1HandCard21c";

                    } else if (card.name == "instantiated1Card22(Clone)") {

                        card.name = "instantiated1HandCard22";

                    } else if (card.name == "instantiated1Card22a(Clone)") {

                        card.name = "instantiated1HandCard22a";

                    } else if (card.name == "instantiated1Card22b(Clone)") {

                        card.name = "instantiated1HandCard22b";

                    } else if (card.name == "instantiated1Card22c(Clone)") {

                        card.name = "instantiated1HandCard22c";

                    } else if (card.name == "instantiated1Card23(Clone)") {

                        card.name = "instantiated1HandCard23";

                    } else if (card.name == "instantiated1Card23a(Clone)") {

                        card.name = "instantiated1HandCard23a";

                    } else if (card.name == "instantiated1Card23b(Clone)") {

                        card.name = "instantiated1HandCard23b";

                    } else if (card.name == "instantiated1Card23c(Clone)") {

                        card.name = "instantiated1HandCard23c";

                    } else if (card.name == "instantiated1Card24(Clone)") {

                        card.name = "instantiated1HandCard24";

                    } else if (card.name == "instantiated1Card24a(Clone)") {

                        card.name = "instantiated1HandCard24a";

                    } else if (card.name == "instantiated1Card24b(Clone)") {

                        card.name = "instantiated1HandCard24b";

                    } else if (card.name == "instantiated1Card24c(Clone)") {

                        card.name = "instantiated1HandCard24c";

                    } else if (card.name == "instantiated1Card25(Clone)") {

                        card.name = "instantiated1HandCard25";

                    } else if (card.name == "instantiated1Card25a(Clone)") {

                        card.name = "instantiated1HandCard25a";

                    } else if (card.name == "instantiated1Card25b(Clone)") {

                        card.name = "instantiated1HandCard25b";

                    } else if (card.name == "instantiated1Card25c(Clone)") {

                        card.name = "instantiated1HandCard25c";

                    } else if (card.name == "instantiated1Card26(Clone)") {

                        card.name = "instantiated1HandCard26";

                    } else if (card.name == "instantiated1Card26a(Clone)") {

                        card.name = "instantiated1HandCard26a";

                    } else if (card.name == "instantiated1Card26b(Clone)") {

                        card.name = "instantiated1HandCard26b";

                    } else if (card.name == "instantiated1Card26c(Clone)") {

                        card.name = "instantiated1HandCard26c";

                    } else if (card.name == "instantiated1Card27(Clone)") {

                        card.name = "instantiated1HandCard27";

                    } else if (card.name == "instantiated1Card27a(Clone)") {

                        card.name = "instantiated1HandCard27a";

                    } else if (card.name == "instantiated1Card27b(Clone)") {

                        card.name = "instantiated1HandCard27b";

                    } else if (card.name == "instantiated1Card27c(Clone)") {

                        card.name = "instantiated1HandCard27c";

                    } else if (card.name == "instantiated1Card28(Clone)") {

                        card.name = "instantiated1HandCard28";

                    } else if (card.name == "instantiated1Card28a(Clone)") {

                        card.name = "instantiated1HandCard28a";

                    } else if (card.name == "instantiated1Card28b(Clone)") {

                        card.name = "instantiated1HandCard28b";

                    } else if (card.name == "instantiated1Card28c(Clone)") {

                        card.name = "instantiated1HandCard28c";

                    } else if (card.name == "instantiated1Card29(Clone)") {

                        card.name = "instantiated1HandCard29";

                    } else if (card.name == "instantiated1Card29a(Clone)") {

                        card.name = "instantiated1HandCard29a";

                    } else if (card.name == "instantiated1Card29b(Clone)") {

                        card.name = "instantiated1HandCard29b";

                    } else if (card.name == "instantiated1Card29c(Clone)") {

                        card.name = "instantiated1HandCard29c";

                    } else if (card.name == "instantiated1Card30(Clone)") {

                        card.name = "instantiated1HandCard30";

                    } else if (card.name == "instantiated1Card30a(Clone)") {

                        card.name = "instantiated1HandCard30a";

                    } else if (card.name == "instantiated1Card30b(Clone)") {

                        card.name = "instantiated1HandCard30b";

                    } else if (card.name == "instantiated1Card30c(Clone)") {

                        card.name = "instantiated1HandCard30c";

                    } else if (card.name == "instantiated1Card31(Clone)") {

                        card.name = "instantiated1HandCard31";

                    } else if (card.name == "instantiated1Card31a(Clone)") {

                        card.name = "instantiated1HandCard31a";

                    } else if (card.name == "instantiated1Card31b(Clone)") {

                        card.name = "instantiated1HandCard31b";

                    } else if (card.name == "instantiated1Card31c(Clone)") {

                        card.name = "instantiated1HandCard31c";

                    } else if (card.name == "instantiated1Card32(Clone)") {

                        card.name = "instantiated1HandCard32";

                    } else if (card.name == "instantiated1Card32a(Clone)") {

                        card.name = "instantiated1HandCard32a";

                    } else if (card.name == "instantiated1Card32b(Clone)") {

                        card.name = "instantiated1HandCard32b";

                    } else if (card.name == "instantiated1Card32c(Clone)") {

                        card.name = "instantiated1HandCard32c";

                    } else if (card.name == "instantiated1Card33(Clone)") {

                        card.name = "instantiated1HandCard33";

                    } else if (card.name == "instantiated1Card33a(Clone)") {

                        card.name = "instantiated1HandCard33a";

                    } else if (card.name == "instantiated1Card33b(Clone)") {

                        card.name = "instantiated1HandCard33b";

                    } else if (card.name == "instantiated1Card33c(Clone)") {

                        card.name = "instantiated1HandCard33c";

                    } else if (card.name == "instantiated1Card34(Clone)") {

                        card.name = "instantiated1HandCard34";

                    } else if (card.name == "instantiated1Card34a(Clone)") {

                        card.name = "instantiated1HandCard34a";

                    } else if (card.name == "instantiated1Card34b(Clone)") {

                        card.name = "instantiated1HandCard34b";

                    } else if (card.name == "instantiated1Card34c(Clone)") {

                        card.name = "instantiated1HandCard34c";

                    } else if (card.name == "instantiated1Card35(Clone)") {

                        card.name = "instantiated1HandCard35";

                    } else if (card.name == "instantiated1Card35a(Clone)") {

                        card.name = "instantiated1HandCard35a";

                    } else if (card.name == "instantiated1Card35b(Clone)") {

                        card.name = "instantiated1HandCard35b";

                    } else if (card.name == "instantiated1Card35c(Clone)") {

                        card.name = "instantiated1HandCard35c";

                    } else if (card.name == "instantiated1Card36(Clone)") {

                        card.name = "instantiated1HandCard36";

                    } else if (card.name == "instantiated1Card36a(Clone)") {

                        card.name = "instantiated1HandCard36a";

                    } else if (card.name == "instantiated1Card36b(Clone)") {

                        card.name = "instantiated1HandCard36b";

                    } else if (card.name == "instantiated1Card36c(Clone)") {

                        card.name = "instantiated1HandCard36c";

                    } else if (card.name == "instantiated1Card37(Clone)") {

                        card.name = "instantiated1HandCard37";

                    } else if (card.name == "instantiated1Card37a(Clone)") {

                        card.name = "instantiated1HandCard37a";

                    } else if (card.name == "instantiated1Card37b(Clone)") {

                        card.name = "instantiated1HandCard37b";

                    } else if (card.name == "instantiated1Card37c(Clone)") {

                        card.name = "instantiated1HandCard37c";

                    } else if (card.name == "instantiated1Card38(Clone)") {

                        card.name = "instantiated1HandCard38";

                    } else if (card.name == "instantiated1Card38a(Clone)") {

                        card.name = "instantiated1HandCard38a";

                    } else if (card.name == "instantiated1Card38b(Clone)") {

                        card.name = "instantiated1HandCard38b";

                    } else if (card.name == "instantiated1Card38c(Clone)") {

                        card.name = "instantiated1HandCard38c";

                    } else if (card.name == "instantiated1Card39(Clone)") {

                        card.name = "instantiated1HandCard39";

                    } else if (card.name == "instantiated1Card39a(Clone)") {

                        card.name = "instantiated1HandCard39a";

                    } else if (card.name == "instantiated1Card39b(Clone)") {

                        card.name = "instantiated1HandCard39b";

                    } else if (card.name == "instantiated1Card39c(Clone)") {

                        card.name = "instantiated1HandCard39c";

                    } else if (card.name == "instantiated1Card40(Clone)") {

                        card.name = "instantiated1HandCard40";

                    } else if (card.name == "instantiated1Card40a(Clone)") {

                        card.name = "instantiated1HandCard40a";

                    } else if (card.name == "instantiated1Card40b(Clone)") {

                        card.name = "instantiated1HandCard40b";

                    } else if (card.name == "instantiated1Card40c(Clone)") {

                        card.name = "instantiated1HandCard40c";

                    } else if (card.name == "instantiated1Card41(Clone)") {

                        card.name = "instantiated1HandCard41";

                    } else if (card.name == "instantiated1Card41a(Clone)") {

                        card.name = "instantiated1HandCard41a";

                    } else if (card.name == "instantiated1Card41b(Clone)") {

                        card.name = "instantiated1HandCard41b";

                    } else if (card.name == "instantiated1Card41c(Clone)") {

                        card.name = "instantiated1HandCard41c";

                    } else if (card.name == "instantiated1Card42(Clone)") {

                        card.name = "instantiated1HandCard42";

                    } else if (card.name == "instantiated1Card42a(Clone)") {

                        card.name = "instantiated1HandCard42a";

                    } else if (card.name == "instantiated1Card42b(Clone)") {

                        card.name = "instantiated1HandCard42b";

                    } else if (card.name == "instantiated1Card42c(Clone)") {

                        card.name = "instantiated1HandCard42c";

                    } else if (card.name == "instantiated1Card43(Clone)") {

                        card.name = "instantiated1HandCard43";

                    } else if (card.name == "instantiated1Card43a(Clone)") {

                        card.name = "instantiated1HandCard43a";

                    } else if (card.name == "instantiated1Card43b(Clone)") {

                        card.name = "instantiated1HandCard43b";

                    } else if (card.name == "instantiated1Card43c(Clone)") {

                        card.name = "instantiated1HandCard43c";

                    } else if (card.name == "instantiated1Card44(Clone)") {

                        card.name = "instantiated1HandCard44";

                    } else if (card.name == "instantiated1Card44a(Clone)") {

                        card.name = "instantiated1HandCard44a";

                    } else if (card.name == "instantiated1Card44b(Clone)") {

                        card.name = "instantiated1HandCard44b";

                    } else if (card.name == "instantiated1Card44c(Clone)") {

                        card.name = "instantiated1HandCard44c";

                    } else if (card.name == "instantiated1Card45(Clone)") {

                        card.name = "instantiated1HandCard45";

                    } else if (card.name == "instantiated1Card45a(Clone)") {

                        card.name = "instantiated1HandCard45a";

                    } else if (card.name == "instantiated1Card45b(Clone)") {

                        card.name = "instantiated1HandCard45b";

                    } else if (card.name == "instantiated1Card45c(Clone)") {

                        card.name = "instantiated1HandCard45c";

                    } else if (card.name == "instantiated1Card46(Clone)") {

                        card.name = "instantiated1HandCard46";

                    } else if (card.name == "instantiated1Card46a(Clone)") {

                        card.name = "instantiated1HandCard46a";

                    } else if (card.name == "instantiated1Card46b(Clone)") {

                        card.name = "instantiated1HandCard46b";

                    } else if (card.name == "instantiated1Card46c(Clone)") {

                        card.name = "instantiated1HandCard46c";

                    } else if (card.name == "instantiated1Card47(Clone)") {

                        card.name = "instantiated1HandCard47";

                    } else if (card.name == "instantiated1Card47a(Clone)") {

                        card.name = "instantiated1HandCard47a";

                    } else if (card.name == "instantiated1Card47b(Clone)") {

                        card.name = "instantiated1HandCard47b";

                    } else if (card.name == "instantiated1Card47c(Clone)") {

                        card.name = "instantiated1HandCard47c";

                    } else if (card.name == "instantiated1Card48(Clone)") {

                        card.name = "instantiated1HandCard48";

                    } else if (card.name == "instantiated1Card48a(Clone)") {

                        card.name = "instantiated1HandCard48a";

                    } else if (card.name == "instantiated1Card48b(Clone)") {

                        card.name = "instantiated1HandCard48b";

                    } else if (card.name == "instantiated1Card48c(Clone)") {

                        card.name = "instantiated1HandCard48c";

                    } else if (card.name == "instantiated1Card49(Clone)") {

                        card.name = "instantiated1HandCard49";

                    } else if (card.name == "instantiated1Card49a(Clone)") {

                        card.name = "instantiated1HandCard49a";

                    } else if (card.name == "instantiated1Card49b(Clone)") {

                        card.name = "instantiated1HandCard49b";

                    } else if (card.name == "instantiated1Card49c(Clone)") {

                        card.name = "instantiated1HandCard49c";

                    } else if (card.name == "instantiated1Card50(Clone)") {

                        card.name = "instantiated1HandCard50";

                    } else if (card.name == "instantiated1Card50a(Clone)") {

                        card.name = "instantiated1HandCard50a";

                    } else if (card.name == "instantiated1Card50b(Clone)") {

                        card.name = "instantiated1HandCard50b";

                    } else if (card.name == "instantiated1Card50c(Clone)") {

                        card.name = "instantiated1HandCard50c";

                    } else if (card.name == "instantiated1Card51(Clone)") {

                        card.name = "instantiated1HandCard51";

                    } else if (card.name == "instantiated1Card51a(Clone)") {

                        card.name = "instantiated1HandCard51a";

                    } else if (card.name == "instantiated1Card51b(Clone)") {

                        card.name = "instantiated1HandCard51b";

                    } else if (card.name == "instantiated1Card51c(Clone)") {

                        card.name = "instantiated1HandCard51c";

                    } else if (card.name == "instantiated1Card52(Clone)") {

                        card.name = "instantiated1HandCard52";

                    } else if (card.name == "instantiated1Card52a(Clone)") {

                        card.name = "instantiated1HandCard52a";

                    } else if (card.name == "instantiated1Card52b(Clone)") {

                        card.name = "instantiated1HandCard52b";

                    } else if (card.name == "instantiated1Card52c(Clone)") {

                        card.name = "instantiated1HandCard52c";

                    } else if (card.name == "instantiated1Card53(Clone)") {

                        card.name = "instantiated1HandCard53";

                    } else if (card.name == "instantiated1Card53a(Clone)") {

                        card.name = "instantiated1HandCard53a";

                    } else if (card.name == "instantiated1Card53b(Clone)") {

                        card.name = "instantiated1HandCard53b";

                    } else if (card.name == "instantiated1Card53c(Clone)") {

                        card.name = "instantiated1HandCard53c";

                    } else if (card.name == "instantiated1Card54(Clone)") {

                        card.name = "instantiated1HandCard54";

                    } else if (card.name == "instantiated1Card54a(Clone)") {

                        card.name = "instantiated1HandCard54a";

                    } else if (card.name == "instantiated1Card54b(Clone)") {

                        card.name = "instantiated1HandCard54b";

                    } else if (card.name == "instantiated1Card54c(Clone)") {

                        card.name = "instantiated1HandCard54c";

                    } else if (card.name == "instantiated1Card55(Clone)") {

                        card.name = "instantiated1HandCard55";

                    } else if (card.name == "instantiated1Card55a(Clone)") {

                        card.name = "instantiated1HandCard55a";

                    } else if (card.name == "instantiated1Card55b(Clone)") {

                        card.name = "instantiated1HandCard55b";

                    } else if (card.name == "instantiated1Card55c(Clone)") {

                        card.name = "instantiated1HandCard55c";

                    } else if (card.name == "instantiated1Card56(Clone)") {

                        card.name = "instantiated1HandCard56";

                    } else if (card.name == "instantiated1Card56a(Clone)") {

                        card.name = "instantiated1HandCard56a";

                    } else if (card.name == "instantiated1Card56b(Clone)") {

                        card.name = "instantiated1HandCard56b";

                    } else if (card.name == "instantiated1Card56c(Clone)") {

                        card.name = "instantiated1HandCard56c";

                    } else if (card.name == "instantiated1Card57(Clone)") {

                        card.name = "instantiated1HandCard57";

                    } else if (card.name == "instantiated1Card57a(Clone)") {

                        card.name = "instantiated1HandCard57a";

                    } else if (card.name == "instantiated1Card57b(Clone)") {

                        card.name = "instantiated1HandCard57b";

                    } else if (card.name == "instantiated1Card57c(Clone)") {

                        card.name = "instantiated1HandCard57c";

                    } else if (card.name == "instantiated1Card58(Clone)") {

                        card.name = "instantiated1HandCard58";

                    } else if (card.name == "instantiated1Card58a(Clone)") {

                        card.name = "instantiated1HandCard58a";

                    } else if (card.name == "instantiated1Card58b(Clone)") {

                        card.name = "instantiated1HandCard58b";

                    } else if (card.name == "instantiated1Card58c(Clone)") {

                        card.name = "instantiated1HandCard58c";

                    } else if (card.name == "instantiated1Card59(Clone)") {

                        card.name = "instantiated1HandCard59";

                    } else if (card.name == "instantiated1Card59a(Clone)") {

                        card.name = "instantiated1HandCard59a";

                    } else if (card.name == "instantiated1Card59b(Clone)") {

                        card.name = "instantiated1HandCard59b";

                    } else if (card.name == "instantiated1Card59c(Clone)") {

                        card.name = "instantiated1HandCard59c";

                    } else if (card.name == "instantiated1Card60(Clone)") {

                        card.name = "instantiated1HandCard60";

                    } else if (card.name == "instantiated1Card60a(Clone)") {

                        card.name = "instantiated1HandCard60a";

                    } else if (card.name == "instantiated1Card60b(Clone)") {

                        card.name = "instantiated1HandCard60b";

                    } else if (card.name == "instantiated1Card60c(Clone)") {

                        card.name = "instantiated1HandCard60c";
                    }

                    instances6M++;

                }

            }

            if (player1DeckSlot7.transform.childCount == 0) {

                while (instances7M < NumberOfCards) {

                    GameObject card = Instantiate(playCardsDeck1[UnityEngine.Random.Range(0, playCardsDeck1.Count)], player1DeckSlot7.transform.position, player1DeckSlot7.transform.rotation) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.transform.parent = player1DeckSlot7.transform;

                    if (card.name == "instantiated1Card1(Clone)") {

                        card.name = "instantiated1HandCard1";

                    } else if (card.name == "instantiated1Card1a(Clone)") {

                        card.name = "instantiated1HandCard1a";

                    } else if (card.name == "instantiated1Card1b(Clone)") {

                        card.name = "instantiated1HandCard1b";

                    } else if (card.name == "instantiated1Card1c(Clone)") {

                        card.name = "instantiated1HandCard1c";

                    } else if (card.name == "instantiated1Card2(Clone)") {

                        card.name = "instantiated1HandCard2";

                    } else if (card.name == "instantiated1Card2a(Clone)") {

                        card.name = "instantiated1HandCard2a";

                    } else if (card.name == "instantiated1Card2b(Clone)") {

                        card.name = "instantiated1HandCard2b";

                    } else if (card.name == "instantiated1Card2c(Clone)") {

                        card.name = "instantiated1HandCard2c";

                    } else if (card.name == "instantiated1Card3(Clone)") {

                        card.name = "instantiated1HandCard3";

                    } else if (card.name == "instantiated1Card3a(Clone)") {

                        card.name = "instantiated1HandCard3a";

                    } else if (card.name == "instantiated1Card3b(Clone)") {

                        card.name = "instantiated1HandCard3b";

                    } else if (card.name == "instantiated1Card3c(Clone)") {

                        card.name = "instantiated1HandCard3c";

                    } else if (card.name == "instantiated1Card4(Clone)") {

                        card.name = "instantiated1HandCard4";

                    } else if (card.name == "instantiated1Card4a(Clone)") {

                        card.name = "instantiated1HandCard4a";

                    } else if (card.name == "instantiated1Card4b(Clone)") {

                        card.name = "instantiated1HandCard4b";

                    } else if (card.name == "instantiated1Card4c(Clone)") {

                        card.name = "instantiated1HandCard4c";

                    } else if (card.name == "instantiated1Card5(Clone)") {

                        card.name = "instantiated1HandCard5";

                    } else if (card.name == "instantiated1Card5a(Clone)") {

                        card.name = "instantiated1HandCard5a";

                    } else if (card.name == "instantiated1Card5b(Clone)") {

                        card.name = "instantiated1HandCard5b";

                    } else if (card.name == "instantiated1Card5c(Clone)") {

                        card.name = "instantiated1HandCard5c";

                    } else if (card.name == "instantiated1Card6(Clone)") {

                        card.name = "instantiated1HandCard6";

                    } else if (card.name == "instantiated1Card6a(Clone)") {

                        card.name = "instantiated1HandCard6a";

                    } else if (card.name == "instantiated1Card6b(Clone)") {

                        card.name = "instantiated1HandCard6b";

                    } else if (card.name == "instantiated1Card6c(Clone)") {

                        card.name = "instantiated1HandCard6c";

                    } else if (card.name == "instantiated1Card7(Clone)") {

                        card.name = "instantiated1HandCard7";

                    } else if (card.name == "instantiated1Card7a(Clone)") {

                        card.name = "instantiated1HandCard7a";

                    } else if (card.name == "instantiated1Card7b(Clone)") {

                        card.name = "instantiated1HandCard7b";

                    } else if (card.name == "instantiated1Card7c(Clone)") {

                        card.name = "instantiated1HandCard7c";

                    } else if (card.name == "instantiated1Card8(Clone)") {

                        card.name = "instantiated1HandCard8";

                    } else if (card.name == "instantiated1Card8a(Clone)") {

                        card.name = "instantiated1HandCard8a";

                    } else if (card.name == "instantiated1Card8b(Clone)") {

                        card.name = "instantiated1HandCard8b";

                    } else if (card.name == "instantiated1Card8c(Clone)") {

                        card.name = "instantiated1HandCard8c";

                    } else if (card.name == "instantiated1Card9(Clone)") {

                        card.name = "instantiated1HandCard9";

                    } else if (card.name == "instantiated1Card9a(Clone)") {

                        card.name = "instantiated1HandCard9a";

                    } else if (card.name == "instantiated1Card9b(Clone)") {

                        card.name = "instantiated1HandCard9b";

                    } else if (card.name == "instantiated1Card9c(Clone)") {

                        card.name = "instantiated1HandCard9c";

                    } else if (card.name == "instantiated1Card10(Clone)") {

                        card.name = "instantiatedAICard10";

                    } else if (card.name == "instantiated1Card10a(Clone)") {

                        card.name = "instantiated1HandCard10a";

                    } else if (card.name == "instantiated1Card10b(Clone)") {

                        card.name = "instantiated1HandCard10b";

                    } else if (card.name == "instantiated1Card10c(Clone)") {

                        card.name = "instantiated1HandCard10c";

                    } else if (card.name == "instantiated1Card11(Clone)") {

                        card.name = "instantiated1HandCard11";

                    } else if (card.name == "instantiated1Card11a(Clone)") {

                        card.name = "instantiated1HandCard11a";

                    } else if (card.name == "instantiated1Card11b(Clone)") {

                        card.name = "instantiated1HandCard11b";

                    } else if (card.name == "instantiated1Card11c(Clone)") {

                        card.name = "instantiated1HandCard11c";

                    } else if (card.name == "instantiated1Card12(Clone)") {

                        card.name = "instantiated1HandCard12";

                    } else if (card.name == "instantiated1Card12a(Clone)") {

                        card.name = "instantiated1HandCard12a";

                    } else if (card.name == "instantiated1Card12b(Clone)") {

                        card.name = "instantiated1HandCard12b";

                    } else if (card.name == "instantiated1Card12c(Clone)") {

                        card.name = "instantiated1HandCard12c";

                    } else if (card.name == "instantiated1Card13(Clone)") {

                        card.name = "instantiated1HandCard13";

                    } else if (card.name == "instantiated1Card13a(Clone)") {

                        card.name = "instantiated1HandCard13a";

                    } else if (card.name == "instantiated1Card13b(Clone)") {

                        card.name = "instantiated1HandCard13b";

                    } else if (card.name == "instantiated1Card13c(Clone)") {

                        card.name = "instantiated1HandCard13c";

                    } else if (card.name == "instantiated1Card14(Clone)") {

                        card.name = "instantiated1HandCard14";

                    } else if (card.name == "instantiated1Card14a(Clone)") {

                        card.name = "instantiated1HandCard14a";

                    } else if (card.name == "instantiated1Card14b(Clone)") {

                        card.name = "instantiated1HandCard14b";

                    } else if (card.name == "instantiated1Card14c(Clone)") {

                        card.name = "instantiated1HandCard14c";

                    } else if (card.name == "instantiated1Card15(Clone)") {

                        card.name = "instantiated1HandCard15";

                    } else if (card.name == "instantiated1Card15a(Clone)") {

                        card.name = "instantiated1HandCard15a";

                    } else if (card.name == "instantiated1Card15b(Clone)") {

                        card.name = "instantiated1HandCard15b";

                    } else if (card.name == "instantiated1Card15c(Clone)") {

                        card.name = "instantiated1HandCard15c";

                    } else if (card.name == "instantiated1Card16(Clone)") {

                        card.name = "instantiated1HandCard16";

                    } else if (card.name == "instantiated1Card16a(Clone)") {

                        card.name = "instantiated1HandCard16a";

                    } else if (card.name == "instantiated1Card16b(Clone)") {

                        card.name = "instantiated1HandCard16b";

                    } else if (card.name == "instantiated1Card16c(Clone)") {

                        card.name = "instantiated1HandCard16c";

                    } else if (card.name == "instantiated1Card17(Clone)") {

                        card.name = "instantiated1HandCard17";

                    } else if (card.name == "instantiated1Card17a(Clone)") {

                        card.name = "instantiated1HandCard17a";

                    } else if (card.name == "instantiated1Card17b(Clone)") {

                        card.name = "instantiated1HandCard17b";

                    } else if (card.name == "instantiated1Card17c(Clone)") {

                        card.name = "instantiated1HandCard17c";

                    } else if (card.name == "instantiated1Card18(Clone)") {

                        card.name = "instantiated1HandCard18";

                    } else if (card.name == "instantiated1Card18a(Clone)") {

                        card.name = "instantiated1HandCard18a";

                    } else if (card.name == "instantiated1Card18b(Clone)") {

                        card.name = "instantiated1HandCard18b";

                    } else if (card.name == "instantiated1Card18c(Clone)") {

                        card.name = "instantiated1HandCard18c";

                    } else if (card.name == "instantiated1Card19(Clone)") {

                        card.name = "instantiated1HandCard19";

                    } else if (card.name == "instantiated1Card19a(Clone)") {

                        card.name = "instantiated1HandCard19a";

                    } else if (card.name == "instantiated1Card19b(Clone)") {

                        card.name = "instantiated1HandCard19b";

                    } else if (card.name == "instantiated1Card19c(Clone)") {

                        card.name = "instantiated1HandCard19c";

                    } else if (card.name == "instantiated1Card20(Clone)") {

                        card.name = "instantiated1HandCard20";

                    } else if (card.name == "instantiated1Card20a(Clone)") {

                        card.name = "instantiated1HandCard20a";

                    } else if (card.name == "instantiated1Card20b(Clone)") {

                        card.name = "instantiated1HandCard20b";

                    } else if (card.name == "instantiated1Card20c(Clone)") {

                        card.name = "instantiated1HandCard20c";

                    } else if (card.name == "instantiated1Card21(Clone)") {

                        card.name = "instantiated1HandCard21";

                    } else if (card.name == "instantiated1Card21a(Clone)") {

                        card.name = "instantiated1HandCard21a";

                    } else if (card.name == "instantiated1Card21b(Clone)") {

                        card.name = "instantiated1HandCard21b";

                    } else if (card.name == "instantiated1Card21c(Clone)") {

                        card.name = "instantiated1HandCard21c";

                    } else if (card.name == "instantiated1Card22(Clone)") {

                        card.name = "instantiated1HandCard22";

                    } else if (card.name == "instantiated1Card22a(Clone)") {

                        card.name = "instantiated1HandCard22a";

                    } else if (card.name == "instantiated1Card22b(Clone)") {

                        card.name = "instantiated1HandCard22b";

                    } else if (card.name == "instantiated1Card22c(Clone)") {

                        card.name = "instantiated1HandCard22c";

                    } else if (card.name == "instantiated1Card23(Clone)") {

                        card.name = "instantiated1HandCard23";

                    } else if (card.name == "instantiated1Card23a(Clone)") {

                        card.name = "instantiated1HandCard23a";

                    } else if (card.name == "instantiated1Card23b(Clone)") {

                        card.name = "instantiated1HandCard23b";

                    } else if (card.name == "instantiated1Card23c(Clone)") {

                        card.name = "instantiated1HandCard23c";

                    } else if (card.name == "instantiated1Card24(Clone)") {

                        card.name = "instantiated1HandCard24";

                    } else if (card.name == "instantiated1Card24a(Clone)") {

                        card.name = "instantiated1HandCard24a";

                    } else if (card.name == "instantiated1Card24b(Clone)") {

                        card.name = "instantiated1HandCard24b";

                    } else if (card.name == "instantiated1Card24c(Clone)") {

                        card.name = "instantiated1HandCard24c";

                    } else if (card.name == "instantiated1Card25(Clone)") {

                        card.name = "instantiated1HandCard25";

                    } else if (card.name == "instantiated1Card25a(Clone)") {

                        card.name = "instantiated1HandCard25a";

                    } else if (card.name == "instantiated1Card25b(Clone)") {

                        card.name = "instantiated1HandCard25b";

                    } else if (card.name == "instantiated1Card25c(Clone)") {

                        card.name = "instantiated1HandCard25c";

                    } else if (card.name == "instantiated1Card26(Clone)") {

                        card.name = "instantiated1HandCard26";

                    } else if (card.name == "instantiated1Card26a(Clone)") {

                        card.name = "instantiated1HandCard26a";

                    } else if (card.name == "instantiated1Card26b(Clone)") {

                        card.name = "instantiated1HandCard26b";

                    } else if (card.name == "instantiated1Card26c(Clone)") {

                        card.name = "instantiated1HandCard26c";

                    } else if (card.name == "instantiated1Card27(Clone)") {

                        card.name = "instantiated1HandCard27";

                    } else if (card.name == "instantiated1Card27a(Clone)") {

                        card.name = "instantiated1HandCard27a";

                    } else if (card.name == "instantiated1Card27b(Clone)") {

                        card.name = "instantiated1HandCard27b";

                    } else if (card.name == "instantiated1Card27c(Clone)") {

                        card.name = "instantiated1HandCard27c";

                    } else if (card.name == "instantiated1Card28(Clone)") {

                        card.name = "instantiated1HandCard28";

                    } else if (card.name == "instantiated1Card28a(Clone)") {

                        card.name = "instantiated1HandCard28a";

                    } else if (card.name == "instantiated1Card28b(Clone)") {

                        card.name = "instantiated1HandCard28b";

                    } else if (card.name == "instantiated1Card28c(Clone)") {

                        card.name = "instantiated1HandCard28c";

                    } else if (card.name == "instantiated1Card29(Clone)") {

                        card.name = "instantiated1HandCard29";

                    } else if (card.name == "instantiated1Card29a(Clone)") {

                        card.name = "instantiated1HandCard29a";

                    } else if (card.name == "instantiated1Card29b(Clone)") {

                        card.name = "instantiated1HandCard29b";

                    } else if (card.name == "instantiated1Card29c(Clone)") {

                        card.name = "instantiated1HandCard29c";

                    } else if (card.name == "instantiated1Card30(Clone)") {

                        card.name = "instantiated1HandCard30";

                    } else if (card.name == "instantiated1Card30a(Clone)") {

                        card.name = "instantiated1HandCard30a";

                    } else if (card.name == "instantiated1Card30b(Clone)") {

                        card.name = "instantiated1HandCard30b";

                    } else if (card.name == "instantiated1Card30c(Clone)") {

                        card.name = "instantiated1HandCard30c";

                    } else if (card.name == "instantiated1Card31(Clone)") {

                        card.name = "instantiated1HandCard31";

                    } else if (card.name == "instantiated1Card31a(Clone)") {

                        card.name = "instantiated1HandCard31a";

                    } else if (card.name == "instantiated1Card31b(Clone)") {

                        card.name = "instantiated1HandCard31b";

                    } else if (card.name == "instantiated1Card31c(Clone)") {

                        card.name = "instantiated1HandCard31c";

                    } else if (card.name == "instantiated1Card32(Clone)") {

                        card.name = "instantiated1HandCard32";

                    } else if (card.name == "instantiated1Card32a(Clone)") {

                        card.name = "instantiated1HandCard32a";

                    } else if (card.name == "instantiated1Card32b(Clone)") {

                        card.name = "instantiated1HandCard32b";

                    } else if (card.name == "instantiated1Card32c(Clone)") {

                        card.name = "instantiated1HandCard32c";

                    } else if (card.name == "instantiated1Card33(Clone)") {

                        card.name = "instantiated1HandCard33";

                    } else if (card.name == "instantiated1Card33a(Clone)") {

                        card.name = "instantiated1HandCard33a";

                    } else if (card.name == "instantiated1Card33b(Clone)") {

                        card.name = "instantiated1HandCard33b";

                    } else if (card.name == "instantiated1Card33c(Clone)") {

                        card.name = "instantiated1HandCard33c";

                    } else if (card.name == "instantiated1Card34(Clone)") {

                        card.name = "instantiated1HandCard34";

                    } else if (card.name == "instantiated1Card34a(Clone)") {

                        card.name = "instantiated1HandCard34a";

                    } else if (card.name == "instantiated1Card34b(Clone)") {

                        card.name = "instantiated1HandCard34b";

                    } else if (card.name == "instantiated1Card34c(Clone)") {

                        card.name = "instantiated1HandCard34c";

                    } else if (card.name == "instantiated1Card35(Clone)") {

                        card.name = "instantiated1HandCard35";

                    } else if (card.name == "instantiated1Card35a(Clone)") {

                        card.name = "instantiated1HandCard35a";

                    } else if (card.name == "instantiated1Card35b(Clone)") {

                        card.name = "instantiated1HandCard35b";

                    } else if (card.name == "instantiated1Card35c(Clone)") {

                        card.name = "instantiated1HandCard35c";

                    } else if (card.name == "instantiated1Card36(Clone)") {

                        card.name = "instantiated1HandCard36";

                    } else if (card.name == "instantiated1Card36a(Clone)") {

                        card.name = "instantiated1HandCard36a";

                    } else if (card.name == "instantiated1Card36b(Clone)") {

                        card.name = "instantiated1HandCard36b";

                    } else if (card.name == "instantiated1Card36c(Clone)") {

                        card.name = "instantiated1HandCard36c";

                    } else if (card.name == "instantiated1Card37(Clone)") {

                        card.name = "instantiated1HandCard37";

                    } else if (card.name == "instantiated1Card37a(Clone)") {

                        card.name = "instantiated1HandCard37a";

                    } else if (card.name == "instantiated1Card37b(Clone)") {

                        card.name = "instantiated1HandCard37b";

                    } else if (card.name == "instantiated1Card37c(Clone)") {

                        card.name = "instantiated1HandCard37c";

                    } else if (card.name == "instantiated1Card38(Clone)") {

                        card.name = "instantiated1HandCard38";

                    } else if (card.name == "instantiated1Card38a(Clone)") {

                        card.name = "instantiated1HandCard38a";

                    } else if (card.name == "instantiated1Card38b(Clone)") {

                        card.name = "instantiated1HandCard38b";

                    } else if (card.name == "instantiated1Card38c(Clone)") {

                        card.name = "instantiated1HandCard38c";

                    } else if (card.name == "instantiated1Card39(Clone)") {

                        card.name = "instantiated1HandCard39";

                    } else if (card.name == "instantiated1Card39a(Clone)") {

                        card.name = "instantiated1HandCard39a";

                    } else if (card.name == "instantiated1Card39b(Clone)") {

                        card.name = "instantiated1HandCard39b";

                    } else if (card.name == "instantiated1Card39c(Clone)") {

                        card.name = "instantiated1HandCard39c";

                    } else if (card.name == "instantiated1Card40(Clone)") {

                        card.name = "instantiated1HandCard40";

                    } else if (card.name == "instantiated1Card40a(Clone)") {

                        card.name = "instantiated1HandCard40a";

                    } else if (card.name == "instantiated1Card40b(Clone)") {

                        card.name = "instantiated1HandCard40b";

                    } else if (card.name == "instantiated1Card40c(Clone)") {

                        card.name = "instantiated1HandCard40c";

                    } else if (card.name == "instantiated1Card41(Clone)") {

                        card.name = "instantiated1HandCard41";

                    } else if (card.name == "instantiated1Card41a(Clone)") {

                        card.name = "instantiated1HandCard41a";

                    } else if (card.name == "instantiated1Card41b(Clone)") {

                        card.name = "instantiated1HandCard41b";

                    } else if (card.name == "instantiated1Card41c(Clone)") {

                        card.name = "instantiated1HandCard41c";

                    } else if (card.name == "instantiated1Card42(Clone)") {

                        card.name = "instantiated1HandCard42";

                    } else if (card.name == "instantiated1Card42a(Clone)") {

                        card.name = "instantiated1HandCard42a";

                    } else if (card.name == "instantiated1Card42b(Clone)") {

                        card.name = "instantiated1HandCard42b";

                    } else if (card.name == "instantiated1Card42c(Clone)") {

                        card.name = "instantiated1HandCard42c";

                    } else if (card.name == "instantiated1Card43(Clone)") {

                        card.name = "instantiated1HandCard43";

                    } else if (card.name == "instantiated1Card43a(Clone)") {

                        card.name = "instantiated1HandCard43a";

                    } else if (card.name == "instantiated1Card43b(Clone)") {

                        card.name = "instantiated1HandCard43b";

                    } else if (card.name == "instantiated1Card43c(Clone)") {

                        card.name = "instantiated1HandCard43c";

                    } else if (card.name == "instantiated1Card44(Clone)") {

                        card.name = "instantiated1HandCard44";

                    } else if (card.name == "instantiated1Card44a(Clone)") {

                        card.name = "instantiated1HandCard44a";

                    } else if (card.name == "instantiated1Card44b(Clone)") {

                        card.name = "instantiated1HandCard44b";

                    } else if (card.name == "instantiated1Card44c(Clone)") {

                        card.name = "instantiated1HandCard44c";

                    } else if (card.name == "instantiated1Card45(Clone)") {

                        card.name = "instantiated1HandCard45";

                    } else if (card.name == "instantiated1Card45a(Clone)") {

                        card.name = "instantiated1HandCard45a";

                    } else if (card.name == "instantiated1Card45b(Clone)") {

                        card.name = "instantiated1HandCard45b";

                    } else if (card.name == "instantiated1Card45c(Clone)") {

                        card.name = "instantiated1HandCard45c";

                    } else if (card.name == "instantiated1Card46(Clone)") {

                        card.name = "instantiated1HandCard46";

                    } else if (card.name == "instantiated1Card46a(Clone)") {

                        card.name = "instantiated1HandCard46a";

                    } else if (card.name == "instantiated1Card46b(Clone)") {

                        card.name = "instantiated1HandCard46b";

                    } else if (card.name == "instantiated1Card46c(Clone)") {

                        card.name = "instantiated1HandCard46c";

                    } else if (card.name == "instantiated1Card47(Clone)") {

                        card.name = "instantiated1HandCard47";

                    } else if (card.name == "instantiated1Card47a(Clone)") {

                        card.name = "instantiated1HandCard47a";

                    } else if (card.name == "instantiated1Card47b(Clone)") {

                        card.name = "instantiated1HandCard47b";

                    } else if (card.name == "instantiated1Card47c(Clone)") {

                        card.name = "instantiated1HandCard47c";

                    } else if (card.name == "instantiated1Card48(Clone)") {

                        card.name = "instantiated1HandCard48";

                    } else if (card.name == "instantiated1Card48a(Clone)") {

                        card.name = "instantiated1HandCard48a";

                    } else if (card.name == "instantiated1Card48b(Clone)") {

                        card.name = "instantiated1HandCard48b";

                    } else if (card.name == "instantiated1Card48c(Clone)") {

                        card.name = "instantiated1HandCard48c";

                    } else if (card.name == "instantiated1Card49(Clone)") {

                        card.name = "instantiated1HandCard49";

                    } else if (card.name == "instantiated1Card49a(Clone)") {

                        card.name = "instantiated1HandCard49a";

                    } else if (card.name == "instantiated1Card49b(Clone)") {

                        card.name = "instantiated1HandCard49b";

                    } else if (card.name == "instantiated1Card49c(Clone)") {

                        card.name = "instantiated1HandCard49c";

                    } else if (card.name == "instantiated1Card50(Clone)") {

                        card.name = "instantiated1HandCard50";

                    } else if (card.name == "instantiated1Card50a(Clone)") {

                        card.name = "instantiated1HandCard50a";

                    } else if (card.name == "instantiated1Card50b(Clone)") {

                        card.name = "instantiated1HandCard50b";

                    } else if (card.name == "instantiated1Card50c(Clone)") {

                        card.name = "instantiated1HandCard50c";

                    } else if (card.name == "instantiated1Card51(Clone)") {

                        card.name = "instantiated1HandCard51";

                    } else if (card.name == "instantiated1Card51a(Clone)") {

                        card.name = "instantiated1HandCard51a";

                    } else if (card.name == "instantiated1Card51b(Clone)") {

                        card.name = "instantiated1HandCard51b";

                    } else if (card.name == "instantiated1Card51c(Clone)") {

                        card.name = "instantiated1HandCard51c";

                    } else if (card.name == "instantiated1Card52(Clone)") {

                        card.name = "instantiated1HandCard52";

                    } else if (card.name == "instantiated1Card52a(Clone)") {

                        card.name = "instantiated1HandCard52a";

                    } else if (card.name == "instantiated1Card52b(Clone)") {

                        card.name = "instantiated1HandCard52b";

                    } else if (card.name == "instantiated1Card52c(Clone)") {

                        card.name = "instantiated1HandCard52c";

                    } else if (card.name == "instantiated1Card53(Clone)") {

                        card.name = "instantiated1HandCard53";

                    } else if (card.name == "instantiated1Card53a(Clone)") {

                        card.name = "instantiated1HandCard53a";

                    } else if (card.name == "instantiated1Card53b(Clone)") {

                        card.name = "instantiated1HandCard53b";

                    } else if (card.name == "instantiated1Card53c(Clone)") {

                        card.name = "instantiated1HandCard53c";

                    } else if (card.name == "instantiated1Card54(Clone)") {

                        card.name = "instantiated1HandCard54";

                    } else if (card.name == "instantiated1Card54a(Clone)") {

                        card.name = "instantiated1HandCard54a";

                    } else if (card.name == "instantiated1Card54b(Clone)") {

                        card.name = "instantiated1HandCard54b";

                    } else if (card.name == "instantiated1Card54c(Clone)") {

                        card.name = "instantiated1HandCard54c";

                    } else if (card.name == "instantiated1Card55(Clone)") {

                        card.name = "instantiated1HandCard55";

                    } else if (card.name == "instantiated1Card55a(Clone)") {

                        card.name = "instantiated1HandCard55a";

                    } else if (card.name == "instantiated1Card55b(Clone)") {

                        card.name = "instantiated1HandCard55b";

                    } else if (card.name == "instantiated1Card55c(Clone)") {

                        card.name = "instantiated1HandCard55c";

                    } else if (card.name == "instantiated1Card56(Clone)") {

                        card.name = "instantiated1HandCard56";

                    } else if (card.name == "instantiated1Card56a(Clone)") {

                        card.name = "instantiated1HandCard56a";

                    } else if (card.name == "instantiated1Card56b(Clone)") {

                        card.name = "instantiated1HandCard56b";

                    } else if (card.name == "instantiated1Card56c(Clone)") {

                        card.name = "instantiated1HandCard56c";

                    } else if (card.name == "instantiated1Card57(Clone)") {

                        card.name = "instantiated1HandCard57";

                    } else if (card.name == "instantiated1Card57a(Clone)") {

                        card.name = "instantiated1HandCard57a";

                    } else if (card.name == "instantiated1Card57b(Clone)") {

                        card.name = "instantiated1HandCard57b";

                    } else if (card.name == "instantiated1Card57c(Clone)") {

                        card.name = "instantiated1HandCard57c";

                    } else if (card.name == "instantiated1Card58(Clone)") {

                        card.name = "instantiated1HandCard58";

                    } else if (card.name == "instantiated1Card58a(Clone)") {

                        card.name = "instantiated1HandCard58a";

                    } else if (card.name == "instantiated1Card58b(Clone)") {

                        card.name = "instantiated1HandCard58b";

                    } else if (card.name == "instantiated1Card58c(Clone)") {

                        card.name = "instantiated1HandCard58c";

                    } else if (card.name == "instantiated1Card59(Clone)") {

                        card.name = "instantiated1HandCard59";

                    } else if (card.name == "instantiated1Card59a(Clone)") {

                        card.name = "instantiated1HandCard59a";

                    } else if (card.name == "instantiated1Card59b(Clone)") {

                        card.name = "instantiated1HandCard59b";

                    } else if (card.name == "instantiated1Card59c(Clone)") {

                        card.name = "instantiated1HandCard59c";

                    } else if (card.name == "instantiated1Card60(Clone)") {

                        card.name = "instantiated1HandCard60";

                    } else if (card.name == "instantiated1Card60a(Clone)") {

                        card.name = "instantiated1HandCard60a";

                    } else if (card.name == "instantiated1Card60b(Clone)") {

                        card.name = "instantiated1HandCard60b";

                    } else if (card.name == "instantiated1Card60c(Clone)") {

                        card.name = "instantiated1HandCard60c";
                    }

                    instances7M++;

                }

            }

            if (player1DeckSlot8.transform.childCount == 0) {

                while (instances8M < NumberOfCards) {

                    GameObject card = Instantiate(playCardsDeck1[UnityEngine.Random.Range(0, playCardsDeck1.Count)], player1DeckSlot8.transform.position, player1DeckSlot8.transform.rotation) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.transform.parent = player1DeckSlot8.transform;

                    if (card.name == "instantiated1Card1(Clone)") {

                        card.name = "instantiated1HandCard1";

                    } else if (card.name == "instantiated1Card1a(Clone)") {

                        card.name = "instantiated1HandCard1a";

                    } else if (card.name == "instantiated1Card1b(Clone)") {

                        card.name = "instantiated1HandCard1b";

                    } else if (card.name == "instantiated1Card1c(Clone)") {

                        card.name = "instantiated1HandCard1c";

                    } else if (card.name == "instantiated1Card2(Clone)") {

                        card.name = "instantiated1HandCard2";

                    } else if (card.name == "instantiated1Card2a(Clone)") {

                        card.name = "instantiated1HandCard2a";

                    } else if (card.name == "instantiated1Card2b(Clone)") {

                        card.name = "instantiated1HandCard2b";

                    } else if (card.name == "instantiated1Card2c(Clone)") {

                        card.name = "instantiated1HandCard2c";

                    } else if (card.name == "instantiated1Card3(Clone)") {

                        card.name = "instantiated1HandCard3";

                    } else if (card.name == "instantiated1Card3a(Clone)") {

                        card.name = "instantiated1HandCard3a";

                    } else if (card.name == "instantiated1Card3b(Clone)") {

                        card.name = "instantiated1HandCard3b";

                    } else if (card.name == "instantiated1Card3c(Clone)") {

                        card.name = "instantiated1HandCard3c";

                    } else if (card.name == "instantiated1Card4(Clone)") {

                        card.name = "instantiated1HandCard4";

                    } else if (card.name == "instantiated1Card4a(Clone)") {

                        card.name = "instantiated1HandCard4a";

                    } else if (card.name == "instantiated1Card4b(Clone)") {

                        card.name = "instantiated1HandCard4b";

                    } else if (card.name == "instantiated1Card4c(Clone)") {

                        card.name = "instantiated1HandCard4c";

                    } else if (card.name == "instantiated1Card5(Clone)") {

                        card.name = "instantiated1HandCard5";

                    } else if (card.name == "instantiated1Card5a(Clone)") {

                        card.name = "instantiated1HandCard5a";

                    } else if (card.name == "instantiated1Card5b(Clone)") {

                        card.name = "instantiated1HandCard5b";

                    } else if (card.name == "instantiated1Card5c(Clone)") {

                        card.name = "instantiated1HandCard5c";

                    } else if (card.name == "instantiated1Card6(Clone)") {

                        card.name = "instantiated1HandCard6";

                    } else if (card.name == "instantiated1Card6a(Clone)") {

                        card.name = "instantiated1HandCard6a";

                    } else if (card.name == "instantiated1Card6b(Clone)") {

                        card.name = "instantiated1HandCard6b";

                    } else if (card.name == "instantiated1Card6c(Clone)") {

                        card.name = "instantiated1HandCard6c";

                    } else if (card.name == "instantiated1Card7(Clone)") {

                        card.name = "instantiated1HandCard7";

                    } else if (card.name == "instantiated1Card7a(Clone)") {

                        card.name = "instantiated1HandCard7a";

                    } else if (card.name == "instantiated1Card7b(Clone)") {

                        card.name = "instantiated1HandCard7b";

                    } else if (card.name == "instantiated1Card7c(Clone)") {

                        card.name = "instantiated1HandCard7c";

                    } else if (card.name == "instantiated1Card8(Clone)") {

                        card.name = "instantiated1HandCard8";

                    } else if (card.name == "instantiated1Card8a(Clone)") {

                        card.name = "instantiated1HandCard8a";

                    } else if (card.name == "instantiated1Card8b(Clone)") {

                        card.name = "instantiated1HandCard8b";

                    } else if (card.name == "instantiated1Card8c(Clone)") {

                        card.name = "instantiated1HandCard8c";

                    } else if (card.name == "instantiated1Card9(Clone)") {

                        card.name = "instantiated1HandCard9";

                    } else if (card.name == "instantiated1Card9a(Clone)") {

                        card.name = "instantiated1HandCard9a";

                    } else if (card.name == "instantiated1Card9b(Clone)") {

                        card.name = "instantiated1HandCard9b";

                    } else if (card.name == "instantiated1Card9c(Clone)") {

                        card.name = "instantiated1HandCard9c";

                    } else if (card.name == "instantiated1Card10(Clone)") {

                        card.name = "instantiatedAICard10";

                    } else if (card.name == "instantiated1Card10a(Clone)") {

                        card.name = "instantiated1HandCard10a";

                    } else if (card.name == "instantiated1Card10b(Clone)") {

                        card.name = "instantiated1HandCard10b";

                    } else if (card.name == "instantiated1Card10c(Clone)") {

                        card.name = "instantiated1HandCard10c";

                    } else if (card.name == "instantiated1Card11(Clone)") {

                        card.name = "instantiated1HandCard11";

                    } else if (card.name == "instantiated1Card11a(Clone)") {

                        card.name = "instantiated1HandCard11a";

                    } else if (card.name == "instantiated1Card11b(Clone)") {

                        card.name = "instantiated1HandCard11b";

                    } else if (card.name == "instantiated1Card11c(Clone)") {

                        card.name = "instantiated1HandCard11c";

                    } else if (card.name == "instantiated1Card12(Clone)") {

                        card.name = "instantiated1HandCard12";

                    } else if (card.name == "instantiated1Card12a(Clone)") {

                        card.name = "instantiated1HandCard12a";

                    } else if (card.name == "instantiated1Card12b(Clone)") {

                        card.name = "instantiated1HandCard12b";

                    } else if (card.name == "instantiated1Card12c(Clone)") {

                        card.name = "instantiated1HandCard12c";

                    } else if (card.name == "instantiated1Card13(Clone)") {

                        card.name = "instantiated1HandCard13";

                    } else if (card.name == "instantiated1Card13a(Clone)") {

                        card.name = "instantiated1HandCard13a";

                    } else if (card.name == "instantiated1Card13b(Clone)") {

                        card.name = "instantiated1HandCard13b";

                    } else if (card.name == "instantiated1Card13c(Clone)") {

                        card.name = "instantiated1HandCard13c";

                    } else if (card.name == "instantiated1Card14(Clone)") {

                        card.name = "instantiated1HandCard14";

                    } else if (card.name == "instantiated1Card14a(Clone)") {

                        card.name = "instantiated1HandCard14a";

                    } else if (card.name == "instantiated1Card14b(Clone)") {

                        card.name = "instantiated1HandCard14b";

                    } else if (card.name == "instantiated1Card14c(Clone)") {

                        card.name = "instantiated1HandCard14c";

                    } else if (card.name == "instantiated1Card15(Clone)") {

                        card.name = "instantiated1HandCard15";

                    } else if (card.name == "instantiated1Card15a(Clone)") {

                        card.name = "instantiated1HandCard15a";

                    } else if (card.name == "instantiated1Card15b(Clone)") {

                        card.name = "instantiated1HandCard15b";

                    } else if (card.name == "instantiated1Card15c(Clone)") {

                        card.name = "instantiated1HandCard15c";

                    } else if (card.name == "instantiated1Card16(Clone)") {

                        card.name = "instantiated1HandCard16";

                    } else if (card.name == "instantiated1Card16a(Clone)") {

                        card.name = "instantiated1HandCard16a";

                    } else if (card.name == "instantiated1Card16b(Clone)") {

                        card.name = "instantiated1HandCard16b";

                    } else if (card.name == "instantiated1Card16c(Clone)") {

                        card.name = "instantiated1HandCard16c";

                    } else if (card.name == "instantiated1Card17(Clone)") {

                        card.name = "instantiated1HandCard17";

                    } else if (card.name == "instantiated1Card17a(Clone)") {

                        card.name = "instantiated1HandCard17a";

                    } else if (card.name == "instantiated1Card17b(Clone)") {

                        card.name = "instantiated1HandCard17b";

                    } else if (card.name == "instantiated1Card17c(Clone)") {

                        card.name = "instantiated1HandCard17c";

                    } else if (card.name == "instantiated1Card18(Clone)") {

                        card.name = "instantiated1HandCard18";

                    } else if (card.name == "instantiated1Card18a(Clone)") {

                        card.name = "instantiated1HandCard18a";

                    } else if (card.name == "instantiated1Card18b(Clone)") {

                        card.name = "instantiated1HandCard18b";

                    } else if (card.name == "instantiated1Card18c(Clone)") {

                        card.name = "instantiated1HandCard18c";

                    } else if (card.name == "instantiated1Card19(Clone)") {

                        card.name = "instantiated1HandCard19";

                    } else if (card.name == "instantiated1Card19a(Clone)") {

                        card.name = "instantiated1HandCard19a";

                    } else if (card.name == "instantiated1Card19b(Clone)") {

                        card.name = "instantiated1HandCard19b";

                    } else if (card.name == "instantiated1Card19c(Clone)") {

                        card.name = "instantiated1HandCard19c";

                    } else if (card.name == "instantiated1Card20(Clone)") {

                        card.name = "instantiated1HandCard20";

                    } else if (card.name == "instantiated1Card20a(Clone)") {

                        card.name = "instantiated1HandCard20a";

                    } else if (card.name == "instantiated1Card20b(Clone)") {

                        card.name = "instantiated1HandCard20b";

                    } else if (card.name == "instantiated1Card20c(Clone)") {

                        card.name = "instantiated1HandCard20c";

                    } else if (card.name == "instantiated1Card21(Clone)") {

                        card.name = "instantiated1HandCard21";

                    } else if (card.name == "instantiated1Card21a(Clone)") {

                        card.name = "instantiated1HandCard21a";

                    } else if (card.name == "instantiated1Card21b(Clone)") {

                        card.name = "instantiated1HandCard21b";

                    } else if (card.name == "instantiated1Card21c(Clone)") {

                        card.name = "instantiated1HandCard21c";

                    } else if (card.name == "instantiated1Card22(Clone)") {

                        card.name = "instantiated1HandCard22";

                    } else if (card.name == "instantiated1Card22a(Clone)") {

                        card.name = "instantiated1HandCard22a";

                    } else if (card.name == "instantiated1Card22b(Clone)") {

                        card.name = "instantiated1HandCard22b";

                    } else if (card.name == "instantiated1Card22c(Clone)") {

                        card.name = "instantiated1HandCard22c";

                    } else if (card.name == "instantiated1Card23(Clone)") {

                        card.name = "instantiated1HandCard23";

                    } else if (card.name == "instantiated1Card23a(Clone)") {

                        card.name = "instantiated1HandCard23a";

                    } else if (card.name == "instantiated1Card23b(Clone)") {

                        card.name = "instantiated1HandCard23b";

                    } else if (card.name == "instantiated1Card23c(Clone)") {

                        card.name = "instantiated1HandCard23c";

                    } else if (card.name == "instantiated1Card24(Clone)") {

                        card.name = "instantiated1HandCard24";

                    } else if (card.name == "instantiated1Card24a(Clone)") {

                        card.name = "instantiated1HandCard24a";

                    } else if (card.name == "instantiated1Card24b(Clone)") {

                        card.name = "instantiated1HandCard24b";

                    } else if (card.name == "instantiated1Card24c(Clone)") {

                        card.name = "instantiated1HandCard24c";

                    } else if (card.name == "instantiated1Card25(Clone)") {

                        card.name = "instantiated1HandCard25";

                    } else if (card.name == "instantiated1Card25a(Clone)") {

                        card.name = "instantiated1HandCard25a";

                    } else if (card.name == "instantiated1Card25b(Clone)") {

                        card.name = "instantiated1HandCard25b";

                    } else if (card.name == "instantiated1Card25c(Clone)") {

                        card.name = "instantiated1HandCard25c";

                    } else if (card.name == "instantiated1Card26(Clone)") {

                        card.name = "instantiated1HandCard26";

                    } else if (card.name == "instantiated1Card26a(Clone)") {

                        card.name = "instantiated1HandCard26a";

                    } else if (card.name == "instantiated1Card26b(Clone)") {

                        card.name = "instantiated1HandCard26b";

                    } else if (card.name == "instantiated1Card26c(Clone)") {

                        card.name = "instantiated1HandCard26c";

                    } else if (card.name == "instantiated1Card27(Clone)") {

                        card.name = "instantiated1HandCard27";

                    } else if (card.name == "instantiated1Card27a(Clone)") {

                        card.name = "instantiated1HandCard27a";

                    } else if (card.name == "instantiated1Card27b(Clone)") {

                        card.name = "instantiated1HandCard27b";

                    } else if (card.name == "instantiated1Card27c(Clone)") {

                        card.name = "instantiated1HandCard27c";

                    } else if (card.name == "instantiated1Card28(Clone)") {

                        card.name = "instantiated1HandCard28";

                    } else if (card.name == "instantiated1Card28a(Clone)") {

                        card.name = "instantiated1HandCard28a";

                    } else if (card.name == "instantiated1Card28b(Clone)") {

                        card.name = "instantiated1HandCard28b";

                    } else if (card.name == "instantiated1Card28c(Clone)") {

                        card.name = "instantiated1HandCard28c";

                    } else if (card.name == "instantiated1Card29(Clone)") {

                        card.name = "instantiated1HandCard29";

                    } else if (card.name == "instantiated1Card29a(Clone)") {

                        card.name = "instantiated1HandCard29a";

                    } else if (card.name == "instantiated1Card29b(Clone)") {

                        card.name = "instantiated1HandCard29b";

                    } else if (card.name == "instantiated1Card29c(Clone)") {

                        card.name = "instantiated1HandCard29c";

                    } else if (card.name == "instantiated1Card30(Clone)") {

                        card.name = "instantiated1HandCard30";

                    } else if (card.name == "instantiated1Card30a(Clone)") {

                        card.name = "instantiated1HandCard30a";

                    } else if (card.name == "instantiated1Card30b(Clone)") {

                        card.name = "instantiated1HandCard30b";

                    } else if (card.name == "instantiated1Card30c(Clone)") {

                        card.name = "instantiated1HandCard30c";

                    } else if (card.name == "instantiated1Card31(Clone)") {

                        card.name = "instantiated1HandCard31";

                    } else if (card.name == "instantiated1Card31a(Clone)") {

                        card.name = "instantiated1HandCard31a";

                    } else if (card.name == "instantiated1Card31b(Clone)") {

                        card.name = "instantiated1HandCard31b";

                    } else if (card.name == "instantiated1Card31c(Clone)") {

                        card.name = "instantiated1HandCard31c";

                    } else if (card.name == "instantiated1Card32(Clone)") {

                        card.name = "instantiated1HandCard32";

                    } else if (card.name == "instantiated1Card32a(Clone)") {

                        card.name = "instantiated1HandCard32a";

                    } else if (card.name == "instantiated1Card32b(Clone)") {

                        card.name = "instantiated1HandCard32b";

                    } else if (card.name == "instantiated1Card32c(Clone)") {

                        card.name = "instantiated1HandCard32c";

                    } else if (card.name == "instantiated1Card33(Clone)") {

                        card.name = "instantiated1HandCard33";

                    } else if (card.name == "instantiated1Card33a(Clone)") {

                        card.name = "instantiated1HandCard33a";

                    } else if (card.name == "instantiated1Card33b(Clone)") {

                        card.name = "instantiated1HandCard33b";

                    } else if (card.name == "instantiated1Card33c(Clone)") {

                        card.name = "instantiated1HandCard33c";

                    } else if (card.name == "instantiated1Card34(Clone)") {

                        card.name = "instantiated1HandCard34";

                    } else if (card.name == "instantiated1Card34a(Clone)") {

                        card.name = "instantiated1HandCard34a";

                    } else if (card.name == "instantiated1Card34b(Clone)") {

                        card.name = "instantiated1HandCard34b";

                    } else if (card.name == "instantiated1Card34c(Clone)") {

                        card.name = "instantiated1HandCard34c";

                    } else if (card.name == "instantiated1Card35(Clone)") {

                        card.name = "instantiated1HandCard35";

                    } else if (card.name == "instantiated1Card35a(Clone)") {

                        card.name = "instantiated1HandCard35a";

                    } else if (card.name == "instantiated1Card35b(Clone)") {

                        card.name = "instantiated1HandCard35b";

                    } else if (card.name == "instantiated1Card35c(Clone)") {

                        card.name = "instantiated1HandCard35c";

                    } else if (card.name == "instantiated1Card36(Clone)") {

                        card.name = "instantiated1HandCard36";

                    } else if (card.name == "instantiated1Card36a(Clone)") {

                        card.name = "instantiated1HandCard36a";

                    } else if (card.name == "instantiated1Card36b(Clone)") {

                        card.name = "instantiated1HandCard36b";

                    } else if (card.name == "instantiated1Card36c(Clone)") {

                        card.name = "instantiated1HandCard36c";

                    } else if (card.name == "instantiated1Card37(Clone)") {

                        card.name = "instantiated1HandCard37";

                    } else if (card.name == "instantiated1Card37a(Clone)") {

                        card.name = "instantiated1HandCard37a";

                    } else if (card.name == "instantiated1Card37b(Clone)") {

                        card.name = "instantiated1HandCard37b";

                    } else if (card.name == "instantiated1Card37c(Clone)") {

                        card.name = "instantiated1HandCard37c";

                    } else if (card.name == "instantiated1Card38(Clone)") {

                        card.name = "instantiated1HandCard38";

                    } else if (card.name == "instantiated1Card38a(Clone)") {

                        card.name = "instantiated1HandCard38a";

                    } else if (card.name == "instantiated1Card38b(Clone)") {

                        card.name = "instantiated1HandCard38b";

                    } else if (card.name == "instantiated1Card38c(Clone)") {

                        card.name = "instantiated1HandCard38c";

                    } else if (card.name == "instantiated1Card39(Clone)") {

                        card.name = "instantiated1HandCard39";

                    } else if (card.name == "instantiated1Card39a(Clone)") {

                        card.name = "instantiated1HandCard39a";

                    } else if (card.name == "instantiated1Card39b(Clone)") {

                        card.name = "instantiated1HandCard39b";

                    } else if (card.name == "instantiated1Card39c(Clone)") {

                        card.name = "instantiated1HandCard39c";

                    } else if (card.name == "instantiated1Card40(Clone)") {

                        card.name = "instantiated1HandCard40";

                    } else if (card.name == "instantiated1Card40a(Clone)") {

                        card.name = "instantiated1HandCard40a";

                    } else if (card.name == "instantiated1Card40b(Clone)") {

                        card.name = "instantiated1HandCard40b";

                    } else if (card.name == "instantiated1Card40c(Clone)") {

                        card.name = "instantiated1HandCard40c";

                    } else if (card.name == "instantiated1Card41(Clone)") {

                        card.name = "instantiated1HandCard41";

                    } else if (card.name == "instantiated1Card41a(Clone)") {

                        card.name = "instantiated1HandCard41a";

                    } else if (card.name == "instantiated1Card41b(Clone)") {

                        card.name = "instantiated1HandCard41b";

                    } else if (card.name == "instantiated1Card41c(Clone)") {

                        card.name = "instantiated1HandCard41c";

                    } else if (card.name == "instantiated1Card42(Clone)") {

                        card.name = "instantiated1HandCard42";

                    } else if (card.name == "instantiated1Card42a(Clone)") {

                        card.name = "instantiated1HandCard42a";

                    } else if (card.name == "instantiated1Card42b(Clone)") {

                        card.name = "instantiated1HandCard42b";

                    } else if (card.name == "instantiated1Card42c(Clone)") {

                        card.name = "instantiated1HandCard42c";

                    } else if (card.name == "instantiated1Card43(Clone)") {

                        card.name = "instantiated1HandCard43";

                    } else if (card.name == "instantiated1Card43a(Clone)") {

                        card.name = "instantiated1HandCard43a";

                    } else if (card.name == "instantiated1Card43b(Clone)") {

                        card.name = "instantiated1HandCard43b";

                    } else if (card.name == "instantiated1Card43c(Clone)") {

                        card.name = "instantiated1HandCard43c";

                    } else if (card.name == "instantiated1Card44(Clone)") {

                        card.name = "instantiated1HandCard44";

                    } else if (card.name == "instantiated1Card44a(Clone)") {

                        card.name = "instantiated1HandCard44a";

                    } else if (card.name == "instantiated1Card44b(Clone)") {

                        card.name = "instantiated1HandCard44b";

                    } else if (card.name == "instantiated1Card44c(Clone)") {

                        card.name = "instantiated1HandCard44c";

                    } else if (card.name == "instantiated1Card45(Clone)") {

                        card.name = "instantiated1HandCard45";

                    } else if (card.name == "instantiated1Card45a(Clone)") {

                        card.name = "instantiated1HandCard45a";

                    } else if (card.name == "instantiated1Card45b(Clone)") {

                        card.name = "instantiated1HandCard45b";

                    } else if (card.name == "instantiated1Card45c(Clone)") {

                        card.name = "instantiated1HandCard45c";

                    } else if (card.name == "instantiated1Card46(Clone)") {

                        card.name = "instantiated1HandCard46";

                    } else if (card.name == "instantiated1Card46a(Clone)") {

                        card.name = "instantiated1HandCard46a";

                    } else if (card.name == "instantiated1Card46b(Clone)") {

                        card.name = "instantiated1HandCard46b";

                    } else if (card.name == "instantiated1Card46c(Clone)") {

                        card.name = "instantiated1HandCard46c";

                    } else if (card.name == "instantiated1Card47(Clone)") {

                        card.name = "instantiated1HandCard47";

                    } else if (card.name == "instantiated1Card47a(Clone)") {

                        card.name = "instantiated1HandCard47a";

                    } else if (card.name == "instantiated1Card47b(Clone)") {

                        card.name = "instantiated1HandCard47b";

                    } else if (card.name == "instantiated1Card47c(Clone)") {

                        card.name = "instantiated1HandCard47c";

                    } else if (card.name == "instantiated1Card48(Clone)") {

                        card.name = "instantiated1HandCard48";

                    } else if (card.name == "instantiated1Card48a(Clone)") {

                        card.name = "instantiated1HandCard48a";

                    } else if (card.name == "instantiated1Card48b(Clone)") {

                        card.name = "instantiated1HandCard48b";

                    } else if (card.name == "instantiated1Card48c(Clone)") {

                        card.name = "instantiated1HandCard48c";

                    } else if (card.name == "instantiated1Card49(Clone)") {

                        card.name = "instantiated1HandCard49";

                    } else if (card.name == "instantiated1Card49a(Clone)") {

                        card.name = "instantiated1HandCard49a";

                    } else if (card.name == "instantiated1Card49b(Clone)") {

                        card.name = "instantiated1HandCard49b";

                    } else if (card.name == "instantiated1Card49c(Clone)") {

                        card.name = "instantiated1HandCard49c";

                    } else if (card.name == "instantiated1Card50(Clone)") {

                        card.name = "instantiated1HandCard50";

                    } else if (card.name == "instantiated1Card50a(Clone)") {

                        card.name = "instantiated1HandCard50a";

                    } else if (card.name == "instantiated1Card50b(Clone)") {

                        card.name = "instantiated1HandCard50b";

                    } else if (card.name == "instantiated1Card50c(Clone)") {

                        card.name = "instantiated1HandCard50c";

                    } else if (card.name == "instantiated1Card51(Clone)") {

                        card.name = "instantiated1HandCard51";

                    } else if (card.name == "instantiated1Card51a(Clone)") {

                        card.name = "instantiated1HandCard51a";

                    } else if (card.name == "instantiated1Card51b(Clone)") {

                        card.name = "instantiated1HandCard51b";

                    } else if (card.name == "instantiated1Card51c(Clone)") {

                        card.name = "instantiated1HandCard51c";

                    } else if (card.name == "instantiated1Card52(Clone)") {

                        card.name = "instantiated1HandCard52";

                    } else if (card.name == "instantiated1Card52a(Clone)") {

                        card.name = "instantiated1HandCard52a";

                    } else if (card.name == "instantiated1Card52b(Clone)") {

                        card.name = "instantiated1HandCard52b";

                    } else if (card.name == "instantiated1Card52c(Clone)") {

                        card.name = "instantiated1HandCard52c";

                    } else if (card.name == "instantiated1Card53(Clone)") {

                        card.name = "instantiated1HandCard53";

                    } else if (card.name == "instantiated1Card53a(Clone)") {

                        card.name = "instantiated1HandCard53a";

                    } else if (card.name == "instantiated1Card53b(Clone)") {

                        card.name = "instantiated1HandCard53b";

                    } else if (card.name == "instantiated1Card53c(Clone)") {

                        card.name = "instantiated1HandCard53c";

                    } else if (card.name == "instantiated1Card54(Clone)") {

                        card.name = "instantiated1HandCard54";

                    } else if (card.name == "instantiated1Card54a(Clone)") {

                        card.name = "instantiated1HandCard54a";

                    } else if (card.name == "instantiated1Card54b(Clone)") {

                        card.name = "instantiated1HandCard54b";

                    } else if (card.name == "instantiated1Card54c(Clone)") {

                        card.name = "instantiated1HandCard54c";

                    } else if (card.name == "instantiated1Card55(Clone)") {

                        card.name = "instantiated1HandCard55";

                    } else if (card.name == "instantiated1Card55a(Clone)") {

                        card.name = "instantiated1HandCard55a";

                    } else if (card.name == "instantiated1Card55b(Clone)") {

                        card.name = "instantiated1HandCard55b";

                    } else if (card.name == "instantiated1Card55c(Clone)") {

                        card.name = "instantiated1HandCard55c";

                    } else if (card.name == "instantiated1Card56(Clone)") {

                        card.name = "instantiated1HandCard56";

                    } else if (card.name == "instantiated1Card56a(Clone)") {

                        card.name = "instantiated1HandCard56a";

                    } else if (card.name == "instantiated1Card56b(Clone)") {

                        card.name = "instantiated1HandCard56b";

                    } else if (card.name == "instantiated1Card56c(Clone)") {

                        card.name = "instantiated1HandCard56c";

                    } else if (card.name == "instantiated1Card57(Clone)") {

                        card.name = "instantiated1HandCard57";

                    } else if (card.name == "instantiated1Card57a(Clone)") {

                        card.name = "instantiated1HandCard57a";

                    } else if (card.name == "instantiated1Card57b(Clone)") {

                        card.name = "instantiated1HandCard57b";

                    } else if (card.name == "instantiated1Card57c(Clone)") {

                        card.name = "instantiated1HandCard57c";

                    } else if (card.name == "instantiated1Card58(Clone)") {

                        card.name = "instantiated1HandCard58";

                    } else if (card.name == "instantiated1Card58a(Clone)") {

                        card.name = "instantiated1HandCard58a";

                    } else if (card.name == "instantiated1Card58b(Clone)") {

                        card.name = "instantiated1HandCard58b";

                    } else if (card.name == "instantiated1Card58c(Clone)") {

                        card.name = "instantiated1HandCard58c";

                    } else if (card.name == "instantiated1Card59(Clone)") {

                        card.name = "instantiated1HandCard59";

                    } else if (card.name == "instantiated1Card59a(Clone)") {

                        card.name = "instantiated1HandCard59a";

                    } else if (card.name == "instantiated1Card59b(Clone)") {

                        card.name = "instantiated1HandCard59b";

                    } else if (card.name == "instantiated1Card59c(Clone)") {

                        card.name = "instantiated1HandCard59c";

                    } else if (card.name == "instantiated1Card60(Clone)") {

                        card.name = "instantiated1HandCard60";

                    } else if (card.name == "instantiated1Card60a(Clone)") {

                        card.name = "instantiated1HandCard60a";

                    } else if (card.name == "instantiated1Card60b(Clone)") {

                        card.name = "instantiated1HandCard60b";

                    } else if (card.name == "instantiated1Card60c(Clone)") {

                        card.name = "instantiated1HandCard60c";
                    }

                    instances8M++;

                }

            }

            if (player1DeckSlot9.transform.childCount == 0) {

                while (instances9M < NumberOfCards) {

                    GameObject card = Instantiate(playCardsDeck1[UnityEngine.Random.Range(0, playCardsDeck1.Count)], player1DeckSlot9.transform.position, player1DeckSlot9.transform.rotation) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.transform.parent = player1DeckSlot9.transform;

                    if (card.name == "instantiated1Card1(Clone)") {

                        card.name = "instantiated1HandCard1";

                    } else if (card.name == "instantiated1Card1a(Clone)") {

                        card.name = "instantiated1HandCard1a";

                    } else if (card.name == "instantiated1Card1b(Clone)") {

                        card.name = "instantiated1HandCard1b";

                    } else if (card.name == "instantiated1Card1c(Clone)") {

                        card.name = "instantiated1HandCard1c";

                    } else if (card.name == "instantiated1Card2(Clone)") {

                        card.name = "instantiated1HandCard2";

                    } else if (card.name == "instantiated1Card2a(Clone)") {

                        card.name = "instantiated1HandCard2a";

                    } else if (card.name == "instantiated1Card2b(Clone)") {

                        card.name = "instantiated1HandCard2b";

                    } else if (card.name == "instantiated1Card2c(Clone)") {

                        card.name = "instantiated1HandCard2c";

                    } else if (card.name == "instantiated1Card3(Clone)") {

                        card.name = "instantiated1HandCard3";

                    } else if (card.name == "instantiated1Card3a(Clone)") {

                        card.name = "instantiated1HandCard3a";

                    } else if (card.name == "instantiated1Card3b(Clone)") {

                        card.name = "instantiated1HandCard3b";

                    } else if (card.name == "instantiated1Card3c(Clone)") {

                        card.name = "instantiated1HandCard3c";

                    } else if (card.name == "instantiated1Card4(Clone)") {

                        card.name = "instantiated1HandCard4";

                    } else if (card.name == "instantiated1Card4a(Clone)") {

                        card.name = "instantiated1HandCard4a";

                    } else if (card.name == "instantiated1Card4b(Clone)") {

                        card.name = "instantiated1HandCard4b";

                    } else if (card.name == "instantiated1Card4c(Clone)") {

                        card.name = "instantiated1HandCard4c";

                    } else if (card.name == "instantiated1Card5(Clone)") {

                        card.name = "instantiated1HandCard5";

                    } else if (card.name == "instantiated1Card5a(Clone)") {

                        card.name = "instantiated1HandCard5a";

                    } else if (card.name == "instantiated1Card5b(Clone)") {

                        card.name = "instantiated1HandCard5b";

                    } else if (card.name == "instantiated1Card5c(Clone)") {

                        card.name = "instantiated1HandCard5c";

                    } else if (card.name == "instantiated1Card6(Clone)") {

                        card.name = "instantiated1HandCard6";

                    } else if (card.name == "instantiated1Card6a(Clone)") {

                        card.name = "instantiated1HandCard6a";

                    } else if (card.name == "instantiated1Card6b(Clone)") {

                        card.name = "instantiated1HandCard6b";

                    } else if (card.name == "instantiated1Card6c(Clone)") {

                        card.name = "instantiated1HandCard6c";

                    } else if (card.name == "instantiated1Card7(Clone)") {

                        card.name = "instantiated1HandCard7";

                    } else if (card.name == "instantiated1Card7a(Clone)") {

                        card.name = "instantiated1HandCard7a";

                    } else if (card.name == "instantiated1Card7b(Clone)") {

                        card.name = "instantiated1HandCard7b";

                    } else if (card.name == "instantiated1Card7c(Clone)") {

                        card.name = "instantiated1HandCard7c";

                    } else if (card.name == "instantiated1Card8(Clone)") {

                        card.name = "instantiated1HandCard8";

                    } else if (card.name == "instantiated1Card8a(Clone)") {

                        card.name = "instantiated1HandCard8a";

                    } else if (card.name == "instantiated1Card8b(Clone)") {

                        card.name = "instantiated1HandCard8b";

                    } else if (card.name == "instantiated1Card8c(Clone)") {

                        card.name = "instantiated1HandCard8c";

                    } else if (card.name == "instantiated1Card9(Clone)") {

                        card.name = "instantiated1HandCard9";

                    } else if (card.name == "instantiated1Card9a(Clone)") {

                        card.name = "instantiated1HandCard9a";

                    } else if (card.name == "instantiated1Card9b(Clone)") {

                        card.name = "instantiated1HandCard9b";

                    } else if (card.name == "instantiated1Card9c(Clone)") {

                        card.name = "instantiated1HandCard9c";

                    } else if (card.name == "instantiated1Card10(Clone)") {

                        card.name = "instantiatedAICard10";

                    } else if (card.name == "instantiated1Card10a(Clone)") {

                        card.name = "instantiated1HandCard10a";

                    } else if (card.name == "instantiated1Card10b(Clone)") {

                        card.name = "instantiated1HandCard10b";

                    } else if (card.name == "instantiated1Card10c(Clone)") {

                        card.name = "instantiated1HandCard10c";

                    } else if (card.name == "instantiated1Card11(Clone)") {

                        card.name = "instantiated1HandCard11";

                    } else if (card.name == "instantiated1Card11a(Clone)") {

                        card.name = "instantiated1HandCard11a";

                    } else if (card.name == "instantiated1Card11b(Clone)") {

                        card.name = "instantiated1HandCard11b";

                    } else if (card.name == "instantiated1Card11c(Clone)") {

                        card.name = "instantiated1HandCard11c";

                    } else if (card.name == "instantiated1Card12(Clone)") {

                        card.name = "instantiated1HandCard12";

                    } else if (card.name == "instantiated1Card12a(Clone)") {

                        card.name = "instantiated1HandCard12a";

                    } else if (card.name == "instantiated1Card12b(Clone)") {

                        card.name = "instantiated1HandCard12b";

                    } else if (card.name == "instantiated1Card12c(Clone)") {

                        card.name = "instantiated1HandCard12c";

                    } else if (card.name == "instantiated1Card13(Clone)") {

                        card.name = "instantiated1HandCard13";

                    } else if (card.name == "instantiated1Card13a(Clone)") {

                        card.name = "instantiated1HandCard13a";

                    } else if (card.name == "instantiated1Card13b(Clone)") {

                        card.name = "instantiated1HandCard13b";

                    } else if (card.name == "instantiated1Card13c(Clone)") {

                        card.name = "instantiated1HandCard13c";

                    } else if (card.name == "instantiated1Card14(Clone)") {

                        card.name = "instantiated1HandCard14";

                    } else if (card.name == "instantiated1Card14a(Clone)") {

                        card.name = "instantiated1HandCard14a";

                    } else if (card.name == "instantiated1Card14b(Clone)") {

                        card.name = "instantiated1HandCard14b";

                    } else if (card.name == "instantiated1Card14c(Clone)") {

                        card.name = "instantiated1HandCard14c";

                    } else if (card.name == "instantiated1Card15(Clone)") {

                        card.name = "instantiated1HandCard15";

                    } else if (card.name == "instantiated1Card15a(Clone)") {

                        card.name = "instantiated1HandCard15a";

                    } else if (card.name == "instantiated1Card15b(Clone)") {

                        card.name = "instantiated1HandCard15b";

                    } else if (card.name == "instantiated1Card15c(Clone)") {

                        card.name = "instantiated1HandCard15c";

                    } else if (card.name == "instantiated1Card16(Clone)") {

                        card.name = "instantiated1HandCard16";

                    } else if (card.name == "instantiated1Card16a(Clone)") {

                        card.name = "instantiated1HandCard16a";

                    } else if (card.name == "instantiated1Card16b(Clone)") {

                        card.name = "instantiated1HandCard16b";

                    } else if (card.name == "instantiated1Card16c(Clone)") {

                        card.name = "instantiated1HandCard16c";

                    } else if (card.name == "instantiated1Card17(Clone)") {

                        card.name = "instantiated1HandCard17";

                    } else if (card.name == "instantiated1Card17a(Clone)") {

                        card.name = "instantiated1HandCard17a";

                    } else if (card.name == "instantiated1Card17b(Clone)") {

                        card.name = "instantiated1HandCard17b";

                    } else if (card.name == "instantiated1Card17c(Clone)") {

                        card.name = "instantiated1HandCard17c";

                    } else if (card.name == "instantiated1Card18(Clone)") {

                        card.name = "instantiated1HandCard18";

                    } else if (card.name == "instantiated1Card18a(Clone)") {

                        card.name = "instantiated1HandCard18a";

                    } else if (card.name == "instantiated1Card18b(Clone)") {

                        card.name = "instantiated1HandCard18b";

                    } else if (card.name == "instantiated1Card18c(Clone)") {

                        card.name = "instantiated1HandCard18c";

                    } else if (card.name == "instantiated1Card19(Clone)") {

                        card.name = "instantiated1HandCard19";

                    } else if (card.name == "instantiated1Card19a(Clone)") {

                        card.name = "instantiated1HandCard19a";

                    } else if (card.name == "instantiated1Card19b(Clone)") {

                        card.name = "instantiated1HandCard19b";

                    } else if (card.name == "instantiated1Card19c(Clone)") {

                        card.name = "instantiated1HandCard19c";

                    } else if (card.name == "instantiated1Card20(Clone)") {

                        card.name = "instantiated1HandCard20";

                    } else if (card.name == "instantiated1Card20a(Clone)") {

                        card.name = "instantiated1HandCard20a";

                    } else if (card.name == "instantiated1Card20b(Clone)") {

                        card.name = "instantiated1HandCard20b";

                    } else if (card.name == "instantiated1Card20c(Clone)") {

                        card.name = "instantiated1HandCard20c";

                    } else if (card.name == "instantiated1Card21(Clone)") {

                        card.name = "instantiated1HandCard21";

                    } else if (card.name == "instantiated1Card21a(Clone)") {

                        card.name = "instantiated1HandCard21a";

                    } else if (card.name == "instantiated1Card21b(Clone)") {

                        card.name = "instantiated1HandCard21b";

                    } else if (card.name == "instantiated1Card21c(Clone)") {

                        card.name = "instantiated1HandCard21c";

                    } else if (card.name == "instantiated1Card22(Clone)") {

                        card.name = "instantiated1HandCard22";

                    } else if (card.name == "instantiated1Card22a(Clone)") {

                        card.name = "instantiated1HandCard22a";

                    } else if (card.name == "instantiated1Card22b(Clone)") {

                        card.name = "instantiated1HandCard22b";

                    } else if (card.name == "instantiated1Card22c(Clone)") {

                        card.name = "instantiated1HandCard22c";

                    } else if (card.name == "instantiated1Card23(Clone)") {

                        card.name = "instantiated1HandCard23";

                    } else if (card.name == "instantiated1Card23a(Clone)") {

                        card.name = "instantiated1HandCard23a";

                    } else if (card.name == "instantiated1Card23b(Clone)") {

                        card.name = "instantiated1HandCard23b";

                    } else if (card.name == "instantiated1Card23c(Clone)") {

                        card.name = "instantiated1HandCard23c";

                    } else if (card.name == "instantiated1Card24(Clone)") {

                        card.name = "instantiated1HandCard24";

                    } else if (card.name == "instantiated1Card24a(Clone)") {

                        card.name = "instantiated1HandCard24a";

                    } else if (card.name == "instantiated1Card24b(Clone)") {

                        card.name = "instantiated1HandCard24b";

                    } else if (card.name == "instantiated1Card24c(Clone)") {

                        card.name = "instantiated1HandCard24c";

                    } else if (card.name == "instantiated1Card25(Clone)") {

                        card.name = "instantiated1HandCard25";

                    } else if (card.name == "instantiated1Card25a(Clone)") {

                        card.name = "instantiated1HandCard25a";

                    } else if (card.name == "instantiated1Card25b(Clone)") {

                        card.name = "instantiated1HandCard25b";

                    } else if (card.name == "instantiated1Card25c(Clone)") {

                        card.name = "instantiated1HandCard25c";

                    } else if (card.name == "instantiated1Card26(Clone)") {

                        card.name = "instantiated1HandCard26";

                    } else if (card.name == "instantiated1Card26a(Clone)") {

                        card.name = "instantiated1HandCard26a";

                    } else if (card.name == "instantiated1Card26b(Clone)") {

                        card.name = "instantiated1HandCard26b";

                    } else if (card.name == "instantiated1Card26c(Clone)") {

                        card.name = "instantiated1HandCard26c";

                    } else if (card.name == "instantiated1Card27(Clone)") {

                        card.name = "instantiated1HandCard27";

                    } else if (card.name == "instantiated1Card27a(Clone)") {

                        card.name = "instantiated1HandCard27a";

                    } else if (card.name == "instantiated1Card27b(Clone)") {

                        card.name = "instantiated1HandCard27b";

                    } else if (card.name == "instantiated1Card27c(Clone)") {

                        card.name = "instantiated1HandCard27c";

                    } else if (card.name == "instantiated1Card28(Clone)") {

                        card.name = "instantiated1HandCard28";

                    } else if (card.name == "instantiated1Card28a(Clone)") {

                        card.name = "instantiated1HandCard28a";

                    } else if (card.name == "instantiated1Card28b(Clone)") {

                        card.name = "instantiated1HandCard28b";

                    } else if (card.name == "instantiated1Card28c(Clone)") {

                        card.name = "instantiated1HandCard28c";

                    } else if (card.name == "instantiated1Card29(Clone)") {

                        card.name = "instantiated1HandCard29";

                    } else if (card.name == "instantiated1Card29a(Clone)") {

                        card.name = "instantiated1HandCard29a";

                    } else if (card.name == "instantiated1Card29b(Clone)") {

                        card.name = "instantiated1HandCard29b";

                    } else if (card.name == "instantiated1Card29c(Clone)") {

                        card.name = "instantiated1HandCard29c";

                    } else if (card.name == "instantiated1Card30(Clone)") {

                        card.name = "instantiated1HandCard30";

                    } else if (card.name == "instantiated1Card30a(Clone)") {

                        card.name = "instantiated1HandCard30a";

                    } else if (card.name == "instantiated1Card30b(Clone)") {

                        card.name = "instantiated1HandCard30b";

                    } else if (card.name == "instantiated1Card30c(Clone)") {

                        card.name = "instantiated1HandCard30c";

                    } else if (card.name == "instantiated1Card31(Clone)") {

                        card.name = "instantiated1HandCard31";

                    } else if (card.name == "instantiated1Card31a(Clone)") {

                        card.name = "instantiated1HandCard31a";

                    } else if (card.name == "instantiated1Card31b(Clone)") {

                        card.name = "instantiated1HandCard31b";

                    } else if (card.name == "instantiated1Card31c(Clone)") {

                        card.name = "instantiated1HandCard31c";

                    } else if (card.name == "instantiated1Card32(Clone)") {

                        card.name = "instantiated1HandCard32";

                    } else if (card.name == "instantiated1Card32a(Clone)") {

                        card.name = "instantiated1HandCard32a";

                    } else if (card.name == "instantiated1Card32b(Clone)") {

                        card.name = "instantiated1HandCard32b";

                    } else if (card.name == "instantiated1Card32c(Clone)") {

                        card.name = "instantiated1HandCard32c";

                    } else if (card.name == "instantiated1Card33(Clone)") {

                        card.name = "instantiated1HandCard33";

                    } else if (card.name == "instantiated1Card33a(Clone)") {

                        card.name = "instantiated1HandCard33a";

                    } else if (card.name == "instantiated1Card33b(Clone)") {

                        card.name = "instantiated1HandCard33b";

                    } else if (card.name == "instantiated1Card33c(Clone)") {

                        card.name = "instantiated1HandCard33c";

                    } else if (card.name == "instantiated1Card34(Clone)") {

                        card.name = "instantiated1HandCard34";

                    } else if (card.name == "instantiated1Card34a(Clone)") {

                        card.name = "instantiated1HandCard34a";

                    } else if (card.name == "instantiated1Card34b(Clone)") {

                        card.name = "instantiated1HandCard34b";

                    } else if (card.name == "instantiated1Card34c(Clone)") {

                        card.name = "instantiated1HandCard34c";

                    } else if (card.name == "instantiated1Card35(Clone)") {

                        card.name = "instantiated1HandCard35";

                    } else if (card.name == "instantiated1Card35a(Clone)") {

                        card.name = "instantiated1HandCard35a";

                    } else if (card.name == "instantiated1Card35b(Clone)") {

                        card.name = "instantiated1HandCard35b";

                    } else if (card.name == "instantiated1Card35c(Clone)") {

                        card.name = "instantiated1HandCard35c";

                    } else if (card.name == "instantiated1Card36(Clone)") {

                        card.name = "instantiated1HandCard36";

                    } else if (card.name == "instantiated1Card36a(Clone)") {

                        card.name = "instantiated1HandCard36a";

                    } else if (card.name == "instantiated1Card36b(Clone)") {

                        card.name = "instantiated1HandCard36b";

                    } else if (card.name == "instantiated1Card36c(Clone)") {

                        card.name = "instantiated1HandCard36c";

                    } else if (card.name == "instantiated1Card37(Clone)") {

                        card.name = "instantiated1HandCard37";

                    } else if (card.name == "instantiated1Card37a(Clone)") {

                        card.name = "instantiated1HandCard37a";

                    } else if (card.name == "instantiated1Card37b(Clone)") {

                        card.name = "instantiated1HandCard37b";

                    } else if (card.name == "instantiated1Card37c(Clone)") {

                        card.name = "instantiated1HandCard37c";

                    } else if (card.name == "instantiated1Card38(Clone)") {

                        card.name = "instantiated1HandCard38";

                    } else if (card.name == "instantiated1Card38a(Clone)") {

                        card.name = "instantiated1HandCard38a";

                    } else if (card.name == "instantiated1Card38b(Clone)") {

                        card.name = "instantiated1HandCard38b";

                    } else if (card.name == "instantiated1Card38c(Clone)") {

                        card.name = "instantiated1HandCard38c";

                    } else if (card.name == "instantiated1Card39(Clone)") {

                        card.name = "instantiated1HandCard39";

                    } else if (card.name == "instantiated1Card39a(Clone)") {

                        card.name = "instantiated1HandCard39a";

                    } else if (card.name == "instantiated1Card39b(Clone)") {

                        card.name = "instantiated1HandCard39b";

                    } else if (card.name == "instantiated1Card39c(Clone)") {

                        card.name = "instantiated1HandCard39c";

                    } else if (card.name == "instantiated1Card40(Clone)") {

                        card.name = "instantiated1HandCard40";

                    } else if (card.name == "instantiated1Card40a(Clone)") {

                        card.name = "instantiated1HandCard40a";

                    } else if (card.name == "instantiated1Card40b(Clone)") {

                        card.name = "instantiated1HandCard40b";

                    } else if (card.name == "instantiated1Card40c(Clone)") {

                        card.name = "instantiated1HandCard40c";

                    } else if (card.name == "instantiated1Card41(Clone)") {

                        card.name = "instantiated1HandCard41";

                    } else if (card.name == "instantiated1Card41a(Clone)") {

                        card.name = "instantiated1HandCard41a";

                    } else if (card.name == "instantiated1Card41b(Clone)") {

                        card.name = "instantiated1HandCard41b";

                    } else if (card.name == "instantiated1Card41c(Clone)") {

                        card.name = "instantiated1HandCard41c";

                    } else if (card.name == "instantiated1Card42(Clone)") {

                        card.name = "instantiated1HandCard42";

                    } else if (card.name == "instantiated1Card42a(Clone)") {

                        card.name = "instantiated1HandCard42a";

                    } else if (card.name == "instantiated1Card42b(Clone)") {

                        card.name = "instantiated1HandCard42b";

                    } else if (card.name == "instantiated1Card42c(Clone)") {

                        card.name = "instantiated1HandCard42c";

                    } else if (card.name == "instantiated1Card43(Clone)") {

                        card.name = "instantiated1HandCard43";

                    } else if (card.name == "instantiated1Card43a(Clone)") {

                        card.name = "instantiated1HandCard43a";

                    } else if (card.name == "instantiated1Card43b(Clone)") {

                        card.name = "instantiated1HandCard43b";

                    } else if (card.name == "instantiated1Card43c(Clone)") {

                        card.name = "instantiated1HandCard43c";

                    } else if (card.name == "instantiated1Card44(Clone)") {

                        card.name = "instantiated1HandCard44";

                    } else if (card.name == "instantiated1Card44a(Clone)") {

                        card.name = "instantiated1HandCard44a";

                    } else if (card.name == "instantiated1Card44b(Clone)") {

                        card.name = "instantiated1HandCard44b";

                    } else if (card.name == "instantiated1Card44c(Clone)") {

                        card.name = "instantiated1HandCard44c";

                    } else if (card.name == "instantiated1Card45(Clone)") {

                        card.name = "instantiated1HandCard45";

                    } else if (card.name == "instantiated1Card45a(Clone)") {

                        card.name = "instantiated1HandCard45a";

                    } else if (card.name == "instantiated1Card45b(Clone)") {

                        card.name = "instantiated1HandCard45b";

                    } else if (card.name == "instantiated1Card45c(Clone)") {

                        card.name = "instantiated1HandCard45c";

                    } else if (card.name == "instantiated1Card46(Clone)") {

                        card.name = "instantiated1HandCard46";

                    } else if (card.name == "instantiated1Card46a(Clone)") {

                        card.name = "instantiated1HandCard46a";

                    } else if (card.name == "instantiated1Card46b(Clone)") {

                        card.name = "instantiated1HandCard46b";

                    } else if (card.name == "instantiated1Card46c(Clone)") {

                        card.name = "instantiated1HandCard46c";

                    } else if (card.name == "instantiated1Card47(Clone)") {

                        card.name = "instantiated1HandCard47";

                    } else if (card.name == "instantiated1Card47a(Clone)") {

                        card.name = "instantiated1HandCard47a";

                    } else if (card.name == "instantiated1Card47b(Clone)") {

                        card.name = "instantiated1HandCard47b";

                    } else if (card.name == "instantiated1Card47c(Clone)") {

                        card.name = "instantiated1HandCard47c";

                    } else if (card.name == "instantiated1Card48(Clone)") {

                        card.name = "instantiated1HandCard48";

                    } else if (card.name == "instantiated1Card48a(Clone)") {

                        card.name = "instantiated1HandCard48a";

                    } else if (card.name == "instantiated1Card48b(Clone)") {

                        card.name = "instantiated1HandCard48b";

                    } else if (card.name == "instantiated1Card48c(Clone)") {

                        card.name = "instantiated1HandCard48c";

                    } else if (card.name == "instantiated1Card49(Clone)") {

                        card.name = "instantiated1HandCard49";

                    } else if (card.name == "instantiated1Card49a(Clone)") {

                        card.name = "instantiated1HandCard49a";

                    } else if (card.name == "instantiated1Card49b(Clone)") {

                        card.name = "instantiated1HandCard49b";

                    } else if (card.name == "instantiated1Card49c(Clone)") {

                        card.name = "instantiated1HandCard49c";

                    } else if (card.name == "instantiated1Card50(Clone)") {

                        card.name = "instantiated1HandCard50";

                    } else if (card.name == "instantiated1Card50a(Clone)") {

                        card.name = "instantiated1HandCard50a";

                    } else if (card.name == "instantiated1Card50b(Clone)") {

                        card.name = "instantiated1HandCard50b";

                    } else if (card.name == "instantiated1Card50c(Clone)") {

                        card.name = "instantiated1HandCard50c";

                    } else if (card.name == "instantiated1Card51(Clone)") {

                        card.name = "instantiated1HandCard51";

                    } else if (card.name == "instantiated1Card51a(Clone)") {

                        card.name = "instantiated1HandCard51a";

                    } else if (card.name == "instantiated1Card51b(Clone)") {

                        card.name = "instantiated1HandCard51b";

                    } else if (card.name == "instantiated1Card51c(Clone)") {

                        card.name = "instantiated1HandCard51c";

                    } else if (card.name == "instantiated1Card52(Clone)") {

                        card.name = "instantiated1HandCard52";

                    } else if (card.name == "instantiated1Card52a(Clone)") {

                        card.name = "instantiated1HandCard52a";

                    } else if (card.name == "instantiated1Card52b(Clone)") {

                        card.name = "instantiated1HandCard52b";

                    } else if (card.name == "instantiated1Card52c(Clone)") {

                        card.name = "instantiated1HandCard52c";

                    } else if (card.name == "instantiated1Card53(Clone)") {

                        card.name = "instantiated1HandCard53";

                    } else if (card.name == "instantiated1Card53a(Clone)") {

                        card.name = "instantiated1HandCard53a";

                    } else if (card.name == "instantiated1Card53b(Clone)") {

                        card.name = "instantiated1HandCard53b";

                    } else if (card.name == "instantiated1Card53c(Clone)") {

                        card.name = "instantiated1HandCard53c";

                    } else if (card.name == "instantiated1Card54(Clone)") {

                        card.name = "instantiated1HandCard54";

                    } else if (card.name == "instantiated1Card54a(Clone)") {

                        card.name = "instantiated1HandCard54a";

                    } else if (card.name == "instantiated1Card54b(Clone)") {

                        card.name = "instantiated1HandCard54b";

                    } else if (card.name == "instantiated1Card54c(Clone)") {

                        card.name = "instantiated1HandCard54c";

                    } else if (card.name == "instantiated1Card55(Clone)") {

                        card.name = "instantiated1HandCard55";

                    } else if (card.name == "instantiated1Card55a(Clone)") {

                        card.name = "instantiated1HandCard55a";

                    } else if (card.name == "instantiated1Card55b(Clone)") {

                        card.name = "instantiated1HandCard55b";

                    } else if (card.name == "instantiated1Card55c(Clone)") {

                        card.name = "instantiated1HandCard55c";

                    } else if (card.name == "instantiated1Card56(Clone)") {

                        card.name = "instantiated1HandCard56";

                    } else if (card.name == "instantiated1Card56a(Clone)") {

                        card.name = "instantiated1HandCard56a";

                    } else if (card.name == "instantiated1Card56b(Clone)") {

                        card.name = "instantiated1HandCard56b";

                    } else if (card.name == "instantiated1Card56c(Clone)") {

                        card.name = "instantiated1HandCard56c";

                    } else if (card.name == "instantiated1Card57(Clone)") {

                        card.name = "instantiated1HandCard57";

                    } else if (card.name == "instantiated1Card57a(Clone)") {

                        card.name = "instantiated1HandCard57a";

                    } else if (card.name == "instantiated1Card57b(Clone)") {

                        card.name = "instantiated1HandCard57b";

                    } else if (card.name == "instantiated1Card57c(Clone)") {

                        card.name = "instantiated1HandCard57c";

                    } else if (card.name == "instantiated1Card58(Clone)") {

                        card.name = "instantiated1HandCard58";

                    } else if (card.name == "instantiated1Card58a(Clone)") {

                        card.name = "instantiated1HandCard58a";

                    } else if (card.name == "instantiated1Card58b(Clone)") {

                        card.name = "instantiated1HandCard58b";

                    } else if (card.name == "instantiated1Card58c(Clone)") {

                        card.name = "instantiated1HandCard58c";

                    } else if (card.name == "instantiated1Card59(Clone)") {

                        card.name = "instantiated1HandCard59";

                    } else if (card.name == "instantiated1Card59a(Clone)") {

                        card.name = "instantiated1HandCard59a";

                    } else if (card.name == "instantiated1Card59b(Clone)") {

                        card.name = "instantiated1HandCard59b";

                    } else if (card.name == "instantiated1Card59c(Clone)") {

                        card.name = "instantiated1HandCard59c";

                    } else if (card.name == "instantiated1Card60(Clone)") {

                        card.name = "instantiated1HandCard60";

                    } else if (card.name == "instantiated1Card60a(Clone)") {

                        card.name = "instantiated1HandCard60a";

                    } else if (card.name == "instantiated1Card60b(Clone)") {

                        card.name = "instantiated1HandCard60b";

                    } else if (card.name == "instantiated1Card60c(Clone)") {

                        card.name = "instantiated1HandCard60c";
                    }

                    instances9M++;

                }

            }

            if (player1DeckSlot10.transform.childCount == 0) {

                while (instances10M < NumberOfCards) {

                    GameObject card = Instantiate(playCardsDeck1[UnityEngine.Random.Range(0, playCardsDeck1.Count)], player1DeckSlot10.transform.position, player1DeckSlot10.transform.rotation) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.transform.parent = player1DeckSlot10.transform;

                    if (card.name == "instantiated1Card1(Clone)") {

                        card.name = "instantiated1HandCard1";

                    } else if (card.name == "instantiated1Card1a(Clone)") {

                        card.name = "instantiated1HandCard1a";

                    } else if (card.name == "instantiated1Card1b(Clone)") {

                        card.name = "instantiated1HandCard1b";

                    } else if (card.name == "instantiated1Card1c(Clone)") {

                        card.name = "instantiated1HandCard1c";

                    } else if (card.name == "instantiated1Card2(Clone)") {

                        card.name = "instantiated1HandCard2";

                    } else if (card.name == "instantiated1Card2a(Clone)") {

                        card.name = "instantiated1HandCard2a";

                    } else if (card.name == "instantiated1Card2b(Clone)") {

                        card.name = "instantiated1HandCard2b";

                    } else if (card.name == "instantiated1Card2c(Clone)") {

                        card.name = "instantiated1HandCard2c";

                    } else if (card.name == "instantiated1Card3(Clone)") {

                        card.name = "instantiated1HandCard3";

                    } else if (card.name == "instantiated1Card3a(Clone)") {

                        card.name = "instantiated1HandCard3a";

                    } else if (card.name == "instantiated1Card3b(Clone)") {

                        card.name = "instantiated1HandCard3b";

                    } else if (card.name == "instantiated1Card3c(Clone)") {

                        card.name = "instantiated1HandCard3c";

                    } else if (card.name == "instantiated1Card4(Clone)") {

                        card.name = "instantiated1HandCard4";

                    } else if (card.name == "instantiated1Card4a(Clone)") {

                        card.name = "instantiated1HandCard4a";

                    } else if (card.name == "instantiated1Card4b(Clone)") {

                        card.name = "instantiated1HandCard4b";

                    } else if (card.name == "instantiated1Card4c(Clone)") {

                        card.name = "instantiated1HandCard4c";

                    } else if (card.name == "instantiated1Card5(Clone)") {

                        card.name = "instantiated1HandCard5";

                    } else if (card.name == "instantiated1Card5a(Clone)") {

                        card.name = "instantiated1HandCard5a";

                    } else if (card.name == "instantiated1Card5b(Clone)") {

                        card.name = "instantiated1HandCard5b";

                    } else if (card.name == "instantiated1Card5c(Clone)") {

                        card.name = "instantiated1HandCard5c";

                    } else if (card.name == "instantiated1Card6(Clone)") {

                        card.name = "instantiated1HandCard6";

                    } else if (card.name == "instantiated1Card6a(Clone)") {

                        card.name = "instantiated1HandCard6a";

                    } else if (card.name == "instantiated1Card6b(Clone)") {

                        card.name = "instantiated1HandCard6b";

                    } else if (card.name == "instantiated1Card6c(Clone)") {

                        card.name = "instantiated1HandCard6c";

                    } else if (card.name == "instantiated1Card7(Clone)") {

                        card.name = "instantiated1HandCard7";

                    } else if (card.name == "instantiated1Card7a(Clone)") {

                        card.name = "instantiated1HandCard7a";

                    } else if (card.name == "instantiated1Card7b(Clone)") {

                        card.name = "instantiated1HandCard7b";

                    } else if (card.name == "instantiated1Card7c(Clone)") {

                        card.name = "instantiated1HandCard7c";

                    } else if (card.name == "instantiated1Card8(Clone)") {

                        card.name = "instantiated1HandCard8";

                    } else if (card.name == "instantiated1Card8a(Clone)") {

                        card.name = "instantiated1HandCard8a";

                    } else if (card.name == "instantiated1Card8b(Clone)") {

                        card.name = "instantiated1HandCard8b";

                    } else if (card.name == "instantiated1Card8c(Clone)") {

                        card.name = "instantiated1HandCard8c";

                    } else if (card.name == "instantiated1Card9(Clone)") {

                        card.name = "instantiated1HandCard9";

                    } else if (card.name == "instantiated1Card9a(Clone)") {

                        card.name = "instantiated1HandCard9a";

                    } else if (card.name == "instantiated1Card9b(Clone)") {

                        card.name = "instantiated1HandCard9b";

                    } else if (card.name == "instantiated1Card9c(Clone)") {

                        card.name = "instantiated1HandCard9c";

                    } else if (card.name == "instantiated1Card10(Clone)") {

                        card.name = "instantiatedAICard10";

                    } else if (card.name == "instantiated1Card10a(Clone)") {

                        card.name = "instantiated1HandCard10a";

                    } else if (card.name == "instantiated1Card10b(Clone)") {

                        card.name = "instantiated1HandCard10b";

                    } else if (card.name == "instantiated1Card10c(Clone)") {

                        card.name = "instantiated1HandCard10c";

                    } else if (card.name == "instantiated1Card11(Clone)") {

                        card.name = "instantiated1HandCard11";

                    } else if (card.name == "instantiated1Card11a(Clone)") {

                        card.name = "instantiated1HandCard11a";

                    } else if (card.name == "instantiated1Card11b(Clone)") {

                        card.name = "instantiated1HandCard11b";

                    } else if (card.name == "instantiated1Card11c(Clone)") {

                        card.name = "instantiated1HandCard11c";

                    } else if (card.name == "instantiated1Card12(Clone)") {

                        card.name = "instantiated1HandCard12";

                    } else if (card.name == "instantiated1Card12a(Clone)") {

                        card.name = "instantiated1HandCard12a";

                    } else if (card.name == "instantiated1Card12b(Clone)") {

                        card.name = "instantiated1HandCard12b";

                    } else if (card.name == "instantiated1Card12c(Clone)") {

                        card.name = "instantiated1HandCard12c";

                    } else if (card.name == "instantiated1Card13(Clone)") {

                        card.name = "instantiated1HandCard13";

                    } else if (card.name == "instantiated1Card13a(Clone)") {

                        card.name = "instantiated1HandCard13a";

                    } else if (card.name == "instantiated1Card13b(Clone)") {

                        card.name = "instantiated1HandCard13b";

                    } else if (card.name == "instantiated1Card13c(Clone)") {

                        card.name = "instantiated1HandCard13c";

                    } else if (card.name == "instantiated1Card14(Clone)") {

                        card.name = "instantiated1HandCard14";

                    } else if (card.name == "instantiated1Card14a(Clone)") {

                        card.name = "instantiated1HandCard14a";

                    } else if (card.name == "instantiated1Card14b(Clone)") {

                        card.name = "instantiated1HandCard14b";

                    } else if (card.name == "instantiated1Card14c(Clone)") {

                        card.name = "instantiated1HandCard14c";

                    } else if (card.name == "instantiated1Card15(Clone)") {

                        card.name = "instantiated1HandCard15";

                    } else if (card.name == "instantiated1Card15a(Clone)") {

                        card.name = "instantiated1HandCard15a";

                    } else if (card.name == "instantiated1Card15b(Clone)") {

                        card.name = "instantiated1HandCard15b";

                    } else if (card.name == "instantiated1Card15c(Clone)") {

                        card.name = "instantiated1HandCard15c";

                    } else if (card.name == "instantiated1Card16(Clone)") {

                        card.name = "instantiated1HandCard16";

                    } else if (card.name == "instantiated1Card16a(Clone)") {

                        card.name = "instantiated1HandCard16a";

                    } else if (card.name == "instantiated1Card16b(Clone)") {

                        card.name = "instantiated1HandCard16b";

                    } else if (card.name == "instantiated1Card16c(Clone)") {

                        card.name = "instantiated1HandCard16c";

                    } else if (card.name == "instantiated1Card17(Clone)") {

                        card.name = "instantiated1HandCard17";

                    } else if (card.name == "instantiated1Card17a(Clone)") {

                        card.name = "instantiated1HandCard17a";

                    } else if (card.name == "instantiated1Card17b(Clone)") {

                        card.name = "instantiated1HandCard17b";

                    } else if (card.name == "instantiated1Card17c(Clone)") {

                        card.name = "instantiated1HandCard17c";

                    } else if (card.name == "instantiated1Card18(Clone)") {

                        card.name = "instantiated1HandCard18";

                    } else if (card.name == "instantiated1Card18a(Clone)") {

                        card.name = "instantiated1HandCard18a";

                    } else if (card.name == "instantiated1Card18b(Clone)") {

                        card.name = "instantiated1HandCard18b";

                    } else if (card.name == "instantiated1Card18c(Clone)") {

                        card.name = "instantiated1HandCard18c";

                    } else if (card.name == "instantiated1Card19(Clone)") {

                        card.name = "instantiated1HandCard19";

                    } else if (card.name == "instantiated1Card19a(Clone)") {

                        card.name = "instantiated1HandCard19a";

                    } else if (card.name == "instantiated1Card19b(Clone)") {

                        card.name = "instantiated1HandCard19b";

                    } else if (card.name == "instantiated1Card19c(Clone)") {

                        card.name = "instantiated1HandCard19c";

                    } else if (card.name == "instantiated1Card20(Clone)") {

                        card.name = "instantiated1HandCard20";

                    } else if (card.name == "instantiated1Card20a(Clone)") {

                        card.name = "instantiated1HandCard20a";

                    } else if (card.name == "instantiated1Card20b(Clone)") {

                        card.name = "instantiated1HandCard20b";

                    } else if (card.name == "instantiated1Card20c(Clone)") {

                        card.name = "instantiated1HandCard20c";

                    } else if (card.name == "instantiated1Card21(Clone)") {

                        card.name = "instantiated1HandCard21";

                    } else if (card.name == "instantiated1Card21a(Clone)") {

                        card.name = "instantiated1HandCard21a";

                    } else if (card.name == "instantiated1Card21b(Clone)") {

                        card.name = "instantiated1HandCard21b";

                    } else if (card.name == "instantiated1Card21c(Clone)") {

                        card.name = "instantiated1HandCard21c";

                    } else if (card.name == "instantiated1Card22(Clone)") {

                        card.name = "instantiated1HandCard22";

                    } else if (card.name == "instantiated1Card22a(Clone)") {

                        card.name = "instantiated1HandCard22a";

                    } else if (card.name == "instantiated1Card22b(Clone)") {

                        card.name = "instantiated1HandCard22b";

                    } else if (card.name == "instantiated1Card22c(Clone)") {

                        card.name = "instantiated1HandCard22c";

                    } else if (card.name == "instantiated1Card23(Clone)") {

                        card.name = "instantiated1HandCard23";

                    } else if (card.name == "instantiated1Card23a(Clone)") {

                        card.name = "instantiated1HandCard23a";

                    } else if (card.name == "instantiated1Card23b(Clone)") {

                        card.name = "instantiated1HandCard23b";

                    } else if (card.name == "instantiated1Card23c(Clone)") {

                        card.name = "instantiated1HandCard23c";

                    } else if (card.name == "instantiated1Card24(Clone)") {

                        card.name = "instantiated1HandCard24";

                    } else if (card.name == "instantiated1Card24a(Clone)") {

                        card.name = "instantiated1HandCard24a";

                    } else if (card.name == "instantiated1Card24b(Clone)") {

                        card.name = "instantiated1HandCard24b";

                    } else if (card.name == "instantiated1Card24c(Clone)") {

                        card.name = "instantiated1HandCard24c";

                    } else if (card.name == "instantiated1Card25(Clone)") {

                        card.name = "instantiated1HandCard25";

                    } else if (card.name == "instantiated1Card25a(Clone)") {

                        card.name = "instantiated1HandCard25a";

                    } else if (card.name == "instantiated1Card25b(Clone)") {

                        card.name = "instantiated1HandCard25b";

                    } else if (card.name == "instantiated1Card25c(Clone)") {

                        card.name = "instantiated1HandCard25c";

                    } else if (card.name == "instantiated1Card26(Clone)") {

                        card.name = "instantiated1HandCard26";

                    } else if (card.name == "instantiated1Card26a(Clone)") {

                        card.name = "instantiated1HandCard26a";

                    } else if (card.name == "instantiated1Card26b(Clone)") {

                        card.name = "instantiated1HandCard26b";

                    } else if (card.name == "instantiated1Card26c(Clone)") {

                        card.name = "instantiated1HandCard26c";

                    } else if (card.name == "instantiated1Card27(Clone)") {

                        card.name = "instantiated1HandCard27";

                    } else if (card.name == "instantiated1Card27a(Clone)") {

                        card.name = "instantiated1HandCard27a";

                    } else if (card.name == "instantiated1Card27b(Clone)") {

                        card.name = "instantiated1HandCard27b";

                    } else if (card.name == "instantiated1Card27c(Clone)") {

                        card.name = "instantiated1HandCard27c";

                    } else if (card.name == "instantiated1Card28(Clone)") {

                        card.name = "instantiated1HandCard28";

                    } else if (card.name == "instantiated1Card28a(Clone)") {

                        card.name = "instantiated1HandCard28a";

                    } else if (card.name == "instantiated1Card28b(Clone)") {

                        card.name = "instantiated1HandCard28b";

                    } else if (card.name == "instantiated1Card28c(Clone)") {

                        card.name = "instantiated1HandCard28c";

                    } else if (card.name == "instantiated1Card29(Clone)") {

                        card.name = "instantiated1HandCard29";

                    } else if (card.name == "instantiated1Card29a(Clone)") {

                        card.name = "instantiated1HandCard29a";

                    } else if (card.name == "instantiated1Card29b(Clone)") {

                        card.name = "instantiated1HandCard29b";

                    } else if (card.name == "instantiated1Card29c(Clone)") {

                        card.name = "instantiated1HandCard29c";

                    } else if (card.name == "instantiated1Card30(Clone)") {

                        card.name = "instantiated1HandCard30";

                    } else if (card.name == "instantiated1Card30a(Clone)") {

                        card.name = "instantiated1HandCard30a";

                    } else if (card.name == "instantiated1Card30b(Clone)") {

                        card.name = "instantiated1HandCard30b";

                    } else if (card.name == "instantiated1Card30c(Clone)") {

                        card.name = "instantiated1HandCard30c";

                    } else if (card.name == "instantiated1Card31(Clone)") {

                        card.name = "instantiated1HandCard31";

                    } else if (card.name == "instantiated1Card31a(Clone)") {

                        card.name = "instantiated1HandCard31a";

                    } else if (card.name == "instantiated1Card31b(Clone)") {

                        card.name = "instantiated1HandCard31b";

                    } else if (card.name == "instantiated1Card31c(Clone)") {

                        card.name = "instantiated1HandCard31c";

                    } else if (card.name == "instantiated1Card32(Clone)") {

                        card.name = "instantiated1HandCard32";

                    } else if (card.name == "instantiated1Card32a(Clone)") {

                        card.name = "instantiated1HandCard32a";

                    } else if (card.name == "instantiated1Card32b(Clone)") {

                        card.name = "instantiated1HandCard32b";

                    } else if (card.name == "instantiated1Card32c(Clone)") {

                        card.name = "instantiated1HandCard32c";

                    } else if (card.name == "instantiated1Card33(Clone)") {

                        card.name = "instantiated1HandCard33";

                    } else if (card.name == "instantiated1Card33a(Clone)") {

                        card.name = "instantiated1HandCard33a";

                    } else if (card.name == "instantiated1Card33b(Clone)") {

                        card.name = "instantiated1HandCard33b";

                    } else if (card.name == "instantiated1Card33c(Clone)") {

                        card.name = "instantiated1HandCard33c";

                    } else if (card.name == "instantiated1Card34(Clone)") {

                        card.name = "instantiated1HandCard34";

                    } else if (card.name == "instantiated1Card34a(Clone)") {

                        card.name = "instantiated1HandCard34a";

                    } else if (card.name == "instantiated1Card34b(Clone)") {

                        card.name = "instantiated1HandCard34b";

                    } else if (card.name == "instantiated1Card34c(Clone)") {

                        card.name = "instantiated1HandCard34c";

                    } else if (card.name == "instantiated1Card35(Clone)") {

                        card.name = "instantiated1HandCard35";

                    } else if (card.name == "instantiated1Card35a(Clone)") {

                        card.name = "instantiated1HandCard35a";

                    } else if (card.name == "instantiated1Card35b(Clone)") {

                        card.name = "instantiated1HandCard35b";

                    } else if (card.name == "instantiated1Card35c(Clone)") {

                        card.name = "instantiated1HandCard35c";

                    } else if (card.name == "instantiated1Card36(Clone)") {

                        card.name = "instantiated1HandCard36";

                    } else if (card.name == "instantiated1Card36a(Clone)") {

                        card.name = "instantiated1HandCard36a";

                    } else if (card.name == "instantiated1Card36b(Clone)") {

                        card.name = "instantiated1HandCard36b";

                    } else if (card.name == "instantiated1Card36c(Clone)") {

                        card.name = "instantiated1HandCard36c";

                    } else if (card.name == "instantiated1Card37(Clone)") {

                        card.name = "instantiated1HandCard37";

                    } else if (card.name == "instantiated1Card37a(Clone)") {

                        card.name = "instantiated1HandCard37a";

                    } else if (card.name == "instantiated1Card37b(Clone)") {

                        card.name = "instantiated1HandCard37b";

                    } else if (card.name == "instantiated1Card37c(Clone)") {

                        card.name = "instantiated1HandCard37c";

                    } else if (card.name == "instantiated1Card38(Clone)") {

                        card.name = "instantiated1HandCard38";

                    } else if (card.name == "instantiated1Card38a(Clone)") {

                        card.name = "instantiated1HandCard38a";

                    } else if (card.name == "instantiated1Card38b(Clone)") {

                        card.name = "instantiated1HandCard38b";

                    } else if (card.name == "instantiated1Card38c(Clone)") {

                        card.name = "instantiated1HandCard38c";

                    } else if (card.name == "instantiated1Card39(Clone)") {

                        card.name = "instantiated1HandCard39";

                    } else if (card.name == "instantiated1Card39a(Clone)") {

                        card.name = "instantiated1HandCard39a";

                    } else if (card.name == "instantiated1Card39b(Clone)") {

                        card.name = "instantiated1HandCard39b";

                    } else if (card.name == "instantiated1Card39c(Clone)") {

                        card.name = "instantiated1HandCard39c";

                    } else if (card.name == "instantiated1Card40(Clone)") {

                        card.name = "instantiated1HandCard40";

                    } else if (card.name == "instantiated1Card40a(Clone)") {

                        card.name = "instantiated1HandCard40a";

                    } else if (card.name == "instantiated1Card40b(Clone)") {

                        card.name = "instantiated1HandCard40b";

                    } else if (card.name == "instantiated1Card40c(Clone)") {

                        card.name = "instantiated1HandCard40c";

                    } else if (card.name == "instantiated1Card41(Clone)") {

                        card.name = "instantiated1HandCard41";

                    } else if (card.name == "instantiated1Card41a(Clone)") {

                        card.name = "instantiated1HandCard41a";

                    } else if (card.name == "instantiated1Card41b(Clone)") {

                        card.name = "instantiated1HandCard41b";

                    } else if (card.name == "instantiated1Card41c(Clone)") {

                        card.name = "instantiated1HandCard41c";

                    } else if (card.name == "instantiated1Card42(Clone)") {

                        card.name = "instantiated1HandCard42";

                    } else if (card.name == "instantiated1Card42a(Clone)") {

                        card.name = "instantiated1HandCard42a";

                    } else if (card.name == "instantiated1Card42b(Clone)") {

                        card.name = "instantiated1HandCard42b";

                    } else if (card.name == "instantiated1Card42c(Clone)") {

                        card.name = "instantiated1HandCard42c";

                    } else if (card.name == "instantiated1Card43(Clone)") {

                        card.name = "instantiated1HandCard43";

                    } else if (card.name == "instantiated1Card43a(Clone)") {

                        card.name = "instantiated1HandCard43a";

                    } else if (card.name == "instantiated1Card43b(Clone)") {

                        card.name = "instantiated1HandCard43b";

                    } else if (card.name == "instantiated1Card43c(Clone)") {

                        card.name = "instantiated1HandCard43c";

                    } else if (card.name == "instantiated1Card44(Clone)") {

                        card.name = "instantiated1HandCard44";

                    } else if (card.name == "instantiated1Card44a(Clone)") {

                        card.name = "instantiated1HandCard44a";

                    } else if (card.name == "instantiated1Card44b(Clone)") {

                        card.name = "instantiated1HandCard44b";

                    } else if (card.name == "instantiated1Card44c(Clone)") {

                        card.name = "instantiated1HandCard44c";

                    } else if (card.name == "instantiated1Card45(Clone)") {

                        card.name = "instantiated1HandCard45";

                    } else if (card.name == "instantiated1Card45a(Clone)") {

                        card.name = "instantiated1HandCard45a";

                    } else if (card.name == "instantiated1Card45b(Clone)") {

                        card.name = "instantiated1HandCard45b";

                    } else if (card.name == "instantiated1Card45c(Clone)") {

                        card.name = "instantiated1HandCard45c";

                    } else if (card.name == "instantiated1Card46(Clone)") {

                        card.name = "instantiated1HandCard46";

                    } else if (card.name == "instantiated1Card46a(Clone)") {

                        card.name = "instantiated1HandCard46a";

                    } else if (card.name == "instantiated1Card46b(Clone)") {

                        card.name = "instantiated1HandCard46b";

                    } else if (card.name == "instantiated1Card46c(Clone)") {

                        card.name = "instantiated1HandCard46c";

                    } else if (card.name == "instantiated1Card47(Clone)") {

                        card.name = "instantiated1HandCard47";

                    } else if (card.name == "instantiated1Card47a(Clone)") {

                        card.name = "instantiated1HandCard47a";

                    } else if (card.name == "instantiated1Card47b(Clone)") {

                        card.name = "instantiated1HandCard47b";

                    } else if (card.name == "instantiated1Card47c(Clone)") {

                        card.name = "instantiated1HandCard47c";

                    } else if (card.name == "instantiated1Card48(Clone)") {

                        card.name = "instantiated1HandCard48";

                    } else if (card.name == "instantiated1Card48a(Clone)") {

                        card.name = "instantiated1HandCard48a";

                    } else if (card.name == "instantiated1Card48b(Clone)") {

                        card.name = "instantiated1HandCard48b";

                    } else if (card.name == "instantiated1Card48c(Clone)") {

                        card.name = "instantiated1HandCard48c";

                    } else if (card.name == "instantiated1Card49(Clone)") {

                        card.name = "instantiated1HandCard49";

                    } else if (card.name == "instantiated1Card49a(Clone)") {

                        card.name = "instantiated1HandCard49a";

                    } else if (card.name == "instantiated1Card49b(Clone)") {

                        card.name = "instantiated1HandCard49b";

                    } else if (card.name == "instantiated1Card49c(Clone)") {

                        card.name = "instantiated1HandCard49c";

                    } else if (card.name == "instantiated1Card50(Clone)") {

                        card.name = "instantiated1HandCard50";

                    } else if (card.name == "instantiated1Card50a(Clone)") {

                        card.name = "instantiated1HandCard50a";

                    } else if (card.name == "instantiated1Card50b(Clone)") {

                        card.name = "instantiated1HandCard50b";

                    } else if (card.name == "instantiated1Card50c(Clone)") {

                        card.name = "instantiated1HandCard50c";

                    } else if (card.name == "instantiated1Card51(Clone)") {

                        card.name = "instantiated1HandCard51";

                    } else if (card.name == "instantiated1Card51a(Clone)") {

                        card.name = "instantiated1HandCard51a";

                    } else if (card.name == "instantiated1Card51b(Clone)") {

                        card.name = "instantiated1HandCard51b";

                    } else if (card.name == "instantiated1Card51c(Clone)") {

                        card.name = "instantiated1HandCard51c";

                    } else if (card.name == "instantiated1Card52(Clone)") {

                        card.name = "instantiated1HandCard52";

                    } else if (card.name == "instantiated1Card52a(Clone)") {

                        card.name = "instantiated1HandCard52a";

                    } else if (card.name == "instantiated1Card52b(Clone)") {

                        card.name = "instantiated1HandCard52b";

                    } else if (card.name == "instantiated1Card52c(Clone)") {

                        card.name = "instantiated1HandCard52c";

                    } else if (card.name == "instantiated1Card53(Clone)") {

                        card.name = "instantiated1HandCard53";

                    } else if (card.name == "instantiated1Card53a(Clone)") {

                        card.name = "instantiated1HandCard53a";

                    } else if (card.name == "instantiated1Card53b(Clone)") {

                        card.name = "instantiated1HandCard53b";

                    } else if (card.name == "instantiated1Card53c(Clone)") {

                        card.name = "instantiated1HandCard53c";

                    } else if (card.name == "instantiated1Card54(Clone)") {

                        card.name = "instantiated1HandCard54";

                    } else if (card.name == "instantiated1Card54a(Clone)") {

                        card.name = "instantiated1HandCard54a";

                    } else if (card.name == "instantiated1Card54b(Clone)") {

                        card.name = "instantiated1HandCard54b";

                    } else if (card.name == "instantiated1Card54c(Clone)") {

                        card.name = "instantiated1HandCard54c";

                    } else if (card.name == "instantiated1Card55(Clone)") {

                        card.name = "instantiated1HandCard55";

                    } else if (card.name == "instantiated1Card55a(Clone)") {

                        card.name = "instantiated1HandCard55a";

                    } else if (card.name == "instantiated1Card55b(Clone)") {

                        card.name = "instantiated1HandCard55b";

                    } else if (card.name == "instantiated1Card55c(Clone)") {

                        card.name = "instantiated1HandCard55c";

                    } else if (card.name == "instantiated1Card56(Clone)") {

                        card.name = "instantiated1HandCard56";

                    } else if (card.name == "instantiated1Card56a(Clone)") {

                        card.name = "instantiated1HandCard56a";

                    } else if (card.name == "instantiated1Card56b(Clone)") {

                        card.name = "instantiated1HandCard56b";

                    } else if (card.name == "instantiated1Card56c(Clone)") {

                        card.name = "instantiated1HandCard56c";

                    } else if (card.name == "instantiated1Card57(Clone)") {

                        card.name = "instantiated1HandCard57";

                    } else if (card.name == "instantiated1Card57a(Clone)") {

                        card.name = "instantiated1HandCard57a";

                    } else if (card.name == "instantiated1Card57b(Clone)") {

                        card.name = "instantiated1HandCard57b";

                    } else if (card.name == "instantiated1Card57c(Clone)") {

                        card.name = "instantiated1HandCard57c";

                    } else if (card.name == "instantiated1Card58(Clone)") {

                        card.name = "instantiated1HandCard58";

                    } else if (card.name == "instantiated1Card58a(Clone)") {

                        card.name = "instantiated1HandCard58a";

                    } else if (card.name == "instantiated1Card58b(Clone)") {

                        card.name = "instantiated1HandCard58b";

                    } else if (card.name == "instantiated1Card58c(Clone)") {

                        card.name = "instantiated1HandCard58c";

                    } else if (card.name == "instantiated1Card59(Clone)") {

                        card.name = "instantiated1HandCard59";

                    } else if (card.name == "instantiated1Card59a(Clone)") {

                        card.name = "instantiated1HandCard59a";

                    } else if (card.name == "instantiated1Card59b(Clone)") {

                        card.name = "instantiated1HandCard59b";

                    } else if (card.name == "instantiated1Card59c(Clone)") {

                        card.name = "instantiated1HandCard59c";

                    } else if (card.name == "instantiated1Card60(Clone)") {

                        card.name = "instantiated1HandCard60";

                    } else if (card.name == "instantiated1Card60a(Clone)") {

                        card.name = "instantiated1HandCard60a";

                    } else if (card.name == "instantiated1Card60b(Clone)") {

                        card.name = "instantiated1HandCard60b";

                    } else if (card.name == "instantiated1Card60c(Clone)") {

                        card.name = "instantiated1HandCard60c";
                    }

                    instances10M++;

                }

            }

            doneButton1.SetActive(false);
            handCardCollection.SetActive(false);
        }


        IEnumerator GetHandCards() {

            yield return new WaitForSeconds(3);

            allObjects1 = GameObject.FindObjectsOfType(typeof(GameObject)) as GameObject[];

            foreach (GameObject obj in allObjects1) {
                if (obj.name.Contains("instantiated1HandCard")) {

                    getHandCardsDeck1.Add(obj);

                }
            }

            mulliganInfo.SetActive(true);
        }
    }

    /* [Serializable]
        class DataToSave1Game{

            public List<string> cardsDeck1;
        } */

}
	

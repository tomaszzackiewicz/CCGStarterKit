using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Caerwent {

    public class LoadDeckCards3 : MonoBehaviour {

        static readonly string BINARY_FILE = "cardsDeck3.dat";

        public GameObject[] allObjects;
        public GameObject[] allObjects1;
        public List<Vector3> spawnPointsDeck3 = new List<Vector3>();
        public List<string> cardsDeck3 = new List<string>();
        public List<GameObject> playCardsDeck3 = new List<GameObject>();
        public List<GameObject> getHandCardsDeck3 = new List<GameObject>();

        private int NumberOfCards;
        private Vector3 spawnPoint = new Vector3(10.0f, 0.35f, -7.55f);
        private GameObject mulliganInfo;
        private GameObject doneButton3;
        private GameObject handCardCollection;
        public bool isScrollDeck3;

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
            doneButton3 = GameObject.Find("DoneButton3");
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
            isScrollDeck3 = false;

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

            spawnPointsDeck3.Insert(0, spawnPoints1);
            spawnPointsDeck3.Insert(1, spawnPoints2);
            spawnPointsDeck3.Insert(2, spawnPoints3);
            spawnPointsDeck3.Insert(3, spawnPoints4);
            spawnPointsDeck3.Insert(4, spawnPoints5);
            spawnPointsDeck3.Insert(5, spawnPoints6);
            spawnPointsDeck3.Insert(6, spawnPoints7);
            spawnPointsDeck3.Insert(7, spawnPoints8);
            spawnPointsDeck3.Insert(8, spawnPoints9);
            spawnPointsDeck3.Insert(9, spawnPoints10);

        }

        // Update is called once per frame
        void Update() {


        }

        public void LoadDeck3() {
            isScrollDeck3 = true;
            if (File.Exists(Path.Combine(Application.persistentDataPath, BINARY_FILE))) {

                BinaryFormatter bf = new BinaryFormatter();

                FileStream file = File.Open(Path.Combine(Application.persistentDataPath, BINARY_FILE), FileMode.Open);
                DataToSave3 data = (DataToSave3)bf.Deserialize(file);
                file.Close();
                cardsDeck3 = data.cardsDeck3;
                //Debug.Log(cardsDeck1.Count);



                foreach (string cardReference in cardsDeck3) {

                    if (cardReference == "instantiated3Card1") {

                        GameObject card = Instantiate(card1, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card1";


                    }

                    if (cardReference == "instantiated3Card1a") {

                        GameObject card = Instantiate(card1a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card1a";

                    }

                    if (cardReference == "instantiated3Card1b") {


                        GameObject card = Instantiate(card1b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card1b";

                    }

                    if (cardReference == "instantiated3Card1c") {


                        GameObject card = Instantiate(card1c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card1c";

                    }

                    if (cardReference == "instantiated3Card2") {


                        GameObject card = Instantiate(card2, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card2";

                    }

                    if (cardReference == "instantiated3Card2a") {


                        GameObject card = Instantiate(card2a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card2a";

                    }

                    if (cardReference == "instantiated3Card2b") {


                        GameObject card = Instantiate(card2b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card2b";

                    }

                    if (cardReference == "instantiated3Card2c") {


                        GameObject card = Instantiate(card2c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card2c";

                    }

                    if (cardReference == "instantiated3Card3") {


                        GameObject card = Instantiate(card3, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card3";

                    }

                    if (cardReference == "instantiated3Card3a") {


                        GameObject card = Instantiate(card3a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card3a";

                    }

                    if (cardReference == "instantiated3Card3b") {


                        GameObject card = Instantiate(card3b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card3b";

                    }

                    if (cardReference == "instantiated3Card3c") {


                        GameObject card = Instantiate(card3c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card3c";

                    }

                    if (cardReference == "instantiated3Card4") {


                        GameObject card = Instantiate(card4, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card4";

                    }

                    if (cardReference == "instantiated3Card4a") {


                        GameObject card = Instantiate(card4a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card4a";

                    }

                    if (cardReference == "instantiated3Card4b") {


                        GameObject card = Instantiate(card4b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card4b";

                    }

                    if (cardReference == "instantiated3Card4c") {


                        GameObject card = Instantiate(card4c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card4c";

                    }

                    if (cardReference == "instantiated3Card5") {


                        GameObject card = Instantiate(card5, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card5";

                    }

                    if (cardReference == "instantiated3Card5a") {


                        GameObject card = Instantiate(card5a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card5a";

                    }

                    if (cardReference == "instantiated3Card5b") {


                        GameObject card = Instantiate(card5b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card5b";

                    }

                    if (cardReference == "instantiated3Card5c") {


                        GameObject card = Instantiate(card5c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card5c";

                    }

                    if (cardReference == "instantiated3Card6") {


                        GameObject card = Instantiate(card6, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card6";

                    }

                    if (cardReference == "instantiated3Card6a") {


                        GameObject card = Instantiate(card6a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card6a";

                    }

                    if (cardReference == "instantiated3Card6b") {


                        GameObject card = Instantiate(card6b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card6b";

                    }

                    if (cardReference == "instantiated3Card6c") {


                        GameObject card = Instantiate(card6c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card6c";

                    }

                    if (cardReference == "instantiated3Card7") {


                        GameObject card = Instantiate(card7, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card7";

                    }

                    if (cardReference == "instantiated3Card7a") {


                        GameObject card = Instantiate(card7a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card7a";

                    }

                    if (cardReference == "instantiated3Card7b") {


                        GameObject card = Instantiate(card7b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card7b";

                    }

                    if (cardReference == "instantiated3Card7c") {


                        GameObject card = Instantiate(card7c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card7c";

                    }

                    if (cardReference == "instantiated3Card8") {


                        GameObject card = Instantiate(card8, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card8";

                    }

                    if (cardReference == "instantiated3Card8a") {


                        GameObject card = Instantiate(card8a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card8a";

                    }

                    if (cardReference == "instantiated3Card8b") {


                        GameObject card = Instantiate(card8b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card8b";

                    }

                    if (cardReference == "instantiated3Card8c") {


                        GameObject card = Instantiate(card8c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card8c";

                    }

                    if (cardReference == "instantiated3Card9") {


                        GameObject card = Instantiate(card9, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card9";

                    }

                    if (cardReference == "instantiated3Card9a") {


                        GameObject card = Instantiate(card9a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card9a";

                    }

                    if (cardReference == "instantiated3Card9b") {


                        GameObject card = Instantiate(card9b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card9b";

                    }

                    if (cardReference == "instantiated3Card9c") {


                        GameObject card = Instantiate(card9c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card9c";

                    }

                    if (cardReference == "instantiated3Card10") {


                        GameObject card = Instantiate(card10, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card10";

                    }

                    if (cardReference == "instantiated3Card10a") {


                        GameObject card = Instantiate(card10a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card10a";

                    }

                    if (cardReference == "instantiated3Card10b") {


                        GameObject card = Instantiate(card10b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card10b";

                    }

                    if (cardReference == "instantiated3Card10c") {


                        GameObject card = Instantiate(card10c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card10c";

                    }

                    if (cardReference == "instantiated3Card11") {


                        GameObject card = Instantiate(card11, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card11";

                    }

                    if (cardReference == "instantiated3Card11a") {


                        GameObject card = Instantiate(card11a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card11a";

                    }

                    if (cardReference == "instantiated3Card11b") {


                        GameObject card = Instantiate(card11b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card11b";

                    }

                    if (cardReference == "instantiated3Card11c") {


                        GameObject card = Instantiate(card11c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card11c";

                    }

                    if (cardReference == "instantiated3Card12") {


                        GameObject card = Instantiate(card12, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card12";

                    }

                    if (cardReference == "instantiated3Card12a") {


                        GameObject card = Instantiate(card12a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card12a";

                    }

                    if (cardReference == "instantiated3Card12b") {


                        GameObject card = Instantiate(card12b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card12b";

                    }

                    if (cardReference == "instantiated3Card12c") {


                        GameObject card = Instantiate(card12c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card12c";

                    }

                    if (cardReference == "instantiated3Card13") {


                        GameObject card = Instantiate(card13, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card13";

                    }

                    if (cardReference == "instantiated3Card13a") {


                        GameObject card = Instantiate(card13a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card13a";

                    }

                    if (cardReference == "instantiated3Card13b") {


                        GameObject card = Instantiate(card13b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card13b";

                    }

                    if (cardReference == "instantiated3Card13c") {


                        GameObject card = Instantiate(card13c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card13c";

                    }

                    if (cardReference == "instantiated3Card14") {


                        GameObject card = Instantiate(card14, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card14";

                    }

                    if (cardReference == "instantiated3Card14a") {


                        GameObject card = Instantiate(card14a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card14a";

                    }

                    if (cardReference == "instantiated3Card14b") {


                        GameObject card = Instantiate(card14b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card14b";

                    }

                    if (cardReference == "instantiated3Card14c") {


                        GameObject card = Instantiate(card14c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card14c";

                    }

                    if (cardReference == "instantiated3Card15") {


                        GameObject card = Instantiate(card15, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card15";

                    }

                    if (cardReference == "instantiated3Card15a") {


                        GameObject card = Instantiate(card15a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card15a";

                    }

                    if (cardReference == "instantiated3Card15b") {


                        GameObject card = Instantiate(card15b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card15b";

                    }

                    if (cardReference == "instantiated3Card15c") {


                        GameObject card = Instantiate(card15c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card15c";

                    }

                    if (cardReference == "instantiated3Card16") {


                        GameObject card = Instantiate(card16, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card16";

                    }

                    if (cardReference == "instantiated3Card16a") {


                        GameObject card = Instantiate(card16a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card16a";

                    }

                    if (cardReference == "instantiated3Card16b") {


                        GameObject card = Instantiate(card16b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card16b";

                    }

                    if (cardReference == "instantiated3Card16c") {


                        GameObject card = Instantiate(card16c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card16c";

                    }

                    if (cardReference == "instantiated3Card17") {


                        GameObject card = Instantiate(card17, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card17";

                    }

                    if (cardReference == "instantiated3Card17a") {


                        GameObject card = Instantiate(card17a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card17a";

                    }

                    if (cardReference == "instantiated3Card17b") {


                        GameObject card = Instantiate(card17b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card17b";

                    }

                    if (cardReference == "instantiated3Card17c") {


                        GameObject card = Instantiate(card17c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card17c";

                    }

                    if (cardReference == "instantiated3Card18") {


                        GameObject card = Instantiate(card18, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card18";

                    }

                    if (cardReference == "instantiated3Card18a") {


                        GameObject card = Instantiate(card18a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card18a";

                    }

                    if (cardReference == "instantiated3Card18b") {


                        GameObject card = Instantiate(card18b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card18b";

                    }

                    if (cardReference == "instantiated3Card18c") {


                        GameObject card = Instantiate(card18c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card18c";

                    }

                    if (cardReference == "instantiated3Card19") {


                        GameObject card = Instantiate(card19, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card19";

                    }

                    if (cardReference == "instantiated3Card19a") {


                        GameObject card = Instantiate(card19a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card19a";

                    }

                    if (cardReference == "instantiated3Card19b") {


                        GameObject card = Instantiate(card19b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card19b";

                    }

                    if (cardReference == "instantiated3Card19c") {


                        GameObject card = Instantiate(card19c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card19c";

                    }

                    if (cardReference == "instantiated3Card20") {


                        GameObject card = Instantiate(card20, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card20";

                    }

                    if (cardReference == "instantiated3Card20a") {


                        GameObject card = Instantiate(card20a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card20a";

                    }

                    if (cardReference == "instantiated3Card20b") {


                        GameObject card = Instantiate(card20b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card20b";

                    }

                    if (cardReference == "instantiated3Card20c") {


                        GameObject card = Instantiate(card20c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card20c";

                    }

                    if (cardReference == "instantiated3Card21") {


                        GameObject card = Instantiate(card21, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card21";

                    }

                    if (cardReference == "instantiated3Card21a") {


                        GameObject card = Instantiate(card21a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card21a";

                    }

                    if (cardReference == "instantiated3Card21b") {


                        GameObject card = Instantiate(card21b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card21b";

                    }

                    if (cardReference == "instantiated3Card21c") {


                        GameObject card = Instantiate(card21c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card21c";

                    }

                    if (cardReference == "instantiated3Card22") {


                        GameObject card = Instantiate(card22, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card22";

                    }

                    if (cardReference == "instantiated3Card22a") {


                        GameObject card = Instantiate(card22a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card22a";

                    }

                    if (cardReference == "instantiated3Card22b") {


                        GameObject card = Instantiate(card22b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card22b";

                    }

                    if (cardReference == "instantiated3Card22c") {


                        GameObject card = Instantiate(card22c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card22c";

                    }

                    if (cardReference == "instantiated3Card23") {


                        GameObject card = Instantiate(card23, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card23";

                    }

                    if (cardReference == "instantiated3Card23a") {


                        GameObject card = Instantiate(card23a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card23a";

                    }

                    if (cardReference == "instantiated3Card23b") {


                        GameObject card = Instantiate(card23b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card23b";

                    }

                    if (cardReference == "instantiated3Card23c") {


                        GameObject card = Instantiate(card23c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card23c";

                    }

                    if (cardReference == "instantiated3Card24") {


                        GameObject card = Instantiate(card24, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card24";

                    }

                    if (cardReference == "instantiated3Card24a") {


                        GameObject card = Instantiate(card24a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card24a";

                    }

                    if (cardReference == "instantiated3Card24b") {


                        GameObject card = Instantiate(card24b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card24b";

                    }

                    if (cardReference == "instantiated3Card24c") {


                        GameObject card = Instantiate(card24c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card24c";

                    }

                    if (cardReference == "instantiated3Card25") {


                        GameObject card = Instantiate(card25, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card25";

                    }

                    if (cardReference == "instantiated3Card25a") {


                        GameObject card = Instantiate(card25a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card25a";

                    }

                    if (cardReference == "instantiated3Card25b") {


                        GameObject card = Instantiate(card25b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card25b";

                    }

                    if (cardReference == "instantiated3Card25c") {


                        GameObject card = Instantiate(card25c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card25c";

                    }

                    if (cardReference == "instantiated3Card26") {


                        GameObject card = Instantiate(card26, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card26";

                    }

                    if (cardReference == "instantiated3Card26a") {


                        GameObject card = Instantiate(card26a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card26a";

                    }

                    if (cardReference == "instantiated3Card26b") {


                        GameObject card = Instantiate(card26b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card26b";

                    }

                    if (cardReference == "instantiated3Card26c") {


                        GameObject card = Instantiate(card26c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card26c";

                    }

                    if (cardReference == "instantiated3Card27") {


                        GameObject card = Instantiate(card27, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card27";

                    }

                    if (cardReference == "instantiated3Card27a") {


                        GameObject card = Instantiate(card27a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card27a";

                    }

                    if (cardReference == "instantiated3Card27b") {


                        GameObject card = Instantiate(card27b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card27b";

                    }

                    if (cardReference == "instantiated3Card27c") {


                        GameObject card = Instantiate(card27c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card27c";

                    }

                    if (cardReference == "instantiated3Card28") {


                        GameObject card = Instantiate(card28, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card28";

                    }

                    if (cardReference == "instantiated3Card28a") {


                        GameObject card = Instantiate(card28a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card28a";

                    }

                    if (cardReference == "instantiated3Card28b") {


                        GameObject card = Instantiate(card28b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card28b";

                    }

                    if (cardReference == "instantiated3Card28c") {


                        GameObject card = Instantiate(card28c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card28c";

                    }

                    if (cardReference == "instantiated3Card29") {


                        GameObject card = Instantiate(card29, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card29";

                    }

                    if (cardReference == "instantiated3Card29a") {


                        GameObject card = Instantiate(card29a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card29a";

                    }

                    if (cardReference == "instantiated3Card29b") {


                        GameObject card = Instantiate(card29b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card29b";

                    }

                    if (cardReference == "instantiated3Card29c") {


                        GameObject card = Instantiate(card29c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card29c";

                    }

                    if (cardReference == "instantiated3Card30") {


                        GameObject card = Instantiate(card30, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card30";

                    }

                    if (cardReference == "instantiated3Card30a") {


                        GameObject card = Instantiate(card30a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card30a";

                    }

                    if (cardReference == "instantiated3Card30b") {


                        GameObject card = Instantiate(card30b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card30b";

                    }

                    if (cardReference == "instantiated3Card30c") {


                        GameObject card = Instantiate(card30c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card30c";

                    }

                    if (cardReference == "instantiated3Card31") {


                        GameObject card = Instantiate(card31, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card31";

                    }

                    if (cardReference == "instantiated3Card31a") {


                        GameObject card = Instantiate(card31a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card31a";

                    }

                    if (cardReference == "instantiated3Card31b") {


                        GameObject card = Instantiate(card31b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card31b";

                    }

                    if (cardReference == "instantiated3Card31c") {


                        GameObject card = Instantiate(card31c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card31c";

                    }

                    if (cardReference == "instantiated3Card32") {


                        GameObject card = Instantiate(card32, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card32";

                    }

                    if (cardReference == "instantiated3Card32a") {


                        GameObject card = Instantiate(card32a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card32a";

                    }

                    if (cardReference == "instantiated3Card32b") {


                        GameObject card = Instantiate(card32b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card32b";

                    }

                    if (cardReference == "instantiated3Card32c") {


                        GameObject card = Instantiate(card32c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card32c";

                    }

                    if (cardReference == "instantiated3Card33") {


                        GameObject card = Instantiate(card33, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card33";

                    }

                    if (cardReference == "instantiated3Card33a") {


                        GameObject card = Instantiate(card33a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card33a";

                    }

                    if (cardReference == "instantiated3Card33b") {


                        GameObject card = Instantiate(card33b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card33b";

                    }

                    if (cardReference == "instantiated3Card33c") {


                        GameObject card = Instantiate(card33c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card33c";

                    }

                    if (cardReference == "instantiated3Card34") {


                        GameObject card = Instantiate(card34, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card34";

                    }

                    if (cardReference == "instantiated3Card34a") {


                        GameObject card = Instantiate(card34a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card34a";

                    }

                    if (cardReference == "instantiated3Card34b") {


                        GameObject card = Instantiate(card34b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card34b";

                    }

                    if (cardReference == "instantiated3Card34c") {


                        GameObject card = Instantiate(card34c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card34c";

                    }

                    if (cardReference == "instantiated3Card35") {


                        GameObject card = Instantiate(card35, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card35";

                    }

                    if (cardReference == "instantiated3Card35a") {


                        GameObject card = Instantiate(card35a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card35a";

                    }

                    if (cardReference == "instantiated3Card35b") {


                        GameObject card = Instantiate(card35b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card35b";

                    }

                    if (cardReference == "instantiated3Card35c") {


                        GameObject card = Instantiate(card35c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card35c";
                    }

                    if (cardReference == "instantiated3Card36") {


                        GameObject card = Instantiate(card36, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card36";

                    }

                    if (cardReference == "instantiated3Card36a") {


                        GameObject card = Instantiate(card36a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card36a";

                    }

                    if (cardReference == "instantiated3Card36b") {


                        GameObject card = Instantiate(card36b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card36b";

                    }

                    if (cardReference == "instantiated3Card36c") {


                        GameObject card = Instantiate(card36c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card36c";

                    }

                    if (cardReference == "instantiated3Card37") {


                        GameObject card = Instantiate(card37, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card37";

                    }

                    if (cardReference == "instantiated3Card37a") {


                        GameObject card = Instantiate(card37a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card37a";

                    }

                    if (cardReference == "instantiated3Card37b") {


                        GameObject card = Instantiate(card37b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card37b";

                    }

                    if (cardReference == "instantiated3Card37c") {


                        GameObject card = Instantiate(card37c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card37c";

                    }

                    if (cardReference == "instantiated3Card38") {


                        GameObject card = Instantiate(card38, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card38";

                    }

                    if (cardReference == "instantiated3Card38a") {


                        GameObject card = Instantiate(card38a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card38a";


                    }

                    if (cardReference == "instantiated3Card38b") {


                        GameObject card = Instantiate(card38b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card38b";

                    }

                    if (cardReference == "instantiated3Card38c") {


                        GameObject card = Instantiate(card38c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card38c";

                    }

                    if (cardReference == "instantiated3Card39") {


                        GameObject card = Instantiate(card39, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card39";

                    }

                    if (cardReference == "instantiated3Card39a") {


                        GameObject card = Instantiate(card39a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card39a";

                    }

                    if (cardReference == "instantiated3Card39b") {


                        GameObject card = Instantiate(card39b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card39b";

                    }

                    if (cardReference == "instantiated3Card39c") {


                        GameObject card = Instantiate(card39c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card39c";

                    }

                    if (cardReference == "instantiated3Card40") {


                        GameObject card = Instantiate(card40, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card40";

                    }

                    if (cardReference == "instantiated3Card40a") {


                        GameObject card = Instantiate(card40a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card40a";

                    }

                    if (cardReference == "instantiated3Card40b") {


                        GameObject card = Instantiate(card40b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card40b";

                    }

                    if (cardReference == "instantiated3Card40c") {


                        GameObject card = Instantiate(card40c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card40c";

                    }

                    if (cardReference == "instantiated3Card41") {


                        GameObject card = Instantiate(card41, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card41";

                    }

                    if (cardReference == "instantiated3Card41a") {


                        GameObject card = Instantiate(card41a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card41a";


                    }

                    if (cardReference == "instantiated3Card41b") {


                        GameObject card = Instantiate(card41b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card41b";

                    }

                    if (cardReference == "instantiated3Card41c") {


                        GameObject card = Instantiate(card41c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card41c";


                    }

                    if (cardReference == "instantiated3Card42") {


                        GameObject card = Instantiate(card42, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card42";


                    }

                    if (cardReference == "instantiated3Card42a") {


                        GameObject card = Instantiate(card42a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card42a";

                    }

                    if (cardReference == "instantiated3Card42b") {


                        GameObject card = Instantiate(card42b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card42b";

                    }

                    if (cardReference == "instantiated3Card42c") {


                        GameObject card = Instantiate(card42c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card42c";

                    }

                    if (cardReference == "instantiated3Card43") {


                        GameObject card = Instantiate(card43, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card43";


                    }

                    if (cardReference == "instantiated3Card43a") {


                        GameObject card = Instantiate(card43a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card43a";

                    }

                    if (cardReference == "instantiated3Card43b") {


                        GameObject card = Instantiate(card43b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card43b";

                    }

                    if (cardReference == "instantiated3Card43c") {


                        GameObject card = Instantiate(card43c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card43c";


                    }

                    if (cardReference == "instantiated3Card44") {


                        GameObject card = Instantiate(card44, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card44";


                    }

                    if (cardReference == "instantiated3Card44a") {


                        GameObject card = Instantiate(card44a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card44a";

                    }

                    if (cardReference == "instantiated3Card44b") {


                        GameObject card = Instantiate(card44b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card44b";

                    }

                    if (cardReference == "instantiated3Card44c") {


                        GameObject card = Instantiate(card44c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card44c";

                    }

                    if (cardReference == "instantiated3Card45") {


                        GameObject card = Instantiate(card45, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card45";

                    }

                    if (cardReference == "instantiated3Card45a") {


                        GameObject card = Instantiate(card45a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card45a";

                    }

                    if (cardReference == "instantiated3Card45b") {


                        GameObject card = Instantiate(card45b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card45b";

                    }

                    if (cardReference == "instantiated3Card45c") {


                        GameObject card = Instantiate(card45c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card45c";

                    }

                    if (cardReference == "instantiated3Card46") {


                        GameObject card = Instantiate(card46, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card46";

                    }

                    if (cardReference == "instantiated3Card46a") {


                        GameObject card = Instantiate(card46a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card46a";

                    }

                    if (cardReference == "instantiated3Card46b") {


                        GameObject card = Instantiate(card46b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card46b";


                    }

                    if (cardReference == "instantiated3Card46c") {


                        GameObject card = Instantiate(card46c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card46c";

                    }

                    if (cardReference == "instantiated3Card47") {


                        GameObject card = Instantiate(card47, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card47";

                    }

                    if (cardReference == "instantiated3Card47a") {


                        GameObject card = Instantiate(card47a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card47a";

                    }

                    if (cardReference == "instantiated3Card47b") {


                        GameObject card = Instantiate(card47b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card47b";

                    }

                    if (cardReference == "instantiated3Card47c") {


                        GameObject card = Instantiate(card47c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card47c";

                    }

                    if (cardReference == "instantiated3Card48") {


                        GameObject card = Instantiate(card48, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card48";

                    }

                    if (cardReference == "instantiated3Card48a") {


                        GameObject card = Instantiate(card48a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card48a";

                    }

                    if (cardReference == "instantiated3Card48b") {


                        GameObject card = Instantiate(card48b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card48b";

                    }

                    if (cardReference == "instantiated3Card48c") {


                        GameObject card = Instantiate(card48c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card48c";

                    }

                    if (cardReference == "instantiated3Card49") {


                        GameObject card = Instantiate(card49, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card49";

                    }

                    if (cardReference == "instantiated3Card49a") {


                        GameObject card = Instantiate(card49a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card49a";

                    }

                    if (cardReference == "instantiated3Card49b") {


                        GameObject card = Instantiate(card49b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card49b";

                    }

                    if (cardReference == "instantiated3Card49c") {


                        GameObject card = Instantiate(card49c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card49c";

                    }

                    if (cardReference == "instantiated3Card50") {


                        GameObject card = Instantiate(card50, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card50";

                    }

                    if (cardReference == "instantiated3Card50a") {


                        GameObject card = Instantiate(card50a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card50a";

                    }

                    if (cardReference == "instantiated3Card50b") {


                        GameObject card = Instantiate(card50b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card50b";

                    }

                    if (cardReference == "instantiated3Card50c") {


                        GameObject card = Instantiate(card50c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card50c";

                    }

                    if (cardReference == "instantiated3Card51") {


                        GameObject card = Instantiate(card51, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card51";

                    }

                    if (cardReference == "instantiated3Card51a") {


                        GameObject card = Instantiate(card51a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card51a";

                    }

                    if (cardReference == "instantiated3Card51b") {


                        GameObject card = Instantiate(card51b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card51b";

                    }

                    if (cardReference == "instantiated3Card51c") {


                        GameObject card = Instantiate(card51c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card51c";

                    }

                    if (cardReference == "instantiated3Card52") {


                        GameObject card = Instantiate(card52, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card52";

                    }

                    if (cardReference == "instantiated3Card52a") {


                        GameObject card = Instantiate(card52a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card52a";

                    }

                    if (cardReference == "instantiated3Card52b") {


                        GameObject card = Instantiate(card52b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card52b";

                    }

                    if (cardReference == "instantiated3Card52c") {


                        GameObject card = Instantiate(card52c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card52c";

                    }

                    if (cardReference == "instantiated3Card53") {


                        GameObject card = Instantiate(card53, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card53";

                    }

                    if (cardReference == "instantiated3Card53a") {


                        GameObject card = Instantiate(card53a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card53a";

                    }

                    if (cardReference == "instantiated3Card53b") {


                        GameObject card = Instantiate(card53b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card53b";

                    }

                    if (cardReference == "instantiated3Card53c") {


                        GameObject card = Instantiate(card53c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card53c";

                    }

                    if (cardReference == "instantiated3Card54") {


                        GameObject card = Instantiate(card54, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card54";

                    }

                    if (cardReference == "instantiated3Card54a") {


                        GameObject card = Instantiate(card54a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card54a";

                    }

                    if (cardReference == "instantiated3Card54b") {


                        GameObject card = Instantiate(card54b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card54b";

                    }

                    if (cardReference == "instantiated3Card54c") {


                        GameObject card = Instantiate(card54c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card54c";

                    }

                    if (cardReference == "instantiated3Card55") {


                        GameObject card = Instantiate(card55, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card55";

                    }

                    if (cardReference == "instantiated3Card55a") {


                        GameObject card = Instantiate(card55a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card55a";

                    }

                    if (cardReference == "instantiated3Card55b") {


                        GameObject card = Instantiate(card55b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card55b";

                    }

                    if (cardReference == "instantiated3Card55c") {


                        GameObject card = Instantiate(card55c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card55c";

                    }

                    if (cardReference == "instantiated3Card56") {


                        GameObject card = Instantiate(card56, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card56";

                    }

                    if (cardReference == "instantiated3Card56a") {


                        GameObject card = Instantiate(card56a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card56a";

                    }

                    if (cardReference == "instantiated3Card56b") {


                        GameObject card = Instantiate(card56b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card56b";

                    }

                    if (cardReference == "instantiated3Card56c") {


                        GameObject card = Instantiate(card56c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card56c";

                    }

                    if (cardReference == "instantiated3Card57") {


                        GameObject card = Instantiate(card57, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card57";

                    }

                    if (cardReference == "instantiated3Card57a") {


                        GameObject card = Instantiate(card57a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card57a";

                    }

                    if (cardReference == "instantiated3Card57b") {


                        GameObject card = Instantiate(card57b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card57b";

                    }

                    if (cardReference == "instantiated3Card57c") {


                        GameObject card = Instantiate(card57c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card57c";

                    }

                    if (cardReference == "instantiated3Card58") {


                        GameObject card = Instantiate(card58, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card58";

                    }

                    if (cardReference == "instantiated3Card58a") {


                        GameObject card = Instantiate(card58a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card58a";

                    }

                    if (cardReference == "instantiated3Card58b") {


                        GameObject card = Instantiate(card58b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card58b";

                    }

                    if (cardReference == "instantiated3Card58c") {


                        GameObject card = Instantiate(card58c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card58c";

                    }

                    if (cardReference == "instantiated3Card59") {


                        GameObject card = Instantiate(card59, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card59";

                    }

                    if (cardReference == "instantiated3Card59a") {


                        GameObject card = Instantiate(card59a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card59a";

                    }

                    if (cardReference == "instantiated3Card59b") {


                        GameObject card = Instantiate(card59b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card59b";

                    }

                    if (cardReference == "instantiated3Card59c") {


                        GameObject card = Instantiate(card59c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card59c";

                    }

                    if (cardReference == "instantiated3Card60") {


                        GameObject card = Instantiate(card60, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card60";

                    }

                    if (cardReference == "instantiated3Card60a") {


                        GameObject card = Instantiate(card60a, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card60a";

                    }

                    if (cardReference == "instantiated3Card60b") {


                        GameObject card = Instantiate(card60b, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card60b";

                    }

                    if (cardReference == "instantiated3Card60c") {


                        GameObject card = Instantiate(card60c, spawnPoint, Quaternion.identity) as GameObject;
                        card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                        card.name = "instantiated3Card60c";

                    }



                }

            }

            StartCoroutine(GetDeck3Cards());
            StartCoroutine(CreateRandomCardsFromDeck3());
            StartCoroutine(GetHandCards());

        }


        IEnumerator GetDeck3Cards() {

            yield return new WaitForSeconds(1);

            allObjects = GameObject.FindObjectsOfType(typeof(GameObject)) as GameObject[];

            foreach (GameObject obj in allObjects) {
                if (obj.name.Contains("instantiated3Card")) {

                    playCardsDeck3.Add(obj);

                }
            }


        }

        IEnumerator CreateRandomCardsFromDeck3() {

            yield return new WaitForSeconds(2);

            while (instances1 < NumberOfCards) {

                GameObject card = Instantiate(playCardsDeck3[UnityEngine.Random.Range(0, playCardsDeck3.Count)], player1DeckSlot1.transform.position, player1DeckSlot1.transform.rotation) as GameObject;
                card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                card.transform.parent = player1DeckSlot1.transform;

                if (card.name == "instantiated3Card1(Clone)") {

                    card.name = "instantiated3HandCard1";

                } else if (card.name == "instantiated3Card1a(Clone)") {

                    card.name = "instantiated3HandCard1a";

                } else if (card.name == "instantiated3Card1b(Clone)") {

                    card.name = "instantiated3HandCard1b";

                } else if (card.name == "instantiated3Card1c(Clone)") {

                    card.name = "instantiated3HandCard1c";

                } else if (card.name == "instantiated3Card2(Clone)") {

                    card.name = "instantiated3HandCard2";

                } else if (card.name == "instantiated3Card2a(Clone)") {

                    card.name = "instantiated3HandCard2a";

                } else if (card.name == "instantiated3Card2b(Clone)") {

                    card.name = "instantiated3HandCard2b";

                } else if (card.name == "instantiated3Card2c(Clone)") {

                    card.name = "instantiated3HandCard2c";

                } else if (card.name == "instantiated3Card3(Clone)") {

                    card.name = "instantiated3HandCard3";

                } else if (card.name == "instantiated3Card3a(Clone)") {

                    card.name = "instantiated3HandCard3a";

                } else if (card.name == "instantiated3Card3b(Clone)") {

                    card.name = "instantiated3HandCard3b";

                } else if (card.name == "instantiated3Card3c(Clone)") {

                    card.name = "instantiated3HandCard3c";

                } else if (card.name == "instantiated3Card4(Clone)") {

                    card.name = "instantiated3HandCard4";

                } else if (card.name == "instantiated3Card4a(Clone)") {

                    card.name = "instantiated3HandCard4a";

                } else if (card.name == "instantiated3Card4b(Clone)") {

                    card.name = "instantiated3HandCard4b";

                } else if (card.name == "instantiated3Card4c(Clone)") {

                    card.name = "instantiated3HandCard4c";

                } else if (card.name == "instantiated3Card5(Clone)") {

                    card.name = "instantiated3HandCard5";

                } else if (card.name == "instantiated3Card5a(Clone)") {

                    card.name = "instantiated3HandCard5a";

                } else if (card.name == "instantiated3Card5b(Clone)") {

                    card.name = "instantiated3HandCard5b";

                } else if (card.name == "instantiated3Card5c(Clone)") {

                    card.name = "instantiated3HandCard5c";

                } else if (card.name == "instantiated3Card6(Clone)") {

                    card.name = "instantiated3HandCard6";

                } else if (card.name == "instantiated3Card6a(Clone)") {

                    card.name = "instantiated3HandCard6a";

                } else if (card.name == "instantiated3Card6b(Clone)") {

                    card.name = "instantiated3HandCard6b";

                } else if (card.name == "instantiated3Card6c(Clone)") {

                    card.name = "instantiated3HandCard6c";

                } else if (card.name == "instantiated3Card7(Clone)") {

                    card.name = "instantiated3HandCard7";

                } else if (card.name == "instantiated3Card7a(Clone)") {

                    card.name = "instantiated3HandCard7a";

                } else if (card.name == "instantiated3Card7b(Clone)") {

                    card.name = "instantiated3HandCard7b";

                } else if (card.name == "instantiated3Card7c(Clone)") {

                    card.name = "instantiated3HandCard7c";

                } else if (card.name == "instantiated3Card8(Clone)") {

                    card.name = "instantiated3HandCard8";

                } else if (card.name == "instantiated3Card8a(Clone)") {

                    card.name = "instantiated3HandCard8a";

                } else if (card.name == "instantiated3Card8b(Clone)") {

                    card.name = "instantiated3HandCard8b";

                } else if (card.name == "instantiated3Card8c(Clone)") {

                    card.name = "instantiated3HandCard8c";

                } else if (card.name == "instantiated3Card9(Clone)") {

                    card.name = "instantiated3HandCard9";

                } else if (card.name == "instantiated3Card9a(Clone)") {

                    card.name = "instantiated3HandCard9a";

                } else if (card.name == "instantiated3Card9b(Clone)") {

                    card.name = "instantiated3HandCard9b";

                } else if (card.name == "instantiated3Card9c(Clone)") {

                    card.name = "instantiated3HandCard9c";

                } else if (card.name == "instantiated3Card10(Clone)") {

                    card.name = "instantiatedAICard10";

                } else if (card.name == "instantiated3Card10a(Clone)") {

                    card.name = "instantiated3HandCard10a";

                } else if (card.name == "instantiated3Card10b(Clone)") {

                    card.name = "instantiated3HandCard10b";

                } else if (card.name == "instantiated3Card10c(Clone)") {

                    card.name = "instantiated3HandCard10c";

                } else if (card.name == "instantiated3Card11(Clone)") {

                    card.name = "instantiated3HandCard11";

                } else if (card.name == "instantiated3Card11a(Clone)") {

                    card.name = "instantiated3HandCard11a";

                } else if (card.name == "instantiated3Card11b(Clone)") {

                    card.name = "instantiated3HandCard11b";

                } else if (card.name == "instantiated3Card11c(Clone)") {

                    card.name = "instantiated3HandCard11c";

                } else if (card.name == "instantiated3Card12(Clone)") {

                    card.name = "instantiated3HandCard12";

                } else if (card.name == "instantiated3Card12a(Clone)") {

                    card.name = "instantiated3HandCard12a";

                } else if (card.name == "instantiated3Card12b(Clone)") {

                    card.name = "instantiated3HandCard12b";

                } else if (card.name == "instantiated3Card12c(Clone)") {

                    card.name = "instantiated3HandCard12c";

                } else if (card.name == "instantiated3Card13(Clone)") {

                    card.name = "instantiated3HandCard13";

                } else if (card.name == "instantiated3Card13a(Clone)") {

                    card.name = "instantiated3HandCard13a";

                } else if (card.name == "instantiated3Card13b(Clone)") {

                    card.name = "instantiated3HandCard13b";

                } else if (card.name == "instantiated3Card13c(Clone)") {

                    card.name = "instantiated3HandCard13c";

                } else if (card.name == "instantiated3Card14(Clone)") {

                    card.name = "instantiated3HandCard14";

                } else if (card.name == "instantiated3Card14a(Clone)") {

                    card.name = "instantiated3HandCard14a";

                } else if (card.name == "instantiated3Card14b(Clone)") {

                    card.name = "instantiated3HandCard14b";

                } else if (card.name == "instantiated3Card14c(Clone)") {

                    card.name = "instantiated3HandCard14c";

                } else if (card.name == "instantiated3Card15(Clone)") {

                    card.name = "instantiated3HandCard15";

                } else if (card.name == "instantiated3Card15a(Clone)") {

                    card.name = "instantiated3HandCard15a";

                } else if (card.name == "instantiated3Card15b(Clone)") {

                    card.name = "instantiated3HandCard15b";

                } else if (card.name == "instantiated3Card15c(Clone)") {

                    card.name = "instantiated3HandCard15c";

                } else if (card.name == "instantiated3Card16(Clone)") {

                    card.name = "instantiated3HandCard16";

                } else if (card.name == "instantiated3Card16a(Clone)") {

                    card.name = "instantiated3HandCard16a";

                } else if (card.name == "instantiated3Card16b(Clone)") {

                    card.name = "instantiated3HandCard16b";

                } else if (card.name == "instantiated3Card16c(Clone)") {

                    card.name = "instantiated3HandCard16c";

                } else if (card.name == "instantiated3Card17(Clone)") {

                    card.name = "instantiated3HandCard17";

                } else if (card.name == "instantiated3Card17a(Clone)") {

                    card.name = "instantiated3HandCard17a";

                } else if (card.name == "instantiated3Card17b(Clone)") {

                    card.name = "instantiated3HandCard17b";

                } else if (card.name == "instantiated3Card17c(Clone)") {

                    card.name = "instantiated3HandCard17c";

                } else if (card.name == "instantiated3Card18(Clone)") {

                    card.name = "instantiated3HandCard18";

                } else if (card.name == "instantiated3Card18a(Clone)") {

                    card.name = "instantiated3HandCard18a";

                } else if (card.name == "instantiated3Card18b(Clone)") {

                    card.name = "instantiated3HandCard18b";

                } else if (card.name == "instantiated3Card18c(Clone)") {

                    card.name = "instantiated3HandCard18c";

                } else if (card.name == "instantiated3Card19(Clone)") {

                    card.name = "instantiated3HandCard19";

                } else if (card.name == "instantiated3Card19a(Clone)") {

                    card.name = "instantiated3HandCard19a";

                } else if (card.name == "instantiated3Card19b(Clone)") {

                    card.name = "instantiated3HandCard19b";

                } else if (card.name == "instantiated3Card19c(Clone)") {

                    card.name = "instantiated3HandCard19c";

                } else if (card.name == "instantiated3Card20(Clone)") {

                    card.name = "instantiated3HandCard20";

                } else if (card.name == "instantiated3Card20a(Clone)") {

                    card.name = "instantiated3HandCard20a";

                } else if (card.name == "instantiated3Card20b(Clone)") {

                    card.name = "instantiated3HandCard20b";

                } else if (card.name == "instantiated3Card20c(Clone)") {

                    card.name = "instantiated3HandCard20c";

                } else if (card.name == "instantiated3Card21(Clone)") {

                    card.name = "instantiated3HandCard21";

                } else if (card.name == "instantiated3Card21a(Clone)") {

                    card.name = "instantiated3HandCard21a";

                } else if (card.name == "instantiated3Card21b(Clone)") {

                    card.name = "instantiated3HandCard21b";

                } else if (card.name == "instantiated3Card21c(Clone)") {

                    card.name = "instantiated3HandCard21c";

                } else if (card.name == "instantiated3Card22(Clone)") {

                    card.name = "instantiated3HandCard22";

                } else if (card.name == "instantiated3Card22a(Clone)") {

                    card.name = "instantiated3HandCard22a";

                } else if (card.name == "instantiated3Card22b(Clone)") {

                    card.name = "instantiated3HandCard22b";

                } else if (card.name == "instantiated3Card22c(Clone)") {

                    card.name = "instantiated3HandCard22c";

                } else if (card.name == "instantiated3Card23(Clone)") {

                    card.name = "instantiated3HandCard23";

                } else if (card.name == "instantiated3Card23a(Clone)") {

                    card.name = "instantiated3HandCard23a";

                } else if (card.name == "instantiated3Card23b(Clone)") {

                    card.name = "instantiated3HandCard23b";

                } else if (card.name == "instantiated3Card23c(Clone)") {

                    card.name = "instantiated3HandCard23c";

                } else if (card.name == "instantiated3Card24(Clone)") {

                    card.name = "instantiated3HandCard24";

                } else if (card.name == "instantiated3Card24a(Clone)") {

                    card.name = "instantiated3HandCard24a";

                } else if (card.name == "instantiated3Card24b(Clone)") {

                    card.name = "instantiated3HandCard24b";

                } else if (card.name == "instantiated3Card24c(Clone)") {

                    card.name = "instantiated3HandCard24c";

                } else if (card.name == "instantiated3Card25(Clone)") {

                    card.name = "instantiated3HandCard25";

                } else if (card.name == "instantiated3Card25a(Clone)") {

                    card.name = "instantiated3HandCard25a";

                } else if (card.name == "instantiated3Card25b(Clone)") {

                    card.name = "instantiated3HandCard25b";

                } else if (card.name == "instantiated3Card25c(Clone)") {

                    card.name = "instantiated3HandCard25c";

                } else if (card.name == "instantiated3Card26(Clone)") {

                    card.name = "instantiated3HandCard26";

                } else if (card.name == "instantiated3Card26a(Clone)") {

                    card.name = "instantiated3HandCard26a";

                } else if (card.name == "instantiated3Card26b(Clone)") {

                    card.name = "instantiated3HandCard26b";

                } else if (card.name == "instantiated3Card26c(Clone)") {

                    card.name = "instantiated3HandCard26c";

                } else if (card.name == "instantiated3Card27(Clone)") {

                    card.name = "instantiated3HandCard27";

                } else if (card.name == "instantiated3Card27a(Clone)") {

                    card.name = "instantiated3HandCard27a";

                } else if (card.name == "instantiated3Card27b(Clone)") {

                    card.name = "instantiated3HandCard27b";

                } else if (card.name == "instantiated3Card27c(Clone)") {

                    card.name = "instantiated3HandCard27c";

                } else if (card.name == "instantiated3Card28(Clone)") {

                    card.name = "instantiated3HandCard28";

                } else if (card.name == "instantiated3Card28a(Clone)") {

                    card.name = "instantiated3HandCard28a";

                } else if (card.name == "instantiated3Card28b(Clone)") {

                    card.name = "instantiated3HandCard28b";

                } else if (card.name == "instantiated3Card28c(Clone)") {

                    card.name = "instantiated3HandCard28c";

                } else if (card.name == "instantiated3Card29(Clone)") {

                    card.name = "instantiated3HandCard29";

                } else if (card.name == "instantiated3Card29a(Clone)") {

                    card.name = "instantiated3HandCard29a";

                } else if (card.name == "instantiated3Card29b(Clone)") {

                    card.name = "instantiated3HandCard29b";

                } else if (card.name == "instantiated3Card29c(Clone)") {

                    card.name = "instantiated3HandCard29c";

                } else if (card.name == "instantiated3Card30(Clone)") {

                    card.name = "instantiated3HandCard30";

                } else if (card.name == "instantiated3Card30a(Clone)") {

                    card.name = "instantiated3HandCard30a";

                } else if (card.name == "instantiated3Card30b(Clone)") {

                    card.name = "instantiated3HandCard30b";

                } else if (card.name == "instantiated3Card30c(Clone)") {

                    card.name = "instantiated3HandCard30c";

                } else if (card.name == "instantiated3Card31(Clone)") {

                    card.name = "instantiated3HandCard31";

                } else if (card.name == "instantiated3Card31a(Clone)") {

                    card.name = "instantiated3HandCard31a";

                } else if (card.name == "instantiated3Card31b(Clone)") {

                    card.name = "instantiated3HandCard31b";

                } else if (card.name == "instantiated3Card31c(Clone)") {

                    card.name = "instantiated3HandCard31c";

                } else if (card.name == "instantiated3Card32(Clone)") {

                    card.name = "instantiated3HandCard32";

                } else if (card.name == "instantiated3Card32a(Clone)") {

                    card.name = "instantiated3HandCard32a";

                } else if (card.name == "instantiated3Card32b(Clone)") {

                    card.name = "instantiated3HandCard32b";

                } else if (card.name == "instantiated3Card32c(Clone)") {

                    card.name = "instantiated3HandCard32c";

                } else if (card.name == "instantiated3Card33(Clone)") {

                    card.name = "instantiated3HandCard33";

                } else if (card.name == "instantiated3Card33a(Clone)") {

                    card.name = "instantiated3HandCard33a";

                } else if (card.name == "instantiated3Card33b(Clone)") {

                    card.name = "instantiated3HandCard33b";

                } else if (card.name == "instantiated3Card33c(Clone)") {

                    card.name = "instantiated3HandCard33c";

                } else if (card.name == "instantiated3Card34(Clone)") {

                    card.name = "instantiated3HandCard34";

                } else if (card.name == "instantiated3Card34a(Clone)") {

                    card.name = "instantiated3HandCard34a";

                } else if (card.name == "instantiated3Card34b(Clone)") {

                    card.name = "instantiated3HandCard34b";

                } else if (card.name == "instantiated3Card34c(Clone)") {

                    card.name = "instantiated3HandCard34c";

                } else if (card.name == "instantiated3Card35(Clone)") {

                    card.name = "instantiated3HandCard35";

                } else if (card.name == "instantiated3Card35a(Clone)") {

                    card.name = "instantiated3HandCard35a";

                } else if (card.name == "instantiated3Card35b(Clone)") {

                    card.name = "instantiated3HandCard35b";

                } else if (card.name == "instantiated3Card35c(Clone)") {

                    card.name = "instantiated3HandCard35c";

                } else if (card.name == "instantiated3Card36(Clone)") {

                    card.name = "instantiated3HandCard36";

                } else if (card.name == "instantiated3Card36a(Clone)") {

                    card.name = "instantiated3HandCard36a";

                } else if (card.name == "instantiated3Card36b(Clone)") {

                    card.name = "instantiated3HandCard36b";

                } else if (card.name == "instantiated3Card36c(Clone)") {

                    card.name = "instantiated3HandCard36c";

                } else if (card.name == "instantiated3Card37(Clone)") {

                    card.name = "instantiated3HandCard37";

                } else if (card.name == "instantiated3Card37a(Clone)") {

                    card.name = "instantiated3HandCard37a";

                } else if (card.name == "instantiated3Card37b(Clone)") {

                    card.name = "instantiated3HandCard37b";

                } else if (card.name == "instantiated3Card37c(Clone)") {

                    card.name = "instantiated3HandCard37c";

                } else if (card.name == "instantiated3Card38(Clone)") {

                    card.name = "instantiated3HandCard38";

                } else if (card.name == "instantiated3Card38a(Clone)") {

                    card.name = "instantiated3HandCard38a";

                } else if (card.name == "instantiated3Card38b(Clone)") {

                    card.name = "instantiated3HandCard38b";

                } else if (card.name == "instantiated3Card38c(Clone)") {

                    card.name = "instantiated3HandCard38c";

                } else if (card.name == "instantiated3Card39(Clone)") {

                    card.name = "instantiated3HandCard39";

                } else if (card.name == "instantiated3Card39a(Clone)") {

                    card.name = "instantiated3HandCard39a";

                } else if (card.name == "instantiated3Card39b(Clone)") {

                    card.name = "instantiated3HandCard39b";

                } else if (card.name == "instantiated3Card39c(Clone)") {

                    card.name = "instantiated3HandCard39c";

                } else if (card.name == "instantiated3Card40(Clone)") {

                    card.name = "instantiated3HandCard40";

                } else if (card.name == "instantiated3Card40a(Clone)") {

                    card.name = "instantiated3HandCard40a";

                } else if (card.name == "instantiated3Card40b(Clone)") {

                    card.name = "instantiated3HandCard40b";

                } else if (card.name == "instantiated3Card40c(Clone)") {

                    card.name = "instantiated3HandCard40c";

                } else if (card.name == "instantiated3Card41(Clone)") {

                    card.name = "instantiated3HandCard41";

                } else if (card.name == "instantiated3Card41a(Clone)") {

                    card.name = "instantiated3HandCard41a";

                } else if (card.name == "instantiated3Card41b(Clone)") {

                    card.name = "instantiated3HandCard41b";

                } else if (card.name == "instantiated3Card41c(Clone)") {

                    card.name = "instantiated3HandCard41c";

                } else if (card.name == "instantiated3Card42(Clone)") {

                    card.name = "instantiated3HandCard42";

                } else if (card.name == "instantiated3Card42a(Clone)") {

                    card.name = "instantiated3HandCard42a";

                } else if (card.name == "instantiated3Card42b(Clone)") {

                    card.name = "instantiated3HandCard42b";

                } else if (card.name == "instantiated3Card42c(Clone)") {

                    card.name = "instantiated3HandCard42c";

                } else if (card.name == "instantiated3Card43(Clone)") {

                    card.name = "instantiated3HandCard43";

                } else if (card.name == "instantiated3Card43a(Clone)") {

                    card.name = "instantiated3HandCard43a";

                } else if (card.name == "instantiated3Card43b(Clone)") {

                    card.name = "instantiated3HandCard43b";

                } else if (card.name == "instantiated3Card43c(Clone)") {

                    card.name = "instantiated3HandCard43c";

                } else if (card.name == "instantiated3Card44(Clone)") {

                    card.name = "instantiated3HandCard44";

                } else if (card.name == "instantiated3Card44a(Clone)") {

                    card.name = "instantiated3HandCard44a";

                } else if (card.name == "instantiated3Card44b(Clone)") {

                    card.name = "instantiated3HandCard44b";

                } else if (card.name == "instantiated3Card44c(Clone)") {

                    card.name = "instantiated3HandCard44c";

                } else if (card.name == "instantiated3Card45(Clone)") {

                    card.name = "instantiated3HandCard45";

                } else if (card.name == "instantiated3Card45a(Clone)") {

                    card.name = "instantiated3HandCard45a";

                } else if (card.name == "instantiated3Card45b(Clone)") {

                    card.name = "instantiated3HandCard45b";

                } else if (card.name == "instantiated3Card45c(Clone)") {

                    card.name = "instantiated3HandCard45c";

                } else if (card.name == "instantiated3Card46(Clone)") {

                    card.name = "instantiated3HandCard46";

                } else if (card.name == "instantiated3Card46a(Clone)") {

                    card.name = "instantiated3HandCard46a";

                } else if (card.name == "instantiated3Card46b(Clone)") {

                    card.name = "instantiated3HandCard46b";

                } else if (card.name == "instantiated3Card46c(Clone)") {

                    card.name = "instantiated3HandCard46c";

                } else if (card.name == "instantiated3Card47(Clone)") {

                    card.name = "instantiated3HandCard47";

                } else if (card.name == "instantiated3Card47a(Clone)") {

                    card.name = "instantiated3HandCard47a";

                } else if (card.name == "instantiated3Card47b(Clone)") {

                    card.name = "instantiated3HandCard47b";

                } else if (card.name == "instantiated3Card47c(Clone)") {

                    card.name = "instantiated3HandCard47c";

                } else if (card.name == "instantiated3Card48(Clone)") {

                    card.name = "instantiated3HandCard48";

                } else if (card.name == "instantiated3Card48a(Clone)") {

                    card.name = "instantiated3HandCard48a";

                } else if (card.name == "instantiated3Card48b(Clone)") {

                    card.name = "instantiated3HandCard48b";

                } else if (card.name == "instantiated3Card48c(Clone)") {

                    card.name = "instantiated3HandCard48c";

                } else if (card.name == "instantiated3Card49(Clone)") {

                    card.name = "instantiated3HandCard49";

                } else if (card.name == "instantiated3Card49a(Clone)") {

                    card.name = "instantiated3HandCard49a";

                } else if (card.name == "instantiated3Card49b(Clone)") {

                    card.name = "instantiated3HandCard49b";

                } else if (card.name == "instantiated3Card49c(Clone)") {

                    card.name = "instantiated3HandCard49c";

                } else if (card.name == "instantiated3Card50(Clone)") {

                    card.name = "instantiated3HandCard50";

                } else if (card.name == "instantiated3Card50a(Clone)") {

                    card.name = "instantiated3HandCard50a";

                } else if (card.name == "instantiated3Card50b(Clone)") {

                    card.name = "instantiated3HandCard50b";

                } else if (card.name == "instantiated3Card50c(Clone)") {

                    card.name = "instantiated3HandCard50c";

                } else if (card.name == "instantiated3Card51(Clone)") {

                    card.name = "instantiated3HandCard51";

                } else if (card.name == "instantiated3Card51a(Clone)") {

                    card.name = "instantiated3HandCard51a";

                } else if (card.name == "instantiated3Card51b(Clone)") {

                    card.name = "instantiated3HandCard51b";

                } else if (card.name == "instantiated3Card51c(Clone)") {

                    card.name = "instantiated3HandCard51c";

                } else if (card.name == "instantiated3Card52(Clone)") {

                    card.name = "instantiated3HandCard52";

                } else if (card.name == "instantiated3Card52a(Clone)") {

                    card.name = "instantiated3HandCard52a";

                } else if (card.name == "instantiated3Card52b(Clone)") {

                    card.name = "instantiated3HandCard52b";

                } else if (card.name == "instantiated3Card52c(Clone)") {

                    card.name = "instantiated3HandCard52c";

                } else if (card.name == "instantiated3Card53(Clone)") {

                    card.name = "instantiated3HandCard53";

                } else if (card.name == "instantiated3Card53a(Clone)") {

                    card.name = "instantiated3HandCard53a";

                } else if (card.name == "instantiated3Card53b(Clone)") {

                    card.name = "instantiated3HandCard53b";

                } else if (card.name == "instantiated3Card53c(Clone)") {

                    card.name = "instantiated3HandCard53c";

                } else if (card.name == "instantiated3Card54(Clone)") {

                    card.name = "instantiated3HandCard54";

                } else if (card.name == "instantiated3Card54a(Clone)") {

                    card.name = "instantiated3HandCard54a";

                } else if (card.name == "instantiated3Card54b(Clone)") {

                    card.name = "instantiated3HandCard54b";

                } else if (card.name == "instantiated3Card54c(Clone)") {

                    card.name = "instantiated3HandCard54c";

                } else if (card.name == "instantiated3Card55(Clone)") {

                    card.name = "instantiated3HandCard55";

                } else if (card.name == "instantiated3Card55a(Clone)") {

                    card.name = "instantiated3HandCard55a";

                } else if (card.name == "instantiated3Card55b(Clone)") {

                    card.name = "instantiated3HandCard55b";

                } else if (card.name == "instantiated3Card55c(Clone)") {

                    card.name = "instantiated3HandCard55c";

                } else if (card.name == "instantiated3Card56(Clone)") {

                    card.name = "instantiated3HandCard56";

                } else if (card.name == "instantiated3Card56a(Clone)") {

                    card.name = "instantiated3HandCard56a";

                } else if (card.name == "instantiated3Card56b(Clone)") {

                    card.name = "instantiated3HandCard56b";

                } else if (card.name == "instantiated3Card56c(Clone)") {

                    card.name = "instantiated3HandCard56c";

                } else if (card.name == "instantiated3Card57(Clone)") {

                    card.name = "instantiated3HandCard57";

                } else if (card.name == "instantiated3Card57a(Clone)") {

                    card.name = "instantiated3HandCard57a";

                } else if (card.name == "instantiated3Card57b(Clone)") {

                    card.name = "instantiated3HandCard57b";

                } else if (card.name == "instantiated3Card57c(Clone)") {

                    card.name = "instantiated3HandCard57c";

                } else if (card.name == "instantiated3Card58(Clone)") {

                    card.name = "instantiated3HandCard58";

                } else if (card.name == "instantiated3Card58a(Clone)") {

                    card.name = "instantiated3HandCard58a";

                } else if (card.name == "instantiated3Card58b(Clone)") {

                    card.name = "instantiated3HandCard58b";

                } else if (card.name == "instantiated3Card58c(Clone)") {

                    card.name = "instantiated3HandCard58c";

                } else if (card.name == "instantiated3Card59(Clone)") {

                    card.name = "instantiated3HandCard59";

                } else if (card.name == "instantiated3Card59a(Clone)") {

                    card.name = "instantiated3HandCard59a";

                } else if (card.name == "instantiated3Card59b(Clone)") {

                    card.name = "instantiated3HandCard59b";

                } else if (card.name == "instantiated3Card59c(Clone)") {

                    card.name = "instantiated3HandCard59c";

                } else if (card.name == "instantiated3Card60(Clone)") {

                    card.name = "instantiated3HandCard60";

                } else if (card.name == "instantiated3Card60a(Clone)") {

                    card.name = "instantiated3HandCard60a";

                } else if (card.name == "instantiated3Card60b(Clone)") {

                    card.name = "instantiated3HandCard60b";

                } else if (card.name == "instantiated3Card60c(Clone)") {

                    card.name = "instantiated3HandCard60c";
                }

                instances1++;

            }

            while (instances2 < NumberOfCards) {

                GameObject card = Instantiate(playCardsDeck3[UnityEngine.Random.Range(0, playCardsDeck3.Count)], player1DeckSlot2.transform.position, player1DeckSlot2.transform.rotation) as GameObject;
                card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                card.transform.parent = player1DeckSlot2.transform;

                if (card.name == "instantiated3Card1(Clone)") {

                    card.name = "instantiated3HandCard1";

                } else if (card.name == "instantiated3Card1a(Clone)") {

                    card.name = "instantiated3HandCard1a";

                } else if (card.name == "instantiated3Card1b(Clone)") {

                    card.name = "instantiated3HandCard1b";

                } else if (card.name == "instantiated3Card1c(Clone)") {

                    card.name = "instantiated3HandCard1c";

                } else if (card.name == "instantiated3Card2(Clone)") {

                    card.name = "instantiated3HandCard2";

                } else if (card.name == "instantiated3Card2a(Clone)") {

                    card.name = "instantiated3HandCard2a";

                } else if (card.name == "instantiated3Card2b(Clone)") {

                    card.name = "instantiated3HandCard2b";

                } else if (card.name == "instantiated3Card2c(Clone)") {

                    card.name = "instantiated3HandCard2c";

                } else if (card.name == "instantiated3Card3(Clone)") {

                    card.name = "instantiated3HandCard3";

                } else if (card.name == "instantiated3Card3a(Clone)") {

                    card.name = "instantiated3HandCard3a";

                } else if (card.name == "instantiated3Card3b(Clone)") {

                    card.name = "instantiated3HandCard3b";

                } else if (card.name == "instantiated3Card3c(Clone)") {

                    card.name = "instantiated3HandCard3c";

                } else if (card.name == "instantiated3Card4(Clone)") {

                    card.name = "instantiated3HandCard4";

                } else if (card.name == "instantiated3Card4a(Clone)") {

                    card.name = "instantiated3HandCard4a";

                } else if (card.name == "instantiated3Card4b(Clone)") {

                    card.name = "instantiated3HandCard4b";

                } else if (card.name == "instantiated3Card4c(Clone)") {

                    card.name = "instantiated3HandCard4c";

                } else if (card.name == "instantiated3Card5(Clone)") {

                    card.name = "instantiated3HandCard5";

                } else if (card.name == "instantiated3Card5a(Clone)") {

                    card.name = "instantiated3HandCard5a";

                } else if (card.name == "instantiated3Card5b(Clone)") {

                    card.name = "instantiated3HandCard5b";

                } else if (card.name == "instantiated3Card5c(Clone)") {

                    card.name = "instantiated3HandCard5c";

                } else if (card.name == "instantiated3Card6(Clone)") {

                    card.name = "instantiated3HandCard6";

                } else if (card.name == "instantiated3Card6a(Clone)") {

                    card.name = "instantiated3HandCard6a";

                } else if (card.name == "instantiated3Card6b(Clone)") {

                    card.name = "instantiated3HandCard6b";

                } else if (card.name == "instantiated3Card6c(Clone)") {

                    card.name = "instantiated3HandCard6c";

                } else if (card.name == "instantiated3Card7(Clone)") {

                    card.name = "instantiated3HandCard7";

                } else if (card.name == "instantiated3Card7a(Clone)") {

                    card.name = "instantiated3HandCard7a";

                } else if (card.name == "instantiated3Card7b(Clone)") {

                    card.name = "instantiated3HandCard7b";

                } else if (card.name == "instantiated3Card7c(Clone)") {

                    card.name = "instantiated3HandCard7c";

                } else if (card.name == "instantiated3Card8(Clone)") {

                    card.name = "instantiated3HandCard8";

                } else if (card.name == "instantiated3Card8a(Clone)") {

                    card.name = "instantiated3HandCard8a";

                } else if (card.name == "instantiated3Card8b(Clone)") {

                    card.name = "instantiated3HandCard8b";

                } else if (card.name == "instantiated3Card8c(Clone)") {

                    card.name = "instantiated3HandCard8c";

                } else if (card.name == "instantiated3Card9(Clone)") {

                    card.name = "instantiated3HandCard9";

                } else if (card.name == "instantiated3Card9a(Clone)") {

                    card.name = "instantiated3HandCard9a";

                } else if (card.name == "instantiated3Card9b(Clone)") {

                    card.name = "instantiated3HandCard9b";

                } else if (card.name == "instantiated3Card9c(Clone)") {

                    card.name = "instantiated3HandCard9c";

                } else if (card.name == "instantiated3Card10(Clone)") {

                    card.name = "instantiatedAICard10";

                } else if (card.name == "instantiated3Card10a(Clone)") {

                    card.name = "instantiated3HandCard10a";

                } else if (card.name == "instantiated3Card10b(Clone)") {

                    card.name = "instantiated3HandCard10b";

                } else if (card.name == "instantiated3Card10c(Clone)") {

                    card.name = "instantiated3HandCard10c";

                } else if (card.name == "instantiated3Card11(Clone)") {

                    card.name = "instantiated3HandCard11";

                } else if (card.name == "instantiated3Card11a(Clone)") {

                    card.name = "instantiated3HandCard11a";

                } else if (card.name == "instantiated3Card11b(Clone)") {

                    card.name = "instantiated3HandCard11b";

                } else if (card.name == "instantiated3Card11c(Clone)") {

                    card.name = "instantiated3HandCard11c";

                } else if (card.name == "instantiated3Card12(Clone)") {

                    card.name = "instantiated3HandCard12";

                } else if (card.name == "instantiated3Card12a(Clone)") {

                    card.name = "instantiated3HandCard12a";

                } else if (card.name == "instantiated3Card12b(Clone)") {

                    card.name = "instantiated3HandCard12b";

                } else if (card.name == "instantiated3Card12c(Clone)") {

                    card.name = "instantiated3HandCard12c";

                } else if (card.name == "instantiated3Card13(Clone)") {

                    card.name = "instantiated3HandCard13";

                } else if (card.name == "instantiated3Card13a(Clone)") {

                    card.name = "instantiated3HandCard13a";

                } else if (card.name == "instantiated3Card13b(Clone)") {

                    card.name = "instantiated3HandCard13b";

                } else if (card.name == "instantiated3Card13c(Clone)") {

                    card.name = "instantiated3HandCard13c";

                } else if (card.name == "instantiated3Card14(Clone)") {

                    card.name = "instantiated3HandCard14";

                } else if (card.name == "instantiated3Card14a(Clone)") {

                    card.name = "instantiated3HandCard14a";

                } else if (card.name == "instantiated3Card14b(Clone)") {

                    card.name = "instantiated3HandCard14b";

                } else if (card.name == "instantiated3Card14c(Clone)") {

                    card.name = "instantiated3HandCard14c";

                } else if (card.name == "instantiated3Card15(Clone)") {

                    card.name = "instantiated3HandCard15";

                } else if (card.name == "instantiated3Card15a(Clone)") {

                    card.name = "instantiated3HandCard15a";

                } else if (card.name == "instantiated3Card15b(Clone)") {

                    card.name = "instantiated3HandCard15b";

                } else if (card.name == "instantiated3Card15c(Clone)") {

                    card.name = "instantiated3HandCard15c";

                } else if (card.name == "instantiated3Card16(Clone)") {

                    card.name = "instantiated3HandCard16";

                } else if (card.name == "instantiated3Card16a(Clone)") {

                    card.name = "instantiated3HandCard16a";

                } else if (card.name == "instantiated3Card16b(Clone)") {

                    card.name = "instantiated3HandCard16b";

                } else if (card.name == "instantiated3Card16c(Clone)") {

                    card.name = "instantiated3HandCard16c";

                } else if (card.name == "instantiated3Card17(Clone)") {

                    card.name = "instantiated3HandCard17";

                } else if (card.name == "instantiated3Card17a(Clone)") {

                    card.name = "instantiated3HandCard17a";

                } else if (card.name == "instantiated3Card17b(Clone)") {

                    card.name = "instantiated3HandCard17b";

                } else if (card.name == "instantiated3Card17c(Clone)") {

                    card.name = "instantiated3HandCard17c";

                } else if (card.name == "instantiated3Card18(Clone)") {

                    card.name = "instantiated3HandCard18";

                } else if (card.name == "instantiated3Card18a(Clone)") {

                    card.name = "instantiated3HandCard18a";

                } else if (card.name == "instantiated3Card18b(Clone)") {

                    card.name = "instantiated3HandCard18b";

                } else if (card.name == "instantiated3Card18c(Clone)") {

                    card.name = "instantiated3HandCard18c";

                } else if (card.name == "instantiated3Card19(Clone)") {

                    card.name = "instantiated3HandCard19";

                } else if (card.name == "instantiated3Card19a(Clone)") {

                    card.name = "instantiated3HandCard19a";

                } else if (card.name == "instantiated3Card19b(Clone)") {

                    card.name = "instantiated3HandCard19b";

                } else if (card.name == "instantiated3Card19c(Clone)") {

                    card.name = "instantiated3HandCard19c";

                } else if (card.name == "instantiated3Card20(Clone)") {

                    card.name = "instantiated3HandCard20";

                } else if (card.name == "instantiated3Card20a(Clone)") {

                    card.name = "instantiated3HandCard20a";

                } else if (card.name == "instantiated3Card20b(Clone)") {

                    card.name = "instantiated3HandCard20b";

                } else if (card.name == "instantiated3Card20c(Clone)") {

                    card.name = "instantiated3HandCard20c";

                } else if (card.name == "instantiated3Card21(Clone)") {

                    card.name = "instantiated3HandCard21";

                } else if (card.name == "instantiated3Card21a(Clone)") {

                    card.name = "instantiated3HandCard21a";

                } else if (card.name == "instantiated3Card21b(Clone)") {

                    card.name = "instantiated3HandCard21b";

                } else if (card.name == "instantiated3Card21c(Clone)") {

                    card.name = "instantiated3HandCard21c";

                } else if (card.name == "instantiated3Card22(Clone)") {

                    card.name = "instantiated3HandCard22";

                } else if (card.name == "instantiated3Card22a(Clone)") {

                    card.name = "instantiated3HandCard22a";

                } else if (card.name == "instantiated3Card22b(Clone)") {

                    card.name = "instantiated3HandCard22b";

                } else if (card.name == "instantiated3Card22c(Clone)") {

                    card.name = "instantiated3HandCard22c";

                } else if (card.name == "instantiated3Card23(Clone)") {

                    card.name = "instantiated3HandCard23";

                } else if (card.name == "instantiated3Card23a(Clone)") {

                    card.name = "instantiated3HandCard23a";

                } else if (card.name == "instantiated3Card23b(Clone)") {

                    card.name = "instantiated3HandCard23b";

                } else if (card.name == "instantiated3Card23c(Clone)") {

                    card.name = "instantiated3HandCard23c";

                } else if (card.name == "instantiated3Card24(Clone)") {

                    card.name = "instantiated3HandCard24";

                } else if (card.name == "instantiated3Card24a(Clone)") {

                    card.name = "instantiated3HandCard24a";

                } else if (card.name == "instantiated3Card24b(Clone)") {

                    card.name = "instantiated3HandCard24b";

                } else if (card.name == "instantiated3Card24c(Clone)") {

                    card.name = "instantiated3HandCard24c";

                } else if (card.name == "instantiated3Card25(Clone)") {

                    card.name = "instantiated3HandCard25";

                } else if (card.name == "instantiated3Card25a(Clone)") {

                    card.name = "instantiated3HandCard25a";

                } else if (card.name == "instantiated3Card25b(Clone)") {

                    card.name = "instantiated3HandCard25b";

                } else if (card.name == "instantiated3Card25c(Clone)") {

                    card.name = "instantiated3HandCard25c";

                } else if (card.name == "instantiated3Card26(Clone)") {

                    card.name = "instantiated3HandCard26";

                } else if (card.name == "instantiated3Card26a(Clone)") {

                    card.name = "instantiated3HandCard26a";

                } else if (card.name == "instantiated3Card26b(Clone)") {

                    card.name = "instantiated3HandCard26b";

                } else if (card.name == "instantiated3Card26c(Clone)") {

                    card.name = "instantiated3HandCard26c";

                } else if (card.name == "instantiated3Card27(Clone)") {

                    card.name = "instantiated3HandCard27";

                } else if (card.name == "instantiated3Card27a(Clone)") {

                    card.name = "instantiated3HandCard27a";

                } else if (card.name == "instantiated3Card27b(Clone)") {

                    card.name = "instantiated3HandCard27b";

                } else if (card.name == "instantiated3Card27c(Clone)") {

                    card.name = "instantiated3HandCard27c";

                } else if (card.name == "instantiated3Card28(Clone)") {

                    card.name = "instantiated3HandCard28";

                } else if (card.name == "instantiated3Card28a(Clone)") {

                    card.name = "instantiated3HandCard28a";

                } else if (card.name == "instantiated3Card28b(Clone)") {

                    card.name = "instantiated3HandCard28b";

                } else if (card.name == "instantiated3Card28c(Clone)") {

                    card.name = "instantiated3HandCard28c";

                } else if (card.name == "instantiated3Card29(Clone)") {

                    card.name = "instantiated3HandCard29";

                } else if (card.name == "instantiated3Card29a(Clone)") {

                    card.name = "instantiated3HandCard29a";

                } else if (card.name == "instantiated3Card29b(Clone)") {

                    card.name = "instantiated3HandCard29b";

                } else if (card.name == "instantiated3Card29c(Clone)") {

                    card.name = "instantiated3HandCard29c";

                } else if (card.name == "instantiated3Card30(Clone)") {

                    card.name = "instantiated3HandCard30";

                } else if (card.name == "instantiated3Card30a(Clone)") {

                    card.name = "instantiated3HandCard30a";

                } else if (card.name == "instantiated3Card30b(Clone)") {

                    card.name = "instantiated3HandCard30b";

                } else if (card.name == "instantiated3Card30c(Clone)") {

                    card.name = "instantiated3HandCard30c";

                } else if (card.name == "instantiated3Card31(Clone)") {

                    card.name = "instantiated3HandCard31";

                } else if (card.name == "instantiated3Card31a(Clone)") {

                    card.name = "instantiated3HandCard31a";

                } else if (card.name == "instantiated3Card31b(Clone)") {

                    card.name = "instantiated3HandCard31b";

                } else if (card.name == "instantiated3Card31c(Clone)") {

                    card.name = "instantiated3HandCard31c";

                } else if (card.name == "instantiated3Card32(Clone)") {

                    card.name = "instantiated3HandCard32";

                } else if (card.name == "instantiated3Card32a(Clone)") {

                    card.name = "instantiated3HandCard32a";

                } else if (card.name == "instantiated3Card32b(Clone)") {

                    card.name = "instantiated3HandCard32b";

                } else if (card.name == "instantiated3Card32c(Clone)") {

                    card.name = "instantiated3HandCard32c";

                } else if (card.name == "instantiated3Card33(Clone)") {

                    card.name = "instantiated3HandCard33";

                } else if (card.name == "instantiated3Card33a(Clone)") {

                    card.name = "instantiated3HandCard33a";

                } else if (card.name == "instantiated3Card33b(Clone)") {

                    card.name = "instantiated3HandCard33b";

                } else if (card.name == "instantiated3Card33c(Clone)") {

                    card.name = "instantiated3HandCard33c";

                } else if (card.name == "instantiated3Card34(Clone)") {

                    card.name = "instantiated3HandCard34";

                } else if (card.name == "instantiated3Card34a(Clone)") {

                    card.name = "instantiated3HandCard34a";

                } else if (card.name == "instantiated3Card34b(Clone)") {

                    card.name = "instantiated3HandCard34b";

                } else if (card.name == "instantiated3Card34c(Clone)") {

                    card.name = "instantiated3HandCard34c";

                } else if (card.name == "instantiated3Card35(Clone)") {

                    card.name = "instantiated3HandCard35";

                } else if (card.name == "instantiated3Card35a(Clone)") {

                    card.name = "instantiated3HandCard35a";

                } else if (card.name == "instantiated3Card35b(Clone)") {

                    card.name = "instantiated3HandCard35b";

                } else if (card.name == "instantiated3Card35c(Clone)") {

                    card.name = "instantiated3HandCard35c";

                } else if (card.name == "instantiated3Card36(Clone)") {

                    card.name = "instantiated3HandCard36";

                } else if (card.name == "instantiated3Card36a(Clone)") {

                    card.name = "instantiated3HandCard36a";

                } else if (card.name == "instantiated3Card36b(Clone)") {

                    card.name = "instantiated3HandCard36b";

                } else if (card.name == "instantiated3Card36c(Clone)") {

                    card.name = "instantiated3HandCard36c";

                } else if (card.name == "instantiated3Card37(Clone)") {

                    card.name = "instantiated3HandCard37";

                } else if (card.name == "instantiated3Card37a(Clone)") {

                    card.name = "instantiated3HandCard37a";

                } else if (card.name == "instantiated3Card37b(Clone)") {

                    card.name = "instantiated3HandCard37b";

                } else if (card.name == "instantiated3Card37c(Clone)") {

                    card.name = "instantiated3HandCard37c";

                } else if (card.name == "instantiated3Card38(Clone)") {

                    card.name = "instantiated3HandCard38";

                } else if (card.name == "instantiated3Card38a(Clone)") {

                    card.name = "instantiated3HandCard38a";

                } else if (card.name == "instantiated3Card38b(Clone)") {

                    card.name = "instantiated3HandCard38b";

                } else if (card.name == "instantiated3Card38c(Clone)") {

                    card.name = "instantiated3HandCard38c";

                } else if (card.name == "instantiated3Card39(Clone)") {

                    card.name = "instantiated3HandCard39";

                } else if (card.name == "instantiated3Card39a(Clone)") {

                    card.name = "instantiated3HandCard39a";

                } else if (card.name == "instantiated3Card39b(Clone)") {

                    card.name = "instantiated3HandCard39b";

                } else if (card.name == "instantiated3Card39c(Clone)") {

                    card.name = "instantiated3HandCard39c";

                } else if (card.name == "instantiated3Card40(Clone)") {

                    card.name = "instantiated3HandCard40";

                } else if (card.name == "instantiated3Card40a(Clone)") {

                    card.name = "instantiated3HandCard40a";

                } else if (card.name == "instantiated3Card40b(Clone)") {

                    card.name = "instantiated3HandCard40b";

                } else if (card.name == "instantiated3Card40c(Clone)") {

                    card.name = "instantiated3HandCard40c";

                } else if (card.name == "instantiated3Card41(Clone)") {

                    card.name = "instantiated3HandCard41";

                } else if (card.name == "instantiated3Card41a(Clone)") {

                    card.name = "instantiated3HandCard41a";

                } else if (card.name == "instantiated3Card41b(Clone)") {

                    card.name = "instantiated3HandCard41b";

                } else if (card.name == "instantiated3Card41c(Clone)") {

                    card.name = "instantiated3HandCard41c";

                } else if (card.name == "instantiated3Card42(Clone)") {

                    card.name = "instantiated3HandCard42";

                } else if (card.name == "instantiated3Card42a(Clone)") {

                    card.name = "instantiated3HandCard42a";

                } else if (card.name == "instantiated3Card42b(Clone)") {

                    card.name = "instantiated3HandCard42b";

                } else if (card.name == "instantiated3Card42c(Clone)") {

                    card.name = "instantiated3HandCard42c";

                } else if (card.name == "instantiated3Card43(Clone)") {

                    card.name = "instantiated3HandCard43";

                } else if (card.name == "instantiated3Card43a(Clone)") {

                    card.name = "instantiated3HandCard43a";

                } else if (card.name == "instantiated3Card43b(Clone)") {

                    card.name = "instantiated3HandCard43b";

                } else if (card.name == "instantiated3Card43c(Clone)") {

                    card.name = "instantiated3HandCard43c";

                } else if (card.name == "instantiated3Card44(Clone)") {

                    card.name = "instantiated3HandCard44";

                } else if (card.name == "instantiated3Card44a(Clone)") {

                    card.name = "instantiated3HandCard44a";

                } else if (card.name == "instantiated3Card44b(Clone)") {

                    card.name = "instantiated3HandCard44b";

                } else if (card.name == "instantiated3Card44c(Clone)") {

                    card.name = "instantiated3HandCard44c";

                } else if (card.name == "instantiated3Card45(Clone)") {

                    card.name = "instantiated3HandCard45";

                } else if (card.name == "instantiated3Card45a(Clone)") {

                    card.name = "instantiated3HandCard45a";

                } else if (card.name == "instantiated3Card45b(Clone)") {

                    card.name = "instantiated3HandCard45b";

                } else if (card.name == "instantiated3Card45c(Clone)") {

                    card.name = "instantiated3HandCard45c";

                } else if (card.name == "instantiated3Card46(Clone)") {

                    card.name = "instantiated3HandCard46";

                } else if (card.name == "instantiated3Card46a(Clone)") {

                    card.name = "instantiated3HandCard46a";

                } else if (card.name == "instantiated3Card46b(Clone)") {

                    card.name = "instantiated3HandCard46b";

                } else if (card.name == "instantiated3Card46c(Clone)") {

                    card.name = "instantiated3HandCard46c";

                } else if (card.name == "instantiated3Card47(Clone)") {

                    card.name = "instantiated3HandCard47";

                } else if (card.name == "instantiated3Card47a(Clone)") {

                    card.name = "instantiated3HandCard47a";

                } else if (card.name == "instantiated3Card47b(Clone)") {

                    card.name = "instantiated3HandCard47b";

                } else if (card.name == "instantiated3Card47c(Clone)") {

                    card.name = "instantiated3HandCard47c";

                } else if (card.name == "instantiated3Card48(Clone)") {

                    card.name = "instantiated3HandCard48";

                } else if (card.name == "instantiated3Card48a(Clone)") {

                    card.name = "instantiated3HandCard48a";

                } else if (card.name == "instantiated3Card48b(Clone)") {

                    card.name = "instantiated3HandCard48b";

                } else if (card.name == "instantiated3Card48c(Clone)") {

                    card.name = "instantiated3HandCard48c";

                } else if (card.name == "instantiated3Card49(Clone)") {

                    card.name = "instantiated3HandCard49";

                } else if (card.name == "instantiated3Card49a(Clone)") {

                    card.name = "instantiated3HandCard49a";

                } else if (card.name == "instantiated3Card49b(Clone)") {

                    card.name = "instantiated3HandCard49b";

                } else if (card.name == "instantiated3Card49c(Clone)") {

                    card.name = "instantiated3HandCard49c";

                } else if (card.name == "instantiated3Card50(Clone)") {

                    card.name = "instantiated3HandCard50";

                } else if (card.name == "instantiated3Card50a(Clone)") {

                    card.name = "instantiated3HandCard50a";

                } else if (card.name == "instantiated3Card50b(Clone)") {

                    card.name = "instantiated3HandCard50b";

                } else if (card.name == "instantiated3Card50c(Clone)") {

                    card.name = "instantiated3HandCard50c";

                } else if (card.name == "instantiated3Card51(Clone)") {

                    card.name = "instantiated3HandCard51";

                } else if (card.name == "instantiated3Card51a(Clone)") {

                    card.name = "instantiated3HandCard51a";

                } else if (card.name == "instantiated3Card51b(Clone)") {

                    card.name = "instantiated3HandCard51b";

                } else if (card.name == "instantiated3Card51c(Clone)") {

                    card.name = "instantiated3HandCard51c";

                } else if (card.name == "instantiated3Card52(Clone)") {

                    card.name = "instantiated3HandCard52";

                } else if (card.name == "instantiated3Card52a(Clone)") {

                    card.name = "instantiated3HandCard52a";

                } else if (card.name == "instantiated3Card52b(Clone)") {

                    card.name = "instantiated3HandCard52b";

                } else if (card.name == "instantiated3Card52c(Clone)") {

                    card.name = "instantiated3HandCard52c";

                } else if (card.name == "instantiated3Card53(Clone)") {

                    card.name = "instantiated3HandCard53";

                } else if (card.name == "instantiated3Card53a(Clone)") {

                    card.name = "instantiated3HandCard53a";

                } else if (card.name == "instantiated3Card53b(Clone)") {

                    card.name = "instantiated3HandCard53b";

                } else if (card.name == "instantiated3Card53c(Clone)") {

                    card.name = "instantiated3HandCard53c";

                } else if (card.name == "instantiated3Card54(Clone)") {

                    card.name = "instantiated3HandCard54";

                } else if (card.name == "instantiated3Card54a(Clone)") {

                    card.name = "instantiated3HandCard54a";

                } else if (card.name == "instantiated3Card54b(Clone)") {

                    card.name = "instantiated3HandCard54b";

                } else if (card.name == "instantiated3Card54c(Clone)") {

                    card.name = "instantiated3HandCard54c";

                } else if (card.name == "instantiated3Card55(Clone)") {

                    card.name = "instantiated3HandCard55";

                } else if (card.name == "instantiated3Card55a(Clone)") {

                    card.name = "instantiated3HandCard55a";

                } else if (card.name == "instantiated3Card55b(Clone)") {

                    card.name = "instantiated3HandCard55b";

                } else if (card.name == "instantiated3Card55c(Clone)") {

                    card.name = "instantiated3HandCard55c";

                } else if (card.name == "instantiated3Card56(Clone)") {

                    card.name = "instantiated3HandCard56";

                } else if (card.name == "instantiated3Card56a(Clone)") {

                    card.name = "instantiated3HandCard56a";

                } else if (card.name == "instantiated3Card56b(Clone)") {

                    card.name = "instantiated3HandCard56b";

                } else if (card.name == "instantiated3Card56c(Clone)") {

                    card.name = "instantiated3HandCard56c";

                } else if (card.name == "instantiated3Card57(Clone)") {

                    card.name = "instantiated3HandCard57";

                } else if (card.name == "instantiated3Card57a(Clone)") {

                    card.name = "instantiated3HandCard57a";

                } else if (card.name == "instantiated3Card57b(Clone)") {

                    card.name = "instantiated3HandCard57b";

                } else if (card.name == "instantiated3Card57c(Clone)") {

                    card.name = "instantiated3HandCard57c";

                } else if (card.name == "instantiated3Card58(Clone)") {

                    card.name = "instantiated3HandCard58";

                } else if (card.name == "instantiated3Card58a(Clone)") {

                    card.name = "instantiated3HandCard58a";

                } else if (card.name == "instantiated3Card58b(Clone)") {

                    card.name = "instantiated3HandCard58b";

                } else if (card.name == "instantiated3Card58c(Clone)") {

                    card.name = "instantiated3HandCard58c";

                } else if (card.name == "instantiated3Card59(Clone)") {

                    card.name = "instantiated3HandCard59";

                } else if (card.name == "instantiated3Card59a(Clone)") {

                    card.name = "instantiated3HandCard59a";

                } else if (card.name == "instantiated3Card59b(Clone)") {

                    card.name = "instantiated3HandCard59b";

                } else if (card.name == "instantiated3Card59c(Clone)") {

                    card.name = "instantiated3HandCard59c";

                } else if (card.name == "instantiated3Card60(Clone)") {

                    card.name = "instantiated3HandCard60";

                } else if (card.name == "instantiated3Card60a(Clone)") {

                    card.name = "instantiated3HandCard60a";

                } else if (card.name == "instantiated3Card60b(Clone)") {

                    card.name = "instantiated3HandCard60b";

                } else if (card.name == "instantiated3Card60c(Clone)") {

                    card.name = "instantiated3HandCard60c";
                }

                instances2++;

            }

            while (instances3 < NumberOfCards) {

                GameObject card = Instantiate(playCardsDeck3[UnityEngine.Random.Range(0, playCardsDeck3.Count)], player1DeckSlot3.transform.position, player1DeckSlot3.transform.rotation) as GameObject;
                card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                card.transform.parent = player1DeckSlot3.transform;

                if (card.name == "instantiated3Card1(Clone)") {

                    card.name = "instantiated3HandCard1";

                } else if (card.name == "instantiated3Card1a(Clone)") {

                    card.name = "instantiated3HandCard1a";

                } else if (card.name == "instantiated3Card1b(Clone)") {

                    card.name = "instantiated3HandCard1b";

                } else if (card.name == "instantiated3Card1c(Clone)") {

                    card.name = "instantiated3HandCard1c";

                } else if (card.name == "instantiated3Card2(Clone)") {

                    card.name = "instantiated3HandCard2";

                } else if (card.name == "instantiated3Card2a(Clone)") {

                    card.name = "instantiated3HandCard2a";

                } else if (card.name == "instantiated3Card2b(Clone)") {

                    card.name = "instantiated3HandCard2b";

                } else if (card.name == "instantiated3Card2c(Clone)") {

                    card.name = "instantiated3HandCard2c";

                } else if (card.name == "instantiated3Card3(Clone)") {

                    card.name = "instantiated3HandCard3";

                } else if (card.name == "instantiated3Card3a(Clone)") {

                    card.name = "instantiated3HandCard3a";

                } else if (card.name == "instantiated3Card3b(Clone)") {

                    card.name = "instantiated3HandCard3b";

                } else if (card.name == "instantiated3Card3c(Clone)") {

                    card.name = "instantiated3HandCard3c";

                } else if (card.name == "instantiated3Card4(Clone)") {

                    card.name = "instantiated3HandCard4";

                } else if (card.name == "instantiated3Card4a(Clone)") {

                    card.name = "instantiated3HandCard4a";

                } else if (card.name == "instantiated3Card4b(Clone)") {

                    card.name = "instantiated3HandCard4b";

                } else if (card.name == "instantiated3Card4c(Clone)") {

                    card.name = "instantiated3HandCard4c";

                } else if (card.name == "instantiated3Card5(Clone)") {

                    card.name = "instantiated3HandCard5";

                } else if (card.name == "instantiated3Card5a(Clone)") {

                    card.name = "instantiated3HandCard5a";

                } else if (card.name == "instantiated3Card5b(Clone)") {

                    card.name = "instantiated3HandCard5b";

                } else if (card.name == "instantiated3Card5c(Clone)") {

                    card.name = "instantiated3HandCard5c";

                } else if (card.name == "instantiated3Card6(Clone)") {

                    card.name = "instantiated3HandCard6";

                } else if (card.name == "instantiated3Card6a(Clone)") {

                    card.name = "instantiated3HandCard6a";

                } else if (card.name == "instantiated3Card6b(Clone)") {

                    card.name = "instantiated3HandCard6b";

                } else if (card.name == "instantiated3Card6c(Clone)") {

                    card.name = "instantiated3HandCard6c";

                } else if (card.name == "instantiated3Card7(Clone)") {

                    card.name = "instantiated3HandCard7";

                } else if (card.name == "instantiated3Card7a(Clone)") {

                    card.name = "instantiated3HandCard7a";

                } else if (card.name == "instantiated3Card7b(Clone)") {

                    card.name = "instantiated3HandCard7b";

                } else if (card.name == "instantiated3Card7c(Clone)") {

                    card.name = "instantiated3HandCard7c";

                } else if (card.name == "instantiated3Card8(Clone)") {

                    card.name = "instantiated3HandCard8";

                } else if (card.name == "instantiated3Card8a(Clone)") {

                    card.name = "instantiated3HandCard8a";

                } else if (card.name == "instantiated3Card8b(Clone)") {

                    card.name = "instantiated3HandCard8b";

                } else if (card.name == "instantiated3Card8c(Clone)") {

                    card.name = "instantiated3HandCard8c";

                } else if (card.name == "instantiated3Card9(Clone)") {

                    card.name = "instantiated3HandCard9";

                } else if (card.name == "instantiated3Card9a(Clone)") {

                    card.name = "instantiated3HandCard9a";

                } else if (card.name == "instantiated3Card9b(Clone)") {

                    card.name = "instantiated3HandCard9b";

                } else if (card.name == "instantiated3Card9c(Clone)") {

                    card.name = "instantiated3HandCard9c";

                } else if (card.name == "instantiated3Card10(Clone)") {

                    card.name = "instantiatedAICard10";

                } else if (card.name == "instantiated3Card10a(Clone)") {

                    card.name = "instantiated3HandCard10a";

                } else if (card.name == "instantiated3Card10b(Clone)") {

                    card.name = "instantiated3HandCard10b";

                } else if (card.name == "instantiated3Card10c(Clone)") {

                    card.name = "instantiated3HandCard10c";

                } else if (card.name == "instantiated3Card11(Clone)") {

                    card.name = "instantiated3HandCard11";

                } else if (card.name == "instantiated3Card11a(Clone)") {

                    card.name = "instantiated3HandCard11a";

                } else if (card.name == "instantiated3Card11b(Clone)") {

                    card.name = "instantiated3HandCard11b";

                } else if (card.name == "instantiated3Card11c(Clone)") {

                    card.name = "instantiated3HandCard11c";

                } else if (card.name == "instantiated3Card12(Clone)") {

                    card.name = "instantiated3HandCard12";

                } else if (card.name == "instantiated3Card12a(Clone)") {

                    card.name = "instantiated3HandCard12a";

                } else if (card.name == "instantiated3Card12b(Clone)") {

                    card.name = "instantiated3HandCard12b";

                } else if (card.name == "instantiated3Card12c(Clone)") {

                    card.name = "instantiated3HandCard12c";

                } else if (card.name == "instantiated3Card13(Clone)") {

                    card.name = "instantiated3HandCard13";

                } else if (card.name == "instantiated3Card13a(Clone)") {

                    card.name = "instantiated3HandCard13a";

                } else if (card.name == "instantiated3Card13b(Clone)") {

                    card.name = "instantiated3HandCard13b";

                } else if (card.name == "instantiated3Card13c(Clone)") {

                    card.name = "instantiated3HandCard13c";

                } else if (card.name == "instantiated3Card14(Clone)") {

                    card.name = "instantiated3HandCard14";

                } else if (card.name == "instantiated3Card14a(Clone)") {

                    card.name = "instantiated3HandCard14a";

                } else if (card.name == "instantiated3Card14b(Clone)") {

                    card.name = "instantiated3HandCard14b";

                } else if (card.name == "instantiated3Card14c(Clone)") {

                    card.name = "instantiated3HandCard14c";

                } else if (card.name == "instantiated3Card15(Clone)") {

                    card.name = "instantiated3HandCard15";

                } else if (card.name == "instantiated3Card15a(Clone)") {

                    card.name = "instantiated3HandCard15a";

                } else if (card.name == "instantiated3Card15b(Clone)") {

                    card.name = "instantiated3HandCard15b";

                } else if (card.name == "instantiated3Card15c(Clone)") {

                    card.name = "instantiated3HandCard15c";

                } else if (card.name == "instantiated3Card16(Clone)") {

                    card.name = "instantiated3HandCard16";

                } else if (card.name == "instantiated3Card16a(Clone)") {

                    card.name = "instantiated3HandCard16a";

                } else if (card.name == "instantiated3Card16b(Clone)") {

                    card.name = "instantiated3HandCard16b";

                } else if (card.name == "instantiated3Card16c(Clone)") {

                    card.name = "instantiated3HandCard16c";

                } else if (card.name == "instantiated3Card17(Clone)") {

                    card.name = "instantiated3HandCard17";

                } else if (card.name == "instantiated3Card17a(Clone)") {

                    card.name = "instantiated3HandCard17a";

                } else if (card.name == "instantiated3Card17b(Clone)") {

                    card.name = "instantiated3HandCard17b";

                } else if (card.name == "instantiated3Card17c(Clone)") {

                    card.name = "instantiated3HandCard17c";

                } else if (card.name == "instantiated3Card18(Clone)") {

                    card.name = "instantiated3HandCard18";

                } else if (card.name == "instantiated3Card18a(Clone)") {

                    card.name = "instantiated3HandCard18a";

                } else if (card.name == "instantiated3Card18b(Clone)") {

                    card.name = "instantiated3HandCard18b";

                } else if (card.name == "instantiated3Card18c(Clone)") {

                    card.name = "instantiated3HandCard18c";

                } else if (card.name == "instantiated3Card19(Clone)") {

                    card.name = "instantiated3HandCard19";

                } else if (card.name == "instantiated3Card19a(Clone)") {

                    card.name = "instantiated3HandCard19a";

                } else if (card.name == "instantiated3Card19b(Clone)") {

                    card.name = "instantiated3HandCard19b";

                } else if (card.name == "instantiated3Card19c(Clone)") {

                    card.name = "instantiated3HandCard19c";

                } else if (card.name == "instantiated3Card20(Clone)") {

                    card.name = "instantiated3HandCard20";

                } else if (card.name == "instantiated3Card20a(Clone)") {

                    card.name = "instantiated3HandCard20a";

                } else if (card.name == "instantiated3Card20b(Clone)") {

                    card.name = "instantiated3HandCard20b";

                } else if (card.name == "instantiated3Card20c(Clone)") {

                    card.name = "instantiated3HandCard20c";

                } else if (card.name == "instantiated3Card21(Clone)") {

                    card.name = "instantiated3HandCard21";

                } else if (card.name == "instantiated3Card21a(Clone)") {

                    card.name = "instantiated3HandCard21a";

                } else if (card.name == "instantiated3Card21b(Clone)") {

                    card.name = "instantiated3HandCard21b";

                } else if (card.name == "instantiated3Card21c(Clone)") {

                    card.name = "instantiated3HandCard21c";

                } else if (card.name == "instantiated3Card22(Clone)") {

                    card.name = "instantiated3HandCard22";

                } else if (card.name == "instantiated3Card22a(Clone)") {

                    card.name = "instantiated3HandCard22a";

                } else if (card.name == "instantiated3Card22b(Clone)") {

                    card.name = "instantiated3HandCard22b";

                } else if (card.name == "instantiated3Card22c(Clone)") {

                    card.name = "instantiated3HandCard22c";

                } else if (card.name == "instantiated3Card23(Clone)") {

                    card.name = "instantiated3HandCard23";

                } else if (card.name == "instantiated3Card23a(Clone)") {

                    card.name = "instantiated3HandCard23a";

                } else if (card.name == "instantiated3Card23b(Clone)") {

                    card.name = "instantiated3HandCard23b";

                } else if (card.name == "instantiated3Card23c(Clone)") {

                    card.name = "instantiated3HandCard23c";

                } else if (card.name == "instantiated3Card24(Clone)") {

                    card.name = "instantiated3HandCard24";

                } else if (card.name == "instantiated3Card24a(Clone)") {

                    card.name = "instantiated3HandCard24a";

                } else if (card.name == "instantiated3Card24b(Clone)") {

                    card.name = "instantiated3HandCard24b";

                } else if (card.name == "instantiated3Card24c(Clone)") {

                    card.name = "instantiated3HandCard24c";

                } else if (card.name == "instantiated3Card25(Clone)") {

                    card.name = "instantiated3HandCard25";

                } else if (card.name == "instantiated3Card25a(Clone)") {

                    card.name = "instantiated3HandCard25a";

                } else if (card.name == "instantiated3Card25b(Clone)") {

                    card.name = "instantiated3HandCard25b";

                } else if (card.name == "instantiated3Card25c(Clone)") {

                    card.name = "instantiated3HandCard25c";

                } else if (card.name == "instantiated3Card26(Clone)") {

                    card.name = "instantiated3HandCard26";

                } else if (card.name == "instantiated3Card26a(Clone)") {

                    card.name = "instantiated3HandCard26a";

                } else if (card.name == "instantiated3Card26b(Clone)") {

                    card.name = "instantiated3HandCard26b";

                } else if (card.name == "instantiated3Card26c(Clone)") {

                    card.name = "instantiated3HandCard26c";

                } else if (card.name == "instantiated3Card27(Clone)") {

                    card.name = "instantiated3HandCard27";

                } else if (card.name == "instantiated3Card27a(Clone)") {

                    card.name = "instantiated3HandCard27a";

                } else if (card.name == "instantiated3Card27b(Clone)") {

                    card.name = "instantiated3HandCard27b";

                } else if (card.name == "instantiated3Card27c(Clone)") {

                    card.name = "instantiated3HandCard27c";

                } else if (card.name == "instantiated3Card28(Clone)") {

                    card.name = "instantiated3HandCard28";

                } else if (card.name == "instantiated3Card28a(Clone)") {

                    card.name = "instantiated3HandCard28a";

                } else if (card.name == "instantiated3Card28b(Clone)") {

                    card.name = "instantiated3HandCard28b";

                } else if (card.name == "instantiated3Card28c(Clone)") {

                    card.name = "instantiated3HandCard28c";

                } else if (card.name == "instantiated3Card29(Clone)") {

                    card.name = "instantiated3HandCard29";

                } else if (card.name == "instantiated3Card29a(Clone)") {

                    card.name = "instantiated3HandCard29a";

                } else if (card.name == "instantiated3Card29b(Clone)") {

                    card.name = "instantiated3HandCard29b";

                } else if (card.name == "instantiated3Card29c(Clone)") {

                    card.name = "instantiated3HandCard29c";

                } else if (card.name == "instantiated3Card30(Clone)") {

                    card.name = "instantiated3HandCard30";

                } else if (card.name == "instantiated3Card30a(Clone)") {

                    card.name = "instantiated3HandCard30a";

                } else if (card.name == "instantiated3Card30b(Clone)") {

                    card.name = "instantiated3HandCard30b";

                } else if (card.name == "instantiated3Card30c(Clone)") {

                    card.name = "instantiated3HandCard30c";

                } else if (card.name == "instantiated3Card31(Clone)") {

                    card.name = "instantiated3HandCard31";

                } else if (card.name == "instantiated3Card31a(Clone)") {

                    card.name = "instantiated3HandCard31a";

                } else if (card.name == "instantiated3Card31b(Clone)") {

                    card.name = "instantiated3HandCard31b";

                } else if (card.name == "instantiated3Card31c(Clone)") {

                    card.name = "instantiated3HandCard31c";

                } else if (card.name == "instantiated3Card32(Clone)") {

                    card.name = "instantiated3HandCard32";

                } else if (card.name == "instantiated3Card32a(Clone)") {

                    card.name = "instantiated3HandCard32a";

                } else if (card.name == "instantiated3Card32b(Clone)") {

                    card.name = "instantiated3HandCard32b";

                } else if (card.name == "instantiated3Card32c(Clone)") {

                    card.name = "instantiated3HandCard32c";

                } else if (card.name == "instantiated3Card33(Clone)") {

                    card.name = "instantiated3HandCard33";

                } else if (card.name == "instantiated3Card33a(Clone)") {

                    card.name = "instantiated3HandCard33a";

                } else if (card.name == "instantiated3Card33b(Clone)") {

                    card.name = "instantiated3HandCard33b";

                } else if (card.name == "instantiated3Card33c(Clone)") {

                    card.name = "instantiated3HandCard33c";

                } else if (card.name == "instantiated3Card34(Clone)") {

                    card.name = "instantiated3HandCard34";

                } else if (card.name == "instantiated3Card34a(Clone)") {

                    card.name = "instantiated3HandCard34a";

                } else if (card.name == "instantiated3Card34b(Clone)") {

                    card.name = "instantiated3HandCard34b";

                } else if (card.name == "instantiated3Card34c(Clone)") {

                    card.name = "instantiated3HandCard34c";

                } else if (card.name == "instantiated3Card35(Clone)") {

                    card.name = "instantiated3HandCard35";

                } else if (card.name == "instantiated3Card35a(Clone)") {

                    card.name = "instantiated3HandCard35a";

                } else if (card.name == "instantiated3Card35b(Clone)") {

                    card.name = "instantiated3HandCard35b";

                } else if (card.name == "instantiated3Card35c(Clone)") {

                    card.name = "instantiated3HandCard35c";

                } else if (card.name == "instantiated3Card36(Clone)") {

                    card.name = "instantiated3HandCard36";

                } else if (card.name == "instantiated3Card36a(Clone)") {

                    card.name = "instantiated3HandCard36a";

                } else if (card.name == "instantiated3Card36b(Clone)") {

                    card.name = "instantiated3HandCard36b";

                } else if (card.name == "instantiated3Card36c(Clone)") {

                    card.name = "instantiated3HandCard36c";

                } else if (card.name == "instantiated3Card37(Clone)") {

                    card.name = "instantiated3HandCard37";

                } else if (card.name == "instantiated3Card37a(Clone)") {

                    card.name = "instantiated3HandCard37a";

                } else if (card.name == "instantiated3Card37b(Clone)") {

                    card.name = "instantiated3HandCard37b";

                } else if (card.name == "instantiated3Card37c(Clone)") {

                    card.name = "instantiated3HandCard37c";

                } else if (card.name == "instantiated3Card38(Clone)") {

                    card.name = "instantiated3HandCard38";

                } else if (card.name == "instantiated3Card38a(Clone)") {

                    card.name = "instantiated3HandCard38a";

                } else if (card.name == "instantiated3Card38b(Clone)") {

                    card.name = "instantiated3HandCard38b";

                } else if (card.name == "instantiated3Card38c(Clone)") {

                    card.name = "instantiated3HandCard38c";

                } else if (card.name == "instantiated3Card39(Clone)") {

                    card.name = "instantiated3HandCard39";

                } else if (card.name == "instantiated3Card39a(Clone)") {

                    card.name = "instantiated3HandCard39a";

                } else if (card.name == "instantiated3Card39b(Clone)") {

                    card.name = "instantiated3HandCard39b";

                } else if (card.name == "instantiated3Card39c(Clone)") {

                    card.name = "instantiated3HandCard39c";

                } else if (card.name == "instantiated3Card40(Clone)") {

                    card.name = "instantiated3HandCard40";

                } else if (card.name == "instantiated3Card40a(Clone)") {

                    card.name = "instantiated3HandCard40a";

                } else if (card.name == "instantiated3Card40b(Clone)") {

                    card.name = "instantiated3HandCard40b";

                } else if (card.name == "instantiated3Card40c(Clone)") {

                    card.name = "instantiated3HandCard40c";

                } else if (card.name == "instantiated3Card41(Clone)") {

                    card.name = "instantiated3HandCard41";

                } else if (card.name == "instantiated3Card41a(Clone)") {

                    card.name = "instantiated3HandCard41a";

                } else if (card.name == "instantiated3Card41b(Clone)") {

                    card.name = "instantiated3HandCard41b";

                } else if (card.name == "instantiated3Card41c(Clone)") {

                    card.name = "instantiated3HandCard41c";

                } else if (card.name == "instantiated3Card42(Clone)") {

                    card.name = "instantiated3HandCard42";

                } else if (card.name == "instantiated3Card42a(Clone)") {

                    card.name = "instantiated3HandCard42a";

                } else if (card.name == "instantiated3Card42b(Clone)") {

                    card.name = "instantiated3HandCard42b";

                } else if (card.name == "instantiated3Card42c(Clone)") {

                    card.name = "instantiated3HandCard42c";

                } else if (card.name == "instantiated3Card43(Clone)") {

                    card.name = "instantiated3HandCard43";

                } else if (card.name == "instantiated3Card43a(Clone)") {

                    card.name = "instantiated3HandCard43a";

                } else if (card.name == "instantiated3Card43b(Clone)") {

                    card.name = "instantiated3HandCard43b";

                } else if (card.name == "instantiated3Card43c(Clone)") {

                    card.name = "instantiated3HandCard43c";

                } else if (card.name == "instantiated3Card44(Clone)") {

                    card.name = "instantiated3HandCard44";

                } else if (card.name == "instantiated3Card44a(Clone)") {

                    card.name = "instantiated3HandCard44a";

                } else if (card.name == "instantiated3Card44b(Clone)") {

                    card.name = "instantiated3HandCard44b";

                } else if (card.name == "instantiated3Card44c(Clone)") {

                    card.name = "instantiated3HandCard44c";

                } else if (card.name == "instantiated3Card45(Clone)") {

                    card.name = "instantiated3HandCard45";

                } else if (card.name == "instantiated3Card45a(Clone)") {

                    card.name = "instantiated3HandCard45a";

                } else if (card.name == "instantiated3Card45b(Clone)") {

                    card.name = "instantiated3HandCard45b";

                } else if (card.name == "instantiated3Card45c(Clone)") {

                    card.name = "instantiated3HandCard45c";

                } else if (card.name == "instantiated3Card46(Clone)") {

                    card.name = "instantiated3HandCard46";

                } else if (card.name == "instantiated3Card46a(Clone)") {

                    card.name = "instantiated3HandCard46a";

                } else if (card.name == "instantiated3Card46b(Clone)") {

                    card.name = "instantiated3HandCard46b";

                } else if (card.name == "instantiated3Card46c(Clone)") {

                    card.name = "instantiated3HandCard46c";

                } else if (card.name == "instantiated3Card47(Clone)") {

                    card.name = "instantiated3HandCard47";

                } else if (card.name == "instantiated3Card47a(Clone)") {

                    card.name = "instantiated3HandCard47a";

                } else if (card.name == "instantiated3Card47b(Clone)") {

                    card.name = "instantiated3HandCard47b";

                } else if (card.name == "instantiated3Card47c(Clone)") {

                    card.name = "instantiated3HandCard47c";

                } else if (card.name == "instantiated3Card48(Clone)") {

                    card.name = "instantiated3HandCard48";

                } else if (card.name == "instantiated3Card48a(Clone)") {

                    card.name = "instantiated3HandCard48a";

                } else if (card.name == "instantiated3Card48b(Clone)") {

                    card.name = "instantiated3HandCard48b";

                } else if (card.name == "instantiated3Card48c(Clone)") {

                    card.name = "instantiated3HandCard48c";

                } else if (card.name == "instantiated3Card49(Clone)") {

                    card.name = "instantiated3HandCard49";

                } else if (card.name == "instantiated3Card49a(Clone)") {

                    card.name = "instantiated3HandCard49a";

                } else if (card.name == "instantiated3Card49b(Clone)") {

                    card.name = "instantiated3HandCard49b";

                } else if (card.name == "instantiated3Card49c(Clone)") {

                    card.name = "instantiated3HandCard49c";

                } else if (card.name == "instantiated3Card50(Clone)") {

                    card.name = "instantiated3HandCard50";

                } else if (card.name == "instantiated3Card50a(Clone)") {

                    card.name = "instantiated3HandCard50a";

                } else if (card.name == "instantiated3Card50b(Clone)") {

                    card.name = "instantiated3HandCard50b";

                } else if (card.name == "instantiated3Card50c(Clone)") {

                    card.name = "instantiated3HandCard50c";

                } else if (card.name == "instantiated3Card51(Clone)") {

                    card.name = "instantiated3HandCard51";

                } else if (card.name == "instantiated3Card51a(Clone)") {

                    card.name = "instantiated3HandCard51a";

                } else if (card.name == "instantiated3Card51b(Clone)") {

                    card.name = "instantiated3HandCard51b";

                } else if (card.name == "instantiated3Card51c(Clone)") {

                    card.name = "instantiated3HandCard51c";

                } else if (card.name == "instantiated3Card52(Clone)") {

                    card.name = "instantiated3HandCard52";

                } else if (card.name == "instantiated3Card52a(Clone)") {

                    card.name = "instantiated3HandCard52a";

                } else if (card.name == "instantiated3Card52b(Clone)") {

                    card.name = "instantiated3HandCard52b";

                } else if (card.name == "instantiated3Card52c(Clone)") {

                    card.name = "instantiated3HandCard52c";

                } else if (card.name == "instantiated3Card53(Clone)") {

                    card.name = "instantiated3HandCard53";

                } else if (card.name == "instantiated3Card53a(Clone)") {

                    card.name = "instantiated3HandCard53a";

                } else if (card.name == "instantiated3Card53b(Clone)") {

                    card.name = "instantiated3HandCard53b";

                } else if (card.name == "instantiated3Card53c(Clone)") {

                    card.name = "instantiated3HandCard53c";

                } else if (card.name == "instantiated3Card54(Clone)") {

                    card.name = "instantiated3HandCard54";

                } else if (card.name == "instantiated3Card54a(Clone)") {

                    card.name = "instantiated3HandCard54a";

                } else if (card.name == "instantiated3Card54b(Clone)") {

                    card.name = "instantiated3HandCard54b";

                } else if (card.name == "instantiated3Card54c(Clone)") {

                    card.name = "instantiated3HandCard54c";

                } else if (card.name == "instantiated3Card55(Clone)") {

                    card.name = "instantiated3HandCard55";

                } else if (card.name == "instantiated3Card55a(Clone)") {

                    card.name = "instantiated3HandCard55a";

                } else if (card.name == "instantiated3Card55b(Clone)") {

                    card.name = "instantiated3HandCard55b";

                } else if (card.name == "instantiated3Card55c(Clone)") {

                    card.name = "instantiated3HandCard55c";

                } else if (card.name == "instantiated3Card56(Clone)") {

                    card.name = "instantiated3HandCard56";

                } else if (card.name == "instantiated3Card56a(Clone)") {

                    card.name = "instantiated3HandCard56a";

                } else if (card.name == "instantiated3Card56b(Clone)") {

                    card.name = "instantiated3HandCard56b";

                } else if (card.name == "instantiated3Card56c(Clone)") {

                    card.name = "instantiated3HandCard56c";

                } else if (card.name == "instantiated3Card57(Clone)") {

                    card.name = "instantiated3HandCard57";

                } else if (card.name == "instantiated3Card57a(Clone)") {

                    card.name = "instantiated3HandCard57a";

                } else if (card.name == "instantiated3Card57b(Clone)") {

                    card.name = "instantiated3HandCard57b";

                } else if (card.name == "instantiated3Card57c(Clone)") {

                    card.name = "instantiated3HandCard57c";

                } else if (card.name == "instantiated3Card58(Clone)") {

                    card.name = "instantiated3HandCard58";

                } else if (card.name == "instantiated3Card58a(Clone)") {

                    card.name = "instantiated3HandCard58a";

                } else if (card.name == "instantiated3Card58b(Clone)") {

                    card.name = "instantiated3HandCard58b";

                } else if (card.name == "instantiated3Card58c(Clone)") {

                    card.name = "instantiated3HandCard58c";

                } else if (card.name == "instantiated3Card59(Clone)") {

                    card.name = "instantiated3HandCard59";

                } else if (card.name == "instantiated3Card59a(Clone)") {

                    card.name = "instantiated3HandCard59a";

                } else if (card.name == "instantiated3Card59b(Clone)") {

                    card.name = "instantiated3HandCard59b";

                } else if (card.name == "instantiated3Card59c(Clone)") {

                    card.name = "instantiated3HandCard59c";

                } else if (card.name == "instantiated3Card60(Clone)") {

                    card.name = "instantiated3HandCard60";

                } else if (card.name == "instantiated3Card60a(Clone)") {

                    card.name = "instantiated3HandCard60a";

                } else if (card.name == "instantiated3Card60b(Clone)") {

                    card.name = "instantiated3HandCard60b";

                } else if (card.name == "instantiated3Card60c(Clone)") {

                    card.name = "instantiated3HandCard60c";
                }

                instances3++;

            }


            while (instances4 < NumberOfCards) {

                GameObject card = Instantiate(playCardsDeck3[UnityEngine.Random.Range(0, playCardsDeck3.Count)], player1DeckSlot4.transform.position, player1DeckSlot4.transform.rotation) as GameObject;
                card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                card.transform.parent = player1DeckSlot4.transform;

                if (card.name == "instantiated3Card1(Clone)") {

                    card.name = "instantiated3HandCard1";

                } else if (card.name == "instantiated3Card1a(Clone)") {

                    card.name = "instantiated3HandCard1a";

                } else if (card.name == "instantiated3Card1b(Clone)") {

                    card.name = "instantiated3HandCard1b";

                } else if (card.name == "instantiated3Card1c(Clone)") {

                    card.name = "instantiated3HandCard1c";

                } else if (card.name == "instantiated3Card2(Clone)") {

                    card.name = "instantiated3HandCard2";

                } else if (card.name == "instantiated3Card2a(Clone)") {

                    card.name = "instantiated3HandCard2a";

                } else if (card.name == "instantiated3Card2b(Clone)") {

                    card.name = "instantiated3HandCard2b";

                } else if (card.name == "instantiated3Card2c(Clone)") {

                    card.name = "instantiated3HandCard2c";

                } else if (card.name == "instantiated3Card3(Clone)") {

                    card.name = "instantiated3HandCard3";

                } else if (card.name == "instantiated3Card3a(Clone)") {

                    card.name = "instantiated3HandCard3a";

                } else if (card.name == "instantiated3Card3b(Clone)") {

                    card.name = "instantiated3HandCard3b";

                } else if (card.name == "instantiated3Card3c(Clone)") {

                    card.name = "instantiated3HandCard3c";

                } else if (card.name == "instantiated3Card4(Clone)") {

                    card.name = "instantiated3HandCard4";

                } else if (card.name == "instantiated3Card4a(Clone)") {

                    card.name = "instantiated3HandCard4a";

                } else if (card.name == "instantiated3Card4b(Clone)") {

                    card.name = "instantiated3HandCard4b";

                } else if (card.name == "instantiated3Card4c(Clone)") {

                    card.name = "instantiated3HandCard4c";

                } else if (card.name == "instantiated3Card5(Clone)") {

                    card.name = "instantiated3HandCard5";

                } else if (card.name == "instantiated3Card5a(Clone)") {

                    card.name = "instantiated3HandCard5a";

                } else if (card.name == "instantiated3Card5b(Clone)") {

                    card.name = "instantiated3HandCard5b";

                } else if (card.name == "instantiated3Card5c(Clone)") {

                    card.name = "instantiated3HandCard5c";

                } else if (card.name == "instantiated3Card6(Clone)") {

                    card.name = "instantiated3HandCard6";

                } else if (card.name == "instantiated3Card6a(Clone)") {

                    card.name = "instantiated3HandCard6a";

                } else if (card.name == "instantiated3Card6b(Clone)") {

                    card.name = "instantiated3HandCard6b";

                } else if (card.name == "instantiated3Card6c(Clone)") {

                    card.name = "instantiated3HandCard6c";

                } else if (card.name == "instantiated3Card7(Clone)") {

                    card.name = "instantiated3HandCard7";

                } else if (card.name == "instantiated3Card7a(Clone)") {

                    card.name = "instantiated3HandCard7a";

                } else if (card.name == "instantiated3Card7b(Clone)") {

                    card.name = "instantiated3HandCard7b";

                } else if (card.name == "instantiated3Card7c(Clone)") {

                    card.name = "instantiated3HandCard7c";

                } else if (card.name == "instantiated3Card8(Clone)") {

                    card.name = "instantiated3HandCard8";

                } else if (card.name == "instantiated3Card8a(Clone)") {

                    card.name = "instantiated3HandCard8a";

                } else if (card.name == "instantiated3Card8b(Clone)") {

                    card.name = "instantiated3HandCard8b";

                } else if (card.name == "instantiated3Card8c(Clone)") {

                    card.name = "instantiated3HandCard8c";

                } else if (card.name == "instantiated3Card9(Clone)") {

                    card.name = "instantiated3HandCard9";

                } else if (card.name == "instantiated3Card9a(Clone)") {

                    card.name = "instantiated3HandCard9a";

                } else if (card.name == "instantiated3Card9b(Clone)") {

                    card.name = "instantiated3HandCard9b";

                } else if (card.name == "instantiated3Card9c(Clone)") {

                    card.name = "instantiated3HandCard9c";

                } else if (card.name == "instantiated3Card10(Clone)") {

                    card.name = "instantiatedAICard10";

                } else if (card.name == "instantiated3Card10a(Clone)") {

                    card.name = "instantiated3HandCard10a";

                } else if (card.name == "instantiated3Card10b(Clone)") {

                    card.name = "instantiated3HandCard10b";

                } else if (card.name == "instantiated3Card10c(Clone)") {

                    card.name = "instantiated3HandCard10c";

                } else if (card.name == "instantiated3Card11(Clone)") {

                    card.name = "instantiated3HandCard11";

                } else if (card.name == "instantiated3Card11a(Clone)") {

                    card.name = "instantiated3HandCard11a";

                } else if (card.name == "instantiated3Card11b(Clone)") {

                    card.name = "instantiated3HandCard11b";

                } else if (card.name == "instantiated3Card11c(Clone)") {

                    card.name = "instantiated3HandCard11c";

                } else if (card.name == "instantiated3Card12(Clone)") {

                    card.name = "instantiated3HandCard12";

                } else if (card.name == "instantiated3Card12a(Clone)") {

                    card.name = "instantiated3HandCard12a";

                } else if (card.name == "instantiated3Card12b(Clone)") {

                    card.name = "instantiated3HandCard12b";

                } else if (card.name == "instantiated3Card12c(Clone)") {

                    card.name = "instantiated3HandCard12c";

                } else if (card.name == "instantiated3Card13(Clone)") {

                    card.name = "instantiated3HandCard13";

                } else if (card.name == "instantiated3Card13a(Clone)") {

                    card.name = "instantiated3HandCard13a";

                } else if (card.name == "instantiated3Card13b(Clone)") {

                    card.name = "instantiated3HandCard13b";

                } else if (card.name == "instantiated3Card13c(Clone)") {

                    card.name = "instantiated3HandCard13c";

                } else if (card.name == "instantiated3Card14(Clone)") {

                    card.name = "instantiated3HandCard14";

                } else if (card.name == "instantiated3Card14a(Clone)") {

                    card.name = "instantiated3HandCard14a";

                } else if (card.name == "instantiated3Card14b(Clone)") {

                    card.name = "instantiated3HandCard14b";

                } else if (card.name == "instantiated3Card14c(Clone)") {

                    card.name = "instantiated3HandCard14c";

                } else if (card.name == "instantiated3Card15(Clone)") {

                    card.name = "instantiated3HandCard15";

                } else if (card.name == "instantiated3Card15a(Clone)") {

                    card.name = "instantiated3HandCard15a";

                } else if (card.name == "instantiated3Card15b(Clone)") {

                    card.name = "instantiated3HandCard15b";

                } else if (card.name == "instantiated3Card15c(Clone)") {

                    card.name = "instantiated3HandCard15c";

                } else if (card.name == "instantiated3Card16(Clone)") {

                    card.name = "instantiated3HandCard16";

                } else if (card.name == "instantiated3Card16a(Clone)") {

                    card.name = "instantiated3HandCard16a";

                } else if (card.name == "instantiated3Card16b(Clone)") {

                    card.name = "instantiated3HandCard16b";

                } else if (card.name == "instantiated3Card16c(Clone)") {

                    card.name = "instantiated3HandCard16c";

                } else if (card.name == "instantiated3Card17(Clone)") {

                    card.name = "instantiated3HandCard17";

                } else if (card.name == "instantiated3Card17a(Clone)") {

                    card.name = "instantiated3HandCard17a";

                } else if (card.name == "instantiated3Card17b(Clone)") {

                    card.name = "instantiated3HandCard17b";

                } else if (card.name == "instantiated3Card17c(Clone)") {

                    card.name = "instantiated3HandCard17c";

                } else if (card.name == "instantiated3Card18(Clone)") {

                    card.name = "instantiated3HandCard18";

                } else if (card.name == "instantiated3Card18a(Clone)") {

                    card.name = "instantiated3HandCard18a";

                } else if (card.name == "instantiated3Card18b(Clone)") {

                    card.name = "instantiated3HandCard18b";

                } else if (card.name == "instantiated3Card18c(Clone)") {

                    card.name = "instantiated3HandCard18c";

                } else if (card.name == "instantiated3Card19(Clone)") {

                    card.name = "instantiated3HandCard19";

                } else if (card.name == "instantiated3Card19a(Clone)") {

                    card.name = "instantiated3HandCard19a";

                } else if (card.name == "instantiated3Card19b(Clone)") {

                    card.name = "instantiated3HandCard19b";

                } else if (card.name == "instantiated3Card19c(Clone)") {

                    card.name = "instantiated3HandCard19c";

                } else if (card.name == "instantiated3Card20(Clone)") {

                    card.name = "instantiated3HandCard20";

                } else if (card.name == "instantiated3Card20a(Clone)") {

                    card.name = "instantiated3HandCard20a";

                } else if (card.name == "instantiated3Card20b(Clone)") {

                    card.name = "instantiated3HandCard20b";

                } else if (card.name == "instantiated3Card20c(Clone)") {

                    card.name = "instantiated3HandCard20c";

                } else if (card.name == "instantiated3Card21(Clone)") {

                    card.name = "instantiated3HandCard21";

                } else if (card.name == "instantiated3Card21a(Clone)") {

                    card.name = "instantiated3HandCard21a";

                } else if (card.name == "instantiated3Card21b(Clone)") {

                    card.name = "instantiated3HandCard21b";

                } else if (card.name == "instantiated3Card21c(Clone)") {

                    card.name = "instantiated3HandCard21c";

                } else if (card.name == "instantiated3Card22(Clone)") {

                    card.name = "instantiated3HandCard22";

                } else if (card.name == "instantiated3Card22a(Clone)") {

                    card.name = "instantiated3HandCard22a";

                } else if (card.name == "instantiated3Card22b(Clone)") {

                    card.name = "instantiated3HandCard22b";

                } else if (card.name == "instantiated3Card22c(Clone)") {

                    card.name = "instantiated3HandCard22c";

                } else if (card.name == "instantiated3Card23(Clone)") {

                    card.name = "instantiated3HandCard23";

                } else if (card.name == "instantiated3Card23a(Clone)") {

                    card.name = "instantiated3HandCard23a";

                } else if (card.name == "instantiated3Card23b(Clone)") {

                    card.name = "instantiated3HandCard23b";

                } else if (card.name == "instantiated3Card23c(Clone)") {

                    card.name = "instantiated3HandCard23c";

                } else if (card.name == "instantiated3Card24(Clone)") {

                    card.name = "instantiated3HandCard24";

                } else if (card.name == "instantiated3Card24a(Clone)") {

                    card.name = "instantiated3HandCard24a";

                } else if (card.name == "instantiated3Card24b(Clone)") {

                    card.name = "instantiated3HandCard24b";

                } else if (card.name == "instantiated3Card24c(Clone)") {

                    card.name = "instantiated3HandCard24c";

                } else if (card.name == "instantiated3Card25(Clone)") {

                    card.name = "instantiated3HandCard25";

                } else if (card.name == "instantiated3Card25a(Clone)") {

                    card.name = "instantiated3HandCard25a";

                } else if (card.name == "instantiated3Card25b(Clone)") {

                    card.name = "instantiated3HandCard25b";

                } else if (card.name == "instantiated3Card25c(Clone)") {

                    card.name = "instantiated3HandCard25c";

                } else if (card.name == "instantiated3Card26(Clone)") {

                    card.name = "instantiated3HandCard26";

                } else if (card.name == "instantiated3Card26a(Clone)") {

                    card.name = "instantiated3HandCard26a";

                } else if (card.name == "instantiated3Card26b(Clone)") {

                    card.name = "instantiated3HandCard26b";

                } else if (card.name == "instantiated3Card26c(Clone)") {

                    card.name = "instantiated3HandCard26c";

                } else if (card.name == "instantiated3Card27(Clone)") {

                    card.name = "instantiated3HandCard27";

                } else if (card.name == "instantiated3Card27a(Clone)") {

                    card.name = "instantiated3HandCard27a";

                } else if (card.name == "instantiated3Card27b(Clone)") {

                    card.name = "instantiated3HandCard27b";

                } else if (card.name == "instantiated3Card27c(Clone)") {

                    card.name = "instantiated3HandCard27c";

                } else if (card.name == "instantiated3Card28(Clone)") {

                    card.name = "instantiated3HandCard28";

                } else if (card.name == "instantiated3Card28a(Clone)") {

                    card.name = "instantiated3HandCard28a";

                } else if (card.name == "instantiated3Card28b(Clone)") {

                    card.name = "instantiated3HandCard28b";

                } else if (card.name == "instantiated3Card28c(Clone)") {

                    card.name = "instantiated3HandCard28c";

                } else if (card.name == "instantiated3Card29(Clone)") {

                    card.name = "instantiated3HandCard29";

                } else if (card.name == "instantiated3Card29a(Clone)") {

                    card.name = "instantiated3HandCard29a";

                } else if (card.name == "instantiated3Card29b(Clone)") {

                    card.name = "instantiated3HandCard29b";

                } else if (card.name == "instantiated3Card29c(Clone)") {

                    card.name = "instantiated3HandCard29c";

                } else if (card.name == "instantiated3Card30(Clone)") {

                    card.name = "instantiated3HandCard30";

                } else if (card.name == "instantiated3Card30a(Clone)") {

                    card.name = "instantiated3HandCard30a";

                } else if (card.name == "instantiated3Card30b(Clone)") {

                    card.name = "instantiated3HandCard30b";

                } else if (card.name == "instantiated3Card30c(Clone)") {

                    card.name = "instantiated3HandCard30c";

                } else if (card.name == "instantiated3Card31(Clone)") {

                    card.name = "instantiated3HandCard31";

                } else if (card.name == "instantiated3Card31a(Clone)") {

                    card.name = "instantiated3HandCard31a";

                } else if (card.name == "instantiated3Card31b(Clone)") {

                    card.name = "instantiated3HandCard31b";

                } else if (card.name == "instantiated3Card31c(Clone)") {

                    card.name = "instantiated3HandCard31c";

                } else if (card.name == "instantiated3Card32(Clone)") {

                    card.name = "instantiated3HandCard32";

                } else if (card.name == "instantiated3Card32a(Clone)") {

                    card.name = "instantiated3HandCard32a";

                } else if (card.name == "instantiated3Card32b(Clone)") {

                    card.name = "instantiated3HandCard32b";

                } else if (card.name == "instantiated3Card32c(Clone)") {

                    card.name = "instantiated3HandCard32c";

                } else if (card.name == "instantiated3Card33(Clone)") {

                    card.name = "instantiated3HandCard33";

                } else if (card.name == "instantiated3Card33a(Clone)") {

                    card.name = "instantiated3HandCard33a";

                } else if (card.name == "instantiated3Card33b(Clone)") {

                    card.name = "instantiated3HandCard33b";

                } else if (card.name == "instantiated3Card33c(Clone)") {

                    card.name = "instantiated3HandCard33c";

                } else if (card.name == "instantiated3Card34(Clone)") {

                    card.name = "instantiated3HandCard34";

                } else if (card.name == "instantiated3Card34a(Clone)") {

                    card.name = "instantiated3HandCard34a";

                } else if (card.name == "instantiated3Card34b(Clone)") {

                    card.name = "instantiated3HandCard34b";

                } else if (card.name == "instantiated3Card34c(Clone)") {

                    card.name = "instantiated3HandCard34c";

                } else if (card.name == "instantiated3Card35(Clone)") {

                    card.name = "instantiated3HandCard35";

                } else if (card.name == "instantiated3Card35a(Clone)") {

                    card.name = "instantiated3HandCard35a";

                } else if (card.name == "instantiated3Card35b(Clone)") {

                    card.name = "instantiated3HandCard35b";

                } else if (card.name == "instantiated3Card35c(Clone)") {

                    card.name = "instantiated3HandCard35c";

                } else if (card.name == "instantiated3Card36(Clone)") {

                    card.name = "instantiated3HandCard36";

                } else if (card.name == "instantiated3Card36a(Clone)") {

                    card.name = "instantiated3HandCard36a";

                } else if (card.name == "instantiated3Card36b(Clone)") {

                    card.name = "instantiated3HandCard36b";

                } else if (card.name == "instantiated3Card36c(Clone)") {

                    card.name = "instantiated3HandCard36c";

                } else if (card.name == "instantiated3Card37(Clone)") {

                    card.name = "instantiated3HandCard37";

                } else if (card.name == "instantiated3Card37a(Clone)") {

                    card.name = "instantiated3HandCard37a";

                } else if (card.name == "instantiated3Card37b(Clone)") {

                    card.name = "instantiated3HandCard37b";

                } else if (card.name == "instantiated3Card37c(Clone)") {

                    card.name = "instantiated3HandCard37c";

                } else if (card.name == "instantiated3Card38(Clone)") {

                    card.name = "instantiated3HandCard38";

                } else if (card.name == "instantiated3Card38a(Clone)") {

                    card.name = "instantiated3HandCard38a";

                } else if (card.name == "instantiated3Card38b(Clone)") {

                    card.name = "instantiated3HandCard38b";

                } else if (card.name == "instantiated3Card38c(Clone)") {

                    card.name = "instantiated3HandCard38c";

                } else if (card.name == "instantiated3Card39(Clone)") {

                    card.name = "instantiated3HandCard39";

                } else if (card.name == "instantiated3Card39a(Clone)") {

                    card.name = "instantiated3HandCard39a";

                } else if (card.name == "instantiated3Card39b(Clone)") {

                    card.name = "instantiated3HandCard39b";

                } else if (card.name == "instantiated3Card39c(Clone)") {

                    card.name = "instantiated3HandCard39c";

                } else if (card.name == "instantiated3Card40(Clone)") {

                    card.name = "instantiated3HandCard40";

                } else if (card.name == "instantiated3Card40a(Clone)") {

                    card.name = "instantiated3HandCard40a";

                } else if (card.name == "instantiated3Card40b(Clone)") {

                    card.name = "instantiated3HandCard40b";

                } else if (card.name == "instantiated3Card40c(Clone)") {

                    card.name = "instantiated3HandCard40c";

                } else if (card.name == "instantiated3Card41(Clone)") {

                    card.name = "instantiated3HandCard41";

                } else if (card.name == "instantiated3Card41a(Clone)") {

                    card.name = "instantiated3HandCard41a";

                } else if (card.name == "instantiated3Card41b(Clone)") {

                    card.name = "instantiated3HandCard41b";

                } else if (card.name == "instantiated3Card41c(Clone)") {

                    card.name = "instantiated3HandCard41c";

                } else if (card.name == "instantiated3Card42(Clone)") {

                    card.name = "instantiated3HandCard42";

                } else if (card.name == "instantiated3Card42a(Clone)") {

                    card.name = "instantiated3HandCard42a";

                } else if (card.name == "instantiated3Card42b(Clone)") {

                    card.name = "instantiated3HandCard42b";

                } else if (card.name == "instantiated3Card42c(Clone)") {

                    card.name = "instantiated3HandCard42c";

                } else if (card.name == "instantiated3Card43(Clone)") {

                    card.name = "instantiated3HandCard43";

                } else if (card.name == "instantiated3Card43a(Clone)") {

                    card.name = "instantiated3HandCard43a";

                } else if (card.name == "instantiated3Card43b(Clone)") {

                    card.name = "instantiated3HandCard43b";

                } else if (card.name == "instantiated3Card43c(Clone)") {

                    card.name = "instantiated3HandCard43c";

                } else if (card.name == "instantiated3Card44(Clone)") {

                    card.name = "instantiated3HandCard44";

                } else if (card.name == "instantiated3Card44a(Clone)") {

                    card.name = "instantiated3HandCard44a";

                } else if (card.name == "instantiated3Card44b(Clone)") {

                    card.name = "instantiated3HandCard44b";

                } else if (card.name == "instantiated3Card44c(Clone)") {

                    card.name = "instantiated3HandCard44c";

                } else if (card.name == "instantiated3Card45(Clone)") {

                    card.name = "instantiated3HandCard45";

                } else if (card.name == "instantiated3Card45a(Clone)") {

                    card.name = "instantiated3HandCard45a";

                } else if (card.name == "instantiated3Card45b(Clone)") {

                    card.name = "instantiated3HandCard45b";

                } else if (card.name == "instantiated3Card45c(Clone)") {

                    card.name = "instantiated3HandCard45c";

                } else if (card.name == "instantiated3Card46(Clone)") {

                    card.name = "instantiated3HandCard46";

                } else if (card.name == "instantiated3Card46a(Clone)") {

                    card.name = "instantiated3HandCard46a";

                } else if (card.name == "instantiated3Card46b(Clone)") {

                    card.name = "instantiated3HandCard46b";

                } else if (card.name == "instantiated3Card46c(Clone)") {

                    card.name = "instantiated3HandCard46c";

                } else if (card.name == "instantiated3Card47(Clone)") {

                    card.name = "instantiated3HandCard47";

                } else if (card.name == "instantiated3Card47a(Clone)") {

                    card.name = "instantiated3HandCard47a";

                } else if (card.name == "instantiated3Card47b(Clone)") {

                    card.name = "instantiated3HandCard47b";

                } else if (card.name == "instantiated3Card47c(Clone)") {

                    card.name = "instantiated3HandCard47c";

                } else if (card.name == "instantiated3Card48(Clone)") {

                    card.name = "instantiated3HandCard48";

                } else if (card.name == "instantiated3Card48a(Clone)") {

                    card.name = "instantiated3HandCard48a";

                } else if (card.name == "instantiated3Card48b(Clone)") {

                    card.name = "instantiated3HandCard48b";

                } else if (card.name == "instantiated3Card48c(Clone)") {

                    card.name = "instantiated3HandCard48c";

                } else if (card.name == "instantiated3Card49(Clone)") {

                    card.name = "instantiated3HandCard49";

                } else if (card.name == "instantiated3Card49a(Clone)") {

                    card.name = "instantiated3HandCard49a";

                } else if (card.name == "instantiated3Card49b(Clone)") {

                    card.name = "instantiated3HandCard49b";

                } else if (card.name == "instantiated3Card49c(Clone)") {

                    card.name = "instantiated3HandCard49c";

                } else if (card.name == "instantiated3Card50(Clone)") {

                    card.name = "instantiated3HandCard50";

                } else if (card.name == "instantiated3Card50a(Clone)") {

                    card.name = "instantiated3HandCard50a";

                } else if (card.name == "instantiated3Card50b(Clone)") {

                    card.name = "instantiated3HandCard50b";

                } else if (card.name == "instantiated3Card50c(Clone)") {

                    card.name = "instantiated3HandCard50c";

                } else if (card.name == "instantiated3Card51(Clone)") {

                    card.name = "instantiated3HandCard51";

                } else if (card.name == "instantiated3Card51a(Clone)") {

                    card.name = "instantiated3HandCard51a";

                } else if (card.name == "instantiated3Card51b(Clone)") {

                    card.name = "instantiated3HandCard51b";

                } else if (card.name == "instantiated3Card51c(Clone)") {

                    card.name = "instantiated3HandCard51c";

                } else if (card.name == "instantiated3Card52(Clone)") {

                    card.name = "instantiated3HandCard52";

                } else if (card.name == "instantiated3Card52a(Clone)") {

                    card.name = "instantiated3HandCard52a";

                } else if (card.name == "instantiated3Card52b(Clone)") {

                    card.name = "instantiated3HandCard52b";

                } else if (card.name == "instantiated3Card52c(Clone)") {

                    card.name = "instantiated3HandCard52c";

                } else if (card.name == "instantiated3Card53(Clone)") {

                    card.name = "instantiated3HandCard53";

                } else if (card.name == "instantiated3Card53a(Clone)") {

                    card.name = "instantiated3HandCard53a";

                } else if (card.name == "instantiated3Card53b(Clone)") {

                    card.name = "instantiated3HandCard53b";

                } else if (card.name == "instantiated3Card53c(Clone)") {

                    card.name = "instantiated3HandCard53c";

                } else if (card.name == "instantiated3Card54(Clone)") {

                    card.name = "instantiated3HandCard54";

                } else if (card.name == "instantiated3Card54a(Clone)") {

                    card.name = "instantiated3HandCard54a";

                } else if (card.name == "instantiated3Card54b(Clone)") {

                    card.name = "instantiated3HandCard54b";

                } else if (card.name == "instantiated3Card54c(Clone)") {

                    card.name = "instantiated3HandCard54c";

                } else if (card.name == "instantiated3Card55(Clone)") {

                    card.name = "instantiated3HandCard55";

                } else if (card.name == "instantiated3Card55a(Clone)") {

                    card.name = "instantiated3HandCard55a";

                } else if (card.name == "instantiated3Card55b(Clone)") {

                    card.name = "instantiated3HandCard55b";

                } else if (card.name == "instantiated3Card55c(Clone)") {

                    card.name = "instantiated3HandCard55c";

                } else if (card.name == "instantiated3Card56(Clone)") {

                    card.name = "instantiated3HandCard56";

                } else if (card.name == "instantiated3Card56a(Clone)") {

                    card.name = "instantiated3HandCard56a";

                } else if (card.name == "instantiated3Card56b(Clone)") {

                    card.name = "instantiated3HandCard56b";

                } else if (card.name == "instantiated3Card56c(Clone)") {

                    card.name = "instantiated3HandCard56c";

                } else if (card.name == "instantiated3Card57(Clone)") {

                    card.name = "instantiated3HandCard57";

                } else if (card.name == "instantiated3Card57a(Clone)") {

                    card.name = "instantiated3HandCard57a";

                } else if (card.name == "instantiated3Card57b(Clone)") {

                    card.name = "instantiated3HandCard57b";

                } else if (card.name == "instantiated3Card57c(Clone)") {

                    card.name = "instantiated3HandCard57c";

                } else if (card.name == "instantiated3Card58(Clone)") {

                    card.name = "instantiated3HandCard58";

                } else if (card.name == "instantiated3Card58a(Clone)") {

                    card.name = "instantiated3HandCard58a";

                } else if (card.name == "instantiated3Card58b(Clone)") {

                    card.name = "instantiated3HandCard58b";

                } else if (card.name == "instantiated3Card58c(Clone)") {

                    card.name = "instantiated3HandCard58c";

                } else if (card.name == "instantiated3Card59(Clone)") {

                    card.name = "instantiated3HandCard59";

                } else if (card.name == "instantiated3Card59a(Clone)") {

                    card.name = "instantiated3HandCard59a";

                } else if (card.name == "instantiated3Card59b(Clone)") {

                    card.name = "instantiated3HandCard59b";

                } else if (card.name == "instantiated3Card59c(Clone)") {

                    card.name = "instantiated3HandCard59c";

                } else if (card.name == "instantiated3Card60(Clone)") {

                    card.name = "instantiated3HandCard60";

                } else if (card.name == "instantiated3Card60a(Clone)") {

                    card.name = "instantiated3HandCard60a";

                } else if (card.name == "instantiated3Card60b(Clone)") {

                    card.name = "instantiated3HandCard60b";

                } else if (card.name == "instantiated3Card60c(Clone)") {

                    card.name = "instantiated3HandCard60c";
                }

                instances4++;

            }

            while (instances5 < NumberOfCards) {

                GameObject card = Instantiate(playCardsDeck3[UnityEngine.Random.Range(0, playCardsDeck3.Count)], player1DeckSlot5.transform.position, player1DeckSlot5.transform.rotation) as GameObject;
                card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                card.transform.parent = player1DeckSlot5.transform;

                if (card.name == "instantiated3Card1(Clone)") {

                    card.name = "instantiated3HandCard1";

                } else if (card.name == "instantiated3Card1a(Clone)") {

                    card.name = "instantiated3HandCard1a";

                } else if (card.name == "instantiated3Card1b(Clone)") {

                    card.name = "instantiated3HandCard1b";

                } else if (card.name == "instantiated3Card1c(Clone)") {

                    card.name = "instantiated3HandCard1c";

                } else if (card.name == "instantiated3Card2(Clone)") {

                    card.name = "instantiated3HandCard2";

                } else if (card.name == "instantiated3Card2a(Clone)") {

                    card.name = "instantiated3HandCard2a";

                } else if (card.name == "instantiated3Card2b(Clone)") {

                    card.name = "instantiated3HandCard2b";

                } else if (card.name == "instantiated3Card2c(Clone)") {

                    card.name = "instantiated3HandCard2c";

                } else if (card.name == "instantiated3Card3(Clone)") {

                    card.name = "instantiated3HandCard3";

                } else if (card.name == "instantiated3Card3a(Clone)") {

                    card.name = "instantiated3HandCard3a";

                } else if (card.name == "instantiated3Card3b(Clone)") {

                    card.name = "instantiated3HandCard3b";

                } else if (card.name == "instantiated3Card3c(Clone)") {

                    card.name = "instantiated3HandCard3c";

                } else if (card.name == "instantiated3Card4(Clone)") {

                    card.name = "instantiated3HandCard4";

                } else if (card.name == "instantiated3Card4a(Clone)") {

                    card.name = "instantiated3HandCard4a";

                } else if (card.name == "instantiated3Card4b(Clone)") {

                    card.name = "instantiated3HandCard4b";

                } else if (card.name == "instantiated3Card4c(Clone)") {

                    card.name = "instantiated3HandCard4c";

                } else if (card.name == "instantiated3Card5(Clone)") {

                    card.name = "instantiated3HandCard5";

                } else if (card.name == "instantiated3Card5a(Clone)") {

                    card.name = "instantiated3HandCard5a";

                } else if (card.name == "instantiated3Card5b(Clone)") {

                    card.name = "instantiated3HandCard5b";

                } else if (card.name == "instantiated3Card5c(Clone)") {

                    card.name = "instantiated3HandCard5c";

                } else if (card.name == "instantiated3Card6(Clone)") {

                    card.name = "instantiated3HandCard6";

                } else if (card.name == "instantiated3Card6a(Clone)") {

                    card.name = "instantiated3HandCard6a";

                } else if (card.name == "instantiated3Card6b(Clone)") {

                    card.name = "instantiated3HandCard6b";

                } else if (card.name == "instantiated3Card6c(Clone)") {

                    card.name = "instantiated3HandCard6c";

                } else if (card.name == "instantiated3Card7(Clone)") {

                    card.name = "instantiated3HandCard7";

                } else if (card.name == "instantiated3Card7a(Clone)") {

                    card.name = "instantiated3HandCard7a";

                } else if (card.name == "instantiated3Card7b(Clone)") {

                    card.name = "instantiated3HandCard7b";

                } else if (card.name == "instantiated3Card7c(Clone)") {

                    card.name = "instantiated3HandCard7c";

                } else if (card.name == "instantiated3Card8(Clone)") {

                    card.name = "instantiated3HandCard8";

                } else if (card.name == "instantiated3Card8a(Clone)") {

                    card.name = "instantiated3HandCard8a";

                } else if (card.name == "instantiated3Card8b(Clone)") {

                    card.name = "instantiated3HandCard8b";

                } else if (card.name == "instantiated3Card8c(Clone)") {

                    card.name = "instantiated3HandCard8c";

                } else if (card.name == "instantiated3Card9(Clone)") {

                    card.name = "instantiated3HandCard9";

                } else if (card.name == "instantiated3Card9a(Clone)") {

                    card.name = "instantiated3HandCard9a";

                } else if (card.name == "instantiated3Card9b(Clone)") {

                    card.name = "instantiated3HandCard9b";

                } else if (card.name == "instantiated3Card9c(Clone)") {

                    card.name = "instantiated3HandCard9c";

                } else if (card.name == "instantiated3Card10(Clone)") {

                    card.name = "instantiatedAICard10";

                } else if (card.name == "instantiated3Card10a(Clone)") {

                    card.name = "instantiated3HandCard10a";

                } else if (card.name == "instantiated3Card10b(Clone)") {

                    card.name = "instantiated3HandCard10b";

                } else if (card.name == "instantiated3Card10c(Clone)") {

                    card.name = "instantiated3HandCard10c";

                } else if (card.name == "instantiated3Card11(Clone)") {

                    card.name = "instantiated3HandCard11";

                } else if (card.name == "instantiated3Card11a(Clone)") {

                    card.name = "instantiated3HandCard11a";

                } else if (card.name == "instantiated3Card11b(Clone)") {

                    card.name = "instantiated3HandCard11b";

                } else if (card.name == "instantiated3Card11c(Clone)") {

                    card.name = "instantiated3HandCard11c";

                } else if (card.name == "instantiated3Card12(Clone)") {

                    card.name = "instantiated3HandCard12";

                } else if (card.name == "instantiated3Card12a(Clone)") {

                    card.name = "instantiated3HandCard12a";

                } else if (card.name == "instantiated3Card12b(Clone)") {

                    card.name = "instantiated3HandCard12b";

                } else if (card.name == "instantiated3Card12c(Clone)") {

                    card.name = "instantiated3HandCard12c";

                } else if (card.name == "instantiated3Card13(Clone)") {

                    card.name = "instantiated3HandCard13";

                } else if (card.name == "instantiated3Card13a(Clone)") {

                    card.name = "instantiated3HandCard13a";

                } else if (card.name == "instantiated3Card13b(Clone)") {

                    card.name = "instantiated3HandCard13b";

                } else if (card.name == "instantiated3Card13c(Clone)") {

                    card.name = "instantiated3HandCard13c";

                } else if (card.name == "instantiated3Card14(Clone)") {

                    card.name = "instantiated3HandCard14";

                } else if (card.name == "instantiated3Card14a(Clone)") {

                    card.name = "instantiated3HandCard14a";

                } else if (card.name == "instantiated3Card14b(Clone)") {

                    card.name = "instantiated3HandCard14b";

                } else if (card.name == "instantiated3Card14c(Clone)") {

                    card.name = "instantiated3HandCard14c";

                } else if (card.name == "instantiated3Card15(Clone)") {

                    card.name = "instantiated3HandCard15";

                } else if (card.name == "instantiated3Card15a(Clone)") {

                    card.name = "instantiated3HandCard15a";

                } else if (card.name == "instantiated3Card15b(Clone)") {

                    card.name = "instantiated3HandCard15b";

                } else if (card.name == "instantiated3Card15c(Clone)") {

                    card.name = "instantiated3HandCard15c";

                } else if (card.name == "instantiated3Card16(Clone)") {

                    card.name = "instantiated3HandCard16";

                } else if (card.name == "instantiated3Card16a(Clone)") {

                    card.name = "instantiated3HandCard16a";

                } else if (card.name == "instantiated3Card16b(Clone)") {

                    card.name = "instantiated3HandCard16b";

                } else if (card.name == "instantiated3Card16c(Clone)") {

                    card.name = "instantiated3HandCard16c";

                } else if (card.name == "instantiated3Card17(Clone)") {

                    card.name = "instantiated3HandCard17";

                } else if (card.name == "instantiated3Card17a(Clone)") {

                    card.name = "instantiated3HandCard17a";

                } else if (card.name == "instantiated3Card17b(Clone)") {

                    card.name = "instantiated3HandCard17b";

                } else if (card.name == "instantiated3Card17c(Clone)") {

                    card.name = "instantiated3HandCard17c";

                } else if (card.name == "instantiated3Card18(Clone)") {

                    card.name = "instantiated3HandCard18";

                } else if (card.name == "instantiated3Card18a(Clone)") {

                    card.name = "instantiated3HandCard18a";

                } else if (card.name == "instantiated3Card18b(Clone)") {

                    card.name = "instantiated3HandCard18b";

                } else if (card.name == "instantiated3Card18c(Clone)") {

                    card.name = "instantiated3HandCard18c";

                } else if (card.name == "instantiated3Card19(Clone)") {

                    card.name = "instantiated3HandCard19";

                } else if (card.name == "instantiated3Card19a(Clone)") {

                    card.name = "instantiated3HandCard19a";

                } else if (card.name == "instantiated3Card19b(Clone)") {

                    card.name = "instantiated3HandCard19b";

                } else if (card.name == "instantiated3Card19c(Clone)") {

                    card.name = "instantiated3HandCard19c";

                } else if (card.name == "instantiated3Card20(Clone)") {

                    card.name = "instantiated3HandCard20";

                } else if (card.name == "instantiated3Card20a(Clone)") {

                    card.name = "instantiated3HandCard20a";

                } else if (card.name == "instantiated3Card20b(Clone)") {

                    card.name = "instantiated3HandCard20b";

                } else if (card.name == "instantiated3Card20c(Clone)") {

                    card.name = "instantiated3HandCard20c";

                } else if (card.name == "instantiated3Card21(Clone)") {

                    card.name = "instantiated3HandCard21";

                } else if (card.name == "instantiated3Card21a(Clone)") {

                    card.name = "instantiated3HandCard21a";

                } else if (card.name == "instantiated3Card21b(Clone)") {

                    card.name = "instantiated3HandCard21b";

                } else if (card.name == "instantiated3Card21c(Clone)") {

                    card.name = "instantiated3HandCard21c";

                } else if (card.name == "instantiated3Card22(Clone)") {

                    card.name = "instantiated3HandCard22";

                } else if (card.name == "instantiated3Card22a(Clone)") {

                    card.name = "instantiated3HandCard22a";

                } else if (card.name == "instantiated3Card22b(Clone)") {

                    card.name = "instantiated3HandCard22b";

                } else if (card.name == "instantiated3Card22c(Clone)") {

                    card.name = "instantiated3HandCard22c";

                } else if (card.name == "instantiated3Card23(Clone)") {

                    card.name = "instantiated3HandCard23";

                } else if (card.name == "instantiated3Card23a(Clone)") {

                    card.name = "instantiated3HandCard23a";

                } else if (card.name == "instantiated3Card23b(Clone)") {

                    card.name = "instantiated3HandCard23b";

                } else if (card.name == "instantiated3Card23c(Clone)") {

                    card.name = "instantiated3HandCard23c";

                } else if (card.name == "instantiated3Card24(Clone)") {

                    card.name = "instantiated3HandCard24";

                } else if (card.name == "instantiated3Card24a(Clone)") {

                    card.name = "instantiated3HandCard24a";

                } else if (card.name == "instantiated3Card24b(Clone)") {

                    card.name = "instantiated3HandCard24b";

                } else if (card.name == "instantiated3Card24c(Clone)") {

                    card.name = "instantiated3HandCard24c";

                } else if (card.name == "instantiated3Card25(Clone)") {

                    card.name = "instantiated3HandCard25";

                } else if (card.name == "instantiated3Card25a(Clone)") {

                    card.name = "instantiated3HandCard25a";

                } else if (card.name == "instantiated3Card25b(Clone)") {

                    card.name = "instantiated3HandCard25b";

                } else if (card.name == "instantiated3Card25c(Clone)") {

                    card.name = "instantiated3HandCard25c";

                } else if (card.name == "instantiated3Card26(Clone)") {

                    card.name = "instantiated3HandCard26";

                } else if (card.name == "instantiated3Card26a(Clone)") {

                    card.name = "instantiated3HandCard26a";

                } else if (card.name == "instantiated3Card26b(Clone)") {

                    card.name = "instantiated3HandCard26b";

                } else if (card.name == "instantiated3Card26c(Clone)") {

                    card.name = "instantiated3HandCard26c";

                } else if (card.name == "instantiated3Card27(Clone)") {

                    card.name = "instantiated3HandCard27";

                } else if (card.name == "instantiated3Card27a(Clone)") {

                    card.name = "instantiated3HandCard27a";

                } else if (card.name == "instantiated3Card27b(Clone)") {

                    card.name = "instantiated3HandCard27b";

                } else if (card.name == "instantiated3Card27c(Clone)") {

                    card.name = "instantiated3HandCard27c";

                } else if (card.name == "instantiated3Card28(Clone)") {

                    card.name = "instantiated3HandCard28";

                } else if (card.name == "instantiated3Card28a(Clone)") {

                    card.name = "instantiated3HandCard28a";

                } else if (card.name == "instantiated3Card28b(Clone)") {

                    card.name = "instantiated3HandCard28b";

                } else if (card.name == "instantiated3Card28c(Clone)") {

                    card.name = "instantiated3HandCard28c";

                } else if (card.name == "instantiated3Card29(Clone)") {

                    card.name = "instantiated3HandCard29";

                } else if (card.name == "instantiated3Card29a(Clone)") {

                    card.name = "instantiated3HandCard29a";

                } else if (card.name == "instantiated3Card29b(Clone)") {

                    card.name = "instantiated3HandCard29b";

                } else if (card.name == "instantiated3Card29c(Clone)") {

                    card.name = "instantiated3HandCard29c";

                } else if (card.name == "instantiated3Card30(Clone)") {

                    card.name = "instantiated3HandCard30";

                } else if (card.name == "instantiated3Card30a(Clone)") {

                    card.name = "instantiated3HandCard30a";

                } else if (card.name == "instantiated3Card30b(Clone)") {

                    card.name = "instantiated3HandCard30b";

                } else if (card.name == "instantiated3Card30c(Clone)") {

                    card.name = "instantiated3HandCard30c";

                } else if (card.name == "instantiated3Card31(Clone)") {

                    card.name = "instantiated3HandCard31";

                } else if (card.name == "instantiated3Card31a(Clone)") {

                    card.name = "instantiated3HandCard31a";

                } else if (card.name == "instantiated3Card31b(Clone)") {

                    card.name = "instantiated3HandCard31b";

                } else if (card.name == "instantiated3Card31c(Clone)") {

                    card.name = "instantiated3HandCard31c";

                } else if (card.name == "instantiated3Card32(Clone)") {

                    card.name = "instantiated3HandCard32";

                } else if (card.name == "instantiated3Card32a(Clone)") {

                    card.name = "instantiated3HandCard32a";

                } else if (card.name == "instantiated3Card32b(Clone)") {

                    card.name = "instantiated3HandCard32b";

                } else if (card.name == "instantiated3Card32c(Clone)") {

                    card.name = "instantiated3HandCard32c";

                } else if (card.name == "instantiated3Card33(Clone)") {

                    card.name = "instantiated3HandCard33";

                } else if (card.name == "instantiated3Card33a(Clone)") {

                    card.name = "instantiated3HandCard33a";

                } else if (card.name == "instantiated3Card33b(Clone)") {

                    card.name = "instantiated3HandCard33b";

                } else if (card.name == "instantiated3Card33c(Clone)") {

                    card.name = "instantiated3HandCard33c";

                } else if (card.name == "instantiated3Card34(Clone)") {

                    card.name = "instantiated3HandCard34";

                } else if (card.name == "instantiated3Card34a(Clone)") {

                    card.name = "instantiated3HandCard34a";

                } else if (card.name == "instantiated3Card34b(Clone)") {

                    card.name = "instantiated3HandCard34b";

                } else if (card.name == "instantiated3Card34c(Clone)") {

                    card.name = "instantiated3HandCard34c";

                } else if (card.name == "instantiated3Card35(Clone)") {

                    card.name = "instantiated3HandCard35";

                } else if (card.name == "instantiated3Card35a(Clone)") {

                    card.name = "instantiated3HandCard35a";

                } else if (card.name == "instantiated3Card35b(Clone)") {

                    card.name = "instantiated3HandCard35b";

                } else if (card.name == "instantiated3Card35c(Clone)") {

                    card.name = "instantiated3HandCard35c";

                } else if (card.name == "instantiated3Card36(Clone)") {

                    card.name = "instantiated3HandCard36";

                } else if (card.name == "instantiated3Card36a(Clone)") {

                    card.name = "instantiated3HandCard36a";

                } else if (card.name == "instantiated3Card36b(Clone)") {

                    card.name = "instantiated3HandCard36b";

                } else if (card.name == "instantiated3Card36c(Clone)") {

                    card.name = "instantiated3HandCard36c";

                } else if (card.name == "instantiated3Card37(Clone)") {

                    card.name = "instantiated3HandCard37";

                } else if (card.name == "instantiated3Card37a(Clone)") {

                    card.name = "instantiated3HandCard37a";

                } else if (card.name == "instantiated3Card37b(Clone)") {

                    card.name = "instantiated3HandCard37b";

                } else if (card.name == "instantiated3Card37c(Clone)") {

                    card.name = "instantiated3HandCard37c";

                } else if (card.name == "instantiated3Card38(Clone)") {

                    card.name = "instantiated3HandCard38";

                } else if (card.name == "instantiated3Card38a(Clone)") {

                    card.name = "instantiated3HandCard38a";

                } else if (card.name == "instantiated3Card38b(Clone)") {

                    card.name = "instantiated3HandCard38b";

                } else if (card.name == "instantiated3Card38c(Clone)") {

                    card.name = "instantiated3HandCard38c";

                } else if (card.name == "instantiated3Card39(Clone)") {

                    card.name = "instantiated3HandCard39";

                } else if (card.name == "instantiated3Card39a(Clone)") {

                    card.name = "instantiated3HandCard39a";

                } else if (card.name == "instantiated3Card39b(Clone)") {

                    card.name = "instantiated3HandCard39b";

                } else if (card.name == "instantiated3Card39c(Clone)") {

                    card.name = "instantiated3HandCard39c";

                } else if (card.name == "instantiated3Card40(Clone)") {

                    card.name = "instantiated3HandCard40";

                } else if (card.name == "instantiated3Card40a(Clone)") {

                    card.name = "instantiated3HandCard40a";

                } else if (card.name == "instantiated3Card40b(Clone)") {

                    card.name = "instantiated3HandCard40b";

                } else if (card.name == "instantiated3Card40c(Clone)") {

                    card.name = "instantiated3HandCard40c";

                } else if (card.name == "instantiated3Card41(Clone)") {

                    card.name = "instantiated3HandCard41";

                } else if (card.name == "instantiated3Card41a(Clone)") {

                    card.name = "instantiated3HandCard41a";

                } else if (card.name == "instantiated3Card41b(Clone)") {

                    card.name = "instantiated3HandCard41b";

                } else if (card.name == "instantiated3Card41c(Clone)") {

                    card.name = "instantiated3HandCard41c";

                } else if (card.name == "instantiated3Card42(Clone)") {

                    card.name = "instantiated3HandCard42";

                } else if (card.name == "instantiated3Card42a(Clone)") {

                    card.name = "instantiated3HandCard42a";

                } else if (card.name == "instantiated3Card42b(Clone)") {

                    card.name = "instantiated3HandCard42b";

                } else if (card.name == "instantiated3Card42c(Clone)") {

                    card.name = "instantiated3HandCard42c";

                } else if (card.name == "instantiated3Card43(Clone)") {

                    card.name = "instantiated3HandCard43";

                } else if (card.name == "instantiated3Card43a(Clone)") {

                    card.name = "instantiated3HandCard43a";

                } else if (card.name == "instantiated3Card43b(Clone)") {

                    card.name = "instantiated3HandCard43b";

                } else if (card.name == "instantiated3Card43c(Clone)") {

                    card.name = "instantiated3HandCard43c";

                } else if (card.name == "instantiated3Card44(Clone)") {

                    card.name = "instantiated3HandCard44";

                } else if (card.name == "instantiated3Card44a(Clone)") {

                    card.name = "instantiated3HandCard44a";

                } else if (card.name == "instantiated3Card44b(Clone)") {

                    card.name = "instantiated3HandCard44b";

                } else if (card.name == "instantiated3Card44c(Clone)") {

                    card.name = "instantiated3HandCard44c";

                } else if (card.name == "instantiated3Card45(Clone)") {

                    card.name = "instantiated3HandCard45";

                } else if (card.name == "instantiated3Card45a(Clone)") {

                    card.name = "instantiated3HandCard45a";

                } else if (card.name == "instantiated3Card45b(Clone)") {

                    card.name = "instantiated3HandCard45b";

                } else if (card.name == "instantiated3Card45c(Clone)") {

                    card.name = "instantiated3HandCard45c";

                } else if (card.name == "instantiated3Card46(Clone)") {

                    card.name = "instantiated3HandCard46";

                } else if (card.name == "instantiated3Card46a(Clone)") {

                    card.name = "instantiated3HandCard46a";

                } else if (card.name == "instantiated3Card46b(Clone)") {

                    card.name = "instantiated3HandCard46b";

                } else if (card.name == "instantiated3Card46c(Clone)") {

                    card.name = "instantiated3HandCard46c";

                } else if (card.name == "instantiated3Card47(Clone)") {

                    card.name = "instantiated3HandCard47";

                } else if (card.name == "instantiated3Card47a(Clone)") {

                    card.name = "instantiated3HandCard47a";

                } else if (card.name == "instantiated3Card47b(Clone)") {

                    card.name = "instantiated3HandCard47b";

                } else if (card.name == "instantiated3Card47c(Clone)") {

                    card.name = "instantiated3HandCard47c";

                } else if (card.name == "instantiated3Card48(Clone)") {

                    card.name = "instantiated3HandCard48";

                } else if (card.name == "instantiated3Card48a(Clone)") {

                    card.name = "instantiated3HandCard48a";

                } else if (card.name == "instantiated3Card48b(Clone)") {

                    card.name = "instantiated3HandCard48b";

                } else if (card.name == "instantiated3Card48c(Clone)") {

                    card.name = "instantiated3HandCard48c";

                } else if (card.name == "instantiated3Card49(Clone)") {

                    card.name = "instantiated3HandCard49";

                } else if (card.name == "instantiated3Card49a(Clone)") {

                    card.name = "instantiated3HandCard49a";

                } else if (card.name == "instantiated3Card49b(Clone)") {

                    card.name = "instantiated3HandCard49b";

                } else if (card.name == "instantiated3Card49c(Clone)") {

                    card.name = "instantiated3HandCard49c";

                } else if (card.name == "instantiated3Card50(Clone)") {

                    card.name = "instantiated3HandCard50";

                } else if (card.name == "instantiated3Card50a(Clone)") {

                    card.name = "instantiated3HandCard50a";

                } else if (card.name == "instantiated3Card50b(Clone)") {

                    card.name = "instantiated3HandCard50b";

                } else if (card.name == "instantiated3Card50c(Clone)") {

                    card.name = "instantiated3HandCard50c";

                } else if (card.name == "instantiated3Card51(Clone)") {

                    card.name = "instantiated3HandCard51";

                } else if (card.name == "instantiated3Card51a(Clone)") {

                    card.name = "instantiated3HandCard51a";

                } else if (card.name == "instantiated3Card51b(Clone)") {

                    card.name = "instantiated3HandCard51b";

                } else if (card.name == "instantiated3Card51c(Clone)") {

                    card.name = "instantiated3HandCard51c";

                } else if (card.name == "instantiated3Card52(Clone)") {

                    card.name = "instantiated3HandCard52";

                } else if (card.name == "instantiated3Card52a(Clone)") {

                    card.name = "instantiated3HandCard52a";

                } else if (card.name == "instantiated3Card52b(Clone)") {

                    card.name = "instantiated3HandCard52b";

                } else if (card.name == "instantiated3Card52c(Clone)") {

                    card.name = "instantiated3HandCard52c";

                } else if (card.name == "instantiated3Card53(Clone)") {

                    card.name = "instantiated3HandCard53";

                } else if (card.name == "instantiated3Card53a(Clone)") {

                    card.name = "instantiated3HandCard53a";

                } else if (card.name == "instantiated3Card53b(Clone)") {

                    card.name = "instantiated3HandCard53b";

                } else if (card.name == "instantiated3Card53c(Clone)") {

                    card.name = "instantiated3HandCard53c";

                } else if (card.name == "instantiated3Card54(Clone)") {

                    card.name = "instantiated3HandCard54";

                } else if (card.name == "instantiated3Card54a(Clone)") {

                    card.name = "instantiated3HandCard54a";

                } else if (card.name == "instantiated3Card54b(Clone)") {

                    card.name = "instantiated3HandCard54b";

                } else if (card.name == "instantiated3Card54c(Clone)") {

                    card.name = "instantiated3HandCard54c";

                } else if (card.name == "instantiated3Card55(Clone)") {

                    card.name = "instantiated3HandCard55";

                } else if (card.name == "instantiated3Card55a(Clone)") {

                    card.name = "instantiated3HandCard55a";

                } else if (card.name == "instantiated3Card55b(Clone)") {

                    card.name = "instantiated3HandCard55b";

                } else if (card.name == "instantiated3Card55c(Clone)") {

                    card.name = "instantiated3HandCard55c";

                } else if (card.name == "instantiated3Card56(Clone)") {

                    card.name = "instantiated3HandCard56";

                } else if (card.name == "instantiated3Card56a(Clone)") {

                    card.name = "instantiated3HandCard56a";

                } else if (card.name == "instantiated3Card56b(Clone)") {

                    card.name = "instantiated3HandCard56b";

                } else if (card.name == "instantiated3Card56c(Clone)") {

                    card.name = "instantiated3HandCard56c";

                } else if (card.name == "instantiated3Card57(Clone)") {

                    card.name = "instantiated3HandCard57";

                } else if (card.name == "instantiated3Card57a(Clone)") {

                    card.name = "instantiated3HandCard57a";

                } else if (card.name == "instantiated3Card57b(Clone)") {

                    card.name = "instantiated3HandCard57b";

                } else if (card.name == "instantiated3Card57c(Clone)") {

                    card.name = "instantiated3HandCard57c";

                } else if (card.name == "instantiated3Card58(Clone)") {

                    card.name = "instantiated3HandCard58";

                } else if (card.name == "instantiated3Card58a(Clone)") {

                    card.name = "instantiated3HandCard58a";

                } else if (card.name == "instantiated3Card58b(Clone)") {

                    card.name = "instantiated3HandCard58b";

                } else if (card.name == "instantiated3Card58c(Clone)") {

                    card.name = "instantiated3HandCard58c";

                } else if (card.name == "instantiated3Card59(Clone)") {

                    card.name = "instantiated3HandCard59";

                } else if (card.name == "instantiated3Card59a(Clone)") {

                    card.name = "instantiated3HandCard59a";

                } else if (card.name == "instantiated3Card59b(Clone)") {

                    card.name = "instantiated3HandCard59b";

                } else if (card.name == "instantiated3Card59c(Clone)") {

                    card.name = "instantiated3HandCard59c";

                } else if (card.name == "instantiated3Card60(Clone)") {

                    card.name = "instantiated3HandCard60";

                } else if (card.name == "instantiated3Card60a(Clone)") {

                    card.name = "instantiated3HandCard60a";

                } else if (card.name == "instantiated3Card60b(Clone)") {

                    card.name = "instantiated3HandCard60b";

                } else if (card.name == "instantiated3Card60c(Clone)") {

                    card.name = "instantiated3HandCard60c";
                }

                instances5++;

            }

            while (instances6 < NumberOfCards) {

                GameObject card = Instantiate(playCardsDeck3[UnityEngine.Random.Range(0, playCardsDeck3.Count)], player1DeckSlot6.transform.position, player1DeckSlot6.transform.rotation) as GameObject;
                card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                card.transform.parent = player1DeckSlot6.transform;

                if (card.name == "instantiated3Card1(Clone)") {

                    card.name = "instantiated3HandCard1";

                } else if (card.name == "instantiated3Card1a(Clone)") {

                    card.name = "instantiated3HandCard1a";

                } else if (card.name == "instantiated3Card1b(Clone)") {

                    card.name = "instantiated3HandCard1b";

                } else if (card.name == "instantiated3Card1c(Clone)") {

                    card.name = "instantiated3HandCard1c";

                } else if (card.name == "instantiated3Card2(Clone)") {

                    card.name = "instantiated3HandCard2";

                } else if (card.name == "instantiated3Card2a(Clone)") {

                    card.name = "instantiated3HandCard2a";

                } else if (card.name == "instantiated3Card2b(Clone)") {

                    card.name = "instantiated3HandCard2b";

                } else if (card.name == "instantiated3Card2c(Clone)") {

                    card.name = "instantiated3HandCard2c";

                } else if (card.name == "instantiated3Card3(Clone)") {

                    card.name = "instantiated3HandCard3";

                } else if (card.name == "instantiated3Card3a(Clone)") {

                    card.name = "instantiated3HandCard3a";

                } else if (card.name == "instantiated3Card3b(Clone)") {

                    card.name = "instantiated3HandCard3b";

                } else if (card.name == "instantiated3Card3c(Clone)") {

                    card.name = "instantiated3HandCard3c";

                } else if (card.name == "instantiated3Card4(Clone)") {

                    card.name = "instantiated3HandCard4";

                } else if (card.name == "instantiated3Card4a(Clone)") {

                    card.name = "instantiated3HandCard4a";

                } else if (card.name == "instantiated3Card4b(Clone)") {

                    card.name = "instantiated3HandCard4b";

                } else if (card.name == "instantiated3Card4c(Clone)") {

                    card.name = "instantiated3HandCard4c";

                } else if (card.name == "instantiated3Card5(Clone)") {

                    card.name = "instantiated3HandCard5";

                } else if (card.name == "instantiated3Card5a(Clone)") {

                    card.name = "instantiated3HandCard5a";

                } else if (card.name == "instantiated3Card5b(Clone)") {

                    card.name = "instantiated3HandCard5b";

                } else if (card.name == "instantiated3Card5c(Clone)") {

                    card.name = "instantiated3HandCard5c";

                } else if (card.name == "instantiated3Card6(Clone)") {

                    card.name = "instantiated3HandCard6";

                } else if (card.name == "instantiated3Card6a(Clone)") {

                    card.name = "instantiated3HandCard6a";

                } else if (card.name == "instantiated3Card6b(Clone)") {

                    card.name = "instantiated3HandCard6b";

                } else if (card.name == "instantiated3Card6c(Clone)") {

                    card.name = "instantiated3HandCard6c";

                } else if (card.name == "instantiated3Card7(Clone)") {

                    card.name = "instantiated3HandCard7";

                } else if (card.name == "instantiated3Card7a(Clone)") {

                    card.name = "instantiated3HandCard7a";

                } else if (card.name == "instantiated3Card7b(Clone)") {

                    card.name = "instantiated3HandCard7b";

                } else if (card.name == "instantiated3Card7c(Clone)") {

                    card.name = "instantiated3HandCard7c";

                } else if (card.name == "instantiated3Card8(Clone)") {

                    card.name = "instantiated3HandCard8";

                } else if (card.name == "instantiated3Card8a(Clone)") {

                    card.name = "instantiated3HandCard8a";

                } else if (card.name == "instantiated3Card8b(Clone)") {

                    card.name = "instantiated3HandCard8b";

                } else if (card.name == "instantiated3Card8c(Clone)") {

                    card.name = "instantiated3HandCard8c";

                } else if (card.name == "instantiated3Card9(Clone)") {

                    card.name = "instantiated3HandCard9";

                } else if (card.name == "instantiated3Card9a(Clone)") {

                    card.name = "instantiated3HandCard9a";

                } else if (card.name == "instantiated3Card9b(Clone)") {

                    card.name = "instantiated3HandCard9b";

                } else if (card.name == "instantiated3Card9c(Clone)") {

                    card.name = "instantiated3HandCard9c";

                } else if (card.name == "instantiated3Card10(Clone)") {

                    card.name = "instantiatedAICard10";

                } else if (card.name == "instantiated3Card10a(Clone)") {

                    card.name = "instantiated3HandCard10a";

                } else if (card.name == "instantiated3Card10b(Clone)") {

                    card.name = "instantiated3HandCard10b";

                } else if (card.name == "instantiated3Card10c(Clone)") {

                    card.name = "instantiated3HandCard10c";

                } else if (card.name == "instantiated3Card11(Clone)") {

                    card.name = "instantiated3HandCard11";

                } else if (card.name == "instantiated3Card11a(Clone)") {

                    card.name = "instantiated3HandCard11a";

                } else if (card.name == "instantiated3Card11b(Clone)") {

                    card.name = "instantiated3HandCard11b";

                } else if (card.name == "instantiated3Card11c(Clone)") {

                    card.name = "instantiated3HandCard11c";

                } else if (card.name == "instantiated3Card12(Clone)") {

                    card.name = "instantiated3HandCard12";

                } else if (card.name == "instantiated3Card12a(Clone)") {

                    card.name = "instantiated3HandCard12a";

                } else if (card.name == "instantiated3Card12b(Clone)") {

                    card.name = "instantiated3HandCard12b";

                } else if (card.name == "instantiated3Card12c(Clone)") {

                    card.name = "instantiated3HandCard12c";

                } else if (card.name == "instantiated3Card13(Clone)") {

                    card.name = "instantiated3HandCard13";

                } else if (card.name == "instantiated3Card13a(Clone)") {

                    card.name = "instantiated3HandCard13a";

                } else if (card.name == "instantiated3Card13b(Clone)") {

                    card.name = "instantiated3HandCard13b";

                } else if (card.name == "instantiated3Card13c(Clone)") {

                    card.name = "instantiated3HandCard13c";

                } else if (card.name == "instantiated3Card14(Clone)") {

                    card.name = "instantiated3HandCard14";

                } else if (card.name == "instantiated3Card14a(Clone)") {

                    card.name = "instantiated3HandCard14a";

                } else if (card.name == "instantiated3Card14b(Clone)") {

                    card.name = "instantiated3HandCard14b";

                } else if (card.name == "instantiated3Card14c(Clone)") {

                    card.name = "instantiated3HandCard14c";

                } else if (card.name == "instantiated3Card15(Clone)") {

                    card.name = "instantiated3HandCard15";

                } else if (card.name == "instantiated3Card15a(Clone)") {

                    card.name = "instantiated3HandCard15a";

                } else if (card.name == "instantiated3Card15b(Clone)") {

                    card.name = "instantiated3HandCard15b";

                } else if (card.name == "instantiated3Card15c(Clone)") {

                    card.name = "instantiated3HandCard15c";

                } else if (card.name == "instantiated3Card16(Clone)") {

                    card.name = "instantiated3HandCard16";

                } else if (card.name == "instantiated3Card16a(Clone)") {

                    card.name = "instantiated3HandCard16a";

                } else if (card.name == "instantiated3Card16b(Clone)") {

                    card.name = "instantiated3HandCard16b";

                } else if (card.name == "instantiated3Card16c(Clone)") {

                    card.name = "instantiated3HandCard16c";

                } else if (card.name == "instantiated3Card17(Clone)") {

                    card.name = "instantiated3HandCard17";

                } else if (card.name == "instantiated3Card17a(Clone)") {

                    card.name = "instantiated3HandCard17a";

                } else if (card.name == "instantiated3Card17b(Clone)") {

                    card.name = "instantiated3HandCard17b";

                } else if (card.name == "instantiated3Card17c(Clone)") {

                    card.name = "instantiated3HandCard17c";

                } else if (card.name == "instantiated3Card18(Clone)") {

                    card.name = "instantiated3HandCard18";

                } else if (card.name == "instantiated3Card18a(Clone)") {

                    card.name = "instantiated3HandCard18a";

                } else if (card.name == "instantiated3Card18b(Clone)") {

                    card.name = "instantiated3HandCard18b";

                } else if (card.name == "instantiated3Card18c(Clone)") {

                    card.name = "instantiated3HandCard18c";

                } else if (card.name == "instantiated3Card19(Clone)") {

                    card.name = "instantiated3HandCard19";

                } else if (card.name == "instantiated3Card19a(Clone)") {

                    card.name = "instantiated3HandCard19a";

                } else if (card.name == "instantiated3Card19b(Clone)") {

                    card.name = "instantiated3HandCard19b";

                } else if (card.name == "instantiated3Card19c(Clone)") {

                    card.name = "instantiated3HandCard19c";

                } else if (card.name == "instantiated3Card20(Clone)") {

                    card.name = "instantiated3HandCard20";

                } else if (card.name == "instantiated3Card20a(Clone)") {

                    card.name = "instantiated3HandCard20a";

                } else if (card.name == "instantiated3Card20b(Clone)") {

                    card.name = "instantiated3HandCard20b";

                } else if (card.name == "instantiated3Card20c(Clone)") {

                    card.name = "instantiated3HandCard20c";

                } else if (card.name == "instantiated3Card21(Clone)") {

                    card.name = "instantiated3HandCard21";

                } else if (card.name == "instantiated3Card21a(Clone)") {

                    card.name = "instantiated3HandCard21a";

                } else if (card.name == "instantiated3Card21b(Clone)") {

                    card.name = "instantiated3HandCard21b";

                } else if (card.name == "instantiated3Card21c(Clone)") {

                    card.name = "instantiated3HandCard21c";

                } else if (card.name == "instantiated3Card22(Clone)") {

                    card.name = "instantiated3HandCard22";

                } else if (card.name == "instantiated3Card22a(Clone)") {

                    card.name = "instantiated3HandCard22a";

                } else if (card.name == "instantiated3Card22b(Clone)") {

                    card.name = "instantiated3HandCard22b";

                } else if (card.name == "instantiated3Card22c(Clone)") {

                    card.name = "instantiated3HandCard22c";

                } else if (card.name == "instantiated3Card23(Clone)") {

                    card.name = "instantiated3HandCard23";

                } else if (card.name == "instantiated3Card23a(Clone)") {

                    card.name = "instantiated3HandCard23a";

                } else if (card.name == "instantiated3Card23b(Clone)") {

                    card.name = "instantiated3HandCard23b";

                } else if (card.name == "instantiated3Card23c(Clone)") {

                    card.name = "instantiated3HandCard23c";

                } else if (card.name == "instantiated3Card24(Clone)") {

                    card.name = "instantiated3HandCard24";

                } else if (card.name == "instantiated3Card24a(Clone)") {

                    card.name = "instantiated3HandCard24a";

                } else if (card.name == "instantiated3Card24b(Clone)") {

                    card.name = "instantiated3HandCard24b";

                } else if (card.name == "instantiated3Card24c(Clone)") {

                    card.name = "instantiated3HandCard24c";

                } else if (card.name == "instantiated3Card25(Clone)") {

                    card.name = "instantiated3HandCard25";

                } else if (card.name == "instantiated3Card25a(Clone)") {

                    card.name = "instantiated3HandCard25a";

                } else if (card.name == "instantiated3Card25b(Clone)") {

                    card.name = "instantiated3HandCard25b";

                } else if (card.name == "instantiated3Card25c(Clone)") {

                    card.name = "instantiated3HandCard25c";

                } else if (card.name == "instantiated3Card26(Clone)") {

                    card.name = "instantiated3HandCard26";

                } else if (card.name == "instantiated3Card26a(Clone)") {

                    card.name = "instantiated3HandCard26a";

                } else if (card.name == "instantiated3Card26b(Clone)") {

                    card.name = "instantiated3HandCard26b";

                } else if (card.name == "instantiated3Card26c(Clone)") {

                    card.name = "instantiated3HandCard26c";

                } else if (card.name == "instantiated3Card27(Clone)") {

                    card.name = "instantiated3HandCard27";

                } else if (card.name == "instantiated3Card27a(Clone)") {

                    card.name = "instantiated3HandCard27a";

                } else if (card.name == "instantiated3Card27b(Clone)") {

                    card.name = "instantiated3HandCard27b";

                } else if (card.name == "instantiated3Card27c(Clone)") {

                    card.name = "instantiated3HandCard27c";

                } else if (card.name == "instantiated3Card28(Clone)") {

                    card.name = "instantiated3HandCard28";

                } else if (card.name == "instantiated3Card28a(Clone)") {

                    card.name = "instantiated3HandCard28a";

                } else if (card.name == "instantiated3Card28b(Clone)") {

                    card.name = "instantiated3HandCard28b";

                } else if (card.name == "instantiated3Card28c(Clone)") {

                    card.name = "instantiated3HandCard28c";

                } else if (card.name == "instantiated3Card29(Clone)") {

                    card.name = "instantiated3HandCard29";

                } else if (card.name == "instantiated3Card29a(Clone)") {

                    card.name = "instantiated3HandCard29a";

                } else if (card.name == "instantiated3Card29b(Clone)") {

                    card.name = "instantiated3HandCard29b";

                } else if (card.name == "instantiated3Card29c(Clone)") {

                    card.name = "instantiated3HandCard29c";

                } else if (card.name == "instantiated3Card30(Clone)") {

                    card.name = "instantiated3HandCard30";

                } else if (card.name == "instantiated3Card30a(Clone)") {

                    card.name = "instantiated3HandCard30a";

                } else if (card.name == "instantiated3Card30b(Clone)") {

                    card.name = "instantiated3HandCard30b";

                } else if (card.name == "instantiated3Card30c(Clone)") {

                    card.name = "instantiated3HandCard30c";

                } else if (card.name == "instantiated3Card31(Clone)") {

                    card.name = "instantiated3HandCard31";

                } else if (card.name == "instantiated3Card31a(Clone)") {

                    card.name = "instantiated3HandCard31a";

                } else if (card.name == "instantiated3Card31b(Clone)") {

                    card.name = "instantiated3HandCard31b";

                } else if (card.name == "instantiated3Card31c(Clone)") {

                    card.name = "instantiated3HandCard31c";

                } else if (card.name == "instantiated3Card32(Clone)") {

                    card.name = "instantiated3HandCard32";

                } else if (card.name == "instantiated3Card32a(Clone)") {

                    card.name = "instantiated3HandCard32a";

                } else if (card.name == "instantiated3Card32b(Clone)") {

                    card.name = "instantiated3HandCard32b";

                } else if (card.name == "instantiated3Card32c(Clone)") {

                    card.name = "instantiated3HandCard32c";

                } else if (card.name == "instantiated3Card33(Clone)") {

                    card.name = "instantiated3HandCard33";

                } else if (card.name == "instantiated3Card33a(Clone)") {

                    card.name = "instantiated3HandCard33a";

                } else if (card.name == "instantiated3Card33b(Clone)") {

                    card.name = "instantiated3HandCard33b";

                } else if (card.name == "instantiated3Card33c(Clone)") {

                    card.name = "instantiated3HandCard33c";

                } else if (card.name == "instantiated3Card34(Clone)") {

                    card.name = "instantiated3HandCard34";

                } else if (card.name == "instantiated3Card34a(Clone)") {

                    card.name = "instantiated3HandCard34a";

                } else if (card.name == "instantiated3Card34b(Clone)") {

                    card.name = "instantiated3HandCard34b";

                } else if (card.name == "instantiated3Card34c(Clone)") {

                    card.name = "instantiated3HandCard34c";

                } else if (card.name == "instantiated3Card35(Clone)") {

                    card.name = "instantiated3HandCard35";

                } else if (card.name == "instantiated3Card35a(Clone)") {

                    card.name = "instantiated3HandCard35a";

                } else if (card.name == "instantiated3Card35b(Clone)") {

                    card.name = "instantiated3HandCard35b";

                } else if (card.name == "instantiated3Card35c(Clone)") {

                    card.name = "instantiated3HandCard35c";

                } else if (card.name == "instantiated3Card36(Clone)") {

                    card.name = "instantiated3HandCard36";

                } else if (card.name == "instantiated3Card36a(Clone)") {

                    card.name = "instantiated3HandCard36a";

                } else if (card.name == "instantiated3Card36b(Clone)") {

                    card.name = "instantiated3HandCard36b";

                } else if (card.name == "instantiated3Card36c(Clone)") {

                    card.name = "instantiated3HandCard36c";

                } else if (card.name == "instantiated3Card37(Clone)") {

                    card.name = "instantiated3HandCard37";

                } else if (card.name == "instantiated3Card37a(Clone)") {

                    card.name = "instantiated3HandCard37a";

                } else if (card.name == "instantiated3Card37b(Clone)") {

                    card.name = "instantiated3HandCard37b";

                } else if (card.name == "instantiated3Card37c(Clone)") {

                    card.name = "instantiated3HandCard37c";

                } else if (card.name == "instantiated3Card38(Clone)") {

                    card.name = "instantiated3HandCard38";

                } else if (card.name == "instantiated3Card38a(Clone)") {

                    card.name = "instantiated3HandCard38a";

                } else if (card.name == "instantiated3Card38b(Clone)") {

                    card.name = "instantiated3HandCard38b";

                } else if (card.name == "instantiated3Card38c(Clone)") {

                    card.name = "instantiated3HandCard38c";

                } else if (card.name == "instantiated3Card39(Clone)") {

                    card.name = "instantiated3HandCard39";

                } else if (card.name == "instantiated3Card39a(Clone)") {

                    card.name = "instantiated3HandCard39a";

                } else if (card.name == "instantiated3Card39b(Clone)") {

                    card.name = "instantiated3HandCard39b";

                } else if (card.name == "instantiated3Card39c(Clone)") {

                    card.name = "instantiated3HandCard39c";

                } else if (card.name == "instantiated3Card40(Clone)") {

                    card.name = "instantiated3HandCard40";

                } else if (card.name == "instantiated3Card40a(Clone)") {

                    card.name = "instantiated3HandCard40a";

                } else if (card.name == "instantiated3Card40b(Clone)") {

                    card.name = "instantiated3HandCard40b";

                } else if (card.name == "instantiated3Card40c(Clone)") {

                    card.name = "instantiated3HandCard40c";

                } else if (card.name == "instantiated3Card41(Clone)") {

                    card.name = "instantiated3HandCard41";

                } else if (card.name == "instantiated3Card41a(Clone)") {

                    card.name = "instantiated3HandCard41a";

                } else if (card.name == "instantiated3Card41b(Clone)") {

                    card.name = "instantiated3HandCard41b";

                } else if (card.name == "instantiated3Card41c(Clone)") {

                    card.name = "instantiated3HandCard41c";

                } else if (card.name == "instantiated3Card42(Clone)") {

                    card.name = "instantiated3HandCard42";

                } else if (card.name == "instantiated3Card42a(Clone)") {

                    card.name = "instantiated3HandCard42a";

                } else if (card.name == "instantiated3Card42b(Clone)") {

                    card.name = "instantiated3HandCard42b";

                } else if (card.name == "instantiated3Card42c(Clone)") {

                    card.name = "instantiated3HandCard42c";

                } else if (card.name == "instantiated3Card43(Clone)") {

                    card.name = "instantiated3HandCard43";

                } else if (card.name == "instantiated3Card43a(Clone)") {

                    card.name = "instantiated3HandCard43a";

                } else if (card.name == "instantiated3Card43b(Clone)") {

                    card.name = "instantiated3HandCard43b";

                } else if (card.name == "instantiated3Card43c(Clone)") {

                    card.name = "instantiated3HandCard43c";

                } else if (card.name == "instantiated3Card44(Clone)") {

                    card.name = "instantiated3HandCard44";

                } else if (card.name == "instantiated3Card44a(Clone)") {

                    card.name = "instantiated3HandCard44a";

                } else if (card.name == "instantiated3Card44b(Clone)") {

                    card.name = "instantiated3HandCard44b";

                } else if (card.name == "instantiated3Card44c(Clone)") {

                    card.name = "instantiated3HandCard44c";

                } else if (card.name == "instantiated3Card45(Clone)") {

                    card.name = "instantiated3HandCard45";

                } else if (card.name == "instantiated3Card45a(Clone)") {

                    card.name = "instantiated3HandCard45a";

                } else if (card.name == "instantiated3Card45b(Clone)") {

                    card.name = "instantiated3HandCard45b";

                } else if (card.name == "instantiated3Card45c(Clone)") {

                    card.name = "instantiated3HandCard45c";

                } else if (card.name == "instantiated3Card46(Clone)") {

                    card.name = "instantiated3HandCard46";

                } else if (card.name == "instantiated3Card46a(Clone)") {

                    card.name = "instantiated3HandCard46a";

                } else if (card.name == "instantiated3Card46b(Clone)") {

                    card.name = "instantiated3HandCard46b";

                } else if (card.name == "instantiated3Card46c(Clone)") {

                    card.name = "instantiated3HandCard46c";

                } else if (card.name == "instantiated3Card47(Clone)") {

                    card.name = "instantiated3HandCard47";

                } else if (card.name == "instantiated3Card47a(Clone)") {

                    card.name = "instantiated3HandCard47a";

                } else if (card.name == "instantiated3Card47b(Clone)") {

                    card.name = "instantiated3HandCard47b";

                } else if (card.name == "instantiated3Card47c(Clone)") {

                    card.name = "instantiated3HandCard47c";

                } else if (card.name == "instantiated3Card48(Clone)") {

                    card.name = "instantiated3HandCard48";

                } else if (card.name == "instantiated3Card48a(Clone)") {

                    card.name = "instantiated3HandCard48a";

                } else if (card.name == "instantiated3Card48b(Clone)") {

                    card.name = "instantiated3HandCard48b";

                } else if (card.name == "instantiated3Card48c(Clone)") {

                    card.name = "instantiated3HandCard48c";

                } else if (card.name == "instantiated3Card49(Clone)") {

                    card.name = "instantiated3HandCard49";

                } else if (card.name == "instantiated3Card49a(Clone)") {

                    card.name = "instantiated3HandCard49a";

                } else if (card.name == "instantiated3Card49b(Clone)") {

                    card.name = "instantiated3HandCard49b";

                } else if (card.name == "instantiated3Card49c(Clone)") {

                    card.name = "instantiated3HandCard49c";

                } else if (card.name == "instantiated3Card50(Clone)") {

                    card.name = "instantiated3HandCard50";

                } else if (card.name == "instantiated3Card50a(Clone)") {

                    card.name = "instantiated3HandCard50a";

                } else if (card.name == "instantiated3Card50b(Clone)") {

                    card.name = "instantiated3HandCard50b";

                } else if (card.name == "instantiated3Card50c(Clone)") {

                    card.name = "instantiated3HandCard50c";

                } else if (card.name == "instantiated3Card51(Clone)") {

                    card.name = "instantiated3HandCard51";

                } else if (card.name == "instantiated3Card51a(Clone)") {

                    card.name = "instantiated3HandCard51a";

                } else if (card.name == "instantiated3Card51b(Clone)") {

                    card.name = "instantiated3HandCard51b";

                } else if (card.name == "instantiated3Card51c(Clone)") {

                    card.name = "instantiated3HandCard51c";

                } else if (card.name == "instantiated3Card52(Clone)") {

                    card.name = "instantiated3HandCard52";

                } else if (card.name == "instantiated3Card52a(Clone)") {

                    card.name = "instantiated3HandCard52a";

                } else if (card.name == "instantiated3Card52b(Clone)") {

                    card.name = "instantiated3HandCard52b";

                } else if (card.name == "instantiated3Card52c(Clone)") {

                    card.name = "instantiated3HandCard52c";

                } else if (card.name == "instantiated3Card53(Clone)") {

                    card.name = "instantiated3HandCard53";

                } else if (card.name == "instantiated3Card53a(Clone)") {

                    card.name = "instantiated3HandCard53a";

                } else if (card.name == "instantiated3Card53b(Clone)") {

                    card.name = "instantiated3HandCard53b";

                } else if (card.name == "instantiated3Card53c(Clone)") {

                    card.name = "instantiated3HandCard53c";

                } else if (card.name == "instantiated3Card54(Clone)") {

                    card.name = "instantiated3HandCard54";

                } else if (card.name == "instantiated3Card54a(Clone)") {

                    card.name = "instantiated3HandCard54a";

                } else if (card.name == "instantiated3Card54b(Clone)") {

                    card.name = "instantiated3HandCard54b";

                } else if (card.name == "instantiated3Card54c(Clone)") {

                    card.name = "instantiated3HandCard54c";

                } else if (card.name == "instantiated3Card55(Clone)") {

                    card.name = "instantiated3HandCard55";

                } else if (card.name == "instantiated3Card55a(Clone)") {

                    card.name = "instantiated3HandCard55a";

                } else if (card.name == "instantiated3Card55b(Clone)") {

                    card.name = "instantiated3HandCard55b";

                } else if (card.name == "instantiated3Card55c(Clone)") {

                    card.name = "instantiated3HandCard55c";

                } else if (card.name == "instantiated3Card56(Clone)") {

                    card.name = "instantiated3HandCard56";

                } else if (card.name == "instantiated3Card56a(Clone)") {

                    card.name = "instantiated3HandCard56a";

                } else if (card.name == "instantiated3Card56b(Clone)") {

                    card.name = "instantiated3HandCard56b";

                } else if (card.name == "instantiated3Card56c(Clone)") {

                    card.name = "instantiated3HandCard56c";

                } else if (card.name == "instantiated3Card57(Clone)") {

                    card.name = "instantiated3HandCard57";

                } else if (card.name == "instantiated3Card57a(Clone)") {

                    card.name = "instantiated3HandCard57a";

                } else if (card.name == "instantiated3Card57b(Clone)") {

                    card.name = "instantiated3HandCard57b";

                } else if (card.name == "instantiated3Card57c(Clone)") {

                    card.name = "instantiated3HandCard57c";

                } else if (card.name == "instantiated3Card58(Clone)") {

                    card.name = "instantiated3HandCard58";

                } else if (card.name == "instantiated3Card58a(Clone)") {

                    card.name = "instantiated3HandCard58a";

                } else if (card.name == "instantiated3Card58b(Clone)") {

                    card.name = "instantiated3HandCard58b";

                } else if (card.name == "instantiated3Card58c(Clone)") {

                    card.name = "instantiated3HandCard58c";

                } else if (card.name == "instantiated3Card59(Clone)") {

                    card.name = "instantiated3HandCard59";

                } else if (card.name == "instantiated3Card59a(Clone)") {

                    card.name = "instantiated3HandCard59a";

                } else if (card.name == "instantiated3Card59b(Clone)") {

                    card.name = "instantiated3HandCard59b";

                } else if (card.name == "instantiated3Card59c(Clone)") {

                    card.name = "instantiated3HandCard59c";

                } else if (card.name == "instantiated3Card60(Clone)") {

                    card.name = "instantiated3HandCard60";

                } else if (card.name == "instantiated3Card60a(Clone)") {

                    card.name = "instantiated3HandCard60a";

                } else if (card.name == "instantiated3Card60b(Clone)") {

                    card.name = "instantiated3HandCard60b";

                } else if (card.name == "instantiated3Card60c(Clone)") {

                    card.name = "instantiated3HandCard60c";
                }

                instances6++;

            }

            while (instances7 < NumberOfCards) {

                GameObject card = Instantiate(playCardsDeck3[UnityEngine.Random.Range(0, playCardsDeck3.Count)], player1DeckSlot7.transform.position, player1DeckSlot7.transform.rotation) as GameObject;
                card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                card.transform.parent = player1DeckSlot7.transform;

                if (card.name == "instantiated3Card1(Clone)") {

                    card.name = "instantiated3HandCard1";

                } else if (card.name == "instantiated3Card1a(Clone)") {

                    card.name = "instantiated3HandCard1a";

                } else if (card.name == "instantiated3Card1b(Clone)") {

                    card.name = "instantiated3HandCard1b";

                } else if (card.name == "instantiated3Card1c(Clone)") {

                    card.name = "instantiated3HandCard1c";

                } else if (card.name == "instantiated3Card2(Clone)") {

                    card.name = "instantiated3HandCard2";

                } else if (card.name == "instantiated3Card2a(Clone)") {

                    card.name = "instantiated3HandCard2a";

                } else if (card.name == "instantiated3Card2b(Clone)") {

                    card.name = "instantiated3HandCard2b";

                } else if (card.name == "instantiated3Card2c(Clone)") {

                    card.name = "instantiated3HandCard2c";

                } else if (card.name == "instantiated3Card3(Clone)") {

                    card.name = "instantiated3HandCard3";

                } else if (card.name == "instantiated3Card3a(Clone)") {

                    card.name = "instantiated3HandCard3a";

                } else if (card.name == "instantiated3Card3b(Clone)") {

                    card.name = "instantiated3HandCard3b";

                } else if (card.name == "instantiated3Card3c(Clone)") {

                    card.name = "instantiated3HandCard3c";

                } else if (card.name == "instantiated3Card4(Clone)") {

                    card.name = "instantiated3HandCard4";

                } else if (card.name == "instantiated3Card4a(Clone)") {

                    card.name = "instantiated3HandCard4a";

                } else if (card.name == "instantiated3Card4b(Clone)") {

                    card.name = "instantiated3HandCard4b";

                } else if (card.name == "instantiated3Card4c(Clone)") {

                    card.name = "instantiated3HandCard4c";

                } else if (card.name == "instantiated3Card5(Clone)") {

                    card.name = "instantiated3HandCard5";

                } else if (card.name == "instantiated3Card5a(Clone)") {

                    card.name = "instantiated3HandCard5a";

                } else if (card.name == "instantiated3Card5b(Clone)") {

                    card.name = "instantiated3HandCard5b";

                } else if (card.name == "instantiated3Card5c(Clone)") {

                    card.name = "instantiated3HandCard5c";

                } else if (card.name == "instantiated3Card6(Clone)") {

                    card.name = "instantiated3HandCard6";

                } else if (card.name == "instantiated3Card6a(Clone)") {

                    card.name = "instantiated3HandCard6a";

                } else if (card.name == "instantiated3Card6b(Clone)") {

                    card.name = "instantiated3HandCard6b";

                } else if (card.name == "instantiated3Card6c(Clone)") {

                    card.name = "instantiated3HandCard6c";

                } else if (card.name == "instantiated3Card7(Clone)") {

                    card.name = "instantiated3HandCard7";

                } else if (card.name == "instantiated3Card7a(Clone)") {

                    card.name = "instantiated3HandCard7a";

                } else if (card.name == "instantiated3Card7b(Clone)") {

                    card.name = "instantiated3HandCard7b";

                } else if (card.name == "instantiated3Card7c(Clone)") {

                    card.name = "instantiated3HandCard7c";

                } else if (card.name == "instantiated3Card8(Clone)") {

                    card.name = "instantiated3HandCard8";

                } else if (card.name == "instantiated3Card8a(Clone)") {

                    card.name = "instantiated3HandCard8a";

                } else if (card.name == "instantiated3Card8b(Clone)") {

                    card.name = "instantiated3HandCard8b";

                } else if (card.name == "instantiated3Card8c(Clone)") {

                    card.name = "instantiated3HandCard8c";

                } else if (card.name == "instantiated3Card9(Clone)") {

                    card.name = "instantiated3HandCard9";

                } else if (card.name == "instantiated3Card9a(Clone)") {

                    card.name = "instantiated3HandCard9a";

                } else if (card.name == "instantiated3Card9b(Clone)") {

                    card.name = "instantiated3HandCard9b";

                } else if (card.name == "instantiated3Card9c(Clone)") {

                    card.name = "instantiated3HandCard9c";

                } else if (card.name == "instantiated3Card10(Clone)") {

                    card.name = "instantiatedAICard10";

                } else if (card.name == "instantiated3Card10a(Clone)") {

                    card.name = "instantiated3HandCard10a";

                } else if (card.name == "instantiated3Card10b(Clone)") {

                    card.name = "instantiated3HandCard10b";

                } else if (card.name == "instantiated3Card10c(Clone)") {

                    card.name = "instantiated3HandCard10c";

                } else if (card.name == "instantiated3Card11(Clone)") {

                    card.name = "instantiated3HandCard11";

                } else if (card.name == "instantiated3Card11a(Clone)") {

                    card.name = "instantiated3HandCard11a";

                } else if (card.name == "instantiated3Card11b(Clone)") {

                    card.name = "instantiated3HandCard11b";

                } else if (card.name == "instantiated3Card11c(Clone)") {

                    card.name = "instantiated3HandCard11c";

                } else if (card.name == "instantiated3Card12(Clone)") {

                    card.name = "instantiated3HandCard12";

                } else if (card.name == "instantiated3Card12a(Clone)") {

                    card.name = "instantiated3HandCard12a";

                } else if (card.name == "instantiated3Card12b(Clone)") {

                    card.name = "instantiated3HandCard12b";

                } else if (card.name == "instantiated3Card12c(Clone)") {

                    card.name = "instantiated3HandCard12c";

                } else if (card.name == "instantiated3Card13(Clone)") {

                    card.name = "instantiated3HandCard13";

                } else if (card.name == "instantiated3Card13a(Clone)") {

                    card.name = "instantiated3HandCard13a";

                } else if (card.name == "instantiated3Card13b(Clone)") {

                    card.name = "instantiated3HandCard13b";

                } else if (card.name == "instantiated3Card13c(Clone)") {

                    card.name = "instantiated3HandCard13c";

                } else if (card.name == "instantiated3Card14(Clone)") {

                    card.name = "instantiated3HandCard14";

                } else if (card.name == "instantiated3Card14a(Clone)") {

                    card.name = "instantiated3HandCard14a";

                } else if (card.name == "instantiated3Card14b(Clone)") {

                    card.name = "instantiated3HandCard14b";

                } else if (card.name == "instantiated3Card14c(Clone)") {

                    card.name = "instantiated3HandCard14c";

                } else if (card.name == "instantiated3Card15(Clone)") {

                    card.name = "instantiated3HandCard15";

                } else if (card.name == "instantiated3Card15a(Clone)") {

                    card.name = "instantiated3HandCard15a";

                } else if (card.name == "instantiated3Card15b(Clone)") {

                    card.name = "instantiated3HandCard15b";

                } else if (card.name == "instantiated3Card15c(Clone)") {

                    card.name = "instantiated3HandCard15c";

                } else if (card.name == "instantiated3Card16(Clone)") {

                    card.name = "instantiated3HandCard16";

                } else if (card.name == "instantiated3Card16a(Clone)") {

                    card.name = "instantiated3HandCard16a";

                } else if (card.name == "instantiated3Card16b(Clone)") {

                    card.name = "instantiated3HandCard16b";

                } else if (card.name == "instantiated3Card16c(Clone)") {

                    card.name = "instantiated3HandCard16c";

                } else if (card.name == "instantiated3Card17(Clone)") {

                    card.name = "instantiated3HandCard17";

                } else if (card.name == "instantiated3Card17a(Clone)") {

                    card.name = "instantiated3HandCard17a";

                } else if (card.name == "instantiated3Card17b(Clone)") {

                    card.name = "instantiated3HandCard17b";

                } else if (card.name == "instantiated3Card17c(Clone)") {

                    card.name = "instantiated3HandCard17c";

                } else if (card.name == "instantiated3Card18(Clone)") {

                    card.name = "instantiated3HandCard18";

                } else if (card.name == "instantiated3Card18a(Clone)") {

                    card.name = "instantiated3HandCard18a";

                } else if (card.name == "instantiated3Card18b(Clone)") {

                    card.name = "instantiated3HandCard18b";

                } else if (card.name == "instantiated3Card18c(Clone)") {

                    card.name = "instantiated3HandCard18c";

                } else if (card.name == "instantiated3Card19(Clone)") {

                    card.name = "instantiated3HandCard19";

                } else if (card.name == "instantiated3Card19a(Clone)") {

                    card.name = "instantiated3HandCard19a";

                } else if (card.name == "instantiated3Card19b(Clone)") {

                    card.name = "instantiated3HandCard19b";

                } else if (card.name == "instantiated3Card19c(Clone)") {

                    card.name = "instantiated3HandCard19c";

                } else if (card.name == "instantiated3Card20(Clone)") {

                    card.name = "instantiated3HandCard20";

                } else if (card.name == "instantiated3Card20a(Clone)") {

                    card.name = "instantiated3HandCard20a";

                } else if (card.name == "instantiated3Card20b(Clone)") {

                    card.name = "instantiated3HandCard20b";

                } else if (card.name == "instantiated3Card20c(Clone)") {

                    card.name = "instantiated3HandCard20c";

                } else if (card.name == "instantiated3Card21(Clone)") {

                    card.name = "instantiated3HandCard21";

                } else if (card.name == "instantiated3Card21a(Clone)") {

                    card.name = "instantiated3HandCard21a";

                } else if (card.name == "instantiated3Card21b(Clone)") {

                    card.name = "instantiated3HandCard21b";

                } else if (card.name == "instantiated3Card21c(Clone)") {

                    card.name = "instantiated3HandCard21c";

                } else if (card.name == "instantiated3Card22(Clone)") {

                    card.name = "instantiated3HandCard22";

                } else if (card.name == "instantiated3Card22a(Clone)") {

                    card.name = "instantiated3HandCard22a";

                } else if (card.name == "instantiated3Card22b(Clone)") {

                    card.name = "instantiated3HandCard22b";

                } else if (card.name == "instantiated3Card22c(Clone)") {

                    card.name = "instantiated3HandCard22c";

                } else if (card.name == "instantiated3Card23(Clone)") {

                    card.name = "instantiated3HandCard23";

                } else if (card.name == "instantiated3Card23a(Clone)") {

                    card.name = "instantiated3HandCard23a";

                } else if (card.name == "instantiated3Card23b(Clone)") {

                    card.name = "instantiated3HandCard23b";

                } else if (card.name == "instantiated3Card23c(Clone)") {

                    card.name = "instantiated3HandCard23c";

                } else if (card.name == "instantiated3Card24(Clone)") {

                    card.name = "instantiated3HandCard24";

                } else if (card.name == "instantiated3Card24a(Clone)") {

                    card.name = "instantiated3HandCard24a";

                } else if (card.name == "instantiated3Card24b(Clone)") {

                    card.name = "instantiated3HandCard24b";

                } else if (card.name == "instantiated3Card24c(Clone)") {

                    card.name = "instantiated3HandCard24c";

                } else if (card.name == "instantiated3Card25(Clone)") {

                    card.name = "instantiated3HandCard25";

                } else if (card.name == "instantiated3Card25a(Clone)") {

                    card.name = "instantiated3HandCard25a";

                } else if (card.name == "instantiated3Card25b(Clone)") {

                    card.name = "instantiated3HandCard25b";

                } else if (card.name == "instantiated3Card25c(Clone)") {

                    card.name = "instantiated3HandCard25c";

                } else if (card.name == "instantiated3Card26(Clone)") {

                    card.name = "instantiated3HandCard26";

                } else if (card.name == "instantiated3Card26a(Clone)") {

                    card.name = "instantiated3HandCard26a";

                } else if (card.name == "instantiated3Card26b(Clone)") {

                    card.name = "instantiated3HandCard26b";

                } else if (card.name == "instantiated3Card26c(Clone)") {

                    card.name = "instantiated3HandCard26c";

                } else if (card.name == "instantiated3Card27(Clone)") {

                    card.name = "instantiated3HandCard27";

                } else if (card.name == "instantiated3Card27a(Clone)") {

                    card.name = "instantiated3HandCard27a";

                } else if (card.name == "instantiated3Card27b(Clone)") {

                    card.name = "instantiated3HandCard27b";

                } else if (card.name == "instantiated3Card27c(Clone)") {

                    card.name = "instantiated3HandCard27c";

                } else if (card.name == "instantiated3Card28(Clone)") {

                    card.name = "instantiated3HandCard28";

                } else if (card.name == "instantiated3Card28a(Clone)") {

                    card.name = "instantiated3HandCard28a";

                } else if (card.name == "instantiated3Card28b(Clone)") {

                    card.name = "instantiated3HandCard28b";

                } else if (card.name == "instantiated3Card28c(Clone)") {

                    card.name = "instantiated3HandCard28c";

                } else if (card.name == "instantiated3Card29(Clone)") {

                    card.name = "instantiated3HandCard29";

                } else if (card.name == "instantiated3Card29a(Clone)") {

                    card.name = "instantiated3HandCard29a";

                } else if (card.name == "instantiated3Card29b(Clone)") {

                    card.name = "instantiated3HandCard29b";

                } else if (card.name == "instantiated3Card29c(Clone)") {

                    card.name = "instantiated3HandCard29c";

                } else if (card.name == "instantiated3Card30(Clone)") {

                    card.name = "instantiated3HandCard30";

                } else if (card.name == "instantiated3Card30a(Clone)") {

                    card.name = "instantiated3HandCard30a";

                } else if (card.name == "instantiated3Card30b(Clone)") {

                    card.name = "instantiated3HandCard30b";

                } else if (card.name == "instantiated3Card30c(Clone)") {

                    card.name = "instantiated3HandCard30c";

                } else if (card.name == "instantiated3Card31(Clone)") {

                    card.name = "instantiated3HandCard31";

                } else if (card.name == "instantiated3Card31a(Clone)") {

                    card.name = "instantiated3HandCard31a";

                } else if (card.name == "instantiated3Card31b(Clone)") {

                    card.name = "instantiated3HandCard31b";

                } else if (card.name == "instantiated3Card31c(Clone)") {

                    card.name = "instantiated3HandCard31c";

                } else if (card.name == "instantiated3Card32(Clone)") {

                    card.name = "instantiated3HandCard32";

                } else if (card.name == "instantiated3Card32a(Clone)") {

                    card.name = "instantiated3HandCard32a";

                } else if (card.name == "instantiated3Card32b(Clone)") {

                    card.name = "instantiated3HandCard32b";

                } else if (card.name == "instantiated3Card32c(Clone)") {

                    card.name = "instantiated3HandCard32c";

                } else if (card.name == "instantiated3Card33(Clone)") {

                    card.name = "instantiated3HandCard33";

                } else if (card.name == "instantiated3Card33a(Clone)") {

                    card.name = "instantiated3HandCard33a";

                } else if (card.name == "instantiated3Card33b(Clone)") {

                    card.name = "instantiated3HandCard33b";

                } else if (card.name == "instantiated3Card33c(Clone)") {

                    card.name = "instantiated3HandCard33c";

                } else if (card.name == "instantiated3Card34(Clone)") {

                    card.name = "instantiated3HandCard34";

                } else if (card.name == "instantiated3Card34a(Clone)") {

                    card.name = "instantiated3HandCard34a";

                } else if (card.name == "instantiated3Card34b(Clone)") {

                    card.name = "instantiated3HandCard34b";

                } else if (card.name == "instantiated3Card34c(Clone)") {

                    card.name = "instantiated3HandCard34c";

                } else if (card.name == "instantiated3Card35(Clone)") {

                    card.name = "instantiated3HandCard35";

                } else if (card.name == "instantiated3Card35a(Clone)") {

                    card.name = "instantiated3HandCard35a";

                } else if (card.name == "instantiated3Card35b(Clone)") {

                    card.name = "instantiated3HandCard35b";

                } else if (card.name == "instantiated3Card35c(Clone)") {

                    card.name = "instantiated3HandCard35c";

                } else if (card.name == "instantiated3Card36(Clone)") {

                    card.name = "instantiated3HandCard36";

                } else if (card.name == "instantiated3Card36a(Clone)") {

                    card.name = "instantiated3HandCard36a";

                } else if (card.name == "instantiated3Card36b(Clone)") {

                    card.name = "instantiated3HandCard36b";

                } else if (card.name == "instantiated3Card36c(Clone)") {

                    card.name = "instantiated3HandCard36c";

                } else if (card.name == "instantiated3Card37(Clone)") {

                    card.name = "instantiated3HandCard37";

                } else if (card.name == "instantiated3Card37a(Clone)") {

                    card.name = "instantiated3HandCard37a";

                } else if (card.name == "instantiated3Card37b(Clone)") {

                    card.name = "instantiated3HandCard37b";

                } else if (card.name == "instantiated3Card37c(Clone)") {

                    card.name = "instantiated3HandCard37c";

                } else if (card.name == "instantiated3Card38(Clone)") {

                    card.name = "instantiated3HandCard38";

                } else if (card.name == "instantiated3Card38a(Clone)") {

                    card.name = "instantiated3HandCard38a";

                } else if (card.name == "instantiated3Card38b(Clone)") {

                    card.name = "instantiated3HandCard38b";

                } else if (card.name == "instantiated3Card38c(Clone)") {

                    card.name = "instantiated3HandCard38c";

                } else if (card.name == "instantiated3Card39(Clone)") {

                    card.name = "instantiated3HandCard39";

                } else if (card.name == "instantiated3Card39a(Clone)") {

                    card.name = "instantiated3HandCard39a";

                } else if (card.name == "instantiated3Card39b(Clone)") {

                    card.name = "instantiated3HandCard39b";

                } else if (card.name == "instantiated3Card39c(Clone)") {

                    card.name = "instantiated3HandCard39c";

                } else if (card.name == "instantiated3Card40(Clone)") {

                    card.name = "instantiated3HandCard40";

                } else if (card.name == "instantiated3Card40a(Clone)") {

                    card.name = "instantiated3HandCard40a";

                } else if (card.name == "instantiated3Card40b(Clone)") {

                    card.name = "instantiated3HandCard40b";

                } else if (card.name == "instantiated3Card40c(Clone)") {

                    card.name = "instantiated3HandCard40c";

                } else if (card.name == "instantiated3Card41(Clone)") {

                    card.name = "instantiated3HandCard41";

                } else if (card.name == "instantiated3Card41a(Clone)") {

                    card.name = "instantiated3HandCard41a";

                } else if (card.name == "instantiated3Card41b(Clone)") {

                    card.name = "instantiated3HandCard41b";

                } else if (card.name == "instantiated3Card41c(Clone)") {

                    card.name = "instantiated3HandCard41c";

                } else if (card.name == "instantiated3Card42(Clone)") {

                    card.name = "instantiated3HandCard42";

                } else if (card.name == "instantiated3Card42a(Clone)") {

                    card.name = "instantiated3HandCard42a";

                } else if (card.name == "instantiated3Card42b(Clone)") {

                    card.name = "instantiated3HandCard42b";

                } else if (card.name == "instantiated3Card42c(Clone)") {

                    card.name = "instantiated3HandCard42c";

                } else if (card.name == "instantiated3Card43(Clone)") {

                    card.name = "instantiated3HandCard43";

                } else if (card.name == "instantiated3Card43a(Clone)") {

                    card.name = "instantiated3HandCard43a";

                } else if (card.name == "instantiated3Card43b(Clone)") {

                    card.name = "instantiated3HandCard43b";

                } else if (card.name == "instantiated3Card43c(Clone)") {

                    card.name = "instantiated3HandCard43c";

                } else if (card.name == "instantiated3Card44(Clone)") {

                    card.name = "instantiated3HandCard44";

                } else if (card.name == "instantiated3Card44a(Clone)") {

                    card.name = "instantiated3HandCard44a";

                } else if (card.name == "instantiated3Card44b(Clone)") {

                    card.name = "instantiated3HandCard44b";

                } else if (card.name == "instantiated3Card44c(Clone)") {

                    card.name = "instantiated3HandCard44c";

                } else if (card.name == "instantiated3Card45(Clone)") {

                    card.name = "instantiated3HandCard45";

                } else if (card.name == "instantiated3Card45a(Clone)") {

                    card.name = "instantiated3HandCard45a";

                } else if (card.name == "instantiated3Card45b(Clone)") {

                    card.name = "instantiated3HandCard45b";

                } else if (card.name == "instantiated3Card45c(Clone)") {

                    card.name = "instantiated3HandCard45c";

                } else if (card.name == "instantiated3Card46(Clone)") {

                    card.name = "instantiated3HandCard46";

                } else if (card.name == "instantiated3Card46a(Clone)") {

                    card.name = "instantiated3HandCard46a";

                } else if (card.name == "instantiated3Card46b(Clone)") {

                    card.name = "instantiated3HandCard46b";

                } else if (card.name == "instantiated3Card46c(Clone)") {

                    card.name = "instantiated3HandCard46c";

                } else if (card.name == "instantiated3Card47(Clone)") {

                    card.name = "instantiated3HandCard47";

                } else if (card.name == "instantiated3Card47a(Clone)") {

                    card.name = "instantiated3HandCard47a";

                } else if (card.name == "instantiated3Card47b(Clone)") {

                    card.name = "instantiated3HandCard47b";

                } else if (card.name == "instantiated3Card47c(Clone)") {

                    card.name = "instantiated3HandCard47c";

                } else if (card.name == "instantiated3Card48(Clone)") {

                    card.name = "instantiated3HandCard48";

                } else if (card.name == "instantiated3Card48a(Clone)") {

                    card.name = "instantiated3HandCard48a";

                } else if (card.name == "instantiated3Card48b(Clone)") {

                    card.name = "instantiated3HandCard48b";

                } else if (card.name == "instantiated3Card48c(Clone)") {

                    card.name = "instantiated3HandCard48c";

                } else if (card.name == "instantiated3Card49(Clone)") {

                    card.name = "instantiated3HandCard49";

                } else if (card.name == "instantiated3Card49a(Clone)") {

                    card.name = "instantiated3HandCard49a";

                } else if (card.name == "instantiated3Card49b(Clone)") {

                    card.name = "instantiated3HandCard49b";

                } else if (card.name == "instantiated3Card49c(Clone)") {

                    card.name = "instantiated3HandCard49c";

                } else if (card.name == "instantiated3Card50(Clone)") {

                    card.name = "instantiated3HandCard50";

                } else if (card.name == "instantiated3Card50a(Clone)") {

                    card.name = "instantiated3HandCard50a";

                } else if (card.name == "instantiated3Card50b(Clone)") {

                    card.name = "instantiated3HandCard50b";

                } else if (card.name == "instantiated3Card50c(Clone)") {

                    card.name = "instantiated3HandCard50c";

                } else if (card.name == "instantiated3Card51(Clone)") {

                    card.name = "instantiated3HandCard51";

                } else if (card.name == "instantiated3Card51a(Clone)") {

                    card.name = "instantiated3HandCard51a";

                } else if (card.name == "instantiated3Card51b(Clone)") {

                    card.name = "instantiated3HandCard51b";

                } else if (card.name == "instantiated3Card51c(Clone)") {

                    card.name = "instantiated3HandCard51c";

                } else if (card.name == "instantiated3Card52(Clone)") {

                    card.name = "instantiated3HandCard52";

                } else if (card.name == "instantiated3Card52a(Clone)") {

                    card.name = "instantiated3HandCard52a";

                } else if (card.name == "instantiated3Card52b(Clone)") {

                    card.name = "instantiated3HandCard52b";

                } else if (card.name == "instantiated3Card52c(Clone)") {

                    card.name = "instantiated3HandCard52c";

                } else if (card.name == "instantiated3Card53(Clone)") {

                    card.name = "instantiated3HandCard53";

                } else if (card.name == "instantiated3Card53a(Clone)") {

                    card.name = "instantiated3HandCard53a";

                } else if (card.name == "instantiated3Card53b(Clone)") {

                    card.name = "instantiated3HandCard53b";

                } else if (card.name == "instantiated3Card53c(Clone)") {

                    card.name = "instantiated3HandCard53c";

                } else if (card.name == "instantiated3Card54(Clone)") {

                    card.name = "instantiated3HandCard54";

                } else if (card.name == "instantiated3Card54a(Clone)") {

                    card.name = "instantiated3HandCard54a";

                } else if (card.name == "instantiated3Card54b(Clone)") {

                    card.name = "instantiated3HandCard54b";

                } else if (card.name == "instantiated3Card54c(Clone)") {

                    card.name = "instantiated3HandCard54c";

                } else if (card.name == "instantiated3Card55(Clone)") {

                    card.name = "instantiated3HandCard55";

                } else if (card.name == "instantiated3Card55a(Clone)") {

                    card.name = "instantiated3HandCard55a";

                } else if (card.name == "instantiated3Card55b(Clone)") {

                    card.name = "instantiated3HandCard55b";

                } else if (card.name == "instantiated3Card55c(Clone)") {

                    card.name = "instantiated3HandCard55c";

                } else if (card.name == "instantiated3Card56(Clone)") {

                    card.name = "instantiated3HandCard56";

                } else if (card.name == "instantiated3Card56a(Clone)") {

                    card.name = "instantiated3HandCard56a";

                } else if (card.name == "instantiated3Card56b(Clone)") {

                    card.name = "instantiated3HandCard56b";

                } else if (card.name == "instantiated3Card56c(Clone)") {

                    card.name = "instantiated3HandCard56c";

                } else if (card.name == "instantiated3Card57(Clone)") {

                    card.name = "instantiated3HandCard57";

                } else if (card.name == "instantiated3Card57a(Clone)") {

                    card.name = "instantiated3HandCard57a";

                } else if (card.name == "instantiated3Card57b(Clone)") {

                    card.name = "instantiated3HandCard57b";

                } else if (card.name == "instantiated3Card57c(Clone)") {

                    card.name = "instantiated3HandCard57c";

                } else if (card.name == "instantiated3Card58(Clone)") {

                    card.name = "instantiated3HandCard58";

                } else if (card.name == "instantiated3Card58a(Clone)") {

                    card.name = "instantiated3HandCard58a";

                } else if (card.name == "instantiated3Card58b(Clone)") {

                    card.name = "instantiated3HandCard58b";

                } else if (card.name == "instantiated3Card58c(Clone)") {

                    card.name = "instantiated3HandCard58c";

                } else if (card.name == "instantiated3Card59(Clone)") {

                    card.name = "instantiated3HandCard59";

                } else if (card.name == "instantiated3Card59a(Clone)") {

                    card.name = "instantiated3HandCard59a";

                } else if (card.name == "instantiated3Card59b(Clone)") {

                    card.name = "instantiated3HandCard59b";

                } else if (card.name == "instantiated3Card59c(Clone)") {

                    card.name = "instantiated3HandCard59c";

                } else if (card.name == "instantiated3Card60(Clone)") {

                    card.name = "instantiated3HandCard60";

                } else if (card.name == "instantiated3Card60a(Clone)") {

                    card.name = "instantiated3HandCard60a";

                } else if (card.name == "instantiated3Card60b(Clone)") {

                    card.name = "instantiated3HandCard60b";

                } else if (card.name == "instantiated3Card60c(Clone)") {

                    card.name = "instantiated3HandCard60c";
                }

                instances7++;

            }

            while (instances8 < NumberOfCards) {

                GameObject card = Instantiate(playCardsDeck3[UnityEngine.Random.Range(0, playCardsDeck3.Count)], player1DeckSlot8.transform.position, player1DeckSlot8.transform.rotation) as GameObject;
                card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                card.transform.parent = player1DeckSlot8.transform;

                if (card.name == "instantiated3Card1(Clone)") {

                    card.name = "instantiated3HandCard1";

                } else if (card.name == "instantiated3Card1a(Clone)") {

                    card.name = "instantiated3HandCard1a";

                } else if (card.name == "instantiated3Card1b(Clone)") {

                    card.name = "instantiated3HandCard1b";

                } else if (card.name == "instantiated3Card1c(Clone)") {

                    card.name = "instantiated3HandCard1c";

                } else if (card.name == "instantiated3Card2(Clone)") {

                    card.name = "instantiated3HandCard2";

                } else if (card.name == "instantiated3Card2a(Clone)") {

                    card.name = "instantiated3HandCard2a";

                } else if (card.name == "instantiated3Card2b(Clone)") {

                    card.name = "instantiated3HandCard2b";

                } else if (card.name == "instantiated3Card2c(Clone)") {

                    card.name = "instantiated3HandCard2c";

                } else if (card.name == "instantiated3Card3(Clone)") {

                    card.name = "instantiated3HandCard3";

                } else if (card.name == "instantiated3Card3a(Clone)") {

                    card.name = "instantiated3HandCard3a";

                } else if (card.name == "instantiated3Card3b(Clone)") {

                    card.name = "instantiated3HandCard3b";

                } else if (card.name == "instantiated3Card3c(Clone)") {

                    card.name = "instantiated3HandCard3c";

                } else if (card.name == "instantiated3Card4(Clone)") {

                    card.name = "instantiated3HandCard4";

                } else if (card.name == "instantiated3Card4a(Clone)") {

                    card.name = "instantiated3HandCard4a";

                } else if (card.name == "instantiated3Card4b(Clone)") {

                    card.name = "instantiated3HandCard4b";

                } else if (card.name == "instantiated3Card4c(Clone)") {

                    card.name = "instantiated3HandCard4c";

                } else if (card.name == "instantiated3Card5(Clone)") {

                    card.name = "instantiated3HandCard5";

                } else if (card.name == "instantiated3Card5a(Clone)") {

                    card.name = "instantiated3HandCard5a";

                } else if (card.name == "instantiated3Card5b(Clone)") {

                    card.name = "instantiated3HandCard5b";

                } else if (card.name == "instantiated3Card5c(Clone)") {

                    card.name = "instantiated3HandCard5c";

                } else if (card.name == "instantiated3Card6(Clone)") {

                    card.name = "instantiated3HandCard6";

                } else if (card.name == "instantiated3Card6a(Clone)") {

                    card.name = "instantiated3HandCard6a";

                } else if (card.name == "instantiated3Card6b(Clone)") {

                    card.name = "instantiated3HandCard6b";

                } else if (card.name == "instantiated3Card6c(Clone)") {

                    card.name = "instantiated3HandCard6c";

                } else if (card.name == "instantiated3Card7(Clone)") {

                    card.name = "instantiated3HandCard7";

                } else if (card.name == "instantiated3Card7a(Clone)") {

                    card.name = "instantiated3HandCard7a";

                } else if (card.name == "instantiated3Card7b(Clone)") {

                    card.name = "instantiated3HandCard7b";

                } else if (card.name == "instantiated3Card7c(Clone)") {

                    card.name = "instantiated3HandCard7c";

                } else if (card.name == "instantiated3Card8(Clone)") {

                    card.name = "instantiated3HandCard8";

                } else if (card.name == "instantiated3Card8a(Clone)") {

                    card.name = "instantiated3HandCard8a";

                } else if (card.name == "instantiated3Card8b(Clone)") {

                    card.name = "instantiated3HandCard8b";

                } else if (card.name == "instantiated3Card8c(Clone)") {

                    card.name = "instantiated3HandCard8c";

                } else if (card.name == "instantiated3Card9(Clone)") {

                    card.name = "instantiated3HandCard9";

                } else if (card.name == "instantiated3Card9a(Clone)") {

                    card.name = "instantiated3HandCard9a";

                } else if (card.name == "instantiated3Card9b(Clone)") {

                    card.name = "instantiated3HandCard9b";

                } else if (card.name == "instantiated3Card9c(Clone)") {

                    card.name = "instantiated3HandCard9c";

                } else if (card.name == "instantiated3Card10(Clone)") {

                    card.name = "instantiatedAICard10";

                } else if (card.name == "instantiated3Card10a(Clone)") {

                    card.name = "instantiated3HandCard10a";

                } else if (card.name == "instantiated3Card10b(Clone)") {

                    card.name = "instantiated3HandCard10b";

                } else if (card.name == "instantiated3Card10c(Clone)") {

                    card.name = "instantiated3HandCard10c";

                } else if (card.name == "instantiated3Card11(Clone)") {

                    card.name = "instantiated3HandCard11";

                } else if (card.name == "instantiated3Card11a(Clone)") {

                    card.name = "instantiated3HandCard11a";

                } else if (card.name == "instantiated3Card11b(Clone)") {

                    card.name = "instantiated3HandCard11b";

                } else if (card.name == "instantiated3Card11c(Clone)") {

                    card.name = "instantiated3HandCard11c";

                } else if (card.name == "instantiated3Card12(Clone)") {

                    card.name = "instantiated3HandCard12";

                } else if (card.name == "instantiated3Card12a(Clone)") {

                    card.name = "instantiated3HandCard12a";

                } else if (card.name == "instantiated3Card12b(Clone)") {

                    card.name = "instantiated3HandCard12b";

                } else if (card.name == "instantiated3Card12c(Clone)") {

                    card.name = "instantiated3HandCard12c";

                } else if (card.name == "instantiated3Card13(Clone)") {

                    card.name = "instantiated3HandCard13";

                } else if (card.name == "instantiated3Card13a(Clone)") {

                    card.name = "instantiated3HandCard13a";

                } else if (card.name == "instantiated3Card13b(Clone)") {

                    card.name = "instantiated3HandCard13b";

                } else if (card.name == "instantiated3Card13c(Clone)") {

                    card.name = "instantiated3HandCard13c";

                } else if (card.name == "instantiated3Card14(Clone)") {

                    card.name = "instantiated3HandCard14";

                } else if (card.name == "instantiated3Card14a(Clone)") {

                    card.name = "instantiated3HandCard14a";

                } else if (card.name == "instantiated3Card14b(Clone)") {

                    card.name = "instantiated3HandCard14b";

                } else if (card.name == "instantiated3Card14c(Clone)") {

                    card.name = "instantiated3HandCard14c";

                } else if (card.name == "instantiated3Card15(Clone)") {

                    card.name = "instantiated3HandCard15";

                } else if (card.name == "instantiated3Card15a(Clone)") {

                    card.name = "instantiated3HandCard15a";

                } else if (card.name == "instantiated3Card15b(Clone)") {

                    card.name = "instantiated3HandCard15b";

                } else if (card.name == "instantiated3Card15c(Clone)") {

                    card.name = "instantiated3HandCard15c";

                } else if (card.name == "instantiated3Card16(Clone)") {

                    card.name = "instantiated3HandCard16";

                } else if (card.name == "instantiated3Card16a(Clone)") {

                    card.name = "instantiated3HandCard16a";

                } else if (card.name == "instantiated3Card16b(Clone)") {

                    card.name = "instantiated3HandCard16b";

                } else if (card.name == "instantiated3Card16c(Clone)") {

                    card.name = "instantiated3HandCard16c";

                } else if (card.name == "instantiated3Card17(Clone)") {

                    card.name = "instantiated3HandCard17";

                } else if (card.name == "instantiated3Card17a(Clone)") {

                    card.name = "instantiated3HandCard17a";

                } else if (card.name == "instantiated3Card17b(Clone)") {

                    card.name = "instantiated3HandCard17b";

                } else if (card.name == "instantiated3Card17c(Clone)") {

                    card.name = "instantiated3HandCard17c";

                } else if (card.name == "instantiated3Card18(Clone)") {

                    card.name = "instantiated3HandCard18";

                } else if (card.name == "instantiated3Card18a(Clone)") {

                    card.name = "instantiated3HandCard18a";

                } else if (card.name == "instantiated3Card18b(Clone)") {

                    card.name = "instantiated3HandCard18b";

                } else if (card.name == "instantiated3Card18c(Clone)") {

                    card.name = "instantiated3HandCard18c";

                } else if (card.name == "instantiated3Card19(Clone)") {

                    card.name = "instantiated3HandCard19";

                } else if (card.name == "instantiated3Card19a(Clone)") {

                    card.name = "instantiated3HandCard19a";

                } else if (card.name == "instantiated3Card19b(Clone)") {

                    card.name = "instantiated3HandCard19b";

                } else if (card.name == "instantiated3Card19c(Clone)") {

                    card.name = "instantiated3HandCard19c";

                } else if (card.name == "instantiated3Card20(Clone)") {

                    card.name = "instantiated3HandCard20";

                } else if (card.name == "instantiated3Card20a(Clone)") {

                    card.name = "instantiated3HandCard20a";

                } else if (card.name == "instantiated3Card20b(Clone)") {

                    card.name = "instantiated3HandCard20b";

                } else if (card.name == "instantiated3Card20c(Clone)") {

                    card.name = "instantiated3HandCard20c";

                } else if (card.name == "instantiated3Card21(Clone)") {

                    card.name = "instantiated3HandCard21";

                } else if (card.name == "instantiated3Card21a(Clone)") {

                    card.name = "instantiated3HandCard21a";

                } else if (card.name == "instantiated3Card21b(Clone)") {

                    card.name = "instantiated3HandCard21b";

                } else if (card.name == "instantiated3Card21c(Clone)") {

                    card.name = "instantiated3HandCard21c";

                } else if (card.name == "instantiated3Card22(Clone)") {

                    card.name = "instantiated3HandCard22";

                } else if (card.name == "instantiated3Card22a(Clone)") {

                    card.name = "instantiated3HandCard22a";

                } else if (card.name == "instantiated3Card22b(Clone)") {

                    card.name = "instantiated3HandCard22b";

                } else if (card.name == "instantiated3Card22c(Clone)") {

                    card.name = "instantiated3HandCard22c";

                } else if (card.name == "instantiated3Card23(Clone)") {

                    card.name = "instantiated3HandCard23";

                } else if (card.name == "instantiated3Card23a(Clone)") {

                    card.name = "instantiated3HandCard23a";

                } else if (card.name == "instantiated3Card23b(Clone)") {

                    card.name = "instantiated3HandCard23b";

                } else if (card.name == "instantiated3Card23c(Clone)") {

                    card.name = "instantiated3HandCard23c";

                } else if (card.name == "instantiated3Card24(Clone)") {

                    card.name = "instantiated3HandCard24";

                } else if (card.name == "instantiated3Card24a(Clone)") {

                    card.name = "instantiated3HandCard24a";

                } else if (card.name == "instantiated3Card24b(Clone)") {

                    card.name = "instantiated3HandCard24b";

                } else if (card.name == "instantiated3Card24c(Clone)") {

                    card.name = "instantiated3HandCard24c";

                } else if (card.name == "instantiated3Card25(Clone)") {

                    card.name = "instantiated3HandCard25";

                } else if (card.name == "instantiated3Card25a(Clone)") {

                    card.name = "instantiated3HandCard25a";

                } else if (card.name == "instantiated3Card25b(Clone)") {

                    card.name = "instantiated3HandCard25b";

                } else if (card.name == "instantiated3Card25c(Clone)") {

                    card.name = "instantiated3HandCard25c";

                } else if (card.name == "instantiated3Card26(Clone)") {

                    card.name = "instantiated3HandCard26";

                } else if (card.name == "instantiated3Card26a(Clone)") {

                    card.name = "instantiated3HandCard26a";

                } else if (card.name == "instantiated3Card26b(Clone)") {

                    card.name = "instantiated3HandCard26b";

                } else if (card.name == "instantiated3Card26c(Clone)") {

                    card.name = "instantiated3HandCard26c";

                } else if (card.name == "instantiated3Card27(Clone)") {

                    card.name = "instantiated3HandCard27";

                } else if (card.name == "instantiated3Card27a(Clone)") {

                    card.name = "instantiated3HandCard27a";

                } else if (card.name == "instantiated3Card27b(Clone)") {

                    card.name = "instantiated3HandCard27b";

                } else if (card.name == "instantiated3Card27c(Clone)") {

                    card.name = "instantiated3HandCard27c";

                } else if (card.name == "instantiated3Card28(Clone)") {

                    card.name = "instantiated3HandCard28";

                } else if (card.name == "instantiated3Card28a(Clone)") {

                    card.name = "instantiated3HandCard28a";

                } else if (card.name == "instantiated3Card28b(Clone)") {

                    card.name = "instantiated3HandCard28b";

                } else if (card.name == "instantiated3Card28c(Clone)") {

                    card.name = "instantiated3HandCard28c";

                } else if (card.name == "instantiated3Card29(Clone)") {

                    card.name = "instantiated3HandCard29";

                } else if (card.name == "instantiated3Card29a(Clone)") {

                    card.name = "instantiated3HandCard29a";

                } else if (card.name == "instantiated3Card29b(Clone)") {

                    card.name = "instantiated3HandCard29b";

                } else if (card.name == "instantiated3Card29c(Clone)") {

                    card.name = "instantiated3HandCard29c";

                } else if (card.name == "instantiated3Card30(Clone)") {

                    card.name = "instantiated3HandCard30";

                } else if (card.name == "instantiated3Card30a(Clone)") {

                    card.name = "instantiated3HandCard30a";

                } else if (card.name == "instantiated3Card30b(Clone)") {

                    card.name = "instantiated3HandCard30b";

                } else if (card.name == "instantiated3Card30c(Clone)") {

                    card.name = "instantiated3HandCard30c";

                } else if (card.name == "instantiated3Card31(Clone)") {

                    card.name = "instantiated3HandCard31";

                } else if (card.name == "instantiated3Card31a(Clone)") {

                    card.name = "instantiated3HandCard31a";

                } else if (card.name == "instantiated3Card31b(Clone)") {

                    card.name = "instantiated3HandCard31b";

                } else if (card.name == "instantiated3Card31c(Clone)") {

                    card.name = "instantiated3HandCard31c";

                } else if (card.name == "instantiated3Card32(Clone)") {

                    card.name = "instantiated3HandCard32";

                } else if (card.name == "instantiated3Card32a(Clone)") {

                    card.name = "instantiated3HandCard32a";

                } else if (card.name == "instantiated3Card32b(Clone)") {

                    card.name = "instantiated3HandCard32b";

                } else if (card.name == "instantiated3Card32c(Clone)") {

                    card.name = "instantiated3HandCard32c";

                } else if (card.name == "instantiated3Card33(Clone)") {

                    card.name = "instantiated3HandCard33";

                } else if (card.name == "instantiated3Card33a(Clone)") {

                    card.name = "instantiated3HandCard33a";

                } else if (card.name == "instantiated3Card33b(Clone)") {

                    card.name = "instantiated3HandCard33b";

                } else if (card.name == "instantiated3Card33c(Clone)") {

                    card.name = "instantiated3HandCard33c";

                } else if (card.name == "instantiated3Card34(Clone)") {

                    card.name = "instantiated3HandCard34";

                } else if (card.name == "instantiated3Card34a(Clone)") {

                    card.name = "instantiated3HandCard34a";

                } else if (card.name == "instantiated3Card34b(Clone)") {

                    card.name = "instantiated3HandCard34b";

                } else if (card.name == "instantiated3Card34c(Clone)") {

                    card.name = "instantiated3HandCard34c";

                } else if (card.name == "instantiated3Card35(Clone)") {

                    card.name = "instantiated3HandCard35";

                } else if (card.name == "instantiated3Card35a(Clone)") {

                    card.name = "instantiated3HandCard35a";

                } else if (card.name == "instantiated3Card35b(Clone)") {

                    card.name = "instantiated3HandCard35b";

                } else if (card.name == "instantiated3Card35c(Clone)") {

                    card.name = "instantiated3HandCard35c";

                } else if (card.name == "instantiated3Card36(Clone)") {

                    card.name = "instantiated3HandCard36";

                } else if (card.name == "instantiated3Card36a(Clone)") {

                    card.name = "instantiated3HandCard36a";

                } else if (card.name == "instantiated3Card36b(Clone)") {

                    card.name = "instantiated3HandCard36b";

                } else if (card.name == "instantiated3Card36c(Clone)") {

                    card.name = "instantiated3HandCard36c";

                } else if (card.name == "instantiated3Card37(Clone)") {

                    card.name = "instantiated3HandCard37";

                } else if (card.name == "instantiated3Card37a(Clone)") {

                    card.name = "instantiated3HandCard37a";

                } else if (card.name == "instantiated3Card37b(Clone)") {

                    card.name = "instantiated3HandCard37b";

                } else if (card.name == "instantiated3Card37c(Clone)") {

                    card.name = "instantiated3HandCard37c";

                } else if (card.name == "instantiated3Card38(Clone)") {

                    card.name = "instantiated3HandCard38";

                } else if (card.name == "instantiated3Card38a(Clone)") {

                    card.name = "instantiated3HandCard38a";

                } else if (card.name == "instantiated3Card38b(Clone)") {

                    card.name = "instantiated3HandCard38b";

                } else if (card.name == "instantiated3Card38c(Clone)") {

                    card.name = "instantiated3HandCard38c";

                } else if (card.name == "instantiated3Card39(Clone)") {

                    card.name = "instantiated3HandCard39";

                } else if (card.name == "instantiated3Card39a(Clone)") {

                    card.name = "instantiated3HandCard39a";

                } else if (card.name == "instantiated3Card39b(Clone)") {

                    card.name = "instantiated3HandCard39b";

                } else if (card.name == "instantiated3Card39c(Clone)") {

                    card.name = "instantiated3HandCard39c";

                } else if (card.name == "instantiated3Card40(Clone)") {

                    card.name = "instantiated3HandCard40";

                } else if (card.name == "instantiated3Card40a(Clone)") {

                    card.name = "instantiated3HandCard40a";

                } else if (card.name == "instantiated3Card40b(Clone)") {

                    card.name = "instantiated3HandCard40b";

                } else if (card.name == "instantiated3Card40c(Clone)") {

                    card.name = "instantiated3HandCard40c";

                } else if (card.name == "instantiated3Card41(Clone)") {

                    card.name = "instantiated3HandCard41";

                } else if (card.name == "instantiated3Card41a(Clone)") {

                    card.name = "instantiated3HandCard41a";

                } else if (card.name == "instantiated3Card41b(Clone)") {

                    card.name = "instantiated3HandCard41b";

                } else if (card.name == "instantiated3Card41c(Clone)") {

                    card.name = "instantiated3HandCard41c";

                } else if (card.name == "instantiated3Card42(Clone)") {

                    card.name = "instantiated3HandCard42";

                } else if (card.name == "instantiated3Card42a(Clone)") {

                    card.name = "instantiated3HandCard42a";

                } else if (card.name == "instantiated3Card42b(Clone)") {

                    card.name = "instantiated3HandCard42b";

                } else if (card.name == "instantiated3Card42c(Clone)") {

                    card.name = "instantiated3HandCard42c";

                } else if (card.name == "instantiated3Card43(Clone)") {

                    card.name = "instantiated3HandCard43";

                } else if (card.name == "instantiated3Card43a(Clone)") {

                    card.name = "instantiated3HandCard43a";

                } else if (card.name == "instantiated3Card43b(Clone)") {

                    card.name = "instantiated3HandCard43b";

                } else if (card.name == "instantiated3Card43c(Clone)") {

                    card.name = "instantiated3HandCard43c";

                } else if (card.name == "instantiated3Card44(Clone)") {

                    card.name = "instantiated3HandCard44";

                } else if (card.name == "instantiated3Card44a(Clone)") {

                    card.name = "instantiated3HandCard44a";

                } else if (card.name == "instantiated3Card44b(Clone)") {

                    card.name = "instantiated3HandCard44b";

                } else if (card.name == "instantiated3Card44c(Clone)") {

                    card.name = "instantiated3HandCard44c";

                } else if (card.name == "instantiated3Card45(Clone)") {

                    card.name = "instantiated3HandCard45";

                } else if (card.name == "instantiated3Card45a(Clone)") {

                    card.name = "instantiated3HandCard45a";

                } else if (card.name == "instantiated3Card45b(Clone)") {

                    card.name = "instantiated3HandCard45b";

                } else if (card.name == "instantiated3Card45c(Clone)") {

                    card.name = "instantiated3HandCard45c";

                } else if (card.name == "instantiated3Card46(Clone)") {

                    card.name = "instantiated3HandCard46";

                } else if (card.name == "instantiated3Card46a(Clone)") {

                    card.name = "instantiated3HandCard46a";

                } else if (card.name == "instantiated3Card46b(Clone)") {

                    card.name = "instantiated3HandCard46b";

                } else if (card.name == "instantiated3Card46c(Clone)") {

                    card.name = "instantiated3HandCard46c";

                } else if (card.name == "instantiated3Card47(Clone)") {

                    card.name = "instantiated3HandCard47";

                } else if (card.name == "instantiated3Card47a(Clone)") {

                    card.name = "instantiated3HandCard47a";

                } else if (card.name == "instantiated3Card47b(Clone)") {

                    card.name = "instantiated3HandCard47b";

                } else if (card.name == "instantiated3Card47c(Clone)") {

                    card.name = "instantiated3HandCard47c";

                } else if (card.name == "instantiated3Card48(Clone)") {

                    card.name = "instantiated3HandCard48";

                } else if (card.name == "instantiated3Card48a(Clone)") {

                    card.name = "instantiated3HandCard48a";

                } else if (card.name == "instantiated3Card48b(Clone)") {

                    card.name = "instantiated3HandCard48b";

                } else if (card.name == "instantiated3Card48c(Clone)") {

                    card.name = "instantiated3HandCard48c";

                } else if (card.name == "instantiated3Card49(Clone)") {

                    card.name = "instantiated3HandCard49";

                } else if (card.name == "instantiated3Card49a(Clone)") {

                    card.name = "instantiated3HandCard49a";

                } else if (card.name == "instantiated3Card49b(Clone)") {

                    card.name = "instantiated3HandCard49b";

                } else if (card.name == "instantiated3Card49c(Clone)") {

                    card.name = "instantiated3HandCard49c";

                } else if (card.name == "instantiated3Card50(Clone)") {

                    card.name = "instantiated3HandCard50";

                } else if (card.name == "instantiated3Card50a(Clone)") {

                    card.name = "instantiated3HandCard50a";

                } else if (card.name == "instantiated3Card50b(Clone)") {

                    card.name = "instantiated3HandCard50b";

                } else if (card.name == "instantiated3Card50c(Clone)") {

                    card.name = "instantiated3HandCard50c";

                } else if (card.name == "instantiated3Card51(Clone)") {

                    card.name = "instantiated3HandCard51";

                } else if (card.name == "instantiated3Card51a(Clone)") {

                    card.name = "instantiated3HandCard51a";

                } else if (card.name == "instantiated3Card51b(Clone)") {

                    card.name = "instantiated3HandCard51b";

                } else if (card.name == "instantiated3Card51c(Clone)") {

                    card.name = "instantiated3HandCard51c";

                } else if (card.name == "instantiated3Card52(Clone)") {

                    card.name = "instantiated3HandCard52";

                } else if (card.name == "instantiated3Card52a(Clone)") {

                    card.name = "instantiated3HandCard52a";

                } else if (card.name == "instantiated3Card52b(Clone)") {

                    card.name = "instantiated3HandCard52b";

                } else if (card.name == "instantiated3Card52c(Clone)") {

                    card.name = "instantiated3HandCard52c";

                } else if (card.name == "instantiated3Card53(Clone)") {

                    card.name = "instantiated3HandCard53";

                } else if (card.name == "instantiated3Card53a(Clone)") {

                    card.name = "instantiated3HandCard53a";

                } else if (card.name == "instantiated3Card53b(Clone)") {

                    card.name = "instantiated3HandCard53b";

                } else if (card.name == "instantiated3Card53c(Clone)") {

                    card.name = "instantiated3HandCard53c";

                } else if (card.name == "instantiated3Card54(Clone)") {

                    card.name = "instantiated3HandCard54";

                } else if (card.name == "instantiated3Card54a(Clone)") {

                    card.name = "instantiated3HandCard54a";

                } else if (card.name == "instantiated3Card54b(Clone)") {

                    card.name = "instantiated3HandCard54b";

                } else if (card.name == "instantiated3Card54c(Clone)") {

                    card.name = "instantiated3HandCard54c";

                } else if (card.name == "instantiated3Card55(Clone)") {

                    card.name = "instantiated3HandCard55";

                } else if (card.name == "instantiated3Card55a(Clone)") {

                    card.name = "instantiated3HandCard55a";

                } else if (card.name == "instantiated3Card55b(Clone)") {

                    card.name = "instantiated3HandCard55b";

                } else if (card.name == "instantiated3Card55c(Clone)") {

                    card.name = "instantiated3HandCard55c";

                } else if (card.name == "instantiated3Card56(Clone)") {

                    card.name = "instantiated3HandCard56";

                } else if (card.name == "instantiated3Card56a(Clone)") {

                    card.name = "instantiated3HandCard56a";

                } else if (card.name == "instantiated3Card56b(Clone)") {

                    card.name = "instantiated3HandCard56b";

                } else if (card.name == "instantiated3Card56c(Clone)") {

                    card.name = "instantiated3HandCard56c";

                } else if (card.name == "instantiated3Card57(Clone)") {

                    card.name = "instantiated3HandCard57";

                } else if (card.name == "instantiated3Card57a(Clone)") {

                    card.name = "instantiated3HandCard57a";

                } else if (card.name == "instantiated3Card57b(Clone)") {

                    card.name = "instantiated3HandCard57b";

                } else if (card.name == "instantiated3Card57c(Clone)") {

                    card.name = "instantiated3HandCard57c";

                } else if (card.name == "instantiated3Card58(Clone)") {

                    card.name = "instantiated3HandCard58";

                } else if (card.name == "instantiated3Card58a(Clone)") {

                    card.name = "instantiated3HandCard58a";

                } else if (card.name == "instantiated3Card58b(Clone)") {

                    card.name = "instantiated3HandCard58b";

                } else if (card.name == "instantiated3Card58c(Clone)") {

                    card.name = "instantiated3HandCard58c";

                } else if (card.name == "instantiated3Card59(Clone)") {

                    card.name = "instantiated3HandCard59";

                } else if (card.name == "instantiated3Card59a(Clone)") {

                    card.name = "instantiated3HandCard59a";

                } else if (card.name == "instantiated3Card59b(Clone)") {

                    card.name = "instantiated3HandCard59b";

                } else if (card.name == "instantiated3Card59c(Clone)") {

                    card.name = "instantiated3HandCard59c";

                } else if (card.name == "instantiated3Card60(Clone)") {

                    card.name = "instantiated3HandCard60";

                } else if (card.name == "instantiated3Card60a(Clone)") {

                    card.name = "instantiated3HandCard60a";

                } else if (card.name == "instantiated3Card60b(Clone)") {

                    card.name = "instantiated3HandCard60b";

                } else if (card.name == "instantiated3Card60c(Clone)") {

                    card.name = "instantiated3HandCard60c";
                }

                instances8++;

            }

            while (instances9 < NumberOfCards) {

                GameObject card = Instantiate(playCardsDeck3[UnityEngine.Random.Range(0, playCardsDeck3.Count)], player1DeckSlot9.transform.position, player1DeckSlot9.transform.rotation) as GameObject;
                card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                card.transform.parent = player1DeckSlot9.transform;

                if (card.name == "instantiated3Card1(Clone)") {

                    card.name = "instantiated3HandCard1";

                } else if (card.name == "instantiated3Card1a(Clone)") {

                    card.name = "instantiated3HandCard1a";

                } else if (card.name == "instantiated3Card1b(Clone)") {

                    card.name = "instantiated3HandCard1b";

                } else if (card.name == "instantiated3Card1c(Clone)") {

                    card.name = "instantiated3HandCard1c";

                } else if (card.name == "instantiated3Card2(Clone)") {

                    card.name = "instantiated3HandCard2";

                } else if (card.name == "instantiated3Card2a(Clone)") {

                    card.name = "instantiated3HandCard2a";

                } else if (card.name == "instantiated3Card2b(Clone)") {

                    card.name = "instantiated3HandCard2b";

                } else if (card.name == "instantiated3Card2c(Clone)") {

                    card.name = "instantiated3HandCard2c";

                } else if (card.name == "instantiated3Card3(Clone)") {

                    card.name = "instantiated3HandCard3";

                } else if (card.name == "instantiated3Card3a(Clone)") {

                    card.name = "instantiated3HandCard3a";

                } else if (card.name == "instantiated3Card3b(Clone)") {

                    card.name = "instantiated3HandCard3b";

                } else if (card.name == "instantiated3Card3c(Clone)") {

                    card.name = "instantiated3HandCard3c";

                } else if (card.name == "instantiated3Card4(Clone)") {

                    card.name = "instantiated3HandCard4";

                } else if (card.name == "instantiated3Card4a(Clone)") {

                    card.name = "instantiated3HandCard4a";

                } else if (card.name == "instantiated3Card4b(Clone)") {

                    card.name = "instantiated3HandCard4b";

                } else if (card.name == "instantiated3Card4c(Clone)") {

                    card.name = "instantiated3HandCard4c";

                } else if (card.name == "instantiated3Card5(Clone)") {

                    card.name = "instantiated3HandCard5";

                } else if (card.name == "instantiated3Card5a(Clone)") {

                    card.name = "instantiated3HandCard5a";

                } else if (card.name == "instantiated3Card5b(Clone)") {

                    card.name = "instantiated3HandCard5b";

                } else if (card.name == "instantiated3Card5c(Clone)") {

                    card.name = "instantiated3HandCard5c";

                } else if (card.name == "instantiated3Card6(Clone)") {

                    card.name = "instantiated3HandCard6";

                } else if (card.name == "instantiated3Card6a(Clone)") {

                    card.name = "instantiated3HandCard6a";

                } else if (card.name == "instantiated3Card6b(Clone)") {

                    card.name = "instantiated3HandCard6b";

                } else if (card.name == "instantiated3Card6c(Clone)") {

                    card.name = "instantiated3HandCard6c";

                } else if (card.name == "instantiated3Card7(Clone)") {

                    card.name = "instantiated3HandCard7";

                } else if (card.name == "instantiated3Card7a(Clone)") {

                    card.name = "instantiated3HandCard7a";

                } else if (card.name == "instantiated3Card7b(Clone)") {

                    card.name = "instantiated3HandCard7b";

                } else if (card.name == "instantiated3Card7c(Clone)") {

                    card.name = "instantiated3HandCard7c";

                } else if (card.name == "instantiated3Card8(Clone)") {

                    card.name = "instantiated3HandCard8";

                } else if (card.name == "instantiated3Card8a(Clone)") {

                    card.name = "instantiated3HandCard8a";

                } else if (card.name == "instantiated3Card8b(Clone)") {

                    card.name = "instantiated3HandCard8b";

                } else if (card.name == "instantiated3Card8c(Clone)") {

                    card.name = "instantiated3HandCard8c";

                } else if (card.name == "instantiated3Card9(Clone)") {

                    card.name = "instantiated3HandCard9";

                } else if (card.name == "instantiated3Card9a(Clone)") {

                    card.name = "instantiated3HandCard9a";

                } else if (card.name == "instantiated3Card9b(Clone)") {

                    card.name = "instantiated3HandCard9b";

                } else if (card.name == "instantiated3Card9c(Clone)") {

                    card.name = "instantiated3HandCard9c";

                } else if (card.name == "instantiated3Card10(Clone)") {

                    card.name = "instantiatedAICard10";

                } else if (card.name == "instantiated3Card10a(Clone)") {

                    card.name = "instantiated3HandCard10a";

                } else if (card.name == "instantiated3Card10b(Clone)") {

                    card.name = "instantiated3HandCard10b";

                } else if (card.name == "instantiated3Card10c(Clone)") {

                    card.name = "instantiated3HandCard10c";

                } else if (card.name == "instantiated3Card11(Clone)") {

                    card.name = "instantiated3HandCard11";

                } else if (card.name == "instantiated3Card11a(Clone)") {

                    card.name = "instantiated3HandCard11a";

                } else if (card.name == "instantiated3Card11b(Clone)") {

                    card.name = "instantiated3HandCard11b";

                } else if (card.name == "instantiated3Card11c(Clone)") {

                    card.name = "instantiated3HandCard11c";

                } else if (card.name == "instantiated3Card12(Clone)") {

                    card.name = "instantiated3HandCard12";

                } else if (card.name == "instantiated3Card12a(Clone)") {

                    card.name = "instantiated3HandCard12a";

                } else if (card.name == "instantiated3Card12b(Clone)") {

                    card.name = "instantiated3HandCard12b";

                } else if (card.name == "instantiated3Card12c(Clone)") {

                    card.name = "instantiated3HandCard12c";

                } else if (card.name == "instantiated3Card13(Clone)") {

                    card.name = "instantiated3HandCard13";

                } else if (card.name == "instantiated3Card13a(Clone)") {

                    card.name = "instantiated3HandCard13a";

                } else if (card.name == "instantiated3Card13b(Clone)") {

                    card.name = "instantiated3HandCard13b";

                } else if (card.name == "instantiated3Card13c(Clone)") {

                    card.name = "instantiated3HandCard13c";

                } else if (card.name == "instantiated3Card14(Clone)") {

                    card.name = "instantiated3HandCard14";

                } else if (card.name == "instantiated3Card14a(Clone)") {

                    card.name = "instantiated3HandCard14a";

                } else if (card.name == "instantiated3Card14b(Clone)") {

                    card.name = "instantiated3HandCard14b";

                } else if (card.name == "instantiated3Card14c(Clone)") {

                    card.name = "instantiated3HandCard14c";

                } else if (card.name == "instantiated3Card15(Clone)") {

                    card.name = "instantiated3HandCard15";

                } else if (card.name == "instantiated3Card15a(Clone)") {

                    card.name = "instantiated3HandCard15a";

                } else if (card.name == "instantiated3Card15b(Clone)") {

                    card.name = "instantiated3HandCard15b";

                } else if (card.name == "instantiated3Card15c(Clone)") {

                    card.name = "instantiated3HandCard15c";

                } else if (card.name == "instantiated3Card16(Clone)") {

                    card.name = "instantiated3HandCard16";

                } else if (card.name == "instantiated3Card16a(Clone)") {

                    card.name = "instantiated3HandCard16a";

                } else if (card.name == "instantiated3Card16b(Clone)") {

                    card.name = "instantiated3HandCard16b";

                } else if (card.name == "instantiated3Card16c(Clone)") {

                    card.name = "instantiated3HandCard16c";

                } else if (card.name == "instantiated3Card17(Clone)") {

                    card.name = "instantiated3HandCard17";

                } else if (card.name == "instantiated3Card17a(Clone)") {

                    card.name = "instantiated3HandCard17a";

                } else if (card.name == "instantiated3Card17b(Clone)") {

                    card.name = "instantiated3HandCard17b";

                } else if (card.name == "instantiated3Card17c(Clone)") {

                    card.name = "instantiated3HandCard17c";

                } else if (card.name == "instantiated3Card18(Clone)") {

                    card.name = "instantiated3HandCard18";

                } else if (card.name == "instantiated3Card18a(Clone)") {

                    card.name = "instantiated3HandCard18a";

                } else if (card.name == "instantiated3Card18b(Clone)") {

                    card.name = "instantiated3HandCard18b";

                } else if (card.name == "instantiated3Card18c(Clone)") {

                    card.name = "instantiated3HandCard18c";

                } else if (card.name == "instantiated3Card19(Clone)") {

                    card.name = "instantiated3HandCard19";

                } else if (card.name == "instantiated3Card19a(Clone)") {

                    card.name = "instantiated3HandCard19a";

                } else if (card.name == "instantiated3Card19b(Clone)") {

                    card.name = "instantiated3HandCard19b";

                } else if (card.name == "instantiated3Card19c(Clone)") {

                    card.name = "instantiated3HandCard19c";

                } else if (card.name == "instantiated3Card20(Clone)") {

                    card.name = "instantiated3HandCard20";

                } else if (card.name == "instantiated3Card20a(Clone)") {

                    card.name = "instantiated3HandCard20a";

                } else if (card.name == "instantiated3Card20b(Clone)") {

                    card.name = "instantiated3HandCard20b";

                } else if (card.name == "instantiated3Card20c(Clone)") {

                    card.name = "instantiated3HandCard20c";

                } else if (card.name == "instantiated3Card21(Clone)") {

                    card.name = "instantiated3HandCard21";

                } else if (card.name == "instantiated3Card21a(Clone)") {

                    card.name = "instantiated3HandCard21a";

                } else if (card.name == "instantiated3Card21b(Clone)") {

                    card.name = "instantiated3HandCard21b";

                } else if (card.name == "instantiated3Card21c(Clone)") {

                    card.name = "instantiated3HandCard21c";

                } else if (card.name == "instantiated3Card22(Clone)") {

                    card.name = "instantiated3HandCard22";

                } else if (card.name == "instantiated3Card22a(Clone)") {

                    card.name = "instantiated3HandCard22a";

                } else if (card.name == "instantiated3Card22b(Clone)") {

                    card.name = "instantiated3HandCard22b";

                } else if (card.name == "instantiated3Card22c(Clone)") {

                    card.name = "instantiated3HandCard22c";

                } else if (card.name == "instantiated3Card23(Clone)") {

                    card.name = "instantiated3HandCard23";

                } else if (card.name == "instantiated3Card23a(Clone)") {

                    card.name = "instantiated3HandCard23a";

                } else if (card.name == "instantiated3Card23b(Clone)") {

                    card.name = "instantiated3HandCard23b";

                } else if (card.name == "instantiated3Card23c(Clone)") {

                    card.name = "instantiated3HandCard23c";

                } else if (card.name == "instantiated3Card24(Clone)") {

                    card.name = "instantiated3HandCard24";

                } else if (card.name == "instantiated3Card24a(Clone)") {

                    card.name = "instantiated3HandCard24a";

                } else if (card.name == "instantiated3Card24b(Clone)") {

                    card.name = "instantiated3HandCard24b";

                } else if (card.name == "instantiated3Card24c(Clone)") {

                    card.name = "instantiated3HandCard24c";

                } else if (card.name == "instantiated3Card25(Clone)") {

                    card.name = "instantiated3HandCard25";

                } else if (card.name == "instantiated3Card25a(Clone)") {

                    card.name = "instantiated3HandCard25a";

                } else if (card.name == "instantiated3Card25b(Clone)") {

                    card.name = "instantiated3HandCard25b";

                } else if (card.name == "instantiated3Card25c(Clone)") {

                    card.name = "instantiated3HandCard25c";

                } else if (card.name == "instantiated3Card26(Clone)") {

                    card.name = "instantiated3HandCard26";

                } else if (card.name == "instantiated3Card26a(Clone)") {

                    card.name = "instantiated3HandCard26a";

                } else if (card.name == "instantiated3Card26b(Clone)") {

                    card.name = "instantiated3HandCard26b";

                } else if (card.name == "instantiated3Card26c(Clone)") {

                    card.name = "instantiated3HandCard26c";

                } else if (card.name == "instantiated3Card27(Clone)") {

                    card.name = "instantiated3HandCard27";

                } else if (card.name == "instantiated3Card27a(Clone)") {

                    card.name = "instantiated3HandCard27a";

                } else if (card.name == "instantiated3Card27b(Clone)") {

                    card.name = "instantiated3HandCard27b";

                } else if (card.name == "instantiated3Card27c(Clone)") {

                    card.name = "instantiated3HandCard27c";

                } else if (card.name == "instantiated3Card28(Clone)") {

                    card.name = "instantiated3HandCard28";

                } else if (card.name == "instantiated3Card28a(Clone)") {

                    card.name = "instantiated3HandCard28a";

                } else if (card.name == "instantiated3Card28b(Clone)") {

                    card.name = "instantiated3HandCard28b";

                } else if (card.name == "instantiated3Card28c(Clone)") {

                    card.name = "instantiated3HandCard28c";

                } else if (card.name == "instantiated3Card29(Clone)") {

                    card.name = "instantiated3HandCard29";

                } else if (card.name == "instantiated3Card29a(Clone)") {

                    card.name = "instantiated3HandCard29a";

                } else if (card.name == "instantiated3Card29b(Clone)") {

                    card.name = "instantiated3HandCard29b";

                } else if (card.name == "instantiated3Card29c(Clone)") {

                    card.name = "instantiated3HandCard29c";

                } else if (card.name == "instantiated3Card30(Clone)") {

                    card.name = "instantiated3HandCard30";

                } else if (card.name == "instantiated3Card30a(Clone)") {

                    card.name = "instantiated3HandCard30a";

                } else if (card.name == "instantiated3Card30b(Clone)") {

                    card.name = "instantiated3HandCard30b";

                } else if (card.name == "instantiated3Card30c(Clone)") {

                    card.name = "instantiated3HandCard30c";

                } else if (card.name == "instantiated3Card31(Clone)") {

                    card.name = "instantiated3HandCard31";

                } else if (card.name == "instantiated3Card31a(Clone)") {

                    card.name = "instantiated3HandCard31a";

                } else if (card.name == "instantiated3Card31b(Clone)") {

                    card.name = "instantiated3HandCard31b";

                } else if (card.name == "instantiated3Card31c(Clone)") {

                    card.name = "instantiated3HandCard31c";

                } else if (card.name == "instantiated3Card32(Clone)") {

                    card.name = "instantiated3HandCard32";

                } else if (card.name == "instantiated3Card32a(Clone)") {

                    card.name = "instantiated3HandCard32a";

                } else if (card.name == "instantiated3Card32b(Clone)") {

                    card.name = "instantiated3HandCard32b";

                } else if (card.name == "instantiated3Card32c(Clone)") {

                    card.name = "instantiated3HandCard32c";

                } else if (card.name == "instantiated3Card33(Clone)") {

                    card.name = "instantiated3HandCard33";

                } else if (card.name == "instantiated3Card33a(Clone)") {

                    card.name = "instantiated3HandCard33a";

                } else if (card.name == "instantiated3Card33b(Clone)") {

                    card.name = "instantiated3HandCard33b";

                } else if (card.name == "instantiated3Card33c(Clone)") {

                    card.name = "instantiated3HandCard33c";

                } else if (card.name == "instantiated3Card34(Clone)") {

                    card.name = "instantiated3HandCard34";

                } else if (card.name == "instantiated3Card34a(Clone)") {

                    card.name = "instantiated3HandCard34a";

                } else if (card.name == "instantiated3Card34b(Clone)") {

                    card.name = "instantiated3HandCard34b";

                } else if (card.name == "instantiated3Card34c(Clone)") {

                    card.name = "instantiated3HandCard34c";

                } else if (card.name == "instantiated3Card35(Clone)") {

                    card.name = "instantiated3HandCard35";

                } else if (card.name == "instantiated3Card35a(Clone)") {

                    card.name = "instantiated3HandCard35a";

                } else if (card.name == "instantiated3Card35b(Clone)") {

                    card.name = "instantiated3HandCard35b";

                } else if (card.name == "instantiated3Card35c(Clone)") {

                    card.name = "instantiated3HandCard35c";

                } else if (card.name == "instantiated3Card36(Clone)") {

                    card.name = "instantiated3HandCard36";

                } else if (card.name == "instantiated3Card36a(Clone)") {

                    card.name = "instantiated3HandCard36a";

                } else if (card.name == "instantiated3Card36b(Clone)") {

                    card.name = "instantiated3HandCard36b";

                } else if (card.name == "instantiated3Card36c(Clone)") {

                    card.name = "instantiated3HandCard36c";

                } else if (card.name == "instantiated3Card37(Clone)") {

                    card.name = "instantiated3HandCard37";

                } else if (card.name == "instantiated3Card37a(Clone)") {

                    card.name = "instantiated3HandCard37a";

                } else if (card.name == "instantiated3Card37b(Clone)") {

                    card.name = "instantiated3HandCard37b";

                } else if (card.name == "instantiated3Card37c(Clone)") {

                    card.name = "instantiated3HandCard37c";

                } else if (card.name == "instantiated3Card38(Clone)") {

                    card.name = "instantiated3HandCard38";

                } else if (card.name == "instantiated3Card38a(Clone)") {

                    card.name = "instantiated3HandCard38a";

                } else if (card.name == "instantiated3Card38b(Clone)") {

                    card.name = "instantiated3HandCard38b";

                } else if (card.name == "instantiated3Card38c(Clone)") {

                    card.name = "instantiated3HandCard38c";

                } else if (card.name == "instantiated3Card39(Clone)") {

                    card.name = "instantiated3HandCard39";

                } else if (card.name == "instantiated3Card39a(Clone)") {

                    card.name = "instantiated3HandCard39a";

                } else if (card.name == "instantiated3Card39b(Clone)") {

                    card.name = "instantiated3HandCard39b";

                } else if (card.name == "instantiated3Card39c(Clone)") {

                    card.name = "instantiated3HandCard39c";

                } else if (card.name == "instantiated3Card40(Clone)") {

                    card.name = "instantiated3HandCard40";

                } else if (card.name == "instantiated3Card40a(Clone)") {

                    card.name = "instantiated3HandCard40a";

                } else if (card.name == "instantiated3Card40b(Clone)") {

                    card.name = "instantiated3HandCard40b";

                } else if (card.name == "instantiated3Card40c(Clone)") {

                    card.name = "instantiated3HandCard40c";

                } else if (card.name == "instantiated3Card41(Clone)") {

                    card.name = "instantiated3HandCard41";

                } else if (card.name == "instantiated3Card41a(Clone)") {

                    card.name = "instantiated3HandCard41a";

                } else if (card.name == "instantiated3Card41b(Clone)") {

                    card.name = "instantiated3HandCard41b";

                } else if (card.name == "instantiated3Card41c(Clone)") {

                    card.name = "instantiated3HandCard41c";

                } else if (card.name == "instantiated3Card42(Clone)") {

                    card.name = "instantiated3HandCard42";

                } else if (card.name == "instantiated3Card42a(Clone)") {

                    card.name = "instantiated3HandCard42a";

                } else if (card.name == "instantiated3Card42b(Clone)") {

                    card.name = "instantiated3HandCard42b";

                } else if (card.name == "instantiated3Card42c(Clone)") {

                    card.name = "instantiated3HandCard42c";

                } else if (card.name == "instantiated3Card43(Clone)") {

                    card.name = "instantiated3HandCard43";

                } else if (card.name == "instantiated3Card43a(Clone)") {

                    card.name = "instantiated3HandCard43a";

                } else if (card.name == "instantiated3Card43b(Clone)") {

                    card.name = "instantiated3HandCard43b";

                } else if (card.name == "instantiated3Card43c(Clone)") {

                    card.name = "instantiated3HandCard43c";

                } else if (card.name == "instantiated3Card44(Clone)") {

                    card.name = "instantiated3HandCard44";

                } else if (card.name == "instantiated3Card44a(Clone)") {

                    card.name = "instantiated3HandCard44a";

                } else if (card.name == "instantiated3Card44b(Clone)") {

                    card.name = "instantiated3HandCard44b";

                } else if (card.name == "instantiated3Card44c(Clone)") {

                    card.name = "instantiated3HandCard44c";

                } else if (card.name == "instantiated3Card45(Clone)") {

                    card.name = "instantiated3HandCard45";

                } else if (card.name == "instantiated3Card45a(Clone)") {

                    card.name = "instantiated3HandCard45a";

                } else if (card.name == "instantiated3Card45b(Clone)") {

                    card.name = "instantiated3HandCard45b";

                } else if (card.name == "instantiated3Card45c(Clone)") {

                    card.name = "instantiated3HandCard45c";

                } else if (card.name == "instantiated3Card46(Clone)") {

                    card.name = "instantiated3HandCard46";

                } else if (card.name == "instantiated3Card46a(Clone)") {

                    card.name = "instantiated3HandCard46a";

                } else if (card.name == "instantiated3Card46b(Clone)") {

                    card.name = "instantiated3HandCard46b";

                } else if (card.name == "instantiated3Card46c(Clone)") {

                    card.name = "instantiated3HandCard46c";

                } else if (card.name == "instantiated3Card47(Clone)") {

                    card.name = "instantiated3HandCard47";

                } else if (card.name == "instantiated3Card47a(Clone)") {

                    card.name = "instantiated3HandCard47a";

                } else if (card.name == "instantiated3Card47b(Clone)") {

                    card.name = "instantiated3HandCard47b";

                } else if (card.name == "instantiated3Card47c(Clone)") {

                    card.name = "instantiated3HandCard47c";

                } else if (card.name == "instantiated3Card48(Clone)") {

                    card.name = "instantiated3HandCard48";

                } else if (card.name == "instantiated3Card48a(Clone)") {

                    card.name = "instantiated3HandCard48a";

                } else if (card.name == "instantiated3Card48b(Clone)") {

                    card.name = "instantiated3HandCard48b";

                } else if (card.name == "instantiated3Card48c(Clone)") {

                    card.name = "instantiated3HandCard48c";

                } else if (card.name == "instantiated3Card49(Clone)") {

                    card.name = "instantiated3HandCard49";

                } else if (card.name == "instantiated3Card49a(Clone)") {

                    card.name = "instantiated3HandCard49a";

                } else if (card.name == "instantiated3Card49b(Clone)") {

                    card.name = "instantiated3HandCard49b";

                } else if (card.name == "instantiated3Card49c(Clone)") {

                    card.name = "instantiated3HandCard49c";

                } else if (card.name == "instantiated3Card50(Clone)") {

                    card.name = "instantiated3HandCard50";

                } else if (card.name == "instantiated3Card50a(Clone)") {

                    card.name = "instantiated3HandCard50a";

                } else if (card.name == "instantiated3Card50b(Clone)") {

                    card.name = "instantiated3HandCard50b";

                } else if (card.name == "instantiated3Card50c(Clone)") {

                    card.name = "instantiated3HandCard50c";

                } else if (card.name == "instantiated3Card51(Clone)") {

                    card.name = "instantiated3HandCard51";

                } else if (card.name == "instantiated3Card51a(Clone)") {

                    card.name = "instantiated3HandCard51a";

                } else if (card.name == "instantiated3Card51b(Clone)") {

                    card.name = "instantiated3HandCard51b";

                } else if (card.name == "instantiated3Card51c(Clone)") {

                    card.name = "instantiated3HandCard51c";

                } else if (card.name == "instantiated3Card52(Clone)") {

                    card.name = "instantiated3HandCard52";

                } else if (card.name == "instantiated3Card52a(Clone)") {

                    card.name = "instantiated3HandCard52a";

                } else if (card.name == "instantiated3Card52b(Clone)") {

                    card.name = "instantiated3HandCard52b";

                } else if (card.name == "instantiated3Card52c(Clone)") {

                    card.name = "instantiated3HandCard52c";

                } else if (card.name == "instantiated3Card53(Clone)") {

                    card.name = "instantiated3HandCard53";

                } else if (card.name == "instantiated3Card53a(Clone)") {

                    card.name = "instantiated3HandCard53a";

                } else if (card.name == "instantiated3Card53b(Clone)") {

                    card.name = "instantiated3HandCard53b";

                } else if (card.name == "instantiated3Card53c(Clone)") {

                    card.name = "instantiated3HandCard53c";

                } else if (card.name == "instantiated3Card54(Clone)") {

                    card.name = "instantiated3HandCard54";

                } else if (card.name == "instantiated3Card54a(Clone)") {

                    card.name = "instantiated3HandCard54a";

                } else if (card.name == "instantiated3Card54b(Clone)") {

                    card.name = "instantiated3HandCard54b";

                } else if (card.name == "instantiated3Card54c(Clone)") {

                    card.name = "instantiated3HandCard54c";

                } else if (card.name == "instantiated3Card55(Clone)") {

                    card.name = "instantiated3HandCard55";

                } else if (card.name == "instantiated3Card55a(Clone)") {

                    card.name = "instantiated3HandCard55a";

                } else if (card.name == "instantiated3Card55b(Clone)") {

                    card.name = "instantiated3HandCard55b";

                } else if (card.name == "instantiated3Card55c(Clone)") {

                    card.name = "instantiated3HandCard55c";

                } else if (card.name == "instantiated3Card56(Clone)") {

                    card.name = "instantiated3HandCard56";

                } else if (card.name == "instantiated3Card56a(Clone)") {

                    card.name = "instantiated3HandCard56a";

                } else if (card.name == "instantiated3Card56b(Clone)") {

                    card.name = "instantiated3HandCard56b";

                } else if (card.name == "instantiated3Card56c(Clone)") {

                    card.name = "instantiated3HandCard56c";

                } else if (card.name == "instantiated3Card57(Clone)") {

                    card.name = "instantiated3HandCard57";

                } else if (card.name == "instantiated3Card57a(Clone)") {

                    card.name = "instantiated3HandCard57a";

                } else if (card.name == "instantiated3Card57b(Clone)") {

                    card.name = "instantiated3HandCard57b";

                } else if (card.name == "instantiated3Card57c(Clone)") {

                    card.name = "instantiated3HandCard57c";

                } else if (card.name == "instantiated3Card58(Clone)") {

                    card.name = "instantiated3HandCard58";

                } else if (card.name == "instantiated3Card58a(Clone)") {

                    card.name = "instantiated3HandCard58a";

                } else if (card.name == "instantiated3Card58b(Clone)") {

                    card.name = "instantiated3HandCard58b";

                } else if (card.name == "instantiated3Card58c(Clone)") {

                    card.name = "instantiated3HandCard58c";

                } else if (card.name == "instantiated3Card59(Clone)") {

                    card.name = "instantiated3HandCard59";

                } else if (card.name == "instantiated3Card59a(Clone)") {

                    card.name = "instantiated3HandCard59a";

                } else if (card.name == "instantiated3Card59b(Clone)") {

                    card.name = "instantiated3HandCard59b";

                } else if (card.name == "instantiated3Card59c(Clone)") {

                    card.name = "instantiated3HandCard59c";

                } else if (card.name == "instantiated3Card60(Clone)") {

                    card.name = "instantiated3HandCard60";

                } else if (card.name == "instantiated3Card60a(Clone)") {

                    card.name = "instantiated3HandCard60a";

                } else if (card.name == "instantiated3Card60b(Clone)") {

                    card.name = "instantiated3HandCard60b";

                } else if (card.name == "instantiated3Card60c(Clone)") {

                    card.name = "instantiated3HandCard60c";
                }

                instances9++;

            }

            while (instances10 < NumberOfCards) {

                GameObject card = Instantiate(playCardsDeck3[UnityEngine.Random.Range(0, playCardsDeck3.Count)], player1DeckSlot10.transform.position, player1DeckSlot10.transform.rotation) as GameObject;
                card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                card.transform.parent = player1DeckSlot10.transform;

                if (card.name == "instantiated3Card1(Clone)") {

                    card.name = "instantiated3HandCard1";

                } else if (card.name == "instantiated3Card1a(Clone)") {

                    card.name = "instantiated3HandCard1a";

                } else if (card.name == "instantiated3Card1b(Clone)") {

                    card.name = "instantiated3HandCard1b";

                } else if (card.name == "instantiated3Card1c(Clone)") {

                    card.name = "instantiated3HandCard1c";

                } else if (card.name == "instantiated3Card2(Clone)") {

                    card.name = "instantiated3HandCard2";

                } else if (card.name == "instantiated3Card2a(Clone)") {

                    card.name = "instantiated3HandCard2a";

                } else if (card.name == "instantiated3Card2b(Clone)") {

                    card.name = "instantiated3HandCard2b";

                } else if (card.name == "instantiated3Card2c(Clone)") {

                    card.name = "instantiated3HandCard2c";

                } else if (card.name == "instantiated3Card3(Clone)") {

                    card.name = "instantiated3HandCard3";

                } else if (card.name == "instantiated3Card3a(Clone)") {

                    card.name = "instantiated3HandCard3a";

                } else if (card.name == "instantiated3Card3b(Clone)") {

                    card.name = "instantiated3HandCard3b";

                } else if (card.name == "instantiated3Card3c(Clone)") {

                    card.name = "instantiated3HandCard3c";

                } else if (card.name == "instantiated3Card4(Clone)") {

                    card.name = "instantiated3HandCard4";

                } else if (card.name == "instantiated3Card4a(Clone)") {

                    card.name = "instantiated3HandCard4a";

                } else if (card.name == "instantiated3Card4b(Clone)") {

                    card.name = "instantiated3HandCard4b";

                } else if (card.name == "instantiated3Card4c(Clone)") {

                    card.name = "instantiated3HandCard4c";

                } else if (card.name == "instantiated3Card5(Clone)") {

                    card.name = "instantiated3HandCard5";

                } else if (card.name == "instantiated3Card5a(Clone)") {

                    card.name = "instantiated3HandCard5a";

                } else if (card.name == "instantiated3Card5b(Clone)") {

                    card.name = "instantiated3HandCard5b";

                } else if (card.name == "instantiated3Card5c(Clone)") {

                    card.name = "instantiated3HandCard5c";

                } else if (card.name == "instantiated3Card6(Clone)") {

                    card.name = "instantiated3HandCard6";

                } else if (card.name == "instantiated3Card6a(Clone)") {

                    card.name = "instantiated3HandCard6a";

                } else if (card.name == "instantiated3Card6b(Clone)") {

                    card.name = "instantiated3HandCard6b";

                } else if (card.name == "instantiated3Card6c(Clone)") {

                    card.name = "instantiated3HandCard6c";

                } else if (card.name == "instantiated3Card7(Clone)") {

                    card.name = "instantiated3HandCard7";

                } else if (card.name == "instantiated3Card7a(Clone)") {

                    card.name = "instantiated3HandCard7a";

                } else if (card.name == "instantiated3Card7b(Clone)") {

                    card.name = "instantiated3HandCard7b";

                } else if (card.name == "instantiated3Card7c(Clone)") {

                    card.name = "instantiated3HandCard7c";

                } else if (card.name == "instantiated3Card8(Clone)") {

                    card.name = "instantiated3HandCard8";

                } else if (card.name == "instantiated3Card8a(Clone)") {

                    card.name = "instantiated3HandCard8a";

                } else if (card.name == "instantiated3Card8b(Clone)") {

                    card.name = "instantiated3HandCard8b";

                } else if (card.name == "instantiated3Card8c(Clone)") {

                    card.name = "instantiated3HandCard8c";

                } else if (card.name == "instantiated3Card9(Clone)") {

                    card.name = "instantiated3HandCard9";

                } else if (card.name == "instantiated3Card9a(Clone)") {

                    card.name = "instantiated3HandCard9a";

                } else if (card.name == "instantiated3Card9b(Clone)") {

                    card.name = "instantiated3HandCard9b";

                } else if (card.name == "instantiated3Card9c(Clone)") {

                    card.name = "instantiated3HandCard9c";

                } else if (card.name == "instantiated3Card10(Clone)") {

                    card.name = "instantiatedAICard10";

                } else if (card.name == "instantiated3Card10a(Clone)") {

                    card.name = "instantiated3HandCard10a";

                } else if (card.name == "instantiated3Card10b(Clone)") {

                    card.name = "instantiated3HandCard10b";

                } else if (card.name == "instantiated3Card10c(Clone)") {

                    card.name = "instantiated3HandCard10c";

                } else if (card.name == "instantiated3Card11(Clone)") {

                    card.name = "instantiated3HandCard11";

                } else if (card.name == "instantiated3Card11a(Clone)") {

                    card.name = "instantiated3HandCard11a";

                } else if (card.name == "instantiated3Card11b(Clone)") {

                    card.name = "instantiated3HandCard11b";

                } else if (card.name == "instantiated3Card11c(Clone)") {

                    card.name = "instantiated3HandCard11c";

                } else if (card.name == "instantiated3Card12(Clone)") {

                    card.name = "instantiated3HandCard12";

                } else if (card.name == "instantiated3Card12a(Clone)") {

                    card.name = "instantiated3HandCard12a";

                } else if (card.name == "instantiated3Card12b(Clone)") {

                    card.name = "instantiated3HandCard12b";

                } else if (card.name == "instantiated3Card12c(Clone)") {

                    card.name = "instantiated3HandCard12c";

                } else if (card.name == "instantiated3Card13(Clone)") {

                    card.name = "instantiated3HandCard13";

                } else if (card.name == "instantiated3Card13a(Clone)") {

                    card.name = "instantiated3HandCard13a";

                } else if (card.name == "instantiated3Card13b(Clone)") {

                    card.name = "instantiated3HandCard13b";

                } else if (card.name == "instantiated3Card13c(Clone)") {

                    card.name = "instantiated3HandCard13c";

                } else if (card.name == "instantiated3Card14(Clone)") {

                    card.name = "instantiated3HandCard14";

                } else if (card.name == "instantiated3Card14a(Clone)") {

                    card.name = "instantiated3HandCard14a";

                } else if (card.name == "instantiated3Card14b(Clone)") {

                    card.name = "instantiated3HandCard14b";

                } else if (card.name == "instantiated3Card14c(Clone)") {

                    card.name = "instantiated3HandCard14c";

                } else if (card.name == "instantiated3Card15(Clone)") {

                    card.name = "instantiated3HandCard15";

                } else if (card.name == "instantiated3Card15a(Clone)") {

                    card.name = "instantiated3HandCard15a";

                } else if (card.name == "instantiated3Card15b(Clone)") {

                    card.name = "instantiated3HandCard15b";

                } else if (card.name == "instantiated3Card15c(Clone)") {

                    card.name = "instantiated3HandCard15c";

                } else if (card.name == "instantiated3Card16(Clone)") {

                    card.name = "instantiated3HandCard16";

                } else if (card.name == "instantiated3Card16a(Clone)") {

                    card.name = "instantiated3HandCard16a";

                } else if (card.name == "instantiated3Card16b(Clone)") {

                    card.name = "instantiated3HandCard16b";

                } else if (card.name == "instantiated3Card16c(Clone)") {

                    card.name = "instantiated3HandCard16c";

                } else if (card.name == "instantiated3Card17(Clone)") {

                    card.name = "instantiated3HandCard17";

                } else if (card.name == "instantiated3Card17a(Clone)") {

                    card.name = "instantiated3HandCard17a";

                } else if (card.name == "instantiated3Card17b(Clone)") {

                    card.name = "instantiated3HandCard17b";

                } else if (card.name == "instantiated3Card17c(Clone)") {

                    card.name = "instantiated3HandCard17c";

                } else if (card.name == "instantiated3Card18(Clone)") {

                    card.name = "instantiated3HandCard18";

                } else if (card.name == "instantiated3Card18a(Clone)") {

                    card.name = "instantiated3HandCard18a";

                } else if (card.name == "instantiated3Card18b(Clone)") {

                    card.name = "instantiated3HandCard18b";

                } else if (card.name == "instantiated3Card18c(Clone)") {

                    card.name = "instantiated3HandCard18c";

                } else if (card.name == "instantiated3Card19(Clone)") {

                    card.name = "instantiated3HandCard19";

                } else if (card.name == "instantiated3Card19a(Clone)") {

                    card.name = "instantiated3HandCard19a";

                } else if (card.name == "instantiated3Card19b(Clone)") {

                    card.name = "instantiated3HandCard19b";

                } else if (card.name == "instantiated3Card19c(Clone)") {

                    card.name = "instantiated3HandCard19c";

                } else if (card.name == "instantiated3Card20(Clone)") {

                    card.name = "instantiated3HandCard20";

                } else if (card.name == "instantiated3Card20a(Clone)") {

                    card.name = "instantiated3HandCard20a";

                } else if (card.name == "instantiated3Card20b(Clone)") {

                    card.name = "instantiated3HandCard20b";

                } else if (card.name == "instantiated3Card20c(Clone)") {

                    card.name = "instantiated3HandCard20c";

                } else if (card.name == "instantiated3Card21(Clone)") {

                    card.name = "instantiated3HandCard21";

                } else if (card.name == "instantiated3Card21a(Clone)") {

                    card.name = "instantiated3HandCard21a";

                } else if (card.name == "instantiated3Card21b(Clone)") {

                    card.name = "instantiated3HandCard21b";

                } else if (card.name == "instantiated3Card21c(Clone)") {

                    card.name = "instantiated3HandCard21c";

                } else if (card.name == "instantiated3Card22(Clone)") {

                    card.name = "instantiated3HandCard22";

                } else if (card.name == "instantiated3Card22a(Clone)") {

                    card.name = "instantiated3HandCard22a";

                } else if (card.name == "instantiated3Card22b(Clone)") {

                    card.name = "instantiated3HandCard22b";

                } else if (card.name == "instantiated3Card22c(Clone)") {

                    card.name = "instantiated3HandCard22c";

                } else if (card.name == "instantiated3Card23(Clone)") {

                    card.name = "instantiated3HandCard23";

                } else if (card.name == "instantiated3Card23a(Clone)") {

                    card.name = "instantiated3HandCard23a";

                } else if (card.name == "instantiated3Card23b(Clone)") {

                    card.name = "instantiated3HandCard23b";

                } else if (card.name == "instantiated3Card23c(Clone)") {

                    card.name = "instantiated3HandCard23c";

                } else if (card.name == "instantiated3Card24(Clone)") {

                    card.name = "instantiated3HandCard24";

                } else if (card.name == "instantiated3Card24a(Clone)") {

                    card.name = "instantiated3HandCard24a";

                } else if (card.name == "instantiated3Card24b(Clone)") {

                    card.name = "instantiated3HandCard24b";

                } else if (card.name == "instantiated3Card24c(Clone)") {

                    card.name = "instantiated3HandCard24c";

                } else if (card.name == "instantiated3Card25(Clone)") {

                    card.name = "instantiated3HandCard25";

                } else if (card.name == "instantiated3Card25a(Clone)") {

                    card.name = "instantiated3HandCard25a";

                } else if (card.name == "instantiated3Card25b(Clone)") {

                    card.name = "instantiated3HandCard25b";

                } else if (card.name == "instantiated3Card25c(Clone)") {

                    card.name = "instantiated3HandCard25c";

                } else if (card.name == "instantiated3Card26(Clone)") {

                    card.name = "instantiated3HandCard26";

                } else if (card.name == "instantiated3Card26a(Clone)") {

                    card.name = "instantiated3HandCard26a";

                } else if (card.name == "instantiated3Card26b(Clone)") {

                    card.name = "instantiated3HandCard26b";

                } else if (card.name == "instantiated3Card26c(Clone)") {

                    card.name = "instantiated3HandCard26c";

                } else if (card.name == "instantiated3Card27(Clone)") {

                    card.name = "instantiated3HandCard27";

                } else if (card.name == "instantiated3Card27a(Clone)") {

                    card.name = "instantiated3HandCard27a";

                } else if (card.name == "instantiated3Card27b(Clone)") {

                    card.name = "instantiated3HandCard27b";

                } else if (card.name == "instantiated3Card27c(Clone)") {

                    card.name = "instantiated3HandCard27c";

                } else if (card.name == "instantiated3Card28(Clone)") {

                    card.name = "instantiated3HandCard28";

                } else if (card.name == "instantiated3Card28a(Clone)") {

                    card.name = "instantiated3HandCard28a";

                } else if (card.name == "instantiated3Card28b(Clone)") {

                    card.name = "instantiated3HandCard28b";

                } else if (card.name == "instantiated3Card28c(Clone)") {

                    card.name = "instantiated3HandCard28c";

                } else if (card.name == "instantiated3Card29(Clone)") {

                    card.name = "instantiated3HandCard29";

                } else if (card.name == "instantiated3Card29a(Clone)") {

                    card.name = "instantiated3HandCard29a";

                } else if (card.name == "instantiated3Card29b(Clone)") {

                    card.name = "instantiated3HandCard29b";

                } else if (card.name == "instantiated3Card29c(Clone)") {

                    card.name = "instantiated3HandCard29c";

                } else if (card.name == "instantiated3Card30(Clone)") {

                    card.name = "instantiated3HandCard30";

                } else if (card.name == "instantiated3Card30a(Clone)") {

                    card.name = "instantiated3HandCard30a";

                } else if (card.name == "instantiated3Card30b(Clone)") {

                    card.name = "instantiated3HandCard30b";

                } else if (card.name == "instantiated3Card30c(Clone)") {

                    card.name = "instantiated3HandCard30c";

                } else if (card.name == "instantiated3Card31(Clone)") {

                    card.name = "instantiated3HandCard31";

                } else if (card.name == "instantiated3Card31a(Clone)") {

                    card.name = "instantiated3HandCard31a";

                } else if (card.name == "instantiated3Card31b(Clone)") {

                    card.name = "instantiated3HandCard31b";

                } else if (card.name == "instantiated3Card31c(Clone)") {

                    card.name = "instantiated3HandCard31c";

                } else if (card.name == "instantiated3Card32(Clone)") {

                    card.name = "instantiated3HandCard32";

                } else if (card.name == "instantiated3Card32a(Clone)") {

                    card.name = "instantiated3HandCard32a";

                } else if (card.name == "instantiated3Card32b(Clone)") {

                    card.name = "instantiated3HandCard32b";

                } else if (card.name == "instantiated3Card32c(Clone)") {

                    card.name = "instantiated3HandCard32c";

                } else if (card.name == "instantiated3Card33(Clone)") {

                    card.name = "instantiated3HandCard33";

                } else if (card.name == "instantiated3Card33a(Clone)") {

                    card.name = "instantiated3HandCard33a";

                } else if (card.name == "instantiated3Card33b(Clone)") {

                    card.name = "instantiated3HandCard33b";

                } else if (card.name == "instantiated3Card33c(Clone)") {

                    card.name = "instantiated3HandCard33c";

                } else if (card.name == "instantiated3Card34(Clone)") {

                    card.name = "instantiated3HandCard34";

                } else if (card.name == "instantiated3Card34a(Clone)") {

                    card.name = "instantiated3HandCard34a";

                } else if (card.name == "instantiated3Card34b(Clone)") {

                    card.name = "instantiated3HandCard34b";

                } else if (card.name == "instantiated3Card34c(Clone)") {

                    card.name = "instantiated3HandCard34c";

                } else if (card.name == "instantiated3Card35(Clone)") {

                    card.name = "instantiated3HandCard35";

                } else if (card.name == "instantiated3Card35a(Clone)") {

                    card.name = "instantiated3HandCard35a";

                } else if (card.name == "instantiated3Card35b(Clone)") {

                    card.name = "instantiated3HandCard35b";

                } else if (card.name == "instantiated3Card35c(Clone)") {

                    card.name = "instantiated3HandCard35c";

                } else if (card.name == "instantiated3Card36(Clone)") {

                    card.name = "instantiated3HandCard36";

                } else if (card.name == "instantiated3Card36a(Clone)") {

                    card.name = "instantiated3HandCard36a";

                } else if (card.name == "instantiated3Card36b(Clone)") {

                    card.name = "instantiated3HandCard36b";

                } else if (card.name == "instantiated3Card36c(Clone)") {

                    card.name = "instantiated3HandCard36c";

                } else if (card.name == "instantiated3Card37(Clone)") {

                    card.name = "instantiated3HandCard37";

                } else if (card.name == "instantiated3Card37a(Clone)") {

                    card.name = "instantiated3HandCard37a";

                } else if (card.name == "instantiated3Card37b(Clone)") {

                    card.name = "instantiated3HandCard37b";

                } else if (card.name == "instantiated3Card37c(Clone)") {

                    card.name = "instantiated3HandCard37c";

                } else if (card.name == "instantiated3Card38(Clone)") {

                    card.name = "instantiated3HandCard38";

                } else if (card.name == "instantiated3Card38a(Clone)") {

                    card.name = "instantiated3HandCard38a";

                } else if (card.name == "instantiated3Card38b(Clone)") {

                    card.name = "instantiated3HandCard38b";

                } else if (card.name == "instantiated3Card38c(Clone)") {

                    card.name = "instantiated3HandCard38c";

                } else if (card.name == "instantiated3Card39(Clone)") {

                    card.name = "instantiated3HandCard39";

                } else if (card.name == "instantiated3Card39a(Clone)") {

                    card.name = "instantiated3HandCard39a";

                } else if (card.name == "instantiated3Card39b(Clone)") {

                    card.name = "instantiated3HandCard39b";

                } else if (card.name == "instantiated3Card39c(Clone)") {

                    card.name = "instantiated3HandCard39c";

                } else if (card.name == "instantiated3Card40(Clone)") {

                    card.name = "instantiated3HandCard40";

                } else if (card.name == "instantiated3Card40a(Clone)") {

                    card.name = "instantiated3HandCard40a";

                } else if (card.name == "instantiated3Card40b(Clone)") {

                    card.name = "instantiated3HandCard40b";

                } else if (card.name == "instantiated3Card40c(Clone)") {

                    card.name = "instantiated3HandCard40c";

                } else if (card.name == "instantiated3Card41(Clone)") {

                    card.name = "instantiated3HandCard41";

                } else if (card.name == "instantiated3Card41a(Clone)") {

                    card.name = "instantiated3HandCard41a";

                } else if (card.name == "instantiated3Card41b(Clone)") {

                    card.name = "instantiated3HandCard41b";

                } else if (card.name == "instantiated3Card41c(Clone)") {

                    card.name = "instantiated3HandCard41c";

                } else if (card.name == "instantiated3Card42(Clone)") {

                    card.name = "instantiated3HandCard42";

                } else if (card.name == "instantiated3Card42a(Clone)") {

                    card.name = "instantiated3HandCard42a";

                } else if (card.name == "instantiated3Card42b(Clone)") {

                    card.name = "instantiated3HandCard42b";

                } else if (card.name == "instantiated3Card42c(Clone)") {

                    card.name = "instantiated3HandCard42c";

                } else if (card.name == "instantiated3Card43(Clone)") {

                    card.name = "instantiated3HandCard43";

                } else if (card.name == "instantiated3Card43a(Clone)") {

                    card.name = "instantiated3HandCard43a";

                } else if (card.name == "instantiated3Card43b(Clone)") {

                    card.name = "instantiated3HandCard43b";

                } else if (card.name == "instantiated3Card43c(Clone)") {

                    card.name = "instantiated3HandCard43c";

                } else if (card.name == "instantiated3Card44(Clone)") {

                    card.name = "instantiated3HandCard44";

                } else if (card.name == "instantiated3Card44a(Clone)") {

                    card.name = "instantiated3HandCard44a";

                } else if (card.name == "instantiated3Card44b(Clone)") {

                    card.name = "instantiated3HandCard44b";

                } else if (card.name == "instantiated3Card44c(Clone)") {

                    card.name = "instantiated3HandCard44c";

                } else if (card.name == "instantiated3Card45(Clone)") {

                    card.name = "instantiated3HandCard45";

                } else if (card.name == "instantiated3Card45a(Clone)") {

                    card.name = "instantiated3HandCard45a";

                } else if (card.name == "instantiated3Card45b(Clone)") {

                    card.name = "instantiated3HandCard45b";

                } else if (card.name == "instantiated3Card45c(Clone)") {

                    card.name = "instantiated3HandCard45c";

                } else if (card.name == "instantiated3Card46(Clone)") {

                    card.name = "instantiated3HandCard46";

                } else if (card.name == "instantiated3Card46a(Clone)") {

                    card.name = "instantiated3HandCard46a";

                } else if (card.name == "instantiated3Card46b(Clone)") {

                    card.name = "instantiated3HandCard46b";

                } else if (card.name == "instantiated3Card46c(Clone)") {

                    card.name = "instantiated3HandCard46c";

                } else if (card.name == "instantiated3Card47(Clone)") {

                    card.name = "instantiated3HandCard47";

                } else if (card.name == "instantiated3Card47a(Clone)") {

                    card.name = "instantiated3HandCard47a";

                } else if (card.name == "instantiated3Card47b(Clone)") {

                    card.name = "instantiated3HandCard47b";

                } else if (card.name == "instantiated3Card47c(Clone)") {

                    card.name = "instantiated3HandCard47c";

                } else if (card.name == "instantiated3Card48(Clone)") {

                    card.name = "instantiated3HandCard48";

                } else if (card.name == "instantiated3Card48a(Clone)") {

                    card.name = "instantiated3HandCard48a";

                } else if (card.name == "instantiated3Card48b(Clone)") {

                    card.name = "instantiated3HandCard48b";

                } else if (card.name == "instantiated3Card48c(Clone)") {

                    card.name = "instantiated3HandCard48c";

                } else if (card.name == "instantiated3Card49(Clone)") {

                    card.name = "instantiated3HandCard49";

                } else if (card.name == "instantiated3Card49a(Clone)") {

                    card.name = "instantiated3HandCard49a";

                } else if (card.name == "instantiated3Card49b(Clone)") {

                    card.name = "instantiated3HandCard49b";

                } else if (card.name == "instantiated3Card49c(Clone)") {

                    card.name = "instantiated3HandCard49c";

                } else if (card.name == "instantiated3Card50(Clone)") {

                    card.name = "instantiated3HandCard50";

                } else if (card.name == "instantiated3Card50a(Clone)") {

                    card.name = "instantiated3HandCard50a";

                } else if (card.name == "instantiated3Card50b(Clone)") {

                    card.name = "instantiated3HandCard50b";

                } else if (card.name == "instantiated3Card50c(Clone)") {

                    card.name = "instantiated3HandCard50c";

                } else if (card.name == "instantiated3Card51(Clone)") {

                    card.name = "instantiated3HandCard51";

                } else if (card.name == "instantiated3Card51a(Clone)") {

                    card.name = "instantiated3HandCard51a";

                } else if (card.name == "instantiated3Card51b(Clone)") {

                    card.name = "instantiated3HandCard51b";

                } else if (card.name == "instantiated3Card51c(Clone)") {

                    card.name = "instantiated3HandCard51c";

                } else if (card.name == "instantiated3Card52(Clone)") {

                    card.name = "instantiated3HandCard52";

                } else if (card.name == "instantiated3Card52a(Clone)") {

                    card.name = "instantiated3HandCard52a";

                } else if (card.name == "instantiated3Card52b(Clone)") {

                    card.name = "instantiated3HandCard52b";

                } else if (card.name == "instantiated3Card52c(Clone)") {

                    card.name = "instantiated3HandCard52c";

                } else if (card.name == "instantiated3Card53(Clone)") {

                    card.name = "instantiated3HandCard53";

                } else if (card.name == "instantiated3Card53a(Clone)") {

                    card.name = "instantiated3HandCard53a";

                } else if (card.name == "instantiated3Card53b(Clone)") {

                    card.name = "instantiated3HandCard53b";

                } else if (card.name == "instantiated3Card53c(Clone)") {

                    card.name = "instantiated3HandCard53c";

                } else if (card.name == "instantiated3Card54(Clone)") {

                    card.name = "instantiated3HandCard54";

                } else if (card.name == "instantiated3Card54a(Clone)") {

                    card.name = "instantiated3HandCard54a";

                } else if (card.name == "instantiated3Card54b(Clone)") {

                    card.name = "instantiated3HandCard54b";

                } else if (card.name == "instantiated3Card54c(Clone)") {

                    card.name = "instantiated3HandCard54c";

                } else if (card.name == "instantiated3Card55(Clone)") {

                    card.name = "instantiated3HandCard55";

                } else if (card.name == "instantiated3Card55a(Clone)") {

                    card.name = "instantiated3HandCard55a";

                } else if (card.name == "instantiated3Card55b(Clone)") {

                    card.name = "instantiated3HandCard55b";

                } else if (card.name == "instantiated3Card55c(Clone)") {

                    card.name = "instantiated3HandCard55c";

                } else if (card.name == "instantiated3Card56(Clone)") {

                    card.name = "instantiated3HandCard56";

                } else if (card.name == "instantiated3Card56a(Clone)") {

                    card.name = "instantiated3HandCard56a";

                } else if (card.name == "instantiated3Card56b(Clone)") {

                    card.name = "instantiated3HandCard56b";

                } else if (card.name == "instantiated3Card56c(Clone)") {

                    card.name = "instantiated3HandCard56c";

                } else if (card.name == "instantiated3Card57(Clone)") {

                    card.name = "instantiated3HandCard57";

                } else if (card.name == "instantiated3Card57a(Clone)") {

                    card.name = "instantiated3HandCard57a";

                } else if (card.name == "instantiated3Card57b(Clone)") {

                    card.name = "instantiated3HandCard57b";

                } else if (card.name == "instantiated3Card57c(Clone)") {

                    card.name = "instantiated3HandCard57c";

                } else if (card.name == "instantiated3Card58(Clone)") {

                    card.name = "instantiated3HandCard58";

                } else if (card.name == "instantiated3Card58a(Clone)") {

                    card.name = "instantiated3HandCard58a";

                } else if (card.name == "instantiated3Card58b(Clone)") {

                    card.name = "instantiated3HandCard58b";

                } else if (card.name == "instantiated3Card58c(Clone)") {

                    card.name = "instantiated3HandCard58c";

                } else if (card.name == "instantiated3Card59(Clone)") {

                    card.name = "instantiated3HandCard59";

                } else if (card.name == "instantiated3Card59a(Clone)") {

                    card.name = "instantiated3HandCard59a";

                } else if (card.name == "instantiated3Card59b(Clone)") {

                    card.name = "instantiated3HandCard59b";

                } else if (card.name == "instantiated3Card59c(Clone)") {

                    card.name = "instantiated3HandCard59c";

                } else if (card.name == "instantiated3Card60(Clone)") {

                    card.name = "instantiated3HandCard60";

                } else if (card.name == "instantiated3Card60a(Clone)") {

                    card.name = "instantiated3HandCard60a";

                } else if (card.name == "instantiated3Card60b(Clone)") {

                    card.name = "instantiated3HandCard60b";

                } else if (card.name == "instantiated3Card60c(Clone)") {

                    card.name = "instantiated3HandCard60c";
                }

                instances10++;

            }



        }


        //DoneButton3
        public void SpawnHandCardsMulligan3() {

            if (player1DeckSlot1.transform.childCount == 0) {

                while (instances1M < NumberOfCards) {

                    GameObject card = Instantiate(playCardsDeck3[UnityEngine.Random.Range(0, playCardsDeck3.Count)], player1DeckSlot1.transform.position, player1DeckSlot1.transform.rotation) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.transform.parent = player1DeckSlot1.transform;

                    if (card.name == "instantiated3Card1(Clone)") {

                        card.name = "instantiated3HandCard1";

                    } else if (card.name == "instantiated3Card1a(Clone)") {

                        card.name = "instantiated3HandCard1a";

                    } else if (card.name == "instantiated3Card1b(Clone)") {

                        card.name = "instantiated3HandCard1b";

                    } else if (card.name == "instantiated3Card1c(Clone)") {

                        card.name = "instantiated3HandCard1c";

                    } else if (card.name == "instantiated3Card2(Clone)") {

                        card.name = "instantiated3HandCard2";

                    } else if (card.name == "instantiated3Card2a(Clone)") {

                        card.name = "instantiated3HandCard2a";

                    } else if (card.name == "instantiated3Card2b(Clone)") {

                        card.name = "instantiated3HandCard2b";

                    } else if (card.name == "instantiated3Card2c(Clone)") {

                        card.name = "instantiated3HandCard2c";

                    } else if (card.name == "instantiated3Card3(Clone)") {

                        card.name = "instantiated3HandCard3";

                    } else if (card.name == "instantiated3Card3a(Clone)") {

                        card.name = "instantiated3HandCard3a";

                    } else if (card.name == "instantiated3Card3b(Clone)") {

                        card.name = "instantiated3HandCard3b";

                    } else if (card.name == "instantiated3Card3c(Clone)") {

                        card.name = "instantiated3HandCard3c";

                    } else if (card.name == "instantiated3Card4(Clone)") {

                        card.name = "instantiated3HandCard4";

                    } else if (card.name == "instantiated3Card4a(Clone)") {

                        card.name = "instantiated3HandCard4a";

                    } else if (card.name == "instantiated3Card4b(Clone)") {

                        card.name = "instantiated3HandCard4b";

                    } else if (card.name == "instantiated3Card4c(Clone)") {

                        card.name = "instantiated3HandCard4c";

                    } else if (card.name == "instantiated3Card5(Clone)") {

                        card.name = "instantiated3HandCard5";

                    } else if (card.name == "instantiated3Card5a(Clone)") {

                        card.name = "instantiated3HandCard5a";

                    } else if (card.name == "instantiated3Card5b(Clone)") {

                        card.name = "instantiated3HandCard5b";

                    } else if (card.name == "instantiated3Card5c(Clone)") {

                        card.name = "instantiated3HandCard5c";

                    } else if (card.name == "instantiated3Card6(Clone)") {

                        card.name = "instantiated3HandCard6";

                    } else if (card.name == "instantiated3Card6a(Clone)") {

                        card.name = "instantiated3HandCard6a";

                    } else if (card.name == "instantiated3Card6b(Clone)") {

                        card.name = "instantiated3HandCard6b";

                    } else if (card.name == "instantiated3Card6c(Clone)") {

                        card.name = "instantiated3HandCard6c";

                    } else if (card.name == "instantiated3Card7(Clone)") {

                        card.name = "instantiated3HandCard7";

                    } else if (card.name == "instantiated3Card7a(Clone)") {

                        card.name = "instantiated3HandCard7a";

                    } else if (card.name == "instantiated3Card7b(Clone)") {

                        card.name = "instantiated3HandCard7b";

                    } else if (card.name == "instantiated3Card7c(Clone)") {

                        card.name = "instantiated3HandCard7c";

                    } else if (card.name == "instantiated3Card8(Clone)") {

                        card.name = "instantiated3HandCard8";

                    } else if (card.name == "instantiated3Card8a(Clone)") {

                        card.name = "instantiated3HandCard8a";

                    } else if (card.name == "instantiated3Card8b(Clone)") {

                        card.name = "instantiated3HandCard8b";

                    } else if (card.name == "instantiated3Card8c(Clone)") {

                        card.name = "instantiated3HandCard8c";

                    } else if (card.name == "instantiated3Card9(Clone)") {

                        card.name = "instantiated3HandCard9";

                    } else if (card.name == "instantiated3Card9a(Clone)") {

                        card.name = "instantiated3HandCard9a";

                    } else if (card.name == "instantiated3Card9b(Clone)") {

                        card.name = "instantiated3HandCard9b";

                    } else if (card.name == "instantiated3Card9c(Clone)") {

                        card.name = "instantiated3HandCard9c";

                    } else if (card.name == "instantiated3Card10(Clone)") {

                        card.name = "instantiatedAICard10";

                    } else if (card.name == "instantiated3Card10a(Clone)") {

                        card.name = "instantiated3HandCard10a";

                    } else if (card.name == "instantiated3Card10b(Clone)") {

                        card.name = "instantiated3HandCard10b";

                    } else if (card.name == "instantiated3Card10c(Clone)") {

                        card.name = "instantiated3HandCard10c";

                    } else if (card.name == "instantiated3Card11(Clone)") {

                        card.name = "instantiated3HandCard11";

                    } else if (card.name == "instantiated3Card11a(Clone)") {

                        card.name = "instantiated3HandCard11a";

                    } else if (card.name == "instantiated3Card11b(Clone)") {

                        card.name = "instantiated3HandCard11b";

                    } else if (card.name == "instantiated3Card11c(Clone)") {

                        card.name = "instantiated3HandCard11c";

                    } else if (card.name == "instantiated3Card12(Clone)") {

                        card.name = "instantiated3HandCard12";

                    } else if (card.name == "instantiated3Card12a(Clone)") {

                        card.name = "instantiated3HandCard12a";

                    } else if (card.name == "instantiated3Card12b(Clone)") {

                        card.name = "instantiated3HandCard12b";

                    } else if (card.name == "instantiated3Card12c(Clone)") {

                        card.name = "instantiated3HandCard12c";

                    } else if (card.name == "instantiated3Card13(Clone)") {

                        card.name = "instantiated3HandCard13";

                    } else if (card.name == "instantiated3Card13a(Clone)") {

                        card.name = "instantiated3HandCard13a";

                    } else if (card.name == "instantiated3Card13b(Clone)") {

                        card.name = "instantiated3HandCard13b";

                    } else if (card.name == "instantiated3Card13c(Clone)") {

                        card.name = "instantiated3HandCard13c";

                    } else if (card.name == "instantiated3Card14(Clone)") {

                        card.name = "instantiated3HandCard14";

                    } else if (card.name == "instantiated3Card14a(Clone)") {

                        card.name = "instantiated3HandCard14a";

                    } else if (card.name == "instantiated3Card14b(Clone)") {

                        card.name = "instantiated3HandCard14b";

                    } else if (card.name == "instantiated3Card14c(Clone)") {

                        card.name = "instantiated3HandCard14c";

                    } else if (card.name == "instantiated3Card15(Clone)") {

                        card.name = "instantiated3HandCard15";

                    } else if (card.name == "instantiated3Card15a(Clone)") {

                        card.name = "instantiated3HandCard15a";

                    } else if (card.name == "instantiated3Card15b(Clone)") {

                        card.name = "instantiated3HandCard15b";

                    } else if (card.name == "instantiated3Card15c(Clone)") {

                        card.name = "instantiated3HandCard15c";

                    } else if (card.name == "instantiated3Card16(Clone)") {

                        card.name = "instantiated3HandCard16";

                    } else if (card.name == "instantiated3Card16a(Clone)") {

                        card.name = "instantiated3HandCard16a";

                    } else if (card.name == "instantiated3Card16b(Clone)") {

                        card.name = "instantiated3HandCard16b";

                    } else if (card.name == "instantiated3Card16c(Clone)") {

                        card.name = "instantiated3HandCard16c";

                    } else if (card.name == "instantiated3Card17(Clone)") {

                        card.name = "instantiated3HandCard17";

                    } else if (card.name == "instantiated3Card17a(Clone)") {

                        card.name = "instantiated3HandCard17a";

                    } else if (card.name == "instantiated3Card17b(Clone)") {

                        card.name = "instantiated3HandCard17b";

                    } else if (card.name == "instantiated3Card17c(Clone)") {

                        card.name = "instantiated3HandCard17c";

                    } else if (card.name == "instantiated3Card18(Clone)") {

                        card.name = "instantiated3HandCard18";

                    } else if (card.name == "instantiated3Card18a(Clone)") {

                        card.name = "instantiated3HandCard18a";

                    } else if (card.name == "instantiated3Card18b(Clone)") {

                        card.name = "instantiated3HandCard18b";

                    } else if (card.name == "instantiated3Card18c(Clone)") {

                        card.name = "instantiated3HandCard18c";

                    } else if (card.name == "instantiated3Card19(Clone)") {

                        card.name = "instantiated3HandCard19";

                    } else if (card.name == "instantiated3Card19a(Clone)") {

                        card.name = "instantiated3HandCard19a";

                    } else if (card.name == "instantiated3Card19b(Clone)") {

                        card.name = "instantiated3HandCard19b";

                    } else if (card.name == "instantiated3Card19c(Clone)") {

                        card.name = "instantiated3HandCard19c";

                    } else if (card.name == "instantiated3Card20(Clone)") {

                        card.name = "instantiated3HandCard20";

                    } else if (card.name == "instantiated3Card20a(Clone)") {

                        card.name = "instantiated3HandCard20a";

                    } else if (card.name == "instantiated3Card20b(Clone)") {

                        card.name = "instantiated3HandCard20b";

                    } else if (card.name == "instantiated3Card20c(Clone)") {

                        card.name = "instantiated3HandCard20c";

                    } else if (card.name == "instantiated3Card21(Clone)") {

                        card.name = "instantiated3HandCard21";

                    } else if (card.name == "instantiated3Card21a(Clone)") {

                        card.name = "instantiated3HandCard21a";

                    } else if (card.name == "instantiated3Card21b(Clone)") {

                        card.name = "instantiated3HandCard21b";

                    } else if (card.name == "instantiated3Card21c(Clone)") {

                        card.name = "instantiated3HandCard21c";

                    } else if (card.name == "instantiated3Card22(Clone)") {

                        card.name = "instantiated3HandCard22";

                    } else if (card.name == "instantiated3Card22a(Clone)") {

                        card.name = "instantiated3HandCard22a";

                    } else if (card.name == "instantiated3Card22b(Clone)") {

                        card.name = "instantiated3HandCard22b";

                    } else if (card.name == "instantiated3Card22c(Clone)") {

                        card.name = "instantiated3HandCard22c";

                    } else if (card.name == "instantiated3Card23(Clone)") {

                        card.name = "instantiated3HandCard23";

                    } else if (card.name == "instantiated3Card23a(Clone)") {

                        card.name = "instantiated3HandCard23a";

                    } else if (card.name == "instantiated3Card23b(Clone)") {

                        card.name = "instantiated3HandCard23b";

                    } else if (card.name == "instantiated3Card23c(Clone)") {

                        card.name = "instantiated3HandCard23c";

                    } else if (card.name == "instantiated3Card24(Clone)") {

                        card.name = "instantiated3HandCard24";

                    } else if (card.name == "instantiated3Card24a(Clone)") {

                        card.name = "instantiated3HandCard24a";

                    } else if (card.name == "instantiated3Card24b(Clone)") {

                        card.name = "instantiated3HandCard24b";

                    } else if (card.name == "instantiated3Card24c(Clone)") {

                        card.name = "instantiated3HandCard24c";

                    } else if (card.name == "instantiated3Card25(Clone)") {

                        card.name = "instantiated3HandCard25";

                    } else if (card.name == "instantiated3Card25a(Clone)") {

                        card.name = "instantiated3HandCard25a";

                    } else if (card.name == "instantiated3Card25b(Clone)") {

                        card.name = "instantiated3HandCard25b";

                    } else if (card.name == "instantiated3Card25c(Clone)") {

                        card.name = "instantiated3HandCard25c";

                    } else if (card.name == "instantiated3Card26(Clone)") {

                        card.name = "instantiated3HandCard26";

                    } else if (card.name == "instantiated3Card26a(Clone)") {

                        card.name = "instantiated3HandCard26a";

                    } else if (card.name == "instantiated3Card26b(Clone)") {

                        card.name = "instantiated3HandCard26b";

                    } else if (card.name == "instantiated3Card26c(Clone)") {

                        card.name = "instantiated3HandCard26c";

                    } else if (card.name == "instantiated3Card27(Clone)") {

                        card.name = "instantiated3HandCard27";

                    } else if (card.name == "instantiated3Card27a(Clone)") {

                        card.name = "instantiated3HandCard27a";

                    } else if (card.name == "instantiated3Card27b(Clone)") {

                        card.name = "instantiated3HandCard27b";

                    } else if (card.name == "instantiated3Card27c(Clone)") {

                        card.name = "instantiated3HandCard27c";

                    } else if (card.name == "instantiated3Card28(Clone)") {

                        card.name = "instantiated3HandCard28";

                    } else if (card.name == "instantiated3Card28a(Clone)") {

                        card.name = "instantiated3HandCard28a";

                    } else if (card.name == "instantiated3Card28b(Clone)") {

                        card.name = "instantiated3HandCard28b";

                    } else if (card.name == "instantiated3Card28c(Clone)") {

                        card.name = "instantiated3HandCard28c";

                    } else if (card.name == "instantiated3Card29(Clone)") {

                        card.name = "instantiated3HandCard29";

                    } else if (card.name == "instantiated3Card29a(Clone)") {

                        card.name = "instantiated3HandCard29a";

                    } else if (card.name == "instantiated3Card29b(Clone)") {

                        card.name = "instantiated3HandCard29b";

                    } else if (card.name == "instantiated3Card29c(Clone)") {

                        card.name = "instantiated3HandCard29c";

                    } else if (card.name == "instantiated3Card30(Clone)") {

                        card.name = "instantiated3HandCard30";

                    } else if (card.name == "instantiated3Card30a(Clone)") {

                        card.name = "instantiated3HandCard30a";

                    } else if (card.name == "instantiated3Card30b(Clone)") {

                        card.name = "instantiated3HandCard30b";

                    } else if (card.name == "instantiated3Card30c(Clone)") {

                        card.name = "instantiated3HandCard30c";

                    } else if (card.name == "instantiated3Card31(Clone)") {

                        card.name = "instantiated3HandCard31";

                    } else if (card.name == "instantiated3Card31a(Clone)") {

                        card.name = "instantiated3HandCard31a";

                    } else if (card.name == "instantiated3Card31b(Clone)") {

                        card.name = "instantiated3HandCard31b";

                    } else if (card.name == "instantiated3Card31c(Clone)") {

                        card.name = "instantiated3HandCard31c";

                    } else if (card.name == "instantiated3Card32(Clone)") {

                        card.name = "instantiated3HandCard32";

                    } else if (card.name == "instantiated3Card32a(Clone)") {

                        card.name = "instantiated3HandCard32a";

                    } else if (card.name == "instantiated3Card32b(Clone)") {

                        card.name = "instantiated3HandCard32b";

                    } else if (card.name == "instantiated3Card32c(Clone)") {

                        card.name = "instantiated3HandCard32c";

                    } else if (card.name == "instantiated3Card33(Clone)") {

                        card.name = "instantiated3HandCard33";

                    } else if (card.name == "instantiated3Card33a(Clone)") {

                        card.name = "instantiated3HandCard33a";

                    } else if (card.name == "instantiated3Card33b(Clone)") {

                        card.name = "instantiated3HandCard33b";

                    } else if (card.name == "instantiated3Card33c(Clone)") {

                        card.name = "instantiated3HandCard33c";

                    } else if (card.name == "instantiated3Card34(Clone)") {

                        card.name = "instantiated3HandCard34";

                    } else if (card.name == "instantiated3Card34a(Clone)") {

                        card.name = "instantiated3HandCard34a";

                    } else if (card.name == "instantiated3Card34b(Clone)") {

                        card.name = "instantiated3HandCard34b";

                    } else if (card.name == "instantiated3Card34c(Clone)") {

                        card.name = "instantiated3HandCard34c";

                    } else if (card.name == "instantiated3Card35(Clone)") {

                        card.name = "instantiated3HandCard35";

                    } else if (card.name == "instantiated3Card35a(Clone)") {

                        card.name = "instantiated3HandCard35a";

                    } else if (card.name == "instantiated3Card35b(Clone)") {

                        card.name = "instantiated3HandCard35b";

                    } else if (card.name == "instantiated3Card35c(Clone)") {

                        card.name = "instantiated3HandCard35c";

                    } else if (card.name == "instantiated3Card36(Clone)") {

                        card.name = "instantiated3HandCard36";

                    } else if (card.name == "instantiated3Card36a(Clone)") {

                        card.name = "instantiated3HandCard36a";

                    } else if (card.name == "instantiated3Card36b(Clone)") {

                        card.name = "instantiated3HandCard36b";

                    } else if (card.name == "instantiated3Card36c(Clone)") {

                        card.name = "instantiated3HandCard36c";

                    } else if (card.name == "instantiated3Card37(Clone)") {

                        card.name = "instantiated3HandCard37";

                    } else if (card.name == "instantiated3Card37a(Clone)") {

                        card.name = "instantiated3HandCard37a";

                    } else if (card.name == "instantiated3Card37b(Clone)") {

                        card.name = "instantiated3HandCard37b";

                    } else if (card.name == "instantiated3Card37c(Clone)") {

                        card.name = "instantiated3HandCard37c";

                    } else if (card.name == "instantiated3Card38(Clone)") {

                        card.name = "instantiated3HandCard38";

                    } else if (card.name == "instantiated3Card38a(Clone)") {

                        card.name = "instantiated3HandCard38a";

                    } else if (card.name == "instantiated3Card38b(Clone)") {

                        card.name = "instantiated3HandCard38b";

                    } else if (card.name == "instantiated3Card38c(Clone)") {

                        card.name = "instantiated3HandCard38c";

                    } else if (card.name == "instantiated3Card39(Clone)") {

                        card.name = "instantiated3HandCard39";

                    } else if (card.name == "instantiated3Card39a(Clone)") {

                        card.name = "instantiated3HandCard39a";

                    } else if (card.name == "instantiated3Card39b(Clone)") {

                        card.name = "instantiated3HandCard39b";

                    } else if (card.name == "instantiated3Card39c(Clone)") {

                        card.name = "instantiated3HandCard39c";

                    } else if (card.name == "instantiated3Card40(Clone)") {

                        card.name = "instantiated3HandCard40";

                    } else if (card.name == "instantiated3Card40a(Clone)") {

                        card.name = "instantiated3HandCard40a";

                    } else if (card.name == "instantiated3Card40b(Clone)") {

                        card.name = "instantiated3HandCard40b";

                    } else if (card.name == "instantiated3Card40c(Clone)") {

                        card.name = "instantiated3HandCard40c";

                    } else if (card.name == "instantiated3Card41(Clone)") {

                        card.name = "instantiated3HandCard41";

                    } else if (card.name == "instantiated3Card41a(Clone)") {

                        card.name = "instantiated3HandCard41a";

                    } else if (card.name == "instantiated3Card41b(Clone)") {

                        card.name = "instantiated3HandCard41b";

                    } else if (card.name == "instantiated3Card41c(Clone)") {

                        card.name = "instantiated3HandCard41c";

                    } else if (card.name == "instantiated3Card42(Clone)") {

                        card.name = "instantiated3HandCard42";

                    } else if (card.name == "instantiated3Card42a(Clone)") {

                        card.name = "instantiated3HandCard42a";

                    } else if (card.name == "instantiated3Card42b(Clone)") {

                        card.name = "instantiated3HandCard42b";

                    } else if (card.name == "instantiated3Card42c(Clone)") {

                        card.name = "instantiated3HandCard42c";

                    } else if (card.name == "instantiated3Card43(Clone)") {

                        card.name = "instantiated3HandCard43";

                    } else if (card.name == "instantiated3Card43a(Clone)") {

                        card.name = "instantiated3HandCard43a";

                    } else if (card.name == "instantiated3Card43b(Clone)") {

                        card.name = "instantiated3HandCard43b";

                    } else if (card.name == "instantiated3Card43c(Clone)") {

                        card.name = "instantiated3HandCard43c";

                    } else if (card.name == "instantiated3Card44(Clone)") {

                        card.name = "instantiated3HandCard44";

                    } else if (card.name == "instantiated3Card44a(Clone)") {

                        card.name = "instantiated3HandCard44a";

                    } else if (card.name == "instantiated3Card44b(Clone)") {

                        card.name = "instantiated3HandCard44b";

                    } else if (card.name == "instantiated3Card44c(Clone)") {

                        card.name = "instantiated3HandCard44c";

                    } else if (card.name == "instantiated3Card45(Clone)") {

                        card.name = "instantiated3HandCard45";

                    } else if (card.name == "instantiated3Card45a(Clone)") {

                        card.name = "instantiated3HandCard45a";

                    } else if (card.name == "instantiated3Card45b(Clone)") {

                        card.name = "instantiated3HandCard45b";

                    } else if (card.name == "instantiated3Card45c(Clone)") {

                        card.name = "instantiated3HandCard45c";

                    } else if (card.name == "instantiated3Card46(Clone)") {

                        card.name = "instantiated3HandCard46";

                    } else if (card.name == "instantiated3Card46a(Clone)") {

                        card.name = "instantiated3HandCard46a";

                    } else if (card.name == "instantiated3Card46b(Clone)") {

                        card.name = "instantiated3HandCard46b";

                    } else if (card.name == "instantiated3Card46c(Clone)") {

                        card.name = "instantiated3HandCard46c";

                    } else if (card.name == "instantiated3Card47(Clone)") {

                        card.name = "instantiated3HandCard47";

                    } else if (card.name == "instantiated3Card47a(Clone)") {

                        card.name = "instantiated3HandCard47a";

                    } else if (card.name == "instantiated3Card47b(Clone)") {

                        card.name = "instantiated3HandCard47b";

                    } else if (card.name == "instantiated3Card47c(Clone)") {

                        card.name = "instantiated3HandCard47c";

                    } else if (card.name == "instantiated3Card48(Clone)") {

                        card.name = "instantiated3HandCard48";

                    } else if (card.name == "instantiated3Card48a(Clone)") {

                        card.name = "instantiated3HandCard48a";

                    } else if (card.name == "instantiated3Card48b(Clone)") {

                        card.name = "instantiated3HandCard48b";

                    } else if (card.name == "instantiated3Card48c(Clone)") {

                        card.name = "instantiated3HandCard48c";

                    } else if (card.name == "instantiated3Card49(Clone)") {

                        card.name = "instantiated3HandCard49";

                    } else if (card.name == "instantiated3Card49a(Clone)") {

                        card.name = "instantiated3HandCard49a";

                    } else if (card.name == "instantiated3Card49b(Clone)") {

                        card.name = "instantiated3HandCard49b";

                    } else if (card.name == "instantiated3Card49c(Clone)") {

                        card.name = "instantiated3HandCard49c";

                    } else if (card.name == "instantiated3Card50(Clone)") {

                        card.name = "instantiated3HandCard50";

                    } else if (card.name == "instantiated3Card50a(Clone)") {

                        card.name = "instantiated3HandCard50a";

                    } else if (card.name == "instantiated3Card50b(Clone)") {

                        card.name = "instantiated3HandCard50b";

                    } else if (card.name == "instantiated3Card50c(Clone)") {

                        card.name = "instantiated3HandCard50c";

                    } else if (card.name == "instantiated3Card51(Clone)") {

                        card.name = "instantiated3HandCard51";

                    } else if (card.name == "instantiated3Card51a(Clone)") {

                        card.name = "instantiated3HandCard51a";

                    } else if (card.name == "instantiated3Card51b(Clone)") {

                        card.name = "instantiated3HandCard51b";

                    } else if (card.name == "instantiated3Card51c(Clone)") {

                        card.name = "instantiated3HandCard51c";

                    } else if (card.name == "instantiated3Card52(Clone)") {

                        card.name = "instantiated3HandCard52";

                    } else if (card.name == "instantiated3Card52a(Clone)") {

                        card.name = "instantiated3HandCard52a";

                    } else if (card.name == "instantiated3Card52b(Clone)") {

                        card.name = "instantiated3HandCard52b";

                    } else if (card.name == "instantiated3Card52c(Clone)") {

                        card.name = "instantiated3HandCard52c";

                    } else if (card.name == "instantiated3Card53(Clone)") {

                        card.name = "instantiated3HandCard53";

                    } else if (card.name == "instantiated3Card53a(Clone)") {

                        card.name = "instantiated3HandCard53a";

                    } else if (card.name == "instantiated3Card53b(Clone)") {

                        card.name = "instantiated3HandCard53b";

                    } else if (card.name == "instantiated3Card53c(Clone)") {

                        card.name = "instantiated3HandCard53c";

                    } else if (card.name == "instantiated3Card54(Clone)") {

                        card.name = "instantiated3HandCard54";

                    } else if (card.name == "instantiated3Card54a(Clone)") {

                        card.name = "instantiated3HandCard54a";

                    } else if (card.name == "instantiated3Card54b(Clone)") {

                        card.name = "instantiated3HandCard54b";

                    } else if (card.name == "instantiated3Card54c(Clone)") {

                        card.name = "instantiated3HandCard54c";

                    } else if (card.name == "instantiated3Card55(Clone)") {

                        card.name = "instantiated3HandCard55";

                    } else if (card.name == "instantiated3Card55a(Clone)") {

                        card.name = "instantiated3HandCard55a";

                    } else if (card.name == "instantiated3Card55b(Clone)") {

                        card.name = "instantiated3HandCard55b";

                    } else if (card.name == "instantiated3Card55c(Clone)") {

                        card.name = "instantiated3HandCard55c";

                    } else if (card.name == "instantiated3Card56(Clone)") {

                        card.name = "instantiated3HandCard56";

                    } else if (card.name == "instantiated3Card56a(Clone)") {

                        card.name = "instantiated3HandCard56a";

                    } else if (card.name == "instantiated3Card56b(Clone)") {

                        card.name = "instantiated3HandCard56b";

                    } else if (card.name == "instantiated3Card56c(Clone)") {

                        card.name = "instantiated3HandCard56c";

                    } else if (card.name == "instantiated3Card57(Clone)") {

                        card.name = "instantiated3HandCard57";

                    } else if (card.name == "instantiated3Card57a(Clone)") {

                        card.name = "instantiated3HandCard57a";

                    } else if (card.name == "instantiated3Card57b(Clone)") {

                        card.name = "instantiated3HandCard57b";

                    } else if (card.name == "instantiated3Card57c(Clone)") {

                        card.name = "instantiated3HandCard57c";

                    } else if (card.name == "instantiated3Card58(Clone)") {

                        card.name = "instantiated3HandCard58";

                    } else if (card.name == "instantiated3Card58a(Clone)") {

                        card.name = "instantiated3HandCard58a";

                    } else if (card.name == "instantiated3Card58b(Clone)") {

                        card.name = "instantiated3HandCard58b";

                    } else if (card.name == "instantiated3Card58c(Clone)") {

                        card.name = "instantiated3HandCard58c";

                    } else if (card.name == "instantiated3Card59(Clone)") {

                        card.name = "instantiated3HandCard59";

                    } else if (card.name == "instantiated3Card59a(Clone)") {

                        card.name = "instantiated3HandCard59a";

                    } else if (card.name == "instantiated3Card59b(Clone)") {

                        card.name = "instantiated3HandCard59b";

                    } else if (card.name == "instantiated3Card59c(Clone)") {

                        card.name = "instantiated3HandCard59c";

                    } else if (card.name == "instantiated3Card60(Clone)") {

                        card.name = "instantiated3HandCard60";

                    } else if (card.name == "instantiated3Card60a(Clone)") {

                        card.name = "instantiated3HandCard60a";

                    } else if (card.name == "instantiated3Card60b(Clone)") {

                        card.name = "instantiated3HandCard60b";

                    } else if (card.name == "instantiated3Card60c(Clone)") {

                        card.name = "instantiated3HandCard60c";
                    }

                    instances1M++;

                }


            }

            if (player1DeckSlot2.transform.childCount == 0) {

                while (instances2M < NumberOfCards) {

                    GameObject card = Instantiate(playCardsDeck3[UnityEngine.Random.Range(0, playCardsDeck3.Count)], player1DeckSlot2.transform.position, player1DeckSlot2.transform.rotation) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.transform.parent = player1DeckSlot2.transform;

                    if (card.name == "instantiated3Card1(Clone)") {

                        card.name = "instantiated3HandCard1";

                    } else if (card.name == "instantiated3Card1a(Clone)") {

                        card.name = "instantiated3HandCard1a";

                    } else if (card.name == "instantiated3Card1b(Clone)") {

                        card.name = "instantiated3HandCard1b";

                    } else if (card.name == "instantiated3Card1c(Clone)") {

                        card.name = "instantiated3HandCard1c";

                    } else if (card.name == "instantiated3Card2(Clone)") {

                        card.name = "instantiated3HandCard2";

                    } else if (card.name == "instantiated3Card2a(Clone)") {

                        card.name = "instantiated3HandCard2a";

                    } else if (card.name == "instantiated3Card2b(Clone)") {

                        card.name = "instantiated3HandCard2b";

                    } else if (card.name == "instantiated3Card2c(Clone)") {

                        card.name = "instantiated3HandCard2c";

                    } else if (card.name == "instantiated3Card3(Clone)") {

                        card.name = "instantiated3HandCard3";

                    } else if (card.name == "instantiated3Card3a(Clone)") {

                        card.name = "instantiated3HandCard3a";

                    } else if (card.name == "instantiated3Card3b(Clone)") {

                        card.name = "instantiated3HandCard3b";

                    } else if (card.name == "instantiated3Card3c(Clone)") {

                        card.name = "instantiated3HandCard3c";

                    } else if (card.name == "instantiated3Card4(Clone)") {

                        card.name = "instantiated3HandCard4";

                    } else if (card.name == "instantiated3Card4a(Clone)") {

                        card.name = "instantiated3HandCard4a";

                    } else if (card.name == "instantiated3Card4b(Clone)") {

                        card.name = "instantiated3HandCard4b";

                    } else if (card.name == "instantiated3Card4c(Clone)") {

                        card.name = "instantiated3HandCard4c";

                    } else if (card.name == "instantiated3Card5(Clone)") {

                        card.name = "instantiated3HandCard5";

                    } else if (card.name == "instantiated3Card5a(Clone)") {

                        card.name = "instantiated3HandCard5a";

                    } else if (card.name == "instantiated3Card5b(Clone)") {

                        card.name = "instantiated3HandCard5b";

                    } else if (card.name == "instantiated3Card5c(Clone)") {

                        card.name = "instantiated3HandCard5c";

                    } else if (card.name == "instantiated3Card6(Clone)") {

                        card.name = "instantiated3HandCard6";

                    } else if (card.name == "instantiated3Card6a(Clone)") {

                        card.name = "instantiated3HandCard6a";

                    } else if (card.name == "instantiated3Card6b(Clone)") {

                        card.name = "instantiated3HandCard6b";

                    } else if (card.name == "instantiated3Card6c(Clone)") {

                        card.name = "instantiated3HandCard6c";

                    } else if (card.name == "instantiated3Card7(Clone)") {

                        card.name = "instantiated3HandCard7";

                    } else if (card.name == "instantiated3Card7a(Clone)") {

                        card.name = "instantiated3HandCard7a";

                    } else if (card.name == "instantiated3Card7b(Clone)") {

                        card.name = "instantiated3HandCard7b";

                    } else if (card.name == "instantiated3Card7c(Clone)") {

                        card.name = "instantiated3HandCard7c";

                    } else if (card.name == "instantiated3Card8(Clone)") {

                        card.name = "instantiated3HandCard8";

                    } else if (card.name == "instantiated3Card8a(Clone)") {

                        card.name = "instantiated3HandCard8a";

                    } else if (card.name == "instantiated3Card8b(Clone)") {

                        card.name = "instantiated3HandCard8b";

                    } else if (card.name == "instantiated3Card8c(Clone)") {

                        card.name = "instantiated3HandCard8c";

                    } else if (card.name == "instantiated3Card9(Clone)") {

                        card.name = "instantiated3HandCard9";

                    } else if (card.name == "instantiated3Card9a(Clone)") {

                        card.name = "instantiated3HandCard9a";

                    } else if (card.name == "instantiated3Card9b(Clone)") {

                        card.name = "instantiated3HandCard9b";

                    } else if (card.name == "instantiated3Card9c(Clone)") {

                        card.name = "instantiated3HandCard9c";

                    } else if (card.name == "instantiated3Card10(Clone)") {

                        card.name = "instantiatedAICard10";

                    } else if (card.name == "instantiated3Card10a(Clone)") {

                        card.name = "instantiated3HandCard10a";

                    } else if (card.name == "instantiated3Card10b(Clone)") {

                        card.name = "instantiated3HandCard10b";

                    } else if (card.name == "instantiated3Card10c(Clone)") {

                        card.name = "instantiated3HandCard10c";

                    } else if (card.name == "instantiated3Card11(Clone)") {

                        card.name = "instantiated3HandCard11";

                    } else if (card.name == "instantiated3Card11a(Clone)") {

                        card.name = "instantiated3HandCard11a";

                    } else if (card.name == "instantiated3Card11b(Clone)") {

                        card.name = "instantiated3HandCard11b";

                    } else if (card.name == "instantiated3Card11c(Clone)") {

                        card.name = "instantiated3HandCard11c";

                    } else if (card.name == "instantiated3Card12(Clone)") {

                        card.name = "instantiated3HandCard12";

                    } else if (card.name == "instantiated3Card12a(Clone)") {

                        card.name = "instantiated3HandCard12a";

                    } else if (card.name == "instantiated3Card12b(Clone)") {

                        card.name = "instantiated3HandCard12b";

                    } else if (card.name == "instantiated3Card12c(Clone)") {

                        card.name = "instantiated3HandCard12c";

                    } else if (card.name == "instantiated3Card13(Clone)") {

                        card.name = "instantiated3HandCard13";

                    } else if (card.name == "instantiated3Card13a(Clone)") {

                        card.name = "instantiated3HandCard13a";

                    } else if (card.name == "instantiated3Card13b(Clone)") {

                        card.name = "instantiated3HandCard13b";

                    } else if (card.name == "instantiated3Card13c(Clone)") {

                        card.name = "instantiated3HandCard13c";

                    } else if (card.name == "instantiated3Card14(Clone)") {

                        card.name = "instantiated3HandCard14";

                    } else if (card.name == "instantiated3Card14a(Clone)") {

                        card.name = "instantiated3HandCard14a";

                    } else if (card.name == "instantiated3Card14b(Clone)") {

                        card.name = "instantiated3HandCard14b";

                    } else if (card.name == "instantiated3Card14c(Clone)") {

                        card.name = "instantiated3HandCard14c";

                    } else if (card.name == "instantiated3Card15(Clone)") {

                        card.name = "instantiated3HandCard15";

                    } else if (card.name == "instantiated3Card15a(Clone)") {

                        card.name = "instantiated3HandCard15a";

                    } else if (card.name == "instantiated3Card15b(Clone)") {

                        card.name = "instantiated3HandCard15b";

                    } else if (card.name == "instantiated3Card15c(Clone)") {

                        card.name = "instantiated3HandCard15c";

                    } else if (card.name == "instantiated3Card16(Clone)") {

                        card.name = "instantiated3HandCard16";

                    } else if (card.name == "instantiated3Card16a(Clone)") {

                        card.name = "instantiated3HandCard16a";

                    } else if (card.name == "instantiated3Card16b(Clone)") {

                        card.name = "instantiated3HandCard16b";

                    } else if (card.name == "instantiated3Card16c(Clone)") {

                        card.name = "instantiated3HandCard16c";

                    } else if (card.name == "instantiated3Card17(Clone)") {

                        card.name = "instantiated3HandCard17";

                    } else if (card.name == "instantiated3Card17a(Clone)") {

                        card.name = "instantiated3HandCard17a";

                    } else if (card.name == "instantiated3Card17b(Clone)") {

                        card.name = "instantiated3HandCard17b";

                    } else if (card.name == "instantiated3Card17c(Clone)") {

                        card.name = "instantiated3HandCard17c";

                    } else if (card.name == "instantiated3Card18(Clone)") {

                        card.name = "instantiated3HandCard18";

                    } else if (card.name == "instantiated3Card18a(Clone)") {

                        card.name = "instantiated3HandCard18a";

                    } else if (card.name == "instantiated3Card18b(Clone)") {

                        card.name = "instantiated3HandCard18b";

                    } else if (card.name == "instantiated3Card18c(Clone)") {

                        card.name = "instantiated3HandCard18c";

                    } else if (card.name == "instantiated3Card19(Clone)") {

                        card.name = "instantiated3HandCard19";

                    } else if (card.name == "instantiated3Card19a(Clone)") {

                        card.name = "instantiated3HandCard19a";

                    } else if (card.name == "instantiated3Card19b(Clone)") {

                        card.name = "instantiated3HandCard19b";

                    } else if (card.name == "instantiated3Card19c(Clone)") {

                        card.name = "instantiated3HandCard19c";

                    } else if (card.name == "instantiated3Card20(Clone)") {

                        card.name = "instantiated3HandCard20";

                    } else if (card.name == "instantiated3Card20a(Clone)") {

                        card.name = "instantiated3HandCard20a";

                    } else if (card.name == "instantiated3Card20b(Clone)") {

                        card.name = "instantiated3HandCard20b";

                    } else if (card.name == "instantiated3Card20c(Clone)") {

                        card.name = "instantiated3HandCard20c";

                    } else if (card.name == "instantiated3Card21(Clone)") {

                        card.name = "instantiated3HandCard21";

                    } else if (card.name == "instantiated3Card21a(Clone)") {

                        card.name = "instantiated3HandCard21a";

                    } else if (card.name == "instantiated3Card21b(Clone)") {

                        card.name = "instantiated3HandCard21b";

                    } else if (card.name == "instantiated3Card21c(Clone)") {

                        card.name = "instantiated3HandCard21c";

                    } else if (card.name == "instantiated3Card22(Clone)") {

                        card.name = "instantiated3HandCard22";

                    } else if (card.name == "instantiated3Card22a(Clone)") {

                        card.name = "instantiated3HandCard22a";

                    } else if (card.name == "instantiated3Card22b(Clone)") {

                        card.name = "instantiated3HandCard22b";

                    } else if (card.name == "instantiated3Card22c(Clone)") {

                        card.name = "instantiated3HandCard22c";

                    } else if (card.name == "instantiated3Card23(Clone)") {

                        card.name = "instantiated3HandCard23";

                    } else if (card.name == "instantiated3Card23a(Clone)") {

                        card.name = "instantiated3HandCard23a";

                    } else if (card.name == "instantiated3Card23b(Clone)") {

                        card.name = "instantiated3HandCard23b";

                    } else if (card.name == "instantiated3Card23c(Clone)") {

                        card.name = "instantiated3HandCard23c";

                    } else if (card.name == "instantiated3Card24(Clone)") {

                        card.name = "instantiated3HandCard24";

                    } else if (card.name == "instantiated3Card24a(Clone)") {

                        card.name = "instantiated3HandCard24a";

                    } else if (card.name == "instantiated3Card24b(Clone)") {

                        card.name = "instantiated3HandCard24b";

                    } else if (card.name == "instantiated3Card24c(Clone)") {

                        card.name = "instantiated3HandCard24c";

                    } else if (card.name == "instantiated3Card25(Clone)") {

                        card.name = "instantiated3HandCard25";

                    } else if (card.name == "instantiated3Card25a(Clone)") {

                        card.name = "instantiated3HandCard25a";

                    } else if (card.name == "instantiated3Card25b(Clone)") {

                        card.name = "instantiated3HandCard25b";

                    } else if (card.name == "instantiated3Card25c(Clone)") {

                        card.name = "instantiated3HandCard25c";

                    } else if (card.name == "instantiated3Card26(Clone)") {

                        card.name = "instantiated3HandCard26";

                    } else if (card.name == "instantiated3Card26a(Clone)") {

                        card.name = "instantiated3HandCard26a";

                    } else if (card.name == "instantiated3Card26b(Clone)") {

                        card.name = "instantiated3HandCard26b";

                    } else if (card.name == "instantiated3Card26c(Clone)") {

                        card.name = "instantiated3HandCard26c";

                    } else if (card.name == "instantiated3Card27(Clone)") {

                        card.name = "instantiated3HandCard27";

                    } else if (card.name == "instantiated3Card27a(Clone)") {

                        card.name = "instantiated3HandCard27a";

                    } else if (card.name == "instantiated3Card27b(Clone)") {

                        card.name = "instantiated3HandCard27b";

                    } else if (card.name == "instantiated3Card27c(Clone)") {

                        card.name = "instantiated3HandCard27c";

                    } else if (card.name == "instantiated3Card28(Clone)") {

                        card.name = "instantiated3HandCard28";

                    } else if (card.name == "instantiated3Card28a(Clone)") {

                        card.name = "instantiated3HandCard28a";

                    } else if (card.name == "instantiated3Card28b(Clone)") {

                        card.name = "instantiated3HandCard28b";

                    } else if (card.name == "instantiated3Card28c(Clone)") {

                        card.name = "instantiated3HandCard28c";

                    } else if (card.name == "instantiated3Card29(Clone)") {

                        card.name = "instantiated3HandCard29";

                    } else if (card.name == "instantiated3Card29a(Clone)") {

                        card.name = "instantiated3HandCard29a";

                    } else if (card.name == "instantiated3Card29b(Clone)") {

                        card.name = "instantiated3HandCard29b";

                    } else if (card.name == "instantiated3Card29c(Clone)") {

                        card.name = "instantiated3HandCard29c";

                    } else if (card.name == "instantiated3Card30(Clone)") {

                        card.name = "instantiated3HandCard30";

                    } else if (card.name == "instantiated3Card30a(Clone)") {

                        card.name = "instantiated3HandCard30a";

                    } else if (card.name == "instantiated3Card30b(Clone)") {

                        card.name = "instantiated3HandCard30b";

                    } else if (card.name == "instantiated3Card30c(Clone)") {

                        card.name = "instantiated3HandCard30c";

                    } else if (card.name == "instantiated3Card31(Clone)") {

                        card.name = "instantiated3HandCard31";

                    } else if (card.name == "instantiated3Card31a(Clone)") {

                        card.name = "instantiated3HandCard31a";

                    } else if (card.name == "instantiated3Card31b(Clone)") {

                        card.name = "instantiated3HandCard31b";

                    } else if (card.name == "instantiated3Card31c(Clone)") {

                        card.name = "instantiated3HandCard31c";

                    } else if (card.name == "instantiated3Card32(Clone)") {

                        card.name = "instantiated3HandCard32";

                    } else if (card.name == "instantiated3Card32a(Clone)") {

                        card.name = "instantiated3HandCard32a";

                    } else if (card.name == "instantiated3Card32b(Clone)") {

                        card.name = "instantiated3HandCard32b";

                    } else if (card.name == "instantiated3Card32c(Clone)") {

                        card.name = "instantiated3HandCard32c";

                    } else if (card.name == "instantiated3Card33(Clone)") {

                        card.name = "instantiated3HandCard33";

                    } else if (card.name == "instantiated3Card33a(Clone)") {

                        card.name = "instantiated3HandCard33a";

                    } else if (card.name == "instantiated3Card33b(Clone)") {

                        card.name = "instantiated3HandCard33b";

                    } else if (card.name == "instantiated3Card33c(Clone)") {

                        card.name = "instantiated3HandCard33c";

                    } else if (card.name == "instantiated3Card34(Clone)") {

                        card.name = "instantiated3HandCard34";

                    } else if (card.name == "instantiated3Card34a(Clone)") {

                        card.name = "instantiated3HandCard34a";

                    } else if (card.name == "instantiated3Card34b(Clone)") {

                        card.name = "instantiated3HandCard34b";

                    } else if (card.name == "instantiated3Card34c(Clone)") {

                        card.name = "instantiated3HandCard34c";

                    } else if (card.name == "instantiated3Card35(Clone)") {

                        card.name = "instantiated3HandCard35";

                    } else if (card.name == "instantiated3Card35a(Clone)") {

                        card.name = "instantiated3HandCard35a";

                    } else if (card.name == "instantiated3Card35b(Clone)") {

                        card.name = "instantiated3HandCard35b";

                    } else if (card.name == "instantiated3Card35c(Clone)") {

                        card.name = "instantiated3HandCard35c";

                    } else if (card.name == "instantiated3Card36(Clone)") {

                        card.name = "instantiated3HandCard36";

                    } else if (card.name == "instantiated3Card36a(Clone)") {

                        card.name = "instantiated3HandCard36a";

                    } else if (card.name == "instantiated3Card36b(Clone)") {

                        card.name = "instantiated3HandCard36b";

                    } else if (card.name == "instantiated3Card36c(Clone)") {

                        card.name = "instantiated3HandCard36c";

                    } else if (card.name == "instantiated3Card37(Clone)") {

                        card.name = "instantiated3HandCard37";

                    } else if (card.name == "instantiated3Card37a(Clone)") {

                        card.name = "instantiated3HandCard37a";

                    } else if (card.name == "instantiated3Card37b(Clone)") {

                        card.name = "instantiated3HandCard37b";

                    } else if (card.name == "instantiated3Card37c(Clone)") {

                        card.name = "instantiated3HandCard37c";

                    } else if (card.name == "instantiated3Card38(Clone)") {

                        card.name = "instantiated3HandCard38";

                    } else if (card.name == "instantiated3Card38a(Clone)") {

                        card.name = "instantiated3HandCard38a";

                    } else if (card.name == "instantiated3Card38b(Clone)") {

                        card.name = "instantiated3HandCard38b";

                    } else if (card.name == "instantiated3Card38c(Clone)") {

                        card.name = "instantiated3HandCard38c";

                    } else if (card.name == "instantiated3Card39(Clone)") {

                        card.name = "instantiated3HandCard39";

                    } else if (card.name == "instantiated3Card39a(Clone)") {

                        card.name = "instantiated3HandCard39a";

                    } else if (card.name == "instantiated3Card39b(Clone)") {

                        card.name = "instantiated3HandCard39b";

                    } else if (card.name == "instantiated3Card39c(Clone)") {

                        card.name = "instantiated3HandCard39c";

                    } else if (card.name == "instantiated3Card40(Clone)") {

                        card.name = "instantiated3HandCard40";

                    } else if (card.name == "instantiated3Card40a(Clone)") {

                        card.name = "instantiated3HandCard40a";

                    } else if (card.name == "instantiated3Card40b(Clone)") {

                        card.name = "instantiated3HandCard40b";

                    } else if (card.name == "instantiated3Card40c(Clone)") {

                        card.name = "instantiated3HandCard40c";

                    } else if (card.name == "instantiated3Card41(Clone)") {

                        card.name = "instantiated3HandCard41";

                    } else if (card.name == "instantiated3Card41a(Clone)") {

                        card.name = "instantiated3HandCard41a";

                    } else if (card.name == "instantiated3Card41b(Clone)") {

                        card.name = "instantiated3HandCard41b";

                    } else if (card.name == "instantiated3Card41c(Clone)") {

                        card.name = "instantiated3HandCard41c";

                    } else if (card.name == "instantiated3Card42(Clone)") {

                        card.name = "instantiated3HandCard42";

                    } else if (card.name == "instantiated3Card42a(Clone)") {

                        card.name = "instantiated3HandCard42a";

                    } else if (card.name == "instantiated3Card42b(Clone)") {

                        card.name = "instantiated3HandCard42b";

                    } else if (card.name == "instantiated3Card42c(Clone)") {

                        card.name = "instantiated3HandCard42c";

                    } else if (card.name == "instantiated3Card43(Clone)") {

                        card.name = "instantiated3HandCard43";

                    } else if (card.name == "instantiated3Card43a(Clone)") {

                        card.name = "instantiated3HandCard43a";

                    } else if (card.name == "instantiated3Card43b(Clone)") {

                        card.name = "instantiated3HandCard43b";

                    } else if (card.name == "instantiated3Card43c(Clone)") {

                        card.name = "instantiated3HandCard43c";

                    } else if (card.name == "instantiated3Card44(Clone)") {

                        card.name = "instantiated3HandCard44";

                    } else if (card.name == "instantiated3Card44a(Clone)") {

                        card.name = "instantiated3HandCard44a";

                    } else if (card.name == "instantiated3Card44b(Clone)") {

                        card.name = "instantiated3HandCard44b";

                    } else if (card.name == "instantiated3Card44c(Clone)") {

                        card.name = "instantiated3HandCard44c";

                    } else if (card.name == "instantiated3Card45(Clone)") {

                        card.name = "instantiated3HandCard45";

                    } else if (card.name == "instantiated3Card45a(Clone)") {

                        card.name = "instantiated3HandCard45a";

                    } else if (card.name == "instantiated3Card45b(Clone)") {

                        card.name = "instantiated3HandCard45b";

                    } else if (card.name == "instantiated3Card45c(Clone)") {

                        card.name = "instantiated3HandCard45c";

                    } else if (card.name == "instantiated3Card46(Clone)") {

                        card.name = "instantiated3HandCard46";

                    } else if (card.name == "instantiated3Card46a(Clone)") {

                        card.name = "instantiated3HandCard46a";

                    } else if (card.name == "instantiated3Card46b(Clone)") {

                        card.name = "instantiated3HandCard46b";

                    } else if (card.name == "instantiated3Card46c(Clone)") {

                        card.name = "instantiated3HandCard46c";

                    } else if (card.name == "instantiated3Card47(Clone)") {

                        card.name = "instantiated3HandCard47";

                    } else if (card.name == "instantiated3Card47a(Clone)") {

                        card.name = "instantiated3HandCard47a";

                    } else if (card.name == "instantiated3Card47b(Clone)") {

                        card.name = "instantiated3HandCard47b";

                    } else if (card.name == "instantiated3Card47c(Clone)") {

                        card.name = "instantiated3HandCard47c";

                    } else if (card.name == "instantiated3Card48(Clone)") {

                        card.name = "instantiated3HandCard48";

                    } else if (card.name == "instantiated3Card48a(Clone)") {

                        card.name = "instantiated3HandCard48a";

                    } else if (card.name == "instantiated3Card48b(Clone)") {

                        card.name = "instantiated3HandCard48b";

                    } else if (card.name == "instantiated3Card48c(Clone)") {

                        card.name = "instantiated3HandCard48c";

                    } else if (card.name == "instantiated3Card49(Clone)") {

                        card.name = "instantiated3HandCard49";

                    } else if (card.name == "instantiated3Card49a(Clone)") {

                        card.name = "instantiated3HandCard49a";

                    } else if (card.name == "instantiated3Card49b(Clone)") {

                        card.name = "instantiated3HandCard49b";

                    } else if (card.name == "instantiated3Card49c(Clone)") {

                        card.name = "instantiated3HandCard49c";

                    } else if (card.name == "instantiated3Card50(Clone)") {

                        card.name = "instantiated3HandCard50";

                    } else if (card.name == "instantiated3Card50a(Clone)") {

                        card.name = "instantiated3HandCard50a";

                    } else if (card.name == "instantiated3Card50b(Clone)") {

                        card.name = "instantiated3HandCard50b";

                    } else if (card.name == "instantiated3Card50c(Clone)") {

                        card.name = "instantiated3HandCard50c";

                    } else if (card.name == "instantiated3Card51(Clone)") {

                        card.name = "instantiated3HandCard51";

                    } else if (card.name == "instantiated3Card51a(Clone)") {

                        card.name = "instantiated3HandCard51a";

                    } else if (card.name == "instantiated3Card51b(Clone)") {

                        card.name = "instantiated3HandCard51b";

                    } else if (card.name == "instantiated3Card51c(Clone)") {

                        card.name = "instantiated3HandCard51c";

                    } else if (card.name == "instantiated3Card52(Clone)") {

                        card.name = "instantiated3HandCard52";

                    } else if (card.name == "instantiated3Card52a(Clone)") {

                        card.name = "instantiated3HandCard52a";

                    } else if (card.name == "instantiated3Card52b(Clone)") {

                        card.name = "instantiated3HandCard52b";

                    } else if (card.name == "instantiated3Card52c(Clone)") {

                        card.name = "instantiated3HandCard52c";

                    } else if (card.name == "instantiated3Card53(Clone)") {

                        card.name = "instantiated3HandCard53";

                    } else if (card.name == "instantiated3Card53a(Clone)") {

                        card.name = "instantiated3HandCard53a";

                    } else if (card.name == "instantiated3Card53b(Clone)") {

                        card.name = "instantiated3HandCard53b";

                    } else if (card.name == "instantiated3Card53c(Clone)") {

                        card.name = "instantiated3HandCard53c";

                    } else if (card.name == "instantiated3Card54(Clone)") {

                        card.name = "instantiated3HandCard54";

                    } else if (card.name == "instantiated3Card54a(Clone)") {

                        card.name = "instantiated3HandCard54a";

                    } else if (card.name == "instantiated3Card54b(Clone)") {

                        card.name = "instantiated3HandCard54b";

                    } else if (card.name == "instantiated3Card54c(Clone)") {

                        card.name = "instantiated3HandCard54c";

                    } else if (card.name == "instantiated3Card55(Clone)") {

                        card.name = "instantiated3HandCard55";

                    } else if (card.name == "instantiated3Card55a(Clone)") {

                        card.name = "instantiated3HandCard55a";

                    } else if (card.name == "instantiated3Card55b(Clone)") {

                        card.name = "instantiated3HandCard55b";

                    } else if (card.name == "instantiated3Card55c(Clone)") {

                        card.name = "instantiated3HandCard55c";

                    } else if (card.name == "instantiated3Card56(Clone)") {

                        card.name = "instantiated3HandCard56";

                    } else if (card.name == "instantiated3Card56a(Clone)") {

                        card.name = "instantiated3HandCard56a";

                    } else if (card.name == "instantiated3Card56b(Clone)") {

                        card.name = "instantiated3HandCard56b";

                    } else if (card.name == "instantiated3Card56c(Clone)") {

                        card.name = "instantiated3HandCard56c";

                    } else if (card.name == "instantiated3Card57(Clone)") {

                        card.name = "instantiated3HandCard57";

                    } else if (card.name == "instantiated3Card57a(Clone)") {

                        card.name = "instantiated3HandCard57a";

                    } else if (card.name == "instantiated3Card57b(Clone)") {

                        card.name = "instantiated3HandCard57b";

                    } else if (card.name == "instantiated3Card57c(Clone)") {

                        card.name = "instantiated3HandCard57c";

                    } else if (card.name == "instantiated3Card58(Clone)") {

                        card.name = "instantiated3HandCard58";

                    } else if (card.name == "instantiated3Card58a(Clone)") {

                        card.name = "instantiated3HandCard58a";

                    } else if (card.name == "instantiated3Card58b(Clone)") {

                        card.name = "instantiated3HandCard58b";

                    } else if (card.name == "instantiated3Card58c(Clone)") {

                        card.name = "instantiated3HandCard58c";

                    } else if (card.name == "instantiated3Card59(Clone)") {

                        card.name = "instantiated3HandCard59";

                    } else if (card.name == "instantiated3Card59a(Clone)") {

                        card.name = "instantiated3HandCard59a";

                    } else if (card.name == "instantiated3Card59b(Clone)") {

                        card.name = "instantiated3HandCard59b";

                    } else if (card.name == "instantiated3Card59c(Clone)") {

                        card.name = "instantiated3HandCard59c";

                    } else if (card.name == "instantiated3Card60(Clone)") {

                        card.name = "instantiated3HandCard60";

                    } else if (card.name == "instantiated3Card60a(Clone)") {

                        card.name = "instantiated3HandCard60a";

                    } else if (card.name == "instantiated3Card60b(Clone)") {

                        card.name = "instantiated3HandCard60b";

                    } else if (card.name == "instantiated3Card60c(Clone)") {

                        card.name = "instantiated3HandCard60c";
                    }

                    instances2M++;

                }

            }

            if (player1DeckSlot3.transform.childCount == 0) {

                while (instances3M < NumberOfCards) {

                    GameObject card = Instantiate(playCardsDeck3[UnityEngine.Random.Range(0, playCardsDeck3.Count)], player1DeckSlot3.transform.position, player1DeckSlot3.transform.rotation) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.transform.parent = player1DeckSlot3.transform;

                    if (card.name == "instantiated3Card1(Clone)") {

                        card.name = "instantiated3HandCard1";

                    } else if (card.name == "instantiated3Card1a(Clone)") {

                        card.name = "instantiated3HandCard1a";

                    } else if (card.name == "instantiated3Card1b(Clone)") {

                        card.name = "instantiated3HandCard1b";

                    } else if (card.name == "instantiated3Card1c(Clone)") {

                        card.name = "instantiated3HandCard1c";

                    } else if (card.name == "instantiated3Card2(Clone)") {

                        card.name = "instantiated3HandCard2";

                    } else if (card.name == "instantiated3Card2a(Clone)") {

                        card.name = "instantiated3HandCard2a";

                    } else if (card.name == "instantiated3Card2b(Clone)") {

                        card.name = "instantiated3HandCard2b";

                    } else if (card.name == "instantiated3Card2c(Clone)") {

                        card.name = "instantiated3HandCard2c";

                    } else if (card.name == "instantiated3Card3(Clone)") {

                        card.name = "instantiated3HandCard3";

                    } else if (card.name == "instantiated3Card3a(Clone)") {

                        card.name = "instantiated3HandCard3a";

                    } else if (card.name == "instantiated3Card3b(Clone)") {

                        card.name = "instantiated3HandCard3b";

                    } else if (card.name == "instantiated3Card3c(Clone)") {

                        card.name = "instantiated3HandCard3c";

                    } else if (card.name == "instantiated3Card4(Clone)") {

                        card.name = "instantiated3HandCard4";

                    } else if (card.name == "instantiated3Card4a(Clone)") {

                        card.name = "instantiated3HandCard4a";

                    } else if (card.name == "instantiated3Card4b(Clone)") {

                        card.name = "instantiated3HandCard4b";

                    } else if (card.name == "instantiated3Card4c(Clone)") {

                        card.name = "instantiated3HandCard4c";

                    } else if (card.name == "instantiated3Card5(Clone)") {

                        card.name = "instantiated3HandCard5";

                    } else if (card.name == "instantiated3Card5a(Clone)") {

                        card.name = "instantiated3HandCard5a";

                    } else if (card.name == "instantiated3Card5b(Clone)") {

                        card.name = "instantiated3HandCard5b";

                    } else if (card.name == "instantiated3Card5c(Clone)") {

                        card.name = "instantiated3HandCard5c";

                    } else if (card.name == "instantiated3Card6(Clone)") {

                        card.name = "instantiated3HandCard6";

                    } else if (card.name == "instantiated3Card6a(Clone)") {

                        card.name = "instantiated3HandCard6a";

                    } else if (card.name == "instantiated3Card6b(Clone)") {

                        card.name = "instantiated3HandCard6b";

                    } else if (card.name == "instantiated3Card6c(Clone)") {

                        card.name = "instantiated3HandCard6c";

                    } else if (card.name == "instantiated3Card7(Clone)") {

                        card.name = "instantiated3HandCard7";

                    } else if (card.name == "instantiated3Card7a(Clone)") {

                        card.name = "instantiated3HandCard7a";

                    } else if (card.name == "instantiated3Card7b(Clone)") {

                        card.name = "instantiated3HandCard7b";

                    } else if (card.name == "instantiated3Card7c(Clone)") {

                        card.name = "instantiated3HandCard7c";

                    } else if (card.name == "instantiated3Card8(Clone)") {

                        card.name = "instantiated3HandCard8";

                    } else if (card.name == "instantiated3Card8a(Clone)") {

                        card.name = "instantiated3HandCard8a";

                    } else if (card.name == "instantiated3Card8b(Clone)") {

                        card.name = "instantiated3HandCard8b";

                    } else if (card.name == "instantiated3Card8c(Clone)") {

                        card.name = "instantiated3HandCard8c";

                    } else if (card.name == "instantiated3Card9(Clone)") {

                        card.name = "instantiated3HandCard9";

                    } else if (card.name == "instantiated3Card9a(Clone)") {

                        card.name = "instantiated3HandCard9a";

                    } else if (card.name == "instantiated3Card9b(Clone)") {

                        card.name = "instantiated3HandCard9b";

                    } else if (card.name == "instantiated3Card9c(Clone)") {

                        card.name = "instantiated3HandCard9c";

                    } else if (card.name == "instantiated3Card10(Clone)") {

                        card.name = "instantiatedAICard10";

                    } else if (card.name == "instantiated3Card10a(Clone)") {

                        card.name = "instantiated3HandCard10a";

                    } else if (card.name == "instantiated3Card10b(Clone)") {

                        card.name = "instantiated3HandCard10b";

                    } else if (card.name == "instantiated3Card10c(Clone)") {

                        card.name = "instantiated3HandCard10c";

                    } else if (card.name == "instantiated3Card11(Clone)") {

                        card.name = "instantiated3HandCard11";

                    } else if (card.name == "instantiated3Card11a(Clone)") {

                        card.name = "instantiated3HandCard11a";

                    } else if (card.name == "instantiated3Card11b(Clone)") {

                        card.name = "instantiated3HandCard11b";

                    } else if (card.name == "instantiated3Card11c(Clone)") {

                        card.name = "instantiated3HandCard11c";

                    } else if (card.name == "instantiated3Card12(Clone)") {

                        card.name = "instantiated3HandCard12";

                    } else if (card.name == "instantiated3Card12a(Clone)") {

                        card.name = "instantiated3HandCard12a";

                    } else if (card.name == "instantiated3Card12b(Clone)") {

                        card.name = "instantiated3HandCard12b";

                    } else if (card.name == "instantiated3Card12c(Clone)") {

                        card.name = "instantiated3HandCard12c";

                    } else if (card.name == "instantiated3Card13(Clone)") {

                        card.name = "instantiated3HandCard13";

                    } else if (card.name == "instantiated3Card13a(Clone)") {

                        card.name = "instantiated3HandCard13a";

                    } else if (card.name == "instantiated3Card13b(Clone)") {

                        card.name = "instantiated3HandCard13b";

                    } else if (card.name == "instantiated3Card13c(Clone)") {

                        card.name = "instantiated3HandCard13c";

                    } else if (card.name == "instantiated3Card14(Clone)") {

                        card.name = "instantiated3HandCard14";

                    } else if (card.name == "instantiated3Card14a(Clone)") {

                        card.name = "instantiated3HandCard14a";

                    } else if (card.name == "instantiated3Card14b(Clone)") {

                        card.name = "instantiated3HandCard14b";

                    } else if (card.name == "instantiated3Card14c(Clone)") {

                        card.name = "instantiated3HandCard14c";

                    } else if (card.name == "instantiated3Card15(Clone)") {

                        card.name = "instantiated3HandCard15";

                    } else if (card.name == "instantiated3Card15a(Clone)") {

                        card.name = "instantiated3HandCard15a";

                    } else if (card.name == "instantiated3Card15b(Clone)") {

                        card.name = "instantiated3HandCard15b";

                    } else if (card.name == "instantiated3Card15c(Clone)") {

                        card.name = "instantiated3HandCard15c";

                    } else if (card.name == "instantiated3Card16(Clone)") {

                        card.name = "instantiated3HandCard16";

                    } else if (card.name == "instantiated3Card16a(Clone)") {

                        card.name = "instantiated3HandCard16a";

                    } else if (card.name == "instantiated3Card16b(Clone)") {

                        card.name = "instantiated3HandCard16b";

                    } else if (card.name == "instantiated3Card16c(Clone)") {

                        card.name = "instantiated3HandCard16c";

                    } else if (card.name == "instantiated3Card17(Clone)") {

                        card.name = "instantiated3HandCard17";

                    } else if (card.name == "instantiated3Card17a(Clone)") {

                        card.name = "instantiated3HandCard17a";

                    } else if (card.name == "instantiated3Card17b(Clone)") {

                        card.name = "instantiated3HandCard17b";

                    } else if (card.name == "instantiated3Card17c(Clone)") {

                        card.name = "instantiated3HandCard17c";

                    } else if (card.name == "instantiated3Card18(Clone)") {

                        card.name = "instantiated3HandCard18";

                    } else if (card.name == "instantiated3Card18a(Clone)") {

                        card.name = "instantiated3HandCard18a";

                    } else if (card.name == "instantiated3Card18b(Clone)") {

                        card.name = "instantiated3HandCard18b";

                    } else if (card.name == "instantiated3Card18c(Clone)") {

                        card.name = "instantiated3HandCard18c";

                    } else if (card.name == "instantiated3Card19(Clone)") {

                        card.name = "instantiated3HandCard19";

                    } else if (card.name == "instantiated3Card19a(Clone)") {

                        card.name = "instantiated3HandCard19a";

                    } else if (card.name == "instantiated3Card19b(Clone)") {

                        card.name = "instantiated3HandCard19b";

                    } else if (card.name == "instantiated3Card19c(Clone)") {

                        card.name = "instantiated3HandCard19c";

                    } else if (card.name == "instantiated3Card20(Clone)") {

                        card.name = "instantiated3HandCard20";

                    } else if (card.name == "instantiated3Card20a(Clone)") {

                        card.name = "instantiated3HandCard20a";

                    } else if (card.name == "instantiated3Card20b(Clone)") {

                        card.name = "instantiated3HandCard20b";

                    } else if (card.name == "instantiated3Card20c(Clone)") {

                        card.name = "instantiated3HandCard20c";

                    } else if (card.name == "instantiated3Card21(Clone)") {

                        card.name = "instantiated3HandCard21";

                    } else if (card.name == "instantiated3Card21a(Clone)") {

                        card.name = "instantiated3HandCard21a";

                    } else if (card.name == "instantiated3Card21b(Clone)") {

                        card.name = "instantiated3HandCard21b";

                    } else if (card.name == "instantiated3Card21c(Clone)") {

                        card.name = "instantiated3HandCard21c";

                    } else if (card.name == "instantiated3Card22(Clone)") {

                        card.name = "instantiated3HandCard22";

                    } else if (card.name == "instantiated3Card22a(Clone)") {

                        card.name = "instantiated3HandCard22a";

                    } else if (card.name == "instantiated3Card22b(Clone)") {

                        card.name = "instantiated3HandCard22b";

                    } else if (card.name == "instantiated3Card22c(Clone)") {

                        card.name = "instantiated3HandCard22c";

                    } else if (card.name == "instantiated3Card23(Clone)") {

                        card.name = "instantiated3HandCard23";

                    } else if (card.name == "instantiated3Card23a(Clone)") {

                        card.name = "instantiated3HandCard23a";

                    } else if (card.name == "instantiated3Card23b(Clone)") {

                        card.name = "instantiated3HandCard23b";

                    } else if (card.name == "instantiated3Card23c(Clone)") {

                        card.name = "instantiated3HandCard23c";

                    } else if (card.name == "instantiated3Card24(Clone)") {

                        card.name = "instantiated3HandCard24";

                    } else if (card.name == "instantiated3Card24a(Clone)") {

                        card.name = "instantiated3HandCard24a";

                    } else if (card.name == "instantiated3Card24b(Clone)") {

                        card.name = "instantiated3HandCard24b";

                    } else if (card.name == "instantiated3Card24c(Clone)") {

                        card.name = "instantiated3HandCard24c";

                    } else if (card.name == "instantiated3Card25(Clone)") {

                        card.name = "instantiated3HandCard25";

                    } else if (card.name == "instantiated3Card25a(Clone)") {

                        card.name = "instantiated3HandCard25a";

                    } else if (card.name == "instantiated3Card25b(Clone)") {

                        card.name = "instantiated3HandCard25b";

                    } else if (card.name == "instantiated3Card25c(Clone)") {

                        card.name = "instantiated3HandCard25c";

                    } else if (card.name == "instantiated3Card26(Clone)") {

                        card.name = "instantiated3HandCard26";

                    } else if (card.name == "instantiated3Card26a(Clone)") {

                        card.name = "instantiated3HandCard26a";

                    } else if (card.name == "instantiated3Card26b(Clone)") {

                        card.name = "instantiated3HandCard26b";

                    } else if (card.name == "instantiated3Card26c(Clone)") {

                        card.name = "instantiated3HandCard26c";

                    } else if (card.name == "instantiated3Card27(Clone)") {

                        card.name = "instantiated3HandCard27";

                    } else if (card.name == "instantiated3Card27a(Clone)") {

                        card.name = "instantiated3HandCard27a";

                    } else if (card.name == "instantiated3Card27b(Clone)") {

                        card.name = "instantiated3HandCard27b";

                    } else if (card.name == "instantiated3Card27c(Clone)") {

                        card.name = "instantiated3HandCard27c";

                    } else if (card.name == "instantiated3Card28(Clone)") {

                        card.name = "instantiated3HandCard28";

                    } else if (card.name == "instantiated3Card28a(Clone)") {

                        card.name = "instantiated3HandCard28a";

                    } else if (card.name == "instantiated3Card28b(Clone)") {

                        card.name = "instantiated3HandCard28b";

                    } else if (card.name == "instantiated3Card28c(Clone)") {

                        card.name = "instantiated3HandCard28c";

                    } else if (card.name == "instantiated3Card29(Clone)") {

                        card.name = "instantiated3HandCard29";

                    } else if (card.name == "instantiated3Card29a(Clone)") {

                        card.name = "instantiated3HandCard29a";

                    } else if (card.name == "instantiated3Card29b(Clone)") {

                        card.name = "instantiated3HandCard29b";

                    } else if (card.name == "instantiated3Card29c(Clone)") {

                        card.name = "instantiated3HandCard29c";

                    } else if (card.name == "instantiated3Card30(Clone)") {

                        card.name = "instantiated3HandCard30";

                    } else if (card.name == "instantiated3Card30a(Clone)") {

                        card.name = "instantiated3HandCard30a";

                    } else if (card.name == "instantiated3Card30b(Clone)") {

                        card.name = "instantiated3HandCard30b";

                    } else if (card.name == "instantiated3Card30c(Clone)") {

                        card.name = "instantiated3HandCard30c";

                    } else if (card.name == "instantiated3Card31(Clone)") {

                        card.name = "instantiated3HandCard31";

                    } else if (card.name == "instantiated3Card31a(Clone)") {

                        card.name = "instantiated3HandCard31a";

                    } else if (card.name == "instantiated3Card31b(Clone)") {

                        card.name = "instantiated3HandCard31b";

                    } else if (card.name == "instantiated3Card31c(Clone)") {

                        card.name = "instantiated3HandCard31c";

                    } else if (card.name == "instantiated3Card32(Clone)") {

                        card.name = "instantiated3HandCard32";

                    } else if (card.name == "instantiated3Card32a(Clone)") {

                        card.name = "instantiated3HandCard32a";

                    } else if (card.name == "instantiated3Card32b(Clone)") {

                        card.name = "instantiated3HandCard32b";

                    } else if (card.name == "instantiated3Card32c(Clone)") {

                        card.name = "instantiated3HandCard32c";

                    } else if (card.name == "instantiated3Card33(Clone)") {

                        card.name = "instantiated3HandCard33";

                    } else if (card.name == "instantiated3Card33a(Clone)") {

                        card.name = "instantiated3HandCard33a";

                    } else if (card.name == "instantiated3Card33b(Clone)") {

                        card.name = "instantiated3HandCard33b";

                    } else if (card.name == "instantiated3Card33c(Clone)") {

                        card.name = "instantiated3HandCard33c";

                    } else if (card.name == "instantiated3Card34(Clone)") {

                        card.name = "instantiated3HandCard34";

                    } else if (card.name == "instantiated3Card34a(Clone)") {

                        card.name = "instantiated3HandCard34a";

                    } else if (card.name == "instantiated3Card34b(Clone)") {

                        card.name = "instantiated3HandCard34b";

                    } else if (card.name == "instantiated3Card34c(Clone)") {

                        card.name = "instantiated3HandCard34c";

                    } else if (card.name == "instantiated3Card35(Clone)") {

                        card.name = "instantiated3HandCard35";

                    } else if (card.name == "instantiated3Card35a(Clone)") {

                        card.name = "instantiated3HandCard35a";

                    } else if (card.name == "instantiated3Card35b(Clone)") {

                        card.name = "instantiated3HandCard35b";

                    } else if (card.name == "instantiated3Card35c(Clone)") {

                        card.name = "instantiated3HandCard35c";

                    } else if (card.name == "instantiated3Card36(Clone)") {

                        card.name = "instantiated3HandCard36";

                    } else if (card.name == "instantiated3Card36a(Clone)") {

                        card.name = "instantiated3HandCard36a";

                    } else if (card.name == "instantiated3Card36b(Clone)") {

                        card.name = "instantiated3HandCard36b";

                    } else if (card.name == "instantiated3Card36c(Clone)") {

                        card.name = "instantiated3HandCard36c";

                    } else if (card.name == "instantiated3Card37(Clone)") {

                        card.name = "instantiated3HandCard37";

                    } else if (card.name == "instantiated3Card37a(Clone)") {

                        card.name = "instantiated3HandCard37a";

                    } else if (card.name == "instantiated3Card37b(Clone)") {

                        card.name = "instantiated3HandCard37b";

                    } else if (card.name == "instantiated3Card37c(Clone)") {

                        card.name = "instantiated3HandCard37c";

                    } else if (card.name == "instantiated3Card38(Clone)") {

                        card.name = "instantiated3HandCard38";

                    } else if (card.name == "instantiated3Card38a(Clone)") {

                        card.name = "instantiated3HandCard38a";

                    } else if (card.name == "instantiated3Card38b(Clone)") {

                        card.name = "instantiated3HandCard38b";

                    } else if (card.name == "instantiated3Card38c(Clone)") {

                        card.name = "instantiated3HandCard38c";

                    } else if (card.name == "instantiated3Card39(Clone)") {

                        card.name = "instantiated3HandCard39";

                    } else if (card.name == "instantiated3Card39a(Clone)") {

                        card.name = "instantiated3HandCard39a";

                    } else if (card.name == "instantiated3Card39b(Clone)") {

                        card.name = "instantiated3HandCard39b";

                    } else if (card.name == "instantiated3Card39c(Clone)") {

                        card.name = "instantiated3HandCard39c";

                    } else if (card.name == "instantiated3Card40(Clone)") {

                        card.name = "instantiated3HandCard40";

                    } else if (card.name == "instantiated3Card40a(Clone)") {

                        card.name = "instantiated3HandCard40a";

                    } else if (card.name == "instantiated3Card40b(Clone)") {

                        card.name = "instantiated3HandCard40b";

                    } else if (card.name == "instantiated3Card40c(Clone)") {

                        card.name = "instantiated3HandCard40c";

                    } else if (card.name == "instantiated3Card41(Clone)") {

                        card.name = "instantiated3HandCard41";

                    } else if (card.name == "instantiated3Card41a(Clone)") {

                        card.name = "instantiated3HandCard41a";

                    } else if (card.name == "instantiated3Card41b(Clone)") {

                        card.name = "instantiated3HandCard41b";

                    } else if (card.name == "instantiated3Card41c(Clone)") {

                        card.name = "instantiated3HandCard41c";

                    } else if (card.name == "instantiated3Card42(Clone)") {

                        card.name = "instantiated3HandCard42";

                    } else if (card.name == "instantiated3Card42a(Clone)") {

                        card.name = "instantiated3HandCard42a";

                    } else if (card.name == "instantiated3Card42b(Clone)") {

                        card.name = "instantiated3HandCard42b";

                    } else if (card.name == "instantiated3Card42c(Clone)") {

                        card.name = "instantiated3HandCard42c";

                    } else if (card.name == "instantiated3Card43(Clone)") {

                        card.name = "instantiated3HandCard43";

                    } else if (card.name == "instantiated3Card43a(Clone)") {

                        card.name = "instantiated3HandCard43a";

                    } else if (card.name == "instantiated3Card43b(Clone)") {

                        card.name = "instantiated3HandCard43b";

                    } else if (card.name == "instantiated3Card43c(Clone)") {

                        card.name = "instantiated3HandCard43c";

                    } else if (card.name == "instantiated3Card44(Clone)") {

                        card.name = "instantiated3HandCard44";

                    } else if (card.name == "instantiated3Card44a(Clone)") {

                        card.name = "instantiated3HandCard44a";

                    } else if (card.name == "instantiated3Card44b(Clone)") {

                        card.name = "instantiated3HandCard44b";

                    } else if (card.name == "instantiated3Card44c(Clone)") {

                        card.name = "instantiated3HandCard44c";

                    } else if (card.name == "instantiated3Card45(Clone)") {

                        card.name = "instantiated3HandCard45";

                    } else if (card.name == "instantiated3Card45a(Clone)") {

                        card.name = "instantiated3HandCard45a";

                    } else if (card.name == "instantiated3Card45b(Clone)") {

                        card.name = "instantiated3HandCard45b";

                    } else if (card.name == "instantiated3Card45c(Clone)") {

                        card.name = "instantiated3HandCard45c";

                    } else if (card.name == "instantiated3Card46(Clone)") {

                        card.name = "instantiated3HandCard46";

                    } else if (card.name == "instantiated3Card46a(Clone)") {

                        card.name = "instantiated3HandCard46a";

                    } else if (card.name == "instantiated3Card46b(Clone)") {

                        card.name = "instantiated3HandCard46b";

                    } else if (card.name == "instantiated3Card46c(Clone)") {

                        card.name = "instantiated3HandCard46c";

                    } else if (card.name == "instantiated3Card47(Clone)") {

                        card.name = "instantiated3HandCard47";

                    } else if (card.name == "instantiated3Card47a(Clone)") {

                        card.name = "instantiated3HandCard47a";

                    } else if (card.name == "instantiated3Card47b(Clone)") {

                        card.name = "instantiated3HandCard47b";

                    } else if (card.name == "instantiated3Card47c(Clone)") {

                        card.name = "instantiated3HandCard47c";

                    } else if (card.name == "instantiated3Card48(Clone)") {

                        card.name = "instantiated3HandCard48";

                    } else if (card.name == "instantiated3Card48a(Clone)") {

                        card.name = "instantiated3HandCard48a";

                    } else if (card.name == "instantiated3Card48b(Clone)") {

                        card.name = "instantiated3HandCard48b";

                    } else if (card.name == "instantiated3Card48c(Clone)") {

                        card.name = "instantiated3HandCard48c";

                    } else if (card.name == "instantiated3Card49(Clone)") {

                        card.name = "instantiated3HandCard49";

                    } else if (card.name == "instantiated3Card49a(Clone)") {

                        card.name = "instantiated3HandCard49a";

                    } else if (card.name == "instantiated3Card49b(Clone)") {

                        card.name = "instantiated3HandCard49b";

                    } else if (card.name == "instantiated3Card49c(Clone)") {

                        card.name = "instantiated3HandCard49c";

                    } else if (card.name == "instantiated3Card50(Clone)") {

                        card.name = "instantiated3HandCard50";

                    } else if (card.name == "instantiated3Card50a(Clone)") {

                        card.name = "instantiated3HandCard50a";

                    } else if (card.name == "instantiated3Card50b(Clone)") {

                        card.name = "instantiated3HandCard50b";

                    } else if (card.name == "instantiated3Card50c(Clone)") {

                        card.name = "instantiated3HandCard50c";

                    } else if (card.name == "instantiated3Card51(Clone)") {

                        card.name = "instantiated3HandCard51";

                    } else if (card.name == "instantiated3Card51a(Clone)") {

                        card.name = "instantiated3HandCard51a";

                    } else if (card.name == "instantiated3Card51b(Clone)") {

                        card.name = "instantiated3HandCard51b";

                    } else if (card.name == "instantiated3Card51c(Clone)") {

                        card.name = "instantiated3HandCard51c";

                    } else if (card.name == "instantiated3Card52(Clone)") {

                        card.name = "instantiated3HandCard52";

                    } else if (card.name == "instantiated3Card52a(Clone)") {

                        card.name = "instantiated3HandCard52a";

                    } else if (card.name == "instantiated3Card52b(Clone)") {

                        card.name = "instantiated3HandCard52b";

                    } else if (card.name == "instantiated3Card52c(Clone)") {

                        card.name = "instantiated3HandCard52c";

                    } else if (card.name == "instantiated3Card53(Clone)") {

                        card.name = "instantiated3HandCard53";

                    } else if (card.name == "instantiated3Card53a(Clone)") {

                        card.name = "instantiated3HandCard53a";

                    } else if (card.name == "instantiated3Card53b(Clone)") {

                        card.name = "instantiated3HandCard53b";

                    } else if (card.name == "instantiated3Card53c(Clone)") {

                        card.name = "instantiated3HandCard53c";

                    } else if (card.name == "instantiated3Card54(Clone)") {

                        card.name = "instantiated3HandCard54";

                    } else if (card.name == "instantiated3Card54a(Clone)") {

                        card.name = "instantiated3HandCard54a";

                    } else if (card.name == "instantiated3Card54b(Clone)") {

                        card.name = "instantiated3HandCard54b";

                    } else if (card.name == "instantiated3Card54c(Clone)") {

                        card.name = "instantiated3HandCard54c";

                    } else if (card.name == "instantiated3Card55(Clone)") {

                        card.name = "instantiated3HandCard55";

                    } else if (card.name == "instantiated3Card55a(Clone)") {

                        card.name = "instantiated3HandCard55a";

                    } else if (card.name == "instantiated3Card55b(Clone)") {

                        card.name = "instantiated3HandCard55b";

                    } else if (card.name == "instantiated3Card55c(Clone)") {

                        card.name = "instantiated3HandCard55c";

                    } else if (card.name == "instantiated3Card56(Clone)") {

                        card.name = "instantiated3HandCard56";

                    } else if (card.name == "instantiated3Card56a(Clone)") {

                        card.name = "instantiated3HandCard56a";

                    } else if (card.name == "instantiated3Card56b(Clone)") {

                        card.name = "instantiated3HandCard56b";

                    } else if (card.name == "instantiated3Card56c(Clone)") {

                        card.name = "instantiated3HandCard56c";

                    } else if (card.name == "instantiated3Card57(Clone)") {

                        card.name = "instantiated3HandCard57";

                    } else if (card.name == "instantiated3Card57a(Clone)") {

                        card.name = "instantiated3HandCard57a";

                    } else if (card.name == "instantiated3Card57b(Clone)") {

                        card.name = "instantiated3HandCard57b";

                    } else if (card.name == "instantiated3Card57c(Clone)") {

                        card.name = "instantiated3HandCard57c";

                    } else if (card.name == "instantiated3Card58(Clone)") {

                        card.name = "instantiated3HandCard58";

                    } else if (card.name == "instantiated3Card58a(Clone)") {

                        card.name = "instantiated3HandCard58a";

                    } else if (card.name == "instantiated3Card58b(Clone)") {

                        card.name = "instantiated3HandCard58b";

                    } else if (card.name == "instantiated3Card58c(Clone)") {

                        card.name = "instantiated3HandCard58c";

                    } else if (card.name == "instantiated3Card59(Clone)") {

                        card.name = "instantiated3HandCard59";

                    } else if (card.name == "instantiated3Card59a(Clone)") {

                        card.name = "instantiated3HandCard59a";

                    } else if (card.name == "instantiated3Card59b(Clone)") {

                        card.name = "instantiated3HandCard59b";

                    } else if (card.name == "instantiated3Card59c(Clone)") {

                        card.name = "instantiated3HandCard59c";

                    } else if (card.name == "instantiated3Card60(Clone)") {

                        card.name = "instantiated3HandCard60";

                    } else if (card.name == "instantiated3Card60a(Clone)") {

                        card.name = "instantiated3HandCard60a";

                    } else if (card.name == "instantiated3Card60b(Clone)") {

                        card.name = "instantiated3HandCard60b";

                    } else if (card.name == "instantiated3Card60c(Clone)") {

                        card.name = "instantiated3HandCard60c";
                    }

                    instances3M++;

                }
            }

            if (player1DeckSlot4.transform.childCount == 0) {

                while (instances4M < NumberOfCards) {

                    GameObject card = Instantiate(playCardsDeck3[UnityEngine.Random.Range(0, playCardsDeck3.Count)], player1DeckSlot4.transform.position, player1DeckSlot4.transform.rotation) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.transform.parent = player1DeckSlot4.transform;

                    if (card.name == "instantiated3Card1(Clone)") {

                        card.name = "instantiated3HandCard1";

                    } else if (card.name == "instantiated3Card1a(Clone)") {

                        card.name = "instantiated3HandCard1a";

                    } else if (card.name == "instantiated3Card1b(Clone)") {

                        card.name = "instantiated3HandCard1b";

                    } else if (card.name == "instantiated3Card1c(Clone)") {

                        card.name = "instantiated3HandCard1c";

                    } else if (card.name == "instantiated3Card2(Clone)") {

                        card.name = "instantiated3HandCard2";

                    } else if (card.name == "instantiated3Card2a(Clone)") {

                        card.name = "instantiated3HandCard2a";

                    } else if (card.name == "instantiated3Card2b(Clone)") {

                        card.name = "instantiated3HandCard2b";

                    } else if (card.name == "instantiated3Card2c(Clone)") {

                        card.name = "instantiated3HandCard2c";

                    } else if (card.name == "instantiated3Card3(Clone)") {

                        card.name = "instantiated3HandCard3";

                    } else if (card.name == "instantiated3Card3a(Clone)") {

                        card.name = "instantiated3HandCard3a";

                    } else if (card.name == "instantiated3Card3b(Clone)") {

                        card.name = "instantiated3HandCard3b";

                    } else if (card.name == "instantiated3Card3c(Clone)") {

                        card.name = "instantiated3HandCard3c";

                    } else if (card.name == "instantiated3Card4(Clone)") {

                        card.name = "instantiated3HandCard4";

                    } else if (card.name == "instantiated3Card4a(Clone)") {

                        card.name = "instantiated3HandCard4a";

                    } else if (card.name == "instantiated3Card4b(Clone)") {

                        card.name = "instantiated3HandCard4b";

                    } else if (card.name == "instantiated3Card4c(Clone)") {

                        card.name = "instantiated3HandCard4c";

                    } else if (card.name == "instantiated3Card5(Clone)") {

                        card.name = "instantiated3HandCard5";

                    } else if (card.name == "instantiated3Card5a(Clone)") {

                        card.name = "instantiated3HandCard5a";

                    } else if (card.name == "instantiated3Card5b(Clone)") {

                        card.name = "instantiated3HandCard5b";

                    } else if (card.name == "instantiated3Card5c(Clone)") {

                        card.name = "instantiated3HandCard5c";

                    } else if (card.name == "instantiated3Card6(Clone)") {

                        card.name = "instantiated3HandCard6";

                    } else if (card.name == "instantiated3Card6a(Clone)") {

                        card.name = "instantiated3HandCard6a";

                    } else if (card.name == "instantiated3Card6b(Clone)") {

                        card.name = "instantiated3HandCard6b";

                    } else if (card.name == "instantiated3Card6c(Clone)") {

                        card.name = "instantiated3HandCard6c";

                    } else if (card.name == "instantiated3Card7(Clone)") {

                        card.name = "instantiated3HandCard7";

                    } else if (card.name == "instantiated3Card7a(Clone)") {

                        card.name = "instantiated3HandCard7a";

                    } else if (card.name == "instantiated3Card7b(Clone)") {

                        card.name = "instantiated3HandCard7b";

                    } else if (card.name == "instantiated3Card7c(Clone)") {

                        card.name = "instantiated3HandCard7c";

                    } else if (card.name == "instantiated3Card8(Clone)") {

                        card.name = "instantiated3HandCard8";

                    } else if (card.name == "instantiated3Card8a(Clone)") {

                        card.name = "instantiated3HandCard8a";

                    } else if (card.name == "instantiated3Card8b(Clone)") {

                        card.name = "instantiated3HandCard8b";

                    } else if (card.name == "instantiated3Card8c(Clone)") {

                        card.name = "instantiated3HandCard8c";

                    } else if (card.name == "instantiated3Card9(Clone)") {

                        card.name = "instantiated3HandCard9";

                    } else if (card.name == "instantiated3Card9a(Clone)") {

                        card.name = "instantiated3HandCard9a";

                    } else if (card.name == "instantiated3Card9b(Clone)") {

                        card.name = "instantiated3HandCard9b";

                    } else if (card.name == "instantiated3Card9c(Clone)") {

                        card.name = "instantiated3HandCard9c";

                    } else if (card.name == "instantiated3Card10(Clone)") {

                        card.name = "instantiatedAICard10";

                    } else if (card.name == "instantiated3Card10a(Clone)") {

                        card.name = "instantiated3HandCard10a";

                    } else if (card.name == "instantiated3Card10b(Clone)") {

                        card.name = "instantiated3HandCard10b";

                    } else if (card.name == "instantiated3Card10c(Clone)") {

                        card.name = "instantiated3HandCard10c";

                    } else if (card.name == "instantiated3Card11(Clone)") {

                        card.name = "instantiated3HandCard11";

                    } else if (card.name == "instantiated3Card11a(Clone)") {

                        card.name = "instantiated3HandCard11a";

                    } else if (card.name == "instantiated3Card11b(Clone)") {

                        card.name = "instantiated3HandCard11b";

                    } else if (card.name == "instantiated3Card11c(Clone)") {

                        card.name = "instantiated3HandCard11c";

                    } else if (card.name == "instantiated3Card12(Clone)") {

                        card.name = "instantiated3HandCard12";

                    } else if (card.name == "instantiated3Card12a(Clone)") {

                        card.name = "instantiated3HandCard12a";

                    } else if (card.name == "instantiated3Card12b(Clone)") {

                        card.name = "instantiated3HandCard12b";

                    } else if (card.name == "instantiated3Card12c(Clone)") {

                        card.name = "instantiated3HandCard12c";

                    } else if (card.name == "instantiated3Card13(Clone)") {

                        card.name = "instantiated3HandCard13";

                    } else if (card.name == "instantiated3Card13a(Clone)") {

                        card.name = "instantiated3HandCard13a";

                    } else if (card.name == "instantiated3Card13b(Clone)") {

                        card.name = "instantiated3HandCard13b";

                    } else if (card.name == "instantiated3Card13c(Clone)") {

                        card.name = "instantiated3HandCard13c";

                    } else if (card.name == "instantiated3Card14(Clone)") {

                        card.name = "instantiated3HandCard14";

                    } else if (card.name == "instantiated3Card14a(Clone)") {

                        card.name = "instantiated3HandCard14a";

                    } else if (card.name == "instantiated3Card14b(Clone)") {

                        card.name = "instantiated3HandCard14b";

                    } else if (card.name == "instantiated3Card14c(Clone)") {

                        card.name = "instantiated3HandCard14c";

                    } else if (card.name == "instantiated3Card15(Clone)") {

                        card.name = "instantiated3HandCard15";

                    } else if (card.name == "instantiated3Card15a(Clone)") {

                        card.name = "instantiated3HandCard15a";

                    } else if (card.name == "instantiated3Card15b(Clone)") {

                        card.name = "instantiated3HandCard15b";

                    } else if (card.name == "instantiated3Card15c(Clone)") {

                        card.name = "instantiated3HandCard15c";

                    } else if (card.name == "instantiated3Card16(Clone)") {

                        card.name = "instantiated3HandCard16";

                    } else if (card.name == "instantiated3Card16a(Clone)") {

                        card.name = "instantiated3HandCard16a";

                    } else if (card.name == "instantiated3Card16b(Clone)") {

                        card.name = "instantiated3HandCard16b";

                    } else if (card.name == "instantiated3Card16c(Clone)") {

                        card.name = "instantiated3HandCard16c";

                    } else if (card.name == "instantiated3Card17(Clone)") {

                        card.name = "instantiated3HandCard17";

                    } else if (card.name == "instantiated3Card17a(Clone)") {

                        card.name = "instantiated3HandCard17a";

                    } else if (card.name == "instantiated3Card17b(Clone)") {

                        card.name = "instantiated3HandCard17b";

                    } else if (card.name == "instantiated3Card17c(Clone)") {

                        card.name = "instantiated3HandCard17c";

                    } else if (card.name == "instantiated3Card18(Clone)") {

                        card.name = "instantiated3HandCard18";

                    } else if (card.name == "instantiated3Card18a(Clone)") {

                        card.name = "instantiated3HandCard18a";

                    } else if (card.name == "instantiated3Card18b(Clone)") {

                        card.name = "instantiated3HandCard18b";

                    } else if (card.name == "instantiated3Card18c(Clone)") {

                        card.name = "instantiated3HandCard18c";

                    } else if (card.name == "instantiated3Card19(Clone)") {

                        card.name = "instantiated3HandCard19";

                    } else if (card.name == "instantiated3Card19a(Clone)") {

                        card.name = "instantiated3HandCard19a";

                    } else if (card.name == "instantiated3Card19b(Clone)") {

                        card.name = "instantiated3HandCard19b";

                    } else if (card.name == "instantiated3Card19c(Clone)") {

                        card.name = "instantiated3HandCard19c";

                    } else if (card.name == "instantiated3Card20(Clone)") {

                        card.name = "instantiated3HandCard20";

                    } else if (card.name == "instantiated3Card20a(Clone)") {

                        card.name = "instantiated3HandCard20a";

                    } else if (card.name == "instantiated3Card20b(Clone)") {

                        card.name = "instantiated3HandCard20b";

                    } else if (card.name == "instantiated3Card20c(Clone)") {

                        card.name = "instantiated3HandCard20c";

                    } else if (card.name == "instantiated3Card21(Clone)") {

                        card.name = "instantiated3HandCard21";

                    } else if (card.name == "instantiated3Card21a(Clone)") {

                        card.name = "instantiated3HandCard21a";

                    } else if (card.name == "instantiated3Card21b(Clone)") {

                        card.name = "instantiated3HandCard21b";

                    } else if (card.name == "instantiated3Card21c(Clone)") {

                        card.name = "instantiated3HandCard21c";

                    } else if (card.name == "instantiated3Card22(Clone)") {

                        card.name = "instantiated3HandCard22";

                    } else if (card.name == "instantiated3Card22a(Clone)") {

                        card.name = "instantiated3HandCard22a";

                    } else if (card.name == "instantiated3Card22b(Clone)") {

                        card.name = "instantiated3HandCard22b";

                    } else if (card.name == "instantiated3Card22c(Clone)") {

                        card.name = "instantiated3HandCard22c";

                    } else if (card.name == "instantiated3Card23(Clone)") {

                        card.name = "instantiated3HandCard23";

                    } else if (card.name == "instantiated3Card23a(Clone)") {

                        card.name = "instantiated3HandCard23a";

                    } else if (card.name == "instantiated3Card23b(Clone)") {

                        card.name = "instantiated3HandCard23b";

                    } else if (card.name == "instantiated3Card23c(Clone)") {

                        card.name = "instantiated3HandCard23c";

                    } else if (card.name == "instantiated3Card24(Clone)") {

                        card.name = "instantiated3HandCard24";

                    } else if (card.name == "instantiated3Card24a(Clone)") {

                        card.name = "instantiated3HandCard24a";

                    } else if (card.name == "instantiated3Card24b(Clone)") {

                        card.name = "instantiated3HandCard24b";

                    } else if (card.name == "instantiated3Card24c(Clone)") {

                        card.name = "instantiated3HandCard24c";

                    } else if (card.name == "instantiated3Card25(Clone)") {

                        card.name = "instantiated3HandCard25";

                    } else if (card.name == "instantiated3Card25a(Clone)") {

                        card.name = "instantiated3HandCard25a";

                    } else if (card.name == "instantiated3Card25b(Clone)") {

                        card.name = "instantiated3HandCard25b";

                    } else if (card.name == "instantiated3Card25c(Clone)") {

                        card.name = "instantiated3HandCard25c";

                    } else if (card.name == "instantiated3Card26(Clone)") {

                        card.name = "instantiated3HandCard26";

                    } else if (card.name == "instantiated3Card26a(Clone)") {

                        card.name = "instantiated3HandCard26a";

                    } else if (card.name == "instantiated3Card26b(Clone)") {

                        card.name = "instantiated3HandCard26b";

                    } else if (card.name == "instantiated3Card26c(Clone)") {

                        card.name = "instantiated3HandCard26c";

                    } else if (card.name == "instantiated3Card27(Clone)") {

                        card.name = "instantiated3HandCard27";

                    } else if (card.name == "instantiated3Card27a(Clone)") {

                        card.name = "instantiated3HandCard27a";

                    } else if (card.name == "instantiated3Card27b(Clone)") {

                        card.name = "instantiated3HandCard27b";

                    } else if (card.name == "instantiated3Card27c(Clone)") {

                        card.name = "instantiated3HandCard27c";

                    } else if (card.name == "instantiated3Card28(Clone)") {

                        card.name = "instantiated3HandCard28";

                    } else if (card.name == "instantiated3Card28a(Clone)") {

                        card.name = "instantiated3HandCard28a";

                    } else if (card.name == "instantiated3Card28b(Clone)") {

                        card.name = "instantiated3HandCard28b";

                    } else if (card.name == "instantiated3Card28c(Clone)") {

                        card.name = "instantiated3HandCard28c";

                    } else if (card.name == "instantiated3Card29(Clone)") {

                        card.name = "instantiated3HandCard29";

                    } else if (card.name == "instantiated3Card29a(Clone)") {

                        card.name = "instantiated3HandCard29a";

                    } else if (card.name == "instantiated3Card29b(Clone)") {

                        card.name = "instantiated3HandCard29b";

                    } else if (card.name == "instantiated3Card29c(Clone)") {

                        card.name = "instantiated3HandCard29c";

                    } else if (card.name == "instantiated3Card30(Clone)") {

                        card.name = "instantiated3HandCard30";

                    } else if (card.name == "instantiated3Card30a(Clone)") {

                        card.name = "instantiated3HandCard30a";

                    } else if (card.name == "instantiated3Card30b(Clone)") {

                        card.name = "instantiated3HandCard30b";

                    } else if (card.name == "instantiated3Card30c(Clone)") {

                        card.name = "instantiated3HandCard30c";

                    } else if (card.name == "instantiated3Card31(Clone)") {

                        card.name = "instantiated3HandCard31";

                    } else if (card.name == "instantiated3Card31a(Clone)") {

                        card.name = "instantiated3HandCard31a";

                    } else if (card.name == "instantiated3Card31b(Clone)") {

                        card.name = "instantiated3HandCard31b";

                    } else if (card.name == "instantiated3Card31c(Clone)") {

                        card.name = "instantiated3HandCard31c";

                    } else if (card.name == "instantiated3Card32(Clone)") {

                        card.name = "instantiated3HandCard32";

                    } else if (card.name == "instantiated3Card32a(Clone)") {

                        card.name = "instantiated3HandCard32a";

                    } else if (card.name == "instantiated3Card32b(Clone)") {

                        card.name = "instantiated3HandCard32b";

                    } else if (card.name == "instantiated3Card32c(Clone)") {

                        card.name = "instantiated3HandCard32c";

                    } else if (card.name == "instantiated3Card33(Clone)") {

                        card.name = "instantiated3HandCard33";

                    } else if (card.name == "instantiated3Card33a(Clone)") {

                        card.name = "instantiated3HandCard33a";

                    } else if (card.name == "instantiated3Card33b(Clone)") {

                        card.name = "instantiated3HandCard33b";

                    } else if (card.name == "instantiated3Card33c(Clone)") {

                        card.name = "instantiated3HandCard33c";

                    } else if (card.name == "instantiated3Card34(Clone)") {

                        card.name = "instantiated3HandCard34";

                    } else if (card.name == "instantiated3Card34a(Clone)") {

                        card.name = "instantiated3HandCard34a";

                    } else if (card.name == "instantiated3Card34b(Clone)") {

                        card.name = "instantiated3HandCard34b";

                    } else if (card.name == "instantiated3Card34c(Clone)") {

                        card.name = "instantiated3HandCard34c";

                    } else if (card.name == "instantiated3Card35(Clone)") {

                        card.name = "instantiated3HandCard35";

                    } else if (card.name == "instantiated3Card35a(Clone)") {

                        card.name = "instantiated3HandCard35a";

                    } else if (card.name == "instantiated3Card35b(Clone)") {

                        card.name = "instantiated3HandCard35b";

                    } else if (card.name == "instantiated3Card35c(Clone)") {

                        card.name = "instantiated3HandCard35c";

                    } else if (card.name == "instantiated3Card36(Clone)") {

                        card.name = "instantiated3HandCard36";

                    } else if (card.name == "instantiated3Card36a(Clone)") {

                        card.name = "instantiated3HandCard36a";

                    } else if (card.name == "instantiated3Card36b(Clone)") {

                        card.name = "instantiated3HandCard36b";

                    } else if (card.name == "instantiated3Card36c(Clone)") {

                        card.name = "instantiated3HandCard36c";

                    } else if (card.name == "instantiated3Card37(Clone)") {

                        card.name = "instantiated3HandCard37";

                    } else if (card.name == "instantiated3Card37a(Clone)") {

                        card.name = "instantiated3HandCard37a";

                    } else if (card.name == "instantiated3Card37b(Clone)") {

                        card.name = "instantiated3HandCard37b";

                    } else if (card.name == "instantiated3Card37c(Clone)") {

                        card.name = "instantiated3HandCard37c";

                    } else if (card.name == "instantiated3Card38(Clone)") {

                        card.name = "instantiated3HandCard38";

                    } else if (card.name == "instantiated3Card38a(Clone)") {

                        card.name = "instantiated3HandCard38a";

                    } else if (card.name == "instantiated3Card38b(Clone)") {

                        card.name = "instantiated3HandCard38b";

                    } else if (card.name == "instantiated3Card38c(Clone)") {

                        card.name = "instantiated3HandCard38c";

                    } else if (card.name == "instantiated3Card39(Clone)") {

                        card.name = "instantiated3HandCard39";

                    } else if (card.name == "instantiated3Card39a(Clone)") {

                        card.name = "instantiated3HandCard39a";

                    } else if (card.name == "instantiated3Card39b(Clone)") {

                        card.name = "instantiated3HandCard39b";

                    } else if (card.name == "instantiated3Card39c(Clone)") {

                        card.name = "instantiated3HandCard39c";

                    } else if (card.name == "instantiated3Card40(Clone)") {

                        card.name = "instantiated3HandCard40";

                    } else if (card.name == "instantiated3Card40a(Clone)") {

                        card.name = "instantiated3HandCard40a";

                    } else if (card.name == "instantiated3Card40b(Clone)") {

                        card.name = "instantiated3HandCard40b";

                    } else if (card.name == "instantiated3Card40c(Clone)") {

                        card.name = "instantiated3HandCard40c";

                    } else if (card.name == "instantiated3Card41(Clone)") {

                        card.name = "instantiated3HandCard41";

                    } else if (card.name == "instantiated3Card41a(Clone)") {

                        card.name = "instantiated3HandCard41a";

                    } else if (card.name == "instantiated3Card41b(Clone)") {

                        card.name = "instantiated3HandCard41b";

                    } else if (card.name == "instantiated3Card41c(Clone)") {

                        card.name = "instantiated3HandCard41c";

                    } else if (card.name == "instantiated3Card42(Clone)") {

                        card.name = "instantiated3HandCard42";

                    } else if (card.name == "instantiated3Card42a(Clone)") {

                        card.name = "instantiated3HandCard42a";

                    } else if (card.name == "instantiated3Card42b(Clone)") {

                        card.name = "instantiated3HandCard42b";

                    } else if (card.name == "instantiated3Card42c(Clone)") {

                        card.name = "instantiated3HandCard42c";

                    } else if (card.name == "instantiated3Card43(Clone)") {

                        card.name = "instantiated3HandCard43";

                    } else if (card.name == "instantiated3Card43a(Clone)") {

                        card.name = "instantiated3HandCard43a";

                    } else if (card.name == "instantiated3Card43b(Clone)") {

                        card.name = "instantiated3HandCard43b";

                    } else if (card.name == "instantiated3Card43c(Clone)") {

                        card.name = "instantiated3HandCard43c";

                    } else if (card.name == "instantiated3Card44(Clone)") {

                        card.name = "instantiated3HandCard44";

                    } else if (card.name == "instantiated3Card44a(Clone)") {

                        card.name = "instantiated3HandCard44a";

                    } else if (card.name == "instantiated3Card44b(Clone)") {

                        card.name = "instantiated3HandCard44b";

                    } else if (card.name == "instantiated3Card44c(Clone)") {

                        card.name = "instantiated3HandCard44c";

                    } else if (card.name == "instantiated3Card45(Clone)") {

                        card.name = "instantiated3HandCard45";

                    } else if (card.name == "instantiated3Card45a(Clone)") {

                        card.name = "instantiated3HandCard45a";

                    } else if (card.name == "instantiated3Card45b(Clone)") {

                        card.name = "instantiated3HandCard45b";

                    } else if (card.name == "instantiated3Card45c(Clone)") {

                        card.name = "instantiated3HandCard45c";

                    } else if (card.name == "instantiated3Card46(Clone)") {

                        card.name = "instantiated3HandCard46";

                    } else if (card.name == "instantiated3Card46a(Clone)") {

                        card.name = "instantiated3HandCard46a";

                    } else if (card.name == "instantiated3Card46b(Clone)") {

                        card.name = "instantiated3HandCard46b";

                    } else if (card.name == "instantiated3Card46c(Clone)") {

                        card.name = "instantiated3HandCard46c";

                    } else if (card.name == "instantiated3Card47(Clone)") {

                        card.name = "instantiated3HandCard47";

                    } else if (card.name == "instantiated3Card47a(Clone)") {

                        card.name = "instantiated3HandCard47a";

                    } else if (card.name == "instantiated3Card47b(Clone)") {

                        card.name = "instantiated3HandCard47b";

                    } else if (card.name == "instantiated3Card47c(Clone)") {

                        card.name = "instantiated3HandCard47c";

                    } else if (card.name == "instantiated3Card48(Clone)") {

                        card.name = "instantiated3HandCard48";

                    } else if (card.name == "instantiated3Card48a(Clone)") {

                        card.name = "instantiated3HandCard48a";

                    } else if (card.name == "instantiated3Card48b(Clone)") {

                        card.name = "instantiated3HandCard48b";

                    } else if (card.name == "instantiated3Card48c(Clone)") {

                        card.name = "instantiated3HandCard48c";

                    } else if (card.name == "instantiated3Card49(Clone)") {

                        card.name = "instantiated3HandCard49";

                    } else if (card.name == "instantiated3Card49a(Clone)") {

                        card.name = "instantiated3HandCard49a";

                    } else if (card.name == "instantiated3Card49b(Clone)") {

                        card.name = "instantiated3HandCard49b";

                    } else if (card.name == "instantiated3Card49c(Clone)") {

                        card.name = "instantiated3HandCard49c";

                    } else if (card.name == "instantiated3Card50(Clone)") {

                        card.name = "instantiated3HandCard50";

                    } else if (card.name == "instantiated3Card50a(Clone)") {

                        card.name = "instantiated3HandCard50a";

                    } else if (card.name == "instantiated3Card50b(Clone)") {

                        card.name = "instantiated3HandCard50b";

                    } else if (card.name == "instantiated3Card50c(Clone)") {

                        card.name = "instantiated3HandCard50c";

                    } else if (card.name == "instantiated3Card51(Clone)") {

                        card.name = "instantiated3HandCard51";

                    } else if (card.name == "instantiated3Card51a(Clone)") {

                        card.name = "instantiated3HandCard51a";

                    } else if (card.name == "instantiated3Card51b(Clone)") {

                        card.name = "instantiated3HandCard51b";

                    } else if (card.name == "instantiated3Card51c(Clone)") {

                        card.name = "instantiated3HandCard51c";

                    } else if (card.name == "instantiated3Card52(Clone)") {

                        card.name = "instantiated3HandCard52";

                    } else if (card.name == "instantiated3Card52a(Clone)") {

                        card.name = "instantiated3HandCard52a";

                    } else if (card.name == "instantiated3Card52b(Clone)") {

                        card.name = "instantiated3HandCard52b";

                    } else if (card.name == "instantiated3Card52c(Clone)") {

                        card.name = "instantiated3HandCard52c";

                    } else if (card.name == "instantiated3Card53(Clone)") {

                        card.name = "instantiated3HandCard53";

                    } else if (card.name == "instantiated3Card53a(Clone)") {

                        card.name = "instantiated3HandCard53a";

                    } else if (card.name == "instantiated3Card53b(Clone)") {

                        card.name = "instantiated3HandCard53b";

                    } else if (card.name == "instantiated3Card53c(Clone)") {

                        card.name = "instantiated3HandCard53c";

                    } else if (card.name == "instantiated3Card54(Clone)") {

                        card.name = "instantiated3HandCard54";

                    } else if (card.name == "instantiated3Card54a(Clone)") {

                        card.name = "instantiated3HandCard54a";

                    } else if (card.name == "instantiated3Card54b(Clone)") {

                        card.name = "instantiated3HandCard54b";

                    } else if (card.name == "instantiated3Card54c(Clone)") {

                        card.name = "instantiated3HandCard54c";

                    } else if (card.name == "instantiated3Card55(Clone)") {

                        card.name = "instantiated3HandCard55";

                    } else if (card.name == "instantiated3Card55a(Clone)") {

                        card.name = "instantiated3HandCard55a";

                    } else if (card.name == "instantiated3Card55b(Clone)") {

                        card.name = "instantiated3HandCard55b";

                    } else if (card.name == "instantiated3Card55c(Clone)") {

                        card.name = "instantiated3HandCard55c";

                    } else if (card.name == "instantiated3Card56(Clone)") {

                        card.name = "instantiated3HandCard56";

                    } else if (card.name == "instantiated3Card56a(Clone)") {

                        card.name = "instantiated3HandCard56a";

                    } else if (card.name == "instantiated3Card56b(Clone)") {

                        card.name = "instantiated3HandCard56b";

                    } else if (card.name == "instantiated3Card56c(Clone)") {

                        card.name = "instantiated3HandCard56c";

                    } else if (card.name == "instantiated3Card57(Clone)") {

                        card.name = "instantiated3HandCard57";

                    } else if (card.name == "instantiated3Card57a(Clone)") {

                        card.name = "instantiated3HandCard57a";

                    } else if (card.name == "instantiated3Card57b(Clone)") {

                        card.name = "instantiated3HandCard57b";

                    } else if (card.name == "instantiated3Card57c(Clone)") {

                        card.name = "instantiated3HandCard57c";

                    } else if (card.name == "instantiated3Card58(Clone)") {

                        card.name = "instantiated3HandCard58";

                    } else if (card.name == "instantiated3Card58a(Clone)") {

                        card.name = "instantiated3HandCard58a";

                    } else if (card.name == "instantiated3Card58b(Clone)") {

                        card.name = "instantiated3HandCard58b";

                    } else if (card.name == "instantiated3Card58c(Clone)") {

                        card.name = "instantiated3HandCard58c";

                    } else if (card.name == "instantiated3Card59(Clone)") {

                        card.name = "instantiated3HandCard59";

                    } else if (card.name == "instantiated3Card59a(Clone)") {

                        card.name = "instantiated3HandCard59a";

                    } else if (card.name == "instantiated3Card59b(Clone)") {

                        card.name = "instantiated3HandCard59b";

                    } else if (card.name == "instantiated3Card59c(Clone)") {

                        card.name = "instantiated3HandCard59c";

                    } else if (card.name == "instantiated3Card60(Clone)") {

                        card.name = "instantiated3HandCard60";

                    } else if (card.name == "instantiated3Card60a(Clone)") {

                        card.name = "instantiated3HandCard60a";

                    } else if (card.name == "instantiated3Card60b(Clone)") {

                        card.name = "instantiated3HandCard60b";

                    } else if (card.name == "instantiated3Card60c(Clone)") {

                        card.name = "instantiated3HandCard60c";
                    }

                    instances4M++;

                }

            }

            if (player1DeckSlot5.transform.childCount == 0) {

                while (instances5M < NumberOfCards) {

                    GameObject card = Instantiate(playCardsDeck3[UnityEngine.Random.Range(0, playCardsDeck3.Count)], player1DeckSlot5.transform.position, player1DeckSlot5.transform.rotation) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.transform.parent = player1DeckSlot5.transform;

                    if (card.name == "instantiated3Card1(Clone)") {

                        card.name = "instantiated3HandCard1";

                    } else if (card.name == "instantiated3Card1a(Clone)") {

                        card.name = "instantiated3HandCard1a";

                    } else if (card.name == "instantiated3Card1b(Clone)") {

                        card.name = "instantiated3HandCard1b";

                    } else if (card.name == "instantiated3Card1c(Clone)") {

                        card.name = "instantiated3HandCard1c";

                    } else if (card.name == "instantiated3Card2(Clone)") {

                        card.name = "instantiated3HandCard2";

                    } else if (card.name == "instantiated3Card2a(Clone)") {

                        card.name = "instantiated3HandCard2a";

                    } else if (card.name == "instantiated3Card2b(Clone)") {

                        card.name = "instantiated3HandCard2b";

                    } else if (card.name == "instantiated3Card2c(Clone)") {

                        card.name = "instantiated3HandCard2c";

                    } else if (card.name == "instantiated3Card3(Clone)") {

                        card.name = "instantiated3HandCard3";

                    } else if (card.name == "instantiated3Card3a(Clone)") {

                        card.name = "instantiated3HandCard3a";

                    } else if (card.name == "instantiated3Card3b(Clone)") {

                        card.name = "instantiated3HandCard3b";

                    } else if (card.name == "instantiated3Card3c(Clone)") {

                        card.name = "instantiated3HandCard3c";

                    } else if (card.name == "instantiated3Card4(Clone)") {

                        card.name = "instantiated3HandCard4";

                    } else if (card.name == "instantiated3Card4a(Clone)") {

                        card.name = "instantiated3HandCard4a";

                    } else if (card.name == "instantiated3Card4b(Clone)") {

                        card.name = "instantiated3HandCard4b";

                    } else if (card.name == "instantiated3Card4c(Clone)") {

                        card.name = "instantiated3HandCard4c";

                    } else if (card.name == "instantiated3Card5(Clone)") {

                        card.name = "instantiated3HandCard5";

                    } else if (card.name == "instantiated3Card5a(Clone)") {

                        card.name = "instantiated3HandCard5a";

                    } else if (card.name == "instantiated3Card5b(Clone)") {

                        card.name = "instantiated3HandCard5b";

                    } else if (card.name == "instantiated3Card5c(Clone)") {

                        card.name = "instantiated3HandCard5c";

                    } else if (card.name == "instantiated3Card6(Clone)") {

                        card.name = "instantiated3HandCard6";

                    } else if (card.name == "instantiated3Card6a(Clone)") {

                        card.name = "instantiated3HandCard6a";

                    } else if (card.name == "instantiated3Card6b(Clone)") {

                        card.name = "instantiated3HandCard6b";

                    } else if (card.name == "instantiated3Card6c(Clone)") {

                        card.name = "instantiated3HandCard6c";

                    } else if (card.name == "instantiated3Card7(Clone)") {

                        card.name = "instantiated3HandCard7";

                    } else if (card.name == "instantiated3Card7a(Clone)") {

                        card.name = "instantiated3HandCard7a";

                    } else if (card.name == "instantiated3Card7b(Clone)") {

                        card.name = "instantiated3HandCard7b";

                    } else if (card.name == "instantiated3Card7c(Clone)") {

                        card.name = "instantiated3HandCard7c";

                    } else if (card.name == "instantiated3Card8(Clone)") {

                        card.name = "instantiated3HandCard8";

                    } else if (card.name == "instantiated3Card8a(Clone)") {

                        card.name = "instantiated3HandCard8a";

                    } else if (card.name == "instantiated3Card8b(Clone)") {

                        card.name = "instantiated3HandCard8b";

                    } else if (card.name == "instantiated3Card8c(Clone)") {

                        card.name = "instantiated3HandCard8c";

                    } else if (card.name == "instantiated3Card9(Clone)") {

                        card.name = "instantiated3HandCard9";

                    } else if (card.name == "instantiated3Card9a(Clone)") {

                        card.name = "instantiated3HandCard9a";

                    } else if (card.name == "instantiated3Card9b(Clone)") {

                        card.name = "instantiated3HandCard9b";

                    } else if (card.name == "instantiated3Card9c(Clone)") {

                        card.name = "instantiated3HandCard9c";

                    } else if (card.name == "instantiated3Card10(Clone)") {

                        card.name = "instantiatedAICard10";

                    } else if (card.name == "instantiated3Card10a(Clone)") {

                        card.name = "instantiated3HandCard10a";

                    } else if (card.name == "instantiated3Card10b(Clone)") {

                        card.name = "instantiated3HandCard10b";

                    } else if (card.name == "instantiated3Card10c(Clone)") {

                        card.name = "instantiated3HandCard10c";

                    } else if (card.name == "instantiated3Card11(Clone)") {

                        card.name = "instantiated3HandCard11";

                    } else if (card.name == "instantiated3Card11a(Clone)") {

                        card.name = "instantiated3HandCard11a";

                    } else if (card.name == "instantiated3Card11b(Clone)") {

                        card.name = "instantiated3HandCard11b";

                    } else if (card.name == "instantiated3Card11c(Clone)") {

                        card.name = "instantiated3HandCard11c";

                    } else if (card.name == "instantiated3Card12(Clone)") {

                        card.name = "instantiated3HandCard12";

                    } else if (card.name == "instantiated3Card12a(Clone)") {

                        card.name = "instantiated3HandCard12a";

                    } else if (card.name == "instantiated3Card12b(Clone)") {

                        card.name = "instantiated3HandCard12b";

                    } else if (card.name == "instantiated3Card12c(Clone)") {

                        card.name = "instantiated3HandCard12c";

                    } else if (card.name == "instantiated3Card13(Clone)") {

                        card.name = "instantiated3HandCard13";

                    } else if (card.name == "instantiated3Card13a(Clone)") {

                        card.name = "instantiated3HandCard13a";

                    } else if (card.name == "instantiated3Card13b(Clone)") {

                        card.name = "instantiated3HandCard13b";

                    } else if (card.name == "instantiated3Card13c(Clone)") {

                        card.name = "instantiated3HandCard13c";

                    } else if (card.name == "instantiated3Card14(Clone)") {

                        card.name = "instantiated3HandCard14";

                    } else if (card.name == "instantiated3Card14a(Clone)") {

                        card.name = "instantiated3HandCard14a";

                    } else if (card.name == "instantiated3Card14b(Clone)") {

                        card.name = "instantiated3HandCard14b";

                    } else if (card.name == "instantiated3Card14c(Clone)") {

                        card.name = "instantiated3HandCard14c";

                    } else if (card.name == "instantiated3Card15(Clone)") {

                        card.name = "instantiated3HandCard15";

                    } else if (card.name == "instantiated3Card15a(Clone)") {

                        card.name = "instantiated3HandCard15a";

                    } else if (card.name == "instantiated3Card15b(Clone)") {

                        card.name = "instantiated3HandCard15b";

                    } else if (card.name == "instantiated3Card15c(Clone)") {

                        card.name = "instantiated3HandCard15c";

                    } else if (card.name == "instantiated3Card16(Clone)") {

                        card.name = "instantiated3HandCard16";

                    } else if (card.name == "instantiated3Card16a(Clone)") {

                        card.name = "instantiated3HandCard16a";

                    } else if (card.name == "instantiated3Card16b(Clone)") {

                        card.name = "instantiated3HandCard16b";

                    } else if (card.name == "instantiated3Card16c(Clone)") {

                        card.name = "instantiated3HandCard16c";

                    } else if (card.name == "instantiated3Card17(Clone)") {

                        card.name = "instantiated3HandCard17";

                    } else if (card.name == "instantiated3Card17a(Clone)") {

                        card.name = "instantiated3HandCard17a";

                    } else if (card.name == "instantiated3Card17b(Clone)") {

                        card.name = "instantiated3HandCard17b";

                    } else if (card.name == "instantiated3Card17c(Clone)") {

                        card.name = "instantiated3HandCard17c";

                    } else if (card.name == "instantiated3Card18(Clone)") {

                        card.name = "instantiated3HandCard18";

                    } else if (card.name == "instantiated3Card18a(Clone)") {

                        card.name = "instantiated3HandCard18a";

                    } else if (card.name == "instantiated3Card18b(Clone)") {

                        card.name = "instantiated3HandCard18b";

                    } else if (card.name == "instantiated3Card18c(Clone)") {

                        card.name = "instantiated3HandCard18c";

                    } else if (card.name == "instantiated3Card19(Clone)") {

                        card.name = "instantiated3HandCard19";

                    } else if (card.name == "instantiated3Card19a(Clone)") {

                        card.name = "instantiated3HandCard19a";

                    } else if (card.name == "instantiated3Card19b(Clone)") {

                        card.name = "instantiated3HandCard19b";

                    } else if (card.name == "instantiated3Card19c(Clone)") {

                        card.name = "instantiated3HandCard19c";

                    } else if (card.name == "instantiated3Card20(Clone)") {

                        card.name = "instantiated3HandCard20";

                    } else if (card.name == "instantiated3Card20a(Clone)") {

                        card.name = "instantiated3HandCard20a";

                    } else if (card.name == "instantiated3Card20b(Clone)") {

                        card.name = "instantiated3HandCard20b";

                    } else if (card.name == "instantiated3Card20c(Clone)") {

                        card.name = "instantiated3HandCard20c";

                    } else if (card.name == "instantiated3Card21(Clone)") {

                        card.name = "instantiated3HandCard21";

                    } else if (card.name == "instantiated3Card21a(Clone)") {

                        card.name = "instantiated3HandCard21a";

                    } else if (card.name == "instantiated3Card21b(Clone)") {

                        card.name = "instantiated3HandCard21b";

                    } else if (card.name == "instantiated3Card21c(Clone)") {

                        card.name = "instantiated3HandCard21c";

                    } else if (card.name == "instantiated3Card22(Clone)") {

                        card.name = "instantiated3HandCard22";

                    } else if (card.name == "instantiated3Card22a(Clone)") {

                        card.name = "instantiated3HandCard22a";

                    } else if (card.name == "instantiated3Card22b(Clone)") {

                        card.name = "instantiated3HandCard22b";

                    } else if (card.name == "instantiated3Card22c(Clone)") {

                        card.name = "instantiated3HandCard22c";

                    } else if (card.name == "instantiated3Card23(Clone)") {

                        card.name = "instantiated3HandCard23";

                    } else if (card.name == "instantiated3Card23a(Clone)") {

                        card.name = "instantiated3HandCard23a";

                    } else if (card.name == "instantiated3Card23b(Clone)") {

                        card.name = "instantiated3HandCard23b";

                    } else if (card.name == "instantiated3Card23c(Clone)") {

                        card.name = "instantiated3HandCard23c";

                    } else if (card.name == "instantiated3Card24(Clone)") {

                        card.name = "instantiated3HandCard24";

                    } else if (card.name == "instantiated3Card24a(Clone)") {

                        card.name = "instantiated3HandCard24a";

                    } else if (card.name == "instantiated3Card24b(Clone)") {

                        card.name = "instantiated3HandCard24b";

                    } else if (card.name == "instantiated3Card24c(Clone)") {

                        card.name = "instantiated3HandCard24c";

                    } else if (card.name == "instantiated3Card25(Clone)") {

                        card.name = "instantiated3HandCard25";

                    } else if (card.name == "instantiated3Card25a(Clone)") {

                        card.name = "instantiated3HandCard25a";

                    } else if (card.name == "instantiated3Card25b(Clone)") {

                        card.name = "instantiated3HandCard25b";

                    } else if (card.name == "instantiated3Card25c(Clone)") {

                        card.name = "instantiated3HandCard25c";

                    } else if (card.name == "instantiated3Card26(Clone)") {

                        card.name = "instantiated3HandCard26";

                    } else if (card.name == "instantiated3Card26a(Clone)") {

                        card.name = "instantiated3HandCard26a";

                    } else if (card.name == "instantiated3Card26b(Clone)") {

                        card.name = "instantiated3HandCard26b";

                    } else if (card.name == "instantiated3Card26c(Clone)") {

                        card.name = "instantiated3HandCard26c";

                    } else if (card.name == "instantiated3Card27(Clone)") {

                        card.name = "instantiated3HandCard27";

                    } else if (card.name == "instantiated3Card27a(Clone)") {

                        card.name = "instantiated3HandCard27a";

                    } else if (card.name == "instantiated3Card27b(Clone)") {

                        card.name = "instantiated3HandCard27b";

                    } else if (card.name == "instantiated3Card27c(Clone)") {

                        card.name = "instantiated3HandCard27c";

                    } else if (card.name == "instantiated3Card28(Clone)") {

                        card.name = "instantiated3HandCard28";

                    } else if (card.name == "instantiated3Card28a(Clone)") {

                        card.name = "instantiated3HandCard28a";

                    } else if (card.name == "instantiated3Card28b(Clone)") {

                        card.name = "instantiated3HandCard28b";

                    } else if (card.name == "instantiated3Card28c(Clone)") {

                        card.name = "instantiated3HandCard28c";

                    } else if (card.name == "instantiated3Card29(Clone)") {

                        card.name = "instantiated3HandCard29";

                    } else if (card.name == "instantiated3Card29a(Clone)") {

                        card.name = "instantiated3HandCard29a";

                    } else if (card.name == "instantiated3Card29b(Clone)") {

                        card.name = "instantiated3HandCard29b";

                    } else if (card.name == "instantiated3Card29c(Clone)") {

                        card.name = "instantiated3HandCard29c";

                    } else if (card.name == "instantiated3Card30(Clone)") {

                        card.name = "instantiated3HandCard30";

                    } else if (card.name == "instantiated3Card30a(Clone)") {

                        card.name = "instantiated3HandCard30a";

                    } else if (card.name == "instantiated3Card30b(Clone)") {

                        card.name = "instantiated3HandCard30b";

                    } else if (card.name == "instantiated3Card30c(Clone)") {

                        card.name = "instantiated3HandCard30c";

                    } else if (card.name == "instantiated3Card31(Clone)") {

                        card.name = "instantiated3HandCard31";

                    } else if (card.name == "instantiated3Card31a(Clone)") {

                        card.name = "instantiated3HandCard31a";

                    } else if (card.name == "instantiated3Card31b(Clone)") {

                        card.name = "instantiated3HandCard31b";

                    } else if (card.name == "instantiated3Card31c(Clone)") {

                        card.name = "instantiated3HandCard31c";

                    } else if (card.name == "instantiated3Card32(Clone)") {

                        card.name = "instantiated3HandCard32";

                    } else if (card.name == "instantiated3Card32a(Clone)") {

                        card.name = "instantiated3HandCard32a";

                    } else if (card.name == "instantiated3Card32b(Clone)") {

                        card.name = "instantiated3HandCard32b";

                    } else if (card.name == "instantiated3Card32c(Clone)") {

                        card.name = "instantiated3HandCard32c";

                    } else if (card.name == "instantiated3Card33(Clone)") {

                        card.name = "instantiated3HandCard33";

                    } else if (card.name == "instantiated3Card33a(Clone)") {

                        card.name = "instantiated3HandCard33a";

                    } else if (card.name == "instantiated3Card33b(Clone)") {

                        card.name = "instantiated3HandCard33b";

                    } else if (card.name == "instantiated3Card33c(Clone)") {

                        card.name = "instantiated3HandCard33c";

                    } else if (card.name == "instantiated3Card34(Clone)") {

                        card.name = "instantiated3HandCard34";

                    } else if (card.name == "instantiated3Card34a(Clone)") {

                        card.name = "instantiated3HandCard34a";

                    } else if (card.name == "instantiated3Card34b(Clone)") {

                        card.name = "instantiated3HandCard34b";

                    } else if (card.name == "instantiated3Card34c(Clone)") {

                        card.name = "instantiated3HandCard34c";

                    } else if (card.name == "instantiated3Card35(Clone)") {

                        card.name = "instantiated3HandCard35";

                    } else if (card.name == "instantiated3Card35a(Clone)") {

                        card.name = "instantiated3HandCard35a";

                    } else if (card.name == "instantiated3Card35b(Clone)") {

                        card.name = "instantiated3HandCard35b";

                    } else if (card.name == "instantiated3Card35c(Clone)") {

                        card.name = "instantiated3HandCard35c";

                    } else if (card.name == "instantiated3Card36(Clone)") {

                        card.name = "instantiated3HandCard36";

                    } else if (card.name == "instantiated3Card36a(Clone)") {

                        card.name = "instantiated3HandCard36a";

                    } else if (card.name == "instantiated3Card36b(Clone)") {

                        card.name = "instantiated3HandCard36b";

                    } else if (card.name == "instantiated3Card36c(Clone)") {

                        card.name = "instantiated3HandCard36c";

                    } else if (card.name == "instantiated3Card37(Clone)") {

                        card.name = "instantiated3HandCard37";

                    } else if (card.name == "instantiated3Card37a(Clone)") {

                        card.name = "instantiated3HandCard37a";

                    } else if (card.name == "instantiated3Card37b(Clone)") {

                        card.name = "instantiated3HandCard37b";

                    } else if (card.name == "instantiated3Card37c(Clone)") {

                        card.name = "instantiated3HandCard37c";

                    } else if (card.name == "instantiated3Card38(Clone)") {

                        card.name = "instantiated3HandCard38";

                    } else if (card.name == "instantiated3Card38a(Clone)") {

                        card.name = "instantiated3HandCard38a";

                    } else if (card.name == "instantiated3Card38b(Clone)") {

                        card.name = "instantiated3HandCard38b";

                    } else if (card.name == "instantiated3Card38c(Clone)") {

                        card.name = "instantiated3HandCard38c";

                    } else if (card.name == "instantiated3Card39(Clone)") {

                        card.name = "instantiated3HandCard39";

                    } else if (card.name == "instantiated3Card39a(Clone)") {

                        card.name = "instantiated3HandCard39a";

                    } else if (card.name == "instantiated3Card39b(Clone)") {

                        card.name = "instantiated3HandCard39b";

                    } else if (card.name == "instantiated3Card39c(Clone)") {

                        card.name = "instantiated3HandCard39c";

                    } else if (card.name == "instantiated3Card40(Clone)") {

                        card.name = "instantiated3HandCard40";

                    } else if (card.name == "instantiated3Card40a(Clone)") {

                        card.name = "instantiated3HandCard40a";

                    } else if (card.name == "instantiated3Card40b(Clone)") {

                        card.name = "instantiated3HandCard40b";

                    } else if (card.name == "instantiated3Card40c(Clone)") {

                        card.name = "instantiated3HandCard40c";

                    } else if (card.name == "instantiated3Card41(Clone)") {

                        card.name = "instantiated3HandCard41";

                    } else if (card.name == "instantiated3Card41a(Clone)") {

                        card.name = "instantiated3HandCard41a";

                    } else if (card.name == "instantiated3Card41b(Clone)") {

                        card.name = "instantiated3HandCard41b";

                    } else if (card.name == "instantiated3Card41c(Clone)") {

                        card.name = "instantiated3HandCard41c";

                    } else if (card.name == "instantiated3Card42(Clone)") {

                        card.name = "instantiated3HandCard42";

                    } else if (card.name == "instantiated3Card42a(Clone)") {

                        card.name = "instantiated3HandCard42a";

                    } else if (card.name == "instantiated3Card42b(Clone)") {

                        card.name = "instantiated3HandCard42b";

                    } else if (card.name == "instantiated3Card42c(Clone)") {

                        card.name = "instantiated3HandCard42c";

                    } else if (card.name == "instantiated3Card43(Clone)") {

                        card.name = "instantiated3HandCard43";

                    } else if (card.name == "instantiated3Card43a(Clone)") {

                        card.name = "instantiated3HandCard43a";

                    } else if (card.name == "instantiated3Card43b(Clone)") {

                        card.name = "instantiated3HandCard43b";

                    } else if (card.name == "instantiated3Card43c(Clone)") {

                        card.name = "instantiated3HandCard43c";

                    } else if (card.name == "instantiated3Card44(Clone)") {

                        card.name = "instantiated3HandCard44";

                    } else if (card.name == "instantiated3Card44a(Clone)") {

                        card.name = "instantiated3HandCard44a";

                    } else if (card.name == "instantiated3Card44b(Clone)") {

                        card.name = "instantiated3HandCard44b";

                    } else if (card.name == "instantiated3Card44c(Clone)") {

                        card.name = "instantiated3HandCard44c";

                    } else if (card.name == "instantiated3Card45(Clone)") {

                        card.name = "instantiated3HandCard45";

                    } else if (card.name == "instantiated3Card45a(Clone)") {

                        card.name = "instantiated3HandCard45a";

                    } else if (card.name == "instantiated3Card45b(Clone)") {

                        card.name = "instantiated3HandCard45b";

                    } else if (card.name == "instantiated3Card45c(Clone)") {

                        card.name = "instantiated3HandCard45c";

                    } else if (card.name == "instantiated3Card46(Clone)") {

                        card.name = "instantiated3HandCard46";

                    } else if (card.name == "instantiated3Card46a(Clone)") {

                        card.name = "instantiated3HandCard46a";

                    } else if (card.name == "instantiated3Card46b(Clone)") {

                        card.name = "instantiated3HandCard46b";

                    } else if (card.name == "instantiated3Card46c(Clone)") {

                        card.name = "instantiated3HandCard46c";

                    } else if (card.name == "instantiated3Card47(Clone)") {

                        card.name = "instantiated3HandCard47";

                    } else if (card.name == "instantiated3Card47a(Clone)") {

                        card.name = "instantiated3HandCard47a";

                    } else if (card.name == "instantiated3Card47b(Clone)") {

                        card.name = "instantiated3HandCard47b";

                    } else if (card.name == "instantiated3Card47c(Clone)") {

                        card.name = "instantiated3HandCard47c";

                    } else if (card.name == "instantiated3Card48(Clone)") {

                        card.name = "instantiated3HandCard48";

                    } else if (card.name == "instantiated3Card48a(Clone)") {

                        card.name = "instantiated3HandCard48a";

                    } else if (card.name == "instantiated3Card48b(Clone)") {

                        card.name = "instantiated3HandCard48b";

                    } else if (card.name == "instantiated3Card48c(Clone)") {

                        card.name = "instantiated3HandCard48c";

                    } else if (card.name == "instantiated3Card49(Clone)") {

                        card.name = "instantiated3HandCard49";

                    } else if (card.name == "instantiated3Card49a(Clone)") {

                        card.name = "instantiated3HandCard49a";

                    } else if (card.name == "instantiated3Card49b(Clone)") {

                        card.name = "instantiated3HandCard49b";

                    } else if (card.name == "instantiated3Card49c(Clone)") {

                        card.name = "instantiated3HandCard49c";

                    } else if (card.name == "instantiated3Card50(Clone)") {

                        card.name = "instantiated3HandCard50";

                    } else if (card.name == "instantiated3Card50a(Clone)") {

                        card.name = "instantiated3HandCard50a";

                    } else if (card.name == "instantiated3Card50b(Clone)") {

                        card.name = "instantiated3HandCard50b";

                    } else if (card.name == "instantiated3Card50c(Clone)") {

                        card.name = "instantiated3HandCard50c";

                    } else if (card.name == "instantiated3Card51(Clone)") {

                        card.name = "instantiated3HandCard51";

                    } else if (card.name == "instantiated3Card51a(Clone)") {

                        card.name = "instantiated3HandCard51a";

                    } else if (card.name == "instantiated3Card51b(Clone)") {

                        card.name = "instantiated3HandCard51b";

                    } else if (card.name == "instantiated3Card51c(Clone)") {

                        card.name = "instantiated3HandCard51c";

                    } else if (card.name == "instantiated3Card52(Clone)") {

                        card.name = "instantiated3HandCard52";

                    } else if (card.name == "instantiated3Card52a(Clone)") {

                        card.name = "instantiated3HandCard52a";

                    } else if (card.name == "instantiated3Card52b(Clone)") {

                        card.name = "instantiated3HandCard52b";

                    } else if (card.name == "instantiated3Card52c(Clone)") {

                        card.name = "instantiated3HandCard52c";

                    } else if (card.name == "instantiated3Card53(Clone)") {

                        card.name = "instantiated3HandCard53";

                    } else if (card.name == "instantiated3Card53a(Clone)") {

                        card.name = "instantiated3HandCard53a";

                    } else if (card.name == "instantiated3Card53b(Clone)") {

                        card.name = "instantiated3HandCard53b";

                    } else if (card.name == "instantiated3Card53c(Clone)") {

                        card.name = "instantiated3HandCard53c";

                    } else if (card.name == "instantiated3Card54(Clone)") {

                        card.name = "instantiated3HandCard54";

                    } else if (card.name == "instantiated3Card54a(Clone)") {

                        card.name = "instantiated3HandCard54a";

                    } else if (card.name == "instantiated3Card54b(Clone)") {

                        card.name = "instantiated3HandCard54b";

                    } else if (card.name == "instantiated3Card54c(Clone)") {

                        card.name = "instantiated3HandCard54c";

                    } else if (card.name == "instantiated3Card55(Clone)") {

                        card.name = "instantiated3HandCard55";

                    } else if (card.name == "instantiated3Card55a(Clone)") {

                        card.name = "instantiated3HandCard55a";

                    } else if (card.name == "instantiated3Card55b(Clone)") {

                        card.name = "instantiated3HandCard55b";

                    } else if (card.name == "instantiated3Card55c(Clone)") {

                        card.name = "instantiated3HandCard55c";

                    } else if (card.name == "instantiated3Card56(Clone)") {

                        card.name = "instantiated3HandCard56";

                    } else if (card.name == "instantiated3Card56a(Clone)") {

                        card.name = "instantiated3HandCard56a";

                    } else if (card.name == "instantiated3Card56b(Clone)") {

                        card.name = "instantiated3HandCard56b";

                    } else if (card.name == "instantiated3Card56c(Clone)") {

                        card.name = "instantiated3HandCard56c";

                    } else if (card.name == "instantiated3Card57(Clone)") {

                        card.name = "instantiated3HandCard57";

                    } else if (card.name == "instantiated3Card57a(Clone)") {

                        card.name = "instantiated3HandCard57a";

                    } else if (card.name == "instantiated3Card57b(Clone)") {

                        card.name = "instantiated3HandCard57b";

                    } else if (card.name == "instantiated3Card57c(Clone)") {

                        card.name = "instantiated3HandCard57c";

                    } else if (card.name == "instantiated3Card58(Clone)") {

                        card.name = "instantiated3HandCard58";

                    } else if (card.name == "instantiated3Card58a(Clone)") {

                        card.name = "instantiated3HandCard58a";

                    } else if (card.name == "instantiated3Card58b(Clone)") {

                        card.name = "instantiated3HandCard58b";

                    } else if (card.name == "instantiated3Card58c(Clone)") {

                        card.name = "instantiated3HandCard58c";

                    } else if (card.name == "instantiated3Card59(Clone)") {

                        card.name = "instantiated3HandCard59";

                    } else if (card.name == "instantiated3Card59a(Clone)") {

                        card.name = "instantiated3HandCard59a";

                    } else if (card.name == "instantiated3Card59b(Clone)") {

                        card.name = "instantiated3HandCard59b";

                    } else if (card.name == "instantiated3Card59c(Clone)") {

                        card.name = "instantiated3HandCard59c";

                    } else if (card.name == "instantiated3Card60(Clone)") {

                        card.name = "instantiated3HandCard60";

                    } else if (card.name == "instantiated3Card60a(Clone)") {

                        card.name = "instantiated3HandCard60a";

                    } else if (card.name == "instantiated3Card60b(Clone)") {

                        card.name = "instantiated3HandCard60b";

                    } else if (card.name == "instantiated3Card60c(Clone)") {

                        card.name = "instantiated3HandCard60c";
                    }

                    instances5M++;

                }

            }

            if (player1DeckSlot6.transform.childCount == 0) {

                while (instances6M < NumberOfCards) {

                    GameObject card = Instantiate(playCardsDeck3[UnityEngine.Random.Range(0, playCardsDeck3.Count)], player1DeckSlot6.transform.position, player1DeckSlot6.transform.rotation) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.transform.parent = player1DeckSlot6.transform;

                    if (card.name == "instantiated3Card1(Clone)") {

                        card.name = "instantiated3HandCard1";

                    } else if (card.name == "instantiated3Card1a(Clone)") {

                        card.name = "instantiated3HandCard1a";

                    } else if (card.name == "instantiated3Card1b(Clone)") {

                        card.name = "instantiated3HandCard1b";

                    } else if (card.name == "instantiated3Card1c(Clone)") {

                        card.name = "instantiated3HandCard1c";

                    } else if (card.name == "instantiated3Card2(Clone)") {

                        card.name = "instantiated3HandCard2";

                    } else if (card.name == "instantiated3Card2a(Clone)") {

                        card.name = "instantiated3HandCard2a";

                    } else if (card.name == "instantiated3Card2b(Clone)") {

                        card.name = "instantiated3HandCard2b";

                    } else if (card.name == "instantiated3Card2c(Clone)") {

                        card.name = "instantiated3HandCard2c";

                    } else if (card.name == "instantiated3Card3(Clone)") {

                        card.name = "instantiated3HandCard3";

                    } else if (card.name == "instantiated3Card3a(Clone)") {

                        card.name = "instantiated3HandCard3a";

                    } else if (card.name == "instantiated3Card3b(Clone)") {

                        card.name = "instantiated3HandCard3b";

                    } else if (card.name == "instantiated3Card3c(Clone)") {

                        card.name = "instantiated3HandCard3c";

                    } else if (card.name == "instantiated3Card4(Clone)") {

                        card.name = "instantiated3HandCard4";

                    } else if (card.name == "instantiated3Card4a(Clone)") {

                        card.name = "instantiated3HandCard4a";

                    } else if (card.name == "instantiated3Card4b(Clone)") {

                        card.name = "instantiated3HandCard4b";

                    } else if (card.name == "instantiated3Card4c(Clone)") {

                        card.name = "instantiated3HandCard4c";

                    } else if (card.name == "instantiated3Card5(Clone)") {

                        card.name = "instantiated3HandCard5";

                    } else if (card.name == "instantiated3Card5a(Clone)") {

                        card.name = "instantiated3HandCard5a";

                    } else if (card.name == "instantiated3Card5b(Clone)") {

                        card.name = "instantiated3HandCard5b";

                    } else if (card.name == "instantiated3Card5c(Clone)") {

                        card.name = "instantiated3HandCard5c";

                    } else if (card.name == "instantiated3Card6(Clone)") {

                        card.name = "instantiated3HandCard6";

                    } else if (card.name == "instantiated3Card6a(Clone)") {

                        card.name = "instantiated3HandCard6a";

                    } else if (card.name == "instantiated3Card6b(Clone)") {

                        card.name = "instantiated3HandCard6b";

                    } else if (card.name == "instantiated3Card6c(Clone)") {

                        card.name = "instantiated3HandCard6c";

                    } else if (card.name == "instantiated3Card7(Clone)") {

                        card.name = "instantiated3HandCard7";

                    } else if (card.name == "instantiated3Card7a(Clone)") {

                        card.name = "instantiated3HandCard7a";

                    } else if (card.name == "instantiated3Card7b(Clone)") {

                        card.name = "instantiated3HandCard7b";

                    } else if (card.name == "instantiated3Card7c(Clone)") {

                        card.name = "instantiated3HandCard7c";

                    } else if (card.name == "instantiated3Card8(Clone)") {

                        card.name = "instantiated3HandCard8";

                    } else if (card.name == "instantiated3Card8a(Clone)") {

                        card.name = "instantiated3HandCard8a";

                    } else if (card.name == "instantiated3Card8b(Clone)") {

                        card.name = "instantiated3HandCard8b";

                    } else if (card.name == "instantiated3Card8c(Clone)") {

                        card.name = "instantiated3HandCard8c";

                    } else if (card.name == "instantiated3Card9(Clone)") {

                        card.name = "instantiated3HandCard9";

                    } else if (card.name == "instantiated3Card9a(Clone)") {

                        card.name = "instantiated3HandCard9a";

                    } else if (card.name == "instantiated3Card9b(Clone)") {

                        card.name = "instantiated3HandCard9b";

                    } else if (card.name == "instantiated3Card9c(Clone)") {

                        card.name = "instantiated3HandCard9c";

                    } else if (card.name == "instantiated3Card10(Clone)") {

                        card.name = "instantiatedAICard10";

                    } else if (card.name == "instantiated3Card10a(Clone)") {

                        card.name = "instantiated3HandCard10a";

                    } else if (card.name == "instantiated3Card10b(Clone)") {

                        card.name = "instantiated3HandCard10b";

                    } else if (card.name == "instantiated3Card10c(Clone)") {

                        card.name = "instantiated3HandCard10c";

                    } else if (card.name == "instantiated3Card11(Clone)") {

                        card.name = "instantiated3HandCard11";

                    } else if (card.name == "instantiated3Card11a(Clone)") {

                        card.name = "instantiated3HandCard11a";

                    } else if (card.name == "instantiated3Card11b(Clone)") {

                        card.name = "instantiated3HandCard11b";

                    } else if (card.name == "instantiated3Card11c(Clone)") {

                        card.name = "instantiated3HandCard11c";

                    } else if (card.name == "instantiated3Card12(Clone)") {

                        card.name = "instantiated3HandCard12";

                    } else if (card.name == "instantiated3Card12a(Clone)") {

                        card.name = "instantiated3HandCard12a";

                    } else if (card.name == "instantiated3Card12b(Clone)") {

                        card.name = "instantiated3HandCard12b";

                    } else if (card.name == "instantiated3Card12c(Clone)") {

                        card.name = "instantiated3HandCard12c";

                    } else if (card.name == "instantiated3Card13(Clone)") {

                        card.name = "instantiated3HandCard13";

                    } else if (card.name == "instantiated3Card13a(Clone)") {

                        card.name = "instantiated3HandCard13a";

                    } else if (card.name == "instantiated3Card13b(Clone)") {

                        card.name = "instantiated3HandCard13b";

                    } else if (card.name == "instantiated3Card13c(Clone)") {

                        card.name = "instantiated3HandCard13c";

                    } else if (card.name == "instantiated3Card14(Clone)") {

                        card.name = "instantiated3HandCard14";

                    } else if (card.name == "instantiated3Card14a(Clone)") {

                        card.name = "instantiated3HandCard14a";

                    } else if (card.name == "instantiated3Card14b(Clone)") {

                        card.name = "instantiated3HandCard14b";

                    } else if (card.name == "instantiated3Card14c(Clone)") {

                        card.name = "instantiated3HandCard14c";

                    } else if (card.name == "instantiated3Card15(Clone)") {

                        card.name = "instantiated3HandCard15";

                    } else if (card.name == "instantiated3Card15a(Clone)") {

                        card.name = "instantiated3HandCard15a";

                    } else if (card.name == "instantiated3Card15b(Clone)") {

                        card.name = "instantiated3HandCard15b";

                    } else if (card.name == "instantiated3Card15c(Clone)") {

                        card.name = "instantiated3HandCard15c";

                    } else if (card.name == "instantiated3Card16(Clone)") {

                        card.name = "instantiated3HandCard16";

                    } else if (card.name == "instantiated3Card16a(Clone)") {

                        card.name = "instantiated3HandCard16a";

                    } else if (card.name == "instantiated3Card16b(Clone)") {

                        card.name = "instantiated3HandCard16b";

                    } else if (card.name == "instantiated3Card16c(Clone)") {

                        card.name = "instantiated3HandCard16c";

                    } else if (card.name == "instantiated3Card17(Clone)") {

                        card.name = "instantiated3HandCard17";

                    } else if (card.name == "instantiated3Card17a(Clone)") {

                        card.name = "instantiated3HandCard17a";

                    } else if (card.name == "instantiated3Card17b(Clone)") {

                        card.name = "instantiated3HandCard17b";

                    } else if (card.name == "instantiated3Card17c(Clone)") {

                        card.name = "instantiated3HandCard17c";

                    } else if (card.name == "instantiated3Card18(Clone)") {

                        card.name = "instantiated3HandCard18";

                    } else if (card.name == "instantiated3Card18a(Clone)") {

                        card.name = "instantiated3HandCard18a";

                    } else if (card.name == "instantiated3Card18b(Clone)") {

                        card.name = "instantiated3HandCard18b";

                    } else if (card.name == "instantiated3Card18c(Clone)") {

                        card.name = "instantiated3HandCard18c";

                    } else if (card.name == "instantiated3Card19(Clone)") {

                        card.name = "instantiated3HandCard19";

                    } else if (card.name == "instantiated3Card19a(Clone)") {

                        card.name = "instantiated3HandCard19a";

                    } else if (card.name == "instantiated3Card19b(Clone)") {

                        card.name = "instantiated3HandCard19b";

                    } else if (card.name == "instantiated3Card19c(Clone)") {

                        card.name = "instantiated3HandCard19c";

                    } else if (card.name == "instantiated3Card20(Clone)") {

                        card.name = "instantiated3HandCard20";

                    } else if (card.name == "instantiated3Card20a(Clone)") {

                        card.name = "instantiated3HandCard20a";

                    } else if (card.name == "instantiated3Card20b(Clone)") {

                        card.name = "instantiated3HandCard20b";

                    } else if (card.name == "instantiated3Card20c(Clone)") {

                        card.name = "instantiated3HandCard20c";

                    } else if (card.name == "instantiated3Card21(Clone)") {

                        card.name = "instantiated3HandCard21";

                    } else if (card.name == "instantiated3Card21a(Clone)") {

                        card.name = "instantiated3HandCard21a";

                    } else if (card.name == "instantiated3Card21b(Clone)") {

                        card.name = "instantiated3HandCard21b";

                    } else if (card.name == "instantiated3Card21c(Clone)") {

                        card.name = "instantiated3HandCard21c";

                    } else if (card.name == "instantiated3Card22(Clone)") {

                        card.name = "instantiated3HandCard22";

                    } else if (card.name == "instantiated3Card22a(Clone)") {

                        card.name = "instantiated3HandCard22a";

                    } else if (card.name == "instantiated3Card22b(Clone)") {

                        card.name = "instantiated3HandCard22b";

                    } else if (card.name == "instantiated3Card22c(Clone)") {

                        card.name = "instantiated3HandCard22c";

                    } else if (card.name == "instantiated3Card23(Clone)") {

                        card.name = "instantiated3HandCard23";

                    } else if (card.name == "instantiated3Card23a(Clone)") {

                        card.name = "instantiated3HandCard23a";

                    } else if (card.name == "instantiated3Card23b(Clone)") {

                        card.name = "instantiated3HandCard23b";

                    } else if (card.name == "instantiated3Card23c(Clone)") {

                        card.name = "instantiated3HandCard23c";

                    } else if (card.name == "instantiated3Card24(Clone)") {

                        card.name = "instantiated3HandCard24";

                    } else if (card.name == "instantiated3Card24a(Clone)") {

                        card.name = "instantiated3HandCard24a";

                    } else if (card.name == "instantiated3Card24b(Clone)") {

                        card.name = "instantiated3HandCard24b";

                    } else if (card.name == "instantiated3Card24c(Clone)") {

                        card.name = "instantiated3HandCard24c";

                    } else if (card.name == "instantiated3Card25(Clone)") {

                        card.name = "instantiated3HandCard25";

                    } else if (card.name == "instantiated3Card25a(Clone)") {

                        card.name = "instantiated3HandCard25a";

                    } else if (card.name == "instantiated3Card25b(Clone)") {

                        card.name = "instantiated3HandCard25b";

                    } else if (card.name == "instantiated3Card25c(Clone)") {

                        card.name = "instantiated3HandCard25c";

                    } else if (card.name == "instantiated3Card26(Clone)") {

                        card.name = "instantiated3HandCard26";

                    } else if (card.name == "instantiated3Card26a(Clone)") {

                        card.name = "instantiated3HandCard26a";

                    } else if (card.name == "instantiated3Card26b(Clone)") {

                        card.name = "instantiated3HandCard26b";

                    } else if (card.name == "instantiated3Card26c(Clone)") {

                        card.name = "instantiated3HandCard26c";

                    } else if (card.name == "instantiated3Card27(Clone)") {

                        card.name = "instantiated3HandCard27";

                    } else if (card.name == "instantiated3Card27a(Clone)") {

                        card.name = "instantiated3HandCard27a";

                    } else if (card.name == "instantiated3Card27b(Clone)") {

                        card.name = "instantiated3HandCard27b";

                    } else if (card.name == "instantiated3Card27c(Clone)") {

                        card.name = "instantiated3HandCard27c";

                    } else if (card.name == "instantiated3Card28(Clone)") {

                        card.name = "instantiated3HandCard28";

                    } else if (card.name == "instantiated3Card28a(Clone)") {

                        card.name = "instantiated3HandCard28a";

                    } else if (card.name == "instantiated3Card28b(Clone)") {

                        card.name = "instantiated3HandCard28b";

                    } else if (card.name == "instantiated3Card28c(Clone)") {

                        card.name = "instantiated3HandCard28c";

                    } else if (card.name == "instantiated3Card29(Clone)") {

                        card.name = "instantiated3HandCard29";

                    } else if (card.name == "instantiated3Card29a(Clone)") {

                        card.name = "instantiated3HandCard29a";

                    } else if (card.name == "instantiated3Card29b(Clone)") {

                        card.name = "instantiated3HandCard29b";

                    } else if (card.name == "instantiated3Card29c(Clone)") {

                        card.name = "instantiated3HandCard29c";

                    } else if (card.name == "instantiated3Card30(Clone)") {

                        card.name = "instantiated3HandCard30";

                    } else if (card.name == "instantiated3Card30a(Clone)") {

                        card.name = "instantiated3HandCard30a";

                    } else if (card.name == "instantiated3Card30b(Clone)") {

                        card.name = "instantiated3HandCard30b";

                    } else if (card.name == "instantiated3Card30c(Clone)") {

                        card.name = "instantiated3HandCard30c";

                    } else if (card.name == "instantiated3Card31(Clone)") {

                        card.name = "instantiated3HandCard31";

                    } else if (card.name == "instantiated3Card31a(Clone)") {

                        card.name = "instantiated3HandCard31a";

                    } else if (card.name == "instantiated3Card31b(Clone)") {

                        card.name = "instantiated3HandCard31b";

                    } else if (card.name == "instantiated3Card31c(Clone)") {

                        card.name = "instantiated3HandCard31c";

                    } else if (card.name == "instantiated3Card32(Clone)") {

                        card.name = "instantiated3HandCard32";

                    } else if (card.name == "instantiated3Card32a(Clone)") {

                        card.name = "instantiated3HandCard32a";

                    } else if (card.name == "instantiated3Card32b(Clone)") {

                        card.name = "instantiated3HandCard32b";

                    } else if (card.name == "instantiated3Card32c(Clone)") {

                        card.name = "instantiated3HandCard32c";

                    } else if (card.name == "instantiated3Card33(Clone)") {

                        card.name = "instantiated3HandCard33";

                    } else if (card.name == "instantiated3Card33a(Clone)") {

                        card.name = "instantiated3HandCard33a";

                    } else if (card.name == "instantiated3Card33b(Clone)") {

                        card.name = "instantiated3HandCard33b";

                    } else if (card.name == "instantiated3Card33c(Clone)") {

                        card.name = "instantiated3HandCard33c";

                    } else if (card.name == "instantiated3Card34(Clone)") {

                        card.name = "instantiated3HandCard34";

                    } else if (card.name == "instantiated3Card34a(Clone)") {

                        card.name = "instantiated3HandCard34a";

                    } else if (card.name == "instantiated3Card34b(Clone)") {

                        card.name = "instantiated3HandCard34b";

                    } else if (card.name == "instantiated3Card34c(Clone)") {

                        card.name = "instantiated3HandCard34c";

                    } else if (card.name == "instantiated3Card35(Clone)") {

                        card.name = "instantiated3HandCard35";

                    } else if (card.name == "instantiated3Card35a(Clone)") {

                        card.name = "instantiated3HandCard35a";

                    } else if (card.name == "instantiated3Card35b(Clone)") {

                        card.name = "instantiated3HandCard35b";

                    } else if (card.name == "instantiated3Card35c(Clone)") {

                        card.name = "instantiated3HandCard35c";

                    } else if (card.name == "instantiated3Card36(Clone)") {

                        card.name = "instantiated3HandCard36";

                    } else if (card.name == "instantiated3Card36a(Clone)") {

                        card.name = "instantiated3HandCard36a";

                    } else if (card.name == "instantiated3Card36b(Clone)") {

                        card.name = "instantiated3HandCard36b";

                    } else if (card.name == "instantiated3Card36c(Clone)") {

                        card.name = "instantiated3HandCard36c";

                    } else if (card.name == "instantiated3Card37(Clone)") {

                        card.name = "instantiated3HandCard37";

                    } else if (card.name == "instantiated3Card37a(Clone)") {

                        card.name = "instantiated3HandCard37a";

                    } else if (card.name == "instantiated3Card37b(Clone)") {

                        card.name = "instantiated3HandCard37b";

                    } else if (card.name == "instantiated3Card37c(Clone)") {

                        card.name = "instantiated3HandCard37c";

                    } else if (card.name == "instantiated3Card38(Clone)") {

                        card.name = "instantiated3HandCard38";

                    } else if (card.name == "instantiated3Card38a(Clone)") {

                        card.name = "instantiated3HandCard38a";

                    } else if (card.name == "instantiated3Card38b(Clone)") {

                        card.name = "instantiated3HandCard38b";

                    } else if (card.name == "instantiated3Card38c(Clone)") {

                        card.name = "instantiated3HandCard38c";

                    } else if (card.name == "instantiated3Card39(Clone)") {

                        card.name = "instantiated3HandCard39";

                    } else if (card.name == "instantiated3Card39a(Clone)") {

                        card.name = "instantiated3HandCard39a";

                    } else if (card.name == "instantiated3Card39b(Clone)") {

                        card.name = "instantiated3HandCard39b";

                    } else if (card.name == "instantiated3Card39c(Clone)") {

                        card.name = "instantiated3HandCard39c";

                    } else if (card.name == "instantiated3Card40(Clone)") {

                        card.name = "instantiated3HandCard40";

                    } else if (card.name == "instantiated3Card40a(Clone)") {

                        card.name = "instantiated3HandCard40a";

                    } else if (card.name == "instantiated3Card40b(Clone)") {

                        card.name = "instantiated3HandCard40b";

                    } else if (card.name == "instantiated3Card40c(Clone)") {

                        card.name = "instantiated3HandCard40c";

                    } else if (card.name == "instantiated3Card41(Clone)") {

                        card.name = "instantiated3HandCard41";

                    } else if (card.name == "instantiated3Card41a(Clone)") {

                        card.name = "instantiated3HandCard41a";

                    } else if (card.name == "instantiated3Card41b(Clone)") {

                        card.name = "instantiated3HandCard41b";

                    } else if (card.name == "instantiated3Card41c(Clone)") {

                        card.name = "instantiated3HandCard41c";

                    } else if (card.name == "instantiated3Card42(Clone)") {

                        card.name = "instantiated3HandCard42";

                    } else if (card.name == "instantiated3Card42a(Clone)") {

                        card.name = "instantiated3HandCard42a";

                    } else if (card.name == "instantiated3Card42b(Clone)") {

                        card.name = "instantiated3HandCard42b";

                    } else if (card.name == "instantiated3Card42c(Clone)") {

                        card.name = "instantiated3HandCard42c";

                    } else if (card.name == "instantiated3Card43(Clone)") {

                        card.name = "instantiated3HandCard43";

                    } else if (card.name == "instantiated3Card43a(Clone)") {

                        card.name = "instantiated3HandCard43a";

                    } else if (card.name == "instantiated3Card43b(Clone)") {

                        card.name = "instantiated3HandCard43b";

                    } else if (card.name == "instantiated3Card43c(Clone)") {

                        card.name = "instantiated3HandCard43c";

                    } else if (card.name == "instantiated3Card44(Clone)") {

                        card.name = "instantiated3HandCard44";

                    } else if (card.name == "instantiated3Card44a(Clone)") {

                        card.name = "instantiated3HandCard44a";

                    } else if (card.name == "instantiated3Card44b(Clone)") {

                        card.name = "instantiated3HandCard44b";

                    } else if (card.name == "instantiated3Card44c(Clone)") {

                        card.name = "instantiated3HandCard44c";

                    } else if (card.name == "instantiated3Card45(Clone)") {

                        card.name = "instantiated3HandCard45";

                    } else if (card.name == "instantiated3Card45a(Clone)") {

                        card.name = "instantiated3HandCard45a";

                    } else if (card.name == "instantiated3Card45b(Clone)") {

                        card.name = "instantiated3HandCard45b";

                    } else if (card.name == "instantiated3Card45c(Clone)") {

                        card.name = "instantiated3HandCard45c";

                    } else if (card.name == "instantiated3Card46(Clone)") {

                        card.name = "instantiated3HandCard46";

                    } else if (card.name == "instantiated3Card46a(Clone)") {

                        card.name = "instantiated3HandCard46a";

                    } else if (card.name == "instantiated3Card46b(Clone)") {

                        card.name = "instantiated3HandCard46b";

                    } else if (card.name == "instantiated3Card46c(Clone)") {

                        card.name = "instantiated3HandCard46c";

                    } else if (card.name == "instantiated3Card47(Clone)") {

                        card.name = "instantiated3HandCard47";

                    } else if (card.name == "instantiated3Card47a(Clone)") {

                        card.name = "instantiated3HandCard47a";

                    } else if (card.name == "instantiated3Card47b(Clone)") {

                        card.name = "instantiated3HandCard47b";

                    } else if (card.name == "instantiated3Card47c(Clone)") {

                        card.name = "instantiated3HandCard47c";

                    } else if (card.name == "instantiated3Card48(Clone)") {

                        card.name = "instantiated3HandCard48";

                    } else if (card.name == "instantiated3Card48a(Clone)") {

                        card.name = "instantiated3HandCard48a";

                    } else if (card.name == "instantiated3Card48b(Clone)") {

                        card.name = "instantiated3HandCard48b";

                    } else if (card.name == "instantiated3Card48c(Clone)") {

                        card.name = "instantiated3HandCard48c";

                    } else if (card.name == "instantiated3Card49(Clone)") {

                        card.name = "instantiated3HandCard49";

                    } else if (card.name == "instantiated3Card49a(Clone)") {

                        card.name = "instantiated3HandCard49a";

                    } else if (card.name == "instantiated3Card49b(Clone)") {

                        card.name = "instantiated3HandCard49b";

                    } else if (card.name == "instantiated3Card49c(Clone)") {

                        card.name = "instantiated3HandCard49c";

                    } else if (card.name == "instantiated3Card50(Clone)") {

                        card.name = "instantiated3HandCard50";

                    } else if (card.name == "instantiated3Card50a(Clone)") {

                        card.name = "instantiated3HandCard50a";

                    } else if (card.name == "instantiated3Card50b(Clone)") {

                        card.name = "instantiated3HandCard50b";

                    } else if (card.name == "instantiated3Card50c(Clone)") {

                        card.name = "instantiated3HandCard50c";

                    } else if (card.name == "instantiated3Card51(Clone)") {

                        card.name = "instantiated3HandCard51";

                    } else if (card.name == "instantiated3Card51a(Clone)") {

                        card.name = "instantiated3HandCard51a";

                    } else if (card.name == "instantiated3Card51b(Clone)") {

                        card.name = "instantiated3HandCard51b";

                    } else if (card.name == "instantiated3Card51c(Clone)") {

                        card.name = "instantiated3HandCard51c";

                    } else if (card.name == "instantiated3Card52(Clone)") {

                        card.name = "instantiated3HandCard52";

                    } else if (card.name == "instantiated3Card52a(Clone)") {

                        card.name = "instantiated3HandCard52a";

                    } else if (card.name == "instantiated3Card52b(Clone)") {

                        card.name = "instantiated3HandCard52b";

                    } else if (card.name == "instantiated3Card52c(Clone)") {

                        card.name = "instantiated3HandCard52c";

                    } else if (card.name == "instantiated3Card53(Clone)") {

                        card.name = "instantiated3HandCard53";

                    } else if (card.name == "instantiated3Card53a(Clone)") {

                        card.name = "instantiated3HandCard53a";

                    } else if (card.name == "instantiated3Card53b(Clone)") {

                        card.name = "instantiated3HandCard53b";

                    } else if (card.name == "instantiated3Card53c(Clone)") {

                        card.name = "instantiated3HandCard53c";

                    } else if (card.name == "instantiated3Card54(Clone)") {

                        card.name = "instantiated3HandCard54";

                    } else if (card.name == "instantiated3Card54a(Clone)") {

                        card.name = "instantiated3HandCard54a";

                    } else if (card.name == "instantiated3Card54b(Clone)") {

                        card.name = "instantiated3HandCard54b";

                    } else if (card.name == "instantiated3Card54c(Clone)") {

                        card.name = "instantiated3HandCard54c";

                    } else if (card.name == "instantiated3Card55(Clone)") {

                        card.name = "instantiated3HandCard55";

                    } else if (card.name == "instantiated3Card55a(Clone)") {

                        card.name = "instantiated3HandCard55a";

                    } else if (card.name == "instantiated3Card55b(Clone)") {

                        card.name = "instantiated3HandCard55b";

                    } else if (card.name == "instantiated3Card55c(Clone)") {

                        card.name = "instantiated3HandCard55c";

                    } else if (card.name == "instantiated3Card56(Clone)") {

                        card.name = "instantiated3HandCard56";

                    } else if (card.name == "instantiated3Card56a(Clone)") {

                        card.name = "instantiated3HandCard56a";

                    } else if (card.name == "instantiated3Card56b(Clone)") {

                        card.name = "instantiated3HandCard56b";

                    } else if (card.name == "instantiated3Card56c(Clone)") {

                        card.name = "instantiated3HandCard56c";

                    } else if (card.name == "instantiated3Card57(Clone)") {

                        card.name = "instantiated3HandCard57";

                    } else if (card.name == "instantiated3Card57a(Clone)") {

                        card.name = "instantiated3HandCard57a";

                    } else if (card.name == "instantiated3Card57b(Clone)") {

                        card.name = "instantiated3HandCard57b";

                    } else if (card.name == "instantiated3Card57c(Clone)") {

                        card.name = "instantiated3HandCard57c";

                    } else if (card.name == "instantiated3Card58(Clone)") {

                        card.name = "instantiated3HandCard58";

                    } else if (card.name == "instantiated3Card58a(Clone)") {

                        card.name = "instantiated3HandCard58a";

                    } else if (card.name == "instantiated3Card58b(Clone)") {

                        card.name = "instantiated3HandCard58b";

                    } else if (card.name == "instantiated3Card58c(Clone)") {

                        card.name = "instantiated3HandCard58c";

                    } else if (card.name == "instantiated3Card59(Clone)") {

                        card.name = "instantiated3HandCard59";

                    } else if (card.name == "instantiated3Card59a(Clone)") {

                        card.name = "instantiated3HandCard59a";

                    } else if (card.name == "instantiated3Card59b(Clone)") {

                        card.name = "instantiated3HandCard59b";

                    } else if (card.name == "instantiated3Card59c(Clone)") {

                        card.name = "instantiated3HandCard59c";

                    } else if (card.name == "instantiated3Card60(Clone)") {

                        card.name = "instantiated3HandCard60";

                    } else if (card.name == "instantiated3Card60a(Clone)") {

                        card.name = "instantiated3HandCard60a";

                    } else if (card.name == "instantiated3Card60b(Clone)") {

                        card.name = "instantiated3HandCard60b";

                    } else if (card.name == "instantiated3Card60c(Clone)") {

                        card.name = "instantiated3HandCard60c";
                    }

                    instances6M++;

                }

            }

            if (player1DeckSlot7.transform.childCount == 0) {

                while (instances7M < NumberOfCards) {

                    GameObject card = Instantiate(playCardsDeck3[UnityEngine.Random.Range(0, playCardsDeck3.Count)], player1DeckSlot7.transform.position, player1DeckSlot7.transform.rotation) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.transform.parent = player1DeckSlot7.transform;

                    if (card.name == "instantiated3Card1(Clone)") {

                        card.name = "instantiated3HandCard1";

                    } else if (card.name == "instantiated3Card1a(Clone)") {

                        card.name = "instantiated3HandCard1a";

                    } else if (card.name == "instantiated3Card1b(Clone)") {

                        card.name = "instantiated3HandCard1b";

                    } else if (card.name == "instantiated3Card1c(Clone)") {

                        card.name = "instantiated3HandCard1c";

                    } else if (card.name == "instantiated3Card2(Clone)") {

                        card.name = "instantiated3HandCard2";

                    } else if (card.name == "instantiated3Card2a(Clone)") {

                        card.name = "instantiated3HandCard2a";

                    } else if (card.name == "instantiated3Card2b(Clone)") {

                        card.name = "instantiated3HandCard2b";

                    } else if (card.name == "instantiated3Card2c(Clone)") {

                        card.name = "instantiated3HandCard2c";

                    } else if (card.name == "instantiated3Card3(Clone)") {

                        card.name = "instantiated3HandCard3";

                    } else if (card.name == "instantiated3Card3a(Clone)") {

                        card.name = "instantiated3HandCard3a";

                    } else if (card.name == "instantiated3Card3b(Clone)") {

                        card.name = "instantiated3HandCard3b";

                    } else if (card.name == "instantiated3Card3c(Clone)") {

                        card.name = "instantiated3HandCard3c";

                    } else if (card.name == "instantiated3Card4(Clone)") {

                        card.name = "instantiated3HandCard4";

                    } else if (card.name == "instantiated3Card4a(Clone)") {

                        card.name = "instantiated3HandCard4a";

                    } else if (card.name == "instantiated3Card4b(Clone)") {

                        card.name = "instantiated3HandCard4b";

                    } else if (card.name == "instantiated3Card4c(Clone)") {

                        card.name = "instantiated3HandCard4c";

                    } else if (card.name == "instantiated3Card5(Clone)") {

                        card.name = "instantiated3HandCard5";

                    } else if (card.name == "instantiated3Card5a(Clone)") {

                        card.name = "instantiated3HandCard5a";

                    } else if (card.name == "instantiated3Card5b(Clone)") {

                        card.name = "instantiated3HandCard5b";

                    } else if (card.name == "instantiated3Card5c(Clone)") {

                        card.name = "instantiated3HandCard5c";

                    } else if (card.name == "instantiated3Card6(Clone)") {

                        card.name = "instantiated3HandCard6";

                    } else if (card.name == "instantiated3Card6a(Clone)") {

                        card.name = "instantiated3HandCard6a";

                    } else if (card.name == "instantiated3Card6b(Clone)") {

                        card.name = "instantiated3HandCard6b";

                    } else if (card.name == "instantiated3Card6c(Clone)") {

                        card.name = "instantiated3HandCard6c";

                    } else if (card.name == "instantiated3Card7(Clone)") {

                        card.name = "instantiated3HandCard7";

                    } else if (card.name == "instantiated3Card7a(Clone)") {

                        card.name = "instantiated3HandCard7a";

                    } else if (card.name == "instantiated3Card7b(Clone)") {

                        card.name = "instantiated3HandCard7b";

                    } else if (card.name == "instantiated3Card7c(Clone)") {

                        card.name = "instantiated3HandCard7c";

                    } else if (card.name == "instantiated3Card8(Clone)") {

                        card.name = "instantiated3HandCard8";

                    } else if (card.name == "instantiated3Card8a(Clone)") {

                        card.name = "instantiated3HandCard8a";

                    } else if (card.name == "instantiated3Card8b(Clone)") {

                        card.name = "instantiated3HandCard8b";

                    } else if (card.name == "instantiated3Card8c(Clone)") {

                        card.name = "instantiated3HandCard8c";

                    } else if (card.name == "instantiated3Card9(Clone)") {

                        card.name = "instantiated3HandCard9";

                    } else if (card.name == "instantiated3Card9a(Clone)") {

                        card.name = "instantiated3HandCard9a";

                    } else if (card.name == "instantiated3Card9b(Clone)") {

                        card.name = "instantiated3HandCard9b";

                    } else if (card.name == "instantiated3Card9c(Clone)") {

                        card.name = "instantiated3HandCard9c";

                    } else if (card.name == "instantiated3Card10(Clone)") {

                        card.name = "instantiatedAICard10";

                    } else if (card.name == "instantiated3Card10a(Clone)") {

                        card.name = "instantiated3HandCard10a";

                    } else if (card.name == "instantiated3Card10b(Clone)") {

                        card.name = "instantiated3HandCard10b";

                    } else if (card.name == "instantiated3Card10c(Clone)") {

                        card.name = "instantiated3HandCard10c";

                    } else if (card.name == "instantiated3Card11(Clone)") {

                        card.name = "instantiated3HandCard11";

                    } else if (card.name == "instantiated3Card11a(Clone)") {

                        card.name = "instantiated3HandCard11a";

                    } else if (card.name == "instantiated3Card11b(Clone)") {

                        card.name = "instantiated3HandCard11b";

                    } else if (card.name == "instantiated3Card11c(Clone)") {

                        card.name = "instantiated3HandCard11c";

                    } else if (card.name == "instantiated3Card12(Clone)") {

                        card.name = "instantiated3HandCard12";

                    } else if (card.name == "instantiated3Card12a(Clone)") {

                        card.name = "instantiated3HandCard12a";

                    } else if (card.name == "instantiated3Card12b(Clone)") {

                        card.name = "instantiated3HandCard12b";

                    } else if (card.name == "instantiated3Card12c(Clone)") {

                        card.name = "instantiated3HandCard12c";

                    } else if (card.name == "instantiated3Card13(Clone)") {

                        card.name = "instantiated3HandCard13";

                    } else if (card.name == "instantiated3Card13a(Clone)") {

                        card.name = "instantiated3HandCard13a";

                    } else if (card.name == "instantiated3Card13b(Clone)") {

                        card.name = "instantiated3HandCard13b";

                    } else if (card.name == "instantiated3Card13c(Clone)") {

                        card.name = "instantiated3HandCard13c";

                    } else if (card.name == "instantiated3Card14(Clone)") {

                        card.name = "instantiated3HandCard14";

                    } else if (card.name == "instantiated3Card14a(Clone)") {

                        card.name = "instantiated3HandCard14a";

                    } else if (card.name == "instantiated3Card14b(Clone)") {

                        card.name = "instantiated3HandCard14b";

                    } else if (card.name == "instantiated3Card14c(Clone)") {

                        card.name = "instantiated3HandCard14c";

                    } else if (card.name == "instantiated3Card15(Clone)") {

                        card.name = "instantiated3HandCard15";

                    } else if (card.name == "instantiated3Card15a(Clone)") {

                        card.name = "instantiated3HandCard15a";

                    } else if (card.name == "instantiated3Card15b(Clone)") {

                        card.name = "instantiated3HandCard15b";

                    } else if (card.name == "instantiated3Card15c(Clone)") {

                        card.name = "instantiated3HandCard15c";

                    } else if (card.name == "instantiated3Card16(Clone)") {

                        card.name = "instantiated3HandCard16";

                    } else if (card.name == "instantiated3Card16a(Clone)") {

                        card.name = "instantiated3HandCard16a";

                    } else if (card.name == "instantiated3Card16b(Clone)") {

                        card.name = "instantiated3HandCard16b";

                    } else if (card.name == "instantiated3Card16c(Clone)") {

                        card.name = "instantiated3HandCard16c";

                    } else if (card.name == "instantiated3Card17(Clone)") {

                        card.name = "instantiated3HandCard17";

                    } else if (card.name == "instantiated3Card17a(Clone)") {

                        card.name = "instantiated3HandCard17a";

                    } else if (card.name == "instantiated3Card17b(Clone)") {

                        card.name = "instantiated3HandCard17b";

                    } else if (card.name == "instantiated3Card17c(Clone)") {

                        card.name = "instantiated3HandCard17c";

                    } else if (card.name == "instantiated3Card18(Clone)") {

                        card.name = "instantiated3HandCard18";

                    } else if (card.name == "instantiated3Card18a(Clone)") {

                        card.name = "instantiated3HandCard18a";

                    } else if (card.name == "instantiated3Card18b(Clone)") {

                        card.name = "instantiated3HandCard18b";

                    } else if (card.name == "instantiated3Card18c(Clone)") {

                        card.name = "instantiated3HandCard18c";

                    } else if (card.name == "instantiated3Card19(Clone)") {

                        card.name = "instantiated3HandCard19";

                    } else if (card.name == "instantiated3Card19a(Clone)") {

                        card.name = "instantiated3HandCard19a";

                    } else if (card.name == "instantiated3Card19b(Clone)") {

                        card.name = "instantiated3HandCard19b";

                    } else if (card.name == "instantiated3Card19c(Clone)") {

                        card.name = "instantiated3HandCard19c";

                    } else if (card.name == "instantiated3Card20(Clone)") {

                        card.name = "instantiated3HandCard20";

                    } else if (card.name == "instantiated3Card20a(Clone)") {

                        card.name = "instantiated3HandCard20a";

                    } else if (card.name == "instantiated3Card20b(Clone)") {

                        card.name = "instantiated3HandCard20b";

                    } else if (card.name == "instantiated3Card20c(Clone)") {

                        card.name = "instantiated3HandCard20c";

                    } else if (card.name == "instantiated3Card21(Clone)") {

                        card.name = "instantiated3HandCard21";

                    } else if (card.name == "instantiated3Card21a(Clone)") {

                        card.name = "instantiated3HandCard21a";

                    } else if (card.name == "instantiated3Card21b(Clone)") {

                        card.name = "instantiated3HandCard21b";

                    } else if (card.name == "instantiated3Card21c(Clone)") {

                        card.name = "instantiated3HandCard21c";

                    } else if (card.name == "instantiated3Card22(Clone)") {

                        card.name = "instantiated3HandCard22";

                    } else if (card.name == "instantiated3Card22a(Clone)") {

                        card.name = "instantiated3HandCard22a";

                    } else if (card.name == "instantiated3Card22b(Clone)") {

                        card.name = "instantiated3HandCard22b";

                    } else if (card.name == "instantiated3Card22c(Clone)") {

                        card.name = "instantiated3HandCard22c";

                    } else if (card.name == "instantiated3Card23(Clone)") {

                        card.name = "instantiated3HandCard23";

                    } else if (card.name == "instantiated3Card23a(Clone)") {

                        card.name = "instantiated3HandCard23a";

                    } else if (card.name == "instantiated3Card23b(Clone)") {

                        card.name = "instantiated3HandCard23b";

                    } else if (card.name == "instantiated3Card23c(Clone)") {

                        card.name = "instantiated3HandCard23c";

                    } else if (card.name == "instantiated3Card24(Clone)") {

                        card.name = "instantiated3HandCard24";

                    } else if (card.name == "instantiated3Card24a(Clone)") {

                        card.name = "instantiated3HandCard24a";

                    } else if (card.name == "instantiated3Card24b(Clone)") {

                        card.name = "instantiated3HandCard24b";

                    } else if (card.name == "instantiated3Card24c(Clone)") {

                        card.name = "instantiated3HandCard24c";

                    } else if (card.name == "instantiated3Card25(Clone)") {

                        card.name = "instantiated3HandCard25";

                    } else if (card.name == "instantiated3Card25a(Clone)") {

                        card.name = "instantiated3HandCard25a";

                    } else if (card.name == "instantiated3Card25b(Clone)") {

                        card.name = "instantiated3HandCard25b";

                    } else if (card.name == "instantiated3Card25c(Clone)") {

                        card.name = "instantiated3HandCard25c";

                    } else if (card.name == "instantiated3Card26(Clone)") {

                        card.name = "instantiated3HandCard26";

                    } else if (card.name == "instantiated3Card26a(Clone)") {

                        card.name = "instantiated3HandCard26a";

                    } else if (card.name == "instantiated3Card26b(Clone)") {

                        card.name = "instantiated3HandCard26b";

                    } else if (card.name == "instantiated3Card26c(Clone)") {

                        card.name = "instantiated3HandCard26c";

                    } else if (card.name == "instantiated3Card27(Clone)") {

                        card.name = "instantiated3HandCard27";

                    } else if (card.name == "instantiated3Card27a(Clone)") {

                        card.name = "instantiated3HandCard27a";

                    } else if (card.name == "instantiated3Card27b(Clone)") {

                        card.name = "instantiated3HandCard27b";

                    } else if (card.name == "instantiated3Card27c(Clone)") {

                        card.name = "instantiated3HandCard27c";

                    } else if (card.name == "instantiated3Card28(Clone)") {

                        card.name = "instantiated3HandCard28";

                    } else if (card.name == "instantiated3Card28a(Clone)") {

                        card.name = "instantiated3HandCard28a";

                    } else if (card.name == "instantiated3Card28b(Clone)") {

                        card.name = "instantiated3HandCard28b";

                    } else if (card.name == "instantiated3Card28c(Clone)") {

                        card.name = "instantiated3HandCard28c";

                    } else if (card.name == "instantiated3Card29(Clone)") {

                        card.name = "instantiated3HandCard29";

                    } else if (card.name == "instantiated3Card29a(Clone)") {

                        card.name = "instantiated3HandCard29a";

                    } else if (card.name == "instantiated3Card29b(Clone)") {

                        card.name = "instantiated3HandCard29b";

                    } else if (card.name == "instantiated3Card29c(Clone)") {

                        card.name = "instantiated3HandCard29c";

                    } else if (card.name == "instantiated3Card30(Clone)") {

                        card.name = "instantiated3HandCard30";

                    } else if (card.name == "instantiated3Card30a(Clone)") {

                        card.name = "instantiated3HandCard30a";

                    } else if (card.name == "instantiated3Card30b(Clone)") {

                        card.name = "instantiated3HandCard30b";

                    } else if (card.name == "instantiated3Card30c(Clone)") {

                        card.name = "instantiated3HandCard30c";

                    } else if (card.name == "instantiated3Card31(Clone)") {

                        card.name = "instantiated3HandCard31";

                    } else if (card.name == "instantiated3Card31a(Clone)") {

                        card.name = "instantiated3HandCard31a";

                    } else if (card.name == "instantiated3Card31b(Clone)") {

                        card.name = "instantiated3HandCard31b";

                    } else if (card.name == "instantiated3Card31c(Clone)") {

                        card.name = "instantiated3HandCard31c";

                    } else if (card.name == "instantiated3Card32(Clone)") {

                        card.name = "instantiated3HandCard32";

                    } else if (card.name == "instantiated3Card32a(Clone)") {

                        card.name = "instantiated3HandCard32a";

                    } else if (card.name == "instantiated3Card32b(Clone)") {

                        card.name = "instantiated3HandCard32b";

                    } else if (card.name == "instantiated3Card32c(Clone)") {

                        card.name = "instantiated3HandCard32c";

                    } else if (card.name == "instantiated3Card33(Clone)") {

                        card.name = "instantiated3HandCard33";

                    } else if (card.name == "instantiated3Card33a(Clone)") {

                        card.name = "instantiated3HandCard33a";

                    } else if (card.name == "instantiated3Card33b(Clone)") {

                        card.name = "instantiated3HandCard33b";

                    } else if (card.name == "instantiated3Card33c(Clone)") {

                        card.name = "instantiated3HandCard33c";

                    } else if (card.name == "instantiated3Card34(Clone)") {

                        card.name = "instantiated3HandCard34";

                    } else if (card.name == "instantiated3Card34a(Clone)") {

                        card.name = "instantiated3HandCard34a";

                    } else if (card.name == "instantiated3Card34b(Clone)") {

                        card.name = "instantiated3HandCard34b";

                    } else if (card.name == "instantiated3Card34c(Clone)") {

                        card.name = "instantiated3HandCard34c";

                    } else if (card.name == "instantiated3Card35(Clone)") {

                        card.name = "instantiated3HandCard35";

                    } else if (card.name == "instantiated3Card35a(Clone)") {

                        card.name = "instantiated3HandCard35a";

                    } else if (card.name == "instantiated3Card35b(Clone)") {

                        card.name = "instantiated3HandCard35b";

                    } else if (card.name == "instantiated3Card35c(Clone)") {

                        card.name = "instantiated3HandCard35c";

                    } else if (card.name == "instantiated3Card36(Clone)") {

                        card.name = "instantiated3HandCard36";

                    } else if (card.name == "instantiated3Card36a(Clone)") {

                        card.name = "instantiated3HandCard36a";

                    } else if (card.name == "instantiated3Card36b(Clone)") {

                        card.name = "instantiated3HandCard36b";

                    } else if (card.name == "instantiated3Card36c(Clone)") {

                        card.name = "instantiated3HandCard36c";

                    } else if (card.name == "instantiated3Card37(Clone)") {

                        card.name = "instantiated3HandCard37";

                    } else if (card.name == "instantiated3Card37a(Clone)") {

                        card.name = "instantiated3HandCard37a";

                    } else if (card.name == "instantiated3Card37b(Clone)") {

                        card.name = "instantiated3HandCard37b";

                    } else if (card.name == "instantiated3Card37c(Clone)") {

                        card.name = "instantiated3HandCard37c";

                    } else if (card.name == "instantiated3Card38(Clone)") {

                        card.name = "instantiated3HandCard38";

                    } else if (card.name == "instantiated3Card38a(Clone)") {

                        card.name = "instantiated3HandCard38a";

                    } else if (card.name == "instantiated3Card38b(Clone)") {

                        card.name = "instantiated3HandCard38b";

                    } else if (card.name == "instantiated3Card38c(Clone)") {

                        card.name = "instantiated3HandCard38c";

                    } else if (card.name == "instantiated3Card39(Clone)") {

                        card.name = "instantiated3HandCard39";

                    } else if (card.name == "instantiated3Card39a(Clone)") {

                        card.name = "instantiated3HandCard39a";

                    } else if (card.name == "instantiated3Card39b(Clone)") {

                        card.name = "instantiated3HandCard39b";

                    } else if (card.name == "instantiated3Card39c(Clone)") {

                        card.name = "instantiated3HandCard39c";

                    } else if (card.name == "instantiated3Card40(Clone)") {

                        card.name = "instantiated3HandCard40";

                    } else if (card.name == "instantiated3Card40a(Clone)") {

                        card.name = "instantiated3HandCard40a";

                    } else if (card.name == "instantiated3Card40b(Clone)") {

                        card.name = "instantiated3HandCard40b";

                    } else if (card.name == "instantiated3Card40c(Clone)") {

                        card.name = "instantiated3HandCard40c";

                    } else if (card.name == "instantiated3Card41(Clone)") {

                        card.name = "instantiated3HandCard41";

                    } else if (card.name == "instantiated3Card41a(Clone)") {

                        card.name = "instantiated3HandCard41a";

                    } else if (card.name == "instantiated3Card41b(Clone)") {

                        card.name = "instantiated3HandCard41b";

                    } else if (card.name == "instantiated3Card41c(Clone)") {

                        card.name = "instantiated3HandCard41c";

                    } else if (card.name == "instantiated3Card42(Clone)") {

                        card.name = "instantiated3HandCard42";

                    } else if (card.name == "instantiated3Card42a(Clone)") {

                        card.name = "instantiated3HandCard42a";

                    } else if (card.name == "instantiated3Card42b(Clone)") {

                        card.name = "instantiated3HandCard42b";

                    } else if (card.name == "instantiated3Card42c(Clone)") {

                        card.name = "instantiated3HandCard42c";

                    } else if (card.name == "instantiated3Card43(Clone)") {

                        card.name = "instantiated3HandCard43";

                    } else if (card.name == "instantiated3Card43a(Clone)") {

                        card.name = "instantiated3HandCard43a";

                    } else if (card.name == "instantiated3Card43b(Clone)") {

                        card.name = "instantiated3HandCard43b";

                    } else if (card.name == "instantiated3Card43c(Clone)") {

                        card.name = "instantiated3HandCard43c";

                    } else if (card.name == "instantiated3Card44(Clone)") {

                        card.name = "instantiated3HandCard44";

                    } else if (card.name == "instantiated3Card44a(Clone)") {

                        card.name = "instantiated3HandCard44a";

                    } else if (card.name == "instantiated3Card44b(Clone)") {

                        card.name = "instantiated3HandCard44b";

                    } else if (card.name == "instantiated3Card44c(Clone)") {

                        card.name = "instantiated3HandCard44c";

                    } else if (card.name == "instantiated3Card45(Clone)") {

                        card.name = "instantiated3HandCard45";

                    } else if (card.name == "instantiated3Card45a(Clone)") {

                        card.name = "instantiated3HandCard45a";

                    } else if (card.name == "instantiated3Card45b(Clone)") {

                        card.name = "instantiated3HandCard45b";

                    } else if (card.name == "instantiated3Card45c(Clone)") {

                        card.name = "instantiated3HandCard45c";

                    } else if (card.name == "instantiated3Card46(Clone)") {

                        card.name = "instantiated3HandCard46";

                    } else if (card.name == "instantiated3Card46a(Clone)") {

                        card.name = "instantiated3HandCard46a";

                    } else if (card.name == "instantiated3Card46b(Clone)") {

                        card.name = "instantiated3HandCard46b";

                    } else if (card.name == "instantiated3Card46c(Clone)") {

                        card.name = "instantiated3HandCard46c";

                    } else if (card.name == "instantiated3Card47(Clone)") {

                        card.name = "instantiated3HandCard47";

                    } else if (card.name == "instantiated3Card47a(Clone)") {

                        card.name = "instantiated3HandCard47a";

                    } else if (card.name == "instantiated3Card47b(Clone)") {

                        card.name = "instantiated3HandCard47b";

                    } else if (card.name == "instantiated3Card47c(Clone)") {

                        card.name = "instantiated3HandCard47c";

                    } else if (card.name == "instantiated3Card48(Clone)") {

                        card.name = "instantiated3HandCard48";

                    } else if (card.name == "instantiated3Card48a(Clone)") {

                        card.name = "instantiated3HandCard48a";

                    } else if (card.name == "instantiated3Card48b(Clone)") {

                        card.name = "instantiated3HandCard48b";

                    } else if (card.name == "instantiated3Card48c(Clone)") {

                        card.name = "instantiated3HandCard48c";

                    } else if (card.name == "instantiated3Card49(Clone)") {

                        card.name = "instantiated3HandCard49";

                    } else if (card.name == "instantiated3Card49a(Clone)") {

                        card.name = "instantiated3HandCard49a";

                    } else if (card.name == "instantiated3Card49b(Clone)") {

                        card.name = "instantiated3HandCard49b";

                    } else if (card.name == "instantiated3Card49c(Clone)") {

                        card.name = "instantiated3HandCard49c";

                    } else if (card.name == "instantiated3Card50(Clone)") {

                        card.name = "instantiated3HandCard50";

                    } else if (card.name == "instantiated3Card50a(Clone)") {

                        card.name = "instantiated3HandCard50a";

                    } else if (card.name == "instantiated3Card50b(Clone)") {

                        card.name = "instantiated3HandCard50b";

                    } else if (card.name == "instantiated3Card50c(Clone)") {

                        card.name = "instantiated3HandCard50c";

                    } else if (card.name == "instantiated3Card51(Clone)") {

                        card.name = "instantiated3HandCard51";

                    } else if (card.name == "instantiated3Card51a(Clone)") {

                        card.name = "instantiated3HandCard51a";

                    } else if (card.name == "instantiated3Card51b(Clone)") {

                        card.name = "instantiated3HandCard51b";

                    } else if (card.name == "instantiated3Card51c(Clone)") {

                        card.name = "instantiated3HandCard51c";

                    } else if (card.name == "instantiated3Card52(Clone)") {

                        card.name = "instantiated3HandCard52";

                    } else if (card.name == "instantiated3Card52a(Clone)") {

                        card.name = "instantiated3HandCard52a";

                    } else if (card.name == "instantiated3Card52b(Clone)") {

                        card.name = "instantiated3HandCard52b";

                    } else if (card.name == "instantiated3Card52c(Clone)") {

                        card.name = "instantiated3HandCard52c";

                    } else if (card.name == "instantiated3Card53(Clone)") {

                        card.name = "instantiated3HandCard53";

                    } else if (card.name == "instantiated3Card53a(Clone)") {

                        card.name = "instantiated3HandCard53a";

                    } else if (card.name == "instantiated3Card53b(Clone)") {

                        card.name = "instantiated3HandCard53b";

                    } else if (card.name == "instantiated3Card53c(Clone)") {

                        card.name = "instantiated3HandCard53c";

                    } else if (card.name == "instantiated3Card54(Clone)") {

                        card.name = "instantiated3HandCard54";

                    } else if (card.name == "instantiated3Card54a(Clone)") {

                        card.name = "instantiated3HandCard54a";

                    } else if (card.name == "instantiated3Card54b(Clone)") {

                        card.name = "instantiated3HandCard54b";

                    } else if (card.name == "instantiated3Card54c(Clone)") {

                        card.name = "instantiated3HandCard54c";

                    } else if (card.name == "instantiated3Card55(Clone)") {

                        card.name = "instantiated3HandCard55";

                    } else if (card.name == "instantiated3Card55a(Clone)") {

                        card.name = "instantiated3HandCard55a";

                    } else if (card.name == "instantiated3Card55b(Clone)") {

                        card.name = "instantiated3HandCard55b";

                    } else if (card.name == "instantiated3Card55c(Clone)") {

                        card.name = "instantiated3HandCard55c";

                    } else if (card.name == "instantiated3Card56(Clone)") {

                        card.name = "instantiated3HandCard56";

                    } else if (card.name == "instantiated3Card56a(Clone)") {

                        card.name = "instantiated3HandCard56a";

                    } else if (card.name == "instantiated3Card56b(Clone)") {

                        card.name = "instantiated3HandCard56b";

                    } else if (card.name == "instantiated3Card56c(Clone)") {

                        card.name = "instantiated3HandCard56c";

                    } else if (card.name == "instantiated3Card57(Clone)") {

                        card.name = "instantiated3HandCard57";

                    } else if (card.name == "instantiated3Card57a(Clone)") {

                        card.name = "instantiated3HandCard57a";

                    } else if (card.name == "instantiated3Card57b(Clone)") {

                        card.name = "instantiated3HandCard57b";

                    } else if (card.name == "instantiated3Card57c(Clone)") {

                        card.name = "instantiated3HandCard57c";

                    } else if (card.name == "instantiated3Card58(Clone)") {

                        card.name = "instantiated3HandCard58";

                    } else if (card.name == "instantiated3Card58a(Clone)") {

                        card.name = "instantiated3HandCard58a";

                    } else if (card.name == "instantiated3Card58b(Clone)") {

                        card.name = "instantiated3HandCard58b";

                    } else if (card.name == "instantiated3Card58c(Clone)") {

                        card.name = "instantiated3HandCard58c";

                    } else if (card.name == "instantiated3Card59(Clone)") {

                        card.name = "instantiated3HandCard59";

                    } else if (card.name == "instantiated3Card59a(Clone)") {

                        card.name = "instantiated3HandCard59a";

                    } else if (card.name == "instantiated3Card59b(Clone)") {

                        card.name = "instantiated3HandCard59b";

                    } else if (card.name == "instantiated3Card59c(Clone)") {

                        card.name = "instantiated3HandCard59c";

                    } else if (card.name == "instantiated3Card60(Clone)") {

                        card.name = "instantiated3HandCard60";

                    } else if (card.name == "instantiated3Card60a(Clone)") {

                        card.name = "instantiated3HandCard60a";

                    } else if (card.name == "instantiated3Card60b(Clone)") {

                        card.name = "instantiated3HandCard60b";

                    } else if (card.name == "instantiated3Card60c(Clone)") {

                        card.name = "instantiated3HandCard60c";
                    }

                    instances7M++;

                }

            }

            if (player1DeckSlot8.transform.childCount == 0) {

                while (instances8M < NumberOfCards) {

                    GameObject card = Instantiate(playCardsDeck3[UnityEngine.Random.Range(0, playCardsDeck3.Count)], player1DeckSlot8.transform.position, player1DeckSlot8.transform.rotation) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.transform.parent = player1DeckSlot8.transform;

                    if (card.name == "instantiated3Card1(Clone)") {

                        card.name = "instantiated3HandCard1";

                    } else if (card.name == "instantiated3Card1a(Clone)") {

                        card.name = "instantiated3HandCard1a";

                    } else if (card.name == "instantiated3Card1b(Clone)") {

                        card.name = "instantiated3HandCard1b";

                    } else if (card.name == "instantiated3Card1c(Clone)") {

                        card.name = "instantiated3HandCard1c";

                    } else if (card.name == "instantiated3Card2(Clone)") {

                        card.name = "instantiated3HandCard2";

                    } else if (card.name == "instantiated3Card2a(Clone)") {

                        card.name = "instantiated3HandCard2a";

                    } else if (card.name == "instantiated3Card2b(Clone)") {

                        card.name = "instantiated3HandCard2b";

                    } else if (card.name == "instantiated3Card2c(Clone)") {

                        card.name = "instantiated3HandCard2c";

                    } else if (card.name == "instantiated3Card3(Clone)") {

                        card.name = "instantiated3HandCard3";

                    } else if (card.name == "instantiated3Card3a(Clone)") {

                        card.name = "instantiated3HandCard3a";

                    } else if (card.name == "instantiated3Card3b(Clone)") {

                        card.name = "instantiated3HandCard3b";

                    } else if (card.name == "instantiated3Card3c(Clone)") {

                        card.name = "instantiated3HandCard3c";

                    } else if (card.name == "instantiated3Card4(Clone)") {

                        card.name = "instantiated3HandCard4";

                    } else if (card.name == "instantiated3Card4a(Clone)") {

                        card.name = "instantiated3HandCard4a";

                    } else if (card.name == "instantiated3Card4b(Clone)") {

                        card.name = "instantiated3HandCard4b";

                    } else if (card.name == "instantiated3Card4c(Clone)") {

                        card.name = "instantiated3HandCard4c";

                    } else if (card.name == "instantiated3Card5(Clone)") {

                        card.name = "instantiated3HandCard5";

                    } else if (card.name == "instantiated3Card5a(Clone)") {

                        card.name = "instantiated3HandCard5a";

                    } else if (card.name == "instantiated3Card5b(Clone)") {

                        card.name = "instantiated3HandCard5b";

                    } else if (card.name == "instantiated3Card5c(Clone)") {

                        card.name = "instantiated3HandCard5c";

                    } else if (card.name == "instantiated3Card6(Clone)") {

                        card.name = "instantiated3HandCard6";

                    } else if (card.name == "instantiated3Card6a(Clone)") {

                        card.name = "instantiated3HandCard6a";

                    } else if (card.name == "instantiated3Card6b(Clone)") {

                        card.name = "instantiated3HandCard6b";

                    } else if (card.name == "instantiated3Card6c(Clone)") {

                        card.name = "instantiated3HandCard6c";

                    } else if (card.name == "instantiated3Card7(Clone)") {

                        card.name = "instantiated3HandCard7";

                    } else if (card.name == "instantiated3Card7a(Clone)") {

                        card.name = "instantiated3HandCard7a";

                    } else if (card.name == "instantiated3Card7b(Clone)") {

                        card.name = "instantiated3HandCard7b";

                    } else if (card.name == "instantiated3Card7c(Clone)") {

                        card.name = "instantiated3HandCard7c";

                    } else if (card.name == "instantiated3Card8(Clone)") {

                        card.name = "instantiated3HandCard8";

                    } else if (card.name == "instantiated3Card8a(Clone)") {

                        card.name = "instantiated3HandCard8a";

                    } else if (card.name == "instantiated3Card8b(Clone)") {

                        card.name = "instantiated3HandCard8b";

                    } else if (card.name == "instantiated3Card8c(Clone)") {

                        card.name = "instantiated3HandCard8c";

                    } else if (card.name == "instantiated3Card9(Clone)") {

                        card.name = "instantiated3HandCard9";

                    } else if (card.name == "instantiated3Card9a(Clone)") {

                        card.name = "instantiated3HandCard9a";

                    } else if (card.name == "instantiated3Card9b(Clone)") {

                        card.name = "instantiated3HandCard9b";

                    } else if (card.name == "instantiated3Card9c(Clone)") {

                        card.name = "instantiated3HandCard9c";

                    } else if (card.name == "instantiated3Card10(Clone)") {

                        card.name = "instantiatedAICard10";

                    } else if (card.name == "instantiated3Card10a(Clone)") {

                        card.name = "instantiated3HandCard10a";

                    } else if (card.name == "instantiated3Card10b(Clone)") {

                        card.name = "instantiated3HandCard10b";

                    } else if (card.name == "instantiated3Card10c(Clone)") {

                        card.name = "instantiated3HandCard10c";

                    } else if (card.name == "instantiated3Card11(Clone)") {

                        card.name = "instantiated3HandCard11";

                    } else if (card.name == "instantiated3Card11a(Clone)") {

                        card.name = "instantiated3HandCard11a";

                    } else if (card.name == "instantiated3Card11b(Clone)") {

                        card.name = "instantiated3HandCard11b";

                    } else if (card.name == "instantiated3Card11c(Clone)") {

                        card.name = "instantiated3HandCard11c";

                    } else if (card.name == "instantiated3Card12(Clone)") {

                        card.name = "instantiated3HandCard12";

                    } else if (card.name == "instantiated3Card12a(Clone)") {

                        card.name = "instantiated3HandCard12a";

                    } else if (card.name == "instantiated3Card12b(Clone)") {

                        card.name = "instantiated3HandCard12b";

                    } else if (card.name == "instantiated3Card12c(Clone)") {

                        card.name = "instantiated3HandCard12c";

                    } else if (card.name == "instantiated3Card13(Clone)") {

                        card.name = "instantiated3HandCard13";

                    } else if (card.name == "instantiated3Card13a(Clone)") {

                        card.name = "instantiated3HandCard13a";

                    } else if (card.name == "instantiated3Card13b(Clone)") {

                        card.name = "instantiated3HandCard13b";

                    } else if (card.name == "instantiated3Card13c(Clone)") {

                        card.name = "instantiated3HandCard13c";

                    } else if (card.name == "instantiated3Card14(Clone)") {

                        card.name = "instantiated3HandCard14";

                    } else if (card.name == "instantiated3Card14a(Clone)") {

                        card.name = "instantiated3HandCard14a";

                    } else if (card.name == "instantiated3Card14b(Clone)") {

                        card.name = "instantiated3HandCard14b";

                    } else if (card.name == "instantiated3Card14c(Clone)") {

                        card.name = "instantiated3HandCard14c";

                    } else if (card.name == "instantiated3Card15(Clone)") {

                        card.name = "instantiated3HandCard15";

                    } else if (card.name == "instantiated3Card15a(Clone)") {

                        card.name = "instantiated3HandCard15a";

                    } else if (card.name == "instantiated3Card15b(Clone)") {

                        card.name = "instantiated3HandCard15b";

                    } else if (card.name == "instantiated3Card15c(Clone)") {

                        card.name = "instantiated3HandCard15c";

                    } else if (card.name == "instantiated3Card16(Clone)") {

                        card.name = "instantiated3HandCard16";

                    } else if (card.name == "instantiated3Card16a(Clone)") {

                        card.name = "instantiated3HandCard16a";

                    } else if (card.name == "instantiated3Card16b(Clone)") {

                        card.name = "instantiated3HandCard16b";

                    } else if (card.name == "instantiated3Card16c(Clone)") {

                        card.name = "instantiated3HandCard16c";

                    } else if (card.name == "instantiated3Card17(Clone)") {

                        card.name = "instantiated3HandCard17";

                    } else if (card.name == "instantiated3Card17a(Clone)") {

                        card.name = "instantiated3HandCard17a";

                    } else if (card.name == "instantiated3Card17b(Clone)") {

                        card.name = "instantiated3HandCard17b";

                    } else if (card.name == "instantiated3Card17c(Clone)") {

                        card.name = "instantiated3HandCard17c";

                    } else if (card.name == "instantiated3Card18(Clone)") {

                        card.name = "instantiated3HandCard18";

                    } else if (card.name == "instantiated3Card18a(Clone)") {

                        card.name = "instantiated3HandCard18a";

                    } else if (card.name == "instantiated3Card18b(Clone)") {

                        card.name = "instantiated3HandCard18b";

                    } else if (card.name == "instantiated3Card18c(Clone)") {

                        card.name = "instantiated3HandCard18c";

                    } else if (card.name == "instantiated3Card19(Clone)") {

                        card.name = "instantiated3HandCard19";

                    } else if (card.name == "instantiated3Card19a(Clone)") {

                        card.name = "instantiated3HandCard19a";

                    } else if (card.name == "instantiated3Card19b(Clone)") {

                        card.name = "instantiated3HandCard19b";

                    } else if (card.name == "instantiated3Card19c(Clone)") {

                        card.name = "instantiated3HandCard19c";

                    } else if (card.name == "instantiated3Card20(Clone)") {

                        card.name = "instantiated3HandCard20";

                    } else if (card.name == "instantiated3Card20a(Clone)") {

                        card.name = "instantiated3HandCard20a";

                    } else if (card.name == "instantiated3Card20b(Clone)") {

                        card.name = "instantiated3HandCard20b";

                    } else if (card.name == "instantiated3Card20c(Clone)") {

                        card.name = "instantiated3HandCard20c";

                    } else if (card.name == "instantiated3Card21(Clone)") {

                        card.name = "instantiated3HandCard21";

                    } else if (card.name == "instantiated3Card21a(Clone)") {

                        card.name = "instantiated3HandCard21a";

                    } else if (card.name == "instantiated3Card21b(Clone)") {

                        card.name = "instantiated3HandCard21b";

                    } else if (card.name == "instantiated3Card21c(Clone)") {

                        card.name = "instantiated3HandCard21c";

                    } else if (card.name == "instantiated3Card22(Clone)") {

                        card.name = "instantiated3HandCard22";

                    } else if (card.name == "instantiated3Card22a(Clone)") {

                        card.name = "instantiated3HandCard22a";

                    } else if (card.name == "instantiated3Card22b(Clone)") {

                        card.name = "instantiated3HandCard22b";

                    } else if (card.name == "instantiated3Card22c(Clone)") {

                        card.name = "instantiated3HandCard22c";

                    } else if (card.name == "instantiated3Card23(Clone)") {

                        card.name = "instantiated3HandCard23";

                    } else if (card.name == "instantiated3Card23a(Clone)") {

                        card.name = "instantiated3HandCard23a";

                    } else if (card.name == "instantiated3Card23b(Clone)") {

                        card.name = "instantiated3HandCard23b";

                    } else if (card.name == "instantiated3Card23c(Clone)") {

                        card.name = "instantiated3HandCard23c";

                    } else if (card.name == "instantiated3Card24(Clone)") {

                        card.name = "instantiated3HandCard24";

                    } else if (card.name == "instantiated3Card24a(Clone)") {

                        card.name = "instantiated3HandCard24a";

                    } else if (card.name == "instantiated3Card24b(Clone)") {

                        card.name = "instantiated3HandCard24b";

                    } else if (card.name == "instantiated3Card24c(Clone)") {

                        card.name = "instantiated3HandCard24c";

                    } else if (card.name == "instantiated3Card25(Clone)") {

                        card.name = "instantiated3HandCard25";

                    } else if (card.name == "instantiated3Card25a(Clone)") {

                        card.name = "instantiated3HandCard25a";

                    } else if (card.name == "instantiated3Card25b(Clone)") {

                        card.name = "instantiated3HandCard25b";

                    } else if (card.name == "instantiated3Card25c(Clone)") {

                        card.name = "instantiated3HandCard25c";

                    } else if (card.name == "instantiated3Card26(Clone)") {

                        card.name = "instantiated3HandCard26";

                    } else if (card.name == "instantiated3Card26a(Clone)") {

                        card.name = "instantiated3HandCard26a";

                    } else if (card.name == "instantiated3Card26b(Clone)") {

                        card.name = "instantiated3HandCard26b";

                    } else if (card.name == "instantiated3Card26c(Clone)") {

                        card.name = "instantiated3HandCard26c";

                    } else if (card.name == "instantiated3Card27(Clone)") {

                        card.name = "instantiated3HandCard27";

                    } else if (card.name == "instantiated3Card27a(Clone)") {

                        card.name = "instantiated3HandCard27a";

                    } else if (card.name == "instantiated3Card27b(Clone)") {

                        card.name = "instantiated3HandCard27b";

                    } else if (card.name == "instantiated3Card27c(Clone)") {

                        card.name = "instantiated3HandCard27c";

                    } else if (card.name == "instantiated3Card28(Clone)") {

                        card.name = "instantiated3HandCard28";

                    } else if (card.name == "instantiated3Card28a(Clone)") {

                        card.name = "instantiated3HandCard28a";

                    } else if (card.name == "instantiated3Card28b(Clone)") {

                        card.name = "instantiated3HandCard28b";

                    } else if (card.name == "instantiated3Card28c(Clone)") {

                        card.name = "instantiated3HandCard28c";

                    } else if (card.name == "instantiated3Card29(Clone)") {

                        card.name = "instantiated3HandCard29";

                    } else if (card.name == "instantiated3Card29a(Clone)") {

                        card.name = "instantiated3HandCard29a";

                    } else if (card.name == "instantiated3Card29b(Clone)") {

                        card.name = "instantiated3HandCard29b";

                    } else if (card.name == "instantiated3Card29c(Clone)") {

                        card.name = "instantiated3HandCard29c";

                    } else if (card.name == "instantiated3Card30(Clone)") {

                        card.name = "instantiated3HandCard30";

                    } else if (card.name == "instantiated3Card30a(Clone)") {

                        card.name = "instantiated3HandCard30a";

                    } else if (card.name == "instantiated3Card30b(Clone)") {

                        card.name = "instantiated3HandCard30b";

                    } else if (card.name == "instantiated3Card30c(Clone)") {

                        card.name = "instantiated3HandCard30c";

                    } else if (card.name == "instantiated3Card31(Clone)") {

                        card.name = "instantiated3HandCard31";

                    } else if (card.name == "instantiated3Card31a(Clone)") {

                        card.name = "instantiated3HandCard31a";

                    } else if (card.name == "instantiated3Card31b(Clone)") {

                        card.name = "instantiated3HandCard31b";

                    } else if (card.name == "instantiated3Card31c(Clone)") {

                        card.name = "instantiated3HandCard31c";

                    } else if (card.name == "instantiated3Card32(Clone)") {

                        card.name = "instantiated3HandCard32";

                    } else if (card.name == "instantiated3Card32a(Clone)") {

                        card.name = "instantiated3HandCard32a";

                    } else if (card.name == "instantiated3Card32b(Clone)") {

                        card.name = "instantiated3HandCard32b";

                    } else if (card.name == "instantiated3Card32c(Clone)") {

                        card.name = "instantiated3HandCard32c";

                    } else if (card.name == "instantiated3Card33(Clone)") {

                        card.name = "instantiated3HandCard33";

                    } else if (card.name == "instantiated3Card33a(Clone)") {

                        card.name = "instantiated3HandCard33a";

                    } else if (card.name == "instantiated3Card33b(Clone)") {

                        card.name = "instantiated3HandCard33b";

                    } else if (card.name == "instantiated3Card33c(Clone)") {

                        card.name = "instantiated3HandCard33c";

                    } else if (card.name == "instantiated3Card34(Clone)") {

                        card.name = "instantiated3HandCard34";

                    } else if (card.name == "instantiated3Card34a(Clone)") {

                        card.name = "instantiated3HandCard34a";

                    } else if (card.name == "instantiated3Card34b(Clone)") {

                        card.name = "instantiated3HandCard34b";

                    } else if (card.name == "instantiated3Card34c(Clone)") {

                        card.name = "instantiated3HandCard34c";

                    } else if (card.name == "instantiated3Card35(Clone)") {

                        card.name = "instantiated3HandCard35";

                    } else if (card.name == "instantiated3Card35a(Clone)") {

                        card.name = "instantiated3HandCard35a";

                    } else if (card.name == "instantiated3Card35b(Clone)") {

                        card.name = "instantiated3HandCard35b";

                    } else if (card.name == "instantiated3Card35c(Clone)") {

                        card.name = "instantiated3HandCard35c";

                    } else if (card.name == "instantiated3Card36(Clone)") {

                        card.name = "instantiated3HandCard36";

                    } else if (card.name == "instantiated3Card36a(Clone)") {

                        card.name = "instantiated3HandCard36a";

                    } else if (card.name == "instantiated3Card36b(Clone)") {

                        card.name = "instantiated3HandCard36b";

                    } else if (card.name == "instantiated3Card36c(Clone)") {

                        card.name = "instantiated3HandCard36c";

                    } else if (card.name == "instantiated3Card37(Clone)") {

                        card.name = "instantiated3HandCard37";

                    } else if (card.name == "instantiated3Card37a(Clone)") {

                        card.name = "instantiated3HandCard37a";

                    } else if (card.name == "instantiated3Card37b(Clone)") {

                        card.name = "instantiated3HandCard37b";

                    } else if (card.name == "instantiated3Card37c(Clone)") {

                        card.name = "instantiated3HandCard37c";

                    } else if (card.name == "instantiated3Card38(Clone)") {

                        card.name = "instantiated3HandCard38";

                    } else if (card.name == "instantiated3Card38a(Clone)") {

                        card.name = "instantiated3HandCard38a";

                    } else if (card.name == "instantiated3Card38b(Clone)") {

                        card.name = "instantiated3HandCard38b";

                    } else if (card.name == "instantiated3Card38c(Clone)") {

                        card.name = "instantiated3HandCard38c";

                    } else if (card.name == "instantiated3Card39(Clone)") {

                        card.name = "instantiated3HandCard39";

                    } else if (card.name == "instantiated3Card39a(Clone)") {

                        card.name = "instantiated3HandCard39a";

                    } else if (card.name == "instantiated3Card39b(Clone)") {

                        card.name = "instantiated3HandCard39b";

                    } else if (card.name == "instantiated3Card39c(Clone)") {

                        card.name = "instantiated3HandCard39c";

                    } else if (card.name == "instantiated3Card40(Clone)") {

                        card.name = "instantiated3HandCard40";

                    } else if (card.name == "instantiated3Card40a(Clone)") {

                        card.name = "instantiated3HandCard40a";

                    } else if (card.name == "instantiated3Card40b(Clone)") {

                        card.name = "instantiated3HandCard40b";

                    } else if (card.name == "instantiated3Card40c(Clone)") {

                        card.name = "instantiated3HandCard40c";

                    } else if (card.name == "instantiated3Card41(Clone)") {

                        card.name = "instantiated3HandCard41";

                    } else if (card.name == "instantiated3Card41a(Clone)") {

                        card.name = "instantiated3HandCard41a";

                    } else if (card.name == "instantiated3Card41b(Clone)") {

                        card.name = "instantiated3HandCard41b";

                    } else if (card.name == "instantiated3Card41c(Clone)") {

                        card.name = "instantiated3HandCard41c";

                    } else if (card.name == "instantiated3Card42(Clone)") {

                        card.name = "instantiated3HandCard42";

                    } else if (card.name == "instantiated3Card42a(Clone)") {

                        card.name = "instantiated3HandCard42a";

                    } else if (card.name == "instantiated3Card42b(Clone)") {

                        card.name = "instantiated3HandCard42b";

                    } else if (card.name == "instantiated3Card42c(Clone)") {

                        card.name = "instantiated3HandCard42c";

                    } else if (card.name == "instantiated3Card43(Clone)") {

                        card.name = "instantiated3HandCard43";

                    } else if (card.name == "instantiated3Card43a(Clone)") {

                        card.name = "instantiated3HandCard43a";

                    } else if (card.name == "instantiated3Card43b(Clone)") {

                        card.name = "instantiated3HandCard43b";

                    } else if (card.name == "instantiated3Card43c(Clone)") {

                        card.name = "instantiated3HandCard43c";

                    } else if (card.name == "instantiated3Card44(Clone)") {

                        card.name = "instantiated3HandCard44";

                    } else if (card.name == "instantiated3Card44a(Clone)") {

                        card.name = "instantiated3HandCard44a";

                    } else if (card.name == "instantiated3Card44b(Clone)") {

                        card.name = "instantiated3HandCard44b";

                    } else if (card.name == "instantiated3Card44c(Clone)") {

                        card.name = "instantiated3HandCard44c";

                    } else if (card.name == "instantiated3Card45(Clone)") {

                        card.name = "instantiated3HandCard45";

                    } else if (card.name == "instantiated3Card45a(Clone)") {

                        card.name = "instantiated3HandCard45a";

                    } else if (card.name == "instantiated3Card45b(Clone)") {

                        card.name = "instantiated3HandCard45b";

                    } else if (card.name == "instantiated3Card45c(Clone)") {

                        card.name = "instantiated3HandCard45c";

                    } else if (card.name == "instantiated3Card46(Clone)") {

                        card.name = "instantiated3HandCard46";

                    } else if (card.name == "instantiated3Card46a(Clone)") {

                        card.name = "instantiated3HandCard46a";

                    } else if (card.name == "instantiated3Card46b(Clone)") {

                        card.name = "instantiated3HandCard46b";

                    } else if (card.name == "instantiated3Card46c(Clone)") {

                        card.name = "instantiated3HandCard46c";

                    } else if (card.name == "instantiated3Card47(Clone)") {

                        card.name = "instantiated3HandCard47";

                    } else if (card.name == "instantiated3Card47a(Clone)") {

                        card.name = "instantiated3HandCard47a";

                    } else if (card.name == "instantiated3Card47b(Clone)") {

                        card.name = "instantiated3HandCard47b";

                    } else if (card.name == "instantiated3Card47c(Clone)") {

                        card.name = "instantiated3HandCard47c";

                    } else if (card.name == "instantiated3Card48(Clone)") {

                        card.name = "instantiated3HandCard48";

                    } else if (card.name == "instantiated3Card48a(Clone)") {

                        card.name = "instantiated3HandCard48a";

                    } else if (card.name == "instantiated3Card48b(Clone)") {

                        card.name = "instantiated3HandCard48b";

                    } else if (card.name == "instantiated3Card48c(Clone)") {

                        card.name = "instantiated3HandCard48c";

                    } else if (card.name == "instantiated3Card49(Clone)") {

                        card.name = "instantiated3HandCard49";

                    } else if (card.name == "instantiated3Card49a(Clone)") {

                        card.name = "instantiated3HandCard49a";

                    } else if (card.name == "instantiated3Card49b(Clone)") {

                        card.name = "instantiated3HandCard49b";

                    } else if (card.name == "instantiated3Card49c(Clone)") {

                        card.name = "instantiated3HandCard49c";

                    } else if (card.name == "instantiated3Card50(Clone)") {

                        card.name = "instantiated3HandCard50";

                    } else if (card.name == "instantiated3Card50a(Clone)") {

                        card.name = "instantiated3HandCard50a";

                    } else if (card.name == "instantiated3Card50b(Clone)") {

                        card.name = "instantiated3HandCard50b";

                    } else if (card.name == "instantiated3Card50c(Clone)") {

                        card.name = "instantiated3HandCard50c";

                    } else if (card.name == "instantiated3Card51(Clone)") {

                        card.name = "instantiated3HandCard51";

                    } else if (card.name == "instantiated3Card51a(Clone)") {

                        card.name = "instantiated3HandCard51a";

                    } else if (card.name == "instantiated3Card51b(Clone)") {

                        card.name = "instantiated3HandCard51b";

                    } else if (card.name == "instantiated3Card51c(Clone)") {

                        card.name = "instantiated3HandCard51c";

                    } else if (card.name == "instantiated3Card52(Clone)") {

                        card.name = "instantiated3HandCard52";

                    } else if (card.name == "instantiated3Card52a(Clone)") {

                        card.name = "instantiated3HandCard52a";

                    } else if (card.name == "instantiated3Card52b(Clone)") {

                        card.name = "instantiated3HandCard52b";

                    } else if (card.name == "instantiated3Card52c(Clone)") {

                        card.name = "instantiated3HandCard52c";

                    } else if (card.name == "instantiated3Card53(Clone)") {

                        card.name = "instantiated3HandCard53";

                    } else if (card.name == "instantiated3Card53a(Clone)") {

                        card.name = "instantiated3HandCard53a";

                    } else if (card.name == "instantiated3Card53b(Clone)") {

                        card.name = "instantiated3HandCard53b";

                    } else if (card.name == "instantiated3Card53c(Clone)") {

                        card.name = "instantiated3HandCard53c";

                    } else if (card.name == "instantiated3Card54(Clone)") {

                        card.name = "instantiated3HandCard54";

                    } else if (card.name == "instantiated3Card54a(Clone)") {

                        card.name = "instantiated3HandCard54a";

                    } else if (card.name == "instantiated3Card54b(Clone)") {

                        card.name = "instantiated3HandCard54b";

                    } else if (card.name == "instantiated3Card54c(Clone)") {

                        card.name = "instantiated3HandCard54c";

                    } else if (card.name == "instantiated3Card55(Clone)") {

                        card.name = "instantiated3HandCard55";

                    } else if (card.name == "instantiated3Card55a(Clone)") {

                        card.name = "instantiated3HandCard55a";

                    } else if (card.name == "instantiated3Card55b(Clone)") {

                        card.name = "instantiated3HandCard55b";

                    } else if (card.name == "instantiated3Card55c(Clone)") {

                        card.name = "instantiated3HandCard55c";

                    } else if (card.name == "instantiated3Card56(Clone)") {

                        card.name = "instantiated3HandCard56";

                    } else if (card.name == "instantiated3Card56a(Clone)") {

                        card.name = "instantiated3HandCard56a";

                    } else if (card.name == "instantiated3Card56b(Clone)") {

                        card.name = "instantiated3HandCard56b";

                    } else if (card.name == "instantiated3Card56c(Clone)") {

                        card.name = "instantiated3HandCard56c";

                    } else if (card.name == "instantiated3Card57(Clone)") {

                        card.name = "instantiated3HandCard57";

                    } else if (card.name == "instantiated3Card57a(Clone)") {

                        card.name = "instantiated3HandCard57a";

                    } else if (card.name == "instantiated3Card57b(Clone)") {

                        card.name = "instantiated3HandCard57b";

                    } else if (card.name == "instantiated3Card57c(Clone)") {

                        card.name = "instantiated3HandCard57c";

                    } else if (card.name == "instantiated3Card58(Clone)") {

                        card.name = "instantiated3HandCard58";

                    } else if (card.name == "instantiated3Card58a(Clone)") {

                        card.name = "instantiated3HandCard58a";

                    } else if (card.name == "instantiated3Card58b(Clone)") {

                        card.name = "instantiated3HandCard58b";

                    } else if (card.name == "instantiated3Card58c(Clone)") {

                        card.name = "instantiated3HandCard58c";

                    } else if (card.name == "instantiated3Card59(Clone)") {

                        card.name = "instantiated3HandCard59";

                    } else if (card.name == "instantiated3Card59a(Clone)") {

                        card.name = "instantiated3HandCard59a";

                    } else if (card.name == "instantiated3Card59b(Clone)") {

                        card.name = "instantiated3HandCard59b";

                    } else if (card.name == "instantiated3Card59c(Clone)") {

                        card.name = "instantiated3HandCard59c";

                    } else if (card.name == "instantiated3Card60(Clone)") {

                        card.name = "instantiated3HandCard60";

                    } else if (card.name == "instantiated3Card60a(Clone)") {

                        card.name = "instantiated3HandCard60a";

                    } else if (card.name == "instantiated3Card60b(Clone)") {

                        card.name = "instantiated3HandCard60b";

                    } else if (card.name == "instantiated3Card60c(Clone)") {

                        card.name = "instantiated3HandCard60c";
                    }

                    instances8M++;

                }

            }

            if (player1DeckSlot9.transform.childCount == 0) {

                while (instances9M < NumberOfCards) {

                    GameObject card = Instantiate(playCardsDeck3[UnityEngine.Random.Range(0, playCardsDeck3.Count)], player1DeckSlot9.transform.position, player1DeckSlot9.transform.rotation) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.transform.parent = player1DeckSlot9.transform;

                    if (card.name == "instantiated3Card1(Clone)") {

                        card.name = "instantiated3HandCard1";

                    } else if (card.name == "instantiated3Card1a(Clone)") {

                        card.name = "instantiated3HandCard1a";

                    } else if (card.name == "instantiated3Card1b(Clone)") {

                        card.name = "instantiated3HandCard1b";

                    } else if (card.name == "instantiated3Card1c(Clone)") {

                        card.name = "instantiated3HandCard1c";

                    } else if (card.name == "instantiated3Card2(Clone)") {

                        card.name = "instantiated3HandCard2";

                    } else if (card.name == "instantiated3Card2a(Clone)") {

                        card.name = "instantiated3HandCard2a";

                    } else if (card.name == "instantiated3Card2b(Clone)") {

                        card.name = "instantiated3HandCard2b";

                    } else if (card.name == "instantiated3Card2c(Clone)") {

                        card.name = "instantiated3HandCard2c";

                    } else if (card.name == "instantiated3Card3(Clone)") {

                        card.name = "instantiated3HandCard3";

                    } else if (card.name == "instantiated3Card3a(Clone)") {

                        card.name = "instantiated3HandCard3a";

                    } else if (card.name == "instantiated3Card3b(Clone)") {

                        card.name = "instantiated3HandCard3b";

                    } else if (card.name == "instantiated3Card3c(Clone)") {

                        card.name = "instantiated3HandCard3c";

                    } else if (card.name == "instantiated3Card4(Clone)") {

                        card.name = "instantiated3HandCard4";

                    } else if (card.name == "instantiated3Card4a(Clone)") {

                        card.name = "instantiated3HandCard4a";

                    } else if (card.name == "instantiated3Card4b(Clone)") {

                        card.name = "instantiated3HandCard4b";

                    } else if (card.name == "instantiated3Card4c(Clone)") {

                        card.name = "instantiated3HandCard4c";

                    } else if (card.name == "instantiated3Card5(Clone)") {

                        card.name = "instantiated3HandCard5";

                    } else if (card.name == "instantiated3Card5a(Clone)") {

                        card.name = "instantiated3HandCard5a";

                    } else if (card.name == "instantiated3Card5b(Clone)") {

                        card.name = "instantiated3HandCard5b";

                    } else if (card.name == "instantiated3Card5c(Clone)") {

                        card.name = "instantiated3HandCard5c";

                    } else if (card.name == "instantiated3Card6(Clone)") {

                        card.name = "instantiated3HandCard6";

                    } else if (card.name == "instantiated3Card6a(Clone)") {

                        card.name = "instantiated3HandCard6a";

                    } else if (card.name == "instantiated3Card6b(Clone)") {

                        card.name = "instantiated3HandCard6b";

                    } else if (card.name == "instantiated3Card6c(Clone)") {

                        card.name = "instantiated3HandCard6c";

                    } else if (card.name == "instantiated3Card7(Clone)") {

                        card.name = "instantiated3HandCard7";

                    } else if (card.name == "instantiated3Card7a(Clone)") {

                        card.name = "instantiated3HandCard7a";

                    } else if (card.name == "instantiated3Card7b(Clone)") {

                        card.name = "instantiated3HandCard7b";

                    } else if (card.name == "instantiated3Card7c(Clone)") {

                        card.name = "instantiated3HandCard7c";

                    } else if (card.name == "instantiated3Card8(Clone)") {

                        card.name = "instantiated3HandCard8";

                    } else if (card.name == "instantiated3Card8a(Clone)") {

                        card.name = "instantiated3HandCard8a";

                    } else if (card.name == "instantiated3Card8b(Clone)") {

                        card.name = "instantiated3HandCard8b";

                    } else if (card.name == "instantiated3Card8c(Clone)") {

                        card.name = "instantiated3HandCard8c";

                    } else if (card.name == "instantiated3Card9(Clone)") {

                        card.name = "instantiated3HandCard9";

                    } else if (card.name == "instantiated3Card9a(Clone)") {

                        card.name = "instantiated3HandCard9a";

                    } else if (card.name == "instantiated3Card9b(Clone)") {

                        card.name = "instantiated3HandCard9b";

                    } else if (card.name == "instantiated3Card9c(Clone)") {

                        card.name = "instantiated3HandCard9c";

                    } else if (card.name == "instantiated3Card10(Clone)") {

                        card.name = "instantiatedAICard10";

                    } else if (card.name == "instantiated3Card10a(Clone)") {

                        card.name = "instantiated3HandCard10a";

                    } else if (card.name == "instantiated3Card10b(Clone)") {

                        card.name = "instantiated3HandCard10b";

                    } else if (card.name == "instantiated3Card10c(Clone)") {

                        card.name = "instantiated3HandCard10c";

                    } else if (card.name == "instantiated3Card11(Clone)") {

                        card.name = "instantiated3HandCard11";

                    } else if (card.name == "instantiated3Card11a(Clone)") {

                        card.name = "instantiated3HandCard11a";

                    } else if (card.name == "instantiated3Card11b(Clone)") {

                        card.name = "instantiated3HandCard11b";

                    } else if (card.name == "instantiated3Card11c(Clone)") {

                        card.name = "instantiated3HandCard11c";

                    } else if (card.name == "instantiated3Card12(Clone)") {

                        card.name = "instantiated3HandCard12";

                    } else if (card.name == "instantiated3Card12a(Clone)") {

                        card.name = "instantiated3HandCard12a";

                    } else if (card.name == "instantiated3Card12b(Clone)") {

                        card.name = "instantiated3HandCard12b";

                    } else if (card.name == "instantiated3Card12c(Clone)") {

                        card.name = "instantiated3HandCard12c";

                    } else if (card.name == "instantiated3Card13(Clone)") {

                        card.name = "instantiated3HandCard13";

                    } else if (card.name == "instantiated3Card13a(Clone)") {

                        card.name = "instantiated3HandCard13a";

                    } else if (card.name == "instantiated3Card13b(Clone)") {

                        card.name = "instantiated3HandCard13b";

                    } else if (card.name == "instantiated3Card13c(Clone)") {

                        card.name = "instantiated3HandCard13c";

                    } else if (card.name == "instantiated3Card14(Clone)") {

                        card.name = "instantiated3HandCard14";

                    } else if (card.name == "instantiated3Card14a(Clone)") {

                        card.name = "instantiated3HandCard14a";

                    } else if (card.name == "instantiated3Card14b(Clone)") {

                        card.name = "instantiated3HandCard14b";

                    } else if (card.name == "instantiated3Card14c(Clone)") {

                        card.name = "instantiated3HandCard14c";

                    } else if (card.name == "instantiated3Card15(Clone)") {

                        card.name = "instantiated3HandCard15";

                    } else if (card.name == "instantiated3Card15a(Clone)") {

                        card.name = "instantiated3HandCard15a";

                    } else if (card.name == "instantiated3Card15b(Clone)") {

                        card.name = "instantiated3HandCard15b";

                    } else if (card.name == "instantiated3Card15c(Clone)") {

                        card.name = "instantiated3HandCard15c";

                    } else if (card.name == "instantiated3Card16(Clone)") {

                        card.name = "instantiated3HandCard16";

                    } else if (card.name == "instantiated3Card16a(Clone)") {

                        card.name = "instantiated3HandCard16a";

                    } else if (card.name == "instantiated3Card16b(Clone)") {

                        card.name = "instantiated3HandCard16b";

                    } else if (card.name == "instantiated3Card16c(Clone)") {

                        card.name = "instantiated3HandCard16c";

                    } else if (card.name == "instantiated3Card17(Clone)") {

                        card.name = "instantiated3HandCard17";

                    } else if (card.name == "instantiated3Card17a(Clone)") {

                        card.name = "instantiated3HandCard17a";

                    } else if (card.name == "instantiated3Card17b(Clone)") {

                        card.name = "instantiated3HandCard17b";

                    } else if (card.name == "instantiated3Card17c(Clone)") {

                        card.name = "instantiated3HandCard17c";

                    } else if (card.name == "instantiated3Card18(Clone)") {

                        card.name = "instantiated3HandCard18";

                    } else if (card.name == "instantiated3Card18a(Clone)") {

                        card.name = "instantiated3HandCard18a";

                    } else if (card.name == "instantiated3Card18b(Clone)") {

                        card.name = "instantiated3HandCard18b";

                    } else if (card.name == "instantiated3Card18c(Clone)") {

                        card.name = "instantiated3HandCard18c";

                    } else if (card.name == "instantiated3Card19(Clone)") {

                        card.name = "instantiated3HandCard19";

                    } else if (card.name == "instantiated3Card19a(Clone)") {

                        card.name = "instantiated3HandCard19a";

                    } else if (card.name == "instantiated3Card19b(Clone)") {

                        card.name = "instantiated3HandCard19b";

                    } else if (card.name == "instantiated3Card19c(Clone)") {

                        card.name = "instantiated3HandCard19c";

                    } else if (card.name == "instantiated3Card20(Clone)") {

                        card.name = "instantiated3HandCard20";

                    } else if (card.name == "instantiated3Card20a(Clone)") {

                        card.name = "instantiated3HandCard20a";

                    } else if (card.name == "instantiated3Card20b(Clone)") {

                        card.name = "instantiated3HandCard20b";

                    } else if (card.name == "instantiated3Card20c(Clone)") {

                        card.name = "instantiated3HandCard20c";

                    } else if (card.name == "instantiated3Card21(Clone)") {

                        card.name = "instantiated3HandCard21";

                    } else if (card.name == "instantiated3Card21a(Clone)") {

                        card.name = "instantiated3HandCard21a";

                    } else if (card.name == "instantiated3Card21b(Clone)") {

                        card.name = "instantiated3HandCard21b";

                    } else if (card.name == "instantiated3Card21c(Clone)") {

                        card.name = "instantiated3HandCard21c";

                    } else if (card.name == "instantiated3Card22(Clone)") {

                        card.name = "instantiated3HandCard22";

                    } else if (card.name == "instantiated3Card22a(Clone)") {

                        card.name = "instantiated3HandCard22a";

                    } else if (card.name == "instantiated3Card22b(Clone)") {

                        card.name = "instantiated3HandCard22b";

                    } else if (card.name == "instantiated3Card22c(Clone)") {

                        card.name = "instantiated3HandCard22c";

                    } else if (card.name == "instantiated3Card23(Clone)") {

                        card.name = "instantiated3HandCard23";

                    } else if (card.name == "instantiated3Card23a(Clone)") {

                        card.name = "instantiated3HandCard23a";

                    } else if (card.name == "instantiated3Card23b(Clone)") {

                        card.name = "instantiated3HandCard23b";

                    } else if (card.name == "instantiated3Card23c(Clone)") {

                        card.name = "instantiated3HandCard23c";

                    } else if (card.name == "instantiated3Card24(Clone)") {

                        card.name = "instantiated3HandCard24";

                    } else if (card.name == "instantiated3Card24a(Clone)") {

                        card.name = "instantiated3HandCard24a";

                    } else if (card.name == "instantiated3Card24b(Clone)") {

                        card.name = "instantiated3HandCard24b";

                    } else if (card.name == "instantiated3Card24c(Clone)") {

                        card.name = "instantiated3HandCard24c";

                    } else if (card.name == "instantiated3Card25(Clone)") {

                        card.name = "instantiated3HandCard25";

                    } else if (card.name == "instantiated3Card25a(Clone)") {

                        card.name = "instantiated3HandCard25a";

                    } else if (card.name == "instantiated3Card25b(Clone)") {

                        card.name = "instantiated3HandCard25b";

                    } else if (card.name == "instantiated3Card25c(Clone)") {

                        card.name = "instantiated3HandCard25c";

                    } else if (card.name == "instantiated3Card26(Clone)") {

                        card.name = "instantiated3HandCard26";

                    } else if (card.name == "instantiated3Card26a(Clone)") {

                        card.name = "instantiated3HandCard26a";

                    } else if (card.name == "instantiated3Card26b(Clone)") {

                        card.name = "instantiated3HandCard26b";

                    } else if (card.name == "instantiated3Card26c(Clone)") {

                        card.name = "instantiated3HandCard26c";

                    } else if (card.name == "instantiated3Card27(Clone)") {

                        card.name = "instantiated3HandCard27";

                    } else if (card.name == "instantiated3Card27a(Clone)") {

                        card.name = "instantiated3HandCard27a";

                    } else if (card.name == "instantiated3Card27b(Clone)") {

                        card.name = "instantiated3HandCard27b";

                    } else if (card.name == "instantiated3Card27c(Clone)") {

                        card.name = "instantiated3HandCard27c";

                    } else if (card.name == "instantiated3Card28(Clone)") {

                        card.name = "instantiated3HandCard28";

                    } else if (card.name == "instantiated3Card28a(Clone)") {

                        card.name = "instantiated3HandCard28a";

                    } else if (card.name == "instantiated3Card28b(Clone)") {

                        card.name = "instantiated3HandCard28b";

                    } else if (card.name == "instantiated3Card28c(Clone)") {

                        card.name = "instantiated3HandCard28c";

                    } else if (card.name == "instantiated3Card29(Clone)") {

                        card.name = "instantiated3HandCard29";

                    } else if (card.name == "instantiated3Card29a(Clone)") {

                        card.name = "instantiated3HandCard29a";

                    } else if (card.name == "instantiated3Card29b(Clone)") {

                        card.name = "instantiated3HandCard29b";

                    } else if (card.name == "instantiated3Card29c(Clone)") {

                        card.name = "instantiated3HandCard29c";

                    } else if (card.name == "instantiated3Card30(Clone)") {

                        card.name = "instantiated3HandCard30";

                    } else if (card.name == "instantiated3Card30a(Clone)") {

                        card.name = "instantiated3HandCard30a";

                    } else if (card.name == "instantiated3Card30b(Clone)") {

                        card.name = "instantiated3HandCard30b";

                    } else if (card.name == "instantiated3Card30c(Clone)") {

                        card.name = "instantiated3HandCard30c";

                    } else if (card.name == "instantiated3Card31(Clone)") {

                        card.name = "instantiated3HandCard31";

                    } else if (card.name == "instantiated3Card31a(Clone)") {

                        card.name = "instantiated3HandCard31a";

                    } else if (card.name == "instantiated3Card31b(Clone)") {

                        card.name = "instantiated3HandCard31b";

                    } else if (card.name == "instantiated3Card31c(Clone)") {

                        card.name = "instantiated3HandCard31c";

                    } else if (card.name == "instantiated3Card32(Clone)") {

                        card.name = "instantiated3HandCard32";

                    } else if (card.name == "instantiated3Card32a(Clone)") {

                        card.name = "instantiated3HandCard32a";

                    } else if (card.name == "instantiated3Card32b(Clone)") {

                        card.name = "instantiated3HandCard32b";

                    } else if (card.name == "instantiated3Card32c(Clone)") {

                        card.name = "instantiated3HandCard32c";

                    } else if (card.name == "instantiated3Card33(Clone)") {

                        card.name = "instantiated3HandCard33";

                    } else if (card.name == "instantiated3Card33a(Clone)") {

                        card.name = "instantiated3HandCard33a";

                    } else if (card.name == "instantiated3Card33b(Clone)") {

                        card.name = "instantiated3HandCard33b";

                    } else if (card.name == "instantiated3Card33c(Clone)") {

                        card.name = "instantiated3HandCard33c";

                    } else if (card.name == "instantiated3Card34(Clone)") {

                        card.name = "instantiated3HandCard34";

                    } else if (card.name == "instantiated3Card34a(Clone)") {

                        card.name = "instantiated3HandCard34a";

                    } else if (card.name == "instantiated3Card34b(Clone)") {

                        card.name = "instantiated3HandCard34b";

                    } else if (card.name == "instantiated3Card34c(Clone)") {

                        card.name = "instantiated3HandCard34c";

                    } else if (card.name == "instantiated3Card35(Clone)") {

                        card.name = "instantiated3HandCard35";

                    } else if (card.name == "instantiated3Card35a(Clone)") {

                        card.name = "instantiated3HandCard35a";

                    } else if (card.name == "instantiated3Card35b(Clone)") {

                        card.name = "instantiated3HandCard35b";

                    } else if (card.name == "instantiated3Card35c(Clone)") {

                        card.name = "instantiated3HandCard35c";

                    } else if (card.name == "instantiated3Card36(Clone)") {

                        card.name = "instantiated3HandCard36";

                    } else if (card.name == "instantiated3Card36a(Clone)") {

                        card.name = "instantiated3HandCard36a";

                    } else if (card.name == "instantiated3Card36b(Clone)") {

                        card.name = "instantiated3HandCard36b";

                    } else if (card.name == "instantiated3Card36c(Clone)") {

                        card.name = "instantiated3HandCard36c";

                    } else if (card.name == "instantiated3Card37(Clone)") {

                        card.name = "instantiated3HandCard37";

                    } else if (card.name == "instantiated3Card37a(Clone)") {

                        card.name = "instantiated3HandCard37a";

                    } else if (card.name == "instantiated3Card37b(Clone)") {

                        card.name = "instantiated3HandCard37b";

                    } else if (card.name == "instantiated3Card37c(Clone)") {

                        card.name = "instantiated3HandCard37c";

                    } else if (card.name == "instantiated3Card38(Clone)") {

                        card.name = "instantiated3HandCard38";

                    } else if (card.name == "instantiated3Card38a(Clone)") {

                        card.name = "instantiated3HandCard38a";

                    } else if (card.name == "instantiated3Card38b(Clone)") {

                        card.name = "instantiated3HandCard38b";

                    } else if (card.name == "instantiated3Card38c(Clone)") {

                        card.name = "instantiated3HandCard38c";

                    } else if (card.name == "instantiated3Card39(Clone)") {

                        card.name = "instantiated3HandCard39";

                    } else if (card.name == "instantiated3Card39a(Clone)") {

                        card.name = "instantiated3HandCard39a";

                    } else if (card.name == "instantiated3Card39b(Clone)") {

                        card.name = "instantiated3HandCard39b";

                    } else if (card.name == "instantiated3Card39c(Clone)") {

                        card.name = "instantiated3HandCard39c";

                    } else if (card.name == "instantiated3Card40(Clone)") {

                        card.name = "instantiated3HandCard40";

                    } else if (card.name == "instantiated3Card40a(Clone)") {

                        card.name = "instantiated3HandCard40a";

                    } else if (card.name == "instantiated3Card40b(Clone)") {

                        card.name = "instantiated3HandCard40b";

                    } else if (card.name == "instantiated3Card40c(Clone)") {

                        card.name = "instantiated3HandCard40c";

                    } else if (card.name == "instantiated3Card41(Clone)") {

                        card.name = "instantiated3HandCard41";

                    } else if (card.name == "instantiated3Card41a(Clone)") {

                        card.name = "instantiated3HandCard41a";

                    } else if (card.name == "instantiated3Card41b(Clone)") {

                        card.name = "instantiated3HandCard41b";

                    } else if (card.name == "instantiated3Card41c(Clone)") {

                        card.name = "instantiated3HandCard41c";

                    } else if (card.name == "instantiated3Card42(Clone)") {

                        card.name = "instantiated3HandCard42";

                    } else if (card.name == "instantiated3Card42a(Clone)") {

                        card.name = "instantiated3HandCard42a";

                    } else if (card.name == "instantiated3Card42b(Clone)") {

                        card.name = "instantiated3HandCard42b";

                    } else if (card.name == "instantiated3Card42c(Clone)") {

                        card.name = "instantiated3HandCard42c";

                    } else if (card.name == "instantiated3Card43(Clone)") {

                        card.name = "instantiated3HandCard43";

                    } else if (card.name == "instantiated3Card43a(Clone)") {

                        card.name = "instantiated3HandCard43a";

                    } else if (card.name == "instantiated3Card43b(Clone)") {

                        card.name = "instantiated3HandCard43b";

                    } else if (card.name == "instantiated3Card43c(Clone)") {

                        card.name = "instantiated3HandCard43c";

                    } else if (card.name == "instantiated3Card44(Clone)") {

                        card.name = "instantiated3HandCard44";

                    } else if (card.name == "instantiated3Card44a(Clone)") {

                        card.name = "instantiated3HandCard44a";

                    } else if (card.name == "instantiated3Card44b(Clone)") {

                        card.name = "instantiated3HandCard44b";

                    } else if (card.name == "instantiated3Card44c(Clone)") {

                        card.name = "instantiated3HandCard44c";

                    } else if (card.name == "instantiated3Card45(Clone)") {

                        card.name = "instantiated3HandCard45";

                    } else if (card.name == "instantiated3Card45a(Clone)") {

                        card.name = "instantiated3HandCard45a";

                    } else if (card.name == "instantiated3Card45b(Clone)") {

                        card.name = "instantiated3HandCard45b";

                    } else if (card.name == "instantiated3Card45c(Clone)") {

                        card.name = "instantiated3HandCard45c";

                    } else if (card.name == "instantiated3Card46(Clone)") {

                        card.name = "instantiated3HandCard46";

                    } else if (card.name == "instantiated3Card46a(Clone)") {

                        card.name = "instantiated3HandCard46a";

                    } else if (card.name == "instantiated3Card46b(Clone)") {

                        card.name = "instantiated3HandCard46b";

                    } else if (card.name == "instantiated3Card46c(Clone)") {

                        card.name = "instantiated3HandCard46c";

                    } else if (card.name == "instantiated3Card47(Clone)") {

                        card.name = "instantiated3HandCard47";

                    } else if (card.name == "instantiated3Card47a(Clone)") {

                        card.name = "instantiated3HandCard47a";

                    } else if (card.name == "instantiated3Card47b(Clone)") {

                        card.name = "instantiated3HandCard47b";

                    } else if (card.name == "instantiated3Card47c(Clone)") {

                        card.name = "instantiated3HandCard47c";

                    } else if (card.name == "instantiated3Card48(Clone)") {

                        card.name = "instantiated3HandCard48";

                    } else if (card.name == "instantiated3Card48a(Clone)") {

                        card.name = "instantiated3HandCard48a";

                    } else if (card.name == "instantiated3Card48b(Clone)") {

                        card.name = "instantiated3HandCard48b";

                    } else if (card.name == "instantiated3Card48c(Clone)") {

                        card.name = "instantiated3HandCard48c";

                    } else if (card.name == "instantiated3Card49(Clone)") {

                        card.name = "instantiated3HandCard49";

                    } else if (card.name == "instantiated3Card49a(Clone)") {

                        card.name = "instantiated3HandCard49a";

                    } else if (card.name == "instantiated3Card49b(Clone)") {

                        card.name = "instantiated3HandCard49b";

                    } else if (card.name == "instantiated3Card49c(Clone)") {

                        card.name = "instantiated3HandCard49c";

                    } else if (card.name == "instantiated3Card50(Clone)") {

                        card.name = "instantiated3HandCard50";

                    } else if (card.name == "instantiated3Card50a(Clone)") {

                        card.name = "instantiated3HandCard50a";

                    } else if (card.name == "instantiated3Card50b(Clone)") {

                        card.name = "instantiated3HandCard50b";

                    } else if (card.name == "instantiated3Card50c(Clone)") {

                        card.name = "instantiated3HandCard50c";

                    } else if (card.name == "instantiated3Card51(Clone)") {

                        card.name = "instantiated3HandCard51";

                    } else if (card.name == "instantiated3Card51a(Clone)") {

                        card.name = "instantiated3HandCard51a";

                    } else if (card.name == "instantiated3Card51b(Clone)") {

                        card.name = "instantiated3HandCard51b";

                    } else if (card.name == "instantiated3Card51c(Clone)") {

                        card.name = "instantiated3HandCard51c";

                    } else if (card.name == "instantiated3Card52(Clone)") {

                        card.name = "instantiated3HandCard52";

                    } else if (card.name == "instantiated3Card52a(Clone)") {

                        card.name = "instantiated3HandCard52a";

                    } else if (card.name == "instantiated3Card52b(Clone)") {

                        card.name = "instantiated3HandCard52b";

                    } else if (card.name == "instantiated3Card52c(Clone)") {

                        card.name = "instantiated3HandCard52c";

                    } else if (card.name == "instantiated3Card53(Clone)") {

                        card.name = "instantiated3HandCard53";

                    } else if (card.name == "instantiated3Card53a(Clone)") {

                        card.name = "instantiated3HandCard53a";

                    } else if (card.name == "instantiated3Card53b(Clone)") {

                        card.name = "instantiated3HandCard53b";

                    } else if (card.name == "instantiated3Card53c(Clone)") {

                        card.name = "instantiated3HandCard53c";

                    } else if (card.name == "instantiated3Card54(Clone)") {

                        card.name = "instantiated3HandCard54";

                    } else if (card.name == "instantiated3Card54a(Clone)") {

                        card.name = "instantiated3HandCard54a";

                    } else if (card.name == "instantiated3Card54b(Clone)") {

                        card.name = "instantiated3HandCard54b";

                    } else if (card.name == "instantiated3Card54c(Clone)") {

                        card.name = "instantiated3HandCard54c";

                    } else if (card.name == "instantiated3Card55(Clone)") {

                        card.name = "instantiated3HandCard55";

                    } else if (card.name == "instantiated3Card55a(Clone)") {

                        card.name = "instantiated3HandCard55a";

                    } else if (card.name == "instantiated3Card55b(Clone)") {

                        card.name = "instantiated3HandCard55b";

                    } else if (card.name == "instantiated3Card55c(Clone)") {

                        card.name = "instantiated3HandCard55c";

                    } else if (card.name == "instantiated3Card56(Clone)") {

                        card.name = "instantiated3HandCard56";

                    } else if (card.name == "instantiated3Card56a(Clone)") {

                        card.name = "instantiated3HandCard56a";

                    } else if (card.name == "instantiated3Card56b(Clone)") {

                        card.name = "instantiated3HandCard56b";

                    } else if (card.name == "instantiated3Card56c(Clone)") {

                        card.name = "instantiated3HandCard56c";

                    } else if (card.name == "instantiated3Card57(Clone)") {

                        card.name = "instantiated3HandCard57";

                    } else if (card.name == "instantiated3Card57a(Clone)") {

                        card.name = "instantiated3HandCard57a";

                    } else if (card.name == "instantiated3Card57b(Clone)") {

                        card.name = "instantiated3HandCard57b";

                    } else if (card.name == "instantiated3Card57c(Clone)") {

                        card.name = "instantiated3HandCard57c";

                    } else if (card.name == "instantiated3Card58(Clone)") {

                        card.name = "instantiated3HandCard58";

                    } else if (card.name == "instantiated3Card58a(Clone)") {

                        card.name = "instantiated3HandCard58a";

                    } else if (card.name == "instantiated3Card58b(Clone)") {

                        card.name = "instantiated3HandCard58b";

                    } else if (card.name == "instantiated3Card58c(Clone)") {

                        card.name = "instantiated3HandCard58c";

                    } else if (card.name == "instantiated3Card59(Clone)") {

                        card.name = "instantiated3HandCard59";

                    } else if (card.name == "instantiated3Card59a(Clone)") {

                        card.name = "instantiated3HandCard59a";

                    } else if (card.name == "instantiated3Card59b(Clone)") {

                        card.name = "instantiated3HandCard59b";

                    } else if (card.name == "instantiated3Card59c(Clone)") {

                        card.name = "instantiated3HandCard59c";

                    } else if (card.name == "instantiated3Card60(Clone)") {

                        card.name = "instantiated3HandCard60";

                    } else if (card.name == "instantiated3Card60a(Clone)") {

                        card.name = "instantiated3HandCard60a";

                    } else if (card.name == "instantiated3Card60b(Clone)") {

                        card.name = "instantiated3HandCard60b";

                    } else if (card.name == "instantiated3Card60c(Clone)") {

                        card.name = "instantiated3HandCard60c";
                    }

                    instances9M++;

                }

            }

            if (player1DeckSlot10.transform.childCount == 0) {

                while (instances10M < NumberOfCards) {

                    GameObject card = Instantiate(playCardsDeck3[UnityEngine.Random.Range(0, playCardsDeck3.Count)], player1DeckSlot10.transform.position, player1DeckSlot10.transform.rotation) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.transform.parent = player1DeckSlot10.transform;

                    if (card.name == "instantiated3Card1(Clone)") {

                        card.name = "instantiated3HandCard1";

                    } else if (card.name == "instantiated3Card1a(Clone)") {

                        card.name = "instantiated3HandCard1a";

                    } else if (card.name == "instantiated3Card1b(Clone)") {

                        card.name = "instantiated3HandCard1b";

                    } else if (card.name == "instantiated3Card1c(Clone)") {

                        card.name = "instantiated3HandCard1c";

                    } else if (card.name == "instantiated3Card2(Clone)") {

                        card.name = "instantiated3HandCard2";

                    } else if (card.name == "instantiated3Card2a(Clone)") {

                        card.name = "instantiated3HandCard2a";

                    } else if (card.name == "instantiated3Card2b(Clone)") {

                        card.name = "instantiated3HandCard2b";

                    } else if (card.name == "instantiated3Card2c(Clone)") {

                        card.name = "instantiated3HandCard2c";

                    } else if (card.name == "instantiated3Card3(Clone)") {

                        card.name = "instantiated3HandCard3";

                    } else if (card.name == "instantiated3Card3a(Clone)") {

                        card.name = "instantiated3HandCard3a";

                    } else if (card.name == "instantiated3Card3b(Clone)") {

                        card.name = "instantiated3HandCard3b";

                    } else if (card.name == "instantiated3Card3c(Clone)") {

                        card.name = "instantiated3HandCard3c";

                    } else if (card.name == "instantiated3Card4(Clone)") {

                        card.name = "instantiated3HandCard4";

                    } else if (card.name == "instantiated3Card4a(Clone)") {

                        card.name = "instantiated3HandCard4a";

                    } else if (card.name == "instantiated3Card4b(Clone)") {

                        card.name = "instantiated3HandCard4b";

                    } else if (card.name == "instantiated3Card4c(Clone)") {

                        card.name = "instantiated3HandCard4c";

                    } else if (card.name == "instantiated3Card5(Clone)") {

                        card.name = "instantiated3HandCard5";

                    } else if (card.name == "instantiated3Card5a(Clone)") {

                        card.name = "instantiated3HandCard5a";

                    } else if (card.name == "instantiated3Card5b(Clone)") {

                        card.name = "instantiated3HandCard5b";

                    } else if (card.name == "instantiated3Card5c(Clone)") {

                        card.name = "instantiated3HandCard5c";

                    } else if (card.name == "instantiated3Card6(Clone)") {

                        card.name = "instantiated3HandCard6";

                    } else if (card.name == "instantiated3Card6a(Clone)") {

                        card.name = "instantiated3HandCard6a";

                    } else if (card.name == "instantiated3Card6b(Clone)") {

                        card.name = "instantiated3HandCard6b";

                    } else if (card.name == "instantiated3Card6c(Clone)") {

                        card.name = "instantiated3HandCard6c";

                    } else if (card.name == "instantiated3Card7(Clone)") {

                        card.name = "instantiated3HandCard7";

                    } else if (card.name == "instantiated3Card7a(Clone)") {

                        card.name = "instantiated3HandCard7a";

                    } else if (card.name == "instantiated3Card7b(Clone)") {

                        card.name = "instantiated3HandCard7b";

                    } else if (card.name == "instantiated3Card7c(Clone)") {

                        card.name = "instantiated3HandCard7c";

                    } else if (card.name == "instantiated3Card8(Clone)") {

                        card.name = "instantiated3HandCard8";

                    } else if (card.name == "instantiated3Card8a(Clone)") {

                        card.name = "instantiated3HandCard8a";

                    } else if (card.name == "instantiated3Card8b(Clone)") {

                        card.name = "instantiated3HandCard8b";

                    } else if (card.name == "instantiated3Card8c(Clone)") {

                        card.name = "instantiated3HandCard8c";

                    } else if (card.name == "instantiated3Card9(Clone)") {

                        card.name = "instantiated3HandCard9";

                    } else if (card.name == "instantiated3Card9a(Clone)") {

                        card.name = "instantiated3HandCard9a";

                    } else if (card.name == "instantiated3Card9b(Clone)") {

                        card.name = "instantiated3HandCard9b";

                    } else if (card.name == "instantiated3Card9c(Clone)") {

                        card.name = "instantiated3HandCard9c";

                    } else if (card.name == "instantiated3Card10(Clone)") {

                        card.name = "instantiatedAICard10";

                    } else if (card.name == "instantiated3Card10a(Clone)") {

                        card.name = "instantiated3HandCard10a";

                    } else if (card.name == "instantiated3Card10b(Clone)") {

                        card.name = "instantiated3HandCard10b";

                    } else if (card.name == "instantiated3Card10c(Clone)") {

                        card.name = "instantiated3HandCard10c";

                    } else if (card.name == "instantiated3Card11(Clone)") {

                        card.name = "instantiated3HandCard11";

                    } else if (card.name == "instantiated3Card11a(Clone)") {

                        card.name = "instantiated3HandCard11a";

                    } else if (card.name == "instantiated3Card11b(Clone)") {

                        card.name = "instantiated3HandCard11b";

                    } else if (card.name == "instantiated3Card11c(Clone)") {

                        card.name = "instantiated3HandCard11c";

                    } else if (card.name == "instantiated3Card12(Clone)") {

                        card.name = "instantiated3HandCard12";

                    } else if (card.name == "instantiated3Card12a(Clone)") {

                        card.name = "instantiated3HandCard12a";

                    } else if (card.name == "instantiated3Card12b(Clone)") {

                        card.name = "instantiated3HandCard12b";

                    } else if (card.name == "instantiated3Card12c(Clone)") {

                        card.name = "instantiated3HandCard12c";

                    } else if (card.name == "instantiated3Card13(Clone)") {

                        card.name = "instantiated3HandCard13";

                    } else if (card.name == "instantiated3Card13a(Clone)") {

                        card.name = "instantiated3HandCard13a";

                    } else if (card.name == "instantiated3Card13b(Clone)") {

                        card.name = "instantiated3HandCard13b";

                    } else if (card.name == "instantiated3Card13c(Clone)") {

                        card.name = "instantiated3HandCard13c";

                    } else if (card.name == "instantiated3Card14(Clone)") {

                        card.name = "instantiated3HandCard14";

                    } else if (card.name == "instantiated3Card14a(Clone)") {

                        card.name = "instantiated3HandCard14a";

                    } else if (card.name == "instantiated3Card14b(Clone)") {

                        card.name = "instantiated3HandCard14b";

                    } else if (card.name == "instantiated3Card14c(Clone)") {

                        card.name = "instantiated3HandCard14c";

                    } else if (card.name == "instantiated3Card15(Clone)") {

                        card.name = "instantiated3HandCard15";

                    } else if (card.name == "instantiated3Card15a(Clone)") {

                        card.name = "instantiated3HandCard15a";

                    } else if (card.name == "instantiated3Card15b(Clone)") {

                        card.name = "instantiated3HandCard15b";

                    } else if (card.name == "instantiated3Card15c(Clone)") {

                        card.name = "instantiated3HandCard15c";

                    } else if (card.name == "instantiated3Card16(Clone)") {

                        card.name = "instantiated3HandCard16";

                    } else if (card.name == "instantiated3Card16a(Clone)") {

                        card.name = "instantiated3HandCard16a";

                    } else if (card.name == "instantiated3Card16b(Clone)") {

                        card.name = "instantiated3HandCard16b";

                    } else if (card.name == "instantiated3Card16c(Clone)") {

                        card.name = "instantiated3HandCard16c";

                    } else if (card.name == "instantiated3Card17(Clone)") {

                        card.name = "instantiated3HandCard17";

                    } else if (card.name == "instantiated3Card17a(Clone)") {

                        card.name = "instantiated3HandCard17a";

                    } else if (card.name == "instantiated3Card17b(Clone)") {

                        card.name = "instantiated3HandCard17b";

                    } else if (card.name == "instantiated3Card17c(Clone)") {

                        card.name = "instantiated3HandCard17c";

                    } else if (card.name == "instantiated3Card18(Clone)") {

                        card.name = "instantiated3HandCard18";

                    } else if (card.name == "instantiated3Card18a(Clone)") {

                        card.name = "instantiated3HandCard18a";

                    } else if (card.name == "instantiated3Card18b(Clone)") {

                        card.name = "instantiated3HandCard18b";

                    } else if (card.name == "instantiated3Card18c(Clone)") {

                        card.name = "instantiated3HandCard18c";

                    } else if (card.name == "instantiated3Card19(Clone)") {

                        card.name = "instantiated3HandCard19";

                    } else if (card.name == "instantiated3Card19a(Clone)") {

                        card.name = "instantiated3HandCard19a";

                    } else if (card.name == "instantiated3Card19b(Clone)") {

                        card.name = "instantiated3HandCard19b";

                    } else if (card.name == "instantiated3Card19c(Clone)") {

                        card.name = "instantiated3HandCard19c";

                    } else if (card.name == "instantiated3Card20(Clone)") {

                        card.name = "instantiated3HandCard20";

                    } else if (card.name == "instantiated3Card20a(Clone)") {

                        card.name = "instantiated3HandCard20a";

                    } else if (card.name == "instantiated3Card20b(Clone)") {

                        card.name = "instantiated3HandCard20b";

                    } else if (card.name == "instantiated3Card20c(Clone)") {

                        card.name = "instantiated3HandCard20c";

                    } else if (card.name == "instantiated3Card21(Clone)") {

                        card.name = "instantiated3HandCard21";

                    } else if (card.name == "instantiated3Card21a(Clone)") {

                        card.name = "instantiated3HandCard21a";

                    } else if (card.name == "instantiated3Card21b(Clone)") {

                        card.name = "instantiated3HandCard21b";

                    } else if (card.name == "instantiated3Card21c(Clone)") {

                        card.name = "instantiated3HandCard21c";

                    } else if (card.name == "instantiated3Card22(Clone)") {

                        card.name = "instantiated3HandCard22";

                    } else if (card.name == "instantiated3Card22a(Clone)") {

                        card.name = "instantiated3HandCard22a";

                    } else if (card.name == "instantiated3Card22b(Clone)") {

                        card.name = "instantiated3HandCard22b";

                    } else if (card.name == "instantiated3Card22c(Clone)") {

                        card.name = "instantiated3HandCard22c";

                    } else if (card.name == "instantiated3Card23(Clone)") {

                        card.name = "instantiated3HandCard23";

                    } else if (card.name == "instantiated3Card23a(Clone)") {

                        card.name = "instantiated3HandCard23a";

                    } else if (card.name == "instantiated3Card23b(Clone)") {

                        card.name = "instantiated3HandCard23b";

                    } else if (card.name == "instantiated3Card23c(Clone)") {

                        card.name = "instantiated3HandCard23c";

                    } else if (card.name == "instantiated3Card24(Clone)") {

                        card.name = "instantiated3HandCard24";

                    } else if (card.name == "instantiated3Card24a(Clone)") {

                        card.name = "instantiated3HandCard24a";

                    } else if (card.name == "instantiated3Card24b(Clone)") {

                        card.name = "instantiated3HandCard24b";

                    } else if (card.name == "instantiated3Card24c(Clone)") {

                        card.name = "instantiated3HandCard24c";

                    } else if (card.name == "instantiated3Card25(Clone)") {

                        card.name = "instantiated3HandCard25";

                    } else if (card.name == "instantiated3Card25a(Clone)") {

                        card.name = "instantiated3HandCard25a";

                    } else if (card.name == "instantiated3Card25b(Clone)") {

                        card.name = "instantiated3HandCard25b";

                    } else if (card.name == "instantiated3Card25c(Clone)") {

                        card.name = "instantiated3HandCard25c";

                    } else if (card.name == "instantiated3Card26(Clone)") {

                        card.name = "instantiated3HandCard26";

                    } else if (card.name == "instantiated3Card26a(Clone)") {

                        card.name = "instantiated3HandCard26a";

                    } else if (card.name == "instantiated3Card26b(Clone)") {

                        card.name = "instantiated3HandCard26b";

                    } else if (card.name == "instantiated3Card26c(Clone)") {

                        card.name = "instantiated3HandCard26c";

                    } else if (card.name == "instantiated3Card27(Clone)") {

                        card.name = "instantiated3HandCard27";

                    } else if (card.name == "instantiated3Card27a(Clone)") {

                        card.name = "instantiated3HandCard27a";

                    } else if (card.name == "instantiated3Card27b(Clone)") {

                        card.name = "instantiated3HandCard27b";

                    } else if (card.name == "instantiated3Card27c(Clone)") {

                        card.name = "instantiated3HandCard27c";

                    } else if (card.name == "instantiated3Card28(Clone)") {

                        card.name = "instantiated3HandCard28";

                    } else if (card.name == "instantiated3Card28a(Clone)") {

                        card.name = "instantiated3HandCard28a";

                    } else if (card.name == "instantiated3Card28b(Clone)") {

                        card.name = "instantiated3HandCard28b";

                    } else if (card.name == "instantiated3Card28c(Clone)") {

                        card.name = "instantiated3HandCard28c";

                    } else if (card.name == "instantiated3Card29(Clone)") {

                        card.name = "instantiated3HandCard29";

                    } else if (card.name == "instantiated3Card29a(Clone)") {

                        card.name = "instantiated3HandCard29a";

                    } else if (card.name == "instantiated3Card29b(Clone)") {

                        card.name = "instantiated3HandCard29b";

                    } else if (card.name == "instantiated3Card29c(Clone)") {

                        card.name = "instantiated3HandCard29c";

                    } else if (card.name == "instantiated3Card30(Clone)") {

                        card.name = "instantiated3HandCard30";

                    } else if (card.name == "instantiated3Card30a(Clone)") {

                        card.name = "instantiated3HandCard30a";

                    } else if (card.name == "instantiated3Card30b(Clone)") {

                        card.name = "instantiated3HandCard30b";

                    } else if (card.name == "instantiated3Card30c(Clone)") {

                        card.name = "instantiated3HandCard30c";

                    } else if (card.name == "instantiated3Card31(Clone)") {

                        card.name = "instantiated3HandCard31";

                    } else if (card.name == "instantiated3Card31a(Clone)") {

                        card.name = "instantiated3HandCard31a";

                    } else if (card.name == "instantiated3Card31b(Clone)") {

                        card.name = "instantiated3HandCard31b";

                    } else if (card.name == "instantiated3Card31c(Clone)") {

                        card.name = "instantiated3HandCard31c";

                    } else if (card.name == "instantiated3Card32(Clone)") {

                        card.name = "instantiated3HandCard32";

                    } else if (card.name == "instantiated3Card32a(Clone)") {

                        card.name = "instantiated3HandCard32a";

                    } else if (card.name == "instantiated3Card32b(Clone)") {

                        card.name = "instantiated3HandCard32b";

                    } else if (card.name == "instantiated3Card32c(Clone)") {

                        card.name = "instantiated3HandCard32c";

                    } else if (card.name == "instantiated3Card33(Clone)") {

                        card.name = "instantiated3HandCard33";

                    } else if (card.name == "instantiated3Card33a(Clone)") {

                        card.name = "instantiated3HandCard33a";

                    } else if (card.name == "instantiated3Card33b(Clone)") {

                        card.name = "instantiated3HandCard33b";

                    } else if (card.name == "instantiated3Card33c(Clone)") {

                        card.name = "instantiated3HandCard33c";

                    } else if (card.name == "instantiated3Card34(Clone)") {

                        card.name = "instantiated3HandCard34";

                    } else if (card.name == "instantiated3Card34a(Clone)") {

                        card.name = "instantiated3HandCard34a";

                    } else if (card.name == "instantiated3Card34b(Clone)") {

                        card.name = "instantiated3HandCard34b";

                    } else if (card.name == "instantiated3Card34c(Clone)") {

                        card.name = "instantiated3HandCard34c";

                    } else if (card.name == "instantiated3Card35(Clone)") {

                        card.name = "instantiated3HandCard35";

                    } else if (card.name == "instantiated3Card35a(Clone)") {

                        card.name = "instantiated3HandCard35a";

                    } else if (card.name == "instantiated3Card35b(Clone)") {

                        card.name = "instantiated3HandCard35b";

                    } else if (card.name == "instantiated3Card35c(Clone)") {

                        card.name = "instantiated3HandCard35c";

                    } else if (card.name == "instantiated3Card36(Clone)") {

                        card.name = "instantiated3HandCard36";

                    } else if (card.name == "instantiated3Card36a(Clone)") {

                        card.name = "instantiated3HandCard36a";

                    } else if (card.name == "instantiated3Card36b(Clone)") {

                        card.name = "instantiated3HandCard36b";

                    } else if (card.name == "instantiated3Card36c(Clone)") {

                        card.name = "instantiated3HandCard36c";

                    } else if (card.name == "instantiated3Card37(Clone)") {

                        card.name = "instantiated3HandCard37";

                    } else if (card.name == "instantiated3Card37a(Clone)") {

                        card.name = "instantiated3HandCard37a";

                    } else if (card.name == "instantiated3Card37b(Clone)") {

                        card.name = "instantiated3HandCard37b";

                    } else if (card.name == "instantiated3Card37c(Clone)") {

                        card.name = "instantiated3HandCard37c";

                    } else if (card.name == "instantiated3Card38(Clone)") {

                        card.name = "instantiated3HandCard38";

                    } else if (card.name == "instantiated3Card38a(Clone)") {

                        card.name = "instantiated3HandCard38a";

                    } else if (card.name == "instantiated3Card38b(Clone)") {

                        card.name = "instantiated3HandCard38b";

                    } else if (card.name == "instantiated3Card38c(Clone)") {

                        card.name = "instantiated3HandCard38c";

                    } else if (card.name == "instantiated3Card39(Clone)") {

                        card.name = "instantiated3HandCard39";

                    } else if (card.name == "instantiated3Card39a(Clone)") {

                        card.name = "instantiated3HandCard39a";

                    } else if (card.name == "instantiated3Card39b(Clone)") {

                        card.name = "instantiated3HandCard39b";

                    } else if (card.name == "instantiated3Card39c(Clone)") {

                        card.name = "instantiated3HandCard39c";

                    } else if (card.name == "instantiated3Card40(Clone)") {

                        card.name = "instantiated3HandCard40";

                    } else if (card.name == "instantiated3Card40a(Clone)") {

                        card.name = "instantiated3HandCard40a";

                    } else if (card.name == "instantiated3Card40b(Clone)") {

                        card.name = "instantiated3HandCard40b";

                    } else if (card.name == "instantiated3Card40c(Clone)") {

                        card.name = "instantiated3HandCard40c";

                    } else if (card.name == "instantiated3Card41(Clone)") {

                        card.name = "instantiated3HandCard41";

                    } else if (card.name == "instantiated3Card41a(Clone)") {

                        card.name = "instantiated3HandCard41a";

                    } else if (card.name == "instantiated3Card41b(Clone)") {

                        card.name = "instantiated3HandCard41b";

                    } else if (card.name == "instantiated3Card41c(Clone)") {

                        card.name = "instantiated3HandCard41c";

                    } else if (card.name == "instantiated3Card42(Clone)") {

                        card.name = "instantiated3HandCard42";

                    } else if (card.name == "instantiated3Card42a(Clone)") {

                        card.name = "instantiated3HandCard42a";

                    } else if (card.name == "instantiated3Card42b(Clone)") {

                        card.name = "instantiated3HandCard42b";

                    } else if (card.name == "instantiated3Card42c(Clone)") {

                        card.name = "instantiated3HandCard42c";

                    } else if (card.name == "instantiated3Card43(Clone)") {

                        card.name = "instantiated3HandCard43";

                    } else if (card.name == "instantiated3Card43a(Clone)") {

                        card.name = "instantiated3HandCard43a";

                    } else if (card.name == "instantiated3Card43b(Clone)") {

                        card.name = "instantiated3HandCard43b";

                    } else if (card.name == "instantiated3Card43c(Clone)") {

                        card.name = "instantiated3HandCard43c";

                    } else if (card.name == "instantiated3Card44(Clone)") {

                        card.name = "instantiated3HandCard44";

                    } else if (card.name == "instantiated3Card44a(Clone)") {

                        card.name = "instantiated3HandCard44a";

                    } else if (card.name == "instantiated3Card44b(Clone)") {

                        card.name = "instantiated3HandCard44b";

                    } else if (card.name == "instantiated3Card44c(Clone)") {

                        card.name = "instantiated3HandCard44c";

                    } else if (card.name == "instantiated3Card45(Clone)") {

                        card.name = "instantiated3HandCard45";

                    } else if (card.name == "instantiated3Card45a(Clone)") {

                        card.name = "instantiated3HandCard45a";

                    } else if (card.name == "instantiated3Card45b(Clone)") {

                        card.name = "instantiated3HandCard45b";

                    } else if (card.name == "instantiated3Card45c(Clone)") {

                        card.name = "instantiated3HandCard45c";

                    } else if (card.name == "instantiated3Card46(Clone)") {

                        card.name = "instantiated3HandCard46";

                    } else if (card.name == "instantiated3Card46a(Clone)") {

                        card.name = "instantiated3HandCard46a";

                    } else if (card.name == "instantiated3Card46b(Clone)") {

                        card.name = "instantiated3HandCard46b";

                    } else if (card.name == "instantiated3Card46c(Clone)") {

                        card.name = "instantiated3HandCard46c";

                    } else if (card.name == "instantiated3Card47(Clone)") {

                        card.name = "instantiated3HandCard47";

                    } else if (card.name == "instantiated3Card47a(Clone)") {

                        card.name = "instantiated3HandCard47a";

                    } else if (card.name == "instantiated3Card47b(Clone)") {

                        card.name = "instantiated3HandCard47b";

                    } else if (card.name == "instantiated3Card47c(Clone)") {

                        card.name = "instantiated3HandCard47c";

                    } else if (card.name == "instantiated3Card48(Clone)") {

                        card.name = "instantiated3HandCard48";

                    } else if (card.name == "instantiated3Card48a(Clone)") {

                        card.name = "instantiated3HandCard48a";

                    } else if (card.name == "instantiated3Card48b(Clone)") {

                        card.name = "instantiated3HandCard48b";

                    } else if (card.name == "instantiated3Card48c(Clone)") {

                        card.name = "instantiated3HandCard48c";

                    } else if (card.name == "instantiated3Card49(Clone)") {

                        card.name = "instantiated3HandCard49";

                    } else if (card.name == "instantiated3Card49a(Clone)") {

                        card.name = "instantiated3HandCard49a";

                    } else if (card.name == "instantiated3Card49b(Clone)") {

                        card.name = "instantiated3HandCard49b";

                    } else if (card.name == "instantiated3Card49c(Clone)") {

                        card.name = "instantiated3HandCard49c";

                    } else if (card.name == "instantiated3Card50(Clone)") {

                        card.name = "instantiated3HandCard50";

                    } else if (card.name == "instantiated3Card50a(Clone)") {

                        card.name = "instantiated3HandCard50a";

                    } else if (card.name == "instantiated3Card50b(Clone)") {

                        card.name = "instantiated3HandCard50b";

                    } else if (card.name == "instantiated3Card50c(Clone)") {

                        card.name = "instantiated3HandCard50c";

                    } else if (card.name == "instantiated3Card51(Clone)") {

                        card.name = "instantiated3HandCard51";

                    } else if (card.name == "instantiated3Card51a(Clone)") {

                        card.name = "instantiated3HandCard51a";

                    } else if (card.name == "instantiated3Card51b(Clone)") {

                        card.name = "instantiated3HandCard51b";

                    } else if (card.name == "instantiated3Card51c(Clone)") {

                        card.name = "instantiated3HandCard51c";

                    } else if (card.name == "instantiated3Card52(Clone)") {

                        card.name = "instantiated3HandCard52";

                    } else if (card.name == "instantiated3Card52a(Clone)") {

                        card.name = "instantiated3HandCard52a";

                    } else if (card.name == "instantiated3Card52b(Clone)") {

                        card.name = "instantiated3HandCard52b";

                    } else if (card.name == "instantiated3Card52c(Clone)") {

                        card.name = "instantiated3HandCard52c";

                    } else if (card.name == "instantiated3Card53(Clone)") {

                        card.name = "instantiated3HandCard53";

                    } else if (card.name == "instantiated3Card53a(Clone)") {

                        card.name = "instantiated3HandCard53a";

                    } else if (card.name == "instantiated3Card53b(Clone)") {

                        card.name = "instantiated3HandCard53b";

                    } else if (card.name == "instantiated3Card53c(Clone)") {

                        card.name = "instantiated3HandCard53c";

                    } else if (card.name == "instantiated3Card54(Clone)") {

                        card.name = "instantiated3HandCard54";

                    } else if (card.name == "instantiated3Card54a(Clone)") {

                        card.name = "instantiated3HandCard54a";

                    } else if (card.name == "instantiated3Card54b(Clone)") {

                        card.name = "instantiated3HandCard54b";

                    } else if (card.name == "instantiated3Card54c(Clone)") {

                        card.name = "instantiated3HandCard54c";

                    } else if (card.name == "instantiated3Card55(Clone)") {

                        card.name = "instantiated3HandCard55";

                    } else if (card.name == "instantiated3Card55a(Clone)") {

                        card.name = "instantiated3HandCard55a";

                    } else if (card.name == "instantiated3Card55b(Clone)") {

                        card.name = "instantiated3HandCard55b";

                    } else if (card.name == "instantiated3Card55c(Clone)") {

                        card.name = "instantiated3HandCard55c";

                    } else if (card.name == "instantiated3Card56(Clone)") {

                        card.name = "instantiated3HandCard56";

                    } else if (card.name == "instantiated3Card56a(Clone)") {

                        card.name = "instantiated3HandCard56a";

                    } else if (card.name == "instantiated3Card56b(Clone)") {

                        card.name = "instantiated3HandCard56b";

                    } else if (card.name == "instantiated3Card56c(Clone)") {

                        card.name = "instantiated3HandCard56c";

                    } else if (card.name == "instantiated3Card57(Clone)") {

                        card.name = "instantiated3HandCard57";

                    } else if (card.name == "instantiated3Card57a(Clone)") {

                        card.name = "instantiated3HandCard57a";

                    } else if (card.name == "instantiated3Card57b(Clone)") {

                        card.name = "instantiated3HandCard57b";

                    } else if (card.name == "instantiated3Card57c(Clone)") {

                        card.name = "instantiated3HandCard57c";

                    } else if (card.name == "instantiated3Card58(Clone)") {

                        card.name = "instantiated3HandCard58";

                    } else if (card.name == "instantiated3Card58a(Clone)") {

                        card.name = "instantiated3HandCard58a";

                    } else if (card.name == "instantiated3Card58b(Clone)") {

                        card.name = "instantiated3HandCard58b";

                    } else if (card.name == "instantiated3Card58c(Clone)") {

                        card.name = "instantiated3HandCard58c";

                    } else if (card.name == "instantiated3Card59(Clone)") {

                        card.name = "instantiated3HandCard59";

                    } else if (card.name == "instantiated3Card59a(Clone)") {

                        card.name = "instantiated3HandCard59a";

                    } else if (card.name == "instantiated3Card59b(Clone)") {

                        card.name = "instantiated3HandCard59b";

                    } else if (card.name == "instantiated3Card59c(Clone)") {

                        card.name = "instantiated3HandCard59c";

                    } else if (card.name == "instantiated3Card60(Clone)") {

                        card.name = "instantiated3HandCard60";

                    } else if (card.name == "instantiated3Card60a(Clone)") {

                        card.name = "instantiated3HandCard60a";

                    } else if (card.name == "instantiated3Card60b(Clone)") {

                        card.name = "instantiated3HandCard60b";

                    } else if (card.name == "instantiated3Card60c(Clone)") {

                        card.name = "instantiated3HandCard60c";
                    }

                    instances10M++;

                }

            }

            doneButton3.SetActive(false);
            handCardCollection.SetActive(false);
        }


        IEnumerator GetHandCards() {

            yield return new WaitForSeconds(3);

            allObjects1 = GameObject.FindObjectsOfType(typeof(GameObject)) as GameObject[];

            foreach (GameObject obj in allObjects1) {
                if (obj.name.Contains("instantiated3HandCard")) {

                    getHandCardsDeck3.Add(obj);

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

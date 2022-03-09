﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.UI;

namespace Caerwent {

    public class SaveCardDeck1 : MonoBehaviour {

        /*
            *
            * Deck 1 manipulation file: two classes
            *
            *	The binary file is saved in this path:
            * Windows: C:/Users/Litech/AppData/LocalLow/DefaultCompany/Card Game/cardsDeck1.dat
            *
        */

        //Static reference variable for this class
        public static SaveCardDeck1 saveCardDeck1;
        //Static constant variable for the binary file containing persistent data
        public static readonly string BINARY_FILE1 = "cardsDeck1.dat";

        #region Variables definition

        public string deckName1;
        public static List<GameObject> editDeck1 = new List<GameObject>();
        public List<string> cardsDeck1 = new List<string>();
        public List<Vector3> spawnPointsDeck1 = new List<Vector3>();
        public List<GameObject> slotsWithChildren = new List<GameObject>();
        public List<GameObject> deck1Slots = new List<GameObject>();

        //Card model scales to lock and unlock the card model
        private Vector3 modelCardScale;
        private Vector3 lockedCardScale;

        //Arrays to get all game objects on the scene to find needed game objects
        private GameObject[] allObjects;
        private GameObject[] allObjects1;
        private GameObject[] allObjects2;

        //private GameObject spawnPointList;

        //UI variables
        private GameObject inputFieldSwitcher1;
        private GameObject warningNameText;
        private GameObject warningCardsText;
        private GameObject deckSavedText;
        public GameObject create1Button;
        private GameObject edit1Button;
        private GameObject save1Button;
        public GameObject delete1Button;
        private GameObject deckNamelabel;
        private GameObject deck1NameButton;
        private GameObject deck1NameInputField;

        public GameObject deck1Button;
        public GameObject deck2Button;
        public GameObject deck3Button;

        //Add the spawn points of the deck again to edit the deck
        private bool addEditSpawnPoints;
        //Set the initial number of the same cards only once in editing the deck
        private bool getDeck;

        public bool isDeck1Editing;

        //Slots to spawn cards of the deck
        private GameObject deck1Slot1;
        private GameObject deck1Slot2;
        private GameObject deck1Slot3;
        private GameObject deck1Slot4;
        private GameObject deck1Slot5;
        private GameObject deck1Slot6;
        private GameObject deck1Slot7;
        private GameObject deck1Slot8;
        private GameObject deck1Slot9;
        private GameObject deck1Slot10;
        private GameObject deck1Slot11;
        private GameObject deck1Slot12;
        private GameObject deck1Slot13;
        private GameObject deck1Slot14;
        private GameObject deck1Slot15;
        private GameObject deck1Slot16;
        private GameObject deck1Slot17;
        private GameObject deck1Slot18;
        private GameObject deck1Slot19;
        private GameObject deck1Slot20;
        private GameObject deck1Slot21;
        private GameObject deck1Slot22;
        private GameObject deck1Slot23;
        private GameObject deck1Slot24;
        private GameObject deck1Slot25;
        private GameObject deck1Slot26;
        private GameObject deck1Slot27;
        private GameObject deck1Slot28;
        private GameObject deck1Slot29;
        private GameObject deck1Slot30;
        private GameObject deck1Slot31;
        private GameObject deck1Slot32;
        private GameObject deck1Slot33;
        private GameObject deck1Slot34;
        private GameObject deck1Slot35;
        private GameObject deck1Slot36;
        private GameObject deck1Slot37;
        private GameObject deck1Slot38;
        private GameObject deck1Slot39;
        private GameObject deck1Slot40;
        private GameObject deck1Slot41;
        private GameObject deck1Slot42;
        private GameObject deck1Slot43;
        private GameObject deck1Slot44;
        private GameObject deck1Slot45;
        private GameObject deck1Slot46;
        private GameObject deck1Slot47;
        private GameObject deck1Slot48;
        private GameObject deck1Slot49;
        private GameObject deck1Slot50;
        private GameObject deck1Slot51;
        private GameObject deck1Slot52;
        private GameObject deck1Slot53;
        private GameObject deck1Slot54;
        private GameObject deck1Slot55;
        private GameObject deck1Slot56;
        private GameObject deck1Slot57;
        private GameObject deck1Slot58;
        private GameObject deck1Slot59;
        private GameObject deck1Slot60;

        //Spawn points of the cards
        private Vector3 spawnPoint1;
        private Vector3 spawnPoint1a;
        private Vector3 spawnPoint1b;
        private Vector3 spawnPoint1c;
        private Vector3 spawnPoint2;
        private Vector3 spawnPoint2a;
        private Vector3 spawnPoint2b;
        private Vector3 spawnPoint2c;
        private Vector3 spawnPoint3;
        private Vector3 spawnPoint3a;
        private Vector3 spawnPoint3b;
        private Vector3 spawnPoint3c;
        private Vector3 spawnPoint4;
        private Vector3 spawnPoint4a;
        private Vector3 spawnPoint4b;
        private Vector3 spawnPoint4c;
        private Vector3 spawnPoint5;
        private Vector3 spawnPoint5a;
        private Vector3 spawnPoint5b;
        private Vector3 spawnPoint5c;
        private Vector3 spawnPoint6;
        private Vector3 spawnPoint6a;
        private Vector3 spawnPoint6b;
        private Vector3 spawnPoint6c;
        private Vector3 spawnPoint7;
        private Vector3 spawnPoint7a;
        private Vector3 spawnPoint7b;
        private Vector3 spawnPoint7c;
        private Vector3 spawnPoint8;
        private Vector3 spawnPoint8a;
        private Vector3 spawnPoint8b;
        private Vector3 spawnPoint8c;
        private Vector3 spawnPoint9;
        private Vector3 spawnPoint9a;
        private Vector3 spawnPoint9b;
        private Vector3 spawnPoint9c;
        private Vector3 spawnPoint10;
        private Vector3 spawnPoint10a;
        private Vector3 spawnPoint10b;
        private Vector3 spawnPoint10c;
        private Vector3 spawnPoint11;
        private Vector3 spawnPoint11a;
        private Vector3 spawnPoint11b;
        private Vector3 spawnPoint11c;
        private Vector3 spawnPoint12;
        private Vector3 spawnPoint12a;
        private Vector3 spawnPoint12b;
        private Vector3 spawnPoint12c;
        private Vector3 spawnPoint13;
        private Vector3 spawnPoint13a;
        private Vector3 spawnPoint13b;
        private Vector3 spawnPoint13c;
        private Vector3 spawnPoint14;
        private Vector3 spawnPoint14a;
        private Vector3 spawnPoint14b;
        private Vector3 spawnPoint14c;
        private Vector3 spawnPoint15;
        private Vector3 spawnPoint15a;
        private Vector3 spawnPoint15b;
        private Vector3 spawnPoint15c;
        private Vector3 spawnPoint16;
        private Vector3 spawnPoint16a;
        private Vector3 spawnPoint16b;
        private Vector3 spawnPoint16c;
        private Vector3 spawnPoint17;
        private Vector3 spawnPoint17a;
        private Vector3 spawnPoint17b;
        private Vector3 spawnPoint17c;
        private Vector3 spawnPoint18;
        private Vector3 spawnPoint18a;
        private Vector3 spawnPoint18b;
        private Vector3 spawnPoint18c;
        private Vector3 spawnPoint19;
        private Vector3 spawnPoint19a;
        private Vector3 spawnPoint19b;
        private Vector3 spawnPoint19c;
        private Vector3 spawnPoint20;
        private Vector3 spawnPoint20a;
        private Vector3 spawnPoint20b;
        private Vector3 spawnPoint20c;
        private Vector3 spawnPoint21;
        private Vector3 spawnPoint21a;
        private Vector3 spawnPoint21b;
        private Vector3 spawnPoint21c;
        private Vector3 spawnPoint22;
        private Vector3 spawnPoint22a;
        private Vector3 spawnPoint22b;
        private Vector3 spawnPoint22c;
        private Vector3 spawnPoint23;
        private Vector3 spawnPoint23a;
        private Vector3 spawnPoint23b;
        private Vector3 spawnPoint23c;
        private Vector3 spawnPoint24;
        private Vector3 spawnPoint24a;
        private Vector3 spawnPoint24b;
        private Vector3 spawnPoint24c;
        private Vector3 spawnPoint25;
        private Vector3 spawnPoint25a;
        private Vector3 spawnPoint25b;
        private Vector3 spawnPoint25c;
        private Vector3 spawnPoint26;
        private Vector3 spawnPoint26a;
        private Vector3 spawnPoint26b;
        private Vector3 spawnPoint26c;
        private Vector3 spawnPoint27;
        private Vector3 spawnPoint27a;
        private Vector3 spawnPoint27b;
        private Vector3 spawnPoint27c;
        private Vector3 spawnPoint28;
        private Vector3 spawnPoint28a;
        private Vector3 spawnPoint28b;
        private Vector3 spawnPoint28c;
        private Vector3 spawnPoint29;
        private Vector3 spawnPoint29a;
        private Vector3 spawnPoint29b;
        private Vector3 spawnPoint29c;
        private Vector3 spawnPoint30;
        private Vector3 spawnPoint30a;
        private Vector3 spawnPoint30b;
        private Vector3 spawnPoint30c;
        private Vector3 spawnPoint31;
        private Vector3 spawnPoint31a;
        private Vector3 spawnPoint31b;
        private Vector3 spawnPoint31c;
        private Vector3 spawnPoint32;
        private Vector3 spawnPoint32a;
        private Vector3 spawnPoint32b;
        private Vector3 spawnPoint32c;
        private Vector3 spawnPoint33;
        private Vector3 spawnPoint33a;
        private Vector3 spawnPoint33b;
        private Vector3 spawnPoint33c;
        private Vector3 spawnPoint34;
        private Vector3 spawnPoint34a;
        private Vector3 spawnPoint34b;
        private Vector3 spawnPoint34c;
        private Vector3 spawnPoint35;
        private Vector3 spawnPoint35a;
        private Vector3 spawnPoint35b;
        private Vector3 spawnPoint35c;
        private Vector3 spawnPoint36;
        private Vector3 spawnPoint36a;
        private Vector3 spawnPoint36b;
        private Vector3 spawnPoint36c;
        private Vector3 spawnPoint37;
        private Vector3 spawnPoint37a;
        private Vector3 spawnPoint37b;
        private Vector3 spawnPoint37c;
        private Vector3 spawnPoint38;
        private Vector3 spawnPoint38a;
        private Vector3 spawnPoint38b;
        private Vector3 spawnPoint38c;
        private Vector3 spawnPoint39;
        private Vector3 spawnPoint39a;
        private Vector3 spawnPoint39b;
        private Vector3 spawnPoint39c;
        private Vector3 spawnPoint40;
        private Vector3 spawnPoint40a;
        private Vector3 spawnPoint40b;
        private Vector3 spawnPoint40c;
        private Vector3 spawnPoint41;
        private Vector3 spawnPoint41a;
        private Vector3 spawnPoint41b;
        private Vector3 spawnPoint41c;
        private Vector3 spawnPoint42;
        private Vector3 spawnPoint42a;
        private Vector3 spawnPoint42b;
        private Vector3 spawnPoint42c;
        private Vector3 spawnPoint43;
        private Vector3 spawnPoint43a;
        private Vector3 spawnPoint43b;
        private Vector3 spawnPoint43c;
        private Vector3 spawnPoint44;
        private Vector3 spawnPoint44a;
        private Vector3 spawnPoint44b;
        private Vector3 spawnPoint44c;
        private Vector3 spawnPoint45;
        private Vector3 spawnPoint45a;
        private Vector3 spawnPoint45b;
        private Vector3 spawnPoint45c;
        private Vector3 spawnPoint46;
        private Vector3 spawnPoint46a;
        private Vector3 spawnPoint46b;
        private Vector3 spawnPoint46c;
        private Vector3 spawnPoint47;
        private Vector3 spawnPoint47a;
        private Vector3 spawnPoint47b;
        private Vector3 spawnPoint47c;
        private Vector3 spawnPoint48;
        private Vector3 spawnPoint48a;
        private Vector3 spawnPoint48b;
        private Vector3 spawnPoint48c;
        private Vector3 spawnPoint49;
        private Vector3 spawnPoint49a;
        private Vector3 spawnPoint49b;
        private Vector3 spawnPoint49c;
        private Vector3 spawnPoint50;
        private Vector3 spawnPoint50a;
        private Vector3 spawnPoint50b;
        private Vector3 spawnPoint50c;
        private Vector3 spawnPoint51;
        private Vector3 spawnPoint51a;
        private Vector3 spawnPoint51b;
        private Vector3 spawnPoint51c;
        private Vector3 spawnPoint52;
        private Vector3 spawnPoint52a;
        private Vector3 spawnPoint52b;
        private Vector3 spawnPoint52c;
        private Vector3 spawnPoint53;
        private Vector3 spawnPoint53a;
        private Vector3 spawnPoint53b;
        private Vector3 spawnPoint53c;
        private Vector3 spawnPoint54;
        private Vector3 spawnPoint54a;
        private Vector3 spawnPoint54b;
        private Vector3 spawnPoint54c;
        private Vector3 spawnPoint55;
        private Vector3 spawnPoint55a;
        private Vector3 spawnPoint55b;
        private Vector3 spawnPoint55c;
        private Vector3 spawnPoint56;
        private Vector3 spawnPoint56a;
        private Vector3 spawnPoint56b;
        private Vector3 spawnPoint56c;
        private Vector3 spawnPoint57;
        private Vector3 spawnPoint57a;
        private Vector3 spawnPoint57b;
        private Vector3 spawnPoint57c;
        private Vector3 spawnPoint58;
        private Vector3 spawnPoint58a;
        private Vector3 spawnPoint58b;
        private Vector3 spawnPoint58c;
        private Vector3 spawnPoint59;
        private Vector3 spawnPoint59a;
        private Vector3 spawnPoint59b;
        private Vector3 spawnPoint59c;
        private Vector3 spawnPoint60;
        private Vector3 spawnPoint60a;
        private Vector3 spawnPoint60b;
        private Vector3 spawnPoint60c;

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


        //Card models of the card collection to click to spawn cards in the deck
        [HideInInspector]
        public GameObject cardModel1;
        [HideInInspector]
        public GameObject cardModel1a;
        [HideInInspector]
        public GameObject cardModel1b;
        [HideInInspector]
        public GameObject cardModel1c;
        [HideInInspector]
        public GameObject cardModel2;
        [HideInInspector]
        public GameObject cardModel2a;
        [HideInInspector]
        public GameObject cardModel2b;
        [HideInInspector]
        public GameObject cardModel2c;
        [HideInInspector]
        public GameObject cardModel3;
        [HideInInspector]
        public GameObject cardModel3a;
        [HideInInspector]
        public GameObject cardModel3b;
        [HideInInspector]
        public GameObject cardModel3c;
        [HideInInspector]
        public GameObject cardModel4;
        [HideInInspector]
        public GameObject cardModel4a;
        [HideInInspector]
        public GameObject cardModel4b;
        [HideInInspector]
        public GameObject cardModel4c;
        [HideInInspector]
        public GameObject cardModel5;
        [HideInInspector]
        public GameObject cardModel5a;
        [HideInInspector]
        public GameObject cardModel5b;
        [HideInInspector]
        public GameObject cardModel5c;
        [HideInInspector]
        public GameObject cardModel6;
        [HideInInspector]
        public GameObject cardModel6a;
        [HideInInspector]
        public GameObject cardModel6b;
        [HideInInspector]
        public GameObject cardModel6c;
        [HideInInspector]
        public GameObject cardModel7;
        [HideInInspector]
        public GameObject cardModel7a;
        [HideInInspector]
        public GameObject cardModel7b;
        [HideInInspector]
        public GameObject cardModel7c;
        [HideInInspector]
        public GameObject cardModel8;
        [HideInInspector]
        public GameObject cardModel8a;
        [HideInInspector]
        public GameObject cardModel8b;
        [HideInInspector]
        public GameObject cardModel8c;
        [HideInInspector]
        public GameObject cardModel9;
        [HideInInspector]
        public GameObject cardModel9a;
        [HideInInspector]
        public GameObject cardModel9b;
        [HideInInspector]
        public GameObject cardModel9c;
        [HideInInspector]
        public GameObject cardModel10;
        [HideInInspector]
        public GameObject cardModel10a;
        [HideInInspector]
        public GameObject cardModel10b;
        [HideInInspector]
        public GameObject cardModel10c;
        [HideInInspector]
        public GameObject cardModel11;
        [HideInInspector]
        public GameObject cardModel11a;
        [HideInInspector]
        public GameObject cardModel11b;
        [HideInInspector]
        public GameObject cardModel11c;
        [HideInInspector]
        public GameObject cardModel12;
        [HideInInspector]
        public GameObject cardModel12a;
        [HideInInspector]
        public GameObject cardModel12b;
        [HideInInspector]
        public GameObject cardModel12c;
        [HideInInspector]
        public GameObject cardModel13;
        [HideInInspector]
        public GameObject cardModel13a;
        [HideInInspector]
        public GameObject cardModel13b;
        [HideInInspector]
        public GameObject cardModel13c;
        [HideInInspector]
        public GameObject cardModel14;
        [HideInInspector]
        public GameObject cardModel14a;
        [HideInInspector]
        public GameObject cardModel14b;
        [HideInInspector]
        public GameObject cardModel14c;
        [HideInInspector]
        public GameObject cardModel15;
        [HideInInspector]
        public GameObject cardModel15a;
        [HideInInspector]
        public GameObject cardModel15b;
        [HideInInspector]
        public GameObject cardModel15c;
        [HideInInspector]
        public GameObject cardModel16;
        [HideInInspector]
        public GameObject cardModel16a;
        [HideInInspector]
        public GameObject cardModel16b;
        [HideInInspector]
        public GameObject cardModel16c;
        [HideInInspector]
        public GameObject cardModel17;
        [HideInInspector]
        public GameObject cardModel17a;
        [HideInInspector]
        public GameObject cardModel17b;
        [HideInInspector]
        public GameObject cardModel17c;
        [HideInInspector]
        public GameObject cardModel18;
        [HideInInspector]
        public GameObject cardModel18a;
        [HideInInspector]
        public GameObject cardModel18b;
        [HideInInspector]
        public GameObject cardModel18c;
        [HideInInspector]
        public GameObject cardModel19;
        [HideInInspector]
        public GameObject cardModel19a;
        [HideInInspector]
        public GameObject cardModel19b;
        [HideInInspector]
        public GameObject cardModel19c;
        [HideInInspector]
        public GameObject cardModel20;
        [HideInInspector]
        public GameObject cardModel20a;
        [HideInInspector]
        public GameObject cardModel20b;
        [HideInInspector]
        public GameObject cardModel20c;
        [HideInInspector]
        public GameObject cardModel21;
        [HideInInspector]
        public GameObject cardModel21a;
        [HideInInspector]
        public GameObject cardModel21b;
        [HideInInspector]
        public GameObject cardModel21c;
        [HideInInspector]
        public GameObject cardModel22;
        [HideInInspector]
        public GameObject cardModel22a;
        [HideInInspector]
        public GameObject cardModel22b;
        [HideInInspector]
        public GameObject cardModel22c;
        [HideInInspector]
        public GameObject cardModel23;
        [HideInInspector]
        public GameObject cardModel23a;
        [HideInInspector]
        public GameObject cardModel23b;
        [HideInInspector]
        public GameObject cardModel23c;
        [HideInInspector]
        public GameObject cardModel24;
        [HideInInspector]
        public GameObject cardModel24a;
        [HideInInspector]
        public GameObject cardModel24b;
        [HideInInspector]
        public GameObject cardModel24c;
        [HideInInspector]
        public GameObject cardModel25;
        [HideInInspector]
        public GameObject cardModel25a;
        [HideInInspector]
        public GameObject cardModel25b;
        [HideInInspector]
        public GameObject cardModel25c;
        [HideInInspector]
        public GameObject cardModel26;
        [HideInInspector]
        public GameObject cardModel26a;
        [HideInInspector]
        public GameObject cardModel26b;
        [HideInInspector]
        public GameObject cardModel26c;
        [HideInInspector]
        public GameObject cardModel27;
        [HideInInspector]
        public GameObject cardModel27a;
        [HideInInspector]
        public GameObject cardModel27b;
        [HideInInspector]
        public GameObject cardModel27c;
        [HideInInspector]
        public GameObject cardModel28;
        [HideInInspector]
        public GameObject cardModel28a;
        [HideInInspector]
        public GameObject cardModel28b;
        [HideInInspector]
        public GameObject cardModel28c;
        [HideInInspector]
        public GameObject cardModel29;
        [HideInInspector]
        public GameObject cardModel29a;
        [HideInInspector]
        public GameObject cardModel29b;
        [HideInInspector]
        public GameObject cardModel29c;
        [HideInInspector]
        public GameObject cardModel30;
        [HideInInspector]
        public GameObject cardModel30a;
        [HideInInspector]
        public GameObject cardModel30b;
        [HideInInspector]
        public GameObject cardModel30c;
        [HideInInspector]
        public GameObject cardModel31;
        [HideInInspector]
        public GameObject cardModel31a;
        [HideInInspector]
        public GameObject cardModel31b;
        [HideInInspector]
        public GameObject cardModel31c;
        [HideInInspector]
        public GameObject cardModel32;
        [HideInInspector]
        public GameObject cardModel32a;
        [HideInInspector]
        public GameObject cardModel32b;
        [HideInInspector]
        public GameObject cardModel32c;
        [HideInInspector]
        public GameObject cardModel33;
        [HideInInspector]
        public GameObject cardModel33a;
        [HideInInspector]
        public GameObject cardModel33b;
        [HideInInspector]
        public GameObject cardModel33c;
        [HideInInspector]
        public GameObject cardModel34;
        [HideInInspector]
        public GameObject cardModel34a;
        [HideInInspector]
        public GameObject cardModel34b;
        [HideInInspector]
        public GameObject cardModel34c;
        [HideInInspector]
        public GameObject cardModel35;
        [HideInInspector]
        public GameObject cardModel35a;
        [HideInInspector]
        public GameObject cardModel35b;
        [HideInInspector]
        public GameObject cardModel35c;
        [HideInInspector]
        public GameObject cardModel36;
        [HideInInspector]
        public GameObject cardModel36a;
        [HideInInspector]
        public GameObject cardModel36b;
        [HideInInspector]
        public GameObject cardModel36c;
        [HideInInspector]
        public GameObject cardModel37;
        [HideInInspector]
        public GameObject cardModel37a;
        [HideInInspector]
        public GameObject cardModel37b;
        [HideInInspector]
        public GameObject cardModel37c;
        [HideInInspector]
        public GameObject cardModel38;
        [HideInInspector]
        public GameObject cardModel38a;
        [HideInInspector]
        public GameObject cardModel38b;
        [HideInInspector]
        public GameObject cardModel38c;
        [HideInInspector]
        public GameObject cardModel39;
        [HideInInspector]
        public GameObject cardModel39a;
        [HideInInspector]
        public GameObject cardModel39b;
        [HideInInspector]
        public GameObject cardModel39c;
        [HideInInspector]
        public GameObject cardModel40;
        [HideInInspector]
        public GameObject cardModel40a;
        [HideInInspector]
        public GameObject cardModel40b;
        [HideInInspector]
        public GameObject cardModel40c;
        [HideInInspector]
        public GameObject cardModel41;
        [HideInInspector]
        public GameObject cardModel41a;
        [HideInInspector]
        public GameObject cardModel41b;
        [HideInInspector]
        public GameObject cardModel41c;
        [HideInInspector]
        public GameObject cardModel42;
        [HideInInspector]
        public GameObject cardModel42a;
        [HideInInspector]
        public GameObject cardModel42b;
        [HideInInspector]
        public GameObject cardModel42c;
        [HideInInspector]
        public GameObject cardModel43;
        [HideInInspector]
        public GameObject cardModel43a;
        [HideInInspector]
        public GameObject cardModel43b;
        [HideInInspector]
        public GameObject cardModel43c;
        [HideInInspector]
        public GameObject cardModel44;
        [HideInInspector]
        public GameObject cardModel44a;
        [HideInInspector]
        public GameObject cardModel44b;
        [HideInInspector]
        public GameObject cardModel44c;
        [HideInInspector]
        public GameObject cardModel45;
        [HideInInspector]
        public GameObject cardModel45a;
        [HideInInspector]
        public GameObject cardModel45b;
        [HideInInspector]
        public GameObject cardModel45c;
        [HideInInspector]
        public GameObject cardModel46;
        [HideInInspector]
        public GameObject cardModel46a;
        [HideInInspector]
        public GameObject cardModel46b;
        [HideInInspector]
        public GameObject cardModel46c;
        [HideInInspector]
        public GameObject cardModel47;
        [HideInInspector]
        public GameObject cardModel47a;
        [HideInInspector]
        public GameObject cardModel47b;
        [HideInInspector]
        public GameObject cardModel47c;
        [HideInInspector]
        public GameObject cardModel48;
        [HideInInspector]
        public GameObject cardModel48a;
        [HideInInspector]
        public GameObject cardModel48b;
        [HideInInspector]
        public GameObject cardModel48c;
        [HideInInspector]
        public GameObject cardModel49;
        [HideInInspector]
        public GameObject cardModel49a;
        [HideInInspector]
        public GameObject cardModel49b;
        [HideInInspector]
        public GameObject cardModel49c;
        [HideInInspector]
        public GameObject cardModel50;
        [HideInInspector]
        public GameObject cardModel50a;
        [HideInInspector]
        public GameObject cardModel50b;
        [HideInInspector]
        public GameObject cardModel50c;
        [HideInInspector]
        public GameObject cardModel51;
        [HideInInspector]
        public GameObject cardModel51a;
        [HideInInspector]
        public GameObject cardModel51b;
        [HideInInspector]
        public GameObject cardModel51c;
        [HideInInspector]
        public GameObject cardModel52;
        [HideInInspector]
        public GameObject cardModel52a;
        [HideInInspector]
        public GameObject cardModel52b;
        [HideInInspector]
        public GameObject cardModel52c;
        [HideInInspector]
        public GameObject cardModel53;
        [HideInInspector]
        public GameObject cardModel53a;
        [HideInInspector]
        public GameObject cardModel53b;
        [HideInInspector]
        public GameObject cardModel53c;
        [HideInInspector]
        public GameObject cardModel54;
        [HideInInspector]
        public GameObject cardModel54a;
        [HideInInspector]
        public GameObject cardModel54b;
        [HideInInspector]
        public GameObject cardModel54c;
        [HideInInspector]
        public GameObject cardModel55;
        [HideInInspector]
        public GameObject cardModel55a;
        [HideInInspector]
        public GameObject cardModel55b;
        [HideInInspector]
        public GameObject cardModel55c;
        [HideInInspector]
        public GameObject cardModel56;
        [HideInInspector]
        public GameObject cardModel56a;
        [HideInInspector]
        public GameObject cardModel56b;
        [HideInInspector]
        public GameObject cardModel56c;
        [HideInInspector]
        public GameObject cardModel57;
        [HideInInspector]
        public GameObject cardModel57a;
        [HideInInspector]
        public GameObject cardModel57b;
        [HideInInspector]
        public GameObject cardModel57c;
        [HideInInspector]
        public GameObject cardModel58;
        [HideInInspector]
        public GameObject cardModel58a;
        [HideInInspector]
        public GameObject cardModel58b;
        [HideInInspector]
        public GameObject cardModel58c;
        [HideInInspector]
        public GameObject cardModel59;
        [HideInInspector]
        public GameObject cardModel59a;
        [HideInInspector]
        public GameObject cardModel59b;
        [HideInInspector]
        public GameObject cardModel59c;
        [HideInInspector]
        public GameObject cardModel60;
        [HideInInspector]
        public GameObject cardModel60a;
        [HideInInspector]
        public GameObject cardModel60b;
        [HideInInspector]
        public GameObject cardModel60c;


        //Spawn points for the deck manipulation (temporary storing deck outside the screen)
        private Vector3 spawnPoints1 = new Vector3(0.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints2 = new Vector3(2.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints3 = new Vector3(4.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints4 = new Vector3(6.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints5 = new Vector3(8.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints6 = new Vector3(10.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints7 = new Vector3(12.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints8 = new Vector3(14.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints9 = new Vector3(16.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints10 = new Vector3(18.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints11 = new Vector3(20.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints12 = new Vector3(22.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints13 = new Vector3(24.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints14 = new Vector3(26.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints15 = new Vector3(28.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints16 = new Vector3(30.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints17 = new Vector3(32.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints18 = new Vector3(34.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints19 = new Vector3(36.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints20 = new Vector3(38.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints21 = new Vector3(40.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints22 = new Vector3(42.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints23 = new Vector3(44.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints24 = new Vector3(46.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints25 = new Vector3(48.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints26 = new Vector3(50.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints27 = new Vector3(52.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints28 = new Vector3(54.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints29 = new Vector3(56.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints30 = new Vector3(58.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints31 = new Vector3(60.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints32 = new Vector3(62.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints33 = new Vector3(64.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints34 = new Vector3(66.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints35 = new Vector3(68.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints36 = new Vector3(70.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints37 = new Vector3(72.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints38 = new Vector3(74.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints39 = new Vector3(76.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints40 = new Vector3(78.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints41 = new Vector3(80.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints42 = new Vector3(82.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints43 = new Vector3(84.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints44 = new Vector3(86.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints45 = new Vector3(88.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints46 = new Vector3(90.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints47 = new Vector3(92.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints48 = new Vector3(94.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints49 = new Vector3(96.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints50 = new Vector3(98.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints51 = new Vector3(100.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints52 = new Vector3(102.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints53 = new Vector3(104.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints54 = new Vector3(106.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints55 = new Vector3(108.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints56 = new Vector3(110.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints57 = new Vector3(112.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints58 = new Vector3(114.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints59 = new Vector3(116.0f, 0.0f, -50.0f);
        private Vector3 spawnPoints60 = new Vector3(118.0f, 0.0f, -50.0f);

        //Lists to check how many the same cards are in the deck
        public static List<GameObject> instantiated1Card1List = new List<GameObject>();
        public static List<GameObject> instantiated1Card1aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card1bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card1cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card2List = new List<GameObject>();
        public static List<GameObject> instantiated1Card2aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card2bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card2cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card3List = new List<GameObject>();
        public static List<GameObject> instantiated1Card3aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card3bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card3cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card4List = new List<GameObject>();
        public static List<GameObject> instantiated1Card4aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card4bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card4cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card5List = new List<GameObject>();
        public static List<GameObject> instantiated1Card5aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card5bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card5cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card6List = new List<GameObject>();
        public static List<GameObject> instantiated1Card6aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card6bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card6cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card7List = new List<GameObject>();
        public static List<GameObject> instantiated1Card7aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card7bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card7cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card8List = new List<GameObject>();
        public static List<GameObject> instantiated1Card8aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card8bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card8cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card9List = new List<GameObject>();
        public static List<GameObject> instantiated1Card9aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card9bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card9cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card10List = new List<GameObject>();
        public static List<GameObject> instantiated1Card10aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card10bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card10cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card11List = new List<GameObject>();
        public static List<GameObject> instantiated1Card11aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card11bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card11cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card12List = new List<GameObject>();
        public static List<GameObject> instantiated1Card12aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card12bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card12cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card13List = new List<GameObject>();
        public static List<GameObject> instantiated1Card13aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card13bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card13cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card14List = new List<GameObject>();
        public static List<GameObject> instantiated1Card14aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card14bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card14cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card15List = new List<GameObject>();
        public static List<GameObject> instantiated1Card15aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card15bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card15cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card16List = new List<GameObject>();
        public static List<GameObject> instantiated1Card16aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card16bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card16cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card17List = new List<GameObject>();
        public static List<GameObject> instantiated1Card17aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card17bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card17cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card18List = new List<GameObject>();
        public static List<GameObject> instantiated1Card18aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card18bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card18cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card19List = new List<GameObject>();
        public static List<GameObject> instantiated1Card19aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card19bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card19cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card20List = new List<GameObject>();
        public static List<GameObject> instantiated1Card20aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card20bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card20cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card21List = new List<GameObject>();
        public static List<GameObject> instantiated1Card21aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card21bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card21cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card22List = new List<GameObject>();
        public static List<GameObject> instantiated1Card22aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card22bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card22cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card23List = new List<GameObject>();
        public static List<GameObject> instantiated1Card23aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card23bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card23cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card24List = new List<GameObject>();
        public static List<GameObject> instantiated1Card24aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card24bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card24cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card25List = new List<GameObject>();
        public static List<GameObject> instantiated1Card25aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card25bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card25cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card26List = new List<GameObject>();
        public static List<GameObject> instantiated1Card26aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card26bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card26cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card27List = new List<GameObject>();
        public static List<GameObject> instantiated1Card27aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card27bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card27cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card28List = new List<GameObject>();
        public static List<GameObject> instantiated1Card28aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card28bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card28cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card29List = new List<GameObject>();
        public static List<GameObject> instantiated1Card29aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card29bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card29cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card30List = new List<GameObject>();
        public static List<GameObject> instantiated1Card30aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card30bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card30cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card31List = new List<GameObject>();
        public static List<GameObject> instantiated1Card31aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card31bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card31cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card32List = new List<GameObject>();
        public static List<GameObject> instantiated1Card32aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card32bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card32cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card33List = new List<GameObject>();
        public static List<GameObject> instantiated1Card33aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card33bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card33cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card34List = new List<GameObject>();
        public static List<GameObject> instantiated1Card34aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card34bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card34cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card35List = new List<GameObject>();
        public static List<GameObject> instantiated1Card35aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card35bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card35cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card36List = new List<GameObject>();
        public static List<GameObject> instantiated1Card36aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card36bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card36cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card37List = new List<GameObject>();
        public static List<GameObject> instantiated1Card37aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card37bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card37cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card38List = new List<GameObject>();
        public static List<GameObject> instantiated1Card38aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card38bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card38cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card39List = new List<GameObject>();
        public static List<GameObject> instantiated1Card39aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card39bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card39cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card40List = new List<GameObject>();
        public static List<GameObject> instantiated1Card40aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card40bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card40cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card41List = new List<GameObject>();
        public static List<GameObject> instantiated1Card41aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card41bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card41cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card42List = new List<GameObject>();
        public static List<GameObject> instantiated1Card42aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card42bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card42cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card43List = new List<GameObject>();
        public static List<GameObject> instantiated1Card43aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card43bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card43cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card44List = new List<GameObject>();
        public static List<GameObject> instantiated1Card44aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card44bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card44cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card45List = new List<GameObject>();
        public static List<GameObject> instantiated1Card45aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card45bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card45cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card46List = new List<GameObject>();
        public static List<GameObject> instantiated1Card46aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card46bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card46cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card47List = new List<GameObject>();
        public static List<GameObject> instantiated1Card47aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card47bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card47cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card48List = new List<GameObject>();
        public static List<GameObject> instantiated1Card48aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card48bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card48cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card49List = new List<GameObject>();
        public static List<GameObject> instantiated1Card49aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card49bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card49cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card50List = new List<GameObject>();
        public static List<GameObject> instantiated1Card50aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card50bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card50cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card51List = new List<GameObject>();
        public static List<GameObject> instantiated1Card51aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card51bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card51cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card52List = new List<GameObject>();
        public static List<GameObject> instantiated1Card52aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card52bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card52cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card53List = new List<GameObject>();
        public static List<GameObject> instantiated1Card53aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card53bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card53cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card54List = new List<GameObject>();
        public static List<GameObject> instantiated1Card54aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card54bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card54cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card55List = new List<GameObject>();
        public static List<GameObject> instantiated1Card55aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card55bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card55cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card56List = new List<GameObject>();
        public static List<GameObject> instantiated1Card56aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card56bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card56cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card57List = new List<GameObject>();
        public static List<GameObject> instantiated1Card57aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card57bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card57cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card58List = new List<GameObject>();
        public static List<GameObject> instantiated1Card58aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card58bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card58cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card59List = new List<GameObject>();
        public static List<GameObject> instantiated1Card59aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card59bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card59cList = new List<GameObject>();
        public static List<GameObject> instantiated1Card60List = new List<GameObject>();
        public static List<GameObject> instantiated1Card60aList = new List<GameObject>();
        public static List<GameObject> instantiated1Card60bList = new List<GameObject>();
        public static List<GameObject> instantiated1Card60cList = new List<GameObject>();


        #endregion

        void Awake() {

            //Make this class singletone (only one instance in application)
            if (saveCardDeck1 == null) {

                DontDestroyOnLoad(gameObject);
                saveCardDeck1 = this;

            } else if (saveCardDeck1 != this) {

                Destroy(gameObject);

            }

            //Finding needed game objects
            //spawnPointList = GameObject.Find("PanelWithDeckSlots");
            inputFieldSwitcher1 = GameObject.Find("InputFieldSwitcher1");
            warningNameText = GameObject.Find("WarningNameText");
            warningCardsText = GameObject.Find("WarningCardsText");
            deckSavedText = GameObject.Find("DeckSavedText");
            create1Button = GameObject.Find("Create1");
            edit1Button = GameObject.Find("Edit1");
            save1Button = GameObject.Find("Save1");
            delete1Button = GameObject.Find("Delete1");
            deckNamelabel = GameObject.Find("DeckNameLabel");
            deck1NameButton = GameObject.Find("Deck1Text");
            deck1NameInputField = GameObject.Find("InputFieldDeck1");

            deck1Button = GameObject.Find("Deck1Buttons");
            deck2Button = GameObject.Find("Deck2Buttons");
            deck3Button = GameObject.Find("Deck3Buttons");

            deck1Slot1 = GameObject.Find("Deck1Slot1");
            deck1Slot2 = GameObject.Find("Deck1Slot2");
            deck1Slot3 = GameObject.Find("Deck1Slot3");
            deck1Slot4 = GameObject.Find("Deck1Slot4");
            deck1Slot5 = GameObject.Find("Deck1Slot5");
            deck1Slot6 = GameObject.Find("Deck1Slot6");
            deck1Slot7 = GameObject.Find("Deck1Slot7");
            deck1Slot8 = GameObject.Find("Deck1Slot8");
            deck1Slot9 = GameObject.Find("Deck1Slot9");
            deck1Slot10 = GameObject.Find("Deck1Slot10");
            deck1Slot11 = GameObject.Find("Deck1Slot11");
            deck1Slot12 = GameObject.Find("Deck1Slot12");
            deck1Slot13 = GameObject.Find("Deck1Slot13");
            deck1Slot14 = GameObject.Find("Deck1Slot14");
            deck1Slot15 = GameObject.Find("Deck1Slot15");
            deck1Slot16 = GameObject.Find("Deck1Slot16");
            deck1Slot17 = GameObject.Find("Deck1Slot17");
            deck1Slot18 = GameObject.Find("Deck1Slot18");
            deck1Slot19 = GameObject.Find("Deck1Slot19");
            deck1Slot20 = GameObject.Find("Deck1Slot20");
            deck1Slot21 = GameObject.Find("Deck1Slot21");
            deck1Slot22 = GameObject.Find("Deck1Slot22");
            deck1Slot23 = GameObject.Find("Deck1Slot23");
            deck1Slot24 = GameObject.Find("Deck1Slot24");
            deck1Slot25 = GameObject.Find("Deck1Slot25");
            deck1Slot26 = GameObject.Find("Deck1Slot26");
            deck1Slot27 = GameObject.Find("Deck1Slot27");
            deck1Slot28 = GameObject.Find("Deck1Slot28");
            deck1Slot29 = GameObject.Find("Deck1Slot29");
            deck1Slot30 = GameObject.Find("Deck1Slot30");
            deck1Slot31 = GameObject.Find("Deck1Slot31");
            deck1Slot32 = GameObject.Find("Deck1Slot32");
            deck1Slot33 = GameObject.Find("Deck1Slot33");
            deck1Slot34 = GameObject.Find("Deck1Slot34");
            deck1Slot35 = GameObject.Find("Deck1Slot35");
            deck1Slot36 = GameObject.Find("Deck1Slot36");
            deck1Slot37 = GameObject.Find("Deck1Slot37");
            deck1Slot38 = GameObject.Find("Deck1Slot38");
            deck1Slot39 = GameObject.Find("Deck1Slot39");
            deck1Slot40 = GameObject.Find("Deck1Slot40");
            deck1Slot41 = GameObject.Find("Deck1Slot41");
            deck1Slot42 = GameObject.Find("Deck1Slot42");
            deck1Slot43 = GameObject.Find("Deck1Slot43");
            deck1Slot44 = GameObject.Find("Deck1Slot44");
            deck1Slot45 = GameObject.Find("Deck1Slot45");
            deck1Slot46 = GameObject.Find("Deck1Slot46");
            deck1Slot47 = GameObject.Find("Deck1Slot47");
            deck1Slot48 = GameObject.Find("Deck1Slot48");
            deck1Slot49 = GameObject.Find("Deck1Slot49");
            deck1Slot50 = GameObject.Find("Deck1Slot50");
            deck1Slot51 = GameObject.Find("Deck1Slot51");
            deck1Slot52 = GameObject.Find("Deck1Slot52");
            deck1Slot53 = GameObject.Find("Deck1Slot53");
            deck1Slot54 = GameObject.Find("Deck1Slot54");
            deck1Slot55 = GameObject.Find("Deck1Slot55");
            deck1Slot56 = GameObject.Find("Deck1Slot56");
            deck1Slot57 = GameObject.Find("Deck1Slot57");
            deck1Slot58 = GameObject.Find("Deck1Slot58");
            deck1Slot59 = GameObject.Find("Deck1Slot59");
            deck1Slot60 = GameObject.Find("Deck1Slot60");

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

        void Start() {

            modelCardScale = new Vector3(2025.0f, 200.0f, 2040.0f);
            lockedCardScale = new Vector3(1025.0f, 200.0f, 1040.0f);

            inputFieldSwitcher1.SetActive(false);
            warningNameText.SetActive(false);
            warningCardsText.SetActive(false);
            deckSavedText.SetActive(false);

            getDeck = true;
            addEditSpawnPoints = false;
            isDeck1Editing = true;

            deck1Button.SetActive(false);
            deck2Button.SetActive(false);
            deck3Button.SetActive(false);

            #region StartStuff definition

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
            spawnPointsDeck1.Insert(10, spawnPoints11);
            spawnPointsDeck1.Insert(11, spawnPoints12);
            spawnPointsDeck1.Insert(12, spawnPoints13);
            spawnPointsDeck1.Insert(13, spawnPoints14);
            spawnPointsDeck1.Insert(14, spawnPoints15);
            spawnPointsDeck1.Insert(15, spawnPoints16);
            spawnPointsDeck1.Insert(16, spawnPoints17);
            spawnPointsDeck1.Insert(17, spawnPoints18);
            spawnPointsDeck1.Insert(18, spawnPoints19);
            spawnPointsDeck1.Insert(19, spawnPoints20);
            spawnPointsDeck1.Insert(20, spawnPoints21);
            spawnPointsDeck1.Insert(21, spawnPoints22);
            spawnPointsDeck1.Insert(22, spawnPoints23);
            spawnPointsDeck1.Insert(23, spawnPoints24);
            spawnPointsDeck1.Insert(24, spawnPoints25);
            spawnPointsDeck1.Insert(25, spawnPoints26);
            spawnPointsDeck1.Insert(26, spawnPoints27);
            spawnPointsDeck1.Insert(27, spawnPoints28);
            spawnPointsDeck1.Insert(28, spawnPoints29);
            spawnPointsDeck1.Insert(29, spawnPoints30);
            spawnPointsDeck1.Insert(30, spawnPoints31);
            spawnPointsDeck1.Insert(31, spawnPoints32);
            spawnPointsDeck1.Insert(32, spawnPoints33);
            spawnPointsDeck1.Insert(33, spawnPoints34);
            spawnPointsDeck1.Insert(34, spawnPoints35);
            spawnPointsDeck1.Insert(35, spawnPoints36);
            spawnPointsDeck1.Insert(36, spawnPoints37);
            spawnPointsDeck1.Insert(37, spawnPoints38);
            spawnPointsDeck1.Insert(38, spawnPoints39);
            spawnPointsDeck1.Insert(39, spawnPoints40);
            spawnPointsDeck1.Insert(40, spawnPoints41);
            spawnPointsDeck1.Insert(41, spawnPoints42);
            spawnPointsDeck1.Insert(42, spawnPoints43);
            spawnPointsDeck1.Insert(43, spawnPoints44);
            spawnPointsDeck1.Insert(44, spawnPoints45);
            spawnPointsDeck1.Insert(45, spawnPoints46);
            spawnPointsDeck1.Insert(46, spawnPoints47);
            spawnPointsDeck1.Insert(47, spawnPoints48);
            spawnPointsDeck1.Insert(48, spawnPoints49);
            spawnPointsDeck1.Insert(49, spawnPoints50);
            spawnPointsDeck1.Insert(50, spawnPoints51);
            spawnPointsDeck1.Insert(51, spawnPoints52);
            spawnPointsDeck1.Insert(52, spawnPoints53);
            spawnPointsDeck1.Insert(53, spawnPoints54);
            spawnPointsDeck1.Insert(54, spawnPoints55);
            spawnPointsDeck1.Insert(55, spawnPoints56);
            spawnPointsDeck1.Insert(56, spawnPoints57);
            spawnPointsDeck1.Insert(57, spawnPoints58);
            spawnPointsDeck1.Insert(58, spawnPoints59);
            spawnPointsDeck1.Insert(59, spawnPoints60);

            deck1Slots.Insert(0, deck1Slot1);
            deck1Slots.Insert(1, deck1Slot2);
            deck1Slots.Insert(2, deck1Slot3);
            deck1Slots.Insert(3, deck1Slot4);
            deck1Slots.Insert(4, deck1Slot5);
            deck1Slots.Insert(5, deck1Slot6);
            deck1Slots.Insert(6, deck1Slot7);
            deck1Slots.Insert(7, deck1Slot8);
            deck1Slots.Insert(8, deck1Slot9);
            deck1Slots.Insert(9, deck1Slot10);
            deck1Slots.Insert(10, deck1Slot11);
            deck1Slots.Insert(11, deck1Slot12);
            deck1Slots.Insert(12, deck1Slot13);
            deck1Slots.Insert(13, deck1Slot14);
            deck1Slots.Insert(14, deck1Slot15);
            deck1Slots.Insert(15, deck1Slot16);
            deck1Slots.Insert(16, deck1Slot17);
            deck1Slots.Insert(17, deck1Slot18);
            deck1Slots.Insert(18, deck1Slot19);
            deck1Slots.Insert(19, deck1Slot20);
            deck1Slots.Insert(20, deck1Slot21);
            deck1Slots.Insert(21, deck1Slot22);
            deck1Slots.Insert(22, deck1Slot23);
            deck1Slots.Insert(23, deck1Slot24);
            deck1Slots.Insert(24, deck1Slot25);
            deck1Slots.Insert(25, deck1Slot26);
            deck1Slots.Insert(26, deck1Slot27);
            deck1Slots.Insert(27, deck1Slot28);
            deck1Slots.Insert(28, deck1Slot29);
            deck1Slots.Insert(29, deck1Slot30);
            deck1Slots.Insert(30, deck1Slot31);
            deck1Slots.Insert(31, deck1Slot32);
            deck1Slots.Insert(32, deck1Slot33);
            deck1Slots.Insert(33, deck1Slot34);
            deck1Slots.Insert(34, deck1Slot35);
            deck1Slots.Insert(35, deck1Slot36);
            deck1Slots.Insert(36, deck1Slot37);
            deck1Slots.Insert(37, deck1Slot38);
            deck1Slots.Insert(38, deck1Slot39);
            deck1Slots.Insert(39, deck1Slot40);
            deck1Slots.Insert(40, deck1Slot41);
            deck1Slots.Insert(41, deck1Slot42);
            deck1Slots.Insert(42, deck1Slot43);
            deck1Slots.Insert(43, deck1Slot44);
            deck1Slots.Insert(44, deck1Slot45);
            deck1Slots.Insert(45, deck1Slot46);
            deck1Slots.Insert(46, deck1Slot47);
            deck1Slots.Insert(47, deck1Slot48);
            deck1Slots.Insert(48, deck1Slot49);
            deck1Slots.Insert(49, deck1Slot50);
            deck1Slots.Insert(50, deck1Slot51);
            deck1Slots.Insert(51, deck1Slot52);
            deck1Slots.Insert(52, deck1Slot53);
            deck1Slots.Insert(53, deck1Slot54);
            deck1Slots.Insert(54, deck1Slot55);
            deck1Slots.Insert(55, deck1Slot56);
            deck1Slots.Insert(56, deck1Slot57);
            deck1Slots.Insert(57, deck1Slot58);
            deck1Slots.Insert(58, deck1Slot59);
            deck1Slots.Insert(59, deck1Slot60);




            #endregion


            //Get data stored in the binary file
            if (File.Exists(Path.Combine(Application.persistentDataPath, BINARY_FILE1))) {

                BinaryFormatter bf = new BinaryFormatter();

                FileStream file = File.OpenRead(Path.Combine(Application.persistentDataPath, BINARY_FILE1));
                DataToSave1 data = (DataToSave1)bf.Deserialize(file);
                file.Close();
                deckName1 = data.deckName1;
                cardsDeck1 = data.cardsDeck1;

                //Convert card references into 3D card game objects
                CardGenerator();

            }



            //Set Create, Save and Edit buttons interactable or noninteractable depending on if the cardsDeck1 list is empty or not
            if (cardsDeck1.Count.Equals(0)) {
                create1Button.GetComponent<Button>().interactable = true;
                save1Button.GetComponent<Button>().interactable = false;
                edit1Button.GetComponent<Button>().interactable = false;
                delete1Button.GetComponent<Button>().interactable = false;
            } else {
                create1Button.GetComponent<Button>().interactable = false;
                save1Button.GetComponent<Button>().interactable = true;
                edit1Button.GetComponent<Button>().interactable = true;
                delete1Button.GetComponent<Button>().interactable = true;
            }



            if (deck1NameButton.GetComponent<Text>().text == "") {
                deck1NameButton.GetComponent<Text>().text = "Deck 1";
            } else {
                deck1NameButton.GetComponent<Text>().text = deckName1;
            }


        }

        void Update() {

            if (Input.GetKeyDown(KeyCode.Mouse0)) {
                //Check every frame if all the slots in Deck Manager panel have cards
                deck1Slots.RemoveAll(item => item == null);
                foreach (GameObject slot in deck1Slots) {
                    if (slot.transform.childCount > 0) { //if so...

                        //Make Save button interactable
                        save1Button.GetComponent<Button>().interactable = true;

                    }
                }


                //Set spawn points to edit cards in the deck
                SetSpawnPointsToEdit();
            }

        }


        /** Edit the deck - the deck is loaded into the Deck manager panel and can be modified*/
        public void Edit() {

            addEditSpawnPoints = true;
            isDeck1Editing = true;

            //Show the input field to enter a name of the deck
            inputFieldSwitcher1.SetActive(true);

            //Clean all lists
            editDeck1.Clear();
            editDeck1.RemoveAll(item => item == null);
            cardsDeck1.Clear();
            cardsDeck1.RemoveAll(item => item == null);

            //Get data stored in the binary file
            if (File.Exists(Path.Combine(Application.persistentDataPath, BINARY_FILE1))) {

                BinaryFormatter bf = new BinaryFormatter();

                FileStream file = File.Open(Path.Combine(Application.persistentDataPath, BINARY_FILE1), FileMode.Open);
                DataToSave1 data = (DataToSave1)bf.Deserialize(file);
                file.Close();
                deckName1 = data.deckName1;

                deckNamelabel.GetComponent<Text>().text = deckName1;

                if (deck1NameButton.GetComponent<Text>().text == "") {
                    deck1NameButton.GetComponent<Text>().text = "Deck 1";
                } else {
                    deck1NameButton.GetComponent<Text>().text = deckName1;
                }
            }

            //Find all the cards for the deck
            allObjects1 = GameObject.FindObjectsOfType(typeof(GameObject)) as GameObject[];
            foreach (GameObject obj in allObjects1) {
                if (obj.name.Contains("instantiated1Card")) {

                    editDeck1.Add(obj);

                }
            }

            //Get ready the cards in the deck to edit
            #region EditFillSlots definition

            if (editDeck1.Count == 20) {
                editDeck1[0].transform.parent = deck1Slot1.transform;
                editDeck1[0].transform.localPosition = Vector3.zero;
                editDeck1[0].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[0].AddComponent<DeleteCardInEditMode>();

                editDeck1[1].transform.parent = deck1Slot2.transform;
                editDeck1[1].transform.localPosition = Vector3.zero;
                editDeck1[1].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[1].AddComponent<DeleteCardInEditMode>();

                editDeck1[2].transform.parent = deck1Slot3.transform;
                editDeck1[2].transform.localPosition = Vector3.zero;
                editDeck1[2].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[2].AddComponent<DeleteCardInEditMode>();

                editDeck1[3].transform.parent = deck1Slot4.transform;
                editDeck1[3].transform.localPosition = Vector3.zero;
                editDeck1[3].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[3].AddComponent<DeleteCardInEditMode>();

                editDeck1[4].transform.parent = deck1Slot5.transform;
                editDeck1[4].transform.localPosition = Vector3.zero;
                editDeck1[4].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[4].AddComponent<DeleteCardInEditMode>();

                editDeck1[5].transform.parent = deck1Slot6.transform;
                editDeck1[5].transform.localPosition = Vector3.zero;
                editDeck1[5].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[5].AddComponent<DeleteCardInEditMode>();

                editDeck1[6].transform.parent = deck1Slot7.transform;
                editDeck1[6].transform.localPosition = Vector3.zero;
                editDeck1[6].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[6].AddComponent<DeleteCardInEditMode>();

                editDeck1[7].transform.parent = deck1Slot8.transform;
                editDeck1[7].transform.localPosition = Vector3.zero;
                editDeck1[7].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[7].AddComponent<DeleteCardInEditMode>();

                editDeck1[8].transform.parent = deck1Slot9.transform;
                editDeck1[8].transform.localPosition = Vector3.zero;
                editDeck1[8].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[8].AddComponent<DeleteCardInEditMode>();

                editDeck1[9].transform.parent = deck1Slot10.transform;
                editDeck1[9].transform.localPosition = Vector3.zero;
                editDeck1[9].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[9].AddComponent<DeleteCardInEditMode>();

                editDeck1[10].transform.parent = deck1Slot11.transform;
                editDeck1[10].transform.localPosition = Vector3.zero;
                editDeck1[10].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[10].AddComponent<DeleteCardInEditMode>();

                editDeck1[11].transform.parent = deck1Slot12.transform;
                editDeck1[11].transform.localPosition = Vector3.zero;
                editDeck1[11].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[11].AddComponent<DeleteCardInEditMode>();

                editDeck1[12].transform.parent = deck1Slot13.transform;
                editDeck1[12].transform.localPosition = Vector3.zero;
                editDeck1[12].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[12].AddComponent<DeleteCardInEditMode>();

                editDeck1[13].transform.parent = deck1Slot14.transform;
                editDeck1[13].transform.localPosition = Vector3.zero;
                editDeck1[13].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[13].AddComponent<DeleteCardInEditMode>();

                editDeck1[14].transform.parent = deck1Slot15.transform;
                editDeck1[14].transform.localPosition = Vector3.zero;
                editDeck1[14].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[14].AddComponent<DeleteCardInEditMode>();

                editDeck1[15].transform.parent = deck1Slot16.transform;
                editDeck1[15].transform.localPosition = Vector3.zero;
                editDeck1[15].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[15].AddComponent<DeleteCardInEditMode>();

                editDeck1[16].transform.parent = deck1Slot17.transform;
                editDeck1[16].transform.localPosition = Vector3.zero;
                editDeck1[16].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[16].AddComponent<DeleteCardInEditMode>();

                editDeck1[17].transform.parent = deck1Slot18.transform;
                editDeck1[17].transform.localPosition = Vector3.zero;
                editDeck1[17].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[17].AddComponent<DeleteCardInEditMode>();

                editDeck1[18].transform.parent = deck1Slot19.transform;
                editDeck1[18].transform.localPosition = Vector3.zero;
                editDeck1[18].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[18].AddComponent<DeleteCardInEditMode>();

                editDeck1[19].transform.parent = deck1Slot20.transform;
                editDeck1[19].transform.localPosition = Vector3.zero;
                editDeck1[19].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[19].AddComponent<DeleteCardInEditMode>();

            } else if (editDeck1.Count == 25) {
                editDeck1[0].transform.parent = deck1Slot1.transform;
                editDeck1[0].transform.localPosition = Vector3.zero;
                editDeck1[0].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[0].AddComponent<DeleteCardInEditMode>();

                editDeck1[1].transform.parent = deck1Slot2.transform;
                editDeck1[1].transform.localPosition = Vector3.zero;
                editDeck1[1].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[1].AddComponent<DeleteCardInEditMode>();

                editDeck1[2].transform.parent = deck1Slot3.transform;
                editDeck1[2].transform.localPosition = Vector3.zero;
                editDeck1[2].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[2].AddComponent<DeleteCardInEditMode>();

                editDeck1[3].transform.parent = deck1Slot4.transform;
                editDeck1[3].transform.localPosition = Vector3.zero;
                editDeck1[3].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[3].AddComponent<DeleteCardInEditMode>();

                editDeck1[4].transform.parent = deck1Slot5.transform;
                editDeck1[4].transform.localPosition = Vector3.zero;
                editDeck1[4].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[4].AddComponent<DeleteCardInEditMode>();

                editDeck1[5].transform.parent = deck1Slot6.transform;
                editDeck1[5].transform.localPosition = Vector3.zero;
                editDeck1[5].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[5].AddComponent<DeleteCardInEditMode>();

                editDeck1[6].transform.parent = deck1Slot7.transform;
                editDeck1[6].transform.localPosition = Vector3.zero;
                editDeck1[6].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[6].AddComponent<DeleteCardInEditMode>();

                editDeck1[7].transform.parent = deck1Slot8.transform;
                editDeck1[7].transform.localPosition = Vector3.zero;
                editDeck1[7].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[7].AddComponent<DeleteCardInEditMode>();

                editDeck1[8].transform.parent = deck1Slot9.transform;
                editDeck1[8].transform.localPosition = Vector3.zero;
                editDeck1[8].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[8].AddComponent<DeleteCardInEditMode>();

                editDeck1[9].transform.parent = deck1Slot10.transform;
                editDeck1[9].transform.localPosition = Vector3.zero;
                editDeck1[9].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[9].AddComponent<DeleteCardInEditMode>();

                editDeck1[10].transform.parent = deck1Slot11.transform;
                editDeck1[10].transform.localPosition = Vector3.zero;
                editDeck1[10].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[10].AddComponent<DeleteCardInEditMode>();

                editDeck1[11].transform.parent = deck1Slot12.transform;
                editDeck1[11].transform.localPosition = Vector3.zero;
                editDeck1[11].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[11].AddComponent<DeleteCardInEditMode>();

                editDeck1[12].transform.parent = deck1Slot13.transform;
                editDeck1[12].transform.localPosition = Vector3.zero;
                editDeck1[12].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[12].AddComponent<DeleteCardInEditMode>();

                editDeck1[13].transform.parent = deck1Slot14.transform;
                editDeck1[13].transform.localPosition = Vector3.zero;
                editDeck1[13].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[13].AddComponent<DeleteCardInEditMode>();

                editDeck1[14].transform.parent = deck1Slot15.transform;
                editDeck1[14].transform.localPosition = Vector3.zero;
                editDeck1[14].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[14].AddComponent<DeleteCardInEditMode>();

                editDeck1[15].transform.parent = deck1Slot16.transform;
                editDeck1[15].transform.localPosition = Vector3.zero;
                editDeck1[15].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[15].AddComponent<DeleteCardInEditMode>();

                editDeck1[16].transform.parent = deck1Slot17.transform;
                editDeck1[16].transform.localPosition = Vector3.zero;
                editDeck1[16].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[16].AddComponent<DeleteCardInEditMode>();

                editDeck1[17].transform.parent = deck1Slot18.transform;
                editDeck1[17].transform.localPosition = Vector3.zero;
                editDeck1[17].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[17].AddComponent<DeleteCardInEditMode>();

                editDeck1[18].transform.parent = deck1Slot19.transform;
                editDeck1[18].transform.localPosition = Vector3.zero;
                editDeck1[18].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[18].AddComponent<DeleteCardInEditMode>();

                editDeck1[19].transform.parent = deck1Slot20.transform;
                editDeck1[19].transform.localPosition = Vector3.zero;
                editDeck1[19].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[19].AddComponent<DeleteCardInEditMode>();

                editDeck1[20].transform.parent = deck1Slot21.transform;
                editDeck1[20].transform.localPosition = Vector3.zero;
                editDeck1[20].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[20].AddComponent<DeleteCardInEditMode>();

                editDeck1[21].transform.parent = deck1Slot22.transform;
                editDeck1[21].transform.localPosition = Vector3.zero;
                editDeck1[21].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[21].AddComponent<DeleteCardInEditMode>();

                editDeck1[22].transform.parent = deck1Slot23.transform;
                editDeck1[22].transform.localPosition = Vector3.zero;
                editDeck1[22].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[22].AddComponent<DeleteCardInEditMode>();

                editDeck1[23].transform.parent = deck1Slot24.transform;
                editDeck1[23].transform.localPosition = Vector3.zero;
                editDeck1[23].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[23].AddComponent<DeleteCardInEditMode>();

                editDeck1[24].transform.parent = deck1Slot25.transform;
                editDeck1[24].transform.localPosition = Vector3.zero;
                editDeck1[24].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[24].AddComponent<DeleteCardInEditMode>();

            } else if (editDeck1.Count == 30) {
                editDeck1[0].transform.parent = deck1Slot1.transform;
                editDeck1[0].transform.localPosition = Vector3.zero;
                editDeck1[0].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[0].AddComponent<DeleteCardInEditMode>();

                editDeck1[1].transform.parent = deck1Slot2.transform;
                editDeck1[1].transform.localPosition = Vector3.zero;
                editDeck1[1].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[1].AddComponent<DeleteCardInEditMode>();

                editDeck1[2].transform.parent = deck1Slot3.transform;
                editDeck1[2].transform.localPosition = Vector3.zero;
                editDeck1[2].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[2].AddComponent<DeleteCardInEditMode>();

                editDeck1[3].transform.parent = deck1Slot4.transform;
                editDeck1[3].transform.localPosition = Vector3.zero;
                editDeck1[3].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[3].AddComponent<DeleteCardInEditMode>();

                editDeck1[4].transform.parent = deck1Slot5.transform;
                editDeck1[4].transform.localPosition = Vector3.zero;
                editDeck1[4].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[4].AddComponent<DeleteCardInEditMode>();

                editDeck1[5].transform.parent = deck1Slot6.transform;
                editDeck1[5].transform.localPosition = Vector3.zero;
                editDeck1[5].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[5].AddComponent<DeleteCardInEditMode>();

                editDeck1[6].transform.parent = deck1Slot7.transform;
                editDeck1[6].transform.localPosition = Vector3.zero;
                editDeck1[6].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[6].AddComponent<DeleteCardInEditMode>();

                editDeck1[7].transform.parent = deck1Slot8.transform;
                editDeck1[7].transform.localPosition = Vector3.zero;
                editDeck1[7].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[7].AddComponent<DeleteCardInEditMode>();

                editDeck1[8].transform.parent = deck1Slot9.transform;
                editDeck1[8].transform.localPosition = Vector3.zero;
                editDeck1[8].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[8].AddComponent<DeleteCardInEditMode>();

                editDeck1[9].transform.parent = deck1Slot10.transform;
                editDeck1[9].transform.localPosition = Vector3.zero;
                editDeck1[9].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[9].AddComponent<DeleteCardInEditMode>();

                editDeck1[10].transform.parent = deck1Slot11.transform;
                editDeck1[10].transform.localPosition = Vector3.zero;
                editDeck1[10].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[10].AddComponent<DeleteCardInEditMode>();

                editDeck1[11].transform.parent = deck1Slot12.transform;
                editDeck1[11].transform.localPosition = Vector3.zero;
                editDeck1[11].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[11].AddComponent<DeleteCardInEditMode>();

                editDeck1[12].transform.parent = deck1Slot13.transform;
                editDeck1[12].transform.localPosition = Vector3.zero;
                editDeck1[12].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[12].AddComponent<DeleteCardInEditMode>();

                editDeck1[13].transform.parent = deck1Slot14.transform;
                editDeck1[13].transform.localPosition = Vector3.zero;
                editDeck1[13].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[13].AddComponent<DeleteCardInEditMode>();

                editDeck1[14].transform.parent = deck1Slot15.transform;
                editDeck1[14].transform.localPosition = Vector3.zero;
                editDeck1[14].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[14].AddComponent<DeleteCardInEditMode>();

                editDeck1[15].transform.parent = deck1Slot16.transform;
                editDeck1[15].transform.localPosition = Vector3.zero;
                editDeck1[15].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[15].AddComponent<DeleteCardInEditMode>();

                editDeck1[16].transform.parent = deck1Slot17.transform;
                editDeck1[16].transform.localPosition = Vector3.zero;
                editDeck1[16].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[16].AddComponent<DeleteCardInEditMode>();

                editDeck1[17].transform.parent = deck1Slot18.transform;
                editDeck1[17].transform.localPosition = Vector3.zero;
                editDeck1[17].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[17].AddComponent<DeleteCardInEditMode>();

                editDeck1[18].transform.parent = deck1Slot19.transform;
                editDeck1[18].transform.localPosition = Vector3.zero;
                editDeck1[18].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[18].AddComponent<DeleteCardInEditMode>();

                editDeck1[19].transform.parent = deck1Slot20.transform;
                editDeck1[19].transform.localPosition = Vector3.zero;
                editDeck1[19].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[19].AddComponent<DeleteCardInEditMode>();

                editDeck1[20].transform.parent = deck1Slot21.transform;
                editDeck1[20].transform.localPosition = Vector3.zero;
                editDeck1[20].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[20].AddComponent<DeleteCardInEditMode>();

                editDeck1[21].transform.parent = deck1Slot22.transform;
                editDeck1[21].transform.localPosition = Vector3.zero;
                editDeck1[21].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[21].AddComponent<DeleteCardInEditMode>();

                editDeck1[22].transform.parent = deck1Slot23.transform;
                editDeck1[22].transform.localPosition = Vector3.zero;
                editDeck1[22].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[22].AddComponent<DeleteCardInEditMode>();

                editDeck1[23].transform.parent = deck1Slot24.transform;
                editDeck1[23].transform.localPosition = Vector3.zero;
                editDeck1[23].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[23].AddComponent<DeleteCardInEditMode>();

                editDeck1[24].transform.parent = deck1Slot25.transform;
                editDeck1[24].transform.localPosition = Vector3.zero;
                editDeck1[24].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[24].AddComponent<DeleteCardInEditMode>();

                editDeck1[25].transform.parent = deck1Slot26.transform;
                editDeck1[25].transform.localPosition = Vector3.zero;
                editDeck1[25].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[25].AddComponent<DeleteCardInEditMode>();

                editDeck1[26].transform.parent = deck1Slot27.transform;
                editDeck1[26].transform.localPosition = Vector3.zero;
                editDeck1[26].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[26].AddComponent<DeleteCardInEditMode>();

                editDeck1[27].transform.parent = deck1Slot28.transform;
                editDeck1[27].transform.localPosition = Vector3.zero;
                editDeck1[27].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[27].AddComponent<DeleteCardInEditMode>();

                editDeck1[28].transform.parent = deck1Slot29.transform;
                editDeck1[28].transform.localPosition = Vector3.zero;
                editDeck1[28].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[28].AddComponent<DeleteCardInEditMode>();

                editDeck1[29].transform.parent = deck1Slot30.transform;
                editDeck1[29].transform.localPosition = Vector3.zero;
                editDeck1[29].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[29].AddComponent<DeleteCardInEditMode>();

            } else if (editDeck1.Count == 35) {
                editDeck1[0].transform.parent = deck1Slot1.transform;
                editDeck1[0].transform.localPosition = Vector3.zero;
                editDeck1[0].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[0].AddComponent<DeleteCardInEditMode>();

                editDeck1[1].transform.parent = deck1Slot2.transform;
                editDeck1[1].transform.localPosition = Vector3.zero;
                editDeck1[1].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[1].AddComponent<DeleteCardInEditMode>();

                editDeck1[2].transform.parent = deck1Slot3.transform;
                editDeck1[2].transform.localPosition = Vector3.zero;
                editDeck1[2].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[2].AddComponent<DeleteCardInEditMode>();

                editDeck1[3].transform.parent = deck1Slot4.transform;
                editDeck1[3].transform.localPosition = Vector3.zero;
                editDeck1[3].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[3].AddComponent<DeleteCardInEditMode>();

                editDeck1[4].transform.parent = deck1Slot5.transform;
                editDeck1[4].transform.localPosition = Vector3.zero;
                editDeck1[4].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[4].AddComponent<DeleteCardInEditMode>();

                editDeck1[5].transform.parent = deck1Slot6.transform;
                editDeck1[5].transform.localPosition = Vector3.zero;
                editDeck1[5].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[5].AddComponent<DeleteCardInEditMode>();

                editDeck1[6].transform.parent = deck1Slot7.transform;
                editDeck1[6].transform.localPosition = Vector3.zero;
                editDeck1[6].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[6].AddComponent<DeleteCardInEditMode>();

                editDeck1[7].transform.parent = deck1Slot8.transform;
                editDeck1[7].transform.localPosition = Vector3.zero;
                editDeck1[7].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[7].AddComponent<DeleteCardInEditMode>();

                editDeck1[8].transform.parent = deck1Slot9.transform;
                editDeck1[8].transform.localPosition = Vector3.zero;
                editDeck1[8].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[8].AddComponent<DeleteCardInEditMode>();

                editDeck1[9].transform.parent = deck1Slot10.transform;
                editDeck1[9].transform.localPosition = Vector3.zero;
                editDeck1[9].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[9].AddComponent<DeleteCardInEditMode>();

                editDeck1[10].transform.parent = deck1Slot11.transform;
                editDeck1[10].transform.localPosition = Vector3.zero;
                editDeck1[10].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[10].AddComponent<DeleteCardInEditMode>();

                editDeck1[11].transform.parent = deck1Slot12.transform;
                editDeck1[11].transform.localPosition = Vector3.zero;
                editDeck1[11].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[11].AddComponent<DeleteCardInEditMode>();

                editDeck1[12].transform.parent = deck1Slot13.transform;
                editDeck1[12].transform.localPosition = Vector3.zero;
                editDeck1[12].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[12].AddComponent<DeleteCardInEditMode>();

                editDeck1[13].transform.parent = deck1Slot14.transform;
                editDeck1[13].transform.localPosition = Vector3.zero;
                editDeck1[13].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[13].AddComponent<DeleteCardInEditMode>();

                editDeck1[14].transform.parent = deck1Slot15.transform;
                editDeck1[14].transform.localPosition = Vector3.zero;
                editDeck1[14].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[14].AddComponent<DeleteCardInEditMode>();

                editDeck1[15].transform.parent = deck1Slot16.transform;
                editDeck1[15].transform.localPosition = Vector3.zero;
                editDeck1[15].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[15].AddComponent<DeleteCardInEditMode>();

                editDeck1[16].transform.parent = deck1Slot17.transform;
                editDeck1[16].transform.localPosition = Vector3.zero;
                editDeck1[16].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[16].AddComponent<DeleteCardInEditMode>();

                editDeck1[17].transform.parent = deck1Slot18.transform;
                editDeck1[17].transform.localPosition = Vector3.zero;
                editDeck1[17].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[17].AddComponent<DeleteCardInEditMode>();

                editDeck1[18].transform.parent = deck1Slot19.transform;
                editDeck1[18].transform.localPosition = Vector3.zero;
                editDeck1[18].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[18].AddComponent<DeleteCardInEditMode>();

                editDeck1[19].transform.parent = deck1Slot20.transform;
                editDeck1[19].transform.localPosition = Vector3.zero;
                editDeck1[19].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[19].AddComponent<DeleteCardInEditMode>();

                editDeck1[20].transform.parent = deck1Slot21.transform;
                editDeck1[20].transform.localPosition = Vector3.zero;
                editDeck1[20].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[20].AddComponent<DeleteCardInEditMode>();

                editDeck1[21].transform.parent = deck1Slot22.transform;
                editDeck1[21].transform.localPosition = Vector3.zero;
                editDeck1[21].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[21].AddComponent<DeleteCardInEditMode>();

                editDeck1[22].transform.parent = deck1Slot23.transform;
                editDeck1[22].transform.localPosition = Vector3.zero;
                editDeck1[22].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[22].AddComponent<DeleteCardInEditMode>();

                editDeck1[23].transform.parent = deck1Slot24.transform;
                editDeck1[23].transform.localPosition = Vector3.zero;
                editDeck1[23].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[23].AddComponent<DeleteCardInEditMode>();

                editDeck1[24].transform.parent = deck1Slot25.transform;
                editDeck1[24].transform.localPosition = Vector3.zero;
                editDeck1[24].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[24].AddComponent<DeleteCardInEditMode>();

                editDeck1[25].transform.parent = deck1Slot26.transform;
                editDeck1[25].transform.localPosition = Vector3.zero;
                editDeck1[25].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[25].AddComponent<DeleteCardInEditMode>();

                editDeck1[26].transform.parent = deck1Slot27.transform;
                editDeck1[26].transform.localPosition = Vector3.zero;
                editDeck1[26].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[26].AddComponent<DeleteCardInEditMode>();

                editDeck1[27].transform.parent = deck1Slot28.transform;
                editDeck1[27].transform.localPosition = Vector3.zero;
                editDeck1[27].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[27].AddComponent<DeleteCardInEditMode>();

                editDeck1[28].transform.parent = deck1Slot29.transform;
                editDeck1[28].transform.localPosition = Vector3.zero;
                editDeck1[28].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[28].AddComponent<DeleteCardInEditMode>();

                editDeck1[29].transform.parent = deck1Slot30.transform;
                editDeck1[29].transform.localPosition = Vector3.zero;
                editDeck1[29].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[29].AddComponent<DeleteCardInEditMode>();

                editDeck1[30].transform.parent = deck1Slot31.transform;
                editDeck1[30].transform.localPosition = Vector3.zero;
                editDeck1[30].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[30].AddComponent<DeleteCardInEditMode>();

                editDeck1[31].transform.parent = deck1Slot32.transform;
                editDeck1[31].transform.localPosition = Vector3.zero;
                editDeck1[31].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[31].AddComponent<DeleteCardInEditMode>();

                editDeck1[32].transform.parent = deck1Slot33.transform;
                editDeck1[32].transform.localPosition = Vector3.zero;
                editDeck1[32].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[32].AddComponent<DeleteCardInEditMode>();

                editDeck1[33].transform.parent = deck1Slot34.transform;
                editDeck1[33].transform.localPosition = Vector3.zero;
                editDeck1[33].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[33].AddComponent<DeleteCardInEditMode>();

                editDeck1[34].transform.parent = deck1Slot35.transform;
                editDeck1[34].transform.localPosition = Vector3.zero;
                editDeck1[34].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[34].AddComponent<DeleteCardInEditMode>();

            } else if (editDeck1.Count == 40) {

                editDeck1[0].transform.parent = deck1Slot1.transform;
                editDeck1[0].transform.localPosition = Vector3.zero;
                editDeck1[0].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[0].AddComponent<DeleteCardInEditMode>();

                editDeck1[1].transform.parent = deck1Slot2.transform;
                editDeck1[1].transform.localPosition = Vector3.zero;
                editDeck1[1].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[1].AddComponent<DeleteCardInEditMode>();

                editDeck1[2].transform.parent = deck1Slot3.transform;
                editDeck1[2].transform.localPosition = Vector3.zero;
                editDeck1[2].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[2].AddComponent<DeleteCardInEditMode>();

                editDeck1[3].transform.parent = deck1Slot4.transform;
                editDeck1[3].transform.localPosition = Vector3.zero;
                editDeck1[3].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[3].AddComponent<DeleteCardInEditMode>();

                editDeck1[4].transform.parent = deck1Slot5.transform;
                editDeck1[4].transform.localPosition = Vector3.zero;
                editDeck1[4].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[4].AddComponent<DeleteCardInEditMode>();

                editDeck1[5].transform.parent = deck1Slot6.transform;
                editDeck1[5].transform.localPosition = Vector3.zero;
                editDeck1[5].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[5].AddComponent<DeleteCardInEditMode>();

                editDeck1[6].transform.parent = deck1Slot7.transform;
                editDeck1[6].transform.localPosition = Vector3.zero;
                editDeck1[6].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[6].AddComponent<DeleteCardInEditMode>();

                editDeck1[7].transform.parent = deck1Slot8.transform;
                editDeck1[7].transform.localPosition = Vector3.zero;
                editDeck1[7].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[7].AddComponent<DeleteCardInEditMode>();

                editDeck1[8].transform.parent = deck1Slot9.transform;
                editDeck1[8].transform.localPosition = Vector3.zero;
                editDeck1[8].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[8].AddComponent<DeleteCardInEditMode>();

                editDeck1[9].transform.parent = deck1Slot10.transform;
                editDeck1[9].transform.localPosition = Vector3.zero;
                editDeck1[9].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[9].AddComponent<DeleteCardInEditMode>();

                editDeck1[10].transform.parent = deck1Slot11.transform;
                editDeck1[10].transform.localPosition = Vector3.zero;
                editDeck1[10].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[10].AddComponent<DeleteCardInEditMode>();

                editDeck1[11].transform.parent = deck1Slot12.transform;
                editDeck1[11].transform.localPosition = Vector3.zero;
                editDeck1[11].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[11].AddComponent<DeleteCardInEditMode>();

                editDeck1[12].transform.parent = deck1Slot13.transform;
                editDeck1[12].transform.localPosition = Vector3.zero;
                editDeck1[12].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[12].AddComponent<DeleteCardInEditMode>();

                editDeck1[13].transform.parent = deck1Slot14.transform;
                editDeck1[13].transform.localPosition = Vector3.zero;
                editDeck1[13].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[13].AddComponent<DeleteCardInEditMode>();

                editDeck1[14].transform.parent = deck1Slot15.transform;
                editDeck1[14].transform.localPosition = Vector3.zero;
                editDeck1[14].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[14].AddComponent<DeleteCardInEditMode>();

                editDeck1[15].transform.parent = deck1Slot16.transform;
                editDeck1[15].transform.localPosition = Vector3.zero;
                editDeck1[15].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[15].AddComponent<DeleteCardInEditMode>();

                editDeck1[16].transform.parent = deck1Slot17.transform;
                editDeck1[16].transform.localPosition = Vector3.zero;
                editDeck1[16].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[16].AddComponent<DeleteCardInEditMode>();

                editDeck1[17].transform.parent = deck1Slot18.transform;
                editDeck1[17].transform.localPosition = Vector3.zero;
                editDeck1[17].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[17].AddComponent<DeleteCardInEditMode>();

                editDeck1[18].transform.parent = deck1Slot19.transform;
                editDeck1[18].transform.localPosition = Vector3.zero;
                editDeck1[18].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[18].AddComponent<DeleteCardInEditMode>();

                editDeck1[19].transform.parent = deck1Slot20.transform;
                editDeck1[19].transform.localPosition = Vector3.zero;
                editDeck1[19].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[19].AddComponent<DeleteCardInEditMode>();

                editDeck1[20].transform.parent = deck1Slot21.transform;
                editDeck1[20].transform.localPosition = Vector3.zero;
                editDeck1[20].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[20].AddComponent<DeleteCardInEditMode>();

                editDeck1[21].transform.parent = deck1Slot22.transform;
                editDeck1[21].transform.localPosition = Vector3.zero;
                editDeck1[21].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[21].AddComponent<DeleteCardInEditMode>();

                editDeck1[22].transform.parent = deck1Slot23.transform;
                editDeck1[22].transform.localPosition = Vector3.zero;
                editDeck1[22].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[22].AddComponent<DeleteCardInEditMode>();

                editDeck1[23].transform.parent = deck1Slot24.transform;
                editDeck1[23].transform.localPosition = Vector3.zero;
                editDeck1[23].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[23].AddComponent<DeleteCardInEditMode>();

                editDeck1[24].transform.parent = deck1Slot25.transform;
                editDeck1[24].transform.localPosition = Vector3.zero;
                editDeck1[24].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[24].AddComponent<DeleteCardInEditMode>();

                editDeck1[25].transform.parent = deck1Slot26.transform;
                editDeck1[25].transform.localPosition = Vector3.zero;
                editDeck1[25].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[25].AddComponent<DeleteCardInEditMode>();

                editDeck1[26].transform.parent = deck1Slot27.transform;
                editDeck1[26].transform.localPosition = Vector3.zero;
                editDeck1[26].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[26].AddComponent<DeleteCardInEditMode>();

                editDeck1[27].transform.parent = deck1Slot28.transform;
                editDeck1[27].transform.localPosition = Vector3.zero;
                editDeck1[27].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[27].AddComponent<DeleteCardInEditMode>();

                editDeck1[28].transform.parent = deck1Slot29.transform;
                editDeck1[28].transform.localPosition = Vector3.zero;
                editDeck1[28].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[28].AddComponent<DeleteCardInEditMode>();

                editDeck1[29].transform.parent = deck1Slot30.transform;
                editDeck1[29].transform.localPosition = Vector3.zero;
                editDeck1[29].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[29].AddComponent<DeleteCardInEditMode>();

                editDeck1[30].transform.parent = deck1Slot31.transform;
                editDeck1[30].transform.localPosition = Vector3.zero;
                editDeck1[30].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[30].AddComponent<DeleteCardInEditMode>();

                editDeck1[31].transform.parent = deck1Slot32.transform;
                editDeck1[31].transform.localPosition = Vector3.zero;
                editDeck1[31].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[31].AddComponent<DeleteCardInEditMode>();

                editDeck1[32].transform.parent = deck1Slot33.transform;
                editDeck1[32].transform.localPosition = Vector3.zero;
                editDeck1[32].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[32].AddComponent<DeleteCardInEditMode>();

                editDeck1[33].transform.parent = deck1Slot34.transform;
                editDeck1[33].transform.localPosition = Vector3.zero;
                editDeck1[33].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[33].AddComponent<DeleteCardInEditMode>();

                editDeck1[34].transform.parent = deck1Slot35.transform;
                editDeck1[34].transform.localPosition = Vector3.zero;
                editDeck1[34].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[34].AddComponent<DeleteCardInEditMode>();

                editDeck1[35].transform.parent = deck1Slot36.transform;
                editDeck1[35].transform.localPosition = Vector3.zero;
                editDeck1[35].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[35].AddComponent<DeleteCardInEditMode>();

                editDeck1[36].transform.parent = deck1Slot37.transform;
                editDeck1[36].transform.localPosition = Vector3.zero;
                editDeck1[36].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[36].AddComponent<DeleteCardInEditMode>();

                editDeck1[37].transform.parent = deck1Slot38.transform;
                editDeck1[37].transform.localPosition = Vector3.zero;
                editDeck1[37].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[37].AddComponent<DeleteCardInEditMode>();

                editDeck1[38].transform.parent = deck1Slot39.transform;
                editDeck1[38].transform.localPosition = Vector3.zero;
                editDeck1[38].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[38].AddComponent<DeleteCardInEditMode>();

                editDeck1[39].transform.parent = deck1Slot40.transform;
                editDeck1[39].transform.localPosition = Vector3.zero;
                editDeck1[39].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[39].AddComponent<DeleteCardInEditMode>();

            } else if (editDeck1.Count == 45) {

                editDeck1[0].transform.parent = deck1Slot1.transform;
                editDeck1[0].transform.localPosition = Vector3.zero;
                editDeck1[0].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[0].AddComponent<DeleteCardInEditMode>();

                editDeck1[1].transform.parent = deck1Slot2.transform;
                editDeck1[1].transform.localPosition = Vector3.zero;
                editDeck1[1].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[1].AddComponent<DeleteCardInEditMode>();

                editDeck1[2].transform.parent = deck1Slot3.transform;
                editDeck1[2].transform.localPosition = Vector3.zero;
                editDeck1[2].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[2].AddComponent<DeleteCardInEditMode>();

                editDeck1[3].transform.parent = deck1Slot4.transform;
                editDeck1[3].transform.localPosition = Vector3.zero;
                editDeck1[3].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[3].AddComponent<DeleteCardInEditMode>();

                editDeck1[4].transform.parent = deck1Slot5.transform;
                editDeck1[4].transform.localPosition = Vector3.zero;
                editDeck1[4].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[4].AddComponent<DeleteCardInEditMode>();

                editDeck1[5].transform.parent = deck1Slot6.transform;
                editDeck1[5].transform.localPosition = Vector3.zero;
                editDeck1[5].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[5].AddComponent<DeleteCardInEditMode>();

                editDeck1[6].transform.parent = deck1Slot7.transform;
                editDeck1[6].transform.localPosition = Vector3.zero;
                editDeck1[6].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[6].AddComponent<DeleteCardInEditMode>();

                editDeck1[7].transform.parent = deck1Slot8.transform;
                editDeck1[7].transform.localPosition = Vector3.zero;
                editDeck1[7].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[7].AddComponent<DeleteCardInEditMode>();

                editDeck1[8].transform.parent = deck1Slot9.transform;
                editDeck1[8].transform.localPosition = Vector3.zero;
                editDeck1[8].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[8].AddComponent<DeleteCardInEditMode>();

                editDeck1[9].transform.parent = deck1Slot10.transform;
                editDeck1[9].transform.localPosition = Vector3.zero;
                editDeck1[9].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[9].AddComponent<DeleteCardInEditMode>();

                editDeck1[10].transform.parent = deck1Slot11.transform;
                editDeck1[10].transform.localPosition = Vector3.zero;
                editDeck1[10].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[10].AddComponent<DeleteCardInEditMode>();

                editDeck1[11].transform.parent = deck1Slot12.transform;
                editDeck1[11].transform.localPosition = Vector3.zero;
                editDeck1[11].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[11].AddComponent<DeleteCardInEditMode>();

                editDeck1[12].transform.parent = deck1Slot13.transform;
                editDeck1[12].transform.localPosition = Vector3.zero;
                editDeck1[12].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[12].AddComponent<DeleteCardInEditMode>();

                editDeck1[13].transform.parent = deck1Slot14.transform;
                editDeck1[13].transform.localPosition = Vector3.zero;
                editDeck1[13].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[13].AddComponent<DeleteCardInEditMode>();

                editDeck1[14].transform.parent = deck1Slot15.transform;
                editDeck1[14].transform.localPosition = Vector3.zero;
                editDeck1[14].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[14].AddComponent<DeleteCardInEditMode>();

                editDeck1[15].transform.parent = deck1Slot16.transform;
                editDeck1[15].transform.localPosition = Vector3.zero;
                editDeck1[15].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[15].AddComponent<DeleteCardInEditMode>();

                editDeck1[16].transform.parent = deck1Slot17.transform;
                editDeck1[16].transform.localPosition = Vector3.zero;
                editDeck1[16].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[16].AddComponent<DeleteCardInEditMode>();

                editDeck1[17].transform.parent = deck1Slot18.transform;
                editDeck1[17].transform.localPosition = Vector3.zero;
                editDeck1[17].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[17].AddComponent<DeleteCardInEditMode>();

                editDeck1[18].transform.parent = deck1Slot19.transform;
                editDeck1[18].transform.localPosition = Vector3.zero;
                editDeck1[18].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[18].AddComponent<DeleteCardInEditMode>();

                editDeck1[19].transform.parent = deck1Slot20.transform;
                editDeck1[19].transform.localPosition = Vector3.zero;
                editDeck1[19].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[19].AddComponent<DeleteCardInEditMode>();

                editDeck1[20].transform.parent = deck1Slot21.transform;
                editDeck1[20].transform.localPosition = Vector3.zero;
                editDeck1[20].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[20].AddComponent<DeleteCardInEditMode>();

                editDeck1[21].transform.parent = deck1Slot22.transform;
                editDeck1[21].transform.localPosition = Vector3.zero;
                editDeck1[21].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[21].AddComponent<DeleteCardInEditMode>();

                editDeck1[22].transform.parent = deck1Slot23.transform;
                editDeck1[22].transform.localPosition = Vector3.zero;
                editDeck1[22].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[22].AddComponent<DeleteCardInEditMode>();

                editDeck1[23].transform.parent = deck1Slot24.transform;
                editDeck1[23].transform.localPosition = Vector3.zero;
                editDeck1[23].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[23].AddComponent<DeleteCardInEditMode>();

                editDeck1[24].transform.parent = deck1Slot25.transform;
                editDeck1[24].transform.localPosition = Vector3.zero;
                editDeck1[24].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[24].AddComponent<DeleteCardInEditMode>();

                editDeck1[25].transform.parent = deck1Slot26.transform;
                editDeck1[25].transform.localPosition = Vector3.zero;
                editDeck1[25].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[25].AddComponent<DeleteCardInEditMode>();

                editDeck1[26].transform.parent = deck1Slot27.transform;
                editDeck1[26].transform.localPosition = Vector3.zero;
                editDeck1[26].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[26].AddComponent<DeleteCardInEditMode>();

                editDeck1[27].transform.parent = deck1Slot28.transform;
                editDeck1[27].transform.localPosition = Vector3.zero;
                editDeck1[27].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[27].AddComponent<DeleteCardInEditMode>();

                editDeck1[28].transform.parent = deck1Slot29.transform;
                editDeck1[28].transform.localPosition = Vector3.zero;
                editDeck1[28].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[28].AddComponent<DeleteCardInEditMode>();

                editDeck1[29].transform.parent = deck1Slot30.transform;
                editDeck1[29].transform.localPosition = Vector3.zero;
                editDeck1[29].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[29].AddComponent<DeleteCardInEditMode>();

                editDeck1[30].transform.parent = deck1Slot31.transform;
                editDeck1[30].transform.localPosition = Vector3.zero;
                editDeck1[30].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[30].AddComponent<DeleteCardInEditMode>();

                editDeck1[31].transform.parent = deck1Slot32.transform;
                editDeck1[31].transform.localPosition = Vector3.zero;
                editDeck1[31].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[31].AddComponent<DeleteCardInEditMode>();

                editDeck1[32].transform.parent = deck1Slot33.transform;
                editDeck1[32].transform.localPosition = Vector3.zero;
                editDeck1[32].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[32].AddComponent<DeleteCardInEditMode>();

                editDeck1[33].transform.parent = deck1Slot34.transform;
                editDeck1[33].transform.localPosition = Vector3.zero;
                editDeck1[33].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[33].AddComponent<DeleteCardInEditMode>();

                editDeck1[34].transform.parent = deck1Slot35.transform;
                editDeck1[34].transform.localPosition = Vector3.zero;
                editDeck1[34].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[34].AddComponent<DeleteCardInEditMode>();

                editDeck1[35].transform.parent = deck1Slot36.transform;
                editDeck1[35].transform.localPosition = Vector3.zero;
                editDeck1[35].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[35].AddComponent<DeleteCardInEditMode>();

                editDeck1[36].transform.parent = deck1Slot37.transform;
                editDeck1[36].transform.localPosition = Vector3.zero;
                editDeck1[36].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[36].AddComponent<DeleteCardInEditMode>();

                editDeck1[37].transform.parent = deck1Slot38.transform;
                editDeck1[37].transform.localPosition = Vector3.zero;
                editDeck1[37].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[37].AddComponent<DeleteCardInEditMode>();

                editDeck1[38].transform.parent = deck1Slot39.transform;
                editDeck1[38].transform.localPosition = Vector3.zero;
                editDeck1[38].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[38].AddComponent<DeleteCardInEditMode>();

                editDeck1[39].transform.parent = deck1Slot40.transform;
                editDeck1[39].transform.localPosition = Vector3.zero;
                editDeck1[39].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[39].AddComponent<DeleteCardInEditMode>();

                editDeck1[40].transform.parent = deck1Slot41.transform;
                editDeck1[40].transform.localPosition = Vector3.zero;
                editDeck1[40].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[40].AddComponent<DeleteCardInEditMode>();

                editDeck1[41].transform.parent = deck1Slot42.transform;
                editDeck1[41].transform.localPosition = Vector3.zero;
                editDeck1[41].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[41].AddComponent<DeleteCardInEditMode>();

                editDeck1[42].transform.parent = deck1Slot43.transform;
                editDeck1[42].transform.localPosition = Vector3.zero;
                editDeck1[42].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[42].AddComponent<DeleteCardInEditMode>();

                editDeck1[43].transform.parent = deck1Slot44.transform;
                editDeck1[43].transform.localPosition = Vector3.zero;
                editDeck1[43].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[43].AddComponent<DeleteCardInEditMode>();

                editDeck1[44].transform.parent = deck1Slot45.transform;
                editDeck1[44].transform.localPosition = Vector3.zero;
                editDeck1[44].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[44].AddComponent<DeleteCardInEditMode>();

            } else if (editDeck1.Count == 50) {

                editDeck1[0].transform.parent = deck1Slot1.transform;
                editDeck1[0].transform.localPosition = Vector3.zero;
                editDeck1[0].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[0].AddComponent<DeleteCardInEditMode>();

                editDeck1[1].transform.parent = deck1Slot2.transform;
                editDeck1[1].transform.localPosition = Vector3.zero;
                editDeck1[1].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[1].AddComponent<DeleteCardInEditMode>();

                editDeck1[2].transform.parent = deck1Slot3.transform;
                editDeck1[2].transform.localPosition = Vector3.zero;
                editDeck1[2].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[2].AddComponent<DeleteCardInEditMode>();

                editDeck1[3].transform.parent = deck1Slot4.transform;
                editDeck1[3].transform.localPosition = Vector3.zero;
                editDeck1[3].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[3].AddComponent<DeleteCardInEditMode>();

                editDeck1[4].transform.parent = deck1Slot5.transform;
                editDeck1[4].transform.localPosition = Vector3.zero;
                editDeck1[4].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[4].AddComponent<DeleteCardInEditMode>();

                editDeck1[5].transform.parent = deck1Slot6.transform;
                editDeck1[5].transform.localPosition = Vector3.zero;
                editDeck1[5].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[5].AddComponent<DeleteCardInEditMode>();

                editDeck1[6].transform.parent = deck1Slot7.transform;
                editDeck1[6].transform.localPosition = Vector3.zero;
                editDeck1[6].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[6].AddComponent<DeleteCardInEditMode>();

                editDeck1[7].transform.parent = deck1Slot8.transform;
                editDeck1[7].transform.localPosition = Vector3.zero;
                editDeck1[7].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[7].AddComponent<DeleteCardInEditMode>();

                editDeck1[8].transform.parent = deck1Slot9.transform;
                editDeck1[8].transform.localPosition = Vector3.zero;
                editDeck1[8].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[8].AddComponent<DeleteCardInEditMode>();

                editDeck1[9].transform.parent = deck1Slot10.transform;
                editDeck1[9].transform.localPosition = Vector3.zero;
                editDeck1[9].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[9].AddComponent<DeleteCardInEditMode>();

                editDeck1[10].transform.parent = deck1Slot11.transform;
                editDeck1[10].transform.localPosition = Vector3.zero;
                editDeck1[10].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[10].AddComponent<DeleteCardInEditMode>();

                editDeck1[11].transform.parent = deck1Slot12.transform;
                editDeck1[11].transform.localPosition = Vector3.zero;
                editDeck1[11].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[11].AddComponent<DeleteCardInEditMode>();

                editDeck1[12].transform.parent = deck1Slot13.transform;
                editDeck1[12].transform.localPosition = Vector3.zero;
                editDeck1[12].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[12].AddComponent<DeleteCardInEditMode>();

                editDeck1[13].transform.parent = deck1Slot14.transform;
                editDeck1[13].transform.localPosition = Vector3.zero;
                editDeck1[13].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[13].AddComponent<DeleteCardInEditMode>();

                editDeck1[14].transform.parent = deck1Slot15.transform;
                editDeck1[14].transform.localPosition = Vector3.zero;
                editDeck1[14].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[14].AddComponent<DeleteCardInEditMode>();

                editDeck1[15].transform.parent = deck1Slot16.transform;
                editDeck1[15].transform.localPosition = Vector3.zero;
                editDeck1[15].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[15].AddComponent<DeleteCardInEditMode>();

                editDeck1[16].transform.parent = deck1Slot17.transform;
                editDeck1[16].transform.localPosition = Vector3.zero;
                editDeck1[16].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[16].AddComponent<DeleteCardInEditMode>();

                editDeck1[17].transform.parent = deck1Slot18.transform;
                editDeck1[17].transform.localPosition = Vector3.zero;
                editDeck1[17].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[17].AddComponent<DeleteCardInEditMode>();

                editDeck1[18].transform.parent = deck1Slot19.transform;
                editDeck1[18].transform.localPosition = Vector3.zero;
                editDeck1[18].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[18].AddComponent<DeleteCardInEditMode>();

                editDeck1[19].transform.parent = deck1Slot20.transform;
                editDeck1[19].transform.localPosition = Vector3.zero;
                editDeck1[19].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[19].AddComponent<DeleteCardInEditMode>();

                editDeck1[20].transform.parent = deck1Slot21.transform;
                editDeck1[20].transform.localPosition = Vector3.zero;
                editDeck1[20].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[20].AddComponent<DeleteCardInEditMode>();

                editDeck1[21].transform.parent = deck1Slot22.transform;
                editDeck1[21].transform.localPosition = Vector3.zero;
                editDeck1[21].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[21].AddComponent<DeleteCardInEditMode>();

                editDeck1[22].transform.parent = deck1Slot23.transform;
                editDeck1[22].transform.localPosition = Vector3.zero;
                editDeck1[22].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[22].AddComponent<DeleteCardInEditMode>();

                editDeck1[23].transform.parent = deck1Slot24.transform;
                editDeck1[23].transform.localPosition = Vector3.zero;
                editDeck1[23].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[23].AddComponent<DeleteCardInEditMode>();

                editDeck1[24].transform.parent = deck1Slot25.transform;
                editDeck1[24].transform.localPosition = Vector3.zero;
                editDeck1[24].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[24].AddComponent<DeleteCardInEditMode>();

                editDeck1[25].transform.parent = deck1Slot26.transform;
                editDeck1[25].transform.localPosition = Vector3.zero;
                editDeck1[25].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[25].AddComponent<DeleteCardInEditMode>();

                editDeck1[26].transform.parent = deck1Slot27.transform;
                editDeck1[26].transform.localPosition = Vector3.zero;
                editDeck1[26].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[26].AddComponent<DeleteCardInEditMode>();

                editDeck1[27].transform.parent = deck1Slot28.transform;
                editDeck1[27].transform.localPosition = Vector3.zero;
                editDeck1[27].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[27].AddComponent<DeleteCardInEditMode>();

                editDeck1[28].transform.parent = deck1Slot29.transform;
                editDeck1[28].transform.localPosition = Vector3.zero;
                editDeck1[28].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[28].AddComponent<DeleteCardInEditMode>();

                editDeck1[29].transform.parent = deck1Slot30.transform;
                editDeck1[29].transform.localPosition = Vector3.zero;
                editDeck1[29].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[29].AddComponent<DeleteCardInEditMode>();

                editDeck1[30].transform.parent = deck1Slot31.transform;
                editDeck1[30].transform.localPosition = Vector3.zero;
                editDeck1[30].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[30].AddComponent<DeleteCardInEditMode>();

                editDeck1[31].transform.parent = deck1Slot32.transform;
                editDeck1[31].transform.localPosition = Vector3.zero;
                editDeck1[31].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[31].AddComponent<DeleteCardInEditMode>();

                editDeck1[32].transform.parent = deck1Slot33.transform;
                editDeck1[32].transform.localPosition = Vector3.zero;
                editDeck1[32].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[32].AddComponent<DeleteCardInEditMode>();

                editDeck1[33].transform.parent = deck1Slot34.transform;
                editDeck1[33].transform.localPosition = Vector3.zero;
                editDeck1[33].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[33].AddComponent<DeleteCardInEditMode>();

                editDeck1[34].transform.parent = deck1Slot35.transform;
                editDeck1[34].transform.localPosition = Vector3.zero;
                editDeck1[34].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[34].AddComponent<DeleteCardInEditMode>();

                editDeck1[35].transform.parent = deck1Slot36.transform;
                editDeck1[35].transform.localPosition = Vector3.zero;
                editDeck1[35].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[35].AddComponent<DeleteCardInEditMode>();

                editDeck1[36].transform.parent = deck1Slot37.transform;
                editDeck1[36].transform.localPosition = Vector3.zero;
                editDeck1[36].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[36].AddComponent<DeleteCardInEditMode>();

                editDeck1[37].transform.parent = deck1Slot38.transform;
                editDeck1[37].transform.localPosition = Vector3.zero;
                editDeck1[37].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[37].AddComponent<DeleteCardInEditMode>();

                editDeck1[38].transform.parent = deck1Slot39.transform;
                editDeck1[38].transform.localPosition = Vector3.zero;
                editDeck1[38].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[38].AddComponent<DeleteCardInEditMode>();

                editDeck1[39].transform.parent = deck1Slot40.transform;
                editDeck1[39].transform.localPosition = Vector3.zero;
                editDeck1[39].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[39].AddComponent<DeleteCardInEditMode>();

                editDeck1[40].transform.parent = deck1Slot41.transform;
                editDeck1[40].transform.localPosition = Vector3.zero;
                editDeck1[40].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[40].AddComponent<DeleteCardInEditMode>();

                editDeck1[41].transform.parent = deck1Slot42.transform;
                editDeck1[41].transform.localPosition = Vector3.zero;
                editDeck1[41].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[41].AddComponent<DeleteCardInEditMode>();

                editDeck1[42].transform.parent = deck1Slot43.transform;
                editDeck1[42].transform.localPosition = Vector3.zero;
                editDeck1[42].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[42].AddComponent<DeleteCardInEditMode>();

                editDeck1[43].transform.parent = deck1Slot44.transform;
                editDeck1[43].transform.localPosition = Vector3.zero;
                editDeck1[43].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[43].AddComponent<DeleteCardInEditMode>();

                editDeck1[44].transform.parent = deck1Slot45.transform;
                editDeck1[44].transform.localPosition = Vector3.zero;
                editDeck1[44].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[44].AddComponent<DeleteCardInEditMode>();

                editDeck1[45].transform.parent = deck1Slot46.transform;
                editDeck1[45].transform.localPosition = Vector3.zero;
                editDeck1[45].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[45].AddComponent<DeleteCardInEditMode>();

                editDeck1[46].transform.parent = deck1Slot47.transform;
                editDeck1[46].transform.localPosition = Vector3.zero;
                editDeck1[46].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[46].AddComponent<DeleteCardInEditMode>();

                editDeck1[47].transform.parent = deck1Slot48.transform;
                editDeck1[47].transform.localPosition = Vector3.zero;
                editDeck1[47].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[47].AddComponent<DeleteCardInEditMode>();

                editDeck1[48].transform.parent = deck1Slot49.transform;
                editDeck1[48].transform.localPosition = Vector3.zero;
                editDeck1[48].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[48].AddComponent<DeleteCardInEditMode>();

                editDeck1[49].transform.parent = deck1Slot50.transform;
                editDeck1[49].transform.localPosition = Vector3.zero;
                editDeck1[49].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[49].AddComponent<DeleteCardInEditMode>();

            } else if (editDeck1.Count == 55) {

                editDeck1[0].transform.parent = deck1Slot1.transform;
                editDeck1[0].transform.localPosition = Vector3.zero;
                editDeck1[0].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[0].AddComponent<DeleteCardInEditMode>();

                editDeck1[1].transform.parent = deck1Slot2.transform;
                editDeck1[1].transform.localPosition = Vector3.zero;
                editDeck1[1].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[1].AddComponent<DeleteCardInEditMode>();

                editDeck1[2].transform.parent = deck1Slot3.transform;
                editDeck1[2].transform.localPosition = Vector3.zero;
                editDeck1[2].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[2].AddComponent<DeleteCardInEditMode>();

                editDeck1[3].transform.parent = deck1Slot4.transform;
                editDeck1[3].transform.localPosition = Vector3.zero;
                editDeck1[3].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[3].AddComponent<DeleteCardInEditMode>();

                editDeck1[4].transform.parent = deck1Slot5.transform;
                editDeck1[4].transform.localPosition = Vector3.zero;
                editDeck1[4].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[4].AddComponent<DeleteCardInEditMode>();

                editDeck1[5].transform.parent = deck1Slot6.transform;
                editDeck1[5].transform.localPosition = Vector3.zero;
                editDeck1[5].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[5].AddComponent<DeleteCardInEditMode>();

                editDeck1[6].transform.parent = deck1Slot7.transform;
                editDeck1[6].transform.localPosition = Vector3.zero;
                editDeck1[6].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[6].AddComponent<DeleteCardInEditMode>();

                editDeck1[7].transform.parent = deck1Slot8.transform;
                editDeck1[7].transform.localPosition = Vector3.zero;
                editDeck1[7].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[7].AddComponent<DeleteCardInEditMode>();

                editDeck1[8].transform.parent = deck1Slot9.transform;
                editDeck1[8].transform.localPosition = Vector3.zero;
                editDeck1[8].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[8].AddComponent<DeleteCardInEditMode>();

                editDeck1[9].transform.parent = deck1Slot10.transform;
                editDeck1[9].transform.localPosition = Vector3.zero;
                editDeck1[9].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[9].AddComponent<DeleteCardInEditMode>();

                editDeck1[10].transform.parent = deck1Slot11.transform;
                editDeck1[10].transform.localPosition = Vector3.zero;
                editDeck1[10].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[10].AddComponent<DeleteCardInEditMode>();

                editDeck1[11].transform.parent = deck1Slot12.transform;
                editDeck1[11].transform.localPosition = Vector3.zero;
                editDeck1[11].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[11].AddComponent<DeleteCardInEditMode>();

                editDeck1[12].transform.parent = deck1Slot13.transform;
                editDeck1[12].transform.localPosition = Vector3.zero;
                editDeck1[12].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[12].AddComponent<DeleteCardInEditMode>();

                editDeck1[13].transform.parent = deck1Slot14.transform;
                editDeck1[13].transform.localPosition = Vector3.zero;
                editDeck1[13].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[13].AddComponent<DeleteCardInEditMode>();

                editDeck1[14].transform.parent = deck1Slot15.transform;
                editDeck1[14].transform.localPosition = Vector3.zero;
                editDeck1[14].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[14].AddComponent<DeleteCardInEditMode>();

                editDeck1[15].transform.parent = deck1Slot16.transform;
                editDeck1[15].transform.localPosition = Vector3.zero;
                editDeck1[15].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[15].AddComponent<DeleteCardInEditMode>();

                editDeck1[16].transform.parent = deck1Slot17.transform;
                editDeck1[16].transform.localPosition = Vector3.zero;
                editDeck1[16].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[16].AddComponent<DeleteCardInEditMode>();

                editDeck1[17].transform.parent = deck1Slot18.transform;
                editDeck1[17].transform.localPosition = Vector3.zero;
                editDeck1[17].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[17].AddComponent<DeleteCardInEditMode>();

                editDeck1[18].transform.parent = deck1Slot19.transform;
                editDeck1[18].transform.localPosition = Vector3.zero;
                editDeck1[18].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[18].AddComponent<DeleteCardInEditMode>();

                editDeck1[19].transform.parent = deck1Slot20.transform;
                editDeck1[19].transform.localPosition = Vector3.zero;
                editDeck1[19].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[19].AddComponent<DeleteCardInEditMode>();

                editDeck1[20].transform.parent = deck1Slot21.transform;
                editDeck1[20].transform.localPosition = Vector3.zero;
                editDeck1[20].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[20].AddComponent<DeleteCardInEditMode>();

                editDeck1[21].transform.parent = deck1Slot22.transform;
                editDeck1[21].transform.localPosition = Vector3.zero;
                editDeck1[21].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[21].AddComponent<DeleteCardInEditMode>();

                editDeck1[22].transform.parent = deck1Slot23.transform;
                editDeck1[22].transform.localPosition = Vector3.zero;
                editDeck1[22].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[22].AddComponent<DeleteCardInEditMode>();

                editDeck1[23].transform.parent = deck1Slot24.transform;
                editDeck1[23].transform.localPosition = Vector3.zero;
                editDeck1[23].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[23].AddComponent<DeleteCardInEditMode>();

                editDeck1[24].transform.parent = deck1Slot25.transform;
                editDeck1[24].transform.localPosition = Vector3.zero;
                editDeck1[24].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[24].AddComponent<DeleteCardInEditMode>();

                editDeck1[25].transform.parent = deck1Slot26.transform;
                editDeck1[25].transform.localPosition = Vector3.zero;
                editDeck1[25].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[25].AddComponent<DeleteCardInEditMode>();

                editDeck1[26].transform.parent = deck1Slot27.transform;
                editDeck1[26].transform.localPosition = Vector3.zero;
                editDeck1[26].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[26].AddComponent<DeleteCardInEditMode>();

                editDeck1[27].transform.parent = deck1Slot28.transform;
                editDeck1[27].transform.localPosition = Vector3.zero;
                editDeck1[27].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[27].AddComponent<DeleteCardInEditMode>();

                editDeck1[28].transform.parent = deck1Slot29.transform;
                editDeck1[28].transform.localPosition = Vector3.zero;
                editDeck1[28].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[28].AddComponent<DeleteCardInEditMode>();

                editDeck1[29].transform.parent = deck1Slot30.transform;
                editDeck1[29].transform.localPosition = Vector3.zero;
                editDeck1[29].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[29].AddComponent<DeleteCardInEditMode>();

                editDeck1[30].transform.parent = deck1Slot31.transform;
                editDeck1[30].transform.localPosition = Vector3.zero;
                editDeck1[30].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[30].AddComponent<DeleteCardInEditMode>();

                editDeck1[31].transform.parent = deck1Slot32.transform;
                editDeck1[31].transform.localPosition = Vector3.zero;
                editDeck1[31].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[31].AddComponent<DeleteCardInEditMode>();

                editDeck1[32].transform.parent = deck1Slot33.transform;
                editDeck1[32].transform.localPosition = Vector3.zero;
                editDeck1[32].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[32].AddComponent<DeleteCardInEditMode>();

                editDeck1[33].transform.parent = deck1Slot34.transform;
                editDeck1[33].transform.localPosition = Vector3.zero;
                editDeck1[33].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[33].AddComponent<DeleteCardInEditMode>();

                editDeck1[34].transform.parent = deck1Slot35.transform;
                editDeck1[34].transform.localPosition = Vector3.zero;
                editDeck1[34].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[34].AddComponent<DeleteCardInEditMode>();

                editDeck1[35].transform.parent = deck1Slot36.transform;
                editDeck1[35].transform.localPosition = Vector3.zero;
                editDeck1[35].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[35].AddComponent<DeleteCardInEditMode>();

                editDeck1[36].transform.parent = deck1Slot37.transform;
                editDeck1[36].transform.localPosition = Vector3.zero;
                editDeck1[36].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[36].AddComponent<DeleteCardInEditMode>();

                editDeck1[37].transform.parent = deck1Slot38.transform;
                editDeck1[37].transform.localPosition = Vector3.zero;
                editDeck1[37].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[37].AddComponent<DeleteCardInEditMode>();

                editDeck1[38].transform.parent = deck1Slot39.transform;
                editDeck1[38].transform.localPosition = Vector3.zero;
                editDeck1[38].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[38].AddComponent<DeleteCardInEditMode>();

                editDeck1[39].transform.parent = deck1Slot40.transform;
                editDeck1[39].transform.localPosition = Vector3.zero;
                editDeck1[39].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[39].AddComponent<DeleteCardInEditMode>();

                editDeck1[40].transform.parent = deck1Slot41.transform;
                editDeck1[40].transform.localPosition = Vector3.zero;
                editDeck1[40].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[40].AddComponent<DeleteCardInEditMode>();

                editDeck1[41].transform.parent = deck1Slot42.transform;
                editDeck1[41].transform.localPosition = Vector3.zero;
                editDeck1[41].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[41].AddComponent<DeleteCardInEditMode>();

                editDeck1[42].transform.parent = deck1Slot43.transform;
                editDeck1[42].transform.localPosition = Vector3.zero;
                editDeck1[42].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[42].AddComponent<DeleteCardInEditMode>();

                editDeck1[43].transform.parent = deck1Slot44.transform;
                editDeck1[43].transform.localPosition = Vector3.zero;
                editDeck1[43].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[43].AddComponent<DeleteCardInEditMode>();

                editDeck1[44].transform.parent = deck1Slot45.transform;
                editDeck1[44].transform.localPosition = Vector3.zero;
                editDeck1[44].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[44].AddComponent<DeleteCardInEditMode>();

                editDeck1[45].transform.parent = deck1Slot46.transform;
                editDeck1[45].transform.localPosition = Vector3.zero;
                editDeck1[45].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[45].AddComponent<DeleteCardInEditMode>();

                editDeck1[46].transform.parent = deck1Slot47.transform;
                editDeck1[46].transform.localPosition = Vector3.zero;
                editDeck1[46].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[46].AddComponent<DeleteCardInEditMode>();

                editDeck1[47].transform.parent = deck1Slot48.transform;
                editDeck1[47].transform.localPosition = Vector3.zero;
                editDeck1[47].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[47].AddComponent<DeleteCardInEditMode>();

                editDeck1[48].transform.parent = deck1Slot49.transform;
                editDeck1[48].transform.localPosition = Vector3.zero;
                editDeck1[48].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[48].AddComponent<DeleteCardInEditMode>();

                editDeck1[49].transform.parent = deck1Slot50.transform;
                editDeck1[49].transform.localPosition = Vector3.zero;
                editDeck1[49].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[49].AddComponent<DeleteCardInEditMode>();

                editDeck1[50].transform.parent = deck1Slot51.transform;
                editDeck1[50].transform.localPosition = Vector3.zero;
                editDeck1[50].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[50].AddComponent<DeleteCardInEditMode>();

                editDeck1[51].transform.parent = deck1Slot52.transform;
                editDeck1[51].transform.localPosition = Vector3.zero;
                editDeck1[51].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[51].AddComponent<DeleteCardInEditMode>();

                editDeck1[52].transform.parent = deck1Slot53.transform;
                editDeck1[52].transform.localPosition = Vector3.zero;
                editDeck1[52].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[52].AddComponent<DeleteCardInEditMode>();

                editDeck1[53].transform.parent = deck1Slot54.transform;
                editDeck1[53].transform.localPosition = Vector3.zero;
                editDeck1[53].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[53].AddComponent<DeleteCardInEditMode>();

                editDeck1[54].transform.parent = deck1Slot55.transform;
                editDeck1[54].transform.localPosition = Vector3.zero;
                editDeck1[54].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[54].AddComponent<DeleteCardInEditMode>();

            } else if (editDeck1.Count == 60) {

                editDeck1[0].transform.parent = deck1Slot1.transform;
                editDeck1[0].transform.localPosition = Vector3.zero;
                editDeck1[0].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[0].AddComponent<DeleteCardInEditMode>();

                editDeck1[1].transform.parent = deck1Slot2.transform;
                editDeck1[1].transform.localPosition = Vector3.zero;
                editDeck1[1].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[1].AddComponent<DeleteCardInEditMode>();

                editDeck1[2].transform.parent = deck1Slot3.transform;
                editDeck1[2].transform.localPosition = Vector3.zero;
                editDeck1[2].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[2].AddComponent<DeleteCardInEditMode>();

                editDeck1[3].transform.parent = deck1Slot4.transform;
                editDeck1[3].transform.localPosition = Vector3.zero;
                editDeck1[3].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[3].AddComponent<DeleteCardInEditMode>();

                editDeck1[4].transform.parent = deck1Slot5.transform;
                editDeck1[4].transform.localPosition = Vector3.zero;
                editDeck1[4].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[4].AddComponent<DeleteCardInEditMode>();

                editDeck1[5].transform.parent = deck1Slot6.transform;
                editDeck1[5].transform.localPosition = Vector3.zero;
                editDeck1[5].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[5].AddComponent<DeleteCardInEditMode>();

                editDeck1[6].transform.parent = deck1Slot7.transform;
                editDeck1[6].transform.localPosition = Vector3.zero;
                editDeck1[6].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[6].AddComponent<DeleteCardInEditMode>();

                editDeck1[7].transform.parent = deck1Slot8.transform;
                editDeck1[7].transform.localPosition = Vector3.zero;
                editDeck1[7].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[7].AddComponent<DeleteCardInEditMode>();

                editDeck1[8].transform.parent = deck1Slot9.transform;
                editDeck1[8].transform.localPosition = Vector3.zero;
                editDeck1[8].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[8].AddComponent<DeleteCardInEditMode>();

                editDeck1[9].transform.parent = deck1Slot10.transform;
                editDeck1[9].transform.localPosition = Vector3.zero;
                editDeck1[9].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[9].AddComponent<DeleteCardInEditMode>();

                editDeck1[10].transform.parent = deck1Slot11.transform;
                editDeck1[10].transform.localPosition = Vector3.zero;
                editDeck1[10].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[10].AddComponent<DeleteCardInEditMode>();

                editDeck1[11].transform.parent = deck1Slot12.transform;
                editDeck1[11].transform.localPosition = Vector3.zero;
                editDeck1[11].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[11].AddComponent<DeleteCardInEditMode>();

                editDeck1[12].transform.parent = deck1Slot13.transform;
                editDeck1[12].transform.localPosition = Vector3.zero;
                editDeck1[12].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[12].AddComponent<DeleteCardInEditMode>();

                editDeck1[13].transform.parent = deck1Slot14.transform;
                editDeck1[13].transform.localPosition = Vector3.zero;
                editDeck1[13].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[13].AddComponent<DeleteCardInEditMode>();

                editDeck1[14].transform.parent = deck1Slot15.transform;
                editDeck1[14].transform.localPosition = Vector3.zero;
                editDeck1[14].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[14].AddComponent<DeleteCardInEditMode>();

                editDeck1[15].transform.parent = deck1Slot16.transform;
                editDeck1[15].transform.localPosition = Vector3.zero;
                editDeck1[15].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[15].AddComponent<DeleteCardInEditMode>();

                editDeck1[16].transform.parent = deck1Slot17.transform;
                editDeck1[16].transform.localPosition = Vector3.zero;
                editDeck1[16].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[16].AddComponent<DeleteCardInEditMode>();

                editDeck1[17].transform.parent = deck1Slot18.transform;
                editDeck1[17].transform.localPosition = Vector3.zero;
                editDeck1[17].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[17].AddComponent<DeleteCardInEditMode>();

                editDeck1[18].transform.parent = deck1Slot19.transform;
                editDeck1[18].transform.localPosition = Vector3.zero;
                editDeck1[18].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[18].AddComponent<DeleteCardInEditMode>();

                editDeck1[19].transform.parent = deck1Slot20.transform;
                editDeck1[19].transform.localPosition = Vector3.zero;
                editDeck1[19].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[19].AddComponent<DeleteCardInEditMode>();

                editDeck1[20].transform.parent = deck1Slot21.transform;
                editDeck1[20].transform.localPosition = Vector3.zero;
                editDeck1[20].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[20].AddComponent<DeleteCardInEditMode>();

                editDeck1[21].transform.parent = deck1Slot22.transform;
                editDeck1[21].transform.localPosition = Vector3.zero;
                editDeck1[21].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[21].AddComponent<DeleteCardInEditMode>();

                editDeck1[22].transform.parent = deck1Slot23.transform;
                editDeck1[22].transform.localPosition = Vector3.zero;
                editDeck1[22].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[22].AddComponent<DeleteCardInEditMode>();

                editDeck1[23].transform.parent = deck1Slot24.transform;
                editDeck1[23].transform.localPosition = Vector3.zero;
                editDeck1[23].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[23].AddComponent<DeleteCardInEditMode>();

                editDeck1[24].transform.parent = deck1Slot25.transform;
                editDeck1[24].transform.localPosition = Vector3.zero;
                editDeck1[24].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[24].AddComponent<DeleteCardInEditMode>();

                editDeck1[25].transform.parent = deck1Slot26.transform;
                editDeck1[25].transform.localPosition = Vector3.zero;
                editDeck1[25].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[25].AddComponent<DeleteCardInEditMode>();

                editDeck1[26].transform.parent = deck1Slot27.transform;
                editDeck1[26].transform.localPosition = Vector3.zero;
                editDeck1[26].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[26].AddComponent<DeleteCardInEditMode>();

                editDeck1[27].transform.parent = deck1Slot28.transform;
                editDeck1[27].transform.localPosition = Vector3.zero;
                editDeck1[27].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[27].AddComponent<DeleteCardInEditMode>();

                editDeck1[28].transform.parent = deck1Slot29.transform;
                editDeck1[28].transform.localPosition = Vector3.zero;
                editDeck1[28].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[28].AddComponent<DeleteCardInEditMode>();

                editDeck1[29].transform.parent = deck1Slot30.transform;
                editDeck1[29].transform.localPosition = Vector3.zero;
                editDeck1[29].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[29].AddComponent<DeleteCardInEditMode>();

                editDeck1[30].transform.parent = deck1Slot31.transform;
                editDeck1[30].transform.localPosition = Vector3.zero;
                editDeck1[30].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[30].AddComponent<DeleteCardInEditMode>();

                editDeck1[31].transform.parent = deck1Slot32.transform;
                editDeck1[31].transform.localPosition = Vector3.zero;
                editDeck1[31].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[31].AddComponent<DeleteCardInEditMode>();

                editDeck1[32].transform.parent = deck1Slot33.transform;
                editDeck1[32].transform.localPosition = Vector3.zero;
                editDeck1[32].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[32].AddComponent<DeleteCardInEditMode>();

                editDeck1[33].transform.parent = deck1Slot34.transform;
                editDeck1[33].transform.localPosition = Vector3.zero;
                editDeck1[33].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[33].AddComponent<DeleteCardInEditMode>();

                editDeck1[34].transform.parent = deck1Slot35.transform;
                editDeck1[34].transform.localPosition = Vector3.zero;
                editDeck1[34].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[34].AddComponent<DeleteCardInEditMode>();

                editDeck1[35].transform.parent = deck1Slot36.transform;
                editDeck1[35].transform.localPosition = Vector3.zero;
                editDeck1[35].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[35].AddComponent<DeleteCardInEditMode>();

                editDeck1[36].transform.parent = deck1Slot37.transform;
                editDeck1[36].transform.localPosition = Vector3.zero;
                editDeck1[36].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[36].AddComponent<DeleteCardInEditMode>();

                editDeck1[37].transform.parent = deck1Slot38.transform;
                editDeck1[37].transform.localPosition = Vector3.zero;
                editDeck1[37].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[37].AddComponent<DeleteCardInEditMode>();

                editDeck1[38].transform.parent = deck1Slot39.transform;
                editDeck1[38].transform.localPosition = Vector3.zero;
                editDeck1[38].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[38].AddComponent<DeleteCardInEditMode>();

                editDeck1[39].transform.parent = deck1Slot40.transform;
                editDeck1[39].transform.localPosition = Vector3.zero;
                editDeck1[39].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[39].AddComponent<DeleteCardInEditMode>();

                editDeck1[40].transform.parent = deck1Slot41.transform;
                editDeck1[40].transform.localPosition = Vector3.zero;
                editDeck1[40].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[40].AddComponent<DeleteCardInEditMode>();

                editDeck1[41].transform.parent = deck1Slot42.transform;
                editDeck1[41].transform.localPosition = Vector3.zero;
                editDeck1[41].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[41].AddComponent<DeleteCardInEditMode>();

                editDeck1[42].transform.parent = deck1Slot43.transform;
                editDeck1[42].transform.localPosition = Vector3.zero;
                editDeck1[42].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[42].AddComponent<DeleteCardInEditMode>();

                editDeck1[43].transform.parent = deck1Slot44.transform;
                editDeck1[43].transform.localPosition = Vector3.zero;
                editDeck1[43].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[43].AddComponent<DeleteCardInEditMode>();

                editDeck1[44].transform.parent = deck1Slot45.transform;
                editDeck1[44].transform.localPosition = Vector3.zero;
                editDeck1[44].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[44].AddComponent<DeleteCardInEditMode>();

                editDeck1[45].transform.parent = deck1Slot46.transform;
                editDeck1[45].transform.localPosition = Vector3.zero;
                editDeck1[45].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[45].AddComponent<DeleteCardInEditMode>();

                editDeck1[46].transform.parent = deck1Slot47.transform;
                editDeck1[46].transform.localPosition = Vector3.zero;
                editDeck1[46].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[46].AddComponent<DeleteCardInEditMode>();

                editDeck1[47].transform.parent = deck1Slot48.transform;
                editDeck1[47].transform.localPosition = Vector3.zero;
                editDeck1[47].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[47].AddComponent<DeleteCardInEditMode>();

                editDeck1[48].transform.parent = deck1Slot49.transform;
                editDeck1[48].transform.localPosition = Vector3.zero;
                editDeck1[48].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[48].AddComponent<DeleteCardInEditMode>();

                editDeck1[49].transform.parent = deck1Slot50.transform;
                editDeck1[49].transform.localPosition = Vector3.zero;
                editDeck1[49].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[49].AddComponent<DeleteCardInEditMode>();

                editDeck1[50].transform.parent = deck1Slot51.transform;
                editDeck1[50].transform.localPosition = Vector3.zero;
                editDeck1[50].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[50].AddComponent<DeleteCardInEditMode>();

                editDeck1[51].transform.parent = deck1Slot52.transform;
                editDeck1[51].transform.localPosition = Vector3.zero;
                editDeck1[51].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[51].AddComponent<DeleteCardInEditMode>();

                editDeck1[52].transform.parent = deck1Slot53.transform;
                editDeck1[52].transform.localPosition = Vector3.zero;
                editDeck1[52].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[52].AddComponent<DeleteCardInEditMode>();

                editDeck1[53].transform.parent = deck1Slot54.transform;
                editDeck1[53].transform.localPosition = Vector3.zero;
                editDeck1[53].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[53].AddComponent<DeleteCardInEditMode>();

                editDeck1[54].transform.parent = deck1Slot55.transform;
                editDeck1[54].transform.localPosition = Vector3.zero;
                editDeck1[54].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[54].AddComponent<DeleteCardInEditMode>();

                editDeck1[55].transform.parent = deck1Slot56.transform;
                editDeck1[55].transform.localPosition = Vector3.zero;
                editDeck1[55].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[55].AddComponent<DeleteCardInEditMode>();

                editDeck1[56].transform.parent = deck1Slot57.transform;
                editDeck1[56].transform.localPosition = Vector3.zero;
                editDeck1[56].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[56].AddComponent<DeleteCardInEditMode>();

                editDeck1[57].transform.parent = deck1Slot58.transform;
                editDeck1[57].transform.localPosition = Vector3.zero;
                editDeck1[57].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[57].AddComponent<DeleteCardInEditMode>();

                editDeck1[58].transform.parent = deck1Slot59.transform;
                editDeck1[58].transform.localPosition = Vector3.zero;
                editDeck1[58].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[58].AddComponent<DeleteCardInEditMode>();

                editDeck1[59].transform.parent = deck1Slot60.transform;
                editDeck1[59].transform.localPosition = Vector3.zero;
                editDeck1[59].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck1[59].AddComponent<DeleteCardInEditMode>();
            } else {

                return;
            }

            #endregion

            //Enable choosing cards from the collection
            DeckManager.deckManager.switcher1 = true;
            DeckManager.deckManager.switcher2 = false;
            DeckManager.deckManager.switcher3 = false;

            edit1Button.GetComponent<Button>().interactable = false;
            delete1Button.GetComponent<Button>().interactable = true;

            //if(getDeck){
            //GetCardCounterInDeck1();
            //getDeck = false;
            //}

        }



        /** Get number of the same cards in the deck */
        public static void GetCardCounterInDeck1() {

            //Only 4 the same cards possible in one deck
            #region EditCheckTheSameCards definition

            foreach (GameObject card in editDeck1) {



                if (card.name == "instantiated1Card1") {

                    instantiated1Card1List.Add(card);

                } else if (card.name == "instantiated1Card1a") {

                    instantiated1Card1aList.Add(card);

                } else if (card.name == "instantiated1Card1b") {

                    instantiated1Card1bList.Add(card);

                } else if (card.name == "instantiated1Card1c") {

                    instantiated1Card1cList.Add(card);

                } else if (card.name == "instantiated1Card2") {

                    instantiated1Card2List.Add(card);


                } else if (card.name == "instantiated1Card2a") {

                    instantiated1Card2aList.Add(card);

                } else if (card.name == "instantiated1Card2b") {

                    instantiated1Card2bList.Add(card);

                } else if (card.name == "instantiated1Card2c") {

                    instantiated1Card2cList.Add(card);

                } else if (card.name == "instantiated1Card3") {

                    instantiated1Card3List.Add(card);

                } else if (card.name == "instantiated1Card3a") {

                    instantiated1Card3aList.Add(card);

                } else if (card.name == "instantiated1Card3b") {

                    instantiated1Card3bList.Add(card);

                } else if (card.name == "instantiated1Card3c") {

                    instantiated1Card3cList.Add(card);

                } else if (card.name == "instantiated1Card4") {

                    instantiated1Card4List.Add(card);

                } else if (card.name == "instantiated1Card4a") {

                    instantiated1Card4aList.Add(card);

                } else if (card.name == "instantiated1Card4b") {

                    instantiated1Card4bList.Add(card);

                } else if (card.name == "instantiated1Card4c") {

                    instantiated1Card4cList.Add(card);

                } else if (card.name == "instantiated1Card5") {

                    instantiated1Card5List.Add(card);

                } else if (card.name == "instantiated1Card5a") {

                    instantiated1Card5aList.Add(card);

                } else if (card.name == "instantiated1Card5b") {

                    instantiated1Card5bList.Add(card);

                } else if (card.name == "instantiated1Card5c") {

                    instantiated1Card5cList.Add(card);

                } else if (card.name == "instantiated1Card6") {

                    instantiated1Card6List.Add(card);

                } else if (card.name == "instantiated1Card6a") {

                    instantiated1Card6aList.Add(card);

                } else if (card.name == "instantiated1Card6b") {

                    instantiated1Card6bList.Add(card);

                } else if (card.name == "instantiated1Card6c") {

                    instantiated1Card6cList.Add(card);

                } else if (card.name == "instantiated1Card7") {

                    instantiated1Card7List.Add(card);

                } else if (card.name == "instantiated1Card7a") {

                    instantiated1Card7aList.Add(card);

                } else if (card.name == "instantiated1Card7b") {

                    instantiated1Card7bList.Add(card);

                } else if (card.name == "instantiated1Card7c") {

                    instantiated1Card7cList.Add(card);

                } else if (card.name == "instantiated1Card8") {

                    instantiated1Card8List.Add(card);

                } else if (card.name == "instantiated1Card8a") {

                    instantiated1Card8aList.Add(card);

                } else if (card.name == "instantiated1Card8b") {

                    instantiated1Card8bList.Add(card);

                } else if (card.name == "instantiated1Card8c") {

                    instantiated1Card8cList.Add(card);

                } else if (card.name == "instantiated1Card9") {

                    instantiated1Card9List.Add(card);

                } else if (card.name == "instantiated1Card9a") {

                    instantiated1Card9aList.Add(card);

                } else if (card.name == "instantiated1Card9b") {

                    instantiated1Card9bList.Add(card);

                } else if (card.name == "instantiated1Card9c") {

                    instantiated1Card9cList.Add(card);

                } else if (card.name == "instantiated1Card10") {

                    instantiated1Card10List.Add(card);

                } else if (card.name == "instantiated1Card10a") {

                    instantiated1Card10aList.Add(card);

                } else if (card.name == "instantiated1Card10b") {

                    instantiated1Card10bList.Add(card);

                } else if (card.name == "instantiated1Card10c") {

                    instantiated1Card10cList.Add(card);

                } else if (card.name == "instantiated1Card11") {

                    instantiated1Card11List.Add(card);

                } else if (card.name == "instantiated1Card11a") {

                    instantiated1Card11aList.Add(card);

                } else if (card.name == "instantiated1Card11b") {

                    instantiated1Card11bList.Add(card);

                } else if (card.name == "instantiated1Card11c") {

                    instantiated1Card11cList.Add(card);

                } else if (card.name == "instantiated1Card12") {

                    instantiated1Card12List.Add(card);

                } else if (card.name == "instantiated1Card12a") {

                    instantiated1Card12aList.Add(card);

                } else if (card.name == "instantiated1Card12b") {

                    instantiated1Card12bList.Add(card);

                } else if (card.name == "instantiated1Card12c") {

                    instantiated1Card12cList.Add(card);

                } else if (card.name == "instantiated1Card13") {

                    instantiated1Card13List.Add(card);

                } else if (card.name == "instantiated1Card13a") {

                    instantiated1Card13aList.Add(card);

                } else if (card.name == "instantiated1Card13b") {

                    instantiated1Card13bList.Add(card);

                } else if (card.name == "instantiated1Card13c") {

                    instantiated1Card13cList.Add(card);

                } else if (card.name == "instantiated1Card14") {

                    instantiated1Card14List.Add(card);

                } else if (card.name == "instantiated1Card14a") {

                    instantiated1Card14aList.Add(card);

                } else if (card.name == "instantiated1Card14b") {

                    instantiated1Card14bList.Add(card);

                } else if (card.name == "instantiated1Card14c") {

                    instantiated1Card14cList.Add(card);

                } else if (card.name == "instantiated1Card15") {

                    instantiated1Card15List.Add(card);

                } else if (card.name == "instantiated1Card15a") {

                    instantiated1Card15aList.Add(card);

                } else if (card.name == "instantiated1Card15b") {

                    instantiated1Card15bList.Add(card);

                } else if (card.name == "instantiated1Card15c") {

                    instantiated1Card15cList.Add(card);

                } else if (card.name == "instantiated1Card16") {

                    instantiated1Card16List.Add(card);

                } else if (card.name == "instantiated1Card16a") {

                    instantiated1Card16aList.Add(card);

                } else if (card.name == "instantiated1Card16b") {

                    instantiated1Card16bList.Add(card);

                } else if (card.name == "instantiated1Card16c") {

                    instantiated1Card16cList.Add(card);

                } else if (card.name == "instantiated1Card17") {

                    instantiated1Card17List.Add(card);

                } else if (card.name == "instantiated1Card17a") {

                    instantiated1Card17aList.Add(card);

                } else if (card.name == "instantiated1Card17b") {

                    instantiated1Card17bList.Add(card);

                } else if (card.name == "instantiated1Card17c") {

                    instantiated1Card17cList.Add(card);

                } else if (card.name == "instantiated1Card18") {

                    instantiated1Card18List.Add(card);

                } else if (card.name == "instantiated1Card18a") {

                    instantiated1Card18aList.Add(card);

                } else if (card.name == "instantiated1Card18b") {

                    instantiated1Card18bList.Add(card);

                } else if (card.name == "instantiated1Card18c") {

                    instantiated1Card18cList.Add(card);

                } else if (card.name == "instantiated1Card19") {

                    instantiated1Card19List.Add(card);

                } else if (card.name == "instantiated1Card19a") {

                    instantiated1Card19aList.Add(card);

                } else if (card.name == "instantiated1Card19b") {

                    instantiated1Card19bList.Add(card);

                } else if (card.name == "instantiated1Card19c") {

                    instantiated1Card19cList.Add(card);

                } else if (card.name == "instantiated1Card20") {

                    instantiated1Card20List.Add(card);

                } else if (card.name == "instantiated1Card20a") {

                    instantiated1Card20aList.Add(card);

                } else if (card.name == "instantiated1Card20b") {

                    instantiated1Card20bList.Add(card);

                } else if (card.name == "instantiated1Card20c") {

                    instantiated1Card20cList.Add(card);

                } else if (card.name == "instantiated1Card21") {

                    instantiated1Card21List.Add(card);

                } else if (card.name == "instantiated1Card21a") {

                    instantiated1Card21aList.Add(card);

                } else if (card.name == "instantiated1Card21b") {

                    instantiated1Card21bList.Add(card);

                } else if (card.name == "instantiated1Card21c") {

                    instantiated1Card21cList.Add(card);

                } else if (card.name == "instantiated1Card22") {

                    instantiated1Card22List.Add(card);

                } else if (card.name == "instantiated1Card22a") {

                    instantiated1Card22aList.Add(card);

                } else if (card.name == "instantiated1Card22b") {

                    instantiated1Card22bList.Add(card);

                } else if (card.name == "instantiated1Card22c") {

                    instantiated1Card22cList.Add(card);

                } else if (card.name == "instantiated1Card23") {

                    instantiated1Card23List.Add(card);

                } else if (card.name == "instantiated1Card23a") {

                    instantiated1Card23aList.Add(card);

                } else if (card.name == "instantiated1Card23b") {

                    instantiated1Card23bList.Add(card);

                } else if (card.name == "instantiated1Card23c") {

                    instantiated1Card23cList.Add(card);

                } else if (card.name == "instantiated1Card24") {

                    instantiated1Card24List.Add(card);

                } else if (card.name == "instantiated1Card24a") {

                    instantiated1Card24aList.Add(card);

                } else if (card.name == "instantiated1Card24b") {

                    instantiated1Card24bList.Add(card);

                } else if (card.name == "instantiated1Card24c") {

                    instantiated1Card24cList.Add(card);

                } else if (card.name == "instantiated1Card25") {

                    instantiated1Card25List.Add(card);

                } else if (card.name == "instantiated1Card25a") {

                    instantiated1Card25aList.Add(card);

                } else if (card.name == "instantiated1Card25b") {

                    instantiated1Card25bList.Add(card);

                } else if (card.name == "instantiated1Card25c") {

                    instantiated1Card25cList.Add(card);

                } else if (card.name == "instantiated1Card26") {

                    instantiated1Card26List.Add(card);

                } else if (card.name == "instantiated1Card26a") {

                    instantiated1Card26aList.Add(card);

                } else if (card.name == "instantiated1Card26b") {

                    instantiated1Card26bList.Add(card);

                } else if (card.name == "instantiated1Card26c") {

                    instantiated1Card26cList.Add(card);

                } else if (card.name == "instantiated1Card27") {

                    instantiated1Card27List.Add(card);

                } else if (card.name == "instantiated1Card27a") {

                    instantiated1Card27aList.Add(card);

                } else if (card.name == "instantiated1Card27b") {

                    instantiated1Card27bList.Add(card);

                } else if (card.name == "instantiated1Card27c") {

                    instantiated1Card27cList.Add(card);

                } else if (card.name == "instantiated1Card28") {

                    instantiated1Card28List.Add(card);

                } else if (card.name == "instantiated1Card28a") {

                    instantiated1Card28aList.Add(card);

                } else if (card.name == "instantiated1Card28b") {

                    instantiated1Card28bList.Add(card);

                } else if (card.name == "instantiated1Card28c") {

                    instantiated1Card28cList.Add(card);

                } else if (card.name == "instantiated1Card29") {

                    instantiated1Card29List.Add(card);

                } else if (card.name == "instantiated1Card29a") {

                    instantiated1Card29aList.Add(card);

                } else if (card.name == "instantiated1Card29b") {

                    instantiated1Card29bList.Add(card);

                } else if (card.name == "instantiated1Card29c") {

                    instantiated1Card29cList.Add(card);

                } else if (card.name == "instantiated1Card30") {

                    instantiated1Card30List.Add(card);

                } else if (card.name == "instantiated1Card30a") {

                    instantiated1Card30aList.Add(card);

                } else if (card.name == "instantiated1Card30b") {

                    instantiated1Card30bList.Add(card);

                } else if (card.name == "instantiated1Card30c") {

                    instantiated1Card30cList.Add(card);

                } else if (card.name == "instantiated1Card31") {

                    instantiated1Card31List.Add(card);

                } else if (card.name == "instantiated1Card31a") {

                    instantiated1Card31aList.Add(card);

                } else if (card.name == "instantiated1Card31b") {

                    instantiated1Card31bList.Add(card);

                } else if (card.name == "instantiated1Card31c") {

                    instantiated1Card31cList.Add(card);

                } else if (card.name == "instantiated1Card32") {

                    instantiated1Card32List.Add(card);

                } else if (card.name == "instantiated1Card32a") {

                    instantiated1Card32aList.Add(card);

                } else if (card.name == "instantiated1Card32b") {

                    instantiated1Card32bList.Add(card);

                } else if (card.name == "instantiated1Card32c") {

                    instantiated1Card32cList.Add(card);

                } else if (card.name == "instantiated1Card33") {

                    instantiated1Card33List.Add(card);

                } else if (card.name == "instantiated1Card33a") {

                    instantiated1Card33aList.Add(card);

                } else if (card.name == "instantiated1Card33b") {

                    instantiated1Card33bList.Add(card);

                } else if (card.name == "instantiated1Card33c") {

                    instantiated1Card33cList.Add(card);

                } else if (card.name == "instantiated1Card34") {

                    instantiated1Card34List.Add(card);

                } else if (card.name == "instantiated1Card34a") {

                    instantiated1Card34aList.Add(card);

                } else if (card.name == "instantiated1Card34b") {

                    instantiated1Card34bList.Add(card);

                } else if (card.name == "instantiated1Card34c") {

                    instantiated1Card34cList.Add(card);

                } else if (card.name == "instantiated1Card35") {

                    instantiated1Card35List.Add(card);

                } else if (card.name == "instantiated1Card35a") {

                    instantiated1Card35aList.Add(card);

                } else if (card.name == "instantiated1Card35b") {

                    instantiated1Card35bList.Add(card);

                } else if (card.name == "instantiated1Card35c") {

                    instantiated1Card35cList.Add(card);

                } else if (card.name == "instantiated1Card36") {

                    instantiated1Card36List.Add(card);

                } else if (card.name == "instantiated1Card36a") {

                    instantiated1Card36aList.Add(card);

                } else if (card.name == "instantiated1Card36b") {

                    instantiated1Card36bList.Add(card);

                } else if (card.name == "instantiated1Card36c") {

                    instantiated1Card36cList.Add(card);

                } else if (card.name == "instantiated1Card37") {

                    instantiated1Card37List.Add(card);

                } else if (card.name == "instantiated1Card37a") {

                    instantiated1Card37aList.Add(card);

                } else if (card.name == "instantiated1Card37b") {

                    instantiated1Card37bList.Add(card);

                } else if (card.name == "instantiated1Card37c") {

                    instantiated1Card37cList.Add(card);

                } else if (card.name == "instantiated1Card38") {

                    instantiated1Card38List.Add(card);

                } else if (card.name == "instantiated1Card38a") {

                    instantiated1Card38aList.Add(card);

                } else if (card.name == "instantiated1Card38b") {

                    instantiated1Card38bList.Add(card);

                } else if (card.name == "instantiated1Card38c") {

                    instantiated1Card38cList.Add(card);

                } else if (card.name == "instantiated1Card39") {

                    instantiated1Card39List.Add(card);

                } else if (card.name == "instantiated1Card39a") {

                    instantiated1Card39aList.Add(card);

                } else if (card.name == "instantiated1Card39b") {

                    instantiated1Card39bList.Add(card);

                } else if (card.name == "instantiated1Card39c") {

                    instantiated1Card39cList.Add(card);

                } else if (card.name == "instantiated1Card40") {

                    instantiated1Card40List.Add(card);

                } else if (card.name == "instantiated1Card40a") {

                    instantiated1Card40aList.Add(card);

                } else if (card.name == "instantiated1Card40b") {

                    instantiated1Card40bList.Add(card);

                } else if (card.name == "instantiated1Card40c") {

                    instantiated1Card40cList.Add(card);

                } else if (card.name == "instantiated1Card41") {

                    instantiated1Card41List.Add(card);

                } else if (card.name == "instantiated1Card41a") {

                    instantiated1Card41aList.Add(card);

                } else if (card.name == "instantiated1Card41b") {

                    instantiated1Card41bList.Add(card);

                } else if (card.name == "instantiated1Card41c") {

                    instantiated1Card41cList.Add(card);

                } else if (card.name == "instantiated1Card42") {

                    instantiated1Card42List.Add(card);

                } else if (card.name == "instantiated1Card42a") {

                    instantiated1Card42aList.Add(card);

                } else if (card.name == "instantiated1Card42b") {

                    instantiated1Card42bList.Add(card);

                } else if (card.name == "instantiated1Card42c") {

                    instantiated1Card42cList.Add(card);

                } else if (card.name == "instantiated1Card43") {

                    instantiated1Card43List.Add(card);

                } else if (card.name == "instantiated1Card43a") {

                    instantiated1Card43aList.Add(card);

                } else if (card.name == "instantiated1Card43b") {

                    instantiated1Card43bList.Add(card);

                } else if (card.name == "instantiated1Card43c") {

                    instantiated1Card43cList.Add(card);

                } else if (card.name == "instantiated1Card44") {

                    instantiated1Card44List.Add(card);

                } else if (card.name == "instantiated1Card44a") {

                    instantiated1Card44aList.Add(card);

                } else if (card.name == "instantiated1Card44b") {

                    instantiated1Card44bList.Add(card);

                } else if (card.name == "instantiated1Card44c") {

                    instantiated1Card44cList.Add(card);

                } else if (card.name == "instantiated1Card45") {

                    instantiated1Card45List.Add(card);

                } else if (card.name == "instantiated1Card45a") {

                    instantiated1Card45aList.Add(card);

                } else if (card.name == "instantiated1Card45b") {

                    instantiated1Card45bList.Add(card);

                } else if (card.name == "instantiated1Card45c") {

                    instantiated1Card45cList.Add(card);

                } else if (card.name == "instantiated1Card46") {

                    instantiated1Card46List.Add(card);

                } else if (card.name == "instantiated1Card46a") {

                    instantiated1Card46aList.Add(card);

                } else if (card.name == "instantiated1Card46b") {

                    instantiated1Card46bList.Add(card);

                } else if (card.name == "instantiated1Card46c") {

                    instantiated1Card46cList.Add(card);

                } else if (card.name == "instantiated1Card47") {

                    instantiated1Card47List.Add(card);

                } else if (card.name == "instantiated1Card47a") {

                    instantiated1Card47aList.Add(card);

                } else if (card.name == "instantiated1Card47b") {

                    instantiated1Card47bList.Add(card);

                } else if (card.name == "instantiated1Card47c") {

                    instantiated1Card47cList.Add(card);

                } else if (card.name == "instantiated1Card48") {

                    instantiated1Card48List.Add(card);

                } else if (card.name == "instantiated1Card48a") {

                    instantiated1Card48aList.Add(card);

                } else if (card.name == "instantiated1Card48b") {

                    instantiated1Card48bList.Add(card);

                } else if (card.name == "instantiated1Card48c") {

                    instantiated1Card48cList.Add(card);

                } else if (card.name == "instantiated1Card49") {

                    instantiated1Card49List.Add(card);

                } else if (card.name == "instantiated1Card49a") {

                    instantiated1Card49aList.Add(card);

                } else if (card.name == "instantiated1Card49b") {

                    instantiated1Card49bList.Add(card);

                } else if (card.name == "instantiated1Card49c") {

                    instantiated1Card49cList.Add(card);

                } else if (card.name == "instantiated1Card50") {

                    instantiated1Card50List.Add(card);

                } else if (card.name == "instantiated1Card50a") {

                    instantiated1Card50aList.Add(card);

                } else if (card.name == "instantiated1Card50b") {

                    instantiated1Card50bList.Add(card);

                } else if (card.name == "instantiated1Card50c") {

                    instantiated1Card50cList.Add(card);

                } else if (card.name == "instantiated1Card51") {

                    instantiated1Card51List.Add(card);

                } else if (card.name == "instantiated1Card51a") {

                    instantiated1Card51aList.Add(card);

                } else if (card.name == "instantiated1Card51b") {

                    instantiated1Card51bList.Add(card);

                } else if (card.name == "instantiated1Card51c") {

                    instantiated1Card51cList.Add(card);

                } else if (card.name == "instantiated1Card52") {

                    instantiated1Card52List.Add(card);

                } else if (card.name == "instantiated1Card52a") {

                    instantiated1Card52aList.Add(card);

                } else if (card.name == "instantiated1Card52b") {

                    instantiated1Card52bList.Add(card);

                } else if (card.name == "instantiated1Card52c") {

                    instantiated1Card52cList.Add(card);

                } else if (card.name == "instantiated1Card53") {

                    instantiated1Card53List.Add(card);

                } else if (card.name == "instantiated1Card53a") {

                    instantiated1Card53aList.Add(card);

                } else if (card.name == "instantiated1Card53b") {

                    instantiated1Card53bList.Add(card);

                } else if (card.name == "instantiated1Card53c") {

                    instantiated1Card53cList.Add(card);

                } else if (card.name == "instantiated1Card54") {

                    instantiated1Card54List.Add(card);

                } else if (card.name == "instantiated1Card54a") {

                    instantiated1Card54aList.Add(card);

                } else if (card.name == "instantiated1Card54b") {

                    instantiated1Card54bList.Add(card);

                } else if (card.name == "instantiated1Card54c") {

                    instantiated1Card54cList.Add(card);

                } else if (card.name == "instantiated1Card55") {

                    instantiated1Card55List.Add(card);

                } else if (card.name == "instantiated1Card55a") {

                    instantiated1Card55aList.Add(card);

                } else if (card.name == "instantiated1Card55b") {

                    instantiated1Card55bList.Add(card);

                } else if (card.name == "instantiated1Card55c") {

                    instantiated1Card55cList.Add(card);

                } else if (card.name == "instantiated1Card56") {

                    instantiated1Card56List.Add(card);

                } else if (card.name == "instantiated1Card56a") {

                    instantiated1Card56aList.Add(card);

                } else if (card.name == "instantiated1Card56b") {

                    instantiated1Card56bList.Add(card);

                } else if (card.name == "instantiated1Card56c") {

                    instantiated1Card56cList.Add(card);

                } else if (card.name == "instantiated1Card57") {

                    instantiated1Card57List.Add(card);

                } else if (card.name == "instantiated1Card57a") {

                    instantiated1Card57aList.Add(card);

                } else if (card.name == "instantiated1Card57b") {

                    instantiated1Card57bList.Add(card);

                } else if (card.name == "instantiated1Card57c") {

                    instantiated1Card57cList.Add(card);

                } else if (card.name == "instantiated1Card58") {

                    instantiated1Card58List.Add(card);

                } else if (card.name == "instantiated1Card58a") {

                    instantiated1Card58aList.Add(card);

                } else if (card.name == "instantiated1Card58b") {

                    instantiated1Card58bList.Add(card);

                } else if (card.name == "instantiated1Card58c") {

                    instantiated1Card58cList.Add(card);

                } else if (card.name == "instantiated1Card59") {

                    instantiated1Card59List.Add(card);

                } else if (card.name == "instantiated1Card59a") {

                    instantiated1Card59aList.Add(card);

                } else if (card.name == "instantiated1Card59b") {

                    instantiated1Card59bList.Add(card);

                } else if (card.name == "instantiated1Card59c") {

                    instantiated1Card59cList.Add(card);

                } else if (card.name == "instantiated1Card60") {

                    instantiated1Card60List.Add(card);

                } else if (card.name == "instantiated1Card60a") {

                    instantiated1Card60aList.Add(card);

                } else if (card.name == "instantiated1Card60b") {

                    instantiated1Card60bList.Add(card);

                } else if (card.name == "instantiated1Card60c") {

                    instantiated1Card60cList.Add(card);

                }


            }
            CardCounterManager.counter1 += instantiated1Card1List.Count;
            CardCounterManager.CardCounter1();

            CardCounterManager.counter1a += instantiated1Card1aList.Count;
            CardCounterManager.CardCounter1a();

            CardCounterManager.counter1b += instantiated1Card1bList.Count;
            CardCounterManager.CardCounter1b();

            CardCounterManager.counter1c += instantiated1Card1cList.Count;
            CardCounterManager.CardCounter1c();

            CardCounterManager.counter2 += instantiated1Card2List.Count;
            CardCounterManager.CardCounter2();

            CardCounterManager.counter2a += instantiated1Card2aList.Count;
            CardCounterManager.CardCounter2a();

            CardCounterManager.counter2b += instantiated1Card2bList.Count;
            CardCounterManager.CardCounter2b();

            CardCounterManager.counter2c += instantiated1Card2cList.Count;
            CardCounterManager.CardCounter2c();

            CardCounterManager.counter3 += instantiated1Card3List.Count;
            CardCounterManager.CardCounter3();

            CardCounterManager.counter3a += instantiated1Card3aList.Count;
            CardCounterManager.CardCounter3a();

            CardCounterManager.counter3b += instantiated1Card3bList.Count;
            CardCounterManager.CardCounter3b();

            CardCounterManager.counter3c += instantiated1Card3cList.Count;
            CardCounterManager.CardCounter3c();

            CardCounterManager.counter4 += instantiated1Card4List.Count;
            CardCounterManager.CardCounter4();

            CardCounterManager.counter4a += instantiated1Card4aList.Count;
            CardCounterManager.CardCounter4a();

            CardCounterManager.counter4b += instantiated1Card4bList.Count;
            CardCounterManager.CardCounter4b();

            CardCounterManager.counter4c += instantiated1Card4cList.Count;
            CardCounterManager.CardCounter4c();

            CardCounterManager.counter5 += instantiated1Card5List.Count;
            CardCounterManager.CardCounter5();

            CardCounterManager.counter5a += instantiated1Card5aList.Count;
            CardCounterManager.CardCounter5a();

            CardCounterManager.counter5b += instantiated1Card5bList.Count;
            CardCounterManager.CardCounter5b();

            CardCounterManager.counter5c += instantiated1Card5cList.Count;
            CardCounterManager.CardCounter5c();

            CardCounterManager.counter6 += instantiated1Card6List.Count;
            CardCounterManager.CardCounter6();

            CardCounterManager.counter6a += instantiated1Card6aList.Count;
            CardCounterManager.CardCounter6a();

            CardCounterManager.counter6b += instantiated1Card6bList.Count;
            CardCounterManager.CardCounter6b();

            CardCounterManager.counter6c += instantiated1Card6cList.Count;
            CardCounterManager.CardCounter6c();

            CardCounterManager.counter7 += instantiated1Card7List.Count;
            CardCounterManager.CardCounter7();

            CardCounterManager.counter7a += instantiated1Card7aList.Count;
            CardCounterManager.CardCounter7a();

            CardCounterManager.counter7b += instantiated1Card7bList.Count;
            CardCounterManager.CardCounter7b();

            CardCounterManager.counter7c += instantiated1Card7cList.Count;
            CardCounterManager.CardCounter7c();

            CardCounterManager.counter8 += instantiated1Card8List.Count;
            CardCounterManager.CardCounter8();

            CardCounterManager.counter8a += instantiated1Card8aList.Count;
            CardCounterManager.CardCounter8a();

            CardCounterManager.counter8b += instantiated1Card8bList.Count;
            CardCounterManager.CardCounter8b();

            CardCounterManager.counter8c += instantiated1Card8cList.Count;
            CardCounterManager.CardCounter8c();

            CardCounterManager.counter9 += instantiated1Card9List.Count;
            CardCounterManager.CardCounter9();

            CardCounterManager.counter9a += instantiated1Card9aList.Count;
            CardCounterManager.CardCounter9a();

            CardCounterManager.counter9b += instantiated1Card9bList.Count;
            CardCounterManager.CardCounter9b();

            CardCounterManager.counter9c += instantiated1Card9cList.Count;
            CardCounterManager.CardCounter9c();

            CardCounterManager.counter10 += instantiated1Card10List.Count;
            CardCounterManager.CardCounter10();

            CardCounterManager.counter10a += instantiated1Card10aList.Count;
            CardCounterManager.CardCounter10a();

            CardCounterManager.counter10b += instantiated1Card10bList.Count;
            CardCounterManager.CardCounter10b();

            CardCounterManager.counter10c += instantiated1Card10cList.Count;
            CardCounterManager.CardCounter10c();

            CardCounterManager.counter11 += instantiated1Card11List.Count;
            CardCounterManager.CardCounter11();

            CardCounterManager.counter11a += instantiated1Card11aList.Count;
            CardCounterManager.CardCounter11a();

            CardCounterManager.counter11b += instantiated1Card11bList.Count;
            CardCounterManager.CardCounter11b();

            CardCounterManager.counter11c += instantiated1Card11cList.Count;
            CardCounterManager.CardCounter11c();

            CardCounterManager.counter12 += instantiated1Card12List.Count;
            CardCounterManager.CardCounter12();

            CardCounterManager.counter12a += instantiated1Card12aList.Count;
            CardCounterManager.CardCounter12a();

            CardCounterManager.counter12b += instantiated1Card12bList.Count;
            CardCounterManager.CardCounter12b();

            CardCounterManager.counter12c += instantiated1Card12cList.Count;
            CardCounterManager.CardCounter12c();

            CardCounterManager.counter13 += instantiated1Card13List.Count;
            CardCounterManager.CardCounter13();

            CardCounterManager.counter13a += instantiated1Card13aList.Count;
            CardCounterManager.CardCounter13a();

            CardCounterManager.counter13b += instantiated1Card13bList.Count;
            CardCounterManager.CardCounter13b();

            CardCounterManager.counter13c += instantiated1Card13cList.Count;
            CardCounterManager.CardCounter13c();

            CardCounterManager.counter14 += instantiated1Card14List.Count;
            CardCounterManager.CardCounter14();

            CardCounterManager.counter14a += instantiated1Card14aList.Count;
            CardCounterManager.CardCounter14a();

            CardCounterManager.counter14b += instantiated1Card14bList.Count;
            CardCounterManager.CardCounter14b();

            CardCounterManager.counter14c += instantiated1Card14cList.Count;
            CardCounterManager.CardCounter14c();

            CardCounterManager.counter15 += instantiated1Card15List.Count;
            CardCounterManager.CardCounter15();

            CardCounterManager.counter15a += instantiated1Card15aList.Count;
            CardCounterManager.CardCounter15a();

            CardCounterManager.counter15b += instantiated1Card15bList.Count;
            CardCounterManager.CardCounter15b();

            CardCounterManager.counter15c += instantiated1Card15cList.Count;
            CardCounterManager.CardCounter15c();

            CardCounterManager.counter16 += instantiated1Card16List.Count;
            CardCounterManager.CardCounter16();

            CardCounterManager.counter16a += instantiated1Card16aList.Count;
            CardCounterManager.CardCounter16a();

            CardCounterManager.counter16b += instantiated1Card16bList.Count;
            CardCounterManager.CardCounter16b();

            CardCounterManager.counter16c += instantiated1Card16cList.Count;
            CardCounterManager.CardCounter16c();

            CardCounterManager.counter17 += instantiated1Card17List.Count;
            CardCounterManager.CardCounter17();

            CardCounterManager.counter17a += instantiated1Card17aList.Count;
            CardCounterManager.CardCounter17a();

            CardCounterManager.counter17b += instantiated1Card17bList.Count;
            CardCounterManager.CardCounter17b();

            CardCounterManager.counter17c += instantiated1Card17cList.Count;
            CardCounterManager.CardCounter17c();

            CardCounterManager.counter18 += instantiated1Card18List.Count;
            CardCounterManager.CardCounter18();

            CardCounterManager.counter18a += instantiated1Card18aList.Count;
            CardCounterManager.CardCounter18a();

            CardCounterManager.counter18b += instantiated1Card18bList.Count;
            CardCounterManager.CardCounter18b();

            CardCounterManager.counter18c += instantiated1Card18cList.Count;
            CardCounterManager.CardCounter18c();

            CardCounterManager.counter19 += instantiated1Card19List.Count;
            CardCounterManager.CardCounter19();

            CardCounterManager.counter19a += instantiated1Card19aList.Count;
            CardCounterManager.CardCounter19a();

            CardCounterManager.counter19b += instantiated1Card19bList.Count;
            CardCounterManager.CardCounter19b();

            CardCounterManager.counter19c += instantiated1Card19cList.Count;
            CardCounterManager.CardCounter19c();

            CardCounterManager.counter20 += instantiated1Card20List.Count;
            CardCounterManager.CardCounter20();

            CardCounterManager.counter20a += instantiated1Card20aList.Count;
            CardCounterManager.CardCounter20a();

            CardCounterManager.counter20b += instantiated1Card20bList.Count;
            CardCounterManager.CardCounter20b();

            CardCounterManager.counter20c += instantiated1Card20cList.Count;
            CardCounterManager.CardCounter20c();

            CardCounterManager.counter21 += instantiated1Card21List.Count;
            CardCounterManager.CardCounter21();

            CardCounterManager.counter21a += instantiated1Card21aList.Count;
            CardCounterManager.CardCounter21a();

            CardCounterManager.counter21b += instantiated1Card21bList.Count;
            CardCounterManager.CardCounter21b();

            CardCounterManager.counter21c += instantiated1Card21cList.Count;
            CardCounterManager.CardCounter21c();

            CardCounterManager.counter22 += instantiated1Card22List.Count;
            CardCounterManager.CardCounter22();

            CardCounterManager.counter22a += instantiated1Card22aList.Count;
            CardCounterManager.CardCounter22a();

            CardCounterManager.counter22b += instantiated1Card22bList.Count;
            CardCounterManager.CardCounter22b();

            CardCounterManager.counter22c += instantiated1Card22cList.Count;
            CardCounterManager.CardCounter22c();

            CardCounterManager.counter23 += instantiated1Card23List.Count;
            CardCounterManager.CardCounter23();

            CardCounterManager.counter23a += instantiated1Card23aList.Count;
            CardCounterManager.CardCounter23a();

            CardCounterManager.counter23b += instantiated1Card23bList.Count;
            CardCounterManager.CardCounter23b();

            CardCounterManager.counter23c += instantiated1Card23cList.Count;
            CardCounterManager.CardCounter23c();

            CardCounterManager.counter24 += instantiated1Card24List.Count;
            CardCounterManager.CardCounter24();

            CardCounterManager.counter24a += instantiated1Card24aList.Count;
            CardCounterManager.CardCounter24a();

            CardCounterManager.counter24b += instantiated1Card24bList.Count;
            CardCounterManager.CardCounter24b();

            CardCounterManager.counter24c += instantiated1Card24cList.Count;
            CardCounterManager.CardCounter24c();

            CardCounterManager.counter25 += instantiated1Card25List.Count;
            CardCounterManager.CardCounter25();

            CardCounterManager.counter25a += instantiated1Card25aList.Count;
            CardCounterManager.CardCounter25a();

            CardCounterManager.counter25b += instantiated1Card25bList.Count;
            CardCounterManager.CardCounter25b();

            CardCounterManager.counter25c += instantiated1Card25cList.Count;
            CardCounterManager.CardCounter25c();

            CardCounterManager.counter26 += instantiated1Card26List.Count;
            CardCounterManager.CardCounter26();

            CardCounterManager.counter26a += instantiated1Card26aList.Count;
            CardCounterManager.CardCounter26a();

            CardCounterManager.counter26b += instantiated1Card26bList.Count;
            CardCounterManager.CardCounter26b();

            CardCounterManager.counter26c += instantiated1Card26cList.Count;
            CardCounterManager.CardCounter26c();

            CardCounterManager.counter27 += instantiated1Card27List.Count;
            CardCounterManager.CardCounter27();

            CardCounterManager.counter27a += instantiated1Card27aList.Count;
            CardCounterManager.CardCounter27a();

            CardCounterManager.counter27b += instantiated1Card27bList.Count;
            CardCounterManager.CardCounter27b();

            CardCounterManager.counter27c += instantiated1Card27cList.Count;
            CardCounterManager.CardCounter27c();

            CardCounterManager.counter28 += instantiated1Card28List.Count;
            CardCounterManager.CardCounter28();

            CardCounterManager.counter28a += instantiated1Card28aList.Count;
            CardCounterManager.CardCounter28a();

            CardCounterManager.counter28b += instantiated1Card28bList.Count;
            CardCounterManager.CardCounter28b();

            CardCounterManager.counter28c += instantiated1Card28cList.Count;
            CardCounterManager.CardCounter28c();

            CardCounterManager.counter29 += instantiated1Card29List.Count;
            CardCounterManager.CardCounter29();

            CardCounterManager.counter29a += instantiated1Card29aList.Count;
            CardCounterManager.CardCounter29a();

            CardCounterManager.counter29b += instantiated1Card29bList.Count;
            CardCounterManager.CardCounter29b();

            CardCounterManager.counter29c += instantiated1Card29cList.Count;
            CardCounterManager.CardCounter29c();

            CardCounterManager.counter30 += instantiated1Card30List.Count;
            CardCounterManager.CardCounter30();

            CardCounterManager.counter30a += instantiated1Card30aList.Count;
            CardCounterManager.CardCounter30a();

            CardCounterManager.counter30b += instantiated1Card30bList.Count;
            CardCounterManager.CardCounter30b();

            CardCounterManager.counter30c += instantiated1Card30cList.Count;
            CardCounterManager.CardCounter30c();

            CardCounterManager.counter31 += instantiated1Card31List.Count;
            CardCounterManager.CardCounter31();

            CardCounterManager.counter31a += instantiated1Card31aList.Count;
            CardCounterManager.CardCounter31a();

            CardCounterManager.counter31b += instantiated1Card31bList.Count;
            CardCounterManager.CardCounter31b();

            CardCounterManager.counter31c += instantiated1Card31cList.Count;
            CardCounterManager.CardCounter31c();

            CardCounterManager.counter32 += instantiated1Card32List.Count;
            CardCounterManager.CardCounter32();

            CardCounterManager.counter32a += instantiated1Card32aList.Count;
            CardCounterManager.CardCounter32a();

            CardCounterManager.counter32b += instantiated1Card32bList.Count;
            CardCounterManager.CardCounter32b();

            CardCounterManager.counter32c += instantiated1Card32cList.Count;
            CardCounterManager.CardCounter32c();

            CardCounterManager.counter33 += instantiated1Card33List.Count;
            CardCounterManager.CardCounter33();

            CardCounterManager.counter33a += instantiated1Card33aList.Count;
            CardCounterManager.CardCounter33a();

            CardCounterManager.counter33b += instantiated1Card33bList.Count;
            CardCounterManager.CardCounter33b();

            CardCounterManager.counter33c += instantiated1Card33cList.Count;
            CardCounterManager.CardCounter33c();

            CardCounterManager.counter34 += instantiated1Card34List.Count;
            CardCounterManager.CardCounter34();

            CardCounterManager.counter34a += instantiated1Card34aList.Count;
            CardCounterManager.CardCounter34a();

            CardCounterManager.counter34b += instantiated1Card34bList.Count;
            CardCounterManager.CardCounter34b();

            CardCounterManager.counter34c += instantiated1Card34cList.Count;
            CardCounterManager.CardCounter34c();

            CardCounterManager.counter35 += instantiated1Card35List.Count;
            CardCounterManager.CardCounter35();

            CardCounterManager.counter35a += instantiated1Card35aList.Count;
            CardCounterManager.CardCounter35a();

            CardCounterManager.counter35b += instantiated1Card35bList.Count;
            CardCounterManager.CardCounter35b();

            CardCounterManager.counter35c += instantiated1Card35cList.Count;
            CardCounterManager.CardCounter35c();

            CardCounterManager.counter36 += instantiated1Card36List.Count;
            CardCounterManager.CardCounter36();

            CardCounterManager.counter36a += instantiated1Card36aList.Count;
            CardCounterManager.CardCounter36a();

            CardCounterManager.counter36b += instantiated1Card36bList.Count;
            CardCounterManager.CardCounter36b();

            CardCounterManager.counter36c += instantiated1Card36cList.Count;
            CardCounterManager.CardCounter36c();

            CardCounterManager.counter37 += instantiated1Card37List.Count;
            CardCounterManager.CardCounter37();

            CardCounterManager.counter37a += instantiated1Card37aList.Count;
            CardCounterManager.CardCounter37a();

            CardCounterManager.counter37b += instantiated1Card37bList.Count;
            CardCounterManager.CardCounter37b();

            CardCounterManager.counter37c += instantiated1Card37cList.Count;
            CardCounterManager.CardCounter37c();

            CardCounterManager.counter38 += instantiated1Card38List.Count;
            CardCounterManager.CardCounter38();

            CardCounterManager.counter38a += instantiated1Card38aList.Count;
            CardCounterManager.CardCounter38a();

            CardCounterManager.counter38b += instantiated1Card38bList.Count;
            CardCounterManager.CardCounter38b();

            CardCounterManager.counter38c += instantiated1Card38cList.Count;
            CardCounterManager.CardCounter38c();

            CardCounterManager.counter39 += instantiated1Card39List.Count;
            CardCounterManager.CardCounter39();

            CardCounterManager.counter39a += instantiated1Card39aList.Count;
            CardCounterManager.CardCounter39a();

            CardCounterManager.counter39b += instantiated1Card39bList.Count;
            CardCounterManager.CardCounter39b();

            CardCounterManager.counter39c += instantiated1Card39cList.Count;
            CardCounterManager.CardCounter39c();

            CardCounterManager.counter40 += instantiated1Card40List.Count;
            CardCounterManager.CardCounter40();

            CardCounterManager.counter40a += instantiated1Card40aList.Count;
            CardCounterManager.CardCounter40a();

            CardCounterManager.counter40b += instantiated1Card40bList.Count;
            CardCounterManager.CardCounter40b();

            CardCounterManager.counter40c += instantiated1Card40cList.Count;
            CardCounterManager.CardCounter40c();

            CardCounterManager.counter41 += instantiated1Card41List.Count;
            CardCounterManager.CardCounter41();

            CardCounterManager.counter41a += instantiated1Card41aList.Count;
            CardCounterManager.CardCounter41a();

            CardCounterManager.counter41b += instantiated1Card41bList.Count;
            CardCounterManager.CardCounter41b();

            CardCounterManager.counter41c += instantiated1Card41cList.Count;
            CardCounterManager.CardCounter41c();

            CardCounterManager.counter42 += instantiated1Card42List.Count;
            CardCounterManager.CardCounter42();

            CardCounterManager.counter42a += instantiated1Card42aList.Count;
            CardCounterManager.CardCounter42a();

            CardCounterManager.counter42b += instantiated1Card42bList.Count;
            CardCounterManager.CardCounter42b();

            CardCounterManager.counter42c += instantiated1Card42cList.Count;
            CardCounterManager.CardCounter42c();

            CardCounterManager.counter43 += instantiated1Card43List.Count;
            CardCounterManager.CardCounter43();

            CardCounterManager.counter43a += instantiated1Card43aList.Count;
            CardCounterManager.CardCounter43a();

            CardCounterManager.counter43b += instantiated1Card43bList.Count;
            CardCounterManager.CardCounter43b();

            CardCounterManager.counter43c += instantiated1Card43cList.Count;
            CardCounterManager.CardCounter43c();

            CardCounterManager.counter44 += instantiated1Card44List.Count;
            CardCounterManager.CardCounter44();

            CardCounterManager.counter44a += instantiated1Card44aList.Count;
            CardCounterManager.CardCounter44a();

            CardCounterManager.counter44b += instantiated1Card44bList.Count;
            CardCounterManager.CardCounter44b();

            CardCounterManager.counter44c += instantiated1Card44cList.Count;
            CardCounterManager.CardCounter44c();

            CardCounterManager.counter45 += instantiated1Card45List.Count;
            CardCounterManager.CardCounter45();

            CardCounterManager.counter45a += instantiated1Card45aList.Count;
            CardCounterManager.CardCounter45a();

            CardCounterManager.counter45b += instantiated1Card45bList.Count;
            CardCounterManager.CardCounter45b();

            CardCounterManager.counter45c += instantiated1Card45cList.Count;
            CardCounterManager.CardCounter45c();

            CardCounterManager.counter46 += instantiated1Card46List.Count;
            CardCounterManager.CardCounter46();

            CardCounterManager.counter46a += instantiated1Card46aList.Count;
            CardCounterManager.CardCounter46a();

            CardCounterManager.counter46b += instantiated1Card46bList.Count;
            CardCounterManager.CardCounter46b();

            CardCounterManager.counter46c += instantiated1Card46cList.Count;
            CardCounterManager.CardCounter46c();

            CardCounterManager.counter47 += instantiated1Card47List.Count;
            CardCounterManager.CardCounter47();

            CardCounterManager.counter47a += instantiated1Card47aList.Count;
            CardCounterManager.CardCounter47a();

            CardCounterManager.counter47b += instantiated1Card47bList.Count;
            CardCounterManager.CardCounter47b();

            CardCounterManager.counter47c += instantiated1Card47cList.Count;
            CardCounterManager.CardCounter47c();

            CardCounterManager.counter48 += instantiated1Card48List.Count;
            CardCounterManager.CardCounter48();

            CardCounterManager.counter48a += instantiated1Card48aList.Count;
            CardCounterManager.CardCounter48a();

            CardCounterManager.counter48b += instantiated1Card48bList.Count;
            CardCounterManager.CardCounter48b();

            CardCounterManager.counter48c += instantiated1Card48cList.Count;
            CardCounterManager.CardCounter48c();

            CardCounterManager.counter49 += instantiated1Card49List.Count;
            CardCounterManager.CardCounter49();

            CardCounterManager.counter49a += instantiated1Card49aList.Count;
            CardCounterManager.CardCounter49a();

            CardCounterManager.counter49b += instantiated1Card49bList.Count;
            CardCounterManager.CardCounter49b();

            CardCounterManager.counter49c += instantiated1Card49cList.Count;
            CardCounterManager.CardCounter49c();

            CardCounterManager.counter50 += instantiated1Card50List.Count;
            CardCounterManager.CardCounter50();

            CardCounterManager.counter50a += instantiated1Card50aList.Count;
            CardCounterManager.CardCounter50a();

            CardCounterManager.counter50b += instantiated1Card50bList.Count;
            CardCounterManager.CardCounter50b();

            CardCounterManager.counter50c += instantiated1Card50cList.Count;
            CardCounterManager.CardCounter50c();

            CardCounterManager.counter51 += instantiated1Card51List.Count;
            CardCounterManager.CardCounter51();

            CardCounterManager.counter51a += instantiated1Card51aList.Count;
            CardCounterManager.CardCounter51a();

            CardCounterManager.counter51b += instantiated1Card51bList.Count;
            CardCounterManager.CardCounter51b();

            CardCounterManager.counter51c += instantiated1Card51cList.Count;
            CardCounterManager.CardCounter51c();

            CardCounterManager.counter52 += instantiated1Card52List.Count;
            CardCounterManager.CardCounter52();

            CardCounterManager.counter52a += instantiated1Card52aList.Count;
            CardCounterManager.CardCounter52a();

            CardCounterManager.counter52b += instantiated1Card52bList.Count;
            CardCounterManager.CardCounter52b();

            CardCounterManager.counter52c += instantiated1Card52cList.Count;
            CardCounterManager.CardCounter52c();

            CardCounterManager.counter53 += instantiated1Card53List.Count;
            CardCounterManager.CardCounter53();

            CardCounterManager.counter53a += instantiated1Card53aList.Count;
            CardCounterManager.CardCounter53a();

            CardCounterManager.counter53b += instantiated1Card53bList.Count;
            CardCounterManager.CardCounter53b();

            CardCounterManager.counter53c += instantiated1Card53cList.Count;
            CardCounterManager.CardCounter53c();

            CardCounterManager.counter54 += instantiated1Card54List.Count;
            CardCounterManager.CardCounter54();

            CardCounterManager.counter54a += instantiated1Card54aList.Count;
            CardCounterManager.CardCounter54a();

            CardCounterManager.counter54b += instantiated1Card54bList.Count;
            CardCounterManager.CardCounter54b();

            CardCounterManager.counter54c += instantiated1Card54cList.Count;
            CardCounterManager.CardCounter54c();

            CardCounterManager.counter55 += instantiated1Card55List.Count;
            CardCounterManager.CardCounter55();

            CardCounterManager.counter55a += instantiated1Card55aList.Count;
            CardCounterManager.CardCounter55a();

            CardCounterManager.counter55b += instantiated1Card55bList.Count;
            CardCounterManager.CardCounter55b();

            CardCounterManager.counter55c += instantiated1Card55cList.Count;
            CardCounterManager.CardCounter55c();

            CardCounterManager.counter56 += instantiated1Card56List.Count;
            CardCounterManager.CardCounter56();

            CardCounterManager.counter56a += instantiated1Card56aList.Count;
            CardCounterManager.CardCounter56a();

            CardCounterManager.counter56b += instantiated1Card56bList.Count;
            CardCounterManager.CardCounter56b();

            CardCounterManager.counter56c += instantiated1Card56cList.Count;
            CardCounterManager.CardCounter56c();

            CardCounterManager.counter57 += instantiated1Card57List.Count;
            CardCounterManager.CardCounter57();

            CardCounterManager.counter57a += instantiated1Card57aList.Count;
            CardCounterManager.CardCounter57a();

            CardCounterManager.counter57b += instantiated1Card57bList.Count;
            CardCounterManager.CardCounter57b();

            CardCounterManager.counter57c += instantiated1Card57cList.Count;
            CardCounterManager.CardCounter57c();

            CardCounterManager.counter58 += instantiated1Card58List.Count;
            CardCounterManager.CardCounter58();

            CardCounterManager.counter58a += instantiated1Card58aList.Count;
            CardCounterManager.CardCounter58a();

            CardCounterManager.counter58b += instantiated1Card58bList.Count;
            CardCounterManager.CardCounter58b();

            CardCounterManager.counter58c += instantiated1Card58cList.Count;
            CardCounterManager.CardCounter58c();

            CardCounterManager.counter59 += instantiated1Card59List.Count;
            CardCounterManager.CardCounter59();

            CardCounterManager.counter59a += instantiated1Card59aList.Count;
            CardCounterManager.CardCounter59a();

            CardCounterManager.counter59b += instantiated1Card59bList.Count;
            CardCounterManager.CardCounter59b();

            CardCounterManager.counter59c += instantiated1Card59cList.Count;
            CardCounterManager.CardCounter59c();

            CardCounterManager.counter60 += instantiated1Card60List.Count;
            CardCounterManager.CardCounter60();

            CardCounterManager.counter60a += instantiated1Card60aList.Count;
            CardCounterManager.CardCounter60a();

            CardCounterManager.counter60b += instantiated1Card60bList.Count;
            CardCounterManager.CardCounter60b();

            CardCounterManager.counter60c += instantiated1Card60cList.Count;
            CardCounterManager.CardCounter60c();


            #endregion





        }


        /** Save the deck - the created or modified deck is svaed to the binary file*/
        public void Save() {

            //Check if there are no empty Deck Builder panel slots
            deckNamelabel.GetComponent<Text>().text = "";

            foreach (GameObject slot in DeckManager.deckManager.spawnPoints1) {
                if (slot.transform.childCount == 0) { //if so...
                                                      //Show the warning and leave the whole Save() function
                    StartCoroutine("ShowWarningCardsText");
                    return;
                }
            }

            //Check if a name of the deck has been entered
            if (deck1NameInputField.GetComponent<Text>().text != "") { //if so...
                                                                       //Save the name and go further
                deckName1 = deck1NameInputField.GetComponent<Text>().text;
                inputFieldSwitcher1.SetActive(false);
                warningNameText.SetActive(false);
            } else {
                //Show the warning and leave the whole Save() function
                StartCoroutine("ShowWarningNameText");
                return;
            }

            isDeck1Editing = false;
            SaveCardDeck2.saveCardDeck2.isDeck2Editing = true;

            if (deck1NameButton.GetComponent<Text>().text == "") {
                deck1NameButton.GetComponent<Text>().text = "Deck 1";
            } else {
                deck1NameButton.GetComponent<Text>().text = deckName1;
            }

            //Clearing all lists
            cardsDeck1.Clear();
            cardsDeck1.RemoveAll(item => item == null);

            editDeck1.Clear();
            editDeck1.RemoveAll(item => item == null);

            //Get all card references
            allObjects = GameObject.FindObjectsOfType(typeof(GameObject)) as GameObject[];
            foreach (GameObject obj in allObjects) {
                if (obj.name.Contains("instantiated1Card")) {

                    cardsDeck1.Add(obj.name);
                    obj.transform.localPosition = new Vector3(0.0f, -20.0f, 0.0f);
                }
            }

            //Get all cards	
            allObjects1 = GameObject.FindObjectsOfType(typeof(GameObject)) as GameObject[];
            foreach (GameObject obj in allObjects1) {
                if (obj.name.Contains("instantiated1Card")) {

                    editDeck1.Add(obj);
                }
            }

            //Check if the deck has cards or not
            if (cardsDeck1.Count >= 0) {
                create1Button.GetComponent<Button>().interactable = false;
                edit1Button.GetComponent<Button>().interactable = true;
            } else {
                create1Button.GetComponent<Button>().interactable = true;
                edit1Button.GetComponent<Button>().interactable = false;
            }

            //Delete the previous binary file
            if (File.Exists(Path.Combine(Application.persistentDataPath, BINARY_FILE1))) {

                File.Delete(Path.Combine(Application.persistentDataPath, BINARY_FILE1));

            }

            //Save the data to the binary file	

            BinaryFormatter bf = new BinaryFormatter();

            FileStream file = File.Create(Path.Combine(Application.persistentDataPath, BINARY_FILE1));
            DataToSave1 data = new DataToSave1();
            data.cardsDeck1 = cardsDeck1;
            data.deckName1 = deckName1;
            bf.Serialize(file, data);
            file.Close();

            cardsDeck1.Clear();
            editDeck1.RemoveAll(item => item == null);
            editDeck1.Clear();
            cardsDeck1.RemoveAll(item => item == null);

            //Show info that the data has been saved
            StartCoroutine("ShowDeckSavedText");

        }

        /** Delete the deck - the deck is deleted and all stuff regarding the deck is cleaned */
        public void Delete() {

            if (deck1NameButton.GetComponent<Text>().text == "") {
                deck1NameButton.GetComponent<Text>().text = "Deck 1";
            } else {
                deck1NameButton.GetComponent<Text>().text = deckName1;
            }

            //coroutine to have enough time for clearing
            StartCoroutine("RemoveDeck1Stuff");
            //GetCardCounterInDeck1();
        }

        /** Clear the deck stuff */
        IEnumerator RemoveDeck1Stuff() {

            yield return new WaitForSeconds(1);



            create1Button.GetComponent<Button>().interactable = true;
            save1Button.GetComponent<Button>().interactable = false;
            edit1Button.GetComponent<Button>().interactable = false;

            if (File.Exists(Path.Combine(Application.persistentDataPath, BINARY_FILE1))) {

                File.Delete(Path.Combine(Application.persistentDataPath, BINARY_FILE1));

            }

            editDeck1.Clear();
            cardsDeck1.Clear();
            editDeck1.RemoveAll(item => item == null);
            cardsDeck1.RemoveAll(item => item == null);



            allObjects1 = GameObject.FindObjectsOfType(typeof(GameObject)) as GameObject[];
            foreach (GameObject obj in allObjects1) {
                if (obj.name.Contains("instantiated1Card")) {

                    editDeck1.Add(obj);
                    editDeck1.Clear();
                    GameObject.Destroy(obj);
                }
            }

            allObjects = GameObject.FindObjectsOfType(typeof(GameObject)) as GameObject[];
            foreach (GameObject obj in allObjects) {
                if (obj.name.Contains("instantiated1Card")) {

                    cardsDeck1.Add(obj.name);
                    cardsDeck1.Clear();
                    GameObject.Destroy(obj);
                }
            }

            StartCoroutine(CheckCardModelScaleAtDelete());
            delete1Button.GetComponent<Button>().interactable = false;
        }

        /** Show the info that the deck has been saved */
        IEnumerator ShowDeckSavedText() {
            deckSavedText.SetActive(true);
            yield return new WaitForSeconds(2);
            deckSavedText.SetActive(false);
        }

        /** Show the info that no name of the deck entered */
        IEnumerator ShowWarningNameText() {
            warningNameText.SetActive(true);
            yield return new WaitForSeconds(2);
            warningNameText.SetActive(false);
        }

        /** Show the info that not all cards has been chosen */
        IEnumerator ShowWarningCardsText() {
            warningCardsText.SetActive(true);
            yield return new WaitForSeconds(2);
            warningCardsText.SetActive(false);
        }


        IEnumerator CheckCardModelScaleAtDelete() {

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject1.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel1.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel1.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel1.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel1.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel1.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel1.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject1a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel1a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel1a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel1a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel1a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel1a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel1a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject1b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel1b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel1b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel1b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel1b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel1b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel1b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject1c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel1c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel1c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel1c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel1c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel1c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel1c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject2.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel2.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel2.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel2.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel2.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel2.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel2.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject2a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel2a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel2a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel2a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel2a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel2a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel2a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject2b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel2b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel2b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel2b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel2b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel2b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel2b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject2c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel2c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel2c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel2c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel2c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel2c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel2c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject3.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel3.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel3.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel3.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel3.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel3.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel3.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject3a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel3a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel3a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel3a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel3a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel3a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel3a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject3b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel3b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel3b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel3b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel3b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel3b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel3b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject3c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel3c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel3c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel3c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel3c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel3c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel3c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject4.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel4.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel4.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel4.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel4.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel4.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel4.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject4a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel4a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel4a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel4a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel4a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel4a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel4a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject4b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel4b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel4b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel4b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel4b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel4b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel4b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject4c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel4c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel4c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel4c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel4c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel4c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel4c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject5.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel5.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel5.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel5.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel5.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel5.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel5.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject5a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel5a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel5a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel5a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel5a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel5a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel5a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject5b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel5b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel5b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel5b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel5b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel5b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel5b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject5c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel5c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel5c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel5c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel5c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel5c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel5c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject6.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel6.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel6.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel6.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel6.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel6.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel6.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject6a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel6a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel6a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel6a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel6a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel6a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel6a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject6b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel6b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel6b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel6b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel6b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel6b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel6b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject6c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel6c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel6c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel6c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel6c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel6c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel6c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject7.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel7.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel7.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel7.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel7.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel7.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel7.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject7a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel7a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel7a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel7a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel7a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel7a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel7a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject7b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel7b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel7b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel7b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel7b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel7b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel7b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject7c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel7c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel7c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel7c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel7c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel7c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel7c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject8.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel8.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel8.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel8.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel8.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel8.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel8.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject8a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel8a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel8a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel8a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel8a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel8a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel8a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject8b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel8b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel8b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel8b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel8b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel8b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel8b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject8c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel8c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel8c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel8c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel8c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel8c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel8c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject9.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel9.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel9.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel9.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel9.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel9.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel9.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject9a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel9a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel9a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel9a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel9a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel9a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel9a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject9b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel9b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel9b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel9b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel9b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel9b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel9b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject9c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel9c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel9c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel9c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel9c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel9c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel9c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject10.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel10.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel10.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel10.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel10.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel10.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel10.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject10a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel10a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel10a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel10a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel10a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel10a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel10a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject10b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel10b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel10b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel10b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel10b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel10b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel10b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject10c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel10c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel10c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel10c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel10c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel10c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel10c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject11.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel11.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel11.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel11.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel11.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel11.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel11.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject11a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel11a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel11a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel11a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel11a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel11a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel11a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject11b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel11b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel11b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel11b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel11b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel11b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel11b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject11c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel11c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel11c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel11c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel11c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel11c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel11c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject12.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel12.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel12.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel12.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel12.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel12.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel12.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject12a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel12a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel12a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel12a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel12a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel12a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel12a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject12b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel12b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel12b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel12b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel12b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel12b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel12b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject12c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel12c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel12c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel12c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel12c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel12c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel12c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject13.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel13.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel13.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel13.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel13.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel13.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel13.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject13a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel13a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel13a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel13a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel13a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel13a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel13a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject13b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel13b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel13b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel13b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel13b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel13b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel13b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject13c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel13c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel13c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel13c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel13c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel13c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel13c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject14.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel14.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel14.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel14.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel14.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel14.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel14.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject14a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel14a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel14a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel14a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel14a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel14a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel14a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject14b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel14b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel14b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel14b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel14b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel14b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel14b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject14c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel14c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel14c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel14c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel14c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel14c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel14c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject15.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel15.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel15.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel15.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel15.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel15.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel15.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject15a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel15a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel15a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel15a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel15a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel15a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel15a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject15b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel15b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel15b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel15b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel15b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel15b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel15b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject15c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel15c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel15c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel15c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel15c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel15c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel15c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject16.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel16.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel16.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel16.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel16.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel16.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel16.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject16a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel16a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel16a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel16a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel16a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel16a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel16a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject16b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel16b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel16b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel16b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel16b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel16b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel16b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject16c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel16c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel16c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel16c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel16c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel16c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel16c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject17.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel17.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel17.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel17.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel17.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel17.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel17.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject17a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel17a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel17a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel17a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel17a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel17a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel17a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject17b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel17b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel17b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel17b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel17b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel17b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel17b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject17c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel17c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel17c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel17c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel17c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel17c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel17c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject18.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel18.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel18.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel18.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel18.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel18.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel18.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject18a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel18a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel18a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel18a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel18a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel18a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel18a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject18b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel18b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel18b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel18b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel18b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel18b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel18b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject18c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel18c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel18c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel18c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel18c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel18c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel18c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject19.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel19.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel19.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel19.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel19.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel19.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel19.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject19a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel19a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel19a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel19a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel19a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel19a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel19a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject19b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel19b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel19b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel19b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel19b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel19b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel19b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject19c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel19c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel19c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel19c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel19c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel19c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel19c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject20.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel20.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel20.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel20.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel20.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel20.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel20.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject20a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel20a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel20a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel20a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel20a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel20a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel20a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject20b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel20b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel20b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel20b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel20b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel20b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel20b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject20c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel20c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel20c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel20c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel20c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel20c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel20c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject21.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel21.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel21.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel21.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel21.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel21.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel21.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject21a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel21a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel21a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel21a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel21a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel21a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel21a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject21b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel21b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel21b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel21b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel21b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel21b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel21b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject21c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel21c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel21c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel21c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel21c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel21c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel21c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject22.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel22.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel22.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel22.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel22.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel22.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel22.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject22a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel22a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel22a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel22a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel22a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel22a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel22a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject22b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel22b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel22b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel22b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel22b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel22b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel22b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject22c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel22c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel22c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel22c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel22c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel22c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel22c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject23.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel23.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel23.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel23.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel23.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel23.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel23.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject23a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel23a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel23a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel23a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel23a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel23a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel23a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject23b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel23b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel23b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel23b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel23b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel23b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel23b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject23c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel23c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel23c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel23c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel23c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel23c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel23c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject24.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel24.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel24.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel24.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel24.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel24.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel24.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject24a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel24a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel24a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel24a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel24a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel24a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel24a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject24b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel24b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel24b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel24b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel24b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel24b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel24b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject24c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel24c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel24c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel24c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel24c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel24c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel24c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject25.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel25.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel25.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel25.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel25.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel25.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel25.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject25a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel25a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel25a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel25a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel25a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel25a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel25a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject25b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel25b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel25b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel25b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel25b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel25b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel25b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject25c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel25c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel25c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel25c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel25c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel25c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel25c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject26.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel26.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel26.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel26.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel26.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel26.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel26.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject26a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel26a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel26a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel26a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel26a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel26a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel26a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject26b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel26b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel26b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel26b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel26b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel26b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel26b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject26c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel26c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel26c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel26c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel26c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel26c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel26c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject27.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel27.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel27.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel27.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel27.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel27.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel27.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject27a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel27a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel27a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel27a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel27a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel27a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel27a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject27b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel27b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel27b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel27b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel27b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel27b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel27b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject27c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel27c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel27c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel27c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel27c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel27c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel27c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject28.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel28.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel28.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel28.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel28.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel28.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel28.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject28a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel28a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel28a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel28a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel28a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel28a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel28a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject28b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel28b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel28b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel28b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel28b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel28b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel28b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject28c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel28c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel28c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel28c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel28c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel28c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel28c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject29.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel29.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel29.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel29.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel29.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel29.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel29.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject29a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel29a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel29a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel29a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel29a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel29a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel29a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject29b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel29b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel29b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel29b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel29b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel29b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel29b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject29c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel29c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel29c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel29c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel29c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel29c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel29c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject30.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel30.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel30.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel30.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel30.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel30.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel30.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject30a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel30a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel30a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel30a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel30a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel30a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel30a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject30b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel30b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel30b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel30b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel30b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel30b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel30b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject30c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel30c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel30c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel30c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel30c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel30c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel30c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject31.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel31.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel31.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel31.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel31.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel31.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel31.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject31a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel31a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel31a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel31a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel31a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel31a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel31a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject31b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel31b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel31b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel31b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel31b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel31b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel31b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject31c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel31c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel31c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel31c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel31c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel31c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel31c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject32.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel32.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel32.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel32.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel32.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel32.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel32.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject32a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel32a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel32a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel32a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel32a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel32a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel32a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject32b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel32b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel32b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel32b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel32b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel32b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel32b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject32c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel32c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel32c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel32c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel32c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel32c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel32c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject33.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel33.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel33.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel33.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel33.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel33.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel33.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject33a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel33a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel33a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel33a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel33a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel33a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel33a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject33b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel33b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel33b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel33b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel33b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel33b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel33b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject33c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel33c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel33c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel33c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel33c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel33c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel33c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject34.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel34.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel34.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel34.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel34.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel34.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel34.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject34a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel34a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel34a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel34a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel34a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel34a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel34a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject34b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel34b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel34b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel34b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel34b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel34b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel34b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject34c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel34c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel34c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel34c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel34c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel34c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel34c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject35.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel35.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel35.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel35.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel35.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel35.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel35.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject35a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel35a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel35a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel35a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel35a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel35a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel35a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject35b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel35b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel35b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel35b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel35b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel35b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel35b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject35c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel35c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel35c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel35c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel35c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel35c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel35c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject36.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel36.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel36.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel36.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel36.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel36.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel36.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject36a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel36a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel36a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel36a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel36a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel36a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel36a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject36b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel36b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel36b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel36b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel36b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel36b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel36b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject36c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel36c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel36c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel36c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel36c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel36c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel36c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject37.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel37.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel37.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel37.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel37.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel37.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel37.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject37a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel37a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel37a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel37a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel37a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel37a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel37a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject37b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel37b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel37b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel37b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel37b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel37b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel37b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject37c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel37c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel37c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel37c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel37c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel37c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel37c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject38.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel38.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel38.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel38.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel38.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel38.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel38.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject38a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel38a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel38a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel38a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel38a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel38a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel38a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject38b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel38b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel38b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel38b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel38b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel38b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel38b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject38c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel38c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel38c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel38c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel38c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel38c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel38c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject39.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel39.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel39.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel39.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel39.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel39.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel39.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject39a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel39a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel39a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel39a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel39a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel39a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel39a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject39b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel39b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel39b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel39b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel39b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel39b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel39b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject39c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel39c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel39c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel39c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel39c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel39c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel39c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject40.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel40.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel40.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel40.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel40.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel40.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel40.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject40a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel40a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel40a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel40a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel40a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel40a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel40a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject40b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel40b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel40b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel40b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel40b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel40b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel40b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject40c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel40c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel40c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel40c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel40c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel40c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel40c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject41.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel41.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel41.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel41.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel41.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel41.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel41.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject41a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel41a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel41a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel41a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel41a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel41a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel41a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject41b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel41b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel41b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel41b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel41b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel41b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel41b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject41c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel41c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel41c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel41c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel41c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel41c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel41c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject42.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel42.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel42.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel42.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel42.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel42.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel42.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject42a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel42a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel42a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel42a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel42a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel42a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel42a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject42b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel42b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel42b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel42b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel42b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel42b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel42b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject42c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel42c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel42c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel42c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel42c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel42c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel42c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject43.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel43.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel43.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel43.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel43.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel43.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel43.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject43a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel43a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel43a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel43a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel43a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel43a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel43a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject43b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel43b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel43b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel43b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel43b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel43b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel43b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject43c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel43c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel43c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel43c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel43c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel43c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel43c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject44.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel44.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel44.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel44.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel44.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel44.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel44.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject44a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel44a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel44a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel44a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel44a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel44a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel44a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject44b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel44b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel44b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel44b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel44b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel44b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel44b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject44c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel44c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel44c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel44c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel44c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel44c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel44c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject45.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel45.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel45.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel45.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel45.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel45.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel45.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject45a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel45a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel45a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel45a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel45a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel45a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel45a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject45b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel45b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel45b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel45b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel45b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel45b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel45b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject45c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel45c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel45c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel45c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel45c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel45c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel45c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject46.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel46.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel46.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel46.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel46.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel46.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel46.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject46a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel46a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel46a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel46a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel46a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel46a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel46a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject46b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel46b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel46b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel46b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel46b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel46b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel46b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject46c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel46c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel46c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel46c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel46c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel46c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel46c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject47.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel47.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel47.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel47.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel47.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel47.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel47.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject47a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel47a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel47a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel47a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel47a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel47a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel47a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject47b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel47b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel47b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel47b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel47b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel47b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel47b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject47c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel47c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel47c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel47c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel47c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel47c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel47c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject48.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel48.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel48.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel48.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel48.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel48.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel48.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject48a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel48a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel48a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel48a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel48a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel48a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel48a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject48b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel48b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel48b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel48b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel48b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel48b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel48b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject48c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel48c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel48c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel48c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel48c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel48c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel48c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject49.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel49.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel49.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel49.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel49.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel49.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel49.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject49a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel49a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel49a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel49a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel49a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel49a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel49a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject49b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel49b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel49b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel49b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel49b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel49b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel49b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject49c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel49c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel49c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel49c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel49c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel49c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel49c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject50.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel50.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel50.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel50.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel50.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel50.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel50.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject50a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel50a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel50a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel50a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel50a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel50a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel50a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject50b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel50b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel50b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel50b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel50b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel50b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel50b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject50c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel50c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel50c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel50c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel50c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel50c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel50c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject51.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel51.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel51.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel51.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel51.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel51.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel51.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject51a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel51a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel51a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel51a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel51a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel51a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel51a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject51b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel51b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel51b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel51b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel51b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel51b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel51b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject51c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel51c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel51c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel51c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel51c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel51c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel51c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject52.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel52.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel52.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel52.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel52.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel52.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel52.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject52a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel52a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel52a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel52a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel52a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel52a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel52a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject52b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel52b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel52b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel52b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel52b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel52b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel52b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject52c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel52c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel52c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel52c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel52c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel52c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel52c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject53.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel53.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel53.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel53.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel53.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel53.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel53.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject53a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel53a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel53a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel53a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel53a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel53a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel53a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject53b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel53b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel53b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel53b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel53b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel53b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel53b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject53c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel53c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel53c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel53c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel53c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel53c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel53c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject54.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel54.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel54.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel54.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel54.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel54.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel54.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject54a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel54a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel54a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel54a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel54a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel54a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel54a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject54b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel54b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel54b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel54b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel54b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel54b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel54b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject54c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel54c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel54c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel54c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel54c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel54c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel54c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject55.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel55.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel55.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel55.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel55.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel55.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel55.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject55a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel55a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel55a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel55a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel55a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel55a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel55a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject55b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel55b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel55b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel55b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel55b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel55b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel55b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject55c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel55c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel55c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel55c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel55c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel55c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel55c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject56.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel56.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel56.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel56.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel56.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel56.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel56.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject56a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel56a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel56a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel56a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel56a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel56a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel56a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject56b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel56b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel56b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel56b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel56b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel56b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel56b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject56c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel56c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel56c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel56c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel56c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel56c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel56c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject57.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel57.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel57.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel57.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel57.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel57.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel57.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject57a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel57a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel57a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel57a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel57a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel57a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel57a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject57b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel57b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel57b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel57b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel57b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel57b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel57b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject57c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel57c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel57c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel57c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel57c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel57c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel57c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject58.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel58.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel58.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel58.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel58.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel58.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel58.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject58a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel58a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel58a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel58a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel58a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel58a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel58a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject58b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel58b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel58b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel58b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel58b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel58b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel58b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject58c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel58c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel58c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel58c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel58c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel58c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel58c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject59.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel59.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel59.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel59.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel59.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel59.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel59.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject59a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel59a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel59a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel59a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel59a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel59a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel59a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject59b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel59b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel59b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel59b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel59b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel59b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel59b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject59c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel59c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel59c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel59c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel59c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel59c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel59c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject60.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel60.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel60.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel60.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel60.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel60.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel60.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject60a.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel60a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel60a.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel60a.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel60a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel60a.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel60a.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject60b.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel60b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel60b.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel60b.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel60b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel60b.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel60b.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            if (System.Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject60c.GetComponent<Text>().text) <= 0) {

                SaveCardDeck1.saveCardDeck1.cardModel60c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel60c.transform.localScale = DeckManager.deckManager.lockedCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel60c.transform.localScale = DeckManager.deckManager.lockedCardScale;

            } else {

                SaveCardDeck1.saveCardDeck1.cardModel60c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck2.saveCardDeck2.cardModel60c.transform.localScale = DeckManager.deckManager.modelCardScale;
                SaveCardDeck3.saveCardDeck3.cardModel60c.transform.localScale = DeckManager.deckManager.modelCardScale;

            }

            yield return null;

        }

        /** Set SpawnPoints to edit the deck  */
        #region SetSpawnPointsStuff definition
        void SetSpawnPointsToEdit() {


            if (addEditSpawnPoints) {

                //Find any slot without cards and add a spawn point for spawning a card
                if (editDeck1.Count == 20) {

                    if (deck1Slot1) {
                        if (deck1Slot1.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot1)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot1);
                            }
                        }
                    }
                    if (deck1Slot2) {
                        if (deck1Slot2.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot2)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot2);
                            }
                        }
                    }
                    if (deck1Slot3) {
                        if (deck1Slot3.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot3)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot3);
                            }
                        }
                    }
                    if (deck1Slot4) {
                        if (deck1Slot4.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot4)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot4);
                            }
                        }
                    }
                    if (deck1Slot5) {
                        if (deck1Slot5.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot5)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot5);
                            }
                        }
                    }
                    if (deck1Slot6) {
                        if (deck1Slot6.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot6)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot6);
                            }
                        }
                    }
                    if (deck1Slot7) {
                        if (deck1Slot7.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot7)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot7);
                            }
                        }
                    }
                    if (deck1Slot8) {
                        if (deck1Slot8.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot8)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot8);
                            }
                        }
                    }
                    if (deck1Slot9) {
                        if (deck1Slot9.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot9)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot9);
                            }
                        }
                    }
                    if (deck1Slot10) {
                        if (deck1Slot10.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot10)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot10);
                            }
                        }
                    }
                    if (deck1Slot11) {
                        if (deck1Slot11.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot11)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot11);
                            }
                        }
                    }
                    if (deck1Slot12) {
                        if (deck1Slot12.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot12)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot12);
                            }
                        }
                    }
                    if (deck1Slot13) {
                        if (deck1Slot13.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot13)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot13);
                            }
                        }
                    }
                    if (deck1Slot14) {
                        if (deck1Slot14.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot14)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot14);
                            }
                        }
                    }
                    if (deck1Slot15) {
                        if (deck1Slot15.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot15)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot15);
                            }
                        }
                    }
                    if (deck1Slot16) {
                        if (deck1Slot16.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot16)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot16);
                            }
                        }
                    }
                    if (deck1Slot17) {
                        if (deck1Slot17.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot17)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot17);
                            }
                        }
                    }
                    if (deck1Slot18) {
                        if (deck1Slot18.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot18)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot18);
                            }
                        }
                    }
                    if (deck1Slot19) {
                        if (deck1Slot19.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot19)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot19);
                            }
                        }
                    }
                    if (deck1Slot20) {
                        if (deck1Slot20.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot20)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot20);
                            }
                        }
                    }


                } else if (editDeck1.Count == 25) {

                    if (deck1Slot1) {
                        if (deck1Slot1.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot1)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot1);
                            }
                        }
                    }
                    if (deck1Slot2) {
                        if (deck1Slot2.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot2)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot2);
                            }
                        }
                    }
                    if (deck1Slot3) {
                        if (deck1Slot3.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot3)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot3);
                            }
                        }
                    }
                    if (deck1Slot4) {
                        if (deck1Slot4.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot4)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot4);
                            }
                        }
                    }
                    if (deck1Slot5) {
                        if (deck1Slot5.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot5)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot5);
                            }
                        }
                    }
                    if (deck1Slot6) {
                        if (deck1Slot6.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot6)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot6);
                            }
                        }
                    }
                    if (deck1Slot7) {
                        if (deck1Slot7.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot7)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot7);
                            }
                        }
                    }
                    if (deck1Slot8) {
                        if (deck1Slot8.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot8)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot8);
                            }
                        }
                    }
                    if (deck1Slot9) {
                        if (deck1Slot9.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot9)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot9);
                            }
                        }
                    }
                    if (deck1Slot10) {
                        if (deck1Slot10.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot10)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot10);
                            }
                        }
                    }
                    if (deck1Slot11) {
                        if (deck1Slot11.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot11)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot11);
                            }
                        }
                    }
                    if (deck1Slot12) {
                        if (deck1Slot12.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot12)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot12);
                            }
                        }
                    }
                    if (deck1Slot13) {
                        if (deck1Slot13.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot13)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot13);
                            }
                        }
                    }
                    if (deck1Slot14) {
                        if (deck1Slot14.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot14)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot14);
                            }
                        }
                    }
                    if (deck1Slot15) {
                        if (deck1Slot15.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot15)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot15);
                            }
                        }
                    }
                    if (deck1Slot16) {
                        if (deck1Slot16.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot16)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot16);
                            }
                        }
                    }
                    if (deck1Slot17) {
                        if (deck1Slot17.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot17)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot17);
                            }
                        }
                    }
                    if (deck1Slot18) {
                        if (deck1Slot18.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot18)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot18);
                            }
                        }
                    }
                    if (deck1Slot19) {
                        if (deck1Slot19.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot19)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot19);
                            }
                        }
                    }
                    if (deck1Slot20) {
                        if (deck1Slot20.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot20)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot20);
                            }
                        }
                    }
                    if (deck1Slot21) {
                        if (deck1Slot21.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot21)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot21);
                            }
                        }
                    }
                    if (deck1Slot22) {
                        if (deck1Slot22.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot22)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot22);
                            }
                        }
                    }
                    if (deck1Slot23) {
                        if (deck1Slot23.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot23)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot23);
                            }
                        }
                    }
                    if (deck1Slot24) {
                        if (deck1Slot24.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot24)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot24);
                            }
                        }
                    }
                    if (deck1Slot25) {
                        if (deck1Slot25.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot25)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot25);
                            }
                        }
                    }

                } else if (editDeck1.Count == 30) {

                    if (deck1Slot1) {
                        if (deck1Slot1.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot1)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot1);
                            }
                        }
                    }
                    if (deck1Slot2) {
                        if (deck1Slot2.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot2)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot2);
                            }
                        }
                    }
                    if (deck1Slot3) {
                        if (deck1Slot3.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot3)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot3);
                            }
                        }
                    }
                    if (deck1Slot4) {
                        if (deck1Slot4.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot4)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot4);
                            }
                        }
                    }
                    if (deck1Slot5) {
                        if (deck1Slot5.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot5)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot5);
                            }
                        }
                    }
                    if (deck1Slot6) {
                        if (deck1Slot6.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot6)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot6);
                            }
                        }
                    }
                    if (deck1Slot7) {
                        if (deck1Slot7.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot7)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot7);
                            }
                        }
                    }
                    if (deck1Slot8) {
                        if (deck1Slot8.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot8)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot8);
                            }
                        }
                    }
                    if (deck1Slot9) {
                        if (deck1Slot9.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot9)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot9);
                            }
                        }
                    }
                    if (deck1Slot10) {
                        if (deck1Slot10.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot10)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot10);
                            }
                        }
                    }
                    if (deck1Slot11) {
                        if (deck1Slot11.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot11)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot11);
                            }
                        }
                    }
                    if (deck1Slot12) {
                        if (deck1Slot12.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot12)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot12);
                            }
                        }
                    }
                    if (deck1Slot13) {
                        if (deck1Slot13.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot13)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot13);
                            }
                        }
                    }
                    if (deck1Slot14) {
                        if (deck1Slot14.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot14)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot14);
                            }
                        }
                    }
                    if (deck1Slot15) {
                        if (deck1Slot15.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot15)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot15);
                            }
                        }
                    }
                    if (deck1Slot16) {
                        if (deck1Slot16.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot16)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot16);
                            }
                        }
                    }
                    if (deck1Slot17) {
                        if (deck1Slot17.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot17)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot17);
                            }
                        }
                    }
                    if (deck1Slot18) {
                        if (deck1Slot18.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot18)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot18);
                            }
                        }
                    }
                    if (deck1Slot19) {
                        if (deck1Slot19.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot19)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot19);
                            }
                        }
                    }
                    if (deck1Slot20) {
                        if (deck1Slot20.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot20)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot20);
                            }
                        }
                    }
                    if (deck1Slot21) {
                        if (deck1Slot21.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot21)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot21);
                            }
                        }
                    }
                    if (deck1Slot22) {
                        if (deck1Slot22.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot22)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot22);
                            }
                        }
                    }
                    if (deck1Slot23) {
                        if (deck1Slot23.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot23)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot23);
                            }
                        }
                    }
                    if (deck1Slot24) {
                        if (deck1Slot24.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot24)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot24);
                            }
                        }
                    }
                    if (deck1Slot25) {
                        if (deck1Slot25.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot25)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot25);
                            }
                        }
                    }
                    if (deck1Slot26) {
                        if (deck1Slot26.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot26)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot26);
                            }
                        }
                    }
                    if (deck1Slot27) {
                        if (deck1Slot27.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot27)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot27);
                            }
                        }
                    }
                    if (deck1Slot28) {
                        if (deck1Slot28.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot28)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot28);
                            }
                        }
                    }
                    if (deck1Slot29) {
                        if (deck1Slot29.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot29)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot29);
                            }
                        }
                    }
                    if (deck1Slot30) {
                        if (deck1Slot30.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot30)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot30);
                            }
                        }
                    }
                } else if (editDeck1.Count == 35) {

                    if (deck1Slot1) {
                        if (deck1Slot1.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot1)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot1);
                            }
                        }
                    }
                    if (deck1Slot2) {
                        if (deck1Slot2.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot2)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot2);
                            }
                        }
                    }
                    if (deck1Slot3) {
                        if (deck1Slot3.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot3)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot3);
                            }
                        }
                    }
                    if (deck1Slot4) {
                        if (deck1Slot4.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot4)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot4);
                            }
                        }
                    }
                    if (deck1Slot5) {
                        if (deck1Slot5.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot5)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot5);
                            }
                        }
                    }
                    if (deck1Slot6) {
                        if (deck1Slot6.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot6)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot6);
                            }
                        }
                    }
                    if (deck1Slot7) {
                        if (deck1Slot7.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot7)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot7);
                            }
                        }
                    }
                    if (deck1Slot8) {
                        if (deck1Slot8.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot8)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot8);
                            }
                        }
                    }
                    if (deck1Slot9) {
                        if (deck1Slot9.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot9)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot9);
                            }
                        }
                    }
                    if (deck1Slot10) {
                        if (deck1Slot10.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot10)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot10);
                            }
                        }
                    }
                    if (deck1Slot11) {
                        if (deck1Slot11.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot11)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot11);
                            }
                        }
                    }
                    if (deck1Slot12) {
                        if (deck1Slot12.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot12)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot12);
                            }
                        }
                    }
                    if (deck1Slot13) {
                        if (deck1Slot13.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot13)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot13);
                            }
                        }
                    }
                    if (deck1Slot14) {
                        if (deck1Slot14.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot14)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot14);
                            }
                        }
                    }
                    if (deck1Slot15) {
                        if (deck1Slot15.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot15)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot15);
                            }
                        }
                    }
                    if (deck1Slot16) {
                        if (deck1Slot16.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot16)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot16);
                            }
                        }
                    }
                    if (deck1Slot17) {
                        if (deck1Slot17.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot17)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot17);
                            }
                        }
                    }
                    if (deck1Slot18) {
                        if (deck1Slot18.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot18)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot18);
                            }
                        }
                    }
                    if (deck1Slot19) {
                        if (deck1Slot19.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot19)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot19);
                            }
                        }
                    }
                    if (deck1Slot20) {
                        if (deck1Slot20.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot20)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot20);
                            }
                        }
                    }
                    if (deck1Slot21) {
                        if (deck1Slot21.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot21)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot21);
                            }
                        }
                    }
                    if (deck1Slot22) {
                        if (deck1Slot22.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot22)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot22);
                            }
                        }
                    }
                    if (deck1Slot23) {
                        if (deck1Slot23.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot23)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot23);
                            }
                        }
                    }
                    if (deck1Slot24) {
                        if (deck1Slot24.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot24)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot24);
                            }
                        }
                    }
                    if (deck1Slot25) {
                        if (deck1Slot25.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot25)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot25);
                            }
                        }
                    }
                    if (deck1Slot26) {
                        if (deck1Slot26.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot26)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot26);
                            }
                        }
                    }
                    if (deck1Slot27) {
                        if (deck1Slot27.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot27)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot27);
                            }
                        }
                    }
                    if (deck1Slot28) {
                        if (deck1Slot28.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot28)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot28);
                            }
                        }
                    }
                    if (deck1Slot29) {
                        if (deck1Slot29.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot29)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot29);
                            }
                        }
                    }
                    if (deck1Slot30) {
                        if (deck1Slot30.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot30)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot30);
                            }
                        }
                    }
                    if (deck1Slot31) {
                        if (deck1Slot31.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot31)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot31);
                            }
                        }
                    }
                    if (deck1Slot32) {
                        if (deck1Slot32.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot32)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot32);
                            }
                        }
                    }
                    if (deck1Slot33) {
                        if (deck1Slot33.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot33)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot33);
                            }
                        }
                    }
                    if (deck1Slot34) {
                        if (deck1Slot34.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot34)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot34);
                            }
                        }
                    }
                    if (deck1Slot35) {
                        if (deck1Slot35.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot35)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot35);
                            }
                        }
                    }
                } else if (editDeck1.Count == 40) {

                    if (deck1Slot1) {
                        if (deck1Slot1.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot1)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot1);
                            }
                        }
                    }
                    if (deck1Slot2) {
                        if (deck1Slot2.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot2)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot2);
                            }
                        }
                    }
                    if (deck1Slot3) {
                        if (deck1Slot3.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot3)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot3);
                            }
                        }
                    }
                    if (deck1Slot4) {
                        if (deck1Slot4.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot4)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot4);
                            }
                        }
                    }
                    if (deck1Slot5) {
                        if (deck1Slot5.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot5)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot5);
                            }
                        }
                    }
                    if (deck1Slot6) {
                        if (deck1Slot6.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot6)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot6);
                            }
                        }
                    }
                    if (deck1Slot7) {
                        if (deck1Slot7.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot7)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot7);
                            }
                        }
                    }
                    if (deck1Slot8) {
                        if (deck1Slot8.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot8)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot8);
                            }
                        }
                    }
                    if (deck1Slot9) {
                        if (deck1Slot9.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot9)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot9);
                            }
                        }
                    }
                    if (deck1Slot10) {
                        if (deck1Slot10.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot10)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot10);
                            }
                        }
                    }
                    if (deck1Slot11) {
                        if (deck1Slot11.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot11)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot11);
                            }
                        }
                    }
                    if (deck1Slot12) {
                        if (deck1Slot12.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot12)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot12);
                            }
                        }
                    }
                    if (deck1Slot13) {
                        if (deck1Slot13.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot13)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot13);
                            }
                        }
                    }
                    if (deck1Slot14) {
                        if (deck1Slot14.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot14)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot14);
                            }
                        }
                    }
                    if (deck1Slot15) {
                        if (deck1Slot15.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot15)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot15);
                            }
                        }
                    }
                    if (deck1Slot16) {
                        if (deck1Slot16.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot16)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot16);
                            }
                        }
                    }
                    if (deck1Slot17) {
                        if (deck1Slot17.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot17)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot17);
                            }
                        }
                    }
                    if (deck1Slot18) {
                        if (deck1Slot18.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot18)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot18);
                            }
                        }
                    }
                    if (deck1Slot19) {
                        if (deck1Slot19.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot19)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot19);
                            }
                        }
                    }
                    if (deck1Slot20) {
                        if (deck1Slot20.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot20)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot20);
                            }
                        }
                    }
                    if (deck1Slot21) {
                        if (deck1Slot21.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot21)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot21);
                            }
                        }
                    }
                    if (deck1Slot22) {
                        if (deck1Slot22.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot22)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot22);
                            }
                        }
                    }
                    if (deck1Slot23) {
                        if (deck1Slot23.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot23)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot23);
                            }
                        }
                    }
                    if (deck1Slot24) {
                        if (deck1Slot24.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot24)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot24);
                            }
                        }
                    }
                    if (deck1Slot25) {
                        if (deck1Slot25.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot25)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot25);
                            }
                        }
                    }
                    if (deck1Slot26) {
                        if (deck1Slot26.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot26)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot26);
                            }
                        }
                    }
                    if (deck1Slot27) {
                        if (deck1Slot27.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot27)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot27);
                            }
                        }
                    }
                    if (deck1Slot28) {
                        if (deck1Slot28.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot28)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot28);
                            }
                        }
                    }
                    if (deck1Slot29) {
                        if (deck1Slot29.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot29)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot29);
                            }
                        }
                    }
                    if (deck1Slot30) {
                        if (deck1Slot30.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot30)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot30);
                            }
                        }
                    }
                    if (deck1Slot31) {
                        if (deck1Slot31.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot31)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot31);
                            }
                        }
                    }
                    if (deck1Slot32) {
                        if (deck1Slot32.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot32)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot32);
                            }
                        }
                    }
                    if (deck1Slot33) {
                        if (deck1Slot33.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot33)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot33);
                            }
                        }
                    }
                    if (deck1Slot34) {
                        if (deck1Slot34.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot34)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot34);
                            }
                        }
                    }
                    if (deck1Slot35) {
                        if (deck1Slot35.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot35)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot35);
                            }
                        }
                    }
                    if (deck1Slot36) {
                        if (deck1Slot36.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot36)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot36);
                            }
                        }
                    }
                    if (deck1Slot37) {
                        if (deck1Slot37.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot37)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot37);
                            }
                        }
                    }
                    if (deck1Slot38) {
                        if (deck1Slot38.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot38)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot38);
                            }
                        }
                    }
                    if (deck1Slot39) {
                        if (deck1Slot39.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot39)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot39);
                            }
                        }
                    }
                    if (deck1Slot40) {
                        if (deck1Slot40.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot40)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot40);
                            }
                        }
                    }

                } else if (editDeck1.Count == 45) {

                    if (deck1Slot1) {
                        if (deck1Slot1.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot1)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot1);
                            }
                        }
                    }
                    if (deck1Slot2) {
                        if (deck1Slot2.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot2)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot2);
                            }
                        }
                    }
                    if (deck1Slot3) {
                        if (deck1Slot3.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot3)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot3);
                            }
                        }
                    }
                    if (deck1Slot4) {
                        if (deck1Slot4.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot4)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot4);
                            }
                        }
                    }
                    if (deck1Slot5) {
                        if (deck1Slot5.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot5)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot5);
                            }
                        }
                    }
                    if (deck1Slot6) {
                        if (deck1Slot6.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot6)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot6);
                            }
                        }
                    }
                    if (deck1Slot7) {
                        if (deck1Slot7.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot7)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot7);
                            }
                        }
                    }
                    if (deck1Slot8) {
                        if (deck1Slot8.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot8)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot8);
                            }
                        }
                    }
                    if (deck1Slot9) {
                        if (deck1Slot9.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot9)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot9);
                            }
                        }
                    }
                    if (deck1Slot10) {
                        if (deck1Slot10.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot10)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot10);
                            }
                        }
                    }
                    if (deck1Slot11) {
                        if (deck1Slot11.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot11)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot11);
                            }
                        }
                    }
                    if (deck1Slot12) {
                        if (deck1Slot12.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot12)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot12);
                            }
                        }
                    }
                    if (deck1Slot13) {
                        if (deck1Slot13.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot13)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot13);
                            }
                        }
                    }
                    if (deck1Slot14) {
                        if (deck1Slot14.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot14)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot14);
                            }
                        }
                    }
                    if (deck1Slot15) {
                        if (deck1Slot15.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot15)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot15);
                            }
                        }
                    }
                    if (deck1Slot16) {
                        if (deck1Slot16.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot16)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot16);
                            }
                        }
                    }
                    if (deck1Slot17) {
                        if (deck1Slot17.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot17)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot17);
                            }
                        }
                    }
                    if (deck1Slot18) {
                        if (deck1Slot18.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot18)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot18);
                            }
                        }
                    }
                    if (deck1Slot19) {
                        if (deck1Slot19.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot19)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot19);
                            }
                        }
                    }
                    if (deck1Slot20) {
                        if (deck1Slot20.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot20)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot20);
                            }
                        }
                    }
                    if (deck1Slot21) {
                        if (deck1Slot21.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot21)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot21);
                            }
                        }
                    }
                    if (deck1Slot22) {
                        if (deck1Slot22.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot22)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot22);
                            }
                        }
                    }
                    if (deck1Slot23) {
                        if (deck1Slot23.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot23)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot23);
                            }
                        }
                    }
                    if (deck1Slot24) {
                        if (deck1Slot24.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot24)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot24);
                            }
                        }
                    }
                    if (deck1Slot25) {
                        if (deck1Slot25.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot25)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot25);
                            }
                        }
                    }
                    if (deck1Slot26) {
                        if (deck1Slot26.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot26)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot26);
                            }
                        }
                    }
                    if (deck1Slot27) {
                        if (deck1Slot27.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot27)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot27);
                            }
                        }
                    }
                    if (deck1Slot28) {
                        if (deck1Slot28.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot28)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot28);
                            }
                        }
                    }
                    if (deck1Slot29) {
                        if (deck1Slot29.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot29)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot29);
                            }
                        }
                    }
                    if (deck1Slot30) {
                        if (deck1Slot30.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot30)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot30);
                            }
                        }
                    }
                    if (deck1Slot31) {
                        if (deck1Slot31.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot31)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot31);
                            }
                        }
                    }
                    if (deck1Slot32) {
                        if (deck1Slot32.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot32)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot32);
                            }
                        }
                    }
                    if (deck1Slot33) {
                        if (deck1Slot33.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot33)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot33);
                            }
                        }
                    }
                    if (deck1Slot34) {
                        if (deck1Slot34.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot34)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot34);
                            }
                        }
                    }
                    if (deck1Slot35) {
                        if (deck1Slot35.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot35)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot35);
                            }
                        }
                    }
                    if (deck1Slot36) {
                        if (deck1Slot36.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot36)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot36);
                            }
                        }
                    }
                    if (deck1Slot37) {
                        if (deck1Slot37.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot37)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot37);
                            }
                        }
                    }
                    if (deck1Slot38) {
                        if (deck1Slot38.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot38)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot38);
                            }
                        }
                    }
                    if (deck1Slot39) {
                        if (deck1Slot39.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot39)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot39);
                            }
                        }
                    }
                    if (deck1Slot40) {
                        if (deck1Slot40.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot40)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot40);
                            }
                        }
                    }
                    if (deck1Slot41) {
                        if (deck1Slot41.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot41)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot41);
                            }
                        }
                    }
                    if (deck1Slot42) {
                        if (deck1Slot42.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot42)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot42);
                            }
                        }
                    }
                    if (deck1Slot43) {
                        if (deck1Slot43.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot43)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot43);
                            }
                        }
                    }
                    if (deck1Slot44) {
                        if (deck1Slot44.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot44)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot44);
                            }
                        }
                    }
                    if (deck1Slot45) {
                        if (deck1Slot45.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot45)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot45);
                            }
                        }
                    }
                } else if (editDeck1.Count == 50) {

                    if (deck1Slot1) {
                        if (deck1Slot1.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot1)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot1);
                            }
                        }
                    }
                    if (deck1Slot2) {
                        if (deck1Slot2.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot2)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot2);
                            }
                        }
                    }
                    if (deck1Slot3) {
                        if (deck1Slot3.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot3)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot3);
                            }
                        }
                    }
                    if (deck1Slot4) {
                        if (deck1Slot4.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot4)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot4);
                            }
                        }
                    }
                    if (deck1Slot5) {
                        if (deck1Slot5.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot5)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot5);
                            }
                        }
                    }
                    if (deck1Slot6) {
                        if (deck1Slot6.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot6)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot6);
                            }
                        }
                    }
                    if (deck1Slot7) {
                        if (deck1Slot7.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot7)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot7);
                            }
                        }
                    }
                    if (deck1Slot8) {
                        if (deck1Slot8.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot8)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot8);
                            }
                        }
                    }
                    if (deck1Slot9) {
                        if (deck1Slot9.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot9)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot9);
                            }
                        }
                    }
                    if (deck1Slot10) {
                        if (deck1Slot10.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot10)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot10);
                            }
                        }
                    }
                    if (deck1Slot11) {
                        if (deck1Slot11.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot11)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot11);
                            }
                        }
                    }
                    if (deck1Slot12) {
                        if (deck1Slot12.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot12)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot12);
                            }
                        }
                    }
                    if (deck1Slot13) {
                        if (deck1Slot13.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot13)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot13);
                            }
                        }
                    }
                    if (deck1Slot14) {
                        if (deck1Slot14.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot14)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot14);
                            }
                        }
                    }
                    if (deck1Slot15) {
                        if (deck1Slot15.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot15)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot15);
                            }
                        }
                    }
                    if (deck1Slot16) {
                        if (deck1Slot16.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot16)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot16);
                            }
                        }
                    }
                    if (deck1Slot17) {
                        if (deck1Slot17.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot17)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot17);
                            }
                        }
                    }
                    if (deck1Slot18) {
                        if (deck1Slot18.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot18)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot18);
                            }
                        }
                    }
                    if (deck1Slot19) {
                        if (deck1Slot19.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot19)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot19);
                            }
                        }
                    }
                    if (deck1Slot20) {
                        if (deck1Slot20.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot20)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot20);
                            }
                        }
                    }
                    if (deck1Slot21) {
                        if (deck1Slot21.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot21)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot21);
                            }
                        }
                    }
                    if (deck1Slot22) {
                        if (deck1Slot22.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot22)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot22);
                            }
                        }
                    }
                    if (deck1Slot23) {
                        if (deck1Slot23.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot23)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot23);
                            }
                        }
                    }
                    if (deck1Slot24) {
                        if (deck1Slot24.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot24)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot24);
                            }
                        }
                    }
                    if (deck1Slot25) {
                        if (deck1Slot25.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot25)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot25);
                            }
                        }
                    }
                    if (deck1Slot26) {
                        if (deck1Slot26.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot26)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot26);
                            }
                        }
                    }
                    if (deck1Slot27) {
                        if (deck1Slot27.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot27)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot27);
                            }
                        }
                    }
                    if (deck1Slot28) {
                        if (deck1Slot28.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot28)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot28);
                            }
                        }
                    }
                    if (deck1Slot29) {
                        if (deck1Slot29.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot29)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot29);
                            }
                        }
                    }
                    if (deck1Slot30) {
                        if (deck1Slot30.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot30)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot30);
                            }
                        }
                    }
                    if (deck1Slot31) {
                        if (deck1Slot31.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot31)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot31);
                            }
                        }
                    }
                    if (deck1Slot32) {
                        if (deck1Slot32.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot32)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot32);
                            }
                        }
                    }
                    if (deck1Slot33) {
                        if (deck1Slot33.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot33)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot33);
                            }
                        }
                    }
                    if (deck1Slot34) {
                        if (deck1Slot34.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot34)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot34);
                            }
                        }
                    }
                    if (deck1Slot35) {
                        if (deck1Slot35.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot35)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot35);
                            }
                        }
                    }
                    if (deck1Slot36) {
                        if (deck1Slot36.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot36)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot36);
                            }
                        }
                    }
                    if (deck1Slot37) {
                        if (deck1Slot37.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot37)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot37);
                            }
                        }
                    }
                    if (deck1Slot38) {
                        if (deck1Slot38.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot38)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot38);
                            }
                        }
                    }
                    if (deck1Slot39) {
                        if (deck1Slot39.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot39)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot39);
                            }
                        }
                    }
                    if (deck1Slot40) {
                        if (deck1Slot40.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot40)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot40);
                            }
                        }
                    }
                    if (deck1Slot41) {
                        if (deck1Slot41.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot41)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot41);
                            }
                        }
                    }
                    if (deck1Slot42) {
                        if (deck1Slot42.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot42)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot42);
                            }
                        }
                    }
                    if (deck1Slot43) {
                        if (deck1Slot43.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot43)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot43);
                            }
                        }
                    }
                    if (deck1Slot44) {
                        if (deck1Slot44.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot44)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot44);
                            }
                        }
                    }
                    if (deck1Slot45) {
                        if (deck1Slot45.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot45)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot45);
                            }
                        }
                    }
                    if (deck1Slot46) {
                        if (deck1Slot46.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot46)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot46);
                            }
                        }
                    }
                    if (deck1Slot47) {
                        if (deck1Slot47.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot47)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot47);
                            }
                        }
                    }
                    if (deck1Slot48) {
                        if (deck1Slot48.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot48)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot48);
                            }
                        }
                    }
                    if (deck1Slot49) {
                        if (deck1Slot49.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot49)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot49);
                            }
                        }
                    }
                    if (deck1Slot50) {
                        if (deck1Slot50.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot50)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot50);
                            }
                        }
                    }
                } else if (editDeck1.Count == 55) {

                    if (deck1Slot1) {
                        if (deck1Slot1.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot1)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot1);
                            }
                        }
                    }
                    if (deck1Slot2) {
                        if (deck1Slot2.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot2)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot2);
                            }
                        }
                    }
                    if (deck1Slot3) {
                        if (deck1Slot3.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot3)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot3);
                            }
                        }
                    }
                    if (deck1Slot4) {
                        if (deck1Slot4.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot4)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot4);
                            }
                        }
                    }
                    if (deck1Slot5) {
                        if (deck1Slot5.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot5)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot5);
                            }
                        }
                    }
                    if (deck1Slot6) {
                        if (deck1Slot6.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot6)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot6);
                            }
                        }
                    }
                    if (deck1Slot7) {
                        if (deck1Slot7.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot7)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot7);
                            }
                        }
                    }
                    if (deck1Slot8) {
                        if (deck1Slot8.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot8)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot8);
                            }
                        }
                    }
                    if (deck1Slot9) {
                        if (deck1Slot9.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot9)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot9);
                            }
                        }
                    }
                    if (deck1Slot10) {
                        if (deck1Slot10.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot10)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot10);
                            }
                        }
                    }
                    if (deck1Slot11) {
                        if (deck1Slot11.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot11)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot11);
                            }
                        }
                    }
                    if (deck1Slot12) {
                        if (deck1Slot12.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot12)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot12);
                            }
                        }
                    }
                    if (deck1Slot13) {
                        if (deck1Slot13.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot13)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot13);
                            }
                        }
                    }
                    if (deck1Slot14) {
                        if (deck1Slot14.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot14)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot14);
                            }
                        }
                    }
                    if (deck1Slot15) {
                        if (deck1Slot15.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot15)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot15);
                            }
                        }
                    }
                    if (deck1Slot16) {
                        if (deck1Slot16.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot16)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot16);
                            }
                        }
                    }
                    if (deck1Slot17) {
                        if (deck1Slot17.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot17)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot17);
                            }
                        }
                    }
                    if (deck1Slot18) {
                        if (deck1Slot18.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot18)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot18);
                            }
                        }
                    }
                    if (deck1Slot19) {
                        if (deck1Slot19.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot19)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot19);
                            }
                        }
                    }
                    if (deck1Slot20) {
                        if (deck1Slot20.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot20)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot20);
                            }
                        }
                    }
                    if (deck1Slot21) {
                        if (deck1Slot21.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot21)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot21);
                            }
                        }
                    }
                    if (deck1Slot22) {
                        if (deck1Slot22.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot22)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot22);
                            }
                        }
                    }
                    if (deck1Slot23) {
                        if (deck1Slot23.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot23)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot23);
                            }
                        }
                    }
                    if (deck1Slot24) {
                        if (deck1Slot24.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot24)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot24);
                            }
                        }
                    }
                    if (deck1Slot25) {
                        if (deck1Slot25.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot25)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot25);
                            }
                        }
                    }
                    if (deck1Slot26) {
                        if (deck1Slot26.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot26)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot26);
                            }
                        }
                    }
                    if (deck1Slot27) {
                        if (deck1Slot27.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot27)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot27);
                            }
                        }
                    }
                    if (deck1Slot28) {
                        if (deck1Slot28.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot28)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot28);
                            }
                        }
                    }
                    if (deck1Slot29) {
                        if (deck1Slot29.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot29)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot29);
                            }
                        }
                    }
                    if (deck1Slot30) {
                        if (deck1Slot30.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot30)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot30);
                            }
                        }
                    }
                    if (deck1Slot31) {
                        if (deck1Slot31.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot31)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot31);
                            }
                        }
                    }
                    if (deck1Slot32) {
                        if (deck1Slot32.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot32)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot32);
                            }
                        }
                    }
                    if (deck1Slot33) {
                        if (deck1Slot33.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot33)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot33);
                            }
                        }
                    }
                    if (deck1Slot34) {
                        if (deck1Slot34.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot34)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot34);
                            }
                        }
                    }
                    if (deck1Slot35) {
                        if (deck1Slot35.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot35)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot35);
                            }
                        }
                    }
                    if (deck1Slot36) {
                        if (deck1Slot36.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot36)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot36);
                            }
                        }
                    }
                    if (deck1Slot37) {
                        if (deck1Slot37.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot37)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot37);
                            }
                        }
                    }
                    if (deck1Slot38) {
                        if (deck1Slot38.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot38)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot38);
                            }
                        }
                    }
                    if (deck1Slot39) {
                        if (deck1Slot39.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot39)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot39);
                            }
                        }
                    }
                    if (deck1Slot40) {
                        if (deck1Slot40.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot40)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot40);
                            }
                        }
                    }
                    if (deck1Slot41) {
                        if (deck1Slot41.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot41)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot41);
                            }
                        }
                    }
                    if (deck1Slot42) {
                        if (deck1Slot42.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot42)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot42);
                            }
                        }
                    }
                    if (deck1Slot43) {
                        if (deck1Slot43.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot43)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot43);
                            }
                        }
                    }
                    if (deck1Slot44) {
                        if (deck1Slot44.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot44)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot44);
                            }
                        }
                    }
                    if (deck1Slot45) {
                        if (deck1Slot45.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot45)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot45);
                            }
                        }
                    }
                    if (deck1Slot46) {
                        if (deck1Slot46.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot46)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot46);
                            }
                        }
                    }
                    if (deck1Slot47) {
                        if (deck1Slot47.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot47)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot47);
                            }
                        }
                    }
                    if (deck1Slot48) {
                        if (deck1Slot48.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot48)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot48);
                            }
                        }
                    }
                    if (deck1Slot49) {
                        if (deck1Slot49.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot49)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot49);
                            }
                        }
                    }
                    if (deck1Slot50) {
                        if (deck1Slot50.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot50)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot50);
                            }
                        }
                    }
                    if (deck1Slot51) {
                        if (deck1Slot51.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot51)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot51);
                            }
                        }
                    }
                    if (deck1Slot52) {
                        if (deck1Slot52.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot52)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot52);
                            }
                        }
                    }
                    if (deck1Slot53) {
                        if (deck1Slot53.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot53)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot53);
                            }
                        }
                    }
                    if (deck1Slot54) {
                        if (deck1Slot54.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot54)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot54);
                            }
                        }
                    }
                    if (deck1Slot55) {
                        if (deck1Slot55.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot55)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot55);
                            }
                        }
                    }
                } else if (editDeck1.Count == 60) {

                    if (deck1Slot1) {
                        if (deck1Slot1.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot1)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot1);
                            }
                        }
                    }
                    if (deck1Slot2) {
                        if (deck1Slot2.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot2)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot2);
                            }
                        }
                    }
                    if (deck1Slot3) {
                        if (deck1Slot3.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot3)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot3);
                            }
                        }
                    }
                    if (deck1Slot4) {
                        if (deck1Slot4.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot4)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot4);
                            }
                        }
                    }
                    if (deck1Slot5) {
                        if (deck1Slot5.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot5)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot5);
                            }
                        }
                    }
                    if (deck1Slot6) {
                        if (deck1Slot6.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot6)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot6);
                            }
                        }
                    }
                    if (deck1Slot7) {
                        if (deck1Slot7.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot7)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot7);
                            }
                        }
                    }
                    if (deck1Slot8) {
                        if (deck1Slot8.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot8)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot8);
                            }
                        }
                    }
                    if (deck1Slot9) {
                        if (deck1Slot9.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot9)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot9);
                            }
                        }
                    }
                    if (deck1Slot10) {
                        if (deck1Slot10.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot10)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot10);
                            }
                        }
                    }
                    if (deck1Slot11) {
                        if (deck1Slot11.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot11)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot11);
                            }
                        }
                    }
                    if (deck1Slot12) {
                        if (deck1Slot12.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot12)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot12);
                            }
                        }
                    }
                    if (deck1Slot13) {
                        if (deck1Slot13.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot13)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot13);
                            }
                        }
                    }
                    if (deck1Slot14) {
                        if (deck1Slot14.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot14)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot14);
                            }
                        }
                    }
                    if (deck1Slot15) {
                        if (deck1Slot15.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot15)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot15);
                            }
                        }
                    }
                    if (deck1Slot16) {
                        if (deck1Slot16.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot16)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot16);
                            }
                        }
                    }
                    if (deck1Slot17) {
                        if (deck1Slot17.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot17)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot17);
                            }
                        }
                    }
                    if (deck1Slot18) {
                        if (deck1Slot18.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot18)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot18);
                            }
                        }
                    }
                    if (deck1Slot19) {
                        if (deck1Slot19.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot19)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot19);
                            }
                        }
                    }
                    if (deck1Slot20) {
                        if (deck1Slot20.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot20)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot20);
                            }
                        }
                    }
                    if (deck1Slot21) {
                        if (deck1Slot21.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot21)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot21);
                            }
                        }
                    }
                    if (deck1Slot22) {
                        if (deck1Slot22.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot22)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot22);
                            }
                        }
                    }
                    if (deck1Slot23) {
                        if (deck1Slot23.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot23)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot23);
                            }
                        }
                    }
                    if (deck1Slot24) {
                        if (deck1Slot24.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot24)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot24);
                            }
                        }
                    }
                    if (deck1Slot25) {
                        if (deck1Slot25.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot25)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot25);
                            }
                        }
                    }
                    if (deck1Slot26) {
                        if (deck1Slot26.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot26)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot26);
                            }
                        }
                    }
                    if (deck1Slot27) {
                        if (deck1Slot27.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot27)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot27);
                            }
                        }
                    }
                    if (deck1Slot28) {
                        if (deck1Slot28.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot28)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot28);
                            }
                        }
                    }
                    if (deck1Slot29) {
                        if (deck1Slot29.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot29)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot29);
                            }
                        }
                    }
                    if (deck1Slot30) {
                        if (deck1Slot30.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot30)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot30);
                            }
                        }
                    }
                    if (deck1Slot31) {
                        if (deck1Slot31.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot31)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot31);
                            }
                        }
                    }
                    if (deck1Slot32) {
                        if (deck1Slot32.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot32)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot32);
                            }
                        }
                    }
                    if (deck1Slot33) {
                        if (deck1Slot33.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot33)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot33);
                            }
                        }
                    }
                    if (deck1Slot34) {
                        if (deck1Slot34.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot34)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot34);
                            }
                        }
                    }
                    if (deck1Slot35) {
                        if (deck1Slot35.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot35)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot35);
                            }
                        }
                    }
                    if (deck1Slot36) {
                        if (deck1Slot36.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot36)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot36);
                            }
                        }
                    }
                    if (deck1Slot37) {
                        if (deck1Slot37.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot37)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot37);
                            }
                        }
                    }
                    if (deck1Slot38) {
                        if (deck1Slot38.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot38)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot38);
                            }
                        }
                    }
                    if (deck1Slot39) {
                        if (deck1Slot39.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot39)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot39);
                            }
                        }
                    }
                    if (deck1Slot40) {
                        if (deck1Slot40.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot40)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot40);
                            }
                        }
                    }
                    if (deck1Slot41) {
                        if (deck1Slot41.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot41)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot41);
                            }
                        }
                    }
                    if (deck1Slot42) {
                        if (deck1Slot42.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot42)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot42);
                            }
                        }
                    }
                    if (deck1Slot43) {
                        if (deck1Slot43.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot43)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot43);
                            }
                        }
                    }
                    if (deck1Slot44) {
                        if (deck1Slot44.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot44)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot44);
                            }
                        }
                    }
                    if (deck1Slot45) {
                        if (deck1Slot45.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot45)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot45);
                            }
                        }
                    }
                    if (deck1Slot46) {
                        if (deck1Slot46.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot46)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot46);
                            }
                        }
                    }
                    if (deck1Slot47) {
                        if (deck1Slot47.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot47)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot47);
                            }
                        }
                    }
                    if (deck1Slot48) {
                        if (deck1Slot48.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot48)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot48);
                            }
                        }
                    }
                    if (deck1Slot49) {
                        if (deck1Slot49.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot49)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot49);
                            }
                        }
                    }
                    if (deck1Slot50) {
                        if (deck1Slot50.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot50)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot50);
                            }
                        }
                    }
                    if (deck1Slot51) {
                        if (deck1Slot51.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot51)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot51);
                            }
                        }
                    }
                    if (deck1Slot52) {
                        if (deck1Slot52.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot52)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot52);
                            }
                        }
                    }
                    if (deck1Slot53) {
                        if (deck1Slot53.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot53)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot53);
                            }
                        }
                    }
                    if (deck1Slot54) {
                        if (deck1Slot54.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot54)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot54);
                            }
                        }
                    }
                    if (deck1Slot55) {
                        if (deck1Slot55.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot55)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot55);
                            }
                        }
                    }
                    if (deck1Slot56) {
                        if (deck1Slot56.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot56)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot56);
                            }
                        }
                    }
                    if (deck1Slot57) {
                        if (deck1Slot57.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot57)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot57);
                            }
                        }
                    }
                    if (deck1Slot58) {
                        if (deck1Slot58.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot58)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot58);
                            }
                        }
                    }
                    if (deck1Slot59) {
                        if (deck1Slot59.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot59)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot59);
                            }
                        }
                    }
                    if (deck1Slot60) {
                        if (deck1Slot60.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints1.Contains(deck1Slot60)) {
                                DeckManager.deckManager.spawnPoints1.Add(deck1Slot60);
                            }
                        }
                    }

                }


            }

        }

        #endregion

        /** Convert the string references to stored cards in the binary file into 3D card game objects */

        void CardGenerator() {

            foreach (string cardReference in cardsDeck1) {

                if (cardReference == "instantiated1Card1") {
                    spawnPoint1 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card1, spawnPoint1, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card1";
                    card.AddComponent<OnDestroyCard1>();

                    spawnPointsDeck1.Remove(spawnPoint1);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card1a") {
                    spawnPoint1a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card1a, spawnPoint1a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card1a";
                    card.AddComponent<OnDestroyCard1a>();

                    spawnPointsDeck1.Remove(spawnPoint1a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card1b") {
                    spawnPoint1b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card1b, spawnPoint1b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card1b";
                    card.AddComponent<OnDestroyCard1b>();

                    spawnPointsDeck1.Remove(spawnPoint1b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card1c") {
                    spawnPoint1c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card1c, spawnPoint1c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card1c";
                    card.AddComponent<OnDestroyCard1c>();

                    spawnPointsDeck1.Remove(spawnPoint1c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card2") {
                    spawnPoint2 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card2, spawnPoint2, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card2";
                    card.AddComponent<OnDestroyCard2>();

                    spawnPointsDeck1.Remove(spawnPoint2);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card2a") {
                    spawnPoint2a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card2a, spawnPoint2a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card2a";
                    card.AddComponent<OnDestroyCard2a>();

                    spawnPointsDeck1.Remove(spawnPoint2a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card2b") {
                    spawnPoint2b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card2b, spawnPoint2b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card2b";
                    card.AddComponent<OnDestroyCard2b>();

                    spawnPointsDeck1.Remove(spawnPoint2b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card2c") {
                    spawnPoint2c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card2c, spawnPoint2c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card2c";
                    card.AddComponent<OnDestroyCard2c>();

                    spawnPointsDeck1.Remove(spawnPoint2c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card3") {
                    spawnPoint3 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card3, spawnPoint3, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card3";
                    card.AddComponent<OnDestroyCard3>();

                    spawnPointsDeck1.Remove(spawnPoint3);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card3a") {
                    spawnPoint3a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card3a, spawnPoint3a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card3a";
                    card.AddComponent<OnDestroyCard3a>();

                    spawnPointsDeck1.Remove(spawnPoint3a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card3b") {
                    spawnPoint3b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card3b, spawnPoint3b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card3b";
                    card.AddComponent<OnDestroyCard3b>();

                    spawnPointsDeck1.Remove(spawnPoint3b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card3c") {
                    spawnPoint3c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card3c, spawnPoint3c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card3c";
                    card.AddComponent<OnDestroyCard3c>();

                    spawnPointsDeck1.Remove(spawnPoint3c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card4") {
                    spawnPoint4 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card4, spawnPoint4, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card4";
                    card.AddComponent<OnDestroyCard4>();

                    spawnPointsDeck1.Remove(spawnPoint4);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card4a") {
                    spawnPoint4a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card4a, spawnPoint4a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card4a";
                    card.AddComponent<OnDestroyCard4a>();

                    spawnPointsDeck1.Remove(spawnPoint4a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card4b") {
                    spawnPoint4b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card4b, spawnPoint4b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card4b";
                    card.AddComponent<OnDestroyCard4b>();

                    spawnPointsDeck1.Remove(spawnPoint4b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card4c") {
                    spawnPoint4c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card4c, spawnPoint4c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card4c";
                    card.AddComponent<OnDestroyCard4c>();

                    spawnPointsDeck1.Remove(spawnPoint4c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card5") {
                    spawnPoint5 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card5, spawnPoint5, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card5";
                    card.AddComponent<OnDestroyCard5>();

                    spawnPointsDeck1.Remove(spawnPoint5);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card5a") {
                    spawnPoint5a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card5a, spawnPoint5a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card5a";
                    card.AddComponent<OnDestroyCard5a>();

                    spawnPointsDeck1.Remove(spawnPoint5a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card5b") {
                    spawnPoint5b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card5b, spawnPoint5b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card5b";
                    card.AddComponent<OnDestroyCard5b>();

                    spawnPointsDeck1.Remove(spawnPoint5b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card5c") {
                    spawnPoint5c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card5c, spawnPoint5c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card5c";
                    card.AddComponent<OnDestroyCard5c>();

                    spawnPointsDeck1.Remove(spawnPoint5c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card6") {
                    spawnPoint6 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card6, spawnPoint6, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card6";
                    card.AddComponent<OnDestroyCard6>();

                    spawnPointsDeck1.Remove(spawnPoint6);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card6a") {
                    spawnPoint6a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card6a, spawnPoint6a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card6a";
                    card.AddComponent<OnDestroyCard6a>();

                    spawnPointsDeck1.Remove(spawnPoint6a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card6b") {
                    spawnPoint6b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card6b, spawnPoint6b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card6b";
                    card.AddComponent<OnDestroyCard6b>();

                    spawnPointsDeck1.Remove(spawnPoint6b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card6c") {
                    spawnPoint6c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card6c, spawnPoint6c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card6c";
                    card.AddComponent<OnDestroyCard6c>();

                    spawnPointsDeck1.Remove(spawnPoint6c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card7") {
                    spawnPoint7 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card7, spawnPoint7, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card7";
                    card.AddComponent<OnDestroyCard7>();

                    spawnPointsDeck1.Remove(spawnPoint7);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card7a") {
                    spawnPoint7a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card7a, spawnPoint7a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card7a";
                    card.AddComponent<OnDestroyCard7a>();

                    spawnPointsDeck1.Remove(spawnPoint7a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card7b") {
                    spawnPoint7b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card7b, spawnPoint7b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card7b";
                    card.AddComponent<OnDestroyCard7b>();

                    spawnPointsDeck1.Remove(spawnPoint7b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card7c") {
                    spawnPoint7c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card7c, spawnPoint7c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card7c";
                    card.AddComponent<OnDestroyCard7c>();

                    spawnPointsDeck1.Remove(spawnPoint7c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card8") {
                    spawnPoint8 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card8, spawnPoint8, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card8";
                    card.AddComponent<OnDestroyCard8>();

                    spawnPointsDeck1.Remove(spawnPoint8);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card8a") {
                    spawnPoint8a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card8a, spawnPoint8a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card8a";
                    card.AddComponent<OnDestroyCard8a>();

                    spawnPointsDeck1.Remove(spawnPoint8a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card8b") {
                    spawnPoint8b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card8b, spawnPoint8b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card8b";
                    card.AddComponent<OnDestroyCard8b>();

                    spawnPointsDeck1.Remove(spawnPoint8b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card8c") {
                    spawnPoint8c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card8c, spawnPoint8c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card8c";
                    card.AddComponent<OnDestroyCard8c>();

                    spawnPointsDeck1.Remove(spawnPoint8c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card9") {
                    spawnPoint9 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card9, spawnPoint9, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card9";
                    card.AddComponent<OnDestroyCard9>();

                    spawnPointsDeck1.Remove(spawnPoint9);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card9a") {
                    spawnPoint9a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card9a, spawnPoint9a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card9a";
                    card.AddComponent<OnDestroyCard9a>();

                    spawnPointsDeck1.Remove(spawnPoint9a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card9b") {
                    spawnPoint9b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card9b, spawnPoint9b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card9b";
                    card.AddComponent<OnDestroyCard9b>();

                    spawnPointsDeck1.Remove(spawnPoint9b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card9c") {
                    spawnPoint9c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card9c, spawnPoint9c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card9c";
                    card.AddComponent<OnDestroyCard9c>();

                    spawnPointsDeck1.Remove(spawnPoint9c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card10") {
                    spawnPoint10 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card10, spawnPoint10, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card10";
                    card.AddComponent<OnDestroyCard10>();

                    spawnPointsDeck1.Remove(spawnPoint10);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card10a") {
                    spawnPoint10a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card10a, spawnPoint10a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card10a";
                    card.AddComponent<OnDestroyCard10a>();

                    spawnPointsDeck1.Remove(spawnPoint10a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card10b") {
                    spawnPoint10b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card10a, spawnPoint10b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card10b";
                    card.AddComponent<OnDestroyCard10b>();

                    spawnPointsDeck1.Remove(spawnPoint10b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card10c") {
                    spawnPoint10c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card10a, spawnPoint10c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card10c";
                    card.AddComponent<OnDestroyCard10c>();

                    spawnPointsDeck1.Remove(spawnPoint10c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card11") {
                    spawnPoint11 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card11, spawnPoint11, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card11";
                    card.AddComponent<OnDestroyCard11>();

                    spawnPointsDeck1.Remove(spawnPoint11);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card11a") {
                    spawnPoint11a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card11a, spawnPoint11a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card11a";
                    card.AddComponent<OnDestroyCard11a>();

                    spawnPointsDeck1.Remove(spawnPoint11a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card11b") {
                    spawnPoint11b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card11b, spawnPoint11b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card11b";
                    card.AddComponent<OnDestroyCard11b>();

                    spawnPointsDeck1.Remove(spawnPoint11b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card11c") {
                    spawnPoint11c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card11c, spawnPoint11c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card11c";
                    card.AddComponent<OnDestroyCard11c>();

                    spawnPointsDeck1.Remove(spawnPoint11c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card12") {
                    spawnPoint12 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card12, spawnPoint12, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card12";
                    card.AddComponent<OnDestroyCard12>();

                    spawnPointsDeck1.Remove(spawnPoint12);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card12a") {
                    spawnPoint12a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card12a, spawnPoint12a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card12a";
                    card.AddComponent<OnDestroyCard12a>();

                    spawnPointsDeck1.Remove(spawnPoint12a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card12b") {
                    spawnPoint12b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card12b, spawnPoint12b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card12b";
                    card.AddComponent<OnDestroyCard12b>();

                    spawnPointsDeck1.Remove(spawnPoint12b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card12c") {
                    spawnPoint12c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card12c, spawnPoint12c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card12c";
                    card.AddComponent<OnDestroyCard12c>();

                    spawnPointsDeck1.Remove(spawnPoint12c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card13") {
                    spawnPoint13 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card13, spawnPoint13, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card13";
                    card.AddComponent<OnDestroyCard13>();

                    spawnPointsDeck1.Remove(spawnPoint13);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card13a") {
                    spawnPoint13a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card13a, spawnPoint13a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card13a";
                    card.AddComponent<OnDestroyCard13a>();

                    spawnPointsDeck1.Remove(spawnPoint13a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card13b") {
                    spawnPoint13b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card13b, spawnPoint13b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card13b";
                    card.AddComponent<OnDestroyCard13b>();

                    spawnPointsDeck1.Remove(spawnPoint13b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card13c") {
                    spawnPoint13c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card13c, spawnPoint13c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card13c";
                    card.AddComponent<OnDestroyCard13c>();

                    spawnPointsDeck1.Remove(spawnPoint13c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card14") {
                    spawnPoint14 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card14, spawnPoint14, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card14";
                    card.AddComponent<OnDestroyCard14>();

                    spawnPointsDeck1.Remove(spawnPoint14);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card14a") {
                    spawnPoint14a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card14a, spawnPoint14a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card14a";
                    card.AddComponent<OnDestroyCard14a>();

                    spawnPointsDeck1.Remove(spawnPoint14a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card14b") {
                    spawnPoint14b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card14b, spawnPoint14b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card14b";
                    card.AddComponent<OnDestroyCard14b>();

                    spawnPointsDeck1.Remove(spawnPoint14b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card14c") {
                    spawnPoint14c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card14c, spawnPoint14c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card14c";
                    card.AddComponent<OnDestroyCard14c>();

                    spawnPointsDeck1.Remove(spawnPoint14c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card15") {
                    spawnPoint15 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card15, spawnPoint15, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card15";
                    card.AddComponent<OnDestroyCard15>();

                    spawnPointsDeck1.Remove(spawnPoint15);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card15a") {
                    spawnPoint15a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card15a, spawnPoint15a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card15a";
                    card.AddComponent<OnDestroyCard15a>();

                    spawnPointsDeck1.Remove(spawnPoint15a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card15b") {
                    spawnPoint15b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card15b, spawnPoint15b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card15b";
                    card.AddComponent<OnDestroyCard15b>();

                    spawnPointsDeck1.Remove(spawnPoint15b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card15c") {
                    spawnPoint15c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card15c, spawnPoint15c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card15c";
                    card.AddComponent<OnDestroyCard15c>();

                    spawnPointsDeck1.Remove(spawnPoint15c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card16") {
                    spawnPoint16 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card16, spawnPoint16, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card16";
                    card.AddComponent<OnDestroyCard16>();

                    spawnPointsDeck1.Remove(spawnPoint16);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card16a") {
                    spawnPoint16a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card16a, spawnPoint16a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card16a";
                    card.AddComponent<OnDestroyCard16a>();

                    spawnPointsDeck1.Remove(spawnPoint16a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card16b") {
                    spawnPoint16b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card16b, spawnPoint16b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card16b";
                    card.AddComponent<OnDestroyCard16b>();

                    spawnPointsDeck1.Remove(spawnPoint16b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card16c") {
                    spawnPoint16c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card16c, spawnPoint16c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card16c";
                    card.AddComponent<OnDestroyCard16c>();

                    spawnPointsDeck1.Remove(spawnPoint16c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card17") {
                    spawnPoint17 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card17, spawnPoint17, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card17";
                    card.AddComponent<OnDestroyCard17>();

                    spawnPointsDeck1.Remove(spawnPoint17);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card17a") {
                    spawnPoint17a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card17a, spawnPoint17a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card17a";
                    card.AddComponent<OnDestroyCard17a>();

                    spawnPointsDeck1.Remove(spawnPoint17a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card17b") {
                    spawnPoint17b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card17b, spawnPoint17b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card17b";
                    card.AddComponent<OnDestroyCard17b>();

                    spawnPointsDeck1.Remove(spawnPoint17b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card17c") {
                    spawnPoint17c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card17c, spawnPoint17c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card17c";
                    card.AddComponent<OnDestroyCard17c>();

                    spawnPointsDeck1.Remove(spawnPoint17c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card18") {
                    spawnPoint18 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card18, spawnPoint18, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card18";
                    card.AddComponent<OnDestroyCard18>();

                    spawnPointsDeck1.Remove(spawnPoint18);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card18a") {
                    spawnPoint18a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card18a, spawnPoint18a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card18a";
                    card.AddComponent<OnDestroyCard18a>();

                    spawnPointsDeck1.Remove(spawnPoint18a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card18b") {
                    spawnPoint18b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card18b, spawnPoint18b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card18b";
                    card.AddComponent<OnDestroyCard18b>();

                    spawnPointsDeck1.Remove(spawnPoint18b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card18c") {
                    spawnPoint18c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card18c, spawnPoint18c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card18c";
                    card.AddComponent<OnDestroyCard18c>();

                    spawnPointsDeck1.Remove(spawnPoint18c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card19") {
                    spawnPoint19 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card19, spawnPoint19, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card19";
                    card.AddComponent<OnDestroyCard19>();

                    spawnPointsDeck1.Remove(spawnPoint19);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card19a") {
                    spawnPoint19a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card19a, spawnPoint19a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card19a";
                    card.AddComponent<OnDestroyCard19a>();

                    spawnPointsDeck1.Remove(spawnPoint19a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card19b") {
                    spawnPoint19b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card19b, spawnPoint19b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card19b";
                    card.AddComponent<OnDestroyCard19b>();

                    spawnPointsDeck1.Remove(spawnPoint19b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card19c") {
                    spawnPoint19c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card19c, spawnPoint19c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card19c";
                    card.AddComponent<OnDestroyCard19c>();

                    spawnPointsDeck1.Remove(spawnPoint19c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card20") {
                    spawnPoint20 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card20, spawnPoint20, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card20";
                    card.AddComponent<OnDestroyCard20>();

                    spawnPointsDeck1.Remove(spawnPoint20);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card20a") {
                    spawnPoint20a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card20a, spawnPoint20a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card20a";
                    card.AddComponent<OnDestroyCard20a>();

                    spawnPointsDeck1.Remove(spawnPoint20a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card20b") {
                    spawnPoint20b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card20b, spawnPoint20b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card20b";
                    card.AddComponent<OnDestroyCard20b>();

                    spawnPointsDeck1.Remove(spawnPoint20b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card20c") {
                    spawnPoint20c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card20c, spawnPoint20c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card20c";
                    card.AddComponent<OnDestroyCard20c>();

                    spawnPointsDeck1.Remove(spawnPoint20c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card21") {
                    spawnPoint21 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card21, spawnPoint21, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card21";
                    card.AddComponent<OnDestroyCard21>();

                    spawnPointsDeck1.Remove(spawnPoint21);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card21a") {
                    spawnPoint21a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card21a, spawnPoint21a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card21a";
                    card.AddComponent<OnDestroyCard21a>();

                    spawnPointsDeck1.Remove(spawnPoint21a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card21b") {
                    spawnPoint21b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card21b, spawnPoint21b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card21b";
                    card.AddComponent<OnDestroyCard21b>();

                    spawnPointsDeck1.Remove(spawnPoint21b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card21c") {
                    spawnPoint21c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card21c, spawnPoint21c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card21c";
                    card.AddComponent<OnDestroyCard21c>();

                    spawnPointsDeck1.Remove(spawnPoint21c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card22") {
                    spawnPoint22 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card22, spawnPoint22, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card22";
                    card.AddComponent<OnDestroyCard22>();

                    spawnPointsDeck1.Remove(spawnPoint22);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card22a") {
                    spawnPoint22a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card22a, spawnPoint22a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card22a";
                    card.AddComponent<OnDestroyCard22a>();

                    spawnPointsDeck1.Remove(spawnPoint22a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card22b") {
                    spawnPoint22b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card22b, spawnPoint22b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card22b";
                    card.AddComponent<OnDestroyCard22b>();

                    spawnPointsDeck1.Remove(spawnPoint22b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card22c") {
                    spawnPoint22c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card22c, spawnPoint22c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card22c";
                    card.AddComponent<OnDestroyCard22c>();

                    spawnPointsDeck1.Remove(spawnPoint22c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card23") {
                    spawnPoint23 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card23, spawnPoint23, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card23";
                    card.AddComponent<OnDestroyCard23>();

                    spawnPointsDeck1.Remove(spawnPoint23);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card23a") {
                    spawnPoint23a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card23a, spawnPoint23a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card23a";
                    card.AddComponent<OnDestroyCard23a>();

                    spawnPointsDeck1.Remove(spawnPoint23a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card23b") {
                    spawnPoint23b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card23b, spawnPoint23b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card23b";
                    card.AddComponent<OnDestroyCard23b>();

                    spawnPointsDeck1.Remove(spawnPoint23b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card23c") {
                    spawnPoint23c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card23c, spawnPoint23c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card23c";
                    card.AddComponent<OnDestroyCard23c>();

                    spawnPointsDeck1.Remove(spawnPoint23c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card24") {
                    spawnPoint24 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card24, spawnPoint24, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card24";
                    card.AddComponent<OnDestroyCard24>();

                    spawnPointsDeck1.Remove(spawnPoint24);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card24a") {
                    spawnPoint24a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card24a, spawnPoint24a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card24a";
                    card.AddComponent<OnDestroyCard24a>();

                    spawnPointsDeck1.Remove(spawnPoint24a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card24b") {
                    spawnPoint24b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card24b, spawnPoint24b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card24b";
                    card.AddComponent<OnDestroyCard24b>();

                    spawnPointsDeck1.Remove(spawnPoint24b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card24c") {
                    spawnPoint24c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card24c, spawnPoint24c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card24c";
                    card.AddComponent<OnDestroyCard24c>();

                    spawnPointsDeck1.Remove(spawnPoint24c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card25") {
                    spawnPoint25 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card25, spawnPoint25, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card25";
                    card.AddComponent<OnDestroyCard25>();

                    spawnPointsDeck1.Remove(spawnPoint25);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card25a") {
                    spawnPoint25a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card25a, spawnPoint25a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card25a";
                    card.AddComponent<OnDestroyCard25a>();

                    spawnPointsDeck1.Remove(spawnPoint25a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card25b") {
                    spawnPoint25b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card25b, spawnPoint25b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card25b";
                    card.AddComponent<OnDestroyCard25b>();

                    spawnPointsDeck1.Remove(spawnPoint25b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card25c") {
                    spawnPoint25c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card25c, spawnPoint25c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card25c";
                    card.AddComponent<OnDestroyCard25c>();

                    spawnPointsDeck1.Remove(spawnPoint25c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card26") {
                    spawnPoint26 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card26, spawnPoint26, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card26";
                    card.AddComponent<OnDestroyCard26>();

                    spawnPointsDeck1.Remove(spawnPoint26);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card26a") {
                    spawnPoint26a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card26a, spawnPoint26a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card26a";
                    card.AddComponent<OnDestroyCard26a>();

                    spawnPointsDeck1.Remove(spawnPoint26a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card26b") {
                    spawnPoint26b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card26b, spawnPoint26b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card26b";
                    card.AddComponent<OnDestroyCard26b>();

                    spawnPointsDeck1.Remove(spawnPoint26b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card26c") {
                    spawnPoint26c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card26c, spawnPoint26c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card26c";
                    card.AddComponent<OnDestroyCard26c>();

                    spawnPointsDeck1.Remove(spawnPoint26c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card27") {
                    spawnPoint27 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card27, spawnPoint27, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card27";
                    card.AddComponent<OnDestroyCard27>();

                    spawnPointsDeck1.Remove(spawnPoint27);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card27a") {
                    spawnPoint27a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card27a, spawnPoint27a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card27a";
                    card.AddComponent<OnDestroyCard27a>();

                    spawnPointsDeck1.Remove(spawnPoint27a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card27b") {
                    spawnPoint27b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card27b, spawnPoint27b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card27b";
                    card.AddComponent<OnDestroyCard27b>();

                    spawnPointsDeck1.Remove(spawnPoint27b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card27c") {
                    spawnPoint27c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card27c, spawnPoint27c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card27c";
                    card.AddComponent<OnDestroyCard27c>();

                    spawnPointsDeck1.Remove(spawnPoint27c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card28") {
                    spawnPoint28 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card28, spawnPoint28, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card28";
                    card.AddComponent<OnDestroyCard28>();

                    spawnPointsDeck1.Remove(spawnPoint28);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card28a") {
                    spawnPoint28a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card28a, spawnPoint28a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card28a";
                    card.AddComponent<OnDestroyCard28a>();

                    spawnPointsDeck1.Remove(spawnPoint28a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card28b") {
                    spawnPoint28b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card28b, spawnPoint28b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card28b";
                    card.AddComponent<OnDestroyCard28b>();

                    spawnPointsDeck1.Remove(spawnPoint28b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card28c") {
                    spawnPoint28c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card28c, spawnPoint28c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card28c";
                    card.AddComponent<OnDestroyCard28c>();

                    spawnPointsDeck1.Remove(spawnPoint28c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card29") {
                    spawnPoint29 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card29, spawnPoint29, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card29";
                    card.AddComponent<OnDestroyCard29>();

                    spawnPointsDeck1.Remove(spawnPoint29);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card29a") {
                    spawnPoint29a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card29a, spawnPoint29a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card29a";
                    card.AddComponent<OnDestroyCard29a>();

                    spawnPointsDeck1.Remove(spawnPoint29a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card29b") {
                    spawnPoint29b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card29b, spawnPoint29b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card29b";
                    card.AddComponent<OnDestroyCard29b>();

                    spawnPointsDeck1.Remove(spawnPoint29b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card29c") {
                    spawnPoint29c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card29c, spawnPoint29c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card29c";
                    card.AddComponent<OnDestroyCard29c>();

                    spawnPointsDeck1.Remove(spawnPoint29c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card30") {
                    spawnPoint30 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card30, spawnPoint30, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card30";
                    card.AddComponent<OnDestroyCard30>();

                    spawnPointsDeck1.Remove(spawnPoint30);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card30a") {
                    spawnPoint30a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card30a, spawnPoint30a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card30a";
                    card.AddComponent<OnDestroyCard30a>();

                    spawnPointsDeck1.Remove(spawnPoint30a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card30b") {
                    spawnPoint30b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card30b, spawnPoint30b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card30b";
                    card.AddComponent<OnDestroyCard30b>();

                    spawnPointsDeck1.Remove(spawnPoint30b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card30c") {
                    spawnPoint30c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card30c, spawnPoint30c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card30c";
                    card.AddComponent<OnDestroyCard30c>();

                    spawnPointsDeck1.Remove(spawnPoint30c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card31") {
                    spawnPoint31 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card31, spawnPoint31, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card31";
                    card.AddComponent<OnDestroyCard31>();

                    spawnPointsDeck1.Remove(spawnPoint31);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card31a") {
                    spawnPoint31a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card31a, spawnPoint31a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card31a";
                    card.AddComponent<OnDestroyCard31a>();

                    spawnPointsDeck1.Remove(spawnPoint31a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card31b") {
                    spawnPoint31b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card31b, spawnPoint31b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card31b";
                    card.AddComponent<OnDestroyCard31b>();

                    spawnPointsDeck1.Remove(spawnPoint31b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card31c") {
                    spawnPoint31c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card31c, spawnPoint31c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card31c";
                    card.AddComponent<OnDestroyCard31c>();

                    spawnPointsDeck1.Remove(spawnPoint31c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card32") {
                    spawnPoint32 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card32, spawnPoint32, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card32";
                    card.AddComponent<OnDestroyCard32>();

                    spawnPointsDeck1.Remove(spawnPoint32);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card32a") {
                    spawnPoint32a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card32a, spawnPoint32a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card32a";
                    card.AddComponent<OnDestroyCard32a>();

                    spawnPointsDeck1.Remove(spawnPoint32a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card32b") {
                    spawnPoint32b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card32b, spawnPoint32b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card32b";
                    card.AddComponent<OnDestroyCard32b>();

                    spawnPointsDeck1.Remove(spawnPoint32b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card32c") {
                    spawnPoint32c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card32c, spawnPoint32c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card32c";
                    card.AddComponent<OnDestroyCard32c>();

                    spawnPointsDeck1.Remove(spawnPoint32c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card33") {
                    spawnPoint33 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card33, spawnPoint33, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card33";
                    card.AddComponent<OnDestroyCard33>();

                    spawnPointsDeck1.Remove(spawnPoint33);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card33a") {
                    spawnPoint33a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card33a, spawnPoint33a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card33a";
                    card.AddComponent<OnDestroyCard33a>();

                    spawnPointsDeck1.Remove(spawnPoint33a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card33b") {
                    spawnPoint33b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card33b, spawnPoint33b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card33b";
                    card.AddComponent<OnDestroyCard33b>();

                    spawnPointsDeck1.Remove(spawnPoint33b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card33c") {
                    spawnPoint33c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card33c, spawnPoint33c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card33c";
                    card.AddComponent<OnDestroyCard33c>();

                    spawnPointsDeck1.Remove(spawnPoint33c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card34") {
                    spawnPoint34 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card34, spawnPoint34, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card34";
                    card.AddComponent<OnDestroyCard34>();

                    spawnPointsDeck1.Remove(spawnPoint34);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card34a") {
                    spawnPoint34a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card34a, spawnPoint34a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card34a";
                    card.AddComponent<OnDestroyCard34a>();

                    spawnPointsDeck1.Remove(spawnPoint34a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card34b") {
                    spawnPoint34b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card34b, spawnPoint34b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card34b";
                    card.AddComponent<OnDestroyCard34b>();

                    spawnPointsDeck1.Remove(spawnPoint34b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card34c") {
                    spawnPoint34c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card34c, spawnPoint34c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card34c";
                    card.AddComponent<OnDestroyCard34c>();

                    spawnPointsDeck1.Remove(spawnPoint34c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card35") {
                    spawnPoint35 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card35, spawnPoint35, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card35";
                    card.AddComponent<OnDestroyCard35>();

                    spawnPointsDeck1.Remove(spawnPoint35);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card35a") {
                    spawnPoint35a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card35a, spawnPoint35a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card35a";
                    card.AddComponent<OnDestroyCard35a>();

                    spawnPointsDeck1.Remove(spawnPoint35a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card35b") {
                    spawnPoint35b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card35b, spawnPoint35b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card35b";
                    card.AddComponent<OnDestroyCard35b>();

                    spawnPointsDeck1.Remove(spawnPoint35b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card35c") {
                    spawnPoint35c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card35c, spawnPoint35c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card35c";
                    card.AddComponent<OnDestroyCard35c>();

                    spawnPointsDeck1.Remove(spawnPoint35c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card36") {
                    spawnPoint36 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card36, spawnPoint36, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card36";
                    card.AddComponent<OnDestroyCard36>();

                    spawnPointsDeck1.Remove(spawnPoint36);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card36a") {
                    spawnPoint36a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card36a, spawnPoint36a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card36a";
                    card.AddComponent<OnDestroyCard36a>();

                    spawnPointsDeck1.Remove(spawnPoint36a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card36b") {
                    spawnPoint36b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card36b, spawnPoint36b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card36b";
                    card.AddComponent<OnDestroyCard36b>();

                    spawnPointsDeck1.Remove(spawnPoint36b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card36c") {
                    spawnPoint36c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card36c, spawnPoint36c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card36c";
                    card.AddComponent<OnDestroyCard36c>();

                    spawnPointsDeck1.Remove(spawnPoint36c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card37") {
                    spawnPoint37 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card37, spawnPoint37, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card37";
                    card.AddComponent<OnDestroyCard37>();

                    spawnPointsDeck1.Remove(spawnPoint37);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card37a") {
                    spawnPoint37a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card37a, spawnPoint37a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card37a";
                    card.AddComponent<OnDestroyCard37a>();

                    spawnPointsDeck1.Remove(spawnPoint37a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card37b") {
                    spawnPoint37b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card37b, spawnPoint37b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card37b";
                    card.AddComponent<OnDestroyCard37b>();

                    spawnPointsDeck1.Remove(spawnPoint37b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card37c") {
                    spawnPoint37c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card37c, spawnPoint37c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card37c";
                    card.AddComponent<OnDestroyCard37c>();

                    spawnPointsDeck1.Remove(spawnPoint37c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card38") {
                    spawnPoint38 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card38, spawnPoint38, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card38";
                    card.AddComponent<OnDestroyCard38>();

                    spawnPointsDeck1.Remove(spawnPoint38);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card38a") {
                    spawnPoint38a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card38a, spawnPoint38a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card38a";
                    card.AddComponent<OnDestroyCard38a>();

                    spawnPointsDeck1.Remove(spawnPoint38a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card38b") {
                    spawnPoint38b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card38b, spawnPoint38b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card38b";
                    card.AddComponent<OnDestroyCard38b>();

                    spawnPointsDeck1.Remove(spawnPoint38b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card38c") {
                    spawnPoint38c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card38c, spawnPoint38c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card38c";
                    card.AddComponent<OnDestroyCard38c>();

                    spawnPointsDeck1.Remove(spawnPoint38c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card39") {
                    spawnPoint39 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card39, spawnPoint39, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card39";
                    card.AddComponent<OnDestroyCard39>();

                    spawnPointsDeck1.Remove(spawnPoint39);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card39a") {
                    spawnPoint39a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card39a, spawnPoint39a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card39a";
                    card.AddComponent<OnDestroyCard39a>();

                    spawnPointsDeck1.Remove(spawnPoint39a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card39b") {
                    spawnPoint39b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card39b, spawnPoint39b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card39b";
                    card.AddComponent<OnDestroyCard39b>();

                    spawnPointsDeck1.Remove(spawnPoint39b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card39c") {
                    spawnPoint39c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card39c, spawnPoint39c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card39c";
                    card.AddComponent<OnDestroyCard39c>();

                    spawnPointsDeck1.Remove(spawnPoint39c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card40") {
                    spawnPoint40 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card40, spawnPoint40, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card40";
                    card.AddComponent<OnDestroyCard40>();

                    spawnPointsDeck1.Remove(spawnPoint40);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card40a") {
                    spawnPoint40a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card40a, spawnPoint40a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card40a";
                    card.AddComponent<OnDestroyCard40a>();

                    spawnPointsDeck1.Remove(spawnPoint40a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card40b") {
                    spawnPoint40b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card40b, spawnPoint40b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card40b";
                    card.AddComponent<OnDestroyCard40b>();

                    spawnPointsDeck1.Remove(spawnPoint40b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card40c") {
                    spawnPoint40c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card40c, spawnPoint40c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card40c";
                    card.AddComponent<OnDestroyCard40c>();

                    spawnPointsDeck1.Remove(spawnPoint40c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card41") {
                    spawnPoint41 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card41, spawnPoint41, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card41";
                    card.AddComponent<OnDestroyCard41>();

                    spawnPointsDeck1.Remove(spawnPoint41);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card41a") {
                    spawnPoint41a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card41a, spawnPoint41a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card41a";
                    card.AddComponent<OnDestroyCard41a>();

                    spawnPointsDeck1.Remove(spawnPoint41a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card41b") {
                    spawnPoint41b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card41b, spawnPoint41b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card41b";
                    card.AddComponent<OnDestroyCard41b>();

                    spawnPointsDeck1.Remove(spawnPoint41b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card41c") {
                    spawnPoint41c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card41c, spawnPoint41c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card41c";
                    card.AddComponent<OnDestroyCard41c>();

                    spawnPointsDeck1.Remove(spawnPoint41c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card42") {
                    spawnPoint42 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card42, spawnPoint42, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card42";
                    card.AddComponent<OnDestroyCard42>();

                    spawnPointsDeck1.Remove(spawnPoint42);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card42a") {
                    spawnPoint42a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card42a, spawnPoint42a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card42a";
                    card.AddComponent<OnDestroyCard42a>();

                    spawnPointsDeck1.Remove(spawnPoint42a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card42b") {
                    spawnPoint42b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card42b, spawnPoint42b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card42b";
                    card.AddComponent<OnDestroyCard42b>();

                    spawnPointsDeck1.Remove(spawnPoint42b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card42c") {
                    spawnPoint42c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card42c, spawnPoint42c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card42c";
                    card.AddComponent<OnDestroyCard42c>();

                    spawnPointsDeck1.Remove(spawnPoint42c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card43") {
                    spawnPoint43 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card43, spawnPoint43, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card43";
                    card.AddComponent<OnDestroyCard43>();

                    spawnPointsDeck1.Remove(spawnPoint43);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card43a") {
                    spawnPoint43a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card43a, spawnPoint43a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card43a";
                    card.AddComponent<OnDestroyCard43a>();

                    spawnPointsDeck1.Remove(spawnPoint43a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card43b") {
                    spawnPoint43b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card43b, spawnPoint43b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card43b";
                    card.AddComponent<OnDestroyCard43b>();

                    spawnPointsDeck1.Remove(spawnPoint43b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card43c") {
                    spawnPoint43c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card43c, spawnPoint43c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card43c";
                    card.AddComponent<OnDestroyCard43c>();

                    spawnPointsDeck1.Remove(spawnPoint43c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card44") {
                    spawnPoint44 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card44, spawnPoint44, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card44";
                    card.AddComponent<OnDestroyCard44>();

                    spawnPointsDeck1.Remove(spawnPoint44);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card44a") {
                    spawnPoint44a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card44a, spawnPoint44a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card44a";
                    card.AddComponent<OnDestroyCard44a>();

                    spawnPointsDeck1.Remove(spawnPoint44a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card44b") {
                    spawnPoint44b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card44b, spawnPoint44b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card44b";
                    card.AddComponent<OnDestroyCard44b>();

                    spawnPointsDeck1.Remove(spawnPoint44b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card44c") {
                    spawnPoint44c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card44c, spawnPoint44c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card44c";
                    card.AddComponent<OnDestroyCard44c>();

                    spawnPointsDeck1.Remove(spawnPoint44c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card45") {
                    spawnPoint45 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card45, spawnPoint45, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card45";
                    card.AddComponent<OnDestroyCard45>();

                    spawnPointsDeck1.Remove(spawnPoint45);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card45a") {
                    spawnPoint45a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card45a, spawnPoint45a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card45a";
                    card.AddComponent<OnDestroyCard45a>();

                    spawnPointsDeck1.Remove(spawnPoint45a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card45b") {
                    spawnPoint45b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card45b, spawnPoint45b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card45b";
                    card.AddComponent<OnDestroyCard45b>();

                    spawnPointsDeck1.Remove(spawnPoint45b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card45c") {
                    spawnPoint45c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card45c, spawnPoint45c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card45c";
                    card.AddComponent<OnDestroyCard45c>();

                    spawnPointsDeck1.Remove(spawnPoint45c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card46") {
                    spawnPoint46 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card46, spawnPoint46, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card46";
                    card.AddComponent<OnDestroyCard46>();

                    spawnPointsDeck1.Remove(spawnPoint46);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card46a") {
                    spawnPoint46a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card46a, spawnPoint46a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card46a";
                    card.AddComponent<OnDestroyCard46a>();

                    spawnPointsDeck1.Remove(spawnPoint46a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card46b") {
                    spawnPoint46b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card46b, spawnPoint46b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card46b";
                    card.AddComponent<OnDestroyCard46b>();

                    spawnPointsDeck1.Remove(spawnPoint46b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card46c") {
                    spawnPoint46c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card46c, spawnPoint46c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card46c";
                    card.AddComponent<OnDestroyCard46c>();

                    spawnPointsDeck1.Remove(spawnPoint46c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card47") {
                    spawnPoint47 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card47, spawnPoint47, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card47";
                    card.AddComponent<OnDestroyCard47>();

                    spawnPointsDeck1.Remove(spawnPoint47);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card47a") {
                    spawnPoint47a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card47a, spawnPoint47a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card47a";
                    card.AddComponent<OnDestroyCard47a>();

                    spawnPointsDeck1.Remove(spawnPoint47a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card47b") {
                    spawnPoint47b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card47b, spawnPoint47b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card47b";
                    card.AddComponent<OnDestroyCard47b>();

                    spawnPointsDeck1.Remove(spawnPoint47b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card47c") {
                    spawnPoint47c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card47c, spawnPoint47c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card47c";
                    card.AddComponent<OnDestroyCard47c>();

                    spawnPointsDeck1.Remove(spawnPoint47c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card48") {
                    spawnPoint48 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card48, spawnPoint48, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card48";
                    card.AddComponent<OnDestroyCard48>();

                    spawnPointsDeck1.Remove(spawnPoint48);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card48a") {
                    spawnPoint48a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card48a, spawnPoint48a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card48a";
                    card.AddComponent<OnDestroyCard48a>();

                    spawnPointsDeck1.Remove(spawnPoint48a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card48b") {
                    spawnPoint48b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card48b, spawnPoint48b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card48b";
                    card.AddComponent<OnDestroyCard48b>();

                    spawnPointsDeck1.Remove(spawnPoint48b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card48c") {
                    spawnPoint48c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card48c, spawnPoint48c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card48c";
                    card.AddComponent<OnDestroyCard48c>();

                    spawnPointsDeck1.Remove(spawnPoint48c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card49") {
                    spawnPoint49 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card49, spawnPoint49, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card49";
                    card.AddComponent<OnDestroyCard49>();

                    spawnPointsDeck1.Remove(spawnPoint49);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card49a") {
                    spawnPoint49a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card49a, spawnPoint49a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card49a";
                    card.AddComponent<OnDestroyCard49a>();

                    spawnPointsDeck1.Remove(spawnPoint49a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card49b") {
                    spawnPoint49b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card49b, spawnPoint49b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card49b";
                    card.AddComponent<OnDestroyCard49b>();

                    spawnPointsDeck1.Remove(spawnPoint49b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card49c") {
                    spawnPoint49c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card49c, spawnPoint49c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card49c";
                    card.AddComponent<OnDestroyCard49c>();

                    spawnPointsDeck1.Remove(spawnPoint49c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card50") {
                    spawnPoint50 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card50, spawnPoint50, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card50";
                    card.AddComponent<OnDestroyCard50>();

                    spawnPointsDeck1.Remove(spawnPoint50);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card50a") {
                    spawnPoint50a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card50a, spawnPoint50a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card50a";
                    card.AddComponent<OnDestroyCard50a>();

                    spawnPointsDeck1.Remove(spawnPoint50a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card50b") {
                    spawnPoint50b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card50b, spawnPoint50b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card50b";
                    card.AddComponent<OnDestroyCard50b>();

                    spawnPointsDeck1.Remove(spawnPoint50b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card50c") {
                    spawnPoint50c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card50c, spawnPoint50c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card50c";
                    card.AddComponent<OnDestroyCard50c>();

                    spawnPointsDeck1.Remove(spawnPoint50c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card51") {
                    spawnPoint51 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card51, spawnPoint51, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card51";
                    card.AddComponent<OnDestroyCard51>();

                    spawnPointsDeck1.Remove(spawnPoint51);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card51a") {
                    spawnPoint51a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card51a, spawnPoint51a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card51a";
                    card.AddComponent<OnDestroyCard51a>();

                    spawnPointsDeck1.Remove(spawnPoint51a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card51b") {
                    spawnPoint51b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card51b, spawnPoint51b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card51b";
                    card.AddComponent<OnDestroyCard51b>();

                    spawnPointsDeck1.Remove(spawnPoint51b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card51c") {
                    spawnPoint51c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card51c, spawnPoint51c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card51c";
                    card.AddComponent<OnDestroyCard51c>();

                    spawnPointsDeck1.Remove(spawnPoint51c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card52") {
                    spawnPoint52 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card52, spawnPoint52, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card52";
                    card.AddComponent<OnDestroyCard52>();

                    spawnPointsDeck1.Remove(spawnPoint52);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card52a") {
                    spawnPoint52a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card52a, spawnPoint52a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card52a";
                    card.AddComponent<OnDestroyCard52a>();

                    spawnPointsDeck1.Remove(spawnPoint52a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card52b") {
                    spawnPoint52b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card52b, spawnPoint52b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card52b";
                    card.AddComponent<OnDestroyCard52b>();

                    spawnPointsDeck1.Remove(spawnPoint52b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card52c") {
                    spawnPoint52c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card52c, spawnPoint52c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card52c";
                    card.AddComponent<OnDestroyCard52c>();

                    spawnPointsDeck1.Remove(spawnPoint52c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card53") {
                    spawnPoint53 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card53, spawnPoint53, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card53";
                    card.AddComponent<OnDestroyCard53>();

                    spawnPointsDeck1.Remove(spawnPoint53);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card53a") {
                    spawnPoint53a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card53a, spawnPoint53a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card53a";
                    card.AddComponent<OnDestroyCard53a>();

                    spawnPointsDeck1.Remove(spawnPoint53a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card53b") {
                    spawnPoint53b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card53b, spawnPoint53b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card53b";
                    card.AddComponent<OnDestroyCard53b>();

                    spawnPointsDeck1.Remove(spawnPoint53b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card53c") {
                    spawnPoint53c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card53c, spawnPoint53c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card53c";
                    card.AddComponent<OnDestroyCard53c>();

                    spawnPointsDeck1.Remove(spawnPoint53c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card54") {
                    spawnPoint54 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card54, spawnPoint54, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card54";
                    card.AddComponent<OnDestroyCard54>();

                    spawnPointsDeck1.Remove(spawnPoint54);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card54a") {
                    spawnPoint54a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card54a, spawnPoint54a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card54a";
                    card.AddComponent<OnDestroyCard54a>();

                    spawnPointsDeck1.Remove(spawnPoint54a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card54b") {
                    spawnPoint54b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card54b, spawnPoint54b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card54b";
                    card.AddComponent<OnDestroyCard54b>();

                    spawnPointsDeck1.Remove(spawnPoint54b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card54c") {
                    spawnPoint54c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card54c, spawnPoint54c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card54c";
                    card.AddComponent<OnDestroyCard54c>();

                    spawnPointsDeck1.Remove(spawnPoint54c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card55") {
                    spawnPoint55 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card55, spawnPoint55, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card55";
                    card.AddComponent<OnDestroyCard55>();

                    spawnPointsDeck1.Remove(spawnPoint55);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card55a") {
                    spawnPoint55a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card55a, spawnPoint55a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card55a";
                    card.AddComponent<OnDestroyCard55a>();

                    spawnPointsDeck1.Remove(spawnPoint55a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card55b") {
                    spawnPoint55b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card55b, spawnPoint55b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card55b";
                    card.AddComponent<OnDestroyCard55b>();

                    spawnPointsDeck1.Remove(spawnPoint55b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card55c") {
                    spawnPoint55c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card55c, spawnPoint55c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card55c";
                    card.AddComponent<OnDestroyCard55c>();

                    spawnPointsDeck1.Remove(spawnPoint55c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card56") {
                    spawnPoint56 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card56, spawnPoint56, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card56";
                    card.AddComponent<OnDestroyCard56>();

                    spawnPointsDeck1.Remove(spawnPoint56);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card56a") {
                    spawnPoint56a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card56a, spawnPoint56a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card56a";
                    card.AddComponent<OnDestroyCard56a>();

                    spawnPointsDeck1.Remove(spawnPoint56a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card56b") {
                    spawnPoint56b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card56b, spawnPoint56b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card56b";
                    card.AddComponent<OnDestroyCard56b>();

                    spawnPointsDeck1.Remove(spawnPoint56b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card56c") {
                    spawnPoint56c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card56c, spawnPoint56c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card56c";
                    card.AddComponent<OnDestroyCard56c>();

                    spawnPointsDeck1.Remove(spawnPoint56c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card57") {
                    spawnPoint57 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card57, spawnPoint57, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card57";
                    card.AddComponent<OnDestroyCard57>();

                    spawnPointsDeck1.Remove(spawnPoint57);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card57a") {
                    spawnPoint57a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card57a, spawnPoint57a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card57a";
                    card.AddComponent<OnDestroyCard57a>();

                    spawnPointsDeck1.Remove(spawnPoint57a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card57b") {
                    spawnPoint57b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card57b, spawnPoint57b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card57b";
                    card.AddComponent<OnDestroyCard57b>();

                    spawnPointsDeck1.Remove(spawnPoint57b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card57c") {
                    spawnPoint57c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card57c, spawnPoint57c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card57c";
                    card.AddComponent<OnDestroyCard57c>();

                    spawnPointsDeck1.Remove(spawnPoint57c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card58") {
                    spawnPoint58 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card58, spawnPoint58, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card58";
                    card.AddComponent<OnDestroyCard58>();

                    spawnPointsDeck1.Remove(spawnPoint58);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card58a") {
                    spawnPoint58a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card58a, spawnPoint58a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card58a";
                    card.AddComponent<OnDestroyCard58a>();

                    spawnPointsDeck1.Remove(spawnPoint58a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card58b") {
                    spawnPoint58b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card58b, spawnPoint58b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card58b";
                    card.AddComponent<OnDestroyCard58b>();

                    spawnPointsDeck1.Remove(spawnPoint58b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card58c") {
                    spawnPoint58c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card58c, spawnPoint58c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card58c";
                    card.AddComponent<OnDestroyCard58c>();

                    spawnPointsDeck1.Remove(spawnPoint58c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card59") {
                    spawnPoint59 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card59, spawnPoint59, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card59";
                    card.AddComponent<OnDestroyCard59>();

                    spawnPointsDeck1.Remove(spawnPoint59);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card59a") {
                    spawnPoint59a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card59a, spawnPoint59a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card59a";
                    card.AddComponent<OnDestroyCard59a>();

                    spawnPointsDeck1.Remove(spawnPoint59a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card59b") {
                    spawnPoint59b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card59b, spawnPoint59b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card59b";
                    card.AddComponent<OnDestroyCard59b>();

                    spawnPointsDeck1.Remove(spawnPoint59b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card59c") {
                    spawnPoint59c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card59c, spawnPoint59c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card59c";
                    card.AddComponent<OnDestroyCard59c>();

                    spawnPointsDeck1.Remove(spawnPoint59c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card60") {
                    spawnPoint60 = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card60, spawnPoint60, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card60";
                    card.AddComponent<OnDestroyCard60>();

                    spawnPointsDeck1.Remove(spawnPoint60);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card60a") {
                    spawnPoint60a = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card60a, spawnPoint60a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card60a";
                    card.AddComponent<OnDestroyCard60a>();

                    spawnPointsDeck1.Remove(spawnPoint60a);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card60b") {
                    spawnPoint60b = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card60b, spawnPoint60b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card60b";
                    card.AddComponent<OnDestroyCard60b>();

                    spawnPointsDeck1.Remove(spawnPoint60b);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated1Card60c") {
                    spawnPoint60c = spawnPointsDeck1[UnityEngine.Random.Range(0, spawnPointsDeck1.Count)];

                    GameObject card = Instantiate(card60c, spawnPoint60c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated1Card60c";
                    card.AddComponent<OnDestroyCard60c>();

                    spawnPointsDeck1.Remove(spawnPoint60c);
                    //spawnPointsDeck1.RemoveAll(item => item == null);

                }

            }
        }


    }


    [Serializable]
    class DataToSave1 {

        /*
			*
			* Serializable class for storing data in the binary file.		
			*
		*/

        //Name of the deck
        public string deckName1;
        //List of the card references to stored cards
        public List<string> cardsDeck1;
    }

}

	

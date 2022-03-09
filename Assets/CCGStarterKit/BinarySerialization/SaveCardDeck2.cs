using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.UI;

namespace Caerwent {

    public class SaveCardDeck2 : MonoBehaviour {

        /*
            *
            * Deck 2 manipulation file: two classes
            *
            *	The binary file is saved in this path:
            * Windows: C:/Users/Litech/AppData/LocalLow/DefaultCompany/Card Game/cardsDeck2.dat
            *
        */

        //Static reference variable for this class
        public static SaveCardDeck2 saveCardDeck2;
        //Static constant variable for the binary file containing persistent data
        public static readonly string BINARY_FILE2 = "cardsDeck2.dat";

        #region Variables definition

        public string deckName2;
        public static List<GameObject> editDeck2 = new List<GameObject>();
        public List<string> cardsDeck2 = new List<string>();
        public List<Vector3> spawnPointsDeck2 = new List<Vector3>();
        public List<GameObject> slotsWithChildren = new List<GameObject>();
        public List<GameObject> deck2Slots = new List<GameObject>();

        //Card model scales to lock and unlock the card model
        private Vector3 modelCardScale;
        private Vector3 lockedCardScale;

        //Arrays to get all game objects on the scene to find needed game objects
        private GameObject[] allObjects;
        private GameObject[] allObjects1;
        private GameObject[] allObjects2;

        //private GameObject spawnPointList;

        //UI variables
        private GameObject inputFieldSwitcher2;
        private GameObject warningNameText;
        private GameObject warningCardsText;
        private GameObject deckSavedText;
        public GameObject create2Button;
        private GameObject edit2Button;
        private GameObject save2Button;
        public GameObject delete2Button;
        private GameObject deckNamelabel;
        private GameObject deck2NameButton;
        private GameObject deck2NameInputField;

        public GameObject deck1Button;
        public GameObject deck2Button;
        public GameObject deck3Button;

        //Add the spawn points of the deck again to edit the deck
        private bool addEditSpawnPoints;
        //Set the initial number of the same cards only once in editing the deck
        private bool getDeck;

        public bool isDeck2Editing;

        //Slots to spawn cards of the deck
        private GameObject deck2Slot1;
        private GameObject deck2Slot2;
        private GameObject deck2Slot3;
        private GameObject deck2Slot4;
        private GameObject deck2Slot5;
        private GameObject deck2Slot6;
        private GameObject deck2Slot7;
        private GameObject deck2Slot8;
        private GameObject deck2Slot9;
        private GameObject deck2Slot10;
        private GameObject deck2Slot11;
        private GameObject deck2Slot12;
        private GameObject deck2Slot13;
        private GameObject deck2Slot14;
        private GameObject deck2Slot15;
        private GameObject deck2Slot16;
        private GameObject deck2Slot17;
        private GameObject deck2Slot18;
        private GameObject deck2Slot19;
        private GameObject deck2Slot20;
        private GameObject deck2Slot21;
        private GameObject deck2Slot22;
        private GameObject deck2Slot23;
        private GameObject deck2Slot24;
        private GameObject deck2Slot25;
        private GameObject deck2Slot26;
        private GameObject deck2Slot27;
        private GameObject deck2Slot28;
        private GameObject deck2Slot29;
        private GameObject deck2Slot30;
        private GameObject deck2Slot31;
        private GameObject deck2Slot32;
        private GameObject deck2Slot33;
        private GameObject deck2Slot34;
        private GameObject deck2Slot35;
        private GameObject deck2Slot36;
        private GameObject deck2Slot37;
        private GameObject deck2Slot38;
        private GameObject deck2Slot39;
        private GameObject deck2Slot40;
        private GameObject deck2Slot41;
        private GameObject deck2Slot42;
        private GameObject deck2Slot43;
        private GameObject deck2Slot44;
        private GameObject deck2Slot45;
        private GameObject deck2Slot46;
        private GameObject deck2Slot47;
        private GameObject deck2Slot48;
        private GameObject deck2Slot49;
        private GameObject deck2Slot50;
        private GameObject deck2Slot51;
        private GameObject deck2Slot52;
        private GameObject deck2Slot53;
        private GameObject deck2Slot54;
        private GameObject deck2Slot55;
        private GameObject deck2Slot56;
        private GameObject deck2Slot57;
        private GameObject deck2Slot58;
        private GameObject deck2Slot59;
        private GameObject deck2Slot60;

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
        private Vector3 spawnPoints1 = new Vector3(0.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints2 = new Vector3(2.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints3 = new Vector3(4.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints4 = new Vector3(6.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints5 = new Vector3(8.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints6 = new Vector3(10.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints7 = new Vector3(12.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints8 = new Vector3(14.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints9 = new Vector3(16.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints10 = new Vector3(18.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints11 = new Vector3(20.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints12 = new Vector3(22.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints13 = new Vector3(24.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints14 = new Vector3(26.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints15 = new Vector3(28.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints16 = new Vector3(30.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints17 = new Vector3(32.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints18 = new Vector3(34.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints19 = new Vector3(36.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints20 = new Vector3(38.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints21 = new Vector3(40.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints22 = new Vector3(42.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints23 = new Vector3(44.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints24 = new Vector3(46.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints25 = new Vector3(48.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints26 = new Vector3(50.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints27 = new Vector3(52.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints28 = new Vector3(54.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints29 = new Vector3(56.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints30 = new Vector3(58.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints31 = new Vector3(60.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints32 = new Vector3(62.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints33 = new Vector3(64.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints34 = new Vector3(66.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints35 = new Vector3(68.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints36 = new Vector3(70.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints37 = new Vector3(72.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints38 = new Vector3(74.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints39 = new Vector3(76.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints40 = new Vector3(78.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints41 = new Vector3(80.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints42 = new Vector3(82.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints43 = new Vector3(84.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints44 = new Vector3(86.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints45 = new Vector3(88.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints46 = new Vector3(90.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints47 = new Vector3(92.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints48 = new Vector3(94.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints49 = new Vector3(96.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints50 = new Vector3(98.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints51 = new Vector3(100.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints52 = new Vector3(102.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints53 = new Vector3(104.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints54 = new Vector3(106.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints55 = new Vector3(108.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints56 = new Vector3(110.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints57 = new Vector3(112.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints58 = new Vector3(114.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints59 = new Vector3(116.0f, 0.0f, -55.0f);
        private Vector3 spawnPoints60 = new Vector3(118.0f, 0.0f, -55.0f);

        //Lists to check how many the same cards are in the deck
        public static List<GameObject> instantiated2Card1List = new List<GameObject>();
        public static List<GameObject> instantiated2Card1aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card1bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card1cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card2List = new List<GameObject>();
        public static List<GameObject> instantiated2Card2aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card2bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card2cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card3List = new List<GameObject>();
        public static List<GameObject> instantiated2Card3aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card3bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card3cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card4List = new List<GameObject>();
        public static List<GameObject> instantiated2Card4aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card4bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card4cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card5List = new List<GameObject>();
        public static List<GameObject> instantiated2Card5aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card5bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card5cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card6List = new List<GameObject>();
        public static List<GameObject> instantiated2Card6aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card6bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card6cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card7List = new List<GameObject>();
        public static List<GameObject> instantiated2Card7aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card7bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card7cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card8List = new List<GameObject>();
        public static List<GameObject> instantiated2Card8aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card8bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card8cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card9List = new List<GameObject>();
        public static List<GameObject> instantiated2Card9aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card9bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card9cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card10List = new List<GameObject>();
        public static List<GameObject> instantiated2Card10aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card10bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card10cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card11List = new List<GameObject>();
        public static List<GameObject> instantiated2Card11aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card11bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card11cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card12List = new List<GameObject>();
        public static List<GameObject> instantiated2Card12aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card12bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card12cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card13List = new List<GameObject>();
        public static List<GameObject> instantiated2Card13aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card13bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card13cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card14List = new List<GameObject>();
        public static List<GameObject> instantiated2Card14aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card14bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card14cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card15List = new List<GameObject>();
        public static List<GameObject> instantiated2Card15aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card15bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card15cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card16List = new List<GameObject>();
        public static List<GameObject> instantiated2Card16aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card16bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card16cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card17List = new List<GameObject>();
        public static List<GameObject> instantiated2Card17aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card17bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card17cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card18List = new List<GameObject>();
        public static List<GameObject> instantiated2Card18aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card18bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card18cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card19List = new List<GameObject>();
        public static List<GameObject> instantiated2Card19aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card19bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card19cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card20List = new List<GameObject>();
        public static List<GameObject> instantiated2Card20aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card20bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card20cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card21List = new List<GameObject>();
        public static List<GameObject> instantiated2Card21aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card21bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card21cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card22List = new List<GameObject>();
        public static List<GameObject> instantiated2Card22aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card22bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card22cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card23List = new List<GameObject>();
        public static List<GameObject> instantiated2Card23aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card23bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card23cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card24List = new List<GameObject>();
        public static List<GameObject> instantiated2Card24aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card24bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card24cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card25List = new List<GameObject>();
        public static List<GameObject> instantiated2Card25aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card25bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card25cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card26List = new List<GameObject>();
        public static List<GameObject> instantiated2Card26aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card26bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card26cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card27List = new List<GameObject>();
        public static List<GameObject> instantiated2Card27aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card27bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card27cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card28List = new List<GameObject>();
        public static List<GameObject> instantiated2Card28aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card28bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card28cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card29List = new List<GameObject>();
        public static List<GameObject> instantiated2Card29aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card29bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card29cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card30List = new List<GameObject>();
        public static List<GameObject> instantiated2Card30aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card30bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card30cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card31List = new List<GameObject>();
        public static List<GameObject> instantiated2Card31aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card31bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card31cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card32List = new List<GameObject>();
        public static List<GameObject> instantiated2Card32aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card32bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card32cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card33List = new List<GameObject>();
        public static List<GameObject> instantiated2Card33aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card33bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card33cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card34List = new List<GameObject>();
        public static List<GameObject> instantiated2Card34aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card34bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card34cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card35List = new List<GameObject>();
        public static List<GameObject> instantiated2Card35aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card35bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card35cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card36List = new List<GameObject>();
        public static List<GameObject> instantiated2Card36aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card36bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card36cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card37List = new List<GameObject>();
        public static List<GameObject> instantiated2Card37aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card37bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card37cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card38List = new List<GameObject>();
        public static List<GameObject> instantiated2Card38aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card38bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card38cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card39List = new List<GameObject>();
        public static List<GameObject> instantiated2Card39aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card39bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card39cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card40List = new List<GameObject>();
        public static List<GameObject> instantiated2Card40aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card40bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card40cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card41List = new List<GameObject>();
        public static List<GameObject> instantiated2Card41aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card41bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card41cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card42List = new List<GameObject>();
        public static List<GameObject> instantiated2Card42aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card42bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card42cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card43List = new List<GameObject>();
        public static List<GameObject> instantiated2Card43aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card43bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card43cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card44List = new List<GameObject>();
        public static List<GameObject> instantiated2Card44aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card44bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card44cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card45List = new List<GameObject>();
        public static List<GameObject> instantiated2Card45aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card45bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card45cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card46List = new List<GameObject>();
        public static List<GameObject> instantiated2Card46aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card46bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card46cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card47List = new List<GameObject>();
        public static List<GameObject> instantiated2Card47aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card47bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card47cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card48List = new List<GameObject>();
        public static List<GameObject> instantiated2Card48aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card48bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card48cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card49List = new List<GameObject>();
        public static List<GameObject> instantiated2Card49aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card49bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card49cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card50List = new List<GameObject>();
        public static List<GameObject> instantiated2Card50aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card50bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card50cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card51List = new List<GameObject>();
        public static List<GameObject> instantiated2Card51aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card51bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card51cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card52List = new List<GameObject>();
        public static List<GameObject> instantiated2Card52aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card52bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card52cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card53List = new List<GameObject>();
        public static List<GameObject> instantiated2Card53aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card53bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card53cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card54List = new List<GameObject>();
        public static List<GameObject> instantiated2Card54aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card54bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card54cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card55List = new List<GameObject>();
        public static List<GameObject> instantiated2Card55aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card55bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card55cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card56List = new List<GameObject>();
        public static List<GameObject> instantiated2Card56aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card56bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card56cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card57List = new List<GameObject>();
        public static List<GameObject> instantiated2Card57aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card57bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card57cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card58List = new List<GameObject>();
        public static List<GameObject> instantiated2Card58aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card58bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card58cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card59List = new List<GameObject>();
        public static List<GameObject> instantiated2Card59aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card59bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card59cList = new List<GameObject>();
        public static List<GameObject> instantiated2Card60List = new List<GameObject>();
        public static List<GameObject> instantiated2Card60aList = new List<GameObject>();
        public static List<GameObject> instantiated2Card60bList = new List<GameObject>();
        public static List<GameObject> instantiated2Card60cList = new List<GameObject>();


        #endregion

        void Awake() {

            //Make this class singletone (only one instance in application)
            if (saveCardDeck2 == null) {

                DontDestroyOnLoad(gameObject);
                saveCardDeck2 = this;

            } else if (saveCardDeck2 != this) {

                Destroy(gameObject);

            }

            //Finding needed game objects
            //spawnPointList = GameObject.Find("PanelWithDeckSlots");
            inputFieldSwitcher2 = GameObject.Find("InputFieldSwitcher2");
            warningNameText = GameObject.Find("WarningNameText");
            warningCardsText = GameObject.Find("WarningCardsText");
            deckSavedText = GameObject.Find("DeckSavedText");
            create2Button = GameObject.Find("Create2");
            edit2Button = GameObject.Find("Edit2");
            save2Button = GameObject.Find("Save2");
            delete2Button = GameObject.Find("Delete2");
            deckNamelabel = GameObject.Find("DeckNameLabel");
            deck2NameButton = GameObject.Find("Deck2Text");
            deck2NameInputField = GameObject.Find("InputFieldDeck2");

            deck1Button = GameObject.Find("Deck1Buttons");
            deck2Button = GameObject.Find("Deck2Buttons");
            deck3Button = GameObject.Find("Deck3Buttons");

            deck2Slot1 = GameObject.Find("Deck2Slot1");
            deck2Slot2 = GameObject.Find("Deck2Slot2");
            deck2Slot3 = GameObject.Find("Deck2Slot3");
            deck2Slot4 = GameObject.Find("Deck2Slot4");
            deck2Slot5 = GameObject.Find("Deck2Slot5");
            deck2Slot6 = GameObject.Find("Deck2Slot6");
            deck2Slot7 = GameObject.Find("Deck2Slot7");
            deck2Slot8 = GameObject.Find("Deck2Slot8");
            deck2Slot9 = GameObject.Find("Deck2Slot9");
            deck2Slot10 = GameObject.Find("Deck2Slot10");
            deck2Slot11 = GameObject.Find("Deck2Slot11");
            deck2Slot12 = GameObject.Find("Deck2Slot12");
            deck2Slot13 = GameObject.Find("Deck2Slot13");
            deck2Slot14 = GameObject.Find("Deck2Slot14");
            deck2Slot15 = GameObject.Find("Deck2Slot15");
            deck2Slot16 = GameObject.Find("Deck2Slot16");
            deck2Slot17 = GameObject.Find("Deck2Slot17");
            deck2Slot18 = GameObject.Find("Deck2Slot18");
            deck2Slot19 = GameObject.Find("Deck2Slot19");
            deck2Slot20 = GameObject.Find("Deck2Slot20");
            deck2Slot21 = GameObject.Find("Deck2Slot21");
            deck2Slot22 = GameObject.Find("Deck2Slot22");
            deck2Slot23 = GameObject.Find("Deck2Slot23");
            deck2Slot24 = GameObject.Find("Deck2Slot24");
            deck2Slot25 = GameObject.Find("Deck2Slot25");
            deck2Slot26 = GameObject.Find("Deck2Slot26");
            deck2Slot27 = GameObject.Find("Deck2Slot27");
            deck2Slot28 = GameObject.Find("Deck2Slot28");
            deck2Slot29 = GameObject.Find("Deck2Slot29");
            deck2Slot30 = GameObject.Find("Deck2Slot30");
            deck2Slot31 = GameObject.Find("Deck2Slot31");
            deck2Slot32 = GameObject.Find("Deck2Slot32");
            deck2Slot33 = GameObject.Find("Deck2Slot33");
            deck2Slot34 = GameObject.Find("Deck2Slot34");
            deck2Slot35 = GameObject.Find("Deck2Slot35");
            deck2Slot36 = GameObject.Find("Deck2Slot36");
            deck2Slot37 = GameObject.Find("Deck2Slot37");
            deck2Slot38 = GameObject.Find("Deck2Slot38");
            deck2Slot39 = GameObject.Find("Deck2Slot39");
            deck2Slot40 = GameObject.Find("Deck2Slot40");
            deck2Slot41 = GameObject.Find("Deck2Slot41");
            deck2Slot42 = GameObject.Find("Deck2Slot42");
            deck2Slot43 = GameObject.Find("Deck2Slot43");
            deck2Slot44 = GameObject.Find("Deck2Slot44");
            deck2Slot45 = GameObject.Find("Deck2Slot45");
            deck2Slot46 = GameObject.Find("Deck2Slot46");
            deck2Slot47 = GameObject.Find("Deck2Slot47");
            deck2Slot48 = GameObject.Find("Deck2Slot48");
            deck2Slot49 = GameObject.Find("Deck2Slot49");
            deck2Slot50 = GameObject.Find("Deck2Slot50");
            deck2Slot51 = GameObject.Find("Deck2Slot51");
            deck2Slot52 = GameObject.Find("Deck2Slot52");
            deck2Slot53 = GameObject.Find("Deck2Slot53");
            deck2Slot54 = GameObject.Find("Deck2Slot54");
            deck2Slot55 = GameObject.Find("Deck2Slot55");
            deck2Slot56 = GameObject.Find("Deck2Slot56");
            deck2Slot57 = GameObject.Find("Deck2Slot57");
            deck2Slot58 = GameObject.Find("Deck2Slot58");
            deck2Slot59 = GameObject.Find("Deck2Slot59");
            deck2Slot60 = GameObject.Find("Deck2Slot60");

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

            inputFieldSwitcher2.SetActive(false);
            warningNameText.SetActive(false);
            warningCardsText.SetActive(false);
            deckSavedText.SetActive(false);

            getDeck = true;
            addEditSpawnPoints = false;
            isDeck2Editing = false;

            deck1Button.SetActive(false);
            deck2Button.SetActive(false);
            deck3Button.SetActive(false);

            #region StartStuff definition

            spawnPointsDeck2.Insert(0, spawnPoints1);
            spawnPointsDeck2.Insert(1, spawnPoints2);
            spawnPointsDeck2.Insert(2, spawnPoints3);
            spawnPointsDeck2.Insert(3, spawnPoints4);
            spawnPointsDeck2.Insert(4, spawnPoints5);
            spawnPointsDeck2.Insert(5, spawnPoints6);
            spawnPointsDeck2.Insert(6, spawnPoints7);
            spawnPointsDeck2.Insert(7, spawnPoints8);
            spawnPointsDeck2.Insert(8, spawnPoints9);
            spawnPointsDeck2.Insert(9, spawnPoints10);
            spawnPointsDeck2.Insert(10, spawnPoints11);
            spawnPointsDeck2.Insert(11, spawnPoints12);
            spawnPointsDeck2.Insert(12, spawnPoints13);
            spawnPointsDeck2.Insert(13, spawnPoints14);
            spawnPointsDeck2.Insert(14, spawnPoints15);
            spawnPointsDeck2.Insert(15, spawnPoints16);
            spawnPointsDeck2.Insert(16, spawnPoints17);
            spawnPointsDeck2.Insert(17, spawnPoints18);
            spawnPointsDeck2.Insert(18, spawnPoints19);
            spawnPointsDeck2.Insert(19, spawnPoints20);
            spawnPointsDeck2.Insert(20, spawnPoints21);
            spawnPointsDeck2.Insert(21, spawnPoints22);
            spawnPointsDeck2.Insert(22, spawnPoints23);
            spawnPointsDeck2.Insert(23, spawnPoints24);
            spawnPointsDeck2.Insert(24, spawnPoints25);
            spawnPointsDeck2.Insert(25, spawnPoints26);
            spawnPointsDeck2.Insert(26, spawnPoints27);
            spawnPointsDeck2.Insert(27, spawnPoints28);
            spawnPointsDeck2.Insert(28, spawnPoints29);
            spawnPointsDeck2.Insert(29, spawnPoints30);
            spawnPointsDeck2.Insert(30, spawnPoints31);
            spawnPointsDeck2.Insert(31, spawnPoints32);
            spawnPointsDeck2.Insert(32, spawnPoints33);
            spawnPointsDeck2.Insert(33, spawnPoints34);
            spawnPointsDeck2.Insert(34, spawnPoints35);
            spawnPointsDeck2.Insert(35, spawnPoints36);
            spawnPointsDeck2.Insert(36, spawnPoints37);
            spawnPointsDeck2.Insert(37, spawnPoints38);
            spawnPointsDeck2.Insert(38, spawnPoints39);
            spawnPointsDeck2.Insert(39, spawnPoints40);
            spawnPointsDeck2.Insert(40, spawnPoints41);
            spawnPointsDeck2.Insert(41, spawnPoints42);
            spawnPointsDeck2.Insert(42, spawnPoints43);
            spawnPointsDeck2.Insert(43, spawnPoints44);
            spawnPointsDeck2.Insert(44, spawnPoints45);
            spawnPointsDeck2.Insert(45, spawnPoints46);
            spawnPointsDeck2.Insert(46, spawnPoints47);
            spawnPointsDeck2.Insert(47, spawnPoints48);
            spawnPointsDeck2.Insert(48, spawnPoints49);
            spawnPointsDeck2.Insert(49, spawnPoints50);
            spawnPointsDeck2.Insert(50, spawnPoints51);
            spawnPointsDeck2.Insert(51, spawnPoints52);
            spawnPointsDeck2.Insert(52, spawnPoints53);
            spawnPointsDeck2.Insert(53, spawnPoints54);
            spawnPointsDeck2.Insert(54, spawnPoints55);
            spawnPointsDeck2.Insert(55, spawnPoints56);
            spawnPointsDeck2.Insert(56, spawnPoints57);
            spawnPointsDeck2.Insert(57, spawnPoints58);
            spawnPointsDeck2.Insert(58, spawnPoints59);
            spawnPointsDeck2.Insert(59, spawnPoints60);

            deck2Slots.Insert(0, deck2Slot1);
            deck2Slots.Insert(1, deck2Slot2);
            deck2Slots.Insert(2, deck2Slot3);
            deck2Slots.Insert(3, deck2Slot4);
            deck2Slots.Insert(4, deck2Slot5);
            deck2Slots.Insert(5, deck2Slot6);
            deck2Slots.Insert(6, deck2Slot7);
            deck2Slots.Insert(7, deck2Slot8);
            deck2Slots.Insert(8, deck2Slot9);
            deck2Slots.Insert(9, deck2Slot10);
            deck2Slots.Insert(10, deck2Slot11);
            deck2Slots.Insert(11, deck2Slot12);
            deck2Slots.Insert(12, deck2Slot13);
            deck2Slots.Insert(13, deck2Slot14);
            deck2Slots.Insert(14, deck2Slot15);
            deck2Slots.Insert(15, deck2Slot16);
            deck2Slots.Insert(16, deck2Slot17);
            deck2Slots.Insert(17, deck2Slot18);
            deck2Slots.Insert(18, deck2Slot19);
            deck2Slots.Insert(19, deck2Slot20);
            deck2Slots.Insert(20, deck2Slot21);
            deck2Slots.Insert(21, deck2Slot22);
            deck2Slots.Insert(22, deck2Slot23);
            deck2Slots.Insert(23, deck2Slot24);
            deck2Slots.Insert(24, deck2Slot25);
            deck2Slots.Insert(25, deck2Slot26);
            deck2Slots.Insert(26, deck2Slot27);
            deck2Slots.Insert(27, deck2Slot28);
            deck2Slots.Insert(28, deck2Slot29);
            deck2Slots.Insert(29, deck2Slot30);
            deck2Slots.Insert(30, deck2Slot31);
            deck2Slots.Insert(31, deck2Slot32);
            deck2Slots.Insert(32, deck2Slot33);
            deck2Slots.Insert(33, deck2Slot34);
            deck2Slots.Insert(34, deck2Slot35);
            deck2Slots.Insert(35, deck2Slot36);
            deck2Slots.Insert(36, deck2Slot37);
            deck2Slots.Insert(37, deck2Slot38);
            deck2Slots.Insert(38, deck2Slot39);
            deck2Slots.Insert(39, deck2Slot40);
            deck2Slots.Insert(40, deck2Slot41);
            deck2Slots.Insert(41, deck2Slot42);
            deck2Slots.Insert(42, deck2Slot43);
            deck2Slots.Insert(43, deck2Slot44);
            deck2Slots.Insert(44, deck2Slot45);
            deck2Slots.Insert(45, deck2Slot46);
            deck2Slots.Insert(46, deck2Slot47);
            deck2Slots.Insert(47, deck2Slot48);
            deck2Slots.Insert(48, deck2Slot49);
            deck2Slots.Insert(49, deck2Slot50);
            deck2Slots.Insert(50, deck2Slot51);
            deck2Slots.Insert(51, deck2Slot52);
            deck2Slots.Insert(52, deck2Slot53);
            deck2Slots.Insert(53, deck2Slot54);
            deck2Slots.Insert(54, deck2Slot55);
            deck2Slots.Insert(55, deck2Slot56);
            deck2Slots.Insert(56, deck2Slot57);
            deck2Slots.Insert(57, deck2Slot58);
            deck2Slots.Insert(58, deck2Slot59);
            deck2Slots.Insert(59, deck2Slot60);




            #endregion


            //Get data stored in the binary file
            if (File.Exists(Path.Combine(Application.persistentDataPath, BINARY_FILE2))) {

                BinaryFormatter bf = new BinaryFormatter();

                FileStream file = File.Open(Path.Combine(Application.persistentDataPath, BINARY_FILE2), FileMode.Open);
                DataToSave2 data = (DataToSave2)bf.Deserialize(file);
                file.Close();
                deckName2 = data.deckName2;
                cardsDeck2 = data.cardsDeck2;

                //Convert card references into 3D card game objects
                CardGenerator();


            }

            //Set Create, Save and Edit buttons interactable or noninteractable depending on if the cardsDeck2 list is empty or not
            if (cardsDeck2.Count.Equals(0)) {
                create2Button.GetComponent<Button>().interactable = true;
                save2Button.GetComponent<Button>().interactable = false;
                edit2Button.GetComponent<Button>().interactable = false;
                delete2Button.GetComponent<Button>().interactable = false;
            } else {
                create2Button.GetComponent<Button>().interactable = false;
                save2Button.GetComponent<Button>().interactable = true;
                edit2Button.GetComponent<Button>().interactable = true;
                delete2Button.GetComponent<Button>().interactable = true;
            }



            if (deck2NameButton.GetComponent<Text>().text == "") {
                deck2NameButton.GetComponent<Text>().text = "Deck 2";
            } else {
                deck2NameButton.GetComponent<Text>().text = deckName2;
            }


        }

        void Update() {

            if (Input.GetKeyDown(KeyCode.Mouse0)) {
                //Check every frame if all the slots in Deck Manager panel have cards
                deck2Slots.RemoveAll(item => item == null);
                foreach (GameObject slot in deck2Slots) {
                    if (slot.transform.childCount > 0) { //if so...

                        //Make Save button interactable
                        save2Button.GetComponent<Button>().interactable = true;

                    }
                }


                //Set spawn points to edit cards in the deck
                SetSpawnPointsToEdit();

            }
        }


        /** Edit the deck - the deck is loaded into the Deck manager panel and can be modified*/
        public void Edit() {

            addEditSpawnPoints = true;
            isDeck2Editing = true;

            //Show the input field to enter a name of the deck
            inputFieldSwitcher2.SetActive(true);

            //Clean all lists
            editDeck2.Clear();
            editDeck2.RemoveAll(item => item == null);
            cardsDeck2.Clear();
            cardsDeck2.RemoveAll(item => item == null);

            //Get data stored in the binary file
            if (File.Exists(Path.Combine(Application.persistentDataPath, BINARY_FILE2))) {

                BinaryFormatter bf = new BinaryFormatter();

                FileStream file = File.Open(Path.Combine(Application.persistentDataPath, BINARY_FILE2), FileMode.Open);
                DataToSave2 data = (DataToSave2)bf.Deserialize(file);
                file.Close();
                deckName2 = data.deckName2;

                deckNamelabel.GetComponent<Text>().text = deckName2;

                if (deck2NameButton.GetComponent<Text>().text == "") {
                    deck2NameButton.GetComponent<Text>().text = "Deck 2";
                } else {
                    deck2NameButton.GetComponent<Text>().text = deckName2;
                }
            }

            //Find all the cards for the deck
            allObjects1 = GameObject.FindObjectsOfType(typeof(GameObject)) as GameObject[];
            foreach (GameObject obj in allObjects1) {
                if (obj.name.Contains("instantiated2Card")) {

                    editDeck2.Add(obj);

                }
            }

            //Get ready the cards in the deck to edit
            #region EditFillSlots definition

            if (editDeck2.Count == 20) {
                editDeck2[0].transform.parent = deck2Slot1.transform;
                editDeck2[0].transform.localPosition = Vector3.zero;
                editDeck2[0].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[0].AddComponent<DeleteCardInEditMode>();

                editDeck2[1].transform.parent = deck2Slot2.transform;
                editDeck2[1].transform.localPosition = Vector3.zero;
                editDeck2[1].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[1].AddComponent<DeleteCardInEditMode>();

                editDeck2[2].transform.parent = deck2Slot3.transform;
                editDeck2[2].transform.localPosition = Vector3.zero;
                editDeck2[2].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[2].AddComponent<DeleteCardInEditMode>();

                editDeck2[3].transform.parent = deck2Slot4.transform;
                editDeck2[3].transform.localPosition = Vector3.zero;
                editDeck2[3].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[3].AddComponent<DeleteCardInEditMode>();

                editDeck2[4].transform.parent = deck2Slot5.transform;
                editDeck2[4].transform.localPosition = Vector3.zero;
                editDeck2[4].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[4].AddComponent<DeleteCardInEditMode>();

                editDeck2[5].transform.parent = deck2Slot6.transform;
                editDeck2[5].transform.localPosition = Vector3.zero;
                editDeck2[5].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[5].AddComponent<DeleteCardInEditMode>();

                editDeck2[6].transform.parent = deck2Slot7.transform;
                editDeck2[6].transform.localPosition = Vector3.zero;
                editDeck2[6].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[6].AddComponent<DeleteCardInEditMode>();

                editDeck2[7].transform.parent = deck2Slot8.transform;
                editDeck2[7].transform.localPosition = Vector3.zero;
                editDeck2[7].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[7].AddComponent<DeleteCardInEditMode>();

                editDeck2[8].transform.parent = deck2Slot9.transform;
                editDeck2[8].transform.localPosition = Vector3.zero;
                editDeck2[8].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[8].AddComponent<DeleteCardInEditMode>();

                editDeck2[9].transform.parent = deck2Slot10.transform;
                editDeck2[9].transform.localPosition = Vector3.zero;
                editDeck2[9].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[9].AddComponent<DeleteCardInEditMode>();

                editDeck2[10].transform.parent = deck2Slot11.transform;
                editDeck2[10].transform.localPosition = Vector3.zero;
                editDeck2[10].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[10].AddComponent<DeleteCardInEditMode>();

                editDeck2[11].transform.parent = deck2Slot12.transform;
                editDeck2[11].transform.localPosition = Vector3.zero;
                editDeck2[11].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[11].AddComponent<DeleteCardInEditMode>();

                editDeck2[12].transform.parent = deck2Slot13.transform;
                editDeck2[12].transform.localPosition = Vector3.zero;
                editDeck2[12].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[12].AddComponent<DeleteCardInEditMode>();

                editDeck2[13].transform.parent = deck2Slot14.transform;
                editDeck2[13].transform.localPosition = Vector3.zero;
                editDeck2[13].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[13].AddComponent<DeleteCardInEditMode>();

                editDeck2[14].transform.parent = deck2Slot15.transform;
                editDeck2[14].transform.localPosition = Vector3.zero;
                editDeck2[14].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[14].AddComponent<DeleteCardInEditMode>();

                editDeck2[15].transform.parent = deck2Slot16.transform;
                editDeck2[15].transform.localPosition = Vector3.zero;
                editDeck2[15].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[15].AddComponent<DeleteCardInEditMode>();

                editDeck2[16].transform.parent = deck2Slot17.transform;
                editDeck2[16].transform.localPosition = Vector3.zero;
                editDeck2[16].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[16].AddComponent<DeleteCardInEditMode>();

                editDeck2[17].transform.parent = deck2Slot18.transform;
                editDeck2[17].transform.localPosition = Vector3.zero;
                editDeck2[17].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[17].AddComponent<DeleteCardInEditMode>();

                editDeck2[18].transform.parent = deck2Slot19.transform;
                editDeck2[18].transform.localPosition = Vector3.zero;
                editDeck2[18].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[18].AddComponent<DeleteCardInEditMode>();

                editDeck2[19].transform.parent = deck2Slot20.transform;
                editDeck2[19].transform.localPosition = Vector3.zero;
                editDeck2[19].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[19].AddComponent<DeleteCardInEditMode>();

            } else if (editDeck2.Count == 25) {
                editDeck2[0].transform.parent = deck2Slot1.transform;
                editDeck2[0].transform.localPosition = Vector3.zero;
                editDeck2[0].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[0].AddComponent<DeleteCardInEditMode>();

                editDeck2[1].transform.parent = deck2Slot2.transform;
                editDeck2[1].transform.localPosition = Vector3.zero;
                editDeck2[1].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[1].AddComponent<DeleteCardInEditMode>();

                editDeck2[2].transform.parent = deck2Slot3.transform;
                editDeck2[2].transform.localPosition = Vector3.zero;
                editDeck2[2].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[2].AddComponent<DeleteCardInEditMode>();

                editDeck2[3].transform.parent = deck2Slot4.transform;
                editDeck2[3].transform.localPosition = Vector3.zero;
                editDeck2[3].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[3].AddComponent<DeleteCardInEditMode>();

                editDeck2[4].transform.parent = deck2Slot5.transform;
                editDeck2[4].transform.localPosition = Vector3.zero;
                editDeck2[4].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[4].AddComponent<DeleteCardInEditMode>();

                editDeck2[5].transform.parent = deck2Slot6.transform;
                editDeck2[5].transform.localPosition = Vector3.zero;
                editDeck2[5].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[5].AddComponent<DeleteCardInEditMode>();

                editDeck2[6].transform.parent = deck2Slot7.transform;
                editDeck2[6].transform.localPosition = Vector3.zero;
                editDeck2[6].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[6].AddComponent<DeleteCardInEditMode>();

                editDeck2[7].transform.parent = deck2Slot8.transform;
                editDeck2[7].transform.localPosition = Vector3.zero;
                editDeck2[7].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[7].AddComponent<DeleteCardInEditMode>();

                editDeck2[8].transform.parent = deck2Slot9.transform;
                editDeck2[8].transform.localPosition = Vector3.zero;
                editDeck2[8].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[8].AddComponent<DeleteCardInEditMode>();

                editDeck2[9].transform.parent = deck2Slot10.transform;
                editDeck2[9].transform.localPosition = Vector3.zero;
                editDeck2[9].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[9].AddComponent<DeleteCardInEditMode>();

                editDeck2[10].transform.parent = deck2Slot11.transform;
                editDeck2[10].transform.localPosition = Vector3.zero;
                editDeck2[10].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[10].AddComponent<DeleteCardInEditMode>();

                editDeck2[11].transform.parent = deck2Slot12.transform;
                editDeck2[11].transform.localPosition = Vector3.zero;
                editDeck2[11].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[11].AddComponent<DeleteCardInEditMode>();

                editDeck2[12].transform.parent = deck2Slot13.transform;
                editDeck2[12].transform.localPosition = Vector3.zero;
                editDeck2[12].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[12].AddComponent<DeleteCardInEditMode>();

                editDeck2[13].transform.parent = deck2Slot14.transform;
                editDeck2[13].transform.localPosition = Vector3.zero;
                editDeck2[13].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[13].AddComponent<DeleteCardInEditMode>();

                editDeck2[14].transform.parent = deck2Slot15.transform;
                editDeck2[14].transform.localPosition = Vector3.zero;
                editDeck2[14].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[14].AddComponent<DeleteCardInEditMode>();

                editDeck2[15].transform.parent = deck2Slot16.transform;
                editDeck2[15].transform.localPosition = Vector3.zero;
                editDeck2[15].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[15].AddComponent<DeleteCardInEditMode>();

                editDeck2[16].transform.parent = deck2Slot17.transform;
                editDeck2[16].transform.localPosition = Vector3.zero;
                editDeck2[16].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[16].AddComponent<DeleteCardInEditMode>();

                editDeck2[17].transform.parent = deck2Slot18.transform;
                editDeck2[17].transform.localPosition = Vector3.zero;
                editDeck2[17].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[17].AddComponent<DeleteCardInEditMode>();

                editDeck2[18].transform.parent = deck2Slot19.transform;
                editDeck2[18].transform.localPosition = Vector3.zero;
                editDeck2[18].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[18].AddComponent<DeleteCardInEditMode>();

                editDeck2[19].transform.parent = deck2Slot20.transform;
                editDeck2[19].transform.localPosition = Vector3.zero;
                editDeck2[19].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[19].AddComponent<DeleteCardInEditMode>();

                editDeck2[20].transform.parent = deck2Slot21.transform;
                editDeck2[20].transform.localPosition = Vector3.zero;
                editDeck2[20].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[20].AddComponent<DeleteCardInEditMode>();

                editDeck2[21].transform.parent = deck2Slot22.transform;
                editDeck2[21].transform.localPosition = Vector3.zero;
                editDeck2[21].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[21].AddComponent<DeleteCardInEditMode>();

                editDeck2[22].transform.parent = deck2Slot23.transform;
                editDeck2[22].transform.localPosition = Vector3.zero;
                editDeck2[22].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[22].AddComponent<DeleteCardInEditMode>();

                editDeck2[23].transform.parent = deck2Slot24.transform;
                editDeck2[23].transform.localPosition = Vector3.zero;
                editDeck2[23].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[23].AddComponent<DeleteCardInEditMode>();

                editDeck2[24].transform.parent = deck2Slot25.transform;
                editDeck2[24].transform.localPosition = Vector3.zero;
                editDeck2[24].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[24].AddComponent<DeleteCardInEditMode>();

            } else if (editDeck2.Count == 30) {
                editDeck2[0].transform.parent = deck2Slot1.transform;
                editDeck2[0].transform.localPosition = Vector3.zero;
                editDeck2[0].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[0].AddComponent<DeleteCardInEditMode>();

                editDeck2[1].transform.parent = deck2Slot2.transform;
                editDeck2[1].transform.localPosition = Vector3.zero;
                editDeck2[1].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[1].AddComponent<DeleteCardInEditMode>();

                editDeck2[2].transform.parent = deck2Slot3.transform;
                editDeck2[2].transform.localPosition = Vector3.zero;
                editDeck2[2].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[2].AddComponent<DeleteCardInEditMode>();

                editDeck2[3].transform.parent = deck2Slot4.transform;
                editDeck2[3].transform.localPosition = Vector3.zero;
                editDeck2[3].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[3].AddComponent<DeleteCardInEditMode>();

                editDeck2[4].transform.parent = deck2Slot5.transform;
                editDeck2[4].transform.localPosition = Vector3.zero;
                editDeck2[4].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[4].AddComponent<DeleteCardInEditMode>();

                editDeck2[5].transform.parent = deck2Slot6.transform;
                editDeck2[5].transform.localPosition = Vector3.zero;
                editDeck2[5].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[5].AddComponent<DeleteCardInEditMode>();

                editDeck2[6].transform.parent = deck2Slot7.transform;
                editDeck2[6].transform.localPosition = Vector3.zero;
                editDeck2[6].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[6].AddComponent<DeleteCardInEditMode>();

                editDeck2[7].transform.parent = deck2Slot8.transform;
                editDeck2[7].transform.localPosition = Vector3.zero;
                editDeck2[7].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[7].AddComponent<DeleteCardInEditMode>();

                editDeck2[8].transform.parent = deck2Slot9.transform;
                editDeck2[8].transform.localPosition = Vector3.zero;
                editDeck2[8].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[8].AddComponent<DeleteCardInEditMode>();

                editDeck2[9].transform.parent = deck2Slot10.transform;
                editDeck2[9].transform.localPosition = Vector3.zero;
                editDeck2[9].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[9].AddComponent<DeleteCardInEditMode>();

                editDeck2[10].transform.parent = deck2Slot11.transform;
                editDeck2[10].transform.localPosition = Vector3.zero;
                editDeck2[10].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[10].AddComponent<DeleteCardInEditMode>();

                editDeck2[11].transform.parent = deck2Slot12.transform;
                editDeck2[11].transform.localPosition = Vector3.zero;
                editDeck2[11].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[11].AddComponent<DeleteCardInEditMode>();

                editDeck2[12].transform.parent = deck2Slot13.transform;
                editDeck2[12].transform.localPosition = Vector3.zero;
                editDeck2[12].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[12].AddComponent<DeleteCardInEditMode>();

                editDeck2[13].transform.parent = deck2Slot14.transform;
                editDeck2[13].transform.localPosition = Vector3.zero;
                editDeck2[13].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[13].AddComponent<DeleteCardInEditMode>();

                editDeck2[14].transform.parent = deck2Slot15.transform;
                editDeck2[14].transform.localPosition = Vector3.zero;
                editDeck2[14].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[14].AddComponent<DeleteCardInEditMode>();

                editDeck2[15].transform.parent = deck2Slot16.transform;
                editDeck2[15].transform.localPosition = Vector3.zero;
                editDeck2[15].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[15].AddComponent<DeleteCardInEditMode>();

                editDeck2[16].transform.parent = deck2Slot17.transform;
                editDeck2[16].transform.localPosition = Vector3.zero;
                editDeck2[16].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[16].AddComponent<DeleteCardInEditMode>();

                editDeck2[17].transform.parent = deck2Slot18.transform;
                editDeck2[17].transform.localPosition = Vector3.zero;
                editDeck2[17].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[17].AddComponent<DeleteCardInEditMode>();

                editDeck2[18].transform.parent = deck2Slot19.transform;
                editDeck2[18].transform.localPosition = Vector3.zero;
                editDeck2[18].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[18].AddComponent<DeleteCardInEditMode>();

                editDeck2[19].transform.parent = deck2Slot20.transform;
                editDeck2[19].transform.localPosition = Vector3.zero;
                editDeck2[19].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[19].AddComponent<DeleteCardInEditMode>();

                editDeck2[20].transform.parent = deck2Slot21.transform;
                editDeck2[20].transform.localPosition = Vector3.zero;
                editDeck2[20].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[20].AddComponent<DeleteCardInEditMode>();

                editDeck2[21].transform.parent = deck2Slot22.transform;
                editDeck2[21].transform.localPosition = Vector3.zero;
                editDeck2[21].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[21].AddComponent<DeleteCardInEditMode>();

                editDeck2[22].transform.parent = deck2Slot23.transform;
                editDeck2[22].transform.localPosition = Vector3.zero;
                editDeck2[22].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[22].AddComponent<DeleteCardInEditMode>();

                editDeck2[23].transform.parent = deck2Slot24.transform;
                editDeck2[23].transform.localPosition = Vector3.zero;
                editDeck2[23].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[23].AddComponent<DeleteCardInEditMode>();

                editDeck2[24].transform.parent = deck2Slot25.transform;
                editDeck2[24].transform.localPosition = Vector3.zero;
                editDeck2[24].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[24].AddComponent<DeleteCardInEditMode>();

                editDeck2[25].transform.parent = deck2Slot26.transform;
                editDeck2[25].transform.localPosition = Vector3.zero;
                editDeck2[25].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[25].AddComponent<DeleteCardInEditMode>();

                editDeck2[26].transform.parent = deck2Slot27.transform;
                editDeck2[26].transform.localPosition = Vector3.zero;
                editDeck2[26].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[26].AddComponent<DeleteCardInEditMode>();

                editDeck2[27].transform.parent = deck2Slot28.transform;
                editDeck2[27].transform.localPosition = Vector3.zero;
                editDeck2[27].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[27].AddComponent<DeleteCardInEditMode>();

                editDeck2[28].transform.parent = deck2Slot29.transform;
                editDeck2[28].transform.localPosition = Vector3.zero;
                editDeck2[28].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[28].AddComponent<DeleteCardInEditMode>();

                editDeck2[29].transform.parent = deck2Slot30.transform;
                editDeck2[29].transform.localPosition = Vector3.zero;
                editDeck2[29].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[29].AddComponent<DeleteCardInEditMode>();

            } else if (editDeck2.Count == 35) {
                editDeck2[0].transform.parent = deck2Slot1.transform;
                editDeck2[0].transform.localPosition = Vector3.zero;
                editDeck2[0].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[0].AddComponent<DeleteCardInEditMode>();

                editDeck2[1].transform.parent = deck2Slot2.transform;
                editDeck2[1].transform.localPosition = Vector3.zero;
                editDeck2[1].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[1].AddComponent<DeleteCardInEditMode>();

                editDeck2[2].transform.parent = deck2Slot3.transform;
                editDeck2[2].transform.localPosition = Vector3.zero;
                editDeck2[2].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[2].AddComponent<DeleteCardInEditMode>();

                editDeck2[3].transform.parent = deck2Slot4.transform;
                editDeck2[3].transform.localPosition = Vector3.zero;
                editDeck2[3].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[3].AddComponent<DeleteCardInEditMode>();

                editDeck2[4].transform.parent = deck2Slot5.transform;
                editDeck2[4].transform.localPosition = Vector3.zero;
                editDeck2[4].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[4].AddComponent<DeleteCardInEditMode>();

                editDeck2[5].transform.parent = deck2Slot6.transform;
                editDeck2[5].transform.localPosition = Vector3.zero;
                editDeck2[5].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[5].AddComponent<DeleteCardInEditMode>();

                editDeck2[6].transform.parent = deck2Slot7.transform;
                editDeck2[6].transform.localPosition = Vector3.zero;
                editDeck2[6].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[6].AddComponent<DeleteCardInEditMode>();

                editDeck2[7].transform.parent = deck2Slot8.transform;
                editDeck2[7].transform.localPosition = Vector3.zero;
                editDeck2[7].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[7].AddComponent<DeleteCardInEditMode>();

                editDeck2[8].transform.parent = deck2Slot9.transform;
                editDeck2[8].transform.localPosition = Vector3.zero;
                editDeck2[8].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[8].AddComponent<DeleteCardInEditMode>();

                editDeck2[9].transform.parent = deck2Slot10.transform;
                editDeck2[9].transform.localPosition = Vector3.zero;
                editDeck2[9].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[9].AddComponent<DeleteCardInEditMode>();

                editDeck2[10].transform.parent = deck2Slot11.transform;
                editDeck2[10].transform.localPosition = Vector3.zero;
                editDeck2[10].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[10].AddComponent<DeleteCardInEditMode>();

                editDeck2[11].transform.parent = deck2Slot12.transform;
                editDeck2[11].transform.localPosition = Vector3.zero;
                editDeck2[11].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[11].AddComponent<DeleteCardInEditMode>();

                editDeck2[12].transform.parent = deck2Slot13.transform;
                editDeck2[12].transform.localPosition = Vector3.zero;
                editDeck2[12].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[12].AddComponent<DeleteCardInEditMode>();

                editDeck2[13].transform.parent = deck2Slot14.transform;
                editDeck2[13].transform.localPosition = Vector3.zero;
                editDeck2[13].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[13].AddComponent<DeleteCardInEditMode>();

                editDeck2[14].transform.parent = deck2Slot15.transform;
                editDeck2[14].transform.localPosition = Vector3.zero;
                editDeck2[14].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[14].AddComponent<DeleteCardInEditMode>();

                editDeck2[15].transform.parent = deck2Slot16.transform;
                editDeck2[15].transform.localPosition = Vector3.zero;
                editDeck2[15].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[15].AddComponent<DeleteCardInEditMode>();

                editDeck2[16].transform.parent = deck2Slot17.transform;
                editDeck2[16].transform.localPosition = Vector3.zero;
                editDeck2[16].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[16].AddComponent<DeleteCardInEditMode>();

                editDeck2[17].transform.parent = deck2Slot18.transform;
                editDeck2[17].transform.localPosition = Vector3.zero;
                editDeck2[17].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[17].AddComponent<DeleteCardInEditMode>();

                editDeck2[18].transform.parent = deck2Slot19.transform;
                editDeck2[18].transform.localPosition = Vector3.zero;
                editDeck2[18].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[18].AddComponent<DeleteCardInEditMode>();

                editDeck2[19].transform.parent = deck2Slot20.transform;
                editDeck2[19].transform.localPosition = Vector3.zero;
                editDeck2[19].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[19].AddComponent<DeleteCardInEditMode>();

                editDeck2[20].transform.parent = deck2Slot21.transform;
                editDeck2[20].transform.localPosition = Vector3.zero;
                editDeck2[20].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[20].AddComponent<DeleteCardInEditMode>();

                editDeck2[21].transform.parent = deck2Slot22.transform;
                editDeck2[21].transform.localPosition = Vector3.zero;
                editDeck2[21].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[21].AddComponent<DeleteCardInEditMode>();

                editDeck2[22].transform.parent = deck2Slot23.transform;
                editDeck2[22].transform.localPosition = Vector3.zero;
                editDeck2[22].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[22].AddComponent<DeleteCardInEditMode>();

                editDeck2[23].transform.parent = deck2Slot24.transform;
                editDeck2[23].transform.localPosition = Vector3.zero;
                editDeck2[23].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[23].AddComponent<DeleteCardInEditMode>();

                editDeck2[24].transform.parent = deck2Slot25.transform;
                editDeck2[24].transform.localPosition = Vector3.zero;
                editDeck2[24].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[24].AddComponent<DeleteCardInEditMode>();

                editDeck2[25].transform.parent = deck2Slot26.transform;
                editDeck2[25].transform.localPosition = Vector3.zero;
                editDeck2[25].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[25].AddComponent<DeleteCardInEditMode>();

                editDeck2[26].transform.parent = deck2Slot27.transform;
                editDeck2[26].transform.localPosition = Vector3.zero;
                editDeck2[26].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[26].AddComponent<DeleteCardInEditMode>();

                editDeck2[27].transform.parent = deck2Slot28.transform;
                editDeck2[27].transform.localPosition = Vector3.zero;
                editDeck2[27].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[27].AddComponent<DeleteCardInEditMode>();

                editDeck2[28].transform.parent = deck2Slot29.transform;
                editDeck2[28].transform.localPosition = Vector3.zero;
                editDeck2[28].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[28].AddComponent<DeleteCardInEditMode>();

                editDeck2[29].transform.parent = deck2Slot30.transform;
                editDeck2[29].transform.localPosition = Vector3.zero;
                editDeck2[29].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[29].AddComponent<DeleteCardInEditMode>();

                editDeck2[30].transform.parent = deck2Slot31.transform;
                editDeck2[30].transform.localPosition = Vector3.zero;
                editDeck2[30].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[30].AddComponent<DeleteCardInEditMode>();

                editDeck2[31].transform.parent = deck2Slot32.transform;
                editDeck2[31].transform.localPosition = Vector3.zero;
                editDeck2[31].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[31].AddComponent<DeleteCardInEditMode>();

                editDeck2[32].transform.parent = deck2Slot33.transform;
                editDeck2[32].transform.localPosition = Vector3.zero;
                editDeck2[32].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[32].AddComponent<DeleteCardInEditMode>();

                editDeck2[33].transform.parent = deck2Slot34.transform;
                editDeck2[33].transform.localPosition = Vector3.zero;
                editDeck2[33].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[33].AddComponent<DeleteCardInEditMode>();

                editDeck2[34].transform.parent = deck2Slot35.transform;
                editDeck2[34].transform.localPosition = Vector3.zero;
                editDeck2[34].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[34].AddComponent<DeleteCardInEditMode>();

            } else if (editDeck2.Count == 40) {

                editDeck2[0].transform.parent = deck2Slot1.transform;
                editDeck2[0].transform.localPosition = Vector3.zero;
                editDeck2[0].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[0].AddComponent<DeleteCardInEditMode>();

                editDeck2[1].transform.parent = deck2Slot2.transform;
                editDeck2[1].transform.localPosition = Vector3.zero;
                editDeck2[1].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[1].AddComponent<DeleteCardInEditMode>();

                editDeck2[2].transform.parent = deck2Slot3.transform;
                editDeck2[2].transform.localPosition = Vector3.zero;
                editDeck2[2].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[2].AddComponent<DeleteCardInEditMode>();

                editDeck2[3].transform.parent = deck2Slot4.transform;
                editDeck2[3].transform.localPosition = Vector3.zero;
                editDeck2[3].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[3].AddComponent<DeleteCardInEditMode>();

                editDeck2[4].transform.parent = deck2Slot5.transform;
                editDeck2[4].transform.localPosition = Vector3.zero;
                editDeck2[4].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[4].AddComponent<DeleteCardInEditMode>();

                editDeck2[5].transform.parent = deck2Slot6.transform;
                editDeck2[5].transform.localPosition = Vector3.zero;
                editDeck2[5].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[5].AddComponent<DeleteCardInEditMode>();

                editDeck2[6].transform.parent = deck2Slot7.transform;
                editDeck2[6].transform.localPosition = Vector3.zero;
                editDeck2[6].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[6].AddComponent<DeleteCardInEditMode>();

                editDeck2[7].transform.parent = deck2Slot8.transform;
                editDeck2[7].transform.localPosition = Vector3.zero;
                editDeck2[7].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[7].AddComponent<DeleteCardInEditMode>();

                editDeck2[8].transform.parent = deck2Slot9.transform;
                editDeck2[8].transform.localPosition = Vector3.zero;
                editDeck2[8].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[8].AddComponent<DeleteCardInEditMode>();

                editDeck2[9].transform.parent = deck2Slot10.transform;
                editDeck2[9].transform.localPosition = Vector3.zero;
                editDeck2[9].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[9].AddComponent<DeleteCardInEditMode>();

                editDeck2[10].transform.parent = deck2Slot11.transform;
                editDeck2[10].transform.localPosition = Vector3.zero;
                editDeck2[10].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[10].AddComponent<DeleteCardInEditMode>();

                editDeck2[11].transform.parent = deck2Slot12.transform;
                editDeck2[11].transform.localPosition = Vector3.zero;
                editDeck2[11].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[11].AddComponent<DeleteCardInEditMode>();

                editDeck2[12].transform.parent = deck2Slot13.transform;
                editDeck2[12].transform.localPosition = Vector3.zero;
                editDeck2[12].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[12].AddComponent<DeleteCardInEditMode>();

                editDeck2[13].transform.parent = deck2Slot14.transform;
                editDeck2[13].transform.localPosition = Vector3.zero;
                editDeck2[13].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[13].AddComponent<DeleteCardInEditMode>();

                editDeck2[14].transform.parent = deck2Slot15.transform;
                editDeck2[14].transform.localPosition = Vector3.zero;
                editDeck2[14].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[14].AddComponent<DeleteCardInEditMode>();

                editDeck2[15].transform.parent = deck2Slot16.transform;
                editDeck2[15].transform.localPosition = Vector3.zero;
                editDeck2[15].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[15].AddComponent<DeleteCardInEditMode>();

                editDeck2[16].transform.parent = deck2Slot17.transform;
                editDeck2[16].transform.localPosition = Vector3.zero;
                editDeck2[16].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[16].AddComponent<DeleteCardInEditMode>();

                editDeck2[17].transform.parent = deck2Slot18.transform;
                editDeck2[17].transform.localPosition = Vector3.zero;
                editDeck2[17].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[17].AddComponent<DeleteCardInEditMode>();

                editDeck2[18].transform.parent = deck2Slot19.transform;
                editDeck2[18].transform.localPosition = Vector3.zero;
                editDeck2[18].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[18].AddComponent<DeleteCardInEditMode>();

                editDeck2[19].transform.parent = deck2Slot20.transform;
                editDeck2[19].transform.localPosition = Vector3.zero;
                editDeck2[19].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[19].AddComponent<DeleteCardInEditMode>();

                editDeck2[20].transform.parent = deck2Slot21.transform;
                editDeck2[20].transform.localPosition = Vector3.zero;
                editDeck2[20].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[20].AddComponent<DeleteCardInEditMode>();

                editDeck2[21].transform.parent = deck2Slot22.transform;
                editDeck2[21].transform.localPosition = Vector3.zero;
                editDeck2[21].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[21].AddComponent<DeleteCardInEditMode>();

                editDeck2[22].transform.parent = deck2Slot23.transform;
                editDeck2[22].transform.localPosition = Vector3.zero;
                editDeck2[22].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[22].AddComponent<DeleteCardInEditMode>();

                editDeck2[23].transform.parent = deck2Slot24.transform;
                editDeck2[23].transform.localPosition = Vector3.zero;
                editDeck2[23].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[23].AddComponent<DeleteCardInEditMode>();

                editDeck2[24].transform.parent = deck2Slot25.transform;
                editDeck2[24].transform.localPosition = Vector3.zero;
                editDeck2[24].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[24].AddComponent<DeleteCardInEditMode>();

                editDeck2[25].transform.parent = deck2Slot26.transform;
                editDeck2[25].transform.localPosition = Vector3.zero;
                editDeck2[25].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[25].AddComponent<DeleteCardInEditMode>();

                editDeck2[26].transform.parent = deck2Slot27.transform;
                editDeck2[26].transform.localPosition = Vector3.zero;
                editDeck2[26].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[26].AddComponent<DeleteCardInEditMode>();

                editDeck2[27].transform.parent = deck2Slot28.transform;
                editDeck2[27].transform.localPosition = Vector3.zero;
                editDeck2[27].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[27].AddComponent<DeleteCardInEditMode>();

                editDeck2[28].transform.parent = deck2Slot29.transform;
                editDeck2[28].transform.localPosition = Vector3.zero;
                editDeck2[28].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[28].AddComponent<DeleteCardInEditMode>();

                editDeck2[29].transform.parent = deck2Slot30.transform;
                editDeck2[29].transform.localPosition = Vector3.zero;
                editDeck2[29].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[29].AddComponent<DeleteCardInEditMode>();

                editDeck2[30].transform.parent = deck2Slot31.transform;
                editDeck2[30].transform.localPosition = Vector3.zero;
                editDeck2[30].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[30].AddComponent<DeleteCardInEditMode>();

                editDeck2[31].transform.parent = deck2Slot32.transform;
                editDeck2[31].transform.localPosition = Vector3.zero;
                editDeck2[31].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[31].AddComponent<DeleteCardInEditMode>();

                editDeck2[32].transform.parent = deck2Slot33.transform;
                editDeck2[32].transform.localPosition = Vector3.zero;
                editDeck2[32].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[32].AddComponent<DeleteCardInEditMode>();

                editDeck2[33].transform.parent = deck2Slot34.transform;
                editDeck2[33].transform.localPosition = Vector3.zero;
                editDeck2[33].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[33].AddComponent<DeleteCardInEditMode>();

                editDeck2[34].transform.parent = deck2Slot35.transform;
                editDeck2[34].transform.localPosition = Vector3.zero;
                editDeck2[34].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[34].AddComponent<DeleteCardInEditMode>();

                editDeck2[35].transform.parent = deck2Slot36.transform;
                editDeck2[35].transform.localPosition = Vector3.zero;
                editDeck2[35].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[35].AddComponent<DeleteCardInEditMode>();

                editDeck2[36].transform.parent = deck2Slot37.transform;
                editDeck2[36].transform.localPosition = Vector3.zero;
                editDeck2[36].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[36].AddComponent<DeleteCardInEditMode>();

                editDeck2[37].transform.parent = deck2Slot38.transform;
                editDeck2[37].transform.localPosition = Vector3.zero;
                editDeck2[37].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[37].AddComponent<DeleteCardInEditMode>();

                editDeck2[38].transform.parent = deck2Slot39.transform;
                editDeck2[38].transform.localPosition = Vector3.zero;
                editDeck2[38].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[38].AddComponent<DeleteCardInEditMode>();

                editDeck2[39].transform.parent = deck2Slot40.transform;
                editDeck2[39].transform.localPosition = Vector3.zero;
                editDeck2[39].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[39].AddComponent<DeleteCardInEditMode>();

            } else if (editDeck2.Count == 45) {

                editDeck2[0].transform.parent = deck2Slot1.transform;
                editDeck2[0].transform.localPosition = Vector3.zero;
                editDeck2[0].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[0].AddComponent<DeleteCardInEditMode>();

                editDeck2[1].transform.parent = deck2Slot2.transform;
                editDeck2[1].transform.localPosition = Vector3.zero;
                editDeck2[1].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[1].AddComponent<DeleteCardInEditMode>();

                editDeck2[2].transform.parent = deck2Slot3.transform;
                editDeck2[2].transform.localPosition = Vector3.zero;
                editDeck2[2].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[2].AddComponent<DeleteCardInEditMode>();

                editDeck2[3].transform.parent = deck2Slot4.transform;
                editDeck2[3].transform.localPosition = Vector3.zero;
                editDeck2[3].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[3].AddComponent<DeleteCardInEditMode>();

                editDeck2[4].transform.parent = deck2Slot5.transform;
                editDeck2[4].transform.localPosition = Vector3.zero;
                editDeck2[4].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[4].AddComponent<DeleteCardInEditMode>();

                editDeck2[5].transform.parent = deck2Slot6.transform;
                editDeck2[5].transform.localPosition = Vector3.zero;
                editDeck2[5].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[5].AddComponent<DeleteCardInEditMode>();

                editDeck2[6].transform.parent = deck2Slot7.transform;
                editDeck2[6].transform.localPosition = Vector3.zero;
                editDeck2[6].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[6].AddComponent<DeleteCardInEditMode>();

                editDeck2[7].transform.parent = deck2Slot8.transform;
                editDeck2[7].transform.localPosition = Vector3.zero;
                editDeck2[7].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[7].AddComponent<DeleteCardInEditMode>();

                editDeck2[8].transform.parent = deck2Slot9.transform;
                editDeck2[8].transform.localPosition = Vector3.zero;
                editDeck2[8].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[8].AddComponent<DeleteCardInEditMode>();

                editDeck2[9].transform.parent = deck2Slot10.transform;
                editDeck2[9].transform.localPosition = Vector3.zero;
                editDeck2[9].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[9].AddComponent<DeleteCardInEditMode>();

                editDeck2[10].transform.parent = deck2Slot11.transform;
                editDeck2[10].transform.localPosition = Vector3.zero;
                editDeck2[10].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[10].AddComponent<DeleteCardInEditMode>();

                editDeck2[11].transform.parent = deck2Slot12.transform;
                editDeck2[11].transform.localPosition = Vector3.zero;
                editDeck2[11].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[11].AddComponent<DeleteCardInEditMode>();

                editDeck2[12].transform.parent = deck2Slot13.transform;
                editDeck2[12].transform.localPosition = Vector3.zero;
                editDeck2[12].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[12].AddComponent<DeleteCardInEditMode>();

                editDeck2[13].transform.parent = deck2Slot14.transform;
                editDeck2[13].transform.localPosition = Vector3.zero;
                editDeck2[13].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[13].AddComponent<DeleteCardInEditMode>();

                editDeck2[14].transform.parent = deck2Slot15.transform;
                editDeck2[14].transform.localPosition = Vector3.zero;
                editDeck2[14].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[14].AddComponent<DeleteCardInEditMode>();

                editDeck2[15].transform.parent = deck2Slot16.transform;
                editDeck2[15].transform.localPosition = Vector3.zero;
                editDeck2[15].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[15].AddComponent<DeleteCardInEditMode>();

                editDeck2[16].transform.parent = deck2Slot17.transform;
                editDeck2[16].transform.localPosition = Vector3.zero;
                editDeck2[16].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[16].AddComponent<DeleteCardInEditMode>();

                editDeck2[17].transform.parent = deck2Slot18.transform;
                editDeck2[17].transform.localPosition = Vector3.zero;
                editDeck2[17].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[17].AddComponent<DeleteCardInEditMode>();

                editDeck2[18].transform.parent = deck2Slot19.transform;
                editDeck2[18].transform.localPosition = Vector3.zero;
                editDeck2[18].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[18].AddComponent<DeleteCardInEditMode>();

                editDeck2[19].transform.parent = deck2Slot20.transform;
                editDeck2[19].transform.localPosition = Vector3.zero;
                editDeck2[19].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[19].AddComponent<DeleteCardInEditMode>();

                editDeck2[20].transform.parent = deck2Slot21.transform;
                editDeck2[20].transform.localPosition = Vector3.zero;
                editDeck2[20].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[20].AddComponent<DeleteCardInEditMode>();

                editDeck2[21].transform.parent = deck2Slot22.transform;
                editDeck2[21].transform.localPosition = Vector3.zero;
                editDeck2[21].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[21].AddComponent<DeleteCardInEditMode>();

                editDeck2[22].transform.parent = deck2Slot23.transform;
                editDeck2[22].transform.localPosition = Vector3.zero;
                editDeck2[22].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[22].AddComponent<DeleteCardInEditMode>();

                editDeck2[23].transform.parent = deck2Slot24.transform;
                editDeck2[23].transform.localPosition = Vector3.zero;
                editDeck2[23].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[23].AddComponent<DeleteCardInEditMode>();

                editDeck2[24].transform.parent = deck2Slot25.transform;
                editDeck2[24].transform.localPosition = Vector3.zero;
                editDeck2[24].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[24].AddComponent<DeleteCardInEditMode>();

                editDeck2[25].transform.parent = deck2Slot26.transform;
                editDeck2[25].transform.localPosition = Vector3.zero;
                editDeck2[25].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[25].AddComponent<DeleteCardInEditMode>();

                editDeck2[26].transform.parent = deck2Slot27.transform;
                editDeck2[26].transform.localPosition = Vector3.zero;
                editDeck2[26].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[26].AddComponent<DeleteCardInEditMode>();

                editDeck2[27].transform.parent = deck2Slot28.transform;
                editDeck2[27].transform.localPosition = Vector3.zero;
                editDeck2[27].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[27].AddComponent<DeleteCardInEditMode>();

                editDeck2[28].transform.parent = deck2Slot29.transform;
                editDeck2[28].transform.localPosition = Vector3.zero;
                editDeck2[28].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[28].AddComponent<DeleteCardInEditMode>();

                editDeck2[29].transform.parent = deck2Slot30.transform;
                editDeck2[29].transform.localPosition = Vector3.zero;
                editDeck2[29].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[29].AddComponent<DeleteCardInEditMode>();

                editDeck2[30].transform.parent = deck2Slot31.transform;
                editDeck2[30].transform.localPosition = Vector3.zero;
                editDeck2[30].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[30].AddComponent<DeleteCardInEditMode>();

                editDeck2[31].transform.parent = deck2Slot32.transform;
                editDeck2[31].transform.localPosition = Vector3.zero;
                editDeck2[31].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[31].AddComponent<DeleteCardInEditMode>();

                editDeck2[32].transform.parent = deck2Slot33.transform;
                editDeck2[32].transform.localPosition = Vector3.zero;
                editDeck2[32].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[32].AddComponent<DeleteCardInEditMode>();

                editDeck2[33].transform.parent = deck2Slot34.transform;
                editDeck2[33].transform.localPosition = Vector3.zero;
                editDeck2[33].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[33].AddComponent<DeleteCardInEditMode>();

                editDeck2[34].transform.parent = deck2Slot35.transform;
                editDeck2[34].transform.localPosition = Vector3.zero;
                editDeck2[34].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[34].AddComponent<DeleteCardInEditMode>();

                editDeck2[35].transform.parent = deck2Slot36.transform;
                editDeck2[35].transform.localPosition = Vector3.zero;
                editDeck2[35].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[35].AddComponent<DeleteCardInEditMode>();

                editDeck2[36].transform.parent = deck2Slot37.transform;
                editDeck2[36].transform.localPosition = Vector3.zero;
                editDeck2[36].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[36].AddComponent<DeleteCardInEditMode>();

                editDeck2[37].transform.parent = deck2Slot38.transform;
                editDeck2[37].transform.localPosition = Vector3.zero;
                editDeck2[37].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[37].AddComponent<DeleteCardInEditMode>();

                editDeck2[38].transform.parent = deck2Slot39.transform;
                editDeck2[38].transform.localPosition = Vector3.zero;
                editDeck2[38].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[38].AddComponent<DeleteCardInEditMode>();

                editDeck2[39].transform.parent = deck2Slot40.transform;
                editDeck2[39].transform.localPosition = Vector3.zero;
                editDeck2[39].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[39].AddComponent<DeleteCardInEditMode>();

                editDeck2[40].transform.parent = deck2Slot41.transform;
                editDeck2[40].transform.localPosition = Vector3.zero;
                editDeck2[40].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[40].AddComponent<DeleteCardInEditMode>();

                editDeck2[41].transform.parent = deck2Slot42.transform;
                editDeck2[41].transform.localPosition = Vector3.zero;
                editDeck2[41].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[41].AddComponent<DeleteCardInEditMode>();

                editDeck2[42].transform.parent = deck2Slot43.transform;
                editDeck2[42].transform.localPosition = Vector3.zero;
                editDeck2[42].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[42].AddComponent<DeleteCardInEditMode>();

                editDeck2[43].transform.parent = deck2Slot44.transform;
                editDeck2[43].transform.localPosition = Vector3.zero;
                editDeck2[43].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[43].AddComponent<DeleteCardInEditMode>();

                editDeck2[44].transform.parent = deck2Slot45.transform;
                editDeck2[44].transform.localPosition = Vector3.zero;
                editDeck2[44].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[44].AddComponent<DeleteCardInEditMode>();

            } else if (editDeck2.Count == 50) {

                editDeck2[0].transform.parent = deck2Slot1.transform;
                editDeck2[0].transform.localPosition = Vector3.zero;
                editDeck2[0].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[0].AddComponent<DeleteCardInEditMode>();

                editDeck2[1].transform.parent = deck2Slot2.transform;
                editDeck2[1].transform.localPosition = Vector3.zero;
                editDeck2[1].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[1].AddComponent<DeleteCardInEditMode>();

                editDeck2[2].transform.parent = deck2Slot3.transform;
                editDeck2[2].transform.localPosition = Vector3.zero;
                editDeck2[2].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[2].AddComponent<DeleteCardInEditMode>();

                editDeck2[3].transform.parent = deck2Slot4.transform;
                editDeck2[3].transform.localPosition = Vector3.zero;
                editDeck2[3].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[3].AddComponent<DeleteCardInEditMode>();

                editDeck2[4].transform.parent = deck2Slot5.transform;
                editDeck2[4].transform.localPosition = Vector3.zero;
                editDeck2[4].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[4].AddComponent<DeleteCardInEditMode>();

                editDeck2[5].transform.parent = deck2Slot6.transform;
                editDeck2[5].transform.localPosition = Vector3.zero;
                editDeck2[5].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[5].AddComponent<DeleteCardInEditMode>();

                editDeck2[6].transform.parent = deck2Slot7.transform;
                editDeck2[6].transform.localPosition = Vector3.zero;
                editDeck2[6].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[6].AddComponent<DeleteCardInEditMode>();

                editDeck2[7].transform.parent = deck2Slot8.transform;
                editDeck2[7].transform.localPosition = Vector3.zero;
                editDeck2[7].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[7].AddComponent<DeleteCardInEditMode>();

                editDeck2[8].transform.parent = deck2Slot9.transform;
                editDeck2[8].transform.localPosition = Vector3.zero;
                editDeck2[8].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[8].AddComponent<DeleteCardInEditMode>();

                editDeck2[9].transform.parent = deck2Slot10.transform;
                editDeck2[9].transform.localPosition = Vector3.zero;
                editDeck2[9].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[9].AddComponent<DeleteCardInEditMode>();

                editDeck2[10].transform.parent = deck2Slot11.transform;
                editDeck2[10].transform.localPosition = Vector3.zero;
                editDeck2[10].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[10].AddComponent<DeleteCardInEditMode>();

                editDeck2[11].transform.parent = deck2Slot12.transform;
                editDeck2[11].transform.localPosition = Vector3.zero;
                editDeck2[11].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[11].AddComponent<DeleteCardInEditMode>();

                editDeck2[12].transform.parent = deck2Slot13.transform;
                editDeck2[12].transform.localPosition = Vector3.zero;
                editDeck2[12].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[12].AddComponent<DeleteCardInEditMode>();

                editDeck2[13].transform.parent = deck2Slot14.transform;
                editDeck2[13].transform.localPosition = Vector3.zero;
                editDeck2[13].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[13].AddComponent<DeleteCardInEditMode>();

                editDeck2[14].transform.parent = deck2Slot15.transform;
                editDeck2[14].transform.localPosition = Vector3.zero;
                editDeck2[14].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[14].AddComponent<DeleteCardInEditMode>();

                editDeck2[15].transform.parent = deck2Slot16.transform;
                editDeck2[15].transform.localPosition = Vector3.zero;
                editDeck2[15].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[15].AddComponent<DeleteCardInEditMode>();

                editDeck2[16].transform.parent = deck2Slot17.transform;
                editDeck2[16].transform.localPosition = Vector3.zero;
                editDeck2[16].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[16].AddComponent<DeleteCardInEditMode>();

                editDeck2[17].transform.parent = deck2Slot18.transform;
                editDeck2[17].transform.localPosition = Vector3.zero;
                editDeck2[17].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[17].AddComponent<DeleteCardInEditMode>();

                editDeck2[18].transform.parent = deck2Slot19.transform;
                editDeck2[18].transform.localPosition = Vector3.zero;
                editDeck2[18].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[18].AddComponent<DeleteCardInEditMode>();

                editDeck2[19].transform.parent = deck2Slot20.transform;
                editDeck2[19].transform.localPosition = Vector3.zero;
                editDeck2[19].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[19].AddComponent<DeleteCardInEditMode>();

                editDeck2[20].transform.parent = deck2Slot21.transform;
                editDeck2[20].transform.localPosition = Vector3.zero;
                editDeck2[20].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[20].AddComponent<DeleteCardInEditMode>();

                editDeck2[21].transform.parent = deck2Slot22.transform;
                editDeck2[21].transform.localPosition = Vector3.zero;
                editDeck2[21].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[21].AddComponent<DeleteCardInEditMode>();

                editDeck2[22].transform.parent = deck2Slot23.transform;
                editDeck2[22].transform.localPosition = Vector3.zero;
                editDeck2[22].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[22].AddComponent<DeleteCardInEditMode>();

                editDeck2[23].transform.parent = deck2Slot24.transform;
                editDeck2[23].transform.localPosition = Vector3.zero;
                editDeck2[23].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[23].AddComponent<DeleteCardInEditMode>();

                editDeck2[24].transform.parent = deck2Slot25.transform;
                editDeck2[24].transform.localPosition = Vector3.zero;
                editDeck2[24].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[24].AddComponent<DeleteCardInEditMode>();

                editDeck2[25].transform.parent = deck2Slot26.transform;
                editDeck2[25].transform.localPosition = Vector3.zero;
                editDeck2[25].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[25].AddComponent<DeleteCardInEditMode>();

                editDeck2[26].transform.parent = deck2Slot27.transform;
                editDeck2[26].transform.localPosition = Vector3.zero;
                editDeck2[26].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[26].AddComponent<DeleteCardInEditMode>();

                editDeck2[27].transform.parent = deck2Slot28.transform;
                editDeck2[27].transform.localPosition = Vector3.zero;
                editDeck2[27].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[27].AddComponent<DeleteCardInEditMode>();

                editDeck2[28].transform.parent = deck2Slot29.transform;
                editDeck2[28].transform.localPosition = Vector3.zero;
                editDeck2[28].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[28].AddComponent<DeleteCardInEditMode>();

                editDeck2[29].transform.parent = deck2Slot30.transform;
                editDeck2[29].transform.localPosition = Vector3.zero;
                editDeck2[29].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[29].AddComponent<DeleteCardInEditMode>();

                editDeck2[30].transform.parent = deck2Slot31.transform;
                editDeck2[30].transform.localPosition = Vector3.zero;
                editDeck2[30].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[30].AddComponent<DeleteCardInEditMode>();

                editDeck2[31].transform.parent = deck2Slot32.transform;
                editDeck2[31].transform.localPosition = Vector3.zero;
                editDeck2[31].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[31].AddComponent<DeleteCardInEditMode>();

                editDeck2[32].transform.parent = deck2Slot33.transform;
                editDeck2[32].transform.localPosition = Vector3.zero;
                editDeck2[32].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[32].AddComponent<DeleteCardInEditMode>();

                editDeck2[33].transform.parent = deck2Slot34.transform;
                editDeck2[33].transform.localPosition = Vector3.zero;
                editDeck2[33].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[33].AddComponent<DeleteCardInEditMode>();

                editDeck2[34].transform.parent = deck2Slot35.transform;
                editDeck2[34].transform.localPosition = Vector3.zero;
                editDeck2[34].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[34].AddComponent<DeleteCardInEditMode>();

                editDeck2[35].transform.parent = deck2Slot36.transform;
                editDeck2[35].transform.localPosition = Vector3.zero;
                editDeck2[35].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[35].AddComponent<DeleteCardInEditMode>();

                editDeck2[36].transform.parent = deck2Slot37.transform;
                editDeck2[36].transform.localPosition = Vector3.zero;
                editDeck2[36].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[36].AddComponent<DeleteCardInEditMode>();

                editDeck2[37].transform.parent = deck2Slot38.transform;
                editDeck2[37].transform.localPosition = Vector3.zero;
                editDeck2[37].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[37].AddComponent<DeleteCardInEditMode>();

                editDeck2[38].transform.parent = deck2Slot39.transform;
                editDeck2[38].transform.localPosition = Vector3.zero;
                editDeck2[38].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[38].AddComponent<DeleteCardInEditMode>();

                editDeck2[39].transform.parent = deck2Slot40.transform;
                editDeck2[39].transform.localPosition = Vector3.zero;
                editDeck2[39].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[39].AddComponent<DeleteCardInEditMode>();

                editDeck2[40].transform.parent = deck2Slot41.transform;
                editDeck2[40].transform.localPosition = Vector3.zero;
                editDeck2[40].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[40].AddComponent<DeleteCardInEditMode>();

                editDeck2[41].transform.parent = deck2Slot42.transform;
                editDeck2[41].transform.localPosition = Vector3.zero;
                editDeck2[41].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[41].AddComponent<DeleteCardInEditMode>();

                editDeck2[42].transform.parent = deck2Slot43.transform;
                editDeck2[42].transform.localPosition = Vector3.zero;
                editDeck2[42].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[42].AddComponent<DeleteCardInEditMode>();

                editDeck2[43].transform.parent = deck2Slot44.transform;
                editDeck2[43].transform.localPosition = Vector3.zero;
                editDeck2[43].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[43].AddComponent<DeleteCardInEditMode>();

                editDeck2[44].transform.parent = deck2Slot45.transform;
                editDeck2[44].transform.localPosition = Vector3.zero;
                editDeck2[44].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[44].AddComponent<DeleteCardInEditMode>();

                editDeck2[45].transform.parent = deck2Slot46.transform;
                editDeck2[45].transform.localPosition = Vector3.zero;
                editDeck2[45].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[45].AddComponent<DeleteCardInEditMode>();

                editDeck2[46].transform.parent = deck2Slot47.transform;
                editDeck2[46].transform.localPosition = Vector3.zero;
                editDeck2[46].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[46].AddComponent<DeleteCardInEditMode>();

                editDeck2[47].transform.parent = deck2Slot48.transform;
                editDeck2[47].transform.localPosition = Vector3.zero;
                editDeck2[47].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[47].AddComponent<DeleteCardInEditMode>();

                editDeck2[48].transform.parent = deck2Slot49.transform;
                editDeck2[48].transform.localPosition = Vector3.zero;
                editDeck2[48].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[48].AddComponent<DeleteCardInEditMode>();

                editDeck2[49].transform.parent = deck2Slot50.transform;
                editDeck2[49].transform.localPosition = Vector3.zero;
                editDeck2[49].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[49].AddComponent<DeleteCardInEditMode>();

            } else if (editDeck2.Count == 55) {

                editDeck2[0].transform.parent = deck2Slot1.transform;
                editDeck2[0].transform.localPosition = Vector3.zero;
                editDeck2[0].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[0].AddComponent<DeleteCardInEditMode>();

                editDeck2[1].transform.parent = deck2Slot2.transform;
                editDeck2[1].transform.localPosition = Vector3.zero;
                editDeck2[1].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[1].AddComponent<DeleteCardInEditMode>();

                editDeck2[2].transform.parent = deck2Slot3.transform;
                editDeck2[2].transform.localPosition = Vector3.zero;
                editDeck2[2].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[2].AddComponent<DeleteCardInEditMode>();

                editDeck2[3].transform.parent = deck2Slot4.transform;
                editDeck2[3].transform.localPosition = Vector3.zero;
                editDeck2[3].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[3].AddComponent<DeleteCardInEditMode>();

                editDeck2[4].transform.parent = deck2Slot5.transform;
                editDeck2[4].transform.localPosition = Vector3.zero;
                editDeck2[4].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[4].AddComponent<DeleteCardInEditMode>();

                editDeck2[5].transform.parent = deck2Slot6.transform;
                editDeck2[5].transform.localPosition = Vector3.zero;
                editDeck2[5].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[5].AddComponent<DeleteCardInEditMode>();

                editDeck2[6].transform.parent = deck2Slot7.transform;
                editDeck2[6].transform.localPosition = Vector3.zero;
                editDeck2[6].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[6].AddComponent<DeleteCardInEditMode>();

                editDeck2[7].transform.parent = deck2Slot8.transform;
                editDeck2[7].transform.localPosition = Vector3.zero;
                editDeck2[7].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[7].AddComponent<DeleteCardInEditMode>();

                editDeck2[8].transform.parent = deck2Slot9.transform;
                editDeck2[8].transform.localPosition = Vector3.zero;
                editDeck2[8].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[8].AddComponent<DeleteCardInEditMode>();

                editDeck2[9].transform.parent = deck2Slot10.transform;
                editDeck2[9].transform.localPosition = Vector3.zero;
                editDeck2[9].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[9].AddComponent<DeleteCardInEditMode>();

                editDeck2[10].transform.parent = deck2Slot11.transform;
                editDeck2[10].transform.localPosition = Vector3.zero;
                editDeck2[10].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[10].AddComponent<DeleteCardInEditMode>();

                editDeck2[11].transform.parent = deck2Slot12.transform;
                editDeck2[11].transform.localPosition = Vector3.zero;
                editDeck2[11].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[11].AddComponent<DeleteCardInEditMode>();

                editDeck2[12].transform.parent = deck2Slot13.transform;
                editDeck2[12].transform.localPosition = Vector3.zero;
                editDeck2[12].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[12].AddComponent<DeleteCardInEditMode>();

                editDeck2[13].transform.parent = deck2Slot14.transform;
                editDeck2[13].transform.localPosition = Vector3.zero;
                editDeck2[13].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[13].AddComponent<DeleteCardInEditMode>();

                editDeck2[14].transform.parent = deck2Slot15.transform;
                editDeck2[14].transform.localPosition = Vector3.zero;
                editDeck2[14].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[14].AddComponent<DeleteCardInEditMode>();

                editDeck2[15].transform.parent = deck2Slot16.transform;
                editDeck2[15].transform.localPosition = Vector3.zero;
                editDeck2[15].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[15].AddComponent<DeleteCardInEditMode>();

                editDeck2[16].transform.parent = deck2Slot17.transform;
                editDeck2[16].transform.localPosition = Vector3.zero;
                editDeck2[16].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[16].AddComponent<DeleteCardInEditMode>();

                editDeck2[17].transform.parent = deck2Slot18.transform;
                editDeck2[17].transform.localPosition = Vector3.zero;
                editDeck2[17].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[17].AddComponent<DeleteCardInEditMode>();

                editDeck2[18].transform.parent = deck2Slot19.transform;
                editDeck2[18].transform.localPosition = Vector3.zero;
                editDeck2[18].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[18].AddComponent<DeleteCardInEditMode>();

                editDeck2[19].transform.parent = deck2Slot20.transform;
                editDeck2[19].transform.localPosition = Vector3.zero;
                editDeck2[19].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[19].AddComponent<DeleteCardInEditMode>();

                editDeck2[20].transform.parent = deck2Slot21.transform;
                editDeck2[20].transform.localPosition = Vector3.zero;
                editDeck2[20].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[20].AddComponent<DeleteCardInEditMode>();

                editDeck2[21].transform.parent = deck2Slot22.transform;
                editDeck2[21].transform.localPosition = Vector3.zero;
                editDeck2[21].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[21].AddComponent<DeleteCardInEditMode>();

                editDeck2[22].transform.parent = deck2Slot23.transform;
                editDeck2[22].transform.localPosition = Vector3.zero;
                editDeck2[22].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[22].AddComponent<DeleteCardInEditMode>();

                editDeck2[23].transform.parent = deck2Slot24.transform;
                editDeck2[23].transform.localPosition = Vector3.zero;
                editDeck2[23].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[23].AddComponent<DeleteCardInEditMode>();

                editDeck2[24].transform.parent = deck2Slot25.transform;
                editDeck2[24].transform.localPosition = Vector3.zero;
                editDeck2[24].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[24].AddComponent<DeleteCardInEditMode>();

                editDeck2[25].transform.parent = deck2Slot26.transform;
                editDeck2[25].transform.localPosition = Vector3.zero;
                editDeck2[25].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[25].AddComponent<DeleteCardInEditMode>();

                editDeck2[26].transform.parent = deck2Slot27.transform;
                editDeck2[26].transform.localPosition = Vector3.zero;
                editDeck2[26].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[26].AddComponent<DeleteCardInEditMode>();

                editDeck2[27].transform.parent = deck2Slot28.transform;
                editDeck2[27].transform.localPosition = Vector3.zero;
                editDeck2[27].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[27].AddComponent<DeleteCardInEditMode>();

                editDeck2[28].transform.parent = deck2Slot29.transform;
                editDeck2[28].transform.localPosition = Vector3.zero;
                editDeck2[28].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[28].AddComponent<DeleteCardInEditMode>();

                editDeck2[29].transform.parent = deck2Slot30.transform;
                editDeck2[29].transform.localPosition = Vector3.zero;
                editDeck2[29].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[29].AddComponent<DeleteCardInEditMode>();

                editDeck2[30].transform.parent = deck2Slot31.transform;
                editDeck2[30].transform.localPosition = Vector3.zero;
                editDeck2[30].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[30].AddComponent<DeleteCardInEditMode>();

                editDeck2[31].transform.parent = deck2Slot32.transform;
                editDeck2[31].transform.localPosition = Vector3.zero;
                editDeck2[31].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[31].AddComponent<DeleteCardInEditMode>();

                editDeck2[32].transform.parent = deck2Slot33.transform;
                editDeck2[32].transform.localPosition = Vector3.zero;
                editDeck2[32].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[32].AddComponent<DeleteCardInEditMode>();

                editDeck2[33].transform.parent = deck2Slot34.transform;
                editDeck2[33].transform.localPosition = Vector3.zero;
                editDeck2[33].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[33].AddComponent<DeleteCardInEditMode>();

                editDeck2[34].transform.parent = deck2Slot35.transform;
                editDeck2[34].transform.localPosition = Vector3.zero;
                editDeck2[34].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[34].AddComponent<DeleteCardInEditMode>();

                editDeck2[35].transform.parent = deck2Slot36.transform;
                editDeck2[35].transform.localPosition = Vector3.zero;
                editDeck2[35].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[35].AddComponent<DeleteCardInEditMode>();

                editDeck2[36].transform.parent = deck2Slot37.transform;
                editDeck2[36].transform.localPosition = Vector3.zero;
                editDeck2[36].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[36].AddComponent<DeleteCardInEditMode>();

                editDeck2[37].transform.parent = deck2Slot38.transform;
                editDeck2[37].transform.localPosition = Vector3.zero;
                editDeck2[37].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[37].AddComponent<DeleteCardInEditMode>();

                editDeck2[38].transform.parent = deck2Slot39.transform;
                editDeck2[38].transform.localPosition = Vector3.zero;
                editDeck2[38].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[38].AddComponent<DeleteCardInEditMode>();

                editDeck2[39].transform.parent = deck2Slot40.transform;
                editDeck2[39].transform.localPosition = Vector3.zero;
                editDeck2[39].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[39].AddComponent<DeleteCardInEditMode>();

                editDeck2[40].transform.parent = deck2Slot41.transform;
                editDeck2[40].transform.localPosition = Vector3.zero;
                editDeck2[40].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[40].AddComponent<DeleteCardInEditMode>();

                editDeck2[41].transform.parent = deck2Slot42.transform;
                editDeck2[41].transform.localPosition = Vector3.zero;
                editDeck2[41].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[41].AddComponent<DeleteCardInEditMode>();

                editDeck2[42].transform.parent = deck2Slot43.transform;
                editDeck2[42].transform.localPosition = Vector3.zero;
                editDeck2[42].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[42].AddComponent<DeleteCardInEditMode>();

                editDeck2[43].transform.parent = deck2Slot44.transform;
                editDeck2[43].transform.localPosition = Vector3.zero;
                editDeck2[43].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[43].AddComponent<DeleteCardInEditMode>();

                editDeck2[44].transform.parent = deck2Slot45.transform;
                editDeck2[44].transform.localPosition = Vector3.zero;
                editDeck2[44].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[44].AddComponent<DeleteCardInEditMode>();

                editDeck2[45].transform.parent = deck2Slot46.transform;
                editDeck2[45].transform.localPosition = Vector3.zero;
                editDeck2[45].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[45].AddComponent<DeleteCardInEditMode>();

                editDeck2[46].transform.parent = deck2Slot47.transform;
                editDeck2[46].transform.localPosition = Vector3.zero;
                editDeck2[46].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[46].AddComponent<DeleteCardInEditMode>();

                editDeck2[47].transform.parent = deck2Slot48.transform;
                editDeck2[47].transform.localPosition = Vector3.zero;
                editDeck2[47].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[47].AddComponent<DeleteCardInEditMode>();

                editDeck2[48].transform.parent = deck2Slot49.transform;
                editDeck2[48].transform.localPosition = Vector3.zero;
                editDeck2[48].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[48].AddComponent<DeleteCardInEditMode>();

                editDeck2[49].transform.parent = deck2Slot50.transform;
                editDeck2[49].transform.localPosition = Vector3.zero;
                editDeck2[49].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[49].AddComponent<DeleteCardInEditMode>();

                editDeck2[50].transform.parent = deck2Slot51.transform;
                editDeck2[50].transform.localPosition = Vector3.zero;
                editDeck2[50].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[50].AddComponent<DeleteCardInEditMode>();

                editDeck2[51].transform.parent = deck2Slot52.transform;
                editDeck2[51].transform.localPosition = Vector3.zero;
                editDeck2[51].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[51].AddComponent<DeleteCardInEditMode>();

                editDeck2[52].transform.parent = deck2Slot53.transform;
                editDeck2[52].transform.localPosition = Vector3.zero;
                editDeck2[52].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[52].AddComponent<DeleteCardInEditMode>();

                editDeck2[53].transform.parent = deck2Slot54.transform;
                editDeck2[53].transform.localPosition = Vector3.zero;
                editDeck2[53].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[53].AddComponent<DeleteCardInEditMode>();

                editDeck2[54].transform.parent = deck2Slot55.transform;
                editDeck2[54].transform.localPosition = Vector3.zero;
                editDeck2[54].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[54].AddComponent<DeleteCardInEditMode>();

            } else if (editDeck2.Count == 60) {

                editDeck2[0].transform.parent = deck2Slot1.transform;
                editDeck2[0].transform.localPosition = Vector3.zero;
                editDeck2[0].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[0].AddComponent<DeleteCardInEditMode>();

                editDeck2[1].transform.parent = deck2Slot2.transform;
                editDeck2[1].transform.localPosition = Vector3.zero;
                editDeck2[1].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[1].AddComponent<DeleteCardInEditMode>();

                editDeck2[2].transform.parent = deck2Slot3.transform;
                editDeck2[2].transform.localPosition = Vector3.zero;
                editDeck2[2].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[2].AddComponent<DeleteCardInEditMode>();

                editDeck2[3].transform.parent = deck2Slot4.transform;
                editDeck2[3].transform.localPosition = Vector3.zero;
                editDeck2[3].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[3].AddComponent<DeleteCardInEditMode>();

                editDeck2[4].transform.parent = deck2Slot5.transform;
                editDeck2[4].transform.localPosition = Vector3.zero;
                editDeck2[4].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[4].AddComponent<DeleteCardInEditMode>();

                editDeck2[5].transform.parent = deck2Slot6.transform;
                editDeck2[5].transform.localPosition = Vector3.zero;
                editDeck2[5].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[5].AddComponent<DeleteCardInEditMode>();

                editDeck2[6].transform.parent = deck2Slot7.transform;
                editDeck2[6].transform.localPosition = Vector3.zero;
                editDeck2[6].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[6].AddComponent<DeleteCardInEditMode>();

                editDeck2[7].transform.parent = deck2Slot8.transform;
                editDeck2[7].transform.localPosition = Vector3.zero;
                editDeck2[7].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[7].AddComponent<DeleteCardInEditMode>();

                editDeck2[8].transform.parent = deck2Slot9.transform;
                editDeck2[8].transform.localPosition = Vector3.zero;
                editDeck2[8].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[8].AddComponent<DeleteCardInEditMode>();

                editDeck2[9].transform.parent = deck2Slot10.transform;
                editDeck2[9].transform.localPosition = Vector3.zero;
                editDeck2[9].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[9].AddComponent<DeleteCardInEditMode>();

                editDeck2[10].transform.parent = deck2Slot11.transform;
                editDeck2[10].transform.localPosition = Vector3.zero;
                editDeck2[10].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[10].AddComponent<DeleteCardInEditMode>();

                editDeck2[11].transform.parent = deck2Slot12.transform;
                editDeck2[11].transform.localPosition = Vector3.zero;
                editDeck2[11].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[11].AddComponent<DeleteCardInEditMode>();

                editDeck2[12].transform.parent = deck2Slot13.transform;
                editDeck2[12].transform.localPosition = Vector3.zero;
                editDeck2[12].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[12].AddComponent<DeleteCardInEditMode>();

                editDeck2[13].transform.parent = deck2Slot14.transform;
                editDeck2[13].transform.localPosition = Vector3.zero;
                editDeck2[13].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[13].AddComponent<DeleteCardInEditMode>();

                editDeck2[14].transform.parent = deck2Slot15.transform;
                editDeck2[14].transform.localPosition = Vector3.zero;
                editDeck2[14].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[14].AddComponent<DeleteCardInEditMode>();

                editDeck2[15].transform.parent = deck2Slot16.transform;
                editDeck2[15].transform.localPosition = Vector3.zero;
                editDeck2[15].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[15].AddComponent<DeleteCardInEditMode>();

                editDeck2[16].transform.parent = deck2Slot17.transform;
                editDeck2[16].transform.localPosition = Vector3.zero;
                editDeck2[16].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[16].AddComponent<DeleteCardInEditMode>();

                editDeck2[17].transform.parent = deck2Slot18.transform;
                editDeck2[17].transform.localPosition = Vector3.zero;
                editDeck2[17].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[17].AddComponent<DeleteCardInEditMode>();

                editDeck2[18].transform.parent = deck2Slot19.transform;
                editDeck2[18].transform.localPosition = Vector3.zero;
                editDeck2[18].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[18].AddComponent<DeleteCardInEditMode>();

                editDeck2[19].transform.parent = deck2Slot20.transform;
                editDeck2[19].transform.localPosition = Vector3.zero;
                editDeck2[19].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[19].AddComponent<DeleteCardInEditMode>();

                editDeck2[20].transform.parent = deck2Slot21.transform;
                editDeck2[20].transform.localPosition = Vector3.zero;
                editDeck2[20].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[20].AddComponent<DeleteCardInEditMode>();

                editDeck2[21].transform.parent = deck2Slot22.transform;
                editDeck2[21].transform.localPosition = Vector3.zero;
                editDeck2[21].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[21].AddComponent<DeleteCardInEditMode>();

                editDeck2[22].transform.parent = deck2Slot23.transform;
                editDeck2[22].transform.localPosition = Vector3.zero;
                editDeck2[22].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[22].AddComponent<DeleteCardInEditMode>();

                editDeck2[23].transform.parent = deck2Slot24.transform;
                editDeck2[23].transform.localPosition = Vector3.zero;
                editDeck2[23].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[23].AddComponent<DeleteCardInEditMode>();

                editDeck2[24].transform.parent = deck2Slot25.transform;
                editDeck2[24].transform.localPosition = Vector3.zero;
                editDeck2[24].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[24].AddComponent<DeleteCardInEditMode>();

                editDeck2[25].transform.parent = deck2Slot26.transform;
                editDeck2[25].transform.localPosition = Vector3.zero;
                editDeck2[25].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[25].AddComponent<DeleteCardInEditMode>();

                editDeck2[26].transform.parent = deck2Slot27.transform;
                editDeck2[26].transform.localPosition = Vector3.zero;
                editDeck2[26].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[26].AddComponent<DeleteCardInEditMode>();

                editDeck2[27].transform.parent = deck2Slot28.transform;
                editDeck2[27].transform.localPosition = Vector3.zero;
                editDeck2[27].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[27].AddComponent<DeleteCardInEditMode>();

                editDeck2[28].transform.parent = deck2Slot29.transform;
                editDeck2[28].transform.localPosition = Vector3.zero;
                editDeck2[28].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[28].AddComponent<DeleteCardInEditMode>();

                editDeck2[29].transform.parent = deck2Slot30.transform;
                editDeck2[29].transform.localPosition = Vector3.zero;
                editDeck2[29].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[29].AddComponent<DeleteCardInEditMode>();

                editDeck2[30].transform.parent = deck2Slot31.transform;
                editDeck2[30].transform.localPosition = Vector3.zero;
                editDeck2[30].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[30].AddComponent<DeleteCardInEditMode>();

                editDeck2[31].transform.parent = deck2Slot32.transform;
                editDeck2[31].transform.localPosition = Vector3.zero;
                editDeck2[31].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[31].AddComponent<DeleteCardInEditMode>();

                editDeck2[32].transform.parent = deck2Slot33.transform;
                editDeck2[32].transform.localPosition = Vector3.zero;
                editDeck2[32].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[32].AddComponent<DeleteCardInEditMode>();

                editDeck2[33].transform.parent = deck2Slot34.transform;
                editDeck2[33].transform.localPosition = Vector3.zero;
                editDeck2[33].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[33].AddComponent<DeleteCardInEditMode>();

                editDeck2[34].transform.parent = deck2Slot35.transform;
                editDeck2[34].transform.localPosition = Vector3.zero;
                editDeck2[34].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[34].AddComponent<DeleteCardInEditMode>();

                editDeck2[35].transform.parent = deck2Slot36.transform;
                editDeck2[35].transform.localPosition = Vector3.zero;
                editDeck2[35].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[35].AddComponent<DeleteCardInEditMode>();

                editDeck2[36].transform.parent = deck2Slot37.transform;
                editDeck2[36].transform.localPosition = Vector3.zero;
                editDeck2[36].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[36].AddComponent<DeleteCardInEditMode>();

                editDeck2[37].transform.parent = deck2Slot38.transform;
                editDeck2[37].transform.localPosition = Vector3.zero;
                editDeck2[37].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[37].AddComponent<DeleteCardInEditMode>();

                editDeck2[38].transform.parent = deck2Slot39.transform;
                editDeck2[38].transform.localPosition = Vector3.zero;
                editDeck2[38].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[38].AddComponent<DeleteCardInEditMode>();

                editDeck2[39].transform.parent = deck2Slot40.transform;
                editDeck2[39].transform.localPosition = Vector3.zero;
                editDeck2[39].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[39].AddComponent<DeleteCardInEditMode>();

                editDeck2[40].transform.parent = deck2Slot41.transform;
                editDeck2[40].transform.localPosition = Vector3.zero;
                editDeck2[40].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[40].AddComponent<DeleteCardInEditMode>();

                editDeck2[41].transform.parent = deck2Slot42.transform;
                editDeck2[41].transform.localPosition = Vector3.zero;
                editDeck2[41].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[41].AddComponent<DeleteCardInEditMode>();

                editDeck2[42].transform.parent = deck2Slot43.transform;
                editDeck2[42].transform.localPosition = Vector3.zero;
                editDeck2[42].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[42].AddComponent<DeleteCardInEditMode>();

                editDeck2[43].transform.parent = deck2Slot44.transform;
                editDeck2[43].transform.localPosition = Vector3.zero;
                editDeck2[43].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[43].AddComponent<DeleteCardInEditMode>();

                editDeck2[44].transform.parent = deck2Slot45.transform;
                editDeck2[44].transform.localPosition = Vector3.zero;
                editDeck2[44].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[44].AddComponent<DeleteCardInEditMode>();

                editDeck2[45].transform.parent = deck2Slot46.transform;
                editDeck2[45].transform.localPosition = Vector3.zero;
                editDeck2[45].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[45].AddComponent<DeleteCardInEditMode>();

                editDeck2[46].transform.parent = deck2Slot47.transform;
                editDeck2[46].transform.localPosition = Vector3.zero;
                editDeck2[46].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[46].AddComponent<DeleteCardInEditMode>();

                editDeck2[47].transform.parent = deck2Slot48.transform;
                editDeck2[47].transform.localPosition = Vector3.zero;
                editDeck2[47].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[47].AddComponent<DeleteCardInEditMode>();

                editDeck2[48].transform.parent = deck2Slot49.transform;
                editDeck2[48].transform.localPosition = Vector3.zero;
                editDeck2[48].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[48].AddComponent<DeleteCardInEditMode>();

                editDeck2[49].transform.parent = deck2Slot50.transform;
                editDeck2[49].transform.localPosition = Vector3.zero;
                editDeck2[49].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[49].AddComponent<DeleteCardInEditMode>();

                editDeck2[50].transform.parent = deck2Slot51.transform;
                editDeck2[50].transform.localPosition = Vector3.zero;
                editDeck2[50].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[50].AddComponent<DeleteCardInEditMode>();

                editDeck2[51].transform.parent = deck2Slot52.transform;
                editDeck2[51].transform.localPosition = Vector3.zero;
                editDeck2[51].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[51].AddComponent<DeleteCardInEditMode>();

                editDeck2[52].transform.parent = deck2Slot53.transform;
                editDeck2[52].transform.localPosition = Vector3.zero;
                editDeck2[52].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[52].AddComponent<DeleteCardInEditMode>();

                editDeck2[53].transform.parent = deck2Slot54.transform;
                editDeck2[53].transform.localPosition = Vector3.zero;
                editDeck2[53].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[53].AddComponent<DeleteCardInEditMode>();

                editDeck2[54].transform.parent = deck2Slot55.transform;
                editDeck2[54].transform.localPosition = Vector3.zero;
                editDeck2[54].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[54].AddComponent<DeleteCardInEditMode>();

                editDeck2[55].transform.parent = deck2Slot56.transform;
                editDeck2[55].transform.localPosition = Vector3.zero;
                editDeck2[55].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[55].AddComponent<DeleteCardInEditMode>();

                editDeck2[56].transform.parent = deck2Slot57.transform;
                editDeck2[56].transform.localPosition = Vector3.zero;
                editDeck2[56].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[56].AddComponent<DeleteCardInEditMode>();

                editDeck2[57].transform.parent = deck2Slot58.transform;
                editDeck2[57].transform.localPosition = Vector3.zero;
                editDeck2[57].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[57].AddComponent<DeleteCardInEditMode>();

                editDeck2[58].transform.parent = deck2Slot59.transform;
                editDeck2[58].transform.localPosition = Vector3.zero;
                editDeck2[58].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[58].AddComponent<DeleteCardInEditMode>();

                editDeck2[59].transform.parent = deck2Slot60.transform;
                editDeck2[59].transform.localPosition = Vector3.zero;
                editDeck2[59].GetComponent<DragObjectWithMouse>().enabled = false;
                editDeck2[59].AddComponent<DeleteCardInEditMode>();
            } else {

                return;
            }

            #endregion

            //Enable choosing cards from the collection
            DeckManager.deckManager.switcher1 = false;
            DeckManager.deckManager.switcher2 = true;
            DeckManager.deckManager.switcher3 = false;

            edit2Button.GetComponent<Button>().interactable = false;
            delete2Button.GetComponent<Button>().interactable = true;

            //if(getDeck){
            //GetCardCounterInDeck2();
            //getDeck = false;
            //}

        }



        /** Get number of the same cards in the deck */
        public static void GetCardCounterInDeck2() {

            //Only 4 the same cards possible in one deck
            #region EditCheckTheSameCards definition

            foreach (GameObject card in editDeck2) {



                if (card.name == "instantiated2Card1") {

                    instantiated2Card1List.Add(card);


                }

                if (card.name == "instantiated2Card1a") {

                    instantiated2Card1aList.Add(card);

                }

                if (card.name == "instantiated2Card1b") {

                    instantiated2Card1bList.Add(card);

                }

                if (card.name == "instantiated2Card1c") {

                    instantiated2Card1cList.Add(card);

                }

                if (card.name == "instantiated2Card2") {

                    instantiated2Card2List.Add(card);

                }

                if (card.name == "instantiated2Card2a") {

                    instantiated2Card2aList.Add(card);

                }

                if (card.name == "instantiated2Card2b") {

                    instantiated2Card2bList.Add(card);

                }

                if (card.name == "instantiated2Card2c") {

                    instantiated2Card2cList.Add(card);

                }

                if (card.name == "instantiated2Card3") {

                    instantiated2Card3List.Add(card);

                }

                if (card.name == "instantiated2Card3a") {

                    instantiated2Card3aList.Add(card);

                }

                if (card.name == "instantiated2Card3b") {

                    instantiated2Card3bList.Add(card);

                }

                if (card.name == "instantiated2Card3c") {

                    instantiated2Card3cList.Add(card);

                } else if (card.name == "instantiated2Card4") {

                    instantiated2Card4List.Add(card);

                } else if (card.name == "instantiated2Card4a") {

                    instantiated2Card4aList.Add(card);

                } else if (card.name == "instantiated2Card4b") {

                    instantiated2Card4bList.Add(card);

                } else if (card.name == "instantiated2Card4c") {

                    instantiated2Card4cList.Add(card);

                } else if (card.name == "instantiated2Card5") {

                    instantiated2Card5List.Add(card);

                } else if (card.name == "instantiated2Card5a") {

                    instantiated2Card5aList.Add(card);

                } else if (card.name == "instantiated2Card5b") {

                    instantiated2Card5bList.Add(card);

                } else if (card.name == "instantiated2Card5c") {

                    instantiated2Card5cList.Add(card);

                } else if (card.name == "instantiated2Card6") {

                    instantiated2Card6List.Add(card);

                } else if (card.name == "instantiated2Card6a") {

                    instantiated2Card6aList.Add(card);

                } else if (card.name == "instantiated2Card6b") {

                    instantiated2Card6bList.Add(card);

                } else if (card.name == "instantiated2Card6c") {

                    instantiated2Card6cList.Add(card);

                } else if (card.name == "instantiated2Card7") {

                    instantiated2Card7List.Add(card);

                } else if (card.name == "instantiated2Card7a") {

                    instantiated2Card7aList.Add(card);

                } else if (card.name == "instantiated2Card7b") {

                    instantiated2Card7bList.Add(card);

                } else if (card.name == "instantiated2Card7c") {

                    instantiated2Card7cList.Add(card);

                } else if (card.name == "instantiated2Card8") {

                    instantiated2Card8List.Add(card);

                } else if (card.name == "instantiated2Card8a") {

                    instantiated2Card8aList.Add(card);

                } else if (card.name == "instantiated2Card8b") {

                    instantiated2Card8bList.Add(card);

                } else if (card.name == "instantiated2Card8c") {

                    instantiated2Card8cList.Add(card);

                } else if (card.name == "instantiated2Card9") {

                    instantiated2Card9List.Add(card);

                } else if (card.name == "instantiated2Card9a") {

                    instantiated2Card9aList.Add(card);

                } else if (card.name == "instantiated2Card9b") {

                    instantiated2Card9bList.Add(card);

                } else if (card.name == "instantiated2Card9c") {

                    instantiated2Card9cList.Add(card);

                } else if (card.name == "instantiated2Card10") {

                    instantiated2Card10List.Add(card);

                } else if (card.name == "instantiated2Card10a") {

                    instantiated2Card10aList.Add(card);

                } else if (card.name == "instantiated2Card10b") {

                    instantiated2Card10bList.Add(card);

                } else if (card.name == "instantiated2Card10c") {

                    instantiated2Card10cList.Add(card);

                } else if (card.name == "instantiated2Card11") {

                    instantiated2Card11List.Add(card);

                } else if (card.name == "instantiated2Card11a") {

                    instantiated2Card11aList.Add(card);

                } else if (card.name == "instantiated2Card11b") {

                    instantiated2Card11bList.Add(card);

                } else if (card.name == "instantiated2Card11c") {

                    instantiated2Card11cList.Add(card);

                } else if (card.name == "instantiated2Card12") {

                    instantiated2Card12List.Add(card);

                } else if (card.name == "instantiated2Card12a") {

                    instantiated2Card12aList.Add(card);

                } else if (card.name == "instantiated2Card12b") {

                    instantiated2Card12bList.Add(card);

                } else if (card.name == "instantiated2Card12c") {

                    instantiated2Card12cList.Add(card);

                } else if (card.name == "instantiated2Card13") {

                    instantiated2Card13List.Add(card);

                } else if (card.name == "instantiated2Card13a") {

                    instantiated2Card13aList.Add(card);

                } else if (card.name == "instantiated2Card13b") {

                    instantiated2Card13bList.Add(card);

                } else if (card.name == "instantiated2Card13c") {

                    instantiated2Card13cList.Add(card);

                } else if (card.name == "instantiated2Card14") {

                    instantiated2Card14List.Add(card);

                } else if (card.name == "instantiated2Card14a") {

                    instantiated2Card14aList.Add(card);

                } else if (card.name == "instantiated2Card14b") {

                    instantiated2Card14bList.Add(card);

                } else if (card.name == "instantiated2Card14c") {

                    instantiated2Card14cList.Add(card);

                } else if (card.name == "instantiated2Card15") {

                    instantiated2Card15List.Add(card);

                } else if (card.name == "instantiated2Card15a") {

                    instantiated2Card15aList.Add(card);

                } else if (card.name == "instantiated2Card15b") {

                    instantiated2Card15bList.Add(card);

                } else if (card.name == "instantiated2Card15c") {

                    instantiated2Card15cList.Add(card);

                } else if (card.name == "instantiated2Card16") {

                    instantiated2Card16List.Add(card);

                } else if (card.name == "instantiated2Card16a") {

                    instantiated2Card16aList.Add(card);

                } else if (card.name == "instantiated2Card16b") {

                    instantiated2Card16bList.Add(card);

                } else if (card.name == "instantiated2Card16c") {

                    instantiated2Card16cList.Add(card);

                } else if (card.name == "instantiated2Card17") {

                    instantiated2Card17List.Add(card);

                } else if (card.name == "instantiated2Card17a") {

                    instantiated2Card17aList.Add(card);

                } else if (card.name == "instantiated2Card17b") {

                    instantiated2Card17bList.Add(card);

                } else if (card.name == "instantiated2Card17c") {

                    instantiated2Card17cList.Add(card);

                } else if (card.name == "instantiated2Card18") {

                    instantiated2Card18List.Add(card);

                } else if (card.name == "instantiated2Card18a") {

                    instantiated2Card18aList.Add(card);

                } else if (card.name == "instantiated2Card18b") {

                    instantiated2Card18bList.Add(card);

                } else if (card.name == "instantiated2Card18c") {

                    instantiated2Card18cList.Add(card);

                } else if (card.name == "instantiated2Card19") {

                    instantiated2Card19List.Add(card);

                } else if (card.name == "instantiated2Card19a") {

                    instantiated2Card19aList.Add(card);

                } else if (card.name == "instantiated2Card19b") {

                    instantiated2Card19bList.Add(card);

                } else if (card.name == "instantiated2Card19c") {

                    instantiated2Card19cList.Add(card);

                } else if (card.name == "instantiated2Card20") {

                    instantiated2Card20List.Add(card);

                } else if (card.name == "instantiated2Card20a") {

                    instantiated2Card20aList.Add(card);

                } else if (card.name == "instantiated2Card20b") {

                    instantiated2Card20bList.Add(card);

                } else if (card.name == "instantiated2Card20c") {

                    instantiated2Card20cList.Add(card);

                } else if (card.name == "instantiated2Card21") {

                    instantiated2Card21List.Add(card);

                } else if (card.name == "instantiated2Card21a") {

                    instantiated2Card21aList.Add(card);

                } else if (card.name == "instantiated2Card21b") {

                    instantiated2Card21bList.Add(card);

                } else if (card.name == "instantiated2Card21c") {

                    instantiated2Card21cList.Add(card);

                } else if (card.name == "instantiated2Card22") {

                    instantiated2Card22List.Add(card);

                } else if (card.name == "instantiated2Card22a") {

                    instantiated2Card22aList.Add(card);

                } else if (card.name == "instantiated2Card22b") {

                    instantiated2Card22bList.Add(card);

                } else if (card.name == "instantiated2Card22c") {

                    instantiated2Card22cList.Add(card);

                } else if (card.name == "instantiated2Card23") {

                    instantiated2Card23List.Add(card);

                } else if (card.name == "instantiated2Card23a") {

                    instantiated2Card23aList.Add(card);

                } else if (card.name == "instantiated2Card23b") {

                    instantiated2Card23bList.Add(card);

                } else if (card.name == "instantiated2Card23c") {

                    instantiated2Card23cList.Add(card);

                } else if (card.name == "instantiated2Card24") {

                    instantiated2Card24List.Add(card);

                } else if (card.name == "instantiated2Card24a") {

                    instantiated2Card24aList.Add(card);

                } else if (card.name == "instantiated2Card24b") {

                    instantiated2Card24bList.Add(card);

                } else if (card.name == "instantiated2Card24c") {

                    instantiated2Card24cList.Add(card);

                } else if (card.name == "instantiated2Card25") {

                    instantiated2Card25List.Add(card);

                } else if (card.name == "instantiated2Card25a") {

                    instantiated2Card25aList.Add(card);

                } else if (card.name == "instantiated2Card25b") {

                    instantiated2Card25bList.Add(card);

                } else if (card.name == "instantiated2Card25c") {

                    instantiated2Card25cList.Add(card);

                } else if (card.name == "instantiated2Card26") {

                    instantiated2Card26List.Add(card);

                } else if (card.name == "instantiated2Card26a") {

                    instantiated2Card26aList.Add(card);

                } else if (card.name == "instantiated2Card26b") {

                    instantiated2Card26bList.Add(card);

                } else if (card.name == "instantiated2Card26c") {

                    instantiated2Card26cList.Add(card);

                } else if (card.name == "instantiated2Card27") {

                    instantiated2Card27List.Add(card);

                } else if (card.name == "instantiated2Card27a") {

                    instantiated2Card27aList.Add(card);

                } else if (card.name == "instantiated2Card27b") {

                    instantiated2Card27bList.Add(card);

                } else if (card.name == "instantiated2Card27c") {

                    instantiated2Card27cList.Add(card);

                } else if (card.name == "instantiated2Card28") {

                    instantiated2Card28List.Add(card);

                } else if (card.name == "instantiated2Card28a") {

                    instantiated2Card28aList.Add(card);

                } else if (card.name == "instantiated2Card28b") {

                    instantiated2Card28bList.Add(card);

                } else if (card.name == "instantiated2Card28c") {

                    instantiated2Card28cList.Add(card);

                } else if (card.name == "instantiated2Card29") {

                    instantiated2Card29List.Add(card);

                } else if (card.name == "instantiated2Card29a") {

                    instantiated2Card29aList.Add(card);

                } else if (card.name == "instantiated2Card29b") {

                    instantiated2Card29bList.Add(card);

                } else if (card.name == "instantiated2Card29c") {

                    instantiated2Card29cList.Add(card);

                } else if (card.name == "instantiated2Card30") {

                    instantiated2Card30List.Add(card);

                } else if (card.name == "instantiated2Card30a") {

                    instantiated2Card30aList.Add(card);

                } else if (card.name == "instantiated2Card30b") {

                    instantiated2Card30bList.Add(card);

                } else if (card.name == "instantiated2Card30c") {

                    instantiated2Card30cList.Add(card);

                } else if (card.name == "instantiated2Card31") {

                    instantiated2Card31List.Add(card);

                } else if (card.name == "instantiated2Card31a") {

                    instantiated2Card31aList.Add(card);

                } else if (card.name == "instantiated2Card31b") {

                    instantiated2Card31bList.Add(card);

                } else if (card.name == "instantiated2Card31c") {

                    instantiated2Card31cList.Add(card);

                } else if (card.name == "instantiated2Card32") {

                    instantiated2Card32List.Add(card);

                } else if (card.name == "instantiated2Card32a") {

                    instantiated2Card32aList.Add(card);

                } else if (card.name == "instantiated2Card32b") {

                    instantiated2Card32bList.Add(card);

                } else if (card.name == "instantiated2Card32c") {

                    instantiated2Card32cList.Add(card);

                } else if (card.name == "instantiated2Card33") {

                    instantiated2Card33List.Add(card);

                } else if (card.name == "instantiated2Card33a") {

                    instantiated2Card33aList.Add(card);

                } else if (card.name == "instantiated2Card33b") {

                    instantiated2Card33bList.Add(card);

                } else if (card.name == "instantiated2Card33c") {

                    instantiated2Card33cList.Add(card);

                } else if (card.name == "instantiated2Card34") {

                    instantiated2Card34List.Add(card);

                } else if (card.name == "instantiated2Card34a") {

                    instantiated2Card34aList.Add(card);

                } else if (card.name == "instantiated2Card34b") {

                    instantiated2Card34bList.Add(card);

                } else if (card.name == "instantiated2Card34c") {

                    instantiated2Card34cList.Add(card);

                } else if (card.name == "instantiated2Card35") {

                    instantiated2Card35List.Add(card);

                } else if (card.name == "instantiated2Card35a") {

                    instantiated2Card35aList.Add(card);

                } else if (card.name == "instantiated2Card35b") {

                    instantiated2Card35bList.Add(card);

                } else if (card.name == "instantiated2Card35c") {

                    instantiated2Card35cList.Add(card);

                } else if (card.name == "instantiated2Card36") {

                    instantiated2Card36List.Add(card);

                } else if (card.name == "instantiated2Card36a") {

                    instantiated2Card36aList.Add(card);

                } else if (card.name == "instantiated2Card36b") {

                    instantiated2Card36bList.Add(card);

                } else if (card.name == "instantiated2Card36c") {

                    instantiated2Card36cList.Add(card);

                } else if (card.name == "instantiated2Card37") {

                    instantiated2Card37List.Add(card);

                } else if (card.name == "instantiated2Card37a") {

                    instantiated2Card37aList.Add(card);

                } else if (card.name == "instantiated2Card37b") {

                    instantiated2Card37bList.Add(card);

                } else if (card.name == "instantiated2Card37c") {

                    instantiated2Card37cList.Add(card);

                } else if (card.name == "instantiated2Card38") {

                    instantiated2Card38List.Add(card);

                } else if (card.name == "instantiated2Card38a") {

                    instantiated2Card38aList.Add(card);

                } else if (card.name == "instantiated2Card38b") {

                    instantiated2Card38bList.Add(card);

                } else if (card.name == "instantiated2Card38c") {

                    instantiated2Card38cList.Add(card);

                } else if (card.name == "instantiated2Card39") {

                    instantiated2Card39List.Add(card);

                } else if (card.name == "instantiated2Card39a") {

                    instantiated2Card39aList.Add(card);

                } else if (card.name == "instantiated2Card39b") {

                    instantiated2Card39bList.Add(card);

                } else if (card.name == "instantiated2Card39c") {

                    instantiated2Card39cList.Add(card);

                } else if (card.name == "instantiated2Card40") {

                    instantiated2Card40List.Add(card);

                } else if (card.name == "instantiated2Card40a") {

                    instantiated2Card40aList.Add(card);

                } else if (card.name == "instantiated2Card40b") {

                    instantiated2Card40bList.Add(card);

                } else if (card.name == "instantiated2Card40c") {

                    instantiated2Card40cList.Add(card);

                } else if (card.name == "instantiated2Card41") {

                    instantiated2Card41List.Add(card);

                } else if (card.name == "instantiated2Card41a") {

                    instantiated2Card41aList.Add(card);

                } else if (card.name == "instantiated2Card41b") {

                    instantiated2Card41bList.Add(card);

                } else if (card.name == "instantiated2Card41c") {

                    instantiated2Card41cList.Add(card);

                } else if (card.name == "instantiated2Card42") {

                    instantiated2Card42List.Add(card);

                } else if (card.name == "instantiated2Card42a") {

                    instantiated2Card42aList.Add(card);

                } else if (card.name == "instantiated2Card42b") {

                    instantiated2Card42bList.Add(card);

                } else if (card.name == "instantiated2Card42c") {

                    instantiated2Card42cList.Add(card);

                } else if (card.name == "instantiated2Card43") {

                    instantiated2Card43List.Add(card);

                } else if (card.name == "instantiated2Card43a") {

                    instantiated2Card43aList.Add(card);

                } else if (card.name == "instantiated2Card43b") {

                    instantiated2Card43bList.Add(card);

                } else if (card.name == "instantiated2Card43c") {

                    instantiated2Card43cList.Add(card);

                } else if (card.name == "instantiated2Card44") {

                    instantiated2Card44List.Add(card);

                } else if (card.name == "instantiated2Card44a") {

                    instantiated2Card44aList.Add(card);

                } else if (card.name == "instantiated2Card44b") {

                    instantiated2Card44bList.Add(card);

                } else if (card.name == "instantiated2Card44c") {

                    instantiated2Card44cList.Add(card);

                } else if (card.name == "instantiated2Card45") {

                    instantiated2Card45List.Add(card);

                } else if (card.name == "instantiated2Card45a") {

                    instantiated2Card45aList.Add(card);

                } else if (card.name == "instantiated2Card45b") {

                    instantiated2Card45bList.Add(card);

                } else if (card.name == "instantiated2Card45c") {

                    instantiated2Card45cList.Add(card);

                } else if (card.name == "instantiated2Card46") {

                    instantiated2Card46List.Add(card);

                } else if (card.name == "instantiated2Card46a") {

                    instantiated2Card46aList.Add(card);

                } else if (card.name == "instantiated2Card46b") {

                    instantiated2Card46bList.Add(card);

                } else if (card.name == "instantiated2Card46c") {

                    instantiated2Card46cList.Add(card);

                } else if (card.name == "instantiated2Card47") {

                    instantiated2Card47List.Add(card);

                } else if (card.name == "instantiated2Card47a") {

                    instantiated2Card47aList.Add(card);

                } else if (card.name == "instantiated2Card47b") {

                    instantiated2Card47bList.Add(card);

                } else if (card.name == "instantiated2Card47c") {

                    instantiated2Card47cList.Add(card);

                } else if (card.name == "instantiated2Card48") {

                    instantiated2Card48List.Add(card);

                } else if (card.name == "instantiated2Card48a") {

                    instantiated2Card48aList.Add(card);

                } else if (card.name == "instantiated2Card48b") {

                    instantiated2Card48bList.Add(card);

                } else if (card.name == "instantiated2Card48c") {

                    instantiated2Card48cList.Add(card);

                } else if (card.name == "instantiated2Card49") {

                    instantiated2Card49List.Add(card);

                } else if (card.name == "instantiated2Card49a") {

                    instantiated2Card49aList.Add(card);

                } else if (card.name == "instantiated2Card49b") {

                    instantiated2Card49bList.Add(card);

                } else if (card.name == "instantiated2Card49c") {

                    instantiated2Card49cList.Add(card);

                } else if (card.name == "instantiated2Card50") {

                    instantiated2Card50List.Add(card);

                } else if (card.name == "instantiated2Card50a") {

                    instantiated2Card50aList.Add(card);

                } else if (card.name == "instantiated2Card50b") {

                    instantiated2Card50bList.Add(card);

                } else if (card.name == "instantiated2Card50c") {

                    instantiated2Card50cList.Add(card);

                } else if (card.name == "instantiated2Card51") {

                    instantiated2Card51List.Add(card);

                } else if (card.name == "instantiated2Card51a") {

                    instantiated2Card51aList.Add(card);

                } else if (card.name == "instantiated2Card51b") {

                    instantiated2Card51bList.Add(card);

                } else if (card.name == "instantiated2Card51c") {

                    instantiated2Card51cList.Add(card);

                } else if (card.name == "instantiated2Card52") {

                    instantiated2Card52List.Add(card);

                } else if (card.name == "instantiated2Card52a") {

                    instantiated2Card52aList.Add(card);

                } else if (card.name == "instantiated2Card52b") {

                    instantiated2Card52bList.Add(card);

                } else if (card.name == "instantiated2Card52c") {

                    instantiated2Card52cList.Add(card);

                } else if (card.name == "instantiated2Card53") {

                    instantiated2Card53List.Add(card);

                } else if (card.name == "instantiated2Card53a") {

                    instantiated2Card53aList.Add(card);

                } else if (card.name == "instantiated2Card53b") {

                    instantiated2Card53bList.Add(card);

                } else if (card.name == "instantiated2Card53c") {

                    instantiated2Card53cList.Add(card);

                } else if (card.name == "instantiated2Card54") {

                    instantiated2Card54List.Add(card);

                } else if (card.name == "instantiated2Card54a") {

                    instantiated2Card54aList.Add(card);

                } else if (card.name == "instantiated2Card54b") {

                    instantiated2Card54bList.Add(card);

                } else if (card.name == "instantiated2Card54c") {

                    instantiated2Card54cList.Add(card);

                } else if (card.name == "instantiated2Card55") {

                    instantiated2Card55List.Add(card);

                } else if (card.name == "instantiated2Card55a") {

                    instantiated2Card55aList.Add(card);

                } else if (card.name == "instantiated2Card55b") {

                    instantiated2Card55bList.Add(card);

                } else if (card.name == "instantiated2Card55c") {

                    instantiated2Card55cList.Add(card);

                } else if (card.name == "instantiated2Card56") {

                    instantiated2Card56List.Add(card);

                } else if (card.name == "instantiated2Card56a") {

                    instantiated2Card56aList.Add(card);

                } else if (card.name == "instantiated2Card56b") {

                    instantiated2Card56bList.Add(card);

                } else if (card.name == "instantiated2Card56c") {

                    instantiated2Card56cList.Add(card);

                } else if (card.name == "instantiated2Card57") {

                    instantiated2Card57List.Add(card);

                } else if (card.name == "instantiated2Card57a") {

                    instantiated2Card57aList.Add(card);

                } else if (card.name == "instantiated2Card57b") {

                    instantiated2Card57bList.Add(card);

                } else if (card.name == "instantiated2Card57c") {

                    instantiated2Card57cList.Add(card);

                } else if (card.name == "instantiated2Card58") {

                    instantiated2Card58List.Add(card);

                } else if (card.name == "instantiated2Card58a") {

                    instantiated2Card58aList.Add(card);

                } else if (card.name == "instantiated2Card58b") {

                    instantiated2Card58bList.Add(card);

                } else if (card.name == "instantiated2Card58c") {

                    instantiated2Card58cList.Add(card);

                } else if (card.name == "instantiated2Card59") {

                    instantiated2Card59List.Add(card);

                } else if (card.name == "instantiated2Card59a") {

                    instantiated2Card59aList.Add(card);

                } else if (card.name == "instantiated2Card59b") {

                    instantiated2Card59bList.Add(card);

                } else if (card.name == "instantiated2Card59c") {

                    instantiated2Card59cList.Add(card);

                } else if (card.name == "instantiated2Card60") {

                    instantiated2Card60List.Add(card);

                } else if (card.name == "instantiated2Card60a") {

                    instantiated2Card60aList.Add(card);

                } else if (card.name == "instantiated2Card60b") {

                    instantiated2Card60bList.Add(card);

                } else if (card.name == "instantiated2Card60c") {

                    instantiated2Card60cList.Add(card);

                }




            }
            CardCounterManager.counter1 += instantiated2Card1List.Count;
            CardCounterManager.CardCounter1();

            CardCounterManager.counter1a += instantiated2Card1aList.Count;
            CardCounterManager.CardCounter1a();

            CardCounterManager.counter1b += instantiated2Card1bList.Count;
            CardCounterManager.CardCounter1b();

            CardCounterManager.counter1c += instantiated2Card1cList.Count;
            CardCounterManager.CardCounter1c();

            CardCounterManager.counter2 += instantiated2Card2List.Count;
            CardCounterManager.CardCounter2();

            CardCounterManager.counter2a += instantiated2Card2aList.Count;
            CardCounterManager.CardCounter2a();

            CardCounterManager.counter2b += instantiated2Card2bList.Count;
            CardCounterManager.CardCounter2b();

            CardCounterManager.counter2c += instantiated2Card2cList.Count;
            CardCounterManager.CardCounter2c();

            CardCounterManager.counter3 += instantiated2Card3List.Count;
            CardCounterManager.CardCounter3();

            CardCounterManager.counter3a += instantiated2Card3aList.Count;
            CardCounterManager.CardCounter3a();

            CardCounterManager.counter3b += instantiated2Card3bList.Count;
            CardCounterManager.CardCounter3b();

            CardCounterManager.counter3c += instantiated2Card3cList.Count;
            CardCounterManager.CardCounter3c();

            CardCounterManager.counter4 += instantiated2Card4List.Count;
            CardCounterManager.CardCounter4();

            CardCounterManager.counter4a += instantiated2Card4aList.Count;
            CardCounterManager.CardCounter4a();

            CardCounterManager.counter4b += instantiated2Card4bList.Count;
            CardCounterManager.CardCounter4b();

            CardCounterManager.counter4c += instantiated2Card4cList.Count;
            CardCounterManager.CardCounter4c();

            CardCounterManager.counter5 += instantiated2Card5List.Count;
            CardCounterManager.CardCounter5();

            CardCounterManager.counter5a += instantiated2Card5aList.Count;
            CardCounterManager.CardCounter5a();

            CardCounterManager.counter5b += instantiated2Card5bList.Count;
            CardCounterManager.CardCounter5b();

            CardCounterManager.counter5c += instantiated2Card5cList.Count;
            CardCounterManager.CardCounter5c();

            CardCounterManager.counter6 += instantiated2Card6List.Count;
            CardCounterManager.CardCounter6();

            CardCounterManager.counter6a += instantiated2Card6aList.Count;
            CardCounterManager.CardCounter6a();

            CardCounterManager.counter6b += instantiated2Card6bList.Count;
            CardCounterManager.CardCounter6b();

            CardCounterManager.counter6c += instantiated2Card6cList.Count;
            CardCounterManager.CardCounter6c();

            CardCounterManager.counter7 += instantiated2Card7List.Count;
            CardCounterManager.CardCounter7();

            CardCounterManager.counter7a += instantiated2Card7aList.Count;
            CardCounterManager.CardCounter7a();

            CardCounterManager.counter7b += instantiated2Card7bList.Count;
            CardCounterManager.CardCounter7b();

            CardCounterManager.counter7c += instantiated2Card7cList.Count;
            CardCounterManager.CardCounter7c();

            CardCounterManager.counter8 += instantiated2Card8List.Count;
            CardCounterManager.CardCounter8();

            CardCounterManager.counter8a += instantiated2Card8aList.Count;
            CardCounterManager.CardCounter8a();

            CardCounterManager.counter8b += instantiated2Card8bList.Count;
            CardCounterManager.CardCounter8b();

            CardCounterManager.counter8c += instantiated2Card8cList.Count;
            CardCounterManager.CardCounter8c();

            CardCounterManager.counter9 += instantiated2Card9List.Count;
            CardCounterManager.CardCounter9();

            CardCounterManager.counter9a += instantiated2Card9aList.Count;
            CardCounterManager.CardCounter9a();

            CardCounterManager.counter9b += instantiated2Card9bList.Count;
            CardCounterManager.CardCounter9b();

            CardCounterManager.counter9c += instantiated2Card9cList.Count;
            CardCounterManager.CardCounter9c();

            CardCounterManager.counter10 += instantiated2Card10List.Count;
            CardCounterManager.CardCounter10();

            CardCounterManager.counter10a += instantiated2Card10aList.Count;
            CardCounterManager.CardCounter10a();

            CardCounterManager.counter10b += instantiated2Card10bList.Count;
            CardCounterManager.CardCounter10b();

            CardCounterManager.counter10c += instantiated2Card10cList.Count;
            CardCounterManager.CardCounter10c();

            CardCounterManager.counter11 += instantiated2Card11List.Count;
            CardCounterManager.CardCounter11();

            CardCounterManager.counter11a += instantiated2Card11aList.Count;
            CardCounterManager.CardCounter11a();

            CardCounterManager.counter11b += instantiated2Card11bList.Count;
            CardCounterManager.CardCounter11b();

            CardCounterManager.counter11c += instantiated2Card11cList.Count;
            CardCounterManager.CardCounter11c();

            CardCounterManager.counter12 += instantiated2Card12List.Count;
            CardCounterManager.CardCounter12();

            CardCounterManager.counter12a += instantiated2Card12aList.Count;
            CardCounterManager.CardCounter12a();

            CardCounterManager.counter12b += instantiated2Card12bList.Count;
            CardCounterManager.CardCounter12b();

            CardCounterManager.counter12c += instantiated2Card12cList.Count;
            CardCounterManager.CardCounter12c();

            CardCounterManager.counter13 += instantiated2Card13List.Count;
            CardCounterManager.CardCounter13();

            CardCounterManager.counter13a += instantiated2Card13aList.Count;
            CardCounterManager.CardCounter13a();

            CardCounterManager.counter13b += instantiated2Card13bList.Count;
            CardCounterManager.CardCounter13b();

            CardCounterManager.counter13c += instantiated2Card13cList.Count;
            CardCounterManager.CardCounter13c();

            CardCounterManager.counter14 += instantiated2Card14List.Count;
            CardCounterManager.CardCounter14();

            CardCounterManager.counter14a += instantiated2Card14aList.Count;
            CardCounterManager.CardCounter14a();

            CardCounterManager.counter14b += instantiated2Card14bList.Count;
            CardCounterManager.CardCounter14b();

            CardCounterManager.counter14c += instantiated2Card14cList.Count;
            CardCounterManager.CardCounter14c();

            CardCounterManager.counter15 += instantiated2Card15List.Count;
            CardCounterManager.CardCounter15();

            CardCounterManager.counter15a += instantiated2Card15aList.Count;
            CardCounterManager.CardCounter15a();

            CardCounterManager.counter15b += instantiated2Card15bList.Count;
            CardCounterManager.CardCounter15b();

            CardCounterManager.counter15c += instantiated2Card15cList.Count;
            CardCounterManager.CardCounter15c();

            CardCounterManager.counter16 += instantiated2Card16List.Count;
            CardCounterManager.CardCounter16();

            CardCounterManager.counter16a += instantiated2Card16aList.Count;
            CardCounterManager.CardCounter16a();

            CardCounterManager.counter16b += instantiated2Card16bList.Count;
            CardCounterManager.CardCounter16b();

            CardCounterManager.counter16c += instantiated2Card16cList.Count;
            CardCounterManager.CardCounter16c();

            CardCounterManager.counter17 += instantiated2Card17List.Count;
            CardCounterManager.CardCounter17();

            CardCounterManager.counter17a += instantiated2Card17aList.Count;
            CardCounterManager.CardCounter17a();

            CardCounterManager.counter7b += instantiated2Card17bList.Count;
            CardCounterManager.CardCounter7b();

            CardCounterManager.counter17c += instantiated2Card17cList.Count;
            CardCounterManager.CardCounter17c();

            CardCounterManager.counter18 += instantiated2Card18List.Count;
            CardCounterManager.CardCounter18();

            CardCounterManager.counter18a += instantiated2Card18aList.Count;
            CardCounterManager.CardCounter18a();

            CardCounterManager.counter18b += instantiated2Card18bList.Count;
            CardCounterManager.CardCounter18b();

            CardCounterManager.counter18c += instantiated2Card18cList.Count;
            CardCounterManager.CardCounter18c();

            CardCounterManager.counter19 += instantiated2Card19List.Count;
            CardCounterManager.CardCounter19();

            CardCounterManager.counter19a += instantiated2Card19aList.Count;
            CardCounterManager.CardCounter19a();

            CardCounterManager.counter19b += instantiated2Card19bList.Count;
            CardCounterManager.CardCounter19b();

            CardCounterManager.counter19c += instantiated2Card19cList.Count;
            CardCounterManager.CardCounter19c();

            CardCounterManager.counter20 += instantiated2Card20List.Count;
            CardCounterManager.CardCounter20();

            CardCounterManager.counter20a += instantiated2Card20aList.Count;
            CardCounterManager.CardCounter20a();

            CardCounterManager.counter20b += instantiated2Card20bList.Count;
            CardCounterManager.CardCounter20b();

            CardCounterManager.counter20c += instantiated2Card20cList.Count;
            CardCounterManager.CardCounter20c();

            CardCounterManager.counter21 += instantiated2Card21List.Count;
            CardCounterManager.CardCounter21();

            CardCounterManager.counter21a += instantiated2Card21aList.Count;
            CardCounterManager.CardCounter21a();

            CardCounterManager.counter21b += instantiated2Card21bList.Count;
            CardCounterManager.CardCounter21b();

            CardCounterManager.counter21c += instantiated2Card21cList.Count;
            CardCounterManager.CardCounter21c();

            CardCounterManager.counter22 += instantiated2Card22List.Count;
            CardCounterManager.CardCounter22();

            CardCounterManager.counter22a += instantiated2Card22aList.Count;
            CardCounterManager.CardCounter22a();

            CardCounterManager.counter22b += instantiated2Card22bList.Count;
            CardCounterManager.CardCounter22b();

            CardCounterManager.counter22c += instantiated2Card22cList.Count;
            CardCounterManager.CardCounter22c();

            CardCounterManager.counter23 += instantiated2Card23List.Count;
            CardCounterManager.CardCounter23();

            CardCounterManager.counter23a += instantiated2Card23aList.Count;
            CardCounterManager.CardCounter23a();

            CardCounterManager.counter23b += instantiated2Card23bList.Count;
            CardCounterManager.CardCounter23b();

            CardCounterManager.counter23c += instantiated2Card23cList.Count;
            CardCounterManager.CardCounter23c();

            CardCounterManager.counter24 += instantiated2Card24List.Count;
            CardCounterManager.CardCounter24();

            CardCounterManager.counter24a += instantiated2Card24aList.Count;
            CardCounterManager.CardCounter24a();

            CardCounterManager.counter24b += instantiated2Card24bList.Count;
            CardCounterManager.CardCounter24b();

            CardCounterManager.counter24c += instantiated2Card24cList.Count;
            CardCounterManager.CardCounter24c();

            CardCounterManager.counter25 += instantiated2Card25List.Count;
            CardCounterManager.CardCounter25();

            CardCounterManager.counter25a += instantiated2Card25aList.Count;
            CardCounterManager.CardCounter25a();

            CardCounterManager.counter25b += instantiated2Card25bList.Count;
            CardCounterManager.CardCounter25b();

            CardCounterManager.counter25c += instantiated2Card25cList.Count;
            CardCounterManager.CardCounter25c();

            CardCounterManager.counter26 += instantiated2Card26List.Count;
            CardCounterManager.CardCounter26();

            CardCounterManager.counter26a += instantiated2Card26aList.Count;
            CardCounterManager.CardCounter26a();

            CardCounterManager.counter26b += instantiated2Card26bList.Count;
            CardCounterManager.CardCounter26b();

            CardCounterManager.counter26c += instantiated2Card26cList.Count;
            CardCounterManager.CardCounter26c();

            CardCounterManager.counter27 += instantiated2Card27List.Count;
            CardCounterManager.CardCounter27();

            CardCounterManager.counter27a += instantiated2Card27aList.Count;
            CardCounterManager.CardCounter27a();

            CardCounterManager.counter27b += instantiated2Card27bList.Count;
            CardCounterManager.CardCounter27b();

            CardCounterManager.counter27c += instantiated2Card27cList.Count;
            CardCounterManager.CardCounter27c();

            CardCounterManager.counter28 += instantiated2Card28List.Count;
            CardCounterManager.CardCounter28();

            CardCounterManager.counter28a += instantiated2Card28aList.Count;
            CardCounterManager.CardCounter28a();

            CardCounterManager.counter28b += instantiated2Card28bList.Count;
            CardCounterManager.CardCounter28b();

            CardCounterManager.counter28c += instantiated2Card28cList.Count;
            CardCounterManager.CardCounter28c();

            CardCounterManager.counter29 += instantiated2Card29List.Count;
            CardCounterManager.CardCounter29();

            CardCounterManager.counter29a += instantiated2Card29aList.Count;
            CardCounterManager.CardCounter29a();

            CardCounterManager.counter29b += instantiated2Card29bList.Count;
            CardCounterManager.CardCounter29b();

            CardCounterManager.counter29c += instantiated2Card29cList.Count;
            CardCounterManager.CardCounter29c();

            CardCounterManager.counter30 += instantiated2Card30List.Count;
            CardCounterManager.CardCounter30();

            CardCounterManager.counter30a += instantiated2Card30aList.Count;
            CardCounterManager.CardCounter30a();

            CardCounterManager.counter30b += instantiated2Card30bList.Count;
            CardCounterManager.CardCounter30b();

            CardCounterManager.counter30c += instantiated2Card30cList.Count;
            CardCounterManager.CardCounter30c();

            CardCounterManager.counter31 += instantiated2Card31List.Count;
            CardCounterManager.CardCounter31();

            CardCounterManager.counter31a += instantiated2Card31aList.Count;
            CardCounterManager.CardCounter31a();

            CardCounterManager.counter31b += instantiated2Card31bList.Count;
            CardCounterManager.CardCounter31b();

            CardCounterManager.counter31c += instantiated2Card31cList.Count;
            CardCounterManager.CardCounter31c();

            CardCounterManager.counter32 += instantiated2Card32List.Count;
            CardCounterManager.CardCounter32();

            CardCounterManager.counter32a += instantiated2Card32aList.Count;
            CardCounterManager.CardCounter32a();

            CardCounterManager.counter32b += instantiated2Card32bList.Count;
            CardCounterManager.CardCounter32b();

            CardCounterManager.counter32c += instantiated2Card32cList.Count;
            CardCounterManager.CardCounter32c();

            CardCounterManager.counter33 += instantiated2Card33List.Count;
            CardCounterManager.CardCounter33();

            CardCounterManager.counter33a += instantiated2Card33aList.Count;
            CardCounterManager.CardCounter33a();

            CardCounterManager.counter33b += instantiated2Card33bList.Count;
            CardCounterManager.CardCounter33b();

            CardCounterManager.counter33c += instantiated2Card33cList.Count;
            CardCounterManager.CardCounter33c();

            CardCounterManager.counter34 += instantiated2Card34List.Count;
            CardCounterManager.CardCounter34();

            CardCounterManager.counter34a += instantiated2Card34aList.Count;
            CardCounterManager.CardCounter34a();

            CardCounterManager.counter34b += instantiated2Card34bList.Count;
            CardCounterManager.CardCounter34b();

            CardCounterManager.counter34c += instantiated2Card34cList.Count;
            CardCounterManager.CardCounter34c();

            CardCounterManager.counter35 += instantiated2Card35List.Count;
            CardCounterManager.CardCounter35();

            CardCounterManager.counter35a += instantiated2Card35aList.Count;
            CardCounterManager.CardCounter35a();

            CardCounterManager.counter35b += instantiated2Card35bList.Count;
            CardCounterManager.CardCounter35b();

            CardCounterManager.counter35c += instantiated2Card35cList.Count;
            CardCounterManager.CardCounter35c();

            CardCounterManager.counter36 += instantiated2Card36List.Count;
            CardCounterManager.CardCounter36();

            CardCounterManager.counter36a += instantiated2Card36aList.Count;
            CardCounterManager.CardCounter36a();

            CardCounterManager.counter36b += instantiated2Card36bList.Count;
            CardCounterManager.CardCounter36b();

            CardCounterManager.counter36c += instantiated2Card36cList.Count;
            CardCounterManager.CardCounter36c();

            CardCounterManager.counter37 += instantiated2Card37List.Count;
            CardCounterManager.CardCounter37();

            CardCounterManager.counter37a += instantiated2Card37aList.Count;
            CardCounterManager.CardCounter37a();

            CardCounterManager.counter37b += instantiated2Card37bList.Count;
            CardCounterManager.CardCounter37b();

            CardCounterManager.counter37c += instantiated2Card37cList.Count;
            CardCounterManager.CardCounter37c();

            CardCounterManager.counter38 += instantiated2Card38List.Count;
            CardCounterManager.CardCounter38();

            CardCounterManager.counter38a += instantiated2Card38aList.Count;
            CardCounterManager.CardCounter38a();

            CardCounterManager.counter38b += instantiated2Card38bList.Count;
            CardCounterManager.CardCounter38b();

            CardCounterManager.counter38c += instantiated2Card38cList.Count;
            CardCounterManager.CardCounter38c();

            CardCounterManager.counter39 += instantiated2Card39List.Count;
            CardCounterManager.CardCounter39();

            CardCounterManager.counter39a += instantiated2Card39aList.Count;
            CardCounterManager.CardCounter39a();

            CardCounterManager.counter39b += instantiated2Card39bList.Count;
            CardCounterManager.CardCounter39b();

            CardCounterManager.counter39c += instantiated2Card39cList.Count;
            CardCounterManager.CardCounter39c();

            CardCounterManager.counter40 += instantiated2Card40List.Count;
            CardCounterManager.CardCounter40();

            CardCounterManager.counter40a += instantiated2Card40aList.Count;
            CardCounterManager.CardCounter40a();

            CardCounterManager.counter40b += instantiated2Card40bList.Count;
            CardCounterManager.CardCounter40b();

            CardCounterManager.counter40c += instantiated2Card40cList.Count;
            CardCounterManager.CardCounter40c();

            CardCounterManager.counter41 += instantiated2Card41List.Count;
            CardCounterManager.CardCounter41();

            CardCounterManager.counter41a += instantiated2Card41aList.Count;
            CardCounterManager.CardCounter41a();

            CardCounterManager.counter41b += instantiated2Card41bList.Count;
            CardCounterManager.CardCounter41b();

            CardCounterManager.counter41c += instantiated2Card41cList.Count;
            CardCounterManager.CardCounter41c();

            CardCounterManager.counter42 += instantiated2Card42List.Count;
            CardCounterManager.CardCounter42();

            CardCounterManager.counter42a += instantiated2Card42aList.Count;
            CardCounterManager.CardCounter42a();

            CardCounterManager.counter42b += instantiated2Card42bList.Count;
            CardCounterManager.CardCounter42b();

            CardCounterManager.counter42c += instantiated2Card42cList.Count;
            CardCounterManager.CardCounter42c();

            CardCounterManager.counter43 += instantiated2Card43List.Count;
            CardCounterManager.CardCounter43();

            CardCounterManager.counter43a += instantiated2Card43aList.Count;
            CardCounterManager.CardCounter43a();

            CardCounterManager.counter43b += instantiated2Card43bList.Count;
            CardCounterManager.CardCounter43b();

            CardCounterManager.counter43c += instantiated2Card43cList.Count;
            CardCounterManager.CardCounter43c();

            CardCounterManager.counter44 += instantiated2Card44List.Count;
            CardCounterManager.CardCounter44();

            CardCounterManager.counter44a += instantiated2Card44aList.Count;
            CardCounterManager.CardCounter44a();

            CardCounterManager.counter44b += instantiated2Card44bList.Count;
            CardCounterManager.CardCounter44b();

            CardCounterManager.counter44c += instantiated2Card44cList.Count;
            CardCounterManager.CardCounter44c();

            CardCounterManager.counter45 += instantiated2Card45List.Count;
            CardCounterManager.CardCounter45();

            CardCounterManager.counter45a += instantiated2Card45aList.Count;
            CardCounterManager.CardCounter45a();

            CardCounterManager.counter45b += instantiated2Card45bList.Count;
            CardCounterManager.CardCounter45b();

            CardCounterManager.counter45c += instantiated2Card45cList.Count;
            CardCounterManager.CardCounter45c();

            CardCounterManager.counter46 += instantiated2Card46List.Count;
            CardCounterManager.CardCounter46();

            CardCounterManager.counter46a += instantiated2Card46aList.Count;
            CardCounterManager.CardCounter46a();

            CardCounterManager.counter46b += instantiated2Card46bList.Count;
            CardCounterManager.CardCounter46b();

            CardCounterManager.counter46c += instantiated2Card46cList.Count;
            CardCounterManager.CardCounter46c();

            CardCounterManager.counter47 += instantiated2Card47List.Count;
            CardCounterManager.CardCounter47();

            CardCounterManager.counter47a += instantiated2Card47aList.Count;
            CardCounterManager.CardCounter47a();

            CardCounterManager.counter47b += instantiated2Card47bList.Count;
            CardCounterManager.CardCounter47b();

            CardCounterManager.counter47c += instantiated2Card47cList.Count;
            CardCounterManager.CardCounter47c();

            CardCounterManager.counter48 += instantiated2Card48List.Count;
            CardCounterManager.CardCounter48();

            CardCounterManager.counter48a += instantiated2Card48aList.Count;
            CardCounterManager.CardCounter48a();

            CardCounterManager.counter48b += instantiated2Card48bList.Count;
            CardCounterManager.CardCounter48b();

            CardCounterManager.counter48c += instantiated2Card48cList.Count;
            CardCounterManager.CardCounter48c();

            CardCounterManager.counter49 += instantiated2Card49List.Count;
            CardCounterManager.CardCounter49();

            CardCounterManager.counter49a += instantiated2Card49aList.Count;
            CardCounterManager.CardCounter49a();

            CardCounterManager.counter49b += instantiated2Card49bList.Count;
            CardCounterManager.CardCounter49b();

            CardCounterManager.counter49c += instantiated2Card49cList.Count;
            CardCounterManager.CardCounter49c();

            CardCounterManager.counter50 += instantiated2Card50List.Count;
            CardCounterManager.CardCounter50();

            CardCounterManager.counter50a += instantiated2Card50aList.Count;
            CardCounterManager.CardCounter50a();

            CardCounterManager.counter50b += instantiated2Card50bList.Count;
            CardCounterManager.CardCounter50b();

            CardCounterManager.counter50c += instantiated2Card50cList.Count;
            CardCounterManager.CardCounter50c();

            CardCounterManager.counter51 += instantiated2Card51List.Count;
            CardCounterManager.CardCounter51();

            CardCounterManager.counter51a += instantiated2Card51aList.Count;
            CardCounterManager.CardCounter51a();

            CardCounterManager.counter51b += instantiated2Card51bList.Count;
            CardCounterManager.CardCounter51b();

            CardCounterManager.counter51c += instantiated2Card51cList.Count;
            CardCounterManager.CardCounter51c();

            CardCounterManager.counter52 += instantiated2Card52List.Count;
            CardCounterManager.CardCounter52();

            CardCounterManager.counter52a += instantiated2Card52aList.Count;
            CardCounterManager.CardCounter52a();

            CardCounterManager.counter52b += instantiated2Card52bList.Count;
            CardCounterManager.CardCounter52b();

            CardCounterManager.counter52c += instantiated2Card52cList.Count;
            CardCounterManager.CardCounter52c();

            CardCounterManager.counter53 += instantiated2Card53List.Count;
            CardCounterManager.CardCounter53();

            CardCounterManager.counter53a += instantiated2Card53aList.Count;
            CardCounterManager.CardCounter53a();

            CardCounterManager.counter53b += instantiated2Card53bList.Count;
            CardCounterManager.CardCounter53b();

            CardCounterManager.counter53c += instantiated2Card53cList.Count;
            CardCounterManager.CardCounter53c();

            CardCounterManager.counter54 += instantiated2Card54List.Count;
            CardCounterManager.CardCounter54();

            CardCounterManager.counter54a += instantiated2Card54aList.Count;
            CardCounterManager.CardCounter54a();

            CardCounterManager.counter54b += instantiated2Card54bList.Count;
            CardCounterManager.CardCounter54b();

            CardCounterManager.counter54c += instantiated2Card54cList.Count;
            CardCounterManager.CardCounter54c();

            CardCounterManager.counter55 += instantiated2Card55List.Count;
            CardCounterManager.CardCounter55();

            CardCounterManager.counter55a += instantiated2Card55aList.Count;
            CardCounterManager.CardCounter55a();

            CardCounterManager.counter55b += instantiated2Card55bList.Count;
            CardCounterManager.CardCounter55b();

            CardCounterManager.counter55c += instantiated2Card55cList.Count;
            CardCounterManager.CardCounter55c();

            CardCounterManager.counter56 += instantiated2Card56List.Count;
            CardCounterManager.CardCounter56();

            CardCounterManager.counter56a += instantiated2Card56aList.Count;
            CardCounterManager.CardCounter56a();

            CardCounterManager.counter56b += instantiated2Card56bList.Count;
            CardCounterManager.CardCounter56b();

            CardCounterManager.counter56c += instantiated2Card56cList.Count;
            CardCounterManager.CardCounter56c();

            CardCounterManager.counter57 += instantiated2Card57List.Count;
            CardCounterManager.CardCounter57();

            CardCounterManager.counter57a += instantiated2Card57aList.Count;
            CardCounterManager.CardCounter57a();

            CardCounterManager.counter57b += instantiated2Card57bList.Count;
            CardCounterManager.CardCounter57b();

            CardCounterManager.counter57c += instantiated2Card57cList.Count;
            CardCounterManager.CardCounter57c();

            CardCounterManager.counter58 += instantiated2Card58List.Count;
            CardCounterManager.CardCounter58();

            CardCounterManager.counter58a += instantiated2Card58aList.Count;
            CardCounterManager.CardCounter58a();

            CardCounterManager.counter58b += instantiated2Card58bList.Count;
            CardCounterManager.CardCounter58b();

            CardCounterManager.counter58c += instantiated2Card58cList.Count;
            CardCounterManager.CardCounter58c();

            CardCounterManager.counter59 += instantiated2Card59List.Count;
            CardCounterManager.CardCounter59();

            CardCounterManager.counter59a += instantiated2Card59aList.Count;
            CardCounterManager.CardCounter59a();

            CardCounterManager.counter59b += instantiated2Card59bList.Count;
            CardCounterManager.CardCounter59b();

            CardCounterManager.counter59c += instantiated2Card59cList.Count;
            CardCounterManager.CardCounter59c();

            CardCounterManager.counter60 += instantiated2Card60List.Count;
            CardCounterManager.CardCounter60();

            CardCounterManager.counter60a += instantiated2Card60aList.Count;
            CardCounterManager.CardCounter60a();

            CardCounterManager.counter60b += instantiated2Card60bList.Count;
            CardCounterManager.CardCounter60b();

            CardCounterManager.counter60c += instantiated2Card60cList.Count;
            CardCounterManager.CardCounter60c();


            #endregion





        }


        /** Save the deck - the created or modified deck is svaed to the binary file*/
        public void Save() {

            //Check if there are no empty Deck Builder panel slots
            deckNamelabel.GetComponent<Text>().text = "";

            foreach (GameObject slot in DeckManager.deckManager.spawnPoints2) {
                if (slot.transform.childCount == 0) { //if so...
                                                      //Show the warning and leave the whole Save() function
                    StartCoroutine("ShowWarningCardsText");
                    return;
                }
            }

            //Check if a name of the deck has been entered
            if (deck2NameInputField.GetComponent<Text>().text != "") { //if so...
                                                                       //Save the name and go further
                deckName2 = deck2NameInputField.GetComponent<Text>().text;
                inputFieldSwitcher2.SetActive(false);
                warningNameText.SetActive(false);
            } else {
                //Show the warning and leave the whole Save() function
                StartCoroutine("ShowWarningNameText");
                return;
            }

            isDeck2Editing = false;
            SaveCardDeck3.saveCardDeck3.isDeck3Editing = true;

            if (deck2NameButton.GetComponent<Text>().text == "") {
                deck2NameButton.GetComponent<Text>().text = "Deck 2";
            } else {
                deck2NameButton.GetComponent<Text>().text = deckName2;
            }

            //Clearing all lists
            cardsDeck2.Clear();
            cardsDeck2.RemoveAll(item => item == null);

            editDeck2.Clear();
            editDeck2.RemoveAll(item => item == null);

            //Get all card references
            allObjects = GameObject.FindObjectsOfType(typeof(GameObject)) as GameObject[];
            foreach (GameObject obj in allObjects) {
                if (obj.name.Contains("instantiated2Card")) {

                    cardsDeck2.Add(obj.name);
                    obj.transform.localPosition = new Vector3(0.0f, -40.0f, 0.0f);
                }
            }

            //Get all cards	
            allObjects1 = GameObject.FindObjectsOfType(typeof(GameObject)) as GameObject[];
            foreach (GameObject obj in allObjects1) {
                if (obj.name.Contains("instantiated2Card")) {

                    editDeck2.Add(obj);
                }
            }

            //Check if the deck has cards or not
            if (cardsDeck2.Count >= 0) {
                create2Button.GetComponent<Button>().interactable = false;
                edit2Button.GetComponent<Button>().interactable = true;
            } else {
                create2Button.GetComponent<Button>().interactable = true;
                edit2Button.GetComponent<Button>().interactable = false;
            }

            //Delete the previous binary file
            if (File.Exists(Path.Combine(Application.persistentDataPath, BINARY_FILE2))) {

                File.Delete(Path.Combine(Application.persistentDataPath, BINARY_FILE2));

            }

            //Save the data to the binary file	

            BinaryFormatter bf = new BinaryFormatter();

            FileStream file = File.Create(Path.Combine(Application.persistentDataPath, BINARY_FILE2));
            DataToSave2 data = new DataToSave2();
            data.cardsDeck2 = cardsDeck2;
            data.deckName2 = deckName2;
            bf.Serialize(file, data);
            file.Close();

            cardsDeck2.Clear();
            editDeck2.RemoveAll(item => item == null);
            editDeck2.Clear();
            cardsDeck2.RemoveAll(item => item == null);

            //Show info that the data has been saved
            StartCoroutine("ShowDeckSavedText");

        }

        /** Delete the deck - the deck is deleted and all stuff regarding the deck is cleaned */
        public void Delete() {

            if (deck2NameButton.GetComponent<Text>().text == "") {
                deck2NameButton.GetComponent<Text>().text = "Deck 2";
            } else {
                deck2NameButton.GetComponent<Text>().text = deckName2;
            }

            //coroutine to have enough time for clearing
            StartCoroutine("RemoveDeck2Stuff");
            //GetCardCounterInDeck2();
        }

        /** Clear the deck stuff */
        IEnumerator RemoveDeck2Stuff() {

            yield return new WaitForSeconds(1);



            create2Button.GetComponent<Button>().interactable = true;
            save2Button.GetComponent<Button>().interactable = false;
            edit2Button.GetComponent<Button>().interactable = false;

            if (File.Exists(Path.Combine(Application.persistentDataPath, BINARY_FILE2))) {

                File.Delete(Path.Combine(Application.persistentDataPath, BINARY_FILE2));

            }

            editDeck2.Clear();
            cardsDeck2.Clear();
            editDeck2.RemoveAll(item => item == null);
            cardsDeck2.RemoveAll(item => item == null);



            allObjects1 = GameObject.FindObjectsOfType(typeof(GameObject)) as GameObject[];
            foreach (GameObject obj in allObjects1) {
                if (obj.name.Contains("instantiated2Card")) {

                    editDeck2.Add(obj);
                    editDeck2.Clear();
                    GameObject.Destroy(obj);
                }
            }

            allObjects = GameObject.FindObjectsOfType(typeof(GameObject)) as GameObject[];
            foreach (GameObject obj in allObjects) {
                if (obj.name.Contains("instantiated2Card")) {

                    cardsDeck2.Add(obj.name);
                    cardsDeck2.Clear();
                    GameObject.Destroy(obj);
                }
            }
            StartCoroutine(CheckCardModelScaleAtDelete());
            delete2Button.GetComponent<Button>().interactable = false;
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
                if (editDeck2.Count == 20) {

                    if (deck2Slot1) {
                        if (deck2Slot1.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot1)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot1);
                            }
                        }
                    }
                    if (deck2Slot2) {
                        if (deck2Slot2.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot2)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot2);
                            }
                        }
                    }
                    if (deck2Slot3) {
                        if (deck2Slot3.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot3)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot3);
                            }
                        }
                    }
                    if (deck2Slot4) {
                        if (deck2Slot4.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot4)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot4);
                            }
                        }
                    }
                    if (deck2Slot5) {
                        if (deck2Slot5.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot5)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot5);
                            }
                        }
                    }
                    if (deck2Slot6) {
                        if (deck2Slot6.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot6)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot6);
                            }
                        }
                    }
                    if (deck2Slot7) {
                        if (deck2Slot7.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot7)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot7);
                            }
                        }
                    }
                    if (deck2Slot8) {
                        if (deck2Slot8.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot8)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot8);
                            }
                        }
                    }
                    if (deck2Slot9) {
                        if (deck2Slot9.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot9)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot9);
                            }
                        }
                    }
                    if (deck2Slot10) {
                        if (deck2Slot10.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot10)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot10);
                            }
                        }
                    }
                    if (deck2Slot11) {
                        if (deck2Slot11.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot11)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot11);
                            }
                        }
                    }
                    if (deck2Slot12) {
                        if (deck2Slot12.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot12)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot12);
                            }
                        }
                    }
                    if (deck2Slot13) {
                        if (deck2Slot13.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot13)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot13);
                            }
                        }
                    }
                    if (deck2Slot14) {
                        if (deck2Slot14.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot14)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot14);
                            }
                        }
                    }
                    if (deck2Slot15) {
                        if (deck2Slot15.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot15)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot15);
                            }
                        }
                    }
                    if (deck2Slot16) {
                        if (deck2Slot16.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot16)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot16);
                            }
                        }
                    }
                    if (deck2Slot17) {
                        if (deck2Slot17.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot17)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot17);
                            }
                        }
                    }
                    if (deck2Slot18) {
                        if (deck2Slot18.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot18)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot18);
                            }
                        }
                    }
                    if (deck2Slot19) {
                        if (deck2Slot19.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot19)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot19);
                            }
                        }
                    }
                    if (deck2Slot20) {
                        if (deck2Slot20.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot20)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot20);
                            }
                        }
                    }


                } else if (editDeck2.Count == 25) {

                    if (deck2Slot1) {
                        if (deck2Slot1.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot1)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot1);
                            }
                        }
                    }
                    if (deck2Slot2) {
                        if (deck2Slot2.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot2)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot2);
                            }
                        }
                    }
                    if (deck2Slot3) {
                        if (deck2Slot3.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot3)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot3);
                            }
                        }
                    }
                    if (deck2Slot4) {
                        if (deck2Slot4.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot4)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot4);
                            }
                        }
                    }
                    if (deck2Slot5) {
                        if (deck2Slot5.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot5)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot5);
                            }
                        }
                    }
                    if (deck2Slot6) {
                        if (deck2Slot6.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot6)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot6);
                            }
                        }
                    }
                    if (deck2Slot7) {
                        if (deck2Slot7.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot7)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot7);
                            }
                        }
                    }
                    if (deck2Slot8) {
                        if (deck2Slot8.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot8)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot8);
                            }
                        }
                    }
                    if (deck2Slot9) {
                        if (deck2Slot9.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot9)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot9);
                            }
                        }
                    }
                    if (deck2Slot10) {
                        if (deck2Slot10.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot10)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot10);
                            }
                        }
                    }
                    if (deck2Slot11) {
                        if (deck2Slot11.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot11)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot11);
                            }
                        }
                    }
                    if (deck2Slot12) {
                        if (deck2Slot12.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot12)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot12);
                            }
                        }
                    }
                    if (deck2Slot13) {
                        if (deck2Slot13.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot13)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot13);
                            }
                        }
                    }
                    if (deck2Slot14) {
                        if (deck2Slot14.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot14)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot14);
                            }
                        }
                    }
                    if (deck2Slot15) {
                        if (deck2Slot15.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot15)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot15);
                            }
                        }
                    }
                    if (deck2Slot16) {
                        if (deck2Slot16.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot16)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot16);
                            }
                        }
                    }
                    if (deck2Slot17) {
                        if (deck2Slot17.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot17)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot17);
                            }
                        }
                    }
                    if (deck2Slot18) {
                        if (deck2Slot18.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot18)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot18);
                            }
                        }
                    }
                    if (deck2Slot19) {
                        if (deck2Slot19.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot19)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot19);
                            }
                        }
                    }
                    if (deck2Slot20) {
                        if (deck2Slot20.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot20)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot20);
                            }
                        }
                    }
                    if (deck2Slot21) {
                        if (deck2Slot21.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot21)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot21);
                            }
                        }
                    }
                    if (deck2Slot22) {
                        if (deck2Slot22.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot22)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot22);
                            }
                        }
                    }
                    if (deck2Slot23) {
                        if (deck2Slot23.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot23)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot23);
                            }
                        }
                    }
                    if (deck2Slot24) {
                        if (deck2Slot24.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot24)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot24);
                            }
                        }
                    }
                    if (deck2Slot25) {
                        if (deck2Slot25.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot25)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot25);
                            }
                        }
                    }

                } else if (editDeck2.Count == 30) {

                    if (deck2Slot1) {
                        if (deck2Slot1.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot1)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot1);
                            }
                        }
                    }
                    if (deck2Slot2) {
                        if (deck2Slot2.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot2)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot2);
                            }
                        }
                    }
                    if (deck2Slot3) {
                        if (deck2Slot3.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot3)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot3);
                            }
                        }
                    }
                    if (deck2Slot4) {
                        if (deck2Slot4.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot4)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot4);
                            }
                        }
                    }
                    if (deck2Slot5) {
                        if (deck2Slot5.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot5)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot5);
                            }
                        }
                    }
                    if (deck2Slot6) {
                        if (deck2Slot6.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot6)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot6);
                            }
                        }
                    }
                    if (deck2Slot7) {
                        if (deck2Slot7.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot7)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot7);
                            }
                        }
                    }
                    if (deck2Slot8) {
                        if (deck2Slot8.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot8)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot8);
                            }
                        }
                    }
                    if (deck2Slot9) {
                        if (deck2Slot9.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot9)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot9);
                            }
                        }
                    }
                    if (deck2Slot10) {
                        if (deck2Slot10.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot10)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot10);
                            }
                        }
                    }
                    if (deck2Slot11) {
                        if (deck2Slot11.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot11)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot11);
                            }
                        }
                    }
                    if (deck2Slot12) {
                        if (deck2Slot12.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot12)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot12);
                            }
                        }
                    }
                    if (deck2Slot13) {
                        if (deck2Slot13.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot13)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot13);
                            }
                        }
                    }
                    if (deck2Slot14) {
                        if (deck2Slot14.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot14)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot14);
                            }
                        }
                    }
                    if (deck2Slot15) {
                        if (deck2Slot15.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot15)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot15);
                            }
                        }
                    }
                    if (deck2Slot16) {
                        if (deck2Slot16.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot16)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot16);
                            }
                        }
                    }
                    if (deck2Slot17) {
                        if (deck2Slot17.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot17)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot17);
                            }
                        }
                    }
                    if (deck2Slot18) {
                        if (deck2Slot18.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot18)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot18);
                            }
                        }
                    }
                    if (deck2Slot19) {
                        if (deck2Slot19.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot19)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot19);
                            }
                        }
                    }
                    if (deck2Slot20) {
                        if (deck2Slot20.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot20)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot20);
                            }
                        }
                    }
                    if (deck2Slot21) {
                        if (deck2Slot21.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot21)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot21);
                            }
                        }
                    }
                    if (deck2Slot22) {
                        if (deck2Slot22.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot22)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot22);
                            }
                        }
                    }
                    if (deck2Slot23) {
                        if (deck2Slot23.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot23)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot23);
                            }
                        }
                    }
                    if (deck2Slot24) {
                        if (deck2Slot24.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot24)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot24);
                            }
                        }
                    }
                    if (deck2Slot25) {
                        if (deck2Slot25.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot25)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot25);
                            }
                        }
                    }
                    if (deck2Slot26) {
                        if (deck2Slot26.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot26)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot26);
                            }
                        }
                    }
                    if (deck2Slot27) {
                        if (deck2Slot27.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot27)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot27);
                            }
                        }
                    }
                    if (deck2Slot28) {
                        if (deck2Slot28.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot28)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot28);
                            }
                        }
                    }
                    if (deck2Slot29) {
                        if (deck2Slot29.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot29)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot29);
                            }
                        }
                    }
                    if (deck2Slot30) {
                        if (deck2Slot30.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot30)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot30);
                            }
                        }
                    }
                } else if (editDeck2.Count == 35) {

                    if (deck2Slot1) {
                        if (deck2Slot1.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot1)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot1);
                            }
                        }
                    }
                    if (deck2Slot2) {
                        if (deck2Slot2.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot2)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot2);
                            }
                        }
                    }
                    if (deck2Slot3) {
                        if (deck2Slot3.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot3)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot3);
                            }
                        }
                    }
                    if (deck2Slot4) {
                        if (deck2Slot4.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot4)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot4);
                            }
                        }
                    }
                    if (deck2Slot5) {
                        if (deck2Slot5.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot5)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot5);
                            }
                        }
                    }
                    if (deck2Slot6) {
                        if (deck2Slot6.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot6)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot6);
                            }
                        }
                    }
                    if (deck2Slot7) {
                        if (deck2Slot7.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot7)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot7);
                            }
                        }
                    }
                    if (deck2Slot8) {
                        if (deck2Slot8.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot8)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot8);
                            }
                        }
                    }
                    if (deck2Slot9) {
                        if (deck2Slot9.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot9)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot9);
                            }
                        }
                    }
                    if (deck2Slot10) {
                        if (deck2Slot10.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot10)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot10);
                            }
                        }
                    }
                    if (deck2Slot11) {
                        if (deck2Slot11.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot11)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot11);
                            }
                        }
                    }
                    if (deck2Slot12) {
                        if (deck2Slot12.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot12)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot12);
                            }
                        }
                    }
                    if (deck2Slot13) {
                        if (deck2Slot13.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot13)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot13);
                            }
                        }
                    }
                    if (deck2Slot14) {
                        if (deck2Slot14.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot14)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot14);
                            }
                        }
                    }
                    if (deck2Slot15) {
                        if (deck2Slot15.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot15)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot15);
                            }
                        }
                    }
                    if (deck2Slot16) {
                        if (deck2Slot16.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot16)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot16);
                            }
                        }
                    }
                    if (deck2Slot17) {
                        if (deck2Slot17.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot17)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot17);
                            }
                        }
                    }
                    if (deck2Slot18) {
                        if (deck2Slot18.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot18)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot18);
                            }
                        }
                    }
                    if (deck2Slot19) {
                        if (deck2Slot19.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot19)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot19);
                            }
                        }
                    }
                    if (deck2Slot20) {
                        if (deck2Slot20.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot20)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot20);
                            }
                        }
                    }
                    if (deck2Slot21) {
                        if (deck2Slot21.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot21)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot21);
                            }
                        }
                    }
                    if (deck2Slot22) {
                        if (deck2Slot22.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot22)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot22);
                            }
                        }
                    }
                    if (deck2Slot23) {
                        if (deck2Slot23.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot23)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot23);
                            }
                        }
                    }
                    if (deck2Slot24) {
                        if (deck2Slot24.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot24)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot24);
                            }
                        }
                    }
                    if (deck2Slot25) {
                        if (deck2Slot25.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot25)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot25);
                            }
                        }
                    }
                    if (deck2Slot26) {
                        if (deck2Slot26.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot26)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot26);
                            }
                        }
                    }
                    if (deck2Slot27) {
                        if (deck2Slot27.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot27)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot27);
                            }
                        }
                    }
                    if (deck2Slot28) {
                        if (deck2Slot28.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot28)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot28);
                            }
                        }
                    }
                    if (deck2Slot29) {
                        if (deck2Slot29.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot29)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot29);
                            }
                        }
                    }
                    if (deck2Slot30) {
                        if (deck2Slot30.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot30)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot30);
                            }
                        }
                    }
                    if (deck2Slot31) {
                        if (deck2Slot31.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot31)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot31);
                            }
                        }
                    }
                    if (deck2Slot32) {
                        if (deck2Slot32.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot32)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot32);
                            }
                        }
                    }
                    if (deck2Slot33) {
                        if (deck2Slot33.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot33)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot33);
                            }
                        }
                    }
                    if (deck2Slot34) {
                        if (deck2Slot34.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot34)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot34);
                            }
                        }
                    }
                    if (deck2Slot35) {
                        if (deck2Slot35.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot35)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot35);
                            }
                        }
                    }
                } else if (editDeck2.Count == 40) {

                    if (deck2Slot1) {
                        if (deck2Slot1.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot1)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot1);
                            }
                        }
                    }
                    if (deck2Slot2) {
                        if (deck2Slot2.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot2)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot2);
                            }
                        }
                    }
                    if (deck2Slot3) {
                        if (deck2Slot3.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot3)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot3);
                            }
                        }
                    }
                    if (deck2Slot4) {
                        if (deck2Slot4.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot4)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot4);
                            }
                        }
                    }
                    if (deck2Slot5) {
                        if (deck2Slot5.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot5)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot5);
                            }
                        }
                    }
                    if (deck2Slot6) {
                        if (deck2Slot6.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot6)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot6);
                            }
                        }
                    }
                    if (deck2Slot7) {
                        if (deck2Slot7.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot7)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot7);
                            }
                        }
                    }
                    if (deck2Slot8) {
                        if (deck2Slot8.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot8)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot8);
                            }
                        }
                    }
                    if (deck2Slot9) {
                        if (deck2Slot9.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot9)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot9);
                            }
                        }
                    }
                    if (deck2Slot10) {
                        if (deck2Slot10.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot10)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot10);
                            }
                        }
                    }
                    if (deck2Slot11) {
                        if (deck2Slot11.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot11)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot11);
                            }
                        }
                    }
                    if (deck2Slot12) {
                        if (deck2Slot12.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot12)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot12);
                            }
                        }
                    }
                    if (deck2Slot13) {
                        if (deck2Slot13.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot13)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot13);
                            }
                        }
                    }
                    if (deck2Slot14) {
                        if (deck2Slot14.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot14)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot14);
                            }
                        }
                    }
                    if (deck2Slot15) {
                        if (deck2Slot15.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot15)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot15);
                            }
                        }
                    }
                    if (deck2Slot16) {
                        if (deck2Slot16.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot16)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot16);
                            }
                        }
                    }
                    if (deck2Slot17) {
                        if (deck2Slot17.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot17)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot17);
                            }
                        }
                    }
                    if (deck2Slot18) {
                        if (deck2Slot18.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot18)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot18);
                            }
                        }
                    }
                    if (deck2Slot19) {
                        if (deck2Slot19.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot19)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot19);
                            }
                        }
                    }
                    if (deck2Slot20) {
                        if (deck2Slot20.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot20)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot20);
                            }
                        }
                    }
                    if (deck2Slot21) {
                        if (deck2Slot21.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot21)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot21);
                            }
                        }
                    }
                    if (deck2Slot22) {
                        if (deck2Slot22.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot22)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot22);
                            }
                        }
                    }
                    if (deck2Slot23) {
                        if (deck2Slot23.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot23)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot23);
                            }
                        }
                    }
                    if (deck2Slot24) {
                        if (deck2Slot24.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot24)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot24);
                            }
                        }
                    }
                    if (deck2Slot25) {
                        if (deck2Slot25.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot25)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot25);
                            }
                        }
                    }
                    if (deck2Slot26) {
                        if (deck2Slot26.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot26)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot26);
                            }
                        }
                    }
                    if (deck2Slot27) {
                        if (deck2Slot27.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot27)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot27);
                            }
                        }
                    }
                    if (deck2Slot28) {
                        if (deck2Slot28.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot28)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot28);
                            }
                        }
                    }
                    if (deck2Slot29) {
                        if (deck2Slot29.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot29)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot29);
                            }
                        }
                    }
                    if (deck2Slot30) {
                        if (deck2Slot30.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot30)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot30);
                            }
                        }
                    }
                    if (deck2Slot31) {
                        if (deck2Slot31.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot31)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot31);
                            }
                        }
                    }
                    if (deck2Slot32) {
                        if (deck2Slot32.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot32)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot32);
                            }
                        }
                    }
                    if (deck2Slot33) {
                        if (deck2Slot33.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot33)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot33);
                            }
                        }
                    }
                    if (deck2Slot34) {
                        if (deck2Slot34.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot34)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot34);
                            }
                        }
                    }
                    if (deck2Slot35) {
                        if (deck2Slot35.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot35)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot35);
                            }
                        }
                    }
                    if (deck2Slot36) {
                        if (deck2Slot36.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot36)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot36);
                            }
                        }
                    }
                    if (deck2Slot37) {
                        if (deck2Slot37.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot37)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot37);
                            }
                        }
                    }
                    if (deck2Slot38) {
                        if (deck2Slot38.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot38)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot38);
                            }
                        }
                    }
                    if (deck2Slot39) {
                        if (deck2Slot39.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot39)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot39);
                            }
                        }
                    }
                    if (deck2Slot40) {
                        if (deck2Slot40.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot40)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot40);
                            }
                        }
                    }

                } else if (editDeck2.Count == 45) {

                    if (deck2Slot1) {
                        if (deck2Slot1.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot1)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot1);
                            }
                        }
                    }
                    if (deck2Slot2) {
                        if (deck2Slot2.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot2)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot2);
                            }
                        }
                    }
                    if (deck2Slot3) {
                        if (deck2Slot3.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot3)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot3);
                            }
                        }
                    }
                    if (deck2Slot4) {
                        if (deck2Slot4.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot4)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot4);
                            }
                        }
                    }
                    if (deck2Slot5) {
                        if (deck2Slot5.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot5)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot5);
                            }
                        }
                    }
                    if (deck2Slot6) {
                        if (deck2Slot6.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot6)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot6);
                            }
                        }
                    }
                    if (deck2Slot7) {
                        if (deck2Slot7.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot7)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot7);
                            }
                        }
                    }
                    if (deck2Slot8) {
                        if (deck2Slot8.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot8)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot8);
                            }
                        }
                    }
                    if (deck2Slot9) {
                        if (deck2Slot9.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot9)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot9);
                            }
                        }
                    }
                    if (deck2Slot10) {
                        if (deck2Slot10.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot10)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot10);
                            }
                        }
                    }
                    if (deck2Slot11) {
                        if (deck2Slot11.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot11)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot11);
                            }
                        }
                    }
                    if (deck2Slot12) {
                        if (deck2Slot12.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot12)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot12);
                            }
                        }
                    }
                    if (deck2Slot13) {
                        if (deck2Slot13.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot13)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot13);
                            }
                        }
                    }
                    if (deck2Slot14) {
                        if (deck2Slot14.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot14)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot14);
                            }
                        }
                    }
                    if (deck2Slot15) {
                        if (deck2Slot15.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot15)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot15);
                            }
                        }
                    }
                    if (deck2Slot16) {
                        if (deck2Slot16.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot16)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot16);
                            }
                        }
                    }
                    if (deck2Slot17) {
                        if (deck2Slot17.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot17)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot17);
                            }
                        }
                    }
                    if (deck2Slot18) {
                        if (deck2Slot18.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot18)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot18);
                            }
                        }
                    }
                    if (deck2Slot19) {
                        if (deck2Slot19.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot19)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot19);
                            }
                        }
                    }
                    if (deck2Slot20) {
                        if (deck2Slot20.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot20)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot20);
                            }
                        }
                    }
                    if (deck2Slot21) {
                        if (deck2Slot21.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot21)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot21);
                            }
                        }
                    }
                    if (deck2Slot22) {
                        if (deck2Slot22.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot22)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot22);
                            }
                        }
                    }
                    if (deck2Slot23) {
                        if (deck2Slot23.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot23)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot23);
                            }
                        }
                    }
                    if (deck2Slot24) {
                        if (deck2Slot24.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot24)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot24);
                            }
                        }
                    }
                    if (deck2Slot25) {
                        if (deck2Slot25.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot25)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot25);
                            }
                        }
                    }
                    if (deck2Slot26) {
                        if (deck2Slot26.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot26)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot26);
                            }
                        }
                    }
                    if (deck2Slot27) {
                        if (deck2Slot27.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot27)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot27);
                            }
                        }
                    }
                    if (deck2Slot28) {
                        if (deck2Slot28.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot28)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot28);
                            }
                        }
                    }
                    if (deck2Slot29) {
                        if (deck2Slot29.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot29)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot29);
                            }
                        }
                    }
                    if (deck2Slot30) {
                        if (deck2Slot30.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot30)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot30);
                            }
                        }
                    }
                    if (deck2Slot31) {
                        if (deck2Slot31.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot31)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot31);
                            }
                        }
                    }
                    if (deck2Slot32) {
                        if (deck2Slot32.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot32)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot32);
                            }
                        }
                    }
                    if (deck2Slot33) {
                        if (deck2Slot33.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot33)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot33);
                            }
                        }
                    }
                    if (deck2Slot34) {
                        if (deck2Slot34.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot34)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot34);
                            }
                        }
                    }
                    if (deck2Slot35) {
                        if (deck2Slot35.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot35)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot35);
                            }
                        }
                    }
                    if (deck2Slot36) {
                        if (deck2Slot36.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot36)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot36);
                            }
                        }
                    }
                    if (deck2Slot37) {
                        if (deck2Slot37.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot37)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot37);
                            }
                        }
                    }
                    if (deck2Slot38) {
                        if (deck2Slot38.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot38)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot38);
                            }
                        }
                    }
                    if (deck2Slot39) {
                        if (deck2Slot39.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot39)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot39);
                            }
                        }
                    }
                    if (deck2Slot40) {
                        if (deck2Slot40.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot40)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot40);
                            }
                        }
                    }
                    if (deck2Slot41) {
                        if (deck2Slot41.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot41)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot41);
                            }
                        }
                    }
                    if (deck2Slot42) {
                        if (deck2Slot42.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot42)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot42);
                            }
                        }
                    }
                    if (deck2Slot43) {
                        if (deck2Slot43.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot43)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot43);
                            }
                        }
                    }
                    if (deck2Slot44) {
                        if (deck2Slot44.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot44)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot44);
                            }
                        }
                    }
                    if (deck2Slot45) {
                        if (deck2Slot45.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot45)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot45);
                            }
                        }
                    }
                } else if (editDeck2.Count == 50) {

                    if (deck2Slot1) {
                        if (deck2Slot1.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot1)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot1);
                            }
                        }
                    }
                    if (deck2Slot2) {
                        if (deck2Slot2.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot2)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot2);
                            }
                        }
                    }
                    if (deck2Slot3) {
                        if (deck2Slot3.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot3)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot3);
                            }
                        }
                    }
                    if (deck2Slot4) {
                        if (deck2Slot4.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot4)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot4);
                            }
                        }
                    }
                    if (deck2Slot5) {
                        if (deck2Slot5.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot5)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot5);
                            }
                        }
                    }
                    if (deck2Slot6) {
                        if (deck2Slot6.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot6)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot6);
                            }
                        }
                    }
                    if (deck2Slot7) {
                        if (deck2Slot7.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot7)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot7);
                            }
                        }
                    }
                    if (deck2Slot8) {
                        if (deck2Slot8.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot8)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot8);
                            }
                        }
                    }
                    if (deck2Slot9) {
                        if (deck2Slot9.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot9)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot9);
                            }
                        }
                    }
                    if (deck2Slot10) {
                        if (deck2Slot10.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot10)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot10);
                            }
                        }
                    }
                    if (deck2Slot11) {
                        if (deck2Slot11.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot11)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot11);
                            }
                        }
                    }
                    if (deck2Slot12) {
                        if (deck2Slot12.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot12)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot12);
                            }
                        }
                    }
                    if (deck2Slot13) {
                        if (deck2Slot13.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot13)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot13);
                            }
                        }
                    }
                    if (deck2Slot14) {
                        if (deck2Slot14.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot14)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot14);
                            }
                        }
                    }
                    if (deck2Slot15) {
                        if (deck2Slot15.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot15)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot15);
                            }
                        }
                    }
                    if (deck2Slot16) {
                        if (deck2Slot16.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot16)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot16);
                            }
                        }
                    }
                    if (deck2Slot17) {
                        if (deck2Slot17.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot17)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot17);
                            }
                        }
                    }
                    if (deck2Slot18) {
                        if (deck2Slot18.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot18)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot18);
                            }
                        }
                    }
                    if (deck2Slot19) {
                        if (deck2Slot19.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot19)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot19);
                            }
                        }
                    }
                    if (deck2Slot20) {
                        if (deck2Slot20.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot20)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot20);
                            }
                        }
                    }
                    if (deck2Slot21) {
                        if (deck2Slot21.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot21)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot21);
                            }
                        }
                    }
                    if (deck2Slot22) {
                        if (deck2Slot22.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot22)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot22);
                            }
                        }
                    }
                    if (deck2Slot23) {
                        if (deck2Slot23.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot23)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot23);
                            }
                        }
                    }
                    if (deck2Slot24) {
                        if (deck2Slot24.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot24)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot24);
                            }
                        }
                    }
                    if (deck2Slot25) {
                        if (deck2Slot25.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot25)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot25);
                            }
                        }
                    }
                    if (deck2Slot26) {
                        if (deck2Slot26.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot26)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot26);
                            }
                        }
                    }
                    if (deck2Slot27) {
                        if (deck2Slot27.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot27)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot27);
                            }
                        }
                    }
                    if (deck2Slot28) {
                        if (deck2Slot28.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot28)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot28);
                            }
                        }
                    }
                    if (deck2Slot29) {
                        if (deck2Slot29.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot29)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot29);
                            }
                        }
                    }
                    if (deck2Slot30) {
                        if (deck2Slot30.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot30)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot30);
                            }
                        }
                    }
                    if (deck2Slot31) {
                        if (deck2Slot31.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot31)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot31);
                            }
                        }
                    }
                    if (deck2Slot32) {
                        if (deck2Slot32.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot32)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot32);
                            }
                        }
                    }
                    if (deck2Slot33) {
                        if (deck2Slot33.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot33)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot33);
                            }
                        }
                    }
                    if (deck2Slot34) {
                        if (deck2Slot34.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot34)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot34);
                            }
                        }
                    }
                    if (deck2Slot35) {
                        if (deck2Slot35.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot35)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot35);
                            }
                        }
                    }
                    if (deck2Slot36) {
                        if (deck2Slot36.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot36)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot36);
                            }
                        }
                    }
                    if (deck2Slot37) {
                        if (deck2Slot37.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot37)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot37);
                            }
                        }
                    }
                    if (deck2Slot38) {
                        if (deck2Slot38.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot38)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot38);
                            }
                        }
                    }
                    if (deck2Slot39) {
                        if (deck2Slot39.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot39)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot39);
                            }
                        }
                    }
                    if (deck2Slot40) {
                        if (deck2Slot40.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot40)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot40);
                            }
                        }
                    }
                    if (deck2Slot41) {
                        if (deck2Slot41.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot41)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot41);
                            }
                        }
                    }
                    if (deck2Slot42) {
                        if (deck2Slot42.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot42)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot42);
                            }
                        }
                    }
                    if (deck2Slot43) {
                        if (deck2Slot43.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot43)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot43);
                            }
                        }
                    }
                    if (deck2Slot44) {
                        if (deck2Slot44.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot44)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot44);
                            }
                        }
                    }
                    if (deck2Slot45) {
                        if (deck2Slot45.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot45)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot45);
                            }
                        }
                    }
                    if (deck2Slot46) {
                        if (deck2Slot46.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot46)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot46);
                            }
                        }
                    }
                    if (deck2Slot47) {
                        if (deck2Slot47.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot47)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot47);
                            }
                        }
                    }
                    if (deck2Slot48) {
                        if (deck2Slot48.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot48)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot48);
                            }
                        }
                    }
                    if (deck2Slot49) {
                        if (deck2Slot49.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot49)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot49);
                            }
                        }
                    }
                    if (deck2Slot50) {
                        if (deck2Slot50.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot50)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot50);
                            }
                        }
                    }
                } else if (editDeck2.Count == 55) {

                    if (deck2Slot1) {
                        if (deck2Slot1.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot1)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot1);
                            }
                        }
                    }
                    if (deck2Slot2) {
                        if (deck2Slot2.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot2)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot2);
                            }
                        }
                    }
                    if (deck2Slot3) {
                        if (deck2Slot3.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot3)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot3);
                            }
                        }
                    }
                    if (deck2Slot4) {
                        if (deck2Slot4.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot4)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot4);
                            }
                        }
                    }
                    if (deck2Slot5) {
                        if (deck2Slot5.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot5)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot5);
                            }
                        }
                    }
                    if (deck2Slot6) {
                        if (deck2Slot6.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot6)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot6);
                            }
                        }
                    }
                    if (deck2Slot7) {
                        if (deck2Slot7.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot7)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot7);
                            }
                        }
                    }
                    if (deck2Slot8) {
                        if (deck2Slot8.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot8)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot8);
                            }
                        }
                    }
                    if (deck2Slot9) {
                        if (deck2Slot9.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot9)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot9);
                            }
                        }
                    }
                    if (deck2Slot10) {
                        if (deck2Slot10.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot10)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot10);
                            }
                        }
                    }
                    if (deck2Slot11) {
                        if (deck2Slot11.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot11)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot11);
                            }
                        }
                    }
                    if (deck2Slot12) {
                        if (deck2Slot12.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot12)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot12);
                            }
                        }
                    }
                    if (deck2Slot13) {
                        if (deck2Slot13.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot13)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot13);
                            }
                        }
                    }
                    if (deck2Slot14) {
                        if (deck2Slot14.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot14)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot14);
                            }
                        }
                    }
                    if (deck2Slot15) {
                        if (deck2Slot15.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot15)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot15);
                            }
                        }
                    }
                    if (deck2Slot16) {
                        if (deck2Slot16.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot16)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot16);
                            }
                        }
                    }
                    if (deck2Slot17) {
                        if (deck2Slot17.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot17)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot17);
                            }
                        }
                    }
                    if (deck2Slot18) {
                        if (deck2Slot18.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot18)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot18);
                            }
                        }
                    }
                    if (deck2Slot19) {
                        if (deck2Slot19.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot19)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot19);
                            }
                        }
                    }
                    if (deck2Slot20) {
                        if (deck2Slot20.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot20)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot20);
                            }
                        }
                    }
                    if (deck2Slot21) {
                        if (deck2Slot21.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot21)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot21);
                            }
                        }
                    }
                    if (deck2Slot22) {
                        if (deck2Slot22.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot22)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot22);
                            }
                        }
                    }
                    if (deck2Slot23) {
                        if (deck2Slot23.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot23)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot23);
                            }
                        }
                    }
                    if (deck2Slot24) {
                        if (deck2Slot24.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot24)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot24);
                            }
                        }
                    }
                    if (deck2Slot25) {
                        if (deck2Slot25.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot25)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot25);
                            }
                        }
                    }
                    if (deck2Slot26) {
                        if (deck2Slot26.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot26)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot26);
                            }
                        }
                    }
                    if (deck2Slot27) {
                        if (deck2Slot27.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot27)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot27);
                            }
                        }
                    }
                    if (deck2Slot28) {
                        if (deck2Slot28.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot28)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot28);
                            }
                        }
                    }
                    if (deck2Slot29) {
                        if (deck2Slot29.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot29)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot29);
                            }
                        }
                    }
                    if (deck2Slot30) {
                        if (deck2Slot30.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot30)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot30);
                            }
                        }
                    }
                    if (deck2Slot31) {
                        if (deck2Slot31.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot31)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot31);
                            }
                        }
                    }
                    if (deck2Slot32) {
                        if (deck2Slot32.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot32)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot32);
                            }
                        }
                    }
                    if (deck2Slot33) {
                        if (deck2Slot33.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot33)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot33);
                            }
                        }
                    }
                    if (deck2Slot34) {
                        if (deck2Slot34.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot34)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot34);
                            }
                        }
                    }
                    if (deck2Slot35) {
                        if (deck2Slot35.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot35)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot35);
                            }
                        }
                    }
                    if (deck2Slot36) {
                        if (deck2Slot36.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot36)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot36);
                            }
                        }
                    }
                    if (deck2Slot37) {
                        if (deck2Slot37.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot37)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot37);
                            }
                        }
                    }
                    if (deck2Slot38) {
                        if (deck2Slot38.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot38)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot38);
                            }
                        }
                    }
                    if (deck2Slot39) {
                        if (deck2Slot39.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot39)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot39);
                            }
                        }
                    }
                    if (deck2Slot40) {
                        if (deck2Slot40.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot40)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot40);
                            }
                        }
                    }
                    if (deck2Slot41) {
                        if (deck2Slot41.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot41)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot41);
                            }
                        }
                    }
                    if (deck2Slot42) {
                        if (deck2Slot42.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot42)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot42);
                            }
                        }
                    }
                    if (deck2Slot43) {
                        if (deck2Slot43.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot43)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot43);
                            }
                        }
                    }
                    if (deck2Slot44) {
                        if (deck2Slot44.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot44)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot44);
                            }
                        }
                    }
                    if (deck2Slot45) {
                        if (deck2Slot45.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot45)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot45);
                            }
                        }
                    }
                    if (deck2Slot46) {
                        if (deck2Slot46.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot46)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot46);
                            }
                        }
                    }
                    if (deck2Slot47) {
                        if (deck2Slot47.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot47)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot47);
                            }
                        }
                    }
                    if (deck2Slot48) {
                        if (deck2Slot48.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot48)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot48);
                            }
                        }
                    }
                    if (deck2Slot49) {
                        if (deck2Slot49.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot49)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot49);
                            }
                        }
                    }
                    if (deck2Slot50) {
                        if (deck2Slot50.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot50)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot50);
                            }
                        }
                    }
                    if (deck2Slot51) {
                        if (deck2Slot51.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot51)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot51);
                            }
                        }
                    }
                    if (deck2Slot52) {
                        if (deck2Slot52.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot52)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot52);
                            }
                        }
                    }
                    if (deck2Slot53) {
                        if (deck2Slot53.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot53)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot53);
                            }
                        }
                    }
                    if (deck2Slot54) {
                        if (deck2Slot54.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot54)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot54);
                            }
                        }
                    }
                    if (deck2Slot55) {
                        if (deck2Slot55.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot55)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot55);
                            }
                        }
                    }
                } else if (editDeck2.Count == 60) {

                    if (deck2Slot1) {
                        if (deck2Slot1.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot1)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot1);
                            }
                        }
                    }
                    if (deck2Slot2) {
                        if (deck2Slot2.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot2)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot2);
                            }
                        }
                    }
                    if (deck2Slot3) {
                        if (deck2Slot3.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot3)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot3);
                            }
                        }
                    }
                    if (deck2Slot4) {
                        if (deck2Slot4.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot4)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot4);
                            }
                        }
                    }
                    if (deck2Slot5) {
                        if (deck2Slot5.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot5)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot5);
                            }
                        }
                    }
                    if (deck2Slot6) {
                        if (deck2Slot6.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot6)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot6);
                            }
                        }
                    }
                    if (deck2Slot7) {
                        if (deck2Slot7.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot7)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot7);
                            }
                        }
                    }
                    if (deck2Slot8) {
                        if (deck2Slot8.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot8)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot8);
                            }
                        }
                    }
                    if (deck2Slot9) {
                        if (deck2Slot9.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot9)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot9);
                            }
                        }
                    }
                    if (deck2Slot10) {
                        if (deck2Slot10.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot10)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot10);
                            }
                        }
                    }
                    if (deck2Slot11) {
                        if (deck2Slot11.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot11)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot11);
                            }
                        }
                    }
                    if (deck2Slot12) {
                        if (deck2Slot12.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot12)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot12);
                            }
                        }
                    }
                    if (deck2Slot13) {
                        if (deck2Slot13.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot13)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot13);
                            }
                        }
                    }
                    if (deck2Slot14) {
                        if (deck2Slot14.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot14)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot14);
                            }
                        }
                    }
                    if (deck2Slot15) {
                        if (deck2Slot15.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot15)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot15);
                            }
                        }
                    }
                    if (deck2Slot16) {
                        if (deck2Slot16.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot16)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot16);
                            }
                        }
                    }
                    if (deck2Slot17) {
                        if (deck2Slot17.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot17)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot17);
                            }
                        }
                    }
                    if (deck2Slot18) {
                        if (deck2Slot18.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot18)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot18);
                            }
                        }
                    }
                    if (deck2Slot19) {
                        if (deck2Slot19.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot19)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot19);
                            }
                        }
                    }
                    if (deck2Slot20) {
                        if (deck2Slot20.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot20)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot20);
                            }
                        }
                    }
                    if (deck2Slot21) {
                        if (deck2Slot21.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot21)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot21);
                            }
                        }
                    }
                    if (deck2Slot22) {
                        if (deck2Slot22.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot22)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot22);
                            }
                        }
                    }
                    if (deck2Slot23) {
                        if (deck2Slot23.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot23)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot23);
                            }
                        }
                    }
                    if (deck2Slot24) {
                        if (deck2Slot24.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot24)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot24);
                            }
                        }
                    }
                    if (deck2Slot25) {
                        if (deck2Slot25.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot25)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot25);
                            }
                        }
                    }
                    if (deck2Slot26) {
                        if (deck2Slot26.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot26)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot26);
                            }
                        }
                    }
                    if (deck2Slot27) {
                        if (deck2Slot27.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot27)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot27);
                            }
                        }
                    }
                    if (deck2Slot28) {
                        if (deck2Slot28.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot28)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot28);
                            }
                        }
                    }
                    if (deck2Slot29) {
                        if (deck2Slot29.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot29)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot29);
                            }
                        }
                    }
                    if (deck2Slot30) {
                        if (deck2Slot30.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot30)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot30);
                            }
                        }
                    }
                    if (deck2Slot31) {
                        if (deck2Slot31.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot31)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot31);
                            }
                        }
                    }
                    if (deck2Slot32) {
                        if (deck2Slot32.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot32)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot32);
                            }
                        }
                    }
                    if (deck2Slot33) {
                        if (deck2Slot33.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot33)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot33);
                            }
                        }
                    }
                    if (deck2Slot34) {
                        if (deck2Slot34.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot34)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot34);
                            }
                        }
                    }
                    if (deck2Slot35) {
                        if (deck2Slot35.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot35)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot35);
                            }
                        }
                    }
                    if (deck2Slot36) {
                        if (deck2Slot36.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot36)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot36);
                            }
                        }
                    }
                    if (deck2Slot37) {
                        if (deck2Slot37.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot37)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot37);
                            }
                        }
                    }
                    if (deck2Slot38) {
                        if (deck2Slot38.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot38)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot38);
                            }
                        }
                    }
                    if (deck2Slot39) {
                        if (deck2Slot39.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot39)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot39);
                            }
                        }
                    }
                    if (deck2Slot40) {
                        if (deck2Slot40.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot40)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot40);
                            }
                        }
                    }
                    if (deck2Slot41) {
                        if (deck2Slot41.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot41)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot41);
                            }
                        }
                    }
                    if (deck2Slot42) {
                        if (deck2Slot42.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot42)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot42);
                            }
                        }
                    }
                    if (deck2Slot43) {
                        if (deck2Slot43.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot43)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot43);
                            }
                        }
                    }
                    if (deck2Slot44) {
                        if (deck2Slot44.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot44)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot44);
                            }
                        }
                    }
                    if (deck2Slot45) {
                        if (deck2Slot45.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot45)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot45);
                            }
                        }
                    }
                    if (deck2Slot46) {
                        if (deck2Slot46.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot46)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot46);
                            }
                        }
                    }
                    if (deck2Slot47) {
                        if (deck2Slot47.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot47)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot47);
                            }
                        }
                    }
                    if (deck2Slot48) {
                        if (deck2Slot48.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot48)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot48);
                            }
                        }
                    }
                    if (deck2Slot49) {
                        if (deck2Slot49.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot49)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot49);
                            }
                        }
                    }
                    if (deck2Slot50) {
                        if (deck2Slot50.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot50)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot50);
                            }
                        }
                    }
                    if (deck2Slot51) {
                        if (deck2Slot51.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot51)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot51);
                            }
                        }
                    }
                    if (deck2Slot52) {
                        if (deck2Slot52.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot52)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot52);
                            }
                        }
                    }
                    if (deck2Slot53) {
                        if (deck2Slot53.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot53)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot53);
                            }
                        }
                    }
                    if (deck2Slot54) {
                        if (deck2Slot54.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot54)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot54);
                            }
                        }
                    }
                    if (deck2Slot55) {
                        if (deck2Slot55.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot55)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot55);
                            }
                        }
                    }
                    if (deck2Slot56) {
                        if (deck2Slot56.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot56)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot56);
                            }
                        }
                    }
                    if (deck2Slot57) {
                        if (deck2Slot57.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot57)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot57);
                            }
                        }
                    }
                    if (deck2Slot58) {
                        if (deck2Slot58.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot58)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot58);
                            }
                        }
                    }
                    if (deck2Slot59) {
                        if (deck2Slot59.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot59)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot59);
                            }
                        }
                    }
                    if (deck2Slot60) {
                        if (deck2Slot60.transform.childCount == 0) {
                            if (!DeckManager.deckManager.spawnPoints2.Contains(deck2Slot60)) {
                                DeckManager.deckManager.spawnPoints2.Add(deck2Slot60);
                            }
                        }
                    }

                }


            }

        }

        #endregion

        /** Convert the string references to stored cards in the binary file into 3D card game objects */

        void CardGenerator() {

            foreach (string cardReference in cardsDeck2) {

                if (cardReference == "instantiated2Card1") {
                    spawnPoint1 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card1, spawnPoint1, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card1";
                    card.AddComponent<OnDestroyCard1>();

                    spawnPointsDeck2.Remove(spawnPoint1);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card1a") {
                    spawnPoint1a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card1a, spawnPoint1a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card1a";
                    card.AddComponent<OnDestroyCard1a>();

                    spawnPointsDeck2.Remove(spawnPoint1a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card1b") {
                    spawnPoint1b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card1b, spawnPoint1b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card1b";
                    card.AddComponent<OnDestroyCard1b>();

                    spawnPointsDeck2.Remove(spawnPoint1b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card1c") {
                    spawnPoint1c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card1c, spawnPoint1c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card1c";
                    card.AddComponent<OnDestroyCard1c>();

                    spawnPointsDeck2.Remove(spawnPoint1c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card2") {
                    spawnPoint2 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card2, spawnPoint2, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card2";
                    card.AddComponent<OnDestroyCard2>();

                    spawnPointsDeck2.Remove(spawnPoint2);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card2a") {
                    spawnPoint2a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card2a, spawnPoint2a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card2a";
                    card.AddComponent<OnDestroyCard2a>();

                    spawnPointsDeck2.Remove(spawnPoint2a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card2b") {
                    spawnPoint2b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card2b, spawnPoint2b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card2b";
                    card.AddComponent<OnDestroyCard2b>();

                    spawnPointsDeck2.Remove(spawnPoint2b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card2c") {
                    spawnPoint2c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card2c, spawnPoint2c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card2c";
                    card.AddComponent<OnDestroyCard2c>();

                    spawnPointsDeck2.Remove(spawnPoint2c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card3") {
                    spawnPoint3 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card3, spawnPoint3, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card3";
                    card.AddComponent<OnDestroyCard3>();

                    spawnPointsDeck2.Remove(spawnPoint3);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card3a") {
                    spawnPoint3a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card3a, spawnPoint3a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card3a";
                    card.AddComponent<OnDestroyCard3a>();

                    spawnPointsDeck2.Remove(spawnPoint3a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card3b") {
                    spawnPoint3b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card3b, spawnPoint3b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card3b";
                    card.AddComponent<OnDestroyCard3b>();

                    spawnPointsDeck2.Remove(spawnPoint3b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card3c") {
                    spawnPoint3c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card3c, spawnPoint3c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card3c";
                    card.AddComponent<OnDestroyCard3c>();

                    spawnPointsDeck2.Remove(spawnPoint3c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card4") {
                    spawnPoint4 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card4, spawnPoint4, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card4";
                    card.AddComponent<OnDestroyCard4>();

                    spawnPointsDeck2.Remove(spawnPoint4);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card4a") {
                    spawnPoint4a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card4a, spawnPoint4a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card4a";
                    card.AddComponent<OnDestroyCard4a>();

                    spawnPointsDeck2.Remove(spawnPoint4a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card4b") {
                    spawnPoint4b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card4b, spawnPoint4b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card4b";
                    card.AddComponent<OnDestroyCard4b>();

                    spawnPointsDeck2.Remove(spawnPoint4b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card4c") {
                    spawnPoint4c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card4c, spawnPoint4c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card4c";
                    card.AddComponent<OnDestroyCard4c>();

                    spawnPointsDeck2.Remove(spawnPoint4c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card5") {
                    spawnPoint5 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card5, spawnPoint5, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card5";
                    card.AddComponent<OnDestroyCard5>();

                    spawnPointsDeck2.Remove(spawnPoint5);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card5a") {
                    spawnPoint5a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card5a, spawnPoint5a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card5a";
                    card.AddComponent<OnDestroyCard5a>();

                    spawnPointsDeck2.Remove(spawnPoint5a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card5b") {
                    spawnPoint5b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card5b, spawnPoint5b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card5b";
                    card.AddComponent<OnDestroyCard5b>();

                    spawnPointsDeck2.Remove(spawnPoint5b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card5c") {
                    spawnPoint5c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card5c, spawnPoint5c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card5c";
                    card.AddComponent<OnDestroyCard5c>();

                    spawnPointsDeck2.Remove(spawnPoint5c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card6") {
                    spawnPoint6 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card6, spawnPoint6, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card6";
                    card.AddComponent<OnDestroyCard6>();

                    spawnPointsDeck2.Remove(spawnPoint6);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card6a") {
                    spawnPoint6a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card6a, spawnPoint6a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card6a";
                    card.AddComponent<OnDestroyCard6a>();

                    spawnPointsDeck2.Remove(spawnPoint6a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card6b") {
                    spawnPoint6b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card6b, spawnPoint6b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card6b";
                    card.AddComponent<OnDestroyCard6b>();

                    spawnPointsDeck2.Remove(spawnPoint6b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card6c") {
                    spawnPoint6c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card6c, spawnPoint6c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card6c";
                    card.AddComponent<OnDestroyCard6c>();

                    spawnPointsDeck2.Remove(spawnPoint6c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card7") {
                    spawnPoint7 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card7, spawnPoint7, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card7";
                    card.AddComponent<OnDestroyCard7>();

                    spawnPointsDeck2.Remove(spawnPoint7);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card7a") {
                    spawnPoint7a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card7a, spawnPoint7a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card7a";
                    card.AddComponent<OnDestroyCard7a>();

                    spawnPointsDeck2.Remove(spawnPoint7a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card7b") {
                    spawnPoint7b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card7b, spawnPoint7b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card7b";
                    card.AddComponent<OnDestroyCard7b>();

                    spawnPointsDeck2.Remove(spawnPoint7b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card7c") {
                    spawnPoint7c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card7c, spawnPoint7c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card7c";
                    card.AddComponent<OnDestroyCard7c>();

                    spawnPointsDeck2.Remove(spawnPoint7c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card8") {
                    spawnPoint8 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card8, spawnPoint8, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card8";
                    card.AddComponent<OnDestroyCard8>();

                    spawnPointsDeck2.Remove(spawnPoint8);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card8a") {
                    spawnPoint8a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card8a, spawnPoint8a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card8a";
                    card.AddComponent<OnDestroyCard8a>();

                    spawnPointsDeck2.Remove(spawnPoint8a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card8b") {
                    spawnPoint8b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card8b, spawnPoint8b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card8b";
                    card.AddComponent<OnDestroyCard8b>();

                    spawnPointsDeck2.Remove(spawnPoint8b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card8c") {
                    spawnPoint8c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card8c, spawnPoint8c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card8c";
                    card.AddComponent<OnDestroyCard8c>();

                    spawnPointsDeck2.Remove(spawnPoint8c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card9") {
                    spawnPoint9 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card9, spawnPoint9, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card9";
                    card.AddComponent<OnDestroyCard9>();

                    spawnPointsDeck2.Remove(spawnPoint9);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card9a") {
                    spawnPoint9a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card9a, spawnPoint9a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card9a";
                    card.AddComponent<OnDestroyCard9a>();

                    spawnPointsDeck2.Remove(spawnPoint9a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card9b") {
                    spawnPoint9b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card9b, spawnPoint9b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card9b";
                    card.AddComponent<OnDestroyCard9b>();

                    spawnPointsDeck2.Remove(spawnPoint9b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card9c") {
                    spawnPoint9c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card9c, spawnPoint9c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card9c";
                    card.AddComponent<OnDestroyCard9c>();

                    spawnPointsDeck2.Remove(spawnPoint9c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card10") {
                    spawnPoint10 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card10, spawnPoint10, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card10";
                    card.AddComponent<OnDestroyCard10>();

                    spawnPointsDeck2.Remove(spawnPoint10);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card10a") {
                    spawnPoint10a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card10a, spawnPoint10a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card10a";
                    card.AddComponent<OnDestroyCard10a>();

                    spawnPointsDeck2.Remove(spawnPoint10a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card10b") {
                    spawnPoint10b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card10a, spawnPoint10b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card10b";
                    card.AddComponent<OnDestroyCard10b>();

                    spawnPointsDeck2.Remove(spawnPoint10b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card10c") {
                    spawnPoint10c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card10a, spawnPoint10c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card10c";
                    card.AddComponent<OnDestroyCard10c>();

                    spawnPointsDeck2.Remove(spawnPoint10c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card11") {
                    spawnPoint11 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card11, spawnPoint11, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card11";
                    card.AddComponent<OnDestroyCard11>();

                    spawnPointsDeck2.Remove(spawnPoint11);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card11a") {
                    spawnPoint11a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card11a, spawnPoint11a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card11a";
                    card.AddComponent<OnDestroyCard11a>();

                    spawnPointsDeck2.Remove(spawnPoint11a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card11b") {
                    spawnPoint11b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card11b, spawnPoint11b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card11b";
                    card.AddComponent<OnDestroyCard11b>();

                    spawnPointsDeck2.Remove(spawnPoint11b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card11c") {
                    spawnPoint11c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card11c, spawnPoint11c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card11c";
                    card.AddComponent<OnDestroyCard11c>();

                    spawnPointsDeck2.Remove(spawnPoint11c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card12") {
                    spawnPoint12 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card12, spawnPoint12, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card12";
                    card.AddComponent<OnDestroyCard12>();

                    spawnPointsDeck2.Remove(spawnPoint12);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card12a") {
                    spawnPoint12a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card12a, spawnPoint12a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card12a";
                    card.AddComponent<OnDestroyCard12a>();

                    spawnPointsDeck2.Remove(spawnPoint12a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card12b") {
                    spawnPoint12b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card12b, spawnPoint12b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card12b";
                    card.AddComponent<OnDestroyCard12b>();

                    spawnPointsDeck2.Remove(spawnPoint12b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card12c") {
                    spawnPoint12c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card12c, spawnPoint12c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card12c";
                    card.AddComponent<OnDestroyCard12c>();

                    spawnPointsDeck2.Remove(spawnPoint12c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card13") {
                    spawnPoint13 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card13, spawnPoint13, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card13";
                    card.AddComponent<OnDestroyCard13>();

                    spawnPointsDeck2.Remove(spawnPoint13);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card13a") {
                    spawnPoint13a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card13a, spawnPoint13a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card13a";
                    card.AddComponent<OnDestroyCard13a>();

                    spawnPointsDeck2.Remove(spawnPoint13a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card13b") {
                    spawnPoint13b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card13b, spawnPoint13b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card13b";
                    card.AddComponent<OnDestroyCard13b>();

                    spawnPointsDeck2.Remove(spawnPoint13b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card13c") {
                    spawnPoint13c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card13c, spawnPoint13c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card13c";
                    card.AddComponent<OnDestroyCard13c>();

                    spawnPointsDeck2.Remove(spawnPoint13c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card14") {
                    spawnPoint14 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card14, spawnPoint14, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card14";
                    card.AddComponent<OnDestroyCard14>();

                    spawnPointsDeck2.Remove(spawnPoint14);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card14a") {
                    spawnPoint14a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card14a, spawnPoint14a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card14a";
                    card.AddComponent<OnDestroyCard14a>();

                    spawnPointsDeck2.Remove(spawnPoint14a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card14b") {
                    spawnPoint14b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card14b, spawnPoint14b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card14b";
                    card.AddComponent<OnDestroyCard14b>();

                    spawnPointsDeck2.Remove(spawnPoint14b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card14c") {
                    spawnPoint14c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card14c, spawnPoint14c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card14c";
                    card.AddComponent<OnDestroyCard14c>();

                    spawnPointsDeck2.Remove(spawnPoint14c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card15") {
                    spawnPoint15 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card15, spawnPoint15, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card15";
                    card.AddComponent<OnDestroyCard15>();

                    spawnPointsDeck2.Remove(spawnPoint15);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card15a") {
                    spawnPoint15a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card15a, spawnPoint15a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card15a";
                    card.AddComponent<OnDestroyCard15a>();

                    spawnPointsDeck2.Remove(spawnPoint15a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card15b") {
                    spawnPoint15b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card15b, spawnPoint15b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card15b";
                    card.AddComponent<OnDestroyCard15b>();

                    spawnPointsDeck2.Remove(spawnPoint15b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card15c") {
                    spawnPoint15c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card15c, spawnPoint15c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card15c";
                    card.AddComponent<OnDestroyCard15c>();

                    spawnPointsDeck2.Remove(spawnPoint15c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card16") {
                    spawnPoint16 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card16, spawnPoint16, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card16";
                    card.AddComponent<OnDestroyCard16>();

                    spawnPointsDeck2.Remove(spawnPoint16);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card16a") {
                    spawnPoint16a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card16a, spawnPoint16a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card16a";
                    card.AddComponent<OnDestroyCard16a>();

                    spawnPointsDeck2.Remove(spawnPoint16a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card16b") {
                    spawnPoint16b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card16b, spawnPoint16b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card16b";
                    card.AddComponent<OnDestroyCard16b>();

                    spawnPointsDeck2.Remove(spawnPoint16b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card16c") {
                    spawnPoint16c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card16c, spawnPoint16c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card16c";
                    card.AddComponent<OnDestroyCard16c>();

                    spawnPointsDeck2.Remove(spawnPoint16c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card17") {
                    spawnPoint17 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card17, spawnPoint17, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card17";
                    card.AddComponent<OnDestroyCard17>();

                    spawnPointsDeck2.Remove(spawnPoint17);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card17a") {
                    spawnPoint17a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card17a, spawnPoint17a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card17a";
                    card.AddComponent<OnDestroyCard17a>();

                    spawnPointsDeck2.Remove(spawnPoint17a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card17b") {
                    spawnPoint17b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card17b, spawnPoint17b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card17b";
                    card.AddComponent<OnDestroyCard17b>();

                    spawnPointsDeck2.Remove(spawnPoint17b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card17c") {
                    spawnPoint17c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card17c, spawnPoint17c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card17c";
                    card.AddComponent<OnDestroyCard17c>();

                    spawnPointsDeck2.Remove(spawnPoint17c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card18") {
                    spawnPoint18 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card18, spawnPoint18, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card18";
                    card.AddComponent<OnDestroyCard18>();

                    spawnPointsDeck2.Remove(spawnPoint18);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card18a") {
                    spawnPoint18a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card18a, spawnPoint18a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card18a";
                    card.AddComponent<OnDestroyCard18a>();

                    spawnPointsDeck2.Remove(spawnPoint18a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card18b") {
                    spawnPoint18b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card18b, spawnPoint18b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card18b";
                    card.AddComponent<OnDestroyCard18b>();

                    spawnPointsDeck2.Remove(spawnPoint18b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card18c") {
                    spawnPoint18c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card18c, spawnPoint18c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card18c";
                    card.AddComponent<OnDestroyCard18c>();

                    spawnPointsDeck2.Remove(spawnPoint18c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card19") {
                    spawnPoint19 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card19, spawnPoint19, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card19";
                    card.AddComponent<OnDestroyCard19>();

                    spawnPointsDeck2.Remove(spawnPoint19);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card19a") {
                    spawnPoint19a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card19a, spawnPoint19a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card19a";
                    card.AddComponent<OnDestroyCard19a>();

                    spawnPointsDeck2.Remove(spawnPoint19a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card19b") {
                    spawnPoint19b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card19b, spawnPoint19b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card19b";
                    card.AddComponent<OnDestroyCard19b>();

                    spawnPointsDeck2.Remove(spawnPoint19b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card19c") {
                    spawnPoint19c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card19c, spawnPoint19c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card19c";
                    card.AddComponent<OnDestroyCard19c>();

                    spawnPointsDeck2.Remove(spawnPoint19c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card20") {
                    spawnPoint20 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card20, spawnPoint20, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card20";
                    card.AddComponent<OnDestroyCard20>();

                    spawnPointsDeck2.Remove(spawnPoint20);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card20a") {
                    spawnPoint20a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card20a, spawnPoint20a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card20a";
                    card.AddComponent<OnDestroyCard20a>();

                    spawnPointsDeck2.Remove(spawnPoint20a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card20b") {
                    spawnPoint20b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card20b, spawnPoint20b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card20b";
                    card.AddComponent<OnDestroyCard20b>();

                    spawnPointsDeck2.Remove(spawnPoint20b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card20c") {
                    spawnPoint20c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card20c, spawnPoint20c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card20c";
                    card.AddComponent<OnDestroyCard20c>();

                    spawnPointsDeck2.Remove(spawnPoint20c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card21") {
                    spawnPoint21 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card21, spawnPoint21, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card21";
                    card.AddComponent<OnDestroyCard21>();

                    spawnPointsDeck2.Remove(spawnPoint21);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card21a") {
                    spawnPoint21a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card21a, spawnPoint21a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card21a";
                    card.AddComponent<OnDestroyCard21a>();

                    spawnPointsDeck2.Remove(spawnPoint21a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card21b") {
                    spawnPoint21b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card21b, spawnPoint21b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card21b";
                    card.AddComponent<OnDestroyCard21b>();

                    spawnPointsDeck2.Remove(spawnPoint21b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card21c") {
                    spawnPoint21c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card21c, spawnPoint21c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card21c";
                    card.AddComponent<OnDestroyCard21c>();

                    spawnPointsDeck2.Remove(spawnPoint21c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card22") {
                    spawnPoint22 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card22, spawnPoint22, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card22";
                    card.AddComponent<OnDestroyCard22>();

                    spawnPointsDeck2.Remove(spawnPoint22);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card22a") {
                    spawnPoint22a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card22a, spawnPoint22a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card22a";
                    card.AddComponent<OnDestroyCard22a>();

                    spawnPointsDeck2.Remove(spawnPoint22a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card22b") {
                    spawnPoint22b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card22b, spawnPoint22b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card22b";
                    card.AddComponent<OnDestroyCard22b>();

                    spawnPointsDeck2.Remove(spawnPoint22b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card22c") {
                    spawnPoint22c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card22c, spawnPoint22c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card22c";
                    card.AddComponent<OnDestroyCard22c>();

                    spawnPointsDeck2.Remove(spawnPoint22c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card23") {
                    spawnPoint23 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card23, spawnPoint23, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card23";
                    card.AddComponent<OnDestroyCard23>();

                    spawnPointsDeck2.Remove(spawnPoint23);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card23a") {
                    spawnPoint23a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card23a, spawnPoint23a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card23a";
                    card.AddComponent<OnDestroyCard23a>();

                    spawnPointsDeck2.Remove(spawnPoint23a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card23b") {
                    spawnPoint23b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card23b, spawnPoint23b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card23b";
                    card.AddComponent<OnDestroyCard23b>();

                    spawnPointsDeck2.Remove(spawnPoint23b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card23c") {
                    spawnPoint23c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card23c, spawnPoint23c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card23c";
                    card.AddComponent<OnDestroyCard23c>();

                    spawnPointsDeck2.Remove(spawnPoint23c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card24") {
                    spawnPoint24 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card24, spawnPoint24, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card24";
                    card.AddComponent<OnDestroyCard24>();

                    spawnPointsDeck2.Remove(spawnPoint24);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card24a") {
                    spawnPoint24a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card24a, spawnPoint24a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card24a";
                    card.AddComponent<OnDestroyCard24a>();

                    spawnPointsDeck2.Remove(spawnPoint24a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card24b") {
                    spawnPoint24b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card24b, spawnPoint24b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card24b";
                    card.AddComponent<OnDestroyCard24b>();

                    spawnPointsDeck2.Remove(spawnPoint24b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card24c") {
                    spawnPoint24c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card24c, spawnPoint24c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card24c";
                    card.AddComponent<OnDestroyCard24c>();

                    spawnPointsDeck2.Remove(spawnPoint24c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card25") {
                    spawnPoint25 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card25, spawnPoint25, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card25";
                    card.AddComponent<OnDestroyCard25>();

                    spawnPointsDeck2.Remove(spawnPoint25);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card25a") {
                    spawnPoint25a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card25a, spawnPoint25a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card25a";
                    card.AddComponent<OnDestroyCard25a>();

                    spawnPointsDeck2.Remove(spawnPoint25a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card25b") {
                    spawnPoint25b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card25b, spawnPoint25b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card25b";
                    card.AddComponent<OnDestroyCard25b>();

                    spawnPointsDeck2.Remove(spawnPoint25b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card25c") {
                    spawnPoint25c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card25c, spawnPoint25c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card25c";
                    card.AddComponent<OnDestroyCard25c>();

                    spawnPointsDeck2.Remove(spawnPoint25c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card26") {
                    spawnPoint26 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card26, spawnPoint26, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card26";
                    card.AddComponent<OnDestroyCard26>();

                    spawnPointsDeck2.Remove(spawnPoint26);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card26a") {
                    spawnPoint26a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card26a, spawnPoint26a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card26a";
                    card.AddComponent<OnDestroyCard26a>();

                    spawnPointsDeck2.Remove(spawnPoint26a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card26b") {
                    spawnPoint26b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card26b, spawnPoint26b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card26b";
                    card.AddComponent<OnDestroyCard26b>();

                    spawnPointsDeck2.Remove(spawnPoint26b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card26c") {
                    spawnPoint26c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card26c, spawnPoint26c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card26c";
                    card.AddComponent<OnDestroyCard26c>();

                    spawnPointsDeck2.Remove(spawnPoint26c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card27") {
                    spawnPoint27 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card27, spawnPoint27, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card27";
                    card.AddComponent<OnDestroyCard27>();

                    spawnPointsDeck2.Remove(spawnPoint27);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card27a") {
                    spawnPoint27a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card27a, spawnPoint27a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card27a";
                    card.AddComponent<OnDestroyCard27a>();

                    spawnPointsDeck2.Remove(spawnPoint27a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card27b") {
                    spawnPoint27b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card27b, spawnPoint27b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card27b";
                    card.AddComponent<OnDestroyCard27b>();

                    spawnPointsDeck2.Remove(spawnPoint27b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card27c") {
                    spawnPoint27c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card27c, spawnPoint27c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card27c";
                    card.AddComponent<OnDestroyCard27c>();

                    spawnPointsDeck2.Remove(spawnPoint27c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card28") {
                    spawnPoint28 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card28, spawnPoint28, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card28";
                    card.AddComponent<OnDestroyCard28>();

                    spawnPointsDeck2.Remove(spawnPoint28);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card28a") {
                    spawnPoint28a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card28a, spawnPoint28a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card28a";
                    card.AddComponent<OnDestroyCard28a>();

                    spawnPointsDeck2.Remove(spawnPoint28a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card28b") {
                    spawnPoint28b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card28b, spawnPoint28b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card28b";
                    card.AddComponent<OnDestroyCard28b>();

                    spawnPointsDeck2.Remove(spawnPoint28b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card28c") {
                    spawnPoint28c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card28c, spawnPoint28c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card28c";
                    card.AddComponent<OnDestroyCard28c>();

                    spawnPointsDeck2.Remove(spawnPoint28c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card29") {
                    spawnPoint29 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card29, spawnPoint29, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card29";
                    card.AddComponent<OnDestroyCard29>();

                    spawnPointsDeck2.Remove(spawnPoint29);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card29a") {
                    spawnPoint29a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card29a, spawnPoint29a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card29a";
                    card.AddComponent<OnDestroyCard29a>();

                    spawnPointsDeck2.Remove(spawnPoint29a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card29b") {
                    spawnPoint29b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card29b, spawnPoint29b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card29b";
                    card.AddComponent<OnDestroyCard29b>();

                    spawnPointsDeck2.Remove(spawnPoint29b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card29c") {
                    spawnPoint29c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card29c, spawnPoint29c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card29c";
                    card.AddComponent<OnDestroyCard29c>();

                    spawnPointsDeck2.Remove(spawnPoint29c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card30") {
                    spawnPoint30 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card30, spawnPoint30, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card30";
                    card.AddComponent<OnDestroyCard30>();

                    spawnPointsDeck2.Remove(spawnPoint30);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card30a") {
                    spawnPoint30a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card30a, spawnPoint30a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card30a";
                    card.AddComponent<OnDestroyCard30a>();

                    spawnPointsDeck2.Remove(spawnPoint30a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card30b") {
                    spawnPoint30b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card30b, spawnPoint30b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card30b";
                    card.AddComponent<OnDestroyCard30b>();

                    spawnPointsDeck2.Remove(spawnPoint30b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card30c") {
                    spawnPoint30c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card30c, spawnPoint30c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card30c";
                    card.AddComponent<OnDestroyCard30c>();

                    spawnPointsDeck2.Remove(spawnPoint30c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card31") {
                    spawnPoint31 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card31, spawnPoint31, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card31";
                    card.AddComponent<OnDestroyCard31>();

                    spawnPointsDeck2.Remove(spawnPoint31);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card31a") {
                    spawnPoint31a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card31a, spawnPoint31a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card31a";
                    card.AddComponent<OnDestroyCard31a>();

                    spawnPointsDeck2.Remove(spawnPoint31a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card31b") {
                    spawnPoint31b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card31b, spawnPoint31b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card31b";
                    card.AddComponent<OnDestroyCard31b>();

                    spawnPointsDeck2.Remove(spawnPoint31b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card31c") {
                    spawnPoint31c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card31c, spawnPoint31c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card31c";
                    card.AddComponent<OnDestroyCard31c>();

                    spawnPointsDeck2.Remove(spawnPoint31c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card32") {
                    spawnPoint32 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card32, spawnPoint32, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card32";
                    card.AddComponent<OnDestroyCard32>();

                    spawnPointsDeck2.Remove(spawnPoint32);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card32a") {
                    spawnPoint32a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card32a, spawnPoint32a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card32a";
                    card.AddComponent<OnDestroyCard32a>();

                    spawnPointsDeck2.Remove(spawnPoint32a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card32b") {
                    spawnPoint32b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card32b, spawnPoint32b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card32b";
                    card.AddComponent<OnDestroyCard32b>();

                    spawnPointsDeck2.Remove(spawnPoint32b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card32c") {
                    spawnPoint32c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card32c, spawnPoint32c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card32c";
                    card.AddComponent<OnDestroyCard32c>();

                    spawnPointsDeck2.Remove(spawnPoint32c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card33") {
                    spawnPoint33 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card33, spawnPoint33, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card33";
                    card.AddComponent<OnDestroyCard33>();

                    spawnPointsDeck2.Remove(spawnPoint33);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card33a") {
                    spawnPoint33a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card33a, spawnPoint33a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card33a";
                    card.AddComponent<OnDestroyCard33a>();

                    spawnPointsDeck2.Remove(spawnPoint33a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card33b") {
                    spawnPoint33b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card33b, spawnPoint33b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card33b";
                    card.AddComponent<OnDestroyCard33b>();

                    spawnPointsDeck2.Remove(spawnPoint33b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card33c") {
                    spawnPoint33c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card33c, spawnPoint33c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card33c";
                    card.AddComponent<OnDestroyCard33c>();

                    spawnPointsDeck2.Remove(spawnPoint33c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card34") {
                    spawnPoint34 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card34, spawnPoint34, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card34";
                    card.AddComponent<OnDestroyCard34>();

                    spawnPointsDeck2.Remove(spawnPoint34);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card34a") {
                    spawnPoint34a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card34a, spawnPoint34a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card34a";
                    card.AddComponent<OnDestroyCard34a>();

                    spawnPointsDeck2.Remove(spawnPoint34a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card34b") {
                    spawnPoint34b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card34b, spawnPoint34b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card34b";
                    card.AddComponent<OnDestroyCard34b>();

                    spawnPointsDeck2.Remove(spawnPoint34b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card34c") {
                    spawnPoint34c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card34c, spawnPoint34c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card34c";
                    card.AddComponent<OnDestroyCard34c>();

                    spawnPointsDeck2.Remove(spawnPoint34c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card35") {
                    spawnPoint35 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card35, spawnPoint35, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card35";
                    card.AddComponent<OnDestroyCard35>();

                    spawnPointsDeck2.Remove(spawnPoint35);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card35a") {
                    spawnPoint35a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card35a, spawnPoint35a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card35a";
                    card.AddComponent<OnDestroyCard35a>();

                    spawnPointsDeck2.Remove(spawnPoint35a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card35b") {
                    spawnPoint35b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card35b, spawnPoint35b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card35b";
                    card.AddComponent<OnDestroyCard35b>();

                    spawnPointsDeck2.Remove(spawnPoint35b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card35c") {
                    spawnPoint35c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card35c, spawnPoint35c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card35c";
                    card.AddComponent<OnDestroyCard35c>();

                    spawnPointsDeck2.Remove(spawnPoint35c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card36") {
                    spawnPoint36 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card36, spawnPoint36, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card36";
                    card.AddComponent<OnDestroyCard36>();

                    spawnPointsDeck2.Remove(spawnPoint36);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card36a") {
                    spawnPoint36a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card36a, spawnPoint36a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card36a";
                    card.AddComponent<OnDestroyCard36a>();

                    spawnPointsDeck2.Remove(spawnPoint36a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card36b") {
                    spawnPoint36b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card36b, spawnPoint36b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card36b";
                    card.AddComponent<OnDestroyCard36b>();

                    spawnPointsDeck2.Remove(spawnPoint36b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card36c") {
                    spawnPoint36c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card36c, spawnPoint36c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card36c";
                    card.AddComponent<OnDestroyCard36c>();

                    spawnPointsDeck2.Remove(spawnPoint36c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card37") {
                    spawnPoint37 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card37, spawnPoint37, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card37";
                    card.AddComponent<OnDestroyCard37>();

                    spawnPointsDeck2.Remove(spawnPoint37);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card37a") {
                    spawnPoint37a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card37a, spawnPoint37a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card37a";
                    card.AddComponent<OnDestroyCard37a>();

                    spawnPointsDeck2.Remove(spawnPoint37a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card37b") {
                    spawnPoint37b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card37b, spawnPoint37b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card37b";
                    card.AddComponent<OnDestroyCard37b>();

                    spawnPointsDeck2.Remove(spawnPoint37b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card37c") {
                    spawnPoint37c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card37c, spawnPoint37c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card37c";
                    card.AddComponent<OnDestroyCard37c>();

                    spawnPointsDeck2.Remove(spawnPoint37c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card38") {
                    spawnPoint38 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card38, spawnPoint38, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card38";
                    card.AddComponent<OnDestroyCard38>();

                    spawnPointsDeck2.Remove(spawnPoint38);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card38a") {
                    spawnPoint38a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card38a, spawnPoint38a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card38a";
                    card.AddComponent<OnDestroyCard38a>();

                    spawnPointsDeck2.Remove(spawnPoint38a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card38b") {
                    spawnPoint38b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card38b, spawnPoint38b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card38b";
                    card.AddComponent<OnDestroyCard38b>();

                    spawnPointsDeck2.Remove(spawnPoint38b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card38c") {
                    spawnPoint38c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card38c, spawnPoint38c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card38c";
                    card.AddComponent<OnDestroyCard38c>();

                    spawnPointsDeck2.Remove(spawnPoint38c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card39") {
                    spawnPoint39 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card39, spawnPoint39, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card39";
                    card.AddComponent<OnDestroyCard39>();

                    spawnPointsDeck2.Remove(spawnPoint39);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card39a") {
                    spawnPoint39a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card39a, spawnPoint39a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card39a";
                    card.AddComponent<OnDestroyCard39a>();

                    spawnPointsDeck2.Remove(spawnPoint39a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card39b") {
                    spawnPoint39b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card39b, spawnPoint39b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card39b";
                    card.AddComponent<OnDestroyCard39b>();

                    spawnPointsDeck2.Remove(spawnPoint39b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card39c") {
                    spawnPoint39c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card39c, spawnPoint39c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card39c";
                    card.AddComponent<OnDestroyCard39c>();

                    spawnPointsDeck2.Remove(spawnPoint39c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card40") {
                    spawnPoint40 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card40, spawnPoint40, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card40";
                    card.AddComponent<OnDestroyCard40>();

                    spawnPointsDeck2.Remove(spawnPoint40);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card40a") {
                    spawnPoint40a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card40a, spawnPoint40a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card40a";
                    card.AddComponent<OnDestroyCard40a>();

                    spawnPointsDeck2.Remove(spawnPoint40a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card40b") {
                    spawnPoint40b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card40b, spawnPoint40b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card40b";
                    card.AddComponent<OnDestroyCard40b>();

                    spawnPointsDeck2.Remove(spawnPoint40b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card40c") {
                    spawnPoint40c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card40c, spawnPoint40c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card40c";
                    card.AddComponent<OnDestroyCard40c>();

                    spawnPointsDeck2.Remove(spawnPoint40c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card41") {
                    spawnPoint41 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card41, spawnPoint41, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card41";
                    card.AddComponent<OnDestroyCard41>();

                    spawnPointsDeck2.Remove(spawnPoint41);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card41a") {
                    spawnPoint41a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card41a, spawnPoint41a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card41a";
                    card.AddComponent<OnDestroyCard41a>();

                    spawnPointsDeck2.Remove(spawnPoint41a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card41b") {
                    spawnPoint41b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card41b, spawnPoint41b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card41b";
                    card.AddComponent<OnDestroyCard41b>();

                    spawnPointsDeck2.Remove(spawnPoint41b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card41c") {
                    spawnPoint41c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card41c, spawnPoint41c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card41c";
                    card.AddComponent<OnDestroyCard41c>();

                    spawnPointsDeck2.Remove(spawnPoint41c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card42") {
                    spawnPoint42 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card42, spawnPoint42, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card42";
                    card.AddComponent<OnDestroyCard42>();

                    spawnPointsDeck2.Remove(spawnPoint42);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card42a") {
                    spawnPoint42a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card42a, spawnPoint42a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card42a";
                    card.AddComponent<OnDestroyCard42a>();

                    spawnPointsDeck2.Remove(spawnPoint42a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card42b") {
                    spawnPoint42b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card42b, spawnPoint42b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card42b";
                    card.AddComponent<OnDestroyCard42b>();

                    spawnPointsDeck2.Remove(spawnPoint42b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card42c") {
                    spawnPoint42c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card42c, spawnPoint42c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card42c";
                    card.AddComponent<OnDestroyCard42c>();

                    spawnPointsDeck2.Remove(spawnPoint42c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card43") {
                    spawnPoint43 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card43, spawnPoint43, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card43";
                    card.AddComponent<OnDestroyCard43>();

                    spawnPointsDeck2.Remove(spawnPoint43);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card43a") {
                    spawnPoint43a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card43a, spawnPoint43a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card43a";
                    card.AddComponent<OnDestroyCard43a>();

                    spawnPointsDeck2.Remove(spawnPoint43a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card43b") {
                    spawnPoint43b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card43b, spawnPoint43b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card43b";
                    card.AddComponent<OnDestroyCard43b>();

                    spawnPointsDeck2.Remove(spawnPoint43b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card43c") {
                    spawnPoint43c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card43c, spawnPoint43c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card43c";
                    card.AddComponent<OnDestroyCard43c>();

                    spawnPointsDeck2.Remove(spawnPoint43c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card44") {
                    spawnPoint44 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card44, spawnPoint44, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card44";
                    card.AddComponent<OnDestroyCard44>();

                    spawnPointsDeck2.Remove(spawnPoint44);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card44a") {
                    spawnPoint44a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card44a, spawnPoint44a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card44a";
                    card.AddComponent<OnDestroyCard44a>();

                    spawnPointsDeck2.Remove(spawnPoint44a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card44b") {
                    spawnPoint44b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card44b, spawnPoint44b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card44b";
                    card.AddComponent<OnDestroyCard44b>();

                    spawnPointsDeck2.Remove(spawnPoint44b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card44c") {
                    spawnPoint44c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card44c, spawnPoint44c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card44c";
                    card.AddComponent<OnDestroyCard44c>();

                    spawnPointsDeck2.Remove(spawnPoint44c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card45") {
                    spawnPoint45 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card45, spawnPoint45, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card45";
                    card.AddComponent<OnDestroyCard45>();

                    spawnPointsDeck2.Remove(spawnPoint45);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card45a") {
                    spawnPoint45a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card45a, spawnPoint45a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card45a";
                    card.AddComponent<OnDestroyCard45a>();

                    spawnPointsDeck2.Remove(spawnPoint45a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card45b") {
                    spawnPoint45b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card45b, spawnPoint45b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card45b";
                    card.AddComponent<OnDestroyCard45b>();

                    spawnPointsDeck2.Remove(spawnPoint45b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card45c") {
                    spawnPoint45c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card45c, spawnPoint45c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card45c";
                    card.AddComponent<OnDestroyCard45c>();

                    spawnPointsDeck2.Remove(spawnPoint45c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card46") {
                    spawnPoint46 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card46, spawnPoint46, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card46";
                    card.AddComponent<OnDestroyCard46>();

                    spawnPointsDeck2.Remove(spawnPoint46);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card46a") {
                    spawnPoint46a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card46a, spawnPoint46a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card46a";
                    card.AddComponent<OnDestroyCard46a>();

                    spawnPointsDeck2.Remove(spawnPoint46a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card46b") {
                    spawnPoint46b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card46b, spawnPoint46b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card46b";
                    card.AddComponent<OnDestroyCard46b>();

                    spawnPointsDeck2.Remove(spawnPoint46b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card46c") {
                    spawnPoint46c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card46c, spawnPoint46c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card46c";
                    card.AddComponent<OnDestroyCard46c>();

                    spawnPointsDeck2.Remove(spawnPoint46c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card47") {
                    spawnPoint47 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card47, spawnPoint47, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card47";
                    card.AddComponent<OnDestroyCard47>();

                    spawnPointsDeck2.Remove(spawnPoint47);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card47a") {
                    spawnPoint47a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card47a, spawnPoint47a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card47a";
                    card.AddComponent<OnDestroyCard47a>();

                    spawnPointsDeck2.Remove(spawnPoint47a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card47b") {
                    spawnPoint47b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card47b, spawnPoint47b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card47b";
                    card.AddComponent<OnDestroyCard47b>();

                    spawnPointsDeck2.Remove(spawnPoint47b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card47c") {
                    spawnPoint47c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card47c, spawnPoint47c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card47c";
                    card.AddComponent<OnDestroyCard47c>();

                    spawnPointsDeck2.Remove(spawnPoint47c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card48") {
                    spawnPoint48 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card48, spawnPoint48, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card48";
                    card.AddComponent<OnDestroyCard48>();

                    spawnPointsDeck2.Remove(spawnPoint48);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card48a") {
                    spawnPoint48a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card48a, spawnPoint48a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card48a";
                    card.AddComponent<OnDestroyCard48a>();

                    spawnPointsDeck2.Remove(spawnPoint48a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card48b") {
                    spawnPoint48b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card48b, spawnPoint48b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card48b";
                    card.AddComponent<OnDestroyCard48b>();

                    spawnPointsDeck2.Remove(spawnPoint48b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card48c") {
                    spawnPoint48c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card48c, spawnPoint48c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card48c";
                    card.AddComponent<OnDestroyCard48c>();

                    spawnPointsDeck2.Remove(spawnPoint48c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card49") {
                    spawnPoint49 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card49, spawnPoint49, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card49";
                    card.AddComponent<OnDestroyCard49>();

                    spawnPointsDeck2.Remove(spawnPoint49);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card49a") {
                    spawnPoint49a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card49a, spawnPoint49a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card49a";
                    card.AddComponent<OnDestroyCard49a>();

                    spawnPointsDeck2.Remove(spawnPoint49a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card49b") {
                    spawnPoint49b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card49b, spawnPoint49b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card49b";
                    card.AddComponent<OnDestroyCard49b>();

                    spawnPointsDeck2.Remove(spawnPoint49b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card49c") {
                    spawnPoint49c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card49c, spawnPoint49c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card49c";
                    card.AddComponent<OnDestroyCard49c>();

                    spawnPointsDeck2.Remove(spawnPoint49c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card50") {
                    spawnPoint50 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card50, spawnPoint50, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card50";
                    card.AddComponent<OnDestroyCard50>();

                    spawnPointsDeck2.Remove(spawnPoint50);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card50a") {
                    spawnPoint50a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card50a, spawnPoint50a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card50a";
                    card.AddComponent<OnDestroyCard50a>();

                    spawnPointsDeck2.Remove(spawnPoint50a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card50b") {
                    spawnPoint50b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card50b, spawnPoint50b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card50b";
                    card.AddComponent<OnDestroyCard50b>();

                    spawnPointsDeck2.Remove(spawnPoint50b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card50c") {
                    spawnPoint50c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card50c, spawnPoint50c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card50c";
                    card.AddComponent<OnDestroyCard50c>();

                    spawnPointsDeck2.Remove(spawnPoint50c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card51") {
                    spawnPoint51 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card51, spawnPoint51, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card51";
                    card.AddComponent<OnDestroyCard51>();

                    spawnPointsDeck2.Remove(spawnPoint51);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card51a") {
                    spawnPoint51a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card51a, spawnPoint51a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card51a";
                    card.AddComponent<OnDestroyCard51a>();

                    spawnPointsDeck2.Remove(spawnPoint51a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card51b") {
                    spawnPoint51b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card51b, spawnPoint51b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card51b";
                    card.AddComponent<OnDestroyCard51b>();

                    spawnPointsDeck2.Remove(spawnPoint51b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card51c") {
                    spawnPoint51c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card51c, spawnPoint51c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card51c";
                    card.AddComponent<OnDestroyCard51c>();

                    spawnPointsDeck2.Remove(spawnPoint51c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card52") {
                    spawnPoint52 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card52, spawnPoint52, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card52";
                    card.AddComponent<OnDestroyCard52>();

                    spawnPointsDeck2.Remove(spawnPoint52);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card52a") {
                    spawnPoint52a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card52a, spawnPoint52a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card52a";
                    card.AddComponent<OnDestroyCard52a>();

                    spawnPointsDeck2.Remove(spawnPoint52a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card52b") {
                    spawnPoint52b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card52b, spawnPoint52b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card52b";
                    card.AddComponent<OnDestroyCard52b>();

                    spawnPointsDeck2.Remove(spawnPoint52b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card52c") {
                    spawnPoint52c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card52c, spawnPoint52c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card52c";
                    card.AddComponent<OnDestroyCard52c>();

                    spawnPointsDeck2.Remove(spawnPoint52c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card53") {
                    spawnPoint53 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card53, spawnPoint53, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card53";
                    card.AddComponent<OnDestroyCard53>();

                    spawnPointsDeck2.Remove(spawnPoint53);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card53a") {
                    spawnPoint53a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card53a, spawnPoint53a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card53a";
                    card.AddComponent<OnDestroyCard53a>();

                    spawnPointsDeck2.Remove(spawnPoint53a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card53b") {
                    spawnPoint53b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card53b, spawnPoint53b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card53b";
                    card.AddComponent<OnDestroyCard53b>();

                    spawnPointsDeck2.Remove(spawnPoint53b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card53c") {
                    spawnPoint53c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card53c, spawnPoint53c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card53c";
                    card.AddComponent<OnDestroyCard53c>();

                    spawnPointsDeck2.Remove(spawnPoint53c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card54") {
                    spawnPoint54 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card54, spawnPoint54, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card54";
                    card.AddComponent<OnDestroyCard54>();

                    spawnPointsDeck2.Remove(spawnPoint54);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card54a") {
                    spawnPoint54a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card54a, spawnPoint54a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card54a";
                    card.AddComponent<OnDestroyCard54a>();

                    spawnPointsDeck2.Remove(spawnPoint54a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card54b") {
                    spawnPoint54b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card54b, spawnPoint54b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card54b";
                    card.AddComponent<OnDestroyCard54b>();

                    spawnPointsDeck2.Remove(spawnPoint54b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card54c") {
                    spawnPoint54c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card54c, spawnPoint54c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card54c";
                    card.AddComponent<OnDestroyCard54c>();

                    spawnPointsDeck2.Remove(spawnPoint54c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card55") {
                    spawnPoint55 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card55, spawnPoint55, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card55";
                    card.AddComponent<OnDestroyCard55>();

                    spawnPointsDeck2.Remove(spawnPoint55);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card55a") {
                    spawnPoint55a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card55a, spawnPoint55a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card55a";
                    card.AddComponent<OnDestroyCard55a>();

                    spawnPointsDeck2.Remove(spawnPoint55a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card55b") {
                    spawnPoint55b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card55b, spawnPoint55b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card55b";
                    card.AddComponent<OnDestroyCard55b>();

                    spawnPointsDeck2.Remove(spawnPoint55b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card55c") {
                    spawnPoint55c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card55c, spawnPoint55c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card55c";
                    card.AddComponent<OnDestroyCard55c>();

                    spawnPointsDeck2.Remove(spawnPoint55c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card56") {
                    spawnPoint56 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card56, spawnPoint56, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card56";
                    card.AddComponent<OnDestroyCard56>();

                    spawnPointsDeck2.Remove(spawnPoint56);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card56a") {
                    spawnPoint56a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card56a, spawnPoint56a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card56a";
                    card.AddComponent<OnDestroyCard56a>();

                    spawnPointsDeck2.Remove(spawnPoint56a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card56b") {
                    spawnPoint56b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card56b, spawnPoint56b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card56b";
                    card.AddComponent<OnDestroyCard56b>();

                    spawnPointsDeck2.Remove(spawnPoint56b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card56c") {
                    spawnPoint56c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card56c, spawnPoint56c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card56c";
                    card.AddComponent<OnDestroyCard56c>();

                    spawnPointsDeck2.Remove(spawnPoint56c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card57") {
                    spawnPoint57 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card57, spawnPoint57, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card57";
                    card.AddComponent<OnDestroyCard57>();

                    spawnPointsDeck2.Remove(spawnPoint57);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card57a") {
                    spawnPoint57a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card57a, spawnPoint57a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card57a";
                    card.AddComponent<OnDestroyCard57a>();

                    spawnPointsDeck2.Remove(spawnPoint57a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card57b") {
                    spawnPoint57b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card57b, spawnPoint57b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card57b";
                    card.AddComponent<OnDestroyCard57b>();

                    spawnPointsDeck2.Remove(spawnPoint57b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card57c") {
                    spawnPoint57c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card57c, spawnPoint57c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card57c";
                    card.AddComponent<OnDestroyCard57c>();

                    spawnPointsDeck2.Remove(spawnPoint57c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card58") {
                    spawnPoint58 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card58, spawnPoint58, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card58";
                    card.AddComponent<OnDestroyCard58>();

                    spawnPointsDeck2.Remove(spawnPoint58);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card58a") {
                    spawnPoint58a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card58a, spawnPoint58a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card58a";
                    card.AddComponent<OnDestroyCard58a>();

                    spawnPointsDeck2.Remove(spawnPoint58a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card58b") {
                    spawnPoint58b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card58b, spawnPoint58b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card58b";
                    card.AddComponent<OnDestroyCard58b>();

                    spawnPointsDeck2.Remove(spawnPoint58b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card58c") {
                    spawnPoint58c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card58c, spawnPoint58c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card58c";
                    card.AddComponent<OnDestroyCard58c>();

                    spawnPointsDeck2.Remove(spawnPoint58c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card59") {
                    spawnPoint59 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card59, spawnPoint59, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card59";
                    card.AddComponent<OnDestroyCard59>();

                    spawnPointsDeck2.Remove(spawnPoint59);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card59a") {
                    spawnPoint59a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card59a, spawnPoint59a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card59a";
                    card.AddComponent<OnDestroyCard59a>();

                    spawnPointsDeck2.Remove(spawnPoint59a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card59b") {
                    spawnPoint59b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card59b, spawnPoint59b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card59b";
                    card.AddComponent<OnDestroyCard59b>();

                    spawnPointsDeck2.Remove(spawnPoint59b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card59c") {
                    spawnPoint59c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card59c, spawnPoint59c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card59c";
                    card.AddComponent<OnDestroyCard59c>();

                    spawnPointsDeck2.Remove(spawnPoint59c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card60") {
                    spawnPoint60 = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card60, spawnPoint60, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card60";
                    card.AddComponent<OnDestroyCard60>();

                    spawnPointsDeck2.Remove(spawnPoint60);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card60a") {
                    spawnPoint60a = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card60a, spawnPoint60a, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card60a";
                    card.AddComponent<OnDestroyCard60a>();

                    spawnPointsDeck2.Remove(spawnPoint60a);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card60b") {
                    spawnPoint60b = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card60b, spawnPoint60b, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card60b";
                    card.AddComponent<OnDestroyCard60b>();

                    spawnPointsDeck2.Remove(spawnPoint60b);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

                if (cardReference == "instantiated2Card60c") {
                    spawnPoint60c = spawnPointsDeck2[UnityEngine.Random.Range(0, spawnPointsDeck2.Count)];

                    GameObject card = Instantiate(card60c, spawnPoint60c, Quaternion.identity) as GameObject;
                    card.transform.localScale = new Vector3(325f, 200f, 340.0f);
                    card.name = "instantiated2Card60c";
                    card.AddComponent<OnDestroyCard60c>();

                    spawnPointsDeck2.Remove(spawnPoint60c);
                    //spawnPointsDeck2.RemoveAll(item => item == null);

                }

            }
        }


    }
	
	[Serializable]
    public class DataToSave2 {

        /*
			*
			* Serializable class for storing data in the binary file.		
			*
		*/

        //Name of the deck
        public string deckName2;
        //List of the card references to stored cards
        public List<string> cardsDeck2;
    }
}


    



	

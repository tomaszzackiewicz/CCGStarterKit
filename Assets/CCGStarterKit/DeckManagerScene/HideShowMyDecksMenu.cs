using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace Caerwent {

    public class HideShowMyDecksMenu : MonoBehaviour {

        private GameObject deck1;
        private GameObject deck2;
        private GameObject deck3;
        private GameObject deckButtons1;
        private GameObject deckButtons2;
        private GameObject deckButtons3;
        private GameObject myDecksPanel;
        private bool maindeckButtonsSwitcher;
        private bool deck1Buttons;
        private bool deck2Buttons;
        private bool deck3Buttons;
        private GameObject deck1NameButton;
        private GameObject deck2NameButton;
        private GameObject deck3NameButton;


        void Awake() {
            deck1 = GameObject.Find("Deck1");
            deck2 = GameObject.Find("Deck2");
            deck3 = GameObject.Find("Deck3");
            deckButtons1 = GameObject.Find("Deck1Buttons");
            deckButtons2 = GameObject.Find("Deck2Buttons");
            deckButtons3 = GameObject.Find("Deck3Buttons");
            myDecksPanel = GameObject.Find("MyDecksPanel");
            deck1NameButton = GameObject.Find("Deck1Text");
            deck2NameButton = GameObject.Find("Deck2Text");
            deck3NameButton = GameObject.Find("Deck3Text");

        }

        // Use this for initialization
        void Start() {
            deck1.SetActive(false);
            deck2.SetActive(false);
            deck3.SetActive(false);
            deckButtons1.SetActive(false);
            deckButtons2.SetActive(false);
            deckButtons3.SetActive(false);
            myDecksPanel.SetActive(false);
            maindeckButtonsSwitcher = false;
        }

        // Update is called once per frame
        void Update() {

            if (maindeckButtonsSwitcher) {
                if (deck1NameButton.GetComponent<Text>().text == "") {
                    deck1NameButton.GetComponent<Text>().text = "Deck 1";
                }
                if (deck2NameButton.GetComponent<Text>().text == "") {
                    deck2NameButton.GetComponent<Text>().text = "Deck 2";
                }
                if (deck3NameButton.GetComponent<Text>().text == "") {
                    deck3NameButton.GetComponent<Text>().text = "Deck 3";
                }

                myDecksPanel.SetActive(true);
                deck1.SetActive(true);
                deck2.SetActive(true);
                deck3.SetActive(true);
            } else {
                myDecksPanel.SetActive(false);
                deck1.SetActive(false);
                deck2.SetActive(false);
                deck3.SetActive(false);
            }
            //
            if (deck1Buttons && SaveCardDeck1.saveCardDeck1.isDeck1Editing) {
                deckButtons1.SetActive(true);
            } else {
                deckButtons1.SetActive(false);
            }
            //
            if (deck2Buttons && SaveCardDeck2.saveCardDeck2.isDeck2Editing) {
                deckButtons2.SetActive(true);
            } else {
                deckButtons2.SetActive(false);
            }
            //
            if (deck3Buttons && SaveCardDeck3.saveCardDeck3.isDeck3Editing) {
                deckButtons3.SetActive(true);
            } else {
                deckButtons3.SetActive(false);
            }

        }

        public void SetPanelDecksActive() {

            maindeckButtonsSwitcher = !maindeckButtonsSwitcher;
        }

        public void SetDeck1Active() {
            deck1Buttons = !deck1Buttons;
        }

        public void SetDeck2Active() {
            deck2Buttons = !deck2Buttons;
        }

        public void SetDeck3Active() {
            deck3Buttons = !deck3Buttons;
        }
    }
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard29c : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter29c >= 0) {
                CardCounterManager.counter29c--;
                CardCounterManager.CardCounter29c();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter29cDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter29cDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter29cDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject29c) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject29c.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel29c.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

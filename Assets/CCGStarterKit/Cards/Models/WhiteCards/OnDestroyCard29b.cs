using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard29b : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter29b >= 0) {
                CardCounterManager.counter29b--;
                CardCounterManager.CardCounter29b();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter29bDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter29bDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter29bDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject29b) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject29b.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel29b.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

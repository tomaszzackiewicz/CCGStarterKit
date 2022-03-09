using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard29a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter29a >= 0) {
                CardCounterManager.counter29a--;
                CardCounterManager.CardCounter29a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter29aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter29aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter29aDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject29a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject29a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel29a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

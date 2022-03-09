using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard10 : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter10 >= 0) {
                CardCounterManager.counter10--;
                CardCounterManager.CardCounter10();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter10Deck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter10Deck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter10Deck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject10) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject10.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel10.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

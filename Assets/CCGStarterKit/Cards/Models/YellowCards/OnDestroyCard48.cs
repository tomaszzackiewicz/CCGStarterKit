using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard48 : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter48 >= 0) {
                CardCounterManager.counter48--;
                CardCounterManager.CardCounter48();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter48Deck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter48Deck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter48Deck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject48) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject48.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel48.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard7 : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter7 >= 0) {
                CardCounterManager.counter7--;
                CardCounterManager.CardCounter7();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter7Deck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter7Deck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter7Deck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject7) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject7.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel7.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

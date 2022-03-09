using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard7b : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter7b >= 0) {
                CardCounterManager.counter7b--;
                CardCounterManager.CardCounter7b();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter7bDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter7bDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter7bDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject7b) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject7b.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel7b.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

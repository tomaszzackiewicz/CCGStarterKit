using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard4b : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter4b >= 0) {
                CardCounterManager.counter4b--;
                CardCounterManager.CardCounter4b();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter4bDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter4bDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter4bDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject4b) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject4b.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel4b.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

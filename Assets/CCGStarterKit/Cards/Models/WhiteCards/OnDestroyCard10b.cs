using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard10b : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter10b >= 0) {
                CardCounterManager.counter10b--;
                CardCounterManager.CardCounter10b();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter10bDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter10bDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter10bDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject10b) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject10b.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel10b.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard48b : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter48b >= 0) {
                CardCounterManager.counter48b--;
                CardCounterManager.CardCounter48b();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter48bDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter48bDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter48bDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject48b) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject48b.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel48b.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

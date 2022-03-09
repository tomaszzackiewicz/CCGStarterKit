using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard48c : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter48c >= 0) {
                CardCounterManager.counter48c--;
                CardCounterManager.CardCounter48c();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter48cDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter48cDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter48cDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject48c) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject48c.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel48c.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

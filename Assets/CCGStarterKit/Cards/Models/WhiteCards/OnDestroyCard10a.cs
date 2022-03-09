using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard10a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter10a >= 0) {
                CardCounterManager.counter10a--;
                CardCounterManager.CardCounter10a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter10aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter10aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter10aDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject10a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject10a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel10a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }

}

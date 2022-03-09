using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard54c : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter54c >= 0) {
                CardCounterManager.counter54c--;
                CardCounterManager.CardCounter54c();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter54cDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter54cDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter54cDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject54c) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject54c.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel54c.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

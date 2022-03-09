using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard5c : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter5c >= 0) {
                CardCounterManager.counter5c--;
                CardCounterManager.CardCounter5c();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter5cDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter5cDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter5cDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject5c) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject5c.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel5c.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

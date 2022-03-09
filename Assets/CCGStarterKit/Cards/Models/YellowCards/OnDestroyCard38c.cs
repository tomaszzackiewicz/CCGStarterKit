using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard38c : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter38c >= 0) {
                CardCounterManager.counter38c--;
                CardCounterManager.CardCounter38c();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter38cDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter38cDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter38cDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject38c) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject38c.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel38c.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

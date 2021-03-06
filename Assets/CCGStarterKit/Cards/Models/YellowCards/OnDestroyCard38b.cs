using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard38b : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter38b >= 0) {
                CardCounterManager.counter38b--;
                CardCounterManager.CardCounter38b();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter38bDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter38bDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter38bDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject38b) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject38b.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel38b.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard27b : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter27b >= 0) {
                CardCounterManager.counter27b--;
                CardCounterManager.CardCounter27b();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter27bDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter27bDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter27bDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject27b) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject27b.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel27b.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

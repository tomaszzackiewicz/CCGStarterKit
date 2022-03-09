using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard31b : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter31b >= 0) {
                CardCounterManager.counter31b--;
                CardCounterManager.CardCounter31b();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter31bDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter31bDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter31bDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject31b) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject31b.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel31b.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

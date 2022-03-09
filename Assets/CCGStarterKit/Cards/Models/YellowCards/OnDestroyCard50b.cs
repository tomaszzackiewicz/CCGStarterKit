using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard50b : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter50b >= 0) {
                CardCounterManager.counter50b--;
                CardCounterManager.CardCounter50b();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter50bDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter50bDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter50bDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject50b) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject50b.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel50b.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

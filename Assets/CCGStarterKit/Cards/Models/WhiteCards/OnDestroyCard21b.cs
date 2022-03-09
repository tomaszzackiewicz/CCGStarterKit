using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard21b : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter21b >= 0) {
                CardCounterManager.counter21b--;
                CardCounterManager.CardCounter21b();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter21bDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter21bDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter21bDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject21b) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject21b.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel21b.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

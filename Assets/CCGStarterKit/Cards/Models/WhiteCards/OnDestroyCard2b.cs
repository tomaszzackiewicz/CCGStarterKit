using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard2b : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter2b >= 0) {
                CardCounterManager.counter2b--;
                CardCounterManager.CardCounter2b();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter2bDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter2bDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter2bDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject2b) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject2b.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel2b.transform.localScale = DeckManager.deckManager.modelCardScale;
                }
            }

        }
    }
}

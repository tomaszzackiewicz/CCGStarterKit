using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard7a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter7a >= 0) {
                CardCounterManager.counter7a--;
                CardCounterManager.CardCounter7a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter7aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter7aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter7aDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject7a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject7a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel7a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

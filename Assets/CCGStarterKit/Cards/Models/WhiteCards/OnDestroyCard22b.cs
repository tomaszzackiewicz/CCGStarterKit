using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard22b : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter22b >= 0) {
                CardCounterManager.counter22b--;
                CardCounterManager.CardCounter22b();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter22bDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter22bDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter22bDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject22b) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject22b.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel22b.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

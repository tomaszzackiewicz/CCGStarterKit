using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard42b : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter42b >= 0) {
                CardCounterManager.counter42b--;
                CardCounterManager.CardCounter42b();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter42bDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter42bDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter42bDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject42b) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject42b.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel42b.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

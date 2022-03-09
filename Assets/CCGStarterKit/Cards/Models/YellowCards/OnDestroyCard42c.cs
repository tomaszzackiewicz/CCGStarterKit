using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard42c : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter42c >= 0) {
                CardCounterManager.counter42c--;
                CardCounterManager.CardCounter42c();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter42cDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter42cDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter42cDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject42c) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject42c.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel42c.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

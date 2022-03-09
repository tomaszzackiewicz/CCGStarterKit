using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard31c : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter31c >= 0) {
                CardCounterManager.counter31c--;
                CardCounterManager.CardCounter31c();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter31cDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter31cDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter31cDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject31c) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject31c.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel31c.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

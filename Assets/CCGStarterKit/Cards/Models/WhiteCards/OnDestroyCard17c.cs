using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard17c : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter17c >= 0) {
                CardCounterManager.counter17c--;
                CardCounterManager.CardCounter17c();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter17cDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter17cDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter17cDeck3--;
                }

            }

            if (DeckManager.deckManager.instancesCounterTextObject17c) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject17c.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel17c.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

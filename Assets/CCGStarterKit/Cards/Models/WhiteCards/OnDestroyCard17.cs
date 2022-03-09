using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard17 : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter17 >= 0) {
                CardCounterManager.counter17--;
                CardCounterManager.CardCounter17();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter17Deck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter17Deck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter17Deck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject17) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject17.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel17.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

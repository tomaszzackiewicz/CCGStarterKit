using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard11 : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter11 >= 0) {
                CardCounterManager.counter11--;
                CardCounterManager.CardCounter11();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter11Deck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter11Deck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter11Deck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject11) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject11.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel11.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

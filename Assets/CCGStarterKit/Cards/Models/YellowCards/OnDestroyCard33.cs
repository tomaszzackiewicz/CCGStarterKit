using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard33 : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter33 >= 0) {
                CardCounterManager.counter33--;
                CardCounterManager.CardCounter33();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter33Deck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter33Deck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter33Deck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject33) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject33.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel33.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

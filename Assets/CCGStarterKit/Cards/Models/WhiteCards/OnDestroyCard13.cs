using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard13 : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter13 >= 0) {
                CardCounterManager.counter13--;
                CardCounterManager.CardCounter13();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter13Deck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter13Deck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter13Deck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject13) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject13.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel13.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

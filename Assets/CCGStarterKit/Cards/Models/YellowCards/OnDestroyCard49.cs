using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard49 : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter49 >= 0) {
                CardCounterManager.counter49--;
                CardCounterManager.CardCounter49();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter49Deck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter49Deck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter49Deck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject49) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject49.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel49.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

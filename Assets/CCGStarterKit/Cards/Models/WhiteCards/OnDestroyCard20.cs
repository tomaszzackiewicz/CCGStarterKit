using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard20 : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter20 >= 0) {
                CardCounterManager.counter20--;
                CardCounterManager.CardCounter20();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter20Deck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter20Deck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter20Deck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject20) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject20.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel20.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

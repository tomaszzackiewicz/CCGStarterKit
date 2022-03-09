using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard2 : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter2 >= 0) {
                CardCounterManager.counter2--;
                CardCounterManager.CardCounter2();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter2Deck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter2Deck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter2Deck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject2) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject2.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel2.transform.localScale = DeckManager.deckManager.modelCardScale;
                }
            }

        }
    }
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard50 : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter50 >= 0) {
                CardCounterManager.counter50--;
                CardCounterManager.CardCounter50();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter50Deck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter50Deck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter50Deck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject50) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject50.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel50.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

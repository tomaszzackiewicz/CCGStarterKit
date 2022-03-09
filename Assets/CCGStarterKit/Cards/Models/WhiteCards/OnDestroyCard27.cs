using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard27 : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter27 >= 0) {
                CardCounterManager.counter27--;
                CardCounterManager.CardCounter27();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter27Deck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter27Deck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter27Deck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject27) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject27.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel27.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

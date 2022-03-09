using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard39 : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter39 >= 0) {
                CardCounterManager.counter39--;
                CardCounterManager.CardCounter39();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter39Deck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter39Deck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter39Deck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject39) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject39.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel39.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

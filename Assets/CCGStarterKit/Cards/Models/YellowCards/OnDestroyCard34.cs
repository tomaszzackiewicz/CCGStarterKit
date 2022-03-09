using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard34 : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter34 >= 0) {
                CardCounterManager.counter34--;
                CardCounterManager.CardCounter34();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter34Deck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter34Deck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter34Deck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject34) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject34.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel34.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}
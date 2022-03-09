using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard6 : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter6 >= 0) {
                CardCounterManager.counter6--;
                CardCounterManager.CardCounter6();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter6Deck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter6Deck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter6Deck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject6) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject6.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel6.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}
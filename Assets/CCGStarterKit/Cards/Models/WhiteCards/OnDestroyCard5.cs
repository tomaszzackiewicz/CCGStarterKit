using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard5 : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter5 >= 0) {
                CardCounterManager.counter5--;
                CardCounterManager.CardCounter5();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter5Deck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter5Deck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter5Deck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject5) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject5.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel5.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

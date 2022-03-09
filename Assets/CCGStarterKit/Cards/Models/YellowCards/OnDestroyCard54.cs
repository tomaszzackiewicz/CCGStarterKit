using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard54 : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter54 >= 0) {
                CardCounterManager.counter54--;
                CardCounterManager.CardCounter54();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter54Deck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter54Deck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter54Deck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject54) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject54.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel54.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard37 : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter37 >= 0) {
                CardCounterManager.counter37--;
                CardCounterManager.CardCounter37();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter37Deck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter37Deck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter37Deck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject37) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject37.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel37.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

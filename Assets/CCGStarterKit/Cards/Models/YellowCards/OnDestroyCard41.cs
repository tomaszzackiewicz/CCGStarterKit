using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard41 : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter41 >= 0) {
                CardCounterManager.counter41--;
                CardCounterManager.CardCounter41();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter41Deck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter41Deck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter41Deck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject41) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject41.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel41.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard36 : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter36 >= 0) {
                CardCounterManager.counter36--;
                CardCounterManager.CardCounter36();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter36Deck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter36Deck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter36Deck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject36) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject36.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel36.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

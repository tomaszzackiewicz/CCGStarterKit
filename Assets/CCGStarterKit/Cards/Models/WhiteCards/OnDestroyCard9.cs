using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard9 : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter9 >= 0) {
                CardCounterManager.counter9--;
                CardCounterManager.CardCounter9();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter9Deck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter9Deck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter9Deck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject9) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject9.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel9.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

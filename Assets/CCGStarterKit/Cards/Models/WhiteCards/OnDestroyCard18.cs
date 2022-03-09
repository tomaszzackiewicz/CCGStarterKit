using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard18 : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter18 >= 0) {
                CardCounterManager.counter18--;
                CardCounterManager.CardCounter18();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter18Deck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter18Deck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter18Deck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject18) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject18.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel18.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

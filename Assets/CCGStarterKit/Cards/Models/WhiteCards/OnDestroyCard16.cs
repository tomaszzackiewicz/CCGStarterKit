using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard16 : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter16 >= 0) {
                CardCounterManager.counter16--;
                CardCounterManager.CardCounter16();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter16Deck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter16Deck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter16Deck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject16) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject16.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel16.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard38 : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter38 >= 0) {
                CardCounterManager.counter38--;
                CardCounterManager.CardCounter38();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter38Deck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter38Deck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter38Deck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject38) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject38.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel38.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

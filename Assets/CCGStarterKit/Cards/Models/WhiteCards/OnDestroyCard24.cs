using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard24 : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter24 >= 0) {
                CardCounterManager.counter24--;
                CardCounterManager.CardCounter24();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter24Deck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter24Deck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter24Deck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject24) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject24.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel24.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

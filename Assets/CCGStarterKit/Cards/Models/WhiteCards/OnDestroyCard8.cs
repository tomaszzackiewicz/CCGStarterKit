using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard8 : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter8 >= 0) {
                CardCounterManager.counter8--;
                CardCounterManager.CardCounter8();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter8Deck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter8Deck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter8Deck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject8) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject8.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel8.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard31 : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter31 >= 0) {
                CardCounterManager.counter31--;
                CardCounterManager.CardCounter31();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter31Deck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter31Deck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter31Deck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject31) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject31.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel31.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }

}
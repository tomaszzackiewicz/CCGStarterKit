using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard53 : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter53 >= 0) {
                CardCounterManager.counter53--;
                CardCounterManager.CardCounter53();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter53Deck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter53Deck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter53Deck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject53) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject53.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel53.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

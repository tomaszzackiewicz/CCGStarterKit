using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard25 : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter25 >= 0) {
                CardCounterManager.counter25--;
                CardCounterManager.CardCounter25();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter25Deck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter25Deck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter25Deck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject25) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject25.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel25.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

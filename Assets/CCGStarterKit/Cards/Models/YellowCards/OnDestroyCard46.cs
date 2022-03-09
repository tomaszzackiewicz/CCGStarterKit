using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard46 : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter46 >= 0) {
                CardCounterManager.counter46--;
                CardCounterManager.CardCounter46();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter46Deck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter46Deck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter46Deck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject46) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject46.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel46.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

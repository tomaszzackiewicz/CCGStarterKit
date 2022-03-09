using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard32 : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter32 >= 0) {
                CardCounterManager.counter32--;
                CardCounterManager.CardCounter32();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter32Deck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter32Deck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter32Deck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject32) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject32.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel32.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

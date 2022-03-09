using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard42 : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter42 >= 0) {
                CardCounterManager.counter42--;
                CardCounterManager.CardCounter42();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter42Deck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter42Deck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter42Deck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject42) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject42.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel42.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

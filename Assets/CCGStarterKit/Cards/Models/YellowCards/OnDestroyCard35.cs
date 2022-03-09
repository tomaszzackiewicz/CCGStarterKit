using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard35 : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter35 >= 0) {
                CardCounterManager.counter35--;
                CardCounterManager.CardCounter35();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter35Deck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter35Deck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter35Deck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject35) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject35.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel35.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

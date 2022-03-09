using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard21 : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter21 >= 0) {
                CardCounterManager.counter21--;
                CardCounterManager.CardCounter21();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter21Deck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter21Deck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter21Deck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject21) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject21.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel21.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

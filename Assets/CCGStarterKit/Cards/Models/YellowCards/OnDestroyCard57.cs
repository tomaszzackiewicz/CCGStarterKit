using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard57 : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter57 >= 0) {
                CardCounterManager.counter57--;
                CardCounterManager.CardCounter57();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter57Deck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter57Deck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter57Deck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject57) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject57.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel57.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

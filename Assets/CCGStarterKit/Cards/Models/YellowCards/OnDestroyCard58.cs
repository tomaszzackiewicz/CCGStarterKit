using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard58 : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter58 >= 0) {
                CardCounterManager.counter58--;
                CardCounterManager.CardCounter58();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter58Deck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter58Deck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter58Deck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject58) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject58.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel58.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }

}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard40 : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter40 >= 0) {
                CardCounterManager.counter40--;
                CardCounterManager.CardCounter40();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter40Deck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter40Deck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter40Deck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject40) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject40.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel40.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

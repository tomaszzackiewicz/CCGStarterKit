using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard44 : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter44 >= 0) {
                CardCounterManager.counter44--;
                CardCounterManager.CardCounter44();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter44Deck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter44Deck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter44Deck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject44) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject44.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel44.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }

}
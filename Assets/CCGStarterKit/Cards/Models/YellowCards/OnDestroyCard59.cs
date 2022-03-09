using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard59 : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter59 >= 0) {
                CardCounterManager.counter59--;
                CardCounterManager.CardCounter59();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter59Deck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter59Deck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter59Deck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject59) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject59.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel59.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }

}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard56 : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter56 >= 0) {
                CardCounterManager.counter56--;
                CardCounterManager.CardCounter56();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter56Deck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter56Deck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter56Deck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject56) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject56.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel56.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

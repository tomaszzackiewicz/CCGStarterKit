using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard56c : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter56c >= 0) {
                CardCounterManager.counter56c--;
                CardCounterManager.CardCounter56c();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter56cDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter56cDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter56cDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject56c) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject56c.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel56c.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

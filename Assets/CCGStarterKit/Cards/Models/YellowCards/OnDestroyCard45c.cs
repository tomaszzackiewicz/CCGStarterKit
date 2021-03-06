using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard45c : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter45c >= 0) {
                CardCounterManager.counter45c--;
                CardCounterManager.CardCounter45c();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter45cDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter45cDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter45cDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject45c) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject45c.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel45c.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

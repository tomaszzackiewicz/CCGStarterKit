using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard2c : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter2c >= 0) {
                CardCounterManager.counter2c--;
                CardCounterManager.CardCounter2c();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter2cDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter2cDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter2cDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject2c) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject2c.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel2c.transform.localScale = DeckManager.deckManager.modelCardScale;
                }
            }

        }
    }
}

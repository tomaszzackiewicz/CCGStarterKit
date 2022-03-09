using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard39c : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter39c >= 0) {
                CardCounterManager.counter39c--;
                CardCounterManager.CardCounter39c();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter39cDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter39cDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter39cDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject39c) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject39c.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel39c.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

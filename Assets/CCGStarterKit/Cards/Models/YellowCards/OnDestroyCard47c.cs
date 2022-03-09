using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard47c : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter47c >= 0) {
                CardCounterManager.counter47c--;
                CardCounterManager.CardCounter47c();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter47cDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter47cDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter47cDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject47c) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject47c.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel47c.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

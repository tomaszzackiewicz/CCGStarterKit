using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard39a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter39a >= 0) {
                CardCounterManager.counter39a--;
                CardCounterManager.CardCounter39a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter39aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter39aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter39aDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject39a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject39a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel39a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

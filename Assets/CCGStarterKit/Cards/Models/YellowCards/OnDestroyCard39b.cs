using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard39b : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter39b >= 0) {
                CardCounterManager.counter39b--;
                CardCounterManager.CardCounter39b();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter39bDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter39bDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter39bDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject39b) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject39b.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel39b.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

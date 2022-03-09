using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard18b : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter18b >= 0) {
                CardCounterManager.counter18b--;
                CardCounterManager.CardCounter18b();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter18bDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter18bDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter18bDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject18b) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject18b.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel18b.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

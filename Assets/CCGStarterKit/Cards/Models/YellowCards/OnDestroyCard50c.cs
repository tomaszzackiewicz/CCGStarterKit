using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard50c : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter50c >= 0) {
                CardCounterManager.counter50c--;
                CardCounterManager.CardCounter50c();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter50cDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter50cDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter50cDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject50c) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject50c.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel50c.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

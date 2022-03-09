using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard53b : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter53b >= 0) {
                CardCounterManager.counter53b--;
                CardCounterManager.CardCounter53b();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter53bDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter53bDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter53bDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject53b) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject53b.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel53b.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

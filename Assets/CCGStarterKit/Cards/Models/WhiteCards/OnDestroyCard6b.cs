using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard6b : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter6b >= 0) {
                CardCounterManager.counter6b--;
                CardCounterManager.CardCounter6b();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter6bDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter6bDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter6bDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject6b) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject6b.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel6b.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard16c : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter16c >= 0) {
                CardCounterManager.counter16c--;
                CardCounterManager.CardCounter16c();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter16cDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter16cDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter16cDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject16c) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject16c.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel16c.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

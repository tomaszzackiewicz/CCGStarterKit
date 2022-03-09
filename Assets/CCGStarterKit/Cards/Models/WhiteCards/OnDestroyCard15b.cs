using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard15b : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter15b >= 0) {
                CardCounterManager.counter15b--;
                CardCounterManager.CardCounter15b();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter15bDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter15bDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter15bDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject15b) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject15b.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel15b.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard15a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter15a >= 0) {
                CardCounterManager.counter15a--;
                CardCounterManager.CardCounter15a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter15aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter15aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter15aDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject15a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject15a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel15a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

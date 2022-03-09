using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard4a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter4a >= 0) {
                CardCounterManager.counter4a--;
                CardCounterManager.CardCounter4a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter4aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter4aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter4aDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject4a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject4a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel4a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

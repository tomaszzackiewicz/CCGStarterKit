using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard31a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter31a >= 0) {
                CardCounterManager.counter31a--;
                CardCounterManager.CardCounter31a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter31aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter31aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter31aDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject31a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject31a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel31a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}
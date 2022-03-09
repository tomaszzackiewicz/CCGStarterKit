using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard50a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter50a >= 0) {
                CardCounterManager.counter50a--;
                CardCounterManager.CardCounter50a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter50aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter50aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter50aDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject50a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject50a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel50a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

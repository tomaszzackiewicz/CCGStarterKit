using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard21a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter21a >= 0) {
                CardCounterManager.counter21a--;
                CardCounterManager.CardCounter21a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter21aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter21aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter21aDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject21a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject21a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel21a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

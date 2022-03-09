using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard37a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter37a >= 0) {
                CardCounterManager.counter37a--;
                CardCounterManager.CardCounter37a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter37aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter37aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter37aDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject37a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject37a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel37a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

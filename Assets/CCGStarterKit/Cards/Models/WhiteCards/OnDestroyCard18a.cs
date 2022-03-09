using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard18a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter18a >= 0) {
                CardCounterManager.counter18a--;
                CardCounterManager.CardCounter18a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter18aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter18aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter18aDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject18a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject18a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel18a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

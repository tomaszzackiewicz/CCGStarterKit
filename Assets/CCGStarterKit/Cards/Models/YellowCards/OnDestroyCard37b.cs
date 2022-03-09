using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard37b : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter37b >= 0) {
                CardCounterManager.counter37b--;
                CardCounterManager.CardCounter37b();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter37bDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter37bDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter37bDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject37b) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject37b.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel37b.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

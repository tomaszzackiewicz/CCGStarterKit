using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard45b : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter45b >= 0) {
                CardCounterManager.counter45b--;
                CardCounterManager.CardCounter45b();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter45bDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter45bDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter45bDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject45b) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject45b.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel45b.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard16b : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter16b >= 0) {
                CardCounterManager.counter16b--;
                CardCounterManager.CardCounter16b();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter16bDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter16bDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter16bDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject16b) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject16b.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel16b.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

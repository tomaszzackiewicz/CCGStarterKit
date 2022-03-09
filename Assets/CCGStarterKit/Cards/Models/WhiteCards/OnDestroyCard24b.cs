using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard24b : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter24b >= 0) {
                CardCounterManager.counter24b--;
                CardCounterManager.CardCounter24b();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter24bDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter24bDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter24bDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject24b) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject24b.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel24b.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard33b : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter33b >= 0) {
                CardCounterManager.counter33b--;
                CardCounterManager.CardCounter33b();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter33bDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter33bDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter33bDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject33b) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject33b.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel33b.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard44b : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter44b >= 0) {
                CardCounterManager.counter44b--;
                CardCounterManager.CardCounter44b();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter44bDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter44bDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter44bDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject44b) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject44b.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel44b.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

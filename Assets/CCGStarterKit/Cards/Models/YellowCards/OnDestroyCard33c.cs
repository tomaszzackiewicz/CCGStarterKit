using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard33c : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter33c >= 0) {
                CardCounterManager.counter33c--;
                CardCounterManager.CardCounter33c();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter33cDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter33cDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter33cDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject33c) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject33c.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel33c.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

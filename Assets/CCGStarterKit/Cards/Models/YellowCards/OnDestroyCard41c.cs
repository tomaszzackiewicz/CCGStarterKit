using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard41c : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter41c >= 0) {
                CardCounterManager.counter41c--;
                CardCounterManager.CardCounter41c();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter41cDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter41cDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter41cDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject41c) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject41c.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel41c.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

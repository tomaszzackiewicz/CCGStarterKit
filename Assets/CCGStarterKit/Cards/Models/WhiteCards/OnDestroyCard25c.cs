using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard25c : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter25c >= 0) {
                CardCounterManager.counter25c--;
                CardCounterManager.CardCounter25c();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter25cDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter25cDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter25cDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject25c) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject25c.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel25c.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard27c : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter27c >= 0) {
                CardCounterManager.counter27c--;
                CardCounterManager.CardCounter27c();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter27cDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter27cDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter27cDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject27c) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject27c.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel27c.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

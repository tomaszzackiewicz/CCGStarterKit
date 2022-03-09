using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard6c : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter6c >= 0) {
                CardCounterManager.counter6c--;
                CardCounterManager.CardCounter6c();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter6cDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter6cDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter6cDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject6c) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject6c.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel6c.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

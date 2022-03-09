using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard13c : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter13c >= 0) {
                CardCounterManager.counter13c--;
                CardCounterManager.CardCounter13c();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter13cDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter13cDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter13cDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject13c) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject13c.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel13c.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

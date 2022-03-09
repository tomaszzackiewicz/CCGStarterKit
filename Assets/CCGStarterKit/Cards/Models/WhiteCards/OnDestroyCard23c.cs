using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard23c : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter23c >= 0) {
                CardCounterManager.counter23c--;
                CardCounterManager.CardCounter23c();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter23cDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter23cDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter23cDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject23c) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject23c.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel23c.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

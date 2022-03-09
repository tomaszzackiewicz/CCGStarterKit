using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard35c : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter35c >= 0) {
                CardCounterManager.counter35c--;
                CardCounterManager.CardCounter35c();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter35cDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter35cDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter35cDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject35c) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject35c.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel35c.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}
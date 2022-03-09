using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard21c : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter21c >= 0) {
                CardCounterManager.counter21c--;
                CardCounterManager.CardCounter21c();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter21cDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter21cDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter21cDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject21c) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject21c.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel21c.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

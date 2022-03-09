using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard3c : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter3c >= 0) {
                CardCounterManager.counter3c--;
                CardCounterManager.CardCounter3c();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter3cDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter3cDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter3cDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject3c) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject3c.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel3c.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard44c : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter44c >= 0) {
                CardCounterManager.counter44c--;
                CardCounterManager.CardCounter44c();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter44cDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter44cDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter44cDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject44c) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject44c.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel44c.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

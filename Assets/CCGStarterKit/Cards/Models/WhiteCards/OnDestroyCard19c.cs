using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard19c : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter19c >= 0) {
                CardCounterManager.counter19c--;
                CardCounterManager.CardCounter19c();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter19cDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter19cDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter19cDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject19c) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject19c.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel19c.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

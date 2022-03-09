using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard19b : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter19b >= 0) {
                CardCounterManager.counter19b--;
                CardCounterManager.CardCounter19b();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter19bDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter19bDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter19bDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject19b) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject19b.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel19b.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

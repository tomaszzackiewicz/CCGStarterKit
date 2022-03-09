using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard32c : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter32c >= 0) {
                CardCounterManager.counter32c--;
                CardCounterManager.CardCounter32c();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter32cDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter32cDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter32cDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject32c) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject32c.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel32c.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

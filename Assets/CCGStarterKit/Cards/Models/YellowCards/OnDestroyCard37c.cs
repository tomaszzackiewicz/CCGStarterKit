using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard37c : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter37c >= 0) {
                CardCounterManager.counter37c--;
                CardCounterManager.CardCounter37c();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter37cDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter37cDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter37cDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject37c) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject37c.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel37c.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

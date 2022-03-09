using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard46b : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter46b >= 0) {
                CardCounterManager.counter46b--;
                CardCounterManager.CardCounter46b();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter46bDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter46bDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter46bDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject46b) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject46b.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel46b.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

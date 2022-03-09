using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard26b : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter26b >= 0) {
                CardCounterManager.counter26b--;
                CardCounterManager.CardCounter26b();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter26bDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter26bDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter26bDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject26b) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject26b.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel26b.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

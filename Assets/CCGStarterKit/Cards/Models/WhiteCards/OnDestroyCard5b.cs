using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard5b : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter5b >= 0) {
                CardCounterManager.counter5b--;
                CardCounterManager.CardCounter5b();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter5bDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter5bDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter5bDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject5b) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject5b.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel5b.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

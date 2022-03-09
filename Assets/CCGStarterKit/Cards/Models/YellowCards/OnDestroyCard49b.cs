using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard49b : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter49b >= 0) {
                CardCounterManager.counter49b--;
                CardCounterManager.CardCounter49b();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter49bDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter49bDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter49bDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject49b) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject49b.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel49b.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

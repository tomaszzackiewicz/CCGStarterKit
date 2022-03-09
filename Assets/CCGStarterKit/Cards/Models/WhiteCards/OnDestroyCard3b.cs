using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard3b : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter3b >= 0) {
                CardCounterManager.counter3b--;
                CardCounterManager.CardCounter3b();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter3bDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter3bDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter3bDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject3b) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject3b.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel3b.transform.localScale = DeckManager.deckManager.modelCardScale;
                }
            }

        }
    }
}

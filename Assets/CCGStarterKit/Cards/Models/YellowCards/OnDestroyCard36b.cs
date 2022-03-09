using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard36b : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter36b >= 0) {
                CardCounterManager.counter36b--;
                CardCounterManager.CardCounter36b();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter36bDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter36bDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter36bDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject36b) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject36b.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel36b.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}
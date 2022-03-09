using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard9b : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter9b >= 0) {
                CardCounterManager.counter9b--;
                CardCounterManager.CardCounter9b();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter9bDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter9bDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter9bDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject9b) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject9b.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel9b.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard54b : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter54b >= 0) {
                CardCounterManager.counter54b--;
                CardCounterManager.CardCounter54b();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter54bDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter54bDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter54bDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject54b) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject54b.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel54b.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

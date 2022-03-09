using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard40b : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter40b >= 0) {
                CardCounterManager.counter40b--;
                CardCounterManager.CardCounter40b();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter40bDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter40bDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter40bDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject40b) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject40b.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel40b.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

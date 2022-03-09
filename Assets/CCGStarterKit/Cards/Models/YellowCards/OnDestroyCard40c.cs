using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard40c : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter40c >= 0) {
                CardCounterManager.counter40c--;
                CardCounterManager.CardCounter40c();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter40cDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter40cDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter40cDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject40c) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject40c.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel40c.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

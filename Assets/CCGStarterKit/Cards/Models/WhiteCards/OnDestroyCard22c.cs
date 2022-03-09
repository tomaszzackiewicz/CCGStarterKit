using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard22c : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter22c >= 0) {
                CardCounterManager.counter22c--;
                CardCounterManager.CardCounter22c();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter22cDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter22cDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter22cDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject22c) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject22c.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel22c.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

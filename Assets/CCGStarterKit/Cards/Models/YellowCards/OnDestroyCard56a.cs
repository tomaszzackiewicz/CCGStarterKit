using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard56a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter56a >= 0) {
                CardCounterManager.counter56a--;
                CardCounterManager.CardCounter56a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter56aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter56aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter56aDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject56a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject56a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel56a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

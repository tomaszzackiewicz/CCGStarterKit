using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard36c : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter36c >= 0) {
                CardCounterManager.counter36c--;
                CardCounterManager.CardCounter36c();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter36cDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter36cDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter36cDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject36c) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject36c.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel36c.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

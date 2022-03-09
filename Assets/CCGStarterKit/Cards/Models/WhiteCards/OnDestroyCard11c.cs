using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard11c : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter11c >= 0) {
                CardCounterManager.counter11c--;
                CardCounterManager.CardCounter11c();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter11cDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter11cDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter11cDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject11b) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject11c.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel11c.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

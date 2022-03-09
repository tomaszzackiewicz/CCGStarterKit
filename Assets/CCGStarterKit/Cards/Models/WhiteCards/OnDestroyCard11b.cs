using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard11b : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter11b >= 0) {
                CardCounterManager.counter11b--;
                CardCounterManager.CardCounter11b();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter11bDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter11bDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter11bDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject11b) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject11b.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel11b.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }

}

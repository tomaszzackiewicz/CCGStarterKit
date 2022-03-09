using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard59b : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter59b >= 0) {
                CardCounterManager.counter59b--;
                CardCounterManager.CardCounter59b();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter59bDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter59bDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter59bDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject59b) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject59b.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel59b.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }

}

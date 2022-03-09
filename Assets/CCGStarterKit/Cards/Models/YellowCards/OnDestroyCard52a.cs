using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard52a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter52a >= 0) {
                CardCounterManager.counter52a--;
                CardCounterManager.CardCounter52a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter52aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter52aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter52aDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject52a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject52a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel52a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

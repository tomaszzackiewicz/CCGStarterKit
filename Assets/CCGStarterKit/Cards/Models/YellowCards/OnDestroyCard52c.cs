using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard52c : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter52c >= 0) {
                CardCounterManager.counter52c--;
                CardCounterManager.CardCounter52c();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter52cDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter52cDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter52cDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject52c) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject52c.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel52c.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

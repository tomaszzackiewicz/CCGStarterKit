using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard52b : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter52b >= 0) {
                CardCounterManager.counter52b--;
                CardCounterManager.CardCounter52b();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter52bDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter52bDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter52bDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject52b) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject52b.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel52b.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }

}

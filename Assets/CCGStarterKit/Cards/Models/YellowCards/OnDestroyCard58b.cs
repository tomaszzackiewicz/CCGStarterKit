using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard58b : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter58b >= 0) {
                CardCounterManager.counter58b--;
                CardCounterManager.CardCounter58b();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter58bDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter58bDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter58bDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject58b) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject58b.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel58b.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }

}

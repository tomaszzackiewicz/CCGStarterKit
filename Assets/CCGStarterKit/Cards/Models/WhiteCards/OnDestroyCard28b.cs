using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard28b : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter28b >= 0) {
                CardCounterManager.counter28b--;
                CardCounterManager.CardCounter28b();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter28bDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter28bDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter28bDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject28b) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject28b.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel28b.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

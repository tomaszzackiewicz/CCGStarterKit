using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard55c : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter55c >= 0) {
                CardCounterManager.counter55c--;
                CardCounterManager.CardCounter55c();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter55cDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter55cDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter55cDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject55c) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject55c.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel55c.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

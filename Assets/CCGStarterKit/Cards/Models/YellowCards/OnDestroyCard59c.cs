using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard59c : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter59c >= 0) {
                CardCounterManager.counter59c--;
                CardCounterManager.CardCounter59c();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter59cDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter59cDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter59cDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject59c) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject59c.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel59c.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }

}

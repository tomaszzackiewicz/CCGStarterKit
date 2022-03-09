using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard9c : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter9c >= 0) {
                CardCounterManager.counter9c--;
                CardCounterManager.CardCounter9c();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter9cDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter9cDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter9cDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject9c) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject9c.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel9c.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }

}

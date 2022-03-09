using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard33a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter33a >= 0) {
                CardCounterManager.counter33a--;
                CardCounterManager.CardCounter33a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter33aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter33aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter33aDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject33a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject33a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel33a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}
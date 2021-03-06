using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard49c : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter49c >= 0) {
                CardCounterManager.counter49c--;
                CardCounterManager.CardCounter49c();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter49cDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter49cDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter49cDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject49c) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject49c.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel49c.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

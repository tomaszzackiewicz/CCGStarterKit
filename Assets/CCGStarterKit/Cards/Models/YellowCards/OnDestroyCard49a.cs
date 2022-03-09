using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard49a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter49a >= 0) {
                CardCounterManager.counter49a--;
                CardCounterManager.CardCounter49a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter49aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter49aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter49aDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject49a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject49a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel49a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}
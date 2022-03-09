using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard26a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter26a >= 0) {
                CardCounterManager.counter26a--;
                CardCounterManager.CardCounter26a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter26aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter26aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter26aDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject26a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject26a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel26a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

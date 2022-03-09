using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard26c : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter26c >= 0) {
                CardCounterManager.counter26c--;
                CardCounterManager.CardCounter26c();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter26cDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter26cDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter26cDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject26c) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject26c.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel26c.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

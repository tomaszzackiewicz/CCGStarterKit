using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard26 : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter26 >= 0) {
                CardCounterManager.counter26--;
                CardCounterManager.CardCounter26();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter26Deck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter26Deck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter26Deck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject26) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject26.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel26.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

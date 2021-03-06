using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard55 : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter55 >= 0) {
                CardCounterManager.counter55--;
                CardCounterManager.CardCounter55();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter55Deck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter55Deck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter55Deck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject55) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject55.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel55.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

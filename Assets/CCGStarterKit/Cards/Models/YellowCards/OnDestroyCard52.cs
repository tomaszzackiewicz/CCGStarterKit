using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard52 : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter52 >= 0) {
                CardCounterManager.counter52--;
                CardCounterManager.CardCounter52();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter52Deck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter52Deck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter52Deck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject52) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject52.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel52.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

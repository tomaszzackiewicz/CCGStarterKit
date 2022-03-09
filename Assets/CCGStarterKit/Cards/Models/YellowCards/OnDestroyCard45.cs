using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard45 : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter45 >= 0) {
                CardCounterManager.counter45--;
                CardCounterManager.CardCounter45();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter45Deck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter45Deck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter45Deck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject45) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject45.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel45.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

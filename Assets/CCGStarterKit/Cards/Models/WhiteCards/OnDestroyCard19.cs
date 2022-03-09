using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard19 : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter19 >= 0) {
                CardCounterManager.counter19--;
                CardCounterManager.CardCounter19();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter19Deck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter19Deck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter19Deck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject19) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject19.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel19.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

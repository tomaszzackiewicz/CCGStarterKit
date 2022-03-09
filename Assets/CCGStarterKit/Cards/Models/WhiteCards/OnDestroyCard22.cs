using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard22 : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter22 >= 0) {
                CardCounterManager.counter22--;
                CardCounterManager.CardCounter22();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter22Deck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter22Deck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter22Deck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject22) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject22.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel22.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }

}

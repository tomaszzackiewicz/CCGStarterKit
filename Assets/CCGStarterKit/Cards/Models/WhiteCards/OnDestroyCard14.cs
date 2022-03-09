using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard14 : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter14 >= 0) {
                CardCounterManager.counter14--;
                CardCounterManager.CardCounter14();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter14Deck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter14Deck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter14Deck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject14) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject14.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel14.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

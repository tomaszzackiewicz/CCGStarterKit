using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard30 : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter30 >= 0) {
                CardCounterManager.counter30--;
                CardCounterManager.CardCounter30();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter30Deck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter30Deck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter30Deck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject30) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject30.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel30.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

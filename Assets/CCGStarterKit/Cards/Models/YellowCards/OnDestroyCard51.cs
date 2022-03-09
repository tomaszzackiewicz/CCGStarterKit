using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard51 : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter51 >= 0) {
                CardCounterManager.counter51--;
                CardCounterManager.CardCounter51();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter51Deck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter51Deck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter51Deck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject51) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject51.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel51.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

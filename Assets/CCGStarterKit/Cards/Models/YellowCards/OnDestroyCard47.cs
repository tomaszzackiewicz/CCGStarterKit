using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard47 : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter47 >= 0) {
                CardCounterManager.counter47--;
                CardCounterManager.CardCounter47();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter47Deck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter47Deck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter47Deck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject47) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject47.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel47.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

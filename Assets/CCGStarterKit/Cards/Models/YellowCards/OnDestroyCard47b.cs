using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard47b : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter47b >= 0) {
                CardCounterManager.counter47b--;
                CardCounterManager.CardCounter47b();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter47bDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter47bDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter47bDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject47b) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject47b.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel47b.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

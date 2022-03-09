using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard47a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter47a >= 0) {
                CardCounterManager.counter47a--;
                CardCounterManager.CardCounter47a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter47aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter47aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter47aDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject47a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject4a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel47a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

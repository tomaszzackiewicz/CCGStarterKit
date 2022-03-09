using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard19a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter19a >= 0) {
                CardCounterManager.counter19a--;
                CardCounterManager.CardCounter19a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter19aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter19aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter19aDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject19a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject19a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel19a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

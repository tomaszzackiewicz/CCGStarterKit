using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard35a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter35a >= 0) {
                CardCounterManager.counter35a--;
                CardCounterManager.CardCounter35a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter35aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter35aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter35aDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject35a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject35a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel35a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

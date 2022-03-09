using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard27a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter27a >= 0) {
                CardCounterManager.counter27a--;
                CardCounterManager.CardCounter27a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter27aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter27aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter27aDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject27a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject27a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel27a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard6a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter6a >= 0) {
                CardCounterManager.counter6a--;
                CardCounterManager.CardCounter6a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter6aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter6aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter6aDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject6a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject6a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel6a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

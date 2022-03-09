using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard44a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter44a >= 0) {
                CardCounterManager.counter44a--;
                CardCounterManager.CardCounter44a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter44aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter44aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter44aDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject44a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject44a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel44a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

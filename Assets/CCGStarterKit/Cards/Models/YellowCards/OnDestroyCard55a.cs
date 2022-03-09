using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard55a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter55a >= 0) {
                CardCounterManager.counter55a--;
                CardCounterManager.CardCounter55a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter55aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter55aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter55aDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject55a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject55a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel55a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

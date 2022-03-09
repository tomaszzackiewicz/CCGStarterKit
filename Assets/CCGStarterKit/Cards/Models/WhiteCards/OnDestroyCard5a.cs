using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard5a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter5a >= 0) {
                CardCounterManager.counter5a--;
                CardCounterManager.CardCounter5a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter5aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter5aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter5aDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject5a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject5a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel5a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

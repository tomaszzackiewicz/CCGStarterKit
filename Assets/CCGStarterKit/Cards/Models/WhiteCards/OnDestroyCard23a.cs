using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard23a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter23a >= 0) {
                CardCounterManager.counter23a--;
                CardCounterManager.CardCounter23a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter23aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter23aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter23aDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject23a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject23a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel23a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

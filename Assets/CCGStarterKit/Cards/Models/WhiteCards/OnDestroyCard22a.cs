using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard22a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter22a >= 0) {
                CardCounterManager.counter22a--;
                CardCounterManager.CardCounter22a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter22aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter22aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter22aDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject22a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject22a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel22a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

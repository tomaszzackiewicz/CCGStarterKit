using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard17a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter17a >= 0) {
                CardCounterManager.counter17a--;
                CardCounterManager.CardCounter17a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter17aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter17aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter17aDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject17a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject17a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel17a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

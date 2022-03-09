using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard17b : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter17b >= 0) {
                CardCounterManager.counter17b--;
                CardCounterManager.CardCounter17b();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter17bDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter17bDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter17bDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject17b) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject17b.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel17b.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

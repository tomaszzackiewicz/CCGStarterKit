using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard12b : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter12b >= 0) {
                CardCounterManager.counter12b--;
                CardCounterManager.CardCounter12b();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter12bDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter12bDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter12bDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject12b) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject12b.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel12b.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

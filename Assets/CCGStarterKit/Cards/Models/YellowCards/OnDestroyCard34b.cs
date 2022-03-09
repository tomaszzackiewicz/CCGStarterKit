using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard34b : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter34b >= 0) {
                CardCounterManager.counter34b--;
                CardCounterManager.CardCounter34b();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter34bDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter34bDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter34bDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject34b) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject34b.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel34b.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

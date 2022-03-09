using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard34c : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter34c >= 0) {
                CardCounterManager.counter34c--;
                CardCounterManager.CardCounter34c();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter34cDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter34cDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter34cDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject34c) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject34c.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel34c.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard13a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter13a >= 0) {
                CardCounterManager.counter13a--;
                CardCounterManager.CardCounter13a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter13aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter13aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter13aDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject13a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject13a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel13a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

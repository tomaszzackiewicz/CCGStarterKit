using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard34a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter34a >= 0) {
                CardCounterManager.counter34a--;
                CardCounterManager.CardCounter34a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter34aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter34aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter34aDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject34a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject34a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel34a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}
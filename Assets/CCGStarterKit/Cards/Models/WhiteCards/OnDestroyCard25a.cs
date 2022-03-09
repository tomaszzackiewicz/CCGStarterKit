using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard25a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter25a >= 0) {
                CardCounterManager.counter25a--;
                CardCounterManager.CardCounter25a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter25aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter25aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter25aDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject25a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject25a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel25a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

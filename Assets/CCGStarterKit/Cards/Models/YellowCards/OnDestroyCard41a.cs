using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard41a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter41a >= 0) {
                CardCounterManager.counter41a--;
                CardCounterManager.CardCounter41a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter41aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter41aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter41aDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject41a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject41a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel41a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

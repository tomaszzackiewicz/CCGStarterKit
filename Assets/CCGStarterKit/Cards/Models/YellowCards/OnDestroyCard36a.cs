using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard36a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter36a >= 0) {
                CardCounterManager.counter36a--;
                CardCounterManager.CardCounter36a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter36aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter36aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter36aDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject36a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject36a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel36a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

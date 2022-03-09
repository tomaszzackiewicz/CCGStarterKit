using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard2a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {


        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter2a >= 0) {
                CardCounterManager.counter2a--;
                CardCounterManager.CardCounter2a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter2aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter2aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter2aDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject2a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject2a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel2a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }
            }

        }
    }
}

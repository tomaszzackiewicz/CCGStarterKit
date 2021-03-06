using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard1b : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {


        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter1b >= 0) {
                CardCounterManager.counter1b--;
                CardCounterManager.CardCounter1b();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter1bDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter1bDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter1bDeck3--;
                }

            }


            if (DeckManager.deckManager.instancesCounterTextObject1b) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject1b.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel1b.transform.localScale = DeckManager.deckManager.modelCardScale;
                }
            }


        }
    }
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard1 : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {


        }

        void OnDestroy() {

            if (gameObject) {

                CardCounterManager.counter1--;
                CardCounterManager.CardCounter1();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter1Deck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter1Deck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter1Deck3--;
                }

            }

            if (DeckManager.deckManager.instancesCounterTextObject1) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject1.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel1.transform.localScale = DeckManager.deckManager.modelCardScale;
                }
            }



        }
    }

}

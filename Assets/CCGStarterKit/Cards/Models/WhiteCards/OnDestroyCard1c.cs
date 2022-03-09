using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard1c : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {


        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter1c >= 0) {
                CardCounterManager.counter1c--;
                CardCounterManager.CardCounter1c();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter1cDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter1cDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter1cDeck3--;
                }

            }

            if (DeckManager.deckManager.instancesCounterTextObject1c) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject1c.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel1c.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

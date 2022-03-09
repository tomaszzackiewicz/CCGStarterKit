using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard1a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {


        }

        void OnDestroy() {
            if (gameObject && CardCounterManager.counter1a >= 0) {
                CardCounterManager.counter1a--;
                CardCounterManager.CardCounter1a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter1aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter1aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter1aDeck3--;
                }

            }

            if (DeckManager.deckManager.instancesCounterTextObject1a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject1a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel1a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }
            }

        }
    }
}

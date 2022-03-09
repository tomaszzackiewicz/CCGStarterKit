using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard45a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter45a >= 0) {
                CardCounterManager.counter45a--;
                CardCounterManager.CardCounter45a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter45aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter45aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter45aDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject45a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject45a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel45a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }

}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard58a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter58a >= 0) {
                CardCounterManager.counter58a--;
                CardCounterManager.CardCounter58a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter58aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter58aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter58aDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject58a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject58a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel58a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }

}

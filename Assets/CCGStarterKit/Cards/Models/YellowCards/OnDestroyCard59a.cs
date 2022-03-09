using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard59a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter59a >= 0) {
                CardCounterManager.counter59a--;
                CardCounterManager.CardCounter59a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter59aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter59aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter59aDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject59a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject59a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel59a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}
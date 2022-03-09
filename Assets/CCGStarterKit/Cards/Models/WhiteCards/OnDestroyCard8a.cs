using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard8a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter8a >= 0) {
                CardCounterManager.counter8a--;
                CardCounterManager.CardCounter8a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter8aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter8aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter8aDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject8a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject8a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel8a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

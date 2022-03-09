using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard46a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter46a >= 0) {
                CardCounterManager.counter46a--;
                CardCounterManager.CardCounter46a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter46aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter46aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter46aDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject46a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject46a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel46a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }

}

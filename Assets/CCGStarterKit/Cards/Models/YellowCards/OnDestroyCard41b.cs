using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard41b : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter41b >= 0) {
                CardCounterManager.counter41b--;
                CardCounterManager.CardCounter41b();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter41bDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter41bDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter41bDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject41b) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject41b.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel41b.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

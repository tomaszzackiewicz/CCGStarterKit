using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard60b : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter60b >= 0) {
                CardCounterManager.counter60b--;
                CardCounterManager.CardCounter60b();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter60bDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter60bDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter60bDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject60b) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject60b.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel60b.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }

}

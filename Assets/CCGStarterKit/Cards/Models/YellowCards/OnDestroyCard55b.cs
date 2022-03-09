using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard55b : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter55b >= 0) {
                CardCounterManager.counter55b--;
                CardCounterManager.CardCounter55b();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter55bDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter55bDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter55bDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject55b) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject55b.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel55b.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

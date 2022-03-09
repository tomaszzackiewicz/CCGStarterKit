using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard23b : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter23b >= 0) {
                CardCounterManager.counter23b--;
                CardCounterManager.CardCounter23b();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter23bDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter23bDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter23bDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject23b) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject23b.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel23b.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

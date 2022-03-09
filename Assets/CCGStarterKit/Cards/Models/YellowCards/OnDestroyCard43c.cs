using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard43c : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter43c >= 0) {
                CardCounterManager.counter43c--;
                CardCounterManager.CardCounter43c();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter43cDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter43cDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter43cDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject43c) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject43c.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel43c.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

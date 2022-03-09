using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard57c : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter57c >= 0) {
                CardCounterManager.counter57c--;
                CardCounterManager.CardCounter57c();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter57cDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter57cDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter57cDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject57c) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject57c.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel57c.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }

}

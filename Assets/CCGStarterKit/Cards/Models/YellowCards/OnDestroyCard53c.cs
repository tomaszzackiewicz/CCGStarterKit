using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard53c : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter53c >= 0) {
                CardCounterManager.counter53c--;
                CardCounterManager.CardCounter53c();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter53cDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter53cDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter53cDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject53c) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject53c.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel53c.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

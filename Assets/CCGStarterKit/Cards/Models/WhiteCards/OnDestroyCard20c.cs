using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard20c : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter20c >= 0) {
                CardCounterManager.counter20c--;
                CardCounterManager.CardCounter20c();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter20cDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter20cDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter20cDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject20c) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject20c.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel20c.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

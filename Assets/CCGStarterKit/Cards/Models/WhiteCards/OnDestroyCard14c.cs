using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard14c : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter14c >= 0) {
                CardCounterManager.counter14c--;
                CardCounterManager.CardCounter14c();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter14cDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter14cDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter14cDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject14c) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject14c.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel14c.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

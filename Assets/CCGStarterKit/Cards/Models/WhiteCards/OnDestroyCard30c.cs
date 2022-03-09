using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard30c : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter30c >= 0) {
                CardCounterManager.counter30c--;
                CardCounterManager.CardCounter30c();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter30cDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter30cDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter30cDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject30c) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject30c.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel30c.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

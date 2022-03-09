using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard30b : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter30b >= 0) {
                CardCounterManager.counter30b--;
                CardCounterManager.CardCounter30b();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter30bDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter30bDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter30bDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject30b) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject30b.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel30b.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard16a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter16a >= 0) {
                CardCounterManager.counter16a--;
                CardCounterManager.CardCounter16a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter16aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter16aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter16aDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject16a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject16a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel16a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

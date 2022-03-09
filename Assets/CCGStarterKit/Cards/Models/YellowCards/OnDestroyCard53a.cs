using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard53a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter53a >= 0) {
                CardCounterManager.counter53a--;
                CardCounterManager.CardCounter53a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter53aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter53aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter53aDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject53a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject53a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel53a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

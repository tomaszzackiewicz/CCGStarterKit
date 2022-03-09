using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard11a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter11a >= 0) {
                CardCounterManager.counter11a--;
                CardCounterManager.CardCounter11a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter11aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter11aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter11aDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject11a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject11a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel11a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

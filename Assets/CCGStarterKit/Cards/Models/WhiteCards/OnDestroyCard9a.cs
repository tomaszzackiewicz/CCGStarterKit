using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard9a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter9a >= 0) {
                CardCounterManager.counter9a--;
                CardCounterManager.CardCounter9a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter9aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter9aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter9aDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject9a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject9a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel9a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

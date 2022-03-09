using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard43a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter43a >= 0) {
                CardCounterManager.counter43a--;
                CardCounterManager.CardCounter43a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter43aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter43aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter43aDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject43a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject43a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel43a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

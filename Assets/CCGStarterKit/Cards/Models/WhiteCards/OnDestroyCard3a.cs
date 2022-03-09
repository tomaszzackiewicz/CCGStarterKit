using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard3a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter3a >= 0) {
                CardCounterManager.counter3a--;
                CardCounterManager.CardCounter3a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter3aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter3aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter3aDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject3a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject3a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel3a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }
            }

        }
    }
}

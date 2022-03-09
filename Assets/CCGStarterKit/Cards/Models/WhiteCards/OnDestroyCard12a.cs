using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard12a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter12a >= 0) {
                CardCounterManager.counter12a--;
                CardCounterManager.CardCounter12a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter12aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter12aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter12aDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject12a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject12a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel12a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

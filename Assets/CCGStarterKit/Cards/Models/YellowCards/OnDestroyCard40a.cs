using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard40a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter40a >= 0) {
                CardCounterManager.counter40a--;
                CardCounterManager.CardCounter40a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter40aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter40aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter40aDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject40a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject40a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel40a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

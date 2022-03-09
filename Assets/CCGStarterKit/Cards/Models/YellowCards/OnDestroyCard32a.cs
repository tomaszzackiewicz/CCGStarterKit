using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard32a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter32a >= 0) {
                CardCounterManager.counter32a--;
                CardCounterManager.CardCounter32a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter32aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter32aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter32aDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject32a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject32a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel32a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }

}
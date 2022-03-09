using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard60a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter60a >= 0) {
                CardCounterManager.counter60a--;
                CardCounterManager.CardCounter60a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter60aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter60aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter60aDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject60a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject60a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel60a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }

}

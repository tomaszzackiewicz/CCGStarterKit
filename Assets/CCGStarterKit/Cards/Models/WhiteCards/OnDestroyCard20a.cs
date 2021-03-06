using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard20a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter20a >= 0) {
                CardCounterManager.counter20a--;
                CardCounterManager.CardCounter20a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter20aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter20aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter20aDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject20a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject20a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel20a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

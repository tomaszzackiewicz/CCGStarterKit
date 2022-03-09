using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard57a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter57a >= 0) {
                CardCounterManager.counter57a--;
                CardCounterManager.CardCounter57a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter57aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter57aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter57aDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject57a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject57a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel57a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

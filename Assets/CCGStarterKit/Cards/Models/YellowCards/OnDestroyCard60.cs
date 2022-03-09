using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard60 : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter60 >= 0) {
                CardCounterManager.counter60--;
                CardCounterManager.CardCounter60();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter60Deck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter60Deck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter60Deck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject60) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject60.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel60.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }

}

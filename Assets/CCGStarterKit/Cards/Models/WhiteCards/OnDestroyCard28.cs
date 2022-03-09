using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard28 : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter28 >= 0) {
                CardCounterManager.counter28--;
                CardCounterManager.CardCounter28();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter28Deck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter28Deck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter28Deck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject28) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject28.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel28.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}
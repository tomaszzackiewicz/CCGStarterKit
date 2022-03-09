using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard28c : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter28c >= 0) {
                CardCounterManager.counter28c--;
                CardCounterManager.CardCounter28c();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter28cDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter28cDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter28cDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject28c) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject28c.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel28c.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

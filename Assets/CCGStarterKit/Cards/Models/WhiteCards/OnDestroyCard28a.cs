using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard28a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter28a >= 0) {
                CardCounterManager.counter28a--;
                CardCounterManager.CardCounter28a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter28aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter28aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter28aDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject28a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject28a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel28a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

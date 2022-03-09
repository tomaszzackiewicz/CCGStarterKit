using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard60c : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter60c >= 0) {
                CardCounterManager.counter60c--;
                CardCounterManager.CardCounter60c();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter60cDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter60cDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter60cDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject60c) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject60c.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel60c.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }

}

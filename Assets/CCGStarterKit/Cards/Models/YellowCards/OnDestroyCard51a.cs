using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard51a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter51a >= 0) {
                CardCounterManager.counter51a--;
                CardCounterManager.CardCounter51a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter51aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter51aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter51aDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject51a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject51a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel51a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}
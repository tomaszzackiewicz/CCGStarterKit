using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard51c : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter51c >= 0) {
                CardCounterManager.counter51c--;
                CardCounterManager.CardCounter51c();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter51cDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter51cDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter51cDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject51c) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject51c.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel51c.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

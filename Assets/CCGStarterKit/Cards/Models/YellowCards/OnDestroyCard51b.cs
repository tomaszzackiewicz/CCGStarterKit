using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard51b : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter51b >= 0) {
                CardCounterManager.counter51b--;
                CardCounterManager.CardCounter51b();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter51bDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter51bDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter51bDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject51b) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject51b.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel51b.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

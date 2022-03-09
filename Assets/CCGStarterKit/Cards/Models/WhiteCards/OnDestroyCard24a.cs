using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard24a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter24a >= 0) {
                CardCounterManager.counter24a--;
                CardCounterManager.CardCounter24a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter24aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter24aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter24aDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject24a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject24a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel24a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

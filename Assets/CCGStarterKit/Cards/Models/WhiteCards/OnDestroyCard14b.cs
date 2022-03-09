using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
namespace Caerwent {

    public class OnDestroyCard14b : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter14b >= 0) {
                CardCounterManager.counter14b--;
                CardCounterManager.CardCounter14b();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter14bDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter14bDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter14bDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject14b) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject14b.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel14b.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

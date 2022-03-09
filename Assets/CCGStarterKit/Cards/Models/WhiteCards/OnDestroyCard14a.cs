using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
namespace Caerwent {

    public class OnDestroyCard14a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter14a >= 0) {
                CardCounterManager.counter14a--;
                CardCounterManager.CardCounter14a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter14aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter14aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter14aDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject14a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject14a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel14a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

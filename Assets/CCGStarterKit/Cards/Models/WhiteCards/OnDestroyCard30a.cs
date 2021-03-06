using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard30a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter30a >= 0) {
                CardCounterManager.counter30a--;
                CardCounterManager.CardCounter30a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter30aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter30aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter30aDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject30a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject30a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel30a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

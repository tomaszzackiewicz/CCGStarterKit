﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard25b : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter25b >= 0) {
                CardCounterManager.counter25b--;
                CardCounterManager.CardCounter25b();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter25bDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter25bDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter25bDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject25b) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject25b.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel25b.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard20b : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter20b >= 0) {
                CardCounterManager.counter20b--;
                CardCounterManager.CardCounter20b();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter20bDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter20bDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter20bDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject20b) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject20b.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel20b.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

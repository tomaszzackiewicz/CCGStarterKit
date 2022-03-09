﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard48a : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter48a >= 0) {
                CardCounterManager.counter48a--;
                CardCounterManager.CardCounter48a();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter48aDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter48aDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter48aDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject48a) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject48a.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel48a.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}
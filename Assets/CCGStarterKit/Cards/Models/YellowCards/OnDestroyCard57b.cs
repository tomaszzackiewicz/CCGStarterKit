﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

    public class OnDestroyCard57b : MonoBehaviour {



        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        void OnDestroy() {

            if (gameObject && CardCounterManager.counter57b >= 0) {
                CardCounterManager.counter57b--;
                CardCounterManager.CardCounter57b();

                if (DeckManager.deckManager.switcher1) {
                    DeckManager.instancesCounter57bDeck1--;
                } else if (DeckManager.deckManager.switcher2) {
                    DeckManager.instancesCounter57bDeck2--;
                } else if (DeckManager.deckManager.switcher3) {
                    DeckManager.instancesCounter57bDeck3--;
                }
            }

            if (DeckManager.deckManager.instancesCounterTextObject57b) {
                if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject57b.GetComponent<Text>().text) > 0) {
                    SaveCardDeck1.saveCardDeck1.cardModel57b.transform.localScale = DeckManager.deckManager.modelCardScale;
                }

            }
        }
    }
}

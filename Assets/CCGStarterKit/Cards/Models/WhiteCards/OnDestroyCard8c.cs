using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Caerwent {

	public class OnDestroyCard8c : MonoBehaviour {



		// Use this for initialization
		void Start() {

		}

		// Update is called once per frame
		void Update() {

		}

		void OnDestroy() {

			if (gameObject && CardCounterManager.counter8c >= 0) {
				CardCounterManager.counter8c--;
				CardCounterManager.CardCounter8c();

				if (DeckManager.deckManager.switcher1) {
					DeckManager.instancesCounter8cDeck1--;
				} else if (DeckManager.deckManager.switcher2) {
					DeckManager.instancesCounter8cDeck2--;
				} else if (DeckManager.deckManager.switcher3) {
					DeckManager.instancesCounter8cDeck3--;
				}
			}

			if (DeckManager.deckManager.instancesCounterTextObject8c) {
				if (Convert.ToInt32(DeckManager.deckManager.instancesCounterTextObject8c.GetComponent<Text>().text) > 0) {
					SaveCardDeck1.saveCardDeck1.cardModel8c.transform.localScale = DeckManager.deckManager.modelCardScale;
				}

			}
		}
	}
}

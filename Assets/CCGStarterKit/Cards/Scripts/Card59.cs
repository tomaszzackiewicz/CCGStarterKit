using UnityEngine;
using System.Collections;

namespace Caerwent {

    public class Card59 : CardParent {

        public int cardPower;

        private GameObject battlefield;
        private GameObject destroySlot;
        private GameObject destroyOpponentSlot;
        private bool isColliding;

        private GameObject handCardCollection;
        private MulliganCards mulliganCards;


        void Awake() {

            battlefield = GameObject.Find("Battlefield");


        }

        // Use this for initialization
        protected override void Start() {

            isColliding = false;

            attackValue = 20;
            battlefieldRowPosition = 1;
            generalCardAbility = 1;


            cardPower = attackValue + battlefieldRowPosition + generalCardAbility;

        }

        // Update is called once per frame
        void Update() {

        }

        void OnTriggerEnter(Collider col) {

            if (col.gameObject.name.Contains("Parent")) {

                if (isColliding) {

                    return;
                }

                isColliding = true;
                if (gameObject.name.Contains("HandCard") || gameObject.name.Contains("RandomCard")) {

                    battlefield.GetComponent<ScoreSystem>().player1Int++;
                    gameObject.transform.parent = col.gameObject.transform;

                    destroySlot = col.transform.GetChild(0).gameObject;

                    if (col.gameObject.name.Contains("Player1Row1")) {

                        battlefield.GetComponent<ScoreSystem>().attackValueRow1 += attackValue;
                    }

                    if (col.gameObject.name.Contains("Player1Row2")) {

                        battlefield.GetComponent<ScoreSystem>().attackValueRow2 += attackValue;
                    }

                    if (col.gameObject.name.Contains("Player1Row3")) {

                        battlefield.GetComponent<ScoreSystem>().attackValueRow3 += attackValue;
                    }

                    battlefield.GetComponent<ScoreSystem>().attackValue += attackValue;

                    StartCoroutine("RemovePlayer1Slot");
                }
                if (gameObject.name.Contains("AICard") || gameObject.name.Contains("OpponentCard")) {

                    battlefield.GetComponent<ScoreSystem>().aiInt++;
                    gameObject.transform.parent = col.gameObject.transform;

                    destroyOpponentSlot = col.transform.GetChild(0).gameObject;

                    if (col.gameObject.name.Contains("AIRow1")) {

                        battlefield.GetComponent<ScoreSystem>().AIattackValueRow1 += attackValue;
                    }

                    if (col.gameObject.name.Contains("AIRow2")) {

                        battlefield.GetComponent<ScoreSystem>().AIattackValueRow2 += attackValue;
                    }

                    if (col.gameObject.name.Contains("AIRow3")) {

                        battlefield.GetComponent<ScoreSystem>().AIattackValueRow3 += attackValue;
                    }

                    battlefield.GetComponent<ScoreSystem>().AIattackValue += attackValue;

                    StartCoroutine("RemoveOpponentSlot");
                }



            }

        }


        IEnumerator RemovePlayer1Slot() {
            yield return new WaitForSeconds(2);
            Destroy(destroySlot);

        }

        IEnumerator RemoveOpponentSlot() {
            yield return new WaitForSeconds(2);
            Destroy(destroyOpponentSlot);

        }

    }
}

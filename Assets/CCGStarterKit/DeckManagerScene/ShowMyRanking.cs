using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

namespace Caerwent{

	public class ShowMyRanking : MonoBehaviour {
		
		private GameObject[] allObjects;
		public List<GameObject> getScoresList = new List<GameObject>();
		private GameObject rankingValue;
		
		void Awake(){
			rankingValue = GameObject.Find("MyRankingValue");
		}

		// Use this for initialization
		void Start () {
			
			StartCoroutine(ShowMyRankingValue());
		
		}
		
		// Update is called once per frame
		void Update () {
			
			/* if (Input.GetKeyDown(KeyCode.M)){
				StartCoroutine(ShowMyRankingValue());
				
			} */
		}
		
		IEnumerator ShowMyRankingValue(){
			yield return new WaitForSeconds(1);
			allObjects = GameObject.FindObjectsOfType(typeof(GameObject)) as GameObject[];
			foreach (GameObject obj in allObjects){
				if (obj.name.Contains("rankingEntry")){
					
						getScoresList.Add(obj);
					}	
				}
			foreach(GameObject obj in getScoresList){
				if(obj.GetComponent<SetRNInfo>().GetName() == "Tomza"){
					rankingValue.GetComponent<Text>().text = obj.GetComponent<SetRNInfo>().GetScore().ToString();
				}
			}
			
		}
		
	}

}

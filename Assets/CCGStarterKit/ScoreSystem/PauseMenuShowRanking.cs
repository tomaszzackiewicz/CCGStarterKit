using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

namespace Caerwent{

	public class PauseMenuShowRanking : MonoBehaviour {

		static int rankNumber = 1;
		
		private GameObject[] allObjects;
		private GameObject[] allObjects1;
		public List<GameObject> getScoresList = new List<GameObject>();
		public List<GameObject> getDBEntryList = new List<GameObject>();
		public GameObject rankingText;
		public GameObject idPauseMenu;
		public GameObject namePauseMenu;
		public GameObject scorePauseMenu;
		private bool isFirstRanking;
		
		void Awake(){
			//idPauseMenu = GameObject.Find("IDPauseMenu");
			//namePauseMenu = GameObject.Find("NamePauseMenu");
			//scorePauseMenu = GameObject.Find("ScorePauseMenu");
		}

		// Use this for initialization
		void Start () {
			
			isFirstRanking = false;
			
		
		}
		
		// Update is called once per frame
		void Update () {
			
			if (Input.GetKeyDown(KeyCode.N)){
				
				
			}	

		}
		
		public void RefreshRanking(){
			
			isFirstRanking = !isFirstRanking;
			
			if(isFirstRanking){
				StartCoroutine(ShowMyRankingValue());
			}
			
			if(!isFirstRanking){
					allObjects1 = GameObject.FindObjectsOfType(typeof(GameObject)) as GameObject[];
					foreach (GameObject obj in allObjects1){
						if (obj.name.Contains("DBEntry")){
							
								getDBEntryList.Add(obj);
								
						}	
					}
					
					if(getDBEntryList.Count > 0){
						for(int i = 0; i < getDBEntryList.Count; i++){
							Destroy(getDBEntryList[i]);
						}
						getDBEntryList.Clear();
						getDBEntryList.RemoveAll(item => item == null);
						getScoresList.Clear();
						getScoresList.RemoveAll(item => item == null);
						rankNumber = 1;
					}
				}
			
			
		}
		
		IEnumerator ShowMyRankingValue(){
			//yield return new WaitForSeconds(1);
			allObjects = GameObject.FindObjectsOfType(typeof(GameObject)) as GameObject[];
			foreach (GameObject obj in allObjects){
				if (obj.name.Contains("rankingEntry")){
					
						getScoresList.Add(obj);
						
					}	
				}
				
			getScoresList.Reverse();
				
			foreach(GameObject obj in getScoresList){
				
				
				GameObject dbIDEntry = Instantiate(rankingText, transform.position, transform.rotation) as GameObject;
				dbIDEntry.name = "idDBEntry";
				dbIDEntry.transform.SetParent(idPauseMenu.transform);
				string rankToShow = ("#" + (rankNumber).ToString());
				dbIDEntry.GetComponent<Text>().text = rankToShow;
				rankNumber++;
				
				GameObject dbNameEntry = Instantiate(rankingText, transform.position, transform.rotation) as GameObject;
				dbNameEntry.name = "nameDBEntry";
				dbNameEntry.transform.SetParent(namePauseMenu.transform);
				dbNameEntry.GetComponent<Text>().text = obj.GetComponent<SetRNInfo>().GetName();
				
				GameObject dbScoreEntry = Instantiate(rankingText, transform.position, transform.rotation) as GameObject;
				dbScoreEntry.name = "scoreDBEntry";
				dbScoreEntry.transform.SetParent(scorePauseMenu.transform);
				dbScoreEntry.GetComponent<Text>().text = obj.GetComponent<SetRNInfo>().GetScore().ToString();
			}
			
			yield return null;
			
		}
	}

}

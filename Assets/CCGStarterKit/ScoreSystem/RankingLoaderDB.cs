using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;

namespace Caerwent{

	public class RankingLoaderDB : MonoBehaviour{
		
		//Static reference variable for this class
		public static RankingLoaderDB rankingLoaderDB;
		
		public List<int> rankingInt = new List<int>();
		public List<GameObject> getScoresList = new List<GameObject>();
		
		private GameObject[] allObjects;
		public string[] items;
		private string db_url = "http://localhost:8088/";
		public GameObject databasePrefab;
		public GameObject rankingPrefab;
		public GameObject databaseTable;
		public GameObject rankingTable;
		private string rank;
		private string iD;
		private string name;
		private string score;
		private string word;
		private string scoreToShow;
		private string nameToShow;
		private string rankToShow;
		
		
		void Awake(){
			
			//Make this class singletone (only one instance in application)
			if(rankingLoaderDB == null){

			DontDestroyOnLoad(gameObject);
			rankingLoaderDB = this;
			
			}
			else if(rankingLoaderDB != this){
			
			Destroy(gameObject);

			}
			
		}
		

		// Use this for initialization
		IEnumerator Start () {
			
			WWW itemsData = new WWW(db_url + "GetRankingData.php");//http://localhost:8088/RankingData.php
			yield return itemsData;
			string itemsDataString = itemsData.text;
			
			items = itemsDataString.Split(';');
			
			
			ShowRanking();
			
		
		}
		
		void Update(){
			
			
		}
		
		string GetDataValue(string data, string index){
			string value = data.Substring(data.IndexOf(index) + index.Length);
			if(value.Contains("|")) value = value.Remove(value.IndexOf("|"));
			
			return value;
		}
		
		public void ShowRanking(){
			StartCoroutine(FunctionSequence());
		}
		
		IEnumerator FunctionSequence(){
			
			 yield return StartCoroutine(ShowDatabaseInformation());
			 yield return StartCoroutine(SortEntries());
			 yield return StartCoroutine(ShowRankingInformation());
		}
		
		
		IEnumerator ShowDatabaseInformation(){
			
			for(int i = 0; i < items.Length; i++){
			
				if(items.Length > 0){
					rank = ("#" + (i+1).ToString());
					iD = GetDataValue(items[i], "ID: ");
					name = GetDataValue(items[i], "Name: ");
					score = GetDataValue(items[i], "Score: ");
				}
				
				
				GameObject tempObject = Instantiate(databasePrefab, databaseTable.transform.position, databaseTable.transform.rotation) as GameObject;
				tempObject.name = "databaseEntry";
				tempObject.GetComponent<SetDBInfo>().SetScore(rank, iD, name, score);
				tempObject.transform.SetParent(databaseTable.transform);
				tempObject.GetComponent<RectTransform>().localScale = new Vector3(1,1,1);	
				
			}
			
			yield return null;

		}
		
		
		IEnumerator SortEntries(){
			
			allObjects = GameObject.FindObjectsOfType(typeof(GameObject)) as GameObject[];
			foreach (GameObject obj in allObjects){
				if (obj.name.Contains("databaseEntry")){
					
						getScoresList.Add(obj);
					}	
				}
				
			//Sorting list and check it count
		   if (getScoresList.Count > 0) {
				getScoresList.Sort(
					delegate(GameObject a, GameObject b) {
						return (a.GetComponent<SetDBInfo>().GetScore()).CompareTo(b.GetComponent<SetDBInfo>().GetScore());
					}
				);
		   }
			getScoresList.Reverse();
			
			yield return null;
			
			
		}
			
		
		IEnumerator ShowRankingInformation(){
			
			for(int i = 0; i < getScoresList.Count; i++){
				
				rankToShow = ("#" + (i+1).ToString());
				nameToShow = getScoresList[i].GetComponent<SetDBInfo>().GetName();
				scoreToShow = getScoresList[i].GetComponent<SetDBInfo>().GetScore().ToString();
				
				GameObject tempObject = Instantiate(rankingPrefab, rankingTable.transform.position, rankingTable.transform.rotation) as GameObject;
				tempObject.name = "rankingEntry";
				tempObject.GetComponent<SetRNInfo>().SetRanking(rankToShow, nameToShow, scoreToShow);
				tempObject.transform.SetParent(rankingTable.transform);
				tempObject.GetComponent<RectTransform>().localScale = new Vector3(1,1,1);
			}
			
			 yield return null;
		}
		
	}

}

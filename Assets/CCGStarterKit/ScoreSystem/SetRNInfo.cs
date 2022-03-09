using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System;

namespace Caerwent{

	public class SetRNInfo : MonoBehaviour {
		
		//Static reference variable for this class
		public static SetRNInfo setRNInfo;
		
		public GameObject rank;
		public GameObject name;
		public GameObject score;
		
		void Awake(){
			
			/* //Make this class singletone (only one instance in application)
			if(setRNInfo == null){

			DontDestroyOnLoad(gameObject);
			setRNInfo = this;
			
			}
			else if(setRNInfo != this){
			
			Destroy(gameObject);

			} */
			
			
		}

		// Use this for initialization
		void Start () {
		
		}
		
		// Update is called once per frame
		void Update () {
		
		}
		
		public void SetRanking(string rankToShow, string nameToShow, string scoreToShow){
			
			this.rank.GetComponent<Text>().text = rankToShow;
			this.name.GetComponent<Text>().text = nameToShow;
			this.score.GetComponent<Text>().text = scoreToShow;
			
		}
		
		public int GetScore(){
			return Convert.ToInt32(this.score.GetComponent<Text>().text);
		}
		public string GetName(){
			return this.name.GetComponent<Text>().text;
		}
	}

}

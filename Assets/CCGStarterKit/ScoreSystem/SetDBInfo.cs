using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System;

namespace Caerwent{

	public class SetDBInfo : MonoBehaviour{
		
		//Static reference variable for this class
		public static SetDBInfo setDBInfo;
		
		public GameObject rank;
		public GameObject id;
		public GameObject name;
		public GameObject score;
		
		void Awake(){
			
			/* //Make this class singletone (only one instance in application)
			if(setDBInfo == null){

			DontDestroyOnLoad(gameObject);
			setDBInfo = this;
			
			}
			else if(setDBInfo != this){
			
			Destroy(gameObject);

			} */
			
			
		}
		

		// Use this for initialization
		void Start () {
			
		
		}
		
		// Update is called once per frame
		void Update () {
		
		}
		
		
		public void SetScore(string rank, string id, string name, string score){
			
			this.rank.GetComponent<Text>().text = rank;
			this.id.GetComponent<Text>().text = id;
			this.name.GetComponent<Text>().text = name;
			this.score.GetComponent<Text>().text = score.ToString();
		}
		
		public int GetScore(){
			return Convert.ToInt32(this.score.GetComponent<Text>().text);
		}
		public string GetName(){
			return this.name.GetComponent<Text>().text;
		}
		
		
		
		
	}

}

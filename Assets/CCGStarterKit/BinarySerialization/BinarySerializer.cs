using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class BinarySerializer : MonoBehaviour{
	
	/*
	*	The binary file is saved in this path:
	* Windows: C:/Users/Litech/AppData/LocalLow/DefaultCompany/Card Game/playerInfo.dat
	*
	*/

	public static BinarySerializer control;
	static readonly string BINARY_FILE = "playerInfo.dat";
	
	public float health;
	public float experience;

	void Awake(){
		if(control == null){

		DontDestroyOnLoad(gameObject);
		control = this;
		
		}
		else if(control != this){
		
		Destroy(gameObject);

		}
	}
	
	void Update(){
		
	}

	public void Save(){

		BinaryFormatter bf  =  new BinaryFormatter();
		//FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.dat");
		FileStream file = File.Create(Path.Combine(Application.persistentDataPath, BINARY_FILE));
		
		PlayerData data =  new PlayerData();
		
		data.health = health;
		data.experience = experience;
		
		bf.Serialize(file, data);
		file.Close();

	}

	
	public void Load(){

		if(File.Exists(Path.Combine(Application.persistentDataPath, BINARY_FILE))){
			
			BinaryFormatter bf  =  new BinaryFormatter();
			//FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);
			FileStream file = File.Open(Path.Combine(Application.persistentDataPath, BINARY_FILE), FileMode.Open);
			PlayerData data = (PlayerData)bf.Deserialize(file);
			file.Close();

			health = data.health;
			experience = data.experience;
		}

	}

	public void Delete(){
		
		if(File.Exists(Path.Combine(Application.persistentDataPath, BINARY_FILE))){
			
			File.Delete(Path.Combine(Application.persistentDataPath, BINARY_FILE));
			
			}
		} 

}


[Serializable]
class PlayerData{
	
	public float health;
	public float experience;
	
}

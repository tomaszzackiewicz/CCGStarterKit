using UnityEngine;
using System.Collections;

public class DeckBuilderCameraManager : MonoBehaviour {
	
	public GameObject cameraCollection;
	public GameObject cameraDeck;
	private bool isCameraDeckOn;
	
	private bool switcher;

	// Use this for initialization
	void Start () {
		cameraCollection.SetActive(true);
		cameraDeck.SetActive(false);
		isCameraDeckOn = false;
	
	}
	
	public void ShowMainCamera(){
		
		cameraCollection.SetActive(true);
		cameraDeck.SetActive(false);
		isCameraDeckOn = false;
		
	}
	
	public void ShowDeckCamera(){
		
		cameraCollection.SetActive(false);
		cameraDeck.SetActive(true);
		isCameraDeckOn = true;
		
	}
	
	// Update is called once per frame
	void Update () {
		if(cameraDeck && cameraDeck.activeInHierarchy && isCameraDeckOn){
			Vector3 temp = cameraDeck.transform.localPosition;
			
			if(Input.GetAxis("Mouse ScrollWheel") > 0){
				
				temp.x++;
				if(temp.x > 15.0f){
					temp.x = 15.0f;
				}
				cameraDeck.transform.localPosition = temp;
			}
			if(Input.GetAxis("Mouse ScrollWheel") < 0){
				
				temp.x--;
				if(temp.x < -15.0f){
					temp.x = -15.0f;
				}
				cameraDeck.transform.localPosition = temp;
			}
			
			if(Input.GetKeyDown(KeyCode.A)){
				
				temp.x++;
				if(temp.x > 15.0f){
					temp.x = 15.0f;
				}
				cameraDeck.transform.localPosition = temp;
				
			}
			if(Input.GetKeyDown(KeyCode.D)){
				
				temp.x--;
				if(temp.x < -15.0f){
					temp.x = -15.0f;
				}
				cameraDeck.transform.localPosition = temp;
				
			}
		}
		
		
	
	}
	
}

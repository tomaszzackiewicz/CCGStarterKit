using UnityEngine;
using System.Collections;

public class CardGameCameraSwitch : MonoBehaviour {
	
	public GameObject fullView;
	public GameObject playerView;
	public GameObject playerPerspectiveView;
	private Vector3 newPosition;
	private Vector3 oldPosition;
	private Vector3 oldRotation;
	private float oldFOV;

	// Use this for initialization
	void Start () {
		if(fullView){
			fullView.gameObject.SetActive(true);
		}
		if(playerView){
			playerView.gameObject.SetActive(false);
		}
		if(playerPerspectiveView){
			playerPerspectiveView.gameObject.SetActive(false);
		}
		
		
		oldPosition = playerPerspectiveView.transform.position;
		newPosition = playerPerspectiveView.transform.position;
		oldRotation = playerPerspectiveView.transform.eulerAngles;
		oldFOV = playerPerspectiveView.GetComponent<Camera>().fieldOfView;
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKeyDown(KeyCode.Alpha1)){
			fullView.gameObject.SetActive(true);
			playerView.gameObject.SetActive(false);
			playerPerspectiveView.gameObject.SetActive(false);
		}
		if(Input.GetKeyDown(KeyCode.Alpha2)){
			fullView.gameObject.SetActive(false);
			playerView.gameObject.SetActive(true);
			playerPerspectiveView.gameObject.SetActive(false);
		}
		if(Input.GetKeyDown(KeyCode.Alpha3)){
			fullView.gameObject.SetActive(false);
			playerView.gameObject.SetActive(false);
			playerPerspectiveView.gameObject.SetActive(true);
		}
		
		if(playerPerspectiveView.activeInHierarchy == true){
			if(Input.GetKeyDown(KeyCode.DownArrow)){
				if(playerPerspectiveView.GetComponent<Camera>().fieldOfView >= 5){
					playerPerspectiveView.GetComponent<Camera>().fieldOfView += 5;
					
					if(playerPerspectiveView.GetComponent<Camera>().fieldOfView >= 60){
						playerPerspectiveView.GetComponent<Camera>().fieldOfView = 60;
					}
				}
				
			}
			if(Input.GetKeyDown(KeyCode.UpArrow)){
				if(playerPerspectiveView.GetComponent<Camera>().fieldOfView <= 60){
					playerPerspectiveView.GetComponent<Camera>().fieldOfView -= 5;
					
					if(playerPerspectiveView.GetComponent<Camera>().fieldOfView <= 5){
						playerPerspectiveView.GetComponent<Camera>().fieldOfView = 5;
					}
				}
			}
			
			if(Input.GetKeyDown(KeyCode.RightArrow)){
				float temp = 10.0f;
				if(newPosition.x >= temp){
					newPosition.x = 10.0f;
				}
				newPosition.x += 1;
				playerPerspectiveView.transform.position = newPosition;
				
			}
			if(Input.GetKeyDown(KeyCode.LeftArrow)){
				float temp = -10.0f;
				if(newPosition.x <= temp){
					newPosition.x = -10.0f;
				}
				newPosition.x -= 1;
				playerPerspectiveView.transform.position = newPosition;
				
			}
			
			if(playerPerspectiveView.transform.eulerAngles.x <= 15){
				Vector3 temp = playerPerspectiveView.transform.eulerAngles;
				temp.x = 15;
				playerPerspectiveView.transform.eulerAngles = temp;
			}
			if(playerPerspectiveView.transform.eulerAngles.x >= 55){
				Vector3 temp = playerPerspectiveView.transform.eulerAngles;
				temp.x = 55;
				playerPerspectiveView.transform.eulerAngles = temp;
			}
			playerPerspectiveView.transform.Rotate(Vector3.right * 10 * Input.GetAxis("Mouse ScrollWheel"));
			
			
		}
		
		if(Input.GetMouseButton(2)){
			playerPerspectiveView.GetComponent<Camera>().fieldOfView = oldFOV;
			playerPerspectiveView.transform.position = oldPosition;
			playerPerspectiveView.transform.eulerAngles = oldRotation;
			
		}
		
	}
	
	public void FullView(){
		
		fullView.gameObject.SetActive(true);
		playerView.gameObject.SetActive(false);
		playerPerspectiveView.gameObject.SetActive(false);
		
	}
	
	public void PlayerView(){
		
		fullView.gameObject.SetActive(false);
		playerView.gameObject.SetActive(true);
		playerPerspectiveView.gameObject.SetActive(false);
		
	}
	
	public void PlayerPerspectiveView(){
		
		fullView.gameObject.SetActive(false);
		playerView.gameObject.SetActive(false);
		playerPerspectiveView.gameObject.SetActive(true);
		
	}
	
	
	public void ZoomInPersCamera(){
		playerPerspectiveView.GetComponent<Camera>().fieldOfView -= 5;
	}
	
	public void ZoomOutPersCamera(){
		playerPerspectiveView.GetComponent<Camera>().fieldOfView += 5;
	}
	
	public void RightMovePersCamera(){
		newPosition.x += 1;
		playerPerspectiveView.transform.position = newPosition;
	}
	
	public void LeftMovePersCamera(){
		newPosition.x -= 1;
		playerPerspectiveView.transform.position = newPosition;
	}
	
	public void ResetPersCamera(){
		playerPerspectiveView.GetComponent<Camera>().fieldOfView = oldFOV;
		playerPerspectiveView.transform.position = oldPosition;
		playerPerspectiveView.transform.eulerAngles = oldRotation;
	}
	
	
}

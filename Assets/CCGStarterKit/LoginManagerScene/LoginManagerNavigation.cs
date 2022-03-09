using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

namespace Caerwent{

	public class LoginManagerNavigation : MonoBehaviour {
		
		private AsyncOperation ao;
		public GameObject loadingScreenBG;
		public Slider progBar;
		public Text loadingText;
		public GameObject levelSelectBG;
		public GameObject loadSceneButton;
		
		public bool isFakeLoadingBar = false;
		public float fakeIncrement = 0f;
		public float fakeTiming = 0f;

		// Use this for initialization
		void Start () {
			loadingScreenBG.SetActive(false);
			progBar.gameObject.SetActive(false);
			loadingText.gameObject.SetActive(false);
			levelSelectBG.SetActive(false);
			loadSceneButton.SetActive(false);
		
		}
		
		// Update is called once per frame
		void Update () {
			if(Input.GetKeyDown(KeyCode.Q)) {
				
				Application.Quit();
				
				}
		
		}
		
		public void Quit(){
			Application.Quit();
		}
		
		public void GoDeckManager(){
			
			loadingScreenBG.SetActive(true);
			progBar.gameObject.SetActive(true);
			loadingText.gameObject.SetActive(true);
			loadingText.text = "Loading...";
			levelSelectBG.SetActive(true);
			
			
			if(!isFakeLoadingBar){
				StartCoroutine (AsynchronousLoad ());
				
			}else{
				StartCoroutine (AsynchronousLoadFake ());
				
			}
			
			
		}
		
		IEnumerator AsynchronousLoad (){
			
			
			 yield return new WaitForSeconds(1); 
			 ao = SceneManager.LoadSceneAsync("DeckManager"); 
			 ao.allowSceneActivation = false;
			 
			 while(!ao.isDone) { 
				 
				 progBar.value = ao.progress;
				 
				 if (ao.progress == 0.9f) {
					 progBar.value = 1.0f;
					 loadingText.text = "Press 'X' or the button \n to continue";
					 loadSceneButton.SetActive(true);
					if(Input.GetKeyDown(KeyCode.X)){
						ao.allowSceneActivation = true;
					}
				 } 
				 
				 //Debug.Log(ao.progress);
				 
				 yield return null; 
			 }
		}
		
		
		IEnumerator AsynchronousLoadFake (){
			
			yield return new WaitForSeconds(1);
			
			while(progBar.value != 1.0f){
				progBar.value += fakeIncrement;
				yield return new WaitForSeconds(fakeTiming);
			}
			while(progBar.value == 1.0f){
				loadingText.text = "Press 'X' or the button \n to continue";
				if(Input.GetKeyDown(KeyCode.X)){
						SceneManager.LoadScene("DeckManager");
					}
				yield return null;	
			}
			
		}
		
		public void LoadDeckManager(){
			ao.allowSceneActivation = true;
		}
	}

}

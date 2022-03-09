using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DeleteCardInEditMode : MonoBehaviour {
	
	private Ray ray;
	private RaycastHit hit;

	// Use this for initialization
	void Start () {
			
	
	}
	
	// Update is called once per frame
	void Update () {
		
		ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		 
		if(Physics.Raycast(ray,out hit)){
		
			if(Input.GetMouseButtonDown(1)){
				if(hit.collider.gameObject.name.Contains("instantiated")){
					Destroy(hit.collider.gameObject);
				}
				
				
			}
		}
	}
	
	
}

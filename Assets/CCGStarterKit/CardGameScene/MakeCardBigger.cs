using UnityEngine;
using System.Collections;

public class MakeCardBigger : MonoBehaviour {

	public Transform card;
	private RaycastHit hit;
	
	// Use this for initialization
	void Start () {
	
		card.transform.localScale = new Vector3(0.6f,0.01f,1.0f);
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(2)) {
			Ray ray  = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray, out hit)) {
		
				if (hit.transform == card) {
						
					card.transform.localScale = new Vector3(2.2f,0.1f,4.0f);
						
					}else{
						
					card.transform.localScale = new Vector3(0.6f,0.01f,1.0f);
						
				}
			}
		}
	}
	
	
}

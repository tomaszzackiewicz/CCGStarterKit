using UnityEngine;
using System.Collections;

public class AICardZone1 : MonoBehaviour {
	
	private Color closeColorWZ;
	private Color normalColorWZ;
	public int counterAI;
	
	void Awake(){
		
	}
	
	// Use this for initialization
	void Start () {
		
		closeColorWZ = new Color(0,1,1);
		normalColorWZ = new Color(1,1,1);
		counterAI = 0;
		gameObject.GetComponent<Renderer>().material.color = normalColorWZ;
		
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	void OnMouseEnter() {
		gameObject.GetComponent<Renderer>().material.color = closeColorWZ;
    }
	
	void OnMouseExit(){
		gameObject.GetComponent<Renderer>().material.color = normalColorWZ;
	}
	
	void OnCollisionEnter(Collision col){
		counterAI++;
	}
	
	
}

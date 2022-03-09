using UnityEngine;
using System.Collections;

namespace Caerwent{

public class RightScrollCards : MonoBehaviour {

	 private int getScroll;
     private int newScrollA;
 
     // Use this for initialization
     void Start () {
 
         newScrollA = 0;
         
     }
     
     // Update is called once per frame
     void Update () {
     
     }
     
     void OnMouseDown(){
             
             ScrollCards.curCard--;
             
         }
}

}

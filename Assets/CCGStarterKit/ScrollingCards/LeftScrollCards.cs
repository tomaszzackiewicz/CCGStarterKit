using UnityEngine;
using System.Collections;

namespace Caerwent{

public class LeftScrollCards : MonoBehaviour {

	 private int getScroll;
     private int newScrollM;
     
     // Use this for initialization
     void Start () {
         
         newScrollM = 0;
         
     }
     
     // Update is called once per frame
     void Update () {
     
     }
     
     void OnMouseDown(){
             
             ScrollCards.curCard++;
             
         }
}

}

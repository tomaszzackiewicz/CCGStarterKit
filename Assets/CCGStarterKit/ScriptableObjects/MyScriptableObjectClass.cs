using UnityEngine;
using System.Collections;

namespace Caerwent{

	[CreateAssetMenu(fileName="inventoryListData", menuName="Inventory/List", order=1)]
	public class MyScriptableObjectClass : ScriptableObject {
		
		public string objectName = "New ScriptableObject";
		public bool colorIsRandom = false;
		public Color myColor = Color.white;
		public Vector3[] spawnPoints;
		
	}

}

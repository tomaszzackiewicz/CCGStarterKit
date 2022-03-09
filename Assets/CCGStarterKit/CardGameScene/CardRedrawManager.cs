using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CardRedrawManager : MonoBehaviour {
	
	private RaycastHit hit;
	private Ray ray;
	private bool switcher;
	
	public GameObject[] cardRedraw;
	//public List<GameObject> cardRedraw = new List<GameObject>();
	//private GameObject card3Redraw;
	
	void Awake(){
		
		/* cardRedraw[0] = GameObject.Find("Card1Redraw");
		cardRedraw[1] = GameObject.Find("Card1aRedraw");
		cardRedraw[2] = GameObject.Find("Card1bRedraw");
		cardRedraw[3] = GameObject.Find("Card1cRedraw");
		
		cardRedraw[4] = GameObject.Find("Card2Redraw");
		cardRedraw[5] = GameObject.Find("Card2aRedraw");
		cardRedraw[6] = GameObject.Find("Card2bRedraw");
		cardRedraw[7] = GameObject.Find("Card2cRedraw");
		
		cardRedraw[8] = GameObject.Find("Card3Redraw");
		cardRedraw[9] = GameObject.Find("Card3aRedraw");
		cardRedraw[10] = GameObject.Find("Card3bRedraw");
		cardRedraw[11] = GameObject.Find("Card3cRedraw");
		
		cardRedraw[12] = GameObject.Find("Card4Redraw");
		cardRedraw[13] = GameObject.Find("Card4aRedraw");
		cardRedraw[14] = GameObject.Find("Card4bRedraw");
		cardRedraw[15] = GameObject.Find("Card4cRedraw");
		
		cardRedraw[16] = GameObject.Find("Card5Redraw");
		cardRedraw[17] = GameObject.Find("Card5aRedraw");
		cardRedraw[18] = GameObject.Find("Card5bRedraw");
		cardRedraw[19] = GameObject.Find("Card5cRedraw");
		
		cardRedraw[20] = GameObject.Find("Card6Redraw");
		cardRedraw[21] = GameObject.Find("Card6aRedraw");
		cardRedraw[22] = GameObject.Find("Card6bRedraw");
		cardRedraw[23] = GameObject.Find("Card6cRedraw");
		
		cardRedraw[24] = GameObject.Find("Card7Redraw");
		cardRedraw[25] = GameObject.Find("Card7aRedraw");
		cardRedraw[26] = GameObject.Find("Card7bRedraw");
		cardRedraw[27] = GameObject.Find("Card7cRedraw");
		
		cardRedraw[28] = GameObject.Find("Card8Redraw");
		cardRedraw[29] = GameObject.Find("Card8aRedraw");
		cardRedraw[30] = GameObject.Find("Card8bRedraw");
		cardRedraw[31] = GameObject.Find("Card8cRedraw");
		
		cardRedraw[32] = GameObject.Find("Card9Redraw");
		cardRedraw[33] = GameObject.Find("Card9aRedraw");
		cardRedraw[34] = GameObject.Find("Card9bRedraw");
		cardRedraw[35] = GameObject.Find("Card9cRedraw");
		
		cardRedraw[36] = GameObject.Find("Card10Redraw");
		cardRedraw[37] = GameObject.Find("Card10aRedraw");
		cardRedraw[38] = GameObject.Find("Card10bRedraw");
		cardRedraw[39] = GameObject.Find("Card10cRedraw");
		
		cardRedraw[40] = GameObject.Find("Card11Redraw");
		cardRedraw[41] = GameObject.Find("Card11aRedraw");
		cardRedraw[42] = GameObject.Find("Card11bRedraw");
		cardRedraw[43] = GameObject.Find("Card11cRedraw");
		
		cardRedraw[44] = GameObject.Find("Card12Redraw");
		cardRedraw[45] = GameObject.Find("Card12aRedraw");
		cardRedraw[46] = GameObject.Find("Card12bRedraw");
		cardRedraw[47] = GameObject.Find("Card12cRedraw");
		
		cardRedraw[48] = GameObject.Find("Card13Redraw");
		cardRedraw[49] = GameObject.Find("Card13aRedraw");
		cardRedraw[50] = GameObject.Find("Card13bRedraw");
		cardRedraw[51] = GameObject.Find("Card13cRedraw");
		
		cardRedraw[52] = GameObject.Find("Card14Redraw");
		cardRedraw[53] = GameObject.Find("Card14aRedraw");
		cardRedraw[54] = GameObject.Find("Card14bRedraw");
		cardRedraw[55] = GameObject.Find("Card14cRedraw");
		
		cardRedraw[56] = GameObject.Find("Card15Redraw");
		cardRedraw[57] = GameObject.Find("Card15aRedraw");
		cardRedraw[58] = GameObject.Find("Card15bRedraw");
		cardRedraw[59] = GameObject.Find("Card15cRedraw");
		
		cardRedraw[60] = GameObject.Find("Card16Redraw");
		cardRedraw[61] = GameObject.Find("Card16aRedraw");
		cardRedraw[62] = GameObject.Find("Card16bRedraw");
		cardRedraw[63] = GameObject.Find("Card16cRedraw");
		
		cardRedraw[64] = GameObject.Find("Card17Redraw");
		cardRedraw[65] = GameObject.Find("Card17aRedraw");
		cardRedraw[66] = GameObject.Find("Card17bRedraw");
		cardRedraw[67] = GameObject.Find("Card17cRedraw");
		
		cardRedraw[68] = GameObject.Find("Card18Redraw");
		cardRedraw[69] = GameObject.Find("Card18aRedraw");
		cardRedraw[70] = GameObject.Find("Card18bRedraw");
		cardRedraw[71] = GameObject.Find("Card18cRedraw");
		
		cardRedraw[72] = GameObject.Find("Card19Redraw");
		cardRedraw[73] = GameObject.Find("Card19aRedraw");
		cardRedraw[74] = GameObject.Find("Card19bRedraw");
		cardRedraw[75] = GameObject.Find("Card19cRedraw");
		
		cardRedraw[76] = GameObject.Find("Card20Redraw");
		cardRedraw[77] = GameObject.Find("Card20aRedraw");
		cardRedraw[78] = GameObject.Find("Card20bRedraw");
		cardRedraw[79] = GameObject.Find("Card20cRedraw");
		
		cardRedraw[80] = GameObject.Find("Card21Redraw");
		cardRedraw[81] = GameObject.Find("Card21aRedraw");
		cardRedraw[82] = GameObject.Find("Card21bRedraw");
		cardRedraw[83] = GameObject.Find("Card21cRedraw");
		
		cardRedraw[84] = GameObject.Find("Card22Redraw");
		cardRedraw[85] = GameObject.Find("Card22aRedraw");
		cardRedraw[86] = GameObject.Find("Card22bRedraw");
		cardRedraw[87] = GameObject.Find("Card22cRedraw");
		
		cardRedraw[88] = GameObject.Find("Card23Redraw");
		cardRedraw[89] = GameObject.Find("Card23aRedraw");
		cardRedraw[90] = GameObject.Find("Card23bRedraw");
		cardRedraw[91] = GameObject.Find("Card23cRedraw");
		
		cardRedraw[92] = GameObject.Find("Card24Redraw");
		cardRedraw[93] = GameObject.Find("Card24aRedraw");
		cardRedraw[94] = GameObject.Find("Card24bRedraw");
		cardRedraw[95] = GameObject.Find("Card24cRedraw");
		
		cardRedraw[96] = GameObject.Find("Card25Redraw");
		cardRedraw[97] = GameObject.Find("Card25aRedraw");
		cardRedraw[98] = GameObject.Find("Card25bRedraw");
		cardRedraw[99] = GameObject.Find("Card25cRedraw");
		
		cardRedraw[100] = GameObject.Find("Card26Redraw");
		cardRedraw[101] = GameObject.Find("Card26aRedraw");
		cardRedraw[102] = GameObject.Find("Card26bRedraw");
		cardRedraw[103] = GameObject.Find("Card26cRedraw");
		
		cardRedraw[104] = GameObject.Find("Card27Redraw");
		cardRedraw[105] = GameObject.Find("Card27aRedraw");
		cardRedraw[106] = GameObject.Find("Card27bRedraw");
		cardRedraw[107] = GameObject.Find("Card27cRedraw");
		
		cardRedraw[108] = GameObject.Find("Card28Redraw");
		cardRedraw[109] = GameObject.Find("Card28aRedraw");
		cardRedraw[110] = GameObject.Find("Card28bRedraw");
		cardRedraw[111] = GameObject.Find("Card28cRedraw");
		
		cardRedraw[112] = GameObject.Find("Card29Redraw");
		cardRedraw[113] = GameObject.Find("Card29aRedraw");
		cardRedraw[114] = GameObject.Find("Card29bRedraw");
		cardRedraw[115] = GameObject.Find("Card29cRedraw");
		
		cardRedraw[116] = GameObject.Find("Card30Redraw");
		cardRedraw[117] = GameObject.Find("Card30aRedraw");
		cardRedraw[118] = GameObject.Find("Card30bRedraw");
		cardRedraw[119] = GameObject.Find("Card30cRedraw");
		
		cardRedraw[120] = GameObject.Find("Card31Redraw");
		cardRedraw[121] = GameObject.Find("Card31aRedraw");
		cardRedraw[122] = GameObject.Find("Card31bRedraw");
		cardRedraw[123] = GameObject.Find("Card31cRedraw");
		
		cardRedraw[124] = GameObject.Find("Card32Redraw");
		cardRedraw[125] = GameObject.Find("Card32aRedraw");
		cardRedraw[126] = GameObject.Find("Card32bRedraw");
		cardRedraw[127] = GameObject.Find("Card32cRedraw");
		
		cardRedraw[128] = GameObject.Find("Card33Redraw");
		cardRedraw[129] = GameObject.Find("Card33aRedraw");
		cardRedraw[130] = GameObject.Find("Card33bRedraw");
		cardRedraw[131] = GameObject.Find("Card33cRedraw");
		
		cardRedraw[132] = GameObject.Find("Card34Redraw");
		cardRedraw[133] = GameObject.Find("Card34aRedraw");
		cardRedraw[134] = GameObject.Find("Card34bRedraw");
		cardRedraw[135] = GameObject.Find("Card34cRedraw");
		
		cardRedraw[136] = GameObject.Find("Card35Redraw");
		cardRedraw[137] = GameObject.Find("Card35aRedraw");
		cardRedraw[138] = GameObject.Find("Card35bRedraw");
		cardRedraw[139] = GameObject.Find("Card35cRedraw");
		
		cardRedraw[140] = GameObject.Find("Card36Redraw");
		cardRedraw[141] = GameObject.Find("Card36aRedraw");
		cardRedraw[142] = GameObject.Find("Card36bRedraw");
		cardRedraw[143] = GameObject.Find("Card36cRedraw");
		
		cardRedraw[144] = GameObject.Find("Card37Redraw");
		cardRedraw[145] = GameObject.Find("Card37aRedraw");
		cardRedraw[146] = GameObject.Find("Card37bRedraw");
		cardRedraw[147] = GameObject.Find("Card37cRedraw");
		
		cardRedraw[148] = GameObject.Find("Card38Redraw");
		cardRedraw[149] = GameObject.Find("Card38aRedraw");
		cardRedraw[150] = GameObject.Find("Card38bRedraw");
		cardRedraw[151] = GameObject.Find("Card38cRedraw");
		
		cardRedraw[152] = GameObject.Find("Card39Redraw");
		cardRedraw[153] = GameObject.Find("Card39aRedraw");
		cardRedraw[154] = GameObject.Find("Card39bRedraw");
		cardRedraw[155] = GameObject.Find("Card39cRedraw");
		
		cardRedraw[156] = GameObject.Find("Card40Redraw");
		cardRedraw[157] = GameObject.Find("Card40aRedraw");
		cardRedraw[158] = GameObject.Find("Card40bRedraw");
		cardRedraw[159] = GameObject.Find("Card40cRedraw");
		
		cardRedraw[160] = GameObject.Find("Card41Redraw");
		cardRedraw[161] = GameObject.Find("Card41aRedraw");
		cardRedraw[162] = GameObject.Find("Card41bRedraw");
		cardRedraw[163] = GameObject.Find("Card41cRedraw");
		
		cardRedraw[164] = GameObject.Find("Card42Redraw");
		cardRedraw[165] = GameObject.Find("Card42aRedraw");
		cardRedraw[166] = GameObject.Find("Card42bRedraw");
		cardRedraw[167] = GameObject.Find("Card42cRedraw");
		
		cardRedraw[168] = GameObject.Find("Card43Redraw");
		cardRedraw[169] = GameObject.Find("Card43aRedraw");
		cardRedraw[170] = GameObject.Find("Card43bRedraw");
		cardRedraw[171] = GameObject.Find("Card43cRedraw");
		
		cardRedraw[172] = GameObject.Find("Card44Redraw");
		cardRedraw[173] = GameObject.Find("Card44aRedraw");
		cardRedraw[174] = GameObject.Find("Card44bRedraw");
		cardRedraw[175] = GameObject.Find("Card44cRedraw");
		
		cardRedraw[176] = GameObject.Find("Card45Redraw");
		cardRedraw[177] = GameObject.Find("Card45aRedraw");
		cardRedraw[178] = GameObject.Find("Card45bRedraw");
		cardRedraw[179] = GameObject.Find("Card45cRedraw");
		
		cardRedraw[180] = GameObject.Find("Card46Redraw");
		cardRedraw[181] = GameObject.Find("Card46aRedraw");
		cardRedraw[182] = GameObject.Find("Card46bRedraw");
		cardRedraw[183] = GameObject.Find("Card46cRedraw");
		
		cardRedraw[184] = GameObject.Find("Card47Redraw");
		cardRedraw[185] = GameObject.Find("Card47aRedraw");
		cardRedraw[186] = GameObject.Find("Card47bRedraw");
		cardRedraw[187] = GameObject.Find("Card47cRedraw");
		
		cardRedraw[188] = GameObject.Find("Card48Redraw");
		cardRedraw[189] = GameObject.Find("Card48aRedraw");
		cardRedraw[190] = GameObject.Find("Card48bRedraw");
		cardRedraw[191] = GameObject.Find("Card48cRedraw");
		
		cardRedraw[192] = GameObject.Find("Card49Redraw");
		cardRedraw[193] = GameObject.Find("Card49aRedraw");
		cardRedraw[194] = GameObject.Find("Card49bRedraw");
		cardRedraw[195] = GameObject.Find("Card49cRedraw");
		
		cardRedraw[196] = GameObject.Find("Card50Redraw");
		cardRedraw[197] = GameObject.Find("Card50aRedraw");
		cardRedraw[198] = GameObject.Find("Card50bRedraw");
		cardRedraw[199] = GameObject.Find("Card50cRedraw");
		
		cardRedraw[200] = GameObject.Find("Card51Redraw");
		cardRedraw[201] = GameObject.Find("Card51aRedraw");
		cardRedraw[202] = GameObject.Find("Card51bRedraw");
		cardRedraw[203] = GameObject.Find("Card51cRedraw");
		
		cardRedraw[204] = GameObject.Find("Card52Redraw");
		cardRedraw[205] = GameObject.Find("Card52aRedraw");
		cardRedraw[206] = GameObject.Find("Card52bRedraw");
		cardRedraw[207] = GameObject.Find("Card52cRedraw");
		
		cardRedraw[208] = GameObject.Find("Card53Redraw");
		cardRedraw[209] = GameObject.Find("Card53aRedraw");
		cardRedraw[210] = GameObject.Find("Card53bRedraw");
		cardRedraw[211] = GameObject.Find("Card53cRedraw");
		
		cardRedraw[212] = GameObject.Find("Card54Redraw");
		cardRedraw[213] = GameObject.Find("Card54aRedraw");
		cardRedraw[214] = GameObject.Find("Card54bRedraw");
		cardRedraw[215] = GameObject.Find("Card54cRedraw");
		
		cardRedraw[216] = GameObject.Find("Card55Redraw");
		cardRedraw[217] = GameObject.Find("Card55aRedraw");
		cardRedraw[218] = GameObject.Find("Card55bRedraw");
		cardRedraw[219] = GameObject.Find("Card55cRedraw");
		
		cardRedraw[220] = GameObject.Find("Card56Redraw");
		cardRedraw[221] = GameObject.Find("Card56aRedraw");
		cardRedraw[222] = GameObject.Find("Card56bRedraw");
		cardRedraw[223] = GameObject.Find("Card56cRedraw");
		
		cardRedraw[224] = GameObject.Find("Card57Redraw");
		cardRedraw[225] = GameObject.Find("Card57aRedraw");
		cardRedraw[226] = GameObject.Find("Card57bRedraw");
		cardRedraw[227] = GameObject.Find("Card57cRedraw");
		
		cardRedraw[228] = GameObject.Find("Card58Redraw");
		cardRedraw[229] = GameObject.Find("Card58aRedraw");
		cardRedraw[230] = GameObject.Find("Card58bRedraw");
		cardRedraw[231] = GameObject.Find("Card58cRedraw");
		
		cardRedraw[232] = GameObject.Find("Card59Redraw");
		cardRedraw[233] = GameObject.Find("Card59aRedraw");
		cardRedraw[234] = GameObject.Find("Card59bRedraw");
		cardRedraw[235] = GameObject.Find("Card59cRedraw");
		
		cardRedraw[236] = GameObject.Find("Card60Redraw");
		cardRedraw[237] = GameObject.Find("Card60aRedraw");
		cardRedraw[238] = GameObject.Find("Card60bRedraw");
		cardRedraw[239] = GameObject.Find("Card60cRedraw"); */
		
		
		
	}
	
	// Use this for initialization
	void Start () {
		switcher = false;
		
		CardRedrawFalse();
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetMouseButtonDown(1)){
			
			ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			if (Physics.Raycast(ray, out hit)) {
				switcher = !switcher;
				
				if (hit.transform.name.Contains("Card1")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[0].SetActive(true);
						
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card1a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[1].SetActive(true);
						
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card1b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[2].SetActive(true);
						
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card1c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[3].SetActive(true);
						
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card2")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[4].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card2a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[5].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card2b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[6].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card2c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[7].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card3")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[8].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card3a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[9].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card3b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[10].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card3c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[11].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card4")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[12].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card4a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[13].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card4b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[14].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card4c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[15].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card5")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[16].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card5a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[17].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card5b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[18].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card5c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[19].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card6")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[20].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card6a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[21].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card6b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[22].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card6c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[23].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card7")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[24].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card7a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[25].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card7b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[26].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card7c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[27].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card8")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[28].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card8a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[29].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card8b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[30].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card8c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[31].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card9")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[32].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card9a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[33].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card9b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[34].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card9c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[35].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card10")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[36].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card10a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[37].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card10b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[38].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card10c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[39].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card11")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[40].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card11a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[41].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card11b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[42].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card11c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[43].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card12")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[44].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card12a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[45].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card12b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[46].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card12c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[47].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card13")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[48].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card13a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[49].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card13b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[50].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card13c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[51].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card14")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[52].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card14a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[53].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card14b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[54].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card14c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[55].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card15")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[56].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card15a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[57].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card15b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[58].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card15c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[59].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card16")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[60].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card16a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[61].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card16b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[62].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card16c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[63].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card17")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[64].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card17a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[65].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card17b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[66].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card17c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[67].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card18")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[68].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card18a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[69].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card18b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[70].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card18c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[71].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card19")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[72].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card19a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[73].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card19b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[74].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card19c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[75].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card20")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[76].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card20a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[77].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card20b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[78].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card20c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[79].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card21")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[80].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card21a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[81].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card21b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[82].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card21c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[83].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card22")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[84].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card22a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[85].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card22b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[86].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card22c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[87].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card23")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[88].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card23a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[89].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card23b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[90].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card23c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[91].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card24")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[92].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card24a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[93].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card24b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[94].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card24c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[95].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card25")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[96].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card25a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[97].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card25b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[98].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card25c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[99].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card26")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[100].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card26a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[101].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card26b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[102].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card26c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[103].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card27")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[104].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card27a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[105].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card27b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[106].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card27c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[107].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card28")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[108].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card28a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[109].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card28b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[110].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card28c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[111].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card29")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[112].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card29a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[113].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card29b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[114].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card29c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[115].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card30")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[116].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card30a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[117].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card30b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[118].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card30c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[119].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card31")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[120].SetActive(true);
						
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card31a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[121].SetActive(true);
						
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card31b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[122].SetActive(true);
						
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card31c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[123].SetActive(true);
						
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card32")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[124].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card32a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[125].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card32b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[126].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card32c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[127].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card33")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[128].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card33a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[129].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card33b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[130].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card33c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[131].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card34")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[132].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card34a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[133].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card34b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[134].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card34c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[135].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card35")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[136].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card35a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[137].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card35b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[138].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card35c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[139].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card36")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[140].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card36a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[141].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card36b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[142].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card36c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[143].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card37")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[144].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card37a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[145].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card37b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[146].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card37c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[147].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card38")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[148].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card38a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[149].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card38b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[150].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card38c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[151].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card39")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[152].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card39a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[153].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card39b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[154].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card39c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[155].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card40")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[156].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card40a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[157].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card40b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[158].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card40c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[159].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card41")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[160].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card41a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[161].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card41b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[162].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card41c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[163].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card42")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[164].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card42a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[165].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card42b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[166].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card42c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[167].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card43")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[168].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card43a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[169].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card43b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[170].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card43c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[171].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card44")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[172].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card44a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[173].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card44b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[174].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card44c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[175].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card45")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[176].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card45a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[177].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card45b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[178].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card45c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[179].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card46")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[180].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card46a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[181].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card46b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[182].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card46c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[183].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card47")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[184].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card47a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[185].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card47b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[186].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card47c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[187].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card48")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[188].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card48a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[189].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card48b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[190].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card48c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[191].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card49")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[192].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card49a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[193].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card49b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[194].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card49c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[195].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card50")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[196].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card50a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[197].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card50b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[198].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card50c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[199].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card51")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[200].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card51a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[201].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card51b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[202].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card51c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[203].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card52")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[204].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card52a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[205].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card52b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[206].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card52c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[207].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card53")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[208].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card53a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[209].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card53b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[210].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card53c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[211].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card54")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[212].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card54a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[213].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card54b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[214].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card54c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[215].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card55")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[216].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card55a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[217].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card55b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[218].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card55c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[219].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card56")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[220].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card56a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[221].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card56b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[222].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card56c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[223].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card57")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[224].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card57a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[225].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card57b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[226].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card57c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[227].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card58")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[228].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				
				if (hit.transform.name.Contains("Card58a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[229].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				
				if (hit.transform.name.Contains("Card58b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[230].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card58c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[231].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card59")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[232].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card59a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[233].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card59b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[234].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card59c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[235].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card60")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[236].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card60a")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[237].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card60b")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[238].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				if (hit.transform.name.Contains("Card60c")) {
					if(switcher){
						CardRedrawFalse();
						cardRedraw[239].SetActive(true);
						
					}else{
						CardRedrawFalse();
					}
				}
				
				
			}
			
			
		}
		
		if(Input.GetKeyDown(KeyCode.Delete)){
			CardRedrawFalse();
		}
	
	}
	
	
	void CardRedrawFalse(){
		/* foreach(GameObject card in cardRedraw){
			card.SetActive(false);
		} */
		
		cardRedraw[0].SetActive(false);
		cardRedraw[1].SetActive(false);
		cardRedraw[2].SetActive(false);
		cardRedraw[3].SetActive(false);
		
		cardRedraw[4].SetActive(false);
		cardRedraw[5].SetActive(false);
		cardRedraw[6].SetActive(false);
		cardRedraw[7].SetActive(false);
		
		cardRedraw[8].SetActive(false);
		cardRedraw[9].SetActive(false);
		cardRedraw[10].SetActive(false); 
		cardRedraw[11].SetActive(false); 
		
		cardRedraw[12].SetActive(false); 
		cardRedraw[13].SetActive(false); 
		cardRedraw[14].SetActive(false); 
		cardRedraw[15].SetActive(false); 
		
		cardRedraw[16].SetActive(false); 
		cardRedraw[17].SetActive(false); 
		cardRedraw[18].SetActive(false); 
		cardRedraw[19].SetActive(false); 
		
		cardRedraw[20].SetActive(false); 
		cardRedraw[21].SetActive(false); 
		cardRedraw[22].SetActive(false); 
		cardRedraw[23].SetActive(false); 
		
		cardRedraw[24].SetActive(false); 
		cardRedraw[25].SetActive(false); 
		cardRedraw[26].SetActive(false); 
		cardRedraw[27].SetActive(false); 
		
		cardRedraw[28].SetActive(false); 
		cardRedraw[29].SetActive(false); 
		cardRedraw[30].SetActive(false); 
		cardRedraw[31].SetActive(false); 
		
		cardRedraw[32].SetActive(false); 
		cardRedraw[33].SetActive(false); 
		cardRedraw[34].SetActive(false); 
		cardRedraw[35].SetActive(false); 
		
		cardRedraw[36].SetActive(false); 
		cardRedraw[37].SetActive(false); 
		cardRedraw[38].SetActive(false); 
		cardRedraw[39].SetActive(false); 
		
		cardRedraw[40].SetActive(false); 
		cardRedraw[41].SetActive(false); 
		cardRedraw[42].SetActive(false); 
		cardRedraw[43].SetActive(false); 
		
		cardRedraw[44].SetActive(false); 
		cardRedraw[45].SetActive(false); 
		cardRedraw[46].SetActive(false); 
		cardRedraw[47].SetActive(false); 
		
		cardRedraw[48].SetActive(false); 
		cardRedraw[49].SetActive(false); 
		cardRedraw[50].SetActive(false); 
		cardRedraw[51].SetActive(false); 
		
		cardRedraw[52].SetActive(false); 
		cardRedraw[53].SetActive(false); 
		cardRedraw[54].SetActive(false); 
		cardRedraw[55].SetActive(false); 
		
		cardRedraw[56].SetActive(false); 
		cardRedraw[57].SetActive(false); 
		cardRedraw[58].SetActive(false); 
		cardRedraw[59].SetActive(false); 
		
		cardRedraw[60].SetActive(false); 
		cardRedraw[61].SetActive(false); 
		cardRedraw[62].SetActive(false); 
		cardRedraw[63].SetActive(false); 
		
		cardRedraw[64].SetActive(false); 
		cardRedraw[65].SetActive(false); 
		cardRedraw[66].SetActive(false); 
		cardRedraw[67].SetActive(false); 
		
	    cardRedraw[68].SetActive(false); 
        cardRedraw[69].SetActive(false); 
        cardRedraw[70].SetActive(false); 
        cardRedraw[71].SetActive(false); 
        
        cardRedraw[72].SetActive(false); 
        cardRedraw[73].SetActive(false); 
        cardRedraw[74].SetActive(false); 
        cardRedraw[75].SetActive(false); 
        
        cardRedraw[76].SetActive(false); 
        cardRedraw[77].SetActive(false); 
        cardRedraw[78].SetActive(false); 
        cardRedraw[79].SetActive(false); 
        
        cardRedraw[80].SetActive(false); 
        cardRedraw[81].SetActive(false); 
        cardRedraw[82].SetActive(false); 
        cardRedraw[83].SetActive(false); 
        
        cardRedraw[84].SetActive(false); 
        cardRedraw[85].SetActive(false); 
        cardRedraw[86].SetActive(false); 
        cardRedraw[87].SetActive(false); 
        
        cardRedraw[88].SetActive(false); 
        cardRedraw[89].SetActive(false); 
        cardRedraw[90].SetActive(false); 
        cardRedraw[91].SetActive(false); 
        
        cardRedraw[92].SetActive(false); 
        cardRedraw[93].SetActive(false); 
        cardRedraw[94].SetActive(false); 
        cardRedraw[95].SetActive(false); 
        
        cardRedraw[96].SetActive(false); 
        cardRedraw[97].SetActive(false); 
        cardRedraw[98].SetActive(false); 
        cardRedraw[99].SetActive(false); 
        
        cardRedraw[100].SetActive(false);
        cardRedraw[101].SetActive(false);
        cardRedraw[102].SetActive(false);
        cardRedraw[103].SetActive(false);
        
        cardRedraw[104].SetActive(false);
        cardRedraw[105].SetActive(false);
        cardRedraw[106].SetActive(false);
        cardRedraw[107].SetActive(false);
        
        cardRedraw[108].SetActive(false);
        cardRedraw[109].SetActive(false);
        cardRedraw[110].SetActive(false);
        cardRedraw[111].SetActive(false);
        
        cardRedraw[112].SetActive(false);
        cardRedraw[113].SetActive(false);
        cardRedraw[114].SetActive(false);
        cardRedraw[115].SetActive(false);
        
        cardRedraw[116].SetActive(false);
        cardRedraw[117].SetActive(false);
        cardRedraw[118].SetActive(false);
        cardRedraw[119].SetActive(false);
        
        cardRedraw[120].SetActive(false);
        cardRedraw[121].SetActive(false);
        cardRedraw[122].SetActive(false);
        cardRedraw[123].SetActive(false);
        
        cardRedraw[124].SetActive(false);
        cardRedraw[125].SetActive(false);
        cardRedraw[126].SetActive(false);
        cardRedraw[127].SetActive(false);
        
        cardRedraw[128].SetActive(false);
        cardRedraw[129].SetActive(false);
        cardRedraw[130].SetActive(false);
        cardRedraw[131].SetActive(false);
        
        cardRedraw[132].SetActive(false);
        cardRedraw[133].SetActive(false);
        cardRedraw[134].SetActive(false);
        cardRedraw[135].SetActive(false);
        
        cardRedraw[136].SetActive(false);
        cardRedraw[137].SetActive(false);
        cardRedraw[138].SetActive(false);
        cardRedraw[139].SetActive(false);
        
        cardRedraw[140].SetActive(false);
        cardRedraw[141].SetActive(false);
        cardRedraw[142].SetActive(false);
        cardRedraw[143].SetActive(false);
        
        cardRedraw[144].SetActive(false);
        cardRedraw[145].SetActive(false);
        cardRedraw[146].SetActive(false);
        cardRedraw[147].SetActive(false);
        
        cardRedraw[148].SetActive(false);
        cardRedraw[149].SetActive(false);
        cardRedraw[150].SetActive(false);
        cardRedraw[151].SetActive(false);
        
        cardRedraw[152].SetActive(false);
        cardRedraw[153].SetActive(false);
        cardRedraw[154].SetActive(false);
        cardRedraw[155].SetActive(false);
        
        cardRedraw[156].SetActive(false);
        cardRedraw[157].SetActive(false);
        cardRedraw[158].SetActive(false);
        cardRedraw[159].SetActive(false);
        
        cardRedraw[160].SetActive(false);
        cardRedraw[161].SetActive(false);
        cardRedraw[162].SetActive(false);
        cardRedraw[163].SetActive(false);
        
        cardRedraw[164].SetActive(false);
        cardRedraw[165].SetActive(false);
        cardRedraw[166].SetActive(false);
        cardRedraw[167].SetActive(false);
        
        cardRedraw[168].SetActive(false);
        cardRedraw[169].SetActive(false);
        cardRedraw[170].SetActive(false);
        cardRedraw[171].SetActive(false);
        
        cardRedraw[172].SetActive(false);
        cardRedraw[173].SetActive(false);
        cardRedraw[174].SetActive(false);
        cardRedraw[175].SetActive(false);
        
        cardRedraw[176].SetActive(false);
        cardRedraw[177].SetActive(false);
        cardRedraw[178].SetActive(false);
        cardRedraw[179].SetActive(false);
        
        cardRedraw[180].SetActive(false);
        cardRedraw[181].SetActive(false);
        cardRedraw[182].SetActive(false);
        cardRedraw[183].SetActive(false);
        
        cardRedraw[184].SetActive(false);
        cardRedraw[185].SetActive(false);
        cardRedraw[186].SetActive(false);
        cardRedraw[187].SetActive(false);
        
        cardRedraw[188].SetActive(false);
        cardRedraw[189].SetActive(false);
        cardRedraw[190].SetActive(false);
        cardRedraw[191].SetActive(false);
        
        cardRedraw[192].SetActive(false);
        cardRedraw[193].SetActive(false);
        cardRedraw[194].SetActive(false);
        cardRedraw[195].SetActive(false);
        
        cardRedraw[196].SetActive(false);
        cardRedraw[197].SetActive(false);
        cardRedraw[198].SetActive(false);
        cardRedraw[199].SetActive(false);
        
        cardRedraw[200].SetActive(false);
        cardRedraw[201].SetActive(false);
        cardRedraw[202].SetActive(false);
        cardRedraw[203].SetActive(false);
        
        cardRedraw[204].SetActive(false);
        cardRedraw[205].SetActive(false);
        cardRedraw[206].SetActive(false);
        cardRedraw[207].SetActive(false);
        
        cardRedraw[208].SetActive(false);
        cardRedraw[209].SetActive(false);
        cardRedraw[210].SetActive(false);
        cardRedraw[211].SetActive(false);
        
        cardRedraw[212].SetActive(false);
        cardRedraw[213].SetActive(false);
        cardRedraw[214].SetActive(false);
        cardRedraw[215].SetActive(false);
        
	    cardRedraw[216].SetActive(false);
	    cardRedraw[217].SetActive(false);
	    cardRedraw[218].SetActive(false);
	    cardRedraw[219].SetActive(false);
	    
	    cardRedraw[220].SetActive(false);
	    cardRedraw[221].SetActive(false);
	    cardRedraw[222].SetActive(false);
	    cardRedraw[223].SetActive(false);
	    
	    cardRedraw[224].SetActive(false);
	    cardRedraw[225].SetActive(false);
	    cardRedraw[226].SetActive(false);
	    cardRedraw[227].SetActive(false);
	    
	    cardRedraw[228].SetActive(false);
	    cardRedraw[229].SetActive(false);
	    cardRedraw[230].SetActive(false);
	    cardRedraw[231].SetActive(false);
	    
	    cardRedraw[232].SetActive(false);
	    cardRedraw[233].SetActive(false);
	    cardRedraw[234].SetActive(false);
	    cardRedraw[235].SetActive(false);
	    
	    cardRedraw[236].SetActive(false);
	    cardRedraw[237].SetActive(false);
	    cardRedraw[238].SetActive(false);
	    cardRedraw[239].SetActive(false);
	
	
	}
	
	
}

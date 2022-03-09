using UnityEngine;
using System.Collections;

public class Player1DeckSlotSpawnCard : MonoBehaviour {
	
	private int NumberOfCards;
	private GameObject[] cardsInDeck240 = new GameObject[240];
	private bool mulligan;
	//public Transform spawnPoint;
	
	private int instances1;
	private int instances2;
	private int instances3;
	private int instances4;
	private int instances5;
	private int instances6;
	private int instances7;
	private int instances8;
	private int instances9;
	private int instances10;
	
	private GameObject spawnPoints1;
	private GameObject spawnPoints2;
	private GameObject spawnPoints3;
	private GameObject spawnPoints4;
	private GameObject spawnPoints5;
	private GameObject spawnPoints6;
	private GameObject spawnPoints7;
	private GameObject spawnPoints8;
	private GameObject spawnPoints9;
	private GameObject spawnPoints10;
	
	
	void Awake(){
		
		cardsInDeck240[0] = GameObject.Find("Card1");
		cardsInDeck240[1] = GameObject.Find("Card1a");
		cardsInDeck240[2] = GameObject.Find("Card1b");
		cardsInDeck240[3] = GameObject.Find("Card1c");
		cardsInDeck240[4] = GameObject.Find("Card2");
		cardsInDeck240[5] = GameObject.Find("Card2a");
		cardsInDeck240[6] = GameObject.Find("Card2b");
		cardsInDeck240[7] = GameObject.Find("Card2c");
		cardsInDeck240[8] = GameObject.Find("Card3");
		cardsInDeck240[9] = GameObject.Find("Card3a");
		cardsInDeck240[10] = GameObject.Find("Card3b");
		cardsInDeck240[11] = GameObject.Find("Card3c");
		cardsInDeck240[12] = GameObject.Find("Card4");
		cardsInDeck240[13] = GameObject.Find("Card4a");
		cardsInDeck240[14] = GameObject.Find("Card4b");
		cardsInDeck240[15] = GameObject.Find("Card4c");
		cardsInDeck240[16] = GameObject.Find("Card5");
		cardsInDeck240[17] = GameObject.Find("Card5a");
		cardsInDeck240[18] = GameObject.Find("Card5b");
		cardsInDeck240[19] = GameObject.Find("Card5c");
		cardsInDeck240[20] = GameObject.Find("Card6");
		cardsInDeck240[21] = GameObject.Find("Card6a");
		cardsInDeck240[22] = GameObject.Find("Card6b");
		cardsInDeck240[23] = GameObject.Find("Card6c");
		cardsInDeck240[24] = GameObject.Find("Card7");
		cardsInDeck240[25] = GameObject.Find("Card7a");
		cardsInDeck240[26] = GameObject.Find("Card7b");
		cardsInDeck240[27] = GameObject.Find("Card7c");
		cardsInDeck240[28] = GameObject.Find("Card8");
		cardsInDeck240[29] = GameObject.Find("Card8a");
		cardsInDeck240[30] = GameObject.Find("Card8b");
		cardsInDeck240[31] = GameObject.Find("Card8c");
		cardsInDeck240[32] = GameObject.Find("Card9");
		cardsInDeck240[33] = GameObject.Find("Card9a");
		cardsInDeck240[34] = GameObject.Find("Card9b");
		cardsInDeck240[35] = GameObject.Find("Card9c");
		cardsInDeck240[36] = GameObject.Find("Card10");
		cardsInDeck240[37] = GameObject.Find("Card10a");
		cardsInDeck240[38] = GameObject.Find("Card10b");
		cardsInDeck240[39] = GameObject.Find("Card10c");
		cardsInDeck240[40] = GameObject.Find("Card11");
		cardsInDeck240[41] = GameObject.Find("Card11a");
		cardsInDeck240[42] = GameObject.Find("Card11b");
		cardsInDeck240[43] = GameObject.Find("Card11c");
		cardsInDeck240[44] = GameObject.Find("Card12");
		cardsInDeck240[45] = GameObject.Find("Card12a");
		cardsInDeck240[46] = GameObject.Find("Card12b");
		cardsInDeck240[47] = GameObject.Find("Card12c");
		cardsInDeck240[48] = GameObject.Find("Card13");
		cardsInDeck240[49] = GameObject.Find("Card13a");
		cardsInDeck240[50] = GameObject.Find("Card13b");
		cardsInDeck240[51] = GameObject.Find("Card13c");
		cardsInDeck240[52] = GameObject.Find("Card14");
		cardsInDeck240[53] = GameObject.Find("Card14a");
		cardsInDeck240[54] = GameObject.Find("Card14b");
		cardsInDeck240[55] = GameObject.Find("Card14c");
		cardsInDeck240[56] = GameObject.Find("Card15");
		cardsInDeck240[57] = GameObject.Find("Card15a");
		cardsInDeck240[58] = GameObject.Find("Card15b");
		cardsInDeck240[59] = GameObject.Find("Card15c");
		cardsInDeck240[60] = GameObject.Find("Card16");
		cardsInDeck240[61] = GameObject.Find("Card16a");
		cardsInDeck240[62] = GameObject.Find("Card16b");
		cardsInDeck240[63] = GameObject.Find("Card16c");
		cardsInDeck240[64] = GameObject.Find("Card17");
		cardsInDeck240[65] = GameObject.Find("Card17a");
		cardsInDeck240[66] = GameObject.Find("Card17b");
		cardsInDeck240[67] = GameObject.Find("Card17c");
		cardsInDeck240[68] = GameObject.Find("Card18");
		cardsInDeck240[69] = GameObject.Find("Card18a");
		cardsInDeck240[70] = GameObject.Find("Card18b");
		cardsInDeck240[71] = GameObject.Find("Card18c");
		cardsInDeck240[72] = GameObject.Find("Card19");
		cardsInDeck240[73] = GameObject.Find("Card19a");
		cardsInDeck240[74] = GameObject.Find("Card19b");
		cardsInDeck240[75] = GameObject.Find("Card19c");
		cardsInDeck240[76] = GameObject.Find("Card20");
		cardsInDeck240[77] = GameObject.Find("Card20a");
		cardsInDeck240[78] = GameObject.Find("Card20b");
		cardsInDeck240[79] = GameObject.Find("Card20c");
		cardsInDeck240[80] = GameObject.Find("Card21");
		cardsInDeck240[81] = GameObject.Find("Card21a");
		cardsInDeck240[82] = GameObject.Find("Card21b");
		cardsInDeck240[83] = GameObject.Find("Card21c");
		cardsInDeck240[84] = GameObject.Find("Card22");
		cardsInDeck240[85] = GameObject.Find("Card22a");
		cardsInDeck240[86] = GameObject.Find("Card22b");
		cardsInDeck240[87] = GameObject.Find("Card22c");
		cardsInDeck240[88] = GameObject.Find("Card23");
		cardsInDeck240[89] = GameObject.Find("Card23a");
		cardsInDeck240[90] = GameObject.Find("Card23b");
		cardsInDeck240[91] = GameObject.Find("Card23c");
		cardsInDeck240[92] = GameObject.Find("Card24");
		cardsInDeck240[93] = GameObject.Find("Card24a");
		cardsInDeck240[94] = GameObject.Find("Card24b");
		cardsInDeck240[95] = GameObject.Find("Card24c");
		cardsInDeck240[96] = GameObject.Find("Card25");
		cardsInDeck240[97] = GameObject.Find("Card25a");
		cardsInDeck240[98] = GameObject.Find("Card25b");
		cardsInDeck240[99] = GameObject.Find("Card25c");
		cardsInDeck240[100] = GameObject.Find("Card26");
		cardsInDeck240[101] = GameObject.Find("Card26a");
		cardsInDeck240[102] = GameObject.Find("Card26b");
		cardsInDeck240[103] = GameObject.Find("Card26c");
		cardsInDeck240[104] = GameObject.Find("Card27");
		cardsInDeck240[105] = GameObject.Find("Card27a");
		cardsInDeck240[106] = GameObject.Find("Card27b");
		cardsInDeck240[107] = GameObject.Find("Card27c");
		cardsInDeck240[108] = GameObject.Find("Card28");
		cardsInDeck240[109] = GameObject.Find("Card28a");
		cardsInDeck240[110] = GameObject.Find("Card28b");
		cardsInDeck240[111] = GameObject.Find("Card28c");
		cardsInDeck240[112] = GameObject.Find("Card29");
		cardsInDeck240[113] = GameObject.Find("Card29a");
		cardsInDeck240[114] = GameObject.Find("Card29b");
		cardsInDeck240[115] = GameObject.Find("Card29c");
		cardsInDeck240[116] = GameObject.Find("Card30");
		cardsInDeck240[117] = GameObject.Find("Card30a");
		cardsInDeck240[118] = GameObject.Find("Card30b");
		cardsInDeck240[119] = GameObject.Find("Card30c");
		cardsInDeck240[120] = GameObject.Find("Card31");
		cardsInDeck240[121] = GameObject.Find("Card31a");
		cardsInDeck240[122] = GameObject.Find("Card31b");
		cardsInDeck240[123] = GameObject.Find("Card31c");
		cardsInDeck240[124] = GameObject.Find("Card32");
		cardsInDeck240[125] = GameObject.Find("Card32a");
		cardsInDeck240[126] = GameObject.Find("Card32b");
		cardsInDeck240[127] = GameObject.Find("Card32c");
		cardsInDeck240[128] = GameObject.Find("Card33");
		cardsInDeck240[129] = GameObject.Find("Card33a");
		cardsInDeck240[130] = GameObject.Find("Card33b");
		cardsInDeck240[131] = GameObject.Find("Card33c");
		cardsInDeck240[132] = GameObject.Find("Card34");
		cardsInDeck240[133] = GameObject.Find("Card34a");
		cardsInDeck240[134] = GameObject.Find("Card34b");
		cardsInDeck240[135] = GameObject.Find("Card34c");
		cardsInDeck240[136] = GameObject.Find("Card35");
		cardsInDeck240[137] = GameObject.Find("Card35a");
		cardsInDeck240[138] = GameObject.Find("Card35b");
		cardsInDeck240[139] = GameObject.Find("Card35c");
		cardsInDeck240[140] = GameObject.Find("Card36");
		cardsInDeck240[141] = GameObject.Find("Card36a");
		cardsInDeck240[142] = GameObject.Find("Card36b");
		cardsInDeck240[143] = GameObject.Find("Card36c");
		cardsInDeck240[144] = GameObject.Find("Card37");
		cardsInDeck240[145] = GameObject.Find("Card37a");
		cardsInDeck240[146] = GameObject.Find("Card37b");
		cardsInDeck240[147] = GameObject.Find("Card37c");
		cardsInDeck240[148] = GameObject.Find("Card38");
		cardsInDeck240[149] = GameObject.Find("Card38a");
		cardsInDeck240[150] = GameObject.Find("Card38b");
		cardsInDeck240[151] = GameObject.Find("Card38c");
		cardsInDeck240[152] = GameObject.Find("Card39");
		cardsInDeck240[153] = GameObject.Find("Card39a");
		cardsInDeck240[154] = GameObject.Find("Card39b");
		cardsInDeck240[155] = GameObject.Find("Card39c");
		cardsInDeck240[156] = GameObject.Find("Card40");
		cardsInDeck240[157] = GameObject.Find("Card40a");
		cardsInDeck240[158] = GameObject.Find("Card40b");
		cardsInDeck240[159] = GameObject.Find("Card40c");
		cardsInDeck240[160] = GameObject.Find("Card41");
		cardsInDeck240[161] = GameObject.Find("Card41a");
		cardsInDeck240[162] = GameObject.Find("Card41b");
		cardsInDeck240[163] = GameObject.Find("Card41c");
		cardsInDeck240[164] = GameObject.Find("Card42");
		cardsInDeck240[165] = GameObject.Find("Card42a");
		cardsInDeck240[166] = GameObject.Find("Card42b");
		cardsInDeck240[167] = GameObject.Find("Card42c");
		cardsInDeck240[168] = GameObject.Find("Card43");
		cardsInDeck240[169] = GameObject.Find("Card43a");
		cardsInDeck240[170] = GameObject.Find("Card43b");
		cardsInDeck240[171] = GameObject.Find("Card43c");
		cardsInDeck240[172] = GameObject.Find("Card44");
		cardsInDeck240[173] = GameObject.Find("Card44a");
		cardsInDeck240[174] = GameObject.Find("Card44b");
		cardsInDeck240[175] = GameObject.Find("Card44c");
		cardsInDeck240[176] = GameObject.Find("Card45");
		cardsInDeck240[177] = GameObject.Find("Card45a");
		cardsInDeck240[178] = GameObject.Find("Card45b");
		cardsInDeck240[179] = GameObject.Find("Card45c");
		cardsInDeck240[180] = GameObject.Find("Card46");
		cardsInDeck240[181] = GameObject.Find("Card46a");
		cardsInDeck240[182] = GameObject.Find("Card46b");
		cardsInDeck240[183] = GameObject.Find("Card46c");
		cardsInDeck240[184] = GameObject.Find("Card47");
		cardsInDeck240[185] = GameObject.Find("Card47a");
		cardsInDeck240[186] = GameObject.Find("Card47b");
		cardsInDeck240[187] = GameObject.Find("Card47c");
		cardsInDeck240[188] = GameObject.Find("Card48");
		cardsInDeck240[189] = GameObject.Find("Card48a");
		cardsInDeck240[190] = GameObject.Find("Card48b");
		cardsInDeck240[191] = GameObject.Find("Card48c");
		cardsInDeck240[192] = GameObject.Find("Card49");
		cardsInDeck240[193] = GameObject.Find("Card49a");
		cardsInDeck240[194] = GameObject.Find("Card49b");
		cardsInDeck240[195] = GameObject.Find("Card49c");
		cardsInDeck240[196] = GameObject.Find("Card50");
		cardsInDeck240[197] = GameObject.Find("Card50a");
		cardsInDeck240[198] = GameObject.Find("Card50b");
		cardsInDeck240[199] = GameObject.Find("Card50c");
		cardsInDeck240[200] = GameObject.Find("Card51");
		cardsInDeck240[201] = GameObject.Find("Card51a");
		cardsInDeck240[202] = GameObject.Find("Card51b");
		cardsInDeck240[203] = GameObject.Find("Card51c");
		cardsInDeck240[204] = GameObject.Find("Card52");
		cardsInDeck240[205] = GameObject.Find("Card52a");
		cardsInDeck240[206] = GameObject.Find("Card52b");
		cardsInDeck240[207] = GameObject.Find("Card52c");
		cardsInDeck240[208] = GameObject.Find("Card53");
		cardsInDeck240[209] = GameObject.Find("Card53a");
		cardsInDeck240[210] = GameObject.Find("Card53b");
		cardsInDeck240[211] = GameObject.Find("Card53c");
		cardsInDeck240[212] = GameObject.Find("Card54");
		cardsInDeck240[213] = GameObject.Find("Card54a");
		cardsInDeck240[214] = GameObject.Find("Card54b");
		cardsInDeck240[215] = GameObject.Find("Card54c");
		cardsInDeck240[216] = GameObject.Find("Card55");
		cardsInDeck240[217] = GameObject.Find("Card55a");
		cardsInDeck240[218] = GameObject.Find("Card55b");
		cardsInDeck240[219] = GameObject.Find("Card55c");
		cardsInDeck240[220] = GameObject.Find("Card56");
		cardsInDeck240[221] = GameObject.Find("Card56a");
		cardsInDeck240[222] = GameObject.Find("Card56b");
		cardsInDeck240[223] = GameObject.Find("Card56c");
		cardsInDeck240[224] = GameObject.Find("Card57");
		cardsInDeck240[225] = GameObject.Find("Card57a");
		cardsInDeck240[226] = GameObject.Find("Card57b");
		cardsInDeck240[227] = GameObject.Find("Card57c");
		cardsInDeck240[228] = GameObject.Find("Card58");
		cardsInDeck240[229] = GameObject.Find("Card58a");
		cardsInDeck240[230] = GameObject.Find("Card58b");
		cardsInDeck240[231] = GameObject.Find("Card58c");
		cardsInDeck240[232] = GameObject.Find("Card59");
		cardsInDeck240[233] = GameObject.Find("Card59a");
		cardsInDeck240[234] = GameObject.Find("Card59b");
		cardsInDeck240[235] = GameObject.Find("Card59c");
		cardsInDeck240[236] = GameObject.Find("Card60");
		cardsInDeck240[237] = GameObject.Find("Card60a");
		cardsInDeck240[238] = GameObject.Find("Card60b");
		cardsInDeck240[239] = GameObject.Find("Card60c");
		
		spawnPoints1 = GameObject.Find("Player1DeckSlot1");
		spawnPoints2 = GameObject.Find("Player1DeckSlot2");
		spawnPoints3 = GameObject.Find("Player1DeckSlot3");
		spawnPoints4 = GameObject.Find("Player1DeckSlot4");
		spawnPoints5 = GameObject.Find("Player1DeckSlot5");
		spawnPoints6 = GameObject.Find("Player1DeckSlot6");
		spawnPoints7 = GameObject.Find("Player1DeckSlot7");
		spawnPoints8 = GameObject.Find("Player1DeckSlot8");
		spawnPoints9 = GameObject.Find("Player1DeckSlot9");
		spawnPoints10 = GameObject.Find("Player1DeckSlot10");
	}
	
	// Use this for initialization
	void Start () {
		mulligan = true;
		
		NumberOfCards = 1;
		
		instances1 = 0;
		instances2 = 0;
		instances3 = 0;
		instances4 = 0;
		instances5 = 0;
		instances6 = 0;
		instances7 = 0;
		instances8 = 0;
		instances9 = 0;
		instances10 = 0;
		
		
		
		
	
	}
	
	// Update is called once per frame
	void Update () {
		
	
	}
	
	public void CreateRandomDeck(){
		
		while(instances1 < NumberOfCards) {
			
			GameObject card = Instantiate (cardsInDeck240[Random.Range(0,cardsInDeck240.Length)], spawnPoints1.transform.position,spawnPoints1.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(325f,200f,340.0f);
			//card.name = "instantiatedRandomCard";
			
			if(card.name == "Card1(Clone)"){
				
				card.name = "instantiatedRandomCard1";
				
			}else if(card.name == "Card1a(Clone)"){
				
				card.name = "instantiatedRandomCard1a";
				
			}else if(card.name == "Card1b(Clone)"){
				
				card.name = "instantiatedRandomCard1b";
				
			}else if(card.name == "Card1c(Clone)"){
				
				card.name = "instantiatedRandomCard1c";
				
			}else if(card.name == "Card2(Clone)"){
				
				card.name = "instantiatedRandomCard2";
				
			}else if(card.name == "Card2a(Clone)"){
				
				card.name = "instantiatedRandomCard2a";
				
			}else if(card.name == "Card2b(Clone)"){
				
				card.name = "instantiatedRandomCard2b";
				
			}else if(card.name == "Card2c(Clone)"){
				
				card.name = "instantiatedRandomCard2c";
				
			}else if(card.name == "Card3(Clone)"){
				
				card.name = "instantiatedRandomCard3";
				
			}else if(card.name == "Card3a(Clone)"){
				
				card.name = "instantiatedRandomCard3a";
				
			}else if(card.name == "Card3b(Clone)"){
				
				card.name = "instantiatedRandomCard3b";
				
			}else if(card.name == "Card3c(Clone)"){
				
				card.name = "instantiatedRandomCard3c";
				
			}else if(card.name == "Card4(Clone)"){
				
				card.name = "instantiatedRandomCard4";
				
			}else if(card.name == "Card4a(Clone)"){
				
				card.name = "instantiatedRandomCard4a";
				
			}else if(card.name == "Card4b(Clone)"){
				
				card.name = "instantiatedRandomCard4b";
				
			}else if(card.name == "Card4c(Clone)"){
				
				card.name = "instantiatedRandomCard4c";
				
			}else if(card.name == "Card5(Clone)"){
				
				card.name = "instantiatedRandomCard5";
				
			}else if(card.name == "Card5a(Clone)"){
				
				card.name = "instantiatedRandomCard5a";
				
			}else if(card.name == "Card5b(Clone)"){
				
				card.name = "instantiatedRandomCard5b";
				
			}else if(card.name == "Card5c(Clone)"){
				
				card.name = "instantiatedRandomCard5c";
				
			}else if(card.name == "Card6(Clone)"){
				
				card.name = "instantiatedRandomCard6";
				
			}else if(card.name == "Card6a(Clone)"){
				
				card.name = "instantiatedRandomCard6a";
				
			}else if(card.name == "Card6b(Clone)"){
				
				card.name = "instantiatedRandomCard6b";
				
			}else if(card.name == "Card6c(Clone)"){
				
				card.name = "instantiatedRandomCard6c";
				
			}else if(card.name == "Card7(Clone)"){
				
				card.name = "instantiatedRandomCard7";
				
			}else if(card.name == "Card7a(Clone)"){
				
				card.name = "instantiatedRandomCard7a";
				
			}else if(card.name == "Card7b(Clone)"){
				
				card.name = "instantiatedRandomCard7b";
				
			}else if(card.name == "Card7c(Clone)"){
				
				card.name = "instantiatedRandomCard7c";
				
			}else if(card.name == "Card8(Clone)"){
				
				card.name = "instantiatedRandomCard8";
				
			}else if(card.name == "Card8a(Clone)"){
				
				card.name = "instantiatedRandomCard8a";
				
			}else if(card.name == "Card8b(Clone)"){
				
				card.name = "instantiatedRandomCard8b";
				
			}else if(card.name == "Card8c(Clone)"){
				
				card.name = "instantiatedRandomCard8c";
				
			}else if(card.name == "Card9(Clone)"){
				
				card.name = "instantiatedRandomCard9";
				
			}else if(card.name == "Card9a(Clone)"){
				
				card.name = "instantiatedRandomCard9a";
				
			}else if(card.name == "Card9b(Clone)"){
				
				card.name = "instantiatedRandomCard9b";
				
			}else if(card.name == "Card9c(Clone)"){
				
				card.name = "instantiatedRandomCard9c";
				
			}else if(card.name == "Card10(Clone)"){
				
				card.name = "instantiatedAICard10";
				
			}else if(card.name == "Card10a(Clone)"){
				
				card.name = "instantiatedRandomCard10a";
				
			}else if(card.name == "Card10b(Clone)"){
				
				card.name = "instantiatedRandomCard10b";
				
			}else if(card.name == "Card10c(Clone)"){
				
				card.name = "instantiatedRandomCard10c";
				
			}else if(card.name == "Card11(Clone)"){
				
				card.name = "instantiatedRandomCard11";
				
			}else if(card.name == "Card11a(Clone)"){
				
				card.name = "instantiatedRandomCard11a";
				
			}else if(card.name == "Card11b(Clone)"){
				
				card.name = "instantiatedRandomCard11b";
				
			}else if(card.name == "Card11c(Clone)"){
				
				card.name = "instantiatedRandomCard11c";
				
			}else if(card.name == "Card12(Clone)"){
				
				card.name = "instantiatedRandomCard12";
				
			}else if(card.name == "Card12a(Clone)"){
				
				card.name = "instantiatedRandomCard12a";
				
			}else if(card.name == "Card12b(Clone)"){
				
				card.name = "instantiatedRandomCard12b";
				
			}else if(card.name == "Card12c(Clone)"){
				
				card.name = "instantiatedRandomCard12c";
				
			}else if(card.name == "Card13(Clone)"){
				
				card.name = "instantiatedRandomCard13";
				
			}else if(card.name == "Card13a(Clone)"){
				
				card.name = "instantiatedRandomCard13a";
				
			}else if(card.name == "Card13b(Clone)"){
				
				card.name = "instantiatedRandomCard13b";
				
			}else if(card.name == "Card13c(Clone)"){
				
				card.name = "instantiatedRandomCard13c";
				
			}else if(card.name == "Card14(Clone)"){
				
				card.name = "instantiatedRandomCard14";
				
			}else if(card.name == "Card14a(Clone)"){
				
				card.name = "instantiatedRandomCard14a";
				
			}else if(card.name == "Card14b(Clone)"){
				
				card.name = "instantiatedRandomCard14b";
				
			}else if(card.name == "Card14c(Clone)"){
				
				card.name = "instantiatedRandomCard14c";
				
			}else if(card.name == "Card15(Clone)"){
				
				card.name = "instantiatedRandomCard15";
				
			}else if(card.name == "Card15a(Clone)"){
				
				card.name = "instantiatedRandomCard15a";
				
			}else if(card.name == "Card15b(Clone)"){
				
				card.name = "instantiatedRandomCard15b";
				
			}else if(card.name == "Card15c(Clone)"){
				
				card.name = "instantiatedRandomCard15c";
				
			}else if(card.name == "Card16(Clone)"){
				
				card.name = "instantiatedRandomCard16";
				
			}else if(card.name == "Card16a(Clone)"){
				
				card.name = "instantiatedRandomCard16a";
				
			}else if(card.name == "Card16b(Clone)"){
				
				card.name = "instantiatedRandomCard16b";
				
			}else if(card.name == "Card16c(Clone)"){
				
				card.name = "instantiatedRandomCard16c";
				
			}else if(card.name == "Card17(Clone)"){
				
				card.name = "instantiatedRandomCard17";
				
			}else if(card.name == "Card17a(Clone)"){
				
				card.name = "instantiatedRandomCard17a";
				
			}else if(card.name == "Card17b(Clone)"){
				
				card.name = "instantiatedRandomCard17b";
				
			}else if(card.name == "Card17c(Clone)"){
				
				card.name = "instantiatedRandomCard17c";
				
			}else if(card.name == "Card18(Clone)"){
				
				card.name = "instantiatedRandomCard18";
				
			}else if(card.name == "Card18a(Clone)"){
				
				card.name = "instantiatedRandomCard18a";
				
			}else if(card.name == "Card18b(Clone)"){
				
				card.name = "instantiatedRandomCard18b";
				
			}else if(card.name == "Card18c(Clone)"){
				
				card.name = "instantiatedRandomCard18c";
				
			}else if(card.name == "Card19(Clone)"){
				
				card.name = "instantiatedRandomCard19";
				
			}else if(card.name == "Card19a(Clone)"){
				
				card.name = "instantiatedRandomCard19a";
				
			}else if(card.name == "Card19b(Clone)"){
				
				card.name = "instantiatedRandomCard19b";
				
			}else if(card.name == "Card19c(Clone)"){
				
				card.name = "instantiatedRandomCard19c";
				
			}else if(card.name == "Card20(Clone)"){
				
				card.name = "instantiatedRandomCard20";
				
			}else if(card.name == "Card20a(Clone)"){
				
				card.name = "instantiatedRandomCard20a";
				
			}else if(card.name == "Card20b(Clone)"){
				
				card.name = "instantiatedRandomCard20b";
				
			}else if(card.name == "Card20c(Clone)"){
				
				card.name = "instantiatedRandomCard20c";
				
			}else if(card.name == "Card21(Clone)"){
				
				card.name = "instantiatedRandomCard21";
				
			}else if(card.name == "Card21a(Clone)"){
				
				card.name = "instantiatedRandomCard21a";
				
			}else if(card.name == "Card21b(Clone)"){
				
				card.name = "instantiatedRandomCard21b";
				
			}else if(card.name == "Card21c(Clone)"){
				
				card.name = "instantiatedRandomCard21c";
				
			}else if(card.name == "Card22(Clone)"){
				
				card.name = "instantiatedRandomCard22";
				
			}else if(card.name == "Card22a(Clone)"){
				
				card.name = "instantiatedRandomCard22a";
				
			}else if(card.name == "Card22b(Clone)"){
				
				card.name = "instantiatedRandomCard22b";
				
			}else if(card.name == "Card22c(Clone)"){
				
				card.name = "instantiatedRandomCard22c";
				
			}else if(card.name == "Card23(Clone)"){
				
				card.name = "instantiatedRandomCard23";
				
			}else if(card.name == "Card23a(Clone)"){
				
				card.name = "instantiatedRandomCard23a";
				
			}else if(card.name == "Card23b(Clone)"){
				
				card.name = "instantiatedRandomCard23b";
				
			}else if(card.name == "Card23c(Clone)"){
				
				card.name = "instantiatedRandomCard23c";
				
			}else if(card.name == "Card24(Clone)"){
				
				card.name = "instantiatedRandomCard24";
				
			}else if(card.name == "Card24a(Clone)"){
				
				card.name = "instantiatedRandomCard24a";
				
			}else if(card.name == "Card24b(Clone)"){
				
				card.name = "instantiatedRandomCard24b";
				
			}else if(card.name == "Card24c(Clone)"){
				
				card.name = "instantiatedRandomCard24c";
				
			}else if(card.name == "Card25(Clone)"){
				
				card.name = "instantiatedRandomCard25";
				
			}else if(card.name == "Card25a(Clone)"){
				
				card.name = "instantiatedRandomCard25a";
				
			}else if(card.name == "Card25b(Clone)"){
				
				card.name = "instantiatedRandomCard25b";
				
			}else if(card.name == "Card25c(Clone)"){
				
				card.name = "instantiatedRandomCard25c";
				
			}else if(card.name == "Card26(Clone)"){
				
				card.name = "instantiatedRandomCard26";
				
			}else if(card.name == "Card26a(Clone)"){
				
				card.name = "instantiatedRandomCard26a";
				
			}else if(card.name == "Card26b(Clone)"){
				
				card.name = "instantiatedRandomCard26b";
				
			}else if(card.name == "Card26c(Clone)"){
				
				card.name = "instantiatedRandomCard26c";
				
			}else if(card.name == "Card27(Clone)"){
				
				card.name = "instantiatedRandomCard27";
				
			}else if(card.name == "Card27a(Clone)"){
				
				card.name = "instantiatedRandomCard27a";
				
			}else if(card.name == "Card27b(Clone)"){
				
				card.name = "instantiatedRandomCard27b";
				
			}else if(card.name == "Card27c(Clone)"){
				
				card.name = "instantiatedRandomCard27c";
				
			}else if(card.name == "Card28(Clone)"){
				
				card.name = "instantiatedRandomCard28";
				
			}else if(card.name == "Card28a(Clone)"){
				
				card.name = "instantiatedRandomCard28a";
				
			}else if(card.name == "Card28b(Clone)"){
				
				card.name = "instantiatedRandomCard28b";
				
			}else if(card.name == "Card28c(Clone)"){
				
				card.name = "instantiatedRandomCard28c";
				
			}else if(card.name == "Card29(Clone)"){
				
				card.name = "instantiatedRandomCard29";
				
			}else if(card.name == "Card29a(Clone)"){
				
				card.name = "instantiatedRandomCard29a";
				
			}else if(card.name == "Card29b(Clone)"){
				
				card.name = "instantiatedRandomCard29b";
				
			}else if(card.name == "Card29c(Clone)"){
				
				card.name = "instantiatedRandomCard29c";
				
			}else if(card.name == "Card30(Clone)"){
				
				card.name = "instantiatedRandomCard30";
				
			}else if(card.name == "Card30a(Clone)"){
				
				card.name = "instantiatedRandomCard30a";
				
			}else if(card.name == "Card30b(Clone)"){
				
				card.name = "instantiatedRandomCard30b";
				
			}else if(card.name == "Card30c(Clone)"){
				
				card.name = "instantiatedRandomCard30c";
				
			}else if(card.name == "Card31(Clone)"){
				
				card.name = "instantiatedRandomCard31";
				
			}else if(card.name == "Card31a(Clone)"){
				
				card.name = "instantiatedRandomCard31a";
				
			}else if(card.name == "Card31b(Clone)"){
				
				card.name = "instantiatedRandomCard31b";
				
			}else if(card.name == "Card31c(Clone)"){
				
				card.name = "instantiatedRandomCard31c";
				
			}else if(card.name == "Card32(Clone)"){
				
				card.name = "instantiatedRandomCard32";
				
			}else if(card.name == "Card32a(Clone)"){
				
				card.name = "instantiatedRandomCard32a";
				
			}else if(card.name == "Card32b(Clone)"){
				
				card.name = "instantiatedRandomCard32b";
				
			}else if(card.name == "Card32c(Clone)"){
				
				card.name = "instantiatedRandomCard32c";
				
			}else if(card.name == "Card33(Clone)"){
				
				card.name = "instantiatedRandomCard33";
				
			}else if(card.name == "Card33a(Clone)"){
				
				card.name = "instantiatedRandomCard33a";
				
			}else if(card.name == "Card33b(Clone)"){
				
				card.name = "instantiatedRandomCard33b";
				
			}else if(card.name == "Card33c(Clone)"){
				
				card.name = "instantiatedRandomCard33c";
				
			}else if(card.name == "Card34(Clone)"){
				
				card.name = "instantiatedRandomCard34";
				
			}else if(card.name == "Card34a(Clone)"){
				
				card.name = "instantiatedRandomCard34a";
				
			}else if(card.name == "Card34b(Clone)"){
				
				card.name = "instantiatedRandomCard34b";
				
			}else if(card.name == "Card34c(Clone)"){
				
				card.name = "instantiatedRandomCard34c";
				
			}else if(card.name == "Card35(Clone)"){
				
				card.name = "instantiatedRandomCard35";
				
			}else if(card.name == "Card35a(Clone)"){
				
				card.name = "instantiatedRandomCard35a";
				
			}else if(card.name == "Card35b(Clone)"){
				
				card.name = "instantiatedRandomCard35b";
				
			}else if(card.name == "Card35c(Clone)"){
				
				card.name = "instantiatedRandomCard35c";
				
			}else if(card.name == "Card36(Clone)"){
				
				card.name = "instantiatedRandomCard36";
				
			}else if(card.name == "Card36a(Clone)"){
				
				card.name = "instantiatedRandomCard36a";
				
			}else if(card.name == "Card36b(Clone)"){
				
				card.name = "instantiatedRandomCard36b";
				
			}else if(card.name == "Card36c(Clone)"){
				
				card.name = "instantiatedRandomCard36c";
				
			}else if(card.name == "Card37(Clone)"){
				
				card.name = "instantiatedRandomCard37";
				
			}else if(card.name == "Card37a(Clone)"){
				
				card.name = "instantiatedRandomCard37a";
				
			}else if(card.name == "Card37b(Clone)"){
				
				card.name = "instantiatedRandomCard37b";
				
			}else if(card.name == "Card37c(Clone)"){
				
				card.name = "instantiatedRandomCard37c";
				
			}else if(card.name == "Card38(Clone)"){
				
				card.name = "instantiatedRandomCard38";
				
			}else if(card.name == "Card38a(Clone)"){
				
				card.name = "instantiatedRandomCard38a";
				
			}else if(card.name == "Card38b(Clone)"){
				
				card.name = "instantiatedRandomCard38b";
				
			}else if(card.name == "Card38c(Clone)"){
				
				card.name = "instantiatedRandomCard38c";
				
			}else if(card.name == "Card39(Clone)"){
				
				card.name = "instantiatedRandomCard39";
				
			}else if(card.name == "Card39a(Clone)"){
				
				card.name = "instantiatedRandomCard39a";
				
			}else if(card.name == "Card39b(Clone)"){
				
				card.name = "instantiatedRandomCard39b";
				
			}else if(card.name == "Card39c(Clone)"){
				
				card.name = "instantiatedRandomCard39c";
				
			}else if(card.name == "Card40(Clone)"){
				
				card.name = "instantiatedRandomCard40";
				
			}else if(card.name == "Card40a(Clone)"){
				
				card.name = "instantiatedRandomCard40a";
				
			}else if(card.name == "Card40b(Clone)"){
				
				card.name = "instantiatedRandomCard40b";
				
			}else if(card.name == "Card40c(Clone)"){
				
				card.name = "instantiatedRandomCard40c";
				
			}else if(card.name == "Card41(Clone)"){
				
				card.name = "instantiatedRandomCard41";
				
			}else if(card.name == "Card41a(Clone)"){
				
				card.name = "instantiatedRandomCard41a";
				
			}else if(card.name == "Card41b(Clone)"){
				
				card.name = "instantiatedRandomCard41b";
				
			}else if(card.name == "Card41c(Clone)"){
				
				card.name = "instantiatedRandomCard41c";
				
			}else if(card.name == "Card42(Clone)"){
				
				card.name = "instantiatedRandomCard42";
				
			}else if(card.name == "Card42a(Clone)"){
				
				card.name = "instantiatedRandomCard42a";
				
			}else if(card.name == "Card42b(Clone)"){
				
				card.name = "instantiatedRandomCard42b";
				
			}else if(card.name == "Card42c(Clone)"){
				
				card.name = "instantiatedRandomCard42c";
				
			}else if(card.name == "Card43(Clone)"){
				
				card.name = "instantiatedRandomCard43";
				
			}else if(card.name == "Card43a(Clone)"){
				
				card.name = "instantiatedRandomCard43a";
				
			}else if(card.name == "Card43b(Clone)"){
				
				card.name = "instantiatedRandomCard43b";
				
			}else if(card.name == "Card43c(Clone)"){
				
				card.name = "instantiatedRandomCard43c";
				
			}else if(card.name == "Card44(Clone)"){
				
				card.name = "instantiatedRandomCard44";
				
			}else if(card.name == "Card44a(Clone)"){
				
				card.name = "instantiatedRandomCard44a";
				
			}else if(card.name == "Card44b(Clone)"){
				
				card.name = "instantiatedRandomCard44b";
				
			}else if(card.name == "Card44c(Clone)"){
				
				card.name = "instantiatedRandomCard44c";
				
			}else if(card.name == "Card45(Clone)"){
				
				card.name = "instantiatedRandomCard45";
				
			}else if(card.name == "Card45a(Clone)"){
				
				card.name = "instantiatedRandomCard45a";
				
			}else if(card.name == "Card45b(Clone)"){
				
				card.name = "instantiatedRandomCard45b";
				
			}else if(card.name == "Card45c(Clone)"){
				
				card.name = "instantiatedRandomCard45c";
				
			}else if(card.name == "Card46(Clone)"){
				
				card.name = "instantiatedRandomCard46";
				
			}else if(card.name == "Card46a(Clone)"){
				
				card.name = "instantiatedRandomCard46a";
				
			}else if(card.name == "Card46b(Clone)"){
				
				card.name = "instantiatedRandomCard46b";
				
			}else if(card.name == "Card46c(Clone)"){
				
				card.name = "instantiatedRandomCard46c";
				
			}else if(card.name == "Card47(Clone)"){
				
				card.name = "instantiatedRandomCard47";
				
			}else if(card.name == "Card47a(Clone)"){
				
				card.name = "instantiatedRandomCard47a";
				
			}else if(card.name == "Card47b(Clone)"){
				
				card.name = "instantiatedRandomCard47b";
				
			}else if(card.name == "Card47c(Clone)"){
				
				card.name = "instantiatedRandomCard47c";
				
			}else if(card.name == "Card48(Clone)"){
				
				card.name = "instantiatedRandomCard48";
				
			}else if(card.name == "Card48a(Clone)"){
				
				card.name = "instantiatedRandomCard48a";
				
			}else if(card.name == "Card48b(Clone)"){
				
				card.name = "instantiatedRandomCard48b";
				
			}else if(card.name == "Card48c(Clone)"){
				
				card.name = "instantiatedRandomCard48c";
				
			}else if(card.name == "Card49(Clone)"){
				
				card.name = "instantiatedRandomCard49";
				
			}else if(card.name == "Card49a(Clone)"){
				
				card.name = "instantiatedRandomCard49a";
				
			}else if(card.name == "Card49b(Clone)"){
				
				card.name = "instantiatedRandomCard49b";
				
			}else if(card.name == "Card49c(Clone)"){
				
				card.name = "instantiatedRandomCard49c";
				
			}else if(card.name == "Card50(Clone)"){
				
				card.name = "instantiatedRandomCard50";
				
			}else if(card.name == "Card50a(Clone)"){
				
				card.name = "instantiatedRandomCard50a";
				
			}else if(card.name == "Card50b(Clone)"){
				
				card.name = "instantiatedRandomCard50b";
				
			}else if(card.name == "Card50c(Clone)"){
				
				card.name = "instantiatedRandomCard50c";
				
			}else if(card.name == "Card51(Clone)"){
				
				card.name = "instantiatedRandomCard51";
				
			}else if(card.name == "Card51a(Clone)"){
				
				card.name = "instantiatedRandomCard51a";
				
			}else if(card.name == "Card51b(Clone)"){
				
				card.name = "instantiatedRandomCard51b";
				
			}else if(card.name == "Card51c(Clone)"){
				
				card.name = "instantiatedRandomCard51c";
				
			}else if(card.name == "Card52(Clone)"){
				
				card.name = "instantiatedRandomCard52";
				
			}else if(card.name == "Card52a(Clone)"){
				
				card.name = "instantiatedRandomCard52a";
				
			}else if(card.name == "Card52b(Clone)"){
				
				card.name = "instantiatedRandomCard52b";
				
			}else if(card.name == "Card52c(Clone)"){
				
				card.name = "instantiatedRandomCard52c";
				
			}else if(card.name == "Card53(Clone)"){
				
				card.name = "instantiatedRandomCard53";
				
			}else if(card.name == "Card53a(Clone)"){
				
				card.name = "instantiatedRandomCard53a";
				
			}else if(card.name == "Card53b(Clone)"){
				
				card.name = "instantiatedRandomCard53b";
				
			}else if(card.name == "Card53c(Clone)"){
				
				card.name = "instantiatedRandomCard53c";
				
			}else if(card.name == "Card54(Clone)"){
				
				card.name = "instantiatedRandomCard54";
				
			}else if(card.name == "Card54a(Clone)"){
				
				card.name = "instantiatedRandomCard54a";
				
			}else if(card.name == "Card54b(Clone)"){
				
				card.name = "instantiatedRandomCard54b";
				
			}else if(card.name == "Card54c(Clone)"){
				
				card.name = "instantiatedRandomCard54c";
				
			}else if(card.name == "Card55(Clone)"){
				
				card.name = "instantiatedRandomCard55";
				
			}else if(card.name == "Card55a(Clone)"){
				
				card.name = "instantiatedRandomCard55a";
				
			}else if(card.name == "Card55b(Clone)"){
				
				card.name = "instantiatedRandomCard55b";
				
			}else if(card.name == "Card55c(Clone)"){
				
				card.name = "instantiatedRandomCard55c";
				
			}else if(card.name == "Card56(Clone)"){
				
				card.name = "instantiatedRandomCard56";
				
			}else if(card.name == "Card56a(Clone)"){
				
				card.name = "instantiatedRandomCard56a";
				
			}else if(card.name == "Card56b(Clone)"){
				
				card.name = "instantiatedRandomCard56b";
				
			}else if(card.name == "Card56c(Clone)"){
				
				card.name = "instantiatedRandomCard56c";
				
			}else if(card.name == "Card57(Clone)"){
				
				card.name = "instantiatedRandomCard57";
				
			}else if(card.name == "Card57a(Clone)"){
				
				card.name = "instantiatedRandomCard57a";
				
			}else if(card.name == "Card57b(Clone)"){
				
				card.name = "instantiatedRandomCard57b";
				
			}else if(card.name == "Card57c(Clone)"){
				
				card.name = "instantiatedRandomCard57c";
				
			}else if(card.name == "Card58(Clone)"){
				
				card.name = "instantiatedRandomCard58";
				
			}else if(card.name == "Card58a(Clone)"){
				
				card.name = "instantiatedRandomCard58a";
				
			}else if(card.name == "Card58b(Clone)"){
				
				card.name = "instantiatedRandomCard58b";
				
			}else if(card.name == "Card58c(Clone)"){
				
				card.name = "instantiatedRandomCard58c";
				
			}else if(card.name == "Card59(Clone)"){
				
				card.name = "instantiatedRandomCard59";
				
			}else if(card.name == "Card59a(Clone)"){
				
				card.name = "instantiatedRandomCard59a";
				
			}else if(card.name == "Card59b(Clone)"){
				
				card.name = "instantiatedRandomCard59b";
				
			}else if(card.name == "Card59c(Clone)"){
				
				card.name = "instantiatedRandomCard59c";
				
			}else if(card.name == "Card60(Clone)"){
				
				card.name = "instantiatedRandomCard60";
				
			}else if(card.name == "Card60a(Clone)"){
				
				card.name = "instantiatedRandomCard60a";
				
			}else if(card.name == "Card60b(Clone)"){
				
				card.name = "instantiatedRandomCard60b";
				
			}else if(card.name == "Card60c(Clone)"){
				
				card.name = "instantiatedRandomCard60c";
			}
			
			instances1++;
			
			}
			
		while(instances2 < NumberOfCards) {
			
			GameObject card = Instantiate (cardsInDeck240[Random.Range(0,cardsInDeck240.Length)], spawnPoints2.transform.position,spawnPoints2.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(325f,200f,340.0f);
			
			if(card.name == "Card1(Clone)"){
				
				card.name = "instantiatedRandomCard1";
				
			}else if(card.name == "Card1a(Clone)"){
				
				card.name = "instantiatedRandomCard1a";
				
			}else if(card.name == "Card1b(Clone)"){
				
				card.name = "instantiatedRandomCard1b";
				
			}else if(card.name == "Card1c(Clone)"){
				
				card.name = "instantiatedRandomCard1c";
				
			}else if(card.name == "Card2(Clone)"){
				
				card.name = "instantiatedRandomCard2";
				
			}else if(card.name == "Card2a(Clone)"){
				
				card.name = "instantiatedRandomCard2a";
				
			}else if(card.name == "Card2b(Clone)"){
				
				card.name = "instantiatedRandomCard2b";
				
			}else if(card.name == "Card2c(Clone)"){
				
				card.name = "instantiatedRandomCard2c";
				
			}else if(card.name == "Card3(Clone)"){
				
				card.name = "instantiatedRandomCard3";
				
			}else if(card.name == "Card3a(Clone)"){
				
				card.name = "instantiatedRandomCard3a";
				
			}else if(card.name == "Card3b(Clone)"){
				
				card.name = "instantiatedRandomCard3b";
				
			}else if(card.name == "Card3c(Clone)"){
				
				card.name = "instantiatedRandomCard3c";
				
			}else if(card.name == "Card4(Clone)"){
				
				card.name = "instantiatedRandomCard4";
				
			}else if(card.name == "Card4a(Clone)"){
				
				card.name = "instantiatedRandomCard4a";
				
			}else if(card.name == "Card4b(Clone)"){
				
				card.name = "instantiatedRandomCard4b";
				
			}else if(card.name == "Card4c(Clone)"){
				
				card.name = "instantiatedRandomCard4c";
				
			}else if(card.name == "Card5(Clone)"){
				
				card.name = "instantiatedRandomCard5";
				
			}else if(card.name == "Card5a(Clone)"){
				
				card.name = "instantiatedRandomCard5a";
				
			}else if(card.name == "Card5b(Clone)"){
				
				card.name = "instantiatedRandomCard5b";
				
			}else if(card.name == "Card5c(Clone)"){
				
				card.name = "instantiatedRandomCard5c";
				
			}else if(card.name == "Card6(Clone)"){
				
				card.name = "instantiatedRandomCard6";
				
			}else if(card.name == "Card6a(Clone)"){
				
				card.name = "instantiatedRandomCard6a";
				
			}else if(card.name == "Card6b(Clone)"){
				
				card.name = "instantiatedRandomCard6b";
				
			}else if(card.name == "Card6c(Clone)"){
				
				card.name = "instantiatedRandomCard6c";
				
			}else if(card.name == "Card7(Clone)"){
				
				card.name = "instantiatedRandomCard7";
				
			}else if(card.name == "Card7a(Clone)"){
				
				card.name = "instantiatedRandomCard7a";
				
			}else if(card.name == "Card7b(Clone)"){
				
				card.name = "instantiatedRandomCard7b";
				
			}else if(card.name == "Card7c(Clone)"){
				
				card.name = "instantiatedRandomCard7c";
				
			}else if(card.name == "Card8(Clone)"){
				
				card.name = "instantiatedRandomCard8";
				
			}else if(card.name == "Card8a(Clone)"){
				
				card.name = "instantiatedRandomCard8a";
				
			}else if(card.name == "Card8b(Clone)"){
				
				card.name = "instantiatedRandomCard8b";
				
			}else if(card.name == "Card8c(Clone)"){
				
				card.name = "instantiatedRandomCard8c";
				
			}else if(card.name == "Card9(Clone)"){
				
				card.name = "instantiatedRandomCard9";
				
			}else if(card.name == "Card9a(Clone)"){
				
				card.name = "instantiatedRandomCard9a";
				
			}else if(card.name == "Card9b(Clone)"){
				
				card.name = "instantiatedRandomCard9b";
				
			}else if(card.name == "Card9c(Clone)"){
				
				card.name = "instantiatedRandomCard9c";
				
			}else if(card.name == "Card10(Clone)"){
				
				card.name = "instantiatedAICard10";
				
			}else if(card.name == "Card10a(Clone)"){
				
				card.name = "instantiatedRandomCard10a";
				
			}else if(card.name == "Card10b(Clone)"){
				
				card.name = "instantiatedRandomCard10b";
				
			}else if(card.name == "Card10c(Clone)"){
				
				card.name = "instantiatedRandomCard10c";
				
			}else if(card.name == "Card11(Clone)"){
				
				card.name = "instantiatedRandomCard11";
				
			}else if(card.name == "Card11a(Clone)"){
				
				card.name = "instantiatedRandomCard11a";
				
			}else if(card.name == "Card11b(Clone)"){
				
				card.name = "instantiatedRandomCard11b";
				
			}else if(card.name == "Card11c(Clone)"){
				
				card.name = "instantiatedRandomCard11c";
				
			}else if(card.name == "Card12(Clone)"){
				
				card.name = "instantiatedRandomCard12";
				
			}else if(card.name == "Card12a(Clone)"){
				
				card.name = "instantiatedRandomCard12a";
				
			}else if(card.name == "Card12b(Clone)"){
				
				card.name = "instantiatedRandomCard12b";
				
			}else if(card.name == "Card12c(Clone)"){
				
				card.name = "instantiatedRandomCard12c";
				
			}else if(card.name == "Card13(Clone)"){
				
				card.name = "instantiatedRandomCard13";
				
			}else if(card.name == "Card13a(Clone)"){
				
				card.name = "instantiatedRandomCard13a";
				
			}else if(card.name == "Card13b(Clone)"){
				
				card.name = "instantiatedRandomCard13b";
				
			}else if(card.name == "Card13c(Clone)"){
				
				card.name = "instantiatedRandomCard13c";
				
			}else if(card.name == "Card14(Clone)"){
				
				card.name = "instantiatedRandomCard14";
				
			}else if(card.name == "Card14a(Clone)"){
				
				card.name = "instantiatedRandomCard14a";
				
			}else if(card.name == "Card14b(Clone)"){
				
				card.name = "instantiatedRandomCard14b";
				
			}else if(card.name == "Card14c(Clone)"){
				
				card.name = "instantiatedRandomCard14c";
				
			}else if(card.name == "Card15(Clone)"){
				
				card.name = "instantiatedRandomCard15";
				
			}else if(card.name == "Card15a(Clone)"){
				
				card.name = "instantiatedRandomCard15a";
				
			}else if(card.name == "Card15b(Clone)"){
				
				card.name = "instantiatedRandomCard15b";
				
			}else if(card.name == "Card15c(Clone)"){
				
				card.name = "instantiatedRandomCard15c";
				
			}else if(card.name == "Card16(Clone)"){
				
				card.name = "instantiatedRandomCard16";
				
			}else if(card.name == "Card16a(Clone)"){
				
				card.name = "instantiatedRandomCard16a";
				
			}else if(card.name == "Card16b(Clone)"){
				
				card.name = "instantiatedRandomCard16b";
				
			}else if(card.name == "Card16c(Clone)"){
				
				card.name = "instantiatedRandomCard16c";
				
			}else if(card.name == "Card17(Clone)"){
				
				card.name = "instantiatedRandomCard17";
				
			}else if(card.name == "Card17a(Clone)"){
				
				card.name = "instantiatedRandomCard17a";
				
			}else if(card.name == "Card17b(Clone)"){
				
				card.name = "instantiatedRandomCard17b";
				
			}else if(card.name == "Card17c(Clone)"){
				
				card.name = "instantiatedRandomCard17c";
				
			}else if(card.name == "Card18(Clone)"){
				
				card.name = "instantiatedRandomCard18";
				
			}else if(card.name == "Card18a(Clone)"){
				
				card.name = "instantiatedRandomCard18a";
				
			}else if(card.name == "Card18b(Clone)"){
				
				card.name = "instantiatedRandomCard18b";
				
			}else if(card.name == "Card18c(Clone)"){
				
				card.name = "instantiatedRandomCard18c";
				
			}else if(card.name == "Card19(Clone)"){
				
				card.name = "instantiatedRandomCard19";
				
			}else if(card.name == "Card19a(Clone)"){
				
				card.name = "instantiatedRandomCard19a";
				
			}else if(card.name == "Card19b(Clone)"){
				
				card.name = "instantiatedRandomCard19b";
				
			}else if(card.name == "Card19c(Clone)"){
				
				card.name = "instantiatedRandomCard19c";
				
			}else if(card.name == "Card20(Clone)"){
				
				card.name = "instantiatedRandomCard20";
				
			}else if(card.name == "Card20a(Clone)"){
				
				card.name = "instantiatedRandomCard20a";
				
			}else if(card.name == "Card20b(Clone)"){
				
				card.name = "instantiatedRandomCard20b";
				
			}else if(card.name == "Card20c(Clone)"){
				
				card.name = "instantiatedRandomCard20c";
				
			}else if(card.name == "Card21(Clone)"){
				
				card.name = "instantiatedRandomCard21";
				
			}else if(card.name == "Card21a(Clone)"){
				
				card.name = "instantiatedRandomCard21a";
				
			}else if(card.name == "Card21b(Clone)"){
				
				card.name = "instantiatedRandomCard21b";
				
			}else if(card.name == "Card21c(Clone)"){
				
				card.name = "instantiatedRandomCard21c";
				
			}else if(card.name == "Card22(Clone)"){
				
				card.name = "instantiatedRandomCard22";
				
			}else if(card.name == "Card22a(Clone)"){
				
				card.name = "instantiatedRandomCard22a";
				
			}else if(card.name == "Card22b(Clone)"){
				
				card.name = "instantiatedRandomCard22b";
				
			}else if(card.name == "Card22c(Clone)"){
				
				card.name = "instantiatedRandomCard22c";
				
			}else if(card.name == "Card23(Clone)"){
				
				card.name = "instantiatedRandomCard23";
				
			}else if(card.name == "Card23a(Clone)"){
				
				card.name = "instantiatedRandomCard23a";
				
			}else if(card.name == "Card23b(Clone)"){
				
				card.name = "instantiatedRandomCard23b";
				
			}else if(card.name == "Card23c(Clone)"){
				
				card.name = "instantiatedRandomCard23c";
				
			}else if(card.name == "Card24(Clone)"){
				
				card.name = "instantiatedRandomCard24";
				
			}else if(card.name == "Card24a(Clone)"){
				
				card.name = "instantiatedRandomCard24a";
				
			}else if(card.name == "Card24b(Clone)"){
				
				card.name = "instantiatedRandomCard24b";
				
			}else if(card.name == "Card24c(Clone)"){
				
				card.name = "instantiatedRandomCard24c";
				
			}else if(card.name == "Card25(Clone)"){
				
				card.name = "instantiatedRandomCard25";
				
			}else if(card.name == "Card25a(Clone)"){
				
				card.name = "instantiatedRandomCard25a";
				
			}else if(card.name == "Card25b(Clone)"){
				
				card.name = "instantiatedRandomCard25b";
				
			}else if(card.name == "Card25c(Clone)"){
				
				card.name = "instantiatedRandomCard25c";
				
			}else if(card.name == "Card26(Clone)"){
				
				card.name = "instantiatedRandomCard26";
				
			}else if(card.name == "Card26a(Clone)"){
				
				card.name = "instantiatedRandomCard26a";
				
			}else if(card.name == "Card26b(Clone)"){
				
				card.name = "instantiatedRandomCard26b";
				
			}else if(card.name == "Card26c(Clone)"){
				
				card.name = "instantiatedRandomCard26c";
				
			}else if(card.name == "Card27(Clone)"){
				
				card.name = "instantiatedRandomCard27";
				
			}else if(card.name == "Card27a(Clone)"){
				
				card.name = "instantiatedRandomCard27a";
				
			}else if(card.name == "Card27b(Clone)"){
				
				card.name = "instantiatedRandomCard27b";
				
			}else if(card.name == "Card27c(Clone)"){
				
				card.name = "instantiatedRandomCard27c";
				
			}else if(card.name == "Card28(Clone)"){
				
				card.name = "instantiatedRandomCard28";
				
			}else if(card.name == "Card28a(Clone)"){
				
				card.name = "instantiatedRandomCard28a";
				
			}else if(card.name == "Card28b(Clone)"){
				
				card.name = "instantiatedRandomCard28b";
				
			}else if(card.name == "Card28c(Clone)"){
				
				card.name = "instantiatedRandomCard28c";
				
			}else if(card.name == "Card29(Clone)"){
				
				card.name = "instantiatedRandomCard29";
				
			}else if(card.name == "Card29a(Clone)"){
				
				card.name = "instantiatedRandomCard29a";
				
			}else if(card.name == "Card29b(Clone)"){
				
				card.name = "instantiatedRandomCard29b";
				
			}else if(card.name == "Card29c(Clone)"){
				
				card.name = "instantiatedRandomCard29c";
				
			}else if(card.name == "Card30(Clone)"){
				
				card.name = "instantiatedRandomCard30";
				
			}else if(card.name == "Card30a(Clone)"){
				
				card.name = "instantiatedRandomCard30a";
				
			}else if(card.name == "Card30b(Clone)"){
				
				card.name = "instantiatedRandomCard30b";
				
			}else if(card.name == "Card30c(Clone)"){
				
				card.name = "instantiatedRandomCard30c";
				
			}else if(card.name == "Card31(Clone)"){
				
				card.name = "instantiatedRandomCard31";
				
			}else if(card.name == "Card31a(Clone)"){
				
				card.name = "instantiatedRandomCard31a";
				
			}else if(card.name == "Card31b(Clone)"){
				
				card.name = "instantiatedRandomCard31b";
				
			}else if(card.name == "Card31c(Clone)"){
				
				card.name = "instantiatedRandomCard31c";
				
			}else if(card.name == "Card32(Clone)"){
				
				card.name = "instantiatedRandomCard32";
				
			}else if(card.name == "Card32a(Clone)"){
				
				card.name = "instantiatedRandomCard32a";
				
			}else if(card.name == "Card32b(Clone)"){
				
				card.name = "instantiatedRandomCard32b";
				
			}else if(card.name == "Card32c(Clone)"){
				
				card.name = "instantiatedRandomCard32c";
				
			}else if(card.name == "Card33(Clone)"){
				
				card.name = "instantiatedRandomCard33";
				
			}else if(card.name == "Card33a(Clone)"){
				
				card.name = "instantiatedRandomCard33a";
				
			}else if(card.name == "Card33b(Clone)"){
				
				card.name = "instantiatedRandomCard33b";
				
			}else if(card.name == "Card33c(Clone)"){
				
				card.name = "instantiatedRandomCard33c";
				
			}else if(card.name == "Card34(Clone)"){
				
				card.name = "instantiatedRandomCard34";
				
			}else if(card.name == "Card34a(Clone)"){
				
				card.name = "instantiatedRandomCard34a";
				
			}else if(card.name == "Card34b(Clone)"){
				
				card.name = "instantiatedRandomCard34b";
				
			}else if(card.name == "Card34c(Clone)"){
				
				card.name = "instantiatedRandomCard34c";
				
			}else if(card.name == "Card35(Clone)"){
				
				card.name = "instantiatedRandomCard35";
				
			}else if(card.name == "Card35a(Clone)"){
				
				card.name = "instantiatedRandomCard35a";
				
			}else if(card.name == "Card35b(Clone)"){
				
				card.name = "instantiatedRandomCard35b";
				
			}else if(card.name == "Card35c(Clone)"){
				
				card.name = "instantiatedRandomCard35c";
				
			}else if(card.name == "Card36(Clone)"){
				
				card.name = "instantiatedRandomCard36";
				
			}else if(card.name == "Card36a(Clone)"){
				
				card.name = "instantiatedRandomCard36a";
				
			}else if(card.name == "Card36b(Clone)"){
				
				card.name = "instantiatedRandomCard36b";
				
			}else if(card.name == "Card36c(Clone)"){
				
				card.name = "instantiatedRandomCard36c";
				
			}else if(card.name == "Card37(Clone)"){
				
				card.name = "instantiatedRandomCard37";
				
			}else if(card.name == "Card37a(Clone)"){
				
				card.name = "instantiatedRandomCard37a";
				
			}else if(card.name == "Card37b(Clone)"){
				
				card.name = "instantiatedRandomCard37b";
				
			}else if(card.name == "Card37c(Clone)"){
				
				card.name = "instantiatedRandomCard37c";
				
			}else if(card.name == "Card38(Clone)"){
				
				card.name = "instantiatedRandomCard38";
				
			}else if(card.name == "Card38a(Clone)"){
				
				card.name = "instantiatedRandomCard38a";
				
			}else if(card.name == "Card38b(Clone)"){
				
				card.name = "instantiatedRandomCard38b";
				
			}else if(card.name == "Card38c(Clone)"){
				
				card.name = "instantiatedRandomCard38c";
				
			}else if(card.name == "Card39(Clone)"){
				
				card.name = "instantiatedRandomCard39";
				
			}else if(card.name == "Card39a(Clone)"){
				
				card.name = "instantiatedRandomCard39a";
				
			}else if(card.name == "Card39b(Clone)"){
				
				card.name = "instantiatedRandomCard39b";
				
			}else if(card.name == "Card39c(Clone)"){
				
				card.name = "instantiatedRandomCard39c";
				
			}else if(card.name == "Card40(Clone)"){
				
				card.name = "instantiatedRandomCard40";
				
			}else if(card.name == "Card40a(Clone)"){
				
				card.name = "instantiatedRandomCard40a";
				
			}else if(card.name == "Card40b(Clone)"){
				
				card.name = "instantiatedRandomCard40b";
				
			}else if(card.name == "Card40c(Clone)"){
				
				card.name = "instantiatedRandomCard40c";
				
			}else if(card.name == "Card41(Clone)"){
				
				card.name = "instantiatedRandomCard41";
				
			}else if(card.name == "Card41a(Clone)"){
				
				card.name = "instantiatedRandomCard41a";
				
			}else if(card.name == "Card41b(Clone)"){
				
				card.name = "instantiatedRandomCard41b";
				
			}else if(card.name == "Card41c(Clone)"){
				
				card.name = "instantiatedRandomCard41c";
				
			}else if(card.name == "Card42(Clone)"){
				
				card.name = "instantiatedRandomCard42";
				
			}else if(card.name == "Card42a(Clone)"){
				
				card.name = "instantiatedRandomCard42a";
				
			}else if(card.name == "Card42b(Clone)"){
				
				card.name = "instantiatedRandomCard42b";
				
			}else if(card.name == "Card42c(Clone)"){
				
				card.name = "instantiatedRandomCard42c";
				
			}else if(card.name == "Card43(Clone)"){
				
				card.name = "instantiatedRandomCard43";
				
			}else if(card.name == "Card43a(Clone)"){
				
				card.name = "instantiatedRandomCard43a";
				
			}else if(card.name == "Card43b(Clone)"){
				
				card.name = "instantiatedRandomCard43b";
				
			}else if(card.name == "Card43c(Clone)"){
				
				card.name = "instantiatedRandomCard43c";
				
			}else if(card.name == "Card44(Clone)"){
				
				card.name = "instantiatedRandomCard44";
				
			}else if(card.name == "Card44a(Clone)"){
				
				card.name = "instantiatedRandomCard44a";
				
			}else if(card.name == "Card44b(Clone)"){
				
				card.name = "instantiatedRandomCard44b";
				
			}else if(card.name == "Card44c(Clone)"){
				
				card.name = "instantiatedRandomCard44c";
				
			}else if(card.name == "Card45(Clone)"){
				
				card.name = "instantiatedRandomCard45";
				
			}else if(card.name == "Card45a(Clone)"){
				
				card.name = "instantiatedRandomCard45a";
				
			}else if(card.name == "Card45b(Clone)"){
				
				card.name = "instantiatedRandomCard45b";
				
			}else if(card.name == "Card45c(Clone)"){
				
				card.name = "instantiatedRandomCard45c";
				
			}else if(card.name == "Card46(Clone)"){
				
				card.name = "instantiatedRandomCard46";
				
			}else if(card.name == "Card46a(Clone)"){
				
				card.name = "instantiatedRandomCard46a";
				
			}else if(card.name == "Card46b(Clone)"){
				
				card.name = "instantiatedRandomCard46b";
				
			}else if(card.name == "Card46c(Clone)"){
				
				card.name = "instantiatedRandomCard46c";
				
			}else if(card.name == "Card47(Clone)"){
				
				card.name = "instantiatedRandomCard47";
				
			}else if(card.name == "Card47a(Clone)"){
				
				card.name = "instantiatedRandomCard47a";
				
			}else if(card.name == "Card47b(Clone)"){
				
				card.name = "instantiatedRandomCard47b";
				
			}else if(card.name == "Card47c(Clone)"){
				
				card.name = "instantiatedRandomCard47c";
				
			}else if(card.name == "Card48(Clone)"){
				
				card.name = "instantiatedRandomCard48";
				
			}else if(card.name == "Card48a(Clone)"){
				
				card.name = "instantiatedRandomCard48a";
				
			}else if(card.name == "Card48b(Clone)"){
				
				card.name = "instantiatedRandomCard48b";
				
			}else if(card.name == "Card48c(Clone)"){
				
				card.name = "instantiatedRandomCard48c";
				
			}else if(card.name == "Card49(Clone)"){
				
				card.name = "instantiatedRandomCard49";
				
			}else if(card.name == "Card49a(Clone)"){
				
				card.name = "instantiatedRandomCard49a";
				
			}else if(card.name == "Card49b(Clone)"){
				
				card.name = "instantiatedRandomCard49b";
				
			}else if(card.name == "Card49c(Clone)"){
				
				card.name = "instantiatedRandomCard49c";
				
			}else if(card.name == "Card50(Clone)"){
				
				card.name = "instantiatedRandomCard50";
				
			}else if(card.name == "Card50a(Clone)"){
				
				card.name = "instantiatedRandomCard50a";
				
			}else if(card.name == "Card50b(Clone)"){
				
				card.name = "instantiatedRandomCard50b";
				
			}else if(card.name == "Card50c(Clone)"){
				
				card.name = "instantiatedRandomCard50c";
				
			}else if(card.name == "Card51(Clone)"){
				
				card.name = "instantiatedRandomCard51";
				
			}else if(card.name == "Card51a(Clone)"){
				
				card.name = "instantiatedRandomCard51a";
				
			}else if(card.name == "Card51b(Clone)"){
				
				card.name = "instantiatedRandomCard51b";
				
			}else if(card.name == "Card51c(Clone)"){
				
				card.name = "instantiatedRandomCard51c";
				
			}else if(card.name == "Card52(Clone)"){
				
				card.name = "instantiatedRandomCard52";
				
			}else if(card.name == "Card52a(Clone)"){
				
				card.name = "instantiatedRandomCard52a";
				
			}else if(card.name == "Card52b(Clone)"){
				
				card.name = "instantiatedRandomCard52b";
				
			}else if(card.name == "Card52c(Clone)"){
				
				card.name = "instantiatedRandomCard52c";
				
			}else if(card.name == "Card53(Clone)"){
				
				card.name = "instantiatedRandomCard53";
				
			}else if(card.name == "Card53a(Clone)"){
				
				card.name = "instantiatedRandomCard53a";
				
			}else if(card.name == "Card53b(Clone)"){
				
				card.name = "instantiatedRandomCard53b";
				
			}else if(card.name == "Card53c(Clone)"){
				
				card.name = "instantiatedRandomCard53c";
				
			}else if(card.name == "Card54(Clone)"){
				
				card.name = "instantiatedRandomCard54";
				
			}else if(card.name == "Card54a(Clone)"){
				
				card.name = "instantiatedRandomCard54a";
				
			}else if(card.name == "Card54b(Clone)"){
				
				card.name = "instantiatedRandomCard54b";
				
			}else if(card.name == "Card54c(Clone)"){
				
				card.name = "instantiatedRandomCard54c";
				
			}else if(card.name == "Card55(Clone)"){
				
				card.name = "instantiatedRandomCard55";
				
			}else if(card.name == "Card55a(Clone)"){
				
				card.name = "instantiatedRandomCard55a";
				
			}else if(card.name == "Card55b(Clone)"){
				
				card.name = "instantiatedRandomCard55b";
				
			}else if(card.name == "Card55c(Clone)"){
				
				card.name = "instantiatedRandomCard55c";
				
			}else if(card.name == "Card56(Clone)"){
				
				card.name = "instantiatedRandomCard56";
				
			}else if(card.name == "Card56a(Clone)"){
				
				card.name = "instantiatedRandomCard56a";
				
			}else if(card.name == "Card56b(Clone)"){
				
				card.name = "instantiatedRandomCard56b";
				
			}else if(card.name == "Card56c(Clone)"){
				
				card.name = "instantiatedRandomCard56c";
				
			}else if(card.name == "Card57(Clone)"){
				
				card.name = "instantiatedRandomCard57";
				
			}else if(card.name == "Card57a(Clone)"){
				
				card.name = "instantiatedRandomCard57a";
				
			}else if(card.name == "Card57b(Clone)"){
				
				card.name = "instantiatedRandomCard57b";
				
			}else if(card.name == "Card57c(Clone)"){
				
				card.name = "instantiatedRandomCard57c";
				
			}else if(card.name == "Card58(Clone)"){
				
				card.name = "instantiatedRandomCard58";
				
			}else if(card.name == "Card58a(Clone)"){
				
				card.name = "instantiatedRandomCard58a";
				
			}else if(card.name == "Card58b(Clone)"){
				
				card.name = "instantiatedRandomCard58b";
				
			}else if(card.name == "Card58c(Clone)"){
				
				card.name = "instantiatedRandomCard58c";
				
			}else if(card.name == "Card59(Clone)"){
				
				card.name = "instantiatedRandomCard59";
				
			}else if(card.name == "Card59a(Clone)"){
				
				card.name = "instantiatedRandomCard59a";
				
			}else if(card.name == "Card59b(Clone)"){
				
				card.name = "instantiatedRandomCard59b";
				
			}else if(card.name == "Card59c(Clone)"){
				
				card.name = "instantiatedRandomCard59c";
				
			}else if(card.name == "Card60(Clone)"){
				
				card.name = "instantiatedRandomCard60";
				
			}else if(card.name == "Card60a(Clone)"){
				
				card.name = "instantiatedRandomCard60a";
				
			}else if(card.name == "Card60b(Clone)"){
				
				card.name = "instantiatedRandomCard60b";
				
			}else if(card.name == "Card60c(Clone)"){
				
				card.name = "instantiatedRandomCard60c";
			}
			
			instances2++;
			
			}
			
		while(instances3 < NumberOfCards) {
			
			GameObject card = Instantiate (cardsInDeck240[Random.Range(0,cardsInDeck240.Length)], spawnPoints3.transform.position,spawnPoints3.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(325f,200f,340.0f);
			
			if(card.name == "Card1(Clone)"){
				
				card.name = "instantiatedRandomCard1";
				
			}else if(card.name == "Card1a(Clone)"){
				
				card.name = "instantiatedRandomCard1a";
				
			}else if(card.name == "Card1b(Clone)"){
				
				card.name = "instantiatedRandomCard1b";
				
			}else if(card.name == "Card1c(Clone)"){
				
				card.name = "instantiatedRandomCard1c";
				
			}else if(card.name == "Card2(Clone)"){
				
				card.name = "instantiatedRandomCard2";
				
			}else if(card.name == "Card2a(Clone)"){
				
				card.name = "instantiatedRandomCard2a";
				
			}else if(card.name == "Card2b(Clone)"){
				
				card.name = "instantiatedRandomCard2b";
				
			}else if(card.name == "Card2c(Clone)"){
				
				card.name = "instantiatedRandomCard2c";
				
			}else if(card.name == "Card3(Clone)"){
				
				card.name = "instantiatedRandomCard3";
				
			}else if(card.name == "Card3a(Clone)"){
				
				card.name = "instantiatedRandomCard3a";
				
			}else if(card.name == "Card3b(Clone)"){
				
				card.name = "instantiatedRandomCard3b";
				
			}else if(card.name == "Card3c(Clone)"){
				
				card.name = "instantiatedRandomCard3c";
				
			}else if(card.name == "Card4(Clone)"){
				
				card.name = "instantiatedRandomCard4";
				
			}else if(card.name == "Card4a(Clone)"){
				
				card.name = "instantiatedRandomCard4a";
				
			}else if(card.name == "Card4b(Clone)"){
				
				card.name = "instantiatedRandomCard4b";
				
			}else if(card.name == "Card4c(Clone)"){
				
				card.name = "instantiatedRandomCard4c";
				
			}else if(card.name == "Card5(Clone)"){
				
				card.name = "instantiatedRandomCard5";
				
			}else if(card.name == "Card5a(Clone)"){
				
				card.name = "instantiatedRandomCard5a";
				
			}else if(card.name == "Card5b(Clone)"){
				
				card.name = "instantiatedRandomCard5b";
				
			}else if(card.name == "Card5c(Clone)"){
				
				card.name = "instantiatedRandomCard5c";
				
			}else if(card.name == "Card6(Clone)"){
				
				card.name = "instantiatedRandomCard6";
				
			}else if(card.name == "Card6a(Clone)"){
				
				card.name = "instantiatedRandomCard6a";
				
			}else if(card.name == "Card6b(Clone)"){
				
				card.name = "instantiatedRandomCard6b";
				
			}else if(card.name == "Card6c(Clone)"){
				
				card.name = "instantiatedRandomCard6c";
				
			}else if(card.name == "Card7(Clone)"){
				
				card.name = "instantiatedRandomCard7";
				
			}else if(card.name == "Card7a(Clone)"){
				
				card.name = "instantiatedRandomCard7a";
				
			}else if(card.name == "Card7b(Clone)"){
				
				card.name = "instantiatedRandomCard7b";
				
			}else if(card.name == "Card7c(Clone)"){
				
				card.name = "instantiatedRandomCard7c";
				
			}else if(card.name == "Card8(Clone)"){
				
				card.name = "instantiatedRandomCard8";
				
			}else if(card.name == "Card8a(Clone)"){
				
				card.name = "instantiatedRandomCard8a";
				
			}else if(card.name == "Card8b(Clone)"){
				
				card.name = "instantiatedRandomCard8b";
				
			}else if(card.name == "Card8c(Clone)"){
				
				card.name = "instantiatedRandomCard8c";
				
			}else if(card.name == "Card9(Clone)"){
				
				card.name = "instantiatedRandomCard9";
				
			}else if(card.name == "Card9a(Clone)"){
				
				card.name = "instantiatedRandomCard9a";
				
			}else if(card.name == "Card9b(Clone)"){
				
				card.name = "instantiatedRandomCard9b";
				
			}else if(card.name == "Card9c(Clone)"){
				
				card.name = "instantiatedRandomCard9c";
				
			}else if(card.name == "Card10(Clone)"){
				
				card.name = "instantiatedAICard10";
				
			}else if(card.name == "Card10a(Clone)"){
				
				card.name = "instantiatedRandomCard10a";
				
			}else if(card.name == "Card10b(Clone)"){
				
				card.name = "instantiatedRandomCard10b";
				
			}else if(card.name == "Card10c(Clone)"){
				
				card.name = "instantiatedRandomCard10c";
				
			}else if(card.name == "Card11(Clone)"){
				
				card.name = "instantiatedRandomCard11";
				
			}else if(card.name == "Card11a(Clone)"){
				
				card.name = "instantiatedRandomCard11a";
				
			}else if(card.name == "Card11b(Clone)"){
				
				card.name = "instantiatedRandomCard11b";
				
			}else if(card.name == "Card11c(Clone)"){
				
				card.name = "instantiatedRandomCard11c";
				
			}else if(card.name == "Card12(Clone)"){
				
				card.name = "instantiatedRandomCard12";
				
			}else if(card.name == "Card12a(Clone)"){
				
				card.name = "instantiatedRandomCard12a";
				
			}else if(card.name == "Card12b(Clone)"){
				
				card.name = "instantiatedRandomCard12b";
				
			}else if(card.name == "Card12c(Clone)"){
				
				card.name = "instantiatedRandomCard12c";
				
			}else if(card.name == "Card13(Clone)"){
				
				card.name = "instantiatedRandomCard13";
				
			}else if(card.name == "Card13a(Clone)"){
				
				card.name = "instantiatedRandomCard13a";
				
			}else if(card.name == "Card13b(Clone)"){
				
				card.name = "instantiatedRandomCard13b";
				
			}else if(card.name == "Card13c(Clone)"){
				
				card.name = "instantiatedRandomCard13c";
				
			}else if(card.name == "Card14(Clone)"){
				
				card.name = "instantiatedRandomCard14";
				
			}else if(card.name == "Card14a(Clone)"){
				
				card.name = "instantiatedRandomCard14a";
				
			}else if(card.name == "Card14b(Clone)"){
				
				card.name = "instantiatedRandomCard14b";
				
			}else if(card.name == "Card14c(Clone)"){
				
				card.name = "instantiatedRandomCard14c";
				
			}else if(card.name == "Card15(Clone)"){
				
				card.name = "instantiatedRandomCard15";
				
			}else if(card.name == "Card15a(Clone)"){
				
				card.name = "instantiatedRandomCard15a";
				
			}else if(card.name == "Card15b(Clone)"){
				
				card.name = "instantiatedRandomCard15b";
				
			}else if(card.name == "Card15c(Clone)"){
				
				card.name = "instantiatedRandomCard15c";
				
			}else if(card.name == "Card16(Clone)"){
				
				card.name = "instantiatedRandomCard16";
				
			}else if(card.name == "Card16a(Clone)"){
				
				card.name = "instantiatedRandomCard16a";
				
			}else if(card.name == "Card16b(Clone)"){
				
				card.name = "instantiatedRandomCard16b";
				
			}else if(card.name == "Card16c(Clone)"){
				
				card.name = "instantiatedRandomCard16c";
				
			}else if(card.name == "Card17(Clone)"){
				
				card.name = "instantiatedRandomCard17";
				
			}else if(card.name == "Card17a(Clone)"){
				
				card.name = "instantiatedRandomCard17a";
				
			}else if(card.name == "Card17b(Clone)"){
				
				card.name = "instantiatedRandomCard17b";
				
			}else if(card.name == "Card17c(Clone)"){
				
				card.name = "instantiatedRandomCard17c";
				
			}else if(card.name == "Card18(Clone)"){
				
				card.name = "instantiatedRandomCard18";
				
			}else if(card.name == "Card18a(Clone)"){
				
				card.name = "instantiatedRandomCard18a";
				
			}else if(card.name == "Card18b(Clone)"){
				
				card.name = "instantiatedRandomCard18b";
				
			}else if(card.name == "Card18c(Clone)"){
				
				card.name = "instantiatedRandomCard18c";
				
			}else if(card.name == "Card19(Clone)"){
				
				card.name = "instantiatedRandomCard19";
				
			}else if(card.name == "Card19a(Clone)"){
				
				card.name = "instantiatedRandomCard19a";
				
			}else if(card.name == "Card19b(Clone)"){
				
				card.name = "instantiatedRandomCard19b";
				
			}else if(card.name == "Card19c(Clone)"){
				
				card.name = "instantiatedRandomCard19c";
				
			}else if(card.name == "Card20(Clone)"){
				
				card.name = "instantiatedRandomCard20";
				
			}else if(card.name == "Card20a(Clone)"){
				
				card.name = "instantiatedRandomCard20a";
				
			}else if(card.name == "Card20b(Clone)"){
				
				card.name = "instantiatedRandomCard20b";
				
			}else if(card.name == "Card20c(Clone)"){
				
				card.name = "instantiatedRandomCard20c";
				
			}else if(card.name == "Card21(Clone)"){
				
				card.name = "instantiatedRandomCard21";
				
			}else if(card.name == "Card21a(Clone)"){
				
				card.name = "instantiatedRandomCard21a";
				
			}else if(card.name == "Card21b(Clone)"){
				
				card.name = "instantiatedRandomCard21b";
				
			}else if(card.name == "Card21c(Clone)"){
				
				card.name = "instantiatedRandomCard21c";
				
			}else if(card.name == "Card22(Clone)"){
				
				card.name = "instantiatedRandomCard22";
				
			}else if(card.name == "Card22a(Clone)"){
				
				card.name = "instantiatedRandomCard22a";
				
			}else if(card.name == "Card22b(Clone)"){
				
				card.name = "instantiatedRandomCard22b";
				
			}else if(card.name == "Card22c(Clone)"){
				
				card.name = "instantiatedRandomCard22c";
				
			}else if(card.name == "Card23(Clone)"){
				
				card.name = "instantiatedRandomCard23";
				
			}else if(card.name == "Card23a(Clone)"){
				
				card.name = "instantiatedRandomCard23a";
				
			}else if(card.name == "Card23b(Clone)"){
				
				card.name = "instantiatedRandomCard23b";
				
			}else if(card.name == "Card23c(Clone)"){
				
				card.name = "instantiatedRandomCard23c";
				
			}else if(card.name == "Card24(Clone)"){
				
				card.name = "instantiatedRandomCard24";
				
			}else if(card.name == "Card24a(Clone)"){
				
				card.name = "instantiatedRandomCard24a";
				
			}else if(card.name == "Card24b(Clone)"){
				
				card.name = "instantiatedRandomCard24b";
				
			}else if(card.name == "Card24c(Clone)"){
				
				card.name = "instantiatedRandomCard24c";
				
			}else if(card.name == "Card25(Clone)"){
				
				card.name = "instantiatedRandomCard25";
				
			}else if(card.name == "Card25a(Clone)"){
				
				card.name = "instantiatedRandomCard25a";
				
			}else if(card.name == "Card25b(Clone)"){
				
				card.name = "instantiatedRandomCard25b";
				
			}else if(card.name == "Card25c(Clone)"){
				
				card.name = "instantiatedRandomCard25c";
				
			}else if(card.name == "Card26(Clone)"){
				
				card.name = "instantiatedRandomCard26";
				
			}else if(card.name == "Card26a(Clone)"){
				
				card.name = "instantiatedRandomCard26a";
				
			}else if(card.name == "Card26b(Clone)"){
				
				card.name = "instantiatedRandomCard26b";
				
			}else if(card.name == "Card26c(Clone)"){
				
				card.name = "instantiatedRandomCard26c";
				
			}else if(card.name == "Card27(Clone)"){
				
				card.name = "instantiatedRandomCard27";
				
			}else if(card.name == "Card27a(Clone)"){
				
				card.name = "instantiatedRandomCard27a";
				
			}else if(card.name == "Card27b(Clone)"){
				
				card.name = "instantiatedRandomCard27b";
				
			}else if(card.name == "Card27c(Clone)"){
				
				card.name = "instantiatedRandomCard27c";
				
			}else if(card.name == "Card28(Clone)"){
				
				card.name = "instantiatedRandomCard28";
				
			}else if(card.name == "Card28a(Clone)"){
				
				card.name = "instantiatedRandomCard28a";
				
			}else if(card.name == "Card28b(Clone)"){
				
				card.name = "instantiatedRandomCard28b";
				
			}else if(card.name == "Card28c(Clone)"){
				
				card.name = "instantiatedRandomCard28c";
				
			}else if(card.name == "Card29(Clone)"){
				
				card.name = "instantiatedRandomCard29";
				
			}else if(card.name == "Card29a(Clone)"){
				
				card.name = "instantiatedRandomCard29a";
				
			}else if(card.name == "Card29b(Clone)"){
				
				card.name = "instantiatedRandomCard29b";
				
			}else if(card.name == "Card29c(Clone)"){
				
				card.name = "instantiatedRandomCard29c";
				
			}else if(card.name == "Card30(Clone)"){
				
				card.name = "instantiatedRandomCard30";
				
			}else if(card.name == "Card30a(Clone)"){
				
				card.name = "instantiatedRandomCard30a";
				
			}else if(card.name == "Card30b(Clone)"){
				
				card.name = "instantiatedRandomCard30b";
				
			}else if(card.name == "Card30c(Clone)"){
				
				card.name = "instantiatedRandomCard30c";
				
			}else if(card.name == "Card31(Clone)"){
				
				card.name = "instantiatedRandomCard31";
				
			}else if(card.name == "Card31a(Clone)"){
				
				card.name = "instantiatedRandomCard31a";
				
			}else if(card.name == "Card31b(Clone)"){
				
				card.name = "instantiatedRandomCard31b";
				
			}else if(card.name == "Card31c(Clone)"){
				
				card.name = "instantiatedRandomCard31c";
				
			}else if(card.name == "Card32(Clone)"){
				
				card.name = "instantiatedRandomCard32";
				
			}else if(card.name == "Card32a(Clone)"){
				
				card.name = "instantiatedRandomCard32a";
				
			}else if(card.name == "Card32b(Clone)"){
				
				card.name = "instantiatedRandomCard32b";
				
			}else if(card.name == "Card32c(Clone)"){
				
				card.name = "instantiatedRandomCard32c";
				
			}else if(card.name == "Card33(Clone)"){
				
				card.name = "instantiatedRandomCard33";
				
			}else if(card.name == "Card33a(Clone)"){
				
				card.name = "instantiatedRandomCard33a";
				
			}else if(card.name == "Card33b(Clone)"){
				
				card.name = "instantiatedRandomCard33b";
				
			}else if(card.name == "Card33c(Clone)"){
				
				card.name = "instantiatedRandomCard33c";
				
			}else if(card.name == "Card34(Clone)"){
				
				card.name = "instantiatedRandomCard34";
				
			}else if(card.name == "Card34a(Clone)"){
				
				card.name = "instantiatedRandomCard34a";
				
			}else if(card.name == "Card34b(Clone)"){
				
				card.name = "instantiatedRandomCard34b";
				
			}else if(card.name == "Card34c(Clone)"){
				
				card.name = "instantiatedRandomCard34c";
				
			}else if(card.name == "Card35(Clone)"){
				
				card.name = "instantiatedRandomCard35";
				
			}else if(card.name == "Card35a(Clone)"){
				
				card.name = "instantiatedRandomCard35a";
				
			}else if(card.name == "Card35b(Clone)"){
				
				card.name = "instantiatedRandomCard35b";
				
			}else if(card.name == "Card35c(Clone)"){
				
				card.name = "instantiatedRandomCard35c";
				
			}else if(card.name == "Card36(Clone)"){
				
				card.name = "instantiatedRandomCard36";
				
			}else if(card.name == "Card36a(Clone)"){
				
				card.name = "instantiatedRandomCard36a";
				
			}else if(card.name == "Card36b(Clone)"){
				
				card.name = "instantiatedRandomCard36b";
				
			}else if(card.name == "Card36c(Clone)"){
				
				card.name = "instantiatedRandomCard36c";
				
			}else if(card.name == "Card37(Clone)"){
				
				card.name = "instantiatedRandomCard37";
				
			}else if(card.name == "Card37a(Clone)"){
				
				card.name = "instantiatedRandomCard37a";
				
			}else if(card.name == "Card37b(Clone)"){
				
				card.name = "instantiatedRandomCard37b";
				
			}else if(card.name == "Card37c(Clone)"){
				
				card.name = "instantiatedRandomCard37c";
				
			}else if(card.name == "Card38(Clone)"){
				
				card.name = "instantiatedRandomCard38";
				
			}else if(card.name == "Card38a(Clone)"){
				
				card.name = "instantiatedRandomCard38a";
				
			}else if(card.name == "Card38b(Clone)"){
				
				card.name = "instantiatedRandomCard38b";
				
			}else if(card.name == "Card38c(Clone)"){
				
				card.name = "instantiatedRandomCard38c";
				
			}else if(card.name == "Card39(Clone)"){
				
				card.name = "instantiatedRandomCard39";
				
			}else if(card.name == "Card39a(Clone)"){
				
				card.name = "instantiatedRandomCard39a";
				
			}else if(card.name == "Card39b(Clone)"){
				
				card.name = "instantiatedRandomCard39b";
				
			}else if(card.name == "Card39c(Clone)"){
				
				card.name = "instantiatedRandomCard39c";
				
			}else if(card.name == "Card40(Clone)"){
				
				card.name = "instantiatedRandomCard40";
				
			}else if(card.name == "Card40a(Clone)"){
				
				card.name = "instantiatedRandomCard40a";
				
			}else if(card.name == "Card40b(Clone)"){
				
				card.name = "instantiatedRandomCard40b";
				
			}else if(card.name == "Card40c(Clone)"){
				
				card.name = "instantiatedRandomCard40c";
				
			}else if(card.name == "Card41(Clone)"){
				
				card.name = "instantiatedRandomCard41";
				
			}else if(card.name == "Card41a(Clone)"){
				
				card.name = "instantiatedRandomCard41a";
				
			}else if(card.name == "Card41b(Clone)"){
				
				card.name = "instantiatedRandomCard41b";
				
			}else if(card.name == "Card41c(Clone)"){
				
				card.name = "instantiatedRandomCard41c";
				
			}else if(card.name == "Card42(Clone)"){
				
				card.name = "instantiatedRandomCard42";
				
			}else if(card.name == "Card42a(Clone)"){
				
				card.name = "instantiatedRandomCard42a";
				
			}else if(card.name == "Card42b(Clone)"){
				
				card.name = "instantiatedRandomCard42b";
				
			}else if(card.name == "Card42c(Clone)"){
				
				card.name = "instantiatedRandomCard42c";
				
			}else if(card.name == "Card43(Clone)"){
				
				card.name = "instantiatedRandomCard43";
				
			}else if(card.name == "Card43a(Clone)"){
				
				card.name = "instantiatedRandomCard43a";
				
			}else if(card.name == "Card43b(Clone)"){
				
				card.name = "instantiatedRandomCard43b";
				
			}else if(card.name == "Card43c(Clone)"){
				
				card.name = "instantiatedRandomCard43c";
				
			}else if(card.name == "Card44(Clone)"){
				
				card.name = "instantiatedRandomCard44";
				
			}else if(card.name == "Card44a(Clone)"){
				
				card.name = "instantiatedRandomCard44a";
				
			}else if(card.name == "Card44b(Clone)"){
				
				card.name = "instantiatedRandomCard44b";
				
			}else if(card.name == "Card44c(Clone)"){
				
				card.name = "instantiatedRandomCard44c";
				
			}else if(card.name == "Card45(Clone)"){
				
				card.name = "instantiatedRandomCard45";
				
			}else if(card.name == "Card45a(Clone)"){
				
				card.name = "instantiatedRandomCard45a";
				
			}else if(card.name == "Card45b(Clone)"){
				
				card.name = "instantiatedRandomCard45b";
				
			}else if(card.name == "Card45c(Clone)"){
				
				card.name = "instantiatedRandomCard45c";
				
			}else if(card.name == "Card46(Clone)"){
				
				card.name = "instantiatedRandomCard46";
				
			}else if(card.name == "Card46a(Clone)"){
				
				card.name = "instantiatedRandomCard46a";
				
			}else if(card.name == "Card46b(Clone)"){
				
				card.name = "instantiatedRandomCard46b";
				
			}else if(card.name == "Card46c(Clone)"){
				
				card.name = "instantiatedRandomCard46c";
				
			}else if(card.name == "Card47(Clone)"){
				
				card.name = "instantiatedRandomCard47";
				
			}else if(card.name == "Card47a(Clone)"){
				
				card.name = "instantiatedRandomCard47a";
				
			}else if(card.name == "Card47b(Clone)"){
				
				card.name = "instantiatedRandomCard47b";
				
			}else if(card.name == "Card47c(Clone)"){
				
				card.name = "instantiatedRandomCard47c";
				
			}else if(card.name == "Card48(Clone)"){
				
				card.name = "instantiatedRandomCard48";
				
			}else if(card.name == "Card48a(Clone)"){
				
				card.name = "instantiatedRandomCard48a";
				
			}else if(card.name == "Card48b(Clone)"){
				
				card.name = "instantiatedRandomCard48b";
				
			}else if(card.name == "Card48c(Clone)"){
				
				card.name = "instantiatedRandomCard48c";
				
			}else if(card.name == "Card49(Clone)"){
				
				card.name = "instantiatedRandomCard49";
				
			}else if(card.name == "Card49a(Clone)"){
				
				card.name = "instantiatedRandomCard49a";
				
			}else if(card.name == "Card49b(Clone)"){
				
				card.name = "instantiatedRandomCard49b";
				
			}else if(card.name == "Card49c(Clone)"){
				
				card.name = "instantiatedRandomCard49c";
				
			}else if(card.name == "Card50(Clone)"){
				
				card.name = "instantiatedRandomCard50";
				
			}else if(card.name == "Card50a(Clone)"){
				
				card.name = "instantiatedRandomCard50a";
				
			}else if(card.name == "Card50b(Clone)"){
				
				card.name = "instantiatedRandomCard50b";
				
			}else if(card.name == "Card50c(Clone)"){
				
				card.name = "instantiatedRandomCard50c";
				
			}else if(card.name == "Card51(Clone)"){
				
				card.name = "instantiatedRandomCard51";
				
			}else if(card.name == "Card51a(Clone)"){
				
				card.name = "instantiatedRandomCard51a";
				
			}else if(card.name == "Card51b(Clone)"){
				
				card.name = "instantiatedRandomCard51b";
				
			}else if(card.name == "Card51c(Clone)"){
				
				card.name = "instantiatedRandomCard51c";
				
			}else if(card.name == "Card52(Clone)"){
				
				card.name = "instantiatedRandomCard52";
				
			}else if(card.name == "Card52a(Clone)"){
				
				card.name = "instantiatedRandomCard52a";
				
			}else if(card.name == "Card52b(Clone)"){
				
				card.name = "instantiatedRandomCard52b";
				
			}else if(card.name == "Card52c(Clone)"){
				
				card.name = "instantiatedRandomCard52c";
				
			}else if(card.name == "Card53(Clone)"){
				
				card.name = "instantiatedRandomCard53";
				
			}else if(card.name == "Card53a(Clone)"){
				
				card.name = "instantiatedRandomCard53a";
				
			}else if(card.name == "Card53b(Clone)"){
				
				card.name = "instantiatedRandomCard53b";
				
			}else if(card.name == "Card53c(Clone)"){
				
				card.name = "instantiatedRandomCard53c";
				
			}else if(card.name == "Card54(Clone)"){
				
				card.name = "instantiatedRandomCard54";
				
			}else if(card.name == "Card54a(Clone)"){
				
				card.name = "instantiatedRandomCard54a";
				
			}else if(card.name == "Card54b(Clone)"){
				
				card.name = "instantiatedRandomCard54b";
				
			}else if(card.name == "Card54c(Clone)"){
				
				card.name = "instantiatedRandomCard54c";
				
			}else if(card.name == "Card55(Clone)"){
				
				card.name = "instantiatedRandomCard55";
				
			}else if(card.name == "Card55a(Clone)"){
				
				card.name = "instantiatedRandomCard55a";
				
			}else if(card.name == "Card55b(Clone)"){
				
				card.name = "instantiatedRandomCard55b";
				
			}else if(card.name == "Card55c(Clone)"){
				
				card.name = "instantiatedRandomCard55c";
				
			}else if(card.name == "Card56(Clone)"){
				
				card.name = "instantiatedRandomCard56";
				
			}else if(card.name == "Card56a(Clone)"){
				
				card.name = "instantiatedRandomCard56a";
				
			}else if(card.name == "Card56b(Clone)"){
				
				card.name = "instantiatedRandomCard56b";
				
			}else if(card.name == "Card56c(Clone)"){
				
				card.name = "instantiatedRandomCard56c";
				
			}else if(card.name == "Card57(Clone)"){
				
				card.name = "instantiatedRandomCard57";
				
			}else if(card.name == "Card57a(Clone)"){
				
				card.name = "instantiatedRandomCard57a";
				
			}else if(card.name == "Card57b(Clone)"){
				
				card.name = "instantiatedRandomCard57b";
				
			}else if(card.name == "Card57c(Clone)"){
				
				card.name = "instantiatedRandomCard57c";
				
			}else if(card.name == "Card58(Clone)"){
				
				card.name = "instantiatedRandomCard58";
				
			}else if(card.name == "Card58a(Clone)"){
				
				card.name = "instantiatedRandomCard58a";
				
			}else if(card.name == "Card58b(Clone)"){
				
				card.name = "instantiatedRandomCard58b";
				
			}else if(card.name == "Card58c(Clone)"){
				
				card.name = "instantiatedRandomCard58c";
				
			}else if(card.name == "Card59(Clone)"){
				
				card.name = "instantiatedRandomCard59";
				
			}else if(card.name == "Card59a(Clone)"){
				
				card.name = "instantiatedRandomCard59a";
				
			}else if(card.name == "Card59b(Clone)"){
				
				card.name = "instantiatedRandomCard59b";
				
			}else if(card.name == "Card59c(Clone)"){
				
				card.name = "instantiatedRandomCard59c";
				
			}else if(card.name == "Card60(Clone)"){
				
				card.name = "instantiatedRandomCard60";
				
			}else if(card.name == "Card60a(Clone)"){
				
				card.name = "instantiatedRandomCard60a";
				
			}else if(card.name == "Card60b(Clone)"){
				
				card.name = "instantiatedRandomCard60b";
				
			}else if(card.name == "Card60c(Clone)"){
				
				card.name = "instantiatedRandomCard60c";
			}
			
			instances3++;
			
			}
			
		while(instances4 < NumberOfCards) {
			
			GameObject card = Instantiate (cardsInDeck240[Random.Range(0,cardsInDeck240.Length)], spawnPoints4.transform.position,spawnPoints4.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(325f,200f,340.0f);
			
			if(card.name == "Card1(Clone)"){
				
				card.name = "instantiatedRandomCard1";
				
			}else if(card.name == "Card1a(Clone)"){
				
				card.name = "instantiatedRandomCard1a";
				
			}else if(card.name == "Card1b(Clone)"){
				
				card.name = "instantiatedRandomCard1b";
				
			}else if(card.name == "Card1c(Clone)"){
				
				card.name = "instantiatedRandomCard1c";
				
			}else if(card.name == "Card2(Clone)"){
				
				card.name = "instantiatedRandomCard2";
				
			}else if(card.name == "Card2a(Clone)"){
				
				card.name = "instantiatedRandomCard2a";
				
			}else if(card.name == "Card2b(Clone)"){
				
				card.name = "instantiatedRandomCard2b";
				
			}else if(card.name == "Card2c(Clone)"){
				
				card.name = "instantiatedRandomCard2c";
				
			}else if(card.name == "Card3(Clone)"){
				
				card.name = "instantiatedRandomCard3";
				
			}else if(card.name == "Card3a(Clone)"){
				
				card.name = "instantiatedRandomCard3a";
				
			}else if(card.name == "Card3b(Clone)"){
				
				card.name = "instantiatedRandomCard3b";
				
			}else if(card.name == "Card3c(Clone)"){
				
				card.name = "instantiatedRandomCard3c";
				
			}else if(card.name == "Card4(Clone)"){
				
				card.name = "instantiatedRandomCard4";
				
			}else if(card.name == "Card4a(Clone)"){
				
				card.name = "instantiatedRandomCard4a";
				
			}else if(card.name == "Card4b(Clone)"){
				
				card.name = "instantiatedRandomCard4b";
				
			}else if(card.name == "Card4c(Clone)"){
				
				card.name = "instantiatedRandomCard4c";
				
			}else if(card.name == "Card5(Clone)"){
				
				card.name = "instantiatedRandomCard5";
				
			}else if(card.name == "Card5a(Clone)"){
				
				card.name = "instantiatedRandomCard5a";
				
			}else if(card.name == "Card5b(Clone)"){
				
				card.name = "instantiatedRandomCard5b";
				
			}else if(card.name == "Card5c(Clone)"){
				
				card.name = "instantiatedRandomCard5c";
				
			}else if(card.name == "Card6(Clone)"){
				
				card.name = "instantiatedRandomCard6";
				
			}else if(card.name == "Card6a(Clone)"){
				
				card.name = "instantiatedRandomCard6a";
				
			}else if(card.name == "Card6b(Clone)"){
				
				card.name = "instantiatedRandomCard6b";
				
			}else if(card.name == "Card6c(Clone)"){
				
				card.name = "instantiatedRandomCard6c";
				
			}else if(card.name == "Card7(Clone)"){
				
				card.name = "instantiatedRandomCard7";
				
			}else if(card.name == "Card7a(Clone)"){
				
				card.name = "instantiatedRandomCard7a";
				
			}else if(card.name == "Card7b(Clone)"){
				
				card.name = "instantiatedRandomCard7b";
				
			}else if(card.name == "Card7c(Clone)"){
				
				card.name = "instantiatedRandomCard7c";
				
			}else if(card.name == "Card8(Clone)"){
				
				card.name = "instantiatedRandomCard8";
				
			}else if(card.name == "Card8a(Clone)"){
				
				card.name = "instantiatedRandomCard8a";
				
			}else if(card.name == "Card8b(Clone)"){
				
				card.name = "instantiatedRandomCard8b";
				
			}else if(card.name == "Card8c(Clone)"){
				
				card.name = "instantiatedRandomCard8c";
				
			}else if(card.name == "Card9(Clone)"){
				
				card.name = "instantiatedRandomCard9";
				
			}else if(card.name == "Card9a(Clone)"){
				
				card.name = "instantiatedRandomCard9a";
				
			}else if(card.name == "Card9b(Clone)"){
				
				card.name = "instantiatedRandomCard9b";
				
			}else if(card.name == "Card9c(Clone)"){
				
				card.name = "instantiatedRandomCard9c";
				
			}else if(card.name == "Card10(Clone)"){
				
				card.name = "instantiatedAICard10";
				
			}else if(card.name == "Card10a(Clone)"){
				
				card.name = "instantiatedRandomCard10a";
				
			}else if(card.name == "Card10b(Clone)"){
				
				card.name = "instantiatedRandomCard10b";
				
			}else if(card.name == "Card10c(Clone)"){
				
				card.name = "instantiatedRandomCard10c";
				
			}else if(card.name == "Card11(Clone)"){
				
				card.name = "instantiatedRandomCard11";
				
			}else if(card.name == "Card11a(Clone)"){
				
				card.name = "instantiatedRandomCard11a";
				
			}else if(card.name == "Card11b(Clone)"){
				
				card.name = "instantiatedRandomCard11b";
				
			}else if(card.name == "Card11c(Clone)"){
				
				card.name = "instantiatedRandomCard11c";
				
			}else if(card.name == "Card12(Clone)"){
				
				card.name = "instantiatedRandomCard12";
				
			}else if(card.name == "Card12a(Clone)"){
				
				card.name = "instantiatedRandomCard12a";
				
			}else if(card.name == "Card12b(Clone)"){
				
				card.name = "instantiatedRandomCard12b";
				
			}else if(card.name == "Card12c(Clone)"){
				
				card.name = "instantiatedRandomCard12c";
				
			}else if(card.name == "Card13(Clone)"){
				
				card.name = "instantiatedRandomCard13";
				
			}else if(card.name == "Card13a(Clone)"){
				
				card.name = "instantiatedRandomCard13a";
				
			}else if(card.name == "Card13b(Clone)"){
				
				card.name = "instantiatedRandomCard13b";
				
			}else if(card.name == "Card13c(Clone)"){
				
				card.name = "instantiatedRandomCard13c";
				
			}else if(card.name == "Card14(Clone)"){
				
				card.name = "instantiatedRandomCard14";
				
			}else if(card.name == "Card14a(Clone)"){
				
				card.name = "instantiatedRandomCard14a";
				
			}else if(card.name == "Card14b(Clone)"){
				
				card.name = "instantiatedRandomCard14b";
				
			}else if(card.name == "Card14c(Clone)"){
				
				card.name = "instantiatedRandomCard14c";
				
			}else if(card.name == "Card15(Clone)"){
				
				card.name = "instantiatedRandomCard15";
				
			}else if(card.name == "Card15a(Clone)"){
				
				card.name = "instantiatedRandomCard15a";
				
			}else if(card.name == "Card15b(Clone)"){
				
				card.name = "instantiatedRandomCard15b";
				
			}else if(card.name == "Card15c(Clone)"){
				
				card.name = "instantiatedRandomCard15c";
				
			}else if(card.name == "Card16(Clone)"){
				
				card.name = "instantiatedRandomCard16";
				
			}else if(card.name == "Card16a(Clone)"){
				
				card.name = "instantiatedRandomCard16a";
				
			}else if(card.name == "Card16b(Clone)"){
				
				card.name = "instantiatedRandomCard16b";
				
			}else if(card.name == "Card16c(Clone)"){
				
				card.name = "instantiatedRandomCard16c";
				
			}else if(card.name == "Card17(Clone)"){
				
				card.name = "instantiatedRandomCard17";
				
			}else if(card.name == "Card17a(Clone)"){
				
				card.name = "instantiatedRandomCard17a";
				
			}else if(card.name == "Card17b(Clone)"){
				
				card.name = "instantiatedRandomCard17b";
				
			}else if(card.name == "Card17c(Clone)"){
				
				card.name = "instantiatedRandomCard17c";
				
			}else if(card.name == "Card18(Clone)"){
				
				card.name = "instantiatedRandomCard18";
				
			}else if(card.name == "Card18a(Clone)"){
				
				card.name = "instantiatedRandomCard18a";
				
			}else if(card.name == "Card18b(Clone)"){
				
				card.name = "instantiatedRandomCard18b";
				
			}else if(card.name == "Card18c(Clone)"){
				
				card.name = "instantiatedRandomCard18c";
				
			}else if(card.name == "Card19(Clone)"){
				
				card.name = "instantiatedRandomCard19";
				
			}else if(card.name == "Card19a(Clone)"){
				
				card.name = "instantiatedRandomCard19a";
				
			}else if(card.name == "Card19b(Clone)"){
				
				card.name = "instantiatedRandomCard19b";
				
			}else if(card.name == "Card19c(Clone)"){
				
				card.name = "instantiatedRandomCard19c";
				
			}else if(card.name == "Card20(Clone)"){
				
				card.name = "instantiatedRandomCard20";
				
			}else if(card.name == "Card20a(Clone)"){
				
				card.name = "instantiatedRandomCard20a";
				
			}else if(card.name == "Card20b(Clone)"){
				
				card.name = "instantiatedRandomCard20b";
				
			}else if(card.name == "Card20c(Clone)"){
				
				card.name = "instantiatedRandomCard20c";
				
			}else if(card.name == "Card21(Clone)"){
				
				card.name = "instantiatedRandomCard21";
				
			}else if(card.name == "Card21a(Clone)"){
				
				card.name = "instantiatedRandomCard21a";
				
			}else if(card.name == "Card21b(Clone)"){
				
				card.name = "instantiatedRandomCard21b";
				
			}else if(card.name == "Card21c(Clone)"){
				
				card.name = "instantiatedRandomCard21c";
				
			}else if(card.name == "Card22(Clone)"){
				
				card.name = "instantiatedRandomCard22";
				
			}else if(card.name == "Card22a(Clone)"){
				
				card.name = "instantiatedRandomCard22a";
				
			}else if(card.name == "Card22b(Clone)"){
				
				card.name = "instantiatedRandomCard22b";
				
			}else if(card.name == "Card22c(Clone)"){
				
				card.name = "instantiatedRandomCard22c";
				
			}else if(card.name == "Card23(Clone)"){
				
				card.name = "instantiatedRandomCard23";
				
			}else if(card.name == "Card23a(Clone)"){
				
				card.name = "instantiatedRandomCard23a";
				
			}else if(card.name == "Card23b(Clone)"){
				
				card.name = "instantiatedRandomCard23b";
				
			}else if(card.name == "Card23c(Clone)"){
				
				card.name = "instantiatedRandomCard23c";
				
			}else if(card.name == "Card24(Clone)"){
				
				card.name = "instantiatedRandomCard24";
				
			}else if(card.name == "Card24a(Clone)"){
				
				card.name = "instantiatedRandomCard24a";
				
			}else if(card.name == "Card24b(Clone)"){
				
				card.name = "instantiatedRandomCard24b";
				
			}else if(card.name == "Card24c(Clone)"){
				
				card.name = "instantiatedRandomCard24c";
				
			}else if(card.name == "Card25(Clone)"){
				
				card.name = "instantiatedRandomCard25";
				
			}else if(card.name == "Card25a(Clone)"){
				
				card.name = "instantiatedRandomCard25a";
				
			}else if(card.name == "Card25b(Clone)"){
				
				card.name = "instantiatedRandomCard25b";
				
			}else if(card.name == "Card25c(Clone)"){
				
				card.name = "instantiatedRandomCard25c";
				
			}else if(card.name == "Card26(Clone)"){
				
				card.name = "instantiatedRandomCard26";
				
			}else if(card.name == "Card26a(Clone)"){
				
				card.name = "instantiatedRandomCard26a";
				
			}else if(card.name == "Card26b(Clone)"){
				
				card.name = "instantiatedRandomCard26b";
				
			}else if(card.name == "Card26c(Clone)"){
				
				card.name = "instantiatedRandomCard26c";
				
			}else if(card.name == "Card27(Clone)"){
				
				card.name = "instantiatedRandomCard27";
				
			}else if(card.name == "Card27a(Clone)"){
				
				card.name = "instantiatedRandomCard27a";
				
			}else if(card.name == "Card27b(Clone)"){
				
				card.name = "instantiatedRandomCard27b";
				
			}else if(card.name == "Card27c(Clone)"){
				
				card.name = "instantiatedRandomCard27c";
				
			}else if(card.name == "Card28(Clone)"){
				
				card.name = "instantiatedRandomCard28";
				
			}else if(card.name == "Card28a(Clone)"){
				
				card.name = "instantiatedRandomCard28a";
				
			}else if(card.name == "Card28b(Clone)"){
				
				card.name = "instantiatedRandomCard28b";
				
			}else if(card.name == "Card28c(Clone)"){
				
				card.name = "instantiatedRandomCard28c";
				
			}else if(card.name == "Card29(Clone)"){
				
				card.name = "instantiatedRandomCard29";
				
			}else if(card.name == "Card29a(Clone)"){
				
				card.name = "instantiatedRandomCard29a";
				
			}else if(card.name == "Card29b(Clone)"){
				
				card.name = "instantiatedRandomCard29b";
				
			}else if(card.name == "Card29c(Clone)"){
				
				card.name = "instantiatedRandomCard29c";
				
			}else if(card.name == "Card30(Clone)"){
				
				card.name = "instantiatedRandomCard30";
				
			}else if(card.name == "Card30a(Clone)"){
				
				card.name = "instantiatedRandomCard30a";
				
			}else if(card.name == "Card30b(Clone)"){
				
				card.name = "instantiatedRandomCard30b";
				
			}else if(card.name == "Card30c(Clone)"){
				
				card.name = "instantiatedRandomCard30c";
				
			}else if(card.name == "Card31(Clone)"){
				
				card.name = "instantiatedRandomCard31";
				
			}else if(card.name == "Card31a(Clone)"){
				
				card.name = "instantiatedRandomCard31a";
				
			}else if(card.name == "Card31b(Clone)"){
				
				card.name = "instantiatedRandomCard31b";
				
			}else if(card.name == "Card31c(Clone)"){
				
				card.name = "instantiatedRandomCard31c";
				
			}else if(card.name == "Card32(Clone)"){
				
				card.name = "instantiatedRandomCard32";
				
			}else if(card.name == "Card32a(Clone)"){
				
				card.name = "instantiatedRandomCard32a";
				
			}else if(card.name == "Card32b(Clone)"){
				
				card.name = "instantiatedRandomCard32b";
				
			}else if(card.name == "Card32c(Clone)"){
				
				card.name = "instantiatedRandomCard32c";
				
			}else if(card.name == "Card33(Clone)"){
				
				card.name = "instantiatedRandomCard33";
				
			}else if(card.name == "Card33a(Clone)"){
				
				card.name = "instantiatedRandomCard33a";
				
			}else if(card.name == "Card33b(Clone)"){
				
				card.name = "instantiatedRandomCard33b";
				
			}else if(card.name == "Card33c(Clone)"){
				
				card.name = "instantiatedRandomCard33c";
				
			}else if(card.name == "Card34(Clone)"){
				
				card.name = "instantiatedRandomCard34";
				
			}else if(card.name == "Card34a(Clone)"){
				
				card.name = "instantiatedRandomCard34a";
				
			}else if(card.name == "Card34b(Clone)"){
				
				card.name = "instantiatedRandomCard34b";
				
			}else if(card.name == "Card34c(Clone)"){
				
				card.name = "instantiatedRandomCard34c";
				
			}else if(card.name == "Card35(Clone)"){
				
				card.name = "instantiatedRandomCard35";
				
			}else if(card.name == "Card35a(Clone)"){
				
				card.name = "instantiatedRandomCard35a";
				
			}else if(card.name == "Card35b(Clone)"){
				
				card.name = "instantiatedRandomCard35b";
				
			}else if(card.name == "Card35c(Clone)"){
				
				card.name = "instantiatedRandomCard35c";
				
			}else if(card.name == "Card36(Clone)"){
				
				card.name = "instantiatedRandomCard36";
				
			}else if(card.name == "Card36a(Clone)"){
				
				card.name = "instantiatedRandomCard36a";
				
			}else if(card.name == "Card36b(Clone)"){
				
				card.name = "instantiatedRandomCard36b";
				
			}else if(card.name == "Card36c(Clone)"){
				
				card.name = "instantiatedRandomCard36c";
				
			}else if(card.name == "Card37(Clone)"){
				
				card.name = "instantiatedRandomCard37";
				
			}else if(card.name == "Card37a(Clone)"){
				
				card.name = "instantiatedRandomCard37a";
				
			}else if(card.name == "Card37b(Clone)"){
				
				card.name = "instantiatedRandomCard37b";
				
			}else if(card.name == "Card37c(Clone)"){
				
				card.name = "instantiatedRandomCard37c";
				
			}else if(card.name == "Card38(Clone)"){
				
				card.name = "instantiatedRandomCard38";
				
			}else if(card.name == "Card38a(Clone)"){
				
				card.name = "instantiatedRandomCard38a";
				
			}else if(card.name == "Card38b(Clone)"){
				
				card.name = "instantiatedRandomCard38b";
				
			}else if(card.name == "Card38c(Clone)"){
				
				card.name = "instantiatedRandomCard38c";
				
			}else if(card.name == "Card39(Clone)"){
				
				card.name = "instantiatedRandomCard39";
				
			}else if(card.name == "Card39a(Clone)"){
				
				card.name = "instantiatedRandomCard39a";
				
			}else if(card.name == "Card39b(Clone)"){
				
				card.name = "instantiatedRandomCard39b";
				
			}else if(card.name == "Card39c(Clone)"){
				
				card.name = "instantiatedRandomCard39c";
				
			}else if(card.name == "Card40(Clone)"){
				
				card.name = "instantiatedRandomCard40";
				
			}else if(card.name == "Card40a(Clone)"){
				
				card.name = "instantiatedRandomCard40a";
				
			}else if(card.name == "Card40b(Clone)"){
				
				card.name = "instantiatedRandomCard40b";
				
			}else if(card.name == "Card40c(Clone)"){
				
				card.name = "instantiatedRandomCard40c";
				
			}else if(card.name == "Card41(Clone)"){
				
				card.name = "instantiatedRandomCard41";
				
			}else if(card.name == "Card41a(Clone)"){
				
				card.name = "instantiatedRandomCard41a";
				
			}else if(card.name == "Card41b(Clone)"){
				
				card.name = "instantiatedRandomCard41b";
				
			}else if(card.name == "Card41c(Clone)"){
				
				card.name = "instantiatedRandomCard41c";
				
			}else if(card.name == "Card42(Clone)"){
				
				card.name = "instantiatedRandomCard42";
				
			}else if(card.name == "Card42a(Clone)"){
				
				card.name = "instantiatedRandomCard42a";
				
			}else if(card.name == "Card42b(Clone)"){
				
				card.name = "instantiatedRandomCard42b";
				
			}else if(card.name == "Card42c(Clone)"){
				
				card.name = "instantiatedRandomCard42c";
				
			}else if(card.name == "Card43(Clone)"){
				
				card.name = "instantiatedRandomCard43";
				
			}else if(card.name == "Card43a(Clone)"){
				
				card.name = "instantiatedRandomCard43a";
				
			}else if(card.name == "Card43b(Clone)"){
				
				card.name = "instantiatedRandomCard43b";
				
			}else if(card.name == "Card43c(Clone)"){
				
				card.name = "instantiatedRandomCard43c";
				
			}else if(card.name == "Card44(Clone)"){
				
				card.name = "instantiatedRandomCard44";
				
			}else if(card.name == "Card44a(Clone)"){
				
				card.name = "instantiatedRandomCard44a";
				
			}else if(card.name == "Card44b(Clone)"){
				
				card.name = "instantiatedRandomCard44b";
				
			}else if(card.name == "Card44c(Clone)"){
				
				card.name = "instantiatedRandomCard44c";
				
			}else if(card.name == "Card45(Clone)"){
				
				card.name = "instantiatedRandomCard45";
				
			}else if(card.name == "Card45a(Clone)"){
				
				card.name = "instantiatedRandomCard45a";
				
			}else if(card.name == "Card45b(Clone)"){
				
				card.name = "instantiatedRandomCard45b";
				
			}else if(card.name == "Card45c(Clone)"){
				
				card.name = "instantiatedRandomCard45c";
				
			}else if(card.name == "Card46(Clone)"){
				
				card.name = "instantiatedRandomCard46";
				
			}else if(card.name == "Card46a(Clone)"){
				
				card.name = "instantiatedRandomCard46a";
				
			}else if(card.name == "Card46b(Clone)"){
				
				card.name = "instantiatedRandomCard46b";
				
			}else if(card.name == "Card46c(Clone)"){
				
				card.name = "instantiatedRandomCard46c";
				
			}else if(card.name == "Card47(Clone)"){
				
				card.name = "instantiatedRandomCard47";
				
			}else if(card.name == "Card47a(Clone)"){
				
				card.name = "instantiatedRandomCard47a";
				
			}else if(card.name == "Card47b(Clone)"){
				
				card.name = "instantiatedRandomCard47b";
				
			}else if(card.name == "Card47c(Clone)"){
				
				card.name = "instantiatedRandomCard47c";
				
			}else if(card.name == "Card48(Clone)"){
				
				card.name = "instantiatedRandomCard48";
				
			}else if(card.name == "Card48a(Clone)"){
				
				card.name = "instantiatedRandomCard48a";
				
			}else if(card.name == "Card48b(Clone)"){
				
				card.name = "instantiatedRandomCard48b";
				
			}else if(card.name == "Card48c(Clone)"){
				
				card.name = "instantiatedRandomCard48c";
				
			}else if(card.name == "Card49(Clone)"){
				
				card.name = "instantiatedRandomCard49";
				
			}else if(card.name == "Card49a(Clone)"){
				
				card.name = "instantiatedRandomCard49a";
				
			}else if(card.name == "Card49b(Clone)"){
				
				card.name = "instantiatedRandomCard49b";
				
			}else if(card.name == "Card49c(Clone)"){
				
				card.name = "instantiatedRandomCard49c";
				
			}else if(card.name == "Card50(Clone)"){
				
				card.name = "instantiatedRandomCard50";
				
			}else if(card.name == "Card50a(Clone)"){
				
				card.name = "instantiatedRandomCard50a";
				
			}else if(card.name == "Card50b(Clone)"){
				
				card.name = "instantiatedRandomCard50b";
				
			}else if(card.name == "Card50c(Clone)"){
				
				card.name = "instantiatedRandomCard50c";
				
			}else if(card.name == "Card51(Clone)"){
				
				card.name = "instantiatedRandomCard51";
				
			}else if(card.name == "Card51a(Clone)"){
				
				card.name = "instantiatedRandomCard51a";
				
			}else if(card.name == "Card51b(Clone)"){
				
				card.name = "instantiatedRandomCard51b";
				
			}else if(card.name == "Card51c(Clone)"){
				
				card.name = "instantiatedRandomCard51c";
				
			}else if(card.name == "Card52(Clone)"){
				
				card.name = "instantiatedRandomCard52";
				
			}else if(card.name == "Card52a(Clone)"){
				
				card.name = "instantiatedRandomCard52a";
				
			}else if(card.name == "Card52b(Clone)"){
				
				card.name = "instantiatedRandomCard52b";
				
			}else if(card.name == "Card52c(Clone)"){
				
				card.name = "instantiatedRandomCard52c";
				
			}else if(card.name == "Card53(Clone)"){
				
				card.name = "instantiatedRandomCard53";
				
			}else if(card.name == "Card53a(Clone)"){
				
				card.name = "instantiatedRandomCard53a";
				
			}else if(card.name == "Card53b(Clone)"){
				
				card.name = "instantiatedRandomCard53b";
				
			}else if(card.name == "Card53c(Clone)"){
				
				card.name = "instantiatedRandomCard53c";
				
			}else if(card.name == "Card54(Clone)"){
				
				card.name = "instantiatedRandomCard54";
				
			}else if(card.name == "Card54a(Clone)"){
				
				card.name = "instantiatedRandomCard54a";
				
			}else if(card.name == "Card54b(Clone)"){
				
				card.name = "instantiatedRandomCard54b";
				
			}else if(card.name == "Card54c(Clone)"){
				
				card.name = "instantiatedRandomCard54c";
				
			}else if(card.name == "Card55(Clone)"){
				
				card.name = "instantiatedRandomCard55";
				
			}else if(card.name == "Card55a(Clone)"){
				
				card.name = "instantiatedRandomCard55a";
				
			}else if(card.name == "Card55b(Clone)"){
				
				card.name = "instantiatedRandomCard55b";
				
			}else if(card.name == "Card55c(Clone)"){
				
				card.name = "instantiatedRandomCard55c";
				
			}else if(card.name == "Card56(Clone)"){
				
				card.name = "instantiatedRandomCard56";
				
			}else if(card.name == "Card56a(Clone)"){
				
				card.name = "instantiatedRandomCard56a";
				
			}else if(card.name == "Card56b(Clone)"){
				
				card.name = "instantiatedRandomCard56b";
				
			}else if(card.name == "Card56c(Clone)"){
				
				card.name = "instantiatedRandomCard56c";
				
			}else if(card.name == "Card57(Clone)"){
				
				card.name = "instantiatedRandomCard57";
				
			}else if(card.name == "Card57a(Clone)"){
				
				card.name = "instantiatedRandomCard57a";
				
			}else if(card.name == "Card57b(Clone)"){
				
				card.name = "instantiatedRandomCard57b";
				
			}else if(card.name == "Card57c(Clone)"){
				
				card.name = "instantiatedRandomCard57c";
				
			}else if(card.name == "Card58(Clone)"){
				
				card.name = "instantiatedRandomCard58";
				
			}else if(card.name == "Card58a(Clone)"){
				
				card.name = "instantiatedRandomCard58a";
				
			}else if(card.name == "Card58b(Clone)"){
				
				card.name = "instantiatedRandomCard58b";
				
			}else if(card.name == "Card58c(Clone)"){
				
				card.name = "instantiatedRandomCard58c";
				
			}else if(card.name == "Card59(Clone)"){
				
				card.name = "instantiatedRandomCard59";
				
			}else if(card.name == "Card59a(Clone)"){
				
				card.name = "instantiatedRandomCard59a";
				
			}else if(card.name == "Card59b(Clone)"){
				
				card.name = "instantiatedRandomCard59b";
				
			}else if(card.name == "Card59c(Clone)"){
				
				card.name = "instantiatedRandomCard59c";
				
			}else if(card.name == "Card60(Clone)"){
				
				card.name = "instantiatedRandomCard60";
				
			}else if(card.name == "Card60a(Clone)"){
				
				card.name = "instantiatedRandomCard60a";
				
			}else if(card.name == "Card60b(Clone)"){
				
				card.name = "instantiatedRandomCard60b";
				
			}else if(card.name == "Card60c(Clone)"){
				
				card.name = "instantiatedRandomCard60c";
			}
			
			instances4++;
			
			}
			
		while(instances5 < NumberOfCards) {
			
			GameObject card = Instantiate (cardsInDeck240[Random.Range(0,cardsInDeck240.Length)], spawnPoints5.transform.position,spawnPoints5.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(325f,200f,340.0f);
			
			if(card.name == "Card1(Clone)"){
				
				card.name = "instantiatedRandomCard1";
				
			}else if(card.name == "Card1a(Clone)"){
				
				card.name = "instantiatedRandomCard1a";
				
			}else if(card.name == "Card1b(Clone)"){
				
				card.name = "instantiatedRandomCard1b";
				
			}else if(card.name == "Card1c(Clone)"){
				
				card.name = "instantiatedRandomCard1c";
				
			}else if(card.name == "Card2(Clone)"){
				
				card.name = "instantiatedRandomCard2";
				
			}else if(card.name == "Card2a(Clone)"){
				
				card.name = "instantiatedRandomCard2a";
				
			}else if(card.name == "Card2b(Clone)"){
				
				card.name = "instantiatedRandomCard2b";
				
			}else if(card.name == "Card2c(Clone)"){
				
				card.name = "instantiatedRandomCard2c";
				
			}else if(card.name == "Card3(Clone)"){
				
				card.name = "instantiatedRandomCard3";
				
			}else if(card.name == "Card3a(Clone)"){
				
				card.name = "instantiatedRandomCard3a";
				
			}else if(card.name == "Card3b(Clone)"){
				
				card.name = "instantiatedRandomCard3b";
				
			}else if(card.name == "Card3c(Clone)"){
				
				card.name = "instantiatedRandomCard3c";
				
			}else if(card.name == "Card4(Clone)"){
				
				card.name = "instantiatedRandomCard4";
				
			}else if(card.name == "Card4a(Clone)"){
				
				card.name = "instantiatedRandomCard4a";
				
			}else if(card.name == "Card4b(Clone)"){
				
				card.name = "instantiatedRandomCard4b";
				
			}else if(card.name == "Card4c(Clone)"){
				
				card.name = "instantiatedRandomCard4c";
				
			}else if(card.name == "Card5(Clone)"){
				
				card.name = "instantiatedRandomCard5";
				
			}else if(card.name == "Card5a(Clone)"){
				
				card.name = "instantiatedRandomCard5a";
				
			}else if(card.name == "Card5b(Clone)"){
				
				card.name = "instantiatedRandomCard5b";
				
			}else if(card.name == "Card5c(Clone)"){
				
				card.name = "instantiatedRandomCard5c";
				
			}else if(card.name == "Card6(Clone)"){
				
				card.name = "instantiatedRandomCard6";
				
			}else if(card.name == "Card6a(Clone)"){
				
				card.name = "instantiatedRandomCard6a";
				
			}else if(card.name == "Card6b(Clone)"){
				
				card.name = "instantiatedRandomCard6b";
				
			}else if(card.name == "Card6c(Clone)"){
				
				card.name = "instantiatedRandomCard6c";
				
			}else if(card.name == "Card7(Clone)"){
				
				card.name = "instantiatedRandomCard7";
				
			}else if(card.name == "Card7a(Clone)"){
				
				card.name = "instantiatedRandomCard7a";
				
			}else if(card.name == "Card7b(Clone)"){
				
				card.name = "instantiatedRandomCard7b";
				
			}else if(card.name == "Card7c(Clone)"){
				
				card.name = "instantiatedRandomCard7c";
				
			}else if(card.name == "Card8(Clone)"){
				
				card.name = "instantiatedRandomCard8";
				
			}else if(card.name == "Card8a(Clone)"){
				
				card.name = "instantiatedRandomCard8a";
				
			}else if(card.name == "Card8b(Clone)"){
				
				card.name = "instantiatedRandomCard8b";
				
			}else if(card.name == "Card8c(Clone)"){
				
				card.name = "instantiatedRandomCard8c";
				
			}else if(card.name == "Card9(Clone)"){
				
				card.name = "instantiatedRandomCard9";
				
			}else if(card.name == "Card9a(Clone)"){
				
				card.name = "instantiatedRandomCard9a";
				
			}else if(card.name == "Card9b(Clone)"){
				
				card.name = "instantiatedRandomCard9b";
				
			}else if(card.name == "Card9c(Clone)"){
				
				card.name = "instantiatedRandomCard9c";
				
			}else if(card.name == "Card10(Clone)"){
				
				card.name = "instantiatedAICard10";
				
			}else if(card.name == "Card10a(Clone)"){
				
				card.name = "instantiatedRandomCard10a";
				
			}else if(card.name == "Card10b(Clone)"){
				
				card.name = "instantiatedRandomCard10b";
				
			}else if(card.name == "Card10c(Clone)"){
				
				card.name = "instantiatedRandomCard10c";
				
			}else if(card.name == "Card11(Clone)"){
				
				card.name = "instantiatedRandomCard11";
				
			}else if(card.name == "Card11a(Clone)"){
				
				card.name = "instantiatedRandomCard11a";
				
			}else if(card.name == "Card11b(Clone)"){
				
				card.name = "instantiatedRandomCard11b";
				
			}else if(card.name == "Card11c(Clone)"){
				
				card.name = "instantiatedRandomCard11c";
				
			}else if(card.name == "Card12(Clone)"){
				
				card.name = "instantiatedRandomCard12";
				
			}else if(card.name == "Card12a(Clone)"){
				
				card.name = "instantiatedRandomCard12a";
				
			}else if(card.name == "Card12b(Clone)"){
				
				card.name = "instantiatedRandomCard12b";
				
			}else if(card.name == "Card12c(Clone)"){
				
				card.name = "instantiatedRandomCard12c";
				
			}else if(card.name == "Card13(Clone)"){
				
				card.name = "instantiatedRandomCard13";
				
			}else if(card.name == "Card13a(Clone)"){
				
				card.name = "instantiatedRandomCard13a";
				
			}else if(card.name == "Card13b(Clone)"){
				
				card.name = "instantiatedRandomCard13b";
				
			}else if(card.name == "Card13c(Clone)"){
				
				card.name = "instantiatedRandomCard13c";
				
			}else if(card.name == "Card14(Clone)"){
				
				card.name = "instantiatedRandomCard14";
				
			}else if(card.name == "Card14a(Clone)"){
				
				card.name = "instantiatedRandomCard14a";
				
			}else if(card.name == "Card14b(Clone)"){
				
				card.name = "instantiatedRandomCard14b";
				
			}else if(card.name == "Card14c(Clone)"){
				
				card.name = "instantiatedRandomCard14c";
				
			}else if(card.name == "Card15(Clone)"){
				
				card.name = "instantiatedRandomCard15";
				
			}else if(card.name == "Card15a(Clone)"){
				
				card.name = "instantiatedRandomCard15a";
				
			}else if(card.name == "Card15b(Clone)"){
				
				card.name = "instantiatedRandomCard15b";
				
			}else if(card.name == "Card15c(Clone)"){
				
				card.name = "instantiatedRandomCard15c";
				
			}else if(card.name == "Card16(Clone)"){
				
				card.name = "instantiatedRandomCard16";
				
			}else if(card.name == "Card16a(Clone)"){
				
				card.name = "instantiatedRandomCard16a";
				
			}else if(card.name == "Card16b(Clone)"){
				
				card.name = "instantiatedRandomCard16b";
				
			}else if(card.name == "Card16c(Clone)"){
				
				card.name = "instantiatedRandomCard16c";
				
			}else if(card.name == "Card17(Clone)"){
				
				card.name = "instantiatedRandomCard17";
				
			}else if(card.name == "Card17a(Clone)"){
				
				card.name = "instantiatedRandomCard17a";
				
			}else if(card.name == "Card17b(Clone)"){
				
				card.name = "instantiatedRandomCard17b";
				
			}else if(card.name == "Card17c(Clone)"){
				
				card.name = "instantiatedRandomCard17c";
				
			}else if(card.name == "Card18(Clone)"){
				
				card.name = "instantiatedRandomCard18";
				
			}else if(card.name == "Card18a(Clone)"){
				
				card.name = "instantiatedRandomCard18a";
				
			}else if(card.name == "Card18b(Clone)"){
				
				card.name = "instantiatedRandomCard18b";
				
			}else if(card.name == "Card18c(Clone)"){
				
				card.name = "instantiatedRandomCard18c";
				
			}else if(card.name == "Card19(Clone)"){
				
				card.name = "instantiatedRandomCard19";
				
			}else if(card.name == "Card19a(Clone)"){
				
				card.name = "instantiatedRandomCard19a";
				
			}else if(card.name == "Card19b(Clone)"){
				
				card.name = "instantiatedRandomCard19b";
				
			}else if(card.name == "Card19c(Clone)"){
				
				card.name = "instantiatedRandomCard19c";
				
			}else if(card.name == "Card20(Clone)"){
				
				card.name = "instantiatedRandomCard20";
				
			}else if(card.name == "Card20a(Clone)"){
				
				card.name = "instantiatedRandomCard20a";
				
			}else if(card.name == "Card20b(Clone)"){
				
				card.name = "instantiatedRandomCard20b";
				
			}else if(card.name == "Card20c(Clone)"){
				
				card.name = "instantiatedRandomCard20c";
				
			}else if(card.name == "Card21(Clone)"){
				
				card.name = "instantiatedRandomCard21";
				
			}else if(card.name == "Card21a(Clone)"){
				
				card.name = "instantiatedRandomCard21a";
				
			}else if(card.name == "Card21b(Clone)"){
				
				card.name = "instantiatedRandomCard21b";
				
			}else if(card.name == "Card21c(Clone)"){
				
				card.name = "instantiatedRandomCard21c";
				
			}else if(card.name == "Card22(Clone)"){
				
				card.name = "instantiatedRandomCard22";
				
			}else if(card.name == "Card22a(Clone)"){
				
				card.name = "instantiatedRandomCard22a";
				
			}else if(card.name == "Card22b(Clone)"){
				
				card.name = "instantiatedRandomCard22b";
				
			}else if(card.name == "Card22c(Clone)"){
				
				card.name = "instantiatedRandomCard22c";
				
			}else if(card.name == "Card23(Clone)"){
				
				card.name = "instantiatedRandomCard23";
				
			}else if(card.name == "Card23a(Clone)"){
				
				card.name = "instantiatedRandomCard23a";
				
			}else if(card.name == "Card23b(Clone)"){
				
				card.name = "instantiatedRandomCard23b";
				
			}else if(card.name == "Card23c(Clone)"){
				
				card.name = "instantiatedRandomCard23c";
				
			}else if(card.name == "Card24(Clone)"){
				
				card.name = "instantiatedRandomCard24";
				
			}else if(card.name == "Card24a(Clone)"){
				
				card.name = "instantiatedRandomCard24a";
				
			}else if(card.name == "Card24b(Clone)"){
				
				card.name = "instantiatedRandomCard24b";
				
			}else if(card.name == "Card24c(Clone)"){
				
				card.name = "instantiatedRandomCard24c";
				
			}else if(card.name == "Card25(Clone)"){
				
				card.name = "instantiatedRandomCard25";
				
			}else if(card.name == "Card25a(Clone)"){
				
				card.name = "instantiatedRandomCard25a";
				
			}else if(card.name == "Card25b(Clone)"){
				
				card.name = "instantiatedRandomCard25b";
				
			}else if(card.name == "Card25c(Clone)"){
				
				card.name = "instantiatedRandomCard25c";
				
			}else if(card.name == "Card26(Clone)"){
				
				card.name = "instantiatedRandomCard26";
				
			}else if(card.name == "Card26a(Clone)"){
				
				card.name = "instantiatedRandomCard26a";
				
			}else if(card.name == "Card26b(Clone)"){
				
				card.name = "instantiatedRandomCard26b";
				
			}else if(card.name == "Card26c(Clone)"){
				
				card.name = "instantiatedRandomCard26c";
				
			}else if(card.name == "Card27(Clone)"){
				
				card.name = "instantiatedRandomCard27";
				
			}else if(card.name == "Card27a(Clone)"){
				
				card.name = "instantiatedRandomCard27a";
				
			}else if(card.name == "Card27b(Clone)"){
				
				card.name = "instantiatedRandomCard27b";
				
			}else if(card.name == "Card27c(Clone)"){
				
				card.name = "instantiatedRandomCard27c";
				
			}else if(card.name == "Card28(Clone)"){
				
				card.name = "instantiatedRandomCard28";
				
			}else if(card.name == "Card28a(Clone)"){
				
				card.name = "instantiatedRandomCard28a";
				
			}else if(card.name == "Card28b(Clone)"){
				
				card.name = "instantiatedRandomCard28b";
				
			}else if(card.name == "Card28c(Clone)"){
				
				card.name = "instantiatedRandomCard28c";
				
			}else if(card.name == "Card29(Clone)"){
				
				card.name = "instantiatedRandomCard29";
				
			}else if(card.name == "Card29a(Clone)"){
				
				card.name = "instantiatedRandomCard29a";
				
			}else if(card.name == "Card29b(Clone)"){
				
				card.name = "instantiatedRandomCard29b";
				
			}else if(card.name == "Card29c(Clone)"){
				
				card.name = "instantiatedRandomCard29c";
				
			}else if(card.name == "Card30(Clone)"){
				
				card.name = "instantiatedRandomCard30";
				
			}else if(card.name == "Card30a(Clone)"){
				
				card.name = "instantiatedRandomCard30a";
				
			}else if(card.name == "Card30b(Clone)"){
				
				card.name = "instantiatedRandomCard30b";
				
			}else if(card.name == "Card30c(Clone)"){
				
				card.name = "instantiatedRandomCard30c";
				
			}else if(card.name == "Card31(Clone)"){
				
				card.name = "instantiatedRandomCard31";
				
			}else if(card.name == "Card31a(Clone)"){
				
				card.name = "instantiatedRandomCard31a";
				
			}else if(card.name == "Card31b(Clone)"){
				
				card.name = "instantiatedRandomCard31b";
				
			}else if(card.name == "Card31c(Clone)"){
				
				card.name = "instantiatedRandomCard31c";
				
			}else if(card.name == "Card32(Clone)"){
				
				card.name = "instantiatedRandomCard32";
				
			}else if(card.name == "Card32a(Clone)"){
				
				card.name = "instantiatedRandomCard32a";
				
			}else if(card.name == "Card32b(Clone)"){
				
				card.name = "instantiatedRandomCard32b";
				
			}else if(card.name == "Card32c(Clone)"){
				
				card.name = "instantiatedRandomCard32c";
				
			}else if(card.name == "Card33(Clone)"){
				
				card.name = "instantiatedRandomCard33";
				
			}else if(card.name == "Card33a(Clone)"){
				
				card.name = "instantiatedRandomCard33a";
				
			}else if(card.name == "Card33b(Clone)"){
				
				card.name = "instantiatedRandomCard33b";
				
			}else if(card.name == "Card33c(Clone)"){
				
				card.name = "instantiatedRandomCard33c";
				
			}else if(card.name == "Card34(Clone)"){
				
				card.name = "instantiatedRandomCard34";
				
			}else if(card.name == "Card34a(Clone)"){
				
				card.name = "instantiatedRandomCard34a";
				
			}else if(card.name == "Card34b(Clone)"){
				
				card.name = "instantiatedRandomCard34b";
				
			}else if(card.name == "Card34c(Clone)"){
				
				card.name = "instantiatedRandomCard34c";
				
			}else if(card.name == "Card35(Clone)"){
				
				card.name = "instantiatedRandomCard35";
				
			}else if(card.name == "Card35a(Clone)"){
				
				card.name = "instantiatedRandomCard35a";
				
			}else if(card.name == "Card35b(Clone)"){
				
				card.name = "instantiatedRandomCard35b";
				
			}else if(card.name == "Card35c(Clone)"){
				
				card.name = "instantiatedRandomCard35c";
				
			}else if(card.name == "Card36(Clone)"){
				
				card.name = "instantiatedRandomCard36";
				
			}else if(card.name == "Card36a(Clone)"){
				
				card.name = "instantiatedRandomCard36a";
				
			}else if(card.name == "Card36b(Clone)"){
				
				card.name = "instantiatedRandomCard36b";
				
			}else if(card.name == "Card36c(Clone)"){
				
				card.name = "instantiatedRandomCard36c";
				
			}else if(card.name == "Card37(Clone)"){
				
				card.name = "instantiatedRandomCard37";
				
			}else if(card.name == "Card37a(Clone)"){
				
				card.name = "instantiatedRandomCard37a";
				
			}else if(card.name == "Card37b(Clone)"){
				
				card.name = "instantiatedRandomCard37b";
				
			}else if(card.name == "Card37c(Clone)"){
				
				card.name = "instantiatedRandomCard37c";
				
			}else if(card.name == "Card38(Clone)"){
				
				card.name = "instantiatedRandomCard38";
				
			}else if(card.name == "Card38a(Clone)"){
				
				card.name = "instantiatedRandomCard38a";
				
			}else if(card.name == "Card38b(Clone)"){
				
				card.name = "instantiatedRandomCard38b";
				
			}else if(card.name == "Card38c(Clone)"){
				
				card.name = "instantiatedRandomCard38c";
				
			}else if(card.name == "Card39(Clone)"){
				
				card.name = "instantiatedRandomCard39";
				
			}else if(card.name == "Card39a(Clone)"){
				
				card.name = "instantiatedRandomCard39a";
				
			}else if(card.name == "Card39b(Clone)"){
				
				card.name = "instantiatedRandomCard39b";
				
			}else if(card.name == "Card39c(Clone)"){
				
				card.name = "instantiatedRandomCard39c";
				
			}else if(card.name == "Card40(Clone)"){
				
				card.name = "instantiatedRandomCard40";
				
			}else if(card.name == "Card40a(Clone)"){
				
				card.name = "instantiatedRandomCard40a";
				
			}else if(card.name == "Card40b(Clone)"){
				
				card.name = "instantiatedRandomCard40b";
				
			}else if(card.name == "Card40c(Clone)"){
				
				card.name = "instantiatedRandomCard40c";
				
			}else if(card.name == "Card41(Clone)"){
				
				card.name = "instantiatedRandomCard41";
				
			}else if(card.name == "Card41a(Clone)"){
				
				card.name = "instantiatedRandomCard41a";
				
			}else if(card.name == "Card41b(Clone)"){
				
				card.name = "instantiatedRandomCard41b";
				
			}else if(card.name == "Card41c(Clone)"){
				
				card.name = "instantiatedRandomCard41c";
				
			}else if(card.name == "Card42(Clone)"){
				
				card.name = "instantiatedRandomCard42";
				
			}else if(card.name == "Card42a(Clone)"){
				
				card.name = "instantiatedRandomCard42a";
				
			}else if(card.name == "Card42b(Clone)"){
				
				card.name = "instantiatedRandomCard42b";
				
			}else if(card.name == "Card42c(Clone)"){
				
				card.name = "instantiatedRandomCard42c";
				
			}else if(card.name == "Card43(Clone)"){
				
				card.name = "instantiatedRandomCard43";
				
			}else if(card.name == "Card43a(Clone)"){
				
				card.name = "instantiatedRandomCard43a";
				
			}else if(card.name == "Card43b(Clone)"){
				
				card.name = "instantiatedRandomCard43b";
				
			}else if(card.name == "Card43c(Clone)"){
				
				card.name = "instantiatedRandomCard43c";
				
			}else if(card.name == "Card44(Clone)"){
				
				card.name = "instantiatedRandomCard44";
				
			}else if(card.name == "Card44a(Clone)"){
				
				card.name = "instantiatedRandomCard44a";
				
			}else if(card.name == "Card44b(Clone)"){
				
				card.name = "instantiatedRandomCard44b";
				
			}else if(card.name == "Card44c(Clone)"){
				
				card.name = "instantiatedRandomCard44c";
				
			}else if(card.name == "Card45(Clone)"){
				
				card.name = "instantiatedRandomCard45";
				
			}else if(card.name == "Card45a(Clone)"){
				
				card.name = "instantiatedRandomCard45a";
				
			}else if(card.name == "Card45b(Clone)"){
				
				card.name = "instantiatedRandomCard45b";
				
			}else if(card.name == "Card45c(Clone)"){
				
				card.name = "instantiatedRandomCard45c";
				
			}else if(card.name == "Card46(Clone)"){
				
				card.name = "instantiatedRandomCard46";
				
			}else if(card.name == "Card46a(Clone)"){
				
				card.name = "instantiatedRandomCard46a";
				
			}else if(card.name == "Card46b(Clone)"){
				
				card.name = "instantiatedRandomCard46b";
				
			}else if(card.name == "Card46c(Clone)"){
				
				card.name = "instantiatedRandomCard46c";
				
			}else if(card.name == "Card47(Clone)"){
				
				card.name = "instantiatedRandomCard47";
				
			}else if(card.name == "Card47a(Clone)"){
				
				card.name = "instantiatedRandomCard47a";
				
			}else if(card.name == "Card47b(Clone)"){
				
				card.name = "instantiatedRandomCard47b";
				
			}else if(card.name == "Card47c(Clone)"){
				
				card.name = "instantiatedRandomCard47c";
				
			}else if(card.name == "Card48(Clone)"){
				
				card.name = "instantiatedRandomCard48";
				
			}else if(card.name == "Card48a(Clone)"){
				
				card.name = "instantiatedRandomCard48a";
				
			}else if(card.name == "Card48b(Clone)"){
				
				card.name = "instantiatedRandomCard48b";
				
			}else if(card.name == "Card48c(Clone)"){
				
				card.name = "instantiatedRandomCard48c";
				
			}else if(card.name == "Card49(Clone)"){
				
				card.name = "instantiatedRandomCard49";
				
			}else if(card.name == "Card49a(Clone)"){
				
				card.name = "instantiatedRandomCard49a";
				
			}else if(card.name == "Card49b(Clone)"){
				
				card.name = "instantiatedRandomCard49b";
				
			}else if(card.name == "Card49c(Clone)"){
				
				card.name = "instantiatedRandomCard49c";
				
			}else if(card.name == "Card50(Clone)"){
				
				card.name = "instantiatedRandomCard50";
				
			}else if(card.name == "Card50a(Clone)"){
				
				card.name = "instantiatedRandomCard50a";
				
			}else if(card.name == "Card50b(Clone)"){
				
				card.name = "instantiatedRandomCard50b";
				
			}else if(card.name == "Card50c(Clone)"){
				
				card.name = "instantiatedRandomCard50c";
				
			}else if(card.name == "Card51(Clone)"){
				
				card.name = "instantiatedRandomCard51";
				
			}else if(card.name == "Card51a(Clone)"){
				
				card.name = "instantiatedRandomCard51a";
				
			}else if(card.name == "Card51b(Clone)"){
				
				card.name = "instantiatedRandomCard51b";
				
			}else if(card.name == "Card51c(Clone)"){
				
				card.name = "instantiatedRandomCard51c";
				
			}else if(card.name == "Card52(Clone)"){
				
				card.name = "instantiatedRandomCard52";
				
			}else if(card.name == "Card52a(Clone)"){
				
				card.name = "instantiatedRandomCard52a";
				
			}else if(card.name == "Card52b(Clone)"){
				
				card.name = "instantiatedRandomCard52b";
				
			}else if(card.name == "Card52c(Clone)"){
				
				card.name = "instantiatedRandomCard52c";
				
			}else if(card.name == "Card53(Clone)"){
				
				card.name = "instantiatedRandomCard53";
				
			}else if(card.name == "Card53a(Clone)"){
				
				card.name = "instantiatedRandomCard53a";
				
			}else if(card.name == "Card53b(Clone)"){
				
				card.name = "instantiatedRandomCard53b";
				
			}else if(card.name == "Card53c(Clone)"){
				
				card.name = "instantiatedRandomCard53c";
				
			}else if(card.name == "Card54(Clone)"){
				
				card.name = "instantiatedRandomCard54";
				
			}else if(card.name == "Card54a(Clone)"){
				
				card.name = "instantiatedRandomCard54a";
				
			}else if(card.name == "Card54b(Clone)"){
				
				card.name = "instantiatedRandomCard54b";
				
			}else if(card.name == "Card54c(Clone)"){
				
				card.name = "instantiatedRandomCard54c";
				
			}else if(card.name == "Card55(Clone)"){
				
				card.name = "instantiatedRandomCard55";
				
			}else if(card.name == "Card55a(Clone)"){
				
				card.name = "instantiatedRandomCard55a";
				
			}else if(card.name == "Card55b(Clone)"){
				
				card.name = "instantiatedRandomCard55b";
				
			}else if(card.name == "Card55c(Clone)"){
				
				card.name = "instantiatedRandomCard55c";
				
			}else if(card.name == "Card56(Clone)"){
				
				card.name = "instantiatedRandomCard56";
				
			}else if(card.name == "Card56a(Clone)"){
				
				card.name = "instantiatedRandomCard56a";
				
			}else if(card.name == "Card56b(Clone)"){
				
				card.name = "instantiatedRandomCard56b";
				
			}else if(card.name == "Card56c(Clone)"){
				
				card.name = "instantiatedRandomCard56c";
				
			}else if(card.name == "Card57(Clone)"){
				
				card.name = "instantiatedRandomCard57";
				
			}else if(card.name == "Card57a(Clone)"){
				
				card.name = "instantiatedRandomCard57a";
				
			}else if(card.name == "Card57b(Clone)"){
				
				card.name = "instantiatedRandomCard57b";
				
			}else if(card.name == "Card57c(Clone)"){
				
				card.name = "instantiatedRandomCard57c";
				
			}else if(card.name == "Card58(Clone)"){
				
				card.name = "instantiatedRandomCard58";
				
			}else if(card.name == "Card58a(Clone)"){
				
				card.name = "instantiatedRandomCard58a";
				
			}else if(card.name == "Card58b(Clone)"){
				
				card.name = "instantiatedRandomCard58b";
				
			}else if(card.name == "Card58c(Clone)"){
				
				card.name = "instantiatedRandomCard58c";
				
			}else if(card.name == "Card59(Clone)"){
				
				card.name = "instantiatedRandomCard59";
				
			}else if(card.name == "Card59a(Clone)"){
				
				card.name = "instantiatedRandomCard59a";
				
			}else if(card.name == "Card59b(Clone)"){
				
				card.name = "instantiatedRandomCard59b";
				
			}else if(card.name == "Card59c(Clone)"){
				
				card.name = "instantiatedRandomCard59c";
				
			}else if(card.name == "Card60(Clone)"){
				
				card.name = "instantiatedRandomCard60";
				
			}else if(card.name == "Card60a(Clone)"){
				
				card.name = "instantiatedRandomCard60a";
				
			}else if(card.name == "Card60b(Clone)"){
				
				card.name = "instantiatedRandomCard60b";
				
			}else if(card.name == "Card60c(Clone)"){
				
				card.name = "instantiatedRandomCard60c";
			}	
			
			instances5++;
			
			}
			
		while(instances6 < NumberOfCards) {
			
			GameObject card = Instantiate (cardsInDeck240[Random.Range(0,cardsInDeck240.Length)], spawnPoints6.transform.position,spawnPoints6.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(325f,200f,340.0f);
			
			if(card.name == "Card1(Clone)"){
				
				card.name = "instantiatedRandomCard1";
				
			}else if(card.name == "Card1a(Clone)"){
				
				card.name = "instantiatedRandomCard1a";
				
			}else if(card.name == "Card1b(Clone)"){
				
				card.name = "instantiatedRandomCard1b";
				
			}else if(card.name == "Card1c(Clone)"){
				
				card.name = "instantiatedRandomCard1c";
				
			}else if(card.name == "Card2(Clone)"){
				
				card.name = "instantiatedRandomCard2";
				
			}else if(card.name == "Card2a(Clone)"){
				
				card.name = "instantiatedRandomCard2a";
				
			}else if(card.name == "Card2b(Clone)"){
				
				card.name = "instantiatedRandomCard2b";
				
			}else if(card.name == "Card2c(Clone)"){
				
				card.name = "instantiatedRandomCard2c";
				
			}else if(card.name == "Card3(Clone)"){
				
				card.name = "instantiatedRandomCard3";
				
			}else if(card.name == "Card3a(Clone)"){
				
				card.name = "instantiatedRandomCard3a";
				
			}else if(card.name == "Card3b(Clone)"){
				
				card.name = "instantiatedRandomCard3b";
				
			}else if(card.name == "Card3c(Clone)"){
				
				card.name = "instantiatedRandomCard3c";
				
			}else if(card.name == "Card4(Clone)"){
				
				card.name = "instantiatedRandomCard4";
				
			}else if(card.name == "Card4a(Clone)"){
				
				card.name = "instantiatedRandomCard4a";
				
			}else if(card.name == "Card4b(Clone)"){
				
				card.name = "instantiatedRandomCard4b";
				
			}else if(card.name == "Card4c(Clone)"){
				
				card.name = "instantiatedRandomCard4c";
				
			}else if(card.name == "Card5(Clone)"){
				
				card.name = "instantiatedRandomCard5";
				
			}else if(card.name == "Card5a(Clone)"){
				
				card.name = "instantiatedRandomCard5a";
				
			}else if(card.name == "Card5b(Clone)"){
				
				card.name = "instantiatedRandomCard5b";
				
			}else if(card.name == "Card5c(Clone)"){
				
				card.name = "instantiatedRandomCard5c";
				
			}else if(card.name == "Card6(Clone)"){
				
				card.name = "instantiatedRandomCard6";
				
			}else if(card.name == "Card6a(Clone)"){
				
				card.name = "instantiatedRandomCard6a";
				
			}else if(card.name == "Card6b(Clone)"){
				
				card.name = "instantiatedRandomCard6b";
				
			}else if(card.name == "Card6c(Clone)"){
				
				card.name = "instantiatedRandomCard6c";
				
			}else if(card.name == "Card7(Clone)"){
				
				card.name = "instantiatedRandomCard7";
				
			}else if(card.name == "Card7a(Clone)"){
				
				card.name = "instantiatedRandomCard7a";
				
			}else if(card.name == "Card7b(Clone)"){
				
				card.name = "instantiatedRandomCard7b";
				
			}else if(card.name == "Card7c(Clone)"){
				
				card.name = "instantiatedRandomCard7c";
				
			}else if(card.name == "Card8(Clone)"){
				
				card.name = "instantiatedRandomCard8";
				
			}else if(card.name == "Card8a(Clone)"){
				
				card.name = "instantiatedRandomCard8a";
				
			}else if(card.name == "Card8b(Clone)"){
				
				card.name = "instantiatedRandomCard8b";
				
			}else if(card.name == "Card8c(Clone)"){
				
				card.name = "instantiatedRandomCard8c";
				
			}else if(card.name == "Card9(Clone)"){
				
				card.name = "instantiatedRandomCard9";
				
			}else if(card.name == "Card9a(Clone)"){
				
				card.name = "instantiatedRandomCard9a";
				
			}else if(card.name == "Card9b(Clone)"){
				
				card.name = "instantiatedRandomCard9b";
				
			}else if(card.name == "Card9c(Clone)"){
				
				card.name = "instantiatedRandomCard9c";
				
			}else if(card.name == "Card10(Clone)"){
				
				card.name = "instantiatedAICard10";
				
			}else if(card.name == "Card10a(Clone)"){
				
				card.name = "instantiatedRandomCard10a";
				
			}else if(card.name == "Card10b(Clone)"){
				
				card.name = "instantiatedRandomCard10b";
				
			}else if(card.name == "Card10c(Clone)"){
				
				card.name = "instantiatedRandomCard10c";
				
			}else if(card.name == "Card11(Clone)"){
				
				card.name = "instantiatedRandomCard11";
				
			}else if(card.name == "Card11a(Clone)"){
				
				card.name = "instantiatedRandomCard11a";
				
			}else if(card.name == "Card11b(Clone)"){
				
				card.name = "instantiatedRandomCard11b";
				
			}else if(card.name == "Card11c(Clone)"){
				
				card.name = "instantiatedRandomCard11c";
				
			}else if(card.name == "Card12(Clone)"){
				
				card.name = "instantiatedRandomCard12";
				
			}else if(card.name == "Card12a(Clone)"){
				
				card.name = "instantiatedRandomCard12a";
				
			}else if(card.name == "Card12b(Clone)"){
				
				card.name = "instantiatedRandomCard12b";
				
			}else if(card.name == "Card12c(Clone)"){
				
				card.name = "instantiatedRandomCard12c";
				
			}else if(card.name == "Card13(Clone)"){
				
				card.name = "instantiatedRandomCard13";
				
			}else if(card.name == "Card13a(Clone)"){
				
				card.name = "instantiatedRandomCard13a";
				
			}else if(card.name == "Card13b(Clone)"){
				
				card.name = "instantiatedRandomCard13b";
				
			}else if(card.name == "Card13c(Clone)"){
				
				card.name = "instantiatedRandomCard13c";
				
			}else if(card.name == "Card14(Clone)"){
				
				card.name = "instantiatedRandomCard14";
				
			}else if(card.name == "Card14a(Clone)"){
				
				card.name = "instantiatedRandomCard14a";
				
			}else if(card.name == "Card14b(Clone)"){
				
				card.name = "instantiatedRandomCard14b";
				
			}else if(card.name == "Card14c(Clone)"){
				
				card.name = "instantiatedRandomCard14c";
				
			}else if(card.name == "Card15(Clone)"){
				
				card.name = "instantiatedRandomCard15";
				
			}else if(card.name == "Card15a(Clone)"){
				
				card.name = "instantiatedRandomCard15a";
				
			}else if(card.name == "Card15b(Clone)"){
				
				card.name = "instantiatedRandomCard15b";
				
			}else if(card.name == "Card15c(Clone)"){
				
				card.name = "instantiatedRandomCard15c";
				
			}else if(card.name == "Card16(Clone)"){
				
				card.name = "instantiatedRandomCard16";
				
			}else if(card.name == "Card16a(Clone)"){
				
				card.name = "instantiatedRandomCard16a";
				
			}else if(card.name == "Card16b(Clone)"){
				
				card.name = "instantiatedRandomCard16b";
				
			}else if(card.name == "Card16c(Clone)"){
				
				card.name = "instantiatedRandomCard16c";
				
			}else if(card.name == "Card17(Clone)"){
				
				card.name = "instantiatedRandomCard17";
				
			}else if(card.name == "Card17a(Clone)"){
				
				card.name = "instantiatedRandomCard17a";
				
			}else if(card.name == "Card17b(Clone)"){
				
				card.name = "instantiatedRandomCard17b";
				
			}else if(card.name == "Card17c(Clone)"){
				
				card.name = "instantiatedRandomCard17c";
				
			}else if(card.name == "Card18(Clone)"){
				
				card.name = "instantiatedRandomCard18";
				
			}else if(card.name == "Card18a(Clone)"){
				
				card.name = "instantiatedRandomCard18a";
				
			}else if(card.name == "Card18b(Clone)"){
				
				card.name = "instantiatedRandomCard18b";
				
			}else if(card.name == "Card18c(Clone)"){
				
				card.name = "instantiatedRandomCard18c";
				
			}else if(card.name == "Card19(Clone)"){
				
				card.name = "instantiatedRandomCard19";
				
			}else if(card.name == "Card19a(Clone)"){
				
				card.name = "instantiatedRandomCard19a";
				
			}else if(card.name == "Card19b(Clone)"){
				
				card.name = "instantiatedRandomCard19b";
				
			}else if(card.name == "Card19c(Clone)"){
				
				card.name = "instantiatedRandomCard19c";
				
			}else if(card.name == "Card20(Clone)"){
				
				card.name = "instantiatedRandomCard20";
				
			}else if(card.name == "Card20a(Clone)"){
				
				card.name = "instantiatedRandomCard20a";
				
			}else if(card.name == "Card20b(Clone)"){
				
				card.name = "instantiatedRandomCard20b";
				
			}else if(card.name == "Card20c(Clone)"){
				
				card.name = "instantiatedRandomCard20c";
				
			}else if(card.name == "Card21(Clone)"){
				
				card.name = "instantiatedRandomCard21";
				
			}else if(card.name == "Card21a(Clone)"){
				
				card.name = "instantiatedRandomCard21a";
				
			}else if(card.name == "Card21b(Clone)"){
				
				card.name = "instantiatedRandomCard21b";
				
			}else if(card.name == "Card21c(Clone)"){
				
				card.name = "instantiatedRandomCard21c";
				
			}else if(card.name == "Card22(Clone)"){
				
				card.name = "instantiatedRandomCard22";
				
			}else if(card.name == "Card22a(Clone)"){
				
				card.name = "instantiatedRandomCard22a";
				
			}else if(card.name == "Card22b(Clone)"){
				
				card.name = "instantiatedRandomCard22b";
				
			}else if(card.name == "Card22c(Clone)"){
				
				card.name = "instantiatedRandomCard22c";
				
			}else if(card.name == "Card23(Clone)"){
				
				card.name = "instantiatedRandomCard23";
				
			}else if(card.name == "Card23a(Clone)"){
				
				card.name = "instantiatedRandomCard23a";
				
			}else if(card.name == "Card23b(Clone)"){
				
				card.name = "instantiatedRandomCard23b";
				
			}else if(card.name == "Card23c(Clone)"){
				
				card.name = "instantiatedRandomCard23c";
				
			}else if(card.name == "Card24(Clone)"){
				
				card.name = "instantiatedRandomCard24";
				
			}else if(card.name == "Card24a(Clone)"){
				
				card.name = "instantiatedRandomCard24a";
				
			}else if(card.name == "Card24b(Clone)"){
				
				card.name = "instantiatedRandomCard24b";
				
			}else if(card.name == "Card24c(Clone)"){
				
				card.name = "instantiatedRandomCard24c";
				
			}else if(card.name == "Card25(Clone)"){
				
				card.name = "instantiatedRandomCard25";
				
			}else if(card.name == "Card25a(Clone)"){
				
				card.name = "instantiatedRandomCard25a";
				
			}else if(card.name == "Card25b(Clone)"){
				
				card.name = "instantiatedRandomCard25b";
				
			}else if(card.name == "Card25c(Clone)"){
				
				card.name = "instantiatedRandomCard25c";
				
			}else if(card.name == "Card26(Clone)"){
				
				card.name = "instantiatedRandomCard26";
				
			}else if(card.name == "Card26a(Clone)"){
				
				card.name = "instantiatedRandomCard26a";
				
			}else if(card.name == "Card26b(Clone)"){
				
				card.name = "instantiatedRandomCard26b";
				
			}else if(card.name == "Card26c(Clone)"){
				
				card.name = "instantiatedRandomCard26c";
				
			}else if(card.name == "Card27(Clone)"){
				
				card.name = "instantiatedRandomCard27";
				
			}else if(card.name == "Card27a(Clone)"){
				
				card.name = "instantiatedRandomCard27a";
				
			}else if(card.name == "Card27b(Clone)"){
				
				card.name = "instantiatedRandomCard27b";
				
			}else if(card.name == "Card27c(Clone)"){
				
				card.name = "instantiatedRandomCard27c";
				
			}else if(card.name == "Card28(Clone)"){
				
				card.name = "instantiatedRandomCard28";
				
			}else if(card.name == "Card28a(Clone)"){
				
				card.name = "instantiatedRandomCard28a";
				
			}else if(card.name == "Card28b(Clone)"){
				
				card.name = "instantiatedRandomCard28b";
				
			}else if(card.name == "Card28c(Clone)"){
				
				card.name = "instantiatedRandomCard28c";
				
			}else if(card.name == "Card29(Clone)"){
				
				card.name = "instantiatedRandomCard29";
				
			}else if(card.name == "Card29a(Clone)"){
				
				card.name = "instantiatedRandomCard29a";
				
			}else if(card.name == "Card29b(Clone)"){
				
				card.name = "instantiatedRandomCard29b";
				
			}else if(card.name == "Card29c(Clone)"){
				
				card.name = "instantiatedRandomCard29c";
				
			}else if(card.name == "Card30(Clone)"){
				
				card.name = "instantiatedRandomCard30";
				
			}else if(card.name == "Card30a(Clone)"){
				
				card.name = "instantiatedRandomCard30a";
				
			}else if(card.name == "Card30b(Clone)"){
				
				card.name = "instantiatedRandomCard30b";
				
			}else if(card.name == "Card30c(Clone)"){
				
				card.name = "instantiatedRandomCard30c";
				
			}else if(card.name == "Card31(Clone)"){
				
				card.name = "instantiatedRandomCard31";
				
			}else if(card.name == "Card31a(Clone)"){
				
				card.name = "instantiatedRandomCard31a";
				
			}else if(card.name == "Card31b(Clone)"){
				
				card.name = "instantiatedRandomCard31b";
				
			}else if(card.name == "Card31c(Clone)"){
				
				card.name = "instantiatedRandomCard31c";
				
			}else if(card.name == "Card32(Clone)"){
				
				card.name = "instantiatedRandomCard32";
				
			}else if(card.name == "Card32a(Clone)"){
				
				card.name = "instantiatedRandomCard32a";
				
			}else if(card.name == "Card32b(Clone)"){
				
				card.name = "instantiatedRandomCard32b";
				
			}else if(card.name == "Card32c(Clone)"){
				
				card.name = "instantiatedRandomCard32c";
				
			}else if(card.name == "Card33(Clone)"){
				
				card.name = "instantiatedRandomCard33";
				
			}else if(card.name == "Card33a(Clone)"){
				
				card.name = "instantiatedRandomCard33a";
				
			}else if(card.name == "Card33b(Clone)"){
				
				card.name = "instantiatedRandomCard33b";
				
			}else if(card.name == "Card33c(Clone)"){
				
				card.name = "instantiatedRandomCard33c";
				
			}else if(card.name == "Card34(Clone)"){
				
				card.name = "instantiatedRandomCard34";
				
			}else if(card.name == "Card34a(Clone)"){
				
				card.name = "instantiatedRandomCard34a";
				
			}else if(card.name == "Card34b(Clone)"){
				
				card.name = "instantiatedRandomCard34b";
				
			}else if(card.name == "Card34c(Clone)"){
				
				card.name = "instantiatedRandomCard34c";
				
			}else if(card.name == "Card35(Clone)"){
				
				card.name = "instantiatedRandomCard35";
				
			}else if(card.name == "Card35a(Clone)"){
				
				card.name = "instantiatedRandomCard35a";
				
			}else if(card.name == "Card35b(Clone)"){
				
				card.name = "instantiatedRandomCard35b";
				
			}else if(card.name == "Card35c(Clone)"){
				
				card.name = "instantiatedRandomCard35c";
				
			}else if(card.name == "Card36(Clone)"){
				
				card.name = "instantiatedRandomCard36";
				
			}else if(card.name == "Card36a(Clone)"){
				
				card.name = "instantiatedRandomCard36a";
				
			}else if(card.name == "Card36b(Clone)"){
				
				card.name = "instantiatedRandomCard36b";
				
			}else if(card.name == "Card36c(Clone)"){
				
				card.name = "instantiatedRandomCard36c";
				
			}else if(card.name == "Card37(Clone)"){
				
				card.name = "instantiatedRandomCard37";
				
			}else if(card.name == "Card37a(Clone)"){
				
				card.name = "instantiatedRandomCard37a";
				
			}else if(card.name == "Card37b(Clone)"){
				
				card.name = "instantiatedRandomCard37b";
				
			}else if(card.name == "Card37c(Clone)"){
				
				card.name = "instantiatedRandomCard37c";
				
			}else if(card.name == "Card38(Clone)"){
				
				card.name = "instantiatedRandomCard38";
				
			}else if(card.name == "Card38a(Clone)"){
				
				card.name = "instantiatedRandomCard38a";
				
			}else if(card.name == "Card38b(Clone)"){
				
				card.name = "instantiatedRandomCard38b";
				
			}else if(card.name == "Card38c(Clone)"){
				
				card.name = "instantiatedRandomCard38c";
				
			}else if(card.name == "Card39(Clone)"){
				
				card.name = "instantiatedRandomCard39";
				
			}else if(card.name == "Card39a(Clone)"){
				
				card.name = "instantiatedRandomCard39a";
				
			}else if(card.name == "Card39b(Clone)"){
				
				card.name = "instantiatedRandomCard39b";
				
			}else if(card.name == "Card39c(Clone)"){
				
				card.name = "instantiatedRandomCard39c";
				
			}else if(card.name == "Card40(Clone)"){
				
				card.name = "instantiatedRandomCard40";
				
			}else if(card.name == "Card40a(Clone)"){
				
				card.name = "instantiatedRandomCard40a";
				
			}else if(card.name == "Card40b(Clone)"){
				
				card.name = "instantiatedRandomCard40b";
				
			}else if(card.name == "Card40c(Clone)"){
				
				card.name = "instantiatedRandomCard40c";
				
			}else if(card.name == "Card41(Clone)"){
				
				card.name = "instantiatedRandomCard41";
				
			}else if(card.name == "Card41a(Clone)"){
				
				card.name = "instantiatedRandomCard41a";
				
			}else if(card.name == "Card41b(Clone)"){
				
				card.name = "instantiatedRandomCard41b";
				
			}else if(card.name == "Card41c(Clone)"){
				
				card.name = "instantiatedRandomCard41c";
				
			}else if(card.name == "Card42(Clone)"){
				
				card.name = "instantiatedRandomCard42";
				
			}else if(card.name == "Card42a(Clone)"){
				
				card.name = "instantiatedRandomCard42a";
				
			}else if(card.name == "Card42b(Clone)"){
				
				card.name = "instantiatedRandomCard42b";
				
			}else if(card.name == "Card42c(Clone)"){
				
				card.name = "instantiatedRandomCard42c";
				
			}else if(card.name == "Card43(Clone)"){
				
				card.name = "instantiatedRandomCard43";
				
			}else if(card.name == "Card43a(Clone)"){
				
				card.name = "instantiatedRandomCard43a";
				
			}else if(card.name == "Card43b(Clone)"){
				
				card.name = "instantiatedRandomCard43b";
				
			}else if(card.name == "Card43c(Clone)"){
				
				card.name = "instantiatedRandomCard43c";
				
			}else if(card.name == "Card44(Clone)"){
				
				card.name = "instantiatedRandomCard44";
				
			}else if(card.name == "Card44a(Clone)"){
				
				card.name = "instantiatedRandomCard44a";
				
			}else if(card.name == "Card44b(Clone)"){
				
				card.name = "instantiatedRandomCard44b";
				
			}else if(card.name == "Card44c(Clone)"){
				
				card.name = "instantiatedRandomCard44c";
				
			}else if(card.name == "Card45(Clone)"){
				
				card.name = "instantiatedRandomCard45";
				
			}else if(card.name == "Card45a(Clone)"){
				
				card.name = "instantiatedRandomCard45a";
				
			}else if(card.name == "Card45b(Clone)"){
				
				card.name = "instantiatedRandomCard45b";
				
			}else if(card.name == "Card45c(Clone)"){
				
				card.name = "instantiatedRandomCard45c";
				
			}else if(card.name == "Card46(Clone)"){
				
				card.name = "instantiatedRandomCard46";
				
			}else if(card.name == "Card46a(Clone)"){
				
				card.name = "instantiatedRandomCard46a";
				
			}else if(card.name == "Card46b(Clone)"){
				
				card.name = "instantiatedRandomCard46b";
				
			}else if(card.name == "Card46c(Clone)"){
				
				card.name = "instantiatedRandomCard46c";
				
			}else if(card.name == "Card47(Clone)"){
				
				card.name = "instantiatedRandomCard47";
				
			}else if(card.name == "Card47a(Clone)"){
				
				card.name = "instantiatedRandomCard47a";
				
			}else if(card.name == "Card47b(Clone)"){
				
				card.name = "instantiatedRandomCard47b";
				
			}else if(card.name == "Card47c(Clone)"){
				
				card.name = "instantiatedRandomCard47c";
				
			}else if(card.name == "Card48(Clone)"){
				
				card.name = "instantiatedRandomCard48";
				
			}else if(card.name == "Card48a(Clone)"){
				
				card.name = "instantiatedRandomCard48a";
				
			}else if(card.name == "Card48b(Clone)"){
				
				card.name = "instantiatedRandomCard48b";
				
			}else if(card.name == "Card48c(Clone)"){
				
				card.name = "instantiatedRandomCard48c";
				
			}else if(card.name == "Card49(Clone)"){
				
				card.name = "instantiatedRandomCard49";
				
			}else if(card.name == "Card49a(Clone)"){
				
				card.name = "instantiatedRandomCard49a";
				
			}else if(card.name == "Card49b(Clone)"){
				
				card.name = "instantiatedRandomCard49b";
				
			}else if(card.name == "Card49c(Clone)"){
				
				card.name = "instantiatedRandomCard49c";
				
			}else if(card.name == "Card50(Clone)"){
				
				card.name = "instantiatedRandomCard50";
				
			}else if(card.name == "Card50a(Clone)"){
				
				card.name = "instantiatedRandomCard50a";
				
			}else if(card.name == "Card50b(Clone)"){
				
				card.name = "instantiatedRandomCard50b";
				
			}else if(card.name == "Card50c(Clone)"){
				
				card.name = "instantiatedRandomCard50c";
				
			}else if(card.name == "Card51(Clone)"){
				
				card.name = "instantiatedRandomCard51";
				
			}else if(card.name == "Card51a(Clone)"){
				
				card.name = "instantiatedRandomCard51a";
				
			}else if(card.name == "Card51b(Clone)"){
				
				card.name = "instantiatedRandomCard51b";
				
			}else if(card.name == "Card51c(Clone)"){
				
				card.name = "instantiatedRandomCard51c";
				
			}else if(card.name == "Card52(Clone)"){
				
				card.name = "instantiatedRandomCard52";
				
			}else if(card.name == "Card52a(Clone)"){
				
				card.name = "instantiatedRandomCard52a";
				
			}else if(card.name == "Card52b(Clone)"){
				
				card.name = "instantiatedRandomCard52b";
				
			}else if(card.name == "Card52c(Clone)"){
				
				card.name = "instantiatedRandomCard52c";
				
			}else if(card.name == "Card53(Clone)"){
				
				card.name = "instantiatedRandomCard53";
				
			}else if(card.name == "Card53a(Clone)"){
				
				card.name = "instantiatedRandomCard53a";
				
			}else if(card.name == "Card53b(Clone)"){
				
				card.name = "instantiatedRandomCard53b";
				
			}else if(card.name == "Card53c(Clone)"){
				
				card.name = "instantiatedRandomCard53c";
				
			}else if(card.name == "Card54(Clone)"){
				
				card.name = "instantiatedRandomCard54";
				
			}else if(card.name == "Card54a(Clone)"){
				
				card.name = "instantiatedRandomCard54a";
				
			}else if(card.name == "Card54b(Clone)"){
				
				card.name = "instantiatedRandomCard54b";
				
			}else if(card.name == "Card54c(Clone)"){
				
				card.name = "instantiatedRandomCard54c";
				
			}else if(card.name == "Card55(Clone)"){
				
				card.name = "instantiatedRandomCard55";
				
			}else if(card.name == "Card55a(Clone)"){
				
				card.name = "instantiatedRandomCard55a";
				
			}else if(card.name == "Card55b(Clone)"){
				
				card.name = "instantiatedRandomCard55b";
				
			}else if(card.name == "Card55c(Clone)"){
				
				card.name = "instantiatedRandomCard55c";
				
			}else if(card.name == "Card56(Clone)"){
				
				card.name = "instantiatedRandomCard56";
				
			}else if(card.name == "Card56a(Clone)"){
				
				card.name = "instantiatedRandomCard56a";
				
			}else if(card.name == "Card56b(Clone)"){
				
				card.name = "instantiatedRandomCard56b";
				
			}else if(card.name == "Card56c(Clone)"){
				
				card.name = "instantiatedRandomCard56c";
				
			}else if(card.name == "Card57(Clone)"){
				
				card.name = "instantiatedRandomCard57";
				
			}else if(card.name == "Card57a(Clone)"){
				
				card.name = "instantiatedRandomCard57a";
				
			}else if(card.name == "Card57b(Clone)"){
				
				card.name = "instantiatedRandomCard57b";
				
			}else if(card.name == "Card57c(Clone)"){
				
				card.name = "instantiatedRandomCard57c";
				
			}else if(card.name == "Card58(Clone)"){
				
				card.name = "instantiatedRandomCard58";
				
			}else if(card.name == "Card58a(Clone)"){
				
				card.name = "instantiatedRandomCard58a";
				
			}else if(card.name == "Card58b(Clone)"){
				
				card.name = "instantiatedRandomCard58b";
				
			}else if(card.name == "Card58c(Clone)"){
				
				card.name = "instantiatedRandomCard58c";
				
			}else if(card.name == "Card59(Clone)"){
				
				card.name = "instantiatedRandomCard59";
				
			}else if(card.name == "Card59a(Clone)"){
				
				card.name = "instantiatedRandomCard59a";
				
			}else if(card.name == "Card59b(Clone)"){
				
				card.name = "instantiatedRandomCard59b";
				
			}else if(card.name == "Card59c(Clone)"){
				
				card.name = "instantiatedRandomCard59c";
				
			}else if(card.name == "Card60(Clone)"){
				
				card.name = "instantiatedRandomCard60";
				
			}else if(card.name == "Card60a(Clone)"){
				
				card.name = "instantiatedRandomCard60a";
				
			}else if(card.name == "Card60b(Clone)"){
				
				card.name = "instantiatedRandomCard60b";
				
			}else if(card.name == "Card60c(Clone)"){
				
				card.name = "instantiatedRandomCard60c";
			}
			
			instances6++;
			
			}
			
		while(instances7 < NumberOfCards) {
			
			GameObject card = Instantiate (cardsInDeck240[Random.Range(0,cardsInDeck240.Length)], spawnPoints7.transform.position,spawnPoints7.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(325f,200f,340.0f);
			
			if(card.name == "Card1(Clone)"){
				
				card.name = "instantiatedRandomCard1";
				
			}else if(card.name == "Card1a(Clone)"){
				
				card.name = "instantiatedRandomCard1a";
				
			}else if(card.name == "Card1b(Clone)"){
				
				card.name = "instantiatedRandomCard1b";
				
			}else if(card.name == "Card1c(Clone)"){
				
				card.name = "instantiatedRandomCard1c";
				
			}else if(card.name == "Card2(Clone)"){
				
				card.name = "instantiatedRandomCard2";
				
			}else if(card.name == "Card2a(Clone)"){
				
				card.name = "instantiatedRandomCard2a";
				
			}else if(card.name == "Card2b(Clone)"){
				
				card.name = "instantiatedRandomCard2b";
				
			}else if(card.name == "Card2c(Clone)"){
				
				card.name = "instantiatedRandomCard2c";
				
			}else if(card.name == "Card3(Clone)"){
				
				card.name = "instantiatedRandomCard3";
				
			}else if(card.name == "Card3a(Clone)"){
				
				card.name = "instantiatedRandomCard3a";
				
			}else if(card.name == "Card3b(Clone)"){
				
				card.name = "instantiatedRandomCard3b";
				
			}else if(card.name == "Card3c(Clone)"){
				
				card.name = "instantiatedRandomCard3c";
				
			}else if(card.name == "Card4(Clone)"){
				
				card.name = "instantiatedRandomCard4";
				
			}else if(card.name == "Card4a(Clone)"){
				
				card.name = "instantiatedRandomCard4a";
				
			}else if(card.name == "Card4b(Clone)"){
				
				card.name = "instantiatedRandomCard4b";
				
			}else if(card.name == "Card4c(Clone)"){
				
				card.name = "instantiatedRandomCard4c";
				
			}else if(card.name == "Card5(Clone)"){
				
				card.name = "instantiatedRandomCard5";
				
			}else if(card.name == "Card5a(Clone)"){
				
				card.name = "instantiatedRandomCard5a";
				
			}else if(card.name == "Card5b(Clone)"){
				
				card.name = "instantiatedRandomCard5b";
				
			}else if(card.name == "Card5c(Clone)"){
				
				card.name = "instantiatedRandomCard5c";
				
			}else if(card.name == "Card6(Clone)"){
				
				card.name = "instantiatedRandomCard6";
				
			}else if(card.name == "Card6a(Clone)"){
				
				card.name = "instantiatedRandomCard6a";
				
			}else if(card.name == "Card6b(Clone)"){
				
				card.name = "instantiatedRandomCard6b";
				
			}else if(card.name == "Card6c(Clone)"){
				
				card.name = "instantiatedRandomCard6c";
				
			}else if(card.name == "Card7(Clone)"){
				
				card.name = "instantiatedRandomCard7";
				
			}else if(card.name == "Card7a(Clone)"){
				
				card.name = "instantiatedRandomCard7a";
				
			}else if(card.name == "Card7b(Clone)"){
				
				card.name = "instantiatedRandomCard7b";
				
			}else if(card.name == "Card7c(Clone)"){
				
				card.name = "instantiatedRandomCard7c";
				
			}else if(card.name == "Card8(Clone)"){
				
				card.name = "instantiatedRandomCard8";
				
			}else if(card.name == "Card8a(Clone)"){
				
				card.name = "instantiatedRandomCard8a";
				
			}else if(card.name == "Card8b(Clone)"){
				
				card.name = "instantiatedRandomCard8b";
				
			}else if(card.name == "Card8c(Clone)"){
				
				card.name = "instantiatedRandomCard8c";
				
			}else if(card.name == "Card9(Clone)"){
				
				card.name = "instantiatedRandomCard9";
				
			}else if(card.name == "Card9a(Clone)"){
				
				card.name = "instantiatedRandomCard9a";
				
			}else if(card.name == "Card9b(Clone)"){
				
				card.name = "instantiatedRandomCard9b";
				
			}else if(card.name == "Card9c(Clone)"){
				
				card.name = "instantiatedRandomCard9c";
				
			}else if(card.name == "Card10(Clone)"){
				
				card.name = "instantiatedAICard10";
				
			}else if(card.name == "Card10a(Clone)"){
				
				card.name = "instantiatedRandomCard10a";
				
			}else if(card.name == "Card10b(Clone)"){
				
				card.name = "instantiatedRandomCard10b";
				
			}else if(card.name == "Card10c(Clone)"){
				
				card.name = "instantiatedRandomCard10c";
				
			}else if(card.name == "Card11(Clone)"){
				
				card.name = "instantiatedRandomCard11";
				
			}else if(card.name == "Card11a(Clone)"){
				
				card.name = "instantiatedRandomCard11a";
				
			}else if(card.name == "Card11b(Clone)"){
				
				card.name = "instantiatedRandomCard11b";
				
			}else if(card.name == "Card11c(Clone)"){
				
				card.name = "instantiatedRandomCard11c";
				
			}else if(card.name == "Card12(Clone)"){
				
				card.name = "instantiatedRandomCard12";
				
			}else if(card.name == "Card12a(Clone)"){
				
				card.name = "instantiatedRandomCard12a";
				
			}else if(card.name == "Card12b(Clone)"){
				
				card.name = "instantiatedRandomCard12b";
				
			}else if(card.name == "Card12c(Clone)"){
				
				card.name = "instantiatedRandomCard12c";
				
			}else if(card.name == "Card13(Clone)"){
				
				card.name = "instantiatedRandomCard13";
				
			}else if(card.name == "Card13a(Clone)"){
				
				card.name = "instantiatedRandomCard13a";
				
			}else if(card.name == "Card13b(Clone)"){
				
				card.name = "instantiatedRandomCard13b";
				
			}else if(card.name == "Card13c(Clone)"){
				
				card.name = "instantiatedRandomCard13c";
				
			}else if(card.name == "Card14(Clone)"){
				
				card.name = "instantiatedRandomCard14";
				
			}else if(card.name == "Card14a(Clone)"){
				
				card.name = "instantiatedRandomCard14a";
				
			}else if(card.name == "Card14b(Clone)"){
				
				card.name = "instantiatedRandomCard14b";
				
			}else if(card.name == "Card14c(Clone)"){
				
				card.name = "instantiatedRandomCard14c";
				
			}else if(card.name == "Card15(Clone)"){
				
				card.name = "instantiatedRandomCard15";
				
			}else if(card.name == "Card15a(Clone)"){
				
				card.name = "instantiatedRandomCard15a";
				
			}else if(card.name == "Card15b(Clone)"){
				
				card.name = "instantiatedRandomCard15b";
				
			}else if(card.name == "Card15c(Clone)"){
				
				card.name = "instantiatedRandomCard15c";
				
			}else if(card.name == "Card16(Clone)"){
				
				card.name = "instantiatedRandomCard16";
				
			}else if(card.name == "Card16a(Clone)"){
				
				card.name = "instantiatedRandomCard16a";
				
			}else if(card.name == "Card16b(Clone)"){
				
				card.name = "instantiatedRandomCard16b";
				
			}else if(card.name == "Card16c(Clone)"){
				
				card.name = "instantiatedRandomCard16c";
				
			}else if(card.name == "Card17(Clone)"){
				
				card.name = "instantiatedRandomCard17";
				
			}else if(card.name == "Card17a(Clone)"){
				
				card.name = "instantiatedRandomCard17a";
				
			}else if(card.name == "Card17b(Clone)"){
				
				card.name = "instantiatedRandomCard17b";
				
			}else if(card.name == "Card17c(Clone)"){
				
				card.name = "instantiatedRandomCard17c";
				
			}else if(card.name == "Card18(Clone)"){
				
				card.name = "instantiatedRandomCard18";
				
			}else if(card.name == "Card18a(Clone)"){
				
				card.name = "instantiatedRandomCard18a";
				
			}else if(card.name == "Card18b(Clone)"){
				
				card.name = "instantiatedRandomCard18b";
				
			}else if(card.name == "Card18c(Clone)"){
				
				card.name = "instantiatedRandomCard18c";
				
			}else if(card.name == "Card19(Clone)"){
				
				card.name = "instantiatedRandomCard19";
				
			}else if(card.name == "Card19a(Clone)"){
				
				card.name = "instantiatedRandomCard19a";
				
			}else if(card.name == "Card19b(Clone)"){
				
				card.name = "instantiatedRandomCard19b";
				
			}else if(card.name == "Card19c(Clone)"){
				
				card.name = "instantiatedRandomCard19c";
				
			}else if(card.name == "Card20(Clone)"){
				
				card.name = "instantiatedRandomCard20";
				
			}else if(card.name == "Card20a(Clone)"){
				
				card.name = "instantiatedRandomCard20a";
				
			}else if(card.name == "Card20b(Clone)"){
				
				card.name = "instantiatedRandomCard20b";
				
			}else if(card.name == "Card20c(Clone)"){
				
				card.name = "instantiatedRandomCard20c";
				
			}else if(card.name == "Card21(Clone)"){
				
				card.name = "instantiatedRandomCard21";
				
			}else if(card.name == "Card21a(Clone)"){
				
				card.name = "instantiatedRandomCard21a";
				
			}else if(card.name == "Card21b(Clone)"){
				
				card.name = "instantiatedRandomCard21b";
				
			}else if(card.name == "Card21c(Clone)"){
				
				card.name = "instantiatedRandomCard21c";
				
			}else if(card.name == "Card22(Clone)"){
				
				card.name = "instantiatedRandomCard22";
				
			}else if(card.name == "Card22a(Clone)"){
				
				card.name = "instantiatedRandomCard22a";
				
			}else if(card.name == "Card22b(Clone)"){
				
				card.name = "instantiatedRandomCard22b";
				
			}else if(card.name == "Card22c(Clone)"){
				
				card.name = "instantiatedRandomCard22c";
				
			}else if(card.name == "Card23(Clone)"){
				
				card.name = "instantiatedRandomCard23";
				
			}else if(card.name == "Card23a(Clone)"){
				
				card.name = "instantiatedRandomCard23a";
				
			}else if(card.name == "Card23b(Clone)"){
				
				card.name = "instantiatedRandomCard23b";
				
			}else if(card.name == "Card23c(Clone)"){
				
				card.name = "instantiatedRandomCard23c";
				
			}else if(card.name == "Card24(Clone)"){
				
				card.name = "instantiatedRandomCard24";
				
			}else if(card.name == "Card24a(Clone)"){
				
				card.name = "instantiatedRandomCard24a";
				
			}else if(card.name == "Card24b(Clone)"){
				
				card.name = "instantiatedRandomCard24b";
				
			}else if(card.name == "Card24c(Clone)"){
				
				card.name = "instantiatedRandomCard24c";
				
			}else if(card.name == "Card25(Clone)"){
				
				card.name = "instantiatedRandomCard25";
				
			}else if(card.name == "Card25a(Clone)"){
				
				card.name = "instantiatedRandomCard25a";
				
			}else if(card.name == "Card25b(Clone)"){
				
				card.name = "instantiatedRandomCard25b";
				
			}else if(card.name == "Card25c(Clone)"){
				
				card.name = "instantiatedRandomCard25c";
				
			}else if(card.name == "Card26(Clone)"){
				
				card.name = "instantiatedRandomCard26";
				
			}else if(card.name == "Card26a(Clone)"){
				
				card.name = "instantiatedRandomCard26a";
				
			}else if(card.name == "Card26b(Clone)"){
				
				card.name = "instantiatedRandomCard26b";
				
			}else if(card.name == "Card26c(Clone)"){
				
				card.name = "instantiatedRandomCard26c";
				
			}else if(card.name == "Card27(Clone)"){
				
				card.name = "instantiatedRandomCard27";
				
			}else if(card.name == "Card27a(Clone)"){
				
				card.name = "instantiatedRandomCard27a";
				
			}else if(card.name == "Card27b(Clone)"){
				
				card.name = "instantiatedRandomCard27b";
				
			}else if(card.name == "Card27c(Clone)"){
				
				card.name = "instantiatedRandomCard27c";
				
			}else if(card.name == "Card28(Clone)"){
				
				card.name = "instantiatedRandomCard28";
				
			}else if(card.name == "Card28a(Clone)"){
				
				card.name = "instantiatedRandomCard28a";
				
			}else if(card.name == "Card28b(Clone)"){
				
				card.name = "instantiatedRandomCard28b";
				
			}else if(card.name == "Card28c(Clone)"){
				
				card.name = "instantiatedRandomCard28c";
				
			}else if(card.name == "Card29(Clone)"){
				
				card.name = "instantiatedRandomCard29";
				
			}else if(card.name == "Card29a(Clone)"){
				
				card.name = "instantiatedRandomCard29a";
				
			}else if(card.name == "Card29b(Clone)"){
				
				card.name = "instantiatedRandomCard29b";
				
			}else if(card.name == "Card29c(Clone)"){
				
				card.name = "instantiatedRandomCard29c";
				
			}else if(card.name == "Card30(Clone)"){
				
				card.name = "instantiatedRandomCard30";
				
			}else if(card.name == "Card30a(Clone)"){
				
				card.name = "instantiatedRandomCard30a";
				
			}else if(card.name == "Card30b(Clone)"){
				
				card.name = "instantiatedRandomCard30b";
				
			}else if(card.name == "Card30c(Clone)"){
				
				card.name = "instantiatedRandomCard30c";
				
			}else if(card.name == "Card31(Clone)"){
				
				card.name = "instantiatedRandomCard31";
				
			}else if(card.name == "Card31a(Clone)"){
				
				card.name = "instantiatedRandomCard31a";
				
			}else if(card.name == "Card31b(Clone)"){
				
				card.name = "instantiatedRandomCard31b";
				
			}else if(card.name == "Card31c(Clone)"){
				
				card.name = "instantiatedRandomCard31c";
				
			}else if(card.name == "Card32(Clone)"){
				
				card.name = "instantiatedRandomCard32";
				
			}else if(card.name == "Card32a(Clone)"){
				
				card.name = "instantiatedRandomCard32a";
				
			}else if(card.name == "Card32b(Clone)"){
				
				card.name = "instantiatedRandomCard32b";
				
			}else if(card.name == "Card32c(Clone)"){
				
				card.name = "instantiatedRandomCard32c";
				
			}else if(card.name == "Card33(Clone)"){
				
				card.name = "instantiatedRandomCard33";
				
			}else if(card.name == "Card33a(Clone)"){
				
				card.name = "instantiatedRandomCard33a";
				
			}else if(card.name == "Card33b(Clone)"){
				
				card.name = "instantiatedRandomCard33b";
				
			}else if(card.name == "Card33c(Clone)"){
				
				card.name = "instantiatedRandomCard33c";
				
			}else if(card.name == "Card34(Clone)"){
				
				card.name = "instantiatedRandomCard34";
				
			}else if(card.name == "Card34a(Clone)"){
				
				card.name = "instantiatedRandomCard34a";
				
			}else if(card.name == "Card34b(Clone)"){
				
				card.name = "instantiatedRandomCard34b";
				
			}else if(card.name == "Card34c(Clone)"){
				
				card.name = "instantiatedRandomCard34c";
				
			}else if(card.name == "Card35(Clone)"){
				
				card.name = "instantiatedRandomCard35";
				
			}else if(card.name == "Card35a(Clone)"){
				
				card.name = "instantiatedRandomCard35a";
				
			}else if(card.name == "Card35b(Clone)"){
				
				card.name = "instantiatedRandomCard35b";
				
			}else if(card.name == "Card35c(Clone)"){
				
				card.name = "instantiatedRandomCard35c";
				
			}else if(card.name == "Card36(Clone)"){
				
				card.name = "instantiatedRandomCard36";
				
			}else if(card.name == "Card36a(Clone)"){
				
				card.name = "instantiatedRandomCard36a";
				
			}else if(card.name == "Card36b(Clone)"){
				
				card.name = "instantiatedRandomCard36b";
				
			}else if(card.name == "Card36c(Clone)"){
				
				card.name = "instantiatedRandomCard36c";
				
			}else if(card.name == "Card37(Clone)"){
				
				card.name = "instantiatedRandomCard37";
				
			}else if(card.name == "Card37a(Clone)"){
				
				card.name = "instantiatedRandomCard37a";
				
			}else if(card.name == "Card37b(Clone)"){
				
				card.name = "instantiatedRandomCard37b";
				
			}else if(card.name == "Card37c(Clone)"){
				
				card.name = "instantiatedRandomCard37c";
				
			}else if(card.name == "Card38(Clone)"){
				
				card.name = "instantiatedRandomCard38";
				
			}else if(card.name == "Card38a(Clone)"){
				
				card.name = "instantiatedRandomCard38a";
				
			}else if(card.name == "Card38b(Clone)"){
				
				card.name = "instantiatedRandomCard38b";
				
			}else if(card.name == "Card38c(Clone)"){
				
				card.name = "instantiatedRandomCard38c";
				
			}else if(card.name == "Card39(Clone)"){
				
				card.name = "instantiatedRandomCard39";
				
			}else if(card.name == "Card39a(Clone)"){
				
				card.name = "instantiatedRandomCard39a";
				
			}else if(card.name == "Card39b(Clone)"){
				
				card.name = "instantiatedRandomCard39b";
				
			}else if(card.name == "Card39c(Clone)"){
				
				card.name = "instantiatedRandomCard39c";
				
			}else if(card.name == "Card40(Clone)"){
				
				card.name = "instantiatedRandomCard40";
				
			}else if(card.name == "Card40a(Clone)"){
				
				card.name = "instantiatedRandomCard40a";
				
			}else if(card.name == "Card40b(Clone)"){
				
				card.name = "instantiatedRandomCard40b";
				
			}else if(card.name == "Card40c(Clone)"){
				
				card.name = "instantiatedRandomCard40c";
				
			}else if(card.name == "Card41(Clone)"){
				
				card.name = "instantiatedRandomCard41";
				
			}else if(card.name == "Card41a(Clone)"){
				
				card.name = "instantiatedRandomCard41a";
				
			}else if(card.name == "Card41b(Clone)"){
				
				card.name = "instantiatedRandomCard41b";
				
			}else if(card.name == "Card41c(Clone)"){
				
				card.name = "instantiatedRandomCard41c";
				
			}else if(card.name == "Card42(Clone)"){
				
				card.name = "instantiatedRandomCard42";
				
			}else if(card.name == "Card42a(Clone)"){
				
				card.name = "instantiatedRandomCard42a";
				
			}else if(card.name == "Card42b(Clone)"){
				
				card.name = "instantiatedRandomCard42b";
				
			}else if(card.name == "Card42c(Clone)"){
				
				card.name = "instantiatedRandomCard42c";
				
			}else if(card.name == "Card43(Clone)"){
				
				card.name = "instantiatedRandomCard43";
				
			}else if(card.name == "Card43a(Clone)"){
				
				card.name = "instantiatedRandomCard43a";
				
			}else if(card.name == "Card43b(Clone)"){
				
				card.name = "instantiatedRandomCard43b";
				
			}else if(card.name == "Card43c(Clone)"){
				
				card.name = "instantiatedRandomCard43c";
				
			}else if(card.name == "Card44(Clone)"){
				
				card.name = "instantiatedRandomCard44";
				
			}else if(card.name == "Card44a(Clone)"){
				
				card.name = "instantiatedRandomCard44a";
				
			}else if(card.name == "Card44b(Clone)"){
				
				card.name = "instantiatedRandomCard44b";
				
			}else if(card.name == "Card44c(Clone)"){
				
				card.name = "instantiatedRandomCard44c";
				
			}else if(card.name == "Card45(Clone)"){
				
				card.name = "instantiatedRandomCard45";
				
			}else if(card.name == "Card45a(Clone)"){
				
				card.name = "instantiatedRandomCard45a";
				
			}else if(card.name == "Card45b(Clone)"){
				
				card.name = "instantiatedRandomCard45b";
				
			}else if(card.name == "Card45c(Clone)"){
				
				card.name = "instantiatedRandomCard45c";
				
			}else if(card.name == "Card46(Clone)"){
				
				card.name = "instantiatedRandomCard46";
				
			}else if(card.name == "Card46a(Clone)"){
				
				card.name = "instantiatedRandomCard46a";
				
			}else if(card.name == "Card46b(Clone)"){
				
				card.name = "instantiatedRandomCard46b";
				
			}else if(card.name == "Card46c(Clone)"){
				
				card.name = "instantiatedRandomCard46c";
				
			}else if(card.name == "Card47(Clone)"){
				
				card.name = "instantiatedRandomCard47";
				
			}else if(card.name == "Card47a(Clone)"){
				
				card.name = "instantiatedRandomCard47a";
				
			}else if(card.name == "Card47b(Clone)"){
				
				card.name = "instantiatedRandomCard47b";
				
			}else if(card.name == "Card47c(Clone)"){
				
				card.name = "instantiatedRandomCard47c";
				
			}else if(card.name == "Card48(Clone)"){
				
				card.name = "instantiatedRandomCard48";
				
			}else if(card.name == "Card48a(Clone)"){
				
				card.name = "instantiatedRandomCard48a";
				
			}else if(card.name == "Card48b(Clone)"){
				
				card.name = "instantiatedRandomCard48b";
				
			}else if(card.name == "Card48c(Clone)"){
				
				card.name = "instantiatedRandomCard48c";
				
			}else if(card.name == "Card49(Clone)"){
				
				card.name = "instantiatedRandomCard49";
				
			}else if(card.name == "Card49a(Clone)"){
				
				card.name = "instantiatedRandomCard49a";
				
			}else if(card.name == "Card49b(Clone)"){
				
				card.name = "instantiatedRandomCard49b";
				
			}else if(card.name == "Card49c(Clone)"){
				
				card.name = "instantiatedRandomCard49c";
				
			}else if(card.name == "Card50(Clone)"){
				
				card.name = "instantiatedRandomCard50";
				
			}else if(card.name == "Card50a(Clone)"){
				
				card.name = "instantiatedRandomCard50a";
				
			}else if(card.name == "Card50b(Clone)"){
				
				card.name = "instantiatedRandomCard50b";
				
			}else if(card.name == "Card50c(Clone)"){
				
				card.name = "instantiatedRandomCard50c";
				
			}else if(card.name == "Card51(Clone)"){
				
				card.name = "instantiatedRandomCard51";
				
			}else if(card.name == "Card51a(Clone)"){
				
				card.name = "instantiatedRandomCard51a";
				
			}else if(card.name == "Card51b(Clone)"){
				
				card.name = "instantiatedRandomCard51b";
				
			}else if(card.name == "Card51c(Clone)"){
				
				card.name = "instantiatedRandomCard51c";
				
			}else if(card.name == "Card52(Clone)"){
				
				card.name = "instantiatedRandomCard52";
				
			}else if(card.name == "Card52a(Clone)"){
				
				card.name = "instantiatedRandomCard52a";
				
			}else if(card.name == "Card52b(Clone)"){
				
				card.name = "instantiatedRandomCard52b";
				
			}else if(card.name == "Card52c(Clone)"){
				
				card.name = "instantiatedRandomCard52c";
				
			}else if(card.name == "Card53(Clone)"){
				
				card.name = "instantiatedRandomCard53";
				
			}else if(card.name == "Card53a(Clone)"){
				
				card.name = "instantiatedRandomCard53a";
				
			}else if(card.name == "Card53b(Clone)"){
				
				card.name = "instantiatedRandomCard53b";
				
			}else if(card.name == "Card53c(Clone)"){
				
				card.name = "instantiatedRandomCard53c";
				
			}else if(card.name == "Card54(Clone)"){
				
				card.name = "instantiatedRandomCard54";
				
			}else if(card.name == "Card54a(Clone)"){
				
				card.name = "instantiatedRandomCard54a";
				
			}else if(card.name == "Card54b(Clone)"){
				
				card.name = "instantiatedRandomCard54b";
				
			}else if(card.name == "Card54c(Clone)"){
				
				card.name = "instantiatedRandomCard54c";
				
			}else if(card.name == "Card55(Clone)"){
				
				card.name = "instantiatedRandomCard55";
				
			}else if(card.name == "Card55a(Clone)"){
				
				card.name = "instantiatedRandomCard55a";
				
			}else if(card.name == "Card55b(Clone)"){
				
				card.name = "instantiatedRandomCard55b";
				
			}else if(card.name == "Card55c(Clone)"){
				
				card.name = "instantiatedRandomCard55c";
				
			}else if(card.name == "Card56(Clone)"){
				
				card.name = "instantiatedRandomCard56";
				
			}else if(card.name == "Card56a(Clone)"){
				
				card.name = "instantiatedRandomCard56a";
				
			}else if(card.name == "Card56b(Clone)"){
				
				card.name = "instantiatedRandomCard56b";
				
			}else if(card.name == "Card56c(Clone)"){
				
				card.name = "instantiatedRandomCard56c";
				
			}else if(card.name == "Card57(Clone)"){
				
				card.name = "instantiatedRandomCard57";
				
			}else if(card.name == "Card57a(Clone)"){
				
				card.name = "instantiatedRandomCard57a";
				
			}else if(card.name == "Card57b(Clone)"){
				
				card.name = "instantiatedRandomCard57b";
				
			}else if(card.name == "Card57c(Clone)"){
				
				card.name = "instantiatedRandomCard57c";
				
			}else if(card.name == "Card58(Clone)"){
				
				card.name = "instantiatedRandomCard58";
				
			}else if(card.name == "Card58a(Clone)"){
				
				card.name = "instantiatedRandomCard58a";
				
			}else if(card.name == "Card58b(Clone)"){
				
				card.name = "instantiatedRandomCard58b";
				
			}else if(card.name == "Card58c(Clone)"){
				
				card.name = "instantiatedRandomCard58c";
				
			}else if(card.name == "Card59(Clone)"){
				
				card.name = "instantiatedRandomCard59";
				
			}else if(card.name == "Card59a(Clone)"){
				
				card.name = "instantiatedRandomCard59a";
				
			}else if(card.name == "Card59b(Clone)"){
				
				card.name = "instantiatedRandomCard59b";
				
			}else if(card.name == "Card59c(Clone)"){
				
				card.name = "instantiatedRandomCard59c";
				
			}else if(card.name == "Card60(Clone)"){
				
				card.name = "instantiatedRandomCard60";
				
			}else if(card.name == "Card60a(Clone)"){
				
				card.name = "instantiatedRandomCard60a";
				
			}else if(card.name == "Card60b(Clone)"){
				
				card.name = "instantiatedRandomCard60b";
				
			}else if(card.name == "Card60c(Clone)"){
				
				card.name = "instantiatedRandomCard60c";
			}
			
			instances7++;
			
			}
			
		while(instances8 < NumberOfCards) {
			
			GameObject card = Instantiate (cardsInDeck240[Random.Range(0,cardsInDeck240.Length)], spawnPoints8.transform.position,spawnPoints8.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(325f,200f,340.0f);
			
			if(card.name == "Card1(Clone)"){
				
				card.name = "instantiatedRandomCard1";
				
			}else if(card.name == "Card1a(Clone)"){
				
				card.name = "instantiatedRandomCard1a";
				
			}else if(card.name == "Card1b(Clone)"){
				
				card.name = "instantiatedRandomCard1b";
				
			}else if(card.name == "Card1c(Clone)"){
				
				card.name = "instantiatedRandomCard1c";
				
			}else if(card.name == "Card2(Clone)"){
				
				card.name = "instantiatedRandomCard2";
				
			}else if(card.name == "Card2a(Clone)"){
				
				card.name = "instantiatedRandomCard2a";
				
			}else if(card.name == "Card2b(Clone)"){
				
				card.name = "instantiatedRandomCard2b";
				
			}else if(card.name == "Card2c(Clone)"){
				
				card.name = "instantiatedRandomCard2c";
				
			}else if(card.name == "Card3(Clone)"){
				
				card.name = "instantiatedRandomCard3";
				
			}else if(card.name == "Card3a(Clone)"){
				
				card.name = "instantiatedRandomCard3a";
				
			}else if(card.name == "Card3b(Clone)"){
				
				card.name = "instantiatedRandomCard3b";
				
			}else if(card.name == "Card3c(Clone)"){
				
				card.name = "instantiatedRandomCard3c";
				
			}else if(card.name == "Card4(Clone)"){
				
				card.name = "instantiatedRandomCard4";
				
			}else if(card.name == "Card4a(Clone)"){
				
				card.name = "instantiatedRandomCard4a";
				
			}else if(card.name == "Card4b(Clone)"){
				
				card.name = "instantiatedRandomCard4b";
				
			}else if(card.name == "Card4c(Clone)"){
				
				card.name = "instantiatedRandomCard4c";
				
			}else if(card.name == "Card5(Clone)"){
				
				card.name = "instantiatedRandomCard5";
				
			}else if(card.name == "Card5a(Clone)"){
				
				card.name = "instantiatedRandomCard5a";
				
			}else if(card.name == "Card5b(Clone)"){
				
				card.name = "instantiatedRandomCard5b";
				
			}else if(card.name == "Card5c(Clone)"){
				
				card.name = "instantiatedRandomCard5c";
				
			}else if(card.name == "Card6(Clone)"){
				
				card.name = "instantiatedRandomCard6";
				
			}else if(card.name == "Card6a(Clone)"){
				
				card.name = "instantiatedRandomCard6a";
				
			}else if(card.name == "Card6b(Clone)"){
				
				card.name = "instantiatedRandomCard6b";
				
			}else if(card.name == "Card6c(Clone)"){
				
				card.name = "instantiatedRandomCard6c";
				
			}else if(card.name == "Card7(Clone)"){
				
				card.name = "instantiatedRandomCard7";
				
			}else if(card.name == "Card7a(Clone)"){
				
				card.name = "instantiatedRandomCard7a";
				
			}else if(card.name == "Card7b(Clone)"){
				
				card.name = "instantiatedRandomCard7b";
				
			}else if(card.name == "Card7c(Clone)"){
				
				card.name = "instantiatedRandomCard7c";
				
			}else if(card.name == "Card8(Clone)"){
				
				card.name = "instantiatedRandomCard8";
				
			}else if(card.name == "Card8a(Clone)"){
				
				card.name = "instantiatedRandomCard8a";
				
			}else if(card.name == "Card8b(Clone)"){
				
				card.name = "instantiatedRandomCard8b";
				
			}else if(card.name == "Card8c(Clone)"){
				
				card.name = "instantiatedRandomCard8c";
				
			}else if(card.name == "Card9(Clone)"){
				
				card.name = "instantiatedRandomCard9";
				
			}else if(card.name == "Card9a(Clone)"){
				
				card.name = "instantiatedRandomCard9a";
				
			}else if(card.name == "Card9b(Clone)"){
				
				card.name = "instantiatedRandomCard9b";
				
			}else if(card.name == "Card9c(Clone)"){
				
				card.name = "instantiatedRandomCard9c";
				
			}else if(card.name == "Card10(Clone)"){
				
				card.name = "instantiatedAICard10";
				
			}else if(card.name == "Card10a(Clone)"){
				
				card.name = "instantiatedRandomCard10a";
				
			}else if(card.name == "Card10b(Clone)"){
				
				card.name = "instantiatedRandomCard10b";
				
			}else if(card.name == "Card10c(Clone)"){
				
				card.name = "instantiatedRandomCard10c";
				
			}else if(card.name == "Card11(Clone)"){
				
				card.name = "instantiatedRandomCard11";
				
			}else if(card.name == "Card11a(Clone)"){
				
				card.name = "instantiatedRandomCard11a";
				
			}else if(card.name == "Card11b(Clone)"){
				
				card.name = "instantiatedRandomCard11b";
				
			}else if(card.name == "Card11c(Clone)"){
				
				card.name = "instantiatedRandomCard11c";
				
			}else if(card.name == "Card12(Clone)"){
				
				card.name = "instantiatedRandomCard12";
				
			}else if(card.name == "Card12a(Clone)"){
				
				card.name = "instantiatedRandomCard12a";
				
			}else if(card.name == "Card12b(Clone)"){
				
				card.name = "instantiatedRandomCard12b";
				
			}else if(card.name == "Card12c(Clone)"){
				
				card.name = "instantiatedRandomCard12c";
				
			}else if(card.name == "Card13(Clone)"){
				
				card.name = "instantiatedRandomCard13";
				
			}else if(card.name == "Card13a(Clone)"){
				
				card.name = "instantiatedRandomCard13a";
				
			}else if(card.name == "Card13b(Clone)"){
				
				card.name = "instantiatedRandomCard13b";
				
			}else if(card.name == "Card13c(Clone)"){
				
				card.name = "instantiatedRandomCard13c";
				
			}else if(card.name == "Card14(Clone)"){
				
				card.name = "instantiatedRandomCard14";
				
			}else if(card.name == "Card14a(Clone)"){
				
				card.name = "instantiatedRandomCard14a";
				
			}else if(card.name == "Card14b(Clone)"){
				
				card.name = "instantiatedRandomCard14b";
				
			}else if(card.name == "Card14c(Clone)"){
				
				card.name = "instantiatedRandomCard14c";
				
			}else if(card.name == "Card15(Clone)"){
				
				card.name = "instantiatedRandomCard15";
				
			}else if(card.name == "Card15a(Clone)"){
				
				card.name = "instantiatedRandomCard15a";
				
			}else if(card.name == "Card15b(Clone)"){
				
				card.name = "instantiatedRandomCard15b";
				
			}else if(card.name == "Card15c(Clone)"){
				
				card.name = "instantiatedRandomCard15c";
				
			}else if(card.name == "Card16(Clone)"){
				
				card.name = "instantiatedRandomCard16";
				
			}else if(card.name == "Card16a(Clone)"){
				
				card.name = "instantiatedRandomCard16a";
				
			}else if(card.name == "Card16b(Clone)"){
				
				card.name = "instantiatedRandomCard16b";
				
			}else if(card.name == "Card16c(Clone)"){
				
				card.name = "instantiatedRandomCard16c";
				
			}else if(card.name == "Card17(Clone)"){
				
				card.name = "instantiatedRandomCard17";
				
			}else if(card.name == "Card17a(Clone)"){
				
				card.name = "instantiatedRandomCard17a";
				
			}else if(card.name == "Card17b(Clone)"){
				
				card.name = "instantiatedRandomCard17b";
				
			}else if(card.name == "Card17c(Clone)"){
				
				card.name = "instantiatedRandomCard17c";
				
			}else if(card.name == "Card18(Clone)"){
				
				card.name = "instantiatedRandomCard18";
				
			}else if(card.name == "Card18a(Clone)"){
				
				card.name = "instantiatedRandomCard18a";
				
			}else if(card.name == "Card18b(Clone)"){
				
				card.name = "instantiatedRandomCard18b";
				
			}else if(card.name == "Card18c(Clone)"){
				
				card.name = "instantiatedRandomCard18c";
				
			}else if(card.name == "Card19(Clone)"){
				
				card.name = "instantiatedRandomCard19";
				
			}else if(card.name == "Card19a(Clone)"){
				
				card.name = "instantiatedRandomCard19a";
				
			}else if(card.name == "Card19b(Clone)"){
				
				card.name = "instantiatedRandomCard19b";
				
			}else if(card.name == "Card19c(Clone)"){
				
				card.name = "instantiatedRandomCard19c";
				
			}else if(card.name == "Card20(Clone)"){
				
				card.name = "instantiatedRandomCard20";
				
			}else if(card.name == "Card20a(Clone)"){
				
				card.name = "instantiatedRandomCard20a";
				
			}else if(card.name == "Card20b(Clone)"){
				
				card.name = "instantiatedRandomCard20b";
				
			}else if(card.name == "Card20c(Clone)"){
				
				card.name = "instantiatedRandomCard20c";
				
			}else if(card.name == "Card21(Clone)"){
				
				card.name = "instantiatedRandomCard21";
				
			}else if(card.name == "Card21a(Clone)"){
				
				card.name = "instantiatedRandomCard21a";
				
			}else if(card.name == "Card21b(Clone)"){
				
				card.name = "instantiatedRandomCard21b";
				
			}else if(card.name == "Card21c(Clone)"){
				
				card.name = "instantiatedRandomCard21c";
				
			}else if(card.name == "Card22(Clone)"){
				
				card.name = "instantiatedRandomCard22";
				
			}else if(card.name == "Card22a(Clone)"){
				
				card.name = "instantiatedRandomCard22a";
				
			}else if(card.name == "Card22b(Clone)"){
				
				card.name = "instantiatedRandomCard22b";
				
			}else if(card.name == "Card22c(Clone)"){
				
				card.name = "instantiatedRandomCard22c";
				
			}else if(card.name == "Card23(Clone)"){
				
				card.name = "instantiatedRandomCard23";
				
			}else if(card.name == "Card23a(Clone)"){
				
				card.name = "instantiatedRandomCard23a";
				
			}else if(card.name == "Card23b(Clone)"){
				
				card.name = "instantiatedRandomCard23b";
				
			}else if(card.name == "Card23c(Clone)"){
				
				card.name = "instantiatedRandomCard23c";
				
			}else if(card.name == "Card24(Clone)"){
				
				card.name = "instantiatedRandomCard24";
				
			}else if(card.name == "Card24a(Clone)"){
				
				card.name = "instantiatedRandomCard24a";
				
			}else if(card.name == "Card24b(Clone)"){
				
				card.name = "instantiatedRandomCard24b";
				
			}else if(card.name == "Card24c(Clone)"){
				
				card.name = "instantiatedRandomCard24c";
				
			}else if(card.name == "Card25(Clone)"){
				
				card.name = "instantiatedRandomCard25";
				
			}else if(card.name == "Card25a(Clone)"){
				
				card.name = "instantiatedRandomCard25a";
				
			}else if(card.name == "Card25b(Clone)"){
				
				card.name = "instantiatedRandomCard25b";
				
			}else if(card.name == "Card25c(Clone)"){
				
				card.name = "instantiatedRandomCard25c";
				
			}else if(card.name == "Card26(Clone)"){
				
				card.name = "instantiatedRandomCard26";
				
			}else if(card.name == "Card26a(Clone)"){
				
				card.name = "instantiatedRandomCard26a";
				
			}else if(card.name == "Card26b(Clone)"){
				
				card.name = "instantiatedRandomCard26b";
				
			}else if(card.name == "Card26c(Clone)"){
				
				card.name = "instantiatedRandomCard26c";
				
			}else if(card.name == "Card27(Clone)"){
				
				card.name = "instantiatedRandomCard27";
				
			}else if(card.name == "Card27a(Clone)"){
				
				card.name = "instantiatedRandomCard27a";
				
			}else if(card.name == "Card27b(Clone)"){
				
				card.name = "instantiatedRandomCard27b";
				
			}else if(card.name == "Card27c(Clone)"){
				
				card.name = "instantiatedRandomCard27c";
				
			}else if(card.name == "Card28(Clone)"){
				
				card.name = "instantiatedRandomCard28";
				
			}else if(card.name == "Card28a(Clone)"){
				
				card.name = "instantiatedRandomCard28a";
				
			}else if(card.name == "Card28b(Clone)"){
				
				card.name = "instantiatedRandomCard28b";
				
			}else if(card.name == "Card28c(Clone)"){
				
				card.name = "instantiatedRandomCard28c";
				
			}else if(card.name == "Card29(Clone)"){
				
				card.name = "instantiatedRandomCard29";
				
			}else if(card.name == "Card29a(Clone)"){
				
				card.name = "instantiatedRandomCard29a";
				
			}else if(card.name == "Card29b(Clone)"){
				
				card.name = "instantiatedRandomCard29b";
				
			}else if(card.name == "Card29c(Clone)"){
				
				card.name = "instantiatedRandomCard29c";
				
			}else if(card.name == "Card30(Clone)"){
				
				card.name = "instantiatedRandomCard30";
				
			}else if(card.name == "Card30a(Clone)"){
				
				card.name = "instantiatedRandomCard30a";
				
			}else if(card.name == "Card30b(Clone)"){
				
				card.name = "instantiatedRandomCard30b";
				
			}else if(card.name == "Card30c(Clone)"){
				
				card.name = "instantiatedRandomCard30c";
				
			}else if(card.name == "Card31(Clone)"){
				
				card.name = "instantiatedRandomCard31";
				
			}else if(card.name == "Card31a(Clone)"){
				
				card.name = "instantiatedRandomCard31a";
				
			}else if(card.name == "Card31b(Clone)"){
				
				card.name = "instantiatedRandomCard31b";
				
			}else if(card.name == "Card31c(Clone)"){
				
				card.name = "instantiatedRandomCard31c";
				
			}else if(card.name == "Card32(Clone)"){
				
				card.name = "instantiatedRandomCard32";
				
			}else if(card.name == "Card32a(Clone)"){
				
				card.name = "instantiatedRandomCard32a";
				
			}else if(card.name == "Card32b(Clone)"){
				
				card.name = "instantiatedRandomCard32b";
				
			}else if(card.name == "Card32c(Clone)"){
				
				card.name = "instantiatedRandomCard32c";
				
			}else if(card.name == "Card33(Clone)"){
				
				card.name = "instantiatedRandomCard33";
				
			}else if(card.name == "Card33a(Clone)"){
				
				card.name = "instantiatedRandomCard33a";
				
			}else if(card.name == "Card33b(Clone)"){
				
				card.name = "instantiatedRandomCard33b";
				
			}else if(card.name == "Card33c(Clone)"){
				
				card.name = "instantiatedRandomCard33c";
				
			}else if(card.name == "Card34(Clone)"){
				
				card.name = "instantiatedRandomCard34";
				
			}else if(card.name == "Card34a(Clone)"){
				
				card.name = "instantiatedRandomCard34a";
				
			}else if(card.name == "Card34b(Clone)"){
				
				card.name = "instantiatedRandomCard34b";
				
			}else if(card.name == "Card34c(Clone)"){
				
				card.name = "instantiatedRandomCard34c";
				
			}else if(card.name == "Card35(Clone)"){
				
				card.name = "instantiatedRandomCard35";
				
			}else if(card.name == "Card35a(Clone)"){
				
				card.name = "instantiatedRandomCard35a";
				
			}else if(card.name == "Card35b(Clone)"){
				
				card.name = "instantiatedRandomCard35b";
				
			}else if(card.name == "Card35c(Clone)"){
				
				card.name = "instantiatedRandomCard35c";
				
			}else if(card.name == "Card36(Clone)"){
				
				card.name = "instantiatedRandomCard36";
				
			}else if(card.name == "Card36a(Clone)"){
				
				card.name = "instantiatedRandomCard36a";
				
			}else if(card.name == "Card36b(Clone)"){
				
				card.name = "instantiatedRandomCard36b";
				
			}else if(card.name == "Card36c(Clone)"){
				
				card.name = "instantiatedRandomCard36c";
				
			}else if(card.name == "Card37(Clone)"){
				
				card.name = "instantiatedRandomCard37";
				
			}else if(card.name == "Card37a(Clone)"){
				
				card.name = "instantiatedRandomCard37a";
				
			}else if(card.name == "Card37b(Clone)"){
				
				card.name = "instantiatedRandomCard37b";
				
			}else if(card.name == "Card37c(Clone)"){
				
				card.name = "instantiatedRandomCard37c";
				
			}else if(card.name == "Card38(Clone)"){
				
				card.name = "instantiatedRandomCard38";
				
			}else if(card.name == "Card38a(Clone)"){
				
				card.name = "instantiatedRandomCard38a";
				
			}else if(card.name == "Card38b(Clone)"){
				
				card.name = "instantiatedRandomCard38b";
				
			}else if(card.name == "Card38c(Clone)"){
				
				card.name = "instantiatedRandomCard38c";
				
			}else if(card.name == "Card39(Clone)"){
				
				card.name = "instantiatedRandomCard39";
				
			}else if(card.name == "Card39a(Clone)"){
				
				card.name = "instantiatedRandomCard39a";
				
			}else if(card.name == "Card39b(Clone)"){
				
				card.name = "instantiatedRandomCard39b";
				
			}else if(card.name == "Card39c(Clone)"){
				
				card.name = "instantiatedRandomCard39c";
				
			}else if(card.name == "Card40(Clone)"){
				
				card.name = "instantiatedRandomCard40";
				
			}else if(card.name == "Card40a(Clone)"){
				
				card.name = "instantiatedRandomCard40a";
				
			}else if(card.name == "Card40b(Clone)"){
				
				card.name = "instantiatedRandomCard40b";
				
			}else if(card.name == "Card40c(Clone)"){
				
				card.name = "instantiatedRandomCard40c";
				
			}else if(card.name == "Card41(Clone)"){
				
				card.name = "instantiatedRandomCard41";
				
			}else if(card.name == "Card41a(Clone)"){
				
				card.name = "instantiatedRandomCard41a";
				
			}else if(card.name == "Card41b(Clone)"){
				
				card.name = "instantiatedRandomCard41b";
				
			}else if(card.name == "Card41c(Clone)"){
				
				card.name = "instantiatedRandomCard41c";
				
			}else if(card.name == "Card42(Clone)"){
				
				card.name = "instantiatedRandomCard42";
				
			}else if(card.name == "Card42a(Clone)"){
				
				card.name = "instantiatedRandomCard42a";
				
			}else if(card.name == "Card42b(Clone)"){
				
				card.name = "instantiatedRandomCard42b";
				
			}else if(card.name == "Card42c(Clone)"){
				
				card.name = "instantiatedRandomCard42c";
				
			}else if(card.name == "Card43(Clone)"){
				
				card.name = "instantiatedRandomCard43";
				
			}else if(card.name == "Card43a(Clone)"){
				
				card.name = "instantiatedRandomCard43a";
				
			}else if(card.name == "Card43b(Clone)"){
				
				card.name = "instantiatedRandomCard43b";
				
			}else if(card.name == "Card43c(Clone)"){
				
				card.name = "instantiatedRandomCard43c";
				
			}else if(card.name == "Card44(Clone)"){
				
				card.name = "instantiatedRandomCard44";
				
			}else if(card.name == "Card44a(Clone)"){
				
				card.name = "instantiatedRandomCard44a";
				
			}else if(card.name == "Card44b(Clone)"){
				
				card.name = "instantiatedRandomCard44b";
				
			}else if(card.name == "Card44c(Clone)"){
				
				card.name = "instantiatedRandomCard44c";
				
			}else if(card.name == "Card45(Clone)"){
				
				card.name = "instantiatedRandomCard45";
				
			}else if(card.name == "Card45a(Clone)"){
				
				card.name = "instantiatedRandomCard45a";
				
			}else if(card.name == "Card45b(Clone)"){
				
				card.name = "instantiatedRandomCard45b";
				
			}else if(card.name == "Card45c(Clone)"){
				
				card.name = "instantiatedRandomCard45c";
				
			}else if(card.name == "Card46(Clone)"){
				
				card.name = "instantiatedRandomCard46";
				
			}else if(card.name == "Card46a(Clone)"){
				
				card.name = "instantiatedRandomCard46a";
				
			}else if(card.name == "Card46b(Clone)"){
				
				card.name = "instantiatedRandomCard46b";
				
			}else if(card.name == "Card46c(Clone)"){
				
				card.name = "instantiatedRandomCard46c";
				
			}else if(card.name == "Card47(Clone)"){
				
				card.name = "instantiatedRandomCard47";
				
			}else if(card.name == "Card47a(Clone)"){
				
				card.name = "instantiatedRandomCard47a";
				
			}else if(card.name == "Card47b(Clone)"){
				
				card.name = "instantiatedRandomCard47b";
				
			}else if(card.name == "Card47c(Clone)"){
				
				card.name = "instantiatedRandomCard47c";
				
			}else if(card.name == "Card48(Clone)"){
				
				card.name = "instantiatedRandomCard48";
				
			}else if(card.name == "Card48a(Clone)"){
				
				card.name = "instantiatedRandomCard48a";
				
			}else if(card.name == "Card48b(Clone)"){
				
				card.name = "instantiatedRandomCard48b";
				
			}else if(card.name == "Card48c(Clone)"){
				
				card.name = "instantiatedRandomCard48c";
				
			}else if(card.name == "Card49(Clone)"){
				
				card.name = "instantiatedRandomCard49";
				
			}else if(card.name == "Card49a(Clone)"){
				
				card.name = "instantiatedRandomCard49a";
				
			}else if(card.name == "Card49b(Clone)"){
				
				card.name = "instantiatedRandomCard49b";
				
			}else if(card.name == "Card49c(Clone)"){
				
				card.name = "instantiatedRandomCard49c";
				
			}else if(card.name == "Card50(Clone)"){
				
				card.name = "instantiatedRandomCard50";
				
			}else if(card.name == "Card50a(Clone)"){
				
				card.name = "instantiatedRandomCard50a";
				
			}else if(card.name == "Card50b(Clone)"){
				
				card.name = "instantiatedRandomCard50b";
				
			}else if(card.name == "Card50c(Clone)"){
				
				card.name = "instantiatedRandomCard50c";
				
			}else if(card.name == "Card51(Clone)"){
				
				card.name = "instantiatedRandomCard51";
				
			}else if(card.name == "Card51a(Clone)"){
				
				card.name = "instantiatedRandomCard51a";
				
			}else if(card.name == "Card51b(Clone)"){
				
				card.name = "instantiatedRandomCard51b";
				
			}else if(card.name == "Card51c(Clone)"){
				
				card.name = "instantiatedRandomCard51c";
				
			}else if(card.name == "Card52(Clone)"){
				
				card.name = "instantiatedRandomCard52";
				
			}else if(card.name == "Card52a(Clone)"){
				
				card.name = "instantiatedRandomCard52a";
				
			}else if(card.name == "Card52b(Clone)"){
				
				card.name = "instantiatedRandomCard52b";
				
			}else if(card.name == "Card52c(Clone)"){
				
				card.name = "instantiatedRandomCard52c";
				
			}else if(card.name == "Card53(Clone)"){
				
				card.name = "instantiatedRandomCard53";
				
			}else if(card.name == "Card53a(Clone)"){
				
				card.name = "instantiatedRandomCard53a";
				
			}else if(card.name == "Card53b(Clone)"){
				
				card.name = "instantiatedRandomCard53b";
				
			}else if(card.name == "Card53c(Clone)"){
				
				card.name = "instantiatedRandomCard53c";
				
			}else if(card.name == "Card54(Clone)"){
				
				card.name = "instantiatedRandomCard54";
				
			}else if(card.name == "Card54a(Clone)"){
				
				card.name = "instantiatedRandomCard54a";
				
			}else if(card.name == "Card54b(Clone)"){
				
				card.name = "instantiatedRandomCard54b";
				
			}else if(card.name == "Card54c(Clone)"){
				
				card.name = "instantiatedRandomCard54c";
				
			}else if(card.name == "Card55(Clone)"){
				
				card.name = "instantiatedRandomCard55";
				
			}else if(card.name == "Card55a(Clone)"){
				
				card.name = "instantiatedRandomCard55a";
				
			}else if(card.name == "Card55b(Clone)"){
				
				card.name = "instantiatedRandomCard55b";
				
			}else if(card.name == "Card55c(Clone)"){
				
				card.name = "instantiatedRandomCard55c";
				
			}else if(card.name == "Card56(Clone)"){
				
				card.name = "instantiatedRandomCard56";
				
			}else if(card.name == "Card56a(Clone)"){
				
				card.name = "instantiatedRandomCard56a";
				
			}else if(card.name == "Card56b(Clone)"){
				
				card.name = "instantiatedRandomCard56b";
				
			}else if(card.name == "Card56c(Clone)"){
				
				card.name = "instantiatedRandomCard56c";
				
			}else if(card.name == "Card57(Clone)"){
				
				card.name = "instantiatedRandomCard57";
				
			}else if(card.name == "Card57a(Clone)"){
				
				card.name = "instantiatedRandomCard57a";
				
			}else if(card.name == "Card57b(Clone)"){
				
				card.name = "instantiatedRandomCard57b";
				
			}else if(card.name == "Card57c(Clone)"){
				
				card.name = "instantiatedRandomCard57c";
				
			}else if(card.name == "Card58(Clone)"){
				
				card.name = "instantiatedRandomCard58";
				
			}else if(card.name == "Card58a(Clone)"){
				
				card.name = "instantiatedRandomCard58a";
				
			}else if(card.name == "Card58b(Clone)"){
				
				card.name = "instantiatedRandomCard58b";
				
			}else if(card.name == "Card58c(Clone)"){
				
				card.name = "instantiatedRandomCard58c";
				
			}else if(card.name == "Card59(Clone)"){
				
				card.name = "instantiatedRandomCard59";
				
			}else if(card.name == "Card59a(Clone)"){
				
				card.name = "instantiatedRandomCard59a";
				
			}else if(card.name == "Card59b(Clone)"){
				
				card.name = "instantiatedRandomCard59b";
				
			}else if(card.name == "Card59c(Clone)"){
				
				card.name = "instantiatedRandomCard59c";
				
			}else if(card.name == "Card60(Clone)"){
				
				card.name = "instantiatedRandomCard60";
				
			}else if(card.name == "Card60a(Clone)"){
				
				card.name = "instantiatedRandomCard60a";
				
			}else if(card.name == "Card60b(Clone)"){
				
				card.name = "instantiatedRandomCard60b";
				
			}else if(card.name == "Card60c(Clone)"){
				
				card.name = "instantiatedRandomCard60c";
			}
			
			instances8++;
			
			}
			
		while(instances9 < NumberOfCards) {
			
			GameObject card = Instantiate (cardsInDeck240[Random.Range(0,cardsInDeck240.Length)], spawnPoints9.transform.position,spawnPoints9.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(325f,200f,340.0f);
			
			if(card.name == "Card1(Clone)"){
				
				card.name = "instantiatedRandomCard1";
				
			}else if(card.name == "Card1a(Clone)"){
				
				card.name = "instantiatedRandomCard1a";
				
			}else if(card.name == "Card1b(Clone)"){
				
				card.name = "instantiatedRandomCard1b";
				
			}else if(card.name == "Card1c(Clone)"){
				
				card.name = "instantiatedRandomCard1c";
				
			}else if(card.name == "Card2(Clone)"){
				
				card.name = "instantiatedRandomCard2";
				
			}else if(card.name == "Card2a(Clone)"){
				
				card.name = "instantiatedRandomCard2a";
				
			}else if(card.name == "Card2b(Clone)"){
				
				card.name = "instantiatedRandomCard2b";
				
			}else if(card.name == "Card2c(Clone)"){
				
				card.name = "instantiatedRandomCard2c";
				
			}else if(card.name == "Card3(Clone)"){
				
				card.name = "instantiatedRandomCard3";
				
			}else if(card.name == "Card3a(Clone)"){
				
				card.name = "instantiatedRandomCard3a";
				
			}else if(card.name == "Card3b(Clone)"){
				
				card.name = "instantiatedRandomCard3b";
				
			}else if(card.name == "Card3c(Clone)"){
				
				card.name = "instantiatedRandomCard3c";
				
			}else if(card.name == "Card4(Clone)"){
				
				card.name = "instantiatedRandomCard4";
				
			}else if(card.name == "Card4a(Clone)"){
				
				card.name = "instantiatedRandomCard4a";
				
			}else if(card.name == "Card4b(Clone)"){
				
				card.name = "instantiatedRandomCard4b";
				
			}else if(card.name == "Card4c(Clone)"){
				
				card.name = "instantiatedRandomCard4c";
				
			}else if(card.name == "Card5(Clone)"){
				
				card.name = "instantiatedRandomCard5";
				
			}else if(card.name == "Card5a(Clone)"){
				
				card.name = "instantiatedRandomCard5a";
				
			}else if(card.name == "Card5b(Clone)"){
				
				card.name = "instantiatedRandomCard5b";
				
			}else if(card.name == "Card5c(Clone)"){
				
				card.name = "instantiatedRandomCard5c";
				
			}else if(card.name == "Card6(Clone)"){
				
				card.name = "instantiatedRandomCard6";
				
			}else if(card.name == "Card6a(Clone)"){
				
				card.name = "instantiatedRandomCard6a";
				
			}else if(card.name == "Card6b(Clone)"){
				
				card.name = "instantiatedRandomCard6b";
				
			}else if(card.name == "Card6c(Clone)"){
				
				card.name = "instantiatedRandomCard6c";
				
			}else if(card.name == "Card7(Clone)"){
				
				card.name = "instantiatedRandomCard7";
				
			}else if(card.name == "Card7a(Clone)"){
				
				card.name = "instantiatedRandomCard7a";
				
			}else if(card.name == "Card7b(Clone)"){
				
				card.name = "instantiatedRandomCard7b";
				
			}else if(card.name == "Card7c(Clone)"){
				
				card.name = "instantiatedRandomCard7c";
				
			}else if(card.name == "Card8(Clone)"){
				
				card.name = "instantiatedRandomCard8";
				
			}else if(card.name == "Card8a(Clone)"){
				
				card.name = "instantiatedRandomCard8a";
				
			}else if(card.name == "Card8b(Clone)"){
				
				card.name = "instantiatedRandomCard8b";
				
			}else if(card.name == "Card8c(Clone)"){
				
				card.name = "instantiatedRandomCard8c";
				
			}else if(card.name == "Card9(Clone)"){
				
				card.name = "instantiatedRandomCard9";
				
			}else if(card.name == "Card9a(Clone)"){
				
				card.name = "instantiatedRandomCard9a";
				
			}else if(card.name == "Card9b(Clone)"){
				
				card.name = "instantiatedRandomCard9b";
				
			}else if(card.name == "Card9c(Clone)"){
				
				card.name = "instantiatedRandomCard9c";
				
			}else if(card.name == "Card10(Clone)"){
				
				card.name = "instantiatedAICard10";
				
			}else if(card.name == "Card10a(Clone)"){
				
				card.name = "instantiatedRandomCard10a";
				
			}else if(card.name == "Card10b(Clone)"){
				
				card.name = "instantiatedRandomCard10b";
				
			}else if(card.name == "Card10c(Clone)"){
				
				card.name = "instantiatedRandomCard10c";
				
			}else if(card.name == "Card11(Clone)"){
				
				card.name = "instantiatedRandomCard11";
				
			}else if(card.name == "Card11a(Clone)"){
				
				card.name = "instantiatedRandomCard11a";
				
			}else if(card.name == "Card11b(Clone)"){
				
				card.name = "instantiatedRandomCard11b";
				
			}else if(card.name == "Card11c(Clone)"){
				
				card.name = "instantiatedRandomCard11c";
				
			}else if(card.name == "Card12(Clone)"){
				
				card.name = "instantiatedRandomCard12";
				
			}else if(card.name == "Card12a(Clone)"){
				
				card.name = "instantiatedRandomCard12a";
				
			}else if(card.name == "Card12b(Clone)"){
				
				card.name = "instantiatedRandomCard12b";
				
			}else if(card.name == "Card12c(Clone)"){
				
				card.name = "instantiatedRandomCard12c";
				
			}else if(card.name == "Card13(Clone)"){
				
				card.name = "instantiatedRandomCard13";
				
			}else if(card.name == "Card13a(Clone)"){
				
				card.name = "instantiatedRandomCard13a";
				
			}else if(card.name == "Card13b(Clone)"){
				
				card.name = "instantiatedRandomCard13b";
				
			}else if(card.name == "Card13c(Clone)"){
				
				card.name = "instantiatedRandomCard13c";
				
			}else if(card.name == "Card14(Clone)"){
				
				card.name = "instantiatedRandomCard14";
				
			}else if(card.name == "Card14a(Clone)"){
				
				card.name = "instantiatedRandomCard14a";
				
			}else if(card.name == "Card14b(Clone)"){
				
				card.name = "instantiatedRandomCard14b";
				
			}else if(card.name == "Card14c(Clone)"){
				
				card.name = "instantiatedRandomCard14c";
				
			}else if(card.name == "Card15(Clone)"){
				
				card.name = "instantiatedRandomCard15";
				
			}else if(card.name == "Card15a(Clone)"){
				
				card.name = "instantiatedRandomCard15a";
				
			}else if(card.name == "Card15b(Clone)"){
				
				card.name = "instantiatedRandomCard15b";
				
			}else if(card.name == "Card15c(Clone)"){
				
				card.name = "instantiatedRandomCard15c";
				
			}else if(card.name == "Card16(Clone)"){
				
				card.name = "instantiatedRandomCard16";
				
			}else if(card.name == "Card16a(Clone)"){
				
				card.name = "instantiatedRandomCard16a";
				
			}else if(card.name == "Card16b(Clone)"){
				
				card.name = "instantiatedRandomCard16b";
				
			}else if(card.name == "Card16c(Clone)"){
				
				card.name = "instantiatedRandomCard16c";
				
			}else if(card.name == "Card17(Clone)"){
				
				card.name = "instantiatedRandomCard17";
				
			}else if(card.name == "Card17a(Clone)"){
				
				card.name = "instantiatedRandomCard17a";
				
			}else if(card.name == "Card17b(Clone)"){
				
				card.name = "instantiatedRandomCard17b";
				
			}else if(card.name == "Card17c(Clone)"){
				
				card.name = "instantiatedRandomCard17c";
				
			}else if(card.name == "Card18(Clone)"){
				
				card.name = "instantiatedRandomCard18";
				
			}else if(card.name == "Card18a(Clone)"){
				
				card.name = "instantiatedRandomCard18a";
				
			}else if(card.name == "Card18b(Clone)"){
				
				card.name = "instantiatedRandomCard18b";
				
			}else if(card.name == "Card18c(Clone)"){
				
				card.name = "instantiatedRandomCard18c";
				
			}else if(card.name == "Card19(Clone)"){
				
				card.name = "instantiatedRandomCard19";
				
			}else if(card.name == "Card19a(Clone)"){
				
				card.name = "instantiatedRandomCard19a";
				
			}else if(card.name == "Card19b(Clone)"){
				
				card.name = "instantiatedRandomCard19b";
				
			}else if(card.name == "Card19c(Clone)"){
				
				card.name = "instantiatedRandomCard19c";
				
			}else if(card.name == "Card20(Clone)"){
				
				card.name = "instantiatedRandomCard20";
				
			}else if(card.name == "Card20a(Clone)"){
				
				card.name = "instantiatedRandomCard20a";
				
			}else if(card.name == "Card20b(Clone)"){
				
				card.name = "instantiatedRandomCard20b";
				
			}else if(card.name == "Card20c(Clone)"){
				
				card.name = "instantiatedRandomCard20c";
				
			}else if(card.name == "Card21(Clone)"){
				
				card.name = "instantiatedRandomCard21";
				
			}else if(card.name == "Card21a(Clone)"){
				
				card.name = "instantiatedRandomCard21a";
				
			}else if(card.name == "Card21b(Clone)"){
				
				card.name = "instantiatedRandomCard21b";
				
			}else if(card.name == "Card21c(Clone)"){
				
				card.name = "instantiatedRandomCard21c";
				
			}else if(card.name == "Card22(Clone)"){
				
				card.name = "instantiatedRandomCard22";
				
			}else if(card.name == "Card22a(Clone)"){
				
				card.name = "instantiatedRandomCard22a";
				
			}else if(card.name == "Card22b(Clone)"){
				
				card.name = "instantiatedRandomCard22b";
				
			}else if(card.name == "Card22c(Clone)"){
				
				card.name = "instantiatedRandomCard22c";
				
			}else if(card.name == "Card23(Clone)"){
				
				card.name = "instantiatedRandomCard23";
				
			}else if(card.name == "Card23a(Clone)"){
				
				card.name = "instantiatedRandomCard23a";
				
			}else if(card.name == "Card23b(Clone)"){
				
				card.name = "instantiatedRandomCard23b";
				
			}else if(card.name == "Card23c(Clone)"){
				
				card.name = "instantiatedRandomCard23c";
				
			}else if(card.name == "Card24(Clone)"){
				
				card.name = "instantiatedRandomCard24";
				
			}else if(card.name == "Card24a(Clone)"){
				
				card.name = "instantiatedRandomCard24a";
				
			}else if(card.name == "Card24b(Clone)"){
				
				card.name = "instantiatedRandomCard24b";
				
			}else if(card.name == "Card24c(Clone)"){
				
				card.name = "instantiatedRandomCard24c";
				
			}else if(card.name == "Card25(Clone)"){
				
				card.name = "instantiatedRandomCard25";
				
			}else if(card.name == "Card25a(Clone)"){
				
				card.name = "instantiatedRandomCard25a";
				
			}else if(card.name == "Card25b(Clone)"){
				
				card.name = "instantiatedRandomCard25b";
				
			}else if(card.name == "Card25c(Clone)"){
				
				card.name = "instantiatedRandomCard25c";
				
			}else if(card.name == "Card26(Clone)"){
				
				card.name = "instantiatedRandomCard26";
				
			}else if(card.name == "Card26a(Clone)"){
				
				card.name = "instantiatedRandomCard26a";
				
			}else if(card.name == "Card26b(Clone)"){
				
				card.name = "instantiatedRandomCard26b";
				
			}else if(card.name == "Card26c(Clone)"){
				
				card.name = "instantiatedRandomCard26c";
				
			}else if(card.name == "Card27(Clone)"){
				
				card.name = "instantiatedRandomCard27";
				
			}else if(card.name == "Card27a(Clone)"){
				
				card.name = "instantiatedRandomCard27a";
				
			}else if(card.name == "Card27b(Clone)"){
				
				card.name = "instantiatedRandomCard27b";
				
			}else if(card.name == "Card27c(Clone)"){
				
				card.name = "instantiatedRandomCard27c";
				
			}else if(card.name == "Card28(Clone)"){
				
				card.name = "instantiatedRandomCard28";
				
			}else if(card.name == "Card28a(Clone)"){
				
				card.name = "instantiatedRandomCard28a";
				
			}else if(card.name == "Card28b(Clone)"){
				
				card.name = "instantiatedRandomCard28b";
				
			}else if(card.name == "Card28c(Clone)"){
				
				card.name = "instantiatedRandomCard28c";
				
			}else if(card.name == "Card29(Clone)"){
				
				card.name = "instantiatedRandomCard29";
				
			}else if(card.name == "Card29a(Clone)"){
				
				card.name = "instantiatedRandomCard29a";
				
			}else if(card.name == "Card29b(Clone)"){
				
				card.name = "instantiatedRandomCard29b";
				
			}else if(card.name == "Card29c(Clone)"){
				
				card.name = "instantiatedRandomCard29c";
				
			}else if(card.name == "Card30(Clone)"){
				
				card.name = "instantiatedRandomCard30";
				
			}else if(card.name == "Card30a(Clone)"){
				
				card.name = "instantiatedRandomCard30a";
				
			}else if(card.name == "Card30b(Clone)"){
				
				card.name = "instantiatedRandomCard30b";
				
			}else if(card.name == "Card30c(Clone)"){
				
				card.name = "instantiatedRandomCard30c";
				
			}else if(card.name == "Card31(Clone)"){
				
				card.name = "instantiatedRandomCard31";
				
			}else if(card.name == "Card31a(Clone)"){
				
				card.name = "instantiatedRandomCard31a";
				
			}else if(card.name == "Card31b(Clone)"){
				
				card.name = "instantiatedRandomCard31b";
				
			}else if(card.name == "Card31c(Clone)"){
				
				card.name = "instantiatedRandomCard31c";
				
			}else if(card.name == "Card32(Clone)"){
				
				card.name = "instantiatedRandomCard32";
				
			}else if(card.name == "Card32a(Clone)"){
				
				card.name = "instantiatedRandomCard32a";
				
			}else if(card.name == "Card32b(Clone)"){
				
				card.name = "instantiatedRandomCard32b";
				
			}else if(card.name == "Card32c(Clone)"){
				
				card.name = "instantiatedRandomCard32c";
				
			}else if(card.name == "Card33(Clone)"){
				
				card.name = "instantiatedRandomCard33";
				
			}else if(card.name == "Card33a(Clone)"){
				
				card.name = "instantiatedRandomCard33a";
				
			}else if(card.name == "Card33b(Clone)"){
				
				card.name = "instantiatedRandomCard33b";
				
			}else if(card.name == "Card33c(Clone)"){
				
				card.name = "instantiatedRandomCard33c";
				
			}else if(card.name == "Card34(Clone)"){
				
				card.name = "instantiatedRandomCard34";
				
			}else if(card.name == "Card34a(Clone)"){
				
				card.name = "instantiatedRandomCard34a";
				
			}else if(card.name == "Card34b(Clone)"){
				
				card.name = "instantiatedRandomCard34b";
				
			}else if(card.name == "Card34c(Clone)"){
				
				card.name = "instantiatedRandomCard34c";
				
			}else if(card.name == "Card35(Clone)"){
				
				card.name = "instantiatedRandomCard35";
				
			}else if(card.name == "Card35a(Clone)"){
				
				card.name = "instantiatedRandomCard35a";
				
			}else if(card.name == "Card35b(Clone)"){
				
				card.name = "instantiatedRandomCard35b";
				
			}else if(card.name == "Card35c(Clone)"){
				
				card.name = "instantiatedRandomCard35c";
				
			}else if(card.name == "Card36(Clone)"){
				
				card.name = "instantiatedRandomCard36";
				
			}else if(card.name == "Card36a(Clone)"){
				
				card.name = "instantiatedRandomCard36a";
				
			}else if(card.name == "Card36b(Clone)"){
				
				card.name = "instantiatedRandomCard36b";
				
			}else if(card.name == "Card36c(Clone)"){
				
				card.name = "instantiatedRandomCard36c";
				
			}else if(card.name == "Card37(Clone)"){
				
				card.name = "instantiatedRandomCard37";
				
			}else if(card.name == "Card37a(Clone)"){
				
				card.name = "instantiatedRandomCard37a";
				
			}else if(card.name == "Card37b(Clone)"){
				
				card.name = "instantiatedRandomCard37b";
				
			}else if(card.name == "Card37c(Clone)"){
				
				card.name = "instantiatedRandomCard37c";
				
			}else if(card.name == "Card38(Clone)"){
				
				card.name = "instantiatedRandomCard38";
				
			}else if(card.name == "Card38a(Clone)"){
				
				card.name = "instantiatedRandomCard38a";
				
			}else if(card.name == "Card38b(Clone)"){
				
				card.name = "instantiatedRandomCard38b";
				
			}else if(card.name == "Card38c(Clone)"){
				
				card.name = "instantiatedRandomCard38c";
				
			}else if(card.name == "Card39(Clone)"){
				
				card.name = "instantiatedRandomCard39";
				
			}else if(card.name == "Card39a(Clone)"){
				
				card.name = "instantiatedRandomCard39a";
				
			}else if(card.name == "Card39b(Clone)"){
				
				card.name = "instantiatedRandomCard39b";
				
			}else if(card.name == "Card39c(Clone)"){
				
				card.name = "instantiatedRandomCard39c";
				
			}else if(card.name == "Card40(Clone)"){
				
				card.name = "instantiatedRandomCard40";
				
			}else if(card.name == "Card40a(Clone)"){
				
				card.name = "instantiatedRandomCard40a";
				
			}else if(card.name == "Card40b(Clone)"){
				
				card.name = "instantiatedRandomCard40b";
				
			}else if(card.name == "Card40c(Clone)"){
				
				card.name = "instantiatedRandomCard40c";
				
			}else if(card.name == "Card41(Clone)"){
				
				card.name = "instantiatedRandomCard41";
				
			}else if(card.name == "Card41a(Clone)"){
				
				card.name = "instantiatedRandomCard41a";
				
			}else if(card.name == "Card41b(Clone)"){
				
				card.name = "instantiatedRandomCard41b";
				
			}else if(card.name == "Card41c(Clone)"){
				
				card.name = "instantiatedRandomCard41c";
				
			}else if(card.name == "Card42(Clone)"){
				
				card.name = "instantiatedRandomCard42";
				
			}else if(card.name == "Card42a(Clone)"){
				
				card.name = "instantiatedRandomCard42a";
				
			}else if(card.name == "Card42b(Clone)"){
				
				card.name = "instantiatedRandomCard42b";
				
			}else if(card.name == "Card42c(Clone)"){
				
				card.name = "instantiatedRandomCard42c";
				
			}else if(card.name == "Card43(Clone)"){
				
				card.name = "instantiatedRandomCard43";
				
			}else if(card.name == "Card43a(Clone)"){
				
				card.name = "instantiatedRandomCard43a";
				
			}else if(card.name == "Card43b(Clone)"){
				
				card.name = "instantiatedRandomCard43b";
				
			}else if(card.name == "Card43c(Clone)"){
				
				card.name = "instantiatedRandomCard43c";
				
			}else if(card.name == "Card44(Clone)"){
				
				card.name = "instantiatedRandomCard44";
				
			}else if(card.name == "Card44a(Clone)"){
				
				card.name = "instantiatedRandomCard44a";
				
			}else if(card.name == "Card44b(Clone)"){
				
				card.name = "instantiatedRandomCard44b";
				
			}else if(card.name == "Card44c(Clone)"){
				
				card.name = "instantiatedRandomCard44c";
				
			}else if(card.name == "Card45(Clone)"){
				
				card.name = "instantiatedRandomCard45";
				
			}else if(card.name == "Card45a(Clone)"){
				
				card.name = "instantiatedRandomCard45a";
				
			}else if(card.name == "Card45b(Clone)"){
				
				card.name = "instantiatedRandomCard45b";
				
			}else if(card.name == "Card45c(Clone)"){
				
				card.name = "instantiatedRandomCard45c";
				
			}else if(card.name == "Card46(Clone)"){
				
				card.name = "instantiatedRandomCard46";
				
			}else if(card.name == "Card46a(Clone)"){
				
				card.name = "instantiatedRandomCard46a";
				
			}else if(card.name == "Card46b(Clone)"){
				
				card.name = "instantiatedRandomCard46b";
				
			}else if(card.name == "Card46c(Clone)"){
				
				card.name = "instantiatedRandomCard46c";
				
			}else if(card.name == "Card47(Clone)"){
				
				card.name = "instantiatedRandomCard47";
				
			}else if(card.name == "Card47a(Clone)"){
				
				card.name = "instantiatedRandomCard47a";
				
			}else if(card.name == "Card47b(Clone)"){
				
				card.name = "instantiatedRandomCard47b";
				
			}else if(card.name == "Card47c(Clone)"){
				
				card.name = "instantiatedRandomCard47c";
				
			}else if(card.name == "Card48(Clone)"){
				
				card.name = "instantiatedRandomCard48";
				
			}else if(card.name == "Card48a(Clone)"){
				
				card.name = "instantiatedRandomCard48a";
				
			}else if(card.name == "Card48b(Clone)"){
				
				card.name = "instantiatedRandomCard48b";
				
			}else if(card.name == "Card48c(Clone)"){
				
				card.name = "instantiatedRandomCard48c";
				
			}else if(card.name == "Card49(Clone)"){
				
				card.name = "instantiatedRandomCard49";
				
			}else if(card.name == "Card49a(Clone)"){
				
				card.name = "instantiatedRandomCard49a";
				
			}else if(card.name == "Card49b(Clone)"){
				
				card.name = "instantiatedRandomCard49b";
				
			}else if(card.name == "Card49c(Clone)"){
				
				card.name = "instantiatedRandomCard49c";
				
			}else if(card.name == "Card50(Clone)"){
				
				card.name = "instantiatedRandomCard50";
				
			}else if(card.name == "Card50a(Clone)"){
				
				card.name = "instantiatedRandomCard50a";
				
			}else if(card.name == "Card50b(Clone)"){
				
				card.name = "instantiatedRandomCard50b";
				
			}else if(card.name == "Card50c(Clone)"){
				
				card.name = "instantiatedRandomCard50c";
				
			}else if(card.name == "Card51(Clone)"){
				
				card.name = "instantiatedRandomCard51";
				
			}else if(card.name == "Card51a(Clone)"){
				
				card.name = "instantiatedRandomCard51a";
				
			}else if(card.name == "Card51b(Clone)"){
				
				card.name = "instantiatedRandomCard51b";
				
			}else if(card.name == "Card51c(Clone)"){
				
				card.name = "instantiatedRandomCard51c";
				
			}else if(card.name == "Card52(Clone)"){
				
				card.name = "instantiatedRandomCard52";
				
			}else if(card.name == "Card52a(Clone)"){
				
				card.name = "instantiatedRandomCard52a";
				
			}else if(card.name == "Card52b(Clone)"){
				
				card.name = "instantiatedRandomCard52b";
				
			}else if(card.name == "Card52c(Clone)"){
				
				card.name = "instantiatedRandomCard52c";
				
			}else if(card.name == "Card53(Clone)"){
				
				card.name = "instantiatedRandomCard53";
				
			}else if(card.name == "Card53a(Clone)"){
				
				card.name = "instantiatedRandomCard53a";
				
			}else if(card.name == "Card53b(Clone)"){
				
				card.name = "instantiatedRandomCard53b";
				
			}else if(card.name == "Card53c(Clone)"){
				
				card.name = "instantiatedRandomCard53c";
				
			}else if(card.name == "Card54(Clone)"){
				
				card.name = "instantiatedRandomCard54";
				
			}else if(card.name == "Card54a(Clone)"){
				
				card.name = "instantiatedRandomCard54a";
				
			}else if(card.name == "Card54b(Clone)"){
				
				card.name = "instantiatedRandomCard54b";
				
			}else if(card.name == "Card54c(Clone)"){
				
				card.name = "instantiatedRandomCard54c";
				
			}else if(card.name == "Card55(Clone)"){
				
				card.name = "instantiatedRandomCard55";
				
			}else if(card.name == "Card55a(Clone)"){
				
				card.name = "instantiatedRandomCard55a";
				
			}else if(card.name == "Card55b(Clone)"){
				
				card.name = "instantiatedRandomCard55b";
				
			}else if(card.name == "Card55c(Clone)"){
				
				card.name = "instantiatedRandomCard55c";
				
			}else if(card.name == "Card56(Clone)"){
				
				card.name = "instantiatedRandomCard56";
				
			}else if(card.name == "Card56a(Clone)"){
				
				card.name = "instantiatedRandomCard56a";
				
			}else if(card.name == "Card56b(Clone)"){
				
				card.name = "instantiatedRandomCard56b";
				
			}else if(card.name == "Card56c(Clone)"){
				
				card.name = "instantiatedRandomCard56c";
				
			}else if(card.name == "Card57(Clone)"){
				
				card.name = "instantiatedRandomCard57";
				
			}else if(card.name == "Card57a(Clone)"){
				
				card.name = "instantiatedRandomCard57a";
				
			}else if(card.name == "Card57b(Clone)"){
				
				card.name = "instantiatedRandomCard57b";
				
			}else if(card.name == "Card57c(Clone)"){
				
				card.name = "instantiatedRandomCard57c";
				
			}else if(card.name == "Card58(Clone)"){
				
				card.name = "instantiatedRandomCard58";
				
			}else if(card.name == "Card58a(Clone)"){
				
				card.name = "instantiatedRandomCard58a";
				
			}else if(card.name == "Card58b(Clone)"){
				
				card.name = "instantiatedRandomCard58b";
				
			}else if(card.name == "Card58c(Clone)"){
				
				card.name = "instantiatedRandomCard58c";
				
			}else if(card.name == "Card59(Clone)"){
				
				card.name = "instantiatedRandomCard59";
				
			}else if(card.name == "Card59a(Clone)"){
				
				card.name = "instantiatedRandomCard59a";
				
			}else if(card.name == "Card59b(Clone)"){
				
				card.name = "instantiatedRandomCard59b";
				
			}else if(card.name == "Card59c(Clone)"){
				
				card.name = "instantiatedRandomCard59c";
				
			}else if(card.name == "Card60(Clone)"){
				
				card.name = "instantiatedRandomCard60";
				
			}else if(card.name == "Card60a(Clone)"){
				
				card.name = "instantiatedRandomCard60a";
				
			}else if(card.name == "Card60b(Clone)"){
				
				card.name = "instantiatedRandomCard60b";
				
			}else if(card.name == "Card60c(Clone)"){
				
				card.name = "instantiatedRandomCard60c";
			}
			
			instances9++;
			
			}
			
		while(instances10 < NumberOfCards) {
			
			GameObject card = Instantiate (cardsInDeck240[Random.Range(0,cardsInDeck240.Length)], spawnPoints10.transform.position,spawnPoints10.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(325f,200f,340.0f);
			
			if(card.name == "Card1(Clone)"){
				
				card.name = "instantiatedRandomCard1";
				
			}else if(card.name == "Card1a(Clone)"){
				
				card.name = "instantiatedRandomCard1a";
				
			}else if(card.name == "Card1b(Clone)"){
				
				card.name = "instantiatedRandomCard1b";
				
			}else if(card.name == "Card1c(Clone)"){
				
				card.name = "instantiatedRandomCard1c";
				
			}else if(card.name == "Card2(Clone)"){
				
				card.name = "instantiatedRandomCard2";
				
			}else if(card.name == "Card2a(Clone)"){
				
				card.name = "instantiatedRandomCard2a";
				
			}else if(card.name == "Card2b(Clone)"){
				
				card.name = "instantiatedRandomCard2b";
				
			}else if(card.name == "Card2c(Clone)"){
				
				card.name = "instantiatedRandomCard2c";
				
			}else if(card.name == "Card3(Clone)"){
				
				card.name = "instantiatedRandomCard3";
				
			}else if(card.name == "Card3a(Clone)"){
				
				card.name = "instantiatedRandomCard3a";
				
			}else if(card.name == "Card3b(Clone)"){
				
				card.name = "instantiatedRandomCard3b";
				
			}else if(card.name == "Card3c(Clone)"){
				
				card.name = "instantiatedRandomCard3c";
				
			}else if(card.name == "Card4(Clone)"){
				
				card.name = "instantiatedRandomCard4";
				
			}else if(card.name == "Card4a(Clone)"){
				
				card.name = "instantiatedRandomCard4a";
				
			}else if(card.name == "Card4b(Clone)"){
				
				card.name = "instantiatedRandomCard4b";
				
			}else if(card.name == "Card4c(Clone)"){
				
				card.name = "instantiatedRandomCard4c";
				
			}else if(card.name == "Card5(Clone)"){
				
				card.name = "instantiatedRandomCard5";
				
			}else if(card.name == "Card5a(Clone)"){
				
				card.name = "instantiatedRandomCard5a";
				
			}else if(card.name == "Card5b(Clone)"){
				
				card.name = "instantiatedRandomCard5b";
				
			}else if(card.name == "Card5c(Clone)"){
				
				card.name = "instantiatedRandomCard5c";
				
			}else if(card.name == "Card6(Clone)"){
				
				card.name = "instantiatedRandomCard6";
				
			}else if(card.name == "Card6a(Clone)"){
				
				card.name = "instantiatedRandomCard6a";
				
			}else if(card.name == "Card6b(Clone)"){
				
				card.name = "instantiatedRandomCard6b";
				
			}else if(card.name == "Card6c(Clone)"){
				
				card.name = "instantiatedRandomCard6c";
				
			}else if(card.name == "Card7(Clone)"){
				
				card.name = "instantiatedRandomCard7";
				
			}else if(card.name == "Card7a(Clone)"){
				
				card.name = "instantiatedRandomCard7a";
				
			}else if(card.name == "Card7b(Clone)"){
				
				card.name = "instantiatedRandomCard7b";
				
			}else if(card.name == "Card7c(Clone)"){
				
				card.name = "instantiatedRandomCard7c";
				
			}else if(card.name == "Card8(Clone)"){
				
				card.name = "instantiatedRandomCard8";
				
			}else if(card.name == "Card8a(Clone)"){
				
				card.name = "instantiatedRandomCard8a";
				
			}else if(card.name == "Card8b(Clone)"){
				
				card.name = "instantiatedRandomCard8b";
				
			}else if(card.name == "Card8c(Clone)"){
				
				card.name = "instantiatedRandomCard8c";
				
			}else if(card.name == "Card9(Clone)"){
				
				card.name = "instantiatedRandomCard9";
				
			}else if(card.name == "Card9a(Clone)"){
				
				card.name = "instantiatedRandomCard9a";
				
			}else if(card.name == "Card9b(Clone)"){
				
				card.name = "instantiatedRandomCard9b";
				
			}else if(card.name == "Card9c(Clone)"){
				
				card.name = "instantiatedRandomCard9c";
				
			}else if(card.name == "Card10(Clone)"){
				
				card.name = "instantiatedAICard10";
				
			}else if(card.name == "Card10a(Clone)"){
				
				card.name = "instantiatedRandomCard10a";
				
			}else if(card.name == "Card10b(Clone)"){
				
				card.name = "instantiatedRandomCard10b";
				
			}else if(card.name == "Card10c(Clone)"){
				
				card.name = "instantiatedRandomCard10c";
				
			}else if(card.name == "Card11(Clone)"){
				
				card.name = "instantiatedRandomCard11";
				
			}else if(card.name == "Card11a(Clone)"){
				
				card.name = "instantiatedRandomCard11a";
				
			}else if(card.name == "Card11b(Clone)"){
				
				card.name = "instantiatedRandomCard11b";
				
			}else if(card.name == "Card11c(Clone)"){
				
				card.name = "instantiatedRandomCard11c";
				
			}else if(card.name == "Card12(Clone)"){
				
				card.name = "instantiatedRandomCard12";
				
			}else if(card.name == "Card12a(Clone)"){
				
				card.name = "instantiatedRandomCard12a";
				
			}else if(card.name == "Card12b(Clone)"){
				
				card.name = "instantiatedRandomCard12b";
				
			}else if(card.name == "Card12c(Clone)"){
				
				card.name = "instantiatedRandomCard12c";
				
			}else if(card.name == "Card13(Clone)"){
				
				card.name = "instantiatedRandomCard13";
				
			}else if(card.name == "Card13a(Clone)"){
				
				card.name = "instantiatedRandomCard13a";
				
			}else if(card.name == "Card13b(Clone)"){
				
				card.name = "instantiatedRandomCard13b";
				
			}else if(card.name == "Card13c(Clone)"){
				
				card.name = "instantiatedRandomCard13c";
				
			}else if(card.name == "Card14(Clone)"){
				
				card.name = "instantiatedRandomCard14";
				
			}else if(card.name == "Card14a(Clone)"){
				
				card.name = "instantiatedRandomCard14a";
				
			}else if(card.name == "Card14b(Clone)"){
				
				card.name = "instantiatedRandomCard14b";
				
			}else if(card.name == "Card14c(Clone)"){
				
				card.name = "instantiatedRandomCard14c";
				
			}else if(card.name == "Card15(Clone)"){
				
				card.name = "instantiatedRandomCard15";
				
			}else if(card.name == "Card15a(Clone)"){
				
				card.name = "instantiatedRandomCard15a";
				
			}else if(card.name == "Card15b(Clone)"){
				
				card.name = "instantiatedRandomCard15b";
				
			}else if(card.name == "Card15c(Clone)"){
				
				card.name = "instantiatedRandomCard15c";
				
			}else if(card.name == "Card16(Clone)"){
				
				card.name = "instantiatedRandomCard16";
				
			}else if(card.name == "Card16a(Clone)"){
				
				card.name = "instantiatedRandomCard16a";
				
			}else if(card.name == "Card16b(Clone)"){
				
				card.name = "instantiatedRandomCard16b";
				
			}else if(card.name == "Card16c(Clone)"){
				
				card.name = "instantiatedRandomCard16c";
				
			}else if(card.name == "Card17(Clone)"){
				
				card.name = "instantiatedRandomCard17";
				
			}else if(card.name == "Card17a(Clone)"){
				
				card.name = "instantiatedRandomCard17a";
				
			}else if(card.name == "Card17b(Clone)"){
				
				card.name = "instantiatedRandomCard17b";
				
			}else if(card.name == "Card17c(Clone)"){
				
				card.name = "instantiatedRandomCard17c";
				
			}else if(card.name == "Card18(Clone)"){
				
				card.name = "instantiatedRandomCard18";
				
			}else if(card.name == "Card18a(Clone)"){
				
				card.name = "instantiatedRandomCard18a";
				
			}else if(card.name == "Card18b(Clone)"){
				
				card.name = "instantiatedRandomCard18b";
				
			}else if(card.name == "Card18c(Clone)"){
				
				card.name = "instantiatedRandomCard18c";
				
			}else if(card.name == "Card19(Clone)"){
				
				card.name = "instantiatedRandomCard19";
				
			}else if(card.name == "Card19a(Clone)"){
				
				card.name = "instantiatedRandomCard19a";
				
			}else if(card.name == "Card19b(Clone)"){
				
				card.name = "instantiatedRandomCard19b";
				
			}else if(card.name == "Card19c(Clone)"){
				
				card.name = "instantiatedRandomCard19c";
				
			}else if(card.name == "Card20(Clone)"){
				
				card.name = "instantiatedRandomCard20";
				
			}else if(card.name == "Card20a(Clone)"){
				
				card.name = "instantiatedRandomCard20a";
				
			}else if(card.name == "Card20b(Clone)"){
				
				card.name = "instantiatedRandomCard20b";
				
			}else if(card.name == "Card20c(Clone)"){
				
				card.name = "instantiatedRandomCard20c";
				
			}else if(card.name == "Card21(Clone)"){
				
				card.name = "instantiatedRandomCard21";
				
			}else if(card.name == "Card21a(Clone)"){
				
				card.name = "instantiatedRandomCard21a";
				
			}else if(card.name == "Card21b(Clone)"){
				
				card.name = "instantiatedRandomCard21b";
				
			}else if(card.name == "Card21c(Clone)"){
				
				card.name = "instantiatedRandomCard21c";
				
			}else if(card.name == "Card22(Clone)"){
				
				card.name = "instantiatedRandomCard22";
				
			}else if(card.name == "Card22a(Clone)"){
				
				card.name = "instantiatedRandomCard22a";
				
			}else if(card.name == "Card22b(Clone)"){
				
				card.name = "instantiatedRandomCard22b";
				
			}else if(card.name == "Card22c(Clone)"){
				
				card.name = "instantiatedRandomCard22c";
				
			}else if(card.name == "Card23(Clone)"){
				
				card.name = "instantiatedRandomCard23";
				
			}else if(card.name == "Card23a(Clone)"){
				
				card.name = "instantiatedRandomCard23a";
				
			}else if(card.name == "Card23b(Clone)"){
				
				card.name = "instantiatedRandomCard23b";
				
			}else if(card.name == "Card23c(Clone)"){
				
				card.name = "instantiatedRandomCard23c";
				
			}else if(card.name == "Card24(Clone)"){
				
				card.name = "instantiatedRandomCard24";
				
			}else if(card.name == "Card24a(Clone)"){
				
				card.name = "instantiatedRandomCard24a";
				
			}else if(card.name == "Card24b(Clone)"){
				
				card.name = "instantiatedRandomCard24b";
				
			}else if(card.name == "Card24c(Clone)"){
				
				card.name = "instantiatedRandomCard24c";
				
			}else if(card.name == "Card25(Clone)"){
				
				card.name = "instantiatedRandomCard25";
				
			}else if(card.name == "Card25a(Clone)"){
				
				card.name = "instantiatedRandomCard25a";
				
			}else if(card.name == "Card25b(Clone)"){
				
				card.name = "instantiatedRandomCard25b";
				
			}else if(card.name == "Card25c(Clone)"){
				
				card.name = "instantiatedRandomCard25c";
				
			}else if(card.name == "Card26(Clone)"){
				
				card.name = "instantiatedRandomCard26";
				
			}else if(card.name == "Card26a(Clone)"){
				
				card.name = "instantiatedRandomCard26a";
				
			}else if(card.name == "Card26b(Clone)"){
				
				card.name = "instantiatedRandomCard26b";
				
			}else if(card.name == "Card26c(Clone)"){
				
				card.name = "instantiatedRandomCard26c";
				
			}else if(card.name == "Card27(Clone)"){
				
				card.name = "instantiatedRandomCard27";
				
			}else if(card.name == "Card27a(Clone)"){
				
				card.name = "instantiatedRandomCard27a";
				
			}else if(card.name == "Card27b(Clone)"){
				
				card.name = "instantiatedRandomCard27b";
				
			}else if(card.name == "Card27c(Clone)"){
				
				card.name = "instantiatedRandomCard27c";
				
			}else if(card.name == "Card28(Clone)"){
				
				card.name = "instantiatedRandomCard28";
				
			}else if(card.name == "Card28a(Clone)"){
				
				card.name = "instantiatedRandomCard28a";
				
			}else if(card.name == "Card28b(Clone)"){
				
				card.name = "instantiatedRandomCard28b";
				
			}else if(card.name == "Card28c(Clone)"){
				
				card.name = "instantiatedRandomCard28c";
				
			}else if(card.name == "Card29(Clone)"){
				
				card.name = "instantiatedRandomCard29";
				
			}else if(card.name == "Card29a(Clone)"){
				
				card.name = "instantiatedRandomCard29a";
				
			}else if(card.name == "Card29b(Clone)"){
				
				card.name = "instantiatedRandomCard29b";
				
			}else if(card.name == "Card29c(Clone)"){
				
				card.name = "instantiatedRandomCard29c";
				
			}else if(card.name == "Card30(Clone)"){
				
				card.name = "instantiatedRandomCard30";
				
			}else if(card.name == "Card30a(Clone)"){
				
				card.name = "instantiatedRandomCard30a";
				
			}else if(card.name == "Card30b(Clone)"){
				
				card.name = "instantiatedRandomCard30b";
				
			}else if(card.name == "Card30c(Clone)"){
				
				card.name = "instantiatedRandomCard30c";
				
			}else if(card.name == "Card31(Clone)"){
				
				card.name = "instantiatedRandomCard31";
				
			}else if(card.name == "Card31a(Clone)"){
				
				card.name = "instantiatedRandomCard31a";
				
			}else if(card.name == "Card31b(Clone)"){
				
				card.name = "instantiatedRandomCard31b";
				
			}else if(card.name == "Card31c(Clone)"){
				
				card.name = "instantiatedRandomCard31c";
				
			}else if(card.name == "Card32(Clone)"){
				
				card.name = "instantiatedRandomCard32";
				
			}else if(card.name == "Card32a(Clone)"){
				
				card.name = "instantiatedRandomCard32a";
				
			}else if(card.name == "Card32b(Clone)"){
				
				card.name = "instantiatedRandomCard32b";
				
			}else if(card.name == "Card32c(Clone)"){
				
				card.name = "instantiatedRandomCard32c";
				
			}else if(card.name == "Card33(Clone)"){
				
				card.name = "instantiatedRandomCard33";
				
			}else if(card.name == "Card33a(Clone)"){
				
				card.name = "instantiatedRandomCard33a";
				
			}else if(card.name == "Card33b(Clone)"){
				
				card.name = "instantiatedRandomCard33b";
				
			}else if(card.name == "Card33c(Clone)"){
				
				card.name = "instantiatedRandomCard33c";
				
			}else if(card.name == "Card34(Clone)"){
				
				card.name = "instantiatedRandomCard34";
				
			}else if(card.name == "Card34a(Clone)"){
				
				card.name = "instantiatedRandomCard34a";
				
			}else if(card.name == "Card34b(Clone)"){
				
				card.name = "instantiatedRandomCard34b";
				
			}else if(card.name == "Card34c(Clone)"){
				
				card.name = "instantiatedRandomCard34c";
				
			}else if(card.name == "Card35(Clone)"){
				
				card.name = "instantiatedRandomCard35";
				
			}else if(card.name == "Card35a(Clone)"){
				
				card.name = "instantiatedRandomCard35a";
				
			}else if(card.name == "Card35b(Clone)"){
				
				card.name = "instantiatedRandomCard35b";
				
			}else if(card.name == "Card35c(Clone)"){
				
				card.name = "instantiatedRandomCard35c";
				
			}else if(card.name == "Card36(Clone)"){
				
				card.name = "instantiatedRandomCard36";
				
			}else if(card.name == "Card36a(Clone)"){
				
				card.name = "instantiatedRandomCard36a";
				
			}else if(card.name == "Card36b(Clone)"){
				
				card.name = "instantiatedRandomCard36b";
				
			}else if(card.name == "Card36c(Clone)"){
				
				card.name = "instantiatedRandomCard36c";
				
			}else if(card.name == "Card37(Clone)"){
				
				card.name = "instantiatedRandomCard37";
				
			}else if(card.name == "Card37a(Clone)"){
				
				card.name = "instantiatedRandomCard37a";
				
			}else if(card.name == "Card37b(Clone)"){
				
				card.name = "instantiatedRandomCard37b";
				
			}else if(card.name == "Card37c(Clone)"){
				
				card.name = "instantiatedRandomCard37c";
				
			}else if(card.name == "Card38(Clone)"){
				
				card.name = "instantiatedRandomCard38";
				
			}else if(card.name == "Card38a(Clone)"){
				
				card.name = "instantiatedRandomCard38a";
				
			}else if(card.name == "Card38b(Clone)"){
				
				card.name = "instantiatedRandomCard38b";
				
			}else if(card.name == "Card38c(Clone)"){
				
				card.name = "instantiatedRandomCard38c";
				
			}else if(card.name == "Card39(Clone)"){
				
				card.name = "instantiatedRandomCard39";
				
			}else if(card.name == "Card39a(Clone)"){
				
				card.name = "instantiatedRandomCard39a";
				
			}else if(card.name == "Card39b(Clone)"){
				
				card.name = "instantiatedRandomCard39b";
				
			}else if(card.name == "Card39c(Clone)"){
				
				card.name = "instantiatedRandomCard39c";
				
			}else if(card.name == "Card40(Clone)"){
				
				card.name = "instantiatedRandomCard40";
				
			}else if(card.name == "Card40a(Clone)"){
				
				card.name = "instantiatedRandomCard40a";
				
			}else if(card.name == "Card40b(Clone)"){
				
				card.name = "instantiatedRandomCard40b";
				
			}else if(card.name == "Card40c(Clone)"){
				
				card.name = "instantiatedRandomCard40c";
				
			}else if(card.name == "Card41(Clone)"){
				
				card.name = "instantiatedRandomCard41";
				
			}else if(card.name == "Card41a(Clone)"){
				
				card.name = "instantiatedRandomCard41a";
				
			}else if(card.name == "Card41b(Clone)"){
				
				card.name = "instantiatedRandomCard41b";
				
			}else if(card.name == "Card41c(Clone)"){
				
				card.name = "instantiatedRandomCard41c";
				
			}else if(card.name == "Card42(Clone)"){
				
				card.name = "instantiatedRandomCard42";
				
			}else if(card.name == "Card42a(Clone)"){
				
				card.name = "instantiatedRandomCard42a";
				
			}else if(card.name == "Card42b(Clone)"){
				
				card.name = "instantiatedRandomCard42b";
				
			}else if(card.name == "Card42c(Clone)"){
				
				card.name = "instantiatedRandomCard42c";
				
			}else if(card.name == "Card43(Clone)"){
				
				card.name = "instantiatedRandomCard43";
				
			}else if(card.name == "Card43a(Clone)"){
				
				card.name = "instantiatedRandomCard43a";
				
			}else if(card.name == "Card43b(Clone)"){
				
				card.name = "instantiatedRandomCard43b";
				
			}else if(card.name == "Card43c(Clone)"){
				
				card.name = "instantiatedRandomCard43c";
				
			}else if(card.name == "Card44(Clone)"){
				
				card.name = "instantiatedRandomCard44";
				
			}else if(card.name == "Card44a(Clone)"){
				
				card.name = "instantiatedRandomCard44a";
				
			}else if(card.name == "Card44b(Clone)"){
				
				card.name = "instantiatedRandomCard44b";
				
			}else if(card.name == "Card44c(Clone)"){
				
				card.name = "instantiatedRandomCard44c";
				
			}else if(card.name == "Card45(Clone)"){
				
				card.name = "instantiatedRandomCard45";
				
			}else if(card.name == "Card45a(Clone)"){
				
				card.name = "instantiatedRandomCard45a";
				
			}else if(card.name == "Card45b(Clone)"){
				
				card.name = "instantiatedRandomCard45b";
				
			}else if(card.name == "Card45c(Clone)"){
				
				card.name = "instantiatedRandomCard45c";
				
			}else if(card.name == "Card46(Clone)"){
				
				card.name = "instantiatedRandomCard46";
				
			}else if(card.name == "Card46a(Clone)"){
				
				card.name = "instantiatedRandomCard46a";
				
			}else if(card.name == "Card46b(Clone)"){
				
				card.name = "instantiatedRandomCard46b";
				
			}else if(card.name == "Card46c(Clone)"){
				
				card.name = "instantiatedRandomCard46c";
				
			}else if(card.name == "Card47(Clone)"){
				
				card.name = "instantiatedRandomCard47";
				
			}else if(card.name == "Card47a(Clone)"){
				
				card.name = "instantiatedRandomCard47a";
				
			}else if(card.name == "Card47b(Clone)"){
				
				card.name = "instantiatedRandomCard47b";
				
			}else if(card.name == "Card47c(Clone)"){
				
				card.name = "instantiatedRandomCard47c";
				
			}else if(card.name == "Card48(Clone)"){
				
				card.name = "instantiatedRandomCard48";
				
			}else if(card.name == "Card48a(Clone)"){
				
				card.name = "instantiatedRandomCard48a";
				
			}else if(card.name == "Card48b(Clone)"){
				
				card.name = "instantiatedRandomCard48b";
				
			}else if(card.name == "Card48c(Clone)"){
				
				card.name = "instantiatedRandomCard48c";
				
			}else if(card.name == "Card49(Clone)"){
				
				card.name = "instantiatedRandomCard49";
				
			}else if(card.name == "Card49a(Clone)"){
				
				card.name = "instantiatedRandomCard49a";
				
			}else if(card.name == "Card49b(Clone)"){
				
				card.name = "instantiatedRandomCard49b";
				
			}else if(card.name == "Card49c(Clone)"){
				
				card.name = "instantiatedRandomCard49c";
				
			}else if(card.name == "Card50(Clone)"){
				
				card.name = "instantiatedRandomCard50";
				
			}else if(card.name == "Card50a(Clone)"){
				
				card.name = "instantiatedRandomCard50a";
				
			}else if(card.name == "Card50b(Clone)"){
				
				card.name = "instantiatedRandomCard50b";
				
			}else if(card.name == "Card50c(Clone)"){
				
				card.name = "instantiatedRandomCard50c";
				
			}else if(card.name == "Card51(Clone)"){
				
				card.name = "instantiatedRandomCard51";
				
			}else if(card.name == "Card51a(Clone)"){
				
				card.name = "instantiatedRandomCard51a";
				
			}else if(card.name == "Card51b(Clone)"){
				
				card.name = "instantiatedRandomCard51b";
				
			}else if(card.name == "Card51c(Clone)"){
				
				card.name = "instantiatedRandomCard51c";
				
			}else if(card.name == "Card52(Clone)"){
				
				card.name = "instantiatedRandomCard52";
				
			}else if(card.name == "Card52a(Clone)"){
				
				card.name = "instantiatedRandomCard52a";
				
			}else if(card.name == "Card52b(Clone)"){
				
				card.name = "instantiatedRandomCard52b";
				
			}else if(card.name == "Card52c(Clone)"){
				
				card.name = "instantiatedRandomCard52c";
				
			}else if(card.name == "Card53(Clone)"){
				
				card.name = "instantiatedRandomCard53";
				
			}else if(card.name == "Card53a(Clone)"){
				
				card.name = "instantiatedRandomCard53a";
				
			}else if(card.name == "Card53b(Clone)"){
				
				card.name = "instantiatedRandomCard53b";
				
			}else if(card.name == "Card53c(Clone)"){
				
				card.name = "instantiatedRandomCard53c";
				
			}else if(card.name == "Card54(Clone)"){
				
				card.name = "instantiatedRandomCard54";
				
			}else if(card.name == "Card54a(Clone)"){
				
				card.name = "instantiatedRandomCard54a";
				
			}else if(card.name == "Card54b(Clone)"){
				
				card.name = "instantiatedRandomCard54b";
				
			}else if(card.name == "Card54c(Clone)"){
				
				card.name = "instantiatedRandomCard54c";
				
			}else if(card.name == "Card55(Clone)"){
				
				card.name = "instantiatedRandomCard55";
				
			}else if(card.name == "Card55a(Clone)"){
				
				card.name = "instantiatedRandomCard55a";
				
			}else if(card.name == "Card55b(Clone)"){
				
				card.name = "instantiatedRandomCard55b";
				
			}else if(card.name == "Card55c(Clone)"){
				
				card.name = "instantiatedRandomCard55c";
				
			}else if(card.name == "Card56(Clone)"){
				
				card.name = "instantiatedRandomCard56";
				
			}else if(card.name == "Card56a(Clone)"){
				
				card.name = "instantiatedRandomCard56a";
				
			}else if(card.name == "Card56b(Clone)"){
				
				card.name = "instantiatedRandomCard56b";
				
			}else if(card.name == "Card56c(Clone)"){
				
				card.name = "instantiatedRandomCard56c";
				
			}else if(card.name == "Card57(Clone)"){
				
				card.name = "instantiatedRandomCard57";
				
			}else if(card.name == "Card57a(Clone)"){
				
				card.name = "instantiatedRandomCard57a";
				
			}else if(card.name == "Card57b(Clone)"){
				
				card.name = "instantiatedRandomCard57b";
				
			}else if(card.name == "Card57c(Clone)"){
				
				card.name = "instantiatedRandomCard57c";
				
			}else if(card.name == "Card58(Clone)"){
				
				card.name = "instantiatedRandomCard58";
				
			}else if(card.name == "Card58a(Clone)"){
				
				card.name = "instantiatedRandomCard58a";
				
			}else if(card.name == "Card58b(Clone)"){
				
				card.name = "instantiatedRandomCard58b";
				
			}else if(card.name == "Card58c(Clone)"){
				
				card.name = "instantiatedRandomCard58c";
				
			}else if(card.name == "Card59(Clone)"){
				
				card.name = "instantiatedRandomCard59";
				
			}else if(card.name == "Card59a(Clone)"){
				
				card.name = "instantiatedRandomCard59a";
				
			}else if(card.name == "Card59b(Clone)"){
				
				card.name = "instantiatedRandomCard59b";
				
			}else if(card.name == "Card59c(Clone)"){
				
				card.name = "instantiatedRandomCard59c";
				
			}else if(card.name == "Card60(Clone)"){
				
				card.name = "instantiatedRandomCard60";
				
			}else if(card.name == "Card60a(Clone)"){
				
				card.name = "instantiatedRandomCard60a";
				
			}else if(card.name == "Card60b(Clone)"){
				
				card.name = "instantiatedRandomCard60b";
				
			}else if(card.name == "Card60c(Clone)"){
				
				card.name = "instantiatedRandomCard60c";
			}
			
			instances10++;
			
			}
		
		
		
		
	}
}

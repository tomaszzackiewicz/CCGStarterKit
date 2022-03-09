using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AISpawnBattlefieldCard : MonoBehaviour {
	
	private int NumberOfCards;
	private int instances;
	//public GameObject[] cardsInSlot;
	public GameObject[] cardsInDeck240 = new GameObject[240];
	public List<GameObject> spawnPoints = new List<GameObject>();
	
	private GameObject aiRow1CardSlot1;
	private GameObject aiRow1CardSlot2;
	private GameObject aiRow1CardSlot3;
	private GameObject aiRow1CardSlot4;
	private GameObject aiRow1CardSlot5;
	private GameObject aiRow1CardSlot6;
	private GameObject aiRow1CardSlot7;
	private GameObject aiRow1CardSlot8;
	private GameObject aiRow1CardSlot9;
	private GameObject aiRow1CardSlot10;
	private GameObject aiRow1CardSlot11;
	private GameObject aiRow1CardSlot12;
	private GameObject aiRow1CardSlot13;
	private GameObject aiRow1CardSlot14;
	private GameObject aiRow1CardSlot15;
	private GameObject aiRow1CardSlot16;
	private GameObject aiRow1CardSlot17;
	private GameObject aiRow1CardSlot18;
	private GameObject aiRow1CardSlot19;
	private GameObject aiRow1CardSlot20;
	
	private GameObject aiRow2CardSlot1;
	private GameObject aiRow2CardSlot2;
	private GameObject aiRow2CardSlot3;
	private GameObject aiRow2CardSlot4;
	private GameObject aiRow2CardSlot5;
	private GameObject aiRow2CardSlot6;
	private GameObject aiRow2CardSlot7;
	private GameObject aiRow2CardSlot8;
	private GameObject aiRow2CardSlot9;
	private GameObject aiRow2CardSlot10;
	private GameObject aiRow2CardSlot11;
	private GameObject aiRow2CardSlot12;
	private GameObject aiRow2CardSlot13;
	private GameObject aiRow2CardSlot14;
	private GameObject aiRow2CardSlot15;
	private GameObject aiRow2CardSlot16;
	private GameObject aiRow2CardSlot17;
	private GameObject aiRow2CardSlot18;
	private GameObject aiRow2CardSlot19;
	private GameObject aiRow2CardSlot20;
	
	private GameObject aiRow3CardSlot1;
	private GameObject aiRow3CardSlot2;
	private GameObject aiRow3CardSlot3;
	private GameObject aiRow3CardSlot4;
	private GameObject aiRow3CardSlot5;
	private GameObject aiRow3CardSlot6;
	private GameObject aiRow3CardSlot7;
	private GameObject aiRow3CardSlot8;
	private GameObject aiRow3CardSlot9;
	private GameObject aiRow3CardSlot10;
	private GameObject aiRow3CardSlot11;
	private GameObject aiRow3CardSlot12;
	private GameObject aiRow3CardSlot13;
	private GameObject aiRow3CardSlot14;
	private GameObject aiRow3CardSlot15;
	private GameObject aiRow3CardSlot16;
	private GameObject aiRow3CardSlot17;
	private GameObject aiRow3CardSlot18;
	private GameObject aiRow3CardSlot19;
	private GameObject aiRow3CardSlot20;
	
	private GameObject spawnPointCard1;
	private GameObject spawnPointCard1a;
	private GameObject spawnPointCard1b;
	private GameObject spawnPointCard1c;
	
	private GameObject spawnPointCard2;
	private GameObject spawnPointCard2a;
	private GameObject spawnPointCard2b;
	private GameObject spawnPointCard2c;
	
	private GameObject spawnPointCard3;
	private GameObject spawnPointCard3a;
	private GameObject spawnPointCard3b;
	private GameObject spawnPointCard3c;
	
	private GameObject spawnPointCard4;
	private GameObject spawnPointCard4a;
	private GameObject spawnPointCard4b;
	private GameObject spawnPointCard4c;
	
	private GameObject spawnPointCard5;
	private GameObject spawnPointCard5a;
	private GameObject spawnPointCard5b;
	private GameObject spawnPointCard5c;
	
	private GameObject spawnPointCard6;
	private GameObject spawnPointCard6a;
	private GameObject spawnPointCard6b;
	private GameObject spawnPointCard6c;
	
	private GameObject spawnPointCard7;
	private GameObject spawnPointCard7a;
	private GameObject spawnPointCard7b;
	private GameObject spawnPointCard7c;
	
	private GameObject spawnPointCard8;
	private GameObject spawnPointCard8a;
	private GameObject spawnPointCard8b;
	private GameObject spawnPointCard8c;
	
	private GameObject spawnPointCard9;
	private GameObject spawnPointCard9a;
	private GameObject spawnPointCard9b;
	private GameObject spawnPointCard9c;
	
	private GameObject spawnPointCard10;
	private GameObject spawnPointCard10a;
	private GameObject spawnPointCard10b;
	private GameObject spawnPointCard10c;
	
	private GameObject spawnPointCard11;
	private GameObject spawnPointCard11a;
	private GameObject spawnPointCard11b;
	private GameObject spawnPointCard11c;
	
	private GameObject spawnPointCard12;
	private GameObject spawnPointCard12a;
	private GameObject spawnPointCard12b;
	private GameObject spawnPointCard12c;
	
	private GameObject spawnPointCard13;
	private GameObject spawnPointCard13a;
	private GameObject spawnPointCard13b;
	private GameObject spawnPointCard13c;
	
	private GameObject spawnPointCard14;
	private GameObject spawnPointCard14a;
	private GameObject spawnPointCard14b;
	private GameObject spawnPointCard14c;
	
	private GameObject spawnPointCard15;
	private GameObject spawnPointCard15a;
	private GameObject spawnPointCard15b;
	private GameObject spawnPointCard15c;
	
	private GameObject spawnPointCard16;
	private GameObject spawnPointCard16a;
	private GameObject spawnPointCard16b;
	private GameObject spawnPointCard16c;
	
	private GameObject spawnPointCard17;
	private GameObject spawnPointCard17a;
	private GameObject spawnPointCard17b;
	private GameObject spawnPointCard17c;
	
	private GameObject spawnPointCard18;
	private GameObject spawnPointCard18a;
	private GameObject spawnPointCard18b;
	private GameObject spawnPointCard18c;
	
	private GameObject spawnPointCard19;
	private GameObject spawnPointCard19a;
	private GameObject spawnPointCard19b;
	private GameObject spawnPointCard19c;
	
	private GameObject spawnPointCard20;
	private GameObject spawnPointCard20a;
	private GameObject spawnPointCard20b;
	private GameObject spawnPointCard20c;
	
	private GameObject spawnPointCard21;
	private GameObject spawnPointCard21a;
	private GameObject spawnPointCard21b;
	private GameObject spawnPointCard21c;
	
	private GameObject spawnPointCard22;
	private GameObject spawnPointCard22a;
	private GameObject spawnPointCard22b;
	private GameObject spawnPointCard22c;
	
	private GameObject spawnPointCard23;
	private GameObject spawnPointCard23a;
	private GameObject spawnPointCard23b;
	private GameObject spawnPointCard23c;
	
	private GameObject spawnPointCard24;
	private GameObject spawnPointCard24a;
	private GameObject spawnPointCard24b;
	private GameObject spawnPointCard24c;
	
	private GameObject spawnPointCard25;
	private GameObject spawnPointCard25a;
	private GameObject spawnPointCard25b;
	private GameObject spawnPointCard25c;
	
	private GameObject spawnPointCard26;
	private GameObject spawnPointCard26a;
	private GameObject spawnPointCard26b;
	private GameObject spawnPointCard26c;
	
	private GameObject spawnPointCard27;
	private GameObject spawnPointCard27a;
	private GameObject spawnPointCard27b;
	private GameObject spawnPointCard27c;
	
	private GameObject spawnPointCard28;
	private GameObject spawnPointCard28a;
	private GameObject spawnPointCard28b;
	private GameObject spawnPointCard28c;
	
	private GameObject spawnPointCard29;
	private GameObject spawnPointCard29a;
	private GameObject spawnPointCard29b;
	private GameObject spawnPointCard29c;
	
	private GameObject spawnPointCard30;
	private GameObject spawnPointCard30a;
	private GameObject spawnPointCard30b;
	private GameObject spawnPointCard30c;
	
	private GameObject spawnPointCard31;
	private GameObject spawnPointCard31a;
	private GameObject spawnPointCard31b;
	private GameObject spawnPointCard31c;
	
	private GameObject spawnPointCard32;
	private GameObject spawnPointCard32a;
	private GameObject spawnPointCard32b;
	private GameObject spawnPointCard32c;
	
	private GameObject spawnPointCard33;
	private GameObject spawnPointCard33a;
	private GameObject spawnPointCard33b;
	private GameObject spawnPointCard33c;
	
	private GameObject spawnPointCard34;
	private GameObject spawnPointCard34a;
	private GameObject spawnPointCard34b;
	private GameObject spawnPointCard34c;
	
	private GameObject spawnPointCard35;
	private GameObject spawnPointCard35a;
	private GameObject spawnPointCard35b;
	private GameObject spawnPointCard35c;
	
	private GameObject spawnPointCard36;
	private GameObject spawnPointCard36a;
	private GameObject spawnPointCard36b;
	private GameObject spawnPointCard36c;
	
	private GameObject spawnPointCard37;
	private GameObject spawnPointCard37a;
	private GameObject spawnPointCard37b;
	private GameObject spawnPointCard37c;
	
	private GameObject spawnPointCard38;
	private GameObject spawnPointCard38a;
	private GameObject spawnPointCard38b;
	private GameObject spawnPointCard38c;
	
	private GameObject spawnPointCard39;
	private GameObject spawnPointCard39a;
	private GameObject spawnPointCard39b;
	private GameObject spawnPointCard39c;
	
	private GameObject spawnPointCard40;
	private GameObject spawnPointCard40a;
	private GameObject spawnPointCard40b;
	private GameObject spawnPointCard40c;
	
	private GameObject spawnPointCard41;
	private GameObject spawnPointCard41a;
	private GameObject spawnPointCard41b;
	private GameObject spawnPointCard41c;
	
	private GameObject spawnPointCard42;
	private GameObject spawnPointCard42a;
	private GameObject spawnPointCard42b;
	private GameObject spawnPointCard42c;
	
	private GameObject spawnPointCard43;
	private GameObject spawnPointCard43a;
	private GameObject spawnPointCard43b;
	private GameObject spawnPointCard43c;
	
	private GameObject spawnPointCard44;
	private GameObject spawnPointCard44a;
	private GameObject spawnPointCard44b;
	private GameObject spawnPointCard44c;
	
	private GameObject spawnPointCard45;
	private GameObject spawnPointCard45a;
	private GameObject spawnPointCard45b;
	private GameObject spawnPointCard45c;
	
	private GameObject spawnPointCard46;
	private GameObject spawnPointCard46a;
	private GameObject spawnPointCard46b;
	private GameObject spawnPointCard46c;
	
	private GameObject spawnPointCard47;
	private GameObject spawnPointCard47a;
	private GameObject spawnPointCard47b;
	private GameObject spawnPointCard47c;
	
	private GameObject spawnPointCard48;
	private GameObject spawnPointCard48a;
	private GameObject spawnPointCard48b;
	private GameObject spawnPointCard48c;
	
	private GameObject spawnPointCard49;
	private GameObject spawnPointCard49a;
	private GameObject spawnPointCard49b;
	private GameObject spawnPointCard49c;
	
	private GameObject spawnPointCard50;
	private GameObject spawnPointCard50a;
	private GameObject spawnPointCard50b;
	private GameObject spawnPointCard50c;
	
	private GameObject spawnPointCard51;
	private GameObject spawnPointCard51a;
	private GameObject spawnPointCard51b;
	private GameObject spawnPointCard51c;
	
	private GameObject spawnPointCard52;
	private GameObject spawnPointCard52a;
	private GameObject spawnPointCard52b;
	private GameObject spawnPointCard52c;
	
	private GameObject spawnPointCard53;
	private GameObject spawnPointCard53a;
	private GameObject spawnPointCard53b;
	private GameObject spawnPointCard53c;
	
	private GameObject spawnPointCard54;
	private GameObject spawnPointCard54a;
	private GameObject spawnPointCard54b;
	private GameObject spawnPointCard54c;
	
	private GameObject spawnPointCard55;
	private GameObject spawnPointCard55a;
	private GameObject spawnPointCard55b;
	private GameObject spawnPointCard55c;
	
	private GameObject spawnPointCard56;
	private GameObject spawnPointCard56a;
	private GameObject spawnPointCard56b;
	private GameObject spawnPointCard56c;
	
	private GameObject spawnPointCard57;
	private GameObject spawnPointCard57a;
	private GameObject spawnPointCard57b;
	private GameObject spawnPointCard57c;
	
	private GameObject spawnPointCard58;
	private GameObject spawnPointCard58a;
	private GameObject spawnPointCard58b;
	private GameObject spawnPointCard58c;
	
	private GameObject spawnPointCard59;
	private GameObject spawnPointCard59a;
	private GameObject spawnPointCard59b;
	private GameObject spawnPointCard59c;
	
	private GameObject spawnPointCard60;
	private GameObject spawnPointCard60a;
	private GameObject spawnPointCard60b;
	private GameObject spawnPointCard60c;
	
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
		
		aiRow1CardSlot1 = GameObject.Find("AIRow1CardSlot1");
		aiRow1CardSlot2 = GameObject.Find("AIRow1CardSlot2");
		aiRow1CardSlot3 = GameObject.Find("AIRow1CardSlot3");
		aiRow1CardSlot4 = GameObject.Find("AIRow1CardSlot4");
		aiRow1CardSlot5 = GameObject.Find("AIRow1CardSlot5");
		aiRow1CardSlot6 = GameObject.Find("AIRow1CardSlot6");
		aiRow1CardSlot7 = GameObject.Find("AIRow1CardSlot7");
		aiRow1CardSlot8 = GameObject.Find("AIRow1CardSlot8");
		aiRow1CardSlot9 = GameObject.Find("AIRow1CardSlot9");
		aiRow1CardSlot10 = GameObject.Find("AIRow1CardSlot10");
		aiRow1CardSlot11 = GameObject.Find("AIRow1CardSlot11");
		aiRow1CardSlot12 = GameObject.Find("AIRow1CardSlot12");
		aiRow1CardSlot13 = GameObject.Find("AIRow1CardSlot13");
		aiRow1CardSlot14 = GameObject.Find("AIRow1CardSlot14");
		aiRow1CardSlot15 = GameObject.Find("AIRow1CardSlot15");
		aiRow1CardSlot16 = GameObject.Find("AIRow1CardSlot16");
		aiRow1CardSlot17 = GameObject.Find("AIRow1CardSlot17");
		aiRow1CardSlot18 = GameObject.Find("AIRow1CardSlot18");
		aiRow1CardSlot19 = GameObject.Find("AIRow1CardSlot19");
		aiRow1CardSlot20 = GameObject.Find("AIRow1CardSlot20");
		
		aiRow2CardSlot1 = GameObject.Find("AIRow2CardSlot1");
		aiRow2CardSlot2 = GameObject.Find("AIRow2CardSlot2");
		aiRow2CardSlot3 = GameObject.Find("AIRow2CardSlot3");
		aiRow2CardSlot4 = GameObject.Find("AIRow2CardSlot4");
		aiRow2CardSlot5 = GameObject.Find("AIRow2CardSlot5");
		aiRow2CardSlot6 = GameObject.Find("AIRow2CardSlot6");
		aiRow2CardSlot7 = GameObject.Find("AIRow2CardSlot7");
		aiRow2CardSlot8 = GameObject.Find("AIRow2CardSlot8");
		aiRow2CardSlot9 = GameObject.Find("AIRow2CardSlot9");
		aiRow2CardSlot10 = GameObject.Find("AIRow2CardSlot10");
		aiRow2CardSlot11 = GameObject.Find("AIRow2CardSlot11");
		aiRow2CardSlot12 = GameObject.Find("AIRow2CardSlot12");
		aiRow2CardSlot13 = GameObject.Find("AIRow2CardSlot13");
		aiRow2CardSlot14 = GameObject.Find("AIRow2CardSlot14");
		aiRow2CardSlot15 = GameObject.Find("AIRow2CardSlot15");
		aiRow2CardSlot16 = GameObject.Find("AIRow2CardSlot16");
		aiRow2CardSlot17 = GameObject.Find("AIRow2CardSlot17");
		aiRow2CardSlot18 = GameObject.Find("AIRow2CardSlot18");
		aiRow2CardSlot19 = GameObject.Find("AIRow2CardSlot19");
		aiRow2CardSlot20 = GameObject.Find("AIRow2CardSlot20");
		
		aiRow3CardSlot1 = GameObject.Find("AIRow3CardSlot1");
		aiRow3CardSlot2 = GameObject.Find("AIRow3CardSlot2");
		aiRow3CardSlot3 = GameObject.Find("AIRow3CardSlot3");
		aiRow3CardSlot4 = GameObject.Find("AIRow3CardSlot4");
		aiRow3CardSlot5 = GameObject.Find("AIRow3CardSlot5");
		aiRow3CardSlot6 = GameObject.Find("AIRow3CardSlot6");
		aiRow3CardSlot7 = GameObject.Find("AIRow3CardSlot7");
		aiRow3CardSlot8 = GameObject.Find("AIRow3CardSlot8");
		aiRow3CardSlot9 = GameObject.Find("AIRow3CardSlot9");
		aiRow3CardSlot10 = GameObject.Find("AIRow3CardSlot10");
		aiRow3CardSlot11 = GameObject.Find("AIRow3CardSlot11");
		aiRow3CardSlot12 = GameObject.Find("AIRow3CardSlot12");
		aiRow3CardSlot13 = GameObject.Find("AIRow3CardSlot13");
		aiRow3CardSlot14 = GameObject.Find("AIRow3CardSlot14");
		aiRow3CardSlot15 = GameObject.Find("AIRow3CardSlot15");
		aiRow3CardSlot16 = GameObject.Find("AIRow3CardSlot16");
		aiRow3CardSlot17 = GameObject.Find("AIRow3CardSlot17");
		aiRow3CardSlot18 = GameObject.Find("AIRow3CardSlot18");
		aiRow3CardSlot19 = GameObject.Find("AIRow3CardSlot19");
		aiRow3CardSlot20 = GameObject.Find("AIRow3CardSlot20");
		
	}

	// Use this for initialization
	void Start () {
		
		spawnPoints.Insert(0,aiRow1CardSlot1);
		spawnPoints.Insert(1,aiRow1CardSlot2);
		spawnPoints.Insert(2,aiRow1CardSlot3);
		spawnPoints.Insert(3,aiRow1CardSlot4);
		spawnPoints.Insert(4,aiRow1CardSlot5);
		spawnPoints.Insert(5,aiRow1CardSlot6);
		spawnPoints.Insert(6,aiRow1CardSlot7);
		spawnPoints.Insert(7,aiRow1CardSlot8);
		spawnPoints.Insert(8,aiRow1CardSlot9);
		spawnPoints.Insert(9,aiRow1CardSlot10);
		spawnPoints.Insert(10,aiRow1CardSlot11);
		spawnPoints.Insert(11,aiRow1CardSlot12);
		spawnPoints.Insert(12,aiRow1CardSlot13);
		spawnPoints.Insert(13,aiRow1CardSlot14);
		spawnPoints.Insert(14,aiRow1CardSlot15);
		spawnPoints.Insert(15,aiRow1CardSlot16);
		spawnPoints.Insert(16,aiRow1CardSlot17);
		spawnPoints.Insert(17,aiRow1CardSlot18);
		spawnPoints.Insert(18,aiRow1CardSlot19);
		spawnPoints.Insert(19,aiRow1CardSlot20);
		
		spawnPoints.Insert(20,aiRow2CardSlot1);
		spawnPoints.Insert(21,aiRow2CardSlot2);
		spawnPoints.Insert(22,aiRow2CardSlot3);
		spawnPoints.Insert(23,aiRow2CardSlot4);
		spawnPoints.Insert(24,aiRow2CardSlot5);
		spawnPoints.Insert(25,aiRow2CardSlot6);
		spawnPoints.Insert(26,aiRow2CardSlot7);
		spawnPoints.Insert(27,aiRow2CardSlot8);
		spawnPoints.Insert(28,aiRow2CardSlot9);
		spawnPoints.Insert(29,aiRow2CardSlot10);
		spawnPoints.Insert(30,aiRow2CardSlot11);
		spawnPoints.Insert(31,aiRow2CardSlot12);
		spawnPoints.Insert(32,aiRow2CardSlot13);
		spawnPoints.Insert(33,aiRow2CardSlot14);
		spawnPoints.Insert(34,aiRow2CardSlot15);
		spawnPoints.Insert(35,aiRow2CardSlot16);
		spawnPoints.Insert(36,aiRow2CardSlot17);
		spawnPoints.Insert(37,aiRow2CardSlot18);
		spawnPoints.Insert(38,aiRow2CardSlot19);
		spawnPoints.Insert(39,aiRow2CardSlot20);
		
		spawnPoints.Insert(40,aiRow3CardSlot1);
		spawnPoints.Insert(41,aiRow3CardSlot2);
		spawnPoints.Insert(42,aiRow3CardSlot3);
		spawnPoints.Insert(43,aiRow3CardSlot4);
		spawnPoints.Insert(44,aiRow3CardSlot5);
		spawnPoints.Insert(45,aiRow3CardSlot6);
		spawnPoints.Insert(46,aiRow3CardSlot7);
		spawnPoints.Insert(47,aiRow3CardSlot8);
		spawnPoints.Insert(48,aiRow3CardSlot9);
		spawnPoints.Insert(49,aiRow3CardSlot10);
		spawnPoints.Insert(50,aiRow3CardSlot11);
		spawnPoints.Insert(51,aiRow3CardSlot12);
		spawnPoints.Insert(52,aiRow3CardSlot13);
		spawnPoints.Insert(53,aiRow3CardSlot14);
		spawnPoints.Insert(54,aiRow3CardSlot15);
		spawnPoints.Insert(55,aiRow3CardSlot16);
		spawnPoints.Insert(56,aiRow3CardSlot17);
		spawnPoints.Insert(57,aiRow3CardSlot18);
		spawnPoints.Insert(58,aiRow3CardSlot19);
		spawnPoints.Insert(59,aiRow3CardSlot20);
		
	
	}
	
	// Update is called once per frame
	void Update () {
		
		
		
	
	}
	
	/* void GetAISpawnPoints(){
		
		aiRow1CardSlot1 = GameObject.Find("AIRow1CardSlot1");
		aiRow1CardSlot2 = GameObject.Find("AIRow1CardSlot2");
		aiRow1CardSlot3 = GameObject.Find("AIRow1CardSlot3");
		aiRow1CardSlot4 = GameObject.Find("AIRow1CardSlot4");
		aiRow1CardSlot5 = GameObject.Find("AIRow1CardSlot5");
		aiRow1CardSlot6 = GameObject.Find("AIRow1CardSlot6");
		aiRow1CardSlot7 = GameObject.Find("AIRow1CardSlot7");
		aiRow1CardSlot8 = GameObject.Find("AIRow1CardSlot8");
		aiRow1CardSlot9 = GameObject.Find("AIRow1CardSlot9");
		aiRow1CardSlot10 = GameObject.Find("AIRow1CardSlot10");
		aiRow1CardSlot11 = GameObject.Find("AIRow1CardSlot11");
		aiRow1CardSlot12 = GameObject.Find("AIRow1CardSlot12");
		aiRow1CardSlot13 = GameObject.Find("AIRow1CardSlot13");
		aiRow1CardSlot14 = GameObject.Find("AIRow1CardSlot14");
		aiRow1CardSlot15 = GameObject.Find("AIRow1CardSlot15");
		aiRow1CardSlot16 = GameObject.Find("AIRow1CardSlot16");
		aiRow1CardSlot17 = GameObject.Find("AIRow1CardSlot17");
		aiRow1CardSlot18 = GameObject.Find("AIRow1CardSlot18");
		aiRow1CardSlot19 = GameObject.Find("AIRow1CardSlot19");
		aiRow1CardSlot20 = GameObject.Find("AIRow1CardSlot20");
		
		
	} */
	
	void OnTriggerEnter(Collider col){
		
		spawnPoints.RemoveAll(item => item == null);
		
		if(col.gameObject.name == "instantiatedAIDeckCard1"){
			
			spawnPointCard1 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[0], spawnPointCard1.transform.position, spawnPointCard1.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard1";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());
			
			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard1a"){
			
			spawnPointCard1a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[1], spawnPointCard1a.transform.position, spawnPointCard1a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard1a";

			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());
			
			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard1b"){
			
			spawnPointCard1b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[2], spawnPointCard1b.transform.position, spawnPointCard1b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard1b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());
			
			
			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard1c"){
			
			spawnPointCard1c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[3], spawnPointCard1c.transform.position, spawnPointCard1c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard1c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());
			
			col.gameObject.transform.parent = null;
			
		}
			
		else if	(col.gameObject.name == "instantiatedAIDeckCard2"){
			
			spawnPointCard2 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[4], spawnPointCard2.transform.position, spawnPointCard2.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard2";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());
			
			col.gameObject.transform.parent = null;
			
		}
		
		else if	(col.gameObject.name == "instantiatedAIDeckCard2a"){
			
			spawnPointCard2a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[5], spawnPointCard2a.transform.position, spawnPointCard2a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard2a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());
			
			col.gameObject.transform.parent = null;
			
		}
		
		else if	(col.gameObject.name == "instantiatedAIDeckCard2b"){
			
			spawnPointCard2b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[6], spawnPointCard2b.transform.position, spawnPointCard2b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard2b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());
			
			col.gameObject.transform.parent = null;
			
		}
		
		else if	(col.gameObject.name == "instantiatedAIDeckCard2c"){
			
			spawnPointCard2c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[7], spawnPointCard2c.transform.position, spawnPointCard2c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard2c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());
			
			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard3"){
			
			spawnPointCard3 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[8], spawnPointCard3.transform.position, spawnPointCard3.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard3";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());
			
			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard3a"){
			
			spawnPointCard3a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[9], spawnPointCard3a.transform.position, spawnPointCard3a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard3a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());
			
			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard3b"){
			
			spawnPointCard3b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[10], spawnPointCard3b.transform.position, spawnPointCard3b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard3b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());
				
			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard3c"){
			
			spawnPointCard3c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[11], spawnPointCard3c.transform.position, spawnPointCard3c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard3c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());
			
			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard4"){
			
			spawnPointCard4 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[12], spawnPointCard4.transform.position, spawnPointCard4.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard4";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());
			
			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard4a"){
			
			spawnPointCard4a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[13], spawnPointCard4a.transform.position, spawnPointCard4a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard4a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());
			
			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard4b"){
			
			spawnPointCard4b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[14], spawnPointCard4b.transform.position, spawnPointCard4b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard4b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());
			
			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard4c"){
			
			spawnPointCard4c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[15], spawnPointCard4c.transform.position, spawnPointCard4c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard4c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());
			
			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard5"){
			
			spawnPointCard5 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[16], spawnPointCard5.transform.position, spawnPointCard5.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard5";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());
			
			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard5a"){
			
			spawnPointCard5a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[17], spawnPointCard5a.transform.position, spawnPointCard5a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard5a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());
			
			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard5b"){
			
			spawnPointCard5b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[18], spawnPointCard5b.transform.position, spawnPointCard5b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard5b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());
			
			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard5c"){
			
			spawnPointCard5c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[19], spawnPointCard5c.transform.position, spawnPointCard5c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard5c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());
			
			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard6"){
			
			spawnPointCard6 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[20], spawnPointCard6.transform.position, spawnPointCard6.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard6";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard6a"){
			
			spawnPointCard6a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[21], spawnPointCard6a.transform.position, spawnPointCard6a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard6a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard6b"){
			
			spawnPointCard6b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[22], spawnPointCard6b.transform.position, spawnPointCard6b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard6b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());
			
			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard6c"){
			
			spawnPointCard6c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[23], spawnPointCard6c.transform.position, spawnPointCard6c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard6c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard7"){
			
			spawnPointCard7 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[24], spawnPointCard7.transform.position, spawnPointCard7.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard7";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard7a"){
			
			spawnPointCard7a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[25], spawnPointCard7a.transform.position, spawnPointCard7a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard7a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard7b"){
			
			spawnPointCard7b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[26], spawnPointCard7b.transform.position, spawnPointCard7b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard7b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard7c"){
			
			spawnPointCard7c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[27], spawnPointCard7c.transform.position, spawnPointCard7c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard7c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());
			
			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard8"){
			
			spawnPointCard8 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[28], spawnPointCard8.transform.position, spawnPointCard8.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard8";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard8a"){
			
			spawnPointCard8a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[29], spawnPointCard8a.transform.position, spawnPointCard8a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard8a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard8b"){
			
			spawnPointCard8b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[30], spawnPointCard8b.transform.position, spawnPointCard8b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard8b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard8c"){
			
			spawnPointCard8c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[31], spawnPointCard8c.transform.position, spawnPointCard8c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard8c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard9"){
			
			spawnPointCard9 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[32], spawnPointCard9.transform.position, spawnPointCard9.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard9";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard9a"){
			
			spawnPointCard9a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[33], spawnPointCard9a.transform.position, spawnPointCard9a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard9a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard9b"){
			
			spawnPointCard9b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[34], spawnPointCard9b.transform.position, spawnPointCard9b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard9b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard9c"){
			
			spawnPointCard9c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[35], spawnPointCard9c.transform.position, spawnPointCard9c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard9c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());
			
			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard10"){
			
			spawnPointCard10 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[36], spawnPointCard10.transform.position, spawnPointCard10.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard10";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard10a"){
			
			spawnPointCard10a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[37], spawnPointCard10a.transform.position, spawnPointCard10a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard10a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard10b"){
			
			spawnPointCard10b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[38], spawnPointCard10b.transform.position, spawnPointCard10b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard10b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard10c"){
			
			spawnPointCard10c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[39], spawnPointCard10c.transform.position, spawnPointCard10c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard10c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard11"){
			
			spawnPointCard11 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[40], spawnPointCard11.transform.position, spawnPointCard11.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard11";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard11a"){
			
			spawnPointCard11a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[41], spawnPointCard11a.transform.position, spawnPointCard11a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard11a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard11b"){
			
			spawnPointCard11b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[42], spawnPointCard11b.transform.position, spawnPointCard11b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard11b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard11c"){
			
			spawnPointCard11c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[43], spawnPointCard11c.transform.position, spawnPointCard11c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard11c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());
	
			col.gameObject.transform.parent = null;
			
		}
			
		else if	(col.gameObject.name == "instantiatedAIDeckCard12"){
			
			spawnPointCard12 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[44], spawnPointCard12.transform.position, spawnPointCard12.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard12";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if	(col.gameObject.name == "instantiatedAIDeckCard12a"){
			
			spawnPointCard12a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[45], spawnPointCard12a.transform.position, spawnPointCard12a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard12a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if	(col.gameObject.name == "instantiatedAIDeckCard12b"){
			
			spawnPointCard12b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[46], spawnPointCard12b.transform.position, spawnPointCard12b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard12b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if	(col.gameObject.name == "instantiatedAIDeckCard12c"){
			
			spawnPointCard12c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[47], spawnPointCard12c.transform.position, spawnPointCard12c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard12c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());
	
			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard13"){
			
			spawnPointCard13 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[48], spawnPointCard13.transform.position, spawnPointCard13.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard13";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard13a"){
			
			spawnPointCard13a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[49], spawnPointCard13a.transform.position, spawnPointCard13a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard13a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard13b"){
			
			spawnPointCard13b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[50], spawnPointCard13b.transform.position, spawnPointCard13b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard13b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard13c"){
			
			spawnPointCard13c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[51], spawnPointCard13c.transform.position, spawnPointCard13c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard13c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard14"){
			
			spawnPointCard14 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[52], spawnPointCard14.transform.position, spawnPointCard14.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard14";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard14a"){
			
			spawnPointCard14a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[53], spawnPointCard14a.transform.position, spawnPointCard14a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard14a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard14b"){
			
			spawnPointCard14b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[54], spawnPointCard14b.transform.position, spawnPointCard14b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard14b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard14c"){
			
			spawnPointCard14c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[55], spawnPointCard14c.transform.position, spawnPointCard14c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard14c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard15"){
			
			spawnPointCard15 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[56], spawnPointCard15.transform.position, spawnPointCard15.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard15";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard15a"){
			
			spawnPointCard15a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[57], spawnPointCard15a.transform.position, spawnPointCard15a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard15a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard15b"){
			
			spawnPointCard15b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[58], spawnPointCard15b.transform.position, spawnPointCard15b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard15b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard15c"){
			
			spawnPointCard15c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[59], spawnPointCard15c.transform.position, spawnPointCard15c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard15c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard16"){
			
			spawnPointCard16 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[60], spawnPointCard16.transform.position, spawnPointCard16.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard16";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard16a"){
			
			spawnPointCard16a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[61], spawnPointCard16a.transform.position, spawnPointCard16a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard16a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAICard16b"){
			
			spawnPointCard16b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[62], spawnPointCard16b.transform.position, spawnPointCard16b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard16b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard16c"){
			
			spawnPointCard16c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[63], spawnPointCard16c.transform.position, spawnPointCard16c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard16c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard17"){
			
			spawnPointCard17 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[64], spawnPointCard17.transform.position, spawnPointCard17.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard17";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard17a"){
			
			spawnPointCard17a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[65], spawnPointCard17a.transform.position, spawnPointCard17a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard17a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard17b"){
			
			spawnPointCard17b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[66], spawnPointCard17b.transform.position, spawnPointCard17b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard17b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard17c"){
			
			spawnPointCard17c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[67], spawnPointCard17c.transform.position, spawnPointCard17c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard17c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());
	
			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard18"){
			
			spawnPointCard18 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[68], spawnPointCard18.transform.position, spawnPointCard18.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard18";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard18a"){
			
			spawnPointCard18a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[69], spawnPointCard18a.transform.position, spawnPointCard18a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard18a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard18b"){
			
			spawnPointCard18b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[70], spawnPointCard18b.transform.position, spawnPointCard18b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard18b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard18c"){
			
			spawnPointCard18c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[71], spawnPointCard18c.transform.position, spawnPointCard18c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard18c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard19"){
			
			spawnPointCard19 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[72], spawnPointCard19.transform.position, spawnPointCard19.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard19";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard19a"){
			
			spawnPointCard19a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[73], spawnPointCard19a.transform.position, spawnPointCard19a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard19a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard19b"){
			
			spawnPointCard19b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[74], spawnPointCard19b.transform.position, spawnPointCard19b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard19b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard19c"){
			
			spawnPointCard19c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[75], spawnPointCard19c.transform.position, spawnPointCard19c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard19c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard20"){
			
			spawnPointCard20 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[76], spawnPointCard20.transform.position, spawnPointCard20.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard20";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard20a"){
			
			spawnPointCard20a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[77], spawnPointCard20a.transform.position, spawnPointCard20a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard20a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard20b"){
			
			spawnPointCard20b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[78], spawnPointCard20b.transform.position, spawnPointCard20b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard20b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard20c"){
			
			spawnPointCard20c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[79], spawnPointCard20c.transform.position, spawnPointCard20c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard20c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard21"){
			
			spawnPointCard21 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[80], spawnPointCard21.transform.position, spawnPointCard21.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard21";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());
	
			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard21a"){
			
			spawnPointCard21a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[81], spawnPointCard21a.transform.position, spawnPointCard21a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard21a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard21b"){
			
			spawnPointCard21b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[82], spawnPointCard21b.transform.position, spawnPointCard21b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard21b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard21c"){
			
			spawnPointCard21c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[83], spawnPointCard21c.transform.position, spawnPointCard21c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard21c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
			
		else if	(col.gameObject.name == "instantiatedAIDeckCard22"){
			
			spawnPointCard22 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[84], spawnPointCard22.transform.position, spawnPointCard22.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard22";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if	(col.gameObject.name == "instantiatedAIDeckCard22a"){
			
			spawnPointCard22a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[85], spawnPointCard22a.transform.position, spawnPointCard22a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard22a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if	(col.gameObject.name == "instantiatedAIDeckCard22b"){
			
			spawnPointCard22b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[86], spawnPointCard22b.transform.position, spawnPointCard22b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard22b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if	(col.gameObject.name == "instantiatedAIDeckCard22c"){
			
			spawnPointCard22c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[87], spawnPointCard22c.transform.position, spawnPointCard22c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard22c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard23"){
			
			spawnPointCard23 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[88], spawnPointCard23.transform.position, spawnPointCard23.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard23";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard23a"){
			
			spawnPointCard23a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[89], spawnPointCard23a.transform.position, spawnPointCard23a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard23a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard23b"){
			
			spawnPointCard23b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[90], spawnPointCard23b.transform.position, spawnPointCard23b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard23b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard23c"){
			
			spawnPointCard23c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[91], spawnPointCard23c.transform.position, spawnPointCard23c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard23c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard24"){
			
			spawnPointCard24 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[92], spawnPointCard24.transform.position, spawnPointCard24.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard24";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard24a"){
			
			spawnPointCard24a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[93], spawnPointCard24a.transform.position, spawnPointCard24a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard24a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard24b"){
			
			spawnPointCard24b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[94], spawnPointCard24b.transform.position, spawnPointCard24b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard24b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard24c"){
			
			spawnPointCard24c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[95], spawnPointCard24c.transform.position, spawnPointCard24c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard24c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard25"){
			
			spawnPointCard25 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[96], spawnPointCard25.transform.position, spawnPointCard25.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard25";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard25a"){
			
			spawnPointCard25a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[97], spawnPointCard25a.transform.position, spawnPointCard25a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard25a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard25b"){
			
			spawnPointCard25b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[98], spawnPointCard25b.transform.position, spawnPointCard25b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard25b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard25c"){
			
			spawnPointCard25c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[99], spawnPointCard25c.transform.position, spawnPointCard25c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard25c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard26"){
			
			spawnPointCard26 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[100], spawnPointCard26.transform.position, spawnPointCard26.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard26";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard26a"){
			
			spawnPointCard26a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[101], spawnPointCard26a.transform.position, spawnPointCard26a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard26a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard26b"){
			
			spawnPointCard26b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[102], spawnPointCard26b.transform.position, spawnPointCard26b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard26b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard26c"){
			
			spawnPointCard26c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[103], spawnPointCard26c.transform.position, spawnPointCard26c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard26c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard27"){
			
			spawnPointCard27 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[104], spawnPointCard27.transform.position, spawnPointCard27.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard27";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard27a"){
			
			spawnPointCard27a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[105], spawnPointCard27a.transform.position, spawnPointCard27a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard27a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard27b"){
			
			spawnPointCard27b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[106], spawnPointCard27b.transform.position, spawnPointCard27b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard27b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard27c"){
			
			spawnPointCard27c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[107], spawnPointCard27c.transform.position, spawnPointCard27c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard27c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard28"){
			
			spawnPointCard28 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[108], spawnPointCard28.transform.position, spawnPointCard28.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard28";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard28a"){
			
			spawnPointCard28a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[109], spawnPointCard28a.transform.position, spawnPointCard28a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard28a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard28b"){
			
			spawnPointCard28b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[110], spawnPointCard28b.transform.position, spawnPointCard28b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard28b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard28c"){
			
			spawnPointCard28c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[111], spawnPointCard28c.transform.position, spawnPointCard28c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard28c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());
	
			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard29"){
			
			spawnPointCard29 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[112], spawnPointCard29.transform.position, spawnPointCard29.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard29";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard29a"){
			
			spawnPointCard29a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[113], spawnPointCard29a.transform.position, spawnPointCard29a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard29a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard29b"){
			
			spawnPointCard29b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[114], spawnPointCard29b.transform.position, spawnPointCard29b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard29b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard29c"){
			
			spawnPointCard29c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[115], spawnPointCard29c.transform.position, spawnPointCard29c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard29c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard30"){
			
			spawnPointCard30 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[116], spawnPointCard30.transform.position, spawnPointCard30.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard30";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard30a"){
			
			spawnPointCard30a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[117], spawnPointCard30a.transform.position, spawnPointCard30a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard30a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());
	
			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard30b"){
			
			spawnPointCard30b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[118], spawnPointCard30b.transform.position, spawnPointCard30b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard30b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard30c"){
			
			spawnPointCard30c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[119], spawnPointCard30c.transform.position, spawnPointCard30c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard30c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());
	
			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard31"){
			
			spawnPointCard31 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[120], spawnPointCard31.transform.position, spawnPointCard31.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard31";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard31a"){
			
			spawnPointCard31a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[121], spawnPointCard31a.transform.position, spawnPointCard31a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard31a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard31b"){
			
			spawnPointCard31b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[122], spawnPointCard31b.transform.position, spawnPointCard31b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard31b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard31c"){
			
			spawnPointCard31c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[123], spawnPointCard31c.transform.position, spawnPointCard31c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard31c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
			
		else if	(col.gameObject.name == "instantiatedAIDeckCard32"){
			
			spawnPointCard32 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[124], spawnPointCard32.transform.position, spawnPointCard32.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard32";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if	(col.gameObject.name == "instantiatedAIDeckCard32a"){
			
			spawnPointCard32a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[125], spawnPointCard32a.transform.position, spawnPointCard32a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard32a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if	(col.gameObject.name == "instantiatedAIDeckCard32b"){
			
			spawnPointCard32b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[126], spawnPointCard32b.transform.position, spawnPointCard32b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard32b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if	(col.gameObject.name == "instantiatedAIDeckCard32c"){
			
			spawnPointCard32c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[127], spawnPointCard32c.transform.position, spawnPointCard32c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard32c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard33"){
			
			spawnPointCard33 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[128], spawnPointCard33.transform.position, spawnPointCard33.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard33";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard33a"){
			
			spawnPointCard33a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[129], spawnPointCard33a.transform.position, spawnPointCard33a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard33a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard33b"){
			
			spawnPointCard33b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[130], spawnPointCard33b.transform.position, spawnPointCard33b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard33b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard33c"){
			
			spawnPointCard33c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[131], spawnPointCard33c.transform.position, spawnPointCard33c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard33c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard34"){
			
			spawnPointCard34 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[132], spawnPointCard34.transform.position, spawnPointCard34.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard34";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard34a"){
			
			spawnPointCard34a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[133], spawnPointCard34a.transform.position, spawnPointCard34a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard34a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());
	
			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard34b"){
			
			spawnPointCard34b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[134], spawnPointCard34b.transform.position, spawnPointCard34b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard34b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard34c"){
			
			spawnPointCard34c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[135], spawnPointCard34c.transform.position, spawnPointCard34c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard34c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard35"){
			
			spawnPointCard35 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[136], spawnPointCard35.transform.position, spawnPointCard35.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard35";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard35a"){
			
			spawnPointCard35a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[137], spawnPointCard35a.transform.position, spawnPointCard35a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard35a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard35b"){
			
			spawnPointCard35b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[138], spawnPointCard35b.transform.position, spawnPointCard35b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard35b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard35c"){
			
			spawnPointCard35c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[139], spawnPointCard35c.transform.position, spawnPointCard35c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard35c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard36"){
			
			spawnPointCard36 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[140], spawnPointCard36.transform.position, spawnPointCard36.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard36";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard36a"){
			
			spawnPointCard36a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[141], spawnPointCard36a.transform.position, spawnPointCard36a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard36a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard36b"){
			
			spawnPointCard36b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[142], spawnPointCard36b.transform.position, spawnPointCard36b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard36b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard36c"){
			
			spawnPointCard36c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[143], spawnPointCard36c.transform.position, spawnPointCard36c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard36c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard37"){
			
			spawnPointCard37 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[144], spawnPointCard37.transform.position, spawnPointCard37.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard37";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard37a"){
			
			spawnPointCard37a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[145], spawnPointCard37a.transform.position, spawnPointCard37a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard37a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard37b"){
			
			spawnPointCard37b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[146], spawnPointCard37b.transform.position, spawnPointCard37b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard37b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard37c"){
			
			spawnPointCard37c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[147], spawnPointCard37c.transform.position, spawnPointCard37c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard37c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard38"){
			
			spawnPointCard38 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[148], spawnPointCard38.transform.position, spawnPointCard38.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard38";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard38a"){
			
			spawnPointCard38a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[149], spawnPointCard38a.transform.position, spawnPointCard38a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard38a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard38b"){
			
			spawnPointCard38b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[150], spawnPointCard38b.transform.position, spawnPointCard38b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard38b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard38c"){
			
			spawnPointCard38c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[151], spawnPointCard38c.transform.position, spawnPointCard38c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard38c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard39"){
			
			spawnPointCard39 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[152], spawnPointCard39.transform.position, spawnPointCard39.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard39";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard39a"){
			
			spawnPointCard39a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[153], spawnPointCard39a.transform.position, spawnPointCard39a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard39a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard39b"){
			
			spawnPointCard39b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[154], spawnPointCard39b.transform.position, spawnPointCard39b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard39b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard39c"){
			
			spawnPointCard39c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[155], spawnPointCard39c.transform.position, spawnPointCard39c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard39c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard40"){
			
			spawnPointCard40 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[156], spawnPointCard40.transform.position, spawnPointCard40.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard40";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard40a"){
			
			spawnPointCard40a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[157], spawnPointCard40a.transform.position, spawnPointCard40a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard40a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard40b"){
			
			spawnPointCard40b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[158], spawnPointCard40b.transform.position, spawnPointCard40b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard40b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard40c"){
			
			spawnPointCard40c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[159], spawnPointCard40c.transform.position, spawnPointCard40c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard40c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard41"){
			
			spawnPointCard41 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[160], spawnPointCard41.transform.position, spawnPointCard41.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard41";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard41a"){
			
			spawnPointCard41a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[161], spawnPointCard41a.transform.position, spawnPointCard41a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard41a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard41b"){
			
			spawnPointCard41b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[162], spawnPointCard41b.transform.position, spawnPointCard41b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard41b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard41c"){
			
			spawnPointCard41c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[163], spawnPointCard41c.transform.position, spawnPointCard41c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard41c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
			
		else if	(col.gameObject.name == "instantiatedAIDeckCard42"){
			
			spawnPointCard42 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[164], spawnPointCard42.transform.position, spawnPointCard42.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard42";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if	(col.gameObject.name == "instantiatedAIDeckCard42a"){
			
			spawnPointCard42a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[165], spawnPointCard42a.transform.position, spawnPointCard42a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard42a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if	(col.gameObject.name == "instantiatedAIDeckCard42b"){
			
			spawnPointCard42b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[166], spawnPointCard42b.transform.position, spawnPointCard42b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard42b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if	(col.gameObject.name == "instantiatedAIDeckCard42c"){
			
			spawnPointCard42c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[167], spawnPointCard42c.transform.position, spawnPointCard42c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard42c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard43"){
			
			spawnPointCard43 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[168], spawnPointCard43.transform.position, spawnPointCard43.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard43";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard43a"){
			
			spawnPointCard43a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[169], spawnPointCard43a.transform.position, spawnPointCard43a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard43a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard43b"){
			
			spawnPointCard43b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[170], spawnPointCard43b.transform.position, spawnPointCard43b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard43b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard43c"){
			
			spawnPointCard43c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[171], spawnPointCard43c.transform.position, spawnPointCard43c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard43c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard44"){
			
			spawnPointCard44 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[172], spawnPointCard44.transform.position, spawnPointCard44.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard44";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard44a"){
			
			spawnPointCard44a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[173], spawnPointCard44a.transform.position, spawnPointCard44a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard44a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard44b"){
			
			spawnPointCard44b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[174], spawnPointCard44b.transform.position, spawnPointCard44b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard44b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard44c"){
			
			spawnPointCard44c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[175], spawnPointCard44c.transform.position, spawnPointCard44c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard44c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard45"){
			
			spawnPointCard45 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[176], spawnPointCard45.transform.position, spawnPointCard45.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard45";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard45a"){
			
			spawnPointCard45a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[177], spawnPointCard45a.transform.position, spawnPointCard45a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard45a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard45b"){
			
			spawnPointCard45b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[178], spawnPointCard45b.transform.position, spawnPointCard45b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard45b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard45c"){
			
			spawnPointCard45c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[179], spawnPointCard45c.transform.position, spawnPointCard45c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard45c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());
	
			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard46"){
			
			spawnPointCard46 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[180], spawnPointCard46.transform.position, spawnPointCard46.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard46";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard46a"){
			
			spawnPointCard46a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[181], spawnPointCard46a.transform.position, spawnPointCard46a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard46a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard46b"){
			
			spawnPointCard46b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[182], spawnPointCard46b.transform.position, spawnPointCard46b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard46b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard46c"){
			
			spawnPointCard46c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[183], spawnPointCard46c.transform.position, spawnPointCard46c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard46c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard47"){
			
			spawnPointCard47 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[184], spawnPointCard47.transform.position, spawnPointCard47.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard47";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard47a"){
			
			spawnPointCard47a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[185], spawnPointCard47a.transform.position, spawnPointCard47a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard47a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard47b"){
			
			spawnPointCard47b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[186], spawnPointCard47b.transform.position, spawnPointCard47b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard47b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard47c"){
			
			spawnPointCard47c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[187], spawnPointCard47c.transform.position, spawnPointCard47c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard47c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard48"){
			
			spawnPointCard48 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[188], spawnPointCard48.transform.position, spawnPointCard48.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard48";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard48a"){
			
			spawnPointCard48a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[189], spawnPointCard48a.transform.position, spawnPointCard48a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard48a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard48b"){
			
			spawnPointCard48b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[190], spawnPointCard48b.transform.position, spawnPointCard48b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard48b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard48c"){
			
			spawnPointCard48c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[191], spawnPointCard48c.transform.position, spawnPointCard48c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard48c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard49"){
			
			spawnPointCard49 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[192], spawnPointCard49.transform.position, spawnPointCard49.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard49";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard49a"){
			
			spawnPointCard49a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[193], spawnPointCard49a.transform.position, spawnPointCard49a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard49a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard49b"){
			
			spawnPointCard49b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[194], spawnPointCard49b.transform.position, spawnPointCard49b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard49b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard49c"){
			
			spawnPointCard49c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[195], spawnPointCard49c.transform.position, spawnPointCard49c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard49c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard50"){
			
			spawnPointCard50 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[196], spawnPointCard50.transform.position, spawnPointCard50.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard50";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard50a"){
			
			spawnPointCard50a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[197], spawnPointCard50a.transform.position, spawnPointCard50a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard50a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard50b"){
			
			spawnPointCard50b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[198], spawnPointCard50b.transform.position, spawnPointCard50b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard50b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard50c"){
			
			spawnPointCard50c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[199], spawnPointCard50c.transform.position, spawnPointCard50c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard50c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard51"){
			
			spawnPointCard51 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[200], spawnPointCard51.transform.position, spawnPointCard51.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard51";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard51a"){
			
			spawnPointCard51a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[201], spawnPointCard51a.transform.position, spawnPointCard51a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard51a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard51b"){
			
			spawnPointCard51b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[202], spawnPointCard51b.transform.position, spawnPointCard51b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard51b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard51c"){
			
			spawnPointCard51c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[203], spawnPointCard51c.transform.position, spawnPointCard51c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard51c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
			
		else if	(col.gameObject.name == "instantiatedAIDeckCard52"){
			
			spawnPointCard52 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[204], spawnPointCard52.transform.position, spawnPointCard52.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard52";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if	(col.gameObject.name == "instantiatedAIDeckCard52a"){
			
			spawnPointCard52a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[205], spawnPointCard52a.transform.position, spawnPointCard52a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard52a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if	(col.gameObject.name == "instantiatedAIDeckCard52b"){
			
			spawnPointCard52b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[206], spawnPointCard52b.transform.position, spawnPointCard52b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard52b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if	(col.gameObject.name == "instantiatedAIDeckCard52c"){
			
			spawnPointCard52c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[207], spawnPointCard52c.transform.position, spawnPointCard52c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard52c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard53"){
			
			spawnPointCard53 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[208], spawnPointCard53.transform.position, spawnPointCard53.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard53";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard53a"){
			
			spawnPointCard53a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[209], spawnPointCard53a.transform.position, spawnPointCard53a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard53a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard53b"){
			
			spawnPointCard53b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[210], spawnPointCard53b.transform.position, spawnPointCard53b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard53b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard53c"){
			
			spawnPointCard53c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[211], spawnPointCard53c.transform.position, spawnPointCard53c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard53c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard54"){
			
			spawnPointCard54 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[212], spawnPointCard54.transform.position, spawnPointCard54.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard54";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard54a"){
			
			spawnPointCard54a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[213], spawnPointCard54a.transform.position, spawnPointCard54a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard54a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard54b"){
			
			spawnPointCard54b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[214], spawnPointCard54b.transform.position, spawnPointCard54b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard54b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard54c"){
			
			spawnPointCard54c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[215], spawnPointCard54c.transform.position, spawnPointCard54c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard54c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard55"){
			
			spawnPointCard55 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[216], spawnPointCard55.transform.position, spawnPointCard55.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard55";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard55a"){
			
			spawnPointCard55a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[217], spawnPointCard55a.transform.position, spawnPointCard55a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard55a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard55b"){
			
			spawnPointCard55b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[218], spawnPointCard55b.transform.position, spawnPointCard55b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard55b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard55c"){
			
			spawnPointCard55c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[219], spawnPointCard55c.transform.position, spawnPointCard55c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard55c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard56"){
			
			spawnPointCard56 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[220], spawnPointCard56.transform.position, spawnPointCard56.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard56";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard56a"){
			
			spawnPointCard56a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[221], spawnPointCard56a.transform.position, spawnPointCard56a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard56a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard56b"){
			
			spawnPointCard56b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[222], spawnPointCard56b.transform.position, spawnPointCard56b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard56b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard56c"){
			
			spawnPointCard56c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[223], spawnPointCard56c.transform.position, spawnPointCard56c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard56c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard57"){
			
			spawnPointCard57 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[224], spawnPointCard57.transform.position, spawnPointCard57.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard57";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard57a"){
			
			spawnPointCard57a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[225], spawnPointCard57a.transform.position, spawnPointCard57a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard57a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard57b"){
			
			spawnPointCard57b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[226], spawnPointCard57b.transform.position, spawnPointCard57b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard57b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard57c"){
			
			spawnPointCard57c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[227], spawnPointCard57c.transform.position, spawnPointCard57c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard57c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard58"){
			
			spawnPointCard58 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[228], spawnPointCard58.transform.position, spawnPointCard58.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard58";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard58a"){
			
			spawnPointCard58a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[229], spawnPointCard58a.transform.position, spawnPointCard58a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard58a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard58b"){
			
			spawnPointCard58b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[230], spawnPointCard58b.transform.position, spawnPointCard58b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard58b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard58c"){
			
			spawnPointCard58c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[231], spawnPointCard58c.transform.position, spawnPointCard58c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard58c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard59"){
			
			spawnPointCard59 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[232], spawnPointCard59.transform.position, spawnPointCard59.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard59";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard59a"){
			
			spawnPointCard59a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[233], spawnPointCard59a.transform.position, spawnPointCard59a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard59a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard59b"){
			
			spawnPointCard59b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[234], spawnPointCard59b.transform.position, spawnPointCard59b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard59b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard59c"){
			
			spawnPointCard59c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[235], spawnPointCard59c.transform.position, spawnPointCard59c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard59c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard60"){
			
			spawnPointCard60 = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[236], spawnPointCard60.transform.position, spawnPointCard60.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard60";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard60a"){
			
			spawnPointCard60a = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[237], spawnPointCard60a.transform.position, spawnPointCard60a.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard60a";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard60b"){
			
			spawnPointCard60b = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[238], spawnPointCard60b.transform.position, spawnPointCard60b.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard60b";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
		else if(col.gameObject.name == "instantiatedAIDeckCard60c"){
			
			spawnPointCard60c = spawnPoints[Random.Range(0,spawnPoints.Count)] as GameObject;
			
			GameObject card = Instantiate (cardsInDeck240[239], spawnPointCard60c.transform.position, spawnPointCard60c.transform.rotation) as GameObject;
			card.transform.localScale = new Vector3(165.0f,100.0f,180.0f);
			card.name = "instantiatedAICard60c";
			
			card.gameObject.AddComponent<Rigidbody>();
			card.gameObject.GetComponent<Rigidbody>().useGravity = false;
			card.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Destroy(card.gameObject.GetComponent<Player1SnapCardToSlot>());
			Destroy(card.gameObject.GetComponent<DragObjectWithMouse>());

			col.gameObject.transform.parent = null;
			
		}
		
			
	}
	
	
	
}

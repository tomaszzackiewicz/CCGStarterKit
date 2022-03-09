using UnityEngine;
using System.Collections;

public class SnapCardToSlotParent : MonoBehaviour {
	
	
    public float moveSpeed = 100.0f;
    public float rotateSpeed = 90.0f;
    protected float closeVPDist = 0.03f;
	protected float dist = Mathf.Infinity;
    protected Color closeColor = new Color(1,0,0,0.2f);
	protected GameObject partnerGo;
	protected Color normalColor;
    public static bool mulligan;
    //0.01f;//
    protected float player1Row1CloseVPDist1 = 0.03f;
	protected float player1Row1Dist1 = 0.01f;
	
	protected float player1Row1CloseVPDist2 = 0.03f;
	protected float player1Row1Dist2 = 0.01f;
	
	protected float player1Row1CloseVPDist3 = 0.03f;
	protected float player1Row1Dist3 = 0.01f;
	
	protected float player1Row1CloseVPDist4 = 0.03f;
	protected float player1Row1Dist4 = 0.01f;
	
	protected float player1Row1CloseVPDist5 = 0.03f;
	protected float player1Row1Dist5 = 0.01f;
	
	protected float player1Row1CloseVPDist6 = 0.03f;
	protected float player1Row1Dist6 = 0.01f;
	
	protected float player1Row1CloseVPDist7 = 0.03f;
	protected float player1Row1Dist7 = 0.01f;
	
	protected float player1Row1CloseVPDist8 = 0.03f;
	protected float player1Row1Dist8 = 0.01f;
	
	protected float player1Row1CloseVPDist9 = 0.03f;
	protected float player1Row1Dist9 = 0.01f;
	
	protected float player1Row1CloseVPDist10 = 0.03f;
	protected float player1Row1Dist10 = 0.01f;
	
	protected float player1Row1CloseVPDist11 = 0.03f;
	protected float player1Row1Dist11 = 0.01f;
	
	protected float player1Row1CloseVPDist12 = 0.03f;
	protected float player1Row1Dist12 = 0.01f;
	
	protected float player1Row1CloseVPDist13 = 0.03f;
	protected float player1Row1Dist13 = 0.01f;
	
	protected float player1Row1CloseVPDist14 = 0.03f;
	protected float player1Row1Dist14 = 0.01f;
	
	protected float player1Row1CloseVPDist15 = 0.03f;
	protected float player1Row1Dist15 = 0.01f;
	
	protected float player1Row1CloseVPDist16 = 0.03f;
	protected float player1Row1Dist16 = 0.01f;
	
	protected float player1Row1CloseVPDist17 = 0.03f;
	protected float player1Row1Dist17 = 0.01f;
	
	protected float player1Row1CloseVPDist18 = 0.03f;
	protected float player1Row1Dist18 = 0.01f;
	
	protected float player1Row1CloseVPDist19 = 0.03f;
	protected float player1Row1Dist19 = 0.01f;
	
	protected float player1Row1CloseVPDist20 = 0.03f;
	protected float player1Row1Dist20 = 0.01f;
	
	
	protected float player1Row2CloseVPDist1 = 0.03f;
	protected float player1Row2Dist1 = 0.01f;
	
	protected float player1Row2CloseVPDist2 = 0.03f;
	protected float player1Row2Dist2 = 0.01f;
	
	protected float player1Row2CloseVPDist3 = 0.03f;
	protected float player1Row2Dist3 = 0.01f;
	
	protected float player1Row2CloseVPDist4 = 0.03f;
	protected float player1Row2Dist4 = 0.01f;
	
	protected float player1Row2CloseVPDist5 = 0.03f;
	protected float player1Row2Dist5 = 0.01f;
	
	protected float player1Row2CloseVPDist6 = 0.03f;
	protected float player1Row2Dist6 = 0.01f;
	
	protected float player1Row2CloseVPDist7 = 0.03f;
	protected float player1Row2Dist7 = 0.01f;
	
	protected float player1Row2CloseVPDist8 = 0.03f;
	protected float player1Row2Dist8 = 0.01f;
	
	protected float player1Row2CloseVPDist9 = 0.03f;
	protected float player1Row2Dist9 = 0.01f;
	
	protected float player1Row2CloseVPDist10 = 0.03f;
	protected float player1Row2Dist10 = 0.01f;
	
	protected float player1Row2CloseVPDist11 = 0.03f;
	protected float player1Row2Dist11 = 0.01f;
	
	protected float player1Row2CloseVPDist12 = 0.03f;
	protected float player1Row2Dist12 = 0.01f;
	
	protected float player1Row2CloseVPDist13 = 0.03f;
	protected float player1Row2Dist13 = 0.01f;
	
	protected float player1Row2CloseVPDist14 = 0.03f;
	protected float player1Row2Dist14 = 0.01f;
	
	protected float player1Row2CloseVPDist15 = 0.03f;
	protected float player1Row2Dist15 = 0.01f;
	
	protected float player1Row2CloseVPDist16 = 0.03f;
	protected float player1Row2Dist16 = 0.01f;
	
	protected float player1Row2CloseVPDist17 = 0.03f;
	protected float player1Row2Dist17 = 0.01f;
	
	protected float player1Row2CloseVPDist18 = 0.03f;
	protected float player1Row2Dist18 = 0.01f;
	
	protected float player1Row2CloseVPDist19 = 0.03f;
	protected float player1Row2Dist19 = 0.01f;
	
	protected float player1Row2CloseVPDist20 = 0.03f;
	protected float player1Row2Dist20 = 0.01f;
	
	
	protected float player1Row3CloseVPDist1 = 0.03f;
	protected float player1Row3Dist1 = 0.01f;
	
	protected float player1Row3CloseVPDist2 = 0.03f;
	protected float player1Row3Dist2 = 0.01f;
	
	protected float player1Row3CloseVPDist3 = 0.03f;
	protected float player1Row3Dist3 = 0.01f;
	
	protected float player1Row3CloseVPDist4 = 0.03f;
	protected float player1Row3Dist4 = 0.01f;
	
	protected float player1Row3CloseVPDist5 = 0.03f;
	protected float player1Row3Dist5 = 0.01f;
	
	protected float player1Row3CloseVPDist6 = 0.03f;
	protected float player1Row3Dist6 = 0.01f;
	
	protected float player1Row3CloseVPDist7 = 0.03f;
	protected float player1Row3Dist7 = 0.01f;
	
	protected float player1Row3CloseVPDist8 = 0.03f;
	protected float player1Row3Dist8 = 0.01f;
	
	protected float player1Row3CloseVPDist9 = 0.03f;
	protected float player1Row3Dist9 = 0.01f;
	
	protected float player1Row3CloseVPDist10 = 0.03f;
	protected float player1Row3Dist10 = 0.01f;
	
	protected float player1Row3CloseVPDist11 = 0.03f;
	protected float player1Row3Dist11 = 0.01f;
	
	protected float player1Row3CloseVPDist12 = 0.03f;
	protected float player1Row3Dist12 = 0.01f;
	
	protected float player1Row3CloseVPDist13 = 0.03f;
	protected float player1Row3Dist13 = 0.01f;
	
	protected float player1Row3CloseVPDist14 = 0.03f;
	protected float player1Row3Dist14 = 0.01f;
	
	protected float player1Row3CloseVPDist15 = 0.03f;
	protected float player1Row3Dist15 = 0.01f;
	
	protected float player1Row3CloseVPDist16 = 0.03f;
	protected float player1Row3Dist16 = 0.01f;
	
	protected float player1Row3CloseVPDist17 = 0.03f;
	protected float player1Row3Dist17 = 0.01f;
	
	protected float player1Row3CloseVPDist18 = 0.03f;
	protected float player1Row3Dist18 = 0.01f;
	
	protected float player1Row3CloseVPDist19 = 0.03f;
	protected float player1Row3Dist19 = 0.01f;
	
	protected float player1Row3CloseVPDist20 = 0.03f;
	protected float player1Row3Dist20 = 0.01f;
	
    protected Color player1Row1NormalColor1;
	protected Color player1Row1NormalColor2;
	protected Color player1Row1NormalColor3;
	protected Color player1Row1NormalColor4;
	protected Color player1Row1NormalColor5;
	protected Color player1Row1NormalColor6;
	protected Color player1Row1NormalColor7;
	protected Color player1Row1NormalColor8;
	protected Color player1Row1NormalColor9;
	protected Color player1Row1NormalColor10;
	protected Color player1Row1NormalColor11;
	protected Color player1Row1NormalColor12;
	protected Color player1Row1NormalColor13;
	protected Color player1Row1NormalColor14;
	protected Color player1Row1NormalColor15;
	protected Color player1Row1NormalColor16;
	protected Color player1Row1NormalColor17;
	protected Color player1Row1NormalColor18;
	protected Color player1Row1NormalColor19;
	protected Color player1Row1NormalColor20;
	
	protected Color player1Row2NormalColor1;
	protected Color player1Row2NormalColor2;
	protected Color player1Row2NormalColor3;
	protected Color player1Row2NormalColor4;
	protected Color player1Row2NormalColor5;
	protected Color player1Row2NormalColor6;
	protected Color player1Row2NormalColor7;
	protected Color player1Row2NormalColor8;
	protected Color player1Row2NormalColor9;
	protected Color player1Row2NormalColor10;
	protected Color player1Row2NormalColor11;
	protected Color player1Row2NormalColor12;
	protected Color player1Row2NormalColor13;
	protected Color player1Row2NormalColor14;
	protected Color player1Row2NormalColor15;
	protected Color player1Row2NormalColor16;
	protected Color player1Row2NormalColor17;
	protected Color player1Row2NormalColor18;
	protected Color player1Row2NormalColor19;
	protected Color player1Row2NormalColor20;
	
	protected Color player1Row3NormalColor1;
	protected Color player1Row3NormalColor2;
	protected Color player1Row3NormalColor3;
	protected Color player1Row3NormalColor4;
	protected Color player1Row3NormalColor5;
	protected Color player1Row3NormalColor6;
	protected Color player1Row3NormalColor7;
	protected Color player1Row3NormalColor8;
	protected Color player1Row3NormalColor9;
	protected Color player1Row3NormalColor10;
	protected Color player1Row3NormalColor11;
	protected Color player1Row3NormalColor12;
	protected Color player1Row3NormalColor13;
	protected Color player1Row3NormalColor14;
	protected Color player1Row3NormalColor15;
	protected Color player1Row3NormalColor16;
	protected Color player1Row3NormalColor17;
	protected Color player1Row3NormalColor18;
	protected Color player1Row3NormalColor19;
	protected Color player1Row3NormalColor20;
	
    protected GameObject player1Row1PartnerGo1;
	protected GameObject player1Row1PartnerGo2;
	protected GameObject player1Row1PartnerGo3;
	protected GameObject player1Row1PartnerGo4;
	protected GameObject player1Row1PartnerGo5;
	protected GameObject player1Row1PartnerGo6;
	protected GameObject player1Row1PartnerGo7;
	protected GameObject player1Row1PartnerGo8;
	protected GameObject player1Row1PartnerGo9;
	protected GameObject player1Row1PartnerGo10;
	protected GameObject player1Row1PartnerGo11;
	protected GameObject player1Row1PartnerGo12;
	protected GameObject player1Row1PartnerGo13;
	protected GameObject player1Row1PartnerGo14;
	protected GameObject player1Row1PartnerGo15;
	protected GameObject player1Row1PartnerGo16;
	protected GameObject player1Row1PartnerGo17;
	protected GameObject player1Row1PartnerGo18;
	protected GameObject player1Row1PartnerGo19;
	protected GameObject player1Row1PartnerGo20;
	
	protected GameObject player1Row2PartnerGo1;
	protected GameObject player1Row2PartnerGo2;
	protected GameObject player1Row2PartnerGo3;
	protected GameObject player1Row2PartnerGo4;
	protected GameObject player1Row2PartnerGo5;
	protected GameObject player1Row2PartnerGo6;
	protected GameObject player1Row2PartnerGo7;
	protected GameObject player1Row2PartnerGo8;
	protected GameObject player1Row2PartnerGo9;
	protected GameObject player1Row2PartnerGo10;
	protected GameObject player1Row2PartnerGo11;
	protected GameObject player1Row2PartnerGo12;
	protected GameObject player1Row2PartnerGo13;
	protected GameObject player1Row2PartnerGo14;
	protected GameObject player1Row2PartnerGo15;
	protected GameObject player1Row2PartnerGo16;
	protected GameObject player1Row2PartnerGo17;
	protected GameObject player1Row2PartnerGo18;
	protected GameObject player1Row2PartnerGo19;
	protected GameObject player1Row2PartnerGo20;
	
	protected GameObject player1Row3PartnerGo1;
	protected GameObject player1Row3PartnerGo2;
	protected GameObject player1Row3PartnerGo3;
	protected GameObject player1Row3PartnerGo4;
	protected GameObject player1Row3PartnerGo5;
	protected GameObject player1Row3PartnerGo6;
	protected GameObject player1Row3PartnerGo7;
	protected GameObject player1Row3PartnerGo8;
	protected GameObject player1Row3PartnerGo9;
	protected GameObject player1Row3PartnerGo10;
	protected GameObject player1Row3PartnerGo11;
	protected GameObject player1Row3PartnerGo12;
	protected GameObject player1Row3PartnerGo13;
	protected GameObject player1Row3PartnerGo14;
	protected GameObject player1Row3PartnerGo15;
	protected GameObject player1Row3PartnerGo16;
	protected GameObject player1Row3PartnerGo17;
	protected GameObject player1Row3PartnerGo18;
	protected GameObject player1Row3PartnerGo19;
	protected GameObject player1Row3PartnerGo20;
	
	protected string player1Row1PartnerName1;
	protected string player1Row1PartnerName2;
	protected string player1Row1PartnerName3;
	protected string player1Row1PartnerName4;
	protected string player1Row1PartnerName5;
	protected string player1Row1PartnerName6;
	protected string player1Row1PartnerName7;
	protected string player1Row1PartnerName8;
	protected string player1Row1PartnerName9;
	protected string player1Row1PartnerName10;
	protected string player1Row1PartnerName11;
	protected string player1Row1PartnerName12;
	protected string player1Row1PartnerName13;
	protected string player1Row1PartnerName14;
	protected string player1Row1PartnerName15;
	protected string player1Row1PartnerName16;
	protected string player1Row1PartnerName17;
	protected string player1Row1PartnerName18;
	protected string player1Row1PartnerName19;
	protected string player1Row1PartnerName20;
	
	protected string player1Row2PartnerName1;
	protected string player1Row2PartnerName2;
	protected string player1Row2PartnerName3;
	protected string player1Row2PartnerName4;
	protected string player1Row2PartnerName5;
	protected string player1Row2PartnerName6;
	protected string player1Row2PartnerName7;
	protected string player1Row2PartnerName8;
	protected string player1Row2PartnerName9;
	protected string player1Row2PartnerName10;
	protected string player1Row2PartnerName11;
	protected string player1Row2PartnerName12;
	protected string player1Row2PartnerName13;
	protected string player1Row2PartnerName14;
	protected string player1Row2PartnerName15;
	protected string player1Row2PartnerName16;
	protected string player1Row2PartnerName17;
	protected string player1Row2PartnerName18;
	protected string player1Row2PartnerName19;
	protected string player1Row2PartnerName20;
	
	protected string player1Row3PartnerName1;
	protected string player1Row3PartnerName2;
	protected string player1Row3PartnerName3;
	protected string player1Row3PartnerName4;
	protected string player1Row3PartnerName5;
	protected string player1Row3PartnerName6;
	protected string player1Row3PartnerName7;
	protected string player1Row3PartnerName8;
	protected string player1Row3PartnerName9;
	protected string player1Row3PartnerName10;
	protected string player1Row3PartnerName11;
	protected string player1Row3PartnerName12;
	protected string player1Row3PartnerName13;
	protected string player1Row3PartnerName14;
	protected string player1Row3PartnerName15;
	protected string player1Row3PartnerName16;
	protected string player1Row3PartnerName17;
	protected string player1Row3PartnerName18;
	protected string player1Row3PartnerName19;
	protected string player1Row3PartnerName20;

    private void Start() {
        mulligan = true;
    }

}

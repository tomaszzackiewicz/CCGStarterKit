using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player1SnapCardToSlot : SnapCardToSlotParent {
	
	private GameObject battlefield;
	private GameObject player1Deck;
	private GameObject player1SpawnCards;
	private Button button;
	private GameObject player2CardPreviewZone;
	
	
	
	
	void Awake(){
		
		player1Row1PartnerGo1 = GameObject.Find("Player1Row1Card1Slot1");
		player1Row1PartnerGo2 = GameObject.Find("Player1Row1Card1Slot2");
		player1Row1PartnerGo3 = GameObject.Find("Player1Row1Card1Slot3");
		player1Row1PartnerGo4 = GameObject.Find("Player1Row1Card1Slot4");
		player1Row1PartnerGo5 = GameObject.Find("Player1Row1Card1Slot5");
		player1Row1PartnerGo6 = GameObject.Find("Player1Row1Card1Slot6");
		player1Row1PartnerGo7 = GameObject.Find("Player1Row1Card1Slot7");
		player1Row1PartnerGo8 = GameObject.Find("Player1Row1Card1Slot8");
		player1Row1PartnerGo9 = GameObject.Find("Player1Row1Card1Slot9");
		player1Row1PartnerGo10 = GameObject.Find("Player1Row1Card1Slot10");
		player1Row1PartnerGo11 = GameObject.Find("Player1Row1Card1Slot11");
		player1Row1PartnerGo12 = GameObject.Find("Player1Row1Card1Slot12");
		player1Row1PartnerGo13 = GameObject.Find("Player1Row1Card1Slot13");
		player1Row1PartnerGo14 = GameObject.Find("Player1Row1Card1Slot14");
		player1Row1PartnerGo15 = GameObject.Find("Player1Row1Card1Slot15");
		player1Row1PartnerGo16 = GameObject.Find("Player1Row1Card1Slot16");
		player1Row1PartnerGo17 = GameObject.Find("Player1Row1Card1Slot17");
		player1Row1PartnerGo18 = GameObject.Find("Player1Row1Card1Slot18");
		player1Row1PartnerGo19 = GameObject.Find("Player1Row1Card1Slot19");
		player1Row1PartnerGo20 = GameObject.Find("Player1Row1Card1Slot20");
		
		player1Row2PartnerGo1 = GameObject.Find("Player1Row2Card1Slot1");
		player1Row2PartnerGo2 = GameObject.Find("Player1Row2Card1Slot2");
		player1Row2PartnerGo3 = GameObject.Find("Player1Row2Card1Slot3");
		player1Row2PartnerGo4 = GameObject.Find("Player1Row2Card1Slot4");
		player1Row2PartnerGo5 = GameObject.Find("Player1Row2Card1Slot5");
		player1Row2PartnerGo6 = GameObject.Find("Player1Row2Card1Slot6");
		player1Row2PartnerGo7 = GameObject.Find("Player1Row2Card1Slot7");
		player1Row2PartnerGo8 = GameObject.Find("Player1Row2Card1Slot8");
		player1Row2PartnerGo9 = GameObject.Find("Player1Row2Card1Slot9");
		player1Row2PartnerGo10 = GameObject.Find("Player1Row2Card1Slot10");
		player1Row2PartnerGo11 = GameObject.Find("Player1Row2Card1Slot11");
		player1Row2PartnerGo12 = GameObject.Find("Player1Row2Card1Slot12");
		player1Row2PartnerGo13 = GameObject.Find("Player1Row2Card1Slot13");
		player1Row2PartnerGo14 = GameObject.Find("Player1Row2Card1Slot14");
		player1Row2PartnerGo15 = GameObject.Find("Player1Row2Card1Slot15");
		player1Row2PartnerGo16 = GameObject.Find("Player1Row2Card1Slot16");
		player1Row2PartnerGo17 = GameObject.Find("Player1Row2Card1Slot17");
		player1Row2PartnerGo18 = GameObject.Find("Player1Row2Card1Slot18");
		player1Row2PartnerGo19 = GameObject.Find("Player1Row2Card1Slot19");
		player1Row2PartnerGo20 = GameObject.Find("Player1Row2Card1Slot20");
		
		player1Row3PartnerGo1 = GameObject.Find("Player1Row3Card1Slot1");
		player1Row3PartnerGo2 = GameObject.Find("Player1Row3Card1Slot2");
		player1Row3PartnerGo3 = GameObject.Find("Player1Row3Card1Slot3");
		player1Row3PartnerGo4 = GameObject.Find("Player1Row3Card1Slot4");
		player1Row3PartnerGo5 = GameObject.Find("Player1Row3Card1Slot5");
		player1Row3PartnerGo6 = GameObject.Find("Player1Row3Card1Slot6");
		player1Row3PartnerGo7 = GameObject.Find("Player1Row3Card1Slot7");
		player1Row3PartnerGo8 = GameObject.Find("Player1Row3Card1Slot8");
		player1Row3PartnerGo9 = GameObject.Find("Player1Row3Card1Slot9");
		player1Row3PartnerGo10 = GameObject.Find("Player1Row3Card1Slot10");
		player1Row3PartnerGo11 = GameObject.Find("Player1Row3Card1Slot11");
		player1Row3PartnerGo12 = GameObject.Find("Player1Row3Card1Slot12");
		player1Row3PartnerGo13 = GameObject.Find("Player1Row3Card1Slot13");
		player1Row3PartnerGo14 = GameObject.Find("Player1Row3Card1Slot14");
		player1Row3PartnerGo15 = GameObject.Find("Player1Row3Card1Slot15");
		player1Row3PartnerGo16 = GameObject.Find("Player1Row3Card1Slot16");
		player1Row3PartnerGo17 = GameObject.Find("Player1Row3Card1Slot17");
		player1Row3PartnerGo18 = GameObject.Find("Player1Row3Card1Slot18");
		player1Row3PartnerGo19 = GameObject.Find("Player1Row3Card1Slot19");
		player1Row3PartnerGo20 = GameObject.Find("Player1Row3Card1Slot20");
		
		if(player1Row1PartnerGo1){
			player1Row1NormalColor1 = player1Row1PartnerGo1.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row1PartnerGo2){
			player1Row1NormalColor2 = player1Row1PartnerGo2.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row1PartnerGo3){
			player1Row1NormalColor3 = player1Row1PartnerGo3.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row1PartnerGo4){
			player1Row1NormalColor4 = player1Row1PartnerGo4.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row1PartnerGo5){
			player1Row1NormalColor5 = player1Row1PartnerGo5.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row1PartnerGo6){
			player1Row1NormalColor6 = player1Row1PartnerGo6.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row1PartnerGo7){
			player1Row1NormalColor7 = player1Row1PartnerGo7.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row1PartnerGo8){
			player1Row1NormalColor8 = player1Row1PartnerGo8.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row1PartnerGo9){
			player1Row1NormalColor9 = player1Row1PartnerGo9.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row1PartnerGo10){
			player1Row1NormalColor10 = player1Row1PartnerGo10.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row1PartnerGo11){
			player1Row1NormalColor11 = player1Row1PartnerGo11.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row1PartnerGo12){
			player1Row1NormalColor12 = player1Row1PartnerGo12.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row1PartnerGo13){
			player1Row1NormalColor13 = player1Row1PartnerGo13.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row1PartnerGo14){
			player1Row1NormalColor14 = player1Row1PartnerGo14.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row1PartnerGo15){
			player1Row1NormalColor15 = player1Row1PartnerGo15.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row1PartnerGo16){
			player1Row1NormalColor16 = player1Row1PartnerGo16.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row1PartnerGo17){
			player1Row1NormalColor17 = player1Row1PartnerGo17.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row1PartnerGo18){
			player1Row1NormalColor18 = player1Row1PartnerGo18.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row1PartnerGo19){
			player1Row1NormalColor19 = player1Row1PartnerGo19.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row1PartnerGo20){
			player1Row1NormalColor20 = player1Row1PartnerGo20.gameObject.GetComponent<Renderer>().material.color;
		}
		
		if(player1Row2PartnerGo1){
			player1Row2NormalColor1 = player1Row2PartnerGo1.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row2PartnerGo2){
			player1Row2NormalColor2 = player1Row2PartnerGo2.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row2PartnerGo3){
			player1Row2NormalColor3 = player1Row2PartnerGo3.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row2PartnerGo4){
			player1Row2NormalColor4 = player1Row2PartnerGo4.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row2PartnerGo5){
			player1Row2NormalColor5 = player1Row2PartnerGo5.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row2PartnerGo6){
			player1Row2NormalColor6 = player1Row2PartnerGo6.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row2PartnerGo7){
			player1Row2NormalColor7 = player1Row2PartnerGo7.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row2PartnerGo8){
			player1Row2NormalColor8 = player1Row2PartnerGo8.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row2PartnerGo9){
			player1Row2NormalColor9 = player1Row2PartnerGo9.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row2PartnerGo10){
			player1Row2NormalColor10 = player1Row2PartnerGo10.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row2PartnerGo11){
			player1Row2NormalColor11 = player1Row2PartnerGo11.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row2PartnerGo12){
			player1Row2NormalColor12 = player1Row2PartnerGo12.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row2PartnerGo13){
			player1Row2NormalColor13 = player1Row2PartnerGo13.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row2PartnerGo14){
			player1Row2NormalColor14 = player1Row2PartnerGo14.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row2PartnerGo15){
			player1Row2NormalColor15 = player1Row2PartnerGo15.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row2PartnerGo16){
			player1Row2NormalColor16 = player1Row2PartnerGo16.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row2PartnerGo17){
			player1Row2NormalColor17 = player1Row2PartnerGo17.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row2PartnerGo18){
			player1Row2NormalColor18 = player1Row2PartnerGo18.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row2PartnerGo19){
			player1Row2NormalColor19 = player1Row2PartnerGo19.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row2PartnerGo20){
			player1Row2NormalColor20 = player1Row2PartnerGo20.gameObject.GetComponent<Renderer>().material.color;
		}
		
		
		if(player1Row3PartnerGo1){
			player1Row3NormalColor1 = player1Row3PartnerGo1.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row3PartnerGo2){
			player1Row3NormalColor2 = player1Row3PartnerGo2.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row3PartnerGo3){
			player1Row3NormalColor3 = player1Row3PartnerGo3.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row3PartnerGo4){
			player1Row3NormalColor4 = player1Row3PartnerGo4.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row3PartnerGo5){
			player1Row3NormalColor5 = player1Row3PartnerGo5.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row3PartnerGo6){
			player1Row3NormalColor6 = player1Row3PartnerGo6.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row3PartnerGo7){
			player1Row3NormalColor7 = player1Row3PartnerGo7.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row3PartnerGo8){
			player1Row3NormalColor8 = player1Row3PartnerGo8.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row3PartnerGo9){
			player1Row3NormalColor9 = player1Row3PartnerGo9.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row3PartnerGo10){
			player1Row3NormalColor10 = player1Row3PartnerGo10.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row3PartnerGo11){
			player1Row3NormalColor11 = player1Row3PartnerGo11.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row3PartnerGo12){
			player1Row3NormalColor12 = player1Row3PartnerGo12.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row3PartnerGo13){
			player1Row3NormalColor13 = player1Row3PartnerGo13.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row3PartnerGo14){
			player1Row3NormalColor14 = player1Row3PartnerGo14.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row3PartnerGo15){
			player1Row3NormalColor15 = player1Row3PartnerGo15.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row3PartnerGo16){
			player1Row3NormalColor16 = player1Row3PartnerGo16.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row3PartnerGo17){
			player1Row3NormalColor17 = player1Row3PartnerGo17.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row3PartnerGo18){
			player1Row3NormalColor18 = player1Row3PartnerGo18.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row3PartnerGo19){
			player1Row3NormalColor19 = player1Row3PartnerGo19.gameObject.GetComponent<Renderer>().material.color;
		}
		if(player1Row3PartnerGo20){
			player1Row3NormalColor20 = player1Row3PartnerGo20.gameObject.GetComponent<Renderer>().material.color;
		}
		
		
		battlefield = GameObject.Find("Battlefield");
		
		//player1Deck = GameObject.Find("Player1TableShowCards");
		
		player2CardPreviewZone = GameObject.Find("Player2CardPreviewZone");
		
		
		
	}
	
    void Start() {
		
		AIController.EndTurnEventIE += AITurn;
		FirstRoundManager.AITurnEventIE += AITurn;
		
		
		
    }
	
	void Update(){
		
      
	}
	
     
     void OnMouseDrag() {
		 
		if(player1Row1PartnerGo1){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row1PartnerGo1.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row1Dist1 = Vector2.Distance(partnerPos, myPos);
			player1Row1PartnerGo1.GetComponent<Renderer>().material.color = (player1Row1Dist1 < player1Row1CloseVPDist1) ? closeColor : player1Row1NormalColor1;
		}
		
		if(player1Row1PartnerGo2){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row1PartnerGo2.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row1Dist2 = Vector2.Distance(partnerPos, myPos);
			player1Row1PartnerGo2.GetComponent<Renderer>().material.color = (player1Row1Dist2 < player1Row1CloseVPDist2) ? closeColor : player1Row1NormalColor2;
		}
		
	
		if(player1Row1PartnerGo3){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row1PartnerGo3.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row1Dist3 = Vector2.Distance(partnerPos, myPos);
			player1Row1PartnerGo3.GetComponent<Renderer>().material.color = (player1Row1Dist3 < player1Row1CloseVPDist3) ? closeColor : player1Row1NormalColor3;
		}
		
		
		if(player1Row1PartnerGo4){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row1PartnerGo4.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row1Dist4 = Vector2.Distance(partnerPos, myPos);
			player1Row1PartnerGo4.GetComponent<Renderer>().material.color = (player1Row1Dist4 < player1Row1CloseVPDist4) ? closeColor : player1Row1NormalColor4;
		}
		
		
		if(player1Row1PartnerGo5){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row1PartnerGo5.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row1Dist5 = Vector2.Distance(partnerPos, myPos);
			player1Row1PartnerGo5.GetComponent<Renderer>().material.color = (player1Row1Dist5 < player1Row1CloseVPDist5) ? closeColor : player1Row1NormalColor5;
		}
		
		if(player1Row1PartnerGo6){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row1PartnerGo6.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row1Dist6 = Vector2.Distance(partnerPos, myPos);
			player1Row1PartnerGo6.GetComponent<Renderer>().material.color = (player1Row1Dist6 < player1Row1CloseVPDist6) ? closeColor : player1Row1NormalColor6;
		}
		
		if(player1Row1PartnerGo7){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row1PartnerGo7.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row1Dist7 = Vector2.Distance(partnerPos, myPos);
			player1Row1PartnerGo7.GetComponent<Renderer>().material.color = (player1Row1Dist7 < player1Row1CloseVPDist7) ? closeColor : player1Row1NormalColor7;
		}
		
		
		if(player1Row1PartnerGo8){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row1PartnerGo8.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row1Dist8 = Vector2.Distance(partnerPos, myPos);
			player1Row1PartnerGo8.GetComponent<Renderer>().material.color = (player1Row1Dist8 < player1Row1CloseVPDist8) ? closeColor : player1Row1NormalColor8;
		}
		
		
		if(player1Row1PartnerGo9){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row1PartnerGo9.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row1Dist9 = Vector2.Distance(partnerPos, myPos);
			player1Row1PartnerGo9.GetComponent<Renderer>().material.color = (player1Row1Dist9 < player1Row1CloseVPDist9) ? closeColor : player1Row1NormalColor9;
		}
		
		
		if(player1Row1PartnerGo10){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row1PartnerGo10.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row1Dist10 = Vector2.Distance(partnerPos, myPos);
			player1Row1PartnerGo10.GetComponent<Renderer>().material.color = (player1Row1Dist10 < player1Row1CloseVPDist10) ? closeColor : player1Row1NormalColor10;
		}
		
		
		if(player1Row1PartnerGo11){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row1PartnerGo11.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row1Dist11 = Vector2.Distance(partnerPos, myPos);
			player1Row1PartnerGo11.GetComponent<Renderer>().material.color = (player1Row1Dist11 < player1Row1CloseVPDist11) ? closeColor : player1Row1NormalColor11;
		}
		
		if(player1Row1PartnerGo12){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row1PartnerGo12.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row1Dist12 = Vector2.Distance(partnerPos, myPos);
			player1Row1PartnerGo12.GetComponent<Renderer>().material.color = (player1Row1Dist12 < player1Row1CloseVPDist12) ? closeColor : player1Row1NormalColor12;
		}
		
	
		if(player1Row1PartnerGo13){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row1PartnerGo13.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row1Dist13 = Vector2.Distance(partnerPos, myPos);
			player1Row1PartnerGo13.GetComponent<Renderer>().material.color = (player1Row1Dist13 < player1Row1CloseVPDist13) ? closeColor : player1Row1NormalColor13;
		}
		
		
		if(player1Row1PartnerGo14){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row1PartnerGo14.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row1Dist14 = Vector2.Distance(partnerPos, myPos);
			player1Row1PartnerGo14.GetComponent<Renderer>().material.color = (player1Row1Dist14 < player1Row1CloseVPDist14) ? closeColor : player1Row1NormalColor14;
		}
		
		
		if(player1Row1PartnerGo15){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row1PartnerGo15.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row1Dist15 = Vector2.Distance(partnerPos, myPos);
			player1Row1PartnerGo15.GetComponent<Renderer>().material.color = (player1Row1Dist15 < player1Row1CloseVPDist15) ? closeColor : player1Row1NormalColor15;
		}
		
		if(player1Row1PartnerGo16){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row1PartnerGo16.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row1Dist16 = Vector2.Distance(partnerPos, myPos);
			player1Row1PartnerGo16.GetComponent<Renderer>().material.color = (player1Row1Dist16 < player1Row1CloseVPDist16) ? closeColor : player1Row1NormalColor16;
		}
		
		if(player1Row1PartnerGo17){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row1PartnerGo17.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row1Dist17 = Vector2.Distance(partnerPos, myPos);
			player1Row1PartnerGo17.GetComponent<Renderer>().material.color = (player1Row1Dist17 < player1Row1CloseVPDist17) ? closeColor : player1Row1NormalColor17;
		}
		
		
		if(player1Row1PartnerGo18){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row1PartnerGo18.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row1Dist18 = Vector2.Distance(partnerPos, myPos);
			player1Row1PartnerGo18.GetComponent<Renderer>().material.color = (player1Row1Dist18 < player1Row1CloseVPDist18) ? closeColor : player1Row1NormalColor18;
		}
		
		
		if(player1Row1PartnerGo19){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row1PartnerGo19.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row1Dist19 = Vector2.Distance(partnerPos, myPos);
			player1Row1PartnerGo19.GetComponent<Renderer>().material.color = (player1Row1Dist19 < player1Row1CloseVPDist19) ? closeColor : player1Row1NormalColor19;
		}
		
		
		if(player1Row1PartnerGo20){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row1PartnerGo20.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row1Dist20 = Vector2.Distance(partnerPos, myPos);
			player1Row1PartnerGo20.GetComponent<Renderer>().material.color = (player1Row1Dist20 < player1Row1CloseVPDist20) ? closeColor : player1Row1NormalColor20;
		}
		
		
		if(player1Row2PartnerGo1){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row2PartnerGo1.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row2Dist1 = Vector2.Distance(partnerPos, myPos);
			player1Row2PartnerGo1.GetComponent<Renderer>().material.color = (player1Row2Dist1 < player1Row2CloseVPDist1) ? closeColor : player1Row2NormalColor1;
		}
		
		if(player1Row2PartnerGo2){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row2PartnerGo2.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row2Dist2 = Vector2.Distance(partnerPos, myPos);
			player1Row2PartnerGo2.GetComponent<Renderer>().material.color = (player1Row2Dist2 < player1Row2CloseVPDist2) ? closeColor : player1Row2NormalColor2;
		}
		
	
		if(player1Row2PartnerGo3){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row2PartnerGo3.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row2Dist3 = Vector2.Distance(partnerPos, myPos);
			player1Row2PartnerGo3.GetComponent<Renderer>().material.color = (player1Row2Dist3 < player1Row2CloseVPDist3) ? closeColor : player1Row2NormalColor3;
		}
		
		
		if(player1Row2PartnerGo4){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row2PartnerGo4.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row2Dist4 = Vector2.Distance(partnerPos, myPos);
			player1Row2PartnerGo4.GetComponent<Renderer>().material.color = (player1Row2Dist4 < player1Row2CloseVPDist4) ? closeColor : player1Row2NormalColor4;
		}
		
		
		if(player1Row2PartnerGo5){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row2PartnerGo5.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row2Dist5 = Vector2.Distance(partnerPos, myPos);
			player1Row2PartnerGo5.GetComponent<Renderer>().material.color = (player1Row2Dist5 < player1Row2CloseVPDist5) ? closeColor : player1Row2NormalColor5;
		}
		
		if(player1Row2PartnerGo6){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row2PartnerGo6.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row2Dist6 = Vector2.Distance(partnerPos, myPos);
			player1Row2PartnerGo6.GetComponent<Renderer>().material.color = (player1Row2Dist6 < player1Row2CloseVPDist6) ? closeColor : player1Row2NormalColor6;
		}
		
		if(player1Row2PartnerGo7){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row2PartnerGo7.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row2Dist7 = Vector2.Distance(partnerPos, myPos);
			player1Row2PartnerGo7.GetComponent<Renderer>().material.color = (player1Row2Dist7 < player1Row2CloseVPDist7) ? closeColor : player1Row2NormalColor7;
		}
		
		
		if(player1Row2PartnerGo8){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row2PartnerGo8.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row2Dist8 = Vector2.Distance(partnerPos, myPos);
			player1Row2PartnerGo8.GetComponent<Renderer>().material.color = (player1Row2Dist8 < player1Row2CloseVPDist8) ? closeColor : player1Row2NormalColor8;
		}
		
		
		if(player1Row2PartnerGo9){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row2PartnerGo9.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row2Dist9 = Vector2.Distance(partnerPos, myPos);
			player1Row2PartnerGo9.GetComponent<Renderer>().material.color = (player1Row2Dist9 < player1Row2CloseVPDist9) ? closeColor : player1Row2NormalColor9;
		}
		
		
		if(player1Row2PartnerGo10){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row2PartnerGo10.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row2Dist10 = Vector2.Distance(partnerPos, myPos);
			player1Row2PartnerGo10.GetComponent<Renderer>().material.color = (player1Row2Dist10 < player1Row2CloseVPDist10) ? closeColor : player1Row2NormalColor10;
		}
		
		
		if(player1Row2PartnerGo11){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row2PartnerGo11.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row2Dist11 = Vector2.Distance(partnerPos, myPos);
			player1Row2PartnerGo11.GetComponent<Renderer>().material.color = (player1Row2Dist11 < player1Row2CloseVPDist11) ? closeColor : player1Row2NormalColor11;
		}
		
		if(player1Row2PartnerGo12){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row2PartnerGo12.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row2Dist12 = Vector2.Distance(partnerPos, myPos);
			player1Row2PartnerGo12.GetComponent<Renderer>().material.color = (player1Row2Dist12 < player1Row2CloseVPDist12) ? closeColor : player1Row2NormalColor12;
		}
		
	
		if(player1Row2PartnerGo13){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row2PartnerGo13.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row2Dist13 = Vector2.Distance(partnerPos, myPos);
			player1Row2PartnerGo13.GetComponent<Renderer>().material.color = (player1Row2Dist13 < player1Row2CloseVPDist13) ? closeColor : player1Row2NormalColor13;
		}
		
		
		if(player1Row2PartnerGo14){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row2PartnerGo14.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row2Dist14 = Vector2.Distance(partnerPos, myPos);
			player1Row2PartnerGo14.GetComponent<Renderer>().material.color = (player1Row2Dist14 < player1Row2CloseVPDist14) ? closeColor : player1Row2NormalColor14;
		}
		
		
		if(player1Row2PartnerGo15){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row2PartnerGo15.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row2Dist15 = Vector2.Distance(partnerPos, myPos);
			player1Row2PartnerGo15.GetComponent<Renderer>().material.color = (player1Row2Dist15 < player1Row2CloseVPDist15) ? closeColor : player1Row2NormalColor15;
		}
		
		if(player1Row2PartnerGo16){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row2PartnerGo16.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row2Dist16 = Vector2.Distance(partnerPos, myPos);
			player1Row2PartnerGo16.GetComponent<Renderer>().material.color = (player1Row2Dist16 < player1Row2CloseVPDist16) ? closeColor : player1Row2NormalColor16;
		}
		
		if(player1Row2PartnerGo17){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row2PartnerGo17.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row2Dist17 = Vector2.Distance(partnerPos, myPos);
			player1Row2PartnerGo17.GetComponent<Renderer>().material.color = (player1Row2Dist17 < player1Row2CloseVPDist17) ? closeColor : player1Row2NormalColor17;
		}
		
		
		if(player1Row2PartnerGo18){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row2PartnerGo18.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row2Dist18 = Vector2.Distance(partnerPos, myPos);
			player1Row2PartnerGo18.GetComponent<Renderer>().material.color = (player1Row2Dist18 < player1Row2CloseVPDist18) ? closeColor : player1Row2NormalColor18;
		}
		
		
		if(player1Row2PartnerGo19){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row2PartnerGo19.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row2Dist19 = Vector2.Distance(partnerPos, myPos);
			player1Row2PartnerGo19.GetComponent<Renderer>().material.color = (player1Row2Dist19 < player1Row2CloseVPDist19) ? closeColor : player1Row2NormalColor19;
		}
		
		
		if(player1Row2PartnerGo20){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row2PartnerGo20.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row2Dist20 = Vector2.Distance(partnerPos, myPos);
			player1Row2PartnerGo20.GetComponent<Renderer>().material.color = (player1Row2Dist20 < player1Row2CloseVPDist20) ? closeColor : player1Row2NormalColor20;
		}
		
		
		
		
		if(player1Row3PartnerGo1){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row3PartnerGo1.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row3Dist1 = Vector2.Distance(partnerPos, myPos);
			player1Row3PartnerGo1.GetComponent<Renderer>().material.color = (player1Row3Dist1 < player1Row3CloseVPDist1) ? closeColor : player1Row3NormalColor1;
		}
		
		if(player1Row3PartnerGo2){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row3PartnerGo2.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row3Dist2 = Vector2.Distance(partnerPos, myPos);
			player1Row3PartnerGo2.GetComponent<Renderer>().material.color = (player1Row3Dist2 < player1Row3CloseVPDist2) ? closeColor : player1Row3NormalColor2;
		}
		
	
		if(player1Row3PartnerGo3){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row3PartnerGo3.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row3Dist3 = Vector2.Distance(partnerPos, myPos);
			player1Row3PartnerGo3.GetComponent<Renderer>().material.color = (player1Row3Dist3 < player1Row3CloseVPDist3) ? closeColor : player1Row3NormalColor3;
		}
		
		
		if(player1Row3PartnerGo4){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row3PartnerGo4.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row3Dist4 = Vector2.Distance(partnerPos, myPos);
			player1Row3PartnerGo4.GetComponent<Renderer>().material.color = (player1Row3Dist4 < player1Row3CloseVPDist4) ? closeColor : player1Row3NormalColor4;
		}
		
		
		if(player1Row3PartnerGo5){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row3PartnerGo5.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row3Dist5 = Vector2.Distance(partnerPos, myPos);
			player1Row3PartnerGo5.GetComponent<Renderer>().material.color = (player1Row3Dist5 < player1Row3CloseVPDist5) ? closeColor : player1Row3NormalColor5;
		}
		
		if(player1Row3PartnerGo6){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row3PartnerGo6.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row3Dist6 = Vector2.Distance(partnerPos, myPos);
			player1Row3PartnerGo6.GetComponent<Renderer>().material.color = (player1Row3Dist6 < player1Row3CloseVPDist6) ? closeColor : player1Row3NormalColor6;
		}
		
		if(player1Row3PartnerGo7){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row3PartnerGo7.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row3Dist7 = Vector2.Distance(partnerPos, myPos);
			player1Row3PartnerGo7.GetComponent<Renderer>().material.color = (player1Row3Dist7 < player1Row3CloseVPDist7) ? closeColor : player1Row3NormalColor7;
		}
		
		
		if(player1Row3PartnerGo8){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row3PartnerGo8.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row3Dist8 = Vector2.Distance(partnerPos, myPos);
			player1Row3PartnerGo8.GetComponent<Renderer>().material.color = (player1Row3Dist8 < player1Row3CloseVPDist8) ? closeColor : player1Row3NormalColor8;
		}
		
		
		if(player1Row3PartnerGo9){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row3PartnerGo9.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row3Dist9 = Vector2.Distance(partnerPos, myPos);
			player1Row3PartnerGo9.GetComponent<Renderer>().material.color = (player1Row3Dist9 < player1Row3CloseVPDist9) ? closeColor : player1Row3NormalColor9;
		}
		
		
		if(player1Row3PartnerGo10){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row3PartnerGo10.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row3Dist10 = Vector2.Distance(partnerPos, myPos);
			player1Row3PartnerGo10.GetComponent<Renderer>().material.color = (player1Row3Dist10 < player1Row3CloseVPDist10) ? closeColor : player1Row3NormalColor10;
		}
		
		
		if(player1Row3PartnerGo11){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row3PartnerGo11.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row3Dist11 = Vector2.Distance(partnerPos, myPos);
			player1Row3PartnerGo11.GetComponent<Renderer>().material.color = (player1Row3Dist11 < player1Row3CloseVPDist11) ? closeColor : player1Row3NormalColor11;
		}
		
		if(player1Row3PartnerGo12){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row3PartnerGo12.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row3Dist12 = Vector2.Distance(partnerPos, myPos);
			player1Row3PartnerGo12.GetComponent<Renderer>().material.color = (player1Row3Dist12 < player1Row3CloseVPDist12) ? closeColor : player1Row3NormalColor12;
		}
		
	
		if(player1Row3PartnerGo13){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row3PartnerGo13.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row3Dist13 = Vector2.Distance(partnerPos, myPos);
			player1Row3PartnerGo13.GetComponent<Renderer>().material.color = (player1Row3Dist13 < player1Row3CloseVPDist13) ? closeColor : player1Row3NormalColor13;
		}
		
		
		if(player1Row3PartnerGo14){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row3PartnerGo14.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row3Dist14 = Vector2.Distance(partnerPos, myPos);
			player1Row3PartnerGo14.GetComponent<Renderer>().material.color = (player1Row3Dist14 < player1Row3CloseVPDist14) ? closeColor : player1Row3NormalColor14;
		}
		
		
		if(player1Row3PartnerGo15){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row3PartnerGo15.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row3Dist15 = Vector2.Distance(partnerPos, myPos);
			player1Row3PartnerGo15.GetComponent<Renderer>().material.color = (player1Row3Dist15 < player1Row3CloseVPDist15) ? closeColor : player1Row3NormalColor15;
		}
		
		if(player1Row3PartnerGo16){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row3PartnerGo16.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row3Dist16 = Vector2.Distance(partnerPos, myPos);
			player1Row3PartnerGo16.GetComponent<Renderer>().material.color = (player1Row3Dist16 < player1Row3CloseVPDist16) ? closeColor : player1Row3NormalColor16;
		}
		
		if(player1Row3PartnerGo17){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row3PartnerGo17.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row3Dist17 = Vector2.Distance(partnerPos, myPos);
			player1Row3PartnerGo17.GetComponent<Renderer>().material.color = (player1Row3Dist17 < player1Row3CloseVPDist17) ? closeColor : player1Row3NormalColor17;
		}
		
		
		if(player1Row3PartnerGo18){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row3PartnerGo18.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row3Dist18 = Vector2.Distance(partnerPos, myPos);
			player1Row3PartnerGo18.GetComponent<Renderer>().material.color = (player1Row3Dist18 < player1Row3CloseVPDist18) ? closeColor : player1Row3NormalColor18;
		}
		
		
		if(player1Row3PartnerGo19){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row3PartnerGo19.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row3Dist19 = Vector2.Distance(partnerPos, myPos);
			player1Row3PartnerGo19.GetComponent<Renderer>().material.color = (player1Row3Dist19 < player1Row3CloseVPDist19) ? closeColor : player1Row3NormalColor19;
		}
		
		
		if(player1Row3PartnerGo20){
			
			NormalCardPosition();
			
			var partnerPos = Camera.main.WorldToViewportPoint(player1Row3PartnerGo20.transform.position);
			var myPos = Camera.main.WorldToViewportPoint(transform.position);
			player1Row3Dist20 = Vector2.Distance(partnerPos, myPos);
			player1Row3PartnerGo20.GetComponent<Renderer>().material.color = (player1Row3Dist20 < player1Row3CloseVPDist20) ? closeColor : player1Row3NormalColor20;
		}
		
		
		
    }
	
	void NormalCardPosition(){
		transform.position =  new Vector3(Mathf.Clamp(transform.position.x, -8.5f, 8.5f), Mathf.Clamp(transform.position.y, 0.3f, 0.3f), Mathf.Clamp(transform.position.z, -5.5f, -1.0f));
	}
	
     
    void OnMouseUp() {
		
		if (player1Row1PartnerGo1 && player1Row1Dist1 < player1Row1CloseVPDist1) {
			transform.parent = player1Row1PartnerGo1.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if(player1Row1PartnerGo2 && player1Row1Dist2 < player1Row1CloseVPDist2){
			transform.parent = player1Row1PartnerGo2.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if(player1Row1PartnerGo3 && player1Row1Dist3 < player1Row1CloseVPDist3){
			transform.parent = player1Row1PartnerGo3.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if(player1Row1PartnerGo4 && player1Row1Dist4 < player1Row1CloseVPDist4){
			transform.parent = player1Row1PartnerGo4.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if(player1Row1PartnerGo5 && player1Row1Dist5 < player1Row1CloseVPDist5){
			transform.parent = player1Row1PartnerGo5.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if(player1Row1PartnerGo6 && player1Row1Dist6 < player1Row1CloseVPDist6){
			transform.parent = player1Row1PartnerGo6.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if(player1Row1PartnerGo7 && player1Row1Dist7 < player1Row1CloseVPDist7){
			transform.parent = player1Row1PartnerGo7.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if(player1Row1PartnerGo8 && player1Row1Dist8 < player1Row1CloseVPDist8){
			transform.parent = player1Row1PartnerGo8.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if(player1Row1PartnerGo9 && player1Row1Dist9 < player1Row1CloseVPDist9){
			transform.parent = player1Row1PartnerGo9.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if(player1Row1PartnerGo10 && player1Row1Dist10 < player1Row1CloseVPDist10){
			transform.parent = player1Row1PartnerGo10.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if (player1Row1PartnerGo11 && player1Row1Dist11 < player1Row1CloseVPDist11) {
			transform.parent = player1Row1PartnerGo11.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if(player1Row1PartnerGo12 && player1Row1Dist12 < player1Row1CloseVPDist12){
			transform.parent = player1Row1PartnerGo12.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if(player1Row1PartnerGo13 && player1Row1Dist13 < player1Row1CloseVPDist13){
			transform.parent = player1Row1PartnerGo13.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if(player1Row1PartnerGo14 && player1Row1Dist14 < player1Row1CloseVPDist14){
			transform.parent = player1Row1PartnerGo14.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if(player1Row1PartnerGo15 && player1Row1Dist15 < player1Row1CloseVPDist15){
			transform.parent = player1Row1PartnerGo15.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if(player1Row1PartnerGo16 && player1Row1Dist16 < player1Row1CloseVPDist16){
			transform.parent = player1Row1PartnerGo16.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if(player1Row1PartnerGo17 && player1Row1Dist17 < player1Row1CloseVPDist17){
			transform.parent = player1Row1PartnerGo17.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if(player1Row1PartnerGo18 && player1Row1Dist18 < player1Row1CloseVPDist18){
			transform.parent = player1Row1PartnerGo18.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if(player1Row1PartnerGo19 && player1Row1Dist19 < player1Row1CloseVPDist19){
			transform.parent = player1Row1PartnerGo19.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if(player1Row1PartnerGo20 && player1Row1Dist20 < player1Row1CloseVPDist20){
			transform.parent = player1Row1PartnerGo20.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		
		if (player1Row2PartnerGo1 && player1Row2Dist1 < player1Row2CloseVPDist1) {
			transform.parent = player1Row2PartnerGo1.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if(player1Row2PartnerGo2 && player1Row2Dist2 < player1Row2CloseVPDist2){
			transform.parent = player1Row2PartnerGo2.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if(player1Row2PartnerGo3 && player1Row2Dist3 < player1Row2CloseVPDist3){
			transform.parent = player1Row2PartnerGo3.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if(player1Row2PartnerGo4 && player1Row2Dist4 < player1Row2CloseVPDist4){
			transform.parent = player1Row2PartnerGo4.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if(player1Row2PartnerGo5 && player1Row2Dist5 < player1Row2CloseVPDist5){
			transform.parent = player1Row2PartnerGo5.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if(player1Row2PartnerGo6 && player1Row2Dist6 < player1Row2CloseVPDist6){
			transform.parent = player1Row2PartnerGo6.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if(player1Row2PartnerGo7 && player1Row2Dist7 < player1Row2CloseVPDist7){
			transform.parent = player1Row2PartnerGo7.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if(player1Row2PartnerGo8 && player1Row2Dist8 < player1Row2CloseVPDist8){
			transform.parent = player1Row2PartnerGo8.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if(player1Row2PartnerGo9 && player1Row2Dist9 < player1Row2CloseVPDist9){
			transform.parent = player1Row2PartnerGo9.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if(player1Row2PartnerGo10 && player1Row2Dist10 < player1Row2CloseVPDist10){
			transform.parent = player1Row2PartnerGo10.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if (player1Row2PartnerGo11 && player1Row2Dist11 < player1Row2CloseVPDist11) {
			transform.parent = player1Row2PartnerGo11.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if(player1Row2PartnerGo12 && player1Row2Dist12 < player1Row2CloseVPDist12){
			transform.parent = player1Row2PartnerGo12.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if(player1Row2PartnerGo13 && player1Row2Dist13 < player1Row2CloseVPDist13){
			transform.parent = player1Row2PartnerGo13.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if(player1Row2PartnerGo14 && player1Row2Dist14 < player1Row2CloseVPDist14){
			transform.parent = player1Row2PartnerGo14.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if(player1Row2PartnerGo15 && player1Row2Dist15 < player1Row2CloseVPDist15){
			transform.parent = player1Row2PartnerGo15.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if(player1Row2PartnerGo16 && player1Row2Dist16 < player1Row2CloseVPDist16){
			transform.parent = player1Row2PartnerGo16.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if(player1Row2PartnerGo17 && player1Row2Dist17 < player1Row2CloseVPDist17){
			transform.parent = player1Row2PartnerGo17.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if(player1Row2PartnerGo18 && player1Row2Dist18 < player1Row2CloseVPDist18){
			transform.parent = player1Row2PartnerGo18.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if(player1Row2PartnerGo19 && player1Row2Dist19 < player1Row2CloseVPDist19){
			transform.parent = player1Row2PartnerGo19.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if(player1Row2PartnerGo20 && player1Row2Dist20 < player1Row2CloseVPDist20){
			transform.parent = player1Row2PartnerGo20.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		
		if (player1Row3PartnerGo1 && player1Row3Dist1 < player1Row3CloseVPDist1) {
			transform.parent = player1Row3PartnerGo1.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if(player1Row3PartnerGo2 && player1Row3Dist2 < player1Row3CloseVPDist2){
			transform.parent = player1Row3PartnerGo2.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if(player1Row3PartnerGo3 && player1Row3Dist3 < player1Row3CloseVPDist3){
			transform.parent = player1Row3PartnerGo3.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if(player1Row3PartnerGo4 && player1Row3Dist4 < player1Row3CloseVPDist4){
			transform.parent = player1Row3PartnerGo4.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if(player1Row3PartnerGo5 && player1Row3Dist5 < player1Row3CloseVPDist5){
			transform.parent = player1Row3PartnerGo5.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if(player1Row3PartnerGo6 && player1Row3Dist6 < player1Row3CloseVPDist6){
			transform.parent = player1Row3PartnerGo6.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if(player1Row3PartnerGo7 && player1Row3Dist7 < player1Row3CloseVPDist7){
			transform.parent = player1Row3PartnerGo7.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if(player1Row3PartnerGo8 && player1Row3Dist8 < player1Row3CloseVPDist8){
			transform.parent = player1Row3PartnerGo8.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if(player1Row3PartnerGo9 && player1Row3Dist9 < player1Row3CloseVPDist9){
			transform.parent = player1Row3PartnerGo9.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if(player1Row3PartnerGo10 && player1Row3Dist10 < player1Row3CloseVPDist10){
			transform.parent = player1Row3PartnerGo10.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if (player1Row3PartnerGo11 && player1Row3Dist11 < player1Row3CloseVPDist11) {
			transform.parent = player1Row3PartnerGo11.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if(player1Row3PartnerGo12 && player1Row3Dist12 < player1Row3CloseVPDist12){
			transform.parent = player1Row3PartnerGo12.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if(player1Row3PartnerGo13 && player1Row3Dist13 < player1Row3CloseVPDist13){
			transform.parent = player1Row3PartnerGo13.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if(player1Row3PartnerGo14 && player1Row3Dist14 < player1Row3CloseVPDist14){
			transform.parent = player1Row3PartnerGo14.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if(player1Row3PartnerGo15 && player1Row3Dist15 < player1Row3CloseVPDist15){
			transform.parent = player1Row3PartnerGo15.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if(player1Row3PartnerGo16 && player1Row3Dist16 < player1Row3CloseVPDist16){
			transform.parent = player1Row3PartnerGo16.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if(player1Row3PartnerGo17 && player1Row3Dist17 < player1Row3CloseVPDist17){
			transform.parent = player1Row3PartnerGo17.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if(player1Row3PartnerGo18 && player1Row3Dist18 < player1Row3CloseVPDist18){
			transform.parent = player1Row3PartnerGo18.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if(player1Row3PartnerGo19 && player1Row3Dist19 < player1Row3CloseVPDist19){
			transform.parent = player1Row3PartnerGo19.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		if(player1Row3PartnerGo20 && player1Row3Dist20 < player1Row3CloseVPDist20){
			transform.parent = player1Row3PartnerGo20.transform;
			StartCoroutine("InstallPart");
			//StartCoroutine("AITurn");
		}
		
		
		if(player1Deck){
			player1Deck.GetComponent<BoxCollider>().size = new Vector3(1.0f,1.0f,1.0f);
			//button.interactable = true;
		}
	}
     
	IEnumerator InstallPart() {
		
         while (transform.localPosition != Vector3.zero || transform.localRotation != Quaternion.identity) {
			 
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, Vector3.zero, Time.deltaTime * moveSpeed);
            transform.localRotation = Quaternion.RotateTowards(transform.localRotation, Quaternion.identity, Time.deltaTime * rotateSpeed);
			
			gameObject.transform.localScale = new Vector3(330.0f,1000.0f,120.0f);
			Destroy(gameObject.GetComponent<DragObjectWithMouse>());

            yield return null;
         }
     }
	 	
	IEnumerator AITurn(){
		
		yield return new WaitForSeconds(2);
		player2CardPreviewZone.GetComponent<AIController>().GetCards();
        if (gameObject.GetComponent<DragObjectWithMouse>()) {
            if (gameObject.GetComponent<DragObjectWithMouse>() == null) {
                if (gameObject.GetComponent<Player1SnapCardToSlot>()) {
                    Destroy(gameObject.GetComponent<Player1SnapCardToSlot>());
                }
            }
        }
		
	}
	
	
	
	
	
	
}


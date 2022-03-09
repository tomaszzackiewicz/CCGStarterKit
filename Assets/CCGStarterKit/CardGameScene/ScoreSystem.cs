using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using TMPro;

public class ScoreSystem : MonoBehaviour {
	
	//public Text totalScore;
	public TextMeshProUGUI attackValueScore;
	//public Text battlefieldRowPositionScore;
	//public Text generalCardAbilityScore;
	
	public TextMeshProUGUI attackValueScoreRow1;
	public TextMeshProUGUI attackValueScoreRow2;
	public TextMeshProUGUI attackValueScoreRow3;
	
	//public int total;
	public int attackValue;
	//public int battlefieldRowPosition;
	//public int generalCardAbility;
	
	public int attackValueRow1;
	public int attackValueRow2;
	public int attackValueRow3;
	
	//public Text AItotalScore;
	public TextMeshProUGUI AIattackValueScore;
	//public Text AIbattlefieldRowPositionScore;
	//public Text AIgeneralCardAbilityScore;
	
	public TextMeshProUGUI AIattackValueScoreRow1;
	public TextMeshProUGUI AIattackValueScoreRow2;
	public TextMeshProUGUI AIattackValueScoreRow3;
	
	//public int AItotal;
	public int AIattackValue;
	//public int AIbattlefieldRowPosition;
	//public int AIgeneralCardAbility;
	
	public int AIattackValueRow1;
	public int AIattackValueRow2;
	public int AIattackValueRow3;
	
	private Image image;
	//public Sprite sprite;
	private GameObject winnerUI;
	private GameObject loserUI;
	private GameObject player1CardZone1;
	private GameObject aiCardZone1;
	public int player1Int;
	public int aiInt;
	
	void Awake(){
		winnerUI = GameObject.Find("WinnerUI");
		loserUI = GameObject.Find("LoserUI");
		
	}

	// Use this for initialization
	void Start () {
		
		//total = 0;
		attackValue = 0;
		//battlefieldRowPosition = 0;
		//generalCardAbility = 0;
		
		//AItotal = 0;
		AIattackValue = 0;
		//AIbattlefieldRowPosition = 0;
		//AIgeneralCardAbility = 0;
		
		GameScore();
		AIGameScore();
		
		if(winnerUI){
			winnerUI.SetActive(false);
		}
		if(loserUI){
			loserUI.SetActive(false);
		}
		
		
		
		//image.sprite = sprite;
		//image.rectTransform.localScale = new Vector3(2,2,0);
		//image.rectTransform.position = new Vector3(0.0f,0.0f,0.0f);
		//image.rectTransform.anchoredPosition = new Vector2(0,0);
	
	}
	
	// Update is called once per frame
	void Update () {
		GameScore();
		AIGameScore();
		//print(aiInt);
		
		//if(Input.GetKeyDown(KeyCode.O)){
		//if( player1Int == 10 && aiInt == 10){
			
		//}
		//}
		
		if(Input.GetKeyDown(KeyCode.Escape)){
			winnerUI.SetActive(false);
			loserUI.SetActive(false);
			
			SceneManager.LoadScene("CardGame");
			
			//total = 0;
			attackValue = 0;
			//battlefieldRowPosition = 0;
			//generalCardAbility = 0;
			
			//AItotal = 0;
			AIattackValue = 0;
			//AIbattlefieldRowPosition = 0;
			//AIgeneralCardAbility = 0;
		}
		
	}
	
	
	void GameScore(){
		//totalScore.text = "Total: " + total.ToString();
		attackValueScore.text = attackValue.ToString();
		//battlefieldRowPositionScore.text = "Position: " + battlefieldRowPosition.ToString();
		//generalCardAbilityScore.text = "Ability: " + generalCardAbility.ToString();
		
		attackValueScoreRow1.text = attackValueRow1.ToString();
		attackValueScoreRow2.text = attackValueRow2.ToString();
		attackValueScoreRow3.text = attackValueRow3.ToString();
	}
	
	void AIGameScore(){
		//AItotalScore.text = "Total: " + AItotal.ToString();
		AIattackValueScore.text = AIattackValue.ToString();
		//AIbattlefieldRowPositionScore.text = "Position: " + AIbattlefieldRowPosition.ToString();
		//AIgeneralCardAbilityScore.text = "Ability: " + AIgeneralCardAbility.ToString();
		
		AIattackValueScoreRow1.text = AIattackValueRow1.ToString();
		AIattackValueScoreRow2.text = AIattackValueRow2.ToString();
		AIattackValueScoreRow3.text = AIattackValueRow3.ToString();
	}
	
	public void ResetGame(){
        WhoIsWinner();

        StartCoroutine(LoadSceneCor());	
		
	}

    IEnumerator LoadSceneCor() {
        yield return new WaitForSeconds(5.0f);

        SceneManager.LoadScene("CardGame");
        winnerUI.SetActive(false);
        loserUI.SetActive(false);
        //total = 0;
        attackValue = 0;
        //battlefieldRowPosition = 0;
        //generalCardAbility = 0;

        //AItotal = 0;
        AIattackValue = 0;
        //AIbattlefieldRowPosition = 0;
        //AIgeneralCardAbility = 0;
    }

    void WhoIsWinner() {
        if (attackValue > AIattackValue) {
            if (winnerUI) {
                winnerUI.SetActive(true);
                loserUI.SetActive(false);
            }
        } else {
            if (loserUI) {
                winnerUI.SetActive(false);
                loserUI.SetActive(true);

            }

        }
    }
}

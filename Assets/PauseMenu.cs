using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour {
	
	public int FPS { get; private set; }
	
	private float startTime = 0.1f;
	private int tris = 0;
	private int verts = 0;
	private float savedTimeScale;
	private GameObject pauseFilter;
	 
	private Color lowFPSColor = Color.red;
	private Color averageFPSColor = Color.yellow;
	private Color highFPSColor = Color.green;
	 
	private int lowFPS = 30;
	private int highFPS = 50;
	 
	private string url = "unity.html";
	 
	private Color statColor = Color.yellow;
	
	private bool togglePauseMenu;
	
	private GameObject pauseMenu;
	
	public GameObject rankingDBPanel;
	
	public GameObject deviceInfoPanel;
	public GameObject graphics;
	public GameObject processorName;
	public GameObject memorySize;
	public GameObject platform;
	public GameObject deviceModel;
	public GameObject unityPlayerVersionText;
	public GameObject productName;
	
	public GameObject qualityPanel;
	public GameObject graphicsQualityLevel;
	
	public GameObject gameStatsInfoPanel;
	public GameObject fpsInfo;
	public GameObject trisInfo;
	public GameObject vertsInfo;
	
	public GameObject inputPanel;
	public GameObject inputDescription;
	
	public GameObject companyInfoPanel;
	public GameObject companyDescription;
	
	public GameObject creditsInfoPanel;
	public GameObject creditsInfo;
	
	public GameObject licenseInfoPanel;
	public GameObject licenseInfo;
	
	public GameObject helpPanel;
	public GameObject helpDocumentation;
	
	void Awake(){
		
		pauseMenu = GameObject.Find("PauseMenu");
		
		//rankingDBPanel = GameObject.Find("RankingDBPanel");
		//deviceInfoPanel = GameObject.Find("DeviceInfoPanel");
		//qualityPanel = GameObject.Find("QualityPanel");
		//gameStatsInfoPanel = GameObject.Find("GameStatsInfoPanel");
		//companyInfoPanel = GameObject.Find("CompanyInfoPanel");
		//inputPanel = GameObject.Find("InputPanel");
		//creditsInfoPanel = GameObject.Find("CreditsInfoPanel");
		//licenseInfoPanel = GameObject.Find("LicenseInfoPanel");
		//helpPanel = GameObject.Find("HelpPanel");
		
		
	}

	 // Use this for initialization
	void Start () {
		
		togglePauseMenu = false;
		if(pauseMenu){
			pauseMenu.SetActive(false);
		}
		
		Time.timeScale = 1.0f;
		//deviceModel = GameObject.Find("DeviceModel");
		//graphics = GameObject.Find("Graphics");
		//processorName = GameObject.Find("ProcessorName");
		//memorySize = GameObject.Find("MemorySize");
		//platform = GameObject.Find("Platform");
		//unityPlayerVersionText = GameObject.Find("UnityPlayerVersionText");
		//productName = GameObject.Find("ProductName");
		
		
		//graphicsQualityLevel = GameObject.Find("GraphicsQualityLevel");
		
		
		//fpsInfo = GameObject.Find("FPS");
		//trisInfo = GameObject.Find("Tris");
		//vertsInfo = GameObject.Find("Verts");
		
		
		//inputDescription = GameObject.Find("InputDescription");
		
		
		//companyDescription = GameObject.Find("CompanyDescription");
		
		
		//creditsInfo = GameObject.Find("CreditsInfo");
		
		
		//licenseInfo = GameObject.Find("LicenseInfo");
		
		
		//helpDocumentation = GameObject.Find("HelpDocumentation");
		
		rankingDBPanel.SetActive(false);
		deviceInfoPanel.SetActive(false);
		qualityPanel.SetActive(false);
		gameStatsInfoPanel.SetActive(false);
		inputPanel.SetActive(false);
		companyInfoPanel.SetActive(false);
		creditsInfoPanel.SetActive(false);
		licenseInfoPanel.SetActive(false);
		helpPanel.SetActive(false);
		
		
		ChangeQualityLevel();
		
	}
	
	
	// Update is called once per frame
	void Update(){
		
		FPS = (int)(1f / Time.unscaledDeltaTime);
  
		if (Input.GetKeyDown(KeyCode.M)){
			
			togglePauseMenu = !togglePauseMenu;
			
		}
		
		if(togglePauseMenu){
			if(pauseMenu){
				pauseMenu.SetActive(true);
			}
			//Time.timeScale = 1.0f;
			//savedTimeScale = Time.timeScale;
			Time.timeScale = 0.0f;
			AudioListener.pause = true;
			if (pauseFilter){
				pauseFilter.SetActive(true);
			} 
			
		}else{
			if(pauseMenu){
				pauseMenu.SetActive(false);
			}
			//Time.timeScale = savedTimeScale;
			Time.timeScale = 1.0f;
			AudioListener.pause = false;
			if (pauseFilter) {
				pauseFilter.SetActive(true);
			}
			
		}

	}
	
	
	public void ShowRankingInfoPanel(){
		
		rankingDBPanel.SetActive(true);
		deviceInfoPanel.SetActive(false);
		qualityPanel.SetActive(false);
		gameStatsInfoPanel.SetActive(false);
		inputPanel.SetActive(false);
		companyInfoPanel.SetActive(false);
		creditsInfoPanel.SetActive(false);
		licenseInfoPanel.SetActive(false);
		helpPanel.SetActive(false);
		
	}
	 
	public void ShowDeviceInfoPanel() {
		
		rankingDBPanel.SetActive(false);
		deviceInfoPanel.SetActive(true);
		qualityPanel.SetActive(false);
		gameStatsInfoPanel.SetActive(false);
		inputPanel.SetActive(false);
		companyInfoPanel.SetActive(false);
		creditsInfoPanel.SetActive(false);
		licenseInfoPanel.SetActive(false);
		helpPanel.SetActive(false);
		
		deviceModel.GetComponent<Text>().text = "Device Mode: "+SystemInfo.deviceModel+" "+"Device Name: "+SystemInfo.deviceName+" "+"Device Type: "+SystemInfo.deviceType;
		
		graphics.GetComponent<Text>().text = "Graphics: "+SystemInfo.graphicsDeviceName+" "+ SystemInfo.graphicsMemorySize+"MB "+SystemInfo.graphicsDeviceVersion+" "+SystemInfo.graphicsDeviceVendor+" "+"Graphics MultiThreaded: "+SystemInfo.graphicsMultiThreaded;
		
		processorName.GetComponent<Text>().text = "Processor name: "+SystemInfo.processorType+" "+SystemInfo.processorFrequency+" "+"Number of processors: "+SystemInfo.processorCount;
		
		memorySize.GetComponent<Text>().text = "Memory size: "+(SystemInfo.systemMemorySize) / 1000.0f+"GB";
		
		platform.GetComponent<Text>().text = "Platform: "+Application.platform;
		
		unityPlayerVersionText.GetComponent<Text>().text = "Unity player version: "+Application.unityVersion;
		
		productName.GetComponent<Text>().text = "Product name: "+Application.productName;
		
	}
	
	public void ShowQualityPanel(){
		
		rankingDBPanel.SetActive(false);
		deviceInfoPanel.SetActive(false);
		qualityPanel.SetActive(true);
		gameStatsInfoPanel.SetActive(false);
		inputPanel.SetActive(false);
		companyInfoPanel.SetActive(false);
		creditsInfoPanel.SetActive(false);
		licenseInfoPanel.SetActive(false);
		helpPanel.SetActive(false);
		
	}
	
	void ChangeQualityLevel(){
		graphicsQualityLevel.GetComponent<Text>().text = QualitySettings.names[QualitySettings.GetQualityLevel()];
	}
	 
	public void QualityGraphicsIncrease() {
		
		QualitySettings.IncreaseLevel();
		ChangeQualityLevel();
	}
	
	public void QualityGraphicsDecrease() {
		
		QualitySettings.DecreaseLevel();
		ChangeQualityLevel();
	}
	 
	public void ShowGameStatsPanel() {
		
		rankingDBPanel.SetActive(false);
		deviceInfoPanel.SetActive(false);
		qualityPanel.SetActive(false);
		gameStatsInfoPanel.SetActive(true);
		inputPanel.SetActive(false);
		companyInfoPanel.SetActive(false);
		creditsInfoPanel.SetActive(false);
		licenseInfoPanel.SetActive(false);
		helpPanel.SetActive(false);
		
		
		string fpsString = FPS.ToString ("#,##0 fps");
		
		if(FPS < lowFPS){
			
			Text text = (Text)fpsInfo.GetComponent<Text>();
			text.color = lowFPSColor;
			fpsInfo.GetComponent<Text>().text = fpsString;
			
		}else if(FPS > highFPS){
			
			Text text = (Text)fpsInfo.GetComponent<Text>();
			text.color = highFPSColor;
			fpsInfo.GetComponent<Text>().text = fpsString;
			
		}else{
			
			Text text = (Text)fpsInfo.GetComponent<Text>();
			text.color = averageFPSColor;
			fpsInfo.GetComponent<Text>().text = fpsString;
			
		}
	
		GetObjectStats();
	
		trisInfo.GetComponent<Text>().text = tris + " tris";
	
		vertsInfo.GetComponent<Text>().text = verts + " vertex";
		
	}
	 
	void GetObjectStats() {
		verts = 0;
		tris = 0;
		GameObject[] ob = FindObjectsOfType(typeof(GameObject)) as GameObject[];
		foreach(GameObject obj in ob) {
			GetObjectStats(obj);
		}
	}
	 
	void GetObjectStats(GameObject obj) {
		Component[] filters;
		filters = obj.GetComponentsInChildren<MeshFilter>();
		foreach( MeshFilter f in filters ){
			tris += f.sharedMesh.triangles.Length/3;
			verts += f.sharedMesh.vertexCount;
		}
	}

	public void ShowInputInfoPanel(){
		
		rankingDBPanel.SetActive(false);
		deviceInfoPanel.SetActive(false);
		qualityPanel.SetActive(false);
		gameStatsInfoPanel.SetActive(false);
		inputPanel.SetActive(true);
		companyInfoPanel.SetActive(false);
		creditsInfoPanel.SetActive(false);
		licenseInfoPanel.SetActive(false);
		helpPanel.SetActive(false);
		

		inputDescription.GetComponent<Text>().text = "KEYS AND BUTTONS" +
		"\n\n\n" +
		"ALL SCENES" +
		"\n\n" +
		"\n Q : Quit game" +
		"\n X : Go to another scene (loading splashscreen)" +
		"\n M : Show/Hide Pause menu splashscreen)" +
		"\n\n" +
		"BATTLEFIELD SCENE" +
		"\n\n" +
		"\n Left Mouse Button : Drag cards" +
		"\n Esc : Reset game" +
		"\n Right Mouse Button : Redraw Card" +
		"\n 1 : Full View Camera" +
		"\n 2 : Player1 View Camera" +
		"\n 3 : Perspective View Camera" +
		"\n" +
		"\n Perspective View Camera Navigation" +
		"\n" +
		"\n Up Arrow : Zoom In" +
		"\n Down Arrow : Zoom Out" +
		"\n Right Arrow : Move Camera Rightwards" +
		"\n Left Arrow : Move Camera Leftwards" +
		"\n Scroll Wheel : Camera inclination" +
		"\n Middle Mouse Button : Reset Perspective View Camera" +
		"\n\n" +
		"DECKBUILDER SCENE" +
		"\n\n" +
		"\n Drag Left Mouse Button : Scroll Card Collection" +
		"\n Scroll Wheel : Scroll Card Collection" +
		"\n" +
		"\n Down Arrow : Stop Automatic Scrolling" +
		"\n Right Arrow : Automatic Scrolling rightwards" +
		"\n Left Arrow : Automatic Scrolling leftwards" +
		"\n" +
		"\n Double Left Mouse Button : Spawn cards to the deck" +
		"\n Right Mouse Button : Delete cards from the deck in Edit mode" +
		"\n" +
		"\n Scroll Wheel : Scroll the Deck Camera to see all the cards in the deck" +
		"\n A/D : Scroll the Deck Camera to see all the cards in the deck";
	}
	
	public void ShowCompanyInfoPanel(){
		
		rankingDBPanel.SetActive(false);
		deviceInfoPanel.SetActive(false);
		qualityPanel.SetActive(false);
		gameStatsInfoPanel.SetActive(false);
		inputPanel.SetActive(false);
		companyInfoPanel.SetActive(true);
		creditsInfoPanel.SetActive(false);
		licenseInfoPanel.SetActive(false);
		helpPanel.SetActive(false);
		
		
		companyDescription.GetComponent<Text>().text = "CAERWENT";
		
	}
	
	public void ShowCreditsInfoPanel(){
		
		rankingDBPanel.SetActive(false);
		deviceInfoPanel.SetActive(false);
		qualityPanel.SetActive(false);
		gameStatsInfoPanel.SetActive(false);
		inputPanel.SetActive(false);
		companyInfoPanel.SetActive(false);
		creditsInfoPanel.SetActive(true);
		licenseInfoPanel.SetActive(false);
		helpPanel.SetActive(false);
		
		creditsInfo.GetComponent<Text>().text = "CAERWENT DEVELOPERS" +
		"\n\n\n" +
		"Simone Salvini" +
		"\n" +
		"Tomasz Zackiewicz";
		
	}
	
	public void ShowLicensePanel(){
		
		rankingDBPanel.SetActive(false);
		deviceInfoPanel.SetActive(false);
		qualityPanel.SetActive(false);
		gameStatsInfoPanel.SetActive(false);
		inputPanel.SetActive(false);
		companyInfoPanel.SetActive(false);
		creditsInfoPanel.SetActive(false);
		licenseInfoPanel.SetActive(true);
		helpPanel.SetActive(false);
		
		licenseInfo.GetComponent<Text>().text = "CAERWENT version 1.0 License";
		
	}

	
	public void ShowHelpDocumentationPanel(){
		
		rankingDBPanel.SetActive(false);
		deviceInfoPanel.SetActive(false);
		qualityPanel.SetActive(false);
		gameStatsInfoPanel.SetActive(false);
		inputPanel.SetActive(false);
		companyInfoPanel.SetActive(false);
		creditsInfoPanel.SetActive(false);
		licenseInfoPanel.SetActive(false);
		helpPanel.SetActive(true);
		
		helpDocumentation.GetComponent<Text>().text = "CAERWENT version 1.0";
		
	}
	
	
	
}

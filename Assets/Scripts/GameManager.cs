using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Reflection;
using System;


public class GameManager : MonoBehaviour
{
	public static GameManager instance = null;
	public GameObject titleScreen;
	public GameObject introScreen;
	public GameObject menuScreen;
	public GameObject overviewScreen;
	/*
	public GameObject financialsScreen;
	public GameObject militaryScreen;
	public GameObject developmentScreen;
	public GameObject educationScreen;
	public GameObject entertainmentScreen;
	public GameObject affairsScreen;
	public GameObject demographicsScreen;
	*/

	private void Start()
	{
		if (instance == null)
		{
			instance = this;
			PreloadScreens();
		}
		else if (instance != this)
		{
			Destroy(gameObject);
		}

		DontDestroyOnLoad(gameObject);
		LoadTitleScreen();
	}

	private void Update()
	{

	}


	private void PreloadScreens()
	{
		titleScreen = Instantiate(titleScreen, new Vector3(0, 0, 0), Quaternion.identity);
		titleScreen.SetActive(false);

		introScreen = Instantiate(introScreen, new Vector3(0, 0, 0), Quaternion.identity);
		introScreen.SetActive(false);

		menuScreen = Instantiate(menuScreen, new Vector3(0, 0, 0), Quaternion.identity);
		menuScreen.SetActive(false);

		overviewScreen = Instantiate(overviewScreen, new Vector3(0, 0, 0), Quaternion.identity);
		overviewScreen.SetActive(false);
		/*
		financialsScreen = Instantiate(financialsScreen, new Vector3(0, 0, 0), Quaternion.identity);
		financialsScreen.SetActive(false);

		militaryScreen = Instantiate(militaryScreen, new Vector3(0, 0, 0), Quaternion.identity);
		militaryScreen.SetActive(false);

		developmentScreen = Instantiate(developmentScreen, new Vector3(0, 0, 0), Quaternion.identity);
		developmentScreen.SetActive(false);

		educationScreen = Instantiate(educationScreen, new Vector3(0, 0, 0), Quaternion.identity);
		educationScreen.SetActive(false);

		entertainmentScreen = Instantiate(entertainmentScreen, new Vector3(0, 0, 0), Quaternion.identity);
		entertainmentScreen.SetActive(false);

		affairsScreen = Instantiate(affairsScreen, new Vector3(0, 0, 0), Quaternion.identity);
		affairsScreen.SetActive(false);

		demographicsScreen = Instantiate(demographicsScreen, new Vector3(0, 0, 0), Quaternion.identity);
		demographicsScreen.SetActive(false);
		*/
	}

	private void LoadTitleScreen()
	{
		titleScreen.SetActive(true);
		titleScreen.GetComponentInChildren<Canvas>().GetComponentInChildren<Button>().onClick.AddListener(StartClick);
	}
	private void LoadIntroScreen()
	{
		introScreen.SetActive(true);
		introScreen.GetComponentInChildren<Canvas>().GetComponentInChildren<Button>().onClick.AddListener(ContinueClick);
	}
	private void LoadMenuScreen()
	{
		menuScreen.SetActive(true);
		Button[] buttons = menuScreen.GetComponentInChildren<Canvas>().GetComponentsInChildren<Button>();

		foreach (Button button in buttons)
		{
			button.onClick.AddListener(OverviewClick);
		}

		//buttons[0].onClick.AddListener(OverviewClick);
	}
	private void LoadOverviewScreen()
	{
		overviewScreen.SetActive(true);
	}
	/*
	private void LoadFinancialsScreen()
	{
		financialsScreen.SetActive(true);
	}
	private void LoadMilitaryScreen()
	{
		militaryScreen.SetActive(true);
	}
	private void LoadDevelopmentScreen()
	{
		developmentScreen.SetActive(true);
	}
	private void LoadEducationScreen()
	{
		educationScreen.SetActive(true);
	}
	private void LoadEntertainmentScreen()
	{
		entertainmentScreen.SetActive(true);
	}
	private void LoadAffairsScreen()
	{
		affairsScreen.SetActive(true);
	}
	private void LoadDemographicsScreen()
	{
		demographicsScreen.SetActive(true);
	}
	*/

	private void StartClick()
	{
		titleScreen.SetActive(false);
		LoadIntroScreen();
	}
	private void ContinueClick()
	{
		introScreen.SetActive(false);
		LoadMenuScreen();
	}
	private void OverviewClick()
	{
		LoadOverviewScreen();
	}
	private void FinancialsClick()
	{
		//LoadFinancialsScreen();
	}
	/*
	private void MilitaryClick()
	{
		LoadMilitaryScreen();
	}
	private void DevelopmentClick()
	{
		LoadDevelopmentScreen();
	}
	private void EducationClick()
	{
		LoadEducationScreen();
	}
	private void EntertianmentClick()
	{
		LoadEntertainmentScreen();
	}
	private void AffairsClick()
	{
		LoadAffairsScreen();
	}
	private void DemographicsClick()
	{
		LoadDemographicsScreen();
	}
	*/

}

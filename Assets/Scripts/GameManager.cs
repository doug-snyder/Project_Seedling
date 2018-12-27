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
	public GameObject oviewScreen;
	
	//public GameObject financialsScreen;
	//public GameObject militaryScreen;
	//public GameObject developmentScreen;
	//public GameObject educationScreen;
	//public GameObject entertainmentScreen;
	//public GameObject affairsScreen;
	//public GameObject demographicsScreen;
	
    
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

		oviewScreen = Instantiate(oviewScreen, new Vector3(0, 0, 0), Quaternion.identity);
		oviewScreen.SetActive(false);
	}

	private void LoadTitleScreen()
	{
		titleScreen.SetActive(true);
		titleScreen.GetComponentInChildren<Canvas>()
				.GetComponentInChildren<Button>().onClick.AddListener(StartClick);
	}

	private void LoadIntroScreen()
	{
		introScreen.SetActive(true);
		introScreen.GetComponentInChildren<Canvas>()
				.GetComponentInChildren<Button>().onClick.AddListener(ContinueClick);
	}

	private void LoadMenuScreen()
	{
		menuScreen.SetActive(true);
		Button[] buttons
				= menuScreen.GetComponentInChildren<Canvas>().GetComponentsInChildren<Button>();

		foreach (Button button in buttons)
		{
			button.onClick.AddListener(OverviewClick);
		}
	}

	private void LoadOviewScreen()
	{
		oviewScreen.SetActive(true);
	}

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
		LoadOviewScreen();
	}

}

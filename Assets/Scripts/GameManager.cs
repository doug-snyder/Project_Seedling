using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
	public static GameManager instance = null;
	public GameObject titleScreen;
	public GameObject introScreen;
	public GameObject overviewScreen;


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
		introScreen = Instantiate(introScreen, new Vector3(0, 0, 0), Quaternion.identity);
		overviewScreen = Instantiate(overviewScreen, new Vector3(0, 0, 0), Quaternion.identity);
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

	private void LoadOverviewScreen()
	{
		overviewScreen.SetActive(true);
	}


	private void StartClick()
	{
		titleScreen.SetActive(false);
		LoadIntroScreen();
	}

	private void ContinueClick()
	{
		introScreen.SetActive(false);
		LoadOverviewScreen();
	}

}

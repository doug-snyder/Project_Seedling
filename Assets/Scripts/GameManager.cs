using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
	public static GameManager instance = null;
	public string screenToLoad = "Title";
	public GameObject titleScreen;
	public GameObject introScreen;


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
	}

	private void OnLevelFinishedLoading(Scene scene, LoadSceneMode mode)
	{
		if (screenToLoad.Equals("Title"))
		{
			LoadTitleScreen();
		}
	}
	private void OnEnable()
	{
		SceneManager.sceneLoaded += OnLevelFinishedLoading;
	}
	private void OnDisable()
	{
		SceneManager.sceneLoaded -= OnLevelFinishedLoading;
	}

	private void Update()
	{

	}

	private void PreloadScreens()
	{
		titleScreen = Instantiate(titleScreen, new Vector3(0, 0, 0), Quaternion.identity);
		introScreen = Instantiate(introScreen, new Vector3(0, 0, 0), Quaternion.identity);
	}

	private void LoadTitleScreen()
	{
		//if (titleScreen.)
		titleScreen.SetActive(true);
		titleScreen.GetComponentInChildren<Canvas>().GetComponentInChildren<Button>().onClick.AddListener(StartClick);
	}

	private void LoadIntroScreen()
	{
		introScreen.SetActive(true);
	}

	private void StartClick()
	{
		Debug.Log("START CLICK");
		titleScreen.SetActive(false);
		LoadIntroScreen();
	}

}

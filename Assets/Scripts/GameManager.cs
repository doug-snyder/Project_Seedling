using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
	public string screenToLoad = "Title";

	public GameObject titleScreen;

	public static GameManager instance = null;


	private void Start()
	{
		if (instance == null)
		{
			instance = this;
		}
		else if (instance != this)
		{
			Destroy(gameObject);
		}

		DontDestroyOnLoad(gameObject);

		if (screenToLoad.Equals("Title"))
		{
			LoadTitleScreen();
		}
	}

	private void OnLevelFinishedLoading(Scene scene, LoadSceneMode mode)
	{

	}
	private void OnEnable()
	{
		SceneManager.sceneLoaded += OnLevelFinishedLoading;
	}
	private void OnDisable()
	{
		SceneManager.sceneLoaded -= OnLevelFinishedLoading;
	}

	private void LoadTitleScreen()
	{
		Instantiate(titleScreen, new Vector3(0, 0, 0), Quaternion.identity);
		Button startGameButton = FindObjectOfType<Button>();
		startGameButton.enabled = true;
		startGameButton.onClick.AddListener(StartClick);
	}

	private void Update()
	{

	}

	private void StartClick()
	{
		Debug.Log("START CLICK");
	}

}

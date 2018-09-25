using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
	[HideInInspector]
	private bool loadTitle = true;
	[HideInInspector]
	private bool loadFirstScene = false;

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
		InitGame();
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

	private void InitGame()
	{
		if (loadTitle)
		{
			GameObject.Find("TitleText").SetActive(true);
			Button startGameButton = FindObjectOfType<Button>();
			startGameButton.enabled = true;
			startGameButton.onClick.AddListener(StartClick);
			loadTitle = false;
		}
	}

	private void Update()
	{

	}

	private void StartClick()
	{
		Debug.Log("START CLICK");
		SceneManager.LoadScene("Intro", LoadSceneMode.Additive);
	}

}

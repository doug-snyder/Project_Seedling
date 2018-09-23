using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
	public static GameManager instance = null;


	private void Awake()
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
	}

	private void InitGame()
	{

	}

	private void OnLevelFinishedLoading(Scene scene, LoadSceneMode mode)
	{

	}

	private void OnEnable()
	{
		
	}
	private void OnDisable()
	{
		
	}

	private void Update()
	{
		
	}

}

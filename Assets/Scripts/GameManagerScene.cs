using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScene : MonoBehaviour
{
	public static GameManagerScene instance = null;
	
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

		StartGame();
	}

	private void StartGame()
	{
		Debug.Log("StartGame");
		SceneManager.LoadScene("Title");
	}

	private void Update(){}

}

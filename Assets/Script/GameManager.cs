using UnityEngine;

public class GameManager : MonoBehaviour
{
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

		StartGame();
	}

	private void StartGame()
	{
		Debug.Log("StartGame");
	}

}

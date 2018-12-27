using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour
{
	public void OnMouseButton()
	{
		Debug.Log("StartGame");
		SceneManager.LoadScene(name);
	}

	public void QuitGame()
	{
		Debug.Log("Quit Clicked");
		Application.Quit();
	}

}

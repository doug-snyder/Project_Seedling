using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
	public void LoadTitle()
	{
		Debug.Log("LoadTitle");
		SceneManager.LoadScene("Title");
	}

	public void LoadMainMenu()
	{
		Debug.Log("LoadMainMenu");
		SceneManager.LoadScene("MainMenu");
	}

	public void LoadOverview()
	{
		Debug.Log("LoadOverview");
		SceneManager.LoadScene("Overview");
	}

	public void LoadFinance()
	{
		Debug.Log("LoadFinance");
		SceneManager.LoadScene("Finance");
	}

}

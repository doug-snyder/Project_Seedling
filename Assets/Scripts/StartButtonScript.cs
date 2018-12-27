using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonScript : MonoBehaviour
{
	public void OnMouseButton()
	{
		Debug.Log("StartGame");
		SceneManager.LoadScene("Menu");
	}
}

using UnityEngine;


public class LoaderScene : MonoBehaviour
{
	public GameObject gameManagerScene;

	void Awake()
	{
		if (GameManagerScene.instance == null)
		{
			Instantiate(gameManagerScene);
		}
	}

}

using UnityEngine;


public class LoaderScene : MonoBehaviour
{
	public GameObject gameManagerScene;
	public DEV_NavButtons DEV_NavButtons;

	void Awake()
	{
		if (GameManagerScene.instance == null)
		{
			Instantiate(gameManagerScene);
			Instantiate(DEV_NavButtons);
		}
	}

}

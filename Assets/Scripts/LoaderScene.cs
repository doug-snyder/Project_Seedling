using UnityEngine;

public class LoaderScene : MonoBehaviour
{
	public GameObject gameManagerScene;
	public GameObject playerDataManager;

	void Awake()
	{
		if (GameManagerScene.instance == null)
		{
			Instantiate(gameManagerScene);
		}

		if (PlayerDataManager.instance == null)
		{
			Instantiate(playerDataManager);
		}
	}

}

using UnityEngine;

namespace ColdPants.ProjectSeedling
{
	public class Loader : MonoBehaviour
	{
		public GameObject gameManager;
		public GameObject dataManager;

		void Awake()
		{
			if (GameManager.instance == null)
			{
				Instantiate(gameManager);
			}

			if (DataManager.instance == null)
			{
				Instantiate(dataManager);
			}
		}

	}
}

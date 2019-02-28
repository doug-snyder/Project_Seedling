using UnityEngine;

namespace ColdPants.ProjectSeedling
{
	public class GameManager : MonoBehaviour
	{
		public static GameManager instance = null;

		#region Main
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

			StartGame();
		}
		#endregion

		#region Helpers
		private void StartGame()
		{
			Debug.Log("StartGame");
		}
		#endregion

	}
}
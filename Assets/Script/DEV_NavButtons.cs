using UnityEngine;
using UnityEngine.SceneManagement;

namespace ColdPants.ProjectSeedling
{
	public class DEV_NavButtons : MonoBehaviour
	{
		public void DEV_GoToTitlePage()
		{
			SceneManager.LoadScene("Title");
		}

	}
}

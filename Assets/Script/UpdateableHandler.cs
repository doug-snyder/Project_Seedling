using UnityEngine;

namespace ColdPants.ProjectSeedling
{
	public class UpdateableHandler : MonoBehaviour
	{

		private UpdateableText[] updateableTexts;

		#region Main
		private void Start()
		{
			updateableTexts = GetComponentsInChildren<UpdateableText>();
		}
		#endregion

		#region Helpers
		public void RefreshAll()
		{
			foreach (UpdateableText updateableText in updateableTexts)
			{

			}
		}
		#endregion

	}
}


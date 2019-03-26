using UnityEngine;

namespace ColdPants.ProjectSeedling
{
	/* This could be a system, perhaps. */

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


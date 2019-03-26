using UnityEngine;
using UnityEngine.UI;

namespace ColdPants.ProjectSeedling
{
	/* This will be a component, I guess. */

	public class UpdateableText : MonoBehaviour
	{
		public string FieldName;

		private Text fieldText;

		#region Main
		private void Start()
		{
			fieldText = gameObject.GetComponent<Text>();
		}
		#endregion

	}
}

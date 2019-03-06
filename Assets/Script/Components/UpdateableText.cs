using UnityEngine;
using UnityEngine.UI;

namespace ColdPants.ProjectSeedling
{
	public class UpdateableText : MonoBehaviour
	{
		public string FieldName;

		private Text fieldText;

		#region Main
		void Start()
		{
			fieldText = gameObject.GetComponent<Text>();
		}
		#endregion

		#region Helpers
		public void Refresh(string newValue)
		{
			fieldText.text = newValue;
		}
		#endregion

	}
}

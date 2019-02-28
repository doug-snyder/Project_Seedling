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
			GetDataByFieldName();
		}
		#endregion

		#region Helpers
		public void GetDataByFieldName()
		{
			fieldText.text = DataManager.instance.GetDataAsString(FieldName);
		}
		#endregion

	}
}

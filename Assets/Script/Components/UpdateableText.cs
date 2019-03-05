using UnityEngine;
using UnityEngine.UI;

namespace ColdPants.ProjectSeedling
{
	public class UpdateableText : MonoBehaviour
	{
		public string FieldName;

		private Text fieldText;

		#region Main
		void Awake()
		{
			fieldText = gameObject.GetComponent<Text>();
		}
		#endregion

		#region Helpers
		public void RefreshField(string newValue)
		{
			fieldText.text = newValue;
		}

		/*
		public void GetDataByFieldName()
		{
			fieldText.text = DataManager.instance.GetDataAsString(FieldName);
		}
		*/
		#endregion

	}
}

using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

namespace ColdPants.ProjectSeedling
{
	public class UpdateableText : MonoBehaviour, INotifyPropertyChanged
	{

		private string _FieldName;
		public string FieldName
		{
			get { return _FieldName; }
			private set
			{
				_FieldName = value;
	
			}
		}

		private Text fieldText;

		#region Main
		private void Start()
		{
			fieldText = gameObject.GetComponent<Text>();
		}
		#endregion

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler handler = PropertyChanged;
			if (handler != null)
			{
				handler(this, new PropertyChangedEventArgs(propertyName));
			}
		}

	}
}

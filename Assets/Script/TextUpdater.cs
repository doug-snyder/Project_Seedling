using System.ComponentModel;

namespace ColdPants.ProjectSeedling
{
	public class TextUpdater : INotifyPropertyChanged //MonoBehaviour
	{

		private string _fieldText;

		public string FieldText
		{
			get { return _fieldText; }
			private set
			{
				_fieldText = value;
				OnPropertyChanged("FieldText");
			}
		}

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
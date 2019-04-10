using System.ComponentModel;

namespace ColdPants.ProjectSeedling
{
	public class TextUpdater : INotifyPropertyChanged
	{
		private string _TaxRate;

		public event PropertyChangedEventHandler PropertyChanged;

		public string TaxRate
		{
			get { return _TaxRate; }
			private set
			{
				_TaxRate = value;
				OnPropertyChanged("TaxRate");
			}
		}

		protected virtual void OnPropertyChanged(string propertyName)
		{
			OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
		}

		protected virtual void OnPropertyChanged(PropertyChangedEventArgs args)
		{
			PropertyChangedEventHandler handler = PropertyChanged;
			if (handler != null)
			{
				handler(this, args);
			}
		}

	}
}
using UnityEngine;

namespace ColdPants.ProjectSeedling
{
	public class DataManager : MonoBehaviour
	{
		public static DataManager instance = null;

		private float gdp; //TODO: calcs for determining GDP
		private float taxRate;
		private float income;
		private float expenses;

		public string NationName = "Principality of Fuck";
		
		public float GDP
		{
			get { return gdp; }
			private set { gdp = value; }
		}

		public float TaxRate
		{
			get { return taxRate; }
			private set { taxRate = (value / 100f); }
		}

		public float Income
		{
			get { return gdp * taxRate; }
			private set { income = value; }
		}

		public float Expenses
		{
			get { return expenses; }
			//TODO: calcs for determining Expenses here
			private set { expenses = value; }
		}

		public float Revenue
		{
			get { return income - expenses; }
		}


		#region Main
		void Awake()
		{
			if (instance == null)
			{
				instance = this;
			}
			else if (instance != this)
			{
				Destroy(gameObject);
			}
			DontDestroyOnLoad(gameObject);

			InitializeData();
		}
		#endregion

		#region Helpers
		public string GetDataAsString(string s)
		{
			if (s.Equals("NationName"))
			{
				return NationName;
			}
			else if (s.Equals("TaxRate"))
			{
				return (TaxRate * 100f).ToString();
			}
			else if (s.Equals("Income"))
			{
				return Income.ToString();
			}
			else if (s.Equals("Expenses"))
			{
				return Expenses.ToString();
			}
			else if (s.Equals("Revenue"))
			{
				return Revenue.ToString();
			}

			return "";
		}

		private void InitializeData()
		{
			GDP = 2000000f;
			TaxRate = 50f;
			Expenses = 500000f;
		}
		#endregion

	}
}

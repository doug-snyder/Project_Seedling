using UnityEngine;

namespace ColdPants.ProjectSeedling
{
	public class DataManager : MonoBehaviour
	{
		public static DataManager instance = null;

		public string NationName = "Principality of Fuck";
		public float GDP; // TODO: calcs for determining GDP
		public float TaxRate;
		public float Income;
		public float Expenses;
		public float Revenue;

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
			else if (s.Equals("GDP"))
			{
				return GDP.ToString();
			}
			else if (s.Equals("TaxRate"))
			{
				return TaxRate.ToString();
			}
			else if (s.Equals("Income"))
			{
				return (GDP * (TaxRate / 100)).ToString();
			}
			else if (s.Equals("Expenses"))
			{
				return Expenses.ToString();
			}
			else if (s.Equals("Revenue"))
			{
				return (Income - Expenses).ToString();
			}

			return "MISSING FIELD";
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

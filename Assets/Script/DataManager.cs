using UnityEngine;

namespace ColdPants.ProjectSeedling
{
	public class DataManager : MonoBehaviour
	{
		public static DataManager instance = null;

		public string NationName = "Principality of Fuck";
		public float Expenses = 460000f;
		public float Income = 1000000f;
		public float Revenue;
		public float TaxRate = 50f;


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
			else if (s.Equals("Expenses"))
			{
				return Expenses.ToString();
			}
			else if (s.Equals("Income"))
			{
				return Income.ToString();
			}
			else if (s.Equals("Revenue"))
			{
				return Revenue.ToString();
			}
			else if (s.Equals("TaxRate"))
			{
				return TaxRate.ToString();
			}

			return "";
		}

		private void InitializeData()
		{
			Revenue = Income - Expenses;
		}
		#endregion

	}
}

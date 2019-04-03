using UnityEngine;

namespace ColdPants.ProjectSeedling
{
	public class DataManager : MonoBehaviour
	{

		public static DataManager instance = null;

		#region PrimaryValues
		/*
		 * TODO:
		 * calcs for determining GDP (DependentValue?)
		 * calcs for determining Expenses (DependentValue?)
		 */
		public string NationName { get; private set; }
		public float GDP { get; private set; }
		public float TaxRate { get; private set; }
		public float Expenses { get; private set; }
		#endregion

		#region DependentValues
		public float Income { get { return GDP * TaxRate; } }
		public float Revenue { get { return Income - Expenses; } }
		#endregion


		#region Main
		private void Awake()
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
		/* Temporary function */
		private void InitializeData()
		{
			NationName = "Principality of Fuck";
			GDP = 2000000f;
			TaxRate = 50f;
			Expenses = 500000f;
		}
		#endregion

	}
}

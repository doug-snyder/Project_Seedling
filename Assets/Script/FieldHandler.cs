using UnityEngine;
using UnityEngine.UI;

/**
 * Handles the retrieval of values from PlayerPrefs that are meant for display
 * as text and saves changed values back to PlayerPrefs when applicable.
 */
public class FieldHandler : MonoBehaviour
{
	[SerializeField]
	private string field;
	private Text FieldText;

	#region Main
	private void Start()
	{
		if (gameObject.GetComponent<InputField>())
		{
			FieldText = gameObject.GetComponent<InputField>().textComponent;
		}
		else
		{
			FieldText = GetComponent<Text>();
		}

		GetField();
	}
	#endregion

	#region Helpers
	private void GetField()
	{
		FieldText.text = PlayerPrefs.GetString(field);
	}

	public void SavePlayerPref()
	{
		PlayerPrefs.SetString(field, FieldText.text);
	}

	private void CalculateIncome()
	{
		// TaxRate * (MedianIncome * Population)?
	}

	private string CalculateRevenue()
	{
		float income = float.Parse(PlayerPrefs.GetString("Income"));
		float expenses = float.Parse(PlayerPrefs.GetString("Expenses"));

		return (income - expenses).ToString();
	}
	#endregion

}

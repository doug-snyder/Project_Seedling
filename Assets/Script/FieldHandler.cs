using UnityEngine;
using UnityEngine.UI;

/**
 * Handles the retrieval of values from PlayerPrefs that are meant for display
 * as text and saves changed values back to PlayerPrefs when applicable.
 */
public class FieldHandler : MonoBehaviour
{
	public string field;
	private Text text;

	#region Main
	private void Start()
	{
		if (gameObject.GetComponent<InputField>())
		{
			text = gameObject.GetComponent<InputField>().textComponent;
		}
		else
		{
			text = GetComponent<Text>();
		}

		GetField();
	}
	#endregion

	#region Helpers
	public void GetField()
	{
		text.text = PlayerPrefs.GetString(field);
	}

	public void SavePlayerPref()
	{
		PlayerPrefs.SetString(field, text.text);
	}

	public void CalculateIncome()
	{
		
	}

	public string CalculateRevenue()
	{
		float income = float.Parse(PlayerPrefs.GetString("Income"));
		float expenses = float.Parse(PlayerPrefs.GetString("Expenses"));

		return (income - expenses).ToString();
	}
	#endregion

}

using UnityEngine;
using UnityEngine.UI;

/**
 * Handles the retrieval of values from PlayerPrefs that are meant for display
 * as text and saves changed values back to PlayerPrefs when applicable.
 */
public class UpdateableHandler : MonoBehaviour
{
	private UpdateableText[] updateableTexts;

	#region Main
	private void Start()
	{
		updateableTexts = GetComponentsInChildren<UpdateableText>();
	}
	#endregion

	#region Helpers
	public void TriggerUpdateables()
	{
		foreach (UpdateableText updateableText in updateableTexts)
		{
			updateableText.UpdateText();
		}
	}

	/*
	private string CalculateRevenue()
	{
		float income = float.Parse(PlayerPrefs.GetString("Income"));
		float expenses = float.Parse(PlayerPrefs.GetString("Expenses"));

		return (income - expenses).ToString();
	}
	*/
	#endregion

}

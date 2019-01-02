using UnityEngine;

public class PlayerDataManager : MonoBehaviour
{
	public static PlayerDataManager instance = null;

    void Start()
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

		InitiateTestValues();
    }

	private void InitiateTestValues()
	{
		Debug.Log("InitiateTestValues");

		// Values that might be usable.
		PlayerPrefs.SetFloat("TaxRate", 0.05f);

		// Test-only values, probably. These
		// should be the result of calculations.
		PlayerPrefs.SetFloat("Funds", 10000000f);
		PlayerPrefs.SetFloat("Costs", 1234567f);

		//PlayerPrefs.Save();
	}

}

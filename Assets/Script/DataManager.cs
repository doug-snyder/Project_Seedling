using UnityEngine;

public class DataManager : MonoBehaviour
{
	public static DataManager instance = null;

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
	private void InitializeData()
	{
		Debug.Log("InitializeData");
	}
	#endregion

}

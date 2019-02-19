using UnityEngine;

public class DataManager : MonoBehaviour
{
	public static DataManager instance = null;

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

	private void InitializeData()
	{
		Debug.Log("InitializeData");
	}

}

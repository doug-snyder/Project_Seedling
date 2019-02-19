using UnityEngine;
using UnityEngine.UI;

public class UpdateableText : MonoBehaviour
{

	[SerializeField]
	public string FieldName;

	private Text fieldText;

	#region Main
	void Start()
    {
		fieldText = gameObject.GetComponent<Text>();
		GetPlayerPref();
    }
	#endregion
	
	#region Helpers
	public void GetPlayerPref()
	{
		fieldText.text = PlayerPrefs.GetString(FieldName);
	}
	#endregion

}

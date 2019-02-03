using UnityEngine;
using UnityEngine.UI;

public class InputFieldHandler : MonoBehaviour
{
	public string field;
	private InputField inputField;

	private void Start()
	{
		inputField = gameObject.GetComponent<InputField>();

		SetField();
	}

	public void SetField()
	{
		inputField.text = PlayerPrefs.GetString(field);
	}

	public void SaveField()
	{
		PlayerPrefs.SetString(field, inputField.text);
	}

}

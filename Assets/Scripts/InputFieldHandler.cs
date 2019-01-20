using UnityEngine;
using UnityEngine.UI;

public class InputFieldHandler : MonoBehaviour
{
	public string field;
	InputField inputField;

	private void Start()
	{
		inputField = gameObject.GetComponent<InputField>();

		inputField.text = PlayerPrefs.GetFloat(field).ToString();
	}

	public void SaveFieldAsFloat()
	{
		PlayerPrefs.SetFloat(field, float.Parse(inputField.text));

		Debug.Log(PlayerPrefs.GetFloat(field));
	}

}

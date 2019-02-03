using UnityEngine;
using UnityEngine.UI;

public class FieldHandler : MonoBehaviour
{
	public string field;
	private Text text;

	private void Start()
	{
		text = gameObject.GetComponent<Text>();

		SetField();
	}

	public void SetField()
	{
		text.text = PlayerPrefs.GetString(field);
	}

}

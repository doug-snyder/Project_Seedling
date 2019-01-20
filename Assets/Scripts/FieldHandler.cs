using UnityEngine;
using UnityEngine.UI;

public class FieldHandler : MonoBehaviour
{
	public string field;    

    void Start()
    {
		Text text = gameObject.GetComponent<Text>();
		text.text = PlayerPrefs.GetFloat(field).ToString();
    }

}

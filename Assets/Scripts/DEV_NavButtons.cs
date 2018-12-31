using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DEV_NavButtons : MonoBehaviour
{
	public static DEV_NavButtons instance = null;

	private void Start()
	{
		if (instance == null)
		{
			instance = this;
		}
		else if (instance != null)
		{
			Destroy(gameObject);
		}
		DontDestroyOnLoad(gameObject);
	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class GenStringChange : MonoBehaviour
{
	public Text text;
	int SelectedGender;

	void Start()
	{

	}

    void Update()
	{
		SelectedGender = MoveCarsorSettings.getGender();
		switch (SelectedGender)
		{
			case 0:
			text.text = "男";
			break;

			case 1:
			text.text = "女";
			break;

			case 2:
			text.text = "他";
			break;

		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingInput : MonoBehaviour
{
	InputField InputField;
	public string TempName;

	private RectTransform rect;
	// Start is called before the first frame update
	void Start()
	{
		rect = GetComponent<RectTransform>();

		InputField = GetComponent<InputField>();
		FormatInputField();
	}

	void Update()
	{
		if(Input.GetKeyDown (KeyCode.Return))
		{
			string InputName = InputField.text;
			int Length = InputName.Length;
			if (InputName == "")
			{
				TempName = "エラー：名前を入力してください　　　　　　　　　　　　";
			}
			else if(Length > 16)
			{
				TempName = "エラー：16文字を超えています(" + Length + "文字)";
			}
			else
			{
				TempName = InputName;
			}
			FormatInputField();
		}
	}	

	/*public void InputAndEnter()
	{
		string InputName = InputField.text;
		int Length = InputName.Length;
		if (InputName == "")
		{
			TempName = "エラー：名前を入力してください";
		}
		else if(Length > 16)
		{
			TempName = "エラー：16文字を超えています(" + Length + "文字)";
		}
		else
		{
			TempName = InputName;
		}
		FormatInputField();
	}*/

	void FormatInputField()
	{
		InputField.text = "";
		InputField.ActivateInputField();
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FeedbackInput : MonoBehaviour
{
 	InputField InputField;
	public string InputString;
	// Start is called before the first frame update
	void Start()
	{
		InputField = GetComponent<InputField>();
	}

	void Update()
	{
		
	}	

	public void InputAndEnter()
	{
		string InputString = InputField.text;
	}
}

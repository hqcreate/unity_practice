using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class LigValueChange : MonoBehaviour
{
	public Text text;
	int SelectedLight;

	void Start()
	{

	}

    void Update()
	{
		string SelectedLight = MoveCarsorSettings.getLight().ToString();
		text.text = SelectedLight + "%";

	}
}
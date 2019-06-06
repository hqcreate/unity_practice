using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class VolValueChange : MonoBehaviour
{
	public Text text;
	string SelectedVolume;

	void Start()
	{

	}

    void Update()
	{
		SelectedVolume = MoveCarsorSettings.getVolume().ToString();
		text.text = SelectedVolume + "%";

	}
}
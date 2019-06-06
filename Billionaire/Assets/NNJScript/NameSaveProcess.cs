using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NameSaveProcess : MonoBehaviour
{
	GameObject SettingInput;
	SettingInput script;
	// Start is called before the first frame update
	void Start()
	{
		SettingInput = GameObject.Find("InputField");
        script = SettingInput.GetComponent<SettingInput>();
	}

	// Update is called once per frame
	void Update()
	{
		
	}

	public void OnClick()
	{
		string DeterminedName = MoveCarsorSettings.getPlayerName();
		string TempName = script.TempName;
		int Length = TempName.Length;
		if (Length >= 1 && Length < 17)
		{
			DeterminedName = TempName;
			SceneManager.LoadScene ("Settings");
		}
	}
}

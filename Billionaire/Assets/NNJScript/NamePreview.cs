using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NamePreview : MonoBehaviour
{
	GameObject SettingInput;
	SettingInput script;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
    	SettingInput = GameObject.Find("InputField");
        script = SettingInput.GetComponent<SettingInput>();
    }

    // Update is called once per frame
    void Update()
    {
     	string Preview = script.TempName;
     	text.text = "変更後の名前：" + Preview;
    }
}

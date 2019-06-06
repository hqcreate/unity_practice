using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsDescription : MonoBehaviour
{
	GameObject MoveCarsorSettings;
	MoveCarsorSettings script;
	public Text text;

	void Start()
	{
		MoveCarsorSettings = GameObject.Find("Icon");
		script = MoveCarsorSettings.GetComponent<MoveCarsorSettings>();
	}

	// Update is called once per frame
	void Update()
	{
		float nowCarsor = script.OptionKey;

		switch(nowCarsor)
		{
			case(0):
			text.text = "性別を変更します。\r\n左右移動キーで変更！";
			break;

			case(1):
			text.text = "ゲーム音量を変更します。\r\n左右移動キーで変更！";
			break;

			case(2):
			text.text = "画面の明るさを変更します。\r\n左右移動キーで変更！";
			break;

			case(3):
			text.text = "プレイヤー名を変更します。\r\nエンターキーで変更画面に移動！";
			break;

			case(4):
			text.text = "タイトルへ戻ります。";
			break;
		}

	}
}

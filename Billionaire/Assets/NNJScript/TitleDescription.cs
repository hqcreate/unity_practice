using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleDescription : MonoBehaviour
{
	GameObject MoveCarsor;
	MoveCarsor script;
	public Text text;

	void Start()
	{
		MoveCarsor = GameObject.Find("Icon");
		script = MoveCarsor.GetComponent<MoveCarsor>();
	}

	// Update is called once per frame
	void Update()
	{
		float nowCarsor = script.TitleKey;
		Debug.Log("ssssssss");
		switch(nowCarsor)
		{
			case(0):
			text.text = "ゲームを開始します。";
			break;

			case(1):
			text.text = "いろいろな設定をします";
			break;

			case(2):
			text.text = "ご意見ご感想はこちらへ。";
			break;

			case(3):
			text.text = "ゲームを終了します。";
			break;
		}

	}
}

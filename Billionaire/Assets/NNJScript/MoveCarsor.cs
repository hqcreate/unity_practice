//鳥肌が立つレベルで煩雑なコード
//著者(読み:しゅはん)：はしもとしゅんすけ

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
 
public class MoveCarsor : MonoBehaviour {
 
	[SerializeField]
	//　アイコンのサイズ取得で使用
	private RectTransform rect;
	//矩形変数

	//Performance関連はいったん使用停止する
	private int TitleClickProcessing = 0;//下起動用0でオフ1でオン
	public int Performance = 0;//使用後は上ともども0に

	public float TitleKey = 0f;
	private float TitleContents = 3f;//Start,Options,Feeback,Quit

/////以下ゲーム全体で使う、使いまわすであろう変数/////
	public static int Money = 5000;
	public static int getMoney(){return Money;}//おかね

	public static int Jewels = 0;
	public static int getJewels(){return Jewels;}//ほうせき

	public static int Oil = 50;
	public static int getOil(){return Oil;}//せきゆ
/////ここまで/////

	void Start ()
	{
		rect = GetComponent<RectTransform>();
	}
 
	void Update ()
	{
		//以下二つカーソル移動
		if (Input.GetKeyDown (KeyCode.W) && TitleKey != 0)
		{
			TitleKey--;
			var pos = rect.anchoredPosition + new Vector2 (0, Screen.height/4);
			rect.anchoredPosition = pos;
		}

		if (Input.GetKeyDown (KeyCode.S) && TitleKey != TitleContents)
		{
			TitleKey++;
			var pos = rect.anchoredPosition + new Vector2 (0, -Screen.height/4);
			rect.anchoredPosition = pos;
		}


		//決定時処理
		if (Input.GetKeyDown (KeyCode.Return)　&& TitleClickProcessing == 0)
		{
			TitleClickProcessing = 1;
		}


		//テキスト移動用グロ変数のくそきたない処理操作
		if (TitleClickProcessing == 1)
		{
			Performance += 1;
		}
		if (Performance == 1)
		{
			switch(TitleKey)
			{
				case 0://Start
				SceneManager.LoadScene ("StageSelect");
				break;

				case 1://Options
				SceneManager.LoadScene ("Settings");
				break;

				case 2://Feedback
				SceneManager.LoadScene ("Feedback");
				break;

				case 3://Quit
				UnityEditor.EditorApplication.isPlaying = false;
				UnityEngine.Application.Quit();
				break;
			}
			Performance = 0;
			TitleClickProcessing = 0;
		}
	}
}	
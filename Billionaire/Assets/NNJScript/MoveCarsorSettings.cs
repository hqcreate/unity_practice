//鳥肌が立つレベルで煩雑なコード
//著者(読み:しゅはん)：はしもとしゅんすけ

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
 
public class MoveCarsorSettings : MonoBehaviour {
 
	[SerializeField]
	//　アイコンのサイズ取得で使用
	private RectTransform rect;
	//矩形変数

	//Performance関連はいったん使用停止する
	private int TitleClickProcessing = 0;//下起動用[オフ,オン]
	public int Performance = 0;//使用後は上ともども0に
	public int Inputting = 1;//[入力中,入力前処理,φ,待機中]
	public float OptionKey = 0f;
	private float OptionContents = 4f;//Gender,Volume,Light,PlayerName,Back


	public static int Gender = 0;//[man,woman,other]
	public static int getGender() {return Gender;}

	public static int Volume = 70;//0から100まで,今はBGMとSEで一括達
	public static int getVolume() {return Volume;}

	public static int Light = 70;//0から100まで
	public static int getLight() {return Light;}

	public static string PlayerName = "Player";
	public static string getPlayerName(){return PlayerName;}


	void Start ()
	{
		rect = GetComponent<RectTransform>();
	}
 
	void Update ()
	{
		//以下二つカーソル移動
		if (Input.GetKeyDown (KeyCode.W) && OptionKey != 0 && Inputting == 1)
		{
			OptionKey--;
			var pos = rect.anchoredPosition + new Vector2 (0, Screen.height/5);
			rect.anchoredPosition = pos;
		}

		if (Input.GetKeyDown (KeyCode.S) && OptionKey != OptionContents && Inputting == 1)
		{
			OptionKey++;
			var pos = rect.anchoredPosition + new Vector2 (0, -Screen.height/5);
			rect.anchoredPosition = pos;
		}


		if (Input.GetKeyDown (KeyCode.D))
		{
			if (OptionKey == 0 && Gender != 2)
			{
				Gender++;
			}
			if (OptionKey == 1 && Volume != 100)
			{
				Volume += 5;
			}
			if (OptionKey == 2 && Light != 100)
			{
				Light += 5;
			}
		}

		if (Input.GetKeyDown (KeyCode.A))
		{
			if (OptionKey == 0 && Gender != 0)
			{
				Gender--;
			}
			if (OptionKey == 1 && Volume != 0)
			{
				Volume -= 5;
			}
			if (OptionKey == 2 && Light != 0)
			{
				Light -= 5;
			}
		}


		//決定時処理
		if (Input.GetKeyDown (KeyCode.Return)　&& TitleClickProcessing == 0 && Inputting == 1)
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
			switch(OptionKey)
			{
				case 3://PlayerName
				SceneManager.LoadScene ("PlayerName");
				break;

				case 4://Back
				SceneManager.LoadScene ("Title");
				break;
			}
			Performance = 0;
			TitleClickProcessing = 0;
		}
	}
}
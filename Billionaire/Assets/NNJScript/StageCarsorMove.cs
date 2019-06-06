using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
 
public class StageCarsorMove : MonoBehaviour {
 
	[SerializeField]
	//　アイコンのサイズ取得で使用
	private RectTransform rect;
	//矩形変数

	//Performance関連はいったん使用停止する
	private int ClickProcessing = 0;//下起動用0でオフ1でオン
	public int Performance = 0;//使用後は上ともども0に
	public int DialogSwitch = 1;
	public int ConfirmOrCancel = 1;

	private float StageKey = 0f;//後の計算用にfloatで定義
	private float Stages = 2f;//0,1,2
	public int Stage1Diff = 1;
	public int Stage2Diff = 1;
	public int Stage3Diff = 1;

	void Start ()
	{
		rect = GetComponent<RectTransform>();
	}
 
	void Update ()
	{
		switch(DialogSwitch)
		{



			case 1://ダイアログが出ていないとき
			//以下二つカーソル移動
			Debug.Log("one");
			if (Input.GetKeyDown (KeyCode.W) && StageKey != 0)
			{
				StageKey--;
				var pos = rect.anchoredPosition + new Vector2 (0, Screen.height/3);
				rect.anchoredPosition = pos;
			}	

			if (Input.GetKeyDown (KeyCode.S) && StageKey != Stages)
			{
				StageKey++;
				var pos = rect.anchoredPosition + new Vector2 (0, -Screen.height/3);
				rect.anchoredPosition = pos;
			}


			if (Input.GetKeyDown (KeyCode.A) || Input.GetKeyDown (KeyCode.D))
			{
				switch(StageKey)
				{
					case 0:
					Stage1Diff *= -1;
					break;

					case 1:
					Stage2Diff *= -1;
					break;

					case 2:
					Stage3Diff *= -1;
					break;
				}
			}

			//決定時処理
			if (Input.GetKeyDown (KeyCode.Return)　&& ClickProcessing == 0)
			{
				DialogSwitch *= -1;
				ClickProcessing = 1;
			}


			//テキスト移動用グロ変数のくそきたない処理操作
			if (ClickProcessing == 1)
			{
				Performance += 1;
			}
			if (Performance == 1)
			{
				Performance = 0;
				ClickProcessing = 0;

			}
			break;

/////////ここまでUpdate中のダイアログなし挙動//////////

			case -1://ダイアログが出ているとき
			Debug.Log("two");
			if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
			{
				ConfirmOrCancel *= -1;
			}

			if (Input.GetKeyDown (KeyCode.Return))
			{
				switch(ConfirmOrCancel)
				{
					case 1://出発
					switch(StageKey)
					{
						case 0://1
						//SceneManager.LoadScene ("Stage1");
						break;

						case 1://2
						//SceneManager.LoadScene ("Stage2");
						break;

						case 2://3
						//SceneManager.LoadScene ("Stage3");
						break;
					}
					DialogSwitch *=-1;
					break;

					case -1://キャンセル
					DialogSwitch *=-1;
					break;
				}
			}
			break;
		}//switch(DialogSwitch)

	}//Updtate
}	
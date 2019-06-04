using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{

    // gameoverTextオブジェクトの入れ物
    Text gameover_text;

    // PLAYERとENEMYの接触状態を表すフラグ
    // get/setメソッドで他のスクリプトから呼び出すためprivateにしておく
    private bool enemyTouch;

    // armorTextオブジェクトの入れ物
    Text oilText;
    // PlayerStatus.csの入れ物
    Playeroil player_oil;
    // PLAYERの体力の入れ物
    private int oilPoint;


    void Start()
    {
        // PlayerStatusの取得
        player_oil = GameObject.Find("player")
          .GetComponentInChildren<Playeroil>();
        // PLAYERの体力をPlayerStatus.csのArmorPointから取得して初期化
        oilPoint = player_oil.ArmorPoint;
        // armorPointを初期化する
        oilText = GameObject.Find("armorText").GetComponent<Text>();
        oilText.text = "armorPoint : " + oilPoint.ToString();

        // UIのテキストを取得する（gameoverTextへ代入する）
        gameover_text = GameObject.Find("gameoverText").GetComponent<Text>();

        // ゲームスタート時はgameoverTextを非表示にしておく
        gameover_text.enabled = false;

        // PLAYERとENEMYの接触状態を表すフラグをfalseに初期化
        enemyTouch = false;
    }


    void Update()
    {
        // PLAYERとENEMYが接触したら
        if (enemyTouch == true)
        {
            // PLAYERの体力を更新する
            oilPoint = player_oil.ArmorPoint;
            // PLAYERの体力表示を更新する
            
        }

        if (oilPoint == 0)
        {
            // ゲームオーバー表示をするための関数を呼び出す。
            GameOverMessage();
        }
    }

    // 他のスクリプトから読み書きするための関数
    // 他のスクリプトから呼び出せるようにpublic属性を付ける
    // true/falseを呼び出し元のスクリプトへ渡すためbool型を付ける
    public bool EnemyTouch
    {
        get { return enemyTouch; }
        set { enemyTouch = value; }
    }

    void GameOverMessage()
    {
        gameover_text.enabled = true;
    }
}



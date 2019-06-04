using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playeroil : MonoBehaviour
{
  

    // PLAYERの体力
    [SerializeField] // Inspectorで確認できるように属性を付ける
    private int oilPoint;

    void Start()
    {
        // PLAYERの体力を初期化
        oilPoint = 60;
    }

    // PLAYERの体力を更新する関数
    public int ArmorPoint
    {
        get { return oilPoint; }
        set { oilPoint = value; }
    }

    // ENEMYとの接触時に動作する関数
    void OnCollisionEnter2D(Collision2D collision)
    {
        // 接触したオブジェクトがenemyのtagが付いたオブジェクトだったら
        if (collision.gameObject.tag == "Enemy")
        {
            int tmpPoint = oilPoint;
            tmpPoint = tmpPoint - 10;
            oilPoint = tmpPoint;
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LenderMoney : MonoBehaviour
{
	public Text text;
	int nowMoney;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string nowMoney = MoveCarsor.getMoney().ToString();
        text.text = "所持金：" + nowMoney + "G";
    }
}

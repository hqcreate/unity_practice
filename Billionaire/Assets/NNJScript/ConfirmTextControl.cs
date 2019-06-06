using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConfirmTextControl : MonoBehaviour
{
	GameObject CarsorMove;
	StageCarsorMove script;
    public Text text;

    void Start()
    {
        CarsorMove = GameObject.Find("Carsor_pan");
        script = CarsorMove.GetComponent<StageCarsorMove>();
    }

    void Update()
    {
        int nowDialog = script.DialogSwitch;
        int SelectedOption = script.ConfirmOrCancel;
        switch(nowDialog)
        {
        	case 1:
        	text.text = "";
        	break;

        	case -1:
        	switch(SelectedOption)
        	{
        		case 1:
  　    				text.text = "出発しますか？\r\n \r\n▶出発する　キャンセル";
        		break;

        		case -1:
        		text.text = "出発しますか？\r\n \r\n　出発する▶キャンセル";
        		break;
        	}
        	break;
        }
    }
}

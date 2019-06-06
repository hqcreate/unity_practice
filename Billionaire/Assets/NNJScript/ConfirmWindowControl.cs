using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConfirmWindowControl : MonoBehaviour
{
	GameObject CarsorMove;
	StageCarsorMove script;
    private GameObject DialogWindow;

    void Start()
    {
        CarsorMove = GameObject.Find("Carsor_pan");
        script = CarsorMove.GetComponent<StageCarsorMove>();
        this.DialogWindow = GameObject.Find("ConfirmDialog_pan");
    }

    void Update()
    {
        int nowDialog = script.DialogSwitch;
        switch(nowDialog)
        {
        	case 1:
			this.DialogWindow.GetComponent<Image>().color = new Color(0.5f, 0.5f, 0.5f, 0f);
        	break;

        	case -1:
        	this.DialogWindow.GetComponent<Image>().color = new Color(1f, 0.7f, 0f, 0.7f);
        	break;
        }
    }
}
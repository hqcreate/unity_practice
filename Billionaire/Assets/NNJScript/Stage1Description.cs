using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stage1Description : MonoBehaviour
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
        int SelectedDifficlt = script.Stage1Diff;
        switch(SelectedDifficlt)
        {
        	case 1:
        	text.text = "入場料：500G\r\n難易度：EASY";
        	break;

        	case -1:
        	text.text = "入場料：1,500G\r\n難易度：HARD";
        	break;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stage2Description : MonoBehaviour
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
        int SelectedDifficlt = script.Stage2Diff;
        switch(SelectedDifficlt)
        {
        	case 1:
        	text.text = "入場料：2,000G\r\n難易度：EASY";
        	break;

        	case -1:
        	text.text = "入場料：10,000G\r\n難易度：HARD";
        	break;
        }
    }
}

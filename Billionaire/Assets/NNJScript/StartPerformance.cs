using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPerformance : MonoBehaviour
{
	GameObject icon;
	MoveCarsor script;

	void Start ()
	{
		icon = GameObject.Find("Icon");
		script =icon.GetComponent<MoveCarsor>();
	}

    void Update ()
    {
    	int Frame = script.Performance;
    	if (Frame >= 1 && Frame <= 10)
    	{
    		Transform TextTransform = this.transform;
    		Vector3 pos = TextTransform.position;
    		pos.x += 35f;
    		TextTransform.position = pos;
    	}
    }
}

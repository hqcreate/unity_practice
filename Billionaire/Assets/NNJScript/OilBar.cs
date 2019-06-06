using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OilBar : MonoBehaviour
{
	private RectTransform rect;
	float nowOil;
	float PreviousOil;
    // Start is called before the first frame update
    void Start()
    {
        rect = GetComponent<RectTransform>();
        nowOil = MoveCarsor.getOil();
        var pos = rect.anchoredPosition + new Vector2 (0, Screen.height * nowOil / 100f);
		rect.anchoredPosition = pos;
		PreviousOil = nowOil;//Update最初のif判定用のダミー
    }

    // Update is called once per frame
    void Update()
    {
    	nowOil = MoveCarsor.getOil();

    	if(nowOil != PreviousOil)
    	{
        var pos = rect.anchoredPosition + new Vector2 (0, Screen.height * (nowOil - PreviousOil) / 100);
		rect.anchoredPosition = pos;
		}

		PreviousOil = nowOil;
    }
}

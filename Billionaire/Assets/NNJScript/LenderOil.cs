using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LenderOil : MonoBehaviour
{
	public Text text;
	int nowOil;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string nowOil = MoveCarsor.getOil().ToString();
        text.text = nowOil + " / 100";
    }
}

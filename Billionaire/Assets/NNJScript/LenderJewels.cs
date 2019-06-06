using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LenderJewels : MonoBehaviour
{
	public Text text;
	int nowJewels;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string nowJewels = MoveCarsor.getJewels().ToString();
        text.text = "x " + nowJewels;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class FeedbackSendProcess : MonoBehaviour
{
	GameObject FeedbackInput;
	FeedbackInput script;
    // Start is called before the first frame update
    void Start()
    {
        FeedbackInput = GameObject.Find("InputField");
        script = FeedbackInput.GetComponent<FeedbackInput>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClick()
    {
    	string FeedbackString = script.InputString;
    	//FeedbackStringの送信処理をこのへんで行う
    	SceneManager.LoadScene ("Title");
    }
}

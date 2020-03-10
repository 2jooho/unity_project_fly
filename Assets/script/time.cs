using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class time : MonoBehaviour {
    private float starttime;
    public  Text uitext;
    public Text result;
    private bool finnished = false;
    float t;
    string minutes; string seconds;
    // Use this for initialization
    void Start () {
        starttime = Time.time;
  
	}
	
	// Update is called once per frame
	void Update () {
        
        if (finnished)
        {
            return;
        }
        else
        {
            t = Time.time - starttime;
            minutes = ((int)t / 60).ToString();
            seconds = (t % 60).ToString("f2");

            uitext.text = "Time    " + minutes + ":" + seconds;
        }


    }
    public void finnish()
    {
        finnished = true;
        result.text = "Time    " + minutes + ":" + seconds;
    }
}

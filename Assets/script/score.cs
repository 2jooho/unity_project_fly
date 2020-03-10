using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {
    private int m_CoinCount = 0000;
    public Text m_CoinText;
    public Text result2;
    private bool finnished = false;
    void GetCoin()
    {
        // int m_CoinCount = 0;
        m_CoinCount+=100;
        m_CoinText.text = "SCORE<color=#ff0000>  " + m_CoinCount + "</color>"; 
    }
    public void finnish()
    {
        finnished = true;
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (finnished)
        {
            result2.text = "Score : " + m_CoinCount;
        }
    }
}

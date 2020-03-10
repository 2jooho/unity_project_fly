using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class helth : MonoBehaviour
{
    bool m_IsGameOver = false;
    public Slider m_HealthBarSlider;
    public GameObject parts;
    //private Transform tr;
    //public int hp = 100;
    //private int inithp;
    //public Image imghpbar;
    //Animation anim;
    public void down()
    {
        m_HealthBarSlider.value -= 0.1f;
        if (m_HealthBarSlider.value <= 0)
        {
            m_IsGameOver = true;
            GameObject.Find("Canvas").SendMessage("finnish");
            parts.SetActive(true);
        }
    }
    public void down2()
    {
        m_HealthBarSlider.value -= 0.05f;
        if (m_HealthBarSlider.value <= 0)
        {
            m_IsGameOver = true;
            GameObject.Find("Canvas").SendMessage("finnish");
            parts.SetActive(true);
        }
    }
    // Use this for initialization
    void Start()
    {

       
    }

    // Update is called once per frame
    void Update()
    {
        if (!m_IsGameOver)
        {
            transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * 100.0f, 0.0f, 0.0f);
        }
    }
   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stone : MonoBehaviour
{
    Vector3 m_TargetPos;
  
    // Use this for initialization
    void Start()
    {
        m_TargetPos = GameObject.Find("unitychan").transform.position;
        //m_TargetPos = GameObject.Find("player").transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       
        transform.position = Vector3.MoveTowards(transform.position, m_TargetPos, 4f);
        transform.Rotate(new Vector3(0.0f, 5.0f, 0.0f));
        if (transform.position == m_TargetPos)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "unitychan")
        {
            GameObject.Find("unitychan").SendMessage("down");
            Destroy(gameObject);
            
        }
    }
}

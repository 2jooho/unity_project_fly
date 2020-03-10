using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stoneclone : MonoBehaviour {
    public GameObject stoneob;
    public Transform fireposition;
    public GameObject m_stone;
    float timecont = 0.0f;
    // Use this for initialization
    void Start () {
        //InvokeRepeating("fire", 1, 10);
    }
	
	// Update is called once per frame
	void Update () {
        timecont += Time.deltaTime;
        if (timecont > 10)
        {
            Instantiate(stoneob,transform.position, Quaternion.identity);
            timecont = 0.0f;
        }
	}
     //void fire()
   // {
      //  Instantiate(stoneob, fireposition.position, fireposition.rotation);
     
  //  }
}

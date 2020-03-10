using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change : MonoBehaviour {
    public GameObject cam1;
    public GameObject cam2;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Click()
    {
        if (cam1.active = true)
        {
            cam1.active = false;
            cam2.active = true;
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailZone : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {

            // restart game : *.unity
            Application.LoadLevel("산 easy");
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        

    }
}

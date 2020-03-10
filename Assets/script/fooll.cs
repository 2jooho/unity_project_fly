using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fooll : MonoBehaviour {
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "unitychan")
        {
            GameObject.Find("unitychan").SendMessage("down2");

        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

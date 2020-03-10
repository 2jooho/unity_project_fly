using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fly : MonoBehaviour {
   
   // public Transform parachute;
    public GameObject wing;
    Animator anim;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	if(Input.GetKey(KeyCode.V))
        {
            //parachute.GetComponent<Rigidbody>().drag = 50;
            anim.SetBool("fly", true);
            transform.Translate(0,3f, 0);
            wing.active = true;
            
        }	
    else
        {
            wing.active = false;
            //parachute.GetComponent<Rigidbody>().drag = 0;
            anim.SetBool("fly", false);
        }
	}
}

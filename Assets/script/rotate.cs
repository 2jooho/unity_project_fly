using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour {
    private float h = 0.0f;
    private float v = 0.0f;
    private Transform tr;
    public float movespeed = 5.0f;
    public float rotspeed = 3.0f;
   // public Camera fpscam;
	// Use this for initialization
	void Start () {
        tr = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        Vector3 movedir = (Vector3.forward * v) + (Vector3.right * h);
         tr.Translate(movedir * Time.deltaTime * movespeed, Space.Self);
         //tr.Rotate(Vector3.up * Time.deltaTime * rotspeed * Input.GetAxis("Mouse X"));
       // rotctrl();
    }
    //void rotctrl()
   // {
       // float rotx = Input.GetAxis("Mouse Y") * rotspeed;
       // float roty = Input.GetAxis("Mouse X") * rotspeed;
        //tr.localRotation *= Quaternion.Euler(0, roty, 0);
        //fpscam.transform.localRotation *= Quaternion.Euler(-rotx, 0, 0);
   // }
}

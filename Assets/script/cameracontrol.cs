using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontrol : MonoBehaviour {
    GameObject cameraParent;
    // Use this for initialization
    void Start () {
        cameraParent = GameObject.Find("cameraParent");

    }
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetMouseButton(1))
        {
            Camera.main.transform.Rotate(0,Input.GetAxisRaw("Mouse X") * 10, Input.GetAxisRaw("Mouse Y") * 10);
            Camera.main.transform.Translate(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"), 0);


        }
        Camera.main.fieldOfView += (20 * Input.GetAxis("Mouse ScrollWheel"));
        if (Camera.main.fieldOfView < 10)
        {
            Camera.main.fieldOfView = 10;
        }
	}
}

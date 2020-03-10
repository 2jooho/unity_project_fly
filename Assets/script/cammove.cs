using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cammove : MonoBehaviour {
    public float movespeed = 5.0f;
    public float rotspeed = 3.0f;
    public Camera fpscam;
    Animator anim;

    private CharacterController characterController;
    // Use this for initialization
    void Start () {
        characterController = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        MoveCtrl();
        RotCtrl();
        if (Input.GetMouseButton(1))
        {
            Camera.main.transform.Rotate(0, Input.GetAxisRaw("Mouse X") * 10, Input.GetAxisRaw("Mouse Y") * 10);
            Camera.main.transform.Translate(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"), 0);


        }
    //    Camera.main.fieldOfView += (20 * Input.GetAxis("Mouse ScrollWheel"));
       // if (Camera.main.fieldOfView < 10)
       // {
       //     Camera.main.fieldOfView = 10;
        //}
    }
    void RotCtrl()
    {
        float rotX = Input.GetAxis("Mouse Y") * rotspeed;
        float rotY = Input.GetAxis("Mouse X") * rotspeed;
        this.transform.localRotation *= Quaternion.Euler(0, rotY, 0);
        fpscam.transform.localRotation *= Quaternion.Euler(-rotX,0, 0);
    }
    void MoveCtrl()
    {
        if (Input.GetKey(KeyCode.W))
        {
            characterController.transform.Translate(Vector3.forward * movespeed * Time.deltaTime);
            anim.SetBool("run", true);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            characterController.transform.Translate(Vector3.back * movespeed * Time.deltaTime);
            anim.SetBool("run", true);
        }

        else if (Input.GetKey(KeyCode.A))
        {
            characterController.transform.Translate(Vector3.left * movespeed * Time.deltaTime);
            anim.SetBool("run", true);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            characterController.transform.Translate(Vector3.right * movespeed * Time.deltaTime);
            anim.SetBool("run", true);
        }

        else if (Input.GetKey(KeyCode.Q))
        {
            characterController.transform.Rotate(0.0f, -90.0f * Time.deltaTime, 0.0f);
            anim.SetBool("run", true);
        }

        else if (Input.GetKey(KeyCode.E))
        {
            characterController.transform.Rotate(0.0f, 90.0f * Time.deltaTime, 0.0f);
            anim.SetBool("run", true);
        }
        else
        {
            anim.SetBool("run", false);
        }
    }
}

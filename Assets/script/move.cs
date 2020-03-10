using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
    private float h ;
    private float v ;
    private float _posY;
    // private Transform tr;
    public float movespeed = 30.0f;
    public float rotationspeed = 360f;
    Animator anim;

    private CharacterController characterController;
    // Use this for initialization
    void Start () {
      // tr = GetComponent<Transform>();
        characterController = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();

    }
	
	// Update is called once per frame
	void Update () {
        //h = Input.GetAxis("Horizontal")*rotationspeed;

        //v = Input.GetAxis("Vertical")*movespeed;
        //Vector3 movedir = (Vector3.forward * v) + (Vector3.right * h);
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
       // transform.Translate(0, -0.1f, 0);
        //tr.Translate(movedir * Time.deltaTime * movespeed, Space.Self);
        /* Vector3 movedir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

         if (movedir.sqrMagnitude > 0.01f)
         {
         Vector3 forward = Vector3.Slerp(transform.forward, movedir, rotationspeed * Time.deltaTime / Vector3.Angle(transform.forward,movedir));
         transform.LookAt(transform.position + forward);
          }
         characterController.Move(movedir * movespeed * Time.deltaTime);
        if (_posY <= 370)
        {
            if (Input.GetKey(KeyCode.V)){
                animator.SetBool("fly wait", true);
            }
        }
        if (_posY > 371)
        {
            if (Input.GetKey(KeyCode.V))
            {
                animator.SetBool("fly wait", false);
            }
        }*/
    }
}

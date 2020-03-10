using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flywait : MonoBehaviour {
    private float h;
    private float v;
    private float _posY;
    private float posy;
    // private Transform tr;
    public float movespeed = 10.0f;
    public float rotationspeed = 360f;
    Animator anim;
    public Transform parachute;
    public GameObject wing;
    private CharacterController characterController;
    // Use this for initialization
    void Start () {
    
        characterController = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
        posy= transform.position.y;
    }
	
	// Update is called once per frame
	void Update () {
        /*_posY = transform.Translate.y;
        if (0f < _posY < 370f)
       { 
          anim.SetBool("fly wait", true);
         }
        else
        {
            anim.SetBool("fly wait", false);
        }
        _posY = transform.position.y;
        if (_posY < posy)
        {
            anim.SetBool("fly wait", true);
        }
        else
        {
            anim.SetBool("fly wait", false);
        }*/
        if (Input.GetKey(KeyCode.I))
        {
            wing.active = true;
            parachute.GetComponent<Rigidbody>().drag = 50;
            characterController.transform.Translate(Vector3.forward * movespeed * Time.deltaTime);
            anim.SetBool("fly wait", true);
        }
        else if (Input.GetKey(KeyCode.K))
        {
            wing.active = true;
            parachute.GetComponent<Rigidbody>().drag = 50;
            characterController.transform.Translate(Vector3.back * movespeed * Time.deltaTime);
            anim.SetBool("fly wait", true);
        }

        else if (Input.GetKey(KeyCode.J))
        {
            wing.active = true;
            parachute.GetComponent<Rigidbody>().drag = 50;
            characterController.transform.Translate(Vector3.left * movespeed * Time.deltaTime);
            anim.SetBool("fly wait", true);
        }

        else if (Input.GetKey(KeyCode.L))
        {
            wing.active = true;
            parachute.GetComponent<Rigidbody>().drag = 50;
            characterController.transform.Translate(Vector3.right * movespeed * Time.deltaTime);
            anim.SetBool("fly wait", true);
        }
        else
        {
            wing.active = false;
            parachute.GetComponent<Rigidbody>().drag = 0;
            anim.SetBool("fly wait", false);
        }
    }

    }

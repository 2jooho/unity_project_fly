using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    private Transform _transform;
    private bool _isJumping;
    private float _posY;        
    private float _gravity;    
    private float _jumpPower;   
    private float _jumpTime;    
     Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
        _transform = transform;
        _isJumping = false;
        _posY = transform.position.y;
        _gravity = 9.8f;
        _jumpPower = 15.0f;
        _jumpTime = 0.0f;
 
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !_isJumping)
        {
            _isJumping = true;
            _posY = _transform.position.y;
            
        }
      
        if (_isJumping)
        {

            Jump();
            anim.SetBool("Jump", true);
        }
        else
        {
            anim.SetBool("Jump", false);
        }


    }

    void Jump()
    {
    
        float height = (_jumpTime * _jumpTime * (-_gravity) / 2) + (_jumpTime * _jumpPower);
        _transform.position = new Vector3(_transform.position.x, _posY + height, _transform.position.z);
   
        _jumpTime += Time.deltaTime;
       
   
        if (height < 0.0f)
        {
            _isJumping = false;
            _jumpTime = 0.0f;
            _transform.position = new Vector3(_transform.position.x, _posY, _transform.position.z);
            
        }
       
        

    }
}


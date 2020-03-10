using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class finish : MonoBehaviour {
    public GameObject parts;
    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("Canvas").SendMessage("finnish");
        parts.SetActive(true);
     
        


    }

   
    
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

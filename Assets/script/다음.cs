using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class 다음 : MonoBehaviour {
    private AudioSource hs;
    public AudioClip sound;
	// Use this for initialization
	void Start () {
        this.hs = this.gameObject.AddComponent<AudioSource>();
        this.hs.clip = this.sound;
        this.hs.loop = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Click()
    {
        this.hs.Play();
        SceneManager.LoadScene(1);
        
    }
}

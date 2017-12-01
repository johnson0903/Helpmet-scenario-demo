using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashSoundEffect : MonoBehaviour {

    AudioSource asc;
    // Use this for initialization
    void Start () {
        asc = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            asc.Play();
            print(1);
            Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
            rb.freezeRotation = false;

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableWarningZone : MonoBehaviour {
    public GameObject warningZone;
	public GameObject movingBus;
	public GameObject stopBus;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
			if (warningZone != null)
            	warningZone.SetActive(true);
			movingBus.SetActive (true);
			stopBus.SetActive (true);
        }
    }
}

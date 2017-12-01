using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateBus : MonoBehaviour {
	public GameObject bus1;
	public GameObject bus2;
	public float busSpeed;
	BusController busController1;
	BusController busController2;
	Rigidbody rb1;
	Rigidbody rb2;
	// Use this for initialization
	void Start () {
//		rb1 = bus1.GetComponent<Rigidbody> ();
//		rb2 = bus2.GetComponent<Rigidbody> ();
		busController1 = bus1.GetComponent<BusController> ();
		busController2 = bus2.GetComponent<BusController> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Player") {
			busController1.enabled = true;
			busController2.enabled = true;
			//rb2.velocity = new Vector3 (busSpeed, 0, 0);
		}
	}
}

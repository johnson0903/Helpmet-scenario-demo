using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusController : MonoBehaviour {
	public float setSpeedValue;
	public Vector3 setAccelerateValue;
	public GameObject light1;
	public GameObject light2;
    Rigidbody rb;
	Vector3 speed;
	Vector3 a = new Vector3(0, 0, 0);

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
		speed = new Vector3(setSpeedValue, 0, 0);

	}

    // Update is called once per frame
    void FixedUpdate() {
		
		rb.velocity = speed + a;
    }

	void OnTriggerEnter(Collider other){
		if (other.gameObject.name == "stopbus") {
			a = setAccelerateValue;
			light1.SetActive (true);
			light2.SetActive (true);
		}
		if (other.gameObject.name == "acclerateBus") {
			a = setAccelerateValue;

		}
	}
}

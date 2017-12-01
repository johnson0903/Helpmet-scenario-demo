using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, zMin, zMax;
}

public class MotorController : MonoBehaviour {
    public float speed;
    public float tilt;
	private Vector3 a;
    //public Boundary boundary;
	//Vector3[] a = new []{new Vector3(0.0f,0.0f,0.0f), new Vector3(0.0f,0.0f,0.0f)};
    Rigidbody rb;
    void FixedUpdate()
    {
		
        //float moveHorizontal = Input.GetAxis("Horizontal");
		//float moveVertical = Input.GetAxis("Vertical");
		float moveHorizontal = Input.acceleration.x * 4;
		float moveVertical = Input.acceleration.z * 4;
		//a[1] = new Vector3 (moveVertical, 0.0f, -moveHorizontal);
		Vector3 movement = new Vector3(moveVertical, 0.0f, -moveHorizontal);
		if (moveVertical < 0)
		{
			movement *= 2;
		}
		if (rb.velocity.x >= 35 && moveVertical > 0) {
			movement *= 0.5f;
		}

		a.x += movement.x * speed;
		//Vector3 movement = a [1] - a [0];

		a.z = movement.z * (rb.velocity.x / 3f);

		//print (rb.velocity);
		if (rb.velocity.x <= 0 && moveVertical < 0) {
			a = new Vector3(0.0f, 0.0f, 0.0f);
		}

		rb.velocity = a;
		//a [0] = a [1];

        if (rb.velocity.z > 0)
        {
            if(transform.rotation.z < 0.1)
                transform.Rotate(0.0f, 0.0f, rb.velocity.z * tilt);
        }
        else
        {
            if(transform.rotation.z > -0.1)
                transform.Rotate(0.0f, 0.0f, rb.velocity.z * tilt);
        }
        if (rb.velocity.z == 0)
            transform.Rotate(0.0f, 0.0f, -transform.rotation.z*4);
        //if (transform.rotation.z > 0.1)
        //    transform.Rotate(0.0f, 0.0f, rb.velocity.z * tilt);
        //else if(transform.rotation.z < -0.1)
        //    transform.Rotate(0.0f, 0.0f, rb.velocity.z * tilt);
        //print(transform.rotation.z);
        //rb.rotation = Quaternion.Euler(0.0f, 0.0f, rb.velocity.x * -tilt);
    }
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

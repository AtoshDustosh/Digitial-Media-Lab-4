using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{

	//private float speed = 0.2f;
	public float speed = 1002f;

	private Rigidbody rb;

	// Use this for initialization
	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update()
	{
		// ControlByArrowKeys(speed);

	}

	void FixedUpdate()
	{
		ControlByArrowKeys(speed);
	}
	void ControlByArrowKeys(float speed)
	{
		float xMove = Input.GetAxis("Horizontal") * speed;
		float zMove = Input.GetAxis("Vertical") * speed;

		//transform.Translate(xMove, 0.0f, zMove);
		rb.AddForce(xMove, 0.0f, zMove);

		Debug.Log("xMove = " + xMove);


	}
}


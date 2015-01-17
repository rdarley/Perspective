using UnityEngine;
using System.Collections;

public class BallControl : MonoBehaviour {

	public int rotationSpeed = 200;
	int jumpHeight = 8;

	float distToGround;
	// Use this for initialization
	void Start () 
	{
		distToGround = collider.bounds.extents.y;
	}
	
	// Update is called once per frame
	void Update () 
	{
		float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
		rotation *= Time.deltaTime;
		rigidbody.AddRelativeTorque(Vector3.back * rotation);

		if(Input.GetButtonDown("Jump") /*Input.GetKeyDown(KeyCode.Space)*/ && IsGrounded())
		{
			rigidbody.velocity = new Vector3(rigidbody.velocity.x, jumpHeight, rigidbody.velocity.z);
		}	
	}

	bool IsGrounded()
	{
		//Check if we are on the ground. Return true if we are else return false.
		float rayDistance = distToGround + (float)0.1;
		return Physics.Raycast(transform.position, Vector3.down, rayDistance);
	}
}

using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

	public Transform target;
	float distance = (float) -10;
	float lift = (float) 1.5;
	bool perpXAxis = true;

	// Update is called once per frame
	void Update () 
	{
		//transform.position = target.position + new Vector3(0.x,lift,distance);
		transform.LookAt(target);

		if(Input.GetButtonDown("RotateLeft") && perpXAxis)
		{
			transform.Rotate(Vector3.left*9);
		}
	
	}
}

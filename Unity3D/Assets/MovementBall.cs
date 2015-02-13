using UnityEngine;
using System.Collections;

public class MovementBall : MonoBehaviour 
{

	
	// Update is called once per frame
	void FixedUpdate () 
	{
		float translation = Input.GetAxis("Vertical")*10;
		float rotation = Input.GetAxis("Horizontal")*10;
		//translation *= Time.deltaTime;
		Vector3 move = new Vector3(translation,0.0F,rotation);
		rigidbody.AddForce(move);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSteering : MonoBehaviour {

	public Rigidbody2D rb;
	[SerializeField]
	float speed = 12f;
	[SerializeField]
	float steeringPower = 2f;
	float steeringAmount, direction;


	
	void FixedUpdate () {

		steeringAmount = -Input.GetAxis("Horizontal");
		direction = Mathf.Sign(Vector2.Dot (rb.velocity, rb.GetRelativeVector(Vector2.up)));
		rb.rotation += steeringAmount * steeringPower * rb.velocity.magnitude * direction;
		rb.rotation += steeringAmount * steeringPower * rb.velocity.magnitude * direction;

		rb.AddRelativeForce (Vector2.up * speed);

		rb.AddRelativeForce ( - Vector2.right * rb.velocity.magnitude * steeringAmount / 2 );
			
	}
	public void sagcixis()
	{
		steeringAmount = 0;
	}
	public void saggiris()
	{
		steeringAmount = -1f;
	}
	public void solcixis()
	{
		steeringAmount = 0;
	}
	public void solgiris()
	{
		steeringAmount = 1f;
	}


}

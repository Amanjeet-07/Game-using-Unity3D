using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube_movement : MonoBehaviour
{
	public float speed = 10f;

	// Update is called once per frame
	void Update()
	{
		float horizontalMovement = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
		float verticalMovement = Input.GetAxis("Vertical") * Time.deltaTime * speed;

		transform.Translate(-verticalMovement, 0, horizontalMovement);
	}
}
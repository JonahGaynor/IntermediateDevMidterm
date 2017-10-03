using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public Transform lookAtTarget;
	public Transform moveToTarget;


	// Update is called once per frame
	void Update () {

		//checking to see if variable is defined first.
		if (lookAtTarget != null) {
			transform.LookAt (lookAtTarget.position);
		}

		if (moveToTarget != null) {
			//figure out what direction to move in
			//calculate vector from this point (A) to moveToTarget (point B) = B-A
			Vector3 moveDirection = moveToTarget.position - transform.position;


			//if magnitude is greater than 1
			if (moveDirection.magnitude > 1f) {
				//normalize. all 3 are the same.
				moveDirection = moveDirection / moveDirection.magnitude;
				moveDirection = moveDirection.normalized;
				moveDirection = Vector3.Normalize (moveDirection);
			}

			moveDirection.y = 0f;
			//actually move the camera
			transform.position += moveDirection * Time.deltaTime * 5f;
		}

	}
}

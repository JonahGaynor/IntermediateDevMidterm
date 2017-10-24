using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public Transform lookAtTarget;
	public Transform moveToTarget;
	public Transform tr;
	bool deadCameraMove = false;

	void Start () {
		tr = GetComponent<Transform> ();

	}


	void Update () {
		deadCameraMove = GetComponentInParent<PlayerControlScript> ().deadOrNot;

		if (lookAtTarget != null) {
			
			transform.forward = Vector3.Slerp (transform.forward, lookAtTarget.position - transform.position, Time.deltaTime * 3f);
		}

		if (moveToTarget != null && deadCameraMove == true && transform.position.x > 5f) {
			Vector3 moveDirection = moveToTarget.position - transform.position;


			if (moveDirection.magnitude > 1f) {
				moveDirection = moveDirection / moveDirection.magnitude;
				moveDirection = moveDirection.normalized;
				moveDirection = Vector3.Normalize (moveDirection);
			}

			moveDirection.y = 0f;
			transform.position += moveDirection * Time.deltaTime * 5f;
		}
		if (gameObject.transform.position.z < -4.5) {
			gameObject.transform.position = new Vector3 (transform.position.x, transform.position.y, -4.5f);
		}
		if (gameObject.transform.position.z > 4.5) {
			gameObject.transform.position = new Vector3 (transform.position.x, transform.position.y, 4.5f);
		}



	}
}

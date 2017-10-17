using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlScript : MonoBehaviour {

	ConstantForce cf;
	Rigidbody rb;
	Vector3 inputVector;
	float zForce = 0f;
	public float computerForce = 0f;
	public bool deadOrNot = false;


	void Start () {
		rb = GetComponent<Rigidbody> ();
		cf = GetComponent<ConstantForce> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (deadOrNot == false) {
			if (Input.GetKey (KeyCode.LeftArrow)) {
				rb.AddForce (0f, 0f, -zForce);
				zForce++;
			}
			if (Input.GetKey (KeyCode.RightArrow)) {
				rb.AddForce (0f, 0f, zForce);
				zForce++;
			}
			if (Input.GetKeyUp (KeyCode.LeftArrow)) {
				zForce = 0f;
			}
			if (Input.GetKeyUp (KeyCode.RightArrow)) {
				zForce = 0f;
			}
			if (computerForce == 200f) {
				cf.force = new Vector3 (0f, 0f, 5f);

			}
			if (computerForce == 500f) {
				cf.force = new Vector3 (0f, 0f, 0f);

			}
			if (computerForce == 700f) {
				cf.force = new Vector3 (0f, 0f, -5f);
			}
			if (computerForce == 1000) {
				cf.force = new Vector3 (0f, 0f, 0f);
			}
			if (computerForce >= 1001f) {
				computerForce = 0f;
			}
			computerForce++;

		}
	}


	void OnTriggerEnter () {
		Debug.Log ("Yup we fell");
		//cf.force = new Vector3 (0f, 1000f, 0f);
		deadOrNot = true;

	}


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlScript : MonoBehaviour {

	ConstantForce cf;
	Vector3 inputVector;
	float zForce = 0f;
	public float computerForce = 0f;


	void Start () {
		cf = GetComponent<ConstantForce> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			cf.force = new Vector3 (0f, 0f, -zForce/2);
			zForce++;
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			cf.force = new Vector3 (0f, 0f, zForce/2);
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
		if (computerForce == 700f) {
			cf.force = new Vector3 (0f, 0f, -5f);
		}
		if (computerForce >= 1001f) {
			computerForce = 0f;
		}
		computerForce++;
	}


	void OnTriggerEnter () {
		cf.force = new Vector3 (0f, 1000f, 0f);



	}
}

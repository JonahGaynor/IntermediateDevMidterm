using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubwayLurch : MonoBehaviour {

	ConstantForce cf;
	Vector3 inputVector;
	public float computerForce = 0f;

	// Use this for initialization
	void Start () {
		cf = GetComponent<ConstantForce> ();

	}
	
	// Update is called once per frame
	void Update () {
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
}

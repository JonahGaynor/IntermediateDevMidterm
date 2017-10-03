using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRollScript : MonoBehaviour {

	public float badName;
	public ConstantForce cf;

	// Use this for initialization
	void Start () {
		cf = GetComponent<ConstantForce> ();
	}
	
	// Update is called once per frame
	void Update () {
		badName = GetComponent<PlayerControlScript> ().computerForce;

		if (badName == 150f) {
			cf.force = new Vector3 (0f, 0f, -1f);

		}
		if (badName == 650f) {
			cf.force = new Vector3 (0f, 0f, 1f);

		}
	}
}

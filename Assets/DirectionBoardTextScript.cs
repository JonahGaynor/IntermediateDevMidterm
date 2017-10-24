using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DirectionBoardTextScript : MonoBehaviour {


	public TextMesh tm;
	public float clockTimer = 0f;
	public PlayerControlScript pcs;

	void Start () {
		tm = GetComponent<TextMesh> ();

	}

	void Update () {
		clockTimer = pcs.computerForce;
		if (clockTimer == 200f) {
			tm.text = ">>>>>";
		}
		if (clockTimer == 500f) {
			tm.text = "";
		}
		if (clockTimer == 700f) {
			tm.text = "<<<<<";
		}
		if (clockTimer == 1000f || clockTimer == 1f) {
			tm.text = "";
		}

	}
}

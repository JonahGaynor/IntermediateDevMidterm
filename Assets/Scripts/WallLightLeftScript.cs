using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallLightLeftScript : MonoBehaviour {

	Renderer rd;
	float clockTimer;
	public PlayerControlScript pcs;
	public Color col;
	public Color whiteCol;


	// Use this for initialization
	void Start () {
		rd = GetComponent<Renderer> ();
		col = new Color (1f, 1f, 0.8f);
		whiteCol = new Color (1f, 1f, 1f);
	}

	// Update is called once per frame
	void Update () {
		clockTimer = pcs.computerForce;

		if (clockTimer == 650f) {
			rd.material.color = col;
		}
		if (clockTimer == 660f) {
			rd.material.color = whiteCol;
		}
		if (clockTimer == 670f) {
			rd.material.color = col;
		}
		if (clockTimer == 680f) {
			rd.material.color = whiteCol;
		}
		if (clockTimer == 690f) {
			rd.material.color = col;
		}
		if (clockTimer == 700f) {
			rd.material.color = whiteCol;
		}



	}
}
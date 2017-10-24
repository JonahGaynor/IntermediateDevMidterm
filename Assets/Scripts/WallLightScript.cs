using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallLightScript : MonoBehaviour {

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

		if (clockTimer == 150f) {
			rd.material.color = col;
		}
		if (clockTimer == 160f) {
			rd.material.color = whiteCol;
		}
		if (clockTimer == 170f) {
			rd.material.color = col;
		}
		if (clockTimer == 180f) {
			rd.material.color = whiteCol;
		}
		if (clockTimer == 190f) {
			rd.material.color = col;
		}
		if (clockTimer == 200f) {
			rd.material.color = whiteCol;
		}


	}
}

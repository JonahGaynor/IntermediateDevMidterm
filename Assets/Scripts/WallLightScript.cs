using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallLightScript : MonoBehaviour {

	Renderer rd;
	public Color col = new Color (1f, 1f, 0f);

	// Use this for initialization
	void Start () {
		rd = GetComponent<Renderer> ();

	}
	
	// Update is called once per frame
	void Update () {
		rd.material.color = col;
	}
}

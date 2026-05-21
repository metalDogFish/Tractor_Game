using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cylinderScript : MonoBehaviour {

	private Transform trans;
	// Use this for initialization
	void Start () {
		trans = GetComponent<Transform>();
		
	}
	
	// Update is called once per frame
	void Update () {
		trans.Rotate(0.3f, 0, 1.0f);
	}
}

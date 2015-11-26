﻿using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {
	public float speed = 100;
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (0, speed * Time.deltaTime, 0);
	}
}

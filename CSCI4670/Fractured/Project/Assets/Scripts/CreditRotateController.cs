﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditRotateController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		transform.Rotate (new Vector3 (15, 20, 45) * Time.deltaTime);	
	}
}
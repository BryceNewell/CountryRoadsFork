﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{
	// Update is called once per frame
	void Update ()
	{

	    transform.RotateAround(Vector3.zero, Vector3.right, 5f * Time.deltaTime);
	}
}
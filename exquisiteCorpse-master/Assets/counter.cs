﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class counter : MonoBehaviour {

	public Text count; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		count.text = "assassins: " + assassin.assassinCount; 
	}
}

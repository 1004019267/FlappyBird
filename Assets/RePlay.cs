﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RePlay : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space)||Input.GetMouseButtonDown(0))
        {
            Air.scalespeed = 1;
            Application.LoadLevel(0);
        }
	}
}

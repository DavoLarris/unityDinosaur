﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class retryScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void onClick()
    {
        Debug.Log("Click");
        SceneManager.LoadScene("gameScene");
        dinosaourScript.isDead = false;
    }
}

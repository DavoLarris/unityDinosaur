using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dinosaourScript : MonoBehaviour {
    private int speed = 20;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space was pressed");
            this.GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
        }
        this.transform.rotation = Quaternion.identity; //estabilizacion
    }
}

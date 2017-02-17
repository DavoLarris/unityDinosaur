using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dinosaourScript : MonoBehaviour {
    private int speed = 20;
    public KeyCode keyUp, keyDown, keySpace;

    // Use this for initialization
    void Start () {
        this.GetComponent<Rigidbody2D>().gravityScale = 6;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(keyUp) || Input.GetKeyDown(keySpace))
        {
            Debug.Log("Space was pressed");
            this.GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
        }
        this.transform.rotation = Quaternion.identity; //estabilizacion
    }
}

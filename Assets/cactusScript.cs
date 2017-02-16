using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cactusScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        // Another way of Accessing
        //GamePoints gamePoints = GameObject.FindObjectOfType(typeof(GamePoints)) as GamePoints;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "dinosaur")
        {
            if (gamePoints.points > gamePoints.hiScorePoints)
            {
                gamePoints.hiScorePoints = gamePoints.points;
            }
        }
        Debug.Log("Game Over! points: " + gamePoints.points);
        //Application.LoadLevel("GameOver");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdDinoScript : MonoBehaviour {
    public Animator anim;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "dinosaur")
        {
            anim.SetTrigger("dead");
            if (gamePoints.points > gamePoints.hiScorePoints)
            {
                gamePoints.hiScorePoints = gamePoints.points;
            }
        }
        Debug.Log("Game Over! points: " + gamePoints.points);
        //Application.LoadLevel("GameOver");
    }


}

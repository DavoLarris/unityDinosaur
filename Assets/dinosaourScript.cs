using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dinosaourScript : MonoBehaviour
{
    private Animator anim;
    private int speed = 20;
    public KeyCode keyUp, keyDown, keySpace;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        this.GetComponent<Rigidbody2D>().gravityScale = 6;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyUp) || Input.GetKeyDown(keySpace))
        {
            Debug.Log("Space was pressed");
            this.GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
        }
        this.transform.rotation = Quaternion.identity; //estabilizacion
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "deadly")
        {
            anim.SetBool("dead", true);
            Debug.Log("Animation");
            if (gamePoints.points > gamePoints.hiScorePoints)
            {
                gamePoints.hiScorePoints = gamePoints.points;
            }
        }
        Debug.Log("Game Over! points: " + gamePoints.points);
        //Application.LoadLevel("GameOver");
    }
}

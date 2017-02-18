using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dinosaourScript : MonoBehaviour
{
    private Animator anim;
    private int speed = 20;
    public KeyCode keyUp, keyDown, keySpace;
    public static bool isDead;
    private Vector2 tocuhOrigin = -Vector2.one;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        this.GetComponent<Rigidbody2D>().gravityScale = 6;
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead == false)
        {
            if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(keyUp) || Input.GetKeyDown(keySpace))
            {
                Debug.Log("Space was pressed");
                this.GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
            }
            this.transform.rotation = Quaternion.identity; //estabilizacion
        }
    }

    IEnumerator OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "deadly")
        {
            anim.SetBool("dead", true);
            isDead = true;
            Debug.Log("Animation");
            yield return new WaitForSeconds(3f);
            SceneManager.LoadScene("gameOverScene");
        }
        
    }

}

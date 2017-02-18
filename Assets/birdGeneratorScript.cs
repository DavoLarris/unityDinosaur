using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdGeneratorScript : MonoBehaviour {
    public GameObject bird;
    private float birdPerSecond = 0.1f;
    private GameObject freshBird = null;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (dinosaourScript.isDead == false)
        {
            float limit = birdPerSecond * Time.deltaTime;
            if (Random.value < limit)
            {
                spawnBird();
            }
        } else
        {
            if (freshBird != null)
                freshBird.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        }
    }
    private void spawnBird()
    {
        freshBird = Instantiate(bird, transform.position, Quaternion.identity) as GameObject;
        float scale = Random.Range(1, 2);
        freshBird.transform.localScale = new Vector3(scale, scale, 0);
        freshBird.transform.position = new Vector3(14, Random.Range(4, 1), 1);
        freshBird.GetComponent<Rigidbody2D>().velocity = Vector3.left * 5;
        Debug.Log("Created bird");
    }
}

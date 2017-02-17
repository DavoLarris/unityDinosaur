using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdGeneratorScript : MonoBehaviour {
    public GameObject bird;
    private float birdPerSecond = 0.5f;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        float limit = birdPerSecond * Time.deltaTime;
        if (Random.value < limit)
        {
            spawnBird();
        }
    }
    private void spawnBird()
    {
        GameObject freshBird = Instantiate(bird, transform.position, Quaternion.identity) as GameObject;
        float scale = Random.Range(2, 4);
        freshBird.transform.localScale = new Vector3(scale, scale, 0);
        freshBird.transform.position = new Vector3(14, 4, 1);
        freshBird.GetComponent<Rigidbody2D>().velocity = Vector3.left * 2;
        Debug.Log("Created bird");
    }
}

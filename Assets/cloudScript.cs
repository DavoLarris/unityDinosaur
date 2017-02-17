using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudScript : MonoBehaviour {
    public GameObject cloud;
    private float cloudsPerSecond = 0.5f;

    // Use this for initialization
    void Start () {
        float limit = cloudsPerSecond * Time.deltaTime;
        if (Random.value < limit)
        {
            spawnCloud();
        }
    }
	
	// Update is called once per frame
	void Update () {
        float limit = cloudsPerSecond * Time.deltaTime;
        if (Random.value < limit)
        {
            spawnCloud();
        }
    }

    private void spawnCloud()
    {
        GameObject freshCloud = Instantiate(cloud, transform.position, Quaternion.identity) as GameObject;
        float scale = Random.Range(1, 5);
        freshCloud.transform.localScale = new Vector3(scale, scale, 0); //tamaño
        freshCloud.transform.position = new Vector3(14, Random.Range(1, 4),1); 
        freshCloud.GetComponent<Rigidbody2D>().velocity = Vector3.left * (scale + 5);
        Debug.Log("Created cloud");
    }
}

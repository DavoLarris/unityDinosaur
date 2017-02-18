using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cactusGenScript : MonoBehaviour
{
    public GameObject cactus;
    private float cactusPerSecond = 0.5f;
    private GameObject freshCactus;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (dinosaourScript.isDead == false)
        {
            float limit = cactusPerSecond * Time.deltaTime;
            if (Random.value < limit)
            {
                spawnCactus();
            }
        }
        else
        {
            if (freshCactus != null)
                freshCactus.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        }
    }
    private void spawnCactus()
    {
        freshCactus = Instantiate(cactus, transform.position, Quaternion.identity) as GameObject;
        float scale = Random.Range(2, 4);
        freshCactus.transform.localScale = new Vector3(scale, scale, 0); //tamaño
        freshCactus.transform.position = new Vector3(14, Random.Range(-0.27f, 0), 1);
        freshCactus.GetComponent<Rigidbody2D>().velocity = Vector3.left * (scale + 5);
        Debug.Log("Created cactus");
    }

}

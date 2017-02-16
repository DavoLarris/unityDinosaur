using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameResult : MonoBehaviour {
    public static int savedHiScore = 0;

    // Use this for initialization
    void Start () {
        Text result = GameObject.Find("GameResult").GetComponent<Text>();
        result.text = "Points: " + gamePoints.points + " - Highest: " + gamePoints.hiScorePoints;
        savedHiScore = gamePoints.hiScorePoints;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

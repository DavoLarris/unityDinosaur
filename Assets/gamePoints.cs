using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamePoints : MonoBehaviour {
    public Text hiScore;
    public Text score;
    public static int hiScorePoints = 0;
    public static int points;

    // Use this for initialization
    void Start () {
        points = 0;
        if (gameResult.savedHiScore > 0)
        {
            hiScorePoints = gameResult.savedHiScore;
            hiScore.text = gameResult.savedHiScore.ToString();
        }
    }
	
	// Update is called once per frame
	void Update () {
        points++;
        score.text = points.ToString();
    }
}

using UnityEngine;
using System.Collections;

public class ScoreKeeper : MonoBehaviour {

    int score = 0;

    void Start () {

    }

    // Update is called once per frame
    void Update () {
	
	}


    public void IncrementScore()
    {
        score++;
        print("You scored! Your current score is: " + score);
    }
}

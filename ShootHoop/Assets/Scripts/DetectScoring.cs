﻿using UnityEngine;
using System.Collections;

public class DetectScoring : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision collision)
    {
        ScoreKeeper scorekeeper = FindObjectOfType<ScoreKeeper>();
        scorekeeper.IncrementScore();
    }
}
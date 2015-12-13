﻿using UnityEngine;
using System.Collections;

public class DestroyTask : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider Collider)
    {
        if (Collider.tag == "Destroy")
        {
            Destroy(gameObject);
            GameManager.Instance.currentScore -= 25;
        }
    }
}

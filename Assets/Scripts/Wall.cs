﻿using UnityEngine;
using System.Collections;

public class Wall : MonoBehaviour {

    public int health;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            //health -= other.gameObject.GetComponent<>();
        }
    }
}

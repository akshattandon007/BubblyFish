﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Bubble : MonoBehaviour {
	 

	//public uiManager ui;
	public int flag=0;

	// Use this for initialization
	void Start () {

	

	
	}

	// Update is called once per frame
	void Update () {
		


	
	
	}



	 void OnCollisionEnter2D (Collision2D col){
		if (col.gameObject.tag == "EnemyFish") {
            Destroy(col.gameObject);
            Destroy(gameObject);
            uiManager.score += 3;
		
		



		}

	}
}

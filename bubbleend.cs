using UnityEngine;
using System.Collections;

public class bubbleend : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.tag=="Bubble" ||col.gameObject.tag=="EnemyFish")
			Destroy (col.gameObject);
		
	}
}

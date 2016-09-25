using UnityEngine;
using System.Collections;


public class Fishlower : MonoBehaviour {
	public uiManager u;
	public uiManager hii;





	// Use this for initialization
	void Start () {
		u.gameOver = false;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Player") {
			Destroy (col.gameObject);
			u.gameOverActivated ();
			hii.highScore ();
		}
			if (col.gameObject.tag == "EnemyFish")
				Destroy (col.gameObject);
		
		



	}
		
}

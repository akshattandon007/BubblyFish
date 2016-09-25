using UnityEngine;
using System.Collections;

public class Destroyer : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "EnemyFish" || col.gameObject.tag == "star" ) {
		//	col.gameObject.transform.position=new Vector3(25.3f,-0.3f,0f);
			//col.gameObject.SetActive(false);

			Destroy (col.gameObject);
		} else if (col.gameObject.tag == "Player") {
			Destroy (col.gameObject);
		}
	}


}


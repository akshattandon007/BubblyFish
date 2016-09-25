using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class starcol : MonoBehaviour {
	public Shooter uv;
	public Image Bar;
	public static int ping;

	// AudioClip star;




	// Use this for initialization

	void Start () {


		ping = 0;
	}
	void Awake(){
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter2D(Collision2D col){
		if (gameObject.tag == "star") {

	
		//	AudioSource.PlayClipAtPoint(star,new Vector3(1,1,1),  10.0f);
			Destroy (gameObject);

			ping = 1;
		

		
		} 
	}



}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FishController : MonoBehaviour {
	public GameObject player2;
  float jumpSpeed=8f;
	float jumpDown=8.0f;
	int isJumping=0;

	public AudioClip star;
//	private AudioSource audio;
	public float lastStep,timeBetweenSteps=1f;



	public float carSpeed;
	public float maxPos=-23.0f;
 public uiManager ui;
	public uiManager hi;
	public float ynegativeup=3.5f;
	public float ynegativedown = -3.9f;
	public float yxnegativeleft = -8.6f;
	public float ynegativeright = 7.0f;
   

	
	Vector3 position;

	public void jumping()
	{
		isJumping = 1;
	}


	void Awake(){
		
	}

	void Start () {
		position = transform.position;
}


	void Update () {
		

		position.y = Mathf.Clamp (position.y, ynegativedown,  ynegativeup);
		position.x = Mathf.Clamp (position.x, yxnegativeleft, ynegativeright);
		GetComponent<Rigidbody2D> ().velocity += jumpDown * Vector2.down*Time.deltaTime;     //Aviod using physics components(gravity) 29/6 instead use scripting

		
		if(isJumping==1)
		{if(Time.time-lastStep>timeBetweenSteps){
			GetComponent<Rigidbody2D> ().velocity += jumpSpeed * Vector2.up;    // 29/6/2016 used vectors for better implementation
		
			}
			isJumping= 0;

		}
	}


	


		void OnCollisionEnter2D (Collision2D col)
{
		if (col.gameObject.tag == "EnemyFish") {
			Destroy (player2);
			ui.gameOverActivated ();
			hi.highScore ();

		} 
		else if (col.gameObject.tag == "star"){
			Destroy (col.gameObject);
			AudioSource.PlayClipAtPoint(star,new Vector3(1,1,1),  1.0f);
		

			}
			}

}





using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Shooter : MonoBehaviour {
	//public GameObject player;
	//public GameObject shootbutton;
	//float jumpSpeed=8f;
	private float nextFire = 0.5F;
	public float fireRate = 1.0F;
	public Image Bar;
	public  float maxh;
	public static float minh;
	public int flag;






	public Rigidbody2D projectile;

	public float speed ;




	// Use this for initialization
	void Start () {
		minh = 0f;
		maxh = 100f;
		minh = maxh;
		InvokeRepeating ("decreaseHealth",0f,2f);
	//	InvokeRepeating ("increaseHealth",0f,2f);
		//shootbutton.SetActive (true);
		flag=0;

	

	}

	// Update is called once per frame
	void Update () {


	//	if (Input.GetKeyDown("space"))
	//	{
	//	Rigidbody2D instantiatedProjectile = Instantiate(projectile,
	//			transform.position,
	//		transform.rotation)
	//			as Rigidbody2D;

	//		instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(speed, 0,0));

	//	}
	//	if (Input.GetButtonDown ("Jump")) {
	//		GetComponent<Rigidbody2D> ().velocity += jumpSpeed * Vector2.up;
	//	}
	}


          void OnCollisionEnter2D(Collision2D col)
	{
		
		if (col.gameObject.tag == "Bubble")
			//shootbutton.SetActive (false);
			Destroy (gameObject);
		

	}
		//ui.gameOverActivated ();
		

		//}
	public void shoot()
	{
		if (minh > 0f) {
			if (Time.time > nextFire) {
				nextFire = Time.time + fireRate;

				Rigidbody2D instantiatedProjectile = Instantiate (projectile,
					                                     transform.position,
					                                     transform.rotation)
			as Rigidbody2D;
				instantiatedProjectile.velocity = transform.TransformDirection (new Vector3 (speed, 0, 0));
				//flag = 1;


						minh -= 15f;
							float calhealth = minh / maxh;
							setHealth (calhealth);
							

				}

					
				
				//		}

		
			
		
	
	}
	}
	void decreaseHealth()
	{//if (flag == 1) {
			
	//		minh -= 15f;
	//		float calhealth = minh / maxh;
	//		setHealth (calhealth);
	//		flag = 0;
	//	}
		if (starcol.ping == 1) {
			while (minh <= 100f)
				minh += 5f;
			starcol.ping = 0;
		}

		}

	//public  void increaseHealth()
	//	{
			
		
	//	}
		
		


	
	void setHealth(float myhealth){
		Bar.fillAmount = myhealth;
	}




}
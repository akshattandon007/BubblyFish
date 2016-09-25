using UnityEngine;
using System.Collections;

public class Social : MonoBehaviour {

	public float speed=5.0f;
	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void Update () {
		transform.Translate  (new Vector3 (1, 0, 0) * speed * Time.deltaTime);
	}


}

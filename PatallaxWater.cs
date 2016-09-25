using UnityEngine;
using System.Collections;

public class PatallaxWater : MonoBehaviour {

	// Use this for initialization

	
	// Update is called once per frame
	void Update () {
		GetComponent<Renderer> ().material.mainTextureOffset = new Vector2 (Time.time * 0.25f, 0.0f);
	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class CompanyName : MonoBehaviour {
    public int timer;
	// Use this for initialization
	void Start () {

        timer = 5;
	}
	
	// Update is called once per frame
	void Update () {
       if(Time.deltaTime==timer)
        {
            
            SceneManager.LoadScene("menu");
        }
      //  if (Time.deltaTime == 2.0f)
          
	
	}
	public void play(){
      //  
     //   SceneManager.LoadScene("menu");
	}


}

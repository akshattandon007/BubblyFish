using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
public class Menu : MonoBehaviour
{
   
 // Use this for initialization
    void Start()
    {
      
    }
 // Update is called once per frame
    void Update()
    {
    }
 public void exit1()
    {
        Application.Quit();
    }
public void Back1()
    {
        SceneManager.LoadScene("menu");
        //SceneManager.LoadScene ("scene1");
    }
    public void help1()
    {
        SceneManager.LoadScene("help");
        //SceneManager.LoadScene ("scene1");
    }
  public void Play1()
    {


        SceneManager.LoadScene("scene1");

    }
 public void rate1()
    {

#if UNITY_ANDROID

       Application.OpenURL("https://play.google.com/store/apps/details?id=com.GameDimension.mm&hl=en");
	#endif

    }
}




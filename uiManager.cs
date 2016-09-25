using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class uiManager : MonoBehaviour {
	//public Rigidbody2D projectile;
	public float speed = 5;
   // AdsManager ad,rq;
    public AdsManager rq, sh;
	int highscore;
	string highscorekey="HIGH SCORE";
	public GameObject back;
	public  int counter;
	public string counterkey="counter";
	public string flagkey="flag";
	public  int flag;
	public GameObject over;
	public Button[] buttons;
	public Text scoreText,highScoreText;
	public static int score;
	public bool gameOver;
	public AudioClip end;
	public float com;
    public GameObject replayButton;
    public GameObject exitButton;
    public GameObject backButton;
    public GameObject pausePlayButton;

	// Use this for initialization
	void Start () {

      
		gameOver = false;
		score=0 ;
		InvokeRepeating ("scoreUpdate", 3.0f, 4.5f);
		highscore = PlayerPrefs.GetInt(highscorekey,0); 
	over.gameObject.SetActive(false);

		back.gameObject.SetActive(false);
		counter = PlayerPrefs.GetInt(counterkey,1); 
		flag = PlayerPrefs.GetInt(flagkey,0);
        rq.RequestInterstitial();

		}
	// Update is called once per frame
			void Update () {
		scoreText.text = "SCORE " + score;
		highScoreText.text = "HIGH SCORE "+ highscore;
		if (Input.GetMouseButtonDown (0)) {
			PlayerPrefs.SetInt (flagkey, 0);
			PlayerPrefs.Save();
			

		}
	}

	void scoreUpdate(){
		if (!gameOver) {
			score += 1;
	
			
		}
	}
    void Awake()
    { 
        exitButton.gameObject.SetActive(false);
        backButton.gameObject.SetActive(false);
        replayButton.gameObject.SetActive(false);
        pausePlayButton.gameObject.SetActive(false);


    }







	public void gameOverActivated(){
		gameOver = true;
			
		over.gameObject.SetActive(true);
		AudioSource.PlayClipAtPoint(end,new Vector3(1,1,1),1f);
        exitButton.gameObject.SetActive(true);
        backButton.gameObject.SetActive(true);
        replayButton.gameObject.SetActive(true);

      
		back.gameObject.SetActive (true);

        sh.ShowInterstitial();

		
			}

	public void Pause(){
		if (Time.timeScale == 1) {
			Time.timeScale = 0;
			pausePlayButton.gameObject.SetActive (true);
		
		}
	}
	public void pausePlay(){
		 if (Time.timeScale == 0){
			Time.timeScale = 1;
			pausePlayButton.gameObject.SetActive (false);

		}



	}
	
	public void exit(){
		Application.Quit ();
	}
	public void highScore(){
		if (score > highscore) {
			highscore = score;
			PlayerPrefs.SetInt (highscorekey, highscore);
			PlayerPrefs.Save();
			Debug.Log (highscore);
			//scoreText.text = "HIGH SCORE " + highscore;
		}
	
	}
	public void Back(){
		SceneManager.LoadScene("menu");
		//SceneManager.LoadScene ("scene1");
	}
	public void help(){
		SceneManager.LoadScene ("help");
		//SceneManager.LoadScene ("scene1");
	}

	


	public void	Play(){


			SceneManager.LoadScene ("scene1");
			
		}



	

}


using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public RotationSphere target;
    public Text scoreText;
    public Text gameOverText;
    public Text highScoreText;
    public GameObject CongratultionsText;
    public GameObject YouMadeText;
    bool gameover = false;
    float score = 0;

    public AudioSource hitSource;

    private void Start()
    {
        scoreText.text = score.ToString();
        highScoreText.text = PlayerPrefs.GetFloat("HighScore", 0).ToString();
        hitSource = GetComponent<AudioSource> ();
    }

    // Playing and getting score
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Knife")
        {
            hitSource.Play();
            score = score + 5;
        }
        
        else
        {
            gameover = true;
        }
        
        scoreText.text = score.ToString();
        gameOverText.text = scoreText.text;
        if(score > PlayerPrefs.GetFloat("HighScore", 0))
        {
            PlayerPrefs.SetFloat("HighScore", score);
            highScoreText.text = score.ToString();
            if(gameover)
            {
                CongratultionsText.SetActive(true);
                YouMadeText.SetActive(true);
            }            
        }
        
    }

    public void ResetScore()
    {
        PlayerPrefs.DeleteKey("HighScore");
    }

}

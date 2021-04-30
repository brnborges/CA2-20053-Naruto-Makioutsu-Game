using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Manager : MonoBehaviour {

    [SerializeField]
    private GameObject restartButton;
    [SerializeField]
    private GameObject gameOver;
    [SerializeField]
    private GameObject gameOverScore;
    [SerializeField]
    private GameObject yourScore;
    [SerializeField]
    private GameObject highScoreText;
    [SerializeField]
    private GameObject highScore;
    [SerializeField]
    private GameObject Score;
    [SerializeField]
    private GameObject Crosshair;
    [SerializeField]
    private GameObject resetScore;



    public void Back()
    {

        SceneManager.LoadScene(0);

    }

    public void ShowRestartButton()
    {
        
        gameOver.SetActive(true);
        yourScore.SetActive(true);
        gameOverScore.SetActive(true);
        highScoreText.SetActive(true);
        highScore.SetActive(true);
        restartButton.SetActive(true);
        resetScore.SetActive(true);
        Crosshair.SetActive(false);
        
    }

    
}

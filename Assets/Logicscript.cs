using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class Logicscript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public Text finalScoreText;


    [ContextMenu("Increasing Score")]
    public void addScore()
    {
        playerScore = playerScore + 1;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame(){
        Time.timeScale = 1; // Resume game speed
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
       
      
    }
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        //finalScoreText.text = scoreText.text; // Update final score
        finalScoreText.text = "Total Score: " + scoreText.text; // Update final score


        // Disable all PipeMoveScript components in the scene
        foreach (PipeMoveScript pipe in FindObjectsOfType<PipeMoveScript>())
        {
            pipe.enabled = false;  // This stops the pipes from moving
        }
        Time.timeScale = 0; // Pauses the entire game
    }


}

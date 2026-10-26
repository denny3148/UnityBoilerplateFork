using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelUIController : MonoBehaviour
{
    public int Lives = 3;
    public int Score;
    public float TotalTime;
    public TextMeshProUGUI LivesLabel;
    public TextMeshProUGUI ScoreLabel;
    public TextMeshProUGUI TimeLabel;
    public AudioClip DeathSound;
    
    public AudioSource audioSource;
    private void Update()
    {
        TotalTime += Time.deltaTime;
        
        LivesLabel.text = "Lives: " + Lives;
        ScoreLabel.text = "Score: " + Score;
        TimeLabel.text = "Time: " + TotalTime.ToString(format:"0.00");
    }


    public void Kill()
    {   audioSource.PlayOneShot(DeathSound, 1.0f);
        Lives--;
        if (Lives <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    public void Collect()
    {
        Score += 50;
        if (Score == 100)
        {
            Lives++;
            Score = 0;
        }
    }

    public void Win()
    {
        SceneManager.LoadScene("Win");
    }
}

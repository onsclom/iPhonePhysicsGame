using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameManaging : MonoBehaviour
{
    // Start is called before the first frame update
    public Text highScoreText;
    public Text curScoreText;
    public int highScore = 0;
    private int curScore = 0;
    void Start()
    {
        highScore = playerScore.highScore;
        highScoreText.text = "High Score: " + highScore;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            resetGame();
        }


    }

    public void resetGame() 
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void scoreUpdate()
    {
        curScore += 1;

        if (curScore > highScore)
            highScore = curScore;

        highScoreText.text = "High Score: " + highScore;
        curScoreText.text = "Score: " + curScore;
    }

    public void scoreReset()
    {
        curScore = 0;
    }
}

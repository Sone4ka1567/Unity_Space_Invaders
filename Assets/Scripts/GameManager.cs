using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static int lives = 3;
    public static bool playGame = true;
    public static int score = 0;
    public Text lives_cnt;
    public Text endScreen;
    public Text score_text;

    void Start()
    {
        lives_cnt.text = "Lives: " + lives;
    }

    void Update()
    {
        lives_cnt.text = "Lives: " + lives;
        if (lives == 0)
        {
            endScreen.text = "Loser!";
        }
        score_text.text = "Score: " + score;
    }
}

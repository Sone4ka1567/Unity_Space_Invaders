using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static int lives = 3;
    public static int enemies = 60;
    public static bool playGame = true;
    public static int score = 0;
    public static float tm_speed_increase = 0;
    public Text lives_cnt;
    public Text endScreen;
    public Text score_text;
    public Text youWon;

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

        if (enemies == 0)
        {
            youWon.text = "You won!";
        }
    }
}

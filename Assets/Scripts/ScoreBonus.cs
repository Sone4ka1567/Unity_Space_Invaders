using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBonus : MonoBehaviour
{
    public GameObject scoreBonus;
    void Start()
    {

    }

    void Update()
    {
        int move_speed = 2;
        transform.Translate(new Vector3(0, move_speed * Time.deltaTime, 0));
        if (scoreBonus.transform.position.y <= -8)
        {
            Destroy(scoreBonus);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(scoreBonus);
            GameManager.score += 10;
        }
    }
}

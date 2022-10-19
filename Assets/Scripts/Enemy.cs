using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject enemyBullet;
    public GameObject enemyBulletClone;
    public GameObject enemy;

    bool first = false;
    float tm = 0;
    float tm_to_move = 0.5f;
    int moves_cnt = 0;
    float speed = 0.2f;
    void Start()
    {
        
    }

    void Update()
    {
        if (GameManager.playGame)
        {
            tm += Time.deltaTime;
            if (tm >= tm_to_move && moves_cnt < 18)
            {
                transform.Translate(new Vector3(speed, 0, 0));
                tm = 0;
                moves_cnt += 1;
            }
            if ((moves_cnt == 9 && !first) || moves_cnt == 18)
            {
                first = true;
                moves_cnt = -1;
                tm = 0;
                transform.Translate(new Vector3(0, -0.25f, 0));
                speed = -speed;
            }

            if (enemy.transform.position.y - 0.4f <= -2)
            {
                GameManager.lives = 0;
                GameManager.playGame = false;
            }

            EnemyFire();
        }
    }

    void EnemyFire()
    {
        if (Random.Range(0, 8000) < 0.5)
        {
            enemyBulletClone = Instantiate(enemyBullet, new Vector3(enemy.transform.position.x, enemy.transform.position.y - 0.4f, 0), enemy.transform.rotation) as GameObject;
        }
    }
}

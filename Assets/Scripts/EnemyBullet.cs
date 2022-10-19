using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public GameObject enemyBullet;
    void Start()
    {
        
    }

    void Update()
    {
        int move_speed = 5;
        transform.Translate(new Vector3(0, -move_speed * Time.deltaTime, 0));
        if (enemyBullet.transform.position.y <= -8)
        {
            Destroy(enemyBullet);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.transform.position = new Vector3(0, -4f ,0);
            Destroy(enemyBullet);
            GameManager.lives--;
            GameManager.playGame = false;
        }
    }
}

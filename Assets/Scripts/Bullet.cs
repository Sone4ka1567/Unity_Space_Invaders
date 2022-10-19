using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject bullet;
    void Start()
    {
        
    }

    void Update()
    {
        int move_speed = 9;
        transform.Translate(new Vector3(0, -move_speed * Time.deltaTime, 0));
        if (bullet.transform.position.y >= 8)
        {
            Destroy(bullet);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(bullet);
            GameManager.playGame = true;
            GameManager.score += 5;
        }
    }
}

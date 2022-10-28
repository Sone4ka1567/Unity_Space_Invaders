using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject bullet;

    public GameObject bonusScore;
    public GameObject bonusScoreClone;

    public GameObject bonusSpeed;
    public GameObject bonusSpeedClone;

    public GameObject bonusLive;
    public GameObject bonusLiveClone;

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
            DropBonus();
            Destroy(collision.gameObject);
            Destroy(bullet);
            GameManager.enemies -= 1;
            GameManager.playGame = true;
            GameManager.score += 5;
        }
    }

    void DropBonus()
    {
        if (Random.Range(0, 15) <= 1)
        {
            bonusScoreClone = Instantiate(bonusScore, new Vector3(bullet.transform.position.x, bullet.transform.position.y - 0.4f, 0), transform.rotation) as GameObject;
        } else if (Random.Range(0, 25) <= 1)
        {
            bonusSpeedClone = Instantiate(bonusSpeed, new Vector3(bullet.transform.position.x, bullet.transform.position.y - 0.4f, 0), transform.rotation) as GameObject;
        } else if (Random.Range(0, 50) <= 1)
        {
            bonusLiveClone = Instantiate(bonusLive, new Vector3(bullet.transform.position.x, bullet.transform.position.y - 0.4f, 0), transform.rotation) as GameObject;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeBonus : MonoBehaviour
{
    public GameObject lifeBonus;
    void Start()
    {

    }

    void Update()
    {
        int move_speed = 2;
        transform.Translate(new Vector3(0, move_speed * Time.deltaTime, 0));
        if (lifeBonus.transform.position.y <= -8)
        {
            Destroy(lifeBonus);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(lifeBonus);
            GameManager.lives += 1;
        }
    }
}

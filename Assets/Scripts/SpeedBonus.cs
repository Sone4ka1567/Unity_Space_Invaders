using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBonus : MonoBehaviour
{
    public GameObject speedBonus;
    void Start()
    {

    }

    void Update()
    {
        int move_speed = 2;
        transform.Translate(new Vector3(0, move_speed * Time.deltaTime, 0));
        if (speedBonus.transform.position.y <= -8)
        {
            Destroy(speedBonus);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(speedBonus);
            GameManager.tm_speed_increase = 2;
        }
    }
}

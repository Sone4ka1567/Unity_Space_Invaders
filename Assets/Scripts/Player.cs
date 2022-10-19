using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject player;
    public GameObject bullet;
    public GameObject bulletClone;

    void Start()
    {
        
    }

    void Update()
    {
        if (GameManager.lives > 0)
        {
            Move();
            Fire();
        }
    }

    void Move()
    {
        int move_speed = 3;
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            if (player.transform.position.x <= 8)
            {
                transform.Translate(new Vector3(move_speed * Time.deltaTime, 0, 0));
            }
            
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            if (player.transform.position.x >= -8)
            {
                transform.Translate(new Vector3(-move_speed * Time.deltaTime, 0, 0));
            }
            
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            if (player.transform.position.y <= -2.5)
            {
                transform.Translate(new Vector3(0, -move_speed * Time.deltaTime, 0));
            }
      
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            if (player.transform.position.y >= -4.5)
            {
                transform.Translate(new Vector3(0, move_speed * Time.deltaTime, 0));
            }
            
        }
    }

    void Fire()
    {
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKey(KeyCode.F)) && bulletClone == null)
        {
            bulletClone = Instantiate(bullet, new Vector3(player.transform.position.x, player.transform.position.y + 0.7f, 0), player.transform.rotation) as GameObject;
        }
    }
}

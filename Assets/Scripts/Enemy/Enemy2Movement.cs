using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Movement : MonoBehaviour
{
    int Direction = 1;
    private float Timer;
    [SerializeField] float FlipTime;
    Rigidbody2D rb2d;
    [SerializeField] int movespeed;
    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    void ChangeDirection()
    {
        if (Timer >= FlipTime)
        {
            Direction *= -1;
            Timer = 0;
        }
    }
    private void Update()
    {
        Timer += Time.deltaTime;
        Move();
        ChangeDirection();
    }
    void Move()
    {
        rb2d.velocity = new Vector2(0, Direction) * movespeed;
    }
}

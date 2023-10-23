using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb2d;
    private Vector2 direccion;
    [SerializeField] private float MoveSpeed;
    public Vector2 Direccion { get { return direccion; } }
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        float Horizontal = Input.GetAxisRaw("Horizontal");
        float Vertical = Input.GetAxisRaw("Vertical");
        if (Horizontal != 0 || Vertical != 0)
        {
            direccion = new Vector2(Horizontal, Vertical);
        }
        rb2d.velocity = direccion * MoveSpeed;
    }
}

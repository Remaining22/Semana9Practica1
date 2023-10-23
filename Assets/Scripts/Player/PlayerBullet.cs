using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public Vector2 direction;
    private Rigidbody2D rb2d;
    [SerializeField] private float BulletSpeed;
    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        GameObject.Destroy(rb2d.gameObject, 3f);
    }

    void Update()
    {
        rb2d.velocity = direction * BulletSpeed;
    }
}

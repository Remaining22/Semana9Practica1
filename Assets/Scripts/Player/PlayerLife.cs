using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour
{
    [SerializeField] Text UI;
    [SerializeField] private int Life;
    private int MaxLife;
    private int CurrentLife;

    private void Awake()
    {
        MaxLife = Life;
        CurrentLife = MaxLife;
    }

    void Start()
    {
        UpdateLife();
    }

    void UpdateLife()
    {
        UI.text = $"Life: {CurrentLife} / {MaxLife}";
    }
    void ChangeLife(int changer)
    {
        CurrentLife += changer;
        UpdateLife();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            int daño = collision.gameObject.GetComponent<EnemyManager>().Damage;
            ChangeLife(-daño);
        }
    }

}

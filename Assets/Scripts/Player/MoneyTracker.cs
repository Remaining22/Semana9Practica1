using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MoneyTracker : MonoBehaviour
{
    [SerializeField] private Text UI;
    private int score = 0;
    public int Score { get { return score; } }
    void Start()
    {
        UpdateScore();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Moneda"))
        {
            ChangeScore(collision.GetComponent<Moneda>().Value);
            collision.GetComponent<Moneda>().OnPickUp();
        }
    }

    void UpdateScore()
    {
        UI.text = $"Score: {score}";
    }
    void ChangeScore(int changer)
    {
        score += changer;
        UpdateScore();
    }
    void Victory()
    {
        if(score >= 10)
        {
            SceneManager.LoadScene("VictoryScreen");
        }
    }
}

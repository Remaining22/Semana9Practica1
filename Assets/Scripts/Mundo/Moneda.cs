using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{
    [SerializeField] private int value;
    public int Value { get { return value; } }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnPickUp()
    {
        GameObject.Destroy(gameObject);
    }
}

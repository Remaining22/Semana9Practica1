using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private GameObject BulletPrefab;
    PlayerMovement PlayerMovement;
    void Start()
    {
        PlayerMovement = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject Bala = Instantiate(BulletPrefab);
        Bala.transform.position = transform.position;
        Bala.GetComponent<PlayerBullet>().direction = PlayerMovement.Direccion;
    }
}

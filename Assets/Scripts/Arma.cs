using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject bullet;
    public float bulletSpeed = 10;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ShootingBullet();
        }
    }

    private void ShootingBullet()
    {
        GameObject cB = Instantiate(bullet, spawnPoint.position, bullet.transform.rotation);
        Rigidbody rig = cB.GetComponent<Rigidbody>();

        rig.AddForce(spawnPoint.forward * bulletSpeed, ForceMode.Impulse);
    }
}

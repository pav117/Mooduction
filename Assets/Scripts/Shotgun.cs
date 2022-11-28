using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float fireForce = 20f;
    public bool shooting;
    public float cooldown;

    private float fireTime;

    private void Update()
    {
        if (shooting)
        {
            if (fireTime < Time.time)
            {
                Fire();
                fireTime = Time.time + cooldown;
            }
        }
    }
    public void Fire()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        bullet.GetComponent<Rigidbody2D>().AddForce(firePoint.up * fireForce, ForceMode2D.Impulse);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootAtPlayer : MonoBehaviour
{
    public Transform Player;
    public float farmerRange;
    private Transform currentTarget;
    public Transform Shotgun;
   // public float speed;
    void Update()
    {
            if (Player.CompareTag("Player"))
            {
                if (Vector3.Distance(transform.position, Player.position) < farmerRange)
                {
                     currentTarget = Player;
                     this.GetComponent<Shotgun>().shooting = true;

                }
                else
                {
                    this.GetComponent<Shotgun>().shooting = false;
                }
            }

        if (currentTarget == Player)
        {
            Vector3 dir = currentTarget.position - Shotgun.position;
            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            Shotgun.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }

    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToBait2 : MonoBehaviour
{
    public Transform Grass;

    void Update()
    {
        if (Grass.CompareTag("Bait"))
        {
            //if (Grass.activeInHierarchy)
            {
                transform.position = Vector3.MoveTowards(transform.position, Grass.transform.position, 0.03f);
            }
        }
    }
}
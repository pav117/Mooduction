using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToBait : MonoBehaviour
{
    public Transform targ;
    
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targ.transform.position, 0.03f);
    }
}
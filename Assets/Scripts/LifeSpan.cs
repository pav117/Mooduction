using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeSpan : MonoBehaviour
{
    public GameObject Bait;
    public float lifetime = 2.0f;

    void Awake()
    {
        Destroy(Bait, lifetime);
    }
}

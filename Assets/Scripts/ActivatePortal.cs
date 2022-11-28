using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePortal : MonoBehaviour
{
    public GameObject Portal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] Cows = GameObject.FindGameObjectsWithTag("Cow");
        if (Cows.Length == 0)
        {
            Portal.SetActive(true);
        }  
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBait : MonoBehaviour
{
    public GameObject BaitSpawn;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Mouse1))
            {
            SpawnIt();
        }
    }

    void SpawnIt()
    {
        Instantiate(BaitSpawn, transform.position, Quaternion.identity);
    }
}
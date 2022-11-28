using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbductionBeam : MonoBehaviour
{
    public GameObject tractorbeam;
    public GameObject CrystalSpawn;

    public float beamTimer;

    private float beamofftime;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (beamofftime < Time.time)
        {
            tractorbeam.SetActive(false);
        }
        /*
        if (Input.GetKeyDown(KeyCode.Mouse0))
            tractorbeam.SetActive(true);

        else if (Input.GetKeyUp(KeyCode.Mouse0))
            tractorbeam.SetActive(false);

        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            SpawnIt();
        }
        */
    }

    public void SpawnIt()
    {
        tractorbeam.SetActive(true);
        beamofftime = Time.time + beamTimer;
        Instantiate(CrystalSpawn, transform.position, Quaternion.identity);
    }
}

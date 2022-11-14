using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbductionBeam : MonoBehaviour
{
    public GameObject tractorbeam;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
            tractorbeam.SetActive(true);

        else if (Input.GetKeyUp(KeyCode.Mouse0))
            tractorbeam.SetActive(false);
    }
}

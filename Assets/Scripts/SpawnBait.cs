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
      //  if (Input.GetKeyUp(KeyCode.Mouse1))
       //     {
       //     SpawnIt();
      //  }
    }

   public void SpawnIt()
    {
        GameObject tempBait = Instantiate(BaitSpawn, transform.position, Quaternion.identity);

        GameObject[] Cows = GameObject.FindGameObjectsWithTag("Cow");
        if (Cows.Length > 0)
        {
            foreach (GameObject cow in Cows)
            {
                cow.SendMessage("AddGrass", tempBait.transform, SendMessageOptions.DontRequireReceiver);
            }
        }
        GameObject[] YFarmers = GameObject.FindGameObjectsWithTag("YFarmer");
        if (YFarmers.Length > 0)
        {
            foreach (GameObject YFarmer in YFarmers)
            {
                YFarmer.SendMessage("AddGrass", tempBait.transform, SendMessageOptions.DontRequireReceiver);
            }
        }
    }
}
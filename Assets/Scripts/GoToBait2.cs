using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToBait2 : MonoBehaviour
{
    public List<Transform> Grasses;
    public float cowRange;
    public float targetRange;
    private Transform currentTarget;
    void Update()
    {
        foreach(Transform Grass in Grasses)
        {
            if (Grass == null)
            {
                Grasses.Remove(Grass);
            }
            else
            {
                if (Grass.CompareTag("Bait"))
                {
                    if (Vector3.Distance(transform.position, Grass.position) < cowRange)
                    {
                        if (currentTarget == null || Vector3.Distance(transform.position, Grass.position) < Vector3.Distance(transform.position, currentTarget.position))
                        {
                            currentTarget = Grass;
                        }
                    }

                }
            }
        }

        if (currentTarget!=null)
        {
            if ((Vector3.Distance(transform.position, currentTarget.position) > targetRange))
            {
                transform.position = Vector3.MoveTowards(transform.position, currentTarget.position, 0.03f);
            }
        }
        
    }

    public void AddGrass(Transform newGrass)
    {
        Grasses.Add(newGrass);
    }


}

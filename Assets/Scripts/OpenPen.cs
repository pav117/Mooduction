using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPen : MonoBehaviour
{
    public GameObject Entrance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Cow"))
        {
            Entrance.SetActive(false);
        }

    }
}

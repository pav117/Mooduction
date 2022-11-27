using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CowList : MonoBehaviour
{
    GameObject[] cows;
    public Text cowListText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cows = GameObject.FindGameObjectsWithTag("Cow");

        cowListText.text = "Cows :" + cows.Length.ToString();
    }
}

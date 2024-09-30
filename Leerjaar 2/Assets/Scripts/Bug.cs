using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bug : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (Application.isPlaying == false)
        {
            Debug.Log("Cook");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

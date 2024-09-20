using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finishline : MonoBehaviour
{
    [SerializeField] GameObject finishline;
    //[SerializeField] GameObject Player;
    public Run Run;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            Run.transform.position += Vector3.forward * 0 * 0;
            
        }
    }
}

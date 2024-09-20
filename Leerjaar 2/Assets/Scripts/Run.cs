using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Run : MonoBehaviour
{
    [SerializeField] public float Speed = 1f;
    [SerializeField] float maxSpeed = 10f; // Max snelheid
    [SerializeField] float SpeedIncrease = 1f; //versnelling
    [SerializeField] float decelerationRate = 0.5f; // hoe snel de Speed versloomd
    [SerializeField] float minSpeed = 0f; //minimaale snelheid
    public Animator animator;


    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Speed = Mathf.Min(Speed + SpeedIncrease, maxSpeed);
            transform.position += Vector3.forward * Speed * Time.deltaTime;
            animator.SetTrigger("Run");
        }

        if (Speed > minSpeed)
        {
            Speed -= decelerationRate * Time.deltaTime;
            Speed = Mathf.Max(Speed, minSpeed); // snelheid gaat niet onder 0
        }
    }

    void FixedUpdate()
    {
        // Keep moving forward using Rigidbody's velocity until speed reaches 0
        if (Speed > 0)
        {
            // Apply velocity in the forward direction
            rb.velocity = transform.forward * Speed;
        }
        else
        {
            // Stop movement when speed is 0
            rb.velocity = Vector3.zero;
        }
    }
}

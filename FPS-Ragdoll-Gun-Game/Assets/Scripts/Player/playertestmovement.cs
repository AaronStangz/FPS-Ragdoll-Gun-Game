using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class playertestmovement : MonoBehaviour
{
    [Header("Movement")]
    public float walkSpeed;
    public float sprintSpeed;

    public Rigidbody rb;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(Vector3.forward * walkSpeed * 10f, ForceMode.Force);
        }
        if (Input.GetKeyDown(KeyCode.W) && Input.GetKeyDown(KeyCode.LeftShift))
        {
            rb.AddForce(Vector3.forward * sprintSpeed * 10f, ForceMode.Force);
        }
    }
}

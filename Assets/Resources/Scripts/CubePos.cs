using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePos : MonoBehaviour
{
    public GameObject BaseParent;
    private Vector3 BasePos;
    private Vector3 temp;

    private Rigidbody rb;


    void Update()
    {
        BasePos = BaseParent.transform.position;
    }

    public void mF()
    {
        rb = GetComponent<Rigidbody>();

            temp = BasePos;
            temp.y = BasePos.y + 0.1f;
            rb.transform.position = temp; 

       // rb.transform.position = new Vector3(1.0f, 1.0f, 1.0f);
        rb.velocity = new Vector3(0.0f, 0.0f, 0.0f);
        rb.angularVelocity = new Vector3(0.0f, 0.0f, 0.0f);
        rb.transform.rotation = Quaternion.identity;

        //or
        // rb.velocity = Vector3.zero;
        //rb.angularVelocity = Vector3.zero;


    }
}

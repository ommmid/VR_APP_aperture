using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;
using Leap.Unity;
using Leap.Unity.Attributes;

public class HandCollWall : MonoBehaviour
{

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("the collider name is: " + col.collider.name);

        if (col.collider.name == "BrushHand_R" || col.collider.name == "BrushHand_L")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
    }

    void OnCollisionExit(Collision col)
    {
        if (col.collider.name == "BrushHand_R" || col.collider.name == "BrushHand_L")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.white;
        }
    }

    /*void OnTriggerEnter(Collider col)
    {
        if (col.GetComponent<Collider>().name == "BrushHand_R" || col.GetComponent<Collider>().name == "BrushHand_L")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
    }*/
}
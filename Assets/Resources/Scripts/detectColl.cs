using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectColl : MonoBehaviour {
    public GameObject w_1;
    public GameObject w_2;
    public GameObject w_3;
    public GameObject w_4;

    void OnCollisionEnter(Collision col)
    {
        switch (col.collider.name)
        {
            case "wall_1":
            w_1.GetComponent<Renderer>().material.color = Color.red;
                break;
            case "wall_2":
            w_2.GetComponent<Renderer>().material.color = Color.red;
                break;
            case "wall_3":
            w_3.GetComponent<Renderer>().material.color = Color.red;
                break;
            case "wall_4":
            w_4.GetComponent<Renderer>().material.color = Color.red;
                break;
        }

    }
    void OnCollisionExit(Collision col)
    {
        switch (col.collider.name)
        {
            case "wall_1":
                w_1.GetComponent<Renderer>().material.color = Color.white;
                break;
            case "wall_2":
                w_2.GetComponent<Renderer>().material.color = Color.white;
                break;
            case "wall_3":
                w_3.GetComponent<Renderer>().material.color = Color.white;
                break;
            case "wall_4":
                w_4.GetComponent<Renderer>().material.color = Color.white;
                break;
        }
    }
}

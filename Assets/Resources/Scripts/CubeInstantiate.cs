using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeInstantiate : MonoBehaviour {
    public GameObject gob;
  
    

	public void CubeIns()
    {
        //GameObject gob = Instantiate(Resources.Load("Prefabs/IntCube")) as GameObject;
        //GameObject gob = (GameObject)AssetDatabase.LoadAssetAtPath("Assets/LeapMotionModules/InteractionEngine/Examples/Prefabs/InteractionCube.prefab", typeof(GameObject));
        //gob.transform.position = new Vector3(0.0f, 0.2f, 0.4f);

        Instantiate(gob, new Vector3(0.0f, 0.2f, 0.4f), transform.rotation);

    }
}

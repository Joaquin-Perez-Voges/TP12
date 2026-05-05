using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionCubos : MonoBehaviour
{
    CubeScript cubeData;

    // Update is called once per frame
        void OnCollisionEnter(Collision col)
    {
        Debug.Log("hubo colisión");
        cubeData = col.gameObject.GetComponent<CubeScript>();
        Debug.Log("Nombre del otro objeto: " + cubeData.objectName);
        
    }
}

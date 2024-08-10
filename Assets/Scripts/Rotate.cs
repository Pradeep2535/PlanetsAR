using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject PlanetObject;
    public Vector3 Rotation;
    

    private void Update(){

        PlanetObject.transform.Rotate(Rotation*Time.deltaTime);
    }
}

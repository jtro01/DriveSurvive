using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playershoot : MonoBehaviour
{


    public GameObject Gun;
    //public Camera cam;
    public GameObject bullet;
    Vector3 prev = Vector3.zero;

    void Update()
    {
        GameObject bulletObject = Instantiate(bullet);
        bulletObject.transform.position = Gun.transform.position + Gun.transform.forward;
        bulletObject.transform.forward = Gun.transform.forward;
    }
}

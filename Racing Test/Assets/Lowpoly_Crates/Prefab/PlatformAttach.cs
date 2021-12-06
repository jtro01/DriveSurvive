using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformAttach : MonoBehaviour 
{
    //public float motorForce;
    public GameObject Car;
    //public float Stiffness;
    //GameObject FrontLeftWheelC;
    //GameObject FrontRightWheelC;
    //GameObject RearLeftWheelC;
    //GameObject RearRightWheelC;
    //GameObject Wheels;
    //public float Mass;
    public Transform SpawnPoint;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == Car)
        {
            Car.SetActive(false);
            
            Car.transform.parent = transform;
        }
    }

    // Update is called once per frame
    private void OnTriggerExit(Collider other)
    {
        if(Input.GetKey(KeyCode.Space))
        {
           Car.SetActive(true);
         
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Booster : MonoBehaviour


{
    public GameObject Car;
    public float MotorForce;
    public float MaxSteerAngle;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(Input.GetKey(KeyCode.LeftShift))
        {
            MaxSteerAngle = 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

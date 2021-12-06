using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootGun : MonoBehaviour
{
    public float moveForce;
    public GameObject Sphere;
    public Transform gun;
    public float shootRate;
    public float shootForce;
    private float m_shootRateTimeStamp;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (Time.time > m_shootRateTimeStamp)
            {
                GameObject obj = (GameObject)Instantiate(
                Sphere, gun.position, gun.rotation);
                obj.name = "Sphere";

                obj.GetComponent<Rigidbody>().AddForce(gun.forward * shootForce);
                m_shootRateTimeStamp = Time.time + shootRate;
                
            }
        }
    }

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletscript : MonoBehaviour
{
    // Start is called before the first frame update
    
    public float speed = 8f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //make the bullet move
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}

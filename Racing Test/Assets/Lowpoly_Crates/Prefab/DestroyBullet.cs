﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
    //public GameObject box;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {

        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnScript : MonoBehaviour
{
    [SerializeField] private GameObject Car;
    [SerializeField] private Transform SpawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Car.transform.position = SpawnPoint.transform.position;
            Physics.SyncTransforms();
        }
    }
}

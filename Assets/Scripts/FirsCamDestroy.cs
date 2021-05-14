using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirsCamDestroy : MonoBehaviour
{
    public GameObject cam1;
  
    void Start()
    {
        cam1.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            cam1.SetActive(false);
        }
    }
}

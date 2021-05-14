using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trininginfoschanger : MonoBehaviour
{
    public GameObject info1;
    public GameObject info2;
    bool was = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")&&was==false)
        {
            info1.SetActive(false);
            info2.SetActive(true);
            was = true;
        }
    }
}

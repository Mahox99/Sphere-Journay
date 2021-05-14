using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCam : MonoBehaviour
{
    public GameObject cam;
    void Start()
    {
        cam.SetActive(true);
    }
}

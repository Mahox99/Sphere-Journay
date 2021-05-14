using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveControler : MonoBehaviour
{
    public float forceMult = 5;
    public Rigidbody rb;
    public static float ver, hor;
 
    void Update()
    {
        ver = Input.GetAxis("Vertical");
        hor = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * Time.deltaTime * ver * forceMult, Space.World);
        transform.Translate(Vector3.right * Time.deltaTime * hor * forceMult, Space.World);
    }
}

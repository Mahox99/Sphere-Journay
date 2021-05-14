using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeControler : MonoBehaviour
{
    public GameObject TimeDisplay;
    public static int time;

    void Start()
    {
        time = 0;
        InvokeRepeating("AddTime", 1, 1f);
    }

    void AddTime()
    {
        time += 1;
        TimeDisplay.GetComponent<UnityEngine.UI.Text>().text = "Time: " + time;
    }
}

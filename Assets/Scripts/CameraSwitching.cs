using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitching : MonoBehaviour
{
    [SerializeField] public GameObject[] cameras;
    //public GameObject cam2;
    //public GameObject cam3;
    //public GameObject cam4;
    //public GameObject cam5;

    public int a = 0;

    void Start()
    {
        Cleaning_cam();
        //cameras[0].SetActive(true);
    }
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
            Cleaning_cam();
            cameras[a].SetActive(true);

                //switch (a)
                //{
                //    case 1:
                //        {
                //            Cleaning_cam();
                //            cam1.SetActive(true);
                //            break;
                //        }
                //    case 2:
                //        {
                //            Cleaning_cam();
                //            cam2.SetActive(true);
                //            break;
                //        }
                //    case 3:
                //        {
                //            Cleaning_cam();
                //            cam3.SetActive(true);
                //            break;
                //        }
                //    case 4:
                //        {
                //            Cleaning_cam();
                //            cam4.SetActive(true);
                //            break;
                //        }
                //    default:
                //        break;
                }
            }
        

        void Cleaning_cam()
        {
            for(int i = 0; i< cameras.Length ; i++)
            {
            cameras[i].SetActive(false);
            }
        }
    }

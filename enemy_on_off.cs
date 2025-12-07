using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class enemy_on_off : MonoBehaviour
{
    public GameObject[] ON_Off;
    //public GameObject sensor;
    //public GameObject cube2;
    //public GameObject cube3;
    //public GameObject cube4;
    public void Start()
    {
        for (int i = 0; i < ON_Off.Length; i++)
        {
            ON_Off[Random.Range(0 , ON_Off.Length)].SetActive(true);
        }     
    }
    private void Update()
    {
        //if (this.gameObject.transform.childCount == 0)
        //{
        //    sensor.gameObject.GetComponent<BoxCollider>().enabled = true;
        //    cube2.gameObject.GetComponent<BoxCollider>().enabled = true;
        //    cube3.gameObject.GetComponent<BoxCollider>().enabled = true;
        //    cube4.gameObject.GetComponent<BoxCollider>().enabled = false;
        //    FindObjectOfType<level_up>().enabled = true;
        //}
    }
}

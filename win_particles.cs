using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class win_particles : MonoBehaviour
{
    public GameObject[] ON_Off;
    public void Start()
    {
        ON_Off[Random.Range(0, 3)].SetActive(true);
    }
}

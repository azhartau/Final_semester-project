using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Pendulum : MonoBehaviour
{
    public float speed;
    public float limit;
    public bool randomstart = false;
    private float random = 0;
    private void Awake()
    {
        if(randomstart)
        {
            random = Random.Range(0, 1);
        }
    }
    private void Update()
    {
        float angle = limit * Mathf.Sin(Time.time + random * speed);
        transform.localRotation = Quaternion.Euler(angle, 0 , 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.transform.CompareTag("EnemySword") || other.gameObject.transform.CompareTag("Enemy"))
        {
            other.gameObject.GetComponent<Death_Animation>().enabled = true;
        }
    }
}
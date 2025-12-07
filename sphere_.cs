using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class sphere_ : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.transform.CompareTag("EnemySword") )
        {
            other.gameObject.GetComponent<Death_Animation>().enabled = true;
            other.gameObject.GetComponent<khatam>().enabled = true;
        }
        if (other.gameObject.transform.CompareTag("DeathGirl"))
        {
            other.gameObject.GetComponent<death_girl>().enabled = true;
        }
        if (other.gameObject.transform.CompareTag("Player"))
        {
            other.gameObject.transform.GetChild(0).GetComponent<Death_Animation>().enabled = true;
            other.gameObject.GetComponent<PlayerController>().enabled = false;
            Invoke("khatam", 5f);
        }
    }
    public void khatam()
    {
        FindObjectOfType<level_fail>().enabled = true;
    }
}

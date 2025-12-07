using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level_fail : MonoBehaviour
{
    public GameObject fail_panel;
    void Start()
    {
        fail_panel.gameObject.SetActive(true);
        FindObjectOfType<PowerSystem>().enabled = false;
    }
}

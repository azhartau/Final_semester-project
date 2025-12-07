using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;
public class level_up : MonoBehaviour
{
    public GameObject fading;
    public GameObject fading_controller;
    public GameObject door2;
    public float destination1;
    public float duration1;
    public float destination2;
    public float duration2;
    public GameObject cam;
    public void Start()
    {
        
    }
    public void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("LevelUp"))
        {
            cam.gameObject.GetComponent<AudioSource>().enabled = false;          
            FindObjectOfType<win_particles>().enabled = true;
            Invoke("player_controller_off", 1.5f);
            Invoke("wait", 5f);
        }
        else if(other.gameObject.CompareTag("Sensor"))
        {
            door2.transform.DOMoveY(destination1 , duration1).OnComplete(() =>
            {
                door2.transform.DOMoveY(destination2, duration2);
            });
        }
        else
        {
            door2.transform.DOMoveY(destination2, duration2);
        }
    }
    public void wait()
    {
        fading.gameObject.SetActive(true);
        fading_controller.gameObject.SetActive(true);
    }
    public GameObject[] enemies;
    public void player_controller_off()
    {
        FindObjectOfType<PlayerController>().enabled = false;
        for (int i = 0; i < enemies.Length; i++)
        {
            enemies[i].gameObject.SetActive(false);
        }
    }
}

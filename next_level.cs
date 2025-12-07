using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class next_level : MonoBehaviour
{
    public GameObject player_off;
    public GameObject level_complete_pannel;
    void Start()
    {       
        player_off.gameObject.SetActive(false);
        level_complete_pannel.gameObject.SetActive(true);
    }
    public void Next_level()
    {      
        SceneManager.LoadScene("Reload");
        level_complete_pannel.gameObject.SetActive(false);
    }
    public void home_btn()
    {

    }
}
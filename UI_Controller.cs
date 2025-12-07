using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UI_Controller : MonoBehaviour
{
    public static UI_Controller tawakal;
    public GameObject Main_menu;
    public GameObject elevator;
    public Text high_score;
    public Text current_score;
    int score = 1;
    public GameObject show_level_number;
    public GameObject pause_menu;
    public GameObject pause_btn;
    public GameObject power_panel;
    private void Start()
    {
        show_level_number.gameObject.SetActive(false);
        power_panel.gameObject.SetActive(false);
        high_score.text = PlayerPrefs.GetInt("Highscore", 1).ToString();
        if(PlayerPrefs.GetInt("Highscore")>=100)
        {
            PlayerPrefs.SetInt("Highscore", 0);
        }
    }
    public void level_up()
    {
        score++;
        current_score.text = score.ToString();
        PlayerPrefs.SetInt("Highscore", PlayerPrefs.GetInt("Highscore")+1);
    }  
    public void play_btn()
    {
        Main_menu.gameObject.SetActive(false);
        show_level_number.gameObject.SetActive(true);       
        elevator.gameObject.SetActive(true);
        pause_btn.gameObject.SetActive(true);
        power_panel.gameObject.SetActive(true);
    }
    public void failed_panel()
    {
        SceneManager.LoadScene("Reload");
    }
    public void Rate_Us()
    {
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.pagieportal.littlespy");
    }
    public void More_Games()
    {
        Application.OpenURL("");
    }
    public void pause_Btn()
    {
        Time.timeScale = 0;
        pause_menu.gameObject.SetActive(true);
        pause_btn.gameObject.SetActive(false);
    }
    public void resunme_btn()
    {
        Time.timeScale = 1;
        pause_menu.gameObject.SetActive(false);
        pause_btn.gameObject.SetActive(true);
    }
}


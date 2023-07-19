using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour {

    public bool Paused = false;
    public GameObject ThePlayer;
    public GameObject PauseMenu; 

    void Update () {
        if (Input.GetButtonDown("Cancel"))
        {
            if (Paused == false)
            {   Time.timeScale = 0;
                Paused = true;
                PauseMenu.SetActive (true);
                ThePlayer.GetComponent<FirstPersonController>().enabled = false;
                Cursor.visible = true;}
            
            else
            {   ThePlayer.GetComponent<FirstPersonController>().enabled = true;
                Paused = false;
                PauseMenu.SetActive (false);
                Time.timeScale = 1;}}}
    
    public void UnpauseGame()
    {   ThePlayer.GetComponent<FirstPersonController>().enabled = true;
        Paused = false;
        PauseMenu.SetActive (false);
        Time.timeScale = 1;}

    public void QuitGame ()
    {   ThePlayer.GetComponent<FirstPersonController>().enabled = true;
        Paused = false;
        PauseMenu.SetActive (false);
        Time.timeScale = 1;
        SceneManager.LoadScene (4);}}

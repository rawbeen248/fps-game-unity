using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuOptions : MonoBehaviour {

    public void PlayGame () {
            SceneManager.LoadScene (1);
        GlobalHealth.PlayerHealth = 10;
        }

    public void CreditScene () {
            SceneManager.LoadScene (2);
        }
    public void Help ()
    {
        SceneManager.LoadScene (6);

    }}

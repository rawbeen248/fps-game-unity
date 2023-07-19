using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitGame : MonoBehaviour {

    // Use this for initialization
    void Start ()
    {
        SceneManager.LoadScene (4);
        GlobalHealth.PlayerHealth = 10;
    }
}
     

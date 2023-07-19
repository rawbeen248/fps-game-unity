using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashToMenu : MonoBehaviour {

    void Start () {
        StartCoroutine (SplashFinish ());
    }

    IEnumerator SplashFinish () {
        yield return new WaitForSeconds (5.5f);
        SceneManager.LoadScene (4);
        }}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CredToMenu : MonoBehaviour {

    void Start (){
        StartCoroutine (ReturnToMenu ());
    }
    IEnumerator ReturnToMenu(){
        yield return new WaitForSeconds (9);
        SceneManager.LoadScene (4);
    }} 


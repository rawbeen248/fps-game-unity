using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MouseCursor : MonoBehaviour
{
    

    void Start()
    {
        //Set Cursor to not be visible
        Cursor.visible = true;
    }
        
    void Update ()
    {
        if (Input.GetKey (KeyCode.Space))
            Cursor.lockState = CursorLockMode.None;
    }

} 

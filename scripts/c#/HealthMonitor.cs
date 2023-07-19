using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthMonitor : MonoBehaviour {

    public GameObject Health04;
    public GameObject Health03;
    public GameObject Health02;
    public GameObject Health01;
    public GameObject Health00;
    public int CurrentHealth;

    void Update () {
        CurrentHealth = GlobalHealth.PlayerHealth;

        if (CurrentHealth == 8) {
            if (Health04.transform.localScale.y <= 0.0f) {
                Health04.SetActive (false);
            } else {
                Health04.transform.localScale -= new Vector3 (0.0f, 0.05f, 0.0f);
            }

        }

        if (CurrentHealth == 6) {
            if (Health03.transform.localScale.y <= 0.0f) {
                Health03.SetActive (false);
            } else {
                Health03.transform.localScale -= new Vector3 (0.0f, 0.05f, 0.0f);
            }

        }

        if (CurrentHealth == 4) {
            if (Health02.transform.localScale.y <= 0.0f) {
                Health02.SetActive (false);
            } else {
                Health02.transform.localScale -= new Vector3 (0.0f, 0.05f, 0.0f);
            }

        }

        if (CurrentHealth == 2) {
            if (Health01.transform.localScale.y <= 0.0f) {
                Health01.SetActive (false);
            } else {
                Health01.transform.localScale -= new Vector3 (0.0f, 0.05f, 0.0f);
            }

        }

        if (CurrentHealth == 0) {
            if (Health00.transform.localScale.y <= 0.0f) {
                Health00.SetActive (false);
            } else {
                Health00.transform.localScale -= new Vector3 (0.0f, 0.05f, 0.0f);
            }

        }


    }
}

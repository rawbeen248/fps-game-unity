using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public int timeLeft = 25;
    public Text countdownText;

    void Start()
    {
        StartCoroutine("LoseTime");
    }

    void Update()
    {
        countdownText.text = ("Time Left = " + timeLeft);

        if (timeLeft <= 0)
        {
            StopCoroutine("LoseTime");
            SceneManager.LoadScene (3);
        }}

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
        }}} 

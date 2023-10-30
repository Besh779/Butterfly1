using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Bar : MonoBehaviour
{
    public string levelToLoad;
    private float timer = 3f;
    private Text timerSeconds;

    private void Start()
    {
        timerSeconds = GetComponent<Text>();
    }

    void Update()
    {
        timer -= Time.deltaTime;
        //timerSeconds.text = timer.ToString("f2");
        if (timer <= 0)
        {
#pragma warning disable CS0618 // Type or member is obsolete
            Application.LoadLevel(levelToLoad);
#pragma warning restore CS0618 // Type or member is obsolete
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    float currentTime = 0;
    int timeSpeed = 2;

    [SerializeField]
    public TextMeshProUGUI timeText;

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime * timeSpeed;
        DisplayTime();
        //timeText.text = $"{currentTime / 60:00} : {currentTime % 59:00}";
    }

    void DisplayTime()
    {
        float minutes = Mathf.Floor(currentTime / 60);
        float seconds = Mathf.Floor(currentTime % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}

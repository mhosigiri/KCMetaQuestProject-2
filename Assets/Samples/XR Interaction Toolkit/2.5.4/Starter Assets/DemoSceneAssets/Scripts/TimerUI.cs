using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
[RequireComponent(typeof(Timer))]
public class TimerUI : MonoBehaviour
{
    private Text text;
    private Timer timer;
    private float minutes, seconds, milliseconds;
    private void Start()
    {
        text = GetComponent<Text>();
        timer = GetComponent<Timer>();
        timer.OnTimerUpdated.AddListener(updateTimer);
        text.text = "00:00:00";
    }

    void updateTimer()
    {
        minutes = Mathf.FloorToInt(timer.time / 60);
        seconds = Mathf.FloorToInt(timer.time % 60);
        milliseconds = timer.time % 1 * 1000;

        text.text = $"{minutes:00}:{seconds:00}:{milliseconds:00}";
    }
}

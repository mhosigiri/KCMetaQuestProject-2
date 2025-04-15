using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    private bool isTimerRunning = false;
    internal float time { private set; get; } = 0.0f;
    internal UnityEvent OnTimerUpdated = new UnityEvent();
    private Coroutine timerCoroutine;

    public void StartTimer()
    {
        if (isTimerRunning) return;

        isTimerRunning = true;
        time = 0f;
        timerCoroutine = StartCoroutine(updateTimer());
    }

    public void StopTimer()
    {
        if (!isTimerRunning) return;

        isTimerRunning = false;
        StopCoroutine(timerCoroutine);
    }

    private IEnumerator updateTimer()
    {
        while (isTimerRunning)
        {
            time += Time.deltaTime;
            OnTimerUpdated.Invoke();
            yield return new WaitForFixedUpdate();
        }
    }
}

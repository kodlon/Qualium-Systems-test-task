using System.Collections;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private TMP_Text timer;

    private float time;
    private float msec;
    private float sec;
    private float min;


    public void StartTimer()
    {
        timer = this.GetComponent<TMP_Text>();
        StartCoroutine(TimerProcessing());
    }

    public void StopTimer()
    {
        StopAllCoroutines();
    }

    private IEnumerator TimerProcessing()
    {
        for (; ; )
        {
            time += Time.deltaTime;
            msec = (int)((time - (int)time) * 100);
            sec = (int)(time % 60);
            min = (int)(time / 60 % 60);

            timer.text = string.Format("{0:00}:{1:00}:{2:00}", min, sec, msec);
            yield return null;
        }
    }
}

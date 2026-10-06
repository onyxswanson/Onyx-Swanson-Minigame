using TMPro;
using UnityEngine;
using System.Collections;

public class TimerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public TextMeshProUGUI timerText;
    public int timer = 15;

    void Start()
    {
        StartCoroutine(timerActive());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator timerActive()
    {
        for (int i = 0; i < 15; i++)
        {
            yield return new WaitForSeconds(1f);
            timer = timer - 1;
            timerText.text = "TIMER: " + timer;
        }
    }
    
}

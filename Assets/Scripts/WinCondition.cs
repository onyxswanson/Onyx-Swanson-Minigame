using UnityEngine;

public class WinCondition : MonoBehaviour
{
    
    public TimerController timerController;
    private bool test = false;
   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (DestroyTarget.targetUp == 0 && timerController.timer > 0 )
        {
            test = true;
        }
        if (test == true)
        {
            timerController.timerText.text = "YOU WIN!";
        }

        if (DestroyTarget.targetUp > 0 && timerController.timer == 0)
        {

            timerController.timerText.text = "YOU LOSE!";
        }
    }
}

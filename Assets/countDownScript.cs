using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countDownScript : MonoBehaviour
{
    public Text countdownText;
    float timer;
    int countdownTimer = 180;
    public Agent_Input Agent_Input;


    // Start is called before the first frame update
    void Start()
    {
        countdownText.GetComponent<Text>();
        countdownText.text = string.Format("Time Left: " + countdownTimer.ToString(), countdownText.text);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= 1 && countdownTimer > 0 )
        {
            countdownTimer--;
            countdownText.text = "Time Left: " + countdownTimer.ToString();
            timer = 0;

            if( countdownTimer == 0)
            {
                countdownText.text = "You Lost";
                Time.timeScale = 0;
            }
            else if (ZombieMove.enemiesKilled == 14)
            {
                countdownText.text = "You Won";
                Time.timeScale = 0;

            }

        }
    }
}

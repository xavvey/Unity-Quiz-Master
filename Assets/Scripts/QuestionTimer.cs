using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionTimer : MonoBehaviour
{
    [SerializeField] float timeToCompleteQuestion = 10f;
    [SerializeField] float timeToShowCorrectAnswer = 5f;

    public bool loadNextQuestion;
    public float fillFraction;
    public bool isAnsweringQuestion;
    
    float currentTimerValue;

    // Update is called once per frame
    void Update()
    {
        UpdateTimer();
    }

    public void CancelTimer()
    {
        currentTimerValue = 0;
    }

    void UpdateTimer()
    {
        currentTimerValue -= Time.deltaTime;
        
        if (isAnsweringQuestion)
        {
            if (currentTimerValue > 0)
            {
                fillFraction = currentTimerValue / timeToCompleteQuestion;
            }
            else
            {
                isAnsweringQuestion = false;
                currentTimerValue = timeToShowCorrectAnswer;
            }
        }
        else
        {
            if (currentTimerValue > 0)
            {
                fillFraction = currentTimerValue / timeToShowCorrectAnswer;
            }
            else
            {
                isAnsweringQuestion = true;
                currentTimerValue = timeToCompleteQuestion;
                loadNextQuestion = true;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    int numCorrectAnswers = 0;
    int questionsSeen = 0;
    string startingScore = "Score: 0%";


    public int GetCorrectAnswers()
    {
        return numCorrectAnswers;
    }

    public void IncrementCorrectAnswers()
    {
        numCorrectAnswers++;
    }

    public int GetQuestionsSeen()
    {
        return questionsSeen;
    }

    public void IncrementQuestionsSeen()
    {
        questionsSeen++;
    }

    public int CalculateScore()
    {
        return Mathf.RoundToInt(numCorrectAnswers / (float)questionsSeen * 100);
    }

    public string setStartingScore()
    {
        return startingScore;
    }
}

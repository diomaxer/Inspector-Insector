using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public int score;
    public void AddScore()
    {
        score++;
        gameObject.GetComponent<Text>().text = $"Score: {score}";
    }

}

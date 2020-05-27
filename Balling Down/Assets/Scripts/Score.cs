using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public float currentScore;
    public float scoreAddPerSecond;
    // Start is called before the first frame update
    void Start()
    {
        currentScore = .0f;
        scoreAddPerSecond = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = currentScore.ToString("0");
        currentScore += scoreAddPerSecond * Time.deltaTime;
    }
}

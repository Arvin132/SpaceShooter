using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreBoard : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text scoreText;
    private int score = 0;
    private void Start() {
        scoreText = GetComponent<TextMeshProUGUI>();
        scoreText.text = "Score: " + score; 
    }

    public void incrementScore() {
        score++;
        scoreText.text = "Score: " + score;
    }
}

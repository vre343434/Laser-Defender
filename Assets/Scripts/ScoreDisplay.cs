using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    private Text scoreText;
    private GameSession gameSession;


    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
        // gameSession = FindObjectOfType<GameSession>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameSession == null)
        {
            gameSession = FindObjectOfType<GameSession>();
        }

        scoreText.text = gameSession.GetScore().ToString();
    }
}

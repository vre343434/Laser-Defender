using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    private Text scoreText;
    private Player Player;


    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
        Player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = Player.GetHealth().ToString();
    }
}

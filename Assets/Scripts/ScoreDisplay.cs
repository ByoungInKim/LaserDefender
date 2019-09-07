using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    Text ScoreText;
    GameSession gameSession;

    // Start is called before the first frame update
    void Start()
    {
        ScoreText = GetComponent<Text>();
        gameSession = FindObjectOfType<GameSession>();
        
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = gameSession.GetScore().ToString();
    }
}

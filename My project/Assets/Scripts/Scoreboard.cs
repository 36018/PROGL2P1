using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class Scoreboard : MonoBehaviour
{
    private int score = 0;
    private int points = +50;
    private TMP_Text textField;

    // Start is called before the first frame update
    void Start()
    {
        textField = GetComponent<TMP_Text>();
        Pickup.OnPickup += UpdateScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void UpdateScore()
    {
        score += points;
        textField.text = "Score: " + score;
    }
}

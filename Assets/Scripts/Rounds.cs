using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Rounds : MonoBehaviour
{
    [Header("Dynamic")]
    public int round = 1;
    public int score = ScoreCounter score;
    private Text roundText;

    // Start is called before the first frame update
    void Start() {
        roundText = GetComponent<Text>();
        roundText.text = "Round: " + round;
    }

    // Update is called once per frame
    void Update() {
        if (score == 1000){
            
            roundText.text = "Round: " + round++;
        }
    }
}

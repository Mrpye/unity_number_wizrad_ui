using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour {
    [SerializeField] private int max;
    [SerializeField] private int min;
    [SerializeField] TextMeshProUGUI guessText;
    private int guess;

    // Use this for initialization
    private void Start() {
        StartGame();
    }

    private void StartGame() {     
        NextGuess();
    }

    public void OnPressHigher() {
        min = guess+1;
        NextGuess();
    }

    public void OnPressLower() {
        max = guess-1;
        NextGuess();
    }

    private void NextGuess() {
        guess = Random.Range(min,max+1);
        guessText.text = guess.ToString();
    }
}
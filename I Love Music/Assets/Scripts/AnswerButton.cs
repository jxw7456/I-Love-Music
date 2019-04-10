using UnityEngine;

public class AnswerButton : MonoBehaviour
{
    // Attributes
    public TMPro.TMP_Text answerText;

    private AnswerData answerData;

    private GameController gameController;

    // Use this for initialization
    void Start()
    {
        gameController = FindObjectOfType<GameController>();
    }

    // Set up the answer choices according to the proper questions
    public void SetUp(AnswerData data)
    {
        answerData = data;
        answerText.text = answerData.answerText;
    }

    // Check for mouse click
    public void HandleClick()
    {
        gameController.AnswerButtonClicked(answerData.isCorrect);
    }
}
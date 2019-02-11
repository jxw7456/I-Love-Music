using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    // Attributes
    public TMPro.TMP_Text questionText, scoreDisplayText, timeRemainingDisplayText;

    public SimpleObjectPool answerButtonObjectPool;

    public Transform answerButtonParent;

    public GameObject questionDisplay, roundEndDisplay;

    private DataController dataController;

    private RoundData currentRoundData;

    private QuestionData[] questionPool;

    private List<GameObject> answerButtonGameObjects = new List<GameObject>();

    private bool isRoundActive;

    private float timeRemaining;

    private int questionIndex, playerScore, roundScore;

    // Initalized
    void Start()
    {
        dataController = FindObjectOfType<DataController>();
        currentRoundData = dataController.GetCurrentRoundData();
        questionPool = currentRoundData.questions;
        timeRemaining = currentRoundData.timeLimitInSeconds;
        UpdateTimeRemainingDisplay();

        roundScore = PlayerPrefs.GetInt("Score");
        playerScore = roundScore;
        scoreDisplayText.text = "Score: " + playerScore.ToString();
        questionIndex = 0;

        ShowQuestion();
        isRoundActive = true;
    }

    // Grabs the proper Question Pool depending on the artist and displays their questions
    private void ShowQuestion()
    {
        // Remove all answer buttons being used
        RemoveAnswerButtons();
        QuestionData questionData = questionPool[questionIndex];
        questionText.text = questionData.questionText;

        // Add the optional answers to the GameObject and set them up
        for (int i = 0; i < questionData.answers.Length; i++)
        {
            GameObject answerButtonGameObject = answerButtonObjectPool.GetObject();
            answerButtonGameObjects.Add(answerButtonGameObject);
            answerButtonGameObject.transform.SetParent(answerButtonParent);

            AnswerButton answerButton = answerButtonGameObject.GetComponent<AnswerButton>();
            answerButton.SetUp(questionData.answers[i]);
        }
    }

    // Return all answer buttons back to the pool for reuse
    private void RemoveAnswerButtons()
    {
        while (answerButtonGameObjects.Count > 0)
        {
            answerButtonObjectPool.ReturnObject(answerButtonGameObjects[0]);
            answerButtonGameObjects.RemoveAt(0);
        }
    }

    // Check if the button click contains the correct answer
    public void AnswerButtonClicked(bool isCorrect)
    {
        if (isCorrect)
        {
            roundScore += currentRoundData.pointsAddedForCorrectAnswer;
            playerScore = roundScore;
            scoreDisplayText.text = "Score: " + playerScore.ToString();
        }
        else
        {
            // Set the entire player's score back to zero
            playerScore = 0;
            PlayerPrefs.SetInt("Score", 0);
            roundScore = PlayerPrefs.GetInt("Score");
            scoreDisplayText.text = "Score: " + playerScore.ToString();
        }

        // Check if the the player still has more questions
        if (questionPool.Length > questionIndex + 1)
        {
            questionIndex++;
            ShowQuestion();
        }
        else
            EndRound();
    }

    // Sets the round to inactive and takes in the player's round score
    public void EndRound()
    {
        isRoundActive = false;

        questionDisplay.SetActive(false);
        roundEndDisplay.SetActive(true);

        PlayerPrefs.SetInt("Score", roundScore);
    }

    // Returns the player back to the select scene
    public void ReturnToArtists()
    {
        SceneManager.LoadScene("SelectScene");
    }

    // Constantly updates the time remaining for the player
    private void UpdateTimeRemainingDisplay()
    {
        timeRemainingDisplayText.text = "Time: " + Mathf.Round(timeRemaining).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (isRoundActive)
        {
            // Countdown timer
            timeRemaining -= Time.deltaTime;
            UpdateTimeRemainingDisplay();

            // Ends the round once time is up
            if (timeRemaining <= 0f)
                EndRound();
        }
    }
}
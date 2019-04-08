using UnityEngine;
using UnityEngine.SceneManagement;

public class DataController : MonoBehaviour
{
    public RoundData[] allRoundData;

    // Only in the Persistent scene, is not destroyed throughout the game and opens up the Menu Scene
    void Start()
    {
        DontDestroyOnLoad(gameObject);

        SceneManager.LoadScene("MenuScreen");
    }

    // Grabs the right data according to the artist
    public RoundData GetCurrentRoundData()
    {
        if (SceneManager.GetActiveScene().name == "KLQuestions")
            return allRoundData[0];

        else if (SceneManager.GetActiveScene().name == "DrakeQuestions")
            return allRoundData[1];

        else if (SceneManager.GetActiveScene().name == "JColeQuestions")
            return allRoundData[2];

        else if (SceneManager.GetActiveScene().name == "DCQuestions")
            return allRoundData[3];

        else if (SceneManager.GetActiveScene().name == "CBQuestions")
            return allRoundData[4];

        else if (SceneManager.GetActiveScene().name == "PMQuestions")
            return allRoundData[5];

        else if (SceneManager.GetActiveScene().name == "M5Questions")
            return allRoundData[6];

        else if (SceneManager.GetActiveScene().name == "M5Questions")
            return allRoundData[7];

        else if (SceneManager.GetActiveScene().name == "M5Questions")
            return allRoundData[8];

        else if (SceneManager.GetActiveScene().name == "M5Questions")
            return allRoundData[9];

        else if (SceneManager.GetActiveScene().name == "M5Questions")
            return allRoundData[10];

        else if (SceneManager.GetActiveScene().name == "M5Questions")
            return allRoundData[11];

        else if (SceneManager.GetActiveScene().name == "M5Questions")
            return allRoundData[12];

        else if (SceneManager.GetActiveScene().name == "M5Questions")
            return allRoundData[13];

        else if (SceneManager.GetActiveScene().name == "M5Questions")
            return allRoundData[14];

        else if (SceneManager.GetActiveScene().name == "M5Questions")
            return allRoundData[15];

        else
            return null;
    }
}
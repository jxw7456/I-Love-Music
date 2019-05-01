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

        else if (SceneManager.GetActiveScene().name == "EMQuestions")
            return allRoundData[3];

        else if (SceneManager.GetActiveScene().name == "CBQuestions")
            return allRoundData[4];

        else if (SceneManager.GetActiveScene().name == "PMQuestions")
            return allRoundData[5];

        else if (SceneManager.GetActiveScene().name == "M5Questions")
            return allRoundData[6];

        else if (SceneManager.GetActiveScene().name == "SZAQuestions")
            return allRoundData[7];

        else if (SceneManager.GetActiveScene().name == "LogicQuestions")
            return allRoundData[8];

        else if (SceneManager.GetActiveScene().name == "FOQuestions")
            return allRoundData[9];

        else if (SceneManager.GetActiveScene().name == "MJQuestions")
            return allRoundData[10];

        else if (SceneManager.GetActiveScene().name == "TPainQuestions")
            return allRoundData[11];

        else if (SceneManager.GetActiveScene().name == "CGQuestions")
            return allRoundData[12];

        else if (SceneManager.GetActiveScene().name == "NMQuestions")
            return allRoundData[13];

        else if (SceneManager.GetActiveScene().name == "JayZQuestions")
            return allRoundData[14];

        else if (SceneManager.GetActiveScene().name == "KhalidQuestions")
            return allRoundData[15];

        else if (SceneManager.GetActiveScene().name == "FutureQuestions")
            return allRoundData[16];

        else if (SceneManager.GetActiveScene().name == "TSQuestions")
            return allRoundData[17];

        else if (SceneManager.GetActiveScene().name == "XXXQuestions")
            return allRoundData[18];

        else if (SceneManager.GetActiveScene().name == "NHQuestions")
            return allRoundData[19];

        else if (SceneManager.GetActiveScene().name == "MMQuestions")
            return allRoundData[20];

        else
            return null;
    }
}
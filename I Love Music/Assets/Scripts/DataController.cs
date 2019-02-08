using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DataController : MonoBehaviour
{
    public RoundData[] allRoundData;

    // Use this for initialization
    void Start()
    {
        DontDestroyOnLoad(gameObject);

        SceneManager.LoadScene("MenuScreen");
    }

    public RoundData GetCurrentRoundData()
    {
        if (SceneManager.GetActiveScene().name == "KLQuestions")
            return allRoundData[0];

        else if (SceneManager.GetActiveScene().name == "DrakeQuestions")
            return allRoundData[1];

        else
            return allRoundData[0];
    }

    // Update is called once per frame
    void Update()
    {

    }
}

using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectSceneController : MonoBehaviour
{
    public void LoadKendrick()
    {
        SceneManager.LoadScene("KLQuestions");
    }

    public void LoadDrake()
    {
        SceneManager.LoadScene("DrakeQuestions");
    }

    public void LoadCole()
    {
        SceneManager.LoadScene("JColeQuestions");
    }

    public void LoadCaesar()
    {
        SceneManager.LoadScene("DCQuestions");
    }

    public void LoadChris()
    {
        SceneManager.LoadScene("CBQuestions");
    }

    public void LoadPost()
    {
        SceneManager.LoadScene("PMQuestions");
    }
}

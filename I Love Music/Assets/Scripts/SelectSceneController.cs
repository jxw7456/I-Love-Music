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
}

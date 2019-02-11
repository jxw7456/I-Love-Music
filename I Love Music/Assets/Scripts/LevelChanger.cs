using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    // Attributes
    public Animator animator;

    public string levelToLoad;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            FadeToLevel(levelToLoad);
        }
    }

    // Fade to proper level
    public void FadeToLevel(string levelIndex)
    {
        levelToLoad = levelIndex;
        animator.SetTrigger("FadeOut");
    }

    // Check if fade is finish
    public void OnFadeComplete()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
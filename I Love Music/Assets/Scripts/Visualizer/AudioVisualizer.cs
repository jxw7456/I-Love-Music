using UnityEngine;

public class AudioVisualizer : MonoBehaviour
{
    public TMPro.TMP_Dropdown tMP_Dropdown;
    
    public AudioClip audioClip1;
    public AudioClip audioClip2;
    public AudioClip audioClip3;
    public AudioClip audioClip4;
    public AudioClip audioClip5;
    public AudioClip audioClip6;
    
    private AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        audioSource = FindObjectOfType<AudioSource>();
    }

    public void CheckSource()
    {
        if (tMP_Dropdown.value == 0)        
            audioSource.clip = audioClip1;

        else if (tMP_Dropdown.value == 1)
            audioSource.clip = audioClip2;

        else if (tMP_Dropdown.value == 2)
            audioSource.clip = audioClip3;

        if (tMP_Dropdown.value == 3)
            audioSource.clip = audioClip4;

        else if (tMP_Dropdown.value == 4)
            audioSource.clip = audioClip5;

        else if (tMP_Dropdown.value == 5)
            audioSource.clip = audioClip6;
    }
}

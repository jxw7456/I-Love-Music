using UnityEngine;

public class ListManager : MonoBehaviour
{
    private GameObject[] artistList;
    private int index;

    // Use this for initialization
    void Start()
    {
        PlayerPrefs.SetInt("ArtistGroup", 0);

        index = PlayerPrefs.GetInt("ArtistGroup");

        artistList = new GameObject[transform.childCount];

        // Fill Array with ship models
        for (int i = 0; i < transform.childCount; i++)
            artistList[i] = transform.GetChild(i).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject go in artistList)
        {
            if (go == artistList[index])
            {
                continue;
            }
            go.SetActive(false);
            for (int i = 0; i < go.transform.childCount; i++)
            {
                go.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
    }

    // Toggles left through ship options
    public void ToggleLeft()
    {
        // Toggle off the current model
        artistList[index].SetActive(false);

        index--;
        if (index < 0)
            index = artistList.Length - 1;

        PlayerPrefs.SetInt("ArtistGroup", index);

        // Switch to new model
        artistList[index].SetActive(true);
        for (int i = 0; i < artistList[index].transform.childCount; i++)
        {
            artistList[index].transform.GetChild(i).gameObject.SetActive(true);
        }
    }

    // Toggles right through ship options
    public void ToggleRight()
    {
        // Toggle off the current model
        artistList[index].SetActive(false);

        index++;
        if (index == artistList.Length)
            index = 0;

        PlayerPrefs.SetInt("ArtistGroup", index);

        // Switch to new model
        artistList[index].SetActive(true);
        for (int i = 0; i < artistList[index].transform.childCount; i++)
        {
            artistList[index].transform.GetChild(i).gameObject.SetActive(true);
        }
    }
}
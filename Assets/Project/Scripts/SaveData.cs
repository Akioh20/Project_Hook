using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveData : MonoBehaviour
{
    public float ThreeStarTime;
    public float TwoStarTime;
    public float OneStarTime;

    public int SaveStars (float time)
    {
        int stars = 0;
        int lastStars = PlayerPrefs.GetInt("Score_Level_" + SceneManager.GetActiveScene().buildIndex, 0);

        if (time <= ThreeStarTime)
        {
            stars = 3;
        }
        else if (time <= TwoStarTime)
        {
            stars = 2;
        }
        else if (time <= OneStarTime)
        {
            stars = 1;
        }

        PlayerPrefs.SetInt("Score_Level_" + SceneManager.GetActiveScene().buildIndex, Mathf.Max(stars, lastStars));

        Debug.Log(PlayerPrefs.GetInt("Score_Level_" + SceneManager.GetActiveScene().buildIndex, Mathf.Max(stars, lastStars)));

        return stars;
    }

    public int GetLevelStars(int levelBuildIndex)
    {
        return PlayerPrefs.GetInt("Score_Level_" + levelBuildIndex, 0);
    }
}